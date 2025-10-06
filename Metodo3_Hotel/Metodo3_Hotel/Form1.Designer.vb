<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Tipo = New System.Windows.Forms.TextBox()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.pic_Tipo = New System.Windows.Forms.PictureBox()
        Me.txt_Precio = New System.Windows.Forms.TextBox()
        Me.txt_NumHabitacion = New System.Windows.Forms.TextBox()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.cnx = New System.Data.OleDb.OleDbConnection()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Buscar.BackgroundImage = Global.Metodo3_Hotel.My.Resources.Resources.Lupa
        Me.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_Buscar.FlatAppearance.BorderSize = 3
        Me.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Buscar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Location = New System.Drawing.Point(176, 65)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(36, 26)
        Me.btn_Buscar.TabIndex = 19
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'txt_Tipo
        '
        Me.txt_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Tipo.Location = New System.Drawing.Point(58, 133)
        Me.txt_Tipo.Name = "txt_Tipo"
        Me.txt_Tipo.ReadOnly = True
        Me.txt_Tipo.Size = New System.Drawing.Size(204, 26)
        Me.txt_Tipo.TabIndex = 13
        '
        'btn_Agregar
        '
        Me.btn_Agregar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_Agregar.FlatAppearance.BorderSize = 3
        Me.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Agregar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Location = New System.Drawing.Point(533, 195)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(112, 35)
        Me.btn_Agregar.TabIndex = 33
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = False
        '
        'pic_Tipo
        '
        Me.pic_Tipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Tipo.Location = New System.Drawing.Point(295, 46)
        Me.pic_Tipo.Name = "pic_Tipo"
        Me.pic_Tipo.Size = New System.Drawing.Size(175, 175)
        Me.pic_Tipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Tipo.TabIndex = 10
        Me.pic_Tipo.TabStop = False
        '
        'txt_Precio
        '
        Me.txt_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Precio.Location = New System.Drawing.Point(58, 197)
        Me.txt_Precio.Name = "txt_Precio"
        Me.txt_Precio.Size = New System.Drawing.Size(204, 26)
        Me.txt_Precio.TabIndex = 6
        '
        'txt_NumHabitacion
        '
        Me.txt_NumHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_NumHabitacion.Location = New System.Drawing.Point(58, 65)
        Me.txt_NumHabitacion.Name = "txt_NumHabitacion"
        Me.txt_NumHabitacion.Size = New System.Drawing.Size(112, 26)
        Me.txt_NumHabitacion.TabIndex = 4
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btn_Salir.FlatAppearance.BorderSize = 3
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(601, 279)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(112, 35)
        Me.btn_Salir.TabIndex = 36
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.Yellow
        Me.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.btn_Eliminar.FlatAppearance.BorderSize = 3
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.Location = New System.Drawing.Point(669, 195)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(112, 35)
        Me.btn_Eliminar.TabIndex = 35
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.BackColor = System.Drawing.Color.Blue
        Me.btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.btn_Modificar.FlatAppearance.BorderSize = 3
        Me.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Modificar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Location = New System.Drawing.Point(669, 238)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(112, 35)
        Me.btn_Modificar.TabIndex = 34
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 167)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Precio:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 106)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Tipo:"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = Global.Metodo3_Hotel.My.Resources.Resources.hotel_luna
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(533, 37)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(248, 128)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 31
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(189, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Número de habitación:"
        '
        'groupBox1
        '
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupBox1.Controls.Add(Me.btn_Buscar)
        Me.groupBox1.Controls.Add(Me.txt_Tipo)
        Me.groupBox1.Controls.Add(Me.pic_Tipo)
        Me.groupBox1.Controls.Add(Me.txt_Precio)
        Me.groupBox1.Controls.Add(Me.txt_NumHabitacion)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(20, 71)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(491, 252)
        Me.groupBox1.TabIndex = 30
        Me.groupBox1.TabStop = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab
        Me.btn_Limpiar.FlatAppearance.BorderSize = 3
        Me.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Limpiar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(533, 238)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(112, 35)
        Me.btn_Limpiar.TabIndex = 37
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'cnx
        '
        Me.cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Hotel_Reservas.mdb"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Metodo3_Hotel.My.Resources.Resources.fondoplaya
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 360)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pic_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btn_Buscar As Button
    Private WithEvents txt_Tipo As TextBox
    Private WithEvents btn_Agregar As Button
    Friend WithEvents pic_Tipo As PictureBox
    Private WithEvents txt_Precio As TextBox
    Private WithEvents txt_NumHabitacion As TextBox
    Private WithEvents btn_Salir As Button
    Private WithEvents btn_Eliminar As Button
    Private WithEvents btn_Modificar As Button
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btn_Limpiar As Button
    Friend WithEvents cnx As OleDb.OleDbConnection
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
