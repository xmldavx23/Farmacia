Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmCategoria
    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtNombreCategoria.Text = ""
    End Sub

    Dim EXISTE_CATEGORIA As Boolean

    Private Function CATEGORY_ALREADY_EXISTS(categoryName As String) As Boolean
        Dim Cmd_Check As SqlCommand
        Dim drCheck As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            Cmd_Check = New SqlCommand("SELECT COUNT(*) FROM DBO.CATEGORIAS WHERE DESCATEGORIA = '" & categoryName & "'", ConeccionBD.CONECCION)
            Dim categoryCount As Integer = CInt(Cmd_Check.ExecuteScalar())

            If categoryCount > 0 Then
                Return True ' Category already exists
            Else
                Return False ' Category does not exist
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
            Return False ' Error occurred, assume category does not exist
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Function

    Private Function GENERATE_UNIQUE_CATEGORY_ID() As Integer
        Dim VALOR_ID_CATEGORIA As Integer
        Dim VALOR_DR As SqlDataReader
        TextBox1.Text = 0
        CADENA_SQL = "SELECT * FROM DBO.CATEGORIAS ORDER BY IDCATEGORIA"
        Dim COMMAND1 As New SqlCommand(CADENA_SQL, ConeccionBD.CONECCION)

        Try
            ConeccionBD.Abrir_BaseDato()
            VALOR_DR = COMMAND1.ExecuteReader

            If (VALOR_DR.HasRows) Then
                While VALOR_DR.Read()
                    VALOR_ID_CATEGORIA = VALOR_DR("IDCATEGORIA").ToString
                    TextBox1.Text = VALOR_ID_CATEGORIA + 1
                End While
            End If

            If TextBox1.Text = "" Or TextBox1.Text = 0 Then
                TextBox1.Text = 1
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try

        Return CInt(TextBox1.Text)
    End Function

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Me.TxtNombreCategoria.Text = "" Then
            MsgBox("Debe digitar el nombre de la categoría que desea agregar", MsgBoxStyle.Information, "Mensaje del Sistema")
            TxtNombreCategoria.Focus()
            Exit Sub
        End If

        ' Call a function to check if the category with the same name already exists
        If CATEGORY_ALREADY_EXISTS(Me.TxtNombreCategoria.Text) Then
            MsgBox("Esta categoría ya existe en la base de datos", MsgBoxStyle.Information, "Mensaje del sistema")
            TxtNombreCategoria.Focus()
            Exit Sub
        End If

        ' Generate a unique ID for the new category
        Dim newCategoryID As Integer = GENERATE_UNIQUE_CATEGORY_ID()

        ' Insert the new category into the database
        Dim InsertQuery As String = "INSERT INTO DBO.CATEGORIAS (IDCATEGORIA, DESCATEGORIA) VALUES (" & newCategoryID & ", '" & Me.TxtNombreCategoria.Text & "')"
        Dim Cmd_Add As SqlCommand

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            Call ConeccionBD.Abrir_BaseDato()
            Cmd_Add = New SqlCommand(InsertQuery, ConeccionBD.CONECCION)
            Cmd_Add.ExecuteNonQuery()
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try

        ' Close the form or perform any other necessary actions
        Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.TxtNombreCategoria.Text = "" Then
            MsgBox("Debe digitar el nombre de la categoría que desea agregar", MsgBoxStyle.Information, "Mensaje del Sistema")
            TxtNombreCategoria.Focus()
            Exit Sub
        End If

        ' Call a function to check if the category with the same name already exists
        If CATEGORY_ALREADY_EXISTS(Me.TxtNombreCategoria.Text) Then
            MsgBox("Esta categoría ya existe en la base de datos", MsgBoxStyle.Information, "Mensaje del sistema")
            TxtNombreCategoria.Focus()
            Exit Sub
        End If

        ' Generate a unique ID for the new category
        Dim newCategoryID As Integer = GENERATE_UNIQUE_CATEGORY_ID()

        ' Insert the new category into the database
        Dim InsertQuery As String = "INSERT INTO DBO.CATEGORIAS (IDCATEGORIA, DESCATEGORIA) VALUES (" & newCategoryID & ", '" & Me.TxtNombreCategoria.Text & "')"
        Dim Cmd_Add As SqlCommand

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            Call ConeccionBD.Abrir_BaseDato()
            Cmd_Add = New SqlCommand(InsertQuery, ConeccionBD.CONECCION)
            Cmd_Add.ExecuteNonQuery()
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try

        ' Close the form or perform any other necessary actions
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Close the form
        Me.Close()
    End Sub
End Class