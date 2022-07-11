Namespace ubiLease.UI.Login

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmLogin
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
            Me.imgLogMain = New System.Windows.Forms.ImageList(Me.components)
            Me.imgListSub = New System.Windows.Forms.ImageList(Me.components)
            Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.picClose = New System.Windows.Forms.PictureBox()
            Me.picMain = New System.Windows.Forms.PictureBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.picCancel = New System.Windows.Forms.PictureBox()
            Me.picOk = New System.Windows.Forms.PictureBox()
            Me.txtNewPassword2 = New System.Windows.Forms.TextBox()
            Me.lblNewPassword = New System.Windows.Forms.Label()
            Me.txtNewPassword = New System.Windows.Forms.TextBox()
            Me.picChangePassword = New System.Windows.Forms.PictureBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.picLogin = New System.Windows.Forms.PictureBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblLoginID = New System.Windows.Forms.Label()
            Me.txtLoginID = New System.Windows.Forms.TextBox()
            Me.lblVersion = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.picCancel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picOk, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picChangePassword, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picLogin, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'imgLogMain
            '
            Me.imgLogMain.ImageStream = CType(resources.GetObject("imgLogMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgLogMain.TransparentColor = System.Drawing.Color.Transparent
            Me.imgLogMain.Images.SetKeyName(0, "picLog00")
            Me.imgLogMain.Images.SetKeyName(1, "picLog01")
            '
            'imgListSub
            '
            Me.imgListSub.ImageStream = CType(resources.GetObject("imgListSub.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgListSub.TransparentColor = System.Drawing.Color.Transparent
            Me.imgListSub.Images.SetKeyName(0, "picClose")
            Me.imgListSub.Images.SetKeyName(1, "picClose")
            Me.imgListSub.Images.SetKeyName(2, "picMinimumSize")
            Me.imgListSub.Images.SetKeyName(3, "picMinimumSize")
            '
            'WebBrowser1
            '
            Me.WebBrowser1.AllowNavigation = False
            Me.WebBrowser1.AllowWebBrowserDrop = False
            Me.WebBrowser1.CausesValidation = False
            Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
            Me.WebBrowser1.Location = New System.Drawing.Point(0, 406)
            Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(0)
            Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowser1.Name = "WebBrowser1"
            Me.WebBrowser1.ScrollBarsEnabled = False
            Me.WebBrowser1.Size = New System.Drawing.Size(52, 34)
            Me.WebBrowser1.TabIndex = 0
            Me.WebBrowser1.TabStop = False
            Me.WebBrowser1.Visible = False
            Me.WebBrowser1.WebBrowserShortcutsEnabled = False
            '
            'picClose
            '
            Me.picClose.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picClose.Image = Global.My.Resources.Resources.close
            Me.picClose.Location = New System.Drawing.Point(625, 5)
            Me.picClose.Name = "picClose"
            Me.picClose.Size = New System.Drawing.Size(11, 11)
            Me.picClose.TabIndex = 19
            Me.picClose.TabStop = False
            '
            'picMain
            '
            Me.picMain.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picMain.BackgroundImage = Global.My.Resources.Resources.login
            Me.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picMain.Location = New System.Drawing.Point(0, 0)
            Me.picMain.Name = "picMain"
            Me.picMain.Size = New System.Drawing.Size(642, 362)
            Me.picMain.TabIndex = 16
            Me.picMain.TabStop = False
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(222, Byte), Integer))
            Me.GroupBox1.Location = New System.Drawing.Point(157, 372)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(43, 30)
            Me.GroupBox1.TabIndex = 28
            Me.GroupBox1.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.Window
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.picCancel)
            Me.Panel1.Controls.Add(Me.picOk)
            Me.Panel1.Controls.Add(Me.txtNewPassword2)
            Me.Panel1.Controls.Add(Me.lblNewPassword)
            Me.Panel1.Controls.Add(Me.txtNewPassword)
            Me.Panel1.Controls.Add(Me.picChangePassword)
            Me.Panel1.Controls.Add(Me.txtPassword)
            Me.Panel1.Controls.Add(Me.picLogin)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.lblLoginID)
            Me.Panel1.Controls.Add(Me.txtLoginID)
            Me.Panel1.Controls.Add(Me.lblVersion)
            Me.Panel1.Controls.Add(Me.lblTitle)
            Me.Panel1.Location = New System.Drawing.Point(206, 84)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(424, 269)
            Me.Panel1.TabIndex = 29
            '
            'picCancel
            '
            Me.picCancel.Image = Global.My.Resources.Resources.cancle_00
            Me.picCancel.Location = New System.Drawing.Point(277, 199)
            Me.picCancel.Name = "picCancel"
            Me.picCancel.Size = New System.Drawing.Size(80, 23)
            Me.picCancel.TabIndex = 40
            Me.picCancel.TabStop = False
            Me.picCancel.Visible = False
            '
            'picOk
            '
            Me.picOk.Image = Global.My.Resources.Resources.ok_00
            Me.picOk.Location = New System.Drawing.Point(193, 199)
            Me.picOk.Name = "picOk"
            Me.picOk.Size = New System.Drawing.Size(80, 23)
            Me.picOk.TabIndex = 39
            Me.picOk.TabStop = False
            Me.picOk.Visible = False
            '
            'txtNewPassword2
            '
            Me.txtNewPassword2.Location = New System.Drawing.Point(193, 174)
            Me.txtNewPassword2.Name = "txtNewPassword2"
            Me.txtNewPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtNewPassword2.Size = New System.Drawing.Size(164, 21)
            Me.txtNewPassword2.TabIndex = 38
            Me.txtNewPassword2.Visible = False
            '
            'lblNewPassword
            '
            Me.lblNewPassword.AutoSize = True
            Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
            Me.lblNewPassword.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblNewPassword.Location = New System.Drawing.Point(120, 156)
            Me.lblNewPassword.Name = "lblNewPassword"
            Me.lblNewPassword.Size = New System.Drawing.Size(70, 12)
            Me.lblNewPassword.TabIndex = 37
            Me.lblNewPassword.Text = "새비밀번호"
            Me.lblNewPassword.Visible = False
            '
            'txtNewPassword
            '
            Me.txtNewPassword.Location = New System.Drawing.Point(193, 150)
            Me.txtNewPassword.Name = "txtNewPassword"
            Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtNewPassword.Size = New System.Drawing.Size(164, 21)
            Me.txtNewPassword.TabIndex = 36
            Me.txtNewPassword.Visible = False
            '
            'picChangePassword
            '
            Me.picChangePassword.Image = Global.My.Resources.Resources.password00
            Me.picChangePassword.Location = New System.Drawing.Point(259, 123)
            Me.picChangePassword.Name = "picChangePassword"
            Me.picChangePassword.Size = New System.Drawing.Size(98, 23)
            Me.picChangePassword.TabIndex = 35
            Me.picChangePassword.TabStop = False
            '
            'txtPassword
            '
            Me.txtPassword.Location = New System.Drawing.Point(193, 97)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(164, 21)
            Me.txtPassword.TabIndex = 31
            '
            'picLogin
            '
            Me.picLogin.Image = Global.My.Resources.Resources.login01
            Me.picLogin.Location = New System.Drawing.Point(193, 123)
            Me.picLogin.Name = "picLogin"
            Me.picLogin.Size = New System.Drawing.Size(61, 23)
            Me.picLogin.TabIndex = 34
            Me.picLogin.TabStop = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(120, 101)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(57, 12)
            Me.Label1.TabIndex = 33
            Me.Label1.Text = "비밀번호"
            '
            'lblLoginID
            '
            Me.lblLoginID.AutoSize = True
            Me.lblLoginID.BackColor = System.Drawing.Color.Transparent
            Me.lblLoginID.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblLoginID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblLoginID.Location = New System.Drawing.Point(120, 77)
            Me.lblLoginID.Name = "lblLoginID"
            Me.lblLoginID.Size = New System.Drawing.Size(57, 12)
            Me.lblLoginID.TabIndex = 32
            Me.lblLoginID.Text = "사원번호"
            '
            'txtLoginID
            '
            Me.txtLoginID.Location = New System.Drawing.Point(193, 73)
            Me.txtLoginID.Name = "txtLoginID"
            Me.txtLoginID.Size = New System.Drawing.Size(164, 21)
            Me.txtLoginID.TabIndex = 30
            '
            'lblVersion
            '
            Me.lblVersion.AutoSize = True
            Me.lblVersion.BackColor = System.Drawing.Color.Transparent
            Me.lblVersion.Location = New System.Drawing.Point(24, 243)
            Me.lblVersion.Name = "lblVersion"
            Me.lblVersion.Size = New System.Drawing.Size(53, 12)
            Me.lblVersion.TabIndex = 29
            Me.lblVersion.Text = "버전정보"
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("돋움", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(44, 40)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(55, 15)
            Me.lblTitle.TabIndex = 28
            Me.lblTitle.Text = "타이틀"
            '
            'frmLogin
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.ClientSize = New System.Drawing.Size(642, 362)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.picClose)
            Me.Controls.Add(Me.WebBrowser1)
            Me.Controls.Add(Me.picMain)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmLogin"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "로그인"
            CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.picCancel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picOk, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picChangePassword, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picLogin, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents picMain As System.Windows.Forms.PictureBox
        Friend WithEvents picClose As System.Windows.Forms.PictureBox
        Friend WithEvents imgLogMain As System.Windows.Forms.ImageList
        Friend WithEvents imgListSub As System.Windows.Forms.ImageList
        Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents picCancel As System.Windows.Forms.PictureBox
        Friend WithEvents picOk As System.Windows.Forms.PictureBox
        Friend WithEvents txtNewPassword2 As System.Windows.Forms.TextBox
        Friend WithEvents lblNewPassword As System.Windows.Forms.Label
        Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
        Friend WithEvents picChangePassword As System.Windows.Forms.PictureBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents picLogin As System.Windows.Forms.PictureBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblLoginID As System.Windows.Forms.Label
        Friend WithEvents txtLoginID As System.Windows.Forms.TextBox
        Friend WithEvents lblVersion As System.Windows.Forms.Label
        Friend WithEvents lblTitle As System.Windows.Forms.Label
    End Class

End Namespace

