<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Tipo = New System.Windows.Forms.TextBox()
        Me.pic_Tipo = New System.Windows.Forms.PictureBox()
        Me.txt_Precio = New System.Windows.Forms.TextBox()
        Me.txt_NumHabitacion = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Primero = New System.Windows.Forms.Button()
        Me.btn_Ultimo = New System.Windows.Forms.Button()
        Me.btn_Siguiente = New System.Windows.Forms.Button()
        Me.btn_Anterior = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Hotel_ReservasDataSet = New Metodo1_Hotel.Hotel_ReservasDataSet()
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionesTableAdapter = New Metodo1_Hotel.Hotel_ReservasDataSetTableAdapters.HabitacionesTableAdapter()
        Me.groupBox1.SuspendLayout()
        CType(Me.pic_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotel_ReservasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Buscar.BackgroundImage = Global.Metodo1_Hotel.My.Resources.Resources.Lupa
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
        Me.txt_Tipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionesBindingSource, "Tipo", True))
        Me.txt_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Tipo.Location = New System.Drawing.Point(58, 133)
        Me.txt_Tipo.Name = "txt_Tipo"
        Me.txt_Tipo.ReadOnly = True
        Me.txt_Tipo.Size = New System.Drawing.Size(204, 26)
        Me.txt_Tipo.TabIndex = 13
        '
        'pic_Tipo
        '
        Me.pic_Tipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Tipo.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.HabitacionesBindingSource, "Foto", True))
        Me.pic_Tipo.Location = New System.Drawing.Point(295, 46)
        Me.pic_Tipo.Name = "pic_Tipo"
        Me.pic_Tipo.Size = New System.Drawing.Size(175, 175)
        Me.pic_Tipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Tipo.TabIndex = 10
        Me.pic_Tipo.TabStop = False
        '
        'txt_Precio
        '
        Me.txt_Precio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionesBindingSource, "Precio", True))
        Me.txt_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Precio.Location = New System.Drawing.Point(58, 197)
        Me.txt_Precio.Name = "txt_Precio"
        Me.txt_Precio.Size = New System.Drawing.Size(204, 26)
        Me.txt_Precio.TabIndex = 6
        '
        'txt_NumHabitacion
        '
        Me.txt_NumHabitacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionesBindingSource, "Num_habitacion", True))
        Me.txt_NumHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_NumHabitacion.Location = New System.Drawing.Point(58, 65)
        Me.txt_NumHabitacion.Name = "txt_NumHabitacion"
        Me.txt_NumHabitacion.Size = New System.Drawing.Size(112, 26)
        Me.txt_NumHabitacion.TabIndex = 4
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
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(189, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Número de habitación:"
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btn_Salir.FlatAppearance.BorderSize = 3
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(603, 194)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(112, 35)
        Me.btn_Salir.TabIndex = 29
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Primero
        '
        Me.btn_Primero.BackColor = System.Drawing.Color.Yellow
        Me.btn_Primero.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.btn_Primero.FlatAppearance.BorderSize = 3
        Me.btn_Primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Primero.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Primero.Location = New System.Drawing.Point(669, 277)
        Me.btn_Primero.Name = "btn_Primero"
        Me.btn_Primero.Size = New System.Drawing.Size(112, 35)
        Me.btn_Primero.TabIndex = 28
        Me.btn_Primero.Text = "Primero"
        Me.btn_Primero.UseVisualStyleBackColor = False
        '
        'btn_Ultimo
        '
        Me.btn_Ultimo.BackColor = System.Drawing.Color.Blue
        Me.btn_Ultimo.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.btn_Ultimo.FlatAppearance.BorderSize = 3
        Me.btn_Ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ultimo.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ultimo.Location = New System.Drawing.Point(533, 277)
        Me.btn_Ultimo.Name = "btn_Ultimo"
        Me.btn_Ultimo.Size = New System.Drawing.Size(112, 35)
        Me.btn_Ultimo.TabIndex = 27
        Me.btn_Ultimo.Text = "Ultimo"
        Me.btn_Ultimo.UseVisualStyleBackColor = False
        '
        'btn_Siguiente
        '
        Me.btn_Siguiente.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btn_Siguiente.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btn_Siguiente.FlatAppearance.BorderSize = 3
        Me.btn_Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Siguiente.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Siguiente.Location = New System.Drawing.Point(669, 236)
        Me.btn_Siguiente.Name = "btn_Siguiente"
        Me.btn_Siguiente.Size = New System.Drawing.Size(112, 35)
        Me.btn_Siguiente.TabIndex = 26
        Me.btn_Siguiente.Text = "Siguiente"
        Me.btn_Siguiente.UseVisualStyleBackColor = False
        '
        'btn_Anterior
        '
        Me.btn_Anterior.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_Anterior.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btn_Anterior.FlatAppearance.BorderSize = 3
        Me.btn_Anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Anterior.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Anterior.Location = New System.Drawing.Point(533, 236)
        Me.btn_Anterior.Name = "btn_Anterior"
        Me.btn_Anterior.Size = New System.Drawing.Size(112, 35)
        Me.btn_Anterior.TabIndex = 25
        Me.btn_Anterior.Text = "Anterior"
        Me.btn_Anterior.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = Global.Metodo1_Hotel.My.Resources.Resources.hotel_luna
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(533, 37)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(248, 128)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 24
        Me.pictureBox1.TabStop = False
        '
        'Hotel_ReservasDataSet
        '
        Me.Hotel_ReservasDataSet.DataSetName = "Hotel_ReservasDataSet"
        Me.Hotel_ReservasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HabitacionesBindingSource
        '
        Me.HabitacionesBindingSource.DataMember = "Habitaciones"
        Me.HabitacionesBindingSource.DataSource = Me.Hotel_ReservasDataSet
        '
        'HabitacionesTableAdapter
        '
        Me.HabitacionesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Metodo1_Hotel.My.Resources.Resources.fondoplaya
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 360)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Primero)
        Me.Controls.Add(Me.btn_Ultimo)
        Me.Controls.Add(Me.btn_Siguiente)
        Me.Controls.Add(Me.btn_Anterior)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pic_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotel_ReservasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btn_Buscar As Button
    Private WithEvents txt_Tipo As TextBox
    Friend WithEvents pic_Tipo As PictureBox
    Private WithEvents txt_Precio As TextBox
    Private WithEvents txt_NumHabitacion As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btn_Salir As Button
    Private WithEvents btn_Primero As Button
    Private WithEvents btn_Ultimo As Button
    Private WithEvents btn_Siguiente As Button
    Private WithEvents btn_Anterior As Button
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents Hotel_ReservasDataSet As Hotel_ReservasDataSet
    Friend WithEvents HabitacionesBindingSource As BindingSource
    Friend WithEvents HabitacionesTableAdapter As Hotel_ReservasDataSetTableAdapters.HabitacionesTableAdapter
End Class
