<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TxtNombreProveedor = New TextBox()
        TxtDireccion = New TextBox()
        TxtTelefono = New TextBox()
        TxtFax = New TextBox()
        TxtWeb = New TextBox()
        TxtContacto = New TextBox()
        TextBox = New TextBox()
        BtnAceptar = New Button()
        BtnCerrar = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(124, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 33)
        Label1.TabIndex = 0
        Label1.Text = "Agregar Proveedores"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(80, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nombre de Proveedor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(165, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 2
        Label3.Text = "Direccion"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(170, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 3
        Label4.Text = "Telefono"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(207, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 20)
        Label5.TabIndex = 4
        Label5.Text = "Fax"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(198, 245)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 20)
        Label6.TabIndex = 5
        Label6.Text = "Web"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(170, 294)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 20)
        Label7.TabIndex = 6
        Label7.Text = "Contacto"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(12, 349)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 20)
        Label8.TabIndex = 7
        Label8.Text = "ID Proveedor"
        ' 
        ' TxtNombreProveedor
        ' 
        TxtNombreProveedor.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNombreProveedor.Location = New Point(269, 59)
        TxtNombreProveedor.Name = "TxtNombreProveedor"
        TxtNombreProveedor.Size = New Size(125, 27)
        TxtNombreProveedor.TabIndex = 8
        ' 
        ' TxtDireccion
        ' 
        TxtDireccion.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDireccion.Location = New Point(270, 108)
        TxtDireccion.Name = "TxtDireccion"
        TxtDireccion.Size = New Size(125, 27)
        TxtDireccion.TabIndex = 9
        ' 
        ' TxtTelefono
        ' 
        TxtTelefono.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtTelefono.Location = New Point(270, 147)
        TxtTelefono.Name = "TxtTelefono"
        TxtTelefono.Size = New Size(125, 27)
        TxtTelefono.TabIndex = 10
        ' 
        ' TxtFax
        ' 
        TxtFax.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFax.Location = New Point(270, 196)
        TxtFax.Name = "TxtFax"
        TxtFax.Size = New Size(125, 27)
        TxtFax.TabIndex = 11
        ' 
        ' TxtWeb
        ' 
        TxtWeb.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtWeb.Location = New Point(270, 238)
        TxtWeb.Name = "TxtWeb"
        TxtWeb.Size = New Size(125, 27)
        TxtWeb.TabIndex = 12
        ' 
        ' TxtContacto
        ' 
        TxtContacto.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContacto.Location = New Point(270, 287)
        TxtContacto.Name = "TxtContacto"
        TxtContacto.Size = New Size(125, 27)
        TxtContacto.TabIndex = 13
        ' 
        ' TextBox
        ' 
        TextBox.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox.Location = New Point(12, 382)
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(125, 27)
        TextBox.TabIndex = 14
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(295, 342)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(99, 29)
        BtnAceptar.TabIndex = 15
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(295, 377)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(99, 29)
        BtnCerrar.TabIndex = 16
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque1
        PictureBox1.Location = New Point(248, 342)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(49, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion3
        PictureBox2.Location = New Point(248, 376)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(49, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' FrmProveedores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(525, 450)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnAceptar)
        Controls.Add(TextBox)
        Controls.Add(TxtContacto)
        Controls.Add(TxtWeb)
        Controls.Add(TxtFax)
        Controls.Add(TxtTelefono)
        Controls.Add(TxtDireccion)
        Controls.Add(TxtNombreProveedor)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmProveedores"
        Text = "FrmProveedores"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents TxtWeb As TextBox
    Friend WithEvents TxtContacto As TextBox
    Friend WithEvents TextBox As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
