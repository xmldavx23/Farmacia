Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmEditarProductos

    Private categoriaadapter As New SqlDataAdapter
    Private proveedoradapter As New SqlDataAdapter
    Private posicion As Integer
    Private posicionCB As Integer
    Dim categoriadataset As New DataSet
    Dim proveedordataset As New DataSet
    Private Sub UpdateData()
        ' Obtener el estado del CheckBox
        Dim descontinuado As Boolean = ChkDescontinuado.Checked

        ' Obtener los valores de los controles
        Dim categoriaId As Integer = CbCategoria.SelectedValue
        Dim proveedorId As Integer = CbProveedor.SelectedValue
        Dim cantidad As Integer = Integer.Parse(TxtCantidad.Text)
        Dim precio As Decimal = Decimal.Parse(TxtPrecio.Text)
        Dim unidadesInv As Integer = Integer.Parse(TxtUnidadesInv.Text)
        Dim productoId As Integer = Integer.Parse(TxtIdProducto.Text)

        ' Crear la instrucción SQL UPDATE
        Dim updateSql As String = "UPDATE Productos SET Id_Categoria = @CategoriaId, Id_Proveedor = @ProveedorId, CANT_X_PRESENTACION = @Cantidad, Precio_UNIT = @Precio, UNIDADES_INV = @UnidadesInv, Descontinuado = @Descontinuado WHERE Id_Producto = @ProductoId"

        ' Crear un SqlCommand
        Dim Cmd_Update As SqlCommand

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            Call ConeccionBD.Abrir_BaseDato()

            ' Inicializar el SqlCommand
            Cmd_Update = New SqlCommand(updateSql, ConeccionBD.CONECCION)

            ' Agregar parámetros al SqlCommand
            Cmd_Update.Parameters.AddWithValue("@CategoriaId", categoriaId)
            Cmd_Update.Parameters.AddWithValue("@ProveedorId", proveedorId)
            Cmd_Update.Parameters.AddWithValue("@Cantidad", cantidad)
            Cmd_Update.Parameters.AddWithValue("@Precio", precio)
            Cmd_Update.Parameters.AddWithValue("@UnidadesInv", unidadesInv)
            Cmd_Update.Parameters.AddWithValue("@ProductoId", productoId)
            Cmd_Update.Parameters.AddWithValue("@Descontinuado", descontinuado) ' Usar el estado del CheckBox

            ' Ejecutar el comando UPDATE
            Cmd_Update.ExecuteNonQuery()

            ' Indicar que la actualización fue exitosa (puedes utilizar un DialogResult o establecer una bandera)
            Me.DialogResult = DialogResult.OK
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ' Llama a la función UpdateData para actualizar la base de datos
        UpdateData()

        ' Cierra el formulario después de actualizar
        Me.Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        ' Puedes agregar cualquier lógica de cierre que necesites
        Me.Close()
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
    Private Sub FrmEditarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtIdProducto.ReadOnly = True
        TxtDescripcion.ReadOnly = True
        Me.CargaDatos()
    End Sub

    Private Sub ChkDescontinuado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ChkDescontinuado.Checked Then
            Me.TxtDescontinuado.Text = True
        Else
            Me.TxtDescontinuado.Text = True
        End If
    End Sub
End Class