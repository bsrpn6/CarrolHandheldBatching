<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClosedProcedureStep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClosedProcedureStep))
        Me.ReturnBtn = New System.Windows.Forms.PictureBox()
        Me.HomeBtn = New System.Windows.Forms.PictureBox()
        Me.StepItemTxtBox = New System.Windows.Forms.TextBox()
        Me.StepNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WorkOrderStepActualTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WorkOrderStepStatusTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WorkOrderDurationTxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StopStepDateTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StartStepDateTxtBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.StepItemTxtBox.Location = New System.Drawing.Point(2, 31)
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
        Me.StepNumberTxtBox.Location = New System.Drawing.Point(101, 10)
        Me.StepNumberTxtBox.Name = "StepNumberTxtBox"
        Me.StepNumberTxtBox.ReadOnly = True
        Me.StepNumberTxtBox.Size = New System.Drawing.Size(108, 19)
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
        'WorkOrderStepActualTxtBox
        '
        Me.WorkOrderStepActualTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderStepActualTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderStepActualTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderStepActualTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderStepActualTxtBox.Location = New System.Drawing.Point(81, 125)
        Me.WorkOrderStepActualTxtBox.Name = "WorkOrderStepActualTxtBox"
        Me.WorkOrderStepActualTxtBox.ReadOnly = True
        Me.WorkOrderStepActualTxtBox.Size = New System.Drawing.Size(130, 19)
        Me.WorkOrderStepActualTxtBox.TabIndex = 54
        Me.WorkOrderStepActualTxtBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Actual:"
        '
        'WorkOrderStepStatusTxtBox
        '
        Me.WorkOrderStepStatusTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderStepStatusTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderStepStatusTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderStepStatusTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderStepStatusTxtBox.Location = New System.Drawing.Point(82, 55)
        Me.WorkOrderStepStatusTxtBox.Name = "WorkOrderStepStatusTxtBox"
        Me.WorkOrderStepStatusTxtBox.ReadOnly = True
        Me.WorkOrderStepStatusTxtBox.Size = New System.Drawing.Size(131, 19)
        Me.WorkOrderStepStatusTxtBox.TabIndex = 56
        Me.WorkOrderStepStatusTxtBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Status:"
        '
        'WorkOrderDurationTxtBox
        '
        Me.WorkOrderDurationTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderDurationTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderDurationTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderDurationTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderDurationTxtBox.Location = New System.Drawing.Point(99, 228)
        Me.WorkOrderDurationTxtBox.Name = "WorkOrderDurationTxtBox"
        Me.WorkOrderDurationTxtBox.ReadOnly = True
        Me.WorkOrderDurationTxtBox.Size = New System.Drawing.Size(112, 19)
        Me.WorkOrderDurationTxtBox.TabIndex = 58
        Me.WorkOrderDurationTxtBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 19)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Duration:"
        '
        'StopStepDateTxtBox
        '
        Me.StopStepDateTxtBox.BackColor = System.Drawing.Color.Black
        Me.StopStepDateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StopStepDateTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopStepDateTxtBox.ForeColor = System.Drawing.Color.White
        Me.StopStepDateTxtBox.Location = New System.Drawing.Point(69, 209)
        Me.StopStepDateTxtBox.Name = "StopStepDateTxtBox"
        Me.StopStepDateTxtBox.ReadOnly = True
        Me.StopStepDateTxtBox.Size = New System.Drawing.Size(142, 19)
        Me.StopStepDateTxtBox.TabIndex = 60
        Me.StopStepDateTxtBox.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 19)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Stop:"
        '
        'StartStepDateTxtBox
        '
        Me.StartStepDateTxtBox.BackColor = System.Drawing.Color.Black
        Me.StartStepDateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StartStepDateTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartStepDateTxtBox.ForeColor = System.Drawing.Color.White
        Me.StartStepDateTxtBox.Location = New System.Drawing.Point(69, 190)
        Me.StartStepDateTxtBox.Name = "StartStepDateTxtBox"
        Me.StartStepDateTxtBox.ReadOnly = True
        Me.StartStepDateTxtBox.Size = New System.Drawing.Size(142, 19)
        Me.StartStepDateTxtBox.TabIndex = 62
        Me.StartStepDateTxtBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 19)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Start:"
        '
        'ClosedProcedureStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.StartStepDateTxtBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StopStepDateTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.WorkOrderDurationTxtBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.WorkOrderStepStatusTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WorkOrderStepActualTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StepItemTxtBox)
        Me.Controls.Add(Me.StepNumberTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Name = "ClosedProcedureStep"
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
    Friend WithEvents WorkOrderStepActualTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents WorkOrderStepStatusTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WorkOrderDurationTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StopStepDateTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StartStepDateTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
