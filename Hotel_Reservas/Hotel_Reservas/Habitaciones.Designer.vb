<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Habitaciones
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.pic_Tipo = New System.Windows.Forms.PictureBox()
        Me.rbtn_Mantenimiento = New System.Windows.Forms.RadioButton()
        Me.rbtn_Disponible = New System.Windows.Forms.RadioButton()
        Me.cmb_Tipo = New System.Windows.Forms.ComboBox()
        Me.txt_Precio = New System.Windows.Forms.TextBox()
        Me.txt_NumHabitacion = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1.SuspendLayout()
        CType(Me.pic_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupBox1.Controls.Add(Me.pic_Tipo)
        Me.groupBox1.Controls.Add(Me.rbtn_Mantenimiento)
        Me.groupBox1.Controls.Add(Me.rbtn_Disponible)
        Me.groupBox1.Controls.Add(Me.cmb_Tipo)
        Me.groupBox1.Controls.Add(Me.txt_Precio)
        Me.groupBox1.Controls.Add(Me.txt_NumHabitacion)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 50)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(491, 359)
        Me.groupBox1.TabIndex = 11
        Me.groupBox1.TabStop = False
        '
        'pic_Tipo
        '
        Me.pic_Tipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Tipo.Location = New System.Drawing.Point(294, 35)
        Me.pic_Tipo.Name = "pic_Tipo"
        Me.pic_Tipo.Size = New System.Drawing.Size(175, 175)
        Me.pic_Tipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Tipo.TabIndex = 10
        Me.pic_Tipo.TabStop = False
        '
        'rbtn_Mantenimiento
        '
        Me.rbtn_Mantenimiento.AutoSize = True
        Me.rbtn_Mantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Mantenimiento.Location = New System.Drawing.Point(211, 263)
        Me.rbtn_Mantenimiento.Name = "rbtn_Mantenimiento"
        Me.rbtn_Mantenimiento.Size = New System.Drawing.Size(156, 24)
        Me.rbtn_Mantenimiento.TabIndex = 9
        Me.rbtn_Mantenimiento.TabStop = True
        Me.rbtn_Mantenimiento.Text = "En mantenimiento"
        Me.rbtn_Mantenimiento.UseVisualStyleBackColor = True
        '
        'rbtn_Disponible
        '
        Me.rbtn_Disponible.AutoSize = True
        Me.rbtn_Disponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Disponible.Location = New System.Drawing.Point(67, 263)
        Me.rbtn_Disponible.Name = "rbtn_Disponible"
        Me.rbtn_Disponible.Size = New System.Drawing.Size(101, 24)
        Me.rbtn_Disponible.TabIndex = 8
        Me.rbtn_Disponible.TabStop = True
        Me.rbtn_Disponible.Text = "Disponible"
        Me.rbtn_Disponible.UseVisualStyleBackColor = True
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Items.AddRange(New Object() {"Estándar Individual", "Estándar Doble", "Estándar Familiar", "Deluxe Individual", "Deluxe Doble", "Deluxe Familiar", "Suite Individual", "Suite Doble", "Suite Familiar"})
        Me.cmb_Tipo.Location = New System.Drawing.Point(67, 115)
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(204, 28)
        Me.cmb_Tipo.TabIndex = 7
        '
        'txt_Precio
        '
        Me.txt_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Precio.Location = New System.Drawing.Point(67, 184)
        Me.txt_Precio.Name = "txt_Precio"
        Me.txt_Precio.Size = New System.Drawing.Size(204, 26)
        Me.txt_Precio.TabIndex = 6
        '
        'txt_NumHabitacion
        '
        Me.txt_NumHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_NumHabitacion.Location = New System.Drawing.Point(67, 52)
        Me.txt_NumHabitacion.Name = "txt_NumHabitacion"
        Me.txt_NumHabitacion.Size = New System.Drawing.Size(112, 26)
        Me.txt_NumHabitacion.TabIndex = 4
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(15, 231)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 20)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Estado:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(15, 154)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Precio:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(15, 93)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Tipo:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(189, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Número de habitación:"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_Cancelar.FlatAppearance.BorderSize = 3
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancelar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Location = New System.Drawing.Point(598, 306)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(144, 35)
        Me.btn_Cancelar.TabIndex = 14
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.Color.Yellow
        Me.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_Guardar.FlatAppearance.BorderSize = 3
        Me.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Guardar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.Location = New System.Drawing.Point(598, 246)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(144, 35)
        Me.btn_Guardar.TabIndex = 13
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.hotel_luna
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(525, 19)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(248, 128)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 12
        Me.pictureBox1.TabStop = False
        '
        'Habitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.fondoplaya
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 431)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Habitaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Habitaciones"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pic_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents rbtn_Mantenimiento As RadioButton
    Private WithEvents rbtn_Disponible As RadioButton
    Private WithEvents cmb_Tipo As ComboBox
    Private WithEvents txt_Precio As TextBox
    Private WithEvents txt_NumHabitacion As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btn_Cancelar As Button
    Private WithEvents btn_Guardar As Button
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents pic_Tipo As PictureBox
End Class
