Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class VisualizarCategorias

    Dim I As Integer
    Private Sub VisualizarCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        CARGAR_DATAGRIDVIEW()
        ARMAR_DATAGRIDVIEW()
        BOTONES()

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        For I = 0 To Me.DataGridView1.RowCount - 1
            If Me.DataGridView1.Rows(I).Selected = True Then
                P01 = Me.DataGridView1.Rows(I).Cells(0).Value
                P02 = Me.DataGridView1.Rows(I).Cells(1).Value
                P03 = Me.DataGridView1.Rows(I).Cells(2).Value
                P04 = Me.DataGridView1.Rows(I).Cells(3).Value
                P05 = Me.DataGridView1.Rows(I).Cells(4).Value
                P06 = Me.DataGridView1.Rows(I).Cells(5).Value
                P07 = Me.DataGridView1.Rows(I).Cells(6).Value
                P08 = Me.DataGridView1.Rows(I).Cells(7).Value
                Exit Sub
            End If
        Next I
    End Sub

    Public Sub ARMAR_DATAGRIDVIEW()
        DataGridView1.Columns(0).HeaderText = "ID CATEGORIA"
        DataGridView1.Columns(1).HeaderText = "CATEGORIA"
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(1).Width = 180
    End Sub

    Public Sub CARGAR_DATAGRIDVIEW()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select * from CATEGORIAS ORDER BY DESCATEGORIA", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "CATEGORIAS")
            DataGridView1.DataSource = DS_U.Tables("CATEGORIAS")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " &
                            ControlChars.CrLf &
                            oExcep.Message & ControlChars.CrLf &
                            oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Public Sub BOTONES()
        Dim dt_B As DataTable
        Dim DA_P As SqlDataAdapter
        Dim DS_P As New DataSet
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            DA_P = New SqlDataAdapter("select * from CATEGORIAS ORDER BY DESCATEGORIA", ConeccionBD.CONECCION)
            DA_P.Fill(DS_P, "CATEGORIAS")
            Dim cb As New SqlCommandBuilder(DA_P)
            dt_B = New DataTable
            DA_P.Fill(dt_B)
            If dt_B.Rows.Count > 0 Then
                BtnNuevo.Enabled = True
                BtnEditar.Enabled = True
                BtnEliminar.Enabled = True
                TextBox1.Enabled = True
                BtnBuscar.Enabled = True
                BtnCancelar.Enabled = True
            Else
                BtnNuevo.Enabled = True
                BtnEditar.Enabled = False
                BtnEliminar.Enabled = False
                TextBox1.Enabled = False
                BtnBuscar.Enabled = False
                BtnCancelar.Enabled = False
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " &
                            ControlChars.CrLf &
                            oExcep.Message & ControlChars.CrLf &
                            oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub CARGAR()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select * from CATEGORIAS WHERE DESCATEGORIA like '%" & TextBox1.Text & "%' ORDER BY DESCATEGORIA", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "CATEGORIAS")
            DataGridView1.DataSource = DS_U.Tables("CATEGORIAS")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " &
                            ControlChars.CrLf &
                            oExcep.Message & ControlChars.CrLf &
                            oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        FrmCategoria.ShowDialog()
        If CANCELAR_A_E = True Then
            CARGAR_DATAGRIDVIEW()
            ARMAR_DATAGRIDVIEW()
            BOTONES()
        End If
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CARGAR()
        ARMAR_DATAGRIDVIEW()
        BOTONES()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TextBox1.Text = ""
        CARGAR_DATAGRIDVIEW()
        ARMAR_DATAGRIDVIEW()
        BOTONES()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Create an instance of FrmEditarCliente
            Dim editarForm As New FrmEditarCategorias

            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Populate the text boxes on FrmEditarCliente with data from the selected row
            editarForm.TxtIdCategoria.Text = selectedRow.Cells("IDCATEGORIA").Value.ToString()

            ' Show FrmEditarCliente
            editarForm.ShowDialog()

            ' Check if any changes were made in FrmEditarCliente and handle them if necessary
            If CANCELAR_A_E = True Then
                Call CARGAR_DATAGRIDVIEW()
                Call ARMAR_DATAGRIDVIEW()
                Call BOTONES()
            End If
        Else
            MsgBox("Debe seleccionar el registro que desea Editar", MsgBoxStyle.Information, "Mensaje del Sistema")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar el registro que desea Eliminar",
                   MsgBoxStyle.Information, "Mensaje del Sistema")
            DataGridView1.Focus()
            P01 = "" : P02 = ""
            Exit Sub
        End If

        ' Ask for confirmation before deletion
        Dim R As DialogResult
        R = MessageBox.Show("Se dispone a Eliminar este registro de Categoria, ¿Desea continuar?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If R = DialogResult.Yes Then
            ' Get the ID_PRODUCTO (assuming it's in the first column) of the selected row
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim P01 As String = DataGridView1.Rows(selectedRowIndex).Cells(0).Value.ToString()

            ' Build and execute the SQL DELETE statement
            Dim ELIMINA_SQL As String = "DELETE FROM DBO.CATEGORIAS WHERE IDCATEGORIA = '" & P01 & "'"

            Try
                ConeccionBD.Abrir_BaseDato()
                Dim ELIMINA_CMD As New SqlCommand(ELIMINA_SQL, ConeccionBD.CONECCION)
                ELIMINA_CMD.ExecuteNonQuery()
                TextBox1.Text = ""
                CARGAR_DATAGRIDVIEW()
                ARMAR_DATAGRIDVIEW()
                BOTONES()
                P01 = "" : P02 = ""
            Catch oExcep As SqlException
                If oExcep.ErrorCode = "-2146232060" Then
                    MsgBox("El registro no puede ser Eliminado, se encuentra actualmente en uso",
                           MsgBoxStyle.Information, "Mensaje del Sistema")
                Else
                    MessageBox.Show("Error: " & ControlChars.CrLf &
                                    oExcep.Message & ControlChars.CrLf &
                                    oExcep.Server)
                End If
            Finally
                If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                    ConeccionBD.Cerrar_BaseDato()
                End If
            End Try
        Else
            P01 = "" : P02 = ""
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmCategoria.ShowDialog()
        If CANCELAR_A_E = True Then
            CARGAR_DATAGRIDVIEW()
            ARMAR_DATAGRIDVIEW()
            BOTONES()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Create an instance of FrmEditarCliente
            Dim editarForm As New FrmEditarCategorias

            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Populate the text boxes on FrmEditarCliente with data from the selected row
            editarForm.TxtIdCategoria.Text = selectedRow.Cells("IDCATEGORIA").Value.ToString()

            ' Show FrmEditarCliente
            editarForm.ShowDialog()

            ' Check if any changes were made in FrmEditarCliente and handle them if necessary
            If CANCELAR_A_E = True Then
                Call CARGAR_DATAGRIDVIEW()
                Call ARMAR_DATAGRIDVIEW()
                Call BOTONES()
            End If
        Else
            MsgBox("Debe seleccionar el registro que desea Editar", MsgBoxStyle.Information, "Mensaje del Sistema")
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar el registro que desea Eliminar",
                   MsgBoxStyle.Information, "Mensaje del Sistema")
            DataGridView1.Focus()
            P01 = "" : P02 = ""
            Exit Sub
        End If

        ' Ask for confirmation before deletion
        Dim R As DialogResult
        R = MessageBox.Show("Se dispone a Eliminar este registro de Categoria, ¿Desea continuar?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If R = DialogResult.Yes Then
            ' Get the ID_PRODUCTO (assuming it's in the first column) of the selected row
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim P01 As String = DataGridView1.Rows(selectedRowIndex).Cells(0).Value.ToString()

            ' Build and execute the SQL DELETE statement
            Dim ELIMINA_SQL As String = "DELETE FROM DBO.CATEGORIAS WHERE IDCATEGORIA = '" & P01 & "'"

            Try
                ConeccionBD.Abrir_BaseDato()
                Dim ELIMINA_CMD As New SqlCommand(ELIMINA_SQL, ConeccionBD.CONECCION)
                ELIMINA_CMD.ExecuteNonQuery()
                TextBox1.Text = ""
                CARGAR_DATAGRIDVIEW()
                ARMAR_DATAGRIDVIEW()
                BOTONES()
                P01 = "" : P02 = ""
            Catch oExcep As SqlException
                If oExcep.ErrorCode = "-2146232060" Then
                    MsgBox("El registro no puede ser Eliminado, se encuentra actualmente en uso",
                           MsgBoxStyle.Information, "Mensaje del Sistema")
                Else
                    MessageBox.Show("Error: " & ControlChars.CrLf &
                                    oExcep.Message & ControlChars.CrLf &
                                    oExcep.Server)
                End If
            Finally
                If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                    ConeccionBD.Cerrar_BaseDato()
                End If
            End Try
        Else
            P01 = "" : P02 = ""
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        CARGAR()
        ARMAR_DATAGRIDVIEW()
        BOTONES()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TextBox1.Text = ""
        CARGAR_DATAGRIDVIEW()
        ARMAR_DATAGRIDVIEW()
        BOTONES()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub
End Class
