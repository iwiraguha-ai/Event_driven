<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmstapplyform
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        DateTimePicker1 = New DateTimePicker()
        txtnin = New TextBox()
        txtname = New TextBox()
        txtnumber = New TextBox()
        txtaddress = New TextBox()
        cmbcourse = New ComboBox()
        btnapply = New Button()
        btnclear = New Button()
        btnexit = New Button()
        GroupBox1 = New GroupBox()
        rdofemale = New RadioButton()
        rdomale = New RadioButton()
        chkterms = New CheckBox()
        lblcount = New Label()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 20)
        Label1.TabIndex = 0
        Label1.Text = "National ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 1
        Label2.Text = "Full Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 2
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(101, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 3
        Label4.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(101, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 20)
        Label5.TabIndex = 4
        Label5.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(101, 260)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 5
        Label6.Text = "Date of Birth"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(101, 316)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 6
        Label7.Text = "Courses"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(257, 255)
        DateTimePicker1.MaxDate = New Date(2026, 10, 19, 10, 36, 26, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(227, 26)
        DateTimePicker1.TabIndex = 7
        DateTimePicker1.Value = New Date(2026, 10, 16, 0, 0, 0, 0)
        ' 
        ' txtnin
        ' 
        txtnin.ForeColor = SystemColors.MenuHighlight
        txtnin.Location = New Point(257, 31)
        txtnin.Multiline = True
        txtnin.Name = "txtnin"
        txtnin.Size = New Size(227, 23)
        txtnin.TabIndex = 8
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(257, 75)
        txtname.Multiline = True
        txtname.Name = "txtname"
        txtname.Size = New Size(227, 23)
        txtname.TabIndex = 9
        ' 
        ' txtnumber
        ' 
        txtnumber.Location = New Point(257, 163)
        txtnumber.Multiline = True
        txtnumber.Name = "txtnumber"
        txtnumber.Size = New Size(227, 23)
        txtnumber.TabIndex = 10
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(257, 206)
        txtaddress.Multiline = True
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(227, 23)
        txtaddress.TabIndex = 11
        ' 
        ' cmbcourse
        ' 
        cmbcourse.DropDownStyle = ComboBoxStyle.DropDownList
        cmbcourse.FormattingEnabled = True
        cmbcourse.Items.AddRange(New Object() {"Computer Science", "Education", "Information Technology", "Business Accounting", "Business Administration", "Law", "UHEC"})
        cmbcourse.Location = New Point(257, 308)
        cmbcourse.Name = "cmbcourse"
        cmbcourse.Size = New Size(281, 28)
        cmbcourse.TabIndex = 13
        ' 
        ' btnapply
        ' 
        btnapply.Location = New Point(86, 419)
        btnapply.Name = "btnapply"
        btnapply.Size = New Size(75, 29)
        btnapply.TabIndex = 14
        btnapply.Text = "Apply"
        btnapply.UseVisualStyleBackColor = True
        ' 
        ' btnclear
        ' 
        btnclear.Location = New Point(272, 419)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 29)
        btnclear.TabIndex = 15
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(440, 419)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(75, 29)
        btnexit.TabIndex = 16
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.NavajoWhite
        GroupBox1.Controls.Add(rdofemale)
        GroupBox1.Controls.Add(rdomale)
        GroupBox1.Controls.Add(chkterms)
        GroupBox1.Controls.Add(lblcount)
        GroupBox1.Controls.Add(txtnin)
        GroupBox1.Controls.Add(txtname)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cmbcourse)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtnumber)
        GroupBox1.Controls.Add(txtaddress)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btnexit)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnclear)
        GroupBox1.Controls.Add(btnapply)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        GroupBox1.Location = New Point(12, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(645, 470)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Application Form"
        ' 
        ' rdofemale
        ' 
        rdofemale.AutoSize = True
        rdofemale.Location = New Point(362, 118)
        rdofemale.Name = "rdofemale"
        rdofemale.Size = New Size(81, 24)
        rdofemale.TabIndex = 20
        rdofemale.TabStop = True
        rdofemale.Text = "FEMALE"
        rdofemale.UseVisualStyleBackColor = True
        ' 
        ' rdomale
        ' 
        rdomale.AutoSize = True
        rdomale.Location = New Point(257, 118)
        rdomale.Name = "rdomale"
        rdomale.Size = New Size(64, 24)
        rdomale.TabIndex = 19
        rdomale.TabStop = True
        rdomale.Text = "MALE"
        rdomale.UseVisualStyleBackColor = True
        ' 
        ' chkterms
        ' 
        chkterms.AutoSize = True
        chkterms.Location = New Point(304, 363)
        chkterms.Name = "chkterms"
        chkterms.Size = New Size(164, 24)
        chkterms.TabIndex = 18
        chkterms.Text = "Terms and conditions"
        chkterms.UseVisualStyleBackColor = True
        ' 
        ' lblcount
        ' 
        lblcount.Location = New Point(527, 78)
        lblcount.Name = "lblcount"
        lblcount.Size = New Size(103, 45)
        lblcount.TabIndex = 17
        lblcount.Text = "Characters : 0"
        lblcount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.NavajoWhite
        GroupBox2.Location = New Point(663, 74)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(281, 374)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' fmstapplyform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlanchedAlmond
        ClientSize = New Size(956, 524)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.MenuHighlight
        Name = "fmstapplyform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Application Form"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtnin As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents cmbcourse As ComboBox
    Friend WithEvents btnapply As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblcount As Label
    Friend WithEvents chkterms As CheckBox
    Friend WithEvents rdofemale As RadioButton
    Friend WithEvents rdomale As RadioButton
    Friend WithEvents GroupBox2 As GroupBox

End Class
