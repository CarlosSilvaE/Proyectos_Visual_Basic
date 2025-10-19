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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirTsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Socio = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Socio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.GreenYellow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoTsm, Me.ConsultarTsm, Me.AgregarTsm, Me.ModificarTsm, Me.EliminarTsm, Me.SalirTsm})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(500, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoTsm
        '
        Me.NuevoTsm.Name = "NuevoTsm"
        Me.NuevoTsm.Size = New System.Drawing.Size(54, 20)
        Me.NuevoTsm.Text = "Nuevo"
        '
        'ConsultarTsm
        '
        Me.ConsultarTsm.Name = "ConsultarTsm"
        Me.ConsultarTsm.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarTsm.Text = "Consultar"
        '
        'AgregarTsm
        '
        Me.AgregarTsm.Name = "AgregarTsm"
        Me.AgregarTsm.Size = New System.Drawing.Size(61, 20)
        Me.AgregarTsm.Text = "Agregar"
        '
        'ModificarTsm
        '
        Me.ModificarTsm.Name = "ModificarTsm"
        Me.ModificarTsm.Size = New System.Drawing.Size(70, 20)
        Me.ModificarTsm.Text = "Modificar"
        '
        'EliminarTsm
        '
        Me.EliminarTsm.Name = "EliminarTsm"
        Me.EliminarTsm.Size = New System.Drawing.Size(62, 20)
        Me.EliminarTsm.Text = "Eliminar"
        '
        'SalirTsm
        '
        Me.SalirTsm.Name = "SalirTsm"
        Me.SalirTsm.Size = New System.Drawing.Size(41, 20)
        Me.SalirTsm.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Telefono"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(182, 28)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(236, 26)
        Me.txtId.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(182, 89)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(236, 26)
        Me.txtNombre.TabIndex = 7
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(182, 147)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(236, 26)
        Me.txtApellido.TabIndex = 8
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(182, 203)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(236, 26)
        Me.txtDireccion.TabIndex = 9
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(182, 262)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(236, 26)
        Me.txtTelefono.TabIndex = 10
        '
        'Socio
        '
        Me.Socio.Controls.Add(Me.txtId)
        Me.Socio.Controls.Add(Me.txtTelefono)
        Me.Socio.Controls.Add(Me.Label1)
        Me.Socio.Controls.Add(Me.txtDireccion)
        Me.Socio.Controls.Add(Me.Label2)
        Me.Socio.Controls.Add(Me.txtApellido)
        Me.Socio.Controls.Add(Me.Label3)
        Me.Socio.Controls.Add(Me.txtNombre)
        Me.Socio.Controls.Add(Me.Label4)
        Me.Socio.Controls.Add(Me.Label5)
        Me.Socio.Location = New System.Drawing.Point(12, 46)
        Me.Socio.Name = "Socio"
        Me.Socio.Size = New System.Drawing.Size(466, 310)
        Me.Socio.TabIndex = 11
        Me.Socio.TabStop = False
        Me.Socio.Text = "Socio"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(500, 403)
        Me.Controls.Add(Me.Socio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Socio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Socio.ResumeLayout(False)
        Me.Socio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoTsm As ToolStripMenuItem
    Friend WithEvents ConsultarTsm As ToolStripMenuItem
    Friend WithEvents AgregarTsm As ToolStripMenuItem
    Friend WithEvents ModificarTsm As ToolStripMenuItem
    Friend WithEvents EliminarTsm As ToolStripMenuItem
    Friend WithEvents SalirTsm As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Socio As GroupBox
End Class
