Imports System.Data.OleDb
Imports System.String
Imports System.Data

Public Class Form7

    Dim WDT As Date
    Dim DTOJ As Date
    Dim DAYOJ As Date
    Dim INT As Integer
    Dim INT2 As Integer
    Dim STR1 As String
    Dim STR2 As String
    ' Dim constring As String = ("Provider = Microsoft.ACE.OLEDB .12.0;Data Source= "|DataDirectory|\DAILY_ INSP.accdb"")
    ' Dim constring As String = Provider = Microsoft.ACE.OLEDB.12.0;Data Source="|DataDirectory|\DAILY_ INSP.accdb"

    ' Dim connect As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source="|DataDirectory|\DAILY_ INSP.accdb"")
    ' con.ConnectionString =( Provider = Microsoft.ACE.OLEDB.12.0;Data Source="C:\MY VB PROJECT\TIA_INSP\\DAILY_ INSP.accdb")
    Dim ds As New DataSet

    ' Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("select * from JOM", connect)
    Dim DGV As DataGridView = New DataGridView()
    Dim BS As BindingSource = New BindingSource()
    ' Dim CONN As String = Provider = Microsoft.ACE.OLEDB.12.0;Data Source="|DataDirectory|\DAILY_ INSP.accdb"
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
        JOMBindingSource1.MoveLast()
        BEAT__PBindingSource.MoveLast()

        'Label3.Text = Me.DAILY__INSPDataSet.JOM.Rows.Count
        CMD_ADD.Select()
    End Sub

    Private Sub CMD_ADD_Click(sender As Object, e As EventArgs) Handles CMD_ADD.Click
        JOMBindingSource.AddNew()
        IDTextBox.Select()
        Me.Refresh()
    End Sub

    Private Sub CMD_SAVE_Click(sender As Object, e As EventArgs) Handles CMD_SAVE.Click

        Try
            ' JOMBindingSource.EndEdit()
            JOMTableAdapter.InsertQuery(WEEK_ENDINGDateTimePicker.Value, DATE__OF__JOURNEYDateTimePicker.Value, DAY_OF_JOURNEYDateTimePicker.Value, TRAINTextBox.Text, DEPMaskedTextBox.Text, ARRMaskedTextBox.Text, ST_FROMTextBox.Text, ST_TOTextBox.Text, ST__WORKED__ATComboBox.Text, ROUNDComboBox.Text, DAY_BOOKEDNumericUpDown.Value, REMARKSTextBox.Text, IR_CASE__NOTextBox.Text, INSP_COMComboBox.Text, REPORT__SUBMISSIONDateTimePicker.Value, _2RODDateTimePicker.Value, _3RODDateTimePicker.Value, _1R0DDateTimePicker.Value, LINSPDateTimePicker.Value, NDUETextBox.Text)
            ' JOMTableAdapter.Update(Me.DAILY__INSPDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        '' CHECK If DATA ADDED TO DATASET
        'If DAILY__INSPDataSet.HasChanges Then
        '    MsgBox("DATA ADDED TO DATASET")
        'Else
        '    MsgBox("DATA NOT ADDED TO DATASET")
        'End If
        JOMDataGridView.Refresh()

        Try
            JOMBindingSource.EndEdit()
            JOMTableAdapter.Update(Me.DAILY__INSPDataSet.JOM)
            BEAT__PBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.DAILY__INSPDataSet)
            DAILY__INSPDataSet.AcceptChanges()
            MsgBox("TOTAL " & INT2 & "DATA SAVED")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

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
        '  BEAT__PBindingSource.MoveLast()


        'INCREASE WEEK AND DATE
        WEEK_ENDINGDateTimePicker.Value = Now
        If Weekday(DTOJ, vbSunday) = 7 Then
            WEEK_ENDINGDateTimePicker.Text = DateAdd(DateInterval.Day, 7, WDT)
        Else
            WEEK_ENDINGDateTimePicker.Text = WDT
        End If

        IDTextBox.Text = INT
        DATE__OF__JOURNEYDateTimePicker.Value = DateAdd("d", 1, DTOJ)
        DAY_OF_JOURNEYDateTimePicker.Value = DATE__OF__JOURNEYDateTimePicker.Value
        BEAT__PBindingSource.EndEdit()
        'BEAT__PDataGridView.ClearSelection()
        'ST__WORKED__ATComboBox.Visible = True

        IDTextBox.Select()
    End Sub

    Private Sub CMD_ADD_KeyUp(sender As Object, e As KeyEventArgs) Handles CMD_ADD.KeyUp
        If e.KeyCode = Keys.Enter Then
            IDTextBox.Select()
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


    Private Sub ROUNDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ROUNDComboBox.SelectedIndexChanged
        If Me.ROUNDComboBox.Text = "1ST ROUND" And DAY_BOOKEDNumericUpDown.Value = 1 Then
            Me._1R0DDateTimePicker.Text = Me.DATE__OF__JOURNEYDateTimePicker.Value
            Me._2RODDateTimePicker.Text = ""
            Me._3RODDateTimePicker.Text = ""
        ElseIf ROUNDComboBox.Text = "2ND ROUND" And DAY_BOOKEDNumericUpDown.Value = 1 Then
            Me._2RODDateTimePicker.Text = Me.DATE__OF__JOURNEYDateTimePicker.Value
            Me._1R0DDateTimePicker.Text = ""
            Me._3RODDateTimePicker.Text = ""
        ElseIf ROUNDComboBox.Text = "3RD ROUND" And DAY_BOOKEDNumericUpDown.Value = 1 Then
            Me._3RODDateTimePicker.Text = Me.DATE__OF__JOURNEYDateTimePicker.Value
            Me._2RODDateTimePicker.Text = ""
            Me._1R0DDateTimePicker.Text = ""
        End If
    End Sub

    Private Sub CMD_EDIT_Click(sender As Object, e As EventArgs) Handles CMD_EDIT.Click
        ' connect.Open()

        ' ds = Me.DAILY__INSPDataSet.GetChanges()

        'JOMDataGridView.DataSource = ds

        If JOMDataGridView.Rows.Count <> 0 Then
            Try
                JOMBindingSource.EndEdit()
                ' JOMTableAdapter.Update(Me.DAILY__INSPDataSet.JOM)
                TableAdapterManager.UpdateAll(Me.DAILY__INSPDataSet)
                DAILY__INSPDataSet.AcceptChanges()
                MsgBox("DATA SAVED")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        Else

            ' Try
            ' Me.DAILY__INSPDataSet.Merge(ds)
            JOMBindingSource.EndEdit()
                JOMTableAdapter.Update(Me.DAILY__INSPDataSet.JOM)
                ' TableAdapterManager.UpdateAll(Me.DAILY__INSPDataSet)
                DAILY__INSPDataSet.AcceptChanges()
                MsgBox("JAI HO DATA SAVED")
            ' Catch ex As Exception
            'gBox(ex.Message, MsgBoxStyle.Critical)
            ' End Try

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

    Private Sub CMDJOM_Click(sender As Object, e As EventArgs)

    End Sub
End Class