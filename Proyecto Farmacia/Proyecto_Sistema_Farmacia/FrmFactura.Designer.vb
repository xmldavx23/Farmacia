<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactura
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
        GroupBox1 = New GroupBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        BtnBuscarCliente = New Button()
        TxtNombreVendedor = New TextBox()
        LblNombreVendedor = New Label()
        TxtNombreCliente = New TextBox()
        TxtIdCliente = New TextBox()
        LblNombreCliente = New Label()
        CmbTipoVenta = New ComboBox()
        LblTipoVenta = New Label()
        TxtHora = New TextBox()
        LblHora = New Label()
        TxtFecha = New TextBox()
        LblFecha = New Label()
        BtnSalir = New Button()
        BtnGuardar = New Button()
        BtnCancelar = New Button()
        LblFacturaNo = New Label()
        TxtFacturaNo = New TextBox()
        LblFactura = New Label()
        BtnNuevo = New Button()
        GroupBox2 = New GroupBox()
        DataGridView = New DataGridView()
        LblProductos = New Label()
        BtnAgregar = New Button()
        BtnEliminar = New Button()
        LblPrecio = New Label()
        LblIva = New Label()
        LblTotal = New Label()
        LblMontoPrecio = New Label()
        LblMontoIva = New Label()
        LblMontoTotal = New Label()
        TxtNumFactura = New TextBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox4)
        GroupBox1.Controls.Add(PictureBox3)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(BtnBuscarCliente)
        GroupBox1.Controls.Add(TxtNombreVendedor)
        GroupBox1.Controls.Add(LblNombreVendedor)
        GroupBox1.Controls.Add(TxtNombreCliente)
        GroupBox1.Controls.Add(TxtIdCliente)
        GroupBox1.Controls.Add(LblNombreCliente)
        GroupBox1.Controls.Add(CmbTipoVenta)
        GroupBox1.Controls.Add(LblTipoVenta)
        GroupBox1.Controls.Add(TxtHora)
        GroupBox1.Controls.Add(LblHora)
        GroupBox1.Controls.Add(TxtFecha)
        GroupBox1.Controls.Add(LblFecha)
        GroupBox1.Controls.Add(BtnSalir)
        GroupBox1.Controls.Add(BtnGuardar)
        GroupBox1.Controls.Add(BtnCancelar)
        GroupBox1.Controls.Add(LblFacturaNo)
        GroupBox1.Controls.Add(TxtFacturaNo)
        GroupBox1.Controls.Add(LblFactura)
        GroupBox1.Controls.Add(BtnNuevo)
        GroupBox1.FlatStyle = FlatStyle.System
        GroupBox1.Location = New Point(24, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(747, 278)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.cerrar_sesion
        PictureBox4.Location = New Point(567, 92)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(42, 33)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.disquete
        PictureBox3.Location = New Point(392, 92)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(45, 33)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.boton_eliminar
        PictureBox2.Location = New Point(201, 92)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(43, 33)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.boton_agregar
        PictureBox1.Location = New Point(6, 92)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' BtnBuscarCliente
        ' 
        BtnBuscarCliente.Location = New Point(331, 244)
        BtnBuscarCliente.Name = "BtnBuscarCliente"
        BtnBuscarCliente.Size = New Size(94, 29)
        BtnBuscarCliente.TabIndex = 18
        BtnBuscarCliente.Text = "..."
        BtnBuscarCliente.UseVisualStyleBackColor = True
        ' 
        ' TxtNombreVendedor
        ' 
        TxtNombreVendedor.Location = New Point(445, 244)
        TxtNombreVendedor.Name = "TxtNombreVendedor"
        TxtNombreVendedor.Size = New Size(282, 27)
        TxtNombreVendedor.TabIndex = 17
        ' 
        ' LblNombreVendedor
        ' 
        LblNombreVendedor.AutoSize = True
        LblNombreVendedor.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblNombreVendedor.Location = New Point(445, 221)
        LblNombreVendedor.Name = "LblNombreVendedor"
        LblNombreVendedor.Size = New Size(266, 20)
        LblNombreVendedor.TabIndex = 16
        LblNombreVendedor.Text = "Nombres y Apellidos  del Vendedor:"
        ' 
        ' TxtNombreCliente
        ' 
        TxtNombreCliente.Location = New Point(6, 245)
        TxtNombreCliente.Name = "TxtNombreCliente"
        TxtNombreCliente.Size = New Size(319, 27)
        TxtNombreCliente.TabIndex = 15
        ' 
        ' TxtIdCliente
        ' 
        TxtIdCliente.Location = New Point(250, 215)
        TxtIdCliente.Name = "TxtIdCliente"
        TxtIdCliente.Size = New Size(75, 27)
        TxtIdCliente.TabIndex = 14
        ' 
        ' LblNombreCliente
        ' 
        LblNombreCliente.AutoSize = True
        LblNombreCliente.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblNombreCliente.Location = New Point(6, 218)
        LblNombreCliente.Name = "LblNombreCliente"
        LblNombreCliente.Size = New Size(238, 20)
        LblNombreCliente.TabIndex = 13
        LblNombreCliente.Text = "Nombre y Apellidos del Cliente:"
        ' 
        ' CmbTipoVenta
        ' 
        CmbTipoVenta.FormattingEnabled = True
        CmbTipoVenta.Location = New Point(523, 167)
        CmbTipoVenta.Name = "CmbTipoVenta"
        CmbTipoVenta.Size = New Size(204, 28)
        CmbTipoVenta.TabIndex = 12
        ' 
        ' LblTipoVenta
        ' 
        LblTipoVenta.AutoSize = True
        LblTipoVenta.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblTipoVenta.Location = New Point(510, 145)
        LblTipoVenta.Name = "LblTipoVenta"
        LblTipoVenta.Size = New Size(111, 20)
        LblTipoVenta.TabIndex = 11
        LblTipoVenta.Text = "Tipo de Venta:"
        ' 
        ' TxtHora
        ' 
        TxtHora.Location = New Point(363, 168)
        TxtHora.Name = "TxtHora"
        TxtHora.Size = New Size(125, 27)
        TxtHora.TabIndex = 10
        ' 
        ' LblHora
        ' 
        LblHora.AutoSize = True
        LblHora.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblHora.Location = New Point(363, 145)
        LblHora.Name = "LblHora"
        LblHora.Size = New Size(45, 20)
        LblHora.TabIndex = 9
        LblHora.Text = "Hora"
        ' 
        ' TxtFecha
        ' 
        TxtFecha.Location = New Point(181, 168)
        TxtFecha.Name = "TxtFecha"
        TxtFecha.Size = New Size(125, 27)
        TxtFecha.TabIndex = 8
        ' 
        ' LblFecha
        ' 
        LblFecha.AutoSize = True
        LblFecha.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblFecha.Location = New Point(181, 145)
        LblFecha.Name = "LblFecha"
        LblFecha.Size = New Size(54, 20)
        LblFecha.TabIndex = 7
        LblFecha.Text = "Fecha:"
        ' 
        ' BtnSalir
        ' 
        BtnSalir.BackColor = Color.LightSlateGray
        BtnSalir.BackgroundImageLayout = ImageLayout.Zoom
        BtnSalir.FlatAppearance.BorderColor = Color.DarkSlateGray
        BtnSalir.FlatAppearance.BorderSize = 0
        BtnSalir.FlatAppearance.CheckedBackColor = Color.DarkSlateGray
        BtnSalir.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        BtnSalir.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        BtnSalir.FlatStyle = FlatStyle.Flat
        BtnSalir.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSalir.ForeColor = SystemColors.ButtonHighlight
        BtnSalir.Location = New Point(588, 92)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(139, 33)
        BtnSalir.TabIndex = 6
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = False
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.BackColor = Color.LightSlateGray
        BtnGuardar.BackgroundImageLayout = ImageLayout.Zoom
        BtnGuardar.FlatAppearance.BorderColor = Color.DarkSlateGray
        BtnGuardar.FlatAppearance.BorderSize = 0
        BtnGuardar.FlatAppearance.CheckedBackColor = Color.DarkSlateGray
        BtnGuardar.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        BtnGuardar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        BtnGuardar.FlatStyle = FlatStyle.Flat
        BtnGuardar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnGuardar.ForeColor = SystemColors.ButtonHighlight
        BtnGuardar.Location = New Point(434, 92)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(118, 33)
        BtnGuardar.TabIndex = 5
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.LightSlateGray
        BtnCancelar.BackgroundImageLayout = ImageLayout.Zoom
        BtnCancelar.FlatAppearance.BorderColor = Color.DarkSlateGray
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatAppearance.CheckedBackColor = Color.DarkSlateGray
        BtnCancelar.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        BtnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCancelar.ForeColor = SystemColors.ButtonHighlight
        BtnCancelar.Location = New Point(241, 92)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(120, 33)
        BtnCancelar.TabIndex = 4
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' LblFacturaNo
        ' 
        LblFacturaNo.AutoSize = True
        LblFacturaNo.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblFacturaNo.Location = New Point(3, 145)
        LblFacturaNo.Name = "LblFacturaNo"
        LblFacturaNo.Size = New Size(85, 20)
        LblFacturaNo.TabIndex = 2
        LblFacturaNo.Text = "Factura N°"
        ' 
        ' TxtFacturaNo
        ' 
        TxtFacturaNo.Location = New Point(6, 167)
        TxtFacturaNo.Name = "TxtFacturaNo"
        TxtFacturaNo.Size = New Size(125, 27)
        TxtFacturaNo.TabIndex = 1
        ' 
        ' LblFactura
        ' 
        LblFactura.BackColor = Color.LightSlateGray
        LblFactura.Font = New Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point)
        LblFactura.ForeColor = SystemColors.ButtonHighlight
        LblFactura.Location = New Point(0, 23)
        LblFactura.Name = "LblFactura"
        LblFactura.Size = New Size(747, 46)
        LblFactura.TabIndex = 0
        LblFactura.Text = "Factura"
        LblFactura.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnNuevo
        ' 
        BtnNuevo.BackColor = Color.LightSlateGray
        BtnNuevo.FlatAppearance.BorderColor = SystemColors.ControlDark
        BtnNuevo.FlatAppearance.BorderSize = 0
        BtnNuevo.FlatAppearance.CheckedBackColor = Color.DarkSlateGray
        BtnNuevo.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray
        BtnNuevo.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray
        BtnNuevo.FlatStyle = FlatStyle.Flat
        BtnNuevo.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnNuevo.ForeColor = SystemColors.ButtonHighlight
        BtnNuevo.Location = New Point(43, 92)
        BtnNuevo.Name = "BtnNuevo"
        BtnNuevo.Size = New Size(123, 33)
        BtnNuevo.TabIndex = 3
        BtnNuevo.Text = "Nuevo"
        BtnNuevo.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DataGridView)
        GroupBox2.Controls.Add(LblProductos)
        GroupBox2.Location = New Point(27, 296)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(744, 285)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' DataGridView
        ' 
        DataGridView.BackgroundColor = Color.LightSlateGray
        DataGridView.ColumnHeadersHeight = 29
        DataGridView.Location = New Point(-3, 91)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.RowTemplate.Height = 29
        DataGridView.Size = New Size(747, 194)
        DataGridView.TabIndex = 1
        ' 
        ' LblProductos
        ' 
        LblProductos.BackColor = Color.LightSlateGray
        LblProductos.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblProductos.ForeColor = SystemColors.ButtonHighlight
        LblProductos.Location = New Point(0, 23)
        LblProductos.Name = "LblProductos"
        LblProductos.Size = New Size(744, 46)
        LblProductos.TabIndex = 0
        LblProductos.Text = "Productos"
        LblProductos.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.BackColor = Color.LightSlateGray
        BtnAgregar.FlatAppearance.BorderColor = Color.DarkSlateGray
        BtnAgregar.FlatAppearance.BorderSize = 0
        BtnAgregar.FlatStyle = FlatStyle.Flat
        BtnAgregar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAgregar.ForeColor = SystemColors.ButtonHighlight
        BtnAgregar.Location = New Point(242, 623)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(105, 40)
        BtnAgregar.TabIndex = 2
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = False
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = Color.LightSlateGray
        BtnEliminar.FlatAppearance.BorderColor = Color.DarkSlateGray
        BtnEliminar.FlatAppearance.BorderSize = 0
        BtnEliminar.FlatStyle = FlatStyle.Flat
        BtnEliminar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnEliminar.ForeColor = SystemColors.ButtonHighlight
        BtnEliminar.Location = New Point(429, 623)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(104, 40)
        BtnEliminar.TabIndex = 3
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' LblPrecio
        ' 
        LblPrecio.AutoSize = True
        LblPrecio.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblPrecio.Location = New Point(627, 600)
        LblPrecio.Name = "LblPrecio"
        LblPrecio.Size = New Size(56, 20)
        LblPrecio.TabIndex = 4
        LblPrecio.Text = "Precio"
        ' 
        ' LblIva
        ' 
        LblIva.AutoSize = True
        LblIva.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblIva.Location = New Point(646, 623)
        LblIva.Name = "LblIva"
        LblIva.Size = New Size(35, 20)
        LblIva.TabIndex = 5
        LblIva.Text = "IVA"
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblTotal.Location = New Point(635, 643)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(46, 20)
        LblTotal.TabIndex = 6
        LblTotal.Text = "Total"
        ' 
        ' LblMontoPrecio
        ' 
        LblMontoPrecio.AutoSize = True
        LblMontoPrecio.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblMontoPrecio.Location = New Point(748, 600)
        LblMontoPrecio.Name = "LblMontoPrecio"
        LblMontoPrecio.Size = New Size(18, 20)
        LblMontoPrecio.TabIndex = 7
        LblMontoPrecio.Text = "0"
        ' 
        ' LblMontoIva
        ' 
        LblMontoIva.AutoSize = True
        LblMontoIva.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblMontoIva.Location = New Point(748, 623)
        LblMontoIva.Name = "LblMontoIva"
        LblMontoIva.Size = New Size(18, 20)
        LblMontoIva.TabIndex = 8
        LblMontoIva.Text = "0"
        ' 
        ' LblMontoTotal
        ' 
        LblMontoTotal.AutoSize = True
        LblMontoTotal.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LblMontoTotal.Location = New Point(748, 643)
        LblMontoTotal.Name = "LblMontoTotal"
        LblMontoTotal.Size = New Size(18, 20)
        LblMontoTotal.TabIndex = 9
        LblMontoTotal.Text = "0"
        ' 
        ' TxtNumFactura
        ' 
        TxtNumFactura.Location = New Point(27, 636)
        TxtNumFactura.Name = "TxtNumFactura"
        TxtNumFactura.Size = New Size(125, 27)
        TxtNumFactura.TabIndex = 10
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.agregar
        PictureBox5.Location = New Point(196, 623)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(47, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.eliminar
        PictureBox6.Location = New Point(387, 623)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(45, 40)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 12
        PictureBox6.TabStop = False
        ' 
        ' FrmFactura
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(807, 698)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(TxtNumFactura)
        Controls.Add(LblMontoTotal)
        Controls.Add(LblMontoIva)
        Controls.Add(LblMontoPrecio)
        Controls.Add(LblTotal)
        Controls.Add(LblIva)
        Controls.Add(LblPrecio)
        Controls.Add(BtnEliminar)
        Controls.Add(BtnAgregar)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FrmFactura"
        Text = "FrmFactura"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents LblFecha As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents LblFacturaNo As Label
    Friend WithEvents TxtFacturaNo As TextBox
    Friend WithEvents LblFactura As Label
    Friend WithEvents TxtHora As TextBox
    Friend WithEvents LblHora As Label
    Friend WithEvents LblTipoVenta As Label
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents LblNombreCliente As Label
    Friend WithEvents CmbTipoVenta As ComboBox
    Friend WithEvents LblNombreVendedor As Label
    Friend WithEvents TxtNombreVendedor As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents LblProductos As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblIva As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblMontoPrecio As Label
    Friend WithEvents LblMontoIva As Label
    Friend WithEvents LblMontoTotal As Label
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents TxtNumFactura As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
