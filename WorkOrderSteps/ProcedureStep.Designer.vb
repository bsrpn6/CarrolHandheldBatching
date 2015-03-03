<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcedureStep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcedureStep))
        Me.ReturnBtn = New System.Windows.Forms.PictureBox()
        Me.HomeBtn = New System.Windows.Forms.PictureBox()
        Me.StepItemTxtBox = New System.Windows.Forms.TextBox()
        Me.StepNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.InstructionsTxtBox = New System.Windows.Forms.TextBox()
        Me.SkipStepBtn = New System.Windows.Forms.Button()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReturnBtn
        '
        Me.ReturnBtn.Image = CType(resources.GetObject("ReturnBtn.Image"), System.Drawing.Image)
        Me.ReturnBtn.Location = New System.Drawing.Point(194, 252)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(25, 25)
        Me.ReturnBtn.TabIndex = 45
        Me.ReturnBtn.TabStop = False
        '
        'HomeBtn
        '
        Me.HomeBtn.Image = CType(resources.GetObject("HomeBtn.Image"), System.Drawing.Image)
        Me.HomeBtn.Location = New System.Drawing.Point(4, 252)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(25, 25)
        Me.HomeBtn.TabIndex = 44
        Me.HomeBtn.TabStop = False
        '
        'StepItemTxtBox
        '
        Me.StepItemTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepItemTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepItemTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepItemTxtBox.ForeColor = System.Drawing.Color.White
        Me.StepItemTxtBox.Location = New System.Drawing.Point(0, 31)
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
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.Location = New System.Drawing.Point(75, 252)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 25)
        Me.SubmitBtn.TabIndex = 57
        Me.SubmitBtn.Text = "Start"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'InstructionsTxtBox
        '
        Me.InstructionsTxtBox.BackColor = System.Drawing.Color.Black
        Me.InstructionsTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InstructionsTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionsTxtBox.ForeColor = System.Drawing.Color.White
        Me.InstructionsTxtBox.Location = New System.Drawing.Point(13, 125)
        Me.InstructionsTxtBox.Multiline = True
        Me.InstructionsTxtBox.Name = "InstructionsTxtBox"
        Me.InstructionsTxtBox.ReadOnly = True
        Me.InstructionsTxtBox.Size = New System.Drawing.Size(199, 121)
        Me.InstructionsTxtBox.TabIndex = 54
        Me.InstructionsTxtBox.TabStop = False
        '
        'SkipStepBtn
        '
        Me.SkipStepBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SkipStepBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkipStepBtn.Location = New System.Drawing.Point(35, 62)
        Me.SkipStepBtn.Name = "SkipStepBtn"
        Me.SkipStepBtn.Size = New System.Drawing.Size(155, 25)
        Me.SkipStepBtn.TabIndex = 58
        Me.SkipStepBtn.Text = "Skip Step"
        Me.SkipStepBtn.UseVisualStyleBackColor = False
        Me.SkipStepBtn.Visible = False
        '
        'ProcedureStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.SkipStepBtn)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.InstructionsTxtBox)
        Me.Controls.Add(Me.StepItemTxtBox)
        Me.Controls.Add(Me.StepNumberTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Name = "ProcedureStep"
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReturnBtn As System.Windows.Forms.PictureBox
    Friend WithEvents HomeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents StepItemTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents StepNumberTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents InstructionsTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents SkipStepBtn As System.Windows.Forms.Button
End Class
