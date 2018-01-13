Public Class Form1
    Private rootPath As String
    Dim word As New clsWordOpt
    Dim project_output As String
    Dim project_template As String

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        MessageBox.Show("按模板创建项目文件" & vbCrLf & _
                        "" & vbCrLf & _
                        "1、模板文件夹与本执行文件及项目信息文件(txt)在同一文件夹；" & vbCrLf & _
                        "2、模板文件可分级子目录，仅处理和复制其中的doc和docx(如果本地支持)文件；" & vbCrLf & _
                        "3、项目信息文件为纯文本txt文件，ini格式，暂不支持utf8等；" & vbCrLf & _
                        "4、项目信息文件必须有project_template参数用于指定模板文件夹名；" & vbCrLf & _
                        "5、项目信息文件用project_output参数指定输出文件夹名称；" & vbCrLf & _
                        "6、在word文件中用‘[[’和‘]]’标记需要替换的文字。" & vbCrLf & _
                        "" & vbCrLf & _
                        "Copyright 2018, ZZX@Beijing" & vbCrLf, "newProject", MessageBoxButtons.OK)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        Dim s As String

        rootPath = Application.StartupPath
        cboConfigFiles.Items.Clear()
        For Each s In System.IO.Directory.EnumerateFiles(rootPath, "*.txt", IO.SearchOption.TopDirectoryOnly)
            cboConfigFiles.Items.Add(s)
        Next
        If cboConfigFiles.Items.Count > 0 Then
            cboConfigFiles.Text = cboConfigFiles.Items(0)
        End If
        project_output = "NewProject"
        project_template = "[模板]"
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        On Error Resume Next
        Dim sr As System.IO.StreamReader
        Dim s As String
        Dim s2 As String()

        lstContent.Items.Clear()
        sr = New IO.StreamReader(cboConfigFiles.Text, System.Text.Encoding.Default)
        While sr.EndOfStream = False
            s = sr.ReadLine()
            lstContent.Items.Add(s)
            s2 = Split(s, "=")
            If s2.Length > 1 Then
                If s2(0) = "project_output" Then
                    project_output = s2(1)
                End If
                If s2(0) = "project_template" Then
                    project_template = s2(1)
                End If
            End If
        End While
        For Each s In lstContent.Items
            s2 = Split(s, "=")
            If s2.Length > 1 Then
                project_output = project_output.Replace("[[" & s2(0) & "]]", s2(1))
            End If
        Next
        Me.Text = project_output
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        ListBox1.Visible = True
        pgbScale.Value = 0
        pgbScale.Visible = True
        Dim all = System.IO.Directory.GetFiles(rootPath & "\" & project_template, "*.doc?", IO.SearchOption.AllDirectories)
        pgbScale.Maximum = all.Length
        word.Create()
        For Each f In all
            If (InStr(f, "~$") <= 0) Then
                replace(f, rootPath & "\" & project_template, rootPath & "\" & project_output)
                pgbScale.Value = pgbScale.Value + 1
                My.Application.DoEvents()
            End If
        Next
        pgbScale.Visible = False
        word.Quit()
        ListBox1.Visible = False
    End Sub

    Private Sub replace(fn As String, sroot As String, droot As String)
        Dim s2 As String()
        Dim i As Integer
        Dim fout As String

        word.Open(fn)
        ListBox1.Items.Add("open " & fn)
        My.Application.DoEvents()
        For i = 0 To lstContent.Items.Count - 1
            s2 = Split(lstContent.Items(i), "=")
            If s2.Length > 1 Then
                word.Replace("[[" & s2(0) & "]]", s2(1))
            End If
        Next

        fout = fn.Replace(sroot, droot)
        For Each s In lstContent.Items
            s2 = Split(s, "=")
            If s2.Length > 1 Then
                fout = fout.Replace("[[" & s2(0) & "]]", s2(1))
            End If
        Next

        System.IO.Directory.CreateDirectory(System.IO.Directory.GetParent(fout).FullName)
        word.SaveAs(fout)
        ListBox1.Items.Add("saveAs " & fout)
        word.Close()

    End Sub

End Class
