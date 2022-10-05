Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim School As String
    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-CNRTCKGK\SQLEXPRESS01;Initial Catalog=InnorikSchoolManagementSystem;Integrated Security=True")

    Private Sub StudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InnorikSchoolManagementSystemDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InnorikSchoolManagementSystemDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.InnorikSchoolManagementSystemDataSet.Students)

        cmbSearch.Items.Add("Student_ID")
        cmbSearch.Items.Add("Programme")
        cmbSearch.Items.Add("Department")
        cmbSearch.Items.Add("Department_Code")
        cmbSearch.Items.Add("Level")
        cmbSearch.Items.Add("First_Name")
        cmbSearch.Items.Add("Last_Name")
        cmbSearch.Items.Add("Gender")
        cmbSearch.Items.Add("DOB")
        cmbSearch.Items.Add("CWA")
        cmbSearch.Items.Add("Course")

        LoadDataInGrid()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        School = cmbSearch.Text
        Select Case School
            Case "Student_ID"
                Me.StudentsBindingSource.Filter = "Student_ID = '" & txtSearch.Text & "'"
            Case "Programme"
                Me.StudentsBindingSource.Filter = "Programme ='" & txtSearch.Text & "'"
            Case "Department"
                Me.StudentsBindingSource.Filter = "Department = '" & txtSearch.Text & "'"
            Case "Department_Code"
                Me.StudentsBindingSource.Filter = "Department_Code ='" & txtSearch.Text & "'"
            Case "First_Name"
                Me.StudentsBindingSource.Filter = "First_Name = '" & txtSearch.Text & "'"
            Case "Last_Name"
                Me.StudentsBindingSource.Filter = "Last_Name ='" & txtSearch.Text & "'"
            Case "Level"
                Me.StudentsBindingSource.Filter = "Level = '" & txtSearch.Text & "'"
            Case "Gender"
                Me.StudentsBindingSource.Filter = "Gender = '" & txtSearch.Text & "'"
            Case "DOB"
                Me.StudentsBindingSource.Filter = "DOB = '" & txtSearch.Text & "'"
            Case "Course"
                Me.StudentsBindingSource.Filter = "Course ='" & txtSearch.Text & "'"
            Case "CWA"
                Me.StudentsBindingSource.Filter = "CWA = '" & txtSearch.Text & "'"
        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you Want to Exit", "Innorik School Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        Me.StudentsBindingSource.MoveFirst()
    End Sub

    Private Sub btnMovePrevious_Click(sender As Object, e As EventArgs) Handles btnMovePrevious.Click
        Me.StudentsBindingSource.MovePrevious()
    End Sub

    Private Sub btnMoveLast_Click(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        Me.StudentsBindingSource.MoveLast()
    End Sub

    Private Sub btnMoveNext_Click(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        Me.StudentsBindingSource.MoveNext()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If MessageBox.Show("Registering a New Student", "Innorik School Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Register.Show()
            Me.Hide()
        End If

        Register.Show()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("DELETE FROM Students WHERE Student_ID = '" & Student_IDTextBox.Text & "'", con)

            If MessageBox.Show("Do you want to delete Student", "Innorik School Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Deleted Successfully")
                    con.Close()
                End If
            End If
            LoadDataInGrid()
        Catch ex As Exception
            If MessageBox.Show("Connection Error", "Innorik School Management System", MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
                Exit Sub
            End If
        End Try


    End Sub
    Private Sub LoadDataInGrid()
        Dim cmd As New SqlCommand("SELECT * FROM Students", con)
        Dim Source As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        Source.Fill(table)
        StudentsDataGridView.DataSource = table
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Students SET First_Name = '" & First_NameTextBox.Text & "',
                                  Last_Name = '" & Last_NameTextBox.Text & "',Gender = '" & GenderTextBox.Text & "',DOB = '" & DOBDateTimePicker.Value & "',
                                  Programme = '" & ProgrammeTextBox.Text & "' , Department = '" & DepartmentTextBox.Text & "', 
                                  Department_Code = '" & Department_CodeTextBox.Text & "',
                                  CWA = '" & CWATextBox.Text & "' WHERE Student_ID = '" & Student_IDTextBox.Text & "'", con)


            If cmd.ExecuteNonQuery Then
                If MessageBox.Show("Updating Student", "Innorik School Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    MsgBox("Updated Successfully")
                    con.Close()
                End If
            End If
            LoadDataInGrid()
        Catch ex As Exception
            If MessageBox.Show("Connection Error", "Innorik School Management System", MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
                Exit Sub
            End If
        End Try
    End Sub
End Class
