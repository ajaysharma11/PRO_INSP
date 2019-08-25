<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MAIN
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
        Dim CMDJOM As System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMD_REPORT = New System.Windows.Forms.Button()
        Me.CMD_BEAT = New System.Windows.Forms.Button()
        Me.CMD_AT_A_GLANCE = New System.Windows.Forms.Button()
        Me.CMD_MY_DATA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CMDJOM = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        CMDJOM.TabIndex = 5
        CMDJOM.Text = "JOM FEDING"
        CMDJOM.UseVisualStyleBackColor = True
        AddHandler CMDJOM.Click, AddressOf Me.CMDJOM_Click
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
        Me.Panel5.Location = New System.Drawing.Point(-2, -11)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(218, 464)
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
        Me.CMD_REPORT.TabIndex = 8
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
        Me.CMD_BEAT.TabIndex = 6
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
        Me.CMD_AT_A_GLANCE.TabIndex = 7
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
        Me.CMD_MY_DATA.TabIndex = 4
        Me.CMD_MY_DATA.Text = "MY DATA"
        Me.CMD_MY_DATA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(296, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AT A GLANCE"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(803, 20)
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
        Me.Panel3.Location = New System.Drawing.Point(215, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(901, 61)
        Me.Panel3.TabIndex = 118
        '
        'FRM_MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1115, 442)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FRM_MAIN"
        Me.Text = "MAIN"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
