<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Regresar = New System.Windows.Forms.Button()
        Me.btn_Confirmar = New System.Windows.Forms.Button()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.hotel_luna
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(4, 8)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(242, 105)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 9
        Me.pictureBox1.TabStop = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.White
        Me.groupBox1.Controls.Add(Me.PictureBox2)
        Me.groupBox1.Controls.Add(Me.txt_Contraseña)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.txt_Usuario)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.btn_Regresar)
        Me.groupBox1.Controls.Add(Me.btn_Confirmar)
        Me.groupBox1.Controls.Add(Me.txt_Telefono)
        Me.groupBox1.Controls.Add(Me.txt_Nombre)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.groupBox1.Location = New System.Drawing.Point(4, 132)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox1.Size = New System.Drawing.Size(558, 306)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Hotel_Reservas.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(332, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 191)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Location = New System.Drawing.Point(25, 259)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Contraseña.Size = New System.Drawing.Size(247, 26)
        Me.txt_Contraseña.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contraseña"
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(25, 191)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Usuario.Size = New System.Drawing.Size(247, 26)
        Me.txt_Usuario.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Correo"
        '
        'btn_Regresar
        '
        Me.btn_Regresar.BackColor = System.Drawing.Color.Red
        Me.btn_Regresar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btn_Regresar.FlatAppearance.BorderSize = 3
        Me.btn_Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Regresar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Regresar.Location = New System.Drawing.Point(295, 251)
        Me.btn_Regresar.Name = "btn_Regresar"
        Me.btn_Regresar.Size = New System.Drawing.Size(116, 34)
        Me.btn_Regresar.TabIndex = 5
        Me.btn_Regresar.Text = "Regresar"
        Me.btn_Regresar.UseVisualStyleBackColor = False
        '
        'btn_Confirmar
        '
        Me.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btn_Confirmar.FlatAppearance.BorderSize = 3
        Me.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Confirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Confirmar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Confirmar.Location = New System.Drawing.Point(426, 251)
        Me.btn_Confirmar.Name = "btn_Confirmar"
        Me.btn_Confirmar.Size = New System.Drawing.Size(116, 34)
        Me.btn_Confirmar.TabIndex = 4
        Me.btn_Confirmar.Text = "Confirmar"
        Me.btn_Confirmar.UseVisualStyleBackColor = False
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(25, 118)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Telefono.Size = New System.Drawing.Size(247, 26)
        Me.txt_Telefono.TabIndex = 3
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(25, 46)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(249, 26)
        Me.txt_Nombre.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(21, 84)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(79, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Telefono"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(21, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Nombre"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.fondoplaya
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(567, 450)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btn_Regresar As Button
    Private WithEvents btn_Confirmar As Button
    Private WithEvents txt_Telefono As TextBox
    Private WithEvents txt_Nombre As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txt_Contraseña As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents txt_Usuario As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
