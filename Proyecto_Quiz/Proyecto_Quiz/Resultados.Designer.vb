<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultados
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
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.lvl_Resultado = New System.Windows.Forms.Label()
        Me.pbx_Result = New System.Windows.Forms.PictureBox()
        CType(Me.pbx_Result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Location = New System.Drawing.Point(157, 242)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(136, 48)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lvl_Resultado
        '
        Me.lvl_Resultado.AutoSize = True
        Me.lvl_Resultado.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvl_Resultado.Location = New System.Drawing.Point(101, 9)
        Me.lvl_Resultado.Name = "lvl_Resultado"
        Me.lvl_Resultado.Size = New System.Drawing.Size(114, 26)
        Me.lvl_Resultado.TabIndex = 2
        Me.lvl_Resultado.Text = "Resultado"
        '
        'pbx_Result
        '
        Me.pbx_Result.Location = New System.Drawing.Point(145, 70)
        Me.pbx_Result.Name = "pbx_Result"
        Me.pbx_Result.Size = New System.Drawing.Size(169, 153)
        Me.pbx_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Result.TabIndex = 3
        Me.pbx_Result.TabStop = False
        '
        'Resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 312)
        Me.Controls.Add(Me.pbx_Result)
        Me.Controls.Add(Me.lvl_Resultado)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Resultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados"
        CType(Me.pbx_Result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents lvl_Resultado As Label
    Friend WithEvents pbx_Result As PictureBox
End Class
