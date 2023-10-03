<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLaboratorios
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
        BtnCerrar = New Button()
        BtnAceptar = New Button()
        TextBox = New TextBox()
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
        Label1.Location = New Point(179, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(274, 33)
        Label1.TabIndex = 0
        Label1.Text = "Agregar Laboratorios"
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(327, 389)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(111, 29)
        BtnCerrar.TabIndex = 32
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(327, 337)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(110, 29)
        BtnAceptar.TabIndex = 31
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' TextBox
        ' 
        TextBox.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox.Location = New Point(16, 349)
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(125, 29)
        TextBox.TabIndex = 30
        ' 
        ' TxtContacto
        ' 
        TxtContacto.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContacto.Location = New Point(312, 269)
        TxtContacto.Name = "TxtContacto"
        TxtContacto.Size = New Size(125, 29)
        TxtContacto.TabIndex = 29
        ' 
        ' TxtFax
        ' 
        TxtFax.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFax.Location = New Point(313, 217)
        TxtFax.Name = "TxtFax"
        TxtFax.Size = New Size(125, 29)
        TxtFax.TabIndex = 27
        ' 
        ' TxtTelefono
        ' 
        TxtTelefono.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtTelefono.Location = New Point(313, 168)
        TxtTelefono.Name = "TxtTelefono"
        TxtTelefono.Size = New Size(125, 29)
        TxtTelefono.TabIndex = 26
        ' 
        ' TxtDireccion
        ' 
        TxtDireccion.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDireccion.Location = New Point(313, 129)
        TxtDireccion.Name = "TxtDireccion"
        TxtDireccion.Size = New Size(125, 29)
        TxtDireccion.TabIndex = 25
        ' 
        ' TxtNombreLaboratorio
        ' 
        TxtNombreLaboratorio.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNombreLaboratorio.Location = New Point(312, 80)
        TxtNombreLaboratorio.Name = "TxtNombreLaboratorio"
        TxtNombreLaboratorio.Size = New Size(125, 29)
        TxtNombreLaboratorio.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(16, 316)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 21)
        Label8.TabIndex = 23
        Label8.Text = "ID Proveedor"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(212, 276)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 21)
        Label7.TabIndex = 22
        Label7.Text = "Contacto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(250, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 21)
        Label5.TabIndex = 20
        Label5.Text = "Fax"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(213, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 21)
        Label4.TabIndex = 19
        Label4.Text = "Telefono"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(208, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 21)
        Label3.TabIndex = 18
        Label3.Text = "Direccion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(100, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 21)
        Label2.TabIndex = 17
        Label2.Text = "Nombre de Laboratorio"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque1
        PictureBox1.Location = New Point(291, 337)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion
        PictureBox2.Location = New Point(291, 389)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 34
        PictureBox2.TabStop = False
        ' 
        ' FrmLaboratorios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(615, 450)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnAceptar)
        Controls.Add(TextBox)
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
        Controls.Add(Label1)
        Name = "FrmLaboratorios"
        Text = "FrmLaboratorios"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TextBox As TextBox
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
