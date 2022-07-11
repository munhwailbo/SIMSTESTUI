Namespace ubiLease.CommonPopup


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmOrganization
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrganization))
            Me.pic1 = New System.Windows.Forms.PictureBox
            Me.txtName = New ubiLease.CommonControls.txt
            Me.txtCode = New ubiLease.CommonControls.txt
            Me.lblName = New System.Windows.Forms.Label
            Me.lblCode = New System.Windows.Forms.Label
            Me.trv1 = New System.Windows.Forms.TreeView
            Me.btnYes = New ubiLease.CommonControls.btn
            Me.btnNo = New ubiLease.CommonControls.btn
            Me.pnlMain = New System.Windows.Forms.Panel
            CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlMain.SuspendLayout()
            Me.SuspendLayout()
            '
            'pic1
            '
            Me.pic1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pic1.Location = New System.Drawing.Point(12, 12)
            Me.pic1.Name = "pic1"
            Me.pic1.Size = New System.Drawing.Size(608, 44)
            Me.pic1.TabIndex = 9
            Me.pic1.TabStop = False
            '
            'txtName
            '
            Me.txtName.BackColor = System.Drawing.SystemColors.Window
            Me.txtName.BorderColor = System.Drawing.Color.Empty
            Me.txtName.BorderStyle = 2
            Me.txtName.CaptionName = Nothing
            Me.txtName.Location = New System.Drawing.Point(258, 22)
            Me.txtName.MaxLength = 32767
            Me.txtName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtName.Multiline = False
            Me.txtName.Name = "txtName"
            Me.txtName.ReadOnlys = False
            Me.txtName.SelectedText = ""
            Me.txtName.SelectionLength = 0
            Me.txtName.SelectionStart = 0
            Me.txtName.Size = New System.Drawing.Size(227, 20)
            Me.txtName.TabIndex = 15
            Me.txtName.Tag = Nothing
            Me.txtName.TextAlign = 0
            Me.txtName.TextValue = ""
            Me.txtName.ToolTipText = ""
            '
            'txtCode
            '
            Me.txtCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtCode.BorderColor = System.Drawing.Color.Empty
            Me.txtCode.BorderStyle = 2
            Me.txtCode.CaptionName = Nothing
            Me.txtCode.Location = New System.Drawing.Point(97, 22)
            Me.txtCode.MaxLength = 32767
            Me.txtCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCode.Multiline = False
            Me.txtCode.Name = "txtCode"
            Me.txtCode.ReadOnlys = False
            Me.txtCode.SelectedText = ""
            Me.txtCode.SelectionLength = 0
            Me.txtCode.SelectionStart = 0
            Me.txtCode.Size = New System.Drawing.Size(86, 20)
            Me.txtCode.TabIndex = 12
            Me.txtCode.Tag = Nothing
            Me.txtCode.TextAlign = 0
            Me.txtCode.TextValue = ""
            Me.txtCode.ToolTipText = ""
            '
            'lblName
            '
            Me.lblName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblName.Location = New System.Drawing.Point(189, 27)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(63, 15)
            Me.lblName.TabIndex = 14
            Me.lblName.Text = "조직명"
            Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblCode
            '
            Me.lblCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCode.Location = New System.Drawing.Point(26, 27)
            Me.lblCode.Name = "lblCode"
            Me.lblCode.Size = New System.Drawing.Size(65, 15)
            Me.lblCode.TabIndex = 13
            Me.lblCode.Text = "조직코드"
            Me.lblCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'trv1
            '
            Me.trv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.trv1.Location = New System.Drawing.Point(12, 62)
            Me.trv1.Name = "trv1"
            Me.trv1.Size = New System.Drawing.Size(608, 376)
            Me.trv1.TabIndex = 17
            '
            'btnYes
            '
            Me.btnYes.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnYes.Location = New System.Drawing.Point(491, 443)
            Me.btnYes.Name = "btnYes"
            Me.btnYes.Size = New System.Drawing.Size(61, 19)
            Me.btnYes.TabIndex = 18
            Me.btnYes.Text = "확인"
            Me.btnYes.UseVisualStyleBackColor = False
            '
            'btnNo
            '
            Me.btnNo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNo.Location = New System.Drawing.Point(558, 443)
            Me.btnNo.Name = "btnNo"
            Me.btnNo.Size = New System.Drawing.Size(61, 19)
            Me.btnNo.TabIndex = 19
            Me.btnNo.Text = "취소"
            Me.btnNo.UseVisualStyleBackColor = False
            '
            'pnlMain
            '
            Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlMain.Controls.Add(Me.btnNo)
            Me.pnlMain.Controls.Add(Me.btnYes)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 0)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Size = New System.Drawing.Size(630, 497)
            Me.pnlMain.TabIndex = 20
            '
            'frmOrganization
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.GhostWhite
            Me.ClientSize = New System.Drawing.Size(630, 497)
            Me.ControlBox = False
            Me.Controls.Add(Me.trv1)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.txtCode)
            Me.Controls.Add(Me.lblName)
            Me.Controls.Add(Me.lblCode)
            Me.Controls.Add(Me.pic1)
            Me.Controls.Add(Me.pnlMain)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmOrganization"
            Me.ShowInTaskbar = False
            Me.Text = "조직 코드 조회"
            CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlMain.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pic1 As System.Windows.Forms.PictureBox
        Friend WithEvents txtName As ubiLease.CommonControls.txt
        Friend WithEvents txtCode As ubiLease.CommonControls.txt
        Friend WithEvents lblName As System.Windows.Forms.Label
        Friend WithEvents lblCode As System.Windows.Forms.Label
        Friend WithEvents trv1 As System.Windows.Forms.TreeView
        Friend WithEvents btnYes As ubiLease.CommonControls.btn
        Friend WithEvents btnNo As ubiLease.CommonControls.btn
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
    End Class
End Namespace
