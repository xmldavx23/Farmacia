Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmProveedores
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtNombreProveedor.Text = ""
        Me.TxtDireccion.Text = ""
        Me.TxtTelefono.Text = ""
        Me.TxtFax.Text = ""
        Me.TxtWeb.Text = ""
        Me.TxtContacto.Text = ""
    End Sub

    Dim EXISTE_PROVEEDOR As Boolean


    Private Function PROVIDER_ALREADY_EXISTS(providerName As String) As Boolean
        Dim Cmd_Check As SqlCommand
        Dim drCheck As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            Cmd_Check = New SqlCommand("SELECT COUNT(*) FROM DBO.PROVEEDORES WHERE NOMBREPROVEEDOR = '" & providerName & "'", ConeccionBD.CONECCION)
            Dim providerCount As Integer = CInt(Cmd_Check.ExecuteScalar())

            If providerCount > 0 Then
                Return True ' Provider already exists
            Else
                Return False ' Provider does not exist
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
            Return False ' Error occurred, assume provider does not exist
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Function

    Private Function GENERATE_UNIQUE_PROVIDER_ID() As Integer
        Dim VALOR_ID_PROVEEDOR As Integer
        Dim VALOR_DR As SqlDataReader
        TextBox.Text = 0
        CADENA_SQL = "SELECT * FROM DBO.PROVEEDORES ORDER BY IDPROVEEDOR"
        Dim COMMAND1 As New SqlCommand(CADENA_SQL, ConeccionBD.CONECCION)

        Try
            ConeccionBD.Abrir_BaseDato()
            VALOR_DR = COMMAND1.ExecuteReader

            If (VALOR_DR.HasRows) Then
                While VALOR_DR.Read()
                    VALOR_ID_PROVEEDOR = VALOR_DR("IDPROVEEDOR").ToString
                    TextBox.Text = VALOR_ID_PROVEEDOR + 1
                End While
            End If

            If TextBox.Text = "" Or TextBox.Text = 0 Then
                TextBox.Text = 1
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try

        Return CInt(TextBox.Text)
    End Function

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Me.TxtNombreProveedor.Text = "" Or Me.TxtDireccion.Text = "" Or Me.TxtTelefono.Text = "" Or Me.TxtFax.Text = "" Or Me.TxtWeb.Text = "" Or Me.TxtContacto.Text = "" Then
            MsgBox("Debe completar todos los campos para agregar un proveedor", MsgBoxStyle.Information, "Mensaje del Sistema")
            Exit Sub
        End If

        ' Call a function to check if the provider with the same name already exists
        If PROVIDER_ALREADY_EXISTS(Me.TxtNombreProveedor.Text) Then
            MsgBox("Este proveedor ya existe en la base de datos", MsgBoxStyle.Information, "Mensaje del sistema")
            Exit Sub
        End If

        ' Generate a unique ID for the new provider
        Dim newProviderID As Integer = GENERATE_UNIQUE_PROVIDER_ID()

        ' Insert the new provider into the database
        Dim InsertQuery As String = "INSERT INTO DBO.PROVEEDORES (IDPROVEEDOR, NOMBREPROVEEDOR, DIRECCION, TELEFONO, FAX, WEB, CONTACTO) VALUES (" & newProviderID & ", '" & Me.TxtNombreProveedor.Text & "', '" & Me.TxtDireccion.Text & "', '" & Me.TxtTelefono.Text & "', '" & Me.TxtFax.Text & "', '" & Me.TxtWeb.Text & "', '" & Me.TxtContacto.Text & "')"
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
        If Me.TxtNombreProveedor.Text = "" Or Me.TxtDireccion.Text = "" Or Me.TxtTelefono.Text = "" Or Me.TxtFax.Text = "" Or Me.TxtWeb.Text = "" Or Me.TxtContacto.Text = "" Then
            MsgBox("Debe completar todos los campos para agregar un proveedor", MsgBoxStyle.Information, "Mensaje del Sistema")
            Exit Sub
        End If

        ' Call a function to check if the provider with the same name already exists
        If PROVIDER_ALREADY_EXISTS(Me.TxtNombreProveedor.Text) Then
            MsgBox("Este proveedor ya existe en la base de datos", MsgBoxStyle.Information, "Mensaje del sistema")
            Exit Sub
        End If

        ' Generate a unique ID for the new provider
        Dim newProviderID As Integer = GENERATE_UNIQUE_PROVIDER_ID()

        ' Insert the new provider into the database
        Dim InsertQuery As String = "INSERT INTO DBO.PROVEEDORES (IDPROVEEDOR, NOMBREPROVEEDOR, DIRECCION, TELEFONO, FAX, WEB, CONTACTO) VALUES (" & newProviderID & ", '" & Me.TxtNombreProveedor.Text & "', '" & Me.TxtDireccion.Text & "', '" & Me.TxtTelefono.Text & "', '" & Me.TxtFax.Text & "', '" & Me.TxtWeb.Text & "', '" & Me.TxtContacto.Text & "')"
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