<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RAMDiskCopy2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RAMDiskCopy2))
        Me.FilesButton = New System.Windows.Forms.Button()
        Me.FileList = New System.Windows.Forms.ListView()
        Me.FileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OriginPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CopyBar = New System.Windows.Forms.ProgressBar()
        Me.CreateDisk = New System.Windows.Forms.Button()
        Me.RemoveDisk = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.AvailableRAM = New System.Windows.Forms.Label()
        Me.TotalSize = New System.Windows.Forms.Label()
        Me.RAMSize = New System.Windows.Forms.TextBox()
        Me.DriveLetter = New System.Windows.Forms.ComboBox()
        Me.FileSystem = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFiles = New System.Windows.Forms.OpenFileDialog()
        Me.AppLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.TotalBar = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SaveProfile = New System.Windows.Forms.Button()
        Me.LoadProfile = New System.Windows.Forms.Button()
        Me.SaveProfileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.LoadProfileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.AppLayout.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilesButton
        '
        Me.FilesButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilesButton.Location = New System.Drawing.Point(0, 0)
        Me.FilesButton.Name = "FilesButton"
        Me.FilesButton.Size = New System.Drawing.Size(627, 23)
        Me.FilesButton.TabIndex = 0
        Me.FilesButton.Text = "Choose Files"
        Me.FilesButton.UseVisualStyleBackColor = True
        '
        'FileList
        '
        Me.FileList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileName, Me.FileSize, Me.OriginPath})
        Me.FileList.Dock = System.Windows.Forms.DockStyle.Top
        Me.FileList.Location = New System.Drawing.Point(0, 46)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(627, 247)
        Me.FileList.TabIndex = 1
        Me.FileList.UseCompatibleStateImageBehavior = False
        Me.FileList.View = System.Windows.Forms.View.Details
        '
        'FileName
        '
        Me.FileName.Text = "File Name"
        Me.FileName.Width = 160
        '
        'FileSize
        '
        Me.FileSize.Text = "File Size (In MB)"
        Me.FileSize.Width = 95
        '
        'OriginPath
        '
        Me.OriginPath.Text = "Original Path"
        Me.OriginPath.Width = 280
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Available RAM (In MB):"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Files Size (In MB):"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RAMDisk Size (In MB):"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "RAMDisk Drive Letter:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "RAMDisk File System:"
        Me.Label5.Visible = False
        '
        'CopyBar
        '
        Me.CopyBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CopyBar.Location = New System.Drawing.Point(0, 537)
        Me.CopyBar.Maximum = 101
        Me.CopyBar.Name = "CopyBar"
        Me.CopyBar.Size = New System.Drawing.Size(627, 10)
        Me.CopyBar.TabIndex = 7
        '
        'CreateDisk
        '
        Me.CreateDisk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateDisk.Location = New System.Drawing.Point(3, 3)
        Me.CreateDisk.Name = "CreateDisk"
        Me.CreateDisk.Size = New System.Drawing.Size(307, 23)
        Me.CreateDisk.TabIndex = 8
        Me.CreateDisk.Text = "Create RAMDisk"
        Me.CreateDisk.UseVisualStyleBackColor = True
        '
        'RemoveDisk
        '
        Me.RemoveDisk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemoveDisk.Enabled = False
        Me.RemoveDisk.Location = New System.Drawing.Point(316, 3)
        Me.RemoveDisk.Name = "RemoveDisk"
        Me.RemoveDisk.Size = New System.Drawing.Size(308, 23)
        Me.RemoveDisk.TabIndex = 9
        Me.RemoveDisk.Text = "Remove RAMDisk"
        Me.RemoveDisk.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AboutButton.Location = New System.Drawing.Point(0, 605)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(627, 23)
        Me.AboutButton.TabIndex = 10
        Me.AboutButton.Text = "About..."
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'AvailableRAM
        '
        Me.AvailableRAM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AvailableRAM.Location = New System.Drawing.Point(354, 15)
        Me.AvailableRAM.Name = "AvailableRAM"
        Me.AvailableRAM.Size = New System.Drawing.Size(124, 13)
        Me.AvailableRAM.TabIndex = 11
        Me.AvailableRAM.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TotalSize
        '
        Me.TotalSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TotalSize.Location = New System.Drawing.Point(354, 59)
        Me.TotalSize.Name = "TotalSize"
        Me.TotalSize.Size = New System.Drawing.Size(124, 13)
        Me.TotalSize.TabIndex = 12
        Me.TotalSize.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RAMSize
        '
        Me.RAMSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RAMSize.Location = New System.Drawing.Point(366, 100)
        Me.RAMSize.Name = "RAMSize"
        Me.RAMSize.Size = New System.Drawing.Size(100, 20)
        Me.RAMSize.TabIndex = 13
        Me.RAMSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DriveLetter
        '
        Me.DriveLetter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DriveLetter.FormattingEnabled = True
        Me.DriveLetter.Location = New System.Drawing.Point(366, 143)
        Me.DriveLetter.Name = "DriveLetter"
        Me.DriveLetter.Size = New System.Drawing.Size(100, 21)
        Me.DriveLetter.TabIndex = 14
        '
        'FileSystem
        '
        Me.FileSystem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FileSystem.FormattingEnabled = True
        Me.FileSystem.Location = New System.Drawing.Point(366, 188)
        Me.FileSystem.Name = "FileSystem"
        Me.FileSystem.Size = New System.Drawing.Size(100, 21)
        Me.FileSystem.TabIndex = 15
        Me.FileSystem.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'OpenFiles
        '
        Me.OpenFiles.Multiselect = True
        Me.OpenFiles.Title = "Select files to copy to RAMDisk"
        '
        'AppLayout
        '
        Me.AppLayout.AutoSize = True
        Me.AppLayout.ColumnCount = 4
        Me.AppLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.AppLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.AppLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.AppLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.AppLayout.Controls.Add(Me.FileSystem, 2, 4)
        Me.AppLayout.Controls.Add(Me.DriveLetter, 2, 3)
        Me.AppLayout.Controls.Add(Me.RAMSize, 2, 2)
        Me.AppLayout.Controls.Add(Me.TotalSize, 2, 1)
        Me.AppLayout.Controls.Add(Me.AvailableRAM, 2, 0)
        Me.AppLayout.Controls.Add(Me.Label1, 1, 0)
        Me.AppLayout.Controls.Add(Me.Label2, 1, 1)
        Me.AppLayout.Controls.Add(Me.Label3, 1, 2)
        Me.AppLayout.Controls.Add(Me.Label4, 1, 3)
        Me.AppLayout.Controls.Add(Me.Label5, 1, 4)
        Me.AppLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.AppLayout.Location = New System.Drawing.Point(0, 293)
        Me.AppLayout.Name = "AppLayout"
        Me.AppLayout.RowCount = 5
        Me.AppLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AppLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AppLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AppLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AppLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AppLayout.Size = New System.Drawing.Size(627, 221)
        Me.AppLayout.TabIndex = 18
        '
        'RemoveButton
        '
        Me.RemoveButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.RemoveButton.Location = New System.Drawing.Point(0, 23)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(627, 23)
        Me.RemoveButton.TabIndex = 19
        Me.RemoveButton.Text = "Remove Selected Files"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'TotalBar
        '
        Me.TotalBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TotalBar.Location = New System.Drawing.Point(0, 514)
        Me.TotalBar.Name = "TotalBar"
        Me.TotalBar.Size = New System.Drawing.Size(627, 23)
        Me.TotalBar.TabIndex = 20
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RemoveDisk, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CreateDisk, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SaveProfile, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LoadProfile, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 547)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(627, 58)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'SaveProfile
        '
        Me.SaveProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveProfile.Location = New System.Drawing.Point(3, 32)
        Me.SaveProfile.Name = "SaveProfile"
        Me.SaveProfile.Size = New System.Drawing.Size(307, 23)
        Me.SaveProfile.TabIndex = 10
        Me.SaveProfile.Text = "Save Profile"
        Me.SaveProfile.UseVisualStyleBackColor = True
        '
        'LoadProfile
        '
        Me.LoadProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoadProfile.Location = New System.Drawing.Point(316, 32)
        Me.LoadProfile.Name = "LoadProfile"
        Me.LoadProfile.Size = New System.Drawing.Size(308, 23)
        Me.LoadProfile.TabIndex = 11
        Me.LoadProfile.Text = "Load Profile"
        Me.LoadProfile.UseVisualStyleBackColor = True
        '
        'LoadProfileDialog
        '
        Me.LoadProfileDialog.FileName = "OpenFileDialog1"
        '
        'RAMDiskCopy2
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 628)
        Me.Controls.Add(Me.AppLayout)
        Me.Controls.Add(Me.TotalBar)
        Me.Controls.Add(Me.CopyBar)
        Me.Controls.Add(Me.FileList)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.FilesButton)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AboutButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RAMDiskCopy2"
        Me.Text = "RAMDiskCopy2"
        Me.AppLayout.ResumeLayout(False)
        Me.AppLayout.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FilesButton As Button
    Friend WithEvents FileList As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CopyBar As ProgressBar
    Friend WithEvents CreateDisk As Button
    Friend WithEvents RemoveDisk As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents AvailableRAM As Label
    Friend WithEvents TotalSize As Label
    Friend WithEvents RAMSize As TextBox
    Friend WithEvents DriveLetter As ComboBox
    Friend WithEvents FileSystem As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FileName As ColumnHeader
    Friend WithEvents FileSize As ColumnHeader
    Friend WithEvents OpenFiles As OpenFileDialog
    Friend WithEvents OriginPath As ColumnHeader
    Friend WithEvents AppLayout As TableLayoutPanel
    Friend WithEvents RemoveButton As Button
    Friend WithEvents TotalBar As ProgressBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SaveProfile As Button
    Friend WithEvents LoadProfile As Button
    Friend WithEvents SaveProfileDialog As SaveFileDialog
    Friend WithEvents LoadProfileDialog As OpenFileDialog
End Class
