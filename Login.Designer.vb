<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnlogin = New Button()
        btnsignup = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnsignup)
        Panel1.Controls.Add(btnlogin)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' btnlogin
        ' 
        btnlogin.Location = New Point(200, 295)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(110, 43)
        btnlogin.TabIndex = 0
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' btnsignup
        ' 
        btnsignup.Location = New Point(451, 295)
        btnsignup.Name = "btnsignup"
        btnsignup.Size = New Size(110, 43)
        btnsignup.TabIndex = 1
        btnsignup.Text = "Sign Up"
        btnsignup.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlanchedAlmond
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Login"
        Text = "Login"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsignup As Button
    Friend WithEvents btnlogin As Button
End Class
