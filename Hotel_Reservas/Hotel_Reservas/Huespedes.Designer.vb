<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Huespedes
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
        Me.txt_Correo = New System.Windows.Forms.TextBox()
        Me.txt_Tel = New System.Windows.Forms.TextBox()
        Me.txt_DNI = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupBox1.Controls.Add(Me.txt_Correo)
        Me.groupBox1.Controls.Add(Me.txt_Tel)
        Me.groupBox1.Controls.Add(Me.txt_DNI)
        Me.groupBox1.Controls.Add(Me.txt_Nombre)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(20, 26)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(491, 320)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        '
        'txt_Correo
        '
        Me.txt_Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Correo.Location = New System.Drawing.Point(67, 266)
        Me.txt_Correo.Name = "txt_Correo"
        Me.txt_Correo.Size = New System.Drawing.Size(303, 26)
        Me.txt_Correo.TabIndex = 7
        '
        'txt_Tel
        '
        Me.txt_Tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Tel.Location = New System.Drawing.Point(67, 184)
        Me.txt_Tel.Name = "txt_Tel"
        Me.txt_Tel.Size = New System.Drawing.Size(303, 26)
        Me.txt_Tel.TabIndex = 6
        '
        'txt_DNI
        '
        Me.txt_DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_DNI.Location = New System.Drawing.Point(67, 115)
        Me.txt_DNI.Name = "txt_DNI"
        Me.txt_DNI.Size = New System.Drawing.Size(303, 26)
        Me.txt_DNI.TabIndex = 5
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Nombre.Location = New System.Drawing.Point(67, 52)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(405, 26)
        Me.txt_Nombre.TabIndex = 4
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(15, 231)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(163, 20)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Correo Electrónico:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(15, 154)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(84, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Teléfono:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(15, 93)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "DNI:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(76, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Nombre:"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_Cancelar.FlatAppearance.BorderSize = 3
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancelar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Location = New System.Drawing.Point(601, 292)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(144, 35)
        Me.btn_Cancelar.TabIndex = 7
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.Color.Yellow
        Me.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_Guardar.FlatAppearance.BorderSize = 3
        Me.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Guardar.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.Location = New System.Drawing.Point(601, 229)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(144, 35)
        Me.btn_Guardar.TabIndex = 6
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.hotel_luna
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(533, 26)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(248, 128)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'Huespedes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Reservas.My.Resources.Resources.fondoplaya
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 372)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Huespedes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Huespedes"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txt_Correo As TextBox
    Private WithEvents txt_Tel As TextBox
    Private WithEvents txt_DNI As TextBox
    Private WithEvents txt_Nombre As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btn_Cancelar As Button
    Private WithEvents btn_Guardar As Button
    Private WithEvents pictureBox1 As PictureBox
End Class
