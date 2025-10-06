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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Num_habitacionLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Me.Hotel_ReservasDataSet = New Metodo2_Hotel.Hotel_ReservasDataSet()
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionesTableAdapter = New Metodo2_Hotel.Hotel_ReservasDataSetTableAdapters.HabitacionesTableAdapter()
        Me.TableAdapterManager = New Metodo2_Hotel.Hotel_ReservasDataSetTableAdapters.TableAdapterManager()
        Me.HabitacionesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.HabitacionesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Num_habitacionTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.pic_Tipo = New System.Windows.Forms.PictureBox()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Num_habitacionLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.Hotel_ReservasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HabitacionesBindingNavigator.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.pic_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Metodo2_Hotel.Hotel_ReservasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HabitacionesBindingNavigator
        '
        Me.HabitacionesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HabitacionesBindingNavigator.BindingSource = Me.HabitacionesBindingSource
        Me.HabitacionesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HabitacionesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HabitacionesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HabitacionesBindingNavigatorSaveItem})
        Me.HabitacionesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HabitacionesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HabitacionesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HabitacionesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HabitacionesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HabitacionesBindingNavigator.Name = "HabitacionesBindingNavigator"
        Me.HabitacionesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HabitacionesBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.HabitacionesBindingNavigator.TabIndex = 0
        Me.HabitacionesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'HabitacionesBindingNavigatorSaveItem
        '
        Me.HabitacionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HabitacionesBindingNavigatorSaveItem.Enabled = False
        Me.HabitacionesBindingNavigatorSaveItem.Image = CType(resources.GetObject("HabitacionesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HabitacionesBindingNavigatorSaveItem.Name = "HabitacionesBindingNavigatorSaveItem"
        Me.HabitacionesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.HabitacionesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Num_habitacionLabel
        '
        Num_habitacionLabel.AutoSize = True
        Num_habitacionLabel.Location = New System.Drawing.Point(6, 22)
        Num_habitacionLabel.Name = "Num_habitacionLabel"
        Num_habitacionLabel.Size = New System.Drawing.Size(138, 20)
        Num_habitacionLabel.TabIndex = 3
        Num_habitacionLabel.Text = "Num habitacion:"
        '
        'Num_habitacionTextBox
        '
        Me.Num_habitacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionesBindingSource, "Num_habitacion", True))
        Me.Num_habitacionTextBox.Location = New System.Drawing.Point(61, 65)
        Me.Num_habitacionTextBox.Name = "Num_habitacionTextBox"
        Me.Num_habitacionTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Num_habitacionTextBox.TabIndex = 4
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(7, 108)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(48, 20)
        TipoLabel.TabIndex = 5
        TipoLabel.Text = "Tipo:"
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionesBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(61, 134)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(183, 26)
        Me.TipoTextBox.TabIndex = 6
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(15, 176)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(64, 20)
        PrecioLabel.TabIndex = 7
        PrecioLabel.Text = "Precio:"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionesBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(61, 199)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(183, 26)
        Me.PrecioTextBox.TabIndex = 8
        '
        'groupBox1
        '
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupBox1.Controls.Add(Me.btn_Buscar)
        Me.groupBox1.Controls.Add(Me.pic_Tipo)
        Me.groupBox1.Controls.Add(Num_habitacionLabel)
        Me.groupBox1.Controls.Add(Me.Num_habitacionTextBox)
        Me.groupBox1.Controls.Add(TipoLabel)
        Me.groupBox1.Controls.Add(Me.TipoTextBox)
        Me.groupBox1.Controls.Add(PrecioLabel)
        Me.groupBox1.Controls.Add(Me.PrecioTextBox)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(23, 64)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(491, 252)
        Me.groupBox1.TabIndex = 30
        Me.groupBox1.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Buscar.BackgroundImage = Global.Metodo2_Hotel.My.Resources.Resources.Lupa
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
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btn_Salir.FlatAppearance.BorderSize = 3
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(602, 292)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(112, 35)
        Me.btn_Salir.TabIndex = 36
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = Global.Metodo2_Hotel.My.Resources.Resources.hotel_luna
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(540, 51)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(248, 128)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 31
        Me.pictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Metodo2_Hotel.My.Resources.Resources.fondoplaya
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 360)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.HabitacionesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Hotel_ReservasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HabitacionesBindingNavigator.ResumeLayout(False)
        Me.HabitacionesBindingNavigator.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pic_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hotel_ReservasDataSet As Hotel_ReservasDataSet
    Friend WithEvents HabitacionesBindingSource As BindingSource
    Friend WithEvents HabitacionesTableAdapter As Hotel_ReservasDataSetTableAdapters.HabitacionesTableAdapter
    Friend WithEvents TableAdapterManager As Hotel_ReservasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HabitacionesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents HabitacionesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Num_habitacionTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btn_Buscar As Button
    Friend WithEvents pic_Tipo As PictureBox
    Private WithEvents btn_Salir As Button
    Private WithEvents pictureBox1 As PictureBox
End Class
