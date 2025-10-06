<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Me.btn_CerrarSesion = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_BuscarReserva = New System.Windows.Forms.Button()
        Me.btn_BuscarHabittacion = New System.Windows.Forms.Button()
        Me.btn_AñadirReserva = New System.Windows.Forms.Button()
        Me.btn_AñadirHabitación = New System.Windows.Forms.Button()
        Me.btn_BuscarHuesped = New System.Windows.Forms.Button()
        Me.btn_AñadirHuesped = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_CerrarSesion
        '
        Me.btn_CerrarSesion.BackColor = System.Drawing.Color.Red
        Me.btn_CerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin
        Me.btn_CerrarSesion.FlatAppearance.BorderSize = 3
        Me.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_CerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_CerrarSesion.Location = New System.Drawing.Point(588, 397)
        Me.btn_CerrarSesion.Name = "btn_CerrarSesion"
        Me.btn_CerrarSesion.Size = New System.Drawing.Size(159, 41)
        Me.btn_CerrarSesion.TabIndex = 7
        Me.btn_CerrarSesion.Text = "Cerrar Sesión"
        Me.btn_CerrarSesion.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btn_BuscarReserva)
        Me.groupBox1.Controls.Add(Me.btn_BuscarHabittacion)
        Me.groupBox1.Controls.Add(Me.btn_AñadirReserva)
        Me.groupBox1.Controls.Add(Me.btn_AñadirHabitación)
        Me.groupBox1.Controls.Add(Me.btn_BuscarHuesped)
        Me.groupBox1.Controls.Add(Me.btn_AñadirHuesped)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.pictureBox4)
        Me.groupBox1.Controls.Add(Me.pictureBox3)
        Me.groupBox1.Controls.Add(Me.pictureBox2)
        Me.groupBox1.Location = New System.Drawing.Point(17, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(484, 426)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        '
        'btn_BuscarReserva
        '
        Me.btn_BuscarReserva.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_BuscarReserva.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btn_BuscarReserva.FlatAppearance.BorderSize = 3
        Me.btn_BuscarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BuscarReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuscarReserva.Location = New System.Drawing.Point(308, 349)
        Me.btn_BuscarReserva.Name = "btn_BuscarReserva"
        Me.btn_BuscarReserva.Size = New System.Drawing.Size(100, 33)
        Me.btn_BuscarReserva.TabIndex = 11
        Me.btn_BuscarReserva.Text = "Buscar"
        Me.btn_BuscarReserva.UseVisualStyleBackColor = False
        '
        'btn_BuscarHabittacion
        '
        Me.btn_BuscarHabittacion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_BuscarHabittacion.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btn_BuscarHabittacion.FlatAppearance.BorderSize = 3
        Me.btn_BuscarHabittacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BuscarHabittacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuscarHabittacion.Location = New System.Drawing.Point(308, 213)
        Me.btn_BuscarHabittacion.Name = "btn_BuscarHabittacion"
        Me.btn_BuscarHabittacion.Size = New System.Drawing.Size(100, 33)
        Me.btn_BuscarHabittacion.TabIndex = 10
        Me.btn_BuscarHabittacion.Text = "Buscar"
        Me.btn_BuscarHabittacion.UseVisualStyleBackColor = False
        '
        'btn_AñadirReserva
        '
        Me.btn_AñadirReserva.BackColor = System.Drawing.Color.Gold
        Me.btn_AñadirReserva.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btn_AñadirReserva.FlatAppearance.BorderSize = 3
        Me.btn_AñadirReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AñadirReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AñadirReserva.Location = New System.Drawing.Point(175, 349)
        Me.btn_AñadirReserva.Name = "btn_AñadirReserva"
        Me.btn_AñadirReserva.Size = New System.Drawing.Size(100, 33)
        Me.btn_AñadirReserva.TabIndex = 9
        Me.btn_AñadirReserva.Text = "Añadir"
        Me.btn_AñadirReserva.UseVisualStyleBackColor = False
        '
        'btn_AñadirHabitación
        '
        Me.btn_AñadirHabitación.BackColor = System.Drawing.Color.Gold
        Me.btn_AñadirHabitación.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btn_AñadirHabitación.FlatAppearance.BorderSize = 3
        Me.btn_AñadirHabitación.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AñadirHabitación.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AñadirHabitación.Location = New System.Drawing.Point(175, 213)
        Me.btn_AñadirHabitación.Name = "btn_AñadirHabitación"
        Me.btn_AñadirHabitación.Size = New System.Drawing.Size(100, 33)
        Me.btn_AñadirHabitación.TabIndex = 8
        Me.btn_AñadirHabitación.Text = "Añadir"
        Me.btn_AñadirHabitación.UseVisualStyleBackColor = False
        '
        'btn_BuscarHuesped
        '
        Me.btn_BuscarHuesped.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_BuscarHuesped.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btn_BuscarHuesped.FlatAppearance.BorderSize = 3
        Me.btn_BuscarHuesped.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BuscarHuesped.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuscarHuesped.Location = New System.Drawing.Point(308, 87)
        Me.btn_BuscarHuesped.Name = "btn_BuscarHuesped"
        Me.btn_BuscarHuesped.Size = New System.Drawing.Size(100, 33)
        Me.btn_BuscarHuesped.TabIndex = 7
        Me.btn_BuscarHuesped.Text = "Buscar"
        Me.btn_BuscarHuesped.UseVisualStyleBackColor = False
        '
        'btn_AñadirHuesped
        '
        Me.btn_AñadirHuesped.BackColor = System.Drawing.Color.Gold
        Me.btn_AñadirHuesped.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btn_AñadirHuesped.FlatAppearance.BorderSize = 3
        Me.btn_AñadirHuesped.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AñadirHuesped.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AñadirHuesped.Location = New System.Drawing.Point(175, 87)
        Me.btn_AñadirHuesped.Name = "btn_AñadirHuesped"
        Me.btn_AñadirHuesped.Size = New System.Drawing.Size(100, 33)
        Me.btn_AñadirHuesped.TabIndex = 6
        Me.btn_AñadirHuesped.Text = "Añadir"
        Me.btn_AñadirHuesped.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Javanese Text", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(157, 303)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(148, 43)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Reservaciones"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Javanese Text", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(157, 167)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(138, 43)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Habitaciones"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Javanese Text", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(157, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(118, 43)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Huéspedes"
        '
        'pictureBox4
        '
        Me.pictureBox4.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.reserva
        Me.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox4.Location = New System.Drawing.Point(25, 294)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(111, 111)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox4.TabIndex = 2
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.habitacion
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox3.Location = New System.Drawing.Point(25, 157)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(111, 111)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 1
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.huesped
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Location = New System.Drawing.Point(25, 20)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(111, 111)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 0
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.hotel_luna
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(526, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(257, 120)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.fondoplaya
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_CerrarSesion)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btn_CerrarSesion As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btn_BuscarReserva As Button
    Private WithEvents btn_BuscarHabittacion As Button
    Private WithEvents btn_AñadirReserva As Button
    Private WithEvents btn_AñadirHabitación As Button
    Private WithEvents btn_BuscarHuesped As Button
    Private WithEvents btn_AñadirHuesped As Button
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
End Class
