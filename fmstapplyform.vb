Partial Class fmstapplyform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnapply.Click

        'Validate Student Name
        If txtname.Text.Trim() = "" Then
            MessageBox.Show("Please enter the student's name.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtname.Focus()
            Exit Sub
        End If
        'Validate Student ID
        If txtnin.Text.Trim() = "" Then
            MessageBox.Show("Please enter the registration number.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtnin.Focus()
            Exit Sub
        End If
        'Validate Course Selection
        If cmbcourse.SelectedIndex = -1 Then
            MessageBox.Show("Please select a programme.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            cmbcourse.Focus()
            Exit Sub
        End If
        ' Validate Age (Must be at least 20 years old)
        If DateTimePicker1.Value > DateTime.Today.AddYears(-20) Then
            MessageBox.Show("You must be more than 20 years old to apply.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If
        'Validate Terms and Conditions
        If chkterms.Checked = False Then
            MessageBox.Show("Please accept the terms and conditions.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            chkterms.Focus()
            Exit Sub
        End If
        'Display Success Message
        MessageBox.Show("Student application submitted successfully!",
                        "Registration Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        'Open the second form
        Dim successForm As New fmsuccessful()
        successForm.FullName = Me.txtname.Text.Trim()
        successForm.NationalID = Me.txtnin.Text.Trim()
        successForm.Course = Me.cmbcourse.SelectedItem.ToString()
        successForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnin.Clear()
        txtname.Clear()
        txtnumber.Clear()
        cmbcourse.SelectedIndex = -1
        txtaddress.Clear()
        DateTimePicker1.Value = Date.Today
        lblcount.Text = "Characters: 0"
        Label7.Text = "Courses: None"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        If String.IsNullOrWhiteSpace(txtname.Text) Then MessageBox.Show("Full Name is required.")
        txtname.Focus()
        lblcount.Text = "Characters: " & txtname.Text.Length.ToString()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnin.TextChanged
        If String.IsNullOrWhiteSpace(txtnin.Text) Then MessageBox.Show("National ID is required!")
        txtnin.Focus()
    End Sub

    Private Sub cmbcourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcourse.SelectedIndexChanged
        If cmbcourse.SelectedIndex <> -1 Then
            Label7.Text = "Courses: " & cmbcourse.SelectedItem.ToString()
        Else
            Label7.Text = "Courses: None"
        End If
    End Sub

    Private Sub fmstapplyform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Automatically set Maxdate to 20 years ago from today
        DateTimePicker1.MaxDate = DateTime.Today.AddYears(-20)

        ' Set a reasonable minimum date so they can't pick the year 1753
        DateTimePicker1.MinDate = DateTime.Today.AddYears(-100)

        ' Set default display value to the max allowed date (turning 20 today)
        DateTimePicker1.Value = DateTime.Today.AddYears(-20)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class
