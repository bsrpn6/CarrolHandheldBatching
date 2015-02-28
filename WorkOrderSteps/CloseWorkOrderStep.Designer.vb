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
        Me.NoBtn = New System.Windows.Forms.Button()
        Me.YesBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WorkOrderNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'NoBtn
        '
        Me.NoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoBtn.Location = New System.Drawing.Point(117, 252)
        Me.NoBtn.Name = "NoBtn"
        Me.NoBtn.Size = New System.Drawing.Size(75, 25)
        Me.NoBtn.TabIndex = 28
        Me.NoBtn.Text = "No"
        Me.NoBtn.UseVisualStyleBackColor = True
        '
        'YesBtn
        '
        Me.YesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesBtn.Location = New System.Drawing.Point(37, 252)
        Me.YesBtn.Name = "YesBtn"
        Me.YesBtn.Size = New System.Drawing.Size(75, 25)
        Me.YesBtn.TabIndex = 27
        Me.YesBtn.Text = "Yes"
        Me.YesBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 57)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Would you like to mark " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the following work " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "order step as complete?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WorkOrderNumberTxtBox
        '
        Me.WorkOrderNumberTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderNumberTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderNumberTxtBox.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderNumberTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderNumberTxtBox.Location = New System.Drawing.Point(62, 131)
        Me.WorkOrderNumberTxtBox.Name = "WorkOrderNumberTxtBox"
        Me.WorkOrderNumberTxtBox.ReadOnly = True
        Me.WorkOrderNumberTxtBox.Size = New System.Drawing.Size(100, 28)
        Me.WorkOrderNumberTxtBox.TabIndex = 29
        Me.WorkOrderNumberTxtBox.TabStop = False
        '
        'CloseWorkOrderStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.WorkOrderNumberTxtBox)
        Me.Controls.Add(Me.NoBtn)
        Me.Controls.Add(Me.YesBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CloseWorkOrderStep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NoBtn As System.Windows.Forms.Button
    Friend WithEvents YesBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WorkOrderNumberTxtBox As System.Windows.Forms.TextBox
End Class
