<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservaciones
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
        Me.label7 = New System.Windows.Forms.Label()
        Me.cmb_Tipo = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.rbtn_Pendiente = New System.Windows.Forms.RadioButton()
        Me.rbtn_Pagado = New System.Windows.Forms.RadioButton()
        Me.dtp_FechaSal = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaEnt = New System.Windows.Forms.DateTimePicker()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cmb_Huesped = New System.Windows.Forms.ComboBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmb_NumHuesped = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(26, 22)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(121, 20)
        Me.label7.TabIndex = 1
        Me.label7.Text = "Total a Pagar:"
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Items.AddRange(New Object() {"Estándar Individual", "Estándar Doble", "Estándar Familiar", "Deluxe Individual", "Deluxe Doble", "Deluxe Familiar", "Suite Individual", "Suite Doble", "Suite Familiar"})
        Me.cmb_Tipo.Location = New System.Drawing.Point(243, 332)
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(204, 28)
        Me.cmb_Tipo.TabIndex = 15
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(239, 298)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(161, 20)
        Me.label6.TabIndex = 14
        Me.label6.Text = "Tipo de habitación:"
        '
        'rbtn_Pendiente
        '
        Me.rbtn_Pendiente.AutoSize = True
        Me.rbtn_Pendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Pendiente.Location = New System.Drawing.Point(59, 376)
        Me.rbtn_Pendiente.Name = "rbtn_Pendiente"
        Me.rbtn_Pendiente.Size = New System.Drawing.Size(99, 24)
        Me.rbtn_Pendiente.TabIndex = 13
        Me.rbtn_Pendiente.TabStop = True
        Me.rbtn_Pendiente.Text = "Pendiente"
        Me.rbtn_Pendiente.UseVisualStyleBackColor = True
        '
        'rbtn_Pagado
        '
        Me.rbtn_Pagado.AutoSize = True
        Me.rbtn_Pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Pagado.Location = New System.Drawing.Point(59, 335)
        Me.rbtn_Pagado.Name = "rbtn_Pagado"
        Me.rbtn_Pagado.Size = New System.Drawing.Size(82, 24)
        Me.rbtn_Pagado.TabIndex = 12
        Me.rbtn_Pagado.TabStop = True
        Me.rbtn_Pagado.Text = "Pagado"
        Me.rbtn_Pagado.UseVisualStyleBackColor = True
        '
        'dtp_FechaSal
        '
        Me.dtp_FechaSal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.dtp_FechaSal.Location = New System.Drawing.Point(116, 253)
        Me.dtp_FechaSal.Name = "dtp_FechaSal"
        Me.dtp_FechaSal.Size = New System.Drawing.Size(367, 26)
        Me.dtp_FechaSal.TabIndex = 11
        '
        'dtp_FechaEnt
        '
        Me.dtp_FechaEnt.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaEnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.dtp_FechaEnt.Location = New System.Drawing.Point(116, 186)
        Me.dtp_FechaEnt.Name = "dtp_FechaEnt"
        Me.dtp_FechaEnt.Size = New System.Drawing.Size(367, 26)
        Me.dtp_FechaEnt.TabIndex = 10
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(15, 298)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(160, 20)
        Me.label5.TabIndex = 9
        Me.label5.Text = "Estado de reserva:"
        '
        'cmb_Huesped
        '
        Me.cmb_Huesped.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.cmb_Huesped.FormattingEnabled = True
        Me.cmb_Huesped.Location = New System.Drawing.Point(116, 53)
        Me.cmb_Huesped.Name = "cmb_Huesped"
        Me.cmb_Huesped.Size = New System.Drawing.Size(367, 28)
        Me.cmb_Huesped.TabIndex = 8
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.lblTotal)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.groupBox2.Location = New System.Drawing.Point(538, 166)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(248, 116)
        Me.groupBox2.TabIndex = 17
        Me.groupBox2.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTotal.Location = New System.Drawing.Point(86, 55)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 31)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_Cancelar.FlatAppearance.BorderSize = 3
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancelar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Location = New System.Drawing.Point(619, 388)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(144, 35)
        Me.btn_Cancelar.TabIndex = 16
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
        Me.btn_Guardar.Location = New System.Drawing.Point(619, 334)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(144, 35)
        Me.btn_Guardar.TabIndex = 15
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.hotel_luna
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(538, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(248, 128)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 14
        Me.pictureBox1.TabStop = False
        '
        'cmb_NumHuesped
        '
        Me.cmb_NumHuesped.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.cmb_NumHuesped.FormattingEnabled = True
        Me.cmb_NumHuesped.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cmb_NumHuesped.Location = New System.Drawing.Point(116, 125)
        Me.cmb_NumHuesped.Name = "cmb_NumHuesped"
        Me.cmb_NumHuesped.Size = New System.Drawing.Size(97, 28)
        Me.cmb_NumHuesped.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(15, 231)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(141, 20)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Fecha de salida:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(15, 154)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(156, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Fecha de entrada:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(15, 93)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(194, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Número de huéspedes:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(195, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Seleccione el huésped:"
        '
        'groupBox1
        '
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupBox1.Controls.Add(Me.cmb_Tipo)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.rbtn_Pendiente)
        Me.groupBox1.Controls.Add(Me.rbtn_Pagado)
        Me.groupBox1.Controls.Add(Me.dtp_FechaSal)
        Me.groupBox1.Controls.Add(Me.dtp_FechaEnt)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.cmb_Huesped)
        Me.groupBox1.Controls.Add(Me.cmb_NumHuesped)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(14, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(518, 426)
        Me.groupBox1.TabIndex = 13
        Me.groupBox1.TabStop = False
        '
        'Reservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.fondoplaya
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Reservaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservaciones"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents label7 As Label
    Private WithEvents cmb_Tipo As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents rbtn_Pendiente As RadioButton
    Private WithEvents rbtn_Pagado As RadioButton
    Private WithEvents dtp_FechaSal As DateTimePicker
    Private WithEvents dtp_FechaEnt As DateTimePicker
    Private WithEvents label5 As Label
    Private WithEvents cmb_Huesped As ComboBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents lblTotal As Label
    Private WithEvents btn_Cancelar As Button
    Private WithEvents btn_Guardar As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents cmb_NumHuesped As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents groupBox1 As GroupBox
End Class
