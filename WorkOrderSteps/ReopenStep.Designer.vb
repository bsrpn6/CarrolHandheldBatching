<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReopenStep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReopenStep))
        Me.StepItemTxtBox = New System.Windows.Forms.TextBox()
        Me.StepNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoBtn = New System.Windows.Forms.Button()
        Me.YesBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StepItemTxtBox
        '
        Me.StepItemTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepItemTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepItemTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepItemTxtBox.ForeColor = System.Drawing.Color.White
        Me.StepItemTxtBox.Location = New System.Drawing.Point(0, 32)
        Me.StepItemTxtBox.Name = "StepItemTxtBox"
        Me.StepItemTxtBox.ReadOnly = True
        Me.StepItemTxtBox.Size = New System.Drawing.Size(225, 19)
        Me.StepItemTxtBox.TabIndex = 50
        Me.StepItemTxtBox.TabStop = False
        Me.StepItemTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StepNumberTxtBox
        '
        Me.StepNumberTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepNumberTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepNumberTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepNumberTxtBox.ForeColor = System.Drawing.Color.White
        Me.StepNumberTxtBox.Location = New System.Drawing.Point(108, 9)
        Me.StepNumberTxtBox.Name = "StepNumberTxtBox"
        Me.StepNumberTxtBox.ReadOnly = True
        Me.StepNumberTxtBox.Size = New System.Drawing.Size(101, 19)
        Me.StepNumberTxtBox.TabIndex = 49
        Me.StepNumberTxtBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Step Num:"
        '
        'NoBtn
        '
        Me.NoBtn.BackColor = System.Drawing.SystemColors.Control
        Me.NoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoBtn.Location = New System.Drawing.Point(115, 252)
        Me.NoBtn.Name = "NoBtn"
        Me.NoBtn.Size = New System.Drawing.Size(75, 25)
        Me.NoBtn.TabIndex = 56
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
        Me.YesBtn.TabIndex = 55
        Me.YesBtn.Text = "Yes"
        Me.YesBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 38)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Would you like to reopen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this step?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReopenStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NoBtn)
        Me.Controls.Add(Me.YesBtn)
        Me.Controls.Add(Me.StepItemTxtBox)
        Me.Controls.Add(Me.StepNumberTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReopenStep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StepItemTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents StepNumberTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NoBtn As System.Windows.Forms.Button
    Friend WithEvents YesBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
