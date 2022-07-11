Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI311
        Inherits CommonControls.UiControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.picIo_1 = New System.Windows.Forms.PictureBox
            Me.dtpYYYYMM = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.btnExec1 = New System.Windows.Forms.Button
            Me.chkExp11 = New ubiLease.CommonControls.chk
            Me.chkExp32 = New ubiLease.CommonControls.chk
            Me.chkExp21 = New ubiLease.CommonControls.chk
            Me.chkExp31 = New ubiLease.CommonControls.chk
            Me.chkExp33 = New ubiLease.CommonControls.chk
            Me.chkExp34 = New ubiLease.CommonControls.chk
            Me.chkExp41 = New ubiLease.CommonControls.chk
            Me.dtpTransferDt1 = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpTransferDt2 = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.btnExec2 = New System.Windows.Forms.Button
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picIo_1
            '
            Me.picIo_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_1.Location = New System.Drawing.Point(4, 4)
            Me.picIo_1.Name = "picIo_1"
            Me.picIo_1.Size = New System.Drawing.Size(765, 572)
            Me.picIo_1.TabIndex = 2
            Me.picIo_1.TabStop = False
            '
            'dtpYYYYMM
            '
            Me.dtpYYYYMM.BackColor = System.Drawing.SystemColors.Window
            Me.dtpYYYYMM.BorderColor = System.Drawing.Color.Empty
            Me.dtpYYYYMM.BorderStyle = 2
            Me.dtpYYYYMM.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpYYYYMM.CaptionName = "지대 년월"
            Me.dtpYYYYMM.DateTimeFormatText = "yyyy-MM"
            Me.dtpYYYYMM.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpYYYYMM.Location = New System.Drawing.Point(368, 273)
            Me.dtpYYYYMM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpYYYYMM.MaxLength = 0
            Me.dtpYYYYMM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpYYYYMM.Name = "dtpYYYYMM"
            Me.dtpYYYYMM.ReadOnlys = False
            Me.dtpYYYYMM.SelectedText = ""
            Me.dtpYYYYMM.SelectionLength = 0
            Me.dtpYYYYMM.SelectionStart = 0
            Me.dtpYYYYMM.Size = New System.Drawing.Size(100, 20)
            Me.dtpYYYYMM.TabIndex = 0
            Me.dtpYYYYMM.Tag = "format(&&&&-&&);"
            Me.dtpYYYYMM.TextAlign = 0
            Me.dtpYYYYMM.TextValue = ""
            Me.dtpYYYYMM.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(298, 276)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(64, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 14
            Me.lblCodeDivisionHangulName.Text = "지대 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'btnExec1
            '
            Me.btnExec1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnExec1.Location = New System.Drawing.Point(300, 355)
            Me.btnExec1.Name = "btnExec1"
            Me.btnExec1.Size = New System.Drawing.Size(80, 48)
            Me.btnExec1.TabIndex = 3
            Me.btnExec1.Text = "대체 처리"
            Me.btnExec1.UseVisualStyleBackColor = False
            '
            'chkExp11
            '
            Me.chkExp11.BackColor = System.Drawing.Color.GhostWhite
            Me.chkExp11.CaptionName = "본사수금구독료 대체 여부"
            Me.chkExp11.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp11.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkExp11.Location = New System.Drawing.Point(218, 128)
            Me.chkExp11.Name = "chkExp11"
            Me.chkExp11.ReadOnlys = False
            Me.chkExp11.Size = New System.Drawing.Size(145, 17)
            Me.chkExp11.TabIndex = 5
            Me.chkExp11.Tag = ""
            Me.chkExp11.Text = "본사수금구독료 대체"
            Me.chkExp11.TextValue = "0"
            Me.chkExp11.UseVisualStyleBackColor = False
            '
            'chkExp32
            '
            Me.chkExp32.BackColor = System.Drawing.Color.GhostWhite
            Me.chkExp32.CaptionName = "조직지원비 대체 여부"
            Me.chkExp32.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp32.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkExp32.Location = New System.Drawing.Point(405, 151)
            Me.chkExp32.Name = "chkExp32"
            Me.chkExp32.ReadOnlys = False
            Me.chkExp32.Size = New System.Drawing.Size(145, 17)
            Me.chkExp32.TabIndex = 9
            Me.chkExp32.Tag = ""
            Me.chkExp32.Text = "조직지원비 대체"
            Me.chkExp32.TextValue = "0"
            Me.chkExp32.UseVisualStyleBackColor = False
            '
            'chkExp21
            '
            Me.chkExp21.BackColor = System.Drawing.Color.GhostWhite
            Me.chkExp21.CaptionName = "지국확장비 대체 여부"
            Me.chkExp21.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp21.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkExp21.Location = New System.Drawing.Point(218, 151)
            Me.chkExp21.Name = "chkExp21"
            Me.chkExp21.ReadOnlys = False
            Me.chkExp21.Size = New System.Drawing.Size(145, 17)
            Me.chkExp21.TabIndex = 6
            Me.chkExp21.Tag = ""
            Me.chkExp21.Text = "지국확장비 대체"
            Me.chkExp21.TextValue = "0"
            Me.chkExp21.UseVisualStyleBackColor = False
            '
            'chkExp31
            '
            Me.chkExp31.BackColor = System.Drawing.Color.GhostWhite
            Me.chkExp31.CaptionName = "목표지원비 대체 여부"
            Me.chkExp31.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp31.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkExp31.Location = New System.Drawing.Point(405, 128)
            Me.chkExp31.Name = "chkExp31"
            Me.chkExp31.ReadOnlys = False
            Me.chkExp31.Size = New System.Drawing.Size(145, 17)
            Me.chkExp31.TabIndex = 8
            Me.chkExp31.Tag = ""
            Me.chkExp31.Text = "목표지원비 대체"
            Me.chkExp31.TextValue = "0"
            Me.chkExp31.UseVisualStyleBackColor = False
            '
            'chkExp33
            '
            Me.chkExp33.BackColor = System.Drawing.Color.GhostWhite
            Me.chkExp33.CaptionName = "기증지 대체 여부"
            Me.chkExp33.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp33.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkExp33.Location = New System.Drawing.Point(405, 174)
            Me.chkExp33.Name = "chkExp33"
            Me.chkExp33.ReadOnlys = False
            Me.chkExp33.Size = New System.Drawing.Size(145, 17)
            Me.chkExp33.TabIndex = 10
            Me.chkExp33.Tag = ""
            Me.chkExp33.Text = "기증지 대체"
            Me.chkExp33.TextValue = "0"
            Me.chkExp33.UseVisualStyleBackColor = False
            '
            'chkExp34
            '
            Me.chkExp34.BackColor = System.Drawing.Color.GhostWhite
            Me.chkExp34.CaptionName = "이사독자 대체 여부"
            Me.chkExp34.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp34.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkExp34.Location = New System.Drawing.Point(405, 197)
            Me.chkExp34.Name = "chkExp34"
            Me.chkExp34.ReadOnlys = False
            Me.chkExp34.Size = New System.Drawing.Size(145, 17)
            Me.chkExp34.TabIndex = 11
            Me.chkExp34.Tag = ""
            Me.chkExp34.Text = "이사독자 대체"
            Me.chkExp34.TextValue = "0"
            Me.chkExp34.UseVisualStyleBackColor = False
            '
            'chkExp41
            '
            Me.chkExp41.BackColor = System.Drawing.Color.GhostWhite
            Me.chkExp41.CaptionName = "배달확인증 대체 여부"
            Me.chkExp41.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkExp41.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkExp41.Location = New System.Drawing.Point(218, 197)
            Me.chkExp41.Name = "chkExp41"
            Me.chkExp41.ReadOnlys = False
            Me.chkExp41.Size = New System.Drawing.Size(145, 17)
            Me.chkExp41.TabIndex = 7
            Me.chkExp41.Tag = ""
            Me.chkExp41.Text = "배달확인증 대체"
            Me.chkExp41.TextValue = "0"
            Me.chkExp41.UseVisualStyleBackColor = False
            '
            'dtpTransferDt1
            '
            Me.dtpTransferDt1.BackColor = System.Drawing.SystemColors.Window
            Me.dtpTransferDt1.BorderColor = System.Drawing.Color.Empty
            Me.dtpTransferDt1.BorderStyle = 2
            Me.dtpTransferDt1.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpTransferDt1.CaptionName = "대체 일자2"
            Me.dtpTransferDt1.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpTransferDt1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpTransferDt1.Location = New System.Drawing.Point(368, 299)
            Me.dtpTransferDt1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpTransferDt1.MaxLength = 0
            Me.dtpTransferDt1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpTransferDt1.Name = "dtpTransferDt1"
            Me.dtpTransferDt1.ReadOnlys = False
            Me.dtpTransferDt1.SelectedText = ""
            Me.dtpTransferDt1.SelectionLength = 0
            Me.dtpTransferDt1.SelectionStart = 0
            Me.dtpTransferDt1.Size = New System.Drawing.Size(100, 20)
            Me.dtpTransferDt1.TabIndex = 1
            Me.dtpTransferDt1.Tag = "format(&&&&-&&-&&);"
            Me.dtpTransferDt1.TextAlign = 0
            Me.dtpTransferDt1.TextValue = ""
            Me.dtpTransferDt1.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(298, 302)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 15)
            Me.Label1.TabIndex = 15
            Me.Label1.Text = "대체 일자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpTransferDt2
            '
            Me.dtpTransferDt2.BackColor = System.Drawing.SystemColors.Window
            Me.dtpTransferDt2.BorderColor = System.Drawing.Color.Empty
            Me.dtpTransferDt2.BorderStyle = 2
            Me.dtpTransferDt2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpTransferDt2.CaptionName = "대체 일자2"
            Me.dtpTransferDt2.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpTransferDt2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpTransferDt2.Location = New System.Drawing.Point(368, 325)
            Me.dtpTransferDt2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpTransferDt2.MaxLength = 0
            Me.dtpTransferDt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpTransferDt2.Name = "dtpTransferDt2"
            Me.dtpTransferDt2.ReadOnlys = False
            Me.dtpTransferDt2.SelectedText = ""
            Me.dtpTransferDt2.SelectionLength = 0
            Me.dtpTransferDt2.SelectionStart = 0
            Me.dtpTransferDt2.Size = New System.Drawing.Size(100, 20)
            Me.dtpTransferDt2.TabIndex = 2
            Me.dtpTransferDt2.Tag = "format(&&&&-&&-&&);"
            Me.dtpTransferDt2.TextAlign = 0
            Me.dtpTransferDt2.TextValue = ""
            Me.dtpTransferDt2.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(343, 328)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(19, 15)
            Me.Label2.TabIndex = 16
            Me.Label2.Text = "~"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(287, 248)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(194, 15)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "================================================"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(287, 413)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(194, 15)
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "================================================"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'btnExec2
            '
            Me.btnExec2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnExec2.Location = New System.Drawing.Point(387, 355)
            Me.btnExec2.Name = "btnExec2"
            Me.btnExec2.Size = New System.Drawing.Size(80, 48)
            Me.btnExec2.TabIndex = 4
            Me.btnExec2.Text = "대체 취소"
            Me.btnExec2.UseVisualStyleBackColor = False
            '
            'PNI311
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.btnExec2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpTransferDt2)
            Me.Controls.Add(Me.dtpTransferDt1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.chkExp41)
            Me.Controls.Add(Me.chkExp33)
            Me.Controls.Add(Me.chkExp34)
            Me.Controls.Add(Me.chkExp31)
            Me.Controls.Add(Me.chkExp21)
            Me.Controls.Add(Me.chkExp32)
            Me.Controls.Add(Me.chkExp11)
            Me.Controls.Add(Me.btnExec1)
            Me.Controls.Add(Me.dtpYYYYMM)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picIo_1)
            Me.Name = "PNI311"
            Me.Size = New System.Drawing.Size(772, 579)
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picIo_1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpYYYYMM As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents btnExec1 As System.Windows.Forms.Button
        Friend WithEvents chkExp11 As ubiLease.CommonControls.chk
        Friend WithEvents chkExp32 As ubiLease.CommonControls.chk
        Friend WithEvents chkExp21 As ubiLease.CommonControls.chk
        Friend WithEvents chkExp31 As ubiLease.CommonControls.chk
        Friend WithEvents chkExp33 As ubiLease.CommonControls.chk
        Friend WithEvents chkExp34 As ubiLease.CommonControls.chk
        Friend WithEvents chkExp41 As ubiLease.CommonControls.chk
        Friend WithEvents dtpTransferDt1 As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpTransferDt2 As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnExec2 As System.Windows.Forms.Button

    End Class

End Namespace
