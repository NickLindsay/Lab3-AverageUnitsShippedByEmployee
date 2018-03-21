<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployees
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
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtEmployeeInput = New System.Windows.Forms.TextBox()
        Me.lblAverage1 = New System.Windows.Forms.Label()
        Me.lblAverage2 = New System.Windows.Forms.Label()
        Me.lblAverage3 = New System.Windows.Forms.Label()
        Me.lblAverageTotal = New System.Windows.Forms.Label()
        Me.lblEmployeeOutput1 = New System.Windows.Forms.Label()
        Me.lblEmployeeOutput2 = New System.Windows.Forms.Label()
        Me.lblEmployeeOutput3 = New System.Windows.Forms.Label()
        Me.AverageUnitsShippedByEmployeeTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDays
        '
        Me.lblDays.AccessibleName = "lblDays"
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(12, 9)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(29, 13)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "Day:"
        '
        'lblUnits
        '
        Me.lblUnits.AccessibleName = "lblUnits"
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(12, 29)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "Units:"
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AccessibleName = "lblEmployee1"
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Location = New System.Drawing.Point(43, 64)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AccessibleName = "lblEmployee2"
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(138, 64)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee2.TabIndex = 6
        Me.lblEmployee2.Text = "Employee 2"
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AccessibleName = "lblEmployee3"
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(230, 64)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee3.TabIndex = 9
        Me.lblEmployee3.Text = "Employee 3"
        '
        'btnEnter
        '
        Me.btnEnter.AccessibleName = "btnEnter"
        Me.btnEnter.Location = New System.Drawing.Point(35, 254)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(83, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnEnter, "Press the enter button  calculate the average")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AccessibleName = "btnReset"
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(128, 254)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnReset, "Click the reset button to Reset the program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "btnExit"
        Me.btnExit.Location = New System.Drawing.Point(220, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnExit, "Click the Exit button to Exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtEmployeeInput
        '
        Me.txtEmployeeInput.AccessibleName = "txtEmployeeInput"
        Me.txtEmployeeInput.Location = New System.Drawing.Point(46, 26)
        Me.txtEmployeeInput.Name = "txtEmployeeInput"
        Me.txtEmployeeInput.Size = New System.Drawing.Size(66, 20)
        Me.txtEmployeeInput.TabIndex = 2
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.txtEmployeeInput, "Please enter Units shipped")
        '
        'lblAverage1
        '
        Me.lblAverage1.AccessibleName = "lblAverage1"
        Me.lblAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage1.Location = New System.Drawing.Point(35, 190)
        Me.lblAverage1.Name = "lblAverage1"
        Me.lblAverage1.Size = New System.Drawing.Size(83, 23)
        Me.lblAverage1.TabIndex = 5
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblAverage1, "Employee 1 Average Units Shipped")
        '
        'lblAverage2
        '
        Me.lblAverage2.AccessibleName = "lblAverage2"
        Me.lblAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage2.Location = New System.Drawing.Point(128, 190)
        Me.lblAverage2.Name = "lblAverage2"
        Me.lblAverage2.Size = New System.Drawing.Size(83, 23)
        Me.lblAverage2.TabIndex = 8
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblAverage2, "Employee 2 Average Units Shipped")
        '
        'lblAverage3
        '
        Me.lblAverage3.AccessibleName = "lblAverage3"
        Me.lblAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage3.Location = New System.Drawing.Point(220, 190)
        Me.lblAverage3.Name = "lblAverage3"
        Me.lblAverage3.Size = New System.Drawing.Size(83, 23)
        Me.lblAverage3.TabIndex = 11
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblAverage3, "Employee 3 Average Units Shipped")
        '
        'lblAverageTotal
        '
        Me.lblAverageTotal.AccessibleName = "lblAverageTotal"
        Me.lblAverageTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageTotal.Location = New System.Drawing.Point(35, 225)
        Me.lblAverageTotal.Name = "lblAverageTotal"
        Me.lblAverageTotal.Size = New System.Drawing.Size(268, 26)
        Me.lblAverageTotal.TabIndex = 12
        '
        'lblEmployeeOutput1
        '
        Me.lblEmployeeOutput1.AccessibleName = "lblEmployeeOutput1"
        Me.lblEmployeeOutput1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmployeeOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOutput1.Location = New System.Drawing.Point(35, 77)
        Me.lblEmployeeOutput1.Name = "lblEmployeeOutput1"
        Me.lblEmployeeOutput1.Size = New System.Drawing.Size(83, 103)
        Me.lblEmployeeOutput1.TabIndex = 4
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblEmployeeOutput1, "Employee 1 units shipped ouput")
        '
        'lblEmployeeOutput2
        '
        Me.lblEmployeeOutput2.AccessibleName = "lblEmployeeOutput2"
        Me.lblEmployeeOutput2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmployeeOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOutput2.Location = New System.Drawing.Point(128, 77)
        Me.lblEmployeeOutput2.Name = "lblEmployeeOutput2"
        Me.lblEmployeeOutput2.Size = New System.Drawing.Size(83, 103)
        Me.lblEmployeeOutput2.TabIndex = 7
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblEmployeeOutput2, "Employee 2 units shipped ouput")
        '
        'lblEmployeeOutput3
        '
        Me.lblEmployeeOutput3.AccessibleName = "lblEmployeeOutput3"
        Me.lblEmployeeOutput3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmployeeOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOutput3.Location = New System.Drawing.Point(220, 77)
        Me.lblEmployeeOutput3.Name = "lblEmployeeOutput3"
        Me.lblEmployeeOutput3.Size = New System.Drawing.Size(83, 103)
        Me.lblEmployeeOutput3.TabIndex = 10
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblEmployeeOutput3, "Employee 3 units shipped ouput")
        '
        'frmAverageUnitsShippedByEmployees
        '
        Me.AcceptButton = Me.btnEnter
        Me.AccessibleName = "frmAverageUnitsShippedByEmployees"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(338, 289)
        Me.Controls.Add(Me.lblEmployeeOutput3)
        Me.Controls.Add(Me.lblEmployeeOutput2)
        Me.Controls.Add(Me.lblEmployeeOutput1)
        Me.Controls.Add(Me.lblAverageTotal)
        Me.Controls.Add(Me.lblAverage3)
        Me.Controls.Add(Me.lblAverage2)
        Me.Controls.Add(Me.lblAverage1)
        Me.Controls.Add(Me.txtEmployeeInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDays)
        Me.Name = "frmAverageUnitsShippedByEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDays As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtEmployeeInput As TextBox
    Friend WithEvents lblAverage1 As Label
    Friend WithEvents lblAverage2 As Label
    Friend WithEvents lblAverage3 As Label
    Friend WithEvents lblAverageTotal As Label
    Friend WithEvents lblEmployeeOutput1 As Label
    Friend WithEvents lblEmployeeOutput2 As Label
    Friend WithEvents lblEmployeeOutput3 As Label
    Friend WithEvents AverageUnitsShippedByEmployeeTips As ToolTip
End Class
