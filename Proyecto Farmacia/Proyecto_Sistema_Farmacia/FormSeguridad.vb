Imports System.Data.SqlClient

Public Class FormSeguridad
    Inherits System.Windows.Forms.Form

    Dim dv As DataView
    Private posicion As Integer
    Dim odataset As New DataSet
    Private oconn As SqlConnection
    Private odataadapter As New SqlDataAdapter

    Private Sub FormSeguridad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oconn = New SqlConnection(oConexion)
        Me.odataadapter = New SqlDataAdapter("Select * from USUARIOS", oconn)
        Dim ocommandbuilder As SqlCommandBuilder = New SqlCommandBuilder(odataadapter)
        Me.odataset = New DataSet
        oconn.Open()
        Me.odataadapter.Fill(odataset, "USUARIOS")
        oconn.Close()
        posicion = 0
        Me.CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Dim odatarow As DataRow
        odatarow = Me.odataset.Tables("USUARIOS").Rows(posicion)
        Me.TxtCargarUsuario.Text = odatarow("Nombre")
        Me.TxtCargarContraseña.Text = odatarow("Contraseña")
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Comparar()
    End Sub

    Private Sub Comparar()
        If Me.TxtCargarUsuario.Text = Me.TxtUsuario.Text And Me.TxtCargarContraseña.Text = Me.TxtContraseña.Text Then
            Abrir()
        Else
            Buscar()
        End If
    End Sub

    Private Sub Abrir()
        Dim open As New FormPresentacion
        open.Show()
        Me.Hide()
    End Sub

    Private Sub Buscar()
        If Me.posicion = (Me.odataset.Tables("USUARIOS").Rows.Count - 1) Then
            MessageBox.Show("Usuario no registrado")
        Else
            posicion += 1
            CargarDatos()
            Comparar()
        End If
    End Sub

    Private Sub TxtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.TxtContraseña.Focus()
        End If
    End Sub

    Private Sub TxtContraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.BtnAceptar.Focus()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Comparar()
    End Sub
End Class