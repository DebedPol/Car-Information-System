<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        EnterBtn = New Button()
        ExitBtn = New Button()
        UsernameTextField = New TextBox()
        PasswordTextField = New TextBox()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        SuspendLayout()
        ' 
        ' EnterBtn
        ' 
        EnterBtn.Location = New Point(217, 153)
        EnterBtn.Name = "EnterBtn"
        EnterBtn.Size = New Size(114, 29)
        EnterBtn.TabIndex = 0
        EnterBtn.Text = "Enter"
        EnterBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Location = New Point(337, 153)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(108, 29)
        ExitBtn.TabIndex = 1
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' UsernameTextField
        ' 
        UsernameTextField.Location = New Point(217, 62)
        UsernameTextField.Name = "UsernameTextField"
        UsernameTextField.Size = New Size(228, 27)
        UsernameTextField.TabIndex = 2
        ' 
        ' PasswordTextField
        ' 
        PasswordTextField.Location = New Point(217, 109)
        PasswordTextField.Name = "PasswordTextField"
        PasswordTextField.PasswordChar = "*"c
        PasswordTextField.Size = New Size(228, 27)
        PasswordTextField.TabIndex = 3
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New Point(217, 39)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(78, 20)
        UsernameLabel.TabIndex = 4
        UsernameLabel.Text = "Username:"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New Point(217, 90)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(70, 20)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(PasswordTextField)
        Controls.Add(UsernameTextField)
        Controls.Add(ExitBtn)
        Controls.Add(EnterBtn)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EnterBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents UsernameTextField As TextBox
    Friend WithEvents PasswordTextField As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label

End Class
