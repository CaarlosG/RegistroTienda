<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menuinicio
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbtienda = New System.Windows.Forms.TextBox()
        Me.tbencargado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(166, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(159, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cerrar sesión"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(12, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(783, 53)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Menú produtos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(12, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(783, 53)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Registrar ventas"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(537, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tienda:"
        '
        'tbtienda
        '
        Me.tbtienda.BackColor = System.Drawing.Color.DarkSlateGray
        Me.tbtienda.ForeColor = System.Drawing.SystemColors.Control
        Me.tbtienda.Location = New System.Drawing.Point(599, 21)
        Me.tbtienda.Name = "tbtienda"
        Me.tbtienda.ReadOnly = True
        Me.tbtienda.Size = New System.Drawing.Size(196, 22)
        Me.tbtienda.TabIndex = 6
        '
        'tbencargado
        '
        Me.tbencargado.BackColor = System.Drawing.Color.DarkSlateGray
        Me.tbencargado.ForeColor = System.Drawing.SystemColors.Control
        Me.tbencargado.Location = New System.Drawing.Point(12, 21)
        Me.tbencargado.Name = "tbencargado"
        Me.tbencargado.ReadOnly = True
        Me.tbencargado.Size = New System.Drawing.Size(148, 22)
        Me.tbencargado.TabIndex = 7
        '
        'Menuinicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(807, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbencargado)
        Me.Controls.Add(Me.tbtienda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Menuinicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbtienda As TextBox
    Friend WithEvents tbencargado As TextBox
End Class
