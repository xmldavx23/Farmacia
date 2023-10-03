<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarCategorias
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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        BtnCerrar = New Button()
        BtnAceptar = New Button()
        TxtIdCategoria = New TextBox()
        TxtNombreCategoria = New TextBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion1
        PictureBox2.Location = New Point(177, 251)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque
        PictureBox1.Location = New Point(177, 202)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(71, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 21)
        Label3.TabIndex = 15
        Label3.Text = "Categoria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(81, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(212, 33)
        Label2.TabIndex = 14
        Label2.Text = "Editar Categoria"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(49, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 21)
        Label1.TabIndex = 13
        Label1.Text = "ID Categoria"
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(213, 251)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(111, 29)
        BtnCerrar.TabIndex = 12
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(213, 202)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(111, 29)
        BtnAceptar.TabIndex = 11
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' TxtIdCategoria
        ' 
        TxtIdCategoria.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtIdCategoria.Location = New Point(172, 148)
        TxtIdCategoria.Name = "TxtIdCategoria"
        TxtIdCategoria.Size = New Size(161, 29)
        TxtIdCategoria.TabIndex = 10
        ' 
        ' TxtNombreCategoria
        ' 
        TxtNombreCategoria.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNombreCategoria.Location = New Point(172, 88)
        TxtNombreCategoria.Name = "TxtNombreCategoria"
        TxtNombreCategoria.Size = New Size(161, 29)
        TxtNombreCategoria.TabIndex = 9
        ' 
        ' FrmEditarCategorias
        ' 
        AcceptButton = BtnAceptar
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(395, 327)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnAceptar)
        Controls.Add(TxtIdCategoria)
        Controls.Add(TxtNombreCategoria)
        Name = "FrmEditarCategorias"
        Text = "FrmEditarCategorias"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtIdCategoria As TextBox
    Friend WithEvents TxtNombreCategoria As TextBox
End Class
