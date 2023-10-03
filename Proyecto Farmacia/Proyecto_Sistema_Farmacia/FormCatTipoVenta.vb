Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormCatTipoVenta
    Private Sub FormCatTipoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtCTV.Text = ""
    End Sub

    Dim EXISTE_CTV As Boolean


    Private Function CTV_ALREADY_EXISTS(categoryName As String) As Boolean
        Dim Cmd_Check As SqlCommand
        Dim drCheck As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            Cmd_Check = New SqlCommand("SELECT COUNT(*) FROM DBO.CAT_TIPO_VENTA WHERE DESCRIPCION = '" & categoryName & "'", ConeccionBD.CONECCION)
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

    Private Function GENERATE_UNIQUE_CTV_ID() As Integer
        Dim VALOR_ID_CATEGORIA As Integer
        Dim VALOR_DR As SqlDataReader
        TxtId.Text = 0
        CADENA_SQL = "SELECT * FROM DBO.CAT_TIPO_VENTA ORDER BY DESCRIPCION"
        Dim COMMAND1 As New SqlCommand(CADENA_SQL, ConeccionBD.CONECCION)

        Try
            ConeccionBD.Abrir_BaseDato()
            VALOR_DR = COMMAND1.ExecuteReader

            If (VALOR_DR.HasRows) Then
                While VALOR_DR.Read()
                    VALOR_ID_CATEGORIA = VALOR_DR("ID_TIPO_VENTA").ToString
                    TxtId.Text = VALOR_ID_CATEGORIA + 1
                End While
            End If

            If TxtId.Text = "" Or TxtId.Text = 0 Then
                TxtId.Text = 1
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try

        Return CInt(TxtId.Text)
    End Function


    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Me.TxtCTV.Text = "" Then
            MsgBox("Debe digitar el nombre de la categoría tipo venta que desea agregar", MsgBoxStyle.Information, "Mensaje del Sistema")
            TxtCTV.Focus()
            Exit Sub
        End If

        ' Call a function to check if the category with the same name already exists
        If CTV_ALREADY_EXISTS(Me.TxtCTV.Text) Then
            MsgBox("Esta categoría tipo venta ya existe en la base de datos", MsgBoxStyle.Information, "Mensaje del sistema")
            TxtCTV.Focus()
            Exit Sub
        End If

        ' Generate a unique ID for the new category
        Dim newCategoryID As Integer = GENERATE_UNIQUE_CTV_ID()

        ' Insert the new category into the database
        Dim InsertQuery As String = "INSERT INTO DBO.CAT_TIPO_VENTA (ID_TIPO_VENTA, DESCRIPCION) VALUES (" & newCategoryID & ", '" & Me.TxtCTV.Text & "')"
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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.TxtCTV.Text = "" Then
            MsgBox("Debe digitar el nombre de la categoría tipo venta que desea agregar", MsgBoxStyle.Information, "Mensaje del Sistema")
            TxtCTV.Focus()
            Exit Sub
        End If

        ' Call a function to check if the category with the same name already exists
        If CTV_ALREADY_EXISTS(Me.TxtCTV.Text) Then
            MsgBox("Esta categoría tipo venta ya existe en la base de datos", MsgBoxStyle.Information, "Mensaje del sistema")
            TxtCTV.Focus()
            Exit Sub
        End If

        ' Generate a unique ID for the new category
        Dim newCategoryID As Integer = GENERATE_UNIQUE_CTV_ID()

        ' Insert the new category into the database
        Dim InsertQuery As String = "INSERT INTO DBO.CAT_TIPO_VENTA (ID_TIPO_VENTA, DESCRIPCION) VALUES (" & newCategoryID & ", '" & Me.TxtCTV.Text & "')"
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
