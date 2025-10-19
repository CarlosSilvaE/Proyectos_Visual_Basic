<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Videogames
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
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.NuevoTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.consultarTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificarTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.salirTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCompañia = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Menu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoTsm, Me.AgregarTsm, Me.consultarTsm, Me.modificarTsm, Me.eliminarTsm, Me.salirTsm})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(776, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'NuevoTsm
        '
        Me.NuevoTsm.Image = Global.App_Videogames.My.Resources.Resources.limpiar
        Me.NuevoTsm.Name = "NuevoTsm"
        Me.NuevoTsm.Size = New System.Drawing.Size(70, 20)
        Me.NuevoTsm.Text = "Nuevo"
        '
        'AgregarTsm
        '
        Me.AgregarTsm.Image = Global.App_Videogames.My.Resources.Resources.nuevo
        Me.AgregarTsm.Name = "AgregarTsm"
        Me.AgregarTsm.Size = New System.Drawing.Size(77, 20)
        Me.AgregarTsm.Text = "Agregar"
        '
        'consultarTsm
        '
        Me.consultarTsm.Image = Global.App_Videogames.My.Resources.Resources.consultar
        Me.consultarTsm.Name = "consultarTsm"
        Me.consultarTsm.Size = New System.Drawing.Size(86, 20)
        Me.consultarTsm.Text = "Consultar"
        '
        'modificarTsm
        '
        Me.modificarTsm.Image = Global.App_Videogames.My.Resources.Resources.modificar
        Me.modificarTsm.Name = "modificarTsm"
        Me.modificarTsm.Size = New System.Drawing.Size(86, 20)
        Me.modificarTsm.Text = "Modificar"
        '
        'eliminarTsm
        '
        Me.eliminarTsm.Image = Global.App_Videogames.My.Resources.Resources.eliminar
        Me.eliminarTsm.Name = "eliminarTsm"
        Me.eliminarTsm.Size = New System.Drawing.Size(78, 20)
        Me.eliminarTsm.Text = "Eliminar"
        '
        'salirTsm
        '
        Me.salirTsm.Image = Global.App_Videogames.My.Resources.Resources.salir
        Me.salirTsm.Name = "salirTsm"
        Me.salirTsm.Size = New System.Drawing.Size(57, 20)
        Me.salirTsm.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtCompañia)
        Me.GroupBox1.Controls.Add(Me.txtGenero)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 426)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Videogames"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(155, 277)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(203, 20)
        Me.txtPrecio.TabIndex = 9
        '
        'txtCompañia
        '
        Me.txtCompañia.Location = New System.Drawing.Point(155, 234)
        Me.txtCompañia.Name = "txtCompañia"
        Me.txtCompañia.Size = New System.Drawing.Size(203, 20)
        Me.txtCompañia.TabIndex = 8
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(155, 189)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(203, 20)
        Me.txtGenero.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(155, 143)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(203, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(155, 98)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(203, 20)
        Me.txtId.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(49, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(49, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Compañia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(49, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Genero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(49, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(49, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Videogames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.App_Videogames.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.Menu
        Me.Name = "Videogames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Videogames"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents NuevoTsm As ToolStripMenuItem
    Friend WithEvents AgregarTsm As ToolStripMenuItem
    Friend WithEvents consultarTsm As ToolStripMenuItem
    Friend WithEvents modificarTsm As ToolStripMenuItem
    Friend WithEvents eliminarTsm As ToolStripMenuItem
    Friend WithEvents salirTsm As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCompañia As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
