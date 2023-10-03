Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class FrmFactura
    Dim I As Integer
    Dim VALIDACION_FACTURA As Boolean
    Dim VALIDACION_DETALLE As Boolean
    Dim IDD As Integer

    Private Sub FrmFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        VPRECIO = 0
        VIVA = 0
        VTOTAL = 0
        Call BORRAR_TEMPORALDGV()

        ' DESACTIVAR BOTONES
        Me.BtnNuevo.Enabled = True
        Me.BtnCancelar.Enabled = False
        Me.BtnGuardar.Enabled = False
        Me.BtnSalir.Enabled = True
        Me.BtnBuscarCliente.Enabled = False
        Me.BtnAgregar.Enabled = False
        Me.BtnEliminar.Enabled = False

        ' LIMPIAR CAJAS DE TEXTOS
        Me.TxtNumFactura.Text = ""
        Me.TxtFacturaNo.Text = ""
        Me.TxtFecha.Text = ""
        Me.TxtHora.Text = ""
        Me.TxtNombreCliente.Text = ""
        Me.TxtNombreVendedor.Text = ""
        Me.TxtIdCliente.Text = ""
        Me.CmbTipoVenta.Text = ""

        ' DESACTIVAR CAJAS DE TEXTO
        Me.TxtNumFactura.Enabled = False
        Me.TxtFacturaNo.Enabled = False
        Me.TxtFecha.Enabled = False
        Me.TxtHora.Enabled = False
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreVendedor.Enabled = False
        Me.CmbTipoVenta.Enabled = False

        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub BORRAR_TEMPORALDGV()
        Dim DR As SqlDataReader
        Dim ELIMINA_SQL As String
        ELIMINA_SQL = "DELETE FROM DBO.TEMPORALDGV"
        Dim ELIMINA_CMD As New SqlCommand(ELIMINA_SQL, ConeccionBD.CONECCION)
        Try
            ConeccionBD.Abrir_BaseDato()
            DR = ELIMINA_CMD.ExecuteReader
            DR.Close()
        Catch oExcep As SqlException
            If oExcep.ErrorCode = "-2146232060" Then
                MsgBox("El registro no puede ser Eliminado, se encuentra actualmente en uso", MsgBoxStyle.Information, "Mensaje del Sistema")
            Else
                MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
            End If
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub CARGAR_COMBO_BOX_1()
        Dim DS_x As New DataSet
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            Call ConeccionBD.Abrir_BaseDato()
            DA_x = New SqlDataAdapter("Select * from [CAT_TIPO_VENTA] ORDER BY DESCRIPCION", ConeccionBD.CONECCION)
            DS_x.Clear()
            DA_x.Fill(DS_x, "[CAT_TIPO_VENTA]")
            With Me.CmbTipoVenta
                .DataSource = DS_x.Tables("[CAT_TIPO_VENTA]")
                .DisplayMember = "DESCRIPCION"
                .ValueMember = "ID_TIPO_VENTA"
            End With
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub GENERAR_NUMERO_FACTURA()
        Dim VALOR_ACTUAL As Integer
        Dim VALOR_DR As SqlDataReader

        ' Consulta SQL para obtener el valor actual de ID_FACTURA desde la base de datos
        CADENA_SQL = "SELECT * FROM [FACTURAS] ORDER BY ID_FACTURA"
        Dim COMMAND1 As New SqlCommand(CADENA_SQL, ConeccionBD.CONECCION)

        Try
            ConeccionBD.Abrir_BaseDato()
            VALOR_DR = COMMAND1.ExecuteReader
            If (VALOR_DR.HasRows) Then
                While VALOR_DR.Read()
                    VALOR_ACTUAL = VALOR_DR("ID_FACTURA").ToString
                End While
                TxtNumFactura.Text = VALOR_ACTUAL + 1
                TxtFacturaNo.Text = Format(CInt(TxtNumFactura.Text), "000000")
            End If
            If TxtNumFactura.Text = "0" Or TxtNumFactura.Text = "" Then
                TxtNumFactura.Text = 1
                TxtFacturaNo.Text = Format(CInt(TxtNumFactura.Text), "000000")
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Public Sub ARMAR_DATAGRIDVIEW()
        DataGridView.Columns(0).HeaderText = "COD. PRODUCTO"
        DataGridView.Columns(1).HeaderText = "PRODUCTO"
        DataGridView.Columns(2).HeaderText = "PRE. UNI."
        DataGridView.Columns(3).HeaderText = "CANT."
        DataGridView.Columns(0).Visible = True
        DataGridView.Columns(1).Visible = True
        DataGridView.Columns(2).Visible = True
        DataGridView.Columns(3).Visible = True
        DataGridView.Columns(0).Width = 100
        DataGridView.Columns(1).Width = 200
        DataGridView.Columns(2).Width = 100
        DataGridView.Columns(3).Width = 100
    End Sub

    Public Sub CARGAR_DATAGRIDVIEW()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select * from [TEMPORALDGV] ORDER BY ID_PRODUCTO", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "[TEMPORALDGV]")
            DataGridView.DataSource = DS_U.Tables("[TEMPORALDGV]")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub GUARDAR_DETALLE_FACTURA()
        For I = 0 To Me.DataGridView.RowCount - 1
            Me.DataGridView.Rows(I).Selected = True
            Dim Insertar As String
            Dim Cmd_Add As SqlCommand
            Insertar = "Insert Into [DETALLEFACTURA] (ID_FACTURA, ID_PRODUCTO, PRECIO_UNIT, CANTIDAD) values (" & CInt(TxtNumFactura.Text) & " ," & Me.DataGridView.Rows(I).Cells(0).Value & ", " & DataGridView.Rows(I).Cells(2).Value & ", " & DataGridView.Rows(I).Cells(3).Value & ")"


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
        Next I
    End Sub



    Private Sub GUARDAR_FACTURA()
        Dim Insertar As String
        Dim Cmd_Add As SqlCommand
        Insertar = "Insert Into [FACTURAS] (NO_FACTURA, FECHA_FACTURA, HORA_FACTURA, ID_TIPO_VENTA, ID_CLIENTE, ID_EMPLEADO, SUB_TOTAL, IVA, TOTAL) values ('" & TxtFacturaNo.Text & "','" & TxtFecha.Text & "','" & TxtHora.Text & "','" & Me.CmbTipoVenta.SelectedValue & "'," & CInt(TxtIdCliente.Text) & ",'0','" & Val(LblMontoPrecio.Text) & "','" & Val(LblMontoIva.Text) & "','" & Val(LblMontoTotal.Text) & "')"
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

    Private Sub VALIDAR_DETALLE()
        VALIDACION_DETALLE = True
    End Sub

    Private Sub VALIDAR_FACTURA()
        If TxtFacturaNo.Text = "" Then
            MsgBox("Error, no se ha generado el No. de Factura", MsgBoxStyle.Information, "Mensaje")
            VALIDACION_FACTURA = False
            Exit Sub
        End If

        If TxtFecha.Text = "" Then
            MsgBox("Error, no se ha generado la Fecha de la Factura", MsgBoxStyle.Information, "Mensaje")
            VALIDACION_FACTURA = False
            Exit Sub
        End If

        If TxtHora.Text = "" Then
            MsgBox("Error, no se ha generado la Hora de la Factura", MsgBoxStyle.Information, "Mensaje")
            VALIDACION_FACTURA = False
            Exit Sub
        End If

        If CInt(CmbTipoVenta.SelectedValue) = 0 Then
            MsgBox("El Tipo de Venta seleccionado no se encuentra en la lista", MsgBoxStyle.Information, "Mensaje")
            CmbTipoVenta.Focus()
            VALIDACION_FACTURA = False
            Exit Sub
        End If

        If TxtNombreCliente.Text = "" Then
            MsgBox("No ha seleccionado el Nombre y Apellido del Cliente", MsgBoxStyle.Information, "Mensaje del Sistema")
            BtnBuscarCliente.Focus()
            VALIDACION_FACTURA = False
            Exit Sub
        End If

        VALIDACION_FACTURA = True
    End Sub

    Private Sub BORRAR_PRODUCTO_EN_TEMPORAL()
        Dim DR As SqlDataReader
        Dim ELIMINA_SQL As String
        ELIMINA_SQL = "DELETE FROM DBO.TEMPORALDGV WHERE ID_PRODUCTO = '" & CInt(T01) & "'"
        Dim ELIMINA_CMD As New SqlCommand(ELIMINA_SQL, ConeccionBD.CONECCION)
        Try
            ConeccionBD.Abrir_BaseDato()
            DR = ELIMINA_CMD.ExecuteReader
            DR.Close()
        Catch oExcep As SqlException
            If oExcep.ErrorCode = "-2146232060" Then
                MsgBox("El registro no puede ser Eliminado, se encuentra actualmente en uso", MsgBoxStyle.Information, "Mensaje del Sistema")
            Else
                MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
            End If
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub DataGridView_Click(sender As Object, e As System.EventArgs)
        For I = 0 To Me.DataGridView.RowCount - 1
            If Me.DataGridView.Rows(I).Selected = True Then
                T01 = Me.DataGridView.Rows(I).Cells(0).Value
                T02 = Me.DataGridView.Rows(I).Cells(1).Value
                T03 = Me.DataGridView.Rows(I).Cells(2).Value
                T04 = Me.DataGridView.Rows(I).Cells(3).Value
                Exit Sub
            End If
        Next I
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        ' NUEVO
        Me.BtnNuevo.Enabled = False
        Me.BtnCancelar.Enabled = True
        Me.BtnGuardar.Enabled = True
        Me.BtnSalir.Enabled = False
        Me.BtnBuscarCliente.Enabled = True
        Me.BtnAgregar.Enabled = True
        Me.BtnEliminar.Enabled = True
        Me.TxtNumFactura.Text = ""
        Me.TxtFacturaNo.Enabled = False
        Me.TxtFacturaNo.Text = ""
        Me.TxtFecha.Text = Mid(Now, 1, 10)
        Me.TxtHora.Text = Format(Now, "hh:mm:ss")
        Me.CmbTipoVenta.Enabled = True
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreVendedor.Enabled = False
        Call CARGAR_COMBO_BOX_1()
        Call GENERAR_NUMERO_FACTURA()
        Call BORRAR_TEMPORALDGV()
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        If MessageBox.Show("Esta seguro que desea Cancelar la Factura?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Cursor.Current = Cursors.WaitCursor
            ' CANCELAR
            Call BORRAR_TEMPORALDGV()
            Call CARGAR_DATAGRIDVIEW()
            Call ARMAR_DATAGRIDVIEW()
            ' DESACTIVAR BOTONES
            Me.BtnNuevo.Enabled = True
            Me.BtnCancelar.Enabled = False
            Me.BtnGuardar.Enabled = False
            Me.BtnSalir.Enabled = True
            Me.BtnBuscarCliente.Enabled = False
            Me.BtnAgregar.Enabled = False
            Me.BtnEliminar.Enabled = False
            ' LIMPIAR CAJAS DE TEXTOS
            Me.TxtNumFactura.Text = ""
            Me.TxtFacturaNo.Text = ""
            Me.TxtFecha.Text = ""
            Me.TxtHora.Text = ""
            Me.TxtNombreCliente.Text = ""
            Me.TxtNombreVendedor.Text = ""
            Me.TxtIdCliente.Text = ""
            Me.CmbTipoVenta.Text = ""
            ' CARGAR COMBOBOX 1
            Call CARGAR_COMBO_BOX_1()
            ' DESACTIVAR CAJAS DE TEXTO
            Me.TxtNumFactura.Enabled = False
            Me.TxtFacturaNo.Enabled = False
            Me.TxtFecha.Enabled = False
            Me.TxtHora.Enabled = False
            Me.TxtNombreCliente.Enabled = False
            Me.TxtNombreVendedor.Enabled = False
            Me.CmbTipoVenta.Enabled = False
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ' GUARDAR
        ' VALIDAR SI TODOS LOS DATOS DE LA FACTURA ESTAN CORRECTOS
        VALIDACION_FACTURA = False
        Call VALIDAR_FACTURA()
        If VALIDACION_FACTURA = False Then
            Exit Sub
        End If
        ' VALIDAR SI TODOS LOS DATOS DEL DETALLE DE FACTURA ESTAN CORRECTOS
        Call VALIDAR_DETALLE()
        If VALIDACION_DETALLE = False Then
            Exit Sub
        End If
        ' GUARDAR DATOS DE FACTURA
        Call GUARDAR_FACTURA()
        ' GUARDAR DATOS DEL DETALLE DE FACTURA
        Call GUARDAR_DETALLE_FACTURA()
        Call BORRAR_TEMPORALDGV()
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
        ' DESACTIVAR BOTONES
        Me.BtnNuevo.Enabled = True
        Me.BtnCancelar.Enabled = False
        Me.BtnGuardar.Enabled = False
        Me.BtnSalir.Enabled = True
        Me.BtnBuscarCliente.Enabled = False
        Me.BtnAgregar.Enabled = False
        Me.BtnEliminar.Enabled = False
        ' LIMPIAR CAJAS DE TEXTOS
        Me.TxtNumFactura.Text = ""
        Me.TxtFacturaNo.Text = ""
        Me.TxtFecha.Text = ""
        Me.TxtHora.Text = ""
        Me.TxtNombreCliente.Text = ""
        Me.TxtNombreVendedor.Text = ""
        Me.TxtIdCliente.Text = ""
        Me.CmbTipoVenta.Text = ""
        ' CARGAR COMBOBOX 1
        Call CARGAR_COMBO_BOX_1()
        ' DESACTIVAR CAJAS DE TEXTO
        Me.TxtNumFactura.Enabled = False
        Me.TxtFacturaNo.Enabled = False
        Me.TxtFecha.Enabled = False
        Me.TxtHora.Enabled = False
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreVendedor.Enabled = False
        Me.CmbTipoVenta.Enabled = False
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        ' SALIR
        Call BORRAR_TEMPORALDGV()
        Me.Close()
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        FrmCliente.ShowDialog()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' AGREGAR
        FrmDetalle.ShowDialog()
        Me.LblMontoPrecio.Text = Val(Me.LblMontoPrecio.Text) + VPRECIO
        Me.LblMontoIva.Text = Val(Me.LblMontoIva.Text) + VIVA
        Me.LblMontoTotal.Text = Val(Me.LblMontoTotal.Text) + VTOTAL
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' ELIMINAR
        If MessageBox.Show("Esta seguro que desea Eliminar el Producto seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Cursor.Current = Cursors.WaitCursor
            ' ELIMINAR
            VPRECIO = Val(T03) * Val(T04)
            VIVA = Val(VPRECIO) * 0.15
            VTOTAL = Val(VPRECIO) - Val(VIVA)
            Me.LblMontoPrecio.Text = Val(Me.LblMontoPrecio.Text) - VPRECIO
            Me.LblMontoIva.Text = Val(Me.LblMontoIva.Text) - VIVA
            Me.LblMontoTotal.Text = Val(Me.LblMontoTotal.Text) - VTOTAL
            Call BORRAR_PRODUCTO_EN_TEMPORAL()
            Call CARGAR_DATAGRIDVIEW()
            Call ARMAR_DATAGRIDVIEW()
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' NUEVO
        Me.BtnNuevo.Enabled = False
        Me.BtnCancelar.Enabled = True
        Me.BtnGuardar.Enabled = True
        Me.BtnSalir.Enabled = False
        Me.BtnBuscarCliente.Enabled = True
        Me.BtnAgregar.Enabled = True
        Me.BtnEliminar.Enabled = True
        Me.TxtNumFactura.Text = ""
        Me.TxtFacturaNo.Enabled = False
        Me.TxtFacturaNo.Text = ""
        Me.TxtFecha.Text = Mid(Now, 1, 10)
        Me.TxtHora.Text = Format(Now, "hh:mm:ss")
        Me.CmbTipoVenta.Enabled = True
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreVendedor.Enabled = False
        Call CARGAR_COMBO_BOX_1()
        Call GENERAR_NUMERO_FACTURA()
        Call BORRAR_TEMPORALDGV()
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MessageBox.Show("Esta seguro que desea Cancelar la Factura?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Cursor.Current = Cursors.WaitCursor
            ' CANCELAR
            Call BORRAR_TEMPORALDGV()
            Call CARGAR_DATAGRIDVIEW()
            Call ARMAR_DATAGRIDVIEW()
            ' DESACTIVAR BOTONES
            Me.BtnNuevo.Enabled = True
            Me.BtnCancelar.Enabled = False
            Me.BtnGuardar.Enabled = False
            Me.BtnSalir.Enabled = True
            Me.BtnBuscarCliente.Enabled = False
            Me.BtnAgregar.Enabled = False
            Me.BtnEliminar.Enabled = False
            ' LIMPIAR CAJAS DE TEXTOS
            Me.TxtNumFactura.Text = ""
            Me.TxtFacturaNo.Text = ""
            Me.TxtFecha.Text = ""
            Me.TxtHora.Text = ""
            Me.TxtNombreCliente.Text = ""
            Me.TxtNombreVendedor.Text = ""
            Me.TxtIdCliente.Text = ""
            Me.CmbTipoVenta.Text = ""
            ' CARGAR COMBOBOX 1
            Call CARGAR_COMBO_BOX_1()
            ' DESACTIVAR CAJAS DE TEXTO
            Me.TxtNumFactura.Enabled = False
            Me.TxtFacturaNo.Enabled = False
            Me.TxtFecha.Enabled = False
            Me.TxtHora.Enabled = False
            Me.TxtNombreCliente.Enabled = False
            Me.TxtNombreVendedor.Enabled = False
            Me.CmbTipoVenta.Enabled = False
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ' GUARDAR
        ' VALIDAR SI TODOS LOS DATOS DE LA FACTURA ESTAN CORRECTOS
        VALIDACION_FACTURA = False
        Call VALIDAR_FACTURA()
        If VALIDACION_FACTURA = False Then
            Exit Sub
        End If
        ' VALIDAR SI TODOS LOS DATOS DEL DETALLE DE FACTURA ESTAN CORRECTOS
        Call VALIDAR_DETALLE()
        If VALIDACION_DETALLE = False Then
            Exit Sub
        End If
        ' GUARDAR DATOS DE FACTURA
        Call GUARDAR_FACTURA()
        ' GUARDAR DATOS DEL DETALLE DE FACTURA
        Call GUARDAR_DETALLE_FACTURA()
        Call BORRAR_TEMPORALDGV()
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
        ' DESACTIVAR BOTONES
        Me.BtnNuevo.Enabled = True
        Me.BtnCancelar.Enabled = False
        Me.BtnGuardar.Enabled = False
        Me.BtnSalir.Enabled = True
        Me.BtnBuscarCliente.Enabled = False
        Me.BtnAgregar.Enabled = False
        Me.BtnEliminar.Enabled = False
        ' LIMPIAR CAJAS DE TEXTOS
        Me.TxtNumFactura.Text = ""
        Me.TxtFacturaNo.Text = ""
        Me.TxtFecha.Text = ""
        Me.TxtHora.Text = ""
        Me.TxtNombreCliente.Text = ""
        Me.TxtNombreVendedor.Text = ""
        Me.TxtIdCliente.Text = ""
        Me.CmbTipoVenta.Text = ""
        ' CARGAR COMBOBOX 1
        Call CARGAR_COMBO_BOX_1()
        ' DESACTIVAR CAJAS DE TEXTO
        Me.TxtNumFactura.Enabled = False
        Me.TxtFacturaNo.Enabled = False
        Me.TxtFecha.Enabled = False
        Me.TxtHora.Enabled = False
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreVendedor.Enabled = False
        Me.CmbTipoVenta.Enabled = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ' SALIR
        Call BORRAR_TEMPORALDGV()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ' AGREGAR
        FrmDetalle.ShowDialog()
        Me.LblMontoPrecio.Text = Val(Me.LblMontoPrecio.Text) + VPRECIO
        Me.LblMontoIva.Text = Val(Me.LblMontoIva.Text) + VIVA
        Me.LblMontoTotal.Text = Val(Me.LblMontoTotal.Text) + VTOTAL
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ' ELIMINAR
        If MessageBox.Show("Esta seguro que desea Eliminar el Producto seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Cursor.Current = Cursors.WaitCursor
            ' ELIMINAR
            VPRECIO = Val(T03) * Val(T04)
            VIVA = Val(VPRECIO) * 0.15
            VTOTAL = Val(VPRECIO) - Val(VIVA)
            Me.LblMontoPrecio.Text = Val(Me.LblMontoPrecio.Text) - VPRECIO
            Me.LblMontoIva.Text = Val(Me.LblMontoIva.Text) - VIVA
            Me.LblMontoTotal.Text = Val(Me.LblMontoTotal.Text) - VTOTAL
            Call BORRAR_PRODUCTO_EN_TEMPORAL()
            Call CARGAR_DATAGRIDVIEW()
            Call ARMAR_DATAGRIDVIEW()
        End If
        Cursor.Current = Cursors.Default
    End Sub
End Class
