Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class Form1

    '  Dim connectionString As String = "Server=localhost;Database=yourDatabase;Uid=yourUsername;Pwd=yourPassword"
    ' Public connection As New MySqlConnection
    ' Public selection As MySqlCommand = New MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' If (TextBox1.Text = " " Or TextBox2.Text = " ") Then 'para comparar no usa == solamente =   el then va fijo
        'MsgBox("ERROR DATOS NO VÁLIDOS", MsgBoxStyle.Critical, "ERROR") 'el ultimo titulo que puse en comillas es el que sale de base y el primer mensaje sale
        ' MsgBox("ERROR, FALTA INFORMACIÓN", MsgBoxStyle.Critical, "ERROR")
        ' Else
        'If (TextBox1.Text = "Admin" And TextBox2.Text = "Admin") Then
        'MsgBox("Welcome Admin", MsgBoxStyle.DefaultButton1, "Bienvenido")
        'Me.Hide() 'me es que se esta parado en el formulario
        'principal.Show() 'el principal es el nombre del nuevo formulario que se creo, yo le puse de nombre principal
        'Else
        'MsgBox("Error, Datos no encontrados", MsgBoxStyle.Critical, "Error")
        'End If
        'End If 'funciona como el fin del If, aqui no usamos las llaves, engloba todo

        'prueba

        '   If (TextBox1.Text = "") Then
        ' MsgBox("Ingrese datos")
        '   Else
        'Dim comando = New MySqlCommand("SELECT * FROM usuarios WHERE username = '" + TextBox1.Text + "';", Conex)
        'Dim resultado = comando.ExecuteReader
        'resultado.Read()
        'If (resultado.HasRows) Then
        'resultado.Close()
        'Dim comand = New MySqlCommand("SELECT * FROM usuarios WHERE password = '" + TextBox2.Text + "';", Conex)
        'Dim Key = comand.ExecuteReader
        'Key.Read()
        'If () Then

        'End If

        'MsgBox("Nombre : " + resultado("fullname"))

        'Else
        'MsgBox("usuario no encontrado")

        '  End If



        ' End If
        '  End Sub '

        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MsgBox("Faltan datos", MsgBoxStyle.Information, "Error")
        Else
            Try
                Dim Comando = New MySqlCommand("SELECT * FROM usuarios WHERE username = '" + TextBox1.Text + "';", Conex)
                Dim Resultado = Comando.ExecuteReader
                Resultado.Read()
                If (Resultado.HasRows) Then
                    If (TextBox2.Text = Resultado("password")) Then
                        MsgBox("Bienvenid@ " + Resultado("fullname"), MsgBoxStyle.Information, "Accediendo")
                        Resultado.Close()
                        Me.Hide()
                        Principal.Show()

                    Else
                        MsgBox("Contraseña incorrecta", MsgBoxStyle.Information, "Error")
                    End If
                Else
                    MsgBox("Usuario no existente", MsgBoxStyle.Exclamation, "Error")
                End If
                Resultado.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Registrar.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Conectar()
    End Sub
End Class
