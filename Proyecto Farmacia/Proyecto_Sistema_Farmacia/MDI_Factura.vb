Imports System.Windows.Forms
Public Class MDI_Factura

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("Esta seguro que desea salir de la Aplicacion?", "Mensaje del sistema", MessageBoxButtons.YesNo,
    MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button2) =
    Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmCliente.ShowDialog()
    End Sub

    Private Sub AgregarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarCategoriaToolStripMenuItem.Click
        FrmCategoria.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem1.Click
        VisualizarCategorias.ShowDialog()
    End Sub

    Private Sub AgregarProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProveedoresToolStripMenuItem.Click
        FrmProveedores.ShowDialog()
    End Sub

    Private Sub VisualizarProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarProveedoresToolStripMenuItem.Click
        VisualizarProveedores.ShowDialog()
    End Sub

    Private Sub CategoriaTipoVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaTipoVentaToolStripMenuItem.Click
        VisualizarCTV.ShowDialog()
    End Sub

    Private Sub MDI_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarLaboratoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarLaboratoriosToolStripMenuItem.Click
        FrmLaboratorios.ShowDialog()
    End Sub

    Private Sub VisualizarLaboratoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarLaboratoriosToolStripMenuItem.Click
        VisualizarLaboratorios.ShowDialog()
    End Sub

    Private Sub VisualizarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarProductosToolStripMenuItem.Click
        FrmProductos.ShowDialog()
    End Sub

    Private Sub AgregarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductosToolStripMenuItem.Click
        FrmAgregarProductos.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        FrmFactura.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Frm_Consulta_Facturas.ShowDialog()
    End Sub
End Class