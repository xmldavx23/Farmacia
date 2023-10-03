<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarClientes
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
        TxtNombreApellidos = New TextBox()
        TxtCedula = New TextBox()
        TxtTelefono = New TextBox()
        TxtIdCliente = New TextBox()
        BtnAceptar = New Button()
        BtnCerrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtNombreApellidos
        ' 
        TxtNombreApellidos.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNombreApellidos.Location = New Point(98, 123)
        TxtNombreApellidos.Name = "TxtNombreApellidos"
        TxtNombreApellidos.Size = New Size(270, 27)
        TxtNombreApellidos.TabIndex = 0
        ' 
        ' TxtCedula
        ' 
        TxtCedula.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCedula.Location = New Point(96, 189)
        TxtCedula.Name = "TxtCedula"
        TxtCedula.Size = New Size(272, 27)
        TxtCedula.TabIndex = 1
        ' 
        ' TxtTelefono
        ' 
        TxtTelefono.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtTelefono.Location = New Point(96, 265)
        TxtTelefono.Name = "TxtTelefono"
        TxtTelefono.Size = New Size(267, 27)
        TxtTelefono.TabIndex = 2
        ' 
        ' TxtIdCliente
        ' 
        TxtIdCliente.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtIdCliente.Location = New Point(12, 392)
        TxtIdCliente.Name = "TxtIdCliente"
        TxtIdCliente.Size = New Size(125, 27)
        TxtIdCliente.TabIndex = 3
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(241, 319)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(122, 35)
        BtnAceptar.TabIndex = 4
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(241, 371)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(122, 35)
        BtnCerrar.TabIndex = 5
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(98, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 20)
        Label1.TabIndex = 6
        Label1.Text = "Nombres y Apellidos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(96, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 7
        Label2.Text = "N° de Cedula"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(98, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 8
        Label3.Text = "N° de Telefono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 356)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 20)
        Label4.TabIndex = 9
        Label4.Text = "ID Cliente"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(114, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(235, 33)
        Label5.TabIndex = 10
        Label5.Text = "    Editar Clientes   "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque
        PictureBox1.Location = New Point(197, 319)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion
        PictureBox2.Location = New Point(197, 371)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(46, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' FrmEditarClientes
        ' 
        AcceptButton = BtnAceptar
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 458)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnAceptar)
        Controls.Add(TxtIdCliente)
        Controls.Add(TxtTelefono)
        Controls.Add(TxtCedula)
        Controls.Add(TxtNombreApellidos)
        Name = "FrmEditarClientes"
        Text = "FrmEditarClientes"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNombreApellidos As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
