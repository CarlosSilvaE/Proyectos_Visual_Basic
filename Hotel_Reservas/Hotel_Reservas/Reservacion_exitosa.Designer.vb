<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservacion_exitosa
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
        Me.lbl_NumReserva = New System.Windows.Forms.Label()
        Me.lbl_NumHabitacion = New System.Windows.Forms.Label()
        Me.lbl_NomHuesped = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupBox1.Controls.Add(Me.lbl_NumReserva)
        Me.groupBox1.Controls.Add(Me.lbl_NumHabitacion)
        Me.groupBox1.Controls.Add(Me.lbl_NomHuesped)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(18, 231)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(491, 161)
        Me.groupBox1.TabIndex = 15
        Me.groupBox1.TabStop = False
        '
        'lbl_NumReserva
        '
        Me.lbl_NumReserva.AutoSize = True
        Me.lbl_NumReserva.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_NumReserva.Location = New System.Drawing.Point(296, 122)
        Me.lbl_NumReserva.Name = "lbl_NumReserva"
        Me.lbl_NumReserva.Size = New System.Drawing.Size(108, 20)
        Me.lbl_NumReserva.TabIndex = 5
        Me.lbl_NumReserva.Text = "# de reserva"
        '
        'lbl_NumHabitacion
        '
        Me.lbl_NumHabitacion.AutoSize = True
        Me.lbl_NumHabitacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_NumHabitacion.Location = New System.Drawing.Point(57, 122)
        Me.lbl_NumHabitacion.Name = "lbl_NumHabitacion"
        Me.lbl_NumHabitacion.Size = New System.Drawing.Size(132, 20)
        Me.lbl_NumHabitacion.TabIndex = 4
        Me.lbl_NumHabitacion.Text = "# de habitación"
        '
        'lbl_NomHuesped
        '
        Me.lbl_NomHuesped.AutoSize = True
        Me.lbl_NomHuesped.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_NomHuesped.Location = New System.Drawing.Point(154, 55)
        Me.lbl_NomHuesped.Name = "lbl_NomHuesped"
        Me.lbl_NomHuesped.Size = New System.Drawing.Size(174, 20)
        Me.lbl_NomHuesped.TabIndex = 3
        Me.lbl_NomHuesped.Text = "Nombre del huésped"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(255, 93)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(113, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = "# de reserva:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(15, 93)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(137, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "# de habitación:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(154, 22)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(179, 20)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Nombre del huésped:"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.hotel_luna
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(115, 58)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(323, 133)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 14
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gold
        Me.label1.Location = New System.Drawing.Point(36, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(427, 29)
        Me.label1.TabIndex = 13
        Me.label1.Text = "¡Reservación completada con exito!"
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.Color.Yellow
        Me.btn_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_Aceptar.FlatAppearance.BorderSize = 3
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Location = New System.Drawing.Point(189, 411)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(144, 35)
        Me.btn_Aceptar.TabIndex = 16
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'Reservacion_exitosa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.fondoplaya
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(526, 463)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Reservacion_exitosa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservacion exitosa"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lbl_NumReserva As Label
    Private WithEvents lbl_NumHabitacion As Label
    Private WithEvents lbl_NomHuesped As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents btn_Aceptar As Button
End Class
