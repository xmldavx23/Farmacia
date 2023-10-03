<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalle
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
        GroupBox6 = New GroupBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        TxtBuscar = New TextBox()
        BtnCancelar = New Button()
        BtnBuscar = New Button()
        DataGridView1 = New DataGridView()
        LlbCantidad = New Label()
        TxtCantidad = New TextBox()
        BtnAgregar = New Button()
        PictureBox3 = New PictureBox()
        GroupBox6.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(PictureBox2)
        GroupBox6.Controls.Add(PictureBox1)
        GroupBox6.Controls.Add(TxtBuscar)
        GroupBox6.Controls.Add(BtnCancelar)
        GroupBox6.Controls.Add(BtnBuscar)
        GroupBox6.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox6.ForeColor = Color.DarkSlateGray
        GroupBox6.Location = New Point(12, 12)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(447, 69)
        GroupBox6.TabIndex = 0
        GroupBox6.TabStop = False
        GroupBox6.Text = "Buscar Medicamentos"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.boton_cancelar
        PictureBox2.Location = New Point(323, 26)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(34, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.lupa1
        PictureBox1.Location = New Point(192, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(34, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(6, 26)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.PlaceholderText = "Buscar"
        TxtBuscar.Size = New Size(171, 27)
        TxtBuscar.TabIndex = 2
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.LightSteelBlue
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCancelar.ForeColor = SystemColors.ActiveCaptionText
        BtnCancelar.Location = New Point(358, 26)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(83, 29)
        BtnCancelar.TabIndex = 1
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackColor = Color.LightSteelBlue
        BtnBuscar.FlatAppearance.BorderSize = 0
        BtnBuscar.FlatStyle = FlatStyle.Flat
        BtnBuscar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBuscar.ForeColor = SystemColors.ActiveCaptionText
        BtnBuscar.Location = New Point(222, 26)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(83, 29)
        BtnBuscar.TabIndex = 0
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 87)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(447, 233)
        DataGridView1.TabIndex = 1
        ' 
        ' LlbCantidad
        ' 
        LlbCantidad.AutoSize = True
        LlbCantidad.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        LlbCantidad.Location = New Point(267, 347)
        LlbCantidad.Name = "LlbCantidad"
        LlbCantidad.Size = New Size(73, 20)
        LlbCantidad.TabIndex = 2
        LlbCantidad.Text = "Cantidad"
        ' 
        ' TxtCantidad
        ' 
        TxtCantidad.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCantidad.Location = New Point(346, 340)
        TxtCantidad.Name = "TxtCantidad"
        TxtCantidad.Size = New Size(113, 27)
        TxtCantidad.TabIndex = 3
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.BackColor = Color.LightSteelBlue
        BtnAgregar.FlatAppearance.BorderSize = 0
        BtnAgregar.FlatStyle = FlatStyle.Flat
        BtnAgregar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAgregar.Location = New Point(346, 403)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(113, 29)
        BtnAgregar.TabIndex = 4
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.boton_agregar
        PictureBox3.Location = New Point(323, 403)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 29)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' FrmDetalle
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(471, 461)
        Controls.Add(PictureBox3)
        Controls.Add(BtnAgregar)
        Controls.Add(TxtCantidad)
        Controls.Add(LlbCantidad)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox6)
        Name = "FrmDetalle"
        Text = "FrmDetalle"
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LlbCantidad As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
