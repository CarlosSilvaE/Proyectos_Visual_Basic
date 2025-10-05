<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenida
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Comenzar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.gbx_Tema = New System.Windows.Forms.GroupBox()
        Me.pbx_Tema = New System.Windows.Forms.PictureBox()
        Me.rdn_Geografia = New System.Windows.Forms.RadioButton()
        Me.rdn_Historia = New System.Windows.Forms.RadioButton()
        Me.gbx_Tema.SuspendLayout()
        CType(Me.pbx_Tema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido al Quiz"
        '
        'btn_Comenzar
        '
        Me.btn_Comenzar.Location = New System.Drawing.Point(170, 218)
        Me.btn_Comenzar.Name = "btn_Comenzar"
        Me.btn_Comenzar.Size = New System.Drawing.Size(110, 38)
        Me.btn_Comenzar.TabIndex = 1
        Me.btn_Comenzar.Text = "Comenzar"
        Me.btn_Comenzar.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Location = New System.Drawing.Point(170, 262)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(110, 38)
        Me.btn_Salir.TabIndex = 2
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'gbx_Tema
        '
        Me.gbx_Tema.Controls.Add(Me.pbx_Tema)
        Me.gbx_Tema.Controls.Add(Me.rdn_Geografia)
        Me.gbx_Tema.Controls.Add(Me.rdn_Historia)
        Me.gbx_Tema.Location = New System.Drawing.Point(52, 48)
        Me.gbx_Tema.Name = "gbx_Tema"
        Me.gbx_Tema.Size = New System.Drawing.Size(340, 144)
        Me.gbx_Tema.TabIndex = 3
        Me.gbx_Tema.TabStop = False
        Me.gbx_Tema.Text = "Seleccione el tema"
        '
        'pbx_Tema
        '
        Me.pbx_Tema.Location = New System.Drawing.Point(191, 15)
        Me.pbx_Tema.Name = "pbx_Tema"
        Me.pbx_Tema.Size = New System.Drawing.Size(131, 119)
        Me.pbx_Tema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Tema.TabIndex = 2
        Me.pbx_Tema.TabStop = False
        '
        'rdn_Geografia
        '
        Me.rdn_Geografia.AutoSize = True
        Me.rdn_Geografia.Location = New System.Drawing.Point(65, 76)
        Me.rdn_Geografia.Name = "rdn_Geografia"
        Me.rdn_Geografia.Size = New System.Drawing.Size(71, 17)
        Me.rdn_Geografia.TabIndex = 1
        Me.rdn_Geografia.TabStop = True
        Me.rdn_Geografia.Text = "Geografia"
        Me.rdn_Geografia.UseVisualStyleBackColor = True
        '
        'rdn_Historia
        '
        Me.rdn_Historia.AutoSize = True
        Me.rdn_Historia.Location = New System.Drawing.Point(65, 53)
        Me.rdn_Historia.Name = "rdn_Historia"
        Me.rdn_Historia.Size = New System.Drawing.Size(60, 17)
        Me.rdn_Historia.TabIndex = 0
        Me.rdn_Historia.TabStop = True
        Me.rdn_Historia.Text = "Historia"
        Me.rdn_Historia.UseVisualStyleBackColor = True
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 312)
        Me.Controls.Add(Me.gbx_Tema)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Comenzar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Bienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenida"
        Me.gbx_Tema.ResumeLayout(False)
        Me.gbx_Tema.PerformLayout()
        CType(Me.pbx_Tema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Comenzar As Button
    Friend WithEvents btn_Salir As Button
    Friend WithEvents gbx_Tema As GroupBox
    Friend WithEvents pbx_Tema As PictureBox
    Friend WithEvents rdn_Geografia As RadioButton
    Friend WithEvents rdn_Historia As RadioButton
End Class
