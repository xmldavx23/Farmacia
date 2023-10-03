<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCatTipoVenta
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
        TxtCTV = New TextBox()
        TxtId = New TextBox()
        BtnAceptar = New Button()
        BtnCancelar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(40, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 33)
        Label1.TabIndex = 0
        Label1.Text = "Agregar Categoria Tipo Venta"
        ' 
        ' TxtCTV
        ' 
        TxtCTV.Location = New Point(231, 100)
        TxtCTV.Name = "TxtCTV"
        TxtCTV.Size = New Size(163, 27)
        TxtCTV.TabIndex = 1
        ' 
        ' TxtId
        ' 
        TxtId.Location = New Point(231, 174)
        TxtId.Name = "TxtId"
        TxtId.Size = New Size(163, 27)
        TxtId.TabIndex = 2
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(282, 252)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(112, 31)
        BtnAceptar.TabIndex = 3
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.LightSteelBlue
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCancelar.Location = New Point(282, 304)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(112, 31)
        BtnCancelar.TabIndex = 4
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(40, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 20)
        Label2.TabIndex = 5
        Label2.Text = "Categoría Tipo Venta"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(21, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 20)
        Label3.TabIndex = 6
        Label3.Text = "ID Categoría Tipo Venta"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion
        PictureBox2.Location = New Point(230, 300)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(46, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque
        PictureBox1.Location = New Point(230, 248)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' FormCatTipoVenta
        ' 
        AcceptButton = BtnAceptar
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 377)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnAceptar)
        Controls.Add(TxtId)
        Controls.Add(TxtCTV)
        Controls.Add(Label1)
        Name = "FormCatTipoVenta"
        Text = "FormCatTipoVenta"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCTV As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
