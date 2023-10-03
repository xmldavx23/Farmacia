<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        BtnNuevo = New Button()
        BtnEditar = New Button()
        BtnEliminar = New Button()
        BtnBuscar = New Button()
        BtnCancelar = New Button()
        Button8 = New Button()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        BtnReporte = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(357, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(2, 100)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(823, 305)
        DataGridView1.TabIndex = 1
        ' 
        ' BtnNuevo
        ' 
        BtnNuevo.BackColor = Color.LightSteelBlue
        BtnNuevo.FlatAppearance.BorderSize = 0
        BtnNuevo.FlatStyle = FlatStyle.Flat
        BtnNuevo.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnNuevo.Location = New Point(40, 65)
        BtnNuevo.Name = "BtnNuevo"
        BtnNuevo.Size = New Size(80, 29)
        BtnNuevo.TabIndex = 2
        BtnNuevo.Text = "Nuevo"
        BtnNuevo.UseVisualStyleBackColor = False
        ' 
        ' BtnEditar
        ' 
        BtnEditar.BackColor = Color.LightSteelBlue
        BtnEditar.FlatAppearance.BorderSize = 0
        BtnEditar.FlatStyle = FlatStyle.Flat
        BtnEditar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnEditar.Location = New Point(126, 65)
        BtnEditar.Name = "BtnEditar"
        BtnEditar.Size = New Size(80, 29)
        BtnEditar.TabIndex = 3
        BtnEditar.Text = "Editar"
        BtnEditar.UseVisualStyleBackColor = False
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = Color.LightSteelBlue
        BtnEliminar.FlatAppearance.BorderSize = 0
        BtnEliminar.FlatStyle = FlatStyle.Flat
        BtnEliminar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnEliminar.Location = New Point(212, 65)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(80, 29)
        BtnEliminar.TabIndex = 4
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackColor = Color.LightSteelBlue
        BtnBuscar.FlatAppearance.BorderSize = 0
        BtnBuscar.FlatStyle = FlatStyle.Flat
        BtnBuscar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBuscar.Location = New Point(538, 48)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(106, 29)
        BtnBuscar.TabIndex = 5
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.LightSteelBlue
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCancelar.Location = New Point(713, 48)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(99, 29)
        BtnCancelar.TabIndex = 6
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.LightSteelBlue
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button8.Location = New Point(713, 413)
        Button8.Name = "Button8"
        Button8.Size = New Size(99, 29)
        Button8.TabIndex = 7
        Button8.Text = "Cerrar"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.borrar
        PictureBox3.Location = New Point(212, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(80, 47)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.lapiz
        PictureBox2.Location = New Point(126, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(80, 47)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.boton_agregar1
        PictureBox1.Location = New Point(40, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.lupa1
        PictureBox4.Location = New Point(502, 48)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(42, 29)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 14
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.boton_cancelar
        PictureBox5.Location = New Point(674, 48)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(42, 30)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 15
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.cerrar_sesion3
        PictureBox6.Location = New Point(674, 411)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(42, 31)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 16
        PictureBox6.TabStop = False
        ' 
        ' BtnReporte
        ' 
        BtnReporte.BackColor = Color.LightSteelBlue
        BtnReporte.FlatAppearance.BorderSize = 0
        BtnReporte.FlatStyle = FlatStyle.Flat
        BtnReporte.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnReporte.Location = New Point(126, 413)
        BtnReporte.Name = "BtnReporte"
        BtnReporte.Size = New Size(80, 29)
        BtnReporte.TabIndex = 17
        BtnReporte.Text = "Reporte"
        BtnReporte.UseVisualStyleBackColor = False
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(824, 450)
        Controls.Add(BtnReporte)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button8)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnBuscar)
        Controls.Add(BtnEliminar)
        Controls.Add(BtnEditar)
        Controls.Add(BtnNuevo)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Name = "FrmProductos"
        Text = "FrmProductos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents BtnReporte As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
