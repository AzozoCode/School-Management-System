<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
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
        Me.StudentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
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
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Location = New System.Drawing.Point(3, 190)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(61, 13)
        Student_IDLabel.TabIndex = 2
        Student_IDLabel.Text = "Student ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(3, 216)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(3, 242)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(3, 269)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 8
        DOBLabel.Text = "DOB:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(3, 294)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 10
        GenderLabel.Text = "Gender:"
        '
        'ProgrammeLabel
        '
        ProgrammeLabel.AutoSize = True
        ProgrammeLabel.Location = New System.Drawing.Point(3, 320)
        ProgrammeLabel.Name = "ProgrammeLabel"
        ProgrammeLabel.Size = New System.Drawing.Size(63, 13)
        ProgrammeLabel.TabIndex = 12
        ProgrammeLabel.Text = "Programme:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(3, 346)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(43, 13)
        CourseLabel.TabIndex = 14
        CourseLabel.Text = "Course:"
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Location = New System.Drawing.Point(3, 372)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(36, 13)
        LevelLabel.TabIndex = 16
        LevelLabel.Text = "Level:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(3, 398)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 18
        DepartmentLabel.Text = "Department:"
        '
        'Department_CodeLabel
        '
        Department_CodeLabel.AutoSize = True
        Department_CodeLabel.Location = New System.Drawing.Point(3, 424)
        Department_CodeLabel.Name = "Department_CodeLabel"
        Department_CodeLabel.Size = New System.Drawing.Size(93, 13)
        Department_CodeLabel.TabIndex = 20
        Department_CodeLabel.Text = "Department Code:"
        '
        'CWALabel
        '
        CWALabel.AutoSize = True
        CWALabel.Location = New System.Drawing.Point(3, 450)
        CWALabel.Name = "CWALabel"
        CWALabel.Size = New System.Drawing.Size(35, 13)
        CWALabel.TabIndex = 22
        CWALabel.Text = "CWA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-7, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1376, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INNORIK SCHOOL MANAGEMENT SYSTEM"
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
        Me.StudentsBindingNavigator.Size = New System.Drawing.Size(1370, 25)
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
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Student_ID", True))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(102, 187)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Student_IDTextBox.TabIndex = 3
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(102, 213)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.First_NameTextBox.TabIndex = 5
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(102, 239)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox.TabIndex = 7
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentsBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(102, 265)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 9
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(102, 291)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 11
        '
        'ProgrammeTextBox
        '
        Me.ProgrammeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Programme", True))
        Me.ProgrammeTextBox.Location = New System.Drawing.Point(102, 317)
        Me.ProgrammeTextBox.Name = "ProgrammeTextBox"
        Me.ProgrammeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProgrammeTextBox.TabIndex = 13
        '
        'CourseTextBox
        '
        Me.CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Course", True))
        Me.CourseTextBox.Location = New System.Drawing.Point(102, 343)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CourseTextBox.TabIndex = 15
        '
        'LevelTextBox
        '
        Me.LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Level", True))
        Me.LevelTextBox.Location = New System.Drawing.Point(102, 369)
        Me.LevelTextBox.Name = "LevelTextBox"
        Me.LevelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LevelTextBox.TabIndex = 17
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(102, 395)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DepartmentTextBox.TabIndex = 19
        '
        'Department_CodeTextBox
        '
        Me.Department_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "Department_Code", True))
        Me.Department_CodeTextBox.Location = New System.Drawing.Point(102, 421)
        Me.Department_CodeTextBox.Name = "Department_CodeTextBox"
        Me.Department_CodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Department_CodeTextBox.TabIndex = 21
        '
        'CWATextBox
        '
        Me.CWATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "CWA", True))
        Me.CWATextBox.Location = New System.Drawing.Point(102, 447)
        Me.CWATextBox.Name = "CWATextBox"
        Me.CWATextBox.Size = New System.Drawing.Size(200, 20)
        Me.CWATextBox.TabIndex = 23
        '
        'StudentsDataGridView
        '
        Me.StudentsDataGridView.AutoGenerateColumns = False
        Me.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.StudentsDataGridView.DataSource = Me.StudentsBindingSource
        Me.StudentsDataGridView.Location = New System.Drawing.Point(305, 187)
        Me.StudentsDataGridView.Name = "StudentsDataGridView"
        Me.StudentsDataGridView.Size = New System.Drawing.Size(1053, 280)
        Me.StudentsDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Programme"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Programme"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Course"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Course"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Level"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Level"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Department_Code"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Department_Code"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CWA"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CWA"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(1007, 28)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(163, 21)
        Me.cmbSearch.TabIndex = 25
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(854, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(147, 20)
        Me.txtSearch.TabIndex = 26
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1187, 29)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(96, 23)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Location = New System.Drawing.Point(663, 489)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(96, 23)
        Me.btnMoveLast.TabIndex = 29
        Me.btnMoveLast.Text = "Move Last"
        Me.btnMoveLast.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.Location = New System.Drawing.Point(544, 489)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(96, 23)
        Me.btnMovePrevious.TabIndex = 30
        Me.btnMovePrevious.Text = "Move Previous"
        Me.btnMovePrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1027, 489)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 23)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1141, 489)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 23)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1262, 489)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 23)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(305, 489)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(96, 23)
        Me.btnRegister.TabIndex = 34
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Location = New System.Drawing.Point(424, 489)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(96, 23)
        Me.btnMoveFirst.TabIndex = 35
        Me.btnMoveFirst.Text = "Move First"
        Me.btnMoveFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Location = New System.Drawing.Point(784, 489)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(96, 23)
        Me.btnMoveNext.TabIndex = 36
        Me.btnMoveNext.Text = "Move Next"
        Me.btnMoveNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 684)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnMovePrevious)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.StudentsDataGridView)
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.InnorikSchoolManagementSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentsBindingNavigator.ResumeLayout(False)
        Me.StudentsBindingNavigator.PerformLayout()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents Student_IDTextBox As TextBox
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
    Friend WithEvents StudentsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnMoveLast As Button
    Friend WithEvents btnMovePrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnMoveFirst As Button
    Friend WithEvents btnMoveNext As Button
End Class
