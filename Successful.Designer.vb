<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmsuccessful
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
        Label1 = New Label()
        Label2 = New Label()
        btnreturn = New Button()
        btnclose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(236, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(288, 115)
        Label1.TabIndex = 0
        Label1.Text = "Student  Registration Successful!"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(281, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 98)
        Label2.TabIndex = 1
        Label2.Text = "Student details "
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnreturn
        ' 
        btnreturn.Location = New Point(236, 322)
        btnreturn.Name = "btnreturn"
        btnreturn.Size = New Size(104, 53)
        btnreturn.TabIndex = 2
        btnreturn.Text = "Return to Application"
        btnreturn.UseVisualStyleBackColor = True
        ' 
        ' btnclose
        ' 
        btnclose.Location = New Point(439, 322)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(85, 53)
        btnclose.TabIndex = 3
        btnclose.Text = "Close"
        btnclose.UseVisualStyleBackColor = True
        ' 
        ' fmsuccessful
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(721, 482)
        Controls.Add(btnclose)
        Controls.Add(btnreturn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "fmsuccessful"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Successful"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnreturn As Button
    Friend WithEvents btnclose As Button
End Class
