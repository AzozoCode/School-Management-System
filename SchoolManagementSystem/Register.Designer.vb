<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.components = New System.ComponentModel.Container()
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim ProgrammeLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim LevelLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim Department_CodeLabel As System.Windows.Forms.Label
        Dim CWALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.InnorikSchoolManagementSystemDataSet = New SchoolManagementSystem.InnorikSchoolManagementSystemDataSet()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New SchoolManagementSystem.InnorikSchoolManagementSystemDataSetTableAdapters.StudentsTableAdapter()
        Me.TableAdapterManager = New SchoolManagementSystem.InnorikSchoolManagementSystemDataSetTableAdapters.TableAdapterManager()
        Me.StudentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.ProgrammeTextBox = New System.Windows.Forms.TextBox()
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.LevelTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Department_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CWATextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgrammeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CWADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Student_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        ProgrammeLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        LevelLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        Department_CodeLabel = New System.Windows.Forms.Label()
        CWALabel = New System.Windows.Forms.Label()
        CType(Me.InnorikSchoolManagementSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentsBindingNavigator.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(29, 264)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(89, 13)
        Student_IDLabel.TabIndex = 2
        Student_IDLabel.Text = "Enter Student ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(29, 290)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(29, 316)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(29, 343)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 8
        DOBLabel.Text = "DOB:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(29, 368)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 10
        GenderLabel.Text = "Gender:"
        '
        'ProgrammeLabel
        '
        ProgrammeLabel.AutoSize = True
        ProgrammeLabel.Location = New System.Drawing.Point(29, 394)
        ProgrammeLabel.Name = "ProgrammeLabel"
        ProgrammeLabel.Size = New System.Drawing.Size(63, 13)
        ProgrammeLabel.TabIndex = 12
        ProgrammeLabel.Text = "Programme:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(29, 420)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(43, 13)
        CourseLabel.TabIndex = 14
        CourseLabel.Text = "Course:"
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Location = New System.Drawing.Point(29, 450)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(36, 13)
        LevelLabel.TabIndex = 16
        LevelLabel.Text = "Level:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(29, 476)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 18
        DepartmentLabel.Text = "Department:"
        '
        'Department_CodeLabel
        '
        Department_CodeLabel.AutoSize = True
        Department_CodeLabel.Location = New System.Drawing.Point(29, 502)
        Department_CodeLabel.Name = "Department_CodeLabel"
        Department_CodeLabel.Size = New System.Drawing.Size(93, 13)
        Department_CodeLabel.TabIndex = 20
        Department_CodeLabel.Text = "Department Code:"
        '
        'CWALabel
        '
        CWALabel.AutoSize = True
        CWALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CWALabel.Location = New System.Drawing.Point(30, 524)
        CWALabel.Name = "CWALabel"
        CWALabel.Size = New System.Drawing.Size(35, 13)
        CWALabel.TabIndex = 22
        CWALabel.Text = "CWA:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(1248, 28)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'InnorikSchoolManagementSystemDataSet
        '
        Me.InnorikSchoolManagementSystemDataSet.DataSetName = "InnorikSchoolManagementSystemDataSet"
        Me.InnorikSchoolManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.InnorikSchoolManagementSystemDataSet
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentsTableAdapter = Me.StudentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = SchoolManagementSystem.InnorikSchoolManagementSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERSTableAdapter = Nothing
        '
        'StudentsBindingNavigator
        '
        Me.StudentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentsBindingNavigator.BindingSource = Me.StudentsBindingSource
        Me.StudentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentsBindingNavigatorSaveItem})
        Me.StudentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentsBindingNavigator.Name = "StudentsBindingNavigator"
        Me.StudentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentsBindingNavigator.Size = New System.Drawing.Size(1352, 25)
        Me.StudentsBindingNavigator.TabIndex = 1
        Me.StudentsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StudentsBindingNavigatorSaveItem
        '
        Me.StudentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentsBindingNavigatorSaveItem.Name = "StudentsBindingNavigatorSaveItem"
        Me.StudentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(128, 287)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.First_NameTextBox.TabIndex = 5
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(128, 316)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox.TabIndex = 7
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentsBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(128, 339)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 9
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(128, 365)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 11
        '
        'ProgrammeTextBox
        '
        Me.ProgrammeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Programme", True))
        Me.ProgrammeTextBox.Location = New System.Drawing.Point(128, 391)
        Me.ProgrammeTextBox.Name = "ProgrammeTextBox"
        Me.ProgrammeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProgrammeTextBox.TabIndex = 13
        '
        'CourseTextBox
        '
        Me.CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Course", True))
        Me.CourseTextBox.Location = New System.Drawing.Point(128, 417)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CourseTextBox.TabIndex = 15
        '
        'LevelTextBox
        '
        Me.LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Level", True))
        Me.LevelTextBox.Location = New System.Drawing.Point(128, 443)
        Me.LevelTextBox.Name = "LevelTextBox"
        Me.LevelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LevelTextBox.TabIndex = 17
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(128, 469)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DepartmentTextBox.TabIndex = 19
        '
        'Department_CodeTextBox
        '
        Me.Department_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Department_Code", True))
        Me.Department_CodeTextBox.Location = New System.Drawing.Point(128, 495)
        Me.Department_CodeTextBox.Name = "Department_CodeTextBox"
        Me.Department_CodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Department_CodeTextBox.TabIndex = 21
        '
        'CWATextBox
        '
        Me.CWATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "CWA", True))
        Me.CWATextBox.Location = New System.Drawing.Point(128, 524)
        Me.CWATextBox.Name = "CWATextBox"
        Me.CWATextBox.Size = New System.Drawing.Size(200, 20)
        Me.CWATextBox.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-13, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1376, 73)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "INNORIK SCHOOL MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(525, 55)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "REGISTER STUDENT"
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Student_ID", True))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(128, 257)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Student_IDTextBox.TabIndex = 3
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(169, 561)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(105, 23)
        Me.btnInsert.TabIndex = 26
        Me.btnInsert.Text = "Register"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'dataGrid
        '
        Me.dataGrid.AutoGenerateColumns = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.ProgrammeDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.LevelDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DepartmentCodeDataGridViewTextBoxColumn, Me.CWADataGridViewTextBoxColumn})
        Me.dataGrid.DataSource = Me.StudentsBindingSource
        Me.dataGrid.Location = New System.Drawing.Point(348, 299)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.Size = New System.Drawing.Size(975, 216)
        Me.dataGrid.TabIndex = 27
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'ProgrammeDataGridViewTextBoxColumn
        '
        Me.ProgrammeDataGridViewTextBoxColumn.DataPropertyName = "Programme"
        Me.ProgrammeDataGridViewTextBoxColumn.HeaderText = "Programme"
        Me.ProgrammeDataGridViewTextBoxColumn.Name = "ProgrammeDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'LevelDataGridViewTextBoxColumn
        '
        Me.LevelDataGridViewTextBoxColumn.DataPropertyName = "Level"
        Me.LevelDataGridViewTextBoxColumn.HeaderText = "Level"
        Me.LevelDataGridViewTextBoxColumn.Name = "LevelDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'DepartmentCodeDataGridViewTextBoxColumn
        '
        Me.DepartmentCodeDataGridViewTextBoxColumn.DataPropertyName = "Department_Code"
        Me.DepartmentCodeDataGridViewTextBoxColumn.HeaderText = "Department_Code"
        Me.DepartmentCodeDataGridViewTextBoxColumn.Name = "DepartmentCodeDataGridViewTextBoxColumn"
        '
        'CWADataGridViewTextBoxColumn
        '
        Me.CWADataGridViewTextBoxColumn.DataPropertyName = "CWA"
        Me.CWADataGridViewTextBoxColumn.HeaderText = "CWA"
        Me.CWADataGridViewTextBoxColumn.Name = "CWADataGridViewTextBoxColumn"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 650)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(ProgrammeLabel)
        Me.Controls.Add(Me.ProgrammeTextBox)
        Me.Controls.Add(CourseLabel)
        Me.Controls.Add(Me.CourseTextBox)
        Me.Controls.Add(LevelLabel)
        Me.Controls.Add(Me.LevelTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Department_CodeLabel)
        Me.Controls.Add(Me.Department_CodeTextBox)
        Me.Controls.Add(CWALabel)
        Me.Controls.Add(Me.CWATextBox)
        Me.Controls.Add(Me.StudentsBindingNavigator)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.InnorikSchoolManagementSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentsBindingNavigator.ResumeLayout(False)
        Me.StudentsBindingNavigator.PerformLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents InnorikSchoolManagementSystemDataSet As InnorikSchoolManagementSystemDataSet
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As InnorikSchoolManagementSystemDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TableAdapterManager As InnorikSchoolManagementSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StudentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents ProgrammeTextBox As TextBox
    Friend WithEvents CourseTextBox As TextBox
    Friend WithEvents LevelTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents Department_CodeTextBox As TextBox
    Friend WithEvents CWATextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Student_IDTextBox As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgrammeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CWADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
