<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SelectOrderBtn = New System.Windows.Forms.Button()
        Me.SelectAssetBtn = New System.Windows.Forms.Button()
        Me.CloseApplication = New System.Windows.Forms.PictureBox()
        Me.TitlePix = New System.Windows.Forms.PictureBox()
        CType(Me.CloseApplication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectOrderBtn
        '
        Me.SelectOrderBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectOrderBtn.Location = New System.Drawing.Point(12, 44)
        Me.SelectOrderBtn.Name = "SelectOrderBtn"
        Me.SelectOrderBtn.Size = New System.Drawing.Size(200, 32)
        Me.SelectOrderBtn.TabIndex = 5
        Me.SelectOrderBtn.Text = "Select Order"
        Me.SelectOrderBtn.UseVisualStyleBackColor = True
        '
        'SelectAssetBtn
        '
        Me.SelectAssetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectAssetBtn.Location = New System.Drawing.Point(12, 82)
        Me.SelectAssetBtn.Name = "SelectAssetBtn"
        Me.SelectAssetBtn.Size = New System.Drawing.Size(200, 32)
        Me.SelectAssetBtn.TabIndex = 6
        Me.SelectAssetBtn.Text = "Select Asset"
        Me.SelectAssetBtn.UseVisualStyleBackColor = True
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
        'TitlePix
        '
        Me.TitlePix.Image = CType(resources.GetObject("TitlePix.Image"), System.Drawing.Image)
        Me.TitlePix.Location = New System.Drawing.Point(17, 12)
        Me.TitlePix.Name = "TitlePix"
        Me.TitlePix.Size = New System.Drawing.Size(196, 26)
        Me.TitlePix.TabIndex = 20
        Me.TitlePix.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(224, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.TitlePix)
        Me.Controls.Add(Me.CloseApplication)
        Me.Controls.Add(Me.SelectAssetBtn)
        Me.Controls.Add(Me.SelectOrderBtn)
        Me.Name = "Main"
        CType(Me.CloseApplication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SelectOrderBtn As System.Windows.Forms.Button
    Friend WithEvents SelectAssetBtn As System.Windows.Forms.Button
    Friend WithEvents CloseApplication As System.Windows.Forms.PictureBox
    Friend WithEvents TitlePix As System.Windows.Forms.PictureBox
End Class
