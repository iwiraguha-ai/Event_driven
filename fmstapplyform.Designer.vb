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
        cmbcountry = New ComboBox()
        Label11 = New Label()
        rdofemale = New RadioButton()
        rdomale = New RadioButton()
        chkterms = New CheckBox()
        lblcount = New Label()
        grppersonal = New GroupBox()
        txtguardiancontact = New TextBox()
        Label10 = New Label()
        txtrelation = New TextBox()
        Label9 = New Label()
        txtguardian = New TextBox()
        Label8 = New Label()
        Panel1 = New Panel()
        GroupBox1.SuspendLayout()
        grppersonal.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(87, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 20)
        Label1.TabIndex = 0
        Label1.Text = "National ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(87, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 1
        Label2.Text = "Full Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(87, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 2
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(87, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 3
        Label4.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(101, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 20)
        Label5.TabIndex = 4
        Label5.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(87, 331)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 5
        Label6.Text = "Date of Birth"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(95, 392)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 6
        Label7.Text = "Courses"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(257, 325)
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
        txtnumber.Location = New Point(257, 220)
        txtnumber.Multiline = True
        txtnumber.Name = "txtnumber"
        txtnumber.Size = New Size(227, 23)
        txtnumber.TabIndex = 10
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(257, 269)
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
        cmbcourse.Location = New Point(257, 384)
        cmbcourse.Name = "cmbcourse"
        cmbcourse.Size = New Size(281, 28)
        cmbcourse.TabIndex = 13
        ' 
        ' btnapply
        ' 
        btnapply.Anchor = AnchorStyles.Bottom
        btnapply.Location = New Point(101, 490)
        btnapply.Name = "btnapply"
        btnapply.Size = New Size(75, 29)
        btnapply.TabIndex = 14
        btnapply.Text = "Apply"
        btnapply.UseVisualStyleBackColor = True
        ' 
        ' btnclear
        ' 
        btnclear.Anchor = AnchorStyles.Bottom
        btnclear.Location = New Point(280, 490)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 29)
        btnclear.TabIndex = 15
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' btnexit
        ' 
        btnexit.Anchor = AnchorStyles.Bottom
        btnexit.Location = New Point(444, 490)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(75, 29)
        btnexit.TabIndex = 16
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.BackColor = Color.NavajoWhite
        GroupBox1.Controls.Add(cmbcountry)
        GroupBox1.Controls.Add(Label11)
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
        GroupBox1.Location = New Point(12, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(672, 548)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Application Form"
        ' 
        ' cmbcountry
        ' 
        cmbcountry.DropDownStyle = ComboBoxStyle.DropDownList
        cmbcountry.FormattingEnabled = True
        cmbcountry.Items.AddRange(New Object() {"Computer Science", "Education", "Information Technology", "Business Accounting", "Business Administration", "Law", "UHEC"})
        cmbcountry.Location = New Point(257, 168)
        cmbcountry.Name = "cmbcountry"
        cmbcountry.Size = New Size(186, 28)
        cmbcountry.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(87, 171)
        Label11.Name = "Label11"
        Label11.Size = New Size(58, 20)
        Label11.TabIndex = 21
        Label11.Text = "Country"
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
        chkterms.Location = New Point(304, 447)
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
        ' grppersonal
        ' 
        grppersonal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grppersonal.BackColor = Color.NavajoWhite
        grppersonal.Controls.Add(txtguardiancontact)
        grppersonal.Controls.Add(Label10)
        grppersonal.Controls.Add(txtrelation)
        grppersonal.Controls.Add(Label9)
        grppersonal.Controls.Add(txtguardian)
        grppersonal.Controls.Add(Label8)
        grppersonal.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grppersonal.Location = New Point(690, 72)
        grppersonal.Name = "grppersonal"
        grppersonal.Size = New Size(291, 426)
        grppersonal.TabIndex = 18
        grppersonal.TabStop = False
        grppersonal.Text = "Personal Information"
        ' 
        ' txtguardiancontact
        ' 
        txtguardiancontact.ForeColor = SystemColors.MenuHighlight
        txtguardiancontact.Location = New Point(20, 239)
        txtguardiancontact.Multiline = True
        txtguardiancontact.Name = "txtguardiancontact"
        txtguardiancontact.Size = New Size(227, 33)
        txtguardiancontact.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.Location = New Point(92, 212)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 24)
        Label10.TabIndex = 24
        Label10.Text = "Contact"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtrelation
        ' 
        txtrelation.ForeColor = SystemColors.MenuHighlight
        txtrelation.Location = New Point(20, 165)
        txtrelation.Multiline = True
        txtrelation.Name = "txtrelation"
        txtrelation.Size = New Size(227, 33)
        txtrelation.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(92, 138)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 24)
        Label9.TabIndex = 22
        Label9.Text = "Relation"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtguardian
        ' 
        txtguardian.ForeColor = SystemColors.MenuHighlight
        txtguardian.Location = New Point(20, 90)
        txtguardian.Multiline = True
        txtguardian.Name = "txtguardian"
        txtguardian.Size = New Size(227, 32)
        txtguardian.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(92, 49)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 29)
        Label8.TabIndex = 21
        Label8.Text = "Guardian"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(grppersonal)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(993, 587)
        Panel1.TabIndex = 19
        ' 
        ' fmstapplyform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlanchedAlmond
        ClientSize = New Size(993, 587)
        Controls.Add(Panel1)
        ForeColor = SystemColors.MenuHighlight
        Name = "fmstapplyform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Application Form"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        grppersonal.ResumeLayout(False)
        grppersonal.PerformLayout()
        Panel1.ResumeLayout(False)
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
    Friend WithEvents grppersonal As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtguardian As TextBox
    Friend WithEvents txtrelation As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtguardiancontact As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbcountry As ComboBox

End Class
