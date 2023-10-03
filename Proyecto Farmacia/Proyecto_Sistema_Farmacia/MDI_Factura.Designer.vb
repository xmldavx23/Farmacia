<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_Factura
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MDI_Factura))
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        FacturasToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        ToolStripMenuItem7 = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        VisualizarProductosToolStripMenuItem = New ToolStripMenuItem()
        AgregarProductosToolStripMenuItem = New ToolStripMenuItem()
        CategoriasToolStripMenuItem = New ToolStripMenuItem()
        AgregarCategoriaToolStripMenuItem = New ToolStripMenuItem()
        CategoriasToolStripMenuItem1 = New ToolStripMenuItem()
        CategoriaTipoVentaToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        AgregarProveedoresToolStripMenuItem = New ToolStripMenuItem()
        VisualizarProveedoresToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        BToolStripMenuItem = New ToolStripDropDownMenu()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        AgregarLaboratoriosToolStripMenuItem = New ToolStripMenuItem()
        VisualizarLaboratoriosToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem8 = New ToolStripMenuItem()
        ToolStripMenuItem9 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(72, 21)
        ToolStripMenuItem1.Text = "Archivo"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(82, 21)
        ToolStripMenuItem2.Text = "Consultas"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(82, 21)
        ToolStripMenuItem3.Text = "Windows"
        ' 
        ' FacturasToolStripMenuItem
        ' 
        FacturasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem6, ToolStripMenuItem7})
        FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        FacturasToolStripMenuItem.Size = New Size(75, 21)
        FacturasToolStripMenuItem.Text = "Facturas"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(200, 26)
        ToolStripMenuItem6.Text = "Crear Factura"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(200, 26)
        ToolStripMenuItem7.Text = "Consultar Factura"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VisualizarProductosToolStripMenuItem, AgregarProductosToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(87, 21)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' VisualizarProductosToolStripMenuItem
        ' 
        VisualizarProductosToolStripMenuItem.Name = "VisualizarProductosToolStripMenuItem"
        VisualizarProductosToolStripMenuItem.Size = New Size(224, 26)
        VisualizarProductosToolStripMenuItem.Text = "Visualizar Productos"
        ' 
        ' AgregarProductosToolStripMenuItem
        ' 
        AgregarProductosToolStripMenuItem.Name = "AgregarProductosToolStripMenuItem"
        AgregarProductosToolStripMenuItem.Size = New Size(224, 26)
        AgregarProductosToolStripMenuItem.Text = "Agregar Productos"
        ' 
        ' CategoriasToolStripMenuItem
        ' 
        CategoriasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarCategoriaToolStripMenuItem, CategoriasToolStripMenuItem1, CategoriaTipoVentaToolStripMenuItem})
        CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        CategoriasToolStripMenuItem.Size = New Size(87, 21)
        CategoriasToolStripMenuItem.Text = "Categorias"
        ' 
        ' AgregarCategoriaToolStripMenuItem
        ' 
        AgregarCategoriaToolStripMenuItem.Name = "AgregarCategoriaToolStripMenuItem"
        AgregarCategoriaToolStripMenuItem.Size = New Size(219, 26)
        AgregarCategoriaToolStripMenuItem.Text = "Agregar Categoria"
        ' 
        ' CategoriasToolStripMenuItem1
        ' 
        CategoriasToolStripMenuItem1.Name = "CategoriasToolStripMenuItem1"
        CategoriasToolStripMenuItem1.Size = New Size(219, 26)
        CategoriasToolStripMenuItem1.Text = "Categorias"
        ' 
        ' CategoriaTipoVentaToolStripMenuItem
        ' 
        CategoriaTipoVentaToolStripMenuItem.Name = "CategoriaTipoVentaToolStripMenuItem"
        CategoriaTipoVentaToolStripMenuItem.Size = New Size(219, 26)
        CategoriaTipoVentaToolStripMenuItem.Text = "Categoria Tipo Venta"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarProveedoresToolStripMenuItem, VisualizarProveedoresToolStripMenuItem})
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(102, 21)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' AgregarProveedoresToolStripMenuItem
        ' 
        AgregarProveedoresToolStripMenuItem.Name = "AgregarProveedoresToolStripMenuItem"
        AgregarProveedoresToolStripMenuItem.Size = New Size(235, 26)
        AgregarProveedoresToolStripMenuItem.Text = "Agregar Proveedores"
        ' 
        ' VisualizarProveedoresToolStripMenuItem
        ' 
        VisualizarProveedoresToolStripMenuItem.Name = "VisualizarProveedoresToolStripMenuItem"
        VisualizarProveedoresToolStripMenuItem.Size = New Size(235, 26)
        VisualizarProveedoresToolStripMenuItem.Text = "Visualizar Proveedores"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(71, 21)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(50, 21)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' BToolStripMenuItem
        ' 
        BToolStripMenuItem.AllowDrop = True
        BToolStripMenuItem.AutoClose = False
        BToolStripMenuItem.ImageScalingSize = New Size(20, 20)
        BToolStripMenuItem.Name = "BToolStripMenuItem"
        BToolStripMenuItem.OwnerItem = SalirToolStripMenuItem
        BToolStripMenuItem.Size = New Size(61, 4)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Silver
        MenuStrip1.Font = New Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2, ToolStripMenuItem3, FacturasToolStripMenuItem, ProductosToolStripMenuItem, CategoriasToolStripMenuItem, ProveedoresToolStripMenuItem, ClientesToolStripMenuItem, ToolStripMenuItem4, SalirToolStripMenuItem, ToolStripMenuItem8, ToolStripMenuItem9})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(836, 25)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.DropDownItems.AddRange(New ToolStripItem() {AgregarLaboratoriosToolStripMenuItem, VisualizarLaboratoriosToolStripMenuItem})
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(103, 21)
        ToolStripMenuItem4.Text = "Laboratorios"
        ' 
        ' AgregarLaboratoriosToolStripMenuItem
        ' 
        AgregarLaboratoriosToolStripMenuItem.Name = "AgregarLaboratoriosToolStripMenuItem"
        AgregarLaboratoriosToolStripMenuItem.Size = New Size(236, 26)
        AgregarLaboratoriosToolStripMenuItem.Text = "Agregar Laboratorios"
        ' 
        ' VisualizarLaboratoriosToolStripMenuItem
        ' 
        VisualizarLaboratoriosToolStripMenuItem.Name = "VisualizarLaboratoriosToolStripMenuItem"
        VisualizarLaboratoriosToolStripMenuItem.Size = New Size(236, 26)
        VisualizarLaboratoriosToolStripMenuItem.Text = "Visualizar Laboratorios"
        ' 
        ' ToolStripMenuItem8
        ' 
        ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        ToolStripMenuItem8.Size = New Size(14, 21)
        ' 
        ' ToolStripMenuItem9
        ' 
        ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        ToolStripMenuItem9.Size = New Size(14, 21)
        ' 
        ' MDI_Factura
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(836, 434)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MDI_Factura"
        Text = "MDI_Factura"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents OtroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CategoriaTipoVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BToolStripMenuItem As ToolStripDropDownMenu
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents AgregarLaboratoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarLaboratoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
End Class
