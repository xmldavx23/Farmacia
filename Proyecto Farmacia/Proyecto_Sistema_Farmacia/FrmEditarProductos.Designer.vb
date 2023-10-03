<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarProductos
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
        Label5 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        TxtDescontinuado = New TextBox()
        ChkDescontinuado = New CheckBox()
        Label6 = New Label()
        TxtUnidadesInv = New TextBox()
        Label1 = New Label()
        TxtPrecio = New TextBox()
        Label4 = New Label()
        TxtCantidad = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        CbProveedor = New ComboBox()
        CbCategoria = New ComboBox()
        TxtIdProducto = New TextBox()
        Label10 = New Label()
        TxtDescripcion = New TextBox()
        BtnCerrar = New Button()
        BtnAceptar = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(211, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(260, 33)
        Label5.TabIndex = 21
        Label5.Text = "    Editar Productos   "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(22, 453)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 20)
        Label8.TabIndex = 40
        Label8.Text = "ID Producto"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(191, 399)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 20)
        Label7.TabIndex = 39
        Label7.Text = "Descontinuado"
        ' 
        ' TxtDescontinuado
        ' 
        TxtDescontinuado.Location = New Point(392, 394)
        TxtDescontinuado.Name = "TxtDescontinuado"
        TxtDescontinuado.Size = New Size(101, 27)
        TxtDescontinuado.TabIndex = 38
        ' 
        ' ChkDescontinuado
        ' 
        ChkDescontinuado.AutoSize = True
        ChkDescontinuado.Location = New Point(346, 399)
        ChkDescontinuado.Name = "ChkDescontinuado"
        ChkDescontinuado.Size = New Size(18, 17)
        ChkDescontinuado.TabIndex = 37
        ChkDescontinuado.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(234, 345)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 36
        Label6.Text = "Unidades"
        ' 
        ' TxtUnidadesInv
        ' 
        TxtUnidadesInv.Location = New Point(346, 345)
        TxtUnidadesInv.Name = "TxtUnidadesInv"
        TxtUnidadesInv.Size = New Size(147, 27)
        TxtUnidadesInv.TabIndex = 35
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(186, 296)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 20)
        Label1.TabIndex = 34
        Label1.Text = "Precio Unitario"
        ' 
        ' TxtPrecio
        ' 
        TxtPrecio.Location = New Point(342, 291)
        TxtPrecio.Name = "TxtPrecio"
        TxtPrecio.Size = New Size(151, 27)
        TxtPrecio.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(237, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 32
        Label4.Text = "Cantidad"
        ' 
        ' TxtCantidad
        ' 
        TxtCantidad.Location = New Point(342, 243)
        TxtCantidad.Name = "TxtCantidad"
        TxtCantidad.Size = New Size(151, 27)
        TxtCantidad.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(225, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 30
        Label3.Text = "Proveedor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(231, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 29
        Label2.Text = "Categoria"
        ' 
        ' CbProveedor
        ' 
        CbProveedor.FormattingEnabled = True
        CbProveedor.Location = New Point(342, 196)
        CbProveedor.Name = "CbProveedor"
        CbProveedor.Size = New Size(151, 28)
        CbProveedor.TabIndex = 28
        ' 
        ' CbCategoria
        ' 
        CbCategoria.FormattingEnabled = True
        CbCategoria.Location = New Point(342, 149)
        CbCategoria.Name = "CbCategoria"
        CbCategoria.Size = New Size(151, 28)
        CbCategoria.TabIndex = 27
        ' 
        ' TxtIdProducto
        ' 
        TxtIdProducto.Location = New Point(22, 480)
        TxtIdProducto.Name = "TxtIdProducto"
        TxtIdProducto.Size = New Size(173, 27)
        TxtIdProducto.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(211, 105)
        Label10.Name = "Label10"
        Label10.Size = New Size(95, 20)
        Label10.TabIndex = 25
        Label10.Text = "Descripcion"
        ' 
        ' TxtDescripcion
        ' 
        TxtDescripcion.Location = New Point(342, 99)
        TxtDescripcion.Name = "TxtDescripcion"
        TxtDescripcion.Size = New Size(151, 27)
        TxtDescripcion.TabIndex = 24
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(392, 491)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(108, 29)
        BtnCerrar.TabIndex = 23
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(392, 443)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(108, 29)
        BtnAceptar.TabIndex = 22
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion2
        PictureBox2.Location = New Point(351, 491)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 42
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque
        PictureBox1.Location = New Point(351, 443)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' FrmEditarProductos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(675, 551)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TxtDescontinuado)
        Controls.Add(ChkDescontinuado)
        Controls.Add(Label6)
        Controls.Add(TxtUnidadesInv)
        Controls.Add(Label1)
        Controls.Add(TxtPrecio)
        Controls.Add(Label4)
        Controls.Add(TxtCantidad)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(CbProveedor)
        Controls.Add(CbCategoria)
        Controls.Add(TxtIdProducto)
        Controls.Add(Label10)
        Controls.Add(TxtDescripcion)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnAceptar)
        Controls.Add(Label5)
        Name = "FrmEditarProductos"
        Text = "FrmEditarProductos"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDescontinuado As TextBox
    Friend WithEvents ChkDescontinuado As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtUnidadesInv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbProveedor As ComboBox
    Friend WithEvents CbCategoria As ComboBox
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
