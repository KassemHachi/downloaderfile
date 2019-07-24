<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebClient = New System.Net.WebClient()
        Me.LabelLinkFile = New System.Windows.Forms.Label()
        Me.LinkFile = New System.Windows.Forms.TextBox()
        Me.LabelPathFile = New System.Windows.Forms.Label()
        Me.PathFile = New System.Windows.Forms.TextBox()
        Me.SaveFileBtn = New System.Windows.Forms.Button()
        Me.OpenFolderBtn = New System.Windows.Forms.Button()
        Me.NameFile = New System.Windows.Forms.TextBox()
        Me.SliderEx = New System.Windows.Forms.ComboBox()
        Me.LabelNameFile = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'WebClient
        '
       
        Me.WebClient.BaseAddress = ""
        Me.WebClient.CachePolicy = Nothing
        Me.WebClient.Credentials = Nothing
        Me.WebClient.Encoding = CType(resources.GetObject("WebClient.Encoding"), System.Text.Encoding)
        Me.WebClient.Headers = CType(resources.GetObject("WebClient.Headers"), System.Net.WebHeaderCollection)
        Me.WebClient.QueryString = CType(resources.GetObject("WebClient.QueryString"), System.Collections.Specialized.NameValueCollection)
        Me.WebClient.UseDefaultCredentials = False
        '
        'LabelLinkFile
        '
        Me.LabelLinkFile.AutoSize = True
        Me.LabelLinkFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLinkFile.Location = New System.Drawing.Point(7, 21)
        Me.LabelLinkFile.Name = "LabelLinkFile"
        Me.LabelLinkFile.Size = New System.Drawing.Size(71, 21)
        Me.LabelLinkFile.TabIndex = 0
        Me.LabelLinkFile.Text = "Link file :"
        '
        'LinkFile
        '
        Me.LinkFile.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkFile.Location = New System.Drawing.Point(101, 15)
        Me.LinkFile.Name = "LinkFile"
        Me.LinkFile.Size = New System.Drawing.Size(283, 33)
        Me.LinkFile.TabIndex = 0
        '
        'LabelPathFile
        '
        Me.LabelPathFile.AutoSize = True
        Me.LabelPathFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPathFile.Location = New System.Drawing.Point(7, 98)
        Me.LabelPathFile.Name = "LabelPathFile"
        Me.LabelPathFile.Size = New System.Drawing.Size(72, 21)
        Me.LabelPathFile.TabIndex = 0
        Me.LabelPathFile.Text = "Path file :"
        '
        'PathFile
        '
        Me.PathFile.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PathFile.Location = New System.Drawing.Point(101, 93)
        Me.PathFile.Name = "PathFile"
        Me.PathFile.ReadOnly = True
        Me.PathFile.Size = New System.Drawing.Size(246, 33)
        Me.PathFile.TabIndex = 3
        '
        'SaveFileBtn
        '
        Me.SaveFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveFileBtn.Location = New System.Drawing.Point(101, 132)
        Me.SaveFileBtn.Name = "SaveFileBtn"
        Me.SaveFileBtn.Size = New System.Drawing.Size(283, 28)
        Me.SaveFileBtn.TabIndex = 5
        Me.SaveFileBtn.Text = "Save"
        Me.SaveFileBtn.UseVisualStyleBackColor = True
        '
        'OpenFolderBtn
        '
        Me.OpenFolderBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFolderBtn.Location = New System.Drawing.Point(353, 93)
        Me.OpenFolderBtn.Name = "OpenFolderBtn"
        Me.OpenFolderBtn.Size = New System.Drawing.Size(31, 33)
        Me.OpenFolderBtn.TabIndex = 4
        Me.OpenFolderBtn.Text = "..."
        Me.OpenFolderBtn.UseVisualStyleBackColor = True
        '
        'NameFile
        '
        Me.NameFile.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameFile.Location = New System.Drawing.Point(101, 54)
        Me.NameFile.Name = "NameFile"
        Me.NameFile.Size = New System.Drawing.Size(185, 33)
        Me.NameFile.TabIndex = 1
        '
        'SliderEx
        '
        Me.SliderEx.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SliderEx.FormattingEnabled = True
        Me.SliderEx.Items.AddRange(New Object() {"jpg", "png", "jpeg", "gif", "docx", "pptx", "txt", "exe", "rar", "zip", "iso", "html", "css", "js", "php", "sln"})
        Me.SliderEx.Location = New System.Drawing.Point(292, 54)
        Me.SliderEx.Name = "SliderEx"
        Me.SliderEx.Size = New System.Drawing.Size(92, 33)
        Me.SliderEx.TabIndex = 2
        '
        'LabelNameFile
        '
        Me.LabelNameFile.AutoSize = True
        Me.LabelNameFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameFile.Location = New System.Drawing.Point(7, 60)
        Me.LabelNameFile.Name = "LabelNameFile"
        Me.LabelNameFile.Size = New System.Drawing.Size(84, 21)
        Me.LabelNameFile.TabIndex = 0
        Me.LabelNameFile.Text = "Name file :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 171)
        Me.Controls.Add(Me.SliderEx)
        Me.Controls.Add(Me.OpenFolderBtn)
        Me.Controls.Add(Me.SaveFileBtn)
        Me.Controls.Add(Me.PathFile)
        Me.Controls.Add(Me.LabelNameFile)
        Me.Controls.Add(Me.LabelPathFile)
        Me.Controls.Add(Me.NameFile)
        Me.Controls.Add(Me.LinkFile)
        Me.Controls.Add(Me.LabelLinkFile)
        Me.MaximumSize = New System.Drawing.Size(409, 210)
        Me.MinimumSize = New System.Drawing.Size(409, 210)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebClient As System.Net.WebClient
    Friend WithEvents LabelLinkFile As System.Windows.Forms.Label
    Friend WithEvents LinkFile As System.Windows.Forms.TextBox
    Friend WithEvents LabelPathFile As System.Windows.Forms.Label
    Friend WithEvents PathFile As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileBtn As System.Windows.Forms.Button
    Friend WithEvents OpenFolderBtn As System.Windows.Forms.Button
    Friend WithEvents NameFile As System.Windows.Forms.TextBox
    Friend WithEvents SliderEx As System.Windows.Forms.ComboBox
    Friend WithEvents LabelNameFile As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog

End Class
