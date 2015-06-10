<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkOrderStep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkOrderStep))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ViewInstructionsBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WorkOrderItemTxtBox = New System.Windows.Forms.TextBox()
        Me.WorkOrderItemDescTxtBox = New System.Windows.Forms.TextBox()
        Me.WorkOrderStepTargetQtyTxtBox = New System.Windows.Forms.TextBox()
        Me.WorkOrderStepItemTxtBox = New System.Windows.Forms.TextBox()
        Me.LotcodeTxtBox = New System.Windows.Forms.TextBox()
        Me.QtyTxtBox = New System.Windows.Forms.TextBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.PictureBox()
        Me.ReturnBtn = New System.Windows.Forms.PictureBox()
        Me.WorkOrderNumberTxtBox = New System.Windows.Forms.TextBox()
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Step Num:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Material:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Target Qty:"
        '
        'ViewInstructionsBtn
        '
        Me.ViewInstructionsBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ViewInstructionsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewInstructionsBtn.Location = New System.Drawing.Point(12, 102)
        Me.ViewInstructionsBtn.Name = "ViewInstructionsBtn"
        Me.ViewInstructionsBtn.Size = New System.Drawing.Size(200, 32)
        Me.ViewInstructionsBtn.TabIndex = 4
        Me.ViewInstructionsBtn.Text = "View Instructions"
        Me.ViewInstructionsBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "MTL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "LOT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "QTY:"
        '
        'WorkOrderItemTxtBox
        '
        Me.WorkOrderItemTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderItemTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderItemTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderItemTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderItemTxtBox.Location = New System.Drawing.Point(92, 31)
        Me.WorkOrderItemTxtBox.Name = "WorkOrderItemTxtBox"
        Me.WorkOrderItemTxtBox.ReadOnly = True
        Me.WorkOrderItemTxtBox.Size = New System.Drawing.Size(117, 19)
        Me.WorkOrderItemTxtBox.TabIndex = 11
        Me.WorkOrderItemTxtBox.TabStop = False
        '
        'WorkOrderItemDescTxtBox
        '
        Me.WorkOrderItemDescTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderItemDescTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderItemDescTxtBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderItemDescTxtBox.ForeColor = System.Drawing.Color.Yellow
        Me.WorkOrderItemDescTxtBox.Location = New System.Drawing.Point(3, 54)
        Me.WorkOrderItemDescTxtBox.Name = "WorkOrderItemDescTxtBox"
        Me.WorkOrderItemDescTxtBox.ReadOnly = True
        Me.WorkOrderItemDescTxtBox.Size = New System.Drawing.Size(218, 15)
        Me.WorkOrderItemDescTxtBox.TabIndex = 12
        Me.WorkOrderItemDescTxtBox.TabStop = False
        Me.WorkOrderItemDescTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WorkOrderStepTargetQtyTxtBox
        '
        Me.WorkOrderStepTargetQtyTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderStepTargetQtyTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderStepTargetQtyTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderStepTargetQtyTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderStepTargetQtyTxtBox.Location = New System.Drawing.Point(111, 77)
        Me.WorkOrderStepTargetQtyTxtBox.Name = "WorkOrderStepTargetQtyTxtBox"
        Me.WorkOrderStepTargetQtyTxtBox.ReadOnly = True
        Me.WorkOrderStepTargetQtyTxtBox.Size = New System.Drawing.Size(98, 19)
        Me.WorkOrderStepTargetQtyTxtBox.TabIndex = 13
        Me.WorkOrderStepTargetQtyTxtBox.TabStop = False
        '
        'WorkOrderStepItemTxtBox
        '
        Me.WorkOrderStepItemTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.WorkOrderStepItemTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderStepItemTxtBox.Location = New System.Drawing.Point(74, 139)
        Me.WorkOrderStepItemTxtBox.Name = "WorkOrderStepItemTxtBox"
        Me.WorkOrderStepItemTxtBox.Size = New System.Drawing.Size(130, 31)
        Me.WorkOrderStepItemTxtBox.TabIndex = 14
        Me.WorkOrderStepItemTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LotcodeTxtBox
        '
        Me.LotcodeTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LotcodeTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LotcodeTxtBox.Location = New System.Drawing.Point(74, 176)
        Me.LotcodeTxtBox.Name = "LotcodeTxtBox"
        Me.LotcodeTxtBox.Size = New System.Drawing.Size(130, 31)
        Me.LotcodeTxtBox.TabIndex = 15
        Me.LotcodeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QtyTxtBox
        '
        Me.QtyTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.QtyTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyTxtBox.Location = New System.Drawing.Point(74, 213)
        Me.QtyTxtBox.Name = "QtyTxtBox"
        Me.QtyTxtBox.Size = New System.Drawing.Size(130, 31)
        Me.QtyTxtBox.TabIndex = 16
        Me.QtyTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(115, 252)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 25)
        Me.ClearBtn.TabIndex = 25
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.Location = New System.Drawing.Point(35, 252)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 25)
        Me.SubmitBtn.TabIndex = 24
        Me.SubmitBtn.Text = "Start"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'HomeBtn
        '
        Me.HomeBtn.Image = CType(resources.GetObject("HomeBtn.Image"), System.Drawing.Image)
        Me.HomeBtn.Location = New System.Drawing.Point(4, 252)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(25, 25)
        Me.HomeBtn.TabIndex = 26
        Me.HomeBtn.TabStop = False
        '
        'ReturnBtn
        '
        Me.ReturnBtn.Image = CType(resources.GetObject("ReturnBtn.Image"), System.Drawing.Image)
        Me.ReturnBtn.Location = New System.Drawing.Point(194, 252)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(25, 25)
        Me.ReturnBtn.TabIndex = 27
        Me.ReturnBtn.TabStop = False
        '
        'WorkOrderNumberTxtBox
        '
        Me.WorkOrderNumberTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderNumberTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderNumberTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderNumberTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderNumberTxtBox.Location = New System.Drawing.Point(108, 9)
        Me.WorkOrderNumberTxtBox.Name = "WorkOrderNumberTxtBox"
        Me.WorkOrderNumberTxtBox.ReadOnly = True
        Me.WorkOrderNumberTxtBox.Size = New System.Drawing.Size(101, 19)
        Me.WorkOrderNumberTxtBox.TabIndex = 10
        Me.WorkOrderNumberTxtBox.TabStop = False
        '
        'WorkOrderStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.QtyTxtBox)
        Me.Controls.Add(Me.LotcodeTxtBox)
        Me.Controls.Add(Me.WorkOrderStepItemTxtBox)
        Me.Controls.Add(Me.WorkOrderStepTargetQtyTxtBox)
        Me.Controls.Add(Me.WorkOrderItemDescTxtBox)
        Me.Controls.Add(Me.WorkOrderItemTxtBox)
        Me.Controls.Add(Me.WorkOrderNumberTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ViewInstructionsBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WorkOrderStep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ViewInstructionsBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WorkOrderItemTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WorkOrderItemDescTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WorkOrderStepTargetQtyTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WorkOrderStepItemTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents LotcodeTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents HomeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents ReturnBtn As System.Windows.Forms.PictureBox
    Friend WithEvents WorkOrderNumberTxtBox As System.Windows.Forms.TextBox

End Class
