Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Frm_Consulta_Facturas_a
    Private Sub Frm_Consulta_Facturas_a_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Frm_Consulta_Facturas_a_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Assuming V02 is defined and initialized elsewhere
        Me.KeyPreview = True
        Me.Text = "Detalles de la Factura: " & V02
        CARGAR_DATAGRIDVIEW()
        ARMAR_DATAGRIDVIEW()
    End Sub

    Public Sub ARMAR_DATAGRIDVIEW()
        DataGridView1.Columns(0).HeaderText = "ID_DETALLE" '*
        DataGridView1.Columns(1).HeaderText = "ID_FACTURA"
        DataGridView1.Columns(2).HeaderText = "PRODUCTO"
        DataGridView1.Columns(3).HeaderText = "PRECIO UNITARIO"
        DataGridView1.Columns(4).HeaderText = "CANTIDAD"
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = True
        DataGridView1.Columns(0).Width = 0
        DataGridView1.Columns(1).Width = 0
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(4).Width = 80
    End Sub

    Public Sub CARGAR_DATAGRIDVIEW()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet

            ' Assuming V01 is defined and initialized elsewhere
            DA_U = New SqlDataAdapter("SELECT * FROM [VISTA_DETALLEFACTURA] WHERE ID_FACTURA = " & V01 & " ORDER BY ID_DETALLE", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "[VISTA_DETALLEFACTURA]")
            DataGridView1.DataSource = DS_U.Tables("[VISTA_DETALLEFACTURA]")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub
End Class

