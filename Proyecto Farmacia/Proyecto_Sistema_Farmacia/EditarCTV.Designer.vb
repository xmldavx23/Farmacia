<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCTV
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
        BtnCancelar = New Button()
        BtnAceptar = New Button()
        TxtId = New TextBox()
        TxtCTV = New TextBox()
        Label1 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion
        PictureBox2.Location = New Point(215, 300)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(46, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque
        PictureBox1.Location = New Point(215, 248)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(15, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 20)
        Label3.TabIndex = 21
        Label3.Text = "ID Categoría Tipo Venta"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(34, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 20)
        Label2.TabIndex = 20
        Label2.Text = "Categoría Tipo Venta"
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.LightSteelBlue
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCancelar.Location = New Point(267, 304)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(112, 31)
        BtnCancelar.TabIndex = 19
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(267, 252)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(112, 31)
        BtnAceptar.TabIndex = 18
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' TxtId
        ' 
        TxtId.Location = New Point(225, 174)
        TxtId.Name = "TxtId"
        TxtId.Size = New Size(154, 27)
        TxtId.TabIndex = 17
        ' 
        ' TxtCTV
        ' 
        TxtCTV.Location = New Point(225, 100)
        TxtCTV.Name = "TxtCTV"
        TxtCTV.Size = New Size(154, 27)
        TxtCTV.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(31, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(348, 33)
        Label1.TabIndex = 15
        Label1.Text = "Editar Categoria Tipo Venta"
        ' 
        ' EditarCTV
        ' 
        AcceptButton = BtnAceptar
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(407, 390)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnAceptar)
        Controls.Add(TxtId)
        Controls.Add(TxtCTV)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "EditarCTV"
        Text = "EditarCTV"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtCTV As TextBox
    Friend WithEvents Label1 As Label
End Class
