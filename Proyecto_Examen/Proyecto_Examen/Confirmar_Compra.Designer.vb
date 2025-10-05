<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirmar_Compra
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
        Me.txt_Pedidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.btn_Confirmar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedido"
        '
        'txt_Pedidos
        '
        Me.txt_Pedidos.Location = New System.Drawing.Point(12, 44)
        Me.txt_Pedidos.Multiline = True
        Me.txt_Pedidos.Name = "txt_Pedidos"
        Me.txt_Pedidos.ReadOnly = True
        Me.txt_Pedidos.Size = New System.Drawing.Size(312, 316)
        Me.txt_Pedidos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total"
        '
        'txt_Total
        '
        Me.txt_Total.Location = New System.Drawing.Point(191, 368)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(133, 20)
        Me.txt_Total.TabIndex = 3
        '
        'Regresar
        '
        Me.Regresar.Location = New System.Drawing.Point(12, 402)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(111, 36)
        Me.Regresar.TabIndex = 4
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'btn_Confirmar
        '
        Me.btn_Confirmar.Location = New System.Drawing.Point(213, 402)
        Me.btn_Confirmar.Name = "btn_Confirmar"
        Me.btn_Confirmar.Size = New System.Drawing.Size(111, 36)
        Me.btn_Confirmar.TabIndex = 5
        Me.btn_Confirmar.Text = "Confirmar"
        Me.btn_Confirmar.UseVisualStyleBackColor = True
        '
        'Confirmar_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 450)
        Me.Controls.Add(Me.btn_Confirmar)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Pedidos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Confirmar_Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar_Compra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Pedidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents Regresar As Button
    Friend WithEvents btn_Confirmar As Button
End Class
