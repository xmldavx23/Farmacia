<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarLaboratorio
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
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        BtnCerrar = New Button()
        BtnAceptar = New Button()
        TxtIdLaboratorio = New TextBox()
        TxtContacto = New TextBox()
        TxtFax = New TextBox()
        TxtTelefono = New TextBox()
        TxtDireccion = New TextBox()
        TxtNombreLaboratorio = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion
        PictureBox2.Location = New Point(248, 396)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 50
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque1
        PictureBox1.Location = New Point(248, 344)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 49
        PictureBox1.TabStop = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(284, 396)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(111, 29)
        BtnCerrar.TabIndex = 48
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(284, 344)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(110, 29)
        BtnAceptar.TabIndex = 47
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' TxtIdLaboratorio
        ' 
        TxtIdLaboratorio.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtIdLaboratorio.Location = New Point(32, 387)
        TxtIdLaboratorio.Name = "TxtIdLaboratorio"
        TxtIdLaboratorio.Size = New Size(125, 29)
        TxtIdLaboratorio.TabIndex = 46
        ' 
        ' TxtContacto
        ' 
        TxtContacto.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContacto.Location = New Point(270, 275)
        TxtContacto.Name = "TxtContacto"
        TxtContacto.Size = New Size(125, 29)
        TxtContacto.TabIndex = 45
        ' 
        ' TxtFax
        ' 
        TxtFax.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFax.Location = New Point(270, 224)
        TxtFax.Name = "TxtFax"
        TxtFax.Size = New Size(125, 29)
        TxtFax.TabIndex = 44
        ' 
        ' TxtTelefono
        ' 
        TxtTelefono.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtTelefono.Location = New Point(270, 175)
        TxtTelefono.Name = "TxtTelefono"
        TxtTelefono.Size = New Size(125, 29)
        TxtTelefono.TabIndex = 43
        ' 
        ' TxtDireccion
        ' 
        TxtDireccion.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDireccion.Location = New Point(270, 136)
        TxtDireccion.Name = "TxtDireccion"
        TxtDireccion.Size = New Size(125, 29)
        TxtDireccion.TabIndex = 42
        ' 
        ' TxtNombreLaboratorio
        ' 
        TxtNombreLaboratorio.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNombreLaboratorio.Location = New Point(269, 87)
        TxtNombreLaboratorio.Name = "TxtNombreLaboratorio"
        TxtNombreLaboratorio.Size = New Size(125, 29)
        TxtNombreLaboratorio.TabIndex = 41
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(32, 354)
        Label8.Name = "Label8"
        Label8.Size = New Size(125, 21)
        Label8.TabIndex = 40
        Label8.Text = "ID Laboratorio"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(169, 283)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 21)
        Label7.TabIndex = 39
        Label7.Text = "Contacto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(207, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 21)
        Label5.TabIndex = 38
        Label5.Text = "Fax"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(170, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 21)
        Label4.TabIndex = 37
        Label4.Text = "Telefono"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(165, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 21)
        Label3.TabIndex = 36
        Label3.Text = "Direccion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(57, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 21)
        Label2.TabIndex = 35
        Label2.Text = "Nombre de Laboratorio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(154, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 33)
        Label1.TabIndex = 51
        Label1.Text = "Editar Laboratorio"
        ' 
        ' FrmEditarLaboratorio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(509, 478)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnAceptar)
        Controls.Add(TxtIdLaboratorio)
        Controls.Add(TxtContacto)
        Controls.Add(TxtFax)
        Controls.Add(TxtTelefono)
        Controls.Add(TxtDireccion)
        Controls.Add(TxtNombreLaboratorio)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "FrmEditarLaboratorio"
        Text = "FrmEditarLaboratorio"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtIdLaboratorio As TextBox
    Friend WithEvents TxtContacto As TextBox
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtNombreLaboratorio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
