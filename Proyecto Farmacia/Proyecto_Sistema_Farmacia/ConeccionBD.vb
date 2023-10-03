Imports System.Data.SqlClient
Module ConeccionBD
    Public CONECCION As New SqlConnection
    Public Sub Abrir_BaseDato()
        CONECCION.ConnectionString = "Data Source=LOURDES;Initial Catalog=Facturacion_Farmacia;Integrated Security=True"
        CONECCION.Open()
    End Sub
    Public Sub Cerrar_BaseDato()
        CONECCION.Close()
    End Sub
End Module

