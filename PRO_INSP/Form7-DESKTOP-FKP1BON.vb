Imports System.Data.OleDb


Public Class Form7

    Dim WDT As Date
    Dim DTOJ As Date
    Dim DAYOJ As Date
    Dim INT As Integer
    Dim INT2 As Integer
    Dim STR1 As String
    Dim STR2 As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub JOMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JOMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JOMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DAILY__INSPDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DAILY__INSPDataSet._BEAT__P' table. You can move, or remove it, as needed.
        Me.BEAT__PTableAdapter.Fill(Me.DAILY__INSPDataSet._BEAT__P)
        'TODO: This line of code loads data into the 'DAILY__INSPDataSet.JOM' table. You can move, or remove it, as needed.
        Me.JOMTableAdapter.Fill(Me.DAILY__INSPDataSet.JOM)
        JOMBindingSource.MoveLast()
        CMD_ADD.Select()
    End Sub

    Private Sub CMD_ADD_Click(sender As Object, e As EventArgs) Handles CMD_ADD.Click
        JOMBindingSource.AddNew()
    End Sub

    Private Sub CMD_SAVE_Click(sender As Object, e As EventArgs) Handles CMD_SAVE.Click
        JOMBindingSource.EndEdit()
        'JOMTableAdapter.InsertQuery(WEEK_ENDINGDateTimePicker.Value, DATE__OF__JOURNEYDateTimePicker.Value, DAY_OF_JOURNEYDateTimePicker.Value, TRAINTextBox.Text, DEPMaskedTextBox.Text, ARRMaskedTextBox.Text, ST_FROMTextBox.Text, ST_TOTextBox.Text, ST__WORKED__ATComboBox.Text, ROUNDComboBox.Text, DAY_BOOKEDNumericUpDown.Value, REMARKSTextBox.Text, IR_CASE__NOTextBox.Text, INSP_COMComboBox.Text, REPORT__SUBMISSIONDateTimePicker.Value, _2RODDateTimePicker.Value, _3RODDateTimePicker.Value, _1R0DDateTimePicker.Value, LINSPDateTimePicker.Value, NDUETextBox.Text)
        JOMTableAdapter.InsertQuery(WEEK_ENDINGDateTimePicker.Value, DATE__OF__JOURNEYDateTimePicker.Value, DAY_OF_JOURNEYDateTimePicker.Value, TRAINTextBox.Text, DEPMaskedTextBox.Text, ARRMaskedTextBox.Text, ST_FROMTextBox.Text, ST_TOTextBox.Text, ST__WORKED__ATComboBox.Text, ROUNDComboBox.Text, DAY_BOOKEDNumericUpDown.Value, REMARKSTextBox.Text, IR_CASE__NOTextBox.Text, INSP_COMComboBox.Text, REPORT__SUBMISSIONDateTimePicker.Value, _2RODDateTimePicker.Value, _3RODDateTimePicker.Value, _1R0DDateTimePicker.Value, LINSPDateTimePicker.Value, NDUETextBox.Text)

        If DAILY__INSPDataSet.HasChanges Then
            MsgBox("DATA ADDED TO DATABASE")
        Else
            MsgBox("DATA NOT ADDED TO DATABASE")
        End If


        Try
            Me.Validate()
            JOMBindingSource.EndEdit()
            JOMTableAdapter.Update(Me.DAILY__INSPDataSet.JOM)
            TableAdapterManager.UpdateAll(Me.DAILY__INSPDataSet)
            DAILY__INSPDataSet.AcceptChanges()
            MsgBox("DATA SAVED")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


        'Try
        '    Me.Validate()
        '    JOMDataGridView.EndEdit()
        '    JOMBindingSource.EndEdit()
        '    TableAdapterManager.UpdateAll(MY_INSP1DataSet)
        '    MY_INSP1DataSet.AcceptChanges()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try
        'Try
        '    Me.Validate()
        '    BEAT__PDataGridView.EndEdit()
        '    BEAT__PBindingSource1.EndEdit()
        '    BEAT__PTableAdapter1.Update(Me.MY_INSP1DataSet1._BEAT__P)
        '    Me.MY_INSP1DataSet1.JOM.AcceptChanges()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub CMD_EXIT_Click(sender As Object, e As EventArgs) Handles CMD_EXIT.Click
        Me.Close()

    End Sub

    Private Sub CMD_ADD_LostFocus(sender As Object, e As EventArgs) Handles CMD_ADD.LostFocus
        Dim NN As Integer = BEAT__PBindingSource.Count
        For NN = 0 To NN - 1
            STR1 = BEAT__PTableAdapter.GetData(NN).STATION
            ST__WORKED__ATComboBox.Items.Add(STR1)
            BEAT__PBindingSource.MoveNext()
        Next NN
        BEAT__PBindingSource.MoveLast()


        'INCREASE WEEK AND DATE
        If Weekday(DTOJ, vbSunday) = 7 Then
            WEEK_ENDINGDateTimePicker.Text = DateAdd(DateInterval.Day, 7, WDT)
        Else
            WEEK_ENDINGDateTimePicker.Text = WDT
        End If
        IDTextBox.Text = INT
        DATE__OF__JOURNEYDateTimePicker.Value = DateAdd("d", 1, DTOJ)
        DAY_OF_JOURNEYDateTimePicker.Value = DATE__OF__JOURNEYDateTimePicker.Value
        'BEAT__PBindingSource.EndEdit()
        BEAT__PDataGridView.ClearSelection()
        'ST__WORKED__ATComboBox.Visible = True

        TRAINTextBox.Select()
    End Sub

    Private Sub CMD_ADD_KeyUp(sender As Object, e As KeyEventArgs) Handles CMD_ADD.KeyUp
        If e.KeyCode = Keys.Enter Then
            WEEK_ENDINGDateTimePicker.Select()
        End If
    End Sub

    Private Sub CTR(sender As Object, e As KeyEventArgs) Handles WEEK_ENDINGDateTimePicker.KeyUp, TRAINTextBox.KeyUp, ST_TOTextBox.KeyUp, ST_FROMTextBox.KeyUp, ST__WORKED__ATComboBox.KeyUp, ROUNDComboBox.KeyUp, REPORT__SUBMISSIONDateTimePicker.KeyUp, REMARKSTextBox.KeyUp, IR_CASE__NOTextBox.KeyUp, INSP_COMComboBox.KeyUp, DEPMaskedTextBox.KeyUp, DAY_OF_JOURNEYDateTimePicker.KeyUp, DAY_BOOKEDNumericUpDown.KeyUp, DATE__OF__JOURNEYDateTimePicker.KeyUp, CMD_SAVE.KeyUp, ARRMaskedTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, False)
        End If
    End Sub

    Private Sub CMD_ADD_GotFocus(sender As Object, e As EventArgs) Handles CMD_ADD.GotFocus
        WDT = WEEK_ENDINGDateTimePicker.Value
        DTOJ = DAY_OF_JOURNEYDateTimePicker.Value
        Dim DD As Integer = Weekday(DTOJ)
        'DAYOJ = WeekdayName(DD)
        INT = IDTextBox.Text + 1
    End Sub

    Private Sub ST__WORKED__ATComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ST__WORKED__ATComboBox.SelectedIndexChanged
        Try
            BEAT__PDataGridView.ClearSelection()
            Dim IIN As Integer = Me.ST__WORKED__ATComboBox.SelectedIndex
            BEAT__PDataGridView.Rows(IIN).Selected = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub DEPMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles DEPMaskedTextBox.MaskInputRejected

    End Sub
End Class