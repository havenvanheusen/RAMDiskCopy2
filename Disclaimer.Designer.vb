<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disclaimer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Disclaimer))
        Me.DisclaimerText = New System.Windows.Forms.Label()
        Me.DontShow = New System.Windows.Forms.CheckBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisclaimerText
        '
        Me.DisclaimerText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisclaimerText.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisclaimerText.Location = New System.Drawing.Point(3, 0)
        Me.DisclaimerText.Name = "DisclaimerText"
        Me.DisclaimerText.Size = New System.Drawing.Size(634, 456)
        Me.DisclaimerText.TabIndex = 0
        Me.DisclaimerText.Text = resources.GetString("DisclaimerText.Text")
        '
        'DontShow
        '
        Me.DontShow.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DontShow.AutoSize = True
        Me.DontShow.Location = New System.Drawing.Point(3, 8)
        Me.DontShow.Name = "DontShow"
        Me.DontShow.Size = New System.Drawing.Size(193, 17)
        Me.DontShow.TabIndex = 1
        Me.DontShow.Text = "Don't show the disclaimer at startup"
        Me.DontShow.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CloseButton.Location = New System.Drawing.Point(562, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(69, 23)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "I Get It"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.QuitButton.Location = New System.Drawing.Point(414, 5)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(139, 23)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "I'm not sure about this..."
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DontShow, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CloseButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.QuitButton, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 459)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(634, 34)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DisclaimerText, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(640, 496)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'Disclaimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 496)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Disclaimer"
        Me.Text = "Disclaimer"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisclaimerText As Label
    Friend WithEvents DontShow As CheckBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
