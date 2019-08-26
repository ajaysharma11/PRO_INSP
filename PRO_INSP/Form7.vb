Imports System.Data.OleDb
Imports System.String
Imports System.Data

Public Class Form7
    Dim IDT As Integer
    Dim WDT As Date
    Dim DTOJ As Date
    Dim DAYOJ As Date
    Dim INT As Integer
    Dim INT2 As Integer
    Dim STR1 As String
    Dim STR2 As String
    Dim ds As New DataSet
    Dim BS As BindingSource = New BindingSource()
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
        BEAT__PBindingSource.MoveLast()


        CMD_ADD.Select()
    End Sub

    Private Sub CMD_ADD_Click(sender As Object, e As EventArgs) Handles CMD_ADD.Click
        JOMBindingSource.AddNew()
        IDTextBox.Select()
        Me.Refresh()
    End Sub

    Private Sub CMD_SAVE_Click(sender As Object, e As EventArgs) Handles CMD_SAVE.Click
        'INSERT DATA
        Try

            JOMTableAdapter.InsertQuery(WEEK_ENDINGDateTimePicker.Value, DATE__OF__JOURNEYDateTimePicker.Value, DAY_OF_JOURNEYDateTimePicker.Value, TRAINTextBox.Text, DEPDateTimePicker.Text, ARRDateTimePicker.Text, ST_FROMTextBox.Text, ST_TOTextBox.Text, ST__WORKED__ATComboBox.Text, ROUNDComboBox.Text, DAY_BOOKEDNumericUpDown.Value, REMARKSTextBox.Text, IR_CASE__NOTextBox.Text, INSP_COMComboBox.Text, REPORT__SUBMISSIONDateTimePicker.Value, _2RODTextBox.Text, _3RODTextBox.Text, _1R0DTextBox.Text, LINSPDateTimePicker.Value, NDUETextBox.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        JOMDataGridView.Refresh()
        'Update Data
        Try
            JOMBindingSource.EndEdit()
            JOMTableAdapter.Update(Me.DAILY__INSPDataSet.JOM)
            BEAT__PBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.DAILY__INSPDataSet)
            DAILY__INSPDataSet.AcceptChanges()
            MsgBox("DATA SAVED")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


        Me.Refresh()
        JOMDataGridView.Refresh()
    End Sub

    Private Sub CMD_EXIT_Click(sender As Object, e As EventArgs) Handles CMD_EXIT.Click

        FRM_MAIN.Show()

        Me.Close()


    End Sub

    Private Sub CMD_ADD_LostFocus(sender As Object, e As EventArgs) Handles CMD_ADD.LostFocus
        ST__WORKED__ATComboBox.Items.Clear()
        Dim NN As Integer = BEAT__PBindingSource.Count
        For NN = 0 To NN - 1
            STR1 = BEAT__PTableAdapter.GetData(NN).STATION
            ST__WORKED__ATComboBox.Items.Add(STR1)
            BEAT__PBindingSource.MoveNext()
        Next NN



        'INCREASE WEEK AND DATE AND ID
        WEEK_ENDINGDateTimePicker.Value = Now

        If Weekday(DTOJ, vbSunday) = 7 Then
            WEEK_ENDINGDateTimePicker.Text = DateAdd(DateInterval.Day, 7, WDT)
        Else
            WEEK_ENDINGDateTimePicker.Text = WDT
        End If
        DATE__OF__JOURNEYDateTimePicker.Value = DateAdd("d", 1, DTOJ)
        DAY_OF_JOURNEYDateTimePicker.Value = DATE__OF__JOURNEYDateTimePicker.Value


        IDTextBox.Text = INT + 1
        INT2 = JOMBindingSource.Count - 1
        JOMDataGridView.Rows(INT2).Cells(0).Value = INT + 1

        ' BEAT__PBindingSource.EndEdit()
        ST__WORKED__ATComboBox.SelectedIndex() = 0
        INSP_COMComboBox.SelectedIndex() = 0

        IDTextBox.Select()
    End Sub

    Private Sub CMD_ADD_KeyUp(sender As Object, e As KeyEventArgs) Handles CMD_ADD.KeyUp
        If e.KeyCode = Keys.Enter Then
            IDTextBox.Select()
        End If
    End Sub

    Private Sub CTR(sender As Object, e As KeyEventArgs) Handles WEEK_ENDINGDateTimePicker.KeyUp, TRAINTextBox.KeyUp, DEPDateTimePicker.KeyUp, ARRDateTimePicker.KeyUp, ST_TOTextBox.KeyUp, ST_FROMTextBox.KeyUp, ST__WORKED__ATComboBox.KeyUp, ROUNDComboBox.KeyUp, REPORT__SUBMISSIONDateTimePicker.KeyUp, REMARKSTextBox.KeyUp, IR_CASE__NOTextBox.KeyUp, INSP_COMComboBox.KeyUp, DAY_OF_JOURNEYDateTimePicker.KeyUp, DAY_BOOKEDNumericUpDown.KeyUp, DATE__OF__JOURNEYDateTimePicker.KeyUp, CMD_SAVE.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, False)
        End If
    End Sub

    Private Sub CMD_ADD_GotFocus(sender As Object, e As EventArgs) Handles CMD_ADD.GotFocus

        WDT = WEEK_ENDINGDateTimePicker.Value
        DTOJ = DAY_OF_JOURNEYDateTimePicker.Value
        Dim DD As Integer = Weekday(DTOJ)
        INT = IDTextBox.Text

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


    Private Sub ROUNDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ROUNDComboBox.SelectedIndexChanged
        If Me.ROUNDComboBox.Text = "1st ROUND" And DAY_BOOKEDNumericUpDown.Value = 1 Then
            Me._1R0DTextBox.Text = Me.DATE__OF__JOURNEYDateTimePicker.Value
            Me._2RODTextBox.Text = ""
            Me._3RODTextBox.Text = ""
        ElseIf ROUNDComboBox.Text = "2nd ROUND" And DAY_BOOKEDNumericUpDown.Value = 1 Then
            Me._2RODTextBox.Text = Me.DATE__OF__JOURNEYDateTimePicker.Value
            Me._1R0DTextBox.Text = ""
            Me._3RODTextBox.Text = ""
        ElseIf ROUNDComboBox.Text = "3rd ROUND" And DAY_BOOKEDNumericUpDown.Value = 1 Then
            Me._3RODTextBox.Text = Me.DATE__OF__JOURNEYDateTimePicker.Value
            Me._2RODTextBox.Text = ""
            Me._1R0DTextBox.Text = ""
        End If
    End Sub

    Private Sub CMD_EDIT_Click(sender As Object, e As EventArgs) Handles CMD_EDIT.Click


        If JOMDataGridView.Rows.Count <> 0 Then
            Try
                JOMBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.DAILY__INSPDataSet)
                DAILY__INSPDataSet.AcceptChanges()
                MsgBox("DATA SAVED")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If


        '  connect.Close()
    End Sub

    Private Sub IDTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles IDTextBox.KeyUp
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            WEEK_ENDINGDateTimePicker.Select()

        End If
    End Sub

    Private Sub WEEK_ENDINGDateTimePicker_GotFocus(sender As Object, e As EventArgs) Handles WEEK_ENDINGDateTimePicker.GotFocus
        WEEK_ENDINGDateTimePicker.Refresh()
    End Sub

    Private Sub DAY_BOOKEDNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles DAY_BOOKEDNumericUpDown.ValueChanged
        Try
            BEAT__PDataGridView.ClearSelection()
            Dim INTG As Integer = DAY_BOOKEDNumericUpDown.Value
            Dim IINN As Integer = ST__WORKED__ATComboBox.SelectedIndex
            BEAT__PDataGridView.Rows(IINN).Selected = True
            BEAT__PDataGridView.Rows(IINN).Cells(2).Value = INTG
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub INSP_COMComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles INSP_COMComboBox.SelectedIndexChanged
        If INSP_COMComboBox.Text = "YES" Then
            REPORT__SUBMISSIONDateTimePicker.Value = DATE__OF__JOURNEYDateTimePicker.Value
        End If

    End Sub


    Private Sub IR_CASE__NOTextBox_LostFocus(sender As Object, e As EventArgs) Handles IR_CASE__NOTextBox.LostFocus
        INSP_COMComboBox.SelectedIndex() = 0
    End Sub



    Private Sub CMD_FIRST_Click(sender As Object, e As EventArgs) Handles CMD_FIRST.Click
        JOMBindingSource.MoveFirst()
    End Sub

    Private Sub CMD_PRE_Click(sender As Object, e As EventArgs) Handles CMD_PRE.Click
        JOMBindingSource.MovePrevious()
    End Sub

    Private Sub CMD_NEXT_Click(sender As Object, e As EventArgs) Handles CMD_NEXT.Click
        JOMBindingSource.MoveNext()
    End Sub

    Private Sub CMD_LAST_Click(sender As Object, e As EventArgs) Handles CMD_LAST.Click
        JOMBindingSource.MoveLast()
    End Sub

    Private Sub WEEK_ENDINGDateTimePicker_LostFocus(sender As Object, e As EventArgs) Handles WEEK_ENDINGDateTimePicker.LostFocus

    End Sub
End Class