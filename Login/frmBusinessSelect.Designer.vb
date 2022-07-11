Namespace ubiLease.UI.Login

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusinessSelect
        Inherits System.Windows.Forms.Form

        'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Windows Form 디자이너에 필요합니다.
        Private components As System.ComponentModel.IContainer

        '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
        '수정하려면 Windows Form 디자이너를 사용하십시오.  
        '코드 편집기를 사용하여 수정하지 마십시오.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusinessSelect))
            Me.notifyIconMain = New System.Windows.Forms.NotifyIcon(Me.components)
            Me.notifyMenuStripMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.spr1 = New System.Windows.Forms.ToolStripSeparator()
            Me.notiyMenuExit = New System.Windows.Forms.ToolStripMenuItem()
            Me.imgListSub = New System.Windows.Forms.ImageList(Me.components)
            Me.imgListMain = New System.Windows.Forms.ImageList(Me.components)
            Me.lblVersion = New System.Windows.Forms.Label()
            Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.flp_BusinessBtn = New System.Windows.Forms.FlowLayoutPanel()
            Me.lblApplication = New System.Windows.Forms.Label()
            Me.picZS = New System.Windows.Forms.PictureBox()
            Me.picClose = New System.Windows.Forms.PictureBox()
            Me.picMinimumSize = New System.Windows.Forms.PictureBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.picMain = New System.Windows.Forms.PictureBox()
            Me.picBG = New System.Windows.Forms.PictureBox()
            Me.notifyMenuStripMain.SuspendLayout()
            CType(Me.picZS, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picMinimumSize, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBG, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'notifyIconMain
            '
            Me.notifyIconMain.ContextMenuStrip = Me.notifyMenuStripMain
            Me.notifyIconMain.Icon = CType(resources.GetObject("notifyIconMain.Icon"), System.Drawing.Icon)
            Me.notifyIconMain.Visible = True
            '
            'notifyMenuStripMain
            '
            Me.notifyMenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.spr1, Me.notiyMenuExit})
            Me.notifyMenuStripMain.Name = "notifyMenuStripMain"
            Me.notifyMenuStripMain.Size = New System.Drawing.Size(99, 32)
            '
            'spr1
            '
            Me.spr1.Name = "spr1"
            Me.spr1.Size = New System.Drawing.Size(95, 6)
            '
            'notiyMenuExit
            '
            Me.notiyMenuExit.Name = "notiyMenuExit"
            Me.notiyMenuExit.Size = New System.Drawing.Size(98, 22)
            Me.notiyMenuExit.Text = "종료"
            '
            'imgListSub
            '
            Me.imgListSub.ImageStream = CType(resources.GetObject("imgListSub.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgListSub.TransparentColor = System.Drawing.Color.Transparent
            Me.imgListSub.Images.SetKeyName(0, "picMinimumSize")
            Me.imgListSub.Images.SetKeyName(1, "picClose")
            Me.imgListSub.Images.SetKeyName(2, "close.gif")
            Me.imgListSub.Images.SetKeyName(3, "picMinimumSize")
            '
            'imgListMain
            '
            Me.imgListMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.imgListMain.ImageSize = New System.Drawing.Size(16, 16)
            Me.imgListMain.TransparentColor = System.Drawing.Color.Transparent
            '
            'lblVersion
            '
            Me.lblVersion.AutoSize = True
            Me.lblVersion.BackColor = System.Drawing.Color.White
            Me.lblVersion.Location = New System.Drawing.Point(112, 547)
            Me.lblVersion.Name = "lblVersion"
            Me.lblVersion.Size = New System.Drawing.Size(53, 12)
            Me.lblVersion.TabIndex = 3
            Me.lblVersion.Text = "버전정보"
            '
            'WebBrowser1
            '
            Me.WebBrowser1.Location = New System.Drawing.Point(450, 90)
            Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowser1.Name = "WebBrowser1"
            Me.WebBrowser1.ScrollBarsEnabled = False
            Me.WebBrowser1.Size = New System.Drawing.Size(329, 338)
            Me.WebBrowser1.TabIndex = 1
            Me.WebBrowser1.Visible = False
            '
            'flp_BusinessBtn
            '
            Me.flp_BusinessBtn.BackColor = System.Drawing.Color.White
            Me.flp_BusinessBtn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.flp_BusinessBtn.Location = New System.Drawing.Point(40, 139)
            Me.flp_BusinessBtn.Name = "flp_BusinessBtn"
            Me.flp_BusinessBtn.Size = New System.Drawing.Size(739, 302)
            Me.flp_BusinessBtn.TabIndex = 0
            '
            'lblApplication
            '
            Me.lblApplication.AutoSize = True
            Me.lblApplication.BackColor = System.Drawing.Color.White
            Me.lblApplication.Location = New System.Drawing.Point(112, 526)
            Me.lblApplication.Name = "lblApplication"
            Me.lblApplication.Size = New System.Drawing.Size(53, 12)
            Me.lblApplication.TabIndex = 2
            Me.lblApplication.Text = "버전정보"
            '
            'picZS
            '
            Me.picZS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.picZS.BackColor = System.Drawing.Color.White
            Me.picZS.Image = Global.My.Resources.Resources.settings
            Me.picZS.Location = New System.Drawing.Point(49, 518)
            Me.picZS.Name = "picZS"
            Me.picZS.Size = New System.Drawing.Size(48, 48)
            Me.picZS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picZS.TabIndex = 44
            Me.picZS.TabStop = False
            '
            'picClose
            '
            Me.picClose.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picClose.Image = Global.My.Resources.Resources.close
            Me.picClose.Location = New System.Drawing.Point(785, 6)
            Me.picClose.Name = "picClose"
            Me.picClose.Size = New System.Drawing.Size(11, 11)
            Me.picClose.TabIndex = 20
            Me.picClose.TabStop = False
            '
            'picMinimumSize
            '
            Me.picMinimumSize.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picMinimumSize.Image = Global.My.Resources.Resources.최소화_00
            Me.picMinimumSize.Location = New System.Drawing.Point(768, 6)
            Me.picMinimumSize.Name = "picMinimumSize"
            Me.picMinimumSize.Size = New System.Drawing.Size(11, 11)
            Me.picMinimumSize.TabIndex = 20
            Me.picMinimumSize.TabStop = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PictureBox1.Enabled = False
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(1155, 575)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(81, 26)
            Me.PictureBox1.TabIndex = 39
            Me.PictureBox1.TabStop = False
            Me.PictureBox1.Visible = False
            '
            'picMain
            '
            Me.picMain.BackColor = System.Drawing.Color.DarkMagenta
            Me.picMain.BackgroundImage = Global.My.Resources.Resources.BusinessSelect
            Me.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.picMain.Location = New System.Drawing.Point(0, 0)
            Me.picMain.Name = "picMain"
            Me.picMain.Size = New System.Drawing.Size(802, 602)
            Me.picMain.TabIndex = 18
            Me.picMain.TabStop = False
            '
            'picBG
            '
            Me.picBG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.picBG.BackColor = System.Drawing.Color.White
            Me.picBG.Image = Global.My.Resources.Resources.newspaper
            Me.picBG.Location = New System.Drawing.Point(49, 518)
            Me.picBG.Name = "picBG"
            Me.picBG.Size = New System.Drawing.Size(48, 48)
            Me.picBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picBG.TabIndex = 45
            Me.picBG.TabStop = False
            '
            'frmBusinessSelect
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(802, 602)
            Me.Controls.Add(Me.picZS)
            Me.Controls.Add(Me.picBG)
            Me.Controls.Add(Me.flp_BusinessBtn)
            Me.Controls.Add(Me.picClose)
            Me.Controls.Add(Me.lblApplication)
            Me.Controls.Add(Me.lblVersion)
            Me.Controls.Add(Me.picMinimumSize)
            Me.Controls.Add(Me.WebBrowser1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.picMain)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmBusinessSelect"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "업무 선택"
            Me.notifyMenuStripMain.ResumeLayout(False)
            CType(Me.picZS, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picMinimumSize, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBG, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents picClose As System.Windows.Forms.PictureBox
        Friend WithEvents notifyIconMain As System.Windows.Forms.NotifyIcon
        Friend WithEvents notifyMenuStripMain As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents spr1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents notiyMenuExit As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents picMinimumSize As System.Windows.Forms.PictureBox
        Friend WithEvents imgListSub As System.Windows.Forms.ImageList

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
        Friend WithEvents imgListMain As System.Windows.Forms.ImageList
        Friend WithEvents lblVersion As System.Windows.Forms.Label
        Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents picMain As System.Windows.Forms.PictureBox
        Friend WithEvents flp_BusinessBtn As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents picZS As PictureBox
        Friend WithEvents lblApplication As Label
        Friend WithEvents picBG As PictureBox
    End Class

End Namespace

