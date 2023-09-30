<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAs1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblWage = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.chkbxSalary = New System.Windows.Forms.CheckBox()
        Me.lblCalculatedWage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(12, 97)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(42, 15)
        Me.lblHours.TabIndex = 1
        Me.lblHours.Text = "Hours:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(12, 53)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 15)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID:"
        '
        'lblWage
        '
        Me.lblWage.AutoSize = True
        Me.lblWage.Location = New System.Drawing.Point(12, 141)
        Me.lblWage.Name = "lblWage"
        Me.lblWage.Size = New System.Drawing.Size(40, 15)
        Me.lblWage.TabIndex = 3
        Me.lblWage.Text = "Wage:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(74, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(155, 23)
        Me.txtName.TabIndex = 1
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(74, 138)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(155, 23)
        Me.txtWage.TabIndex = 4
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(74, 94)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(155, 23)
        Me.txtHours.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(74, 50)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(155, 23)
        Me.txtID.TabIndex = 2
        '
        'chkbxSalary
        '
        Me.chkbxSalary.AutoSize = True
        Me.chkbxSalary.Location = New System.Drawing.Point(13, 183)
        Me.chkbxSalary.Name = "chkbxSalary"
        Me.chkbxSalary.Size = New System.Drawing.Size(118, 19)
        Me.chkbxSalary.TabIndex = 5
        Me.chkbxSalary.Text = "Salaried Position?"
        Me.chkbxSalary.UseVisualStyleBackColor = True
        '
        'lblCalculatedWage
        '
        Me.lblCalculatedWage.AutoSize = True
        Me.lblCalculatedWage.Location = New System.Drawing.Point(161, 186)
        Me.lblCalculatedWage.Name = "lblCalculatedWage"
        Me.lblCalculatedWage.Size = New System.Drawing.Size(106, 15)
        Me.lblCalculatedWage.TabIndex = 6
        Me.lblCalculatedWage.Text = "lblCalculatedWage"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 218)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(320, 41)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Wage"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(13, 274)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(93, 43)
        Me.btnLeft.TabIndex = 8
        Me.btnLeft.Text = "<<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(239, 274)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(93, 43)
        Me.btnRight.TabIndex = 10
        Me.btnRight.Text = ">>"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(126, 274)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(93, 43)
        Me.btnAddNew.TabIndex = 9
        Me.btnAddNew.Text = "Add New Employee"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 337)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(146, 47)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(186, 337)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 47)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAs1
        '
        Me.AccessibleDescription = "Payroll System"
        Me.AccessibleName = "Payroll System"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 396)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCalculatedWage)
        Me.Controls.Add(Me.chkbxSalary)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtWage)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblWage)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmAs1"
        Me.Text = "Payroll System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblWage As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtWage As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents chkbxSalary As CheckBox
    Friend WithEvents lblCalculatedWage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
