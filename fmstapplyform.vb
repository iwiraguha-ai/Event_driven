Imports System.Globalization
Partial Class fmstapplyform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnapply.Click

        'Create a Student object
        Dim student As New Student()
        'Assign values from the form to the Student object
        student.FullName = txtname.Text
        student.NationalID = txtnin.Text

        If cmbcourse.SelectedIndex <> -1 Then
            student.Course = cmbcourse.SelectedItem.ToString()
        Else
            student.Course = String.Empty
        End If
        If cmbcountry.SelectedIndex <> -1 Then
            MessageBox.Show("Please select a country.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbcountry.Focus()
            Exit Sub
        End If

        'Validate the student details
        If Not student.IsValid() Then
            If String.IsNullOrWhiteSpace(student.FullName) Then
                MessageBox.Show("Please enter the student's full name.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtname.Focus()
            ElseIf String.IsNullOrWhiteSpace(student.NationalID) Then
                MessageBox.Show("Please enter the registration number.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtnin.Focus()
            ElseIf String.IsNullOrWhiteSpace(student.Course) Then
                MessageBox.Show("Please select a programme.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbcourse.Focus()
            End If
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
            MessageBox.Show("Please accept the terms and conditions.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            chkterms.Focus()
            Exit Sub
        End If
        'Display Success Message
        MessageBox.Show("Student application submitted successfully!", "Registration Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Open the second form
        Dim successForm As New fmsuccessful()
        successForm.FullName = Me.txtname.Text.Trim()
        successForm.NationalID = Me.txtnin.Text.Trim()
        successForm.Course = Me.cmbcourse.SelectedItem.ToString()
        successForm.Country = Me.cmbcountry.SelectedItem.ToString()
        successForm.ShowDialog()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnin.Clear()
        txtname.Clear()
        txtguardian.Clear()
        txtguardiancontact.Clear()
        txtrelation.Clear()
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
            Label7.Text = "Courses: " & cmbcourse.SelectedItem.ToString
        Else
            Label7.Text = "Courses: None"
        End If
    End Sub

    Private Sub fmstapplyform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbcountry.Items.Clear()
        Dim countries As New SortedSet(Of String)(StringComparer.OrdinalIgnoreCase)
        For Each culture As CultureInfo In CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            Try
                Dim region As New RegionInfo(culture.Name)
                countries.Add(region.EnglishName)
            Catch ex As ArgumentException
                ' Skip cultures without a valid region.
            End Try
        Next
        cmbcountry.Items.AddRange(countries.ToArray())
        cmbcountry.SelectedIndex = -1

        ' Automatically set Maxdate to 20 years ago from today
        DateTimePicker1.MaxDate = DateTime.Today.AddYears(-20)

        ' Set a reasonable minimum date so they can't pick the year 1753
        DateTimePicker1.MinDate = DateTime.Today.AddYears(-100)

        ' Set default display value to the max allowed date (turning 20 today)
        DateTimePicker1.Value = DateTime.Today.AddYears(-20)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcountry.SelectedIndexChanged

    End Sub
End Class
