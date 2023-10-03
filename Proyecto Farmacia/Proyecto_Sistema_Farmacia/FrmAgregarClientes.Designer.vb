<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarClientes
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
        TxtNombreApellidos = New TextBox()
        Label2 = New Label()
        TxtCedula = New TextBox()
        Label3 = New Label()
        TxtTelefono = New TextBox()
        BtnAceptar = New Button()
        BtnCerrar = New Button()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(117, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombres y Apellidos"
        ' 
        ' TxtNombreApellidos
        ' 
        TxtNombreApellidos.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNombreApellidos.Location = New Point(117, 134)
        TxtNombreApellidos.Name = "TxtNombreApellidos"
        TxtNombreApellidos.Size = New Size(234, 27)
        TxtNombreApellidos.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(117, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 2
        Label2.Text = "N° Cedula"
        ' 
        ' TxtCedula
        ' 
        TxtCedula.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCedula.Location = New Point(117, 201)
        TxtCedula.Name = "TxtCedula"
        TxtCedula.Size = New Size(234, 27)
        TxtCedula.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(117, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 4
        Label3.Text = "N° Telefono"
        ' 
        ' TxtTelefono
        ' 
        TxtTelefono.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtTelefono.Location = New Point(117, 265)
        TxtTelefono.Name = "TxtTelefono"
        TxtTelefono.Size = New Size(234, 27)
        TxtTelefono.TabIndex = 5
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.ForeColor = SystemColors.ActiveCaptionText
        BtnAceptar.Location = New Point(193, 310)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(104, 29)
        BtnAceptar.TabIndex = 6
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(193, 361)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(104, 29)
        BtnCerrar.TabIndex = 7
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(12, 415)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(140, 27)
        TextBox1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 392)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 20)
        Label4.TabIndex = 9
        Label4.Text = "ID Cliente"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(106, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(258, 40)
        Label5.TabIndex = 10
        Label5.Text = "Agregar Clientes"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque
        PictureBox1.Location = New Point(158, 310)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion1
        PictureBox2.Location = New Point(158, 361)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(37, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' FrmAgregarClientes
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(497, 474)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnAceptar)
        Controls.Add(TxtTelefono)
        Controls.Add(Label3)
        Controls.Add(TxtCedula)
        Controls.Add(Label2)
        Controls.Add(TxtNombreApellidos)
        Controls.Add(Label1)
        Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "FrmAgregarClientes"
        Text = "FrmAgregarClientes"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombreApellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
