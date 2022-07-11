Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMDB03
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMDB03))
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.txtLogTitle = New ubiLease.CommonControls.txt
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.dtpBusinessDateFrom = New ubiLease.CommonControls.dtp
            Me.lblDongCode = New System.Windows.Forms.Label
            Me.dtpBusinessLogDate = New ubiLease.CommonControls.dtp
            Me.Label15 = New System.Windows.Forms.Label
            Me.dtpBusinessDateTo = New ubiLease.CommonControls.dtp
            Me.Label16 = New System.Windows.Forms.Label
            Me.txtRemark = New ubiLease.CommonControls.txt
            Me.Label19 = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.grd_4 = New ubiLease.GridControl.grd
            Me.txtBusinessLogContent = New System.Windows.Forms.TextBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.numOrders = New ubiLease.CommonControls.txt
            Me.TabPage1 = New System.Windows.Forms.TabPage
            Me.TabControl1 = New System.Windows.Forms.TabControl
            Me.numProgressRate = New ubiLease.CommonControls.num
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.numWorkTime = New ubiLease.CommonControls.num
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.cboEmployee_R = New ubiLease.CommonControls.cbo
            Me.cboEmployee = New ubiLease.CommonControls.cbo
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(384, 66)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(421, 299)
            Me.picIo_2.TabIndex = 8
            Me.picIo_2.TabStop = False
            '
            'grd_3
            '
            Me.grd_3.AllowBigSelection = False
            Me.grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_3.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_3.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_3.Cols = 2
            Me.grd_3.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(5, 396)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(800, 112)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 100
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'txtLogTitle
            '
            Me.txtLogTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtLogTitle.BackColor = System.Drawing.SystemColors.Window
            Me.txtLogTitle.BorderColor = System.Drawing.Color.Empty
            Me.txtLogTitle.BorderStyle = 2
            Me.txtLogTitle.CaptionName = "제목"
            Me.txtLogTitle.Location = New System.Drawing.Point(464, 161)
            Me.txtLogTitle.MaxLength = 255
            Me.txtLogTitle.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtLogTitle.Multiline = False
            Me.txtLogTitle.Name = "txtLogTitle"
            Me.txtLogTitle.ReadOnlys = False
            Me.txtLogTitle.SelectedText = ""
            Me.txtLogTitle.SelectionLength = 0
            Me.txtLogTitle.SelectionStart = 0
            Me.txtLogTitle.Size = New System.Drawing.Size(318, 20)
            Me.txtLogTitle.TabIndex = 6
            Me.txtLogTitle.Tag = "need;"
            Me.txtLogTitle.TextAlign = 0
            Me.txtLogTitle.TextValue = ""
            Me.txtLogTitle.ToolTipText = ""
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 6)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(800, 57)
            Me.picCriteria_1.TabIndex = 70
            Me.picCriteria_1.TabStop = False
            '
            'dtpBusinessDateFrom
            '
            Me.dtpBusinessDateFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBusinessDateFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpBusinessDateFrom.BorderStyle = 2
            Me.dtpBusinessDateFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBusinessDateFrom.CaptionName = ""
            Me.dtpBusinessDateFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBusinessDateFrom.Location = New System.Drawing.Point(82, 23)
            Me.dtpBusinessDateFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBusinessDateFrom.MaxLength = 0
            Me.dtpBusinessDateFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBusinessDateFrom.Name = "dtpBusinessDateFrom"
            Me.dtpBusinessDateFrom.ReadOnlys = False
            Me.dtpBusinessDateFrom.SelectedText = ""
            Me.dtpBusinessDateFrom.SelectionLength = 0
            Me.dtpBusinessDateFrom.SelectionStart = 0
            Me.dtpBusinessDateFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpBusinessDateFrom.TabIndex = 0
            Me.dtpBusinessDateFrom.TabStop = False
            Me.dtpBusinessDateFrom.Tag = "format(&&&&-&&-&&);"
            Me.dtpBusinessDateFrom.TextAlign = 0
            Me.dtpBusinessDateFrom.TextValue = ""
            Me.dtpBusinessDateFrom.ToolTipText = ""
            '
            'lblDongCode
            '
            Me.lblDongCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDongCode.Location = New System.Drawing.Point(22, 27)
            Me.lblDongCode.Name = "lblDongCode"
            Me.lblDongCode.Size = New System.Drawing.Size(54, 14)
            Me.lblDongCode.TabIndex = 469
            Me.lblDongCode.Text = "업무일자"
            Me.lblDongCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpBusinessLogDate
            '
            Me.dtpBusinessLogDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpBusinessLogDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBusinessLogDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpBusinessLogDate.BorderStyle = 2
            Me.dtpBusinessLogDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBusinessLogDate.CaptionName = "업무일지일자"
            Me.dtpBusinessLogDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBusinessLogDate.Location = New System.Drawing.Point(464, 109)
            Me.dtpBusinessLogDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBusinessLogDate.MaxLength = 0
            Me.dtpBusinessLogDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBusinessLogDate.Name = "dtpBusinessLogDate"
            Me.dtpBusinessLogDate.ReadOnlys = False
            Me.dtpBusinessLogDate.SelectedText = ""
            Me.dtpBusinessLogDate.SelectionLength = 0
            Me.dtpBusinessLogDate.SelectionStart = 0
            Me.dtpBusinessLogDate.Size = New System.Drawing.Size(94, 20)
            Me.dtpBusinessLogDate.TabIndex = 4
            Me.dtpBusinessLogDate.TabStop = False
            Me.dtpBusinessLogDate.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpBusinessLogDate.TextAlign = 0
            Me.dtpBusinessLogDate.TextValue = ""
            Me.dtpBusinessLogDate.ToolTipText = ""
            '
            'Label15
            '
            Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label15.Location = New System.Drawing.Point(409, 114)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(54, 12)
            Me.Label15.TabIndex = 469
            Me.Label15.Text = "업무일자"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpBusinessDateTo
            '
            Me.dtpBusinessDateTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBusinessDateTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpBusinessDateTo.BorderStyle = 2
            Me.dtpBusinessDateTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBusinessDateTo.CaptionName = ""
            Me.dtpBusinessDateTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBusinessDateTo.Location = New System.Drawing.Point(198, 23)
            Me.dtpBusinessDateTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBusinessDateTo.MaxLength = 0
            Me.dtpBusinessDateTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBusinessDateTo.Name = "dtpBusinessDateTo"
            Me.dtpBusinessDateTo.ReadOnlys = False
            Me.dtpBusinessDateTo.SelectedText = ""
            Me.dtpBusinessDateTo.SelectionLength = 0
            Me.dtpBusinessDateTo.SelectionStart = 0
            Me.dtpBusinessDateTo.Size = New System.Drawing.Size(94, 20)
            Me.dtpBusinessDateTo.TabIndex = 1
            Me.dtpBusinessDateTo.TabStop = False
            Me.dtpBusinessDateTo.Tag = "format(&&&&-&&-&&);"
            Me.dtpBusinessDateTo.TextAlign = 0
            Me.dtpBusinessDateTo.TextValue = ""
            Me.dtpBusinessDateTo.ToolTipText = ""
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label16.Location = New System.Drawing.Point(181, 26)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(12, 14)
            Me.Label16.TabIndex = 9
            Me.Label16.Text = "~"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtRemark
            '
            Me.txtRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtRemark.BackColor = System.Drawing.SystemColors.Window
            Me.txtRemark.BorderColor = System.Drawing.Color.Empty
            Me.txtRemark.BorderStyle = 2
            Me.txtRemark.CaptionName = "비고"
            Me.txtRemark.Location = New System.Drawing.Point(464, 310)
            Me.txtRemark.MaxLength = 255
            Me.txtRemark.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRemark.Multiline = False
            Me.txtRemark.Name = "txtRemark"
            Me.txtRemark.ReadOnlys = False
            Me.txtRemark.SelectedText = ""
            Me.txtRemark.SelectionLength = 0
            Me.txtRemark.SelectionStart = 0
            Me.txtRemark.Size = New System.Drawing.Size(318, 42)
            Me.txtRemark.TabIndex = 9
            Me.txtRemark.Tag = ""
            Me.txtRemark.TextAlign = 0
            Me.txtRemark.TextValue = ""
            Me.txtRemark.ToolTipText = ""
            '
            'Label19
            '
            Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label19.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label19.Location = New System.Drawing.Point(409, 310)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(54, 12)
            Me.Label19.TabIndex = 130
            Me.Label19.Text = "특이사항"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_1.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_1.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 66)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(373, 299)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 605
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(409, 192)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(54, 12)
            Me.Label1.TabIndex = 607
            Me.Label1.Text = "업무내용"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label12
            '
            Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label12.Location = New System.Drawing.Point(409, 140)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(49, 12)
            Me.Label12.TabIndex = 481
            Me.Label12.Text = "사원"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(409, 165)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 12)
            Me.Label2.TabIndex = 608
            Me.Label2.Text = "제목"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(3, 371)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(802, 21)
            Me.Label3.TabIndex = 609
            Me.Label3.Tag = "left;"
            Me.Label3.Text = "접수 내역"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(3, 511)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(802, 21)
            Me.Label5.TabIndex = 611
            Me.Label5.Tag = "left;"
            Me.Label5.Text = "처리 내역"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'grd_4
            '
            Me.grd_4.AllowBigSelection = False
            Me.grd_4.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_4.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_4.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_4.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_4.Cols = 2
            Me.grd_4.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_4.ExplorerBar = 0
            Me.grd_4.ExtendLastCol = True
            Me.grd_4.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_4.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_4.FrozenCols = 1
            Me.grd_4.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_4.Location = New System.Drawing.Point(5, 536)
            Me.grd_4.Name = "grd_4"
            Me.grd_4.NodeClosedPicture = Nothing
            Me.grd_4.NodeOpenPicture = Nothing
            Me.grd_4.OutlineCol = -1
            Me.grd_4.RowHeightMax = 18
            Me.grd_4.RowHeightMin = 18
            Me.grd_4.Rows = 2
            Me.grd_4.Size = New System.Drawing.Size(800, 108)
            Me.grd_4.StyleInfo = resources.GetString("grd_4.StyleInfo")
            Me.grd_4.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_4.TabIndex = 610
            Me.grd_4.TreeColor = System.Drawing.Color.DarkGray
            '
            'txtBusinessLogContent
            '
            Me.txtBusinessLogContent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtBusinessLogContent.BackColor = System.Drawing.Color.LightCyan
            Me.txtBusinessLogContent.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtBusinessLogContent.ImeMode = System.Windows.Forms.ImeMode.Hangul
            Me.txtBusinessLogContent.Location = New System.Drawing.Point(0, 0)
            Me.txtBusinessLogContent.MaxLength = 9999999
            Me.txtBusinessLogContent.Multiline = True
            Me.txtBusinessLogContent.Name = "txtBusinessLogContent"
            Me.txtBusinessLogContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtBusinessLogContent.Size = New System.Drawing.Size(310, 92)
            Me.txtBusinessLogContent.TabIndex = 0
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(333, 27)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(32, 14)
            Me.Label4.TabIndex = 616
            Me.Label4.Text = "사원"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'numOrders
            '
            Me.numOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numOrders.BackColor = System.Drawing.SystemColors.Window
            Me.numOrders.BorderColor = System.Drawing.Color.Empty
            Me.numOrders.BorderStyle = 2
            Me.numOrders.CaptionName = ""
            Me.numOrders.Location = New System.Drawing.Point(556, 109)
            Me.numOrders.MaxLength = 255
            Me.numOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numOrders.Multiline = False
            Me.numOrders.Name = "numOrders"
            Me.numOrders.ReadOnlys = False
            Me.numOrders.SelectedText = ""
            Me.numOrders.SelectionLength = 0
            Me.numOrders.SelectionStart = 0
            Me.numOrders.Size = New System.Drawing.Size(32, 20)
            Me.numOrders.TabIndex = 617
            Me.numOrders.Tag = "init(0);read();"
            Me.numOrders.TextAlign = 0
            Me.numOrders.TextValue = ""
            Me.numOrders.ToolTipText = ""
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.txtBusinessLogContent)
            Me.TabPage1.Location = New System.Drawing.Point(4, 21)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New System.Drawing.Size(310, 92)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Location = New System.Drawing.Point(464, 187)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(318, 117)
            Me.TabControl1.TabIndex = 615
            '
            'numProgressRate
            '
            Me.numProgressRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numProgressRate.BackColor = System.Drawing.SystemColors.Window
            Me.numProgressRate.BorderColor = System.Drawing.Color.Empty
            Me.numProgressRate.BorderStyle = 2
            Me.numProgressRate.CaptionName = "진행율"
            Me.numProgressRate.LengthPrecision = 15
            Me.numProgressRate.LengthScale = 0
            Me.numProgressRate.Location = New System.Drawing.Point(715, 109)
            Me.numProgressRate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numProgressRate.MaxLength = 3
            Me.numProgressRate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numProgressRate.Name = "numProgressRate"
            Me.numProgressRate.ReadOnlys = False
            Me.numProgressRate.SelectedText = ""
            Me.numProgressRate.SelectionLength = 0
            Me.numProgressRate.SelectionStart = 1
            Me.numProgressRate.Size = New System.Drawing.Size(37, 20)
            Me.numProgressRate.TabIndex = 7
            Me.numProgressRate.Tag = ""
            Me.numProgressRate.TextValue = "0"
            Me.numProgressRate.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(658, 110)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(55, 18)
            Me.Label6.TabIndex = 618
            Me.Label6.Text = "진행율"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label7
            '
            Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(658, 134)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(55, 18)
            Me.Label7.TabIndex = 620
            Me.Label7.Text = "작업시간"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'numWorkTime
            '
            Me.numWorkTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numWorkTime.BackColor = System.Drawing.SystemColors.Window
            Me.numWorkTime.BorderColor = System.Drawing.Color.Empty
            Me.numWorkTime.BorderStyle = 2
            Me.numWorkTime.CaptionName = "작업 시간"
            Me.numWorkTime.LengthPrecision = 15
            Me.numWorkTime.LengthScale = 0
            Me.numWorkTime.Location = New System.Drawing.Point(715, 132)
            Me.numWorkTime.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numWorkTime.MaxLength = 0
            Me.numWorkTime.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numWorkTime.Name = "numWorkTime"
            Me.numWorkTime.ReadOnlys = False
            Me.numWorkTime.SelectedText = ""
            Me.numWorkTime.SelectionLength = 0
            Me.numWorkTime.SelectionStart = 1
            Me.numWorkTime.Size = New System.Drawing.Size(37, 20)
            Me.numWorkTime.TabIndex = 8
            Me.numWorkTime.Tag = ""
            Me.numWorkTime.TextValue = "0"
            Me.numWorkTime.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(758, 135)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(20, 17)
            Me.Label8.TabIndex = 621
            Me.Label8.Text = "분"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label9
            '
            Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Font = New System.Drawing.Font("굴림", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label9.Location = New System.Drawing.Point(758, 111)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(20, 17)
            Me.Label9.TabIndex = 622
            Me.Label9.Text = "%"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboEmployee_R
            '
            Me.cboEmployee_R.CaptionName = "작업 분류"
            Me.cboEmployee_R.ListCount = 0
            Me.cboEmployee_R.Location = New System.Drawing.Point(371, 23)
            Me.cboEmployee_R.Name = "cboEmployee_R"
            Me.cboEmployee_R.ReadOnlys = False
            Me.cboEmployee_R.Size = New System.Drawing.Size(203, 20)
            Me.cboEmployee_R.TabIndex = 623
            Me.cboEmployee_R.Tag = "code(요청사원 명|선택하세요);"
            Me.cboEmployee_R.TextValue = ""
            '
            'cboEmployee
            '
            Me.cboEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboEmployee.CaptionName = "작업 분류"
            Me.cboEmployee.ListCount = 0
            Me.cboEmployee.Location = New System.Drawing.Point(464, 135)
            Me.cboEmployee.Name = "cboEmployee"
            Me.cboEmployee.ReadOnlys = False
            Me.cboEmployee.Size = New System.Drawing.Size(181, 20)
            Me.cboEmployee.TabIndex = 624
            Me.cboEmployee.Tag = "code(요청사원 명|선택하세요);"
            Me.cboEmployee.TextValue = ""
            '
            'SMDB03
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.cboEmployee)
            Me.Controls.Add(Me.cboEmployee_R)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.numWorkTime)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.numProgressRate)
            Me.Controls.Add(Me.numOrders)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.grd_4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.dtpBusinessLogDate)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.dtpBusinessDateTo)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.dtpBusinessDateFrom)
            Me.Controls.Add(Me.lblDongCode)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.Label19)
            Me.Controls.Add(Me.txtRemark)
            Me.Controls.Add(Me.txtLogTitle)
            Me.Controls.Add(Me.picIo_2)
            Me.Name = "SMDB03"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picIo_2, 0)
            Me.Controls.SetChildIndex(Me.txtLogTitle, 0)
            Me.Controls.SetChildIndex(Me.txtRemark, 0)
            Me.Controls.SetChildIndex(Me.Label19, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblDongCode, 0)
            Me.Controls.SetChildIndex(Me.dtpBusinessDateFrom, 0)
            Me.Controls.SetChildIndex(Me.Label16, 0)
            Me.Controls.SetChildIndex(Me.dtpBusinessDateTo, 0)
            Me.Controls.SetChildIndex(Me.Label12, 0)
            Me.Controls.SetChildIndex(Me.dtpBusinessLogDate, 0)
            Me.Controls.SetChildIndex(Me.Label15, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.grd_4, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.grd_3, 0)
            Me.Controls.SetChildIndex(Me.TabControl1, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.numOrders, 0)
            Me.Controls.SetChildIndex(Me.numProgressRate, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.numWorkTime, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.cboEmployee_R, 0)
            Me.Controls.SetChildIndex(Me.cboEmployee, 0)
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents txtLogTitle As ubiLease.CommonControls.txt
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpBusinessDateFrom As ubiLease.CommonControls.dtp
        Friend WithEvents lblDongCode As System.Windows.Forms.Label
        Friend WithEvents dtpBusinessLogDate As ubiLease.CommonControls.dtp
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents dtpBusinessDateTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents txtRemark As ubiLease.CommonControls.txt
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents grd_4 As ubiLease.GridControl.grd
        Friend WithEvents txtBusinessLogContent As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents numOrders As ubiLease.CommonControls.txt
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents numProgressRate As ubiLease.CommonControls.num
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents numWorkTime As ubiLease.CommonControls.num
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cboEmployee_R As ubiLease.CommonControls.cbo
        Friend WithEvents cboEmployee As ubiLease.CommonControls.cbo

    End Class

End Namespace
