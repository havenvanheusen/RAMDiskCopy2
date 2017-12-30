Public Class RAMDiskCopy2

    'To do list:

    'Bugs:
    'Fix copy progress bar?
    'Optimize remove files (and add files?)

    'Features:
    'Option to copy files from the RAMDisk to the original file location
    'Status text label?

    'Basics:
    'Get a better icon

    Dim ThereIsDisk As Boolean = False
    Dim ImDiskProcess As New Process
    Dim FormatProcess As New Process
    Dim JunctionProcess As New Process
    Dim RMDIRProcess As New Process
    Dim OriginFile As String
    Dim DestinationFolder As String
    Dim ParseFolderPath As String

    Private Sub RAMDiskCopy2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If My.Application.CommandLineArgs.Count > 1 Then
        'If RDC2 profile was opened, automatically parse files
        'End If
        If Not IO.File.Exists("C:\Windows\System32\imdisk.cpl") Then
            MsgBox("This program requires the ImDisk Toolkit to function properly. Please download at https://sourceforge.net/projects/imdisk-toolkit/", MsgBoxStyle.OkOnly, "")
        End If
        If My.Settings.DisclaimerSetting = False Then
            Disclaimer.Show()

        End If
        Timer1.Start()
        DriveLetter.Items.AddRange(GetAvailableDriveLetters.ToArray)
        DriveLetter.SelectedIndex = (GetAvailableDriveLetters.Count - 1)
        FileSystem.Items.Add("FAT32")
        FileSystem.Items.Add("NTFS")
        FileSystem.SelectedIndex = 0
    End Sub

    Public Function GetAvailableDriveLetters() As List(Of String)
        Dim letters As New List(Of String)()
        For i As Integer = Convert.ToInt16("A"c) To Convert.ToInt16("Z"c) - 1
            letters.Add(New String(New Char() {ChrW(i)}))
        Next
        For Each drive As String In IO.Directory.GetLogicalDrives()
            letters.Remove(drive.Substring(0, 1))
        Next
        Return letters
    End Function

    Private Sub GetRAMUsage()
        Dim info = New Devices.ComputerInfo()
        AvailableRAM.Text = Math.Round(info.AvailablePhysicalMemory / 1024 / 1024)
    End Sub

    Public Sub CheckSize()
        TotalSize.Text = "0"
        For Index As Integer = 0 To FileList.Items.Count - 1
            Dim X As Decimal = Convert.ToDecimal(FileList.Items.Item(Index).SubItems(1).Text)
            TotalSize.Text = (Convert.ToDecimal(TotalSize.Text) + X).ToString
        Next
    End Sub

    Public Function CanWrite() As Boolean
        Try
            IO.File.Create(DriveLetter.Text & ":\Test.touch").Dispose()
            IO.File.Delete(DriveLetter.Text & ":\Test.touch")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub CopyFile(file As String, folder As String, destinationF As String)
        If Not IO.Directory.Exists(folder) Then
            IO.Directory.CreateDirectory(folder)
        End If
        Dim streamRead As New IO.FileStream(file, IO.FileMode.Open)
        Dim streamWrite As New IO.FileStream(folder & destinationF, IO.FileMode.Create)
        Dim FileLength As Long = streamRead.Length - 1
        Dim byteBuffer(1048576) As Byte
        Dim BytesRead As Integer
        While streamRead.Position < FileLength
            BytesRead = (streamRead.Read(byteBuffer, 0, 1048576))
            streamWrite.Write(byteBuffer, 0, BytesRead)
            'Still working out why this isn't working right
            'CopyBar.Value = CInt(streamRead.Position / FileLength * 100)
            Application.DoEvents()
        End While
        streamWrite.Flush()
        streamWrite.Close()
        streamRead.Close()
    End Sub

    Private Sub CreateJunction(linkName As String, targetPath As String)
        JunctionProcess.StartInfo.FileName = "cmd.exe"
        JunctionProcess.StartInfo.Arguments = " /c mklink """ & linkName & """ """ & targetPath & """"
        JunctionProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        JunctionProcess.Start()
        JunctionProcess.WaitForExit()
    End Sub

    Private Sub RemoveJunction(linkName As String)
        JunctionProcess.StartInfo.FileName = "cmd.exe"
        JunctionProcess.StartInfo.Arguments = " /c del """ & linkName & """"
        JunctionProcess.StartInfo.UseShellExecute = True
        JunctionProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        JunctionProcess.Start()
        JunctionProcess.WaitForExit()
    End Sub

    Private Sub RAMSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RAMSize.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetRAMUsage()
    End Sub

    Private Sub FilesButton_Click(sender As Object, e As EventArgs) Handles FilesButton.Click
        If TotalSize.Text = "" Then
            TotalSize.Text = "0"
        End If
        If OpenFiles.ShowDialog() = DialogResult.OK Then
            For Each file In OpenFiles.FileNames
                Dim Item As New ListViewItem()
                Item.Text = IO.Path.GetFileName(file)
                Item.SubItems.Add(Math.Round((My.Computer.FileSystem.GetFileInfo(file).Length / 1048576), 3))
                Item.SubItems.Add(IO.Path.GetDirectoryName(file))
                FileList.Items.Add(Item)
            Next
            CheckSize()
        End If
    End Sub

    Private Sub FolderButton_Click(sender As Object, e As EventArgs) Handles FolderButton.Click
        If FindFolder.ShowDialog = DialogResult.OK Then
            ParseFolderPath = FindFolder.SelectedPath
            ParseFolders()

        End If

    End Sub

    Private Sub ParseFolders()
        Dim files =
            From d In IO.Directory.EnumerateDirectories(ParseFolderPath, "*", IO.SearchOption.AllDirectories)
            From f In IO.Directory.EnumerateFiles(d, "*")
            Select f
        Dim ParseMe As String() = files.ToArray
        For Each File As String In ParseMe
            Dim Item As New ListViewItem
            Item.Text = IO.Path.GetFileName(File)
            Item.SubItems.Add(Math.Round((My.Computer.FileSystem.GetFileInfo(File).Length / 1048576), 3))
            Item.SubItems.Add(IO.Path.GetDirectoryName(File))
            FileList.Items.Add(Item)
        Next
        Dim FolderItself As New IO.DirectoryInfo(ParseFolderPath)
        'Still working out the kinks in this one
        For Each File In FolderItself.GetFiles
            Dim Item As New ListViewItem
            Item.Text = IO.Path.GetFileName(File.ToString)
            Item.SubItems.Add(Math.Round((My.Computer.FileSystem.GetFileInfo(File.FullName).Length / 1048576), 3))
            Item.SubItems.Add(File.DirectoryName)
            FileList.Items.Add(Item)
        Next
        CheckSize()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        For Each Item As ListViewItem In FileList.SelectedItems
            Item.Remove()
        Next
        CheckSize()
    End Sub

    Private Sub CreateDisk_Click(sender As Object, e As EventArgs) Handles CreateDisk.Click
        Dim folderSize As Decimal = Convert.ToDecimal(TotalSize.Text)
        Dim PathContainsWindows As Boolean
        For Each Item As ListViewItem In FileList.Items
            If Item.SubItems(1).Text.Contains("windows") Then
                PathContainsWindows = True
            End If
        Next
        If PathContainsWindows Then
            MsgBox("Do not use your Windows folder; if your username contains Windows in the name, please move your file to another location (i.e., C:\MyFolder)", MsgBoxStyle.OkOnly, "")
        Else
            If RAMSize.Text = "" Then
                MsgBox("Enter how large you want the RAM disk to be", MsgBoxStyle.OkOnly, "")
            Else
                If ThereIsDisk Then
                    MsgBox("There is already a RAM disk, please remove the RAM disk before creating a new one", MsgBoxStyle.OkOnly, "")
                Else
                    If Convert.ToDecimal(TotalSize.Text) > (Convert.ToDecimal(RAMSize.Text) * 0.95) Then
                        MsgBox("The files are larger than the RAM disk, please increase the size of the disk or remove some files" & Environment.NewLine & "Calculation of RAMDisk space available is 95% of the original capacity", MsgBoxStyle.OkOnly, "")
                    Else
                        If Convert.ToDecimal(RAMSize.Text) > Convert.ToDecimal(AvailableRAM.Text) Then
                            MsgBox("The RAM disk is larger than the available amount of RAM, please decrease the size of the disk", MsgBoxStyle.OkOnly, "")
                        Else
                            ImDiskProcess.StartInfo.FileName = "imdisk.exe"
                            ImDiskProcess.StartInfo.Verb = "runas"
                            ImDiskProcess.StartInfo.Arguments = " -a -s " & RAMSize.Text & "M -m " & DriveLetter.Text & ": -o rem"
                            ImDiskProcess.StartInfo.UseShellExecute = True
                            ImDiskProcess.StartInfo.CreateNoWindow = True
                            ImDiskProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                            ImDiskProcess.Start()
                            ImDiskProcess.WaitForExit()
                            Dim RAMDiskDeci As Decimal
                            Dim formatArgs As String = DriveLetter.Text & ": /FS:exFAT /v: /q /y"
                            Decimal.TryParse(RAMSize.Text, RAMDiskDeci)

                            'This part has been removed so as to always format in exFAT

                            'If RAMDiskDeci > 32000 Then
                            'formatArgs = DriveLetter.Text & ": /FS:exFAT /v: /q /y"
                            'Else
                            'formatArgs = DriveLetter.Text & ": /FS:" & FileSystem.Text & " /v: /q /y"
                            'End If
                            FormatProcess.StartInfo.FileName = "format.com"
                            FormatProcess.StartInfo.Arguments = formatArgs
                            FormatProcess.StartInfo.UseShellExecute = True
                            FormatProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                            FormatProcess.Start()
                            FormatProcess.WaitForExit()
                            ThereIsDisk = True
                            Do Until CanWrite()
                                Application.DoEvents()
                            Loop
                            TotalBar.Maximum = FileList.Items.Count
                            For Each Item As ListViewItem In FileList.Items
                                OriginFile = Item.SubItems(2).Text & "\" & Item.Text
                                DestinationFolder = DriveLetter.Text & ":\" & Item.SubItems(2).Text.Replace(":", "") & "\"
                                CopyFile(OriginFile, DestinationFolder, Item.Text)
                                My.Computer.FileSystem.RenameFile(OriginFile, Item.Text & ".old")
                                TotalBar.Value = TotalBar.Value + 1
                                CreateJunction(OriginFile, DestinationFolder & Item.Text)
                            Next
                            CopyBar.Value = 0
                            TotalBar.Value = 0
                            CreateDisk.Enabled = False
                            FilesButton.Enabled = False
                            RemoveButton.Enabled = False
                            DriveLetter.Enabled = False
                            RemoveDisk.Enabled = True
                            LoadProfile.Enabled = False
                            MsgBox("RAM disk ready", MsgBoxStyle.OkOnly, "")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RemoveDisk_Click(sender As Object, e As EventArgs) Handles RemoveDisk.Click
        For Each Item As ListViewItem In FileList.Items
            OriginFile = Item.SubItems(2).Text & "\" & Item.Text
            RemoveJunction(OriginFile)
            My.Computer.FileSystem.RenameFile(OriginFile & ".old", Item.Text)
            TotalBar.Value = TotalBar.Value + 1
        Next
        'If DontCopyCheck.Checked = False Then
        'ROOTFOLDER = RAMDiskLetter.Text & ":\" & folderNameVar
        'DESTFOLDER = PathBox.Text
        'GetTotalFileSize(New DirectoryInfo(ROOTFOLDER))
        '_copyProgressRoutine = New CopyProgressRoutine(AddressOf CopyProgress)
        'CopyFiles(New DirectoryInfo(ROOTFOLDER), DESTFOLDER)
        'While CopyCompleted = False
        'Application.DoEvents()
        'End While
        'End If
        ImDiskProcess.StartInfo.FileName = "imdisk.exe"
        ImDiskProcess.StartInfo.Verb = "runas"
        ImDiskProcess.StartInfo.Arguments = " -D -m " & DriveLetter.Text & ":"
        ImDiskProcess.StartInfo.UseShellExecute = True
        ImDiskProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        ImDiskProcess.Start()
        'If DontCopyCheck.Checked = False Then
        'Dim deletePath As String = PathBox.Text & ".old"
        'Directory.Delete(deletePath, True)
        'Else
        'My.Computer.FileSystem.RenameDirectory(PathBox.Text & ".old", folderNameVar)
        'End If
        Do Until ImDiskProcess.HasExited
            Application.DoEvents()
        Loop
        TotalBar.Value = 0
        ThereIsDisk = 0
        CreateDisk.Enabled = True
        FilesButton.Enabled = True
        RemoveButton.Enabled = True
        DriveLetter.Enabled = True
        RemoveDisk.Enabled = False
        LoadProfile.Enabled = True
        MsgBox("RAM disk removed")
    End Sub

    Private Sub SaveProfile_Click(sender As Object, e As EventArgs) Handles SaveProfile.Click
        SaveProfileDialog.InitialDirectory = IO.Directory.GetCurrentDirectory
        SaveProfileDialog.Filter = "RAMDiskCopy2 Profiles *.rdc2|*.rdc2"
        If SaveProfileDialog.ShowDialog = DialogResult.OK Then
            IO.File.CreateText(SaveProfileDialog.FileName).Dispose()
            IO.File.CreateText(SaveProfileDialog.FileName.Substring(0, SaveProfileDialog.FileName.Length - 4) & "var").Dispose()
            Using sw As New IO.StreamWriter(SaveProfileDialog.FileName)
                For Each item As ListViewItem In FileList.Items
                    sw.WriteLine(item.SubItems(2).Text & "\" & item.Text)
                Next
            End Using
            Using sw As New IO.StreamWriter(SaveProfileDialog.FileName.Substring(0, SaveProfileDialog.FileName.Length - 4) & "var")
                sw.WriteLine("RAMSize," & RAMSize.Text)
                sw.WriteLine("DriveLetter," & DriveLetter.Text)
            End Using
        End If
    End Sub

    Private Sub LoadProfile_Click(sender As Object, e As EventArgs) Handles LoadProfile.Click
        LoadProfileDialog.InitialDirectory = IO.Directory.GetCurrentDirectory
        LoadProfileDialog.Filter = "RAMDiskCopy2 Profiles *.rdc2|*.rdc2"
        If LoadProfileDialog.ShowDialog = DialogResult.OK Then
            FileList.Items.Clear()
            Dim lines As String() = IO.File.ReadAllLines(LoadProfileDialog.FileName)
            Dim missingfile As Int16 = 0
            For Each file As String In lines
                If IO.File.Exists(file) Then
                    Dim Item As New ListViewItem()
                    Item.Text = IO.Path.GetFileName(file)
                    Item.SubItems.Add(Math.Round((My.Computer.FileSystem.GetFileInfo(file).Length / 1048576), 3))
                    Item.SubItems.Add(IO.Path.GetDirectoryName(file))
                    FileList.Items.Add(Item)
                ElseIf missingfile > 3 Then
                    MsgBox(file & " is missing. Seems that this file is outdated and won't proceed." & Environment.NewLine & "Please create a new Profile or edit the current one with a text editor like Notepad", MsgBoxStyle.Critical, "Too many files missing")
                    Exit Sub
                Else
                    missingfile += 1
                    MsgBox(file & " is missing. It won't be added to the list" & Environment.NewLine & "After four times, this process will stop" & Environment.NewLine & "Current count: " & missingfile, MsgBoxStyle.Exclamation, "File missing")
                End If
            Next
            lines = IO.File.ReadAllLines(LoadProfileDialog.FileName.Substring(0, LoadProfileDialog.FileName.Length - 4) & "var")
            Dim var As String()
            For Each line As String In lines
                If line.StartsWith("RAMSize") Then
                    var = line.Split(",")
                    RAMSize.Text = var(1)
                ElseIf line.StartsWith("DriveLetter") Then
                    var = line.Split(",")
                    DriveLetter.SelectedIndex = DriveLetter.FindStringExact(var(1))
                End If
            Next
        End If
        CheckSize()
    End Sub

    Private Sub RAMDiskCopy2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ThereIsDisk Then
            Dim result As MsgBoxResult = MsgBox("There is still a RAM disk mounted. Are you sure you want to exit?", MsgBoxStyle.YesNo, "Do you want to quit?")
            If result = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub drag_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim DropItem() As String = CType(e.Data.GetData("FileDrop", True), String())
        For Each file In DropItem
            If IO.Directory.Exists(file) Then
                ParseFolders()
            End If
        Next
        For Each file In DropItem
            Dim Item As New ListViewItem()
            Item.Text = IO.Path.GetFileName(file)
            Item.SubItems.Add(Math.Round((My.Computer.FileSystem.GetFileInfo(file).Length / 1048576), 3))
            Item.SubItems.Add(IO.Path.GetDirectoryName(file))
            FileList.Items.Add(Item)
        Next
        CheckSize()
    End Sub

    Private Sub drag_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.Show()
    End Sub

End Class
