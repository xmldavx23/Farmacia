Imports System.Data.SqlClient

Public Class EditarCTV
    Private Sub UpdateData()
        Dim newCategoria As String = TxtCTV.Text.ToUpper()
        Dim categoriaId As Integer = Integer.Parse(TxtId.Text)

        ' Create the SQL UPDATE statement
        Dim updateSql As String = "UPDATE CAT_TIPO_VENTA SET DESCRIPCION = @Nombre WHERE ID_TIPO_VENTA = @ID"

        ' Create a SqlCommand
        Dim Cmd_Update As SqlCommand

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            Call ConeccionBD.Abrir_BaseDato()

            ' Initialize the SqlCommand
            Cmd_Update = New SqlCommand(updateSql, ConeccionBD.CONECCION)

            ' Add parameters to the SqlCommand
            Cmd_Update.Parameters.AddWithValue("@Nombre", newCategoria)
            Cmd_Update.Parameters.AddWithValue("@ID", categoriaId)

            ' Execute the UPDATE command
            Cmd_Update.ExecuteNonQuery()

            ' Indicate that the update was successful (you can use a DialogResult or set a flag)
            Me.DialogResult = DialogResult.OK
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub BtnAceptar_Click_1(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ' Call the UpdateData function to update the database
        UpdateData()

        ' Close the form after updating
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        CANCELAR_A_E = False
        Me.Close()
    End Sub

    Private Sub EditarCTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtId.ReadOnly = True
    End Sub
End Class