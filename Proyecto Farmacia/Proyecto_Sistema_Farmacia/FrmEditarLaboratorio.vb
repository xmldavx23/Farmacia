Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class FrmEditarLaboratorio
    Private Sub UpdateData()
        Dim newDireccion As String = TxtDireccion.Text
        Dim newTelefono As String = TxtTelefono.Text
        Dim newFax As String = TxtFax.Text
        Dim newContacto As String = TxtContacto.Text
        Dim labId As Integer = Integer.Parse(TxtIdLaboratorio.Text) ' Suponiendo que TxtIdProveedor contiene el ID del laboratorio a actualizar

        ' Crear la instrucción SQL UPDATES
        Dim updateSql As String = "UPDATE Laboratorios SET Direccion = @Direccion, Telefono = @Telefono, Fax = @Fax, Contacto = @Contacto WHERE IdLaboratorio = @IdLaboratorio"

        ' Crear un SqlCommand
        Dim Cmd_Update As SqlCommand

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            Call ConeccionBD.Abrir_BaseDato()

            ' Inicializar el SqlCommand
            Cmd_Update = New SqlCommand(updateSql, ConeccionBD.CONECCION)

            ' Agregar parámetros al SqlCommand
            Cmd_Update.Parameters.AddWithValue("@Direccion", newDireccion)
            Cmd_Update.Parameters.AddWithValue("@Telefono", newTelefono)
            Cmd_Update.Parameters.AddWithValue("@Fax", newFax)
            Cmd_Update.Parameters.AddWithValue("@Contacto", newContacto)
            Cmd_Update.Parameters.AddWithValue("@IdLaboratorio", labId)

            ' Ejecutar el comando UPDATE
            Cmd_Update.ExecuteNonQuery()

            ' Indicar que la actualización fue exitosa (puedes utilizar un DialogResult o establecer una bandera)
            Me.DialogResult = DialogResult.OK
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ' Llama a la función UpdateData para actualizar la base de datos
        UpdateData()

        ' Cierra el formulario después de actualizar
        Me.Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        ' Puedes agregar cualquier lógica de cierre que necesites
        Me.Close()
    End Sub

    Private Sub FrmEditarLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtIdLaboratorio.ReadOnly = True
        TxtNombreLaboratorio.ReadOnly = True
    End Sub
End Class