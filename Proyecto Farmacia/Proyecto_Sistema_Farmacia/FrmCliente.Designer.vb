<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        BtnCerrar = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        BtnReporte = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(276, 39)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Buscar"
        TextBox1.Size = New Size(206, 27)
        TextBox1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(18, 89)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(745, 324)
        DataGridView1.TabIndex = 1
        ' 
        ' BtnNuevo
        ' 
        BtnNuevo.BackColor = Color.LightSteelBlue
        BtnNuevo.FlatAppearance.BorderSize = 0
        BtnNuevo.FlatStyle = FlatStyle.Flat
        BtnNuevo.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnNuevo.Location = New Point(18, 54)
        BtnNuevo.Name = "BtnNuevo"
        BtnNuevo.Size = New Size(80, 30)
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
        BtnEditar.Location = New Point(104, 54)
        BtnEditar.Name = "BtnEditar"
        BtnEditar.Size = New Size(80, 30)
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
        BtnEliminar.Location = New Point(190, 53)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(80, 30)
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
        BtnBuscar.Location = New Point(520, 39)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(87, 30)
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
        BtnCancelar.Location = New Point(655, 39)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(93, 30)
        BtnCancelar.TabIndex = 6
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.LightSteelBlue
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCerrar.Location = New Point(667, 430)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(96, 29)
        BtnCerrar.TabIndex = 7
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.boton_agregar1
        PictureBox1.Location = New Point(18, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.lapiz
        PictureBox2.Location = New Point(104, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(80, 47)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.borrar
        PictureBox3.Location = New Point(190, 6)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(80, 47)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.lupa1
        PictureBox4.Location = New Point(488, 38)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(39, 31)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.boton_cancelar
        PictureBox5.Location = New Point(625, 39)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(37, 30)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.cerrar_sesion3
        PictureBox6.Location = New Point(635, 430)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(35, 29)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 13
        PictureBox6.TabStop = False
        ' 
        ' BtnReporte
        ' 
        BtnReporte.BackColor = Color.LightSteelBlue
        BtnReporte.FlatAppearance.BorderSize = 0
        BtnReporte.FlatStyle = FlatStyle.Flat
        BtnReporte.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnReporte.Location = New Point(104, 430)
        BtnReporte.Name = "BtnReporte"
        BtnReporte.Size = New Size(80, 29)
        BtnReporte.TabIndex = 14
        BtnReporte.Text = "Reporte"
        BtnReporte.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' FrmCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(787, 471)
        Controls.Add(BtnReporte)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(BtnNuevo)
        Controls.Add(PictureBox1)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnBuscar)
        Controls.Add(BtnEliminar)
        Controls.Add(BtnEditar)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Name = "FrmCliente"
        Text = "FrmCliente"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents BtnReporte As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
