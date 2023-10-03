<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoria
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
        TxtNombreCategoria = New TextBox()
        TextBox1 = New TextBox()
        BtnAceptar = New Button()
        BtnCerrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtNombreCategoria
        ' 
        TxtNombreCategoria.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNombreCategoria.Location = New Point(225, 87)
        TxtNombreCategoria.Name = "TxtNombreCategoria"
        TxtNombreCategoria.Size = New Size(161, 29)
        TxtNombreCategoria.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(225, 147)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(161, 29)
        TextBox1.TabIndex = 1
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.LightSteelBlue
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAceptar.Location = New Point(266, 201)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(111, 29)
        BtnAceptar.TabIndex = 2
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(266, 250)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(111, 29)
        BtnCerrar.TabIndex = 3
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(102, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 21)
        Label1.TabIndex = 4
        Label1.Text = "ID Categoria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(85, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(315, 33)
        Label2.TabIndex = 5
        Label2.Text = "Agregar Categoria Nueva"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(124, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 21)
        Label3.TabIndex = 6
        Label3.Text = "Categoria"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheque
        PictureBox1.Location = New Point(230, 201)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.cerrar_sesion1
        PictureBox2.Location = New Point(230, 250)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' FrmCategoria
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 310)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnAceptar)
        Controls.Add(TextBox1)
        Controls.Add(TxtNombreCategoria)
        Name = "FrmCategoria"
        Text = "FrmCategoria"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNombreCategoria As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
