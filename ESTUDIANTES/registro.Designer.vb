<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Regname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Reguser = New System.Windows.Forms.TextBox()
        Me.Regemail = New System.Windows.Forms.TextBox()
        Me.Regpass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(360, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "REGISTRARSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Regname
        '
        Me.Regname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Regname.Location = New System.Drawing.Point(360, 127)
        Me.Regname.Name = "Regname"
        Me.Regname.Size = New System.Drawing.Size(185, 26)
        Me.Regname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(215, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(215, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "USUARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(215, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "EMAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(215, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CONTRASEÑA"
        '
        'Reguser
        '
        Me.Reguser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Reguser.Location = New System.Drawing.Point(360, 196)
        Me.Reguser.Name = "Reguser"
        Me.Reguser.Size = New System.Drawing.Size(185, 26)
        Me.Reguser.TabIndex = 7
        '
        'Regemail
        '
        Me.Regemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Regemail.Location = New System.Drawing.Point(360, 257)
        Me.Regemail.Name = "Regemail"
        Me.Regemail.Size = New System.Drawing.Size(185, 26)
        Me.Regemail.TabIndex = 8
        '
        'Regpass
        '
        Me.Regpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Regpass.Location = New System.Drawing.Point(360, 310)
        Me.Regpass.Name = "Regpass"
        Me.Regpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Regpass.Size = New System.Drawing.Size(185, 26)
        Me.Regpass.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label5.Location = New System.Drawing.Point(341, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 37)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "REGISTRO"
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Regpass)
        Me.Controls.Add(Me.Regemail)
        Me.Controls.Add(Me.Reguser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Regname)
        Me.Controls.Add(Me.Button1)
        Me.Name = "registro"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Regname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Reguser As TextBox
    Friend WithEvents Regemail As TextBox
    Friend WithEvents Regpass As TextBox
    Friend WithEvents Label5 As Label
End Class
