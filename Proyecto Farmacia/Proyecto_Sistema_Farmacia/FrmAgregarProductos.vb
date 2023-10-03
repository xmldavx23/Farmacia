Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmAgregarProductos
    Dim EXISTE_PRODUCTO As Boolean
    Private categoriaadapter As New SqlDataAdapter
    Private proveedoradapter As New SqlDataAdapter
    Private posicion As Integer
    Private posicionCB As Integer
    Dim categoriadataset As New DataSet
    Dim proveedordataset As New DataSet

    Private Sub BUSCAR_SI_YA_EXISTE_PRODUCTO()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("select * from DBO.PRODUCTOS WHERE DES_PRODUCTO = '" & TextBox1.Text & "'  ORDER BY DES_PRODUCTO", ConeccionBD.CONECCION)
            drbuscar = cmbuscar.ExecuteReader

            If drbuscar.HasRows Then
                While drbuscar.Read
                    If UCase(drbuscar("Facturacion_Farmacia").ToString) = UCase(Me.TxtDescripcion.Text) Then
                        EXISTE_PRODUCTO = True
                    Else
                        EXISTE_PRODUCTO = False
                    End If
                End While
            Else
                EXISTE_PRODUCTO = False
            End If

            drbuscar.Close()
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub



    Private Sub FrmAgregarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        posicion = 0
        Me.CargaDatos()
    End Sub

    Private Sub CargaDatos()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            Dim categoriadatarow As DataRow
            Dim proveedordatarow As DataRow

            Me.categoriaadapter = New SqlDataAdapter("Select * from CATEGORIAS", ConeccionBD.CONECCION)
            Me.proveedoradapter = New SqlDataAdapter("Select * from PROVEEDORES", ConeccionBD.CONECCION)

            categoriadataset.Clear()
            proveedordataset.Clear()

            Me.categoriaadapter.Fill(categoriadataset, "CATEGORIAS")
            Me.proveedoradapter.Fill(proveedordataset, "PROVEEDORES")

            posicionCB = 0
            categoriadatarow = Me.categoriadataset.Tables("CATEGORIAS").Rows(posicionCB)
            proveedordatarow = Me.proveedordataset.Tables("PROVEEDORES").Rows(posicionCB)

            Dim dt As DataTable = categoriadataset.Tables(0)
            Dim dt2 As DataTable = proveedordataset.Tables(0)

            Me.CbCategoria.DataSource = categoriadataset.Tables("CATEGORIAS")
            Me.CbCategoria.DisplayMember = "DESCATEGORIA"
            Me.CbCategoria.ValueMember = "IDCATEGORIA"

            Me.CbProveedor.DataSource = proveedordataset.Tables("PROVEEDORES")
            Me.CbProveedor.DisplayMember = "NOMBREPROVEEDOR"
            Me.CbProveedor.ValueMember = "IDPROVEEDOR"
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub ChkDescontinuado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ChkDescontinuado.Checked Then
            Me.TxtDescontinuado.Text = True
        Else
            Me.TxtDescontinuado.Text = True
        End If
    End Sub

    Private Sub BtnAceptar_Click_1(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Me.TxtDescripcion.Text = "" Then
            MsgBox("Debe digitar la descripcion del producto que desea agregar", MsgBoxStyle.Information, "Mensaje del Sistema")
            TxtDescripcion.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_PRODUCTO()
        If EXISTE_PRODUCTO = True Then
            MsgBox("Este Producto ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            TextBox1.Focus()
            Exit Sub
        End If


        Dim Insertar As String
        Dim Cmd_Add As SqlCommand

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Insertar = "Insert Into DBO.PRODUCTOS ( DES_PRODUCTO, ID_CATEGORIA, ID_PROVEEDOR, CANT_X_PRESENTACION, PRECIO_UNIT, UNIDADES_INV, DESCONTINUADO) values ('" & UCase(Me.TxtDescripcion.Text) & "','" & (Me.CbCategoria.SelectedValue) & "','" & (Me.CbProveedor.SelectedValue) & "', '" & UCase(Me.TxtCantidad.Text) & "','" & UCase(Me.TxtPrecio.Text) & "', '" & UCase(Me.TxtUnidadesInv.Text) & "', '" & UCase(Me.TxtDescontinuado.Text) & "')"

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

        CANCELAR_A_E = True
        Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        CANCELAR_A_E = False
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.TxtDescripcion.Text = "" Then
            MsgBox("Debe digitar la descripcion del producto que desea agregar", MsgBoxStyle.Information, "Mensaje del Sistema")
            TxtDescripcion.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_PRODUCTO()
        If EXISTE_PRODUCTO = True Then
            MsgBox("Este Producto ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            TextBox1.Focus()
            Exit Sub
        End If


        Dim Insertar As String
        Dim Cmd_Add As SqlCommand

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Insertar = "Insert Into DBO.PRODUCTOS ( DES_PRODUCTO, ID_CATEGORIA, ID_PROVEEDOR, CANT_X_PRESENTACION, PRECIO_UNIT, UNIDADES_INV, DESCONTINUADO) values ('" & UCase(Me.TxtDescripcion.Text) & "','" & (Me.CbCategoria.SelectedValue) & "','" & (Me.CbProveedor.SelectedValue) & "', '" & UCase(Me.TxtCantidad.Text) & "','" & UCase(Me.TxtPrecio.Text) & "', '" & UCase(Me.TxtUnidadesInv.Text) & "', '" & UCase(Me.TxtDescontinuado.Text) & "')"

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

        CANCELAR_A_E = True
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CANCELAR_A_E = False
        Me.Close()
    End Sub
End Class
