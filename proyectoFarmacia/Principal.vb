Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Principal
    Public comand As New MySqlCommand 'hablo de cambiar comand por conection
    Public selection As MySqlCommand = New MySqlCommand
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar1_grid()
        llenar2_grid()
    End Sub
    Private Sub llenar1_grid()

        Dim consulta = New MySqlCommand("SELECT * FROM productos;", Conex)
        Dim productos = consulta.ExecuteReader
        While (productos.Read())
            Dim codigo = productos.GetInt32(0)
            Dim nombre = productos.GetString(1)
            Dim marca = productos.GetString(2)
            Dim precio = productos.GetInt32(3)
            DataGridView1.Rows.Add(Convert.ToString(codigo), nombre, marca, Convert.ToString(precio))

        End While

        productos.Close()
    End Sub

    Private Sub llenar2_grid()

        Dim consulta = New MySqlCommand("SELECT * FROM usuarios;", Conex)
        Dim usuarios = consulta.ExecuteReader
        While (usuarios.Read())
            Dim username = usuarios.GetInt32(0)
            Dim fullname = usuarios.GetString(1)
            DataGridView1.Rows.Add(username, fullname)

        End While
        usuarios.Close()

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Close()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim dato As String = "%" + TextBox1.Text + "%"
        getBuscar(dato)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub getBuscar(s)
        Dim consulta = New MySqlCommand("SELECT * FROM productos where codigo like'" + s + "' " + "or nombre like'" + s.ToString() + "' " + "or marca like'" + s.ToString() + "' " + "or precio  like'" + s + "' ", Conex)
        Dim productos = consulta.ExecuteReader
        DataGridView1.Rows.Clear()
        Try
            While (productos.Read())
                Dim codigo = productos.GetInt32(0)
                Dim nombre = productos.GetString(1)
                Dim marca = productos.GetString(2)
                Dim precio = productos.GetInt32(3)
                DataGridView1.Rows.Add(Convert.ToString(codigo), nombre, marca, Convert.ToString(precio))

            End While
            productos.Close()
        Catch ex As Exception
            MsgBox("error desconocido o no esta lo que buscas")
            productos.Close()
        End Try
        productos.Close()

    End Sub

    Private Sub RjToggleButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RjToggleButton1.CheckedChanged
        If (RjToggleButton1.Checked) Then
            Panel1.Hide()
            Panel2.Hide()
            Panel3.Show()
            Panel4.Show()
        Else

            Panel1.Show()
            Panel2.Show()
            Panel3.Hide()
            Panel4.Hide()

        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub RjToggleButton2_CheckedChanged(sender As Object, e As EventArgs)
        If (RjToggleButton2.Checked) Then
            Panel3.Hide()
            Panel4.Hide()
            Panel1.Show()
            Panel2.Show()
        Else

            Panel3.Show()
            Panel4.Show()
            Panel1.Hide()
            Panel2.Hide()

        End If
    End Sub

    Private Sub RjButton2_Click(sender As Object, e As EventArgs) Handles RjButton2.Click
        If (RjTextBox8.Texts = "" Or RjTextBox7.Texts = "" Or RjTextBox5.Texts = "" Or RjTextBox6.Texts = "") Then
            MsgBox("Por favor, ingrese un dato", MsgBoxStyle.Information, "Informacion")
        Else
            If (Not RjTextBox5.Texts = RjTextBox6.Texts) Then
                MsgBox("Contraseñas no iguales", MsgBoxStyle.Information, "ERROR")
            Else
                Try
                    Dim Comando = New MySqlCommand("SELECT * FROM usuarios WHERE username = '" + RjTextBox8.Texts + "';", Conex)
                    Dim Resultado = Comando.ExecuteReader
                    Resultado.Read()
                    If (Resultado.HasRows) Then
                        MsgBox("Usuario ya registrado", MsgBoxStyle.Exclamation, "ERROR")
                        Resultado.Close()

                    Else
                        Resultado.Close()
                        Comando = New MySqlCommand("INSERT INTO usuarios (username,password,fullname) VALUES ('" + RjTextBox8.Texts + "','" + RjTextBox6.Texts + "','" + RjTextBox7.Texts + "')", Conex)
                        Dim Busqueda = Comando.ExecuteNonQuery
                        MsgBox("Usuario registrado exitosamente", MsgBoxStyle.Information, "REGISTRADO")
                        RjTextBox8.Texts = ""
                        RjTextBox7.Texts = ""
                        RjTextBox6.Texts = ""
                        RjTextBox5.Texts = ""
                    End If
                    Resultado.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                End Try
            End If
        End If

    End Sub

    Private Sub RjButton1_Click(sender As Object, e As EventArgs) Handles RjButton1.Click
        If (RjTextBox1.Texts = "" Or RjTextBox2.Texts = "" Or RjTextBox4.Texts = "" Or RjTextBox3.Texts = "") Then
            MsgBox("Faltan datos")
        Else
            Try
                Dim comando = New MySqlCommand("INSERT INTO productos (codigo,nombre,marca,precio) VALUES ('" + RjTextBox1.Texts + "','" + RjTextBox2.Texts + "','" + RjTextBox4.Texts + "',' " + RjTextBox3.Texts + " ')", Conex)
                Dim resultado = comando.ExecuteNonQuery 'activa el comando para insertar los datos'
                MsgBox("Producto creado con Exito! ", MsgBoxStyle.Information)
                RjTextBox5.Texts = ""
                RjTextBox4.Texts = ""
                RjTextBox3.Texts = ""
                RjTextBox2.Texts = ""

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Dim dato As String = "%" + TextBox2.Text + "%"
        buscar(dato)
    End Sub

    Private Sub buscar(s)


        Dim consulta = New MySqlCommand("SELECT * FROM usuarios where id like '" + s + "' " + "or username like '" + s.ToString() + "' " + "or fullname like '" + s.ToString() + "' ", Conex)
        Dim productos = consulta.ExecuteReader
        DataGridView2.Rows.Clear()

        Try
            While (productos.Read())


                Dim username = productos.GetString(1)
                Dim fullname = productos.GetString(2)

                DataGridView1.Rows.Add(username, fullname)

            End While

        Catch ex As Exception
            MsgBox("error desconocido")

        End Try
        productos.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class