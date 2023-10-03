<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeguridad
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
        Label2 = New Label()
        Label3 = New Label()
        TxtCargarUsuario = New TextBox()
        TxtCargarContraseña = New TextBox()
        TxtUsuario = New TextBox()
        TxtContraseña = New TextBox()
        BtnAceptar = New Button()
        BtnCancelar = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(95, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 23)
        Label2.TabIndex = 1
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(95, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 23)
        Label3.TabIndex = 2
        Label3.Text = "Contraseña"
        ' 
        ' TxtCargarUsuario
        ' 
        TxtCargarUsuario.Location = New Point(371, 120)
        TxtCargarUsuario.Name = "TxtCargarUsuario"
        TxtCargarUsuario.Size = New Size(125, 27)
        TxtCargarUsuario.TabIndex = 3
        ' 
        ' TxtCargarContraseña
        ' 
        TxtCargarContraseña.Location = New Point(371, 153)
        TxtCargarContraseña.Name = "TxtCargarContraseña"
        TxtCargarContraseña.Size = New Size(125, 27)
        TxtCargarContraseña.TabIndex = 4
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.BackColor = SystemColors.ActiveCaption
        TxtUsuario.BorderStyle = BorderStyle.FixedSingle
        TxtUsuario.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsuario.Location = New Point(95, 239)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(295, 31)
        TxtUsuario.TabIndex = 5
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.BackColor = SystemColors.ActiveCaption
        TxtContraseña.BorderStyle = BorderStyle.FixedSingle
        TxtContraseña.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContraseña.Location = New Point(95, 305)
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.PasswordChar = "*"c
        TxtContraseña.Size = New Size(295, 31)
        TxtContraseña.TabIndex = 6
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.ForeColor = Color.Black
        BtnAceptar.Location = New Point(95, 368)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.RightToLeft = RightToLeft.No
        BtnAceptar.Size = New Size(295, 36)
        BtnAceptar.TabIndex = 7
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.LightSteelBlue
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCancelar.ForeColor = Color.Black
        BtnCancelar.Location = New Point(336, 450)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(120, 36)
        BtnCancelar.TabIndex = 8
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.usuario
        PictureBox1.Location = New Point(165, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 168)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.noun_login_5455317
        PictureBox2.Location = New Point(345, 368)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' FormSeguridad
        ' 
        AcceptButton = BtnAceptar
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.R
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(508, 518)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnAceptar)
        Controls.Add(TxtContraseña)
        Controls.Add(TxtUsuario)
        Controls.Add(TxtCargarContraseña)
        Controls.Add(TxtCargarUsuario)
        Controls.Add(Label3)
        Name = "FormSeguridad"
        Text = "FormSeguridad"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCargarUsuario As TextBox
    Friend WithEvents TxtCargarContraseña As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
