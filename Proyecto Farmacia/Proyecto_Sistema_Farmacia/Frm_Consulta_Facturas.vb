Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing.Printing

Public Class Frm_Consulta_Facturas
    Dim I As Integer
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader
    Dim printDocument As New PrintDocument()
    Dim printPreviewDialog1 As New PrintPreviewDialog()
    Private Sub Frm_Consulta_Facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR_DATAGRIDVIEW()
        ARMAR_DATAGRIDVIEW()
    End Sub

    Public Sub ARMAR_DATAGRIDVIEW()
        DataGridView1.Columns(0).HeaderText = "ID_FACTURA" '*
        DataGridView1.Columns(1).HeaderText = "NO."
        DataGridView1.Columns(2).HeaderText = "FECHA"
        DataGridView1.Columns(3).HeaderText = "HORA"
        DataGridView1.Columns(4).HeaderText = "ID_TIPO_VENTA" '*
        DataGridView1.Columns(5).HeaderText = "TIPO VENTA"
        DataGridView1.Columns(6).HeaderText = "ID_CLIENTE" '*
        DataGridView1.Columns(7).HeaderText = "NOMBRES Y APELLIDOS"
        DataGridView1.Columns(8).HeaderText = "CEDULA"
        DataGridView1.Columns(9).HeaderText = "TELEFONO"
        DataGridView1.Columns(10).HeaderText = "ID EMPLEADO" '*
        DataGridView1.Columns(11).HeaderText = "SUB TOTAL"
        DataGridView1.Columns(12).HeaderText = "IVA"
        DataGridView1.Columns(13).HeaderText = "TOTAL"
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = True
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = True
        DataGridView1.Columns(8).Visible = True
        DataGridView1.Columns(9).Visible = True
        DataGridView1.Columns(10).Visible = False
        DataGridView1.Columns(11).Visible = True
        DataGridView1.Columns(12).Visible = True
        DataGridView1.Columns(13).Visible = True
        DataGridView1.Columns(0).Width = 0
        DataGridView1.Columns(1).Width = 50
        DataGridView1.Columns(2).Width = 70
        DataGridView1.Columns(3).Width = 60
        DataGridView1.Columns(4).Width = 0
        DataGridView1.Columns(5).Width = 70
        DataGridView1.Columns(6).Width = 0
        DataGridView1.Columns(7).Width = 180
        DataGridView1.Columns(8).Width = 110
        DataGridView1.Columns(9).Width = 80
        DataGridView1.Columns(10).Width = 0
        DataGridView1.Columns(11).Width = 50
        DataGridView1.Columns(12).Width = 50
        DataGridView1.Columns(13).Width = 50
    End Sub

    Public Sub CARGAR_DATAGRIDVIEW()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select * from [VISTA_FACTURAS] ORDER BY ID_FACTURA", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "[VISTA_FACTURAS]")
            DataGridView1.DataSource = DS_U.Tables("[VISTA_FACTURAS]")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        For I = 0 To Me.DataGridView1.RowCount - 1
            If Me.DataGridView1.Rows(I).Selected = True Then
                V01 = Me.DataGridView1.Rows(I).Cells(0).Value
                V02 = Me.DataGridView1.Rows(I).Cells(1).Value
                V03 = Me.DataGridView1.Rows(I).Cells(2).Value
                V04 = Me.DataGridView1.Rows(I).Cells(3).Value
                V05 = Me.DataGridView1.Rows(I).Cells(4).Value
                V06 = Me.DataGridView1.Rows(I).Cells(5).Value
                V07 = Me.DataGridView1.Rows(I).Cells(6).Value
                V08 = Me.DataGridView1.Rows(I).Cells(7).Value
                V09 = Me.DataGridView1.Rows(I).Cells(8).Value
                V10 = Me.DataGridView1.Rows(I).Cells(9).Value
                V11 = Me.DataGridView1.Rows(I).Cells(10).Value
                V12 = Me.DataGridView1.Rows(I).Cells(11).Value
                V13 = Me.DataGridView1.Rows(I).Cells(12).Value
                V14 = Me.DataGridView1.Rows(I).Cells(13).Value
                Exit Sub
            End If
        Next I
    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If V01 <> 0 Then
            Frm_Consulta_Facturas_a.ShowDialog()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Call CARGAR()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub CARGAR()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select * from [VISTA_FACTURAS] WHERE NOMBRES_APELLIDOS like '%" & UCase(TxtNombreCliente.Text) & "%' ORDER BY NOMBRES_APELLIDOS", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "VISTA_FACTURAS")
            DataGridView1.DataSource = DS_U.Tables("VISTA_FACTURAS")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtNombreCliente.Text = ""
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call CARGAR()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TxtNombreCliente.Text = ""
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Legal", 850, 1400)

        Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
        Dim regularFont As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)
        Dim yPos As Single = 50
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim headerLine As Boolean = True
        Dim columnNames() As String = {"ID Factura", "No. Factura", "Fecha Factura",
        "Hora Factura", "ID Tipo Venta", "ID Cliente", "ID Empleado", "Subtotal", "IVA", "Total"}
        Dim columnSpacing As Single = 130

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DS_U As New DataSet
            command = New SqlCommand("SELECT * FROM Facturas",
            ConeccionBD.CONECCION)
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
        AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Legal", 850, 1400)
        printPreviewDialog1.Document = PrintDocument1
        printPreviewDialog1.ShowDialog()
    End Sub
End Class
