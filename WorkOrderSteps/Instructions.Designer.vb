<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructions))
        Me.InstructionsTxtBox = New System.Windows.Forms.TextBox()
        Me.ReturnBtn = New System.Windows.Forms.PictureBox()
        Me.SkipStepBtn = New System.Windows.Forms.Button()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InstructionsTxtBox
        '
        Me.InstructionsTxtBox.BackColor = System.Drawing.Color.White
        Me.InstructionsTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionsTxtBox.Location = New System.Drawing.Point(2, 0)
        Me.InstructionsTxtBox.Multiline = True
        Me.InstructionsTxtBox.Name = "InstructionsTxtBox"
        Me.InstructionsTxtBox.ReadOnly = True
        Me.InstructionsTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InstructionsTxtBox.Size = New System.Drawing.Size(221, 250)
        Me.InstructionsTxtBox.TabIndex = 2
        Me.InstructionsTxtBox.TabStop = False
        '
        'ReturnBtn
        '
        Me.ReturnBtn.Image = CType(resources.GetObject("ReturnBtn.Image"), System.Drawing.Image)
        Me.ReturnBtn.Location = New System.Drawing.Point(194, 252)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(25, 25)
        Me.ReturnBtn.TabIndex = 29
        Me.ReturnBtn.TabStop = False
        '
        'SkipStepBtn
        '
        Me.SkipStepBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SkipStepBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkipStepBtn.Location = New System.Drawing.Point(35, 252)
        Me.SkipStepBtn.Name = "SkipStepBtn"
        Me.SkipStepBtn.Size = New System.Drawing.Size(155, 25)
        Me.SkipStepBtn.TabIndex = 33
        Me.SkipStepBtn.Text = "Skip Step"
        Me.SkipStepBtn.UseVisualStyleBackColor = False
        Me.SkipStepBtn.Visible = False
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.SkipStepBtn)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.InstructionsTxtBox)
        Me.Name = "Instructions"
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InstructionsTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ReturnBtn As System.Windows.Forms.PictureBox
    Friend WithEvents SkipStepBtn As System.Windows.Forms.Button
End Class
