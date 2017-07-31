<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SupportLink = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.YouTube = New System.Windows.Forms.LinkLabel()
        Me.GitHub = New System.Windows.Forms.LinkLabel()
        Me.Reddit = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ImDisk = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CloseButton.Location = New System.Drawing.Point(280, 68)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(60, 23)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "OK"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SupportLink
        '
        Me.SupportLink.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SupportLink.AutoSize = True
        Me.SupportLink.Location = New System.Drawing.Point(313, 14)
        Me.SupportLink.Name = "SupportLink"
        Me.SupportLink.Size = New System.Drawing.Size(294, 26)
        Me.SupportLink.TabIndex = 1
        Me.SupportLink.TabStop = True
        Me.SupportLink.Text = "Watch an ad to support me! (I only get 1/10th to 1/20th of a penny per click, so " &
    "get click happy!)"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Want to say thanks?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(614, 208)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pay me a visit!"
        '
        'YouTube
        '
        Me.YouTube.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.YouTube.AutoSize = True
        Me.YouTube.Location = New System.Drawing.Point(70, 25)
        Me.YouTube.Name = "YouTube"
        Me.YouTube.Size = New System.Drawing.Size(166, 13)
        Me.YouTube.TabIndex = 5
        Me.YouTube.TabStop = True
        Me.YouTube.Text = "My not-so-busy YouTube channel"
        '
        'GitHub
        '
        Me.GitHub.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GitHub.AutoSize = True
        Me.GitHub.Location = New System.Drawing.Point(91, 47)
        Me.GitHub.Name = "GitHub"
        Me.GitHub.Size = New System.Drawing.Size(124, 13)
        Me.GitHub.TabIndex = 6
        Me.GitHub.TabStop = True
        Me.GitHub.Text = "My growing GitHub page"
        '
        'Reddit
        '
        Me.Reddit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Reddit.AutoSize = True
        Me.Reddit.Location = New System.Drawing.Point(390, 25)
        Me.Reddit.Name = "Reddit"
        Me.Reddit.Size = New System.Drawing.Size(140, 13)
        Me.Reddit.TabIndex = 7
        Me.Reddit.TabStop = True
        Me.Reddit.Text = "My rarely used Reddit profile"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "RAMDiskCopy2 v1.0.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "This program is basically just a wrapper for the ImDisk Toolkit."
        '
        'ImDisk
        '
        Me.ImDisk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImDisk.AutoSize = True
        Me.ImDisk.Location = New System.Drawing.Point(346, 0)
        Me.ImDisk.Name = "ImDisk"
        Me.ImDisk.Size = New System.Drawing.Size(229, 13)
        Me.ImDisk.TabIndex = 10
        Me.ImDisk.TabStop = True
        Me.ImDisk.Text = "https://sourceforge.net/projects/imdisk-toolkit/"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.YouTube, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GitHub, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Reddit, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 250)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(614, 65)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CloseButton, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 318)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(620, 100)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.SupportLink, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(614, 54)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(620, 318)
        Me.TableLayoutPanel4.TabIndex = 14
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ImDisk, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 231)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(614, 13)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 418)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About"
        Me.Text = "About"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents SupportLink As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents YouTube As LinkLabel
    Friend WithEvents GitHub As LinkLabel
    Friend WithEvents Reddit As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ImDisk As LinkLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
