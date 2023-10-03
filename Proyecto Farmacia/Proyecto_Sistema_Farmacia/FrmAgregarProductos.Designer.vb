<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarProductos
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
        BtnAceptar = New Button()
        BtnCerrar = New Button()
        TxtDescripcion = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        CbCategoria = New ComboBox()
        CbProveedor = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        TxtCantidad = New TextBox()
        Label4 = New Label()
        TxtPrecio = New TextBox()
        Label5 = New Label()
        TxtUnidadesInv = New TextBox()
        Label6 = New Label()
        ChkDescontinuado = New CheckBox()
        TxtDescontinuado = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(274, 453)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(133, 29)
        BtnAceptar.TabIndex = 0
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(274, 501)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(133, 29)
        BtnCerrar.TabIndex = 1
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' TxtDescripcion
        ' 
        TxtDescripcion.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescripcion.Location = New Point(274, 94)
        TxtDescripcion.Name = "TxtDescripcion"
        TxtDescripcion.Size = New Size(151, 29)
        TxtDescripcion.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(143, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 21)
        Label1.TabIndex = 3
        Label1.Text = "Descripcion"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(29, 528)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(173, 29)
        TextBox1.TabIndex = 4
        ' 
        ' CbCategoria
        ' 
        CbCategoria.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        CbCategoria.FormattingEnabled = True
        CbCategoria.Location = New Point(274, 144)
        CbCategoria.Name = "CbCategoria"
        CbCategoria.Size = New Size(151, 29)
        CbCategoria.TabIndex = 5
        ' 
        ' CbProveedor
        ' 
        CbProveedor.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        CbProveedor.FormattingEnabled = True
        CbProveedor.Location = New Point(274, 191)
        CbProveedor.Name = "CbProveedor"
        CbProveedor.Size = New Size(151, 29)
        CbProveedor.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(163, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 21)
        Label2.TabIndex = 7
        Label2.Text = "Categoria"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(157, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 21)
        Label3.TabIndex = 8
        Label3.Text = "Proveedor"
        ' 
        ' TxtCantidad
        ' 
        TxtCantidad.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCantidad.Location = New Point(274, 238)
        TxtCantidad.Name = "TxtCantidad"
        TxtCantidad.Size = New Size(151, 29)
        TxtCantidad.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(169, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 21)
        Label4.TabIndex = 10
        Label4.Text = "Cantidad"
        ' 
        ' TxtPrecio
        ' 
        TxtPrecio.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPrecio.Location = New Point(274, 286)
        TxtPrecio.Name = "TxtPrecio"
        TxtPrecio.Size = New Size(151, 29)
        TxtPrecio.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(118, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 21)
        Label5.TabIndex = 12
        Label5.Text = "Precio Unitario"
        ' 
        ' TxtUnidadesInv
        ' 
        TxtUnidadesInv.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUnidadesInv.Location = New Point(278, 340)
        TxtUnidadesInv.Name = "TxtUnidadesInv"
        TxtUnidadesInv.Size = New Size(147, 29)
        TxtUnidadesInv.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(166, 340)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 21)
        Label6.TabIndex = 14
        Label6.Text = "Unidades"
        ' 
        ' ChkDescontinuado
        ' 
        ChkDescontinuado.AutoSize = True
        ChkDescontinuado.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        ChkDescontinuado.Location = New Point(278, 395)
        ChkDescontinuado.Name = "ChkDescontinuado"
        ChkDescontinuado.Size = New Size(18, 17)
        ChkDescontinuado.TabIndex = 15
        ChkDescontinuado.UseVisualStyleBackColor = True
        ' 
        ' TxtDescontinuado
        ' 
        TxtDescontinuado.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescontinuado.Location = New Point(324, 389)
        TxtDescontinuado.Name = "TxtDescontinuado"
        TxtDescontinuado.Size = New Size(101, 29)
        TxtDescontinuado.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(123, 394)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 21)
        Label7.TabIndex = 17
        Label7.Text = "Descontinuado"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(29, 501)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 21)
        Label8.TabIndex = 18
        Label8.Text = "ID Producto"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(170, 31)
        Label9.Name = "Label9"
        Label9.Size = New Size(240, 33)
        Label9.TabIndex = 19
        Label9.Text = "Agregar Productos"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque
        PictureBox1.Location = New Point(243, 453)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion2
        PictureBox2.Location = New Point(243, 501)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' FrmAgregarProductos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(571, 589)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TxtDescontinuado)
        Controls.Add(ChkDescontinuado)
        Controls.Add(Label6)
        Controls.Add(TxtUnidadesInv)
        Controls.Add(Label5)
        Controls.Add(TxtPrecio)
        Controls.Add(Label4)
        Controls.Add(TxtCantidad)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(CbProveedor)
        Controls.Add(CbCategoria)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(TxtDescripcion)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnAceptar)
        Name = "FrmAgregarProductos"
        Text = "FrmAgregarProductos"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CbCategoria As ComboBox
    Friend WithEvents CbProveedor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUnidadesInv As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ChkDescontinuado As CheckBox
    Friend WithEvents TxtDescontinuado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
