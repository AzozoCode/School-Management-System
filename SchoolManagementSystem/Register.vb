Imports System.Data.SqlClient
Public Class Register

    Dim con As New SqlConnection("Data Source=LAPTOP-CNRTCKGK\SQLEXPRESS01;Initial Catalog=InnorikSchoolManagementSystem;Integrated Security=True")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub StudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InnorikSchoolManagementSystemDataSet)

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InnorikSchoolManagementSystemDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.InnorikSchoolManagementSystemDataSet.Students)

        Student_IDTextBox.Text = ""
        First_NameTextBox.Text = ""
        Last_NameTextBox.Text = ""
        GenderTextBox.Text = ""
        ProgrammeTextBox.Text = ""
        CourseTextBox.Text = ""
        LevelTextBox.Text = ""
        DepartmentTextBox.Text = ""
        Department_CodeTextBox.Text = ""
        CWATextBox.Text = ""
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If (Student_IDTextBox.Text = "") Then
            MessageBox.Show("Student Id can not be Empty")
            Student_IDTextBox.Focus()
            Exit Sub
        End If


        If (First_NameTextBox.Text = "") Then
            MessageBox.Show("Field can not be Empty")
            First_NameTextBox.Focus()
            Exit Sub
        End If


        If (Last_NameTextBox.Text = "") Then
            MessageBox.Show("Field can not be Empty")
            Last_NameTextBox.Focus()
            Exit Sub
        End If





        If (GenderTextBox.Text = "") Then
            MessageBox.Show("Field cannot be Empty")
            GenderTextBox.Focus()
        End If

        If (ProgrammeTextBox.Text = "") Then
            MessageBox.Show("Field can not be Empty")
            ProgrammeTextBox.Focus()
        End If

        If (CourseTextBox.Text = "") Then
            MessageBox.Show("Field can not be Empty")
            CourseTextBox.Focus()
        End If

        If (LevelTextBox.Text = "") Then
            MessageBox.Show("Field can not be Empty")
            LevelTextBox.Focus()
        End If

        If (DepartmentTextBox.Text = "") Then
            MessageBox.Show("Field cannot be Empty")
            DepartmentTextBox.Focus()
        End If

        If (Department_CodeTextBox.Text = "") Then
            MessageBox.Show("Field cannot be Empty")
            Department_CodeTextBox.Focus()
        End If

        If (CWATextBox.Text = "") Then
            MessageBox.Show("Field can not be Empty")
            CWATextBox.Focus()
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Students VALUES( '" & Student_IDTextBox.Text & "',
'" & First_NameTextBox.Text & "', '" & Last_NameTextBox.Text & "','" & DOBDateTimePicker.Value & "',
'" & GenderTextBox.Text & "','" & ProgrammeTextBox.Text & "','" & CourseTextBox.Text & "',
'" & LevelTextBox.Text & "','" & DepartmentTextBox.Text & "','" & Department_CodeTextBox.Text & "','" & CWATextBox.Text & "')", con)


            If MessageBox.Show("Register Student", "Innorik School Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If cmd.ExecuteNonQuery Then
                    con.Close()
                    MessageBox.Show("Successfully Registered")
                End If
                LoadDataInGrid()
            End If

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
        dataGrid.DataSource = table
    End Sub
End Class