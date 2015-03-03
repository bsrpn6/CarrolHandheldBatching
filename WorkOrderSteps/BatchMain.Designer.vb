<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatchMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BatchMain))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SelectBtn = New System.Windows.Forms.Button()
        Me.WorkOrderNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.ItemTxtBox = New System.Windows.Forms.TextBox()
        Me.DescTxtBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StepNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StepName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnBtn = New System.Windows.Forms.PictureBox()
        Me.HomeBtn = New System.Windows.Forms.PictureBox()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.ActiveStepBtn = New System.Windows.Forms.Button()
        Me.ShowCompleteTglBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Work Order:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desc:"
        '
        'SelectBtn
        '
        Me.SelectBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Location = New System.Drawing.Point(35, 252)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(75, 25)
        Me.SelectBtn.TabIndex = 20
        Me.SelectBtn.Text = "Select"
        Me.SelectBtn.UseVisualStyleBackColor = False
        '
        'WorkOrderNumberTxtBox
        '
        Me.WorkOrderNumberTxtBox.BackColor = System.Drawing.Color.Black
        Me.WorkOrderNumberTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkOrderNumberTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderNumberTxtBox.ForeColor = System.Drawing.Color.White
        Me.WorkOrderNumberTxtBox.Location = New System.Drawing.Point(118, 6)
        Me.WorkOrderNumberTxtBox.Name = "WorkOrderNumberTxtBox"
        Me.WorkOrderNumberTxtBox.ReadOnly = True
        Me.WorkOrderNumberTxtBox.Size = New System.Drawing.Size(100, 19)
        Me.WorkOrderNumberTxtBox.TabIndex = 21
        Me.WorkOrderNumberTxtBox.TabStop = False
        '
        'ItemTxtBox
        '
        Me.ItemTxtBox.BackColor = System.Drawing.Color.Black
        Me.ItemTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTxtBox.ForeColor = System.Drawing.Color.White
        Me.ItemTxtBox.Location = New System.Drawing.Point(65, 28)
        Me.ItemTxtBox.Name = "ItemTxtBox"
        Me.ItemTxtBox.ReadOnly = True
        Me.ItemTxtBox.Size = New System.Drawing.Size(153, 19)
        Me.ItemTxtBox.TabIndex = 22
        Me.ItemTxtBox.TabStop = False
        '
        'DescTxtBox
        '
        Me.DescTxtBox.BackColor = System.Drawing.Color.Black
        Me.DescTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescTxtBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescTxtBox.ForeColor = System.Drawing.Color.White
        Me.DescTxtBox.Location = New System.Drawing.Point(72, 47)
        Me.DescTxtBox.Name = "DescTxtBox"
        Me.DescTxtBox.ReadOnly = True
        Me.DescTxtBox.Size = New System.Drawing.Size(146, 19)
        Me.DescTxtBox.TabIndex = 23
        Me.DescTxtBox.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StepNum, Me.StepName, Me.Complete, Me.Type})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 107)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(200, 112)
        Me.DataGridView1.TabIndex = 24
        Me.DataGridView1.TabStop = False
        '
        'StepNum
        '
        Me.StepNum.HeaderText = "Step"
        Me.StepNum.Name = "StepNum"
        Me.StepNum.ReadOnly = True
        Me.StepNum.Width = 40
        '
        'StepName
        '
        Me.StepName.HeaderText = "Name"
        Me.StepName.Name = "StepName"
        Me.StepName.ReadOnly = True
        Me.StepName.Width = 160
        '
        'Complete
        '
        Me.Complete.HeaderText = "Complete"
        Me.Complete.Name = "Complete"
        Me.Complete.ReadOnly = True
        Me.Complete.Visible = False
        '
        'Type
        '
        Me.Type.HeaderText = "Step Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Visible = False
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
        'HomeBtn
        '
        Me.HomeBtn.Image = CType(resources.GetObject("HomeBtn.Image"), System.Drawing.Image)
        Me.HomeBtn.Location = New System.Drawing.Point(4, 252)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(25, 25)
        Me.HomeBtn.TabIndex = 28
        Me.HomeBtn.TabStop = False
        '
        'RefreshBtn
        '
        Me.RefreshBtn.BackColor = System.Drawing.SystemColors.Control
        Me.RefreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.Location = New System.Drawing.Point(115, 252)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(75, 25)
        Me.RefreshBtn.TabIndex = 30
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = False
        '
        'ActiveStepBtn
        '
        Me.ActiveStepBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ActiveStepBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveStepBtn.Location = New System.Drawing.Point(35, 223)
        Me.ActiveStepBtn.Name = "ActiveStepBtn"
        Me.ActiveStepBtn.Size = New System.Drawing.Size(155, 25)
        Me.ActiveStepBtn.TabIndex = 31
        Me.ActiveStepBtn.Text = "Next Step"
        Me.ActiveStepBtn.UseVisualStyleBackColor = False
        '
        'ShowCompleteTglBtn
        '
        Me.ShowCompleteTglBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ShowCompleteTglBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowCompleteTglBtn.Location = New System.Drawing.Point(35, 76)
        Me.ShowCompleteTglBtn.Name = "ShowCompleteTglBtn"
        Me.ShowCompleteTglBtn.Size = New System.Drawing.Size(155, 25)
        Me.ShowCompleteTglBtn.TabIndex = 32
        Me.ShowCompleteTglBtn.Text = "Show Completed"
        Me.ShowCompleteTglBtn.UseVisualStyleBackColor = False
        '
        'BatchMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.ShowCompleteTglBtn)
        Me.Controls.Add(Me.ActiveStepBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DescTxtBox)
        Me.Controls.Add(Me.ItemTxtBox)
        Me.Controls.Add(Me.WorkOrderNumberTxtBox)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BatchMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SelectBtn As System.Windows.Forms.Button
    Friend WithEvents WorkOrderNumberTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DescTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ReturnBtn As System.Windows.Forms.PictureBox
    Friend WithEvents HomeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents ActiveStepBtn As System.Windows.Forms.Button
    Friend WithEvents ShowCompleteTglBtn As System.Windows.Forms.Button
    Friend WithEvents StepNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StepName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Complete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
