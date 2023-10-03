Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmAgregarClientes
    Dim EXISTE_PERSONA As Boolean

    Private Sub TxtCedula_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Len(Me.TxtCedula.Text) = 0 Then
            Me.TxtCedula.Text = "00000000000000"
        End If
    End Sub

    Private Sub TxtTelefono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Len(Me.TxtTelefono.Text) = 0 Then
            Me.TxtTelefono.Text = "00000000"
        End If
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        CANCELAR_A_E = False
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Me.TxtNombreApellidos.Text = "" Then
            MsgBox("Debe digitar los Nombres y Apellidos de la Persona que desea agregar", MsgBoxStyle.Information, "Mensaje del Sistema")
            TxtNombreApellidos.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_CLIENTE()

        If EXISTE_PERSONA = True Then
            MsgBox("Esta Persona ya fue ingresada con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            TxtNombreApellidos.Focus()
            Exit Sub
        End If

        Call GENERAR_CODIGO_ID_CLIENTE()

        Dim Insertar As String
        Dim Cmd_Add As SqlCommand

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Insertar = "INSERT INTO DBO.CLIENTES (IDCLIENTE, NOMBRES_APELLIDOS, CEDULA, TELEFONO) VALUES (" & CInt(TextBox1.Text) & ", '" & UCase(TxtNombreApellidos.Text) & "', '" & UCase(TxtCedula.Text) & "', '" & TxtTelefono.Text & "')"

        Try
            Call ConeccionBD.Abrir_BaseDato()
            Cmd_Add = New SqlCommand(Insertar, ConeccionBD.CONECCION)
            Cmd_Add.ExecuteNonQuery()
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

        CANCELAR_A_E = True
        Close()
    End Sub

    Private Sub GENERAR_CODIGO_ID_CLIENTE()
        Dim VALOR_ID_PERSONA As Integer
        Dim VALOR_DR As SqlDataReader
        TextBox1.Text = 0
        CADENA_SQL = "SELECT * FROM DBO.CLIENTES ORDER BY IDCLIENTE"
        Dim COMMAND1 As New SqlCommand(CADENA_SQL, ConeccionBD.CONECCION)

        Try
            ConeccionBD.Abrir_BaseDato()
            VALOR_DR = COMMAND1.ExecuteReader

            If (VALOR_DR.HasRows) Then
                While VALOR_DR.Read()
                    VALOR_ID_PERSONA = VALOR_DR("IDCLIENTE").ToString
                    TextBox1.Text = VALOR_ID_PERSONA + 1
                End While
            End If
            If TextBox1.Text = "" Or TextBox1.Text = 0 Then
                TextBox1.Text = 1
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

    Private Sub BUSCAR_SI_YA_EXISTE_CLIENTE()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("select * from DBO.CLIENTES WHERE NOMBRES_APELLIDOS = '" & TxtNombreApellidos.Text & "'  ORDER BY NOMBRES_APELLIDOS", ConeccionBD.CONECCION)
            drbuscar = cmbuscar.ExecuteReader

            If drbuscar.HasRows Then
                While drbuscar.Read
                    If UCase(drbuscar("Facturacion_Farmacia").ToString) = UCase(Me.TxtNombreApellidos.Text) Then
                        EXISTE_PERSONA = True
                    Else
                        EXISTE_PERSONA = False
                    End If
                End While
            Else
                EXISTE_PERSONA = False
            End If

            drbuscar.Close()
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

    Private Sub TxtNombreApellidos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.TxtNombreApellidos.Text = UCase(Me.TxtNombreApellidos.Text)
    End Sub

    Private Sub FrmAgregarClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtNombreApellidos.Text = ""
        Me.TxtCedula.Text = ""
        Me.TxtTelefono.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.TxtNombreApellidos.Text = "" Then
            MsgBox("Debe digitar los Nombres y Apellidos de la Persona que desea agregar", MsgBoxStyle.Information, "Mensaje del Sistema")
            TxtNombreApellidos.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_CLIENTE()

        If EXISTE_PERSONA = True Then
            MsgBox("Esta Persona ya fue ingresada con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            TxtNombreApellidos.Focus()
            Exit Sub
        End If

        Call GENERAR_CODIGO_ID_CLIENTE()

        Dim Insertar As String
        Dim Cmd_Add As SqlCommand

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Insertar = "INSERT INTO DBO.CLIENTES (IDCLIENTE, NOMBRES_APELLIDOS, CEDULA, TELEFONO) VALUES (" & CInt(TextBox1.Text) & ", '" & UCase(TxtNombreApellidos.Text) & "', '" & UCase(TxtCedula.Text) & "', '" & TxtTelefono.Text & "')"

        Try
            Call ConeccionBD.Abrir_BaseDato()
            Cmd_Add = New SqlCommand(Insertar, ConeccionBD.CONECCION)
            Cmd_Add.ExecuteNonQuery()
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

        CANCELAR_A_E = True
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CANCELAR_A_E = False
        Me.Close()
    End Sub
End Class
