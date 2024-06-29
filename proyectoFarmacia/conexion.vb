Imports MySql.Data
Imports MySql.Data.MySqlClient
Module conexion
    Public Conex As MySqlConnection
    Sub Conectar()
        Dim conectar = "Server = localhost; Database = farmacia; Port=3306;user id=root;password=;"
        Try
            Conex = New MySqlConnection(conectar)
            Conex.ConnectionString = conectar
            Conex.Open()
            MsgBox("conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


End Module
