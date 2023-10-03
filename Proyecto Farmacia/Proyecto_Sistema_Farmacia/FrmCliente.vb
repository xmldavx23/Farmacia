Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class FrmCliente

    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader
    Dim printDocument As New PrintDocument()
    Dim printPreviewDialog As New PrintPreviewDialog()
    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
        Call BOTONES()
    End Sub
    Private Sub FrmClientes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        For I = 0 To Me.DataGridView1.RowCount - 1
            If Me.DataGridView1.Rows(I).Selected = True Then
                P01 = Me.DataGridView1.Rows(I).Cells(0).Value
                P02 = Me.DataGridView1.Rows(I).Cells(1).Value
                P03 = Me.DataGridView1.Rows(I).Cells(2).Value
                P04 = Me.DataGridView1.Rows(I).Cells(3).Value
                Exit Sub
            End If
        Next I
    End Sub

    Public Sub ARMAR_DATAGRIDVIEW()
        DataGridView1.Columns(0).HeaderText = "IDCLIENTE"
        DataGridView1.Columns(1).HeaderText = "NOMBRES Y APELLIDOS"
        DataGridView1.Columns(2).HeaderText = "CEDULA"
        DataGridView1.Columns(3).HeaderText = "TELEFONO"
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(1).Width = 230
        DataGridView1.Columns(2).Width = 120
        DataGridView1.Columns(3).Width = 80
    End Sub

    Public Sub CARGAR_DATAGRIDVIEW()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select * from CLIENTES ORDER BY NOMBRES_APELLIDOS", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "CLIENTES")
            DataGridView1.DataSource = DS_U.Tables("CLIENTES")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " &
            ControlChars.CrLf &
            oExcep.Message & ControlChars.CrLf &
            oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Public Sub BOTONES()
        Dim dt_B As DataTable
        Dim DA_P As SqlDataAdapter
        Dim DS_P As New DataSet
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            DA_P = New SqlDataAdapter("select * from CLIENTES ORDER BY NOMBRES_APELLIDOS", ConeccionBD.CONECCION)
            DA_P.Fill(DS_P, "CLIENTES")
            Dim cb As New SqlCommandBuilder(DA_P)
            dt_B = New DataTable
            DA_P.Fill(dt_B)
            If dt_B.Rows.Count > 0 Then
                BtnNuevo.Enabled = True
                BtnEditar.Enabled = True
                BtnEliminar.Enabled = True
                TextBox1.Enabled = True
                BtnBuscar.Enabled = True
                BtnCancelar.Enabled = True
            Else
                BtnNuevo.Enabled = True
                BtnEditar.Enabled = False
                BtnEliminar.Enabled = False
                TextBox1.Enabled = False
                BtnBuscar.Enabled = False
                BtnCancelar.Enabled = False
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " &
            ControlChars.CrLf &
            oExcep.Message & ControlChars.CrLf &
            oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub CARGAR()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select * from CLIENTES WHERE NOMBRES_APELLIDOS like '%" & TextBox1.Text & "%' ORDER BY NOMBRES_APELLIDOS", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "CLIENTES")
            DataGridView1.DataSource = DS_U.Tables("CLIENTES")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " &
            ControlChars.CrLf &
            oExcep.Message & ControlChars.CrLf &
            oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Obtener el cliente seleccionado
        Dim selectedRowIndex As Integer = e.RowIndex
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
            ' Obtener los datos del cliente desde las celdas del DataGridView
            Dim idCliente As Integer = CInt(DataGridView1.Rows(selectedRowIndex).Cells("IDCLIENTE").Value.ToString())
            Dim nombreCliente As String = DataGridView1.Rows(selectedRowIndex).Cells("NOMBRES_APELLIDOS").Value.ToString()

            ' Llenar los campos en el formulario principal con los datos del cliente seleccionado
            FrmFactura.TxtIdCliente.Text = idCliente
            FrmFactura.TxtNombreCliente.Text = UCase(nombreCliente)

            ' Cerrar el formulario de clientes
            Me.Close()
        End If

    End Sub



    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        FrmAgregarClientes.ShowDialog()
        If CANCELAR_A_E = True Then
            Call CARGAR_DATAGRIDVIEW()
            Call ARMAR_DATAGRIDVIEW()
            Call BOTONES()
        End If
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar el registro que desea Eliminar",
                   MsgBoxStyle.Information, "Mensaje del Sistema")
            DataGridView1.Focus()
            P01 = "" : P02 = ""
            Exit Sub
        End If

        ' Ask for confirmation before deletion
        Dim R As DialogResult
        R = MessageBox.Show("Se dispone a Eliminar este registro de Cliente, ¿Desea continuar?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If R = DialogResult.Yes Then
            ' Get the ID_PRODUCTO (assuming it's in the first column) of the selected row
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim P01 As String = DataGridView1.Rows(selectedRowIndex).Cells(0).Value.ToString()

            ' Build and execute the SQL DELETE statement
            Dim ELIMINA_SQL As String = "DELETE FROM DBO.CLIENTES WHERE IDCLIENTE = '" & P01 & "'"

            Try
                ConeccionBD.Abrir_BaseDato()
                Dim ELIMINA_CMD As New SqlCommand(ELIMINA_SQL, ConeccionBD.CONECCION)
                ELIMINA_CMD.ExecuteNonQuery()
                TextBox1.Text = ""
                CARGAR_DATAGRIDVIEW()
                ARMAR_DATAGRIDVIEW()
                BOTONES()
                P01 = "" : P02 = ""
            Catch oExcep As SqlException
                If oExcep.ErrorCode = "-2146232060" Then
                    MsgBox("El registro no puede ser Eliminado, se encuentra actualmente en uso",
                           MsgBoxStyle.Information, "Mensaje del Sistema")
                Else
                    MessageBox.Show("Error: " & ControlChars.CrLf &
                                    oExcep.Message & ControlChars.CrLf &
                                    oExcep.Server)
                End If
            Finally
                If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                    ConeccionBD.Cerrar_BaseDato()
                End If
            End Try
        Else
            P01 = "" : P02 = ""
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Call CARGAR()
        Call ARMAR_DATAGRIDVIEW()
        Call BOTONES()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TextBox1.Text = ""
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
        Call BOTONES()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmAgregarClientes.ShowDialog()
        If CANCELAR_A_E = True Then
            Call CARGAR_DATAGRIDVIEW()
            Call ARMAR_DATAGRIDVIEW()
            Call BOTONES()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Create an instance of FrmEditarCliente
            Dim editarForm As New FrmEditarClientes()

            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Populate the text boxes on FrmEditarCliente with data from the selected row
            editarForm.TxtIdCliente.Text = selectedRow.Cells("IDCLIENTE").Value.ToString()
            editarForm.TxtNombreApellidos.Text = selectedRow.Cells("NOMBRES_APELLIDOS").Value

            ' Show FrmEditarCliente
            editarForm.ShowDialog()

            ' Check if any changes were made in FrmEditarCliente and handle them if necessary
            If CANCELAR_A_E = True Then
                Call CARGAR_DATAGRIDVIEW()
                Call ARMAR_DATAGRIDVIEW()
                Call BOTONES()
            End If
        Else
            MsgBox("Debe seleccionar el registro que desea Editar", MsgBoxStyle.Information, "Mensaje del Sistema")
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call CARGAR()
        Call ARMAR_DATAGRIDVIEW()
        Call BOTONES()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TextBox1.Text = ""
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
        Call BOTONES()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar el registro que desea Eliminar",
                   MsgBoxStyle.Information, "Mensaje del Sistema")
            DataGridView1.Focus()
            P01 = "" : P02 = ""
            Exit Sub
        End If

        ' Ask for confirmation before deletion
        Dim R As DialogResult
        R = MessageBox.Show("Se dispone a Eliminar este registro de Cliente, ¿Desea continuar?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If R = DialogResult.Yes Then
            ' Get the ID_PRODUCTO (assuming it's in the first column) of the selected row
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim P01 As String = DataGridView1.Rows(selectedRowIndex).Cells(0).Value.ToString()

            ' Build and execute the SQL DELETE statement
            Dim ELIMINA_SQL As String = "DELETE FROM DBO.CLIENTES WHERE IDCLIENTE = '" & P01 & "'"

            Try
                ConeccionBD.Abrir_BaseDato()
                Dim ELIMINA_CMD As New SqlCommand(ELIMINA_SQL, ConeccionBD.CONECCION)
                ELIMINA_CMD.ExecuteNonQuery()
                TextBox1.Text = ""
                CARGAR_DATAGRIDVIEW()
                ARMAR_DATAGRIDVIEW()
                BOTONES()
                P01 = "" : P02 = ""
            Catch oExcep As SqlException
                If oExcep.ErrorCode = "-2146232060" Then
                    MsgBox("El registro no puede ser Eliminado, se encuentra actualmente en uso",
                           MsgBoxStyle.Information, "Mensaje del Sistema")
                Else
                    MessageBox.Show("Error: " & ControlChars.CrLf &
                                    oExcep.Message & ControlChars.CrLf &
                                    oExcep.Server)
                End If
            Finally
                If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                    ConeccionBD.Cerrar_BaseDato()
                End If
            End Try
        Else
            P01 = "" : P02 = ""
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
        Dim regularFont As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)
        Dim yPos As Single = 50
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim headerLine As Boolean = True
        Dim columnNames() As String = {"ID de Cliente", "Nombre Completo", "No. Cedula", "No. Telefono"}

        Dim columnSpacing As Single = 175

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DS_U As New DataSet
            command = New SqlCommand("SELECT * FROM CLIENTES", ConeccionBD.CONECCION)
            reader = command.ExecuteReader()

            For i As Integer = 0 To columnNames.Length - 1
                e.Graphics.DrawString(columnNames(i), headerFont, brush, leftMargin + (i * columnSpacing), yPos)
            Next

            yPos += 30

            While reader.Read()
                For i As Integer = 0 To reader.FieldCount - 1
                    e.Graphics.DrawString(reader(i).ToString(), regularFont, brush, leftMargin + (i * columnSpacing), yPos)
                Next
                yPos += 20
            End While

            reader.Close()
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        AddHandler printDocument.PrintPage, AddressOf PrintDocument1_PrintPage
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Create an instance of FrmEditarCliente
            Dim editarForm As New FrmEditarClientes()

            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Populate the text boxes on FrmEditarCliente with data from the selected row
            editarForm.TxtIdCliente.Text = selectedRow.Cells("IDCLIENTE").Value.ToString()
            editarForm.TxtNombreApellidos.Text = selectedRow.Cells("NOMBRES_APELLIDOS").Value

            ' Show FrmEditarCliente
            editarForm.ShowDialog()

            ' Check if any changes were made in FrmEditarCliente and handle them if necessary
            If CANCELAR_A_E = True Then
                Call CARGAR_DATAGRIDVIEW()
                Call ARMAR_DATAGRIDVIEW()
                Call BOTONES()
            End If
        Else
            MsgBox("Debe seleccionar el registro que desea Editar", MsgBoxStyle.Information, "Mensaje del Sistema")
        End If
    End Sub


End Class