<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consulta_Facturas
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
        GroupBox1 = New GroupBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        BtnCerrar = New Button()
        BtnCancelar = New Button()
        BtnBuscar = New Button()
        TxtNombreCliente = New TextBox()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        BtnReporte = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        GroupBox1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox3)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(BtnCerrar)
        GroupBox1.Controls.Add(BtnCancelar)
        GroupBox1.Controls.Add(BtnBuscar)
        GroupBox1.Controls.Add(TxtNombreCliente)
        GroupBox1.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.LightSlateGray
        GroupBox1.Location = New Point(24, 12)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(837, 89)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Buscar por Nombres y Apellidos del Cliente"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.cerrar_sesion1
        PictureBox3.Location = New Point(696, 28)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(42, 33)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.boton_cancelar
        PictureBox2.Location = New Point(557, 27)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(41, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.lupa
        PictureBox1.Location = New Point(411, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSlateGray
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.ForeColor = SystemColors.ButtonHighlight
        BtnCerrar.Location = New Point(738, 27)
        BtnCerrar.Margin = New Padding(3, 4, 3, 4)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(93, 33)
        BtnCerrar.TabIndex = 3
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.LightSlateGray
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.ForeColor = SystemColors.ButtonHighlight
        BtnCancelar.Location = New Point(593, 28)
        BtnCancelar.Margin = New Padding(3, 4, 3, 4)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(97, 33)
        BtnCancelar.TabIndex = 2
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackColor = Color.LightSlateGray
        BtnBuscar.FlatAppearance.BorderSize = 0
        BtnBuscar.FlatStyle = FlatStyle.Flat
        BtnBuscar.ForeColor = SystemColors.ButtonHighlight
        BtnBuscar.Location = New Point(445, 28)
        BtnBuscar.Margin = New Padding(3, 4, 3, 4)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(98, 33)
        BtnBuscar.TabIndex = 1
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = False
        ' 
        ' TxtNombreCliente
        ' 
        TxtNombreCliente.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNombreCliente.Location = New Point(6, 33)
        TxtNombreCliente.Margin = New Padding(3, 4, 3, 4)
        TxtNombreCliente.Name = "TxtNombreCliente"
        TxtNombreCliente.PlaceholderText = "Buscar"
        TxtNombreCliente.Size = New Size(390, 27)
        TxtNombreCliente.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(27, 116)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(827, 289)
        DataGridView1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(25, 418)
        Label1.Name = "Label1"
        Label1.Size = New Size(561, 20)
        Label1.TabIndex = 2
        Label1.Text = "Haga doble click sobre el registro que desea visualizar los detalles de Factura"
        ' 
        ' BtnReporte
        ' 
        BtnReporte.BackColor = Color.LightSlateGray
        BtnReporte.FlatAppearance.BorderSize = 0
        BtnReporte.FlatStyle = FlatStyle.Flat
        BtnReporte.ForeColor = SystemColors.ButtonHighlight
        BtnReporte.Location = New Point(768, 412)
        BtnReporte.Margin = New Padding(3, 4, 3, 4)
        BtnReporte.Name = "BtnReporte"
        BtnReporte.Size = New Size(93, 33)
        BtnReporte.TabIndex = 4
        BtnReporte.Text = "Reporte"
        BtnReporte.UseVisualStyleBackColor = False
        ' 
        ' Frm_Consulta_Facturas
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 449)
        Controls.Add(BtnReporte)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Frm_Consulta_Facturas"
        Text = "Frm_Consulta_Facturas"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnReporte As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
