<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
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
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbtel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbcui = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbcontra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbuser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbcontra1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbdirec = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(157, 20)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(308, 22)
        Me.tbname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Teléfono"
        '
        'tbtel
        '
        Me.tbtel.Location = New System.Drawing.Point(157, 55)
        Me.tbtel.Name = "tbtel"
        Me.tbtel.Size = New System.Drawing.Size(308, 22)
        Me.tbtel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(9, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CUI"
        '
        'tbcui
        '
        Me.tbcui.Location = New System.Drawing.Point(157, 90)
        Me.tbcui.Name = "tbcui"
        Me.tbcui.Size = New System.Drawing.Size(308, 22)
        Me.tbcui.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(9, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirmar contraseña"
        '
        'tbcontra
        '
        Me.tbcontra.Location = New System.Drawing.Point(157, 160)
        Me.tbcontra.Name = "tbcontra"
        Me.tbcontra.Size = New System.Drawing.Size(308, 22)
        Me.tbcontra.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(9, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Usuario"
        '
        'tbuser
        '
        Me.tbuser.Location = New System.Drawing.Point(157, 125)
        Me.tbuser.Name = "tbuser"
        Me.tbuser.Size = New System.Drawing.Size(308, 22)
        Me.tbuser.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(9, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Contraseña"
        '
        'tbcontra1
        '
        Me.tbcontra1.Location = New System.Drawing.Point(157, 195)
        Me.tbcontra1.Name = "tbcontra1"
        Me.tbcontra1.Size = New System.Drawing.Size(308, 22)
        Me.tbcontra1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(12, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(453, 40)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(9, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(961, 40)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(35, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(312, 24)
        Me.ComboBox1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(38, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Municipio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(32, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(35, 173)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(377, 40)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Registrarse"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbdirec)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(527, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 239)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tienda"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.tbname)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tbcontra1)
        Me.GroupBox2.Controls.Add(Me.tbtel)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbuser)
        Me.GroupBox2.Controls.Add(Me.tbcui)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tbcontra)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 298)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del usuario"
        '
        'tbdirec
        '
        Me.tbdirec.Location = New System.Drawing.Point(35, 130)
        Me.tbdirec.Name = "tbdirec"
        Me.tbdirec.Size = New System.Drawing.Size(312, 22)
        Me.tbdirec.TabIndex = 19
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(988, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbtel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbcui As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbcontra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbuser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbcontra1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbdirec As TextBox
End Class
