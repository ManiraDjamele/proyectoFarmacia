Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class Registrar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "") Then
            MsgBox("Por favor, ingrese un dato", MsgBoxStyle.Information, "Informacion")
        Else
            If (Not TextBox2.Text = TextBox3.Text) Then
                MsgBox("Contraseñas no iguales", MsgBoxStyle.Information, "ERROR")
            Else
                Try
                    Dim Comando = New MySqlCommand("SELECT * FROM usuarios WHERE username = '" + TextBox1.Text + "';", Conex)
                    Dim Resultado = Comando.ExecuteReader
                    Resultado.Read()
                    If (Resultado.HasRows) Then
                        MsgBox("Usuario ya registrado", MsgBoxStyle.Exclamation, "ERROR")
                        Resultado.Close()

                    Else
                        Resultado.Close()
                        Comando = New MySqlCommand("INSERT INTO usuarios (username,password,fullname) VALUES ('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", Conex)
                        Dim Busqueda = Comando.ExecuteNonQuery
                        MsgBox("Usuario registrado exitosamente", MsgBoxStyle.Information, "REGISTRADO")
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        TextBox3.Text = ""
                        TextBox4.Text = ""
                    End If
                    Resultado.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                End Try
            End If
        End If

    End Sub


    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Registrar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Form1.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()
        Form1.Show()
    End Sub
End Class