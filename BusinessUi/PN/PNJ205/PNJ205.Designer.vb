Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNJ205
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNJ205))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.popCouponCorpCd = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpRedeemDt = New ubiLease.CommonControls.dtp
            Me.Label5 = New System.Windows.Forms.Label
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.Label33 = New System.Windows.Forms.Label
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optMode3 = New System.Windows.Forms.RadioButton
            Me.optMode2 = New System.Windows.Forms.RadioButton
            Me.optMode1 = New System.Windows.Forms.RadioButton
            Me.Label1 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.Opt1 = New ubiLease.CommonControls.opt
            Me.optExpAmt3 = New System.Windows.Forms.RadioButton
            Me.optExpAmt1 = New System.Windows.Forms.RadioButton
            Me.optExpAmt2 = New System.Windows.Forms.RadioButton
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt1.SuspendLayout()
            Me.SuspendLayout()
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 4)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(801, 67)
            Me.picCriteria.TabIndex = 1561
            Me.picCriteria.TabStop = False
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_1.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_1.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 109)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 534)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1560
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'popCouponCorpCd
            '
            Me.popCouponCorpCd.BorderColor = System.Drawing.Color.Empty
            Me.popCouponCorpCd.BorderStyle = 2
            Me.popCouponCorpCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCouponCorpCd.CaptionName = "소속사코드"
            Me.popCouponCorpCd.CodeText = ""
            Me.popCouponCorpCd.CodeWidth = 60
            Me.popCouponCorpCd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popCouponCorpCd.Location = New System.Drawing.Point(413, 42)
            Me.popCouponCorpCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCouponCorpCd.MaxLength = 4
            Me.popCouponCorpCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCouponCorpCd.Name = "popCouponCorpCd"
            Me.popCouponCorpCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCouponCorpCd.NameText = ""
            Me.popCouponCorpCd.ReadOnlys = False
            Me.popCouponCorpCd.SelectedText = ""
            Me.popCouponCorpCd.SelectionLength = 0
            Me.popCouponCorpCd.SelectionStart = 0
            Me.popCouponCorpCd.Size = New System.Drawing.Size(252, 20)
            Me.popCouponCorpCd.TabIndex = 1575
            Me.popCouponCorpCd.Tag = "code(소속사 명);"
            Me.popCouponCorpCd.TextAlign = 0
            Me.popCouponCorpCd.TextValue = ""
            Me.popCouponCorpCd.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(363, 43)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 18)
            Me.Label2.TabIndex = 1576
            Me.Label2.Text = "소속사"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpRedeemDt
            '
            Me.dtpRedeemDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpRedeemDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpRedeemDt.BorderStyle = 2
            Me.dtpRedeemDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpRedeemDt.CaptionName = "회수 년월"
            Me.dtpRedeemDt.DateTimeFormatText = "yyyy-MM"
            Me.dtpRedeemDt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpRedeemDt.Location = New System.Drawing.Point(98, 15)
            Me.dtpRedeemDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpRedeemDt.MaxLength = 0
            Me.dtpRedeemDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpRedeemDt.Name = "dtpRedeemDt"
            Me.dtpRedeemDt.ReadOnlys = False
            Me.dtpRedeemDt.SelectedText = ""
            Me.dtpRedeemDt.SelectionLength = 0
            Me.dtpRedeemDt.SelectionStart = 0
            Me.dtpRedeemDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpRedeemDt.TabIndex = 1615
            Me.dtpRedeemDt.Tag = "format(&&&&-&&);"
            Me.dtpRedeemDt.TextAlign = 0
            Me.dtpRedeemDt.TextValue = ""
            Me.dtpRedeemDt.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(28, 18)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(64, 15)
            Me.Label5.TabIndex = 1616
            Me.Label5.Text = "회수 년월"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "담당자"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 60
            Me.popEmployeeNumber.Location = New System.Drawing.Point(98, 42)
            Me.popEmployeeNumber.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEmployeeNumber.MaxLength = 32767
            Me.popEmployeeNumber.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeNumber.Name = "popEmployeeNumber"
            Me.popEmployeeNumber.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeNumber.NameText = ""
            Me.popEmployeeNumber.ReadOnlys = False
            Me.popEmployeeNumber.SelectedText = ""
            Me.popEmployeeNumber.SelectionLength = 0
            Me.popEmployeeNumber.SelectionStart = 0
            Me.popEmployeeNumber.Size = New System.Drawing.Size(233, 20)
            Me.popEmployeeNumber.TabIndex = 1617
            Me.popEmployeeNumber.Tag = "code(영업사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label33.Location = New System.Drawing.Point(28, 45)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(65, 15)
            Me.Label33.TabIndex = 1618
            Me.Label33.Text = "담당자"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optMode3)
            Me.Opt2.Controls.Add(Me.optMode2)
            Me.Opt2.Controls.Add(Me.optMode1)
            Me.Opt2.Location = New System.Drawing.Point(363, 11)
            Me.Opt2.MaximumSize = New System.Drawing.Size(500, 200)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(302, 25)
            Me.Opt2.TabIndex = 1619
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optMode3
            '
            Me.optMode3.AutoSize = True
            Me.optMode3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optMode3.Location = New System.Drawing.Point(179, 5)
            Me.optMode3.Name = "optMode3"
            Me.optMode3.Size = New System.Drawing.Size(113, 16)
            Me.optMode3.TabIndex = 2
            Me.optMode3.Text = "지국별/소속사별"
            Me.optMode3.UseVisualStyleBackColor = False
            '
            'optMode2
            '
            Me.optMode2.AutoSize = True
            Me.optMode2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optMode2.Location = New System.Drawing.Point(100, 5)
            Me.optMode2.Name = "optMode2"
            Me.optMode2.Size = New System.Drawing.Size(59, 16)
            Me.optMode2.TabIndex = 1
            Me.optMode2.Text = "지국별"
            Me.optMode2.UseVisualStyleBackColor = False
            '
            'optMode1
            '
            Me.optMode1.AutoSize = True
            Me.optMode1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optMode1.Checked = True
            Me.optMode1.Location = New System.Drawing.Point(12, 5)
            Me.optMode1.Name = "optMode1"
            Me.optMode1.Size = New System.Drawing.Size(71, 16)
            Me.optMode1.TabIndex = 0
            Me.optMode1.TabStop = True
            Me.optMode1.Text = "소속사별"
            Me.optMode1.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label1.Location = New System.Drawing.Point(387, 79)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(412, 24)
            Me.Label1.TabIndex = 1674
            Me.Label1.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(363, 74)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(443, 32)
            Me.PictureBox1.TabIndex = 1675
            Me.PictureBox1.TabStop = False
            '
            'Opt1
            '
            Me.Opt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt1.CaptionName = Nothing
            Me.Opt1.Controls.Add(Me.optExpAmt1)
            Me.Opt1.Controls.Add(Me.optExpAmt2)
            Me.Opt1.Location = New System.Drawing.Point(5, 74)
            Me.Opt1.MaximumSize = New System.Drawing.Size(1000, 100)
            Me.Opt1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt1.Name = "Opt1"
            Me.Opt1.ReadOnlys = False
            Me.Opt1.Size = New System.Drawing.Size(354, 32)
            Me.Opt1.TabIndex = 1673
            Me.Opt1.Tag = Nothing
            Me.Opt1.TextValue = ""
            '
            'optExpAmt3
            '
            Me.optExpAmt3.AutoSize = True
            Me.optExpAmt3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt3.Location = New System.Drawing.Point(600, 52)
            Me.optExpAmt3.Name = "optExpAmt3"
            Me.optExpAmt3.Size = New System.Drawing.Size(199, 16)
            Me.optExpAmt3.TabIndex = 344
            Me.optExpAmt3.Text = "지국별 구독권 회수 및 지급 현황"
            Me.optExpAmt3.UseVisualStyleBackColor = False
            Me.optExpAmt3.Visible = False
            '
            'optExpAmt1
            '
            Me.optExpAmt1.AutoSize = True
            Me.optExpAmt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt1.Checked = True
            Me.optExpAmt1.Location = New System.Drawing.Point(22, 9)
            Me.optExpAmt1.Name = "optExpAmt1"
            Me.optExpAmt1.Size = New System.Drawing.Size(135, 16)
            Me.optExpAmt1.TabIndex = 342
            Me.optExpAmt1.TabStop = True
            Me.optExpAmt1.Text = "구독권 송금내역현황"
            Me.optExpAmt1.UseVisualStyleBackColor = False
            '
            'optExpAmt2
            '
            Me.optExpAmt2.AutoSize = True
            Me.optExpAmt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt2.Location = New System.Drawing.Point(177, 9)
            Me.optExpAmt2.Name = "optExpAmt2"
            Me.optExpAmt2.Size = New System.Drawing.Size(167, 16)
            Me.optExpAmt2.TabIndex = 343
            Me.optExpAmt2.Text = "구독권 회수 및 지급총괄표"
            Me.optExpAmt2.UseVisualStyleBackColor = False
            '
            'PNJ205
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.optExpAmt3)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Opt1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.Label33)
            Me.Controls.Add(Me.dtpRedeemDt)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.popCouponCorpCd)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNJ205"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.popCouponCorpCd, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.dtpRedeemDt, 0)
            Me.Controls.SetChildIndex(Me.Label33, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeNumber, 0)
            Me.Controls.SetChildIndex(Me.Opt2, 0)
            Me.Controls.SetChildIndex(Me.Opt1, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.optExpAmt3, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt1.ResumeLayout(False)
            Me.Opt1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents popCouponCorpCd As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpRedeemDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optMode3 As System.Windows.Forms.RadioButton
        Friend WithEvents optMode2 As System.Windows.Forms.RadioButton
        Friend WithEvents optMode1 As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents Opt1 As ubiLease.CommonControls.opt
        Friend WithEvents optExpAmt3 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt1 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt2 As System.Windows.Forms.RadioButton


    End Class

End Namespace
