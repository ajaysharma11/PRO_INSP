<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim CMDJOM As System.Windows.Forms.Button
        Dim IDLabel As System.Windows.Forms.Label
        Dim WEEK_ENDINGLabel As System.Windows.Forms.Label
        Dim DATE__OF__JOURNEYLabel As System.Windows.Forms.Label
        Dim DAY_OF_JOURNEYLabel As System.Windows.Forms.Label
        Dim TRAINLabel As System.Windows.Forms.Label
        Dim DEPLabel As System.Windows.Forms.Label
        Dim ARRLabel As System.Windows.Forms.Label
        Dim ST_FROMLabel As System.Windows.Forms.Label
        Dim ST_TOLabel As System.Windows.Forms.Label
        Dim ST__WORKED__ATLabel As System.Windows.Forms.Label
        Dim ROUNDLabel As System.Windows.Forms.Label
        Dim DAY_BOOKEDLabel As System.Windows.Forms.Label
        Dim REMARKSLabel As System.Windows.Forms.Label
        Dim IR_CASE__NOLabel As System.Windows.Forms.Label
        Dim INSP_COMLabel As System.Windows.Forms.Label
        Dim REPORT__SUBMISSIONLabel As System.Windows.Forms.Label
        Dim _2RODLabel As System.Windows.Forms.Label
        Dim _3RODLabel As System.Windows.Forms.Label
        Dim _1R0DLabel As System.Windows.Forms.Label
        Dim LINSPLabel As System.Windows.Forms.Label
        Dim NDUELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMD_REPORT = New System.Windows.Forms.Button()
        Me.CMD_BEAT = New System.Windows.Forms.Button()
        Me.CMD_AT_A_GLANCE = New System.Windows.Forms.Button()
        Me.CMD_MY_DATA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.JOMBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.JOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAILY__INSPDataSet = New PRO_INSP.DAILY__INSPDataSet()
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
        Me.JOMBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.JOMBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATE__OF__JOURNEYDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DAY_OF_JOURNEYDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TRAINTextBox = New System.Windows.Forms.TextBox()
        Me.DEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ARRMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ST_FROMTextBox = New System.Windows.Forms.TextBox()
        Me.ST_TOTextBox = New System.Windows.Forms.TextBox()
        Me.ST__WORKED__ATComboBox = New System.Windows.Forms.ComboBox()
        Me.ROUNDComboBox = New System.Windows.Forms.ComboBox()
        Me.DAY_BOOKEDNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.REMARKSTextBox = New System.Windows.Forms.TextBox()
        Me.IR_CASE__NOTextBox = New System.Windows.Forms.TextBox()
        Me.INSP_COMComboBox = New System.Windows.Forms.ComboBox()
        Me.REPORT__SUBMISSIONDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me._2RODDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me._3RODDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me._1R0DDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LINSPDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NDUETextBox = New System.Windows.Forms.TextBox()
        Me.CMD_ADD = New System.Windows.Forms.Button()
        Me.CMD_SAVE = New System.Windows.Forms.Button()
        Me.CMD_EDIT = New System.Windows.Forms.Button()
        Me.CMD_EXIT = New System.Windows.Forms.Button()
        Me.WEEK_ENDINGDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BEAT__PDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BEAT__PBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JOMTableAdapter = New PRO_INSP.DAILY__INSPDataSetTableAdapters.JOMTableAdapter()
        Me.TableAdapterManager = New PRO_INSP.DAILY__INSPDataSetTableAdapters.TableAdapterManager()
        Me.BEAT__PTableAdapter = New PRO_INSP.DAILY__INSPDataSetTableAdapters.BEAT__PTableAdapter()
        Me.JOMDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CMDJOM = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        WEEK_ENDINGLabel = New System.Windows.Forms.Label()
        DATE__OF__JOURNEYLabel = New System.Windows.Forms.Label()
        DAY_OF_JOURNEYLabel = New System.Windows.Forms.Label()
        TRAINLabel = New System.Windows.Forms.Label()
        DEPLabel = New System.Windows.Forms.Label()
        ARRLabel = New System.Windows.Forms.Label()
        ST_FROMLabel = New System.Windows.Forms.Label()
        ST_TOLabel = New System.Windows.Forms.Label()
        ST__WORKED__ATLabel = New System.Windows.Forms.Label()
        ROUNDLabel = New System.Windows.Forms.Label()
        DAY_BOOKEDLabel = New System.Windows.Forms.Label()
        REMARKSLabel = New System.Windows.Forms.Label()
        IR_CASE__NOLabel = New System.Windows.Forms.Label()
        INSP_COMLabel = New System.Windows.Forms.Label()
        REPORT__SUBMISSIONLabel = New System.Windows.Forms.Label()
        _2RODLabel = New System.Windows.Forms.Label()
        _3RODLabel = New System.Windows.Forms.Label()
        _1R0DLabel = New System.Windows.Forms.Label()
        LINSPLabel = New System.Windows.Forms.Label()
        NDUELabel = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.JOMBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JOMBindingNavigator.SuspendLayout()
        CType(Me.JOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAILY__INSPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOMBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAY_BOOKEDNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BEAT__PDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BEAT__PBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMDJOM
        '
        CMDJOM.BackColor = System.Drawing.Color.OrangeRed
        CMDJOM.DialogResult = System.Windows.Forms.DialogResult.Cancel
        CMDJOM.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        CMDJOM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        CMDJOM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        CMDJOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        CMDJOM.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CMDJOM.ForeColor = System.Drawing.Color.WhiteSmoke
        CMDJOM.Location = New System.Drawing.Point(6, 159)
        CMDJOM.Name = "CMDJOM"
        CMDJOM.Size = New System.Drawing.Size(205, 40)
        CMDJOM.TabIndex = 0
        CMDJOM.Text = "JOM FEDING"
        CMDJOM.UseVisualStyleBackColor = True
        AddHandler CMDJOM.Click, AddressOf Me.CMDJOM_Click
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(234, 69)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 119
        IDLabel.Text = "ID:"
        '
        'WEEK_ENDINGLabel
        '
        WEEK_ENDINGLabel.AutoSize = True
        WEEK_ENDINGLabel.Location = New System.Drawing.Point(234, 95)
        WEEK_ENDINGLabel.Name = "WEEK_ENDINGLabel"
        WEEK_ENDINGLabel.Size = New System.Drawing.Size(87, 13)
        WEEK_ENDINGLabel.TabIndex = 121
        WEEK_ENDINGLabel.Text = "WEEK ENDING:"
        '
        'DATE__OF__JOURNEYLabel
        '
        DATE__OF__JOURNEYLabel.AutoSize = True
        DATE__OF__JOURNEYLabel.Location = New System.Drawing.Point(234, 122)
        DATE__OF__JOURNEYLabel.Name = "DATE__OF__JOURNEYLabel"
        DATE__OF__JOURNEYLabel.Size = New System.Drawing.Size(116, 13)
        DATE__OF__JOURNEYLabel.TabIndex = 123
        DATE__OF__JOURNEYLabel.Text = "DATE  OF  JOURNEY:"
        '
        'DAY_OF_JOURNEYLabel
        '
        DAY_OF_JOURNEYLabel.AutoSize = True
        DAY_OF_JOURNEYLabel.Location = New System.Drawing.Point(234, 148)
        DAY_OF_JOURNEYLabel.Name = "DAY_OF_JOURNEYLabel"
        DAY_OF_JOURNEYLabel.Size = New System.Drawing.Size(103, 13)
        DAY_OF_JOURNEYLabel.TabIndex = 125
        DAY_OF_JOURNEYLabel.Text = "DAY OF JOURNEY:"
        '
        'TRAINLabel
        '
        TRAINLabel.AutoSize = True
        TRAINLabel.Location = New System.Drawing.Point(234, 173)
        TRAINLabel.Name = "TRAINLabel"
        TRAINLabel.Size = New System.Drawing.Size(43, 13)
        TRAINLabel.TabIndex = 127
        TRAINLabel.Text = "TRAIN:"
        '
        'DEPLabel
        '
        DEPLabel.AutoSize = True
        DEPLabel.Location = New System.Drawing.Point(234, 199)
        DEPLabel.Name = "DEPLabel"
        DEPLabel.Size = New System.Drawing.Size(32, 13)
        DEPLabel.TabIndex = 129
        DEPLabel.Text = "DEP:"
        '
        'ARRLabel
        '
        ARRLabel.AutoSize = True
        ARRLabel.Location = New System.Drawing.Point(234, 225)
        ARRLabel.Name = "ARRLabel"
        ARRLabel.Size = New System.Drawing.Size(33, 13)
        ARRLabel.TabIndex = 131
        ARRLabel.Text = "ARR:"
        '
        'ST_FROMLabel
        '
        ST_FROMLabel.AutoSize = True
        ST_FROMLabel.Location = New System.Drawing.Point(234, 251)
        ST_FROMLabel.Name = "ST_FROMLabel"
        ST_FROMLabel.Size = New System.Drawing.Size(58, 13)
        ST_FROMLabel.TabIndex = 133
        ST_FROMLabel.Text = "ST FROM:"
        '
        'ST_TOLabel
        '
        ST_TOLabel.AutoSize = True
        ST_TOLabel.Location = New System.Drawing.Point(234, 277)
        ST_TOLabel.Name = "ST_TOLabel"
        ST_TOLabel.Size = New System.Drawing.Size(42, 13)
        ST_TOLabel.TabIndex = 135
        ST_TOLabel.Text = "ST TO:"
        '
        'ST__WORKED__ATLabel
        '
        ST__WORKED__ATLabel.AutoSize = True
        ST__WORKED__ATLabel.Location = New System.Drawing.Point(500, 70)
        ST__WORKED__ATLabel.Name = "ST__WORKED__ATLabel"
        ST__WORKED__ATLabel.Size = New System.Drawing.Size(99, 13)
        ST__WORKED__ATLabel.TabIndex = 137
        ST__WORKED__ATLabel.Text = "ST  WORKED  AT:"
        '
        'ROUNDLabel
        '
        ROUNDLabel.AutoSize = True
        ROUNDLabel.Location = New System.Drawing.Point(500, 97)
        ROUNDLabel.Name = "ROUNDLabel"
        ROUNDLabel.Size = New System.Drawing.Size(50, 13)
        ROUNDLabel.TabIndex = 139
        ROUNDLabel.Text = "ROUND:"
        '
        'DAY_BOOKEDLabel
        '
        DAY_BOOKEDLabel.AutoSize = True
        DAY_BOOKEDLabel.Location = New System.Drawing.Point(500, 121)
        DAY_BOOKEDLabel.Name = "DAY_BOOKEDLabel"
        DAY_BOOKEDLabel.Size = New System.Drawing.Size(80, 13)
        DAY_BOOKEDLabel.TabIndex = 141
        DAY_BOOKEDLabel.Text = "DAY BOOKED:"
        '
        'REMARKSLabel
        '
        REMARKSLabel.AutoSize = True
        REMARKSLabel.Location = New System.Drawing.Point(500, 150)
        REMARKSLabel.Name = "REMARKSLabel"
        REMARKSLabel.Size = New System.Drawing.Size(63, 13)
        REMARKSLabel.TabIndex = 143
        REMARKSLabel.Text = "REMARKS:"
        '
        'IR_CASE__NOLabel
        '
        IR_CASE__NOLabel.AutoSize = True
        IR_CASE__NOLabel.Location = New System.Drawing.Point(500, 176)
        IR_CASE__NOLabel.Name = "IR_CASE__NOLabel"
        IR_CASE__NOLabel.Size = New System.Drawing.Size(74, 13)
        IR_CASE__NOLabel.TabIndex = 145
        IR_CASE__NOLabel.Text = "IR CASE  NO:"
        '
        'INSP_COMLabel
        '
        INSP_COMLabel.AutoSize = True
        INSP_COMLabel.Location = New System.Drawing.Point(500, 202)
        INSP_COMLabel.Name = "INSP_COMLabel"
        INSP_COMLabel.Size = New System.Drawing.Size(62, 13)
        INSP_COMLabel.TabIndex = 147
        INSP_COMLabel.Text = "INSP COM:"
        '
        'REPORT__SUBMISSIONLabel
        '
        REPORT__SUBMISSIONLabel.AutoSize = True
        REPORT__SUBMISSIONLabel.Location = New System.Drawing.Point(500, 230)
        REPORT__SUBMISSIONLabel.Name = "REPORT__SUBMISSIONLabel"
        REPORT__SUBMISSIONLabel.Size = New System.Drawing.Size(128, 13)
        REPORT__SUBMISSIONLabel.TabIndex = 149
        REPORT__SUBMISSIONLabel.Text = "REPORT  SUBMISSION:"
        '
        '_2RODLabel
        '
        _2RODLabel.AutoSize = True
        _2RODLabel.Location = New System.Drawing.Point(762, 70)
        _2RODLabel.Name = "_2RODLabel"
        _2RODLabel.Size = New System.Drawing.Size(40, 13)
        _2RODLabel.TabIndex = 151
        _2RODLabel.Text = "2ROD:"
        '
        '_3RODLabel
        '
        _3RODLabel.AutoSize = True
        _3RODLabel.Location = New System.Drawing.Point(762, 96)
        _3RODLabel.Name = "_3RODLabel"
        _3RODLabel.Size = New System.Drawing.Size(40, 13)
        _3RODLabel.TabIndex = 153
        _3RODLabel.Text = "3ROD:"
        '
        '_1R0DLabel
        '
        _1R0DLabel.AutoSize = True
        _1R0DLabel.Location = New System.Drawing.Point(762, 122)
        _1R0DLabel.Name = "_1R0DLabel"
        _1R0DLabel.Size = New System.Drawing.Size(38, 13)
        _1R0DLabel.TabIndex = 155
        _1R0DLabel.Text = "1R0D:"
        '
        'LINSPLabel
        '
        LINSPLabel.AutoSize = True
        LINSPLabel.Location = New System.Drawing.Point(762, 148)
        LINSPLabel.Name = "LINSPLabel"
        LINSPLabel.Size = New System.Drawing.Size(41, 13)
        LINSPLabel.TabIndex = 157
        LINSPLabel.Text = "LINSP:"
        '
        'NDUELabel
        '
        NDUELabel.AutoSize = True
        NDUELabel.Location = New System.Drawing.Point(762, 173)
        NDUELabel.Name = "NDUELabel"
        NDUELabel.Size = New System.Drawing.Size(41, 13)
        NDUELabel.TabIndex = 159
        NDUELabel.Text = "NDUE:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.CMD_REPORT)
        Me.Panel5.Controls.Add(Me.CMD_BEAT)
        Me.Panel5.Controls.Add(CMDJOM)
        Me.Panel5.Controls.Add(Me.CMD_AT_A_GLANCE)
        Me.Panel5.Controls.Add(Me.CMD_MY_DATA)
        Me.Panel5.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Location = New System.Drawing.Point(1, -11)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(218, 618)
        Me.Panel5.TabIndex = 117
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(11, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "TIA INSPECTIONS"
        '
        'CMD_REPORT
        '
        Me.CMD_REPORT.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_REPORT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CMD_REPORT.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.CMD_REPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.CMD_REPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.CMD_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_REPORT.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_REPORT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CMD_REPORT.Location = New System.Drawing.Point(6, 253)
        Me.CMD_REPORT.Name = "CMD_REPORT"
        Me.CMD_REPORT.Size = New System.Drawing.Size(205, 40)
        Me.CMD_REPORT.TabIndex = 4
        Me.CMD_REPORT.Text = "REPORTs"
        Me.CMD_REPORT.UseVisualStyleBackColor = True
        '
        'CMD_BEAT
        '
        Me.CMD_BEAT.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_BEAT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CMD_BEAT.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.CMD_BEAT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.CMD_BEAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.CMD_BEAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_BEAT.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_BEAT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CMD_BEAT.Location = New System.Drawing.Point(6, 113)
        Me.CMD_BEAT.Name = "CMD_BEAT"
        Me.CMD_BEAT.Size = New System.Drawing.Size(205, 40)
        Me.CMD_BEAT.TabIndex = 2
        Me.CMD_BEAT.Text = "MY BEAT"
        Me.CMD_BEAT.UseVisualStyleBackColor = True
        '
        'CMD_AT_A_GLANCE
        '
        Me.CMD_AT_A_GLANCE.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_AT_A_GLANCE.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CMD_AT_A_GLANCE.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.CMD_AT_A_GLANCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.CMD_AT_A_GLANCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.CMD_AT_A_GLANCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_AT_A_GLANCE.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_AT_A_GLANCE.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CMD_AT_A_GLANCE.Location = New System.Drawing.Point(6, 205)
        Me.CMD_AT_A_GLANCE.Name = "CMD_AT_A_GLANCE"
        Me.CMD_AT_A_GLANCE.Size = New System.Drawing.Size(205, 42)
        Me.CMD_AT_A_GLANCE.TabIndex = 3
        Me.CMD_AT_A_GLANCE.Text = "AT A GLANCE"
        Me.CMD_AT_A_GLANCE.UseVisualStyleBackColor = True
        '
        'CMD_MY_DATA
        '
        Me.CMD_MY_DATA.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_MY_DATA.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CMD_MY_DATA.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.CMD_MY_DATA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.CMD_MY_DATA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.CMD_MY_DATA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_MY_DATA.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_MY_DATA.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CMD_MY_DATA.Location = New System.Drawing.Point(6, 65)
        Me.CMD_MY_DATA.Name = "CMD_MY_DATA"
        Me.CMD_MY_DATA.Size = New System.Drawing.Size(205, 42)
        Me.CMD_MY_DATA.TabIndex = 1
        Me.CMD_MY_DATA.Text = "MY DATA"
        Me.CMD_MY_DATA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(171, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JOURRNAL OF MOVEMENT "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(813, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Orange
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Location = New System.Drawing.Point(218, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(912, 59)
        Me.Panel3.TabIndex = 118
        '
        'JOMBindingNavigator
        '
        Me.JOMBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JOMBindingNavigator.BindingSource = Me.JOMBindingSource
        Me.JOMBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JOMBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JOMBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JOMBindingNavigatorSaveItem})
        Me.JOMBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.JOMBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JOMBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JOMBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JOMBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JOMBindingNavigator.Name = "JOMBindingNavigator"
        Me.JOMBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JOMBindingNavigator.Size = New System.Drawing.Size(1267, 25)
        Me.JOMBindingNavigator.TabIndex = 119
        Me.JOMBindingNavigator.Text = "BindingNavigator1"
        Me.JOMBindingNavigator.Visible = False
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
        'JOMBindingSource
        '
        Me.JOMBindingSource.DataMember = "JOM"
        Me.JOMBindingSource.DataSource = Me.DAILY__INSPDataSet
        '
        'DAILY__INSPDataSet
        '
        Me.DAILY__INSPDataSet.DataSetName = "DAILY__INSPDataSet"
        Me.DAILY__INSPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'JOMBindingNavigatorSaveItem
        '
        Me.JOMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JOMBindingNavigatorSaveItem.Image = CType(resources.GetObject("JOMBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.JOMBindingNavigatorSaveItem.Name = "JOMBindingNavigatorSaveItem"
        Me.JOMBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.JOMBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource1, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(368, 66)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(116, 20)
        Me.IDTextBox.TabIndex = 0
        '
        'JOMBindingSource1
        '
        Me.JOMBindingSource1.DataMember = "JOM"
        Me.JOMBindingSource1.DataSource = Me.DAILY__INSPDataSet
        '
        'DATE__OF__JOURNEYDateTimePicker
        '
        Me.DATE__OF__JOURNEYDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JOMBindingSource, "DATE_ OF_ JOURNEY", True))
        Me.DATE__OF__JOURNEYDateTimePicker.Location = New System.Drawing.Point(368, 118)
        Me.DATE__OF__JOURNEYDateTimePicker.Name = "DATE__OF__JOURNEYDateTimePicker"
        Me.DATE__OF__JOURNEYDateTimePicker.ShowUpDown = True
        Me.DATE__OF__JOURNEYDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.DATE__OF__JOURNEYDateTimePicker.TabIndex = 2
        '
        'DAY_OF_JOURNEYDateTimePicker
        '
        Me.DAY_OF_JOURNEYDateTimePicker.CustomFormat = "dddd"
        Me.DAY_OF_JOURNEYDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JOMBindingSource, "DAY_OF_JOURNEY", True))
        Me.DAY_OF_JOURNEYDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DAY_OF_JOURNEYDateTimePicker.Location = New System.Drawing.Point(368, 144)
        Me.DAY_OF_JOURNEYDateTimePicker.Name = "DAY_OF_JOURNEYDateTimePicker"
        Me.DAY_OF_JOURNEYDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.DAY_OF_JOURNEYDateTimePicker.TabIndex = 3
        '
        'TRAINTextBox
        '
        Me.TRAINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "TRAIN", True))
        Me.TRAINTextBox.Location = New System.Drawing.Point(368, 170)
        Me.TRAINTextBox.Name = "TRAINTextBox"
        Me.TRAINTextBox.Size = New System.Drawing.Size(116, 20)
        Me.TRAINTextBox.TabIndex = 4
        '
        'DEPMaskedTextBox
        '
        Me.DEPMaskedTextBox.Culture = New System.Globalization.CultureInfo("sa-IN")
        Me.DEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "DEP", True))
        Me.DEPMaskedTextBox.Location = New System.Drawing.Point(368, 196)
        Me.DEPMaskedTextBox.Mask = "00:00"
        Me.DEPMaskedTextBox.Name = "DEPMaskedTextBox"
        Me.DEPMaskedTextBox.Size = New System.Drawing.Size(116, 20)
        Me.DEPMaskedTextBox.TabIndex = 5
        '
        'ARRMaskedTextBox
        '
        Me.ARRMaskedTextBox.Culture = New System.Globalization.CultureInfo("sa-IN")
        Me.ARRMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ARR", True))
        Me.ARRMaskedTextBox.Location = New System.Drawing.Point(368, 222)
        Me.ARRMaskedTextBox.Mask = "90:00"
        Me.ARRMaskedTextBox.Name = "ARRMaskedTextBox"
        Me.ARRMaskedTextBox.Size = New System.Drawing.Size(116, 20)
        Me.ARRMaskedTextBox.TabIndex = 6
        '
        'ST_FROMTextBox
        '
        Me.ST_FROMTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ST_FROMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ST_FROM", True))
        Me.ST_FROMTextBox.Location = New System.Drawing.Point(368, 248)
        Me.ST_FROMTextBox.Name = "ST_FROMTextBox"
        Me.ST_FROMTextBox.Size = New System.Drawing.Size(116, 20)
        Me.ST_FROMTextBox.TabIndex = 7
        '
        'ST_TOTextBox
        '
        Me.ST_TOTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ST_TOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ST_TO", True))
        Me.ST_TOTextBox.Location = New System.Drawing.Point(368, 274)
        Me.ST_TOTextBox.Name = "ST_TOTextBox"
        Me.ST_TOTextBox.Size = New System.Drawing.Size(116, 20)
        Me.ST_TOTextBox.TabIndex = 8
        '
        'ST__WORKED__ATComboBox
        '
        Me.ST__WORKED__ATComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ST_ WORKED_ AT", True))
        Me.ST__WORKED__ATComboBox.FormattingEnabled = True
        Me.ST__WORKED__ATComboBox.Location = New System.Drawing.Point(634, 67)
        Me.ST__WORKED__ATComboBox.Name = "ST__WORKED__ATComboBox"
        Me.ST__WORKED__ATComboBox.Size = New System.Drawing.Size(120, 21)
        Me.ST__WORKED__ATComboBox.TabIndex = 9
        '
        'ROUNDComboBox
        '
        Me.ROUNDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "ROUND", True))
        Me.ROUNDComboBox.FormattingEnabled = True
        Me.ROUNDComboBox.Items.AddRange(New Object() {"Ist ROUND", "2nd ROUND", "3rd ROUND"})
        Me.ROUNDComboBox.Location = New System.Drawing.Point(634, 94)
        Me.ROUNDComboBox.Name = "ROUNDComboBox"
        Me.ROUNDComboBox.Size = New System.Drawing.Size(120, 21)
        Me.ROUNDComboBox.TabIndex = 10
        '
        'DAY_BOOKEDNumericUpDown
        '
        Me.DAY_BOOKEDNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JOMBindingSource, "DAY_BOOKED", True))
        Me.DAY_BOOKEDNumericUpDown.Location = New System.Drawing.Point(634, 121)
        Me.DAY_BOOKEDNumericUpDown.Name = "DAY_BOOKEDNumericUpDown"
        Me.DAY_BOOKEDNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.DAY_BOOKEDNumericUpDown.TabIndex = 11
        '
        'REMARKSTextBox
        '
        Me.REMARKSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "REMARKS", True))
        Me.REMARKSTextBox.Location = New System.Drawing.Point(634, 147)
        Me.REMARKSTextBox.Name = "REMARKSTextBox"
        Me.REMARKSTextBox.Size = New System.Drawing.Size(120, 20)
        Me.REMARKSTextBox.TabIndex = 12
        '
        'IR_CASE__NOTextBox
        '
        Me.IR_CASE__NOTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IR_CASE__NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "IR_CASE_ NO", True))
        Me.IR_CASE__NOTextBox.Location = New System.Drawing.Point(634, 173)
        Me.IR_CASE__NOTextBox.Name = "IR_CASE__NOTextBox"
        Me.IR_CASE__NOTextBox.Size = New System.Drawing.Size(120, 20)
        Me.IR_CASE__NOTextBox.TabIndex = 13
        '
        'INSP_COMComboBox
        '
        Me.INSP_COMComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "INSP_COM", True))
        Me.INSP_COMComboBox.FormattingEnabled = True
        Me.INSP_COMComboBox.Items.AddRange(New Object() {"NO", "YES"})
        Me.INSP_COMComboBox.Location = New System.Drawing.Point(634, 199)
        Me.INSP_COMComboBox.Name = "INSP_COMComboBox"
        Me.INSP_COMComboBox.Size = New System.Drawing.Size(120, 21)
        Me.INSP_COMComboBox.TabIndex = 14
        '
        'REPORT__SUBMISSIONDateTimePicker
        '
        Me.REPORT__SUBMISSIONDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JOMBindingSource, "REPORT_ SUBMISSION", True))
        Me.REPORT__SUBMISSIONDateTimePicker.Location = New System.Drawing.Point(634, 226)
        Me.REPORT__SUBMISSIONDateTimePicker.Name = "REPORT__SUBMISSIONDateTimePicker"
        Me.REPORT__SUBMISSIONDateTimePicker.Size = New System.Drawing.Size(120, 20)
        Me.REPORT__SUBMISSIONDateTimePicker.TabIndex = 15
        '
        '_2RODDateTimePicker
        '
        Me._2RODDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JOMBindingSource, "2ROD", True))
        Me._2RODDateTimePicker.Location = New System.Drawing.Point(809, 64)
        Me._2RODDateTimePicker.Name = "_2RODDateTimePicker"
        Me._2RODDateTimePicker.Size = New System.Drawing.Size(118, 20)
        Me._2RODDateTimePicker.TabIndex = 152
        '
        '_3RODDateTimePicker
        '
        Me._3RODDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JOMBindingSource, "3ROD", True))
        Me._3RODDateTimePicker.Location = New System.Drawing.Point(809, 90)
        Me._3RODDateTimePicker.Name = "_3RODDateTimePicker"
        Me._3RODDateTimePicker.Size = New System.Drawing.Size(118, 20)
        Me._3RODDateTimePicker.TabIndex = 154
        '
        '_1R0DDateTimePicker
        '
        Me._1R0DDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JOMBindingSource, "1R0D", True))
        Me._1R0DDateTimePicker.Location = New System.Drawing.Point(809, 116)
        Me._1R0DDateTimePicker.Name = "_1R0DDateTimePicker"
        Me._1R0DDateTimePicker.Size = New System.Drawing.Size(118, 20)
        Me._1R0DDateTimePicker.TabIndex = 156
        '
        'LINSPDateTimePicker
        '
        Me.LINSPDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JOMBindingSource, "LINSP", True))
        Me.LINSPDateTimePicker.Location = New System.Drawing.Point(809, 142)
        Me.LINSPDateTimePicker.Name = "LINSPDateTimePicker"
        Me.LINSPDateTimePicker.Size = New System.Drawing.Size(118, 20)
        Me.LINSPDateTimePicker.TabIndex = 158
        '
        'NDUETextBox
        '
        Me.NDUETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JOMBindingSource, "NDUE", True))
        Me.NDUETextBox.Location = New System.Drawing.Point(809, 168)
        Me.NDUETextBox.Name = "NDUETextBox"
        Me.NDUETextBox.Size = New System.Drawing.Size(118, 20)
        Me.NDUETextBox.TabIndex = 160
        '
        'CMD_ADD
        '
        Me.CMD_ADD.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_ADD.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.CMD_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_ADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CMD_ADD.Location = New System.Drawing.Point(225, 305)
        Me.CMD_ADD.Name = "CMD_ADD"
        Me.CMD_ADD.Size = New System.Drawing.Size(208, 25)
        Me.CMD_ADD.TabIndex = 24
        Me.CMD_ADD.Text = "ADD"
        Me.CMD_ADD.UseVisualStyleBackColor = False
        '
        'CMD_SAVE
        '
        Me.CMD_SAVE.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_SAVE.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.CMD_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_SAVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CMD_SAVE.Location = New System.Drawing.Point(439, 305)
        Me.CMD_SAVE.Name = "CMD_SAVE"
        Me.CMD_SAVE.Size = New System.Drawing.Size(208, 25)
        Me.CMD_SAVE.TabIndex = 16
        Me.CMD_SAVE.Text = "SAVE"
        Me.CMD_SAVE.UseVisualStyleBackColor = False
        '
        'CMD_EDIT
        '
        Me.CMD_EDIT.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_EDIT.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.CMD_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_EDIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CMD_EDIT.Location = New System.Drawing.Point(653, 305)
        Me.CMD_EDIT.Name = "CMD_EDIT"
        Me.CMD_EDIT.Size = New System.Drawing.Size(208, 25)
        Me.CMD_EDIT.TabIndex = 18
        Me.CMD_EDIT.Text = "EDIT"
        Me.CMD_EDIT.UseVisualStyleBackColor = False
        '
        'CMD_EXIT
        '
        Me.CMD_EXIT.BackColor = System.Drawing.Color.OrangeRed
        Me.CMD_EXIT.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.CMD_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_EXIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CMD_EXIT.Location = New System.Drawing.Point(867, 305)
        Me.CMD_EXIT.Name = "CMD_EXIT"
        Me.CMD_EXIT.Size = New System.Drawing.Size(208, 25)
        Me.CMD_EXIT.TabIndex = 17
        Me.CMD_EXIT.Text = "EXIT"
        Me.CMD_EXIT.UseVisualStyleBackColor = False
        '
        'WEEK_ENDINGDateTimePicker
        '
        Me.WEEK_ENDINGDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JOMBindingSource, "WEEK_ENDING", True))
        Me.WEEK_ENDINGDateTimePicker.Location = New System.Drawing.Point(368, 92)
        Me.WEEK_ENDINGDateTimePicker.Name = "WEEK_ENDINGDateTimePicker"
        Me.WEEK_ENDINGDateTimePicker.Size = New System.Drawing.Size(117, 20)
        Me.WEEK_ENDINGDateTimePicker.TabIndex = 1
        '
        'BEAT__PDataGridView
        '
        Me.BEAT__PDataGridView.AutoGenerateColumns = False
        Me.BEAT__PDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BEAT__PDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn24})
        Me.BEAT__PDataGridView.DataSource = Me.BEAT__PBindingSource
        Me.BEAT__PDataGridView.Location = New System.Drawing.Point(933, 64)
        Me.BEAT__PDataGridView.Name = "BEAT__PDataGridView"
        Me.BEAT__PDataGridView.Size = New System.Drawing.Size(314, 239)
        Me.BEAT__PDataGridView.TabIndex = 165
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn22.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "STATION"
        Me.DataGridViewTextBoxColumn23.HeaderText = "STATION"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "DAY_BOOKED"
        Me.DataGridViewTextBoxColumn26.HeaderText = "DAY_BOOKED"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "DAYS"
        Me.DataGridViewTextBoxColumn25.HeaderText = "DAYS"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "CLASS_ST"
        Me.DataGridViewTextBoxColumn24.HeaderText = "CLASS_ST"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'BEAT__PBindingSource
        '
        Me.BEAT__PBindingSource.DataMember = "BEAT­_P"
        Me.BEAT__PBindingSource.DataSource = Me.DAILY__INSPDataSet
        '
        'JOMTableAdapter
        '
        Me.JOMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BEAT__PTableAdapter = Me.BEAT__PTableAdapter
        Me.TableAdapterManager.FORCASTTableAdapter = Nothing
        Me.TableAdapterManager.JOMTableAdapter = Me.JOMTableAdapter
        Me.TableAdapterManager.MY_DATATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRO_INSP.DAILY__INSPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BEAT__PTableAdapter
        '
        Me.BEAT__PTableAdapter.ClearBeforeFill = True
        '
        'JOMDataGridView
        '
        Me.JOMDataGridView.AutoGenerateColumns = False
        Me.JOMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JOMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.JOMDataGridView.DataSource = Me.JOMBindingSource
        Me.JOMDataGridView.Location = New System.Drawing.Point(225, 336)
        Me.JOMDataGridView.Name = "JOMDataGridView"
        Me.JOMDataGridView.Size = New System.Drawing.Size(1022, 286)
        Me.JOMDataGridView.TabIndex = 165
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WEEK_ENDING"
        Me.DataGridViewTextBoxColumn2.HeaderText = "WEEK_ENDING"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DATE_ OF_ JOURNEY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DATE_ OF_ JOURNEY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DAY_OF_JOURNEY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DAY_OF_JOURNEY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TRAIN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TRAIN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DEP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DEP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ARR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ARR"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ST_FROM"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ST_FROM"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ST_TO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ST_TO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ST_ WORKED_ AT"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ST_ WORKED_ AT"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ROUND"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ROUND"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DAY_BOOKED"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DAY_BOOKED"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "REMARKS"
        Me.DataGridViewTextBoxColumn13.HeaderText = "REMARKS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "IR_CASE_ NO"
        Me.DataGridViewTextBoxColumn14.HeaderText = "IR_CASE_ NO"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "INSP_COM"
        Me.DataGridViewTextBoxColumn15.HeaderText = "INSP_COM"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "REPORT_ SUBMISSION"
        Me.DataGridViewTextBoxColumn16.HeaderText = "REPORT_ SUBMISSION"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "2ROD"
        Me.DataGridViewTextBoxColumn17.HeaderText = "2ROD"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "3ROD"
        Me.DataGridViewTextBoxColumn18.HeaderText = "3ROD"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "1R0D"
        Me.DataGridViewTextBoxColumn19.HeaderText = "1R0D"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "LINSP"
        Me.DataGridViewTextBoxColumn20.HeaderText = "LINSP"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "NDUE"
        Me.DataGridViewTextBoxColumn21.HeaderText = "NDUE"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(560, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(723, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Label4"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1267, 619)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.JOMDataGridView)
        Me.Controls.Add(Me.BEAT__PDataGridView)
        Me.Controls.Add(Me.WEEK_ENDINGDateTimePicker)
        Me.Controls.Add(Me.CMD_EXIT)
        Me.Controls.Add(Me.CMD_EDIT)
        Me.Controls.Add(Me.CMD_SAVE)
        Me.Controls.Add(Me.CMD_ADD)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(WEEK_ENDINGLabel)
        Me.Controls.Add(DATE__OF__JOURNEYLabel)
        Me.Controls.Add(Me.DATE__OF__JOURNEYDateTimePicker)
        Me.Controls.Add(DAY_OF_JOURNEYLabel)
        Me.Controls.Add(Me.DAY_OF_JOURNEYDateTimePicker)
        Me.Controls.Add(TRAINLabel)
        Me.Controls.Add(Me.TRAINTextBox)
        Me.Controls.Add(DEPLabel)
        Me.Controls.Add(Me.DEPMaskedTextBox)
        Me.Controls.Add(ARRLabel)
        Me.Controls.Add(Me.ARRMaskedTextBox)
        Me.Controls.Add(ST_FROMLabel)
        Me.Controls.Add(Me.ST_FROMTextBox)
        Me.Controls.Add(ST_TOLabel)
        Me.Controls.Add(Me.ST_TOTextBox)
        Me.Controls.Add(ST__WORKED__ATLabel)
        Me.Controls.Add(Me.ST__WORKED__ATComboBox)
        Me.Controls.Add(ROUNDLabel)
        Me.Controls.Add(Me.ROUNDComboBox)
        Me.Controls.Add(DAY_BOOKEDLabel)
        Me.Controls.Add(Me.DAY_BOOKEDNumericUpDown)
        Me.Controls.Add(REMARKSLabel)
        Me.Controls.Add(Me.REMARKSTextBox)
        Me.Controls.Add(IR_CASE__NOLabel)
        Me.Controls.Add(Me.IR_CASE__NOTextBox)
        Me.Controls.Add(INSP_COMLabel)
        Me.Controls.Add(Me.INSP_COMComboBox)
        Me.Controls.Add(REPORT__SUBMISSIONLabel)
        Me.Controls.Add(Me.REPORT__SUBMISSIONDateTimePicker)
        Me.Controls.Add(_2RODLabel)
        Me.Controls.Add(Me._2RODDateTimePicker)
        Me.Controls.Add(_3RODLabel)
        Me.Controls.Add(Me._3RODDateTimePicker)
        Me.Controls.Add(_1R0DLabel)
        Me.Controls.Add(Me._1R0DDateTimePicker)
        Me.Controls.Add(LINSPLabel)
        Me.Controls.Add(Me.LINSPDateTimePicker)
        Me.Controls.Add(NDUELabel)
        Me.Controls.Add(Me.NDUETextBox)
        Me.Controls.Add(Me.JOMBindingNavigator)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.JOMBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JOMBindingNavigator.ResumeLayout(False)
        Me.JOMBindingNavigator.PerformLayout()
        CType(Me.JOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAILY__INSPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOMBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAY_BOOKEDNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BEAT__PDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BEAT__PBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CMD_REPORT As Button
    Friend WithEvents CMD_BEAT As Button
    Friend WithEvents CMD_AT_A_GLANCE As Button
    Friend WithEvents CMD_MY_DATA As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DAILY__INSPDataSet As DAILY__INSPDataSet
    Friend WithEvents JOMBindingSource As BindingSource
    Friend WithEvents JOMTableAdapter As DAILY__INSPDataSetTableAdapters.JOMTableAdapter
    Friend WithEvents TableAdapterManager As DAILY__INSPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JOMBindingNavigator As BindingNavigator
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
    Friend WithEvents JOMBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DATE__OF__JOURNEYDateTimePicker As DateTimePicker
    Friend WithEvents DAY_OF_JOURNEYDateTimePicker As DateTimePicker
    Friend WithEvents TRAINTextBox As TextBox
    Friend WithEvents DEPMaskedTextBox As MaskedTextBox
    Friend WithEvents ARRMaskedTextBox As MaskedTextBox
    Friend WithEvents ST_FROMTextBox As TextBox
    Friend WithEvents ST_TOTextBox As TextBox
    Friend WithEvents ST__WORKED__ATComboBox As ComboBox
    Friend WithEvents ROUNDComboBox As ComboBox
    Friend WithEvents DAY_BOOKEDNumericUpDown As NumericUpDown
    Friend WithEvents REMARKSTextBox As TextBox
    Friend WithEvents IR_CASE__NOTextBox As TextBox
    Friend WithEvents INSP_COMComboBox As ComboBox
    Friend WithEvents REPORT__SUBMISSIONDateTimePicker As DateTimePicker
    Friend WithEvents _2RODDateTimePicker As DateTimePicker
    Friend WithEvents _3RODDateTimePicker As DateTimePicker
    Friend WithEvents _1R0DDateTimePicker As DateTimePicker
    Friend WithEvents LINSPDateTimePicker As DateTimePicker
    Friend WithEvents NDUETextBox As TextBox
    Friend WithEvents CMD_ADD As Button
    Friend WithEvents CMD_SAVE As Button
    Friend WithEvents CMD_EDIT As Button
    Friend WithEvents CMD_EXIT As Button
    Friend WithEvents WEEK_ENDINGDateTimePicker As DateTimePicker
    Friend WithEvents BEAT__PTableAdapter As DAILY__INSPDataSetTableAdapters.BEAT__PTableAdapter
    Friend WithEvents BEAT__PBindingSource As BindingSource
    Friend WithEvents BEAT__PDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents JOMDataGridView As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents JOMBindingSource1 As BindingSource
End Class
