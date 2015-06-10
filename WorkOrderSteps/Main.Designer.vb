<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SelectOrderBtn = New System.Windows.Forms.Button()
        Me.SelectAssetBtn = New System.Windows.Forms.Button()
        Me.CloseApplication = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VersionLbl = New System.Windows.Forms.Label()
        CType(Me.CloseApplication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectOrderBtn
        '
        Me.SelectOrderBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SelectOrderBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectOrderBtn.Location = New System.Drawing.Point(12, 105)
        Me.SelectOrderBtn.Name = "SelectOrderBtn"
        Me.SelectOrderBtn.Size = New System.Drawing.Size(200, 32)
        Me.SelectOrderBtn.TabIndex = 5
        Me.SelectOrderBtn.Text = "Select Order"
        Me.SelectOrderBtn.UseVisualStyleBackColor = False
        '
        'SelectAssetBtn
        '
        Me.SelectAssetBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SelectAssetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectAssetBtn.Location = New System.Drawing.Point(12, 143)
        Me.SelectAssetBtn.Name = "SelectAssetBtn"
        Me.SelectAssetBtn.Size = New System.Drawing.Size(200, 32)
        Me.SelectAssetBtn.TabIndex = 6
        Me.SelectAssetBtn.Text = "Select Asset"
        Me.SelectAssetBtn.UseVisualStyleBackColor = False
        '
        'CloseApplication
        '
        Me.CloseApplication.Image = CType(resources.GetObject("CloseApplication.Image"), System.Drawing.Image)
        Me.CloseApplication.Location = New System.Drawing.Point(194, 252)
        Me.CloseApplication.Name = "CloseApplication"
        Me.CloseApplication.Size = New System.Drawing.Size(23, 24)
        Me.CloseApplication.TabIndex = 19
        Me.CloseApplication.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 50)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Batching System"
        '
        'VersionLbl
        '
        Me.VersionLbl.AutoSize = True
        Me.VersionLbl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLbl.ForeColor = System.Drawing.Color.White
        Me.VersionLbl.Location = New System.Drawing.Point(8, 257)
        Me.VersionLbl.Name = "VersionLbl"
        Me.VersionLbl.Size = New System.Drawing.Size(0, 14)
        Me.VersionLbl.TabIndex = 22
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.VersionLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CloseApplication)
        Me.Controls.Add(Me.SelectAssetBtn)
        Me.Controls.Add(Me.SelectOrderBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        CType(Me.CloseApplication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelectOrderBtn As System.Windows.Forms.Button
    Friend WithEvents SelectAssetBtn As System.Windows.Forms.Button
    Friend WithEvents CloseApplication As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VersionLbl As Label
End Class
