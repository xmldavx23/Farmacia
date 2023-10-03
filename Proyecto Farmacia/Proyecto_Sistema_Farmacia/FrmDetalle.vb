Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmDetalle

    Dim I As Integer
    Dim Cantidad As Integer

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        ' Llamar a CARGAR_DATAGRIDVIEW y ARMAR_DATAGRIDVIEW
        TxtBuscar.Text = ""
        CARGAR_DATAGRIDVIEW()
        ARMAR_DATAGRIDVIEW()
    End Sub

    ' Procedimiento para cargar los datos de la tabla Productos
    Private Sub CARGAR()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select ID_PRODUCTO, DES_PRODUCTO, PRECIO_UNIT from PRODUCTOS WHERE DES_PRODUCTO like '%" & TxtBuscar.Text & "%' ORDER BY DES_PRODUCTO", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "PRODUCTOS")
            DataGridView1.DataSource = DS_U.Tables("PRODUCTOS")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    ' Procedimiento ARMAR_DATAGRIDVIEW
    Public Sub ARMAR_DATAGRIDVIEW()
        DataGridView1.Columns(0).HeaderText = "IDPRODUCTO"
        DataGridView1.Columns(1).HeaderText = "DESCRIPCION"
        DataGridView1.Columns(2).HeaderText = "PRE. UNI."
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 80
    End Sub

    ' Procedimiento CARGAR_DATAGRIDVIEW
    Public Sub CARGAR_DATAGRIDVIEW()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select ID_PRODUCTO, DES_PRODUCTO, PRECIO_UNIT from PRODUCTOS ORDER BY DES_PRODUCTO", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "PRODUCTOS")
            DataGridView1.DataSource = DS_U.Tables("PRODUCTOS")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub FrmDetalle_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            D01 = ""
            D02 = ""
            D03 = ""
            Me.Close()
        End If
    End Sub

    Private Sub FrmDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtBuscar.Text = ""
        Me.TxtCantidad.Text = ""
        CARGAR_DATAGRIDVIEW()
        ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If D01 = "" Then
            MsgBox("Debe seleccionar el Producto", MsgBoxStyle.Information, "Mensaje")
            Me.DataGridView1.Focus()
            Exit Sub
        End If
        If TxtCantidad.Text = "" Then
            MsgBox("Debe digitar la cantidad de Productos", MsgBoxStyle.Information, "Mensaje")
            TxtCantidad.Focus()
            Exit Sub
        End If
        VPRECIO = Val(D03) * Val(TxtCantidad.Text)
        VIVA = Val(VPRECIO) * 0.15
        VTOTAL = Val(VPRECIO) + Val(VIVA)
        INSERTARDATOSDGV()
        Me.Close()
    End Sub

    Private Sub INSERTARDATOSDGV()
        Dim Insertar As String
        Dim Cmd_Add As SqlCommand
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Insertar = "Insert Into DBO.TEMPORALDGV (ID_PRODUCTO, DES_PRODUCTO, PRECIO_UNIT, CANTIDAD)values('" & D01 & "','" & D02 & "','" & D03 & "','" & (Me.TxtCantidad.Text) & "')"
        Try
            Call ConeccionBD.Abrir_BaseDato()
            Cmd_Add = New SqlCommand(Insertar, ConeccionBD.CONECCION)
            Cmd_Add.ExecuteNonQuery()
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        For I = 0 To Me.DataGridView1.RowCount - 1
            If Me.DataGridView1.Rows(I).Selected = True Then
                D01 = Me.DataGridView1.Rows(I).Cells(0).Value
                D02 = Me.DataGridView1.Rows(I).Cells(1).Value
                D03 = Me.DataGridView1.Rows(I).Cells(2).Value
                Exit Sub
            End If
        Next I
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Call CARGAR()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call CARGAR()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Llamar a CARGAR_DATAGRIDVIEW y ARMAR_DATAGRIDVIEW
        TxtBuscar.Text = ""
        CARGAR_DATAGRIDVIEW()
        ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If D01 = "" Then
            MsgBox("Debe seleccionar el Producto", MsgBoxStyle.Information, "Mensaje")
            Me.DataGridView1.Focus()
            Exit Sub
        End If
        If TxtCantidad.Text = "" Then
            MsgBox("Debe digitar la cantidad de Productos", MsgBoxStyle.Information, "Mensaje")
            TxtCantidad.Focus()
            Exit Sub
        End If
        VPRECIO = Val(D03) * Val(TxtCantidad.Text)
        VIVA = Val(VPRECIO) * 0.15
        VTOTAL = Val(VPRECIO) + Val(VIVA)
        INSERTARDATOSDGV()
        Me.Close()
    End Sub
End Class