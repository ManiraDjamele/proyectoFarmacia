<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RjToggleButton1 = New RJCodeAdvance.RJControls.RJToggleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RjTextBox1 = New RJCodeAdvance.RJControls.RJTextBox()
        Me.RjTextBox2 = New RJCodeAdvance.RJControls.RJTextBox()
        Me.RjTextBox3 = New RJCodeAdvance.RJControls.RJTextBox()
        Me.RjTextBox4 = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RjButton1 = New RJCodeAdvance.RJControls.RJButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RjButton2 = New RJCodeAdvance.RJControls.RJButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RjTextBox5 = New RJCodeAdvance.RJControls.RJTextBox()
        Me.RjTextBox6 = New RJCodeAdvance.RJControls.RJTextBox()
        Me.RjTextBox7 = New RJCodeAdvance.RJControls.RJTextBox()
        Me.RjTextBox8 = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RjToggleButton2 = New RJCodeAdvance.RJControls.RJToggleButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(649, 295)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "codigo"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "nombre"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "marca"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "precio"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(230, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(422, 30)
        Me.TextBox1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(249, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 384)
        Me.Panel1.TabIndex = 3
        '
        'RjToggleButton1
        '
        Me.RjToggleButton1.AutoSize = True
        Me.RjToggleButton1.Location = New System.Drawing.Point(33, 305)
        Me.RjToggleButton1.MinimumSize = New System.Drawing.Size(45, 22)
        Me.RjToggleButton1.Name = "RjToggleButton1"
        Me.RjToggleButton1.OffBackColor = System.Drawing.Color.Gray
        Me.RjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro
        Me.RjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke
        Me.RjToggleButton1.Size = New System.Drawing.Size(45, 22)
        Me.RjToggleButton1.TabIndex = 3
        Me.RjToggleButton1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Controls.Add(Me.RjButton1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.RjTextBox4)
        Me.Panel2.Controls.Add(Me.RjTextBox3)
        Me.Panel2.Controls.Add(Me.RjToggleButton1)
        Me.Panel2.Controls.Add(Me.RjTextBox2)
        Me.Panel2.Controls.Add(Me.RjTextBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 384)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Codigo"
        '
        'RjTextBox1
        '
        Me.RjTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.RjTextBox1.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox1.BorderRadius = 8
        Me.RjTextBox1.BorderSize = 2
        Me.RjTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RjTextBox1.Location = New System.Drawing.Point(8, 43)
        Me.RjTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox1.Multiline = False
        Me.RjTextBox1.Name = "RjTextBox1"
        Me.RjTextBox1.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox1.PasswordChar = False
        Me.RjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox1.PlaceholderText = ""
        Me.RjTextBox1.Size = New System.Drawing.Size(182, 39)
        Me.RjTextBox1.TabIndex = 3
        Me.RjTextBox1.Texts = ""
        Me.RjTextBox1.UnderlinedStyle = False
        '
        'RjTextBox2
        '
        Me.RjTextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.RjTextBox2.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox2.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox2.BorderRadius = 8
        Me.RjTextBox2.BorderSize = 2
        Me.RjTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjTextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RjTextBox2.Location = New System.Drawing.Point(8, 115)
        Me.RjTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox2.Multiline = False
        Me.RjTextBox2.Name = "RjTextBox2"
        Me.RjTextBox2.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox2.PasswordChar = False
        Me.RjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox2.PlaceholderText = ""
        Me.RjTextBox2.Size = New System.Drawing.Size(182, 39)
        Me.RjTextBox2.TabIndex = 7
        Me.RjTextBox2.Texts = ""
        Me.RjTextBox2.UnderlinedStyle = False
        '
        'RjTextBox3
        '
        Me.RjTextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.RjTextBox3.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox3.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox3.BorderRadius = 8
        Me.RjTextBox3.BorderSize = 2
        Me.RjTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjTextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RjTextBox3.Location = New System.Drawing.Point(8, 259)
        Me.RjTextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox3.Multiline = False
        Me.RjTextBox3.Name = "RjTextBox3"
        Me.RjTextBox3.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox3.PasswordChar = False
        Me.RjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox3.PlaceholderText = ""
        Me.RjTextBox3.Size = New System.Drawing.Size(182, 39)
        Me.RjTextBox3.TabIndex = 8
        Me.RjTextBox3.Texts = ""
        Me.RjTextBox3.UnderlinedStyle = False
        '
        'RjTextBox4
        '
        Me.RjTextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.RjTextBox4.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox4.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox4.BorderRadius = 8
        Me.RjTextBox4.BorderSize = 2
        Me.RjTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjTextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RjTextBox4.Location = New System.Drawing.Point(8, 187)
        Me.RjTextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox4.Multiline = False
        Me.RjTextBox4.Name = "RjTextBox4"
        Me.RjTextBox4.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox4.PasswordChar = False
        Me.RjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox4.PlaceholderText = ""
        Me.RjTextBox4.Size = New System.Drawing.Size(182, 39)
        Me.RjTextBox4.TabIndex = 9
        Me.RjTextBox4.Texts = ""
        Me.RjTextBox4.UnderlinedStyle = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Usuario\Producto"
        '
        'RjButton1
        '
        Me.RjButton1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.RjButton1.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.RjButton1.BorderColor = System.Drawing.Color.Blue
        Me.RjButton1.BorderRadius = 8
        Me.RjButton1.BorderSize = 0
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.Location = New System.Drawing.Point(84, 330)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(82, 43)
        Me.RjButton1.TabIndex = 3
        Me.RjButton1.Text = "Ingresar"
        Me.RjButton1.TextColor = System.Drawing.Color.White
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.RjToggleButton2)
        Me.Panel3.Controls.Add(Me.RjButton2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.RjTextBox5)
        Me.Panel3.Controls.Add(Me.RjTextBox6)
        Me.Panel3.Controls.Add(Me.RjTextBox7)
        Me.Panel3.Controls.Add(Me.RjTextBox8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(6, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 384)
        Me.Panel3.TabIndex = 4
        Me.Panel3.Visible = False
        '
        'RjButton2
        '
        Me.RjButton2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.RjButton2.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.RjButton2.BorderColor = System.Drawing.Color.Blue
        Me.RjButton2.BorderRadius = 8
        Me.RjButton2.BorderSize = 0
        Me.RjButton2.FlatAppearance.BorderSize = 0
        Me.RjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton2.ForeColor = System.Drawing.Color.White
        Me.RjButton2.Location = New System.Drawing.Point(84, 330)
        Me.RjButton2.Name = "RjButton2"
        Me.RjButton2.Size = New System.Drawing.Size(82, 43)
        Me.RjButton2.TabIndex = 3
        Me.RjButton2.Text = "Ingresar"
        Me.RjButton2.TextColor = System.Drawing.Color.White
        Me.RjButton2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(84, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Usuario\Producto"
        '
        'RjTextBox5
        '
        Me.RjTextBox5.BackColor = System.Drawing.SystemColors.Window
        Me.RjTextBox5.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox5.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox5.BorderRadius = 8
        Me.RjTextBox5.BorderSize = 2
        Me.RjTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjTextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RjTextBox5.Location = New System.Drawing.Point(8, 187)
        Me.RjTextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox5.Multiline = False
        Me.RjTextBox5.Name = "RjTextBox5"
        Me.RjTextBox5.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox5.PasswordChar = False
        Me.RjTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox5.PlaceholderText = ""
        Me.RjTextBox5.Size = New System.Drawing.Size(182, 39)
        Me.RjTextBox5.TabIndex = 9
        Me.RjTextBox5.Texts = ""
        Me.RjTextBox5.UnderlinedStyle = False
        '
        'RjTextBox6
        '
        Me.RjTextBox6.BackColor = System.Drawing.SystemColors.Window
        Me.RjTextBox6.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox6.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox6.BorderRadius = 8
        Me.RjTextBox6.BorderSize = 2
        Me.RjTextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjTextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RjTextBox6.Location = New System.Drawing.Point(8, 259)
        Me.RjTextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox6.Multiline = False
        Me.RjTextBox6.Name = "RjTextBox6"
        Me.RjTextBox6.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox6.PasswordChar = False
        Me.RjTextBox6.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox6.PlaceholderText = ""
        Me.RjTextBox6.Size = New System.Drawing.Size(182, 39)
        Me.RjTextBox6.TabIndex = 8
        Me.RjTextBox6.Texts = ""
        Me.RjTextBox6.UnderlinedStyle = False
        '
        'RjTextBox7
        '
        Me.RjTextBox7.BackColor = System.Drawing.SystemColors.Window
        Me.RjTextBox7.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox7.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox7.BorderRadius = 8
        Me.RjTextBox7.BorderSize = 2
        Me.RjTextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjTextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RjTextBox7.Location = New System.Drawing.Point(8, 115)
        Me.RjTextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox7.Multiline = False
        Me.RjTextBox7.Name = "RjTextBox7"
        Me.RjTextBox7.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox7.PasswordChar = False
        Me.RjTextBox7.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox7.PlaceholderText = ""
        Me.RjTextBox7.Size = New System.Drawing.Size(182, 39)
        Me.RjTextBox7.TabIndex = 7
        Me.RjTextBox7.Texts = ""
        Me.RjTextBox7.UnderlinedStyle = False
        '
        'RjTextBox8
        '
        Me.RjTextBox8.BackColor = System.Drawing.SystemColors.Window
        Me.RjTextBox8.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox8.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.RjTextBox8.BorderRadius = 8
        Me.RjTextBox8.BorderSize = 2
        Me.RjTextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjTextBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RjTextBox8.Location = New System.Drawing.Point(8, 43)
        Me.RjTextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.RjTextBox8.Multiline = False
        Me.RjTextBox8.Name = "RjTextBox8"
        Me.RjTextBox8.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.RjTextBox8.PasswordChar = False
        Me.RjTextBox8.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.RjTextBox8.PlaceholderText = ""
        Me.RjTextBox8.Size = New System.Drawing.Size(182, 39)
        Me.RjTextBox8.TabIndex = 3
        Me.RjTextBox8.Texts = ""
        Me.RjTextBox8.UnderlinedStyle = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Confirmar Contraseña"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 25)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Nombre del Usuario"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.DataGridView2)
        Me.Panel4.Location = New System.Drawing.Point(249, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(655, 384)
        Me.Panel4.TabIndex = 5
        Me.Panel4.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 42)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(230, 31)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(422, 30)
        Me.TextBox2.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.Location = New System.Drawing.Point(109, 78)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(482, 295)
        Me.DataGridView2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(6, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(898, 384)
        Me.Panel5.TabIndex = 6
        '
        'RjToggleButton2
        '
        Me.RjToggleButton2.AutoSize = True
        Me.RjToggleButton2.Location = New System.Drawing.Point(25, 307)
        Me.RjToggleButton2.MinimumSize = New System.Drawing.Size(45, 22)
        Me.RjToggleButton2.Name = "RjToggleButton2"
        Me.RjToggleButton2.OffBackColor = System.Drawing.Color.Gray
        Me.RjToggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro
        Me.RjToggleButton2.OnBackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjToggleButton2.OnToggleColor = System.Drawing.Color.WhiteSmoke
        Me.RjToggleButton2.Size = New System.Drawing.Size(45, 22)
        Me.RjToggleButton2.TabIndex = 11
        Me.RjToggleButton2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "usuario"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "fullname"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 408)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.Text = "Principal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RjToggleButton1 As RJCodeAdvance.RJControls.RJToggleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RjTextBox4 As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents RjTextBox3 As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents RjTextBox2 As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents RjTextBox1 As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RjButton1 As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RjButton2 As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label6 As Label
    Friend WithEvents RjTextBox5 As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents RjTextBox6 As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents RjTextBox7 As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents RjTextBox8 As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RjToggleButton2 As RJCodeAdvance.RJControls.RJToggleButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
