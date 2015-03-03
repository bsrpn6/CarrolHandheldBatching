<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClosedWorkOrderStep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClosedWorkOrderStep))
        Me.ReturnBtn = New System.Windows.Forms.PictureBox()
        Me.HomeBtn = New System.Windows.Forms.PictureBox()
        Me.StepNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StepActualTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StepStatusTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WorkOrderDurationTxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StopStepDateTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StartStepDateTxtBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LotNumTxtBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StepItemDescTxtBox = New System.Windows.Forms.TextBox()
        Me.StepItemTxtBox = New System.Windows.Forms.TextBox()
        CType(Me.ReturnBtn,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.HomeBtn,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ReturnBtn
        '
        Me.ReturnBtn.Image = CType(resources.GetObject("ReturnBtn.Image"),System.Drawing.Image)
        Me.ReturnBtn.Location = New System.Drawing.Point(194, 252)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(25, 25)
        Me.ReturnBtn.TabIndex = 45
        Me.ReturnBtn.TabStop = false
        '
        'HomeBtn
        '
        Me.HomeBtn.Image = CType(resources.GetObject("HomeBtn.Image"),System.Drawing.Image)
        Me.HomeBtn.Location = New System.Drawing.Point(4, 252)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(25, 25)
        Me.HomeBtn.TabIndex = 44
        Me.HomeBtn.TabStop = false
        '
        'StepNumberTxtBox
        '
        Me.StepNumberTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepNumberTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepNumberTxtBox.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StepNumberTxtBox.ForeColor = System.Drawing.Color.White
        Me.StepNumberTxtBox.Location = New System.Drawing.Point(108, 9)
        Me.StepNumberTxtBox.Name = "StepNumberTxtBox"
        Me.StepNumberTxtBox.ReadOnly = True
        Me.StepNumberTxtBox.Size = New System.Drawing.Size(106, 19)
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
        'StepActualTxtBox
        '
        Me.StepActualTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepActualTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepActualTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepActualTxtBox.ForeColor = System.Drawing.Color.White
        Me.StepActualTxtBox.Location = New System.Drawing.Point(81, 123)
        Me.StepActualTxtBox.Name = "StepActualTxtBox"
        Me.StepActualTxtBox.ReadOnly = True
        Me.StepActualTxtBox.Size = New System.Drawing.Size(133, 19)
        Me.StepActualTxtBox.TabIndex = 54
        Me.StepActualTxtBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Actual:"
        '
        'StepStatusTxtBox
        '
        Me.StepStatusTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepStatusTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepStatusTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepStatusTxtBox.ForeColor = System.Drawing.Color.White
        Me.StepStatusTxtBox.Location = New System.Drawing.Point(82, 71)
        Me.StepStatusTxtBox.Name = "StepStatusTxtBox"
        Me.StepStatusTxtBox.ReadOnly = True
        Me.StepStatusTxtBox.Size = New System.Drawing.Size(132, 19)
        Me.StepStatusTxtBox.TabIndex = 56
        Me.StepStatusTxtBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 71)
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
        Me.WorkOrderDurationTxtBox.Size = New System.Drawing.Size(115, 19)
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
        Me.StopStepDateTxtBox.Size = New System.Drawing.Size(145, 19)
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
        Me.StartStepDateTxtBox.Size = New System.Drawing.Size(145, 19)
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
        'LotNumTxtBox
        '
        Me.LotNumTxtBox.BackColor = System.Drawing.Color.Black
        Me.LotNumTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LotNumTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LotNumTxtBox.ForeColor = System.Drawing.Color.White
        Me.LotNumTxtBox.Location = New System.Drawing.Point(71, 143)
        Me.LotNumTxtBox.Name = "LotNumTxtBox"
        Me.LotNumTxtBox.ReadOnly = True
        Me.LotNumTxtBox.Size = New System.Drawing.Size(143, 19)
        Me.LotNumTxtBox.TabIndex = 66
        Me.LotNumTxtBox.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 19)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Lot #:"
        '
        'StepItemDescTxtBox
        '
        Me.StepItemDescTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepItemDescTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepItemDescTxtBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepItemDescTxtBox.ForeColor = System.Drawing.Color.Yellow
        Me.StepItemDescTxtBox.Location = New System.Drawing.Point(3, 51)
        Me.StepItemDescTxtBox.Name = "StepItemDescTxtBox"
        Me.StepItemDescTxtBox.ReadOnly = True
        Me.StepItemDescTxtBox.Size = New System.Drawing.Size(218, 15)
        Me.StepItemDescTxtBox.TabIndex = 67
        Me.StepItemDescTxtBox.TabStop = False
        Me.StepItemDescTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StepItemTxtBox
        '
        Me.StepItemTxtBox.BackColor = System.Drawing.Color.Black
        Me.StepItemTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StepItemTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepItemTxtBox.ForeColor = System.Drawing.Color.White
        Me.StepItemTxtBox.Location = New System.Drawing.Point(3, 32)
        Me.StepItemTxtBox.Name = "StepItemTxtBox"
        Me.StepItemTxtBox.ReadOnly = True
        Me.StepItemTxtBox.Size = New System.Drawing.Size(216, 19)
        Me.StepItemTxtBox.TabIndex = 68
        Me.StepItemTxtBox.TabStop = False
        Me.StepItemTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClosedWorkOrderStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = false
        Me.Controls.Add(Me.StepItemTxtBox)
        Me.Controls.Add(Me.StepItemDescTxtBox)
        Me.Controls.Add(Me.LotNumTxtBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.StartStepDateTxtBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StopStepDateTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.WorkOrderDurationTxtBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StepStatusTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StepActualTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StepNumberTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Name = "ClosedWorkOrderStep"
        CType(Me.ReturnBtn,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HomeBtn,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ReturnBtn As System.Windows.Forms.PictureBox
    Friend WithEvents HomeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents StepNumberTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StepActualTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StepStatusTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WorkOrderDurationTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StopStepDateTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StartStepDateTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LotNumTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents StepItemDescTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents StepItemTxtBox As System.Windows.Forms.TextBox
End Class
