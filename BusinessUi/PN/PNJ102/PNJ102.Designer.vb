Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNJ102
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNJ102))
            Me.dtpBaseYear = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpBaseYear2 = New ubiLease.CommonControls.dtp
            Me.popCouponCorpCd = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.numPublishStNum_R = New ubiLease.CommonControls.num
            Me.numPublishEdNum_R = New ubiLease.CommonControls.num
            Me.Label5 = New System.Windows.Forms.Label
            Me.numOrders_R = New ubiLease.CommonControls.num
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpBaseYear
            '
            Me.dtpBaseYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYear.BorderStyle = 2
            Me.dtpBaseYear.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYear.CaptionName = "발행시작년월"
            Me.dtpBaseYear.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseYear.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYear.Location = New System.Drawing.Point(134, 43)
            Me.dtpBaseYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYear.MaxLength = 0
            Me.dtpBaseYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYear.Name = "dtpBaseYear"
            Me.dtpBaseYear.ReadOnlys = False
            Me.dtpBaseYear.SelectedText = ""
            Me.dtpBaseYear.SelectionLength = 0
            Me.dtpBaseYear.SelectionStart = 0
            Me.dtpBaseYear.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYear.TabIndex = 20
            Me.dtpBaseYear.Tag = "format(&&&&-&&);"
            Me.dtpBaseYear.TextAlign = 0
            Me.dtpBaseYear.TextValue = ""
            Me.dtpBaseYear.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(45, 46)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(82, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 17
            Me.lblCodeDivisionHangulName.Text = "발행 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(6, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(801, 71)
            Me.picCriteria_1.TabIndex = 18
            Me.picCriteria_1.TabStop = False
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
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 81)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 562)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 19
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(239, 45)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(21, 17)
            Me.Label1.TabIndex = 21
            Me.Label1.Text = "~"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dtpBaseYear2
            '
            Me.dtpBaseYear2.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYear2.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYear2.BorderStyle = 2
            Me.dtpBaseYear2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYear2.CaptionName = "발행종료년월"
            Me.dtpBaseYear2.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseYear2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYear2.Location = New System.Drawing.Point(266, 43)
            Me.dtpBaseYear2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYear2.MaxLength = 0
            Me.dtpBaseYear2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYear2.Name = "dtpBaseYear2"
            Me.dtpBaseYear2.ReadOnlys = False
            Me.dtpBaseYear2.SelectedText = ""
            Me.dtpBaseYear2.SelectionLength = 0
            Me.dtpBaseYear2.SelectionStart = 0
            Me.dtpBaseYear2.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYear2.TabIndex = 22
            Me.dtpBaseYear2.Tag = "format(&&&&-&&);"
            Me.dtpBaseYear2.TextAlign = 0
            Me.dtpBaseYear2.TextValue = ""
            Me.dtpBaseYear2.ToolTipText = ""
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
            Me.popCouponCorpCd.Location = New System.Drawing.Point(134, 19)
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
            Me.popCouponCorpCd.Size = New System.Drawing.Size(231, 20)
            Me.popCouponCorpCd.TabIndex = 31
            Me.popCouponCorpCd.Tag = "code(소속사 명);"
            Me.popCouponCorpCd.TextAlign = 0
            Me.popCouponCorpCd.TextValue = ""
            Me.popCouponCorpCd.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(45, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(82, 18)
            Me.Label2.TabIndex = 32
            Me.Label2.Text = "소속사코드"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(423, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(97, 15)
            Me.Label3.TabIndex = 33
            Me.Label3.Text = "발행 순번"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(423, 46)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(97, 15)
            Me.Label4.TabIndex = 34
            Me.Label4.Text = "발행 상세 순번"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'numPublishStNum_R
            '
            Me.numPublishStNum_R.BackColor = System.Drawing.SystemColors.Window
            Me.numPublishStNum_R.BorderColor = System.Drawing.Color.Empty
            Me.numPublishStNum_R.BorderStyle = 2
            Me.numPublishStNum_R.CaptionName = "발행 상세 순번"
            Me.numPublishStNum_R.LengthPrecision = 15
            Me.numPublishStNum_R.LengthScale = 0
            Me.numPublishStNum_R.Location = New System.Drawing.Point(526, 43)
            Me.numPublishStNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numPublishStNum_R.MaxLength = 32767
            Me.numPublishStNum_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numPublishStNum_R.Name = "numPublishStNum_R"
            Me.numPublishStNum_R.ReadOnlys = False
            Me.numPublishStNum_R.SelectedText = ""
            Me.numPublishStNum_R.SelectionLength = 0
            Me.numPublishStNum_R.SelectionStart = 1
            Me.numPublishStNum_R.Size = New System.Drawing.Size(89, 20)
            Me.numPublishStNum_R.TabIndex = 35
            Me.numPublishStNum_R.Tag = ""
            Me.numPublishStNum_R.TextValue = "0"
            Me.numPublishStNum_R.ToolTipText = ""
            '
            'numPublishEdNum_R
            '
            Me.numPublishEdNum_R.BackColor = System.Drawing.SystemColors.Window
            Me.numPublishEdNum_R.BorderColor = System.Drawing.Color.Empty
            Me.numPublishEdNum_R.BorderStyle = 2
            Me.numPublishEdNum_R.CaptionName = "발행 상세 순번"
            Me.numPublishEdNum_R.LengthPrecision = 15
            Me.numPublishEdNum_R.LengthScale = 0
            Me.numPublishEdNum_R.Location = New System.Drawing.Point(638, 43)
            Me.numPublishEdNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numPublishEdNum_R.MaxLength = 32767
            Me.numPublishEdNum_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numPublishEdNum_R.Name = "numPublishEdNum_R"
            Me.numPublishEdNum_R.ReadOnlys = False
            Me.numPublishEdNum_R.SelectedText = ""
            Me.numPublishEdNum_R.SelectionLength = 0
            Me.numPublishEdNum_R.SelectionStart = 1
            Me.numPublishEdNum_R.Size = New System.Drawing.Size(89, 20)
            Me.numPublishEdNum_R.TabIndex = 36
            Me.numPublishEdNum_R.Tag = ""
            Me.numPublishEdNum_R.TextValue = "0"
            Me.numPublishEdNum_R.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(620, 46)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(12, 15)
            Me.Label5.TabIndex = 37
            Me.Label5.Text = "~"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'numOrders_R
            '
            Me.numOrders_R.BackColor = System.Drawing.SystemColors.Window
            Me.numOrders_R.BorderColor = System.Drawing.Color.Empty
            Me.numOrders_R.BorderStyle = 2
            Me.numOrders_R.CaptionName = "발행 순번"
            Me.numOrders_R.LengthPrecision = 15
            Me.numOrders_R.LengthScale = 0
            Me.numOrders_R.Location = New System.Drawing.Point(526, 19)
            Me.numOrders_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numOrders_R.MaxLength = 32767
            Me.numOrders_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numOrders_R.Name = "numOrders_R"
            Me.numOrders_R.ReadOnlys = False
            Me.numOrders_R.SelectedText = ""
            Me.numOrders_R.SelectionLength = 0
            Me.numOrders_R.SelectionStart = 1
            Me.numOrders_R.Size = New System.Drawing.Size(89, 20)
            Me.numOrders_R.TabIndex = 38
            Me.numOrders_R.Tag = ""
            Me.numOrders_R.TextValue = "0"
            Me.numOrders_R.ToolTipText = ""
            '
            'PNJ102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.numOrders_R)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.numPublishEdNum_R)
            Me.Controls.Add(Me.numPublishStNum_R)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.popCouponCorpCd)
            Me.Controls.Add(Me.dtpBaseYear2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpBaseYear)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "PNJ102"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseYear, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseYear2, 0)
            Me.Controls.SetChildIndex(Me.popCouponCorpCd, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.numPublishStNum_R, 0)
            Me.Controls.SetChildIndex(Me.numPublishEdNum_R, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.numOrders_R, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dtpBaseYear As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpBaseYear2 As ubiLease.CommonControls.dtp
        Friend WithEvents popCouponCorpCd As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents numPublishStNum_R As ubiLease.CommonControls.num
        Friend WithEvents numPublishEdNum_R As ubiLease.CommonControls.num
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents numOrders_R As ubiLease.CommonControls.num


    End Class

End Namespace
