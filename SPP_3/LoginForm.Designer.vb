<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.ScreenPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.LoginSiswa = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fnisn = New DevExpress.XtraEditors.TextEdit()
        Me.LoginButton = New DevExpress.XtraEditors.SimpleButton()
        Me.Password = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Username = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FpasswordSiswa = New DevExpress.XtraEditors.TextEdit()
        Me.ScreenPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Fnisn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpasswordSiswa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScreenPanel
        '
        Me.ScreenPanel.BackColor = System.Drawing.Color.LightGray
        Me.ScreenPanel.Controls.Add(Me.Panel2)
        Me.ScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScreenPanel.ForeColor = System.Drawing.Color.Maroon
        Me.ScreenPanel.Location = New System.Drawing.Point(0, 0)
        Me.ScreenPanel.Name = "ScreenPanel"
        Me.ScreenPanel.Size = New System.Drawing.Size(774, 425)
        Me.ScreenPanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.FpasswordSiswa)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Controls.Add(Me.LoginLabel)
        Me.Panel2.Controls.Add(Me.LoginSiswa)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Fnisn)
        Me.Panel2.Controls.Add(Me.LoginButton)
        Me.Panel2.Controls.Add(Me.Password)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Username)
        Me.Panel2.Location = New System.Drawing.Point(169, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 362)
        Me.Panel2.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.ImageOptions.Image = CType(resources.GetObject("LabelControl1.ImageOptions.Image"), System.Drawing.Image)
        Me.LabelControl1.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.LabelControl1.Location = New System.Drawing.Point(111, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 78)
        Me.LabelControl1.TabIndex = 10
        '
        'LoginLabel
        '
        Me.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LoginLabel.ForeColor = System.Drawing.Color.MintCream
        Me.LoginLabel.Location = New System.Drawing.Point(169, 35)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(98, 32)
        Me.LoginLabel.TabIndex = 9
        Me.LoginLabel.Text = "Login"
        '
        'LoginSiswa
        '
        Me.LoginSiswa.Location = New System.Drawing.Point(283, 298)
        Me.LoginSiswa.Name = "LoginSiswa"
        Me.LoginSiswa.Size = New System.Drawing.Size(104, 44)
        Me.LoginSiswa.TabIndex = 8
        Me.LoginSiswa.Text = "Login Siswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(47, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NISN"
        '
        'Fnisn
        '
        Me.Fnisn.Location = New System.Drawing.Point(95, 295)
        Me.Fnisn.Name = "Fnisn"
        Me.Fnisn.Properties.UseSystemPasswordChar = True
        Me.Fnisn.Size = New System.Drawing.Size(182, 20)
        Me.Fnisn.TabIndex = 6
        '
        'LoginButton
        '
        Me.LoginButton.Appearance.Options.UseImage = True
        Me.LoginButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LoginButton.Location = New System.Drawing.Point(104, 194)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(163, 39)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.Text = "Login"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(95, 149)
        Me.Password.Name = "Password"
        Me.Password.Properties.UseSystemPasswordChar = True
        Me.Password.Size = New System.Drawing.Size(182, 20)
        Me.Password.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(17, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(17, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(95, 112)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(182, 20)
        Me.Username.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(20, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "PAssword"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.MintCream
        Me.Label5.Location = New System.Drawing.Point(98, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 32)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Login Siswa"
        '
        'FpasswordSiswa
        '
        Me.FpasswordSiswa.Location = New System.Drawing.Point(95, 324)
        Me.FpasswordSiswa.Name = "FpasswordSiswa"
        Me.FpasswordSiswa.Properties.UseSystemPasswordChar = True
        Me.FpasswordSiswa.Size = New System.Drawing.Size(182, 20)
        Me.FpasswordSiswa.TabIndex = 14
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 425)
        Me.Controls.Add(Me.ScreenPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.ScreenPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Fnisn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpasswordSiswa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ScreenPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LoginButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginSiswa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Fnisn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LoginLabel As Label
    Friend WithEvents FpasswordSiswa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
