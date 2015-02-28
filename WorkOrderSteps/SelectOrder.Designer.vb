<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectOrder))
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WorkOrderNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.SelectBtn = New System.Windows.Forms.Button()
        Me.ReturnBtn = New System.Windows.Forms.PictureBox()
        Me.HomeBtn = New System.Windows.Forms.PictureBox()
        Me.WorkOrderTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.Color.White
        Me.TitleLbl.Location = New System.Drawing.Point(51, 9)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(126, 22)
        Me.TitleLbl.TabIndex = 3
        Me.TitleLbl.Text = "Select Order"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorkOrderNumber})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 87)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(200, 157)
        Me.DataGridView1.TabIndex = 4
        '
        'WorkOrderNumber
        '
        Me.WorkOrderNumber.FillWeight = 120.0!
        Me.WorkOrderNumber.HeaderText = "Work Order #:"
        Me.WorkOrderNumber.Name = "WorkOrderNumber"
        Me.WorkOrderNumber.ReadOnly = True
        Me.WorkOrderNumber.Width = 200
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.Location = New System.Drawing.Point(118, 252)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(75, 25)
        Me.RefreshBtn.TabIndex = 23
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'SelectBtn
        '
        Me.SelectBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBtn.Location = New System.Drawing.Point(38, 252)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(75, 25)
        Me.SelectBtn.TabIndex = 22
        Me.SelectBtn.Text = "Select"
        Me.SelectBtn.UseVisualStyleBackColor = True
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
        'WorkOrderTxtBox
        '
        Me.WorkOrderTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.WorkOrderTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderTxtBox.Location = New System.Drawing.Point(69, 43)
        Me.WorkOrderTxtBox.Name = "WorkOrderTxtBox"
        Me.WorkOrderTxtBox.Size = New System.Drawing.Size(130, 31)
        Me.WorkOrderTxtBox.TabIndex = 31
        Me.WorkOrderTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "WO#:"
        '
        'SelectOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.WorkOrderTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TitleLbl)
        Me.Name = "SelectOrder"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLbl As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents SelectBtn As System.Windows.Forms.Button
    Friend WithEvents WorkOrderNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnBtn As System.Windows.Forms.PictureBox
    Friend WithEvents HomeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents WorkOrderTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
