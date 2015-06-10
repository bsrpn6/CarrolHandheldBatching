<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StagingMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StagingMain))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReturnBtn = New System.Windows.Forms.PictureBox()
        Me.HomeBtn = New System.Windows.Forms.PictureBox()
        Me.QtyTxtBox = New System.Windows.Forms.TextBox()
        Me.LotcodeTxtBox = New System.Windows.Forms.TextBox()
        Me.BOMItemTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShowCompleteTglBtn = New System.Windows.Forms.Button()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.StepNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StepNum})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 159)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(200, 88)
        Me.DataGridView1.TabIndex = 24
        Me.DataGridView1.TabStop = False
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
        'QtyTxtBox
        '
        Me.QtyTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.QtyTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyTxtBox.Location = New System.Drawing.Point(74, 86)
        Me.QtyTxtBox.Name = "QtyTxtBox"
        Me.QtyTxtBox.Size = New System.Drawing.Size(130, 31)
        Me.QtyTxtBox.TabIndex = 36
        Me.QtyTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LotcodeTxtBox
        '
        Me.LotcodeTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LotcodeTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LotcodeTxtBox.Location = New System.Drawing.Point(74, 49)
        Me.LotcodeTxtBox.Name = "LotcodeTxtBox"
        Me.LotcodeTxtBox.Size = New System.Drawing.Size(130, 31)
        Me.LotcodeTxtBox.TabIndex = 35
        Me.LotcodeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BOMItemTxtBox
        '
        Me.BOMItemTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BOMItemTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOMItemTxtBox.Location = New System.Drawing.Point(74, 12)
        Me.BOMItemTxtBox.Name = "BOMItemTxtBox"
        Me.BOMItemTxtBox.Size = New System.Drawing.Size(130, 31)
        Me.BOMItemTxtBox.TabIndex = 34
        Me.BOMItemTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "QTY:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "LOT:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "MTL:"
        '
        'ShowCompleteTglBtn
        '
        Me.ShowCompleteTglBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ShowCompleteTglBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowCompleteTglBtn.Location = New System.Drawing.Point(35, 252)
        Me.ShowCompleteTglBtn.Name = "ShowCompleteTglBtn"
        Me.ShowCompleteTglBtn.Size = New System.Drawing.Size(155, 25)
        Me.ShowCompleteTglBtn.TabIndex = 37
        Me.ShowCompleteTglBtn.Text = "Show Completed"
        Me.ShowCompleteTglBtn.UseVisualStyleBackColor = False
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.Location = New System.Drawing.Point(75, 128)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 25)
        Me.SubmitBtn.TabIndex = 38
        Me.SubmitBtn.Text = "Save"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'StepNum
        '
        Me.StepNum.HeaderText = "Item"
        Me.StepNum.Name = "StepNum"
        Me.StepNum.ReadOnly = True
        Me.StepNum.Width = 200
        '
        'StagingMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.ShowCompleteTglBtn)
        Me.Controls.Add(Me.QtyTxtBox)
        Me.Controls.Add(Me.LotcodeTxtBox)
        Me.Controls.Add(Me.BOMItemTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "StagingMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ReturnBtn As System.Windows.Forms.PictureBox
    Friend WithEvents HomeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents QtyTxtBox As TextBox
    Friend WithEvents LotcodeTxtBox As TextBox
    Friend WithEvents BOMItemTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ShowCompleteTglBtn As Button
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents StepNum As DataGridViewTextBoxColumn
End Class
