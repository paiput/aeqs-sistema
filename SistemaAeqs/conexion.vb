﻿Imports MySql.Data.MySqlClient
Public Class conexion
    Dim connectionString = "Server=aeqs; user id=root;password =;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Public Sub pruebaConn()
        Try
            MysqlConexion.Open()
            MsgBox("Conexion establecida")
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class
