Namespace ubiLease.UI.BusinessUi.PR

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class PNE701
        Inherits CommonControls.UiControl

        'UserControl overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE701))
            Me.grd_1 = New ubiLease.GridControl.grd()
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox()
            Me.dtpYear = New ubiLease.CommonControls.dtp()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.popBasketCode = New ubiLease.CommonControls.pop()
            Me.txtCompanyHangulNm = New ubiLease.CommonControls.txt()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.dtpBeforeYear = New ubiLease.CommonControls.dtp()
            Me.dtpAfterYear = New ubiLease.CommonControls.dtp()
            Me.btnPlus = New System.Windows.Forms.Button()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.btnComDataReq = New System.Windows.Forms.Button()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(4, 126)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 509)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 3
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(4, 6)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 46)
            Me.picCriteria_1.TabIndex = 112
            Me.picCriteria_1.TabStop = False
            '
            'dtpYear
            '
            Me.dtpYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpYear.BorderStyle = 2
            Me.dtpYear.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpYear.CaptionName = ""
            Me.dtpYear.DateTimeFormatText = "yyyy"
            Me.dtpYear.Location = New System.Drawing.Point(80, 14)
            Me.dtpYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpYear.MaxLength = 0
            Me.dtpYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpYear.Name = "dtpYear"
            Me.dtpYear.ReadOnlys = False
            Me.dtpYear.SelectedText = ""
            Me.dtpYear.SelectionLength = 0
            Me.dtpYear.SelectionStart = 0
            Me.dtpYear.Size = New System.Drawing.Size(101, 20)
            Me.dtpYear.TabIndex = 913
            Me.dtpYear.Tag = "format(####);format(&&&&);"
            Me.dtpYear.TextAlign = 0
            Me.dtpYear.TextValue = ""
            Me.dtpYear.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(21, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(57, 12)
            Me.Label2.TabIndex = 912
            Me.Label2.Text = "관리 년도"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.Label1.Location = New System.Drawing.Point(187, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(69, 18)
            Me.Label1.TabIndex = 1628
            Me.Label1.Text = "바스켓 분류"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popBasketCode
            '
            Me.popBasketCode.BorderColor = System.Drawing.Color.Empty
            Me.popBasketCode.BorderStyle = 2
            Me.popBasketCode.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBasketCode.CaptionName = "바스켓코드"
            Me.popBasketCode.CodeText = ""
            Me.popBasketCode.CodeWidth = 70
            Me.popBasketCode.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.popBasketCode.Location = New System.Drawing.Point(262, 16)
            Me.popBasketCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.popBasketCode.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBasketCode.MaxLength = 6
            Me.popBasketCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popBasketCode.Name = "popBasketCode"
            Me.popBasketCode.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBasketCode.NameText = ""
            Me.popBasketCode.ReadOnlys = False
            Me.popBasketCode.SelectedText = ""
            Me.popBasketCode.SelectionLength = 0
            Me.popBasketCode.SelectionStart = 0
            Me.popBasketCode.Size = New System.Drawing.Size(131, 20)
            Me.popBasketCode.TabIndex = 1629
            Me.popBasketCode.Tag = "code(바스켓코드);"
            Me.popBasketCode.TextAlign = 0
            Me.popBasketCode.TextValue = ""
            Me.popBasketCode.ToolTipText = ""
            '
            'txtCompanyHangulNm
            '
            Me.txtCompanyHangulNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtCompanyHangulNm.BaseBackColor = System.Drawing.Color.White
            Me.txtCompanyHangulNm.BorderColor = System.Drawing.Color.Empty
            Me.txtCompanyHangulNm.BorderStyle = 2
            Me.txtCompanyHangulNm.CaptionName = Nothing
            Me.txtCompanyHangulNm.Location = New System.Drawing.Point(461, 16)
            Me.txtCompanyHangulNm.MaxLength = 20
            Me.txtCompanyHangulNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCompanyHangulNm.Multiline = False
            Me.txtCompanyHangulNm.Name = "txtCompanyHangulNm"
            Me.txtCompanyHangulNm.ReadOnlys = False
            Me.txtCompanyHangulNm.SelectedText = ""
            Me.txtCompanyHangulNm.SelectionLength = 0
            Me.txtCompanyHangulNm.SelectionStart = 0
            Me.txtCompanyHangulNm.Size = New System.Drawing.Size(134, 20)
            Me.txtCompanyHangulNm.TabIndex = 1630
            Me.txtCompanyHangulNm.Tag = Nothing
            Me.txtCompanyHangulNm.TextAlign = 0
            Me.txtCompanyHangulNm.TextValue = ""
            Me.txtCompanyHangulNm.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.Label3.Location = New System.Drawing.Point(399, 15)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(56, 16)
            Me.Label3.TabIndex = 1631
            Me.Label3.Text = "확장처명"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(3, 58)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(799, 62)
            Me.PictureBox1.TabIndex = 1632
            Me.PictureBox1.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Gainsboro
            Me.Label4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label4.Location = New System.Drawing.Point(20, 69)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(75, 12)
            Me.Label4.TabIndex = 1633
            Me.Label4.Text = "데이터 이월"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Gainsboro
            Me.Label5.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.Label5.Location = New System.Drawing.Point(101, 69)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(329, 12)
            Me.Label5.TabIndex = 1634
            Me.Label5.Text = "※주의: 이월받을 연도에 데이터 존재 시 이월되지 않습니다."
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpBeforeYear
            '
            Me.dtpBeforeYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBeforeYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpBeforeYear.BorderStyle = 2
            Me.dtpBeforeYear.ButtonBackColor = System.Drawing.Color.Gainsboro
            Me.dtpBeforeYear.CaptionName = ""
            Me.dtpBeforeYear.DateTimeFormatText = "yyyy"
            Me.dtpBeforeYear.Location = New System.Drawing.Point(80, 90)
            Me.dtpBeforeYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBeforeYear.MaxLength = 0
            Me.dtpBeforeYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBeforeYear.Name = "dtpBeforeYear"
            Me.dtpBeforeYear.ReadOnlys = False
            Me.dtpBeforeYear.SelectedText = ""
            Me.dtpBeforeYear.SelectionLength = 0
            Me.dtpBeforeYear.SelectionStart = 0
            Me.dtpBeforeYear.Size = New System.Drawing.Size(101, 20)
            Me.dtpBeforeYear.TabIndex = 1635
            Me.dtpBeforeYear.Tag = "format(####);format(&&&&);"
            Me.dtpBeforeYear.TextAlign = 0
            Me.dtpBeforeYear.TextValue = ""
            Me.dtpBeforeYear.ToolTipText = ""
            '
            'dtpAfterYear
            '
            Me.dtpAfterYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpAfterYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpAfterYear.BorderStyle = 2
            Me.dtpAfterYear.ButtonBackColor = System.Drawing.Color.Gainsboro
            Me.dtpAfterYear.CaptionName = ""
            Me.dtpAfterYear.DateTimeFormatText = "yyyy"
            Me.dtpAfterYear.Location = New System.Drawing.Point(249, 90)
            Me.dtpAfterYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpAfterYear.MaxLength = 0
            Me.dtpAfterYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpAfterYear.Name = "dtpAfterYear"
            Me.dtpAfterYear.ReadOnlys = False
            Me.dtpAfterYear.SelectedText = ""
            Me.dtpAfterYear.SelectionLength = 0
            Me.dtpAfterYear.SelectionStart = 0
            Me.dtpAfterYear.Size = New System.Drawing.Size(101, 20)
            Me.dtpAfterYear.TabIndex = 1636
            Me.dtpAfterYear.Tag = "format(####);format(&&&&);"
            Me.dtpAfterYear.TextAlign = 0
            Me.dtpAfterYear.TextValue = ""
            Me.dtpAfterYear.ToolTipText = ""
            '
            'btnPlus
            '
            Me.btnPlus.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.btnPlus.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPlus.Location = New System.Drawing.Point(533, 79)
            Me.btnPlus.Name = "btnPlus"
            Me.btnPlus.Size = New System.Drawing.Size(71, 27)
            Me.btnPlus.TabIndex = 1637
            Me.btnPlus.Text = "이월"
            Me.btnPlus.UseVisualStyleBackColor = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Gainsboro
            Me.Label6.Font = New System.Drawing.Font("돋움", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label6.Location = New System.Drawing.Point(204, 94)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(21, 15)
            Me.Label6.TabIndex = 1638
            Me.Label6.Text = "→"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'btnComDataReq
            '
            Me.btnComDataReq.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.btnComDataReq.Location = New System.Drawing.Point(635, 9)
            Me.btnComDataReq.Name = "btnComDataReq"
            Me.btnComDataReq.Size = New System.Drawing.Size(117, 39)
            Me.btnComDataReq.TabIndex = 1639
            Me.btnComDataReq.Text = "확장처 코드 이전"
            Me.btnComDataReq.UseVisualStyleBackColor = True
            '
            'PNE701
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.btnComDataReq)
            Me.Controls.Add(Me.btnPlus)
            Me.Controls.Add(Me.dtpAfterYear)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpBeforeYear)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtCompanyHangulNm)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.popBasketCode)
            Me.Controls.Add(Me.dtpYear)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNE701"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.dtpYear, 0)
            Me.Controls.SetChildIndex(Me.popBasketCode, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.txtCompanyHangulNm, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.dtpBeforeYear, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.dtpAfterYear, 0)
            Me.Controls.SetChildIndex(Me.btnPlus, 0)
            Me.Controls.SetChildIndex(Me.btnComDataReq, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpYear As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents popBasketCode As CommonControls.pop
        Friend WithEvents txtCompanyHangulNm As CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpBeforeYear As CommonControls.dtp
        Friend WithEvents dtpAfterYear As CommonControls.dtp
        Friend WithEvents btnPlus As System.Windows.Forms.Button
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents btnComDataReq As System.Windows.Forms.Button
    End Class

End Namespace
