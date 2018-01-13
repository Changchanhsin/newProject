<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstContent = New System.Windows.Forms.ListBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.cboConfigFiles = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pgbScale = New System.Windows.Forms.ProgressBar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstContent
        '
        Me.lstContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstContent.FormattingEnabled = True
        Me.lstContent.IntegralHeight = False
        Me.lstContent.ItemHeight = 12
        Me.lstContent.Location = New System.Drawing.Point(12, 12)
        Me.lstContent.Name = "lstContent"
        Me.lstContent.Size = New System.Drawing.Size(260, 182)
        Me.lstContent.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.Location = New System.Drawing.Point(12, 200)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(115, 23)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "1 加载项目信息(&L)"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(12, 229)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(115, 23)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "2 创建项目(&C)"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'cboConfigFiles
        '
        Me.cboConfigFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboConfigFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConfigFiles.FormattingEnabled = True
        Me.cboConfigFiles.Location = New System.Drawing.Point(133, 202)
        Me.cboConfigFiles.Name = "cboConfigFiles"
        Me.cboConfigFiles.Size = New System.Drawing.Size(139, 20)
        Me.cboConfigFiles.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(197, 229)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "退出(&X)"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pgbScale
        '
        Me.pgbScale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbScale.Location = New System.Drawing.Point(133, 229)
        Me.pgbScale.Name = "pgbScale"
        Me.pgbScale.Size = New System.Drawing.Size(58, 23)
        Me.pgbScale.TabIndex = 5
        Me.pgbScale.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(12, 29)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(259, 165)
        Me.ListBox1.TabIndex = 6
        Me.ListBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.pgbScale)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboConfigFiles)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lstContent)
        Me.Name = "Form1"
        Me.Text = "newProject"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstContent As System.Windows.Forms.ListBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents cboConfigFiles As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pgbScale As System.Windows.Forms.ProgressBar
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
