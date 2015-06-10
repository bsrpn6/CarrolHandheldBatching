<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloseWorkOrderStep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CloseWorkOrderStep))
        Me.NoBtn = New System.Windows.Forms.Button()
        Me.YesBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StepDurationTxtBox = New System.Windows.Forms.TextBox()
        Me.WorkOrderNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AbortStepBtn = New System.Windows.Forms.Button()
        Me.WorkOrderStepTargetQtyTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NoBtn
        '
        Me.NoBtn.BackColor = System.Drawing.SystemColors.Control
        Me.NoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoBtn.Location = New System.Drawing.Point(115, 252)
        Me.NoBtn.Name = "NoBtn"
        Me.NoBtn.Size = New System.Drawing.Size(75, 25)
        Me.NoBtn.TabIndex = 28
        Me.NoBtn.Text = "No"
        Me.NoBtn.UseVisualStyleBackColor = False
        '
        'YesBtn
        '
        Me.YesBtn.BackColor = System.Drawing.SystemColors.Control
        Me.YesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesBtn.Location = New System.Drawing.Point(35, 252)
        Me.YesBtn.Name = "YesBtn"
        Me.YesBtn.Size = New System.Drawing.Size(75, 25)
        Me.YesBtn.TabIndex = 27
        Me.YesBtn.Text = "Yes"
        Me.YesBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 38)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Would you like to mark " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this step complete?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Current Time In Step"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StepDurationTxtBox
        '
        Me.StepDurationTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepDurationTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepDurationTxtBox.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepDurationTxtBox.ForeColor = System.Drawing.Color.White
        Me.StepDurationTxtBox.Location = New System.Drawing.Point(11, 131)
        Me.StepDurationTxtBox.Name = "StepDurationTxtBox"
        Me.StepDurationTxtBox.ReadOnly = True
        Me.StepDurationTxtBox.Size = New System.Drawing.Size(203, 56)
        Me.StepDurationTxtBox.TabIndex = 32
        Me.StepDurationTxtBox.TabStop = False
        '
        'WorkOrderNumberTxtBox
        '
        Me.WorkOrderNumberTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderNumberTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderNumberTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderNumberTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderNumberTxtBox.Location = New System.Drawing.Point(108, 10)
        Me.WorkOrderNumberTxtBox.Name = "WorkOrderNumberTxtBox"
        Me.WorkOrderNumberTxtBox.ReadOnly = True
        Me.WorkOrderNumberTxtBox.Size = New System.Drawing.Size(107, 19)
        Me.WorkOrderNumberTxtBox.TabIndex = 35
        Me.WorkOrderNumberTxtBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Step Num:"
        '
        'AbortStepBtn
        '
        Me.AbortStepBtn.BackColor = System.Drawing.SystemColors.Control
        Me.AbortStepBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbortStepBtn.Location = New System.Drawing.Point(35, 65)
        Me.AbortStepBtn.Name = "AbortStepBtn"
        Me.AbortStepBtn.Size = New System.Drawing.Size(155, 25)
        Me.AbortStepBtn.TabIndex = 36
        Me.AbortStepBtn.Text = "Abort Step"
        Me.AbortStepBtn.UseVisualStyleBackColor = False
        '
        'WorkOrderStepTargetQtyTxtBox
        '
        Me.WorkOrderStepTargetQtyTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderStepTargetQtyTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderStepTargetQtyTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderStepTargetQtyTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderStepTargetQtyTxtBox.Location = New System.Drawing.Point(83, 30)
        Me.WorkOrderStepTargetQtyTxtBox.Name = "WorkOrderStepTargetQtyTxtBox"
        Me.WorkOrderStepTargetQtyTxtBox.ReadOnly = True
        Me.WorkOrderStepTargetQtyTxtBox.Size = New System.Drawing.Size(128, 19)
        Me.WorkOrderStepTargetQtyTxtBox.TabIndex = 38
        Me.WorkOrderStepTargetQtyTxtBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Target:"
        '
        'CloseWorkOrderStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.WorkOrderStepTargetQtyTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AbortStepBtn)
        Me.Controls.Add(Me.WorkOrderNumberTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StepDurationTxtBox)
        Me.Controls.Add(Me.NoBtn)
        Me.Controls.Add(Me.YesBtn)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CloseWorkOrderStep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NoBtn As System.Windows.Forms.Button
    Friend WithEvents YesBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StepDurationTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WorkOrderNumberTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AbortStepBtn As System.Windows.Forms.Button
    Friend WithEvents WorkOrderStepTargetQtyTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
