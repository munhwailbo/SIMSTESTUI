Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNH201
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNH201))
            Me.dtpBaseYear = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.NumYdPaperNumYT = New ubiLease.CommonControls.num
            Me.NumYdPaperNum2 = New ubiLease.CommonControls.num
            Me.NumYdPaperNum1 = New ubiLease.CommonControls.num
            Me.NumFixedValPaperNumYT = New ubiLease.CommonControls.num
            Me.NumFixedValPaperNum2 = New ubiLease.CommonControls.num
            Me.NumFixedValPaperNum1 = New ubiLease.CommonControls.num
            Me.NumCurValPaperNumYT = New ubiLease.CommonControls.num
            Me.Label5 = New System.Windows.Forms.Label
            Me.NumCurValPaperNum2 = New ubiLease.CommonControls.num
            Me.Label4 = New System.Windows.Forms.Label
            Me.numCurValPaperNum1 = New ubiLease.CommonControls.num
            Me.Label40 = New System.Windows.Forms.Label
            Me.dtpBaseMMBefore = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.dtpBaseMMtoday = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.NumYdPaperNum4 = New ubiLease.CommonControls.num
            Me.NumYdPaperNum3 = New ubiLease.CommonControls.num
            Me.NumFixedValPaperNum4 = New ubiLease.CommonControls.num
            Me.NumFixedValPaperNum3 = New ubiLease.CommonControls.num
            Me.NumCurValPaperNum4 = New ubiLease.CommonControls.num
            Me.Label1 = New System.Windows.Forms.Label
            Me.NumCurValPaperNum3 = New ubiLease.CommonControls.num
            Me.Label8 = New System.Windows.Forms.Label
            Me.btnNew = New ubiLease.CommonControls.btn
            Me.NumYdPaperNum = New ubiLease.CommonControls.num
            Me.NumFixedNoValPaperNum = New ubiLease.CommonControls.num
            Me.NumCurValPaperNum = New ubiLease.CommonControls.num
            Me.Label9 = New System.Windows.Forms.Label
            Me.NumYdPaperNumT = New ubiLease.CommonControls.num
            Me.NumFixedNoValPaperNumT = New ubiLease.CommonControls.num
            Me.NumCurValPaperNumT = New ubiLease.CommonControls.num
            Me.Label10 = New System.Windows.Forms.Label
            Me.txtEmployee_R = New ubiLease.CommonControls.txt
            Me.Label11 = New System.Windows.Forms.Label
            Me.txtBranchNm_R = New ubiLease.CommonControls.txt
            Me.lblReaderNm_2 = New System.Windows.Forms.Label
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optExpAmt4 = New System.Windows.Forms.RadioButton
            Me.optExpAmt3 = New System.Windows.Forms.RadioButton
            Me.optExpAmt1 = New System.Windows.Forms.RadioButton
            Me.optExpAmt2 = New System.Windows.Forms.RadioButton
            Me.Label12 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpBaseYear
            '
            Me.dtpBaseYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYear.BorderStyle = 2
            Me.dtpBaseYear.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYear.CaptionName = "기준 일자"
            Me.dtpBaseYear.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseYear.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYear.Location = New System.Drawing.Point(102, 15)
            Me.dtpBaseYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYear.MaxLength = 0
            Me.dtpBaseYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYear.Name = "dtpBaseYear"
            Me.dtpBaseYear.ReadOnlys = False
            Me.dtpBaseYear.SelectedText = ""
            Me.dtpBaseYear.SelectionLength = 0
            Me.dtpBaseYear.SelectionStart = 0
            Me.dtpBaseYear.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYear.TabIndex = 2
            Me.dtpBaseYear.Tag = "format(&&&&-&&);"
            Me.dtpBaseYear.TextAlign = 0
            Me.dtpBaseYear.TextValue = ""
            Me.dtpBaseYear.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(22, 18)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(74, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 35
            Me.lblCodeDivisionHangulName.Text = "기준 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(3, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 60)
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
            Me.grd_1.Location = New System.Drawing.Point(3, 116)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(804, 420)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 36
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label7
            '
            Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label7.BackColor = System.Drawing.Color.GhostWhite
            Me.Label7.Location = New System.Drawing.Point(52, 556)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(100, 15)
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "년월"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label6.BackColor = System.Drawing.Color.GhostWhite
            Me.Label6.Location = New System.Drawing.Point(23, 601)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(43, 15)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "증 감"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'NumYdPaperNumYT
            '
            Me.NumYdPaperNumYT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumYdPaperNumYT.BackColor = System.Drawing.SystemColors.Window
            Me.NumYdPaperNumYT.BorderColor = System.Drawing.Color.Empty
            Me.NumYdPaperNumYT.BorderStyle = 2
            Me.NumYdPaperNumYT.CaptionName = "증감부수계"
            Me.NumYdPaperNumYT.LengthPrecision = 15
            Me.NumYdPaperNumYT.LengthScale = 0
            Me.NumYdPaperNumYT.Location = New System.Drawing.Point(330, 596)
            Me.NumYdPaperNumYT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumYdPaperNumYT.MaxLength = 32767
            Me.NumYdPaperNumYT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumYdPaperNumYT.Name = "NumYdPaperNumYT"
            Me.NumYdPaperNumYT.ReadOnlys = False
            Me.NumYdPaperNumYT.SelectedText = ""
            Me.NumYdPaperNumYT.SelectionLength = 0
            Me.NumYdPaperNumYT.SelectionStart = 1
            Me.NumYdPaperNumYT.Size = New System.Drawing.Size(92, 20)
            Me.NumYdPaperNumYT.TabIndex = 22
            Me.NumYdPaperNumYT.Tag = "read;"
            Me.NumYdPaperNumYT.TextValue = "0"
            Me.NumYdPaperNumYT.ToolTipText = ""
            '
            'NumYdPaperNum2
            '
            Me.NumYdPaperNum2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumYdPaperNum2.BackColor = System.Drawing.SystemColors.Window
            Me.NumYdPaperNum2.BorderColor = System.Drawing.Color.Empty
            Me.NumYdPaperNum2.BorderStyle = 2
            Me.NumYdPaperNum2.CaptionName = "증감무가"
            Me.NumYdPaperNum2.LengthPrecision = 15
            Me.NumYdPaperNum2.LengthScale = 0
            Me.NumYdPaperNum2.Location = New System.Drawing.Point(246, 596)
            Me.NumYdPaperNum2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumYdPaperNum2.MaxLength = 32767
            Me.NumYdPaperNum2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumYdPaperNum2.Name = "NumYdPaperNum2"
            Me.NumYdPaperNum2.ReadOnlys = False
            Me.NumYdPaperNum2.SelectedText = ""
            Me.NumYdPaperNum2.SelectionLength = 0
            Me.NumYdPaperNum2.SelectionStart = 1
            Me.NumYdPaperNum2.Size = New System.Drawing.Size(80, 20)
            Me.NumYdPaperNum2.TabIndex = 21
            Me.NumYdPaperNum2.Tag = Nothing
            Me.NumYdPaperNum2.TextValue = "0"
            Me.NumYdPaperNum2.ToolTipText = ""
            '
            'NumYdPaperNum1
            '
            Me.NumYdPaperNum1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumYdPaperNum1.BackColor = System.Drawing.SystemColors.Window
            Me.NumYdPaperNum1.BorderColor = System.Drawing.Color.Empty
            Me.NumYdPaperNum1.BorderStyle = 2
            Me.NumYdPaperNum1.CaptionName = "증감유가"
            Me.NumYdPaperNum1.LengthPrecision = 15
            Me.NumYdPaperNum1.LengthScale = 0
            Me.NumYdPaperNum1.Location = New System.Drawing.Point(164, 596)
            Me.NumYdPaperNum1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumYdPaperNum1.MaxLength = 32767
            Me.NumYdPaperNum1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumYdPaperNum1.Name = "NumYdPaperNum1"
            Me.NumYdPaperNum1.ReadOnlys = False
            Me.NumYdPaperNum1.SelectedText = ""
            Me.NumYdPaperNum1.SelectionLength = 0
            Me.NumYdPaperNum1.SelectionStart = 1
            Me.NumYdPaperNum1.Size = New System.Drawing.Size(80, 20)
            Me.NumYdPaperNum1.TabIndex = 19
            Me.NumYdPaperNum1.Tag = Nothing
            Me.NumYdPaperNum1.TextValue = "0"
            Me.NumYdPaperNum1.ToolTipText = ""
            '
            'NumFixedValPaperNumYT
            '
            Me.NumFixedValPaperNumYT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumFixedValPaperNumYT.BackColor = System.Drawing.SystemColors.Window
            Me.NumFixedValPaperNumYT.BorderColor = System.Drawing.Color.Empty
            Me.NumFixedValPaperNumYT.BorderStyle = 2
            Me.NumFixedValPaperNumYT.CaptionName = "당일부수계"
            Me.NumFixedValPaperNumYT.LengthPrecision = 15
            Me.NumFixedValPaperNumYT.LengthScale = 0
            Me.NumFixedValPaperNumYT.Location = New System.Drawing.Point(330, 618)
            Me.NumFixedValPaperNumYT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumFixedValPaperNumYT.MaxLength = 32767
            Me.NumFixedValPaperNumYT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumFixedValPaperNumYT.Name = "NumFixedValPaperNumYT"
            Me.NumFixedValPaperNumYT.ReadOnlys = False
            Me.NumFixedValPaperNumYT.SelectedText = ""
            Me.NumFixedValPaperNumYT.SelectionLength = 0
            Me.NumFixedValPaperNumYT.SelectionStart = 1
            Me.NumFixedValPaperNumYT.Size = New System.Drawing.Size(92, 20)
            Me.NumFixedValPaperNumYT.TabIndex = 30
            Me.NumFixedValPaperNumYT.Tag = "read;"
            Me.NumFixedValPaperNumYT.TextValue = "0"
            Me.NumFixedValPaperNumYT.ToolTipText = ""
            '
            'NumFixedValPaperNum2
            '
            Me.NumFixedValPaperNum2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumFixedValPaperNum2.BackColor = System.Drawing.SystemColors.Window
            Me.NumFixedValPaperNum2.BorderColor = System.Drawing.Color.Empty
            Me.NumFixedValPaperNum2.BorderStyle = 2
            Me.NumFixedValPaperNum2.CaptionName = "당일무가"
            Me.NumFixedValPaperNum2.LengthPrecision = 15
            Me.NumFixedValPaperNum2.LengthScale = 0
            Me.NumFixedValPaperNum2.Location = New System.Drawing.Point(246, 618)
            Me.NumFixedValPaperNum2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumFixedValPaperNum2.MaxLength = 32767
            Me.NumFixedValPaperNum2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumFixedValPaperNum2.Name = "NumFixedValPaperNum2"
            Me.NumFixedValPaperNum2.ReadOnlys = False
            Me.NumFixedValPaperNum2.SelectedText = ""
            Me.NumFixedValPaperNum2.SelectionLength = 0
            Me.NumFixedValPaperNum2.SelectionStart = 1
            Me.NumFixedValPaperNum2.Size = New System.Drawing.Size(80, 20)
            Me.NumFixedValPaperNum2.TabIndex = 29
            Me.NumFixedValPaperNum2.Tag = "read;"
            Me.NumFixedValPaperNum2.TextValue = "0"
            Me.NumFixedValPaperNum2.ToolTipText = ""
            '
            'NumFixedValPaperNum1
            '
            Me.NumFixedValPaperNum1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumFixedValPaperNum1.BackColor = System.Drawing.SystemColors.Window
            Me.NumFixedValPaperNum1.BorderColor = System.Drawing.Color.Empty
            Me.NumFixedValPaperNum1.BorderStyle = 2
            Me.NumFixedValPaperNum1.CaptionName = "당일유가"
            Me.NumFixedValPaperNum1.LengthPrecision = 15
            Me.NumFixedValPaperNum1.LengthScale = 0
            Me.NumFixedValPaperNum1.Location = New System.Drawing.Point(164, 618)
            Me.NumFixedValPaperNum1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumFixedValPaperNum1.MaxLength = 32767
            Me.NumFixedValPaperNum1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumFixedValPaperNum1.Name = "NumFixedValPaperNum1"
            Me.NumFixedValPaperNum1.ReadOnlys = False
            Me.NumFixedValPaperNum1.SelectedText = ""
            Me.NumFixedValPaperNum1.SelectionLength = 0
            Me.NumFixedValPaperNum1.SelectionStart = 1
            Me.NumFixedValPaperNum1.Size = New System.Drawing.Size(80, 20)
            Me.NumFixedValPaperNum1.TabIndex = 28
            Me.NumFixedValPaperNum1.Tag = "read;"
            Me.NumFixedValPaperNum1.TextValue = "0"
            Me.NumFixedValPaperNum1.ToolTipText = ""
            '
            'NumCurValPaperNumYT
            '
            Me.NumCurValPaperNumYT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumCurValPaperNumYT.BackColor = System.Drawing.SystemColors.Window
            Me.NumCurValPaperNumYT.BorderColor = System.Drawing.Color.Empty
            Me.NumCurValPaperNumYT.BorderStyle = 2
            Me.NumCurValPaperNumYT.CaptionName = "전일부수계"
            Me.NumCurValPaperNumYT.LengthPrecision = 15
            Me.NumCurValPaperNumYT.LengthScale = 0
            Me.NumCurValPaperNumYT.Location = New System.Drawing.Point(330, 575)
            Me.NumCurValPaperNumYT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumCurValPaperNumYT.MaxLength = 32767
            Me.NumCurValPaperNumYT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumCurValPaperNumYT.Name = "NumCurValPaperNumYT"
            Me.NumCurValPaperNumYT.ReadOnlys = False
            Me.NumCurValPaperNumYT.SelectedText = ""
            Me.NumCurValPaperNumYT.SelectionLength = 0
            Me.NumCurValPaperNumYT.SelectionStart = 1
            Me.NumCurValPaperNumYT.Size = New System.Drawing.Size(92, 20)
            Me.NumCurValPaperNumYT.TabIndex = 14
            Me.NumCurValPaperNumYT.Tag = "read;"
            Me.NumCurValPaperNumYT.TextValue = "0"
            Me.NumCurValPaperNumYT.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Location = New System.Drawing.Point(330, 554)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(92, 18)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "유가부수계"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'NumCurValPaperNum2
            '
            Me.NumCurValPaperNum2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumCurValPaperNum2.BackColor = System.Drawing.SystemColors.Window
            Me.NumCurValPaperNum2.BorderColor = System.Drawing.Color.Empty
            Me.NumCurValPaperNum2.BorderStyle = 2
            Me.NumCurValPaperNum2.CaptionName = "전일무가"
            Me.NumCurValPaperNum2.LengthPrecision = 15
            Me.NumCurValPaperNum2.LengthScale = 0
            Me.NumCurValPaperNum2.Location = New System.Drawing.Point(246, 575)
            Me.NumCurValPaperNum2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumCurValPaperNum2.MaxLength = 32767
            Me.NumCurValPaperNum2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumCurValPaperNum2.Name = "NumCurValPaperNum2"
            Me.NumCurValPaperNum2.ReadOnlys = False
            Me.NumCurValPaperNum2.SelectedText = ""
            Me.NumCurValPaperNum2.SelectionLength = 0
            Me.NumCurValPaperNum2.SelectionStart = 1
            Me.NumCurValPaperNum2.Size = New System.Drawing.Size(80, 20)
            Me.NumCurValPaperNum2.TabIndex = 13
            Me.NumCurValPaperNum2.Tag = "read;"
            Me.NumCurValPaperNum2.TextValue = "0"
            Me.NumCurValPaperNum2.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Location = New System.Drawing.Point(246, 554)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(80, 18)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "일반유가2"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numCurValPaperNum1
            '
            Me.numCurValPaperNum1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.numCurValPaperNum1.BackColor = System.Drawing.SystemColors.Window
            Me.numCurValPaperNum1.BorderColor = System.Drawing.Color.Empty
            Me.numCurValPaperNum1.BorderStyle = 2
            Me.numCurValPaperNum1.CaptionName = "전일유가"
            Me.numCurValPaperNum1.LengthPrecision = 15
            Me.numCurValPaperNum1.LengthScale = 0
            Me.numCurValPaperNum1.Location = New System.Drawing.Point(164, 575)
            Me.numCurValPaperNum1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numCurValPaperNum1.MaxLength = 32767
            Me.numCurValPaperNum1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numCurValPaperNum1.Name = "numCurValPaperNum1"
            Me.numCurValPaperNum1.ReadOnlys = False
            Me.numCurValPaperNum1.SelectedText = ""
            Me.numCurValPaperNum1.SelectionLength = 0
            Me.numCurValPaperNum1.SelectionStart = 1
            Me.numCurValPaperNum1.Size = New System.Drawing.Size(80, 20)
            Me.numCurValPaperNum1.TabIndex = 12
            Me.numCurValPaperNum1.Tag = "read;"
            Me.numCurValPaperNum1.TextValue = "0"
            Me.numCurValPaperNum1.ToolTipText = ""
            '
            'Label40
            '
            Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label40.BackColor = System.Drawing.Color.GhostWhite
            Me.Label40.Location = New System.Drawing.Point(164, 554)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(80, 18)
            Me.Label40.TabIndex = 4
            Me.Label40.Text = "일반유가1"
            Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpBaseMMBefore
            '
            Me.dtpBaseMMBefore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpBaseMMBefore.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseMMBefore.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseMMBefore.BorderStyle = 2
            Me.dtpBaseMMBefore.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseMMBefore.CaptionName = "전일 발행 일자"
            Me.dtpBaseMMBefore.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseMMBefore.Enabled = False
            Me.dtpBaseMMBefore.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseMMBefore.Location = New System.Drawing.Point(71, 575)
            Me.dtpBaseMMBefore.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseMMBefore.MaxLength = 0
            Me.dtpBaseMMBefore.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseMMBefore.Name = "dtpBaseMMBefore"
            Me.dtpBaseMMBefore.ReadOnlys = False
            Me.dtpBaseMMBefore.SelectedText = ""
            Me.dtpBaseMMBefore.SelectionLength = 0
            Me.dtpBaseMMBefore.SelectionStart = 0
            Me.dtpBaseMMBefore.Size = New System.Drawing.Size(81, 20)
            Me.dtpBaseMMBefore.TabIndex = 11
            Me.dtpBaseMMBefore.Tag = "read;format(&&&&-&&);"
            Me.dtpBaseMMBefore.TextAlign = 0
            Me.dtpBaseMMBefore.TextValue = ""
            Me.dtpBaseMMBefore.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Location = New System.Drawing.Point(23, 578)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 15)
            Me.Label3.TabIndex = 37
            Me.Label3.Text = "전 월"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpBaseMMtoday
            '
            Me.dtpBaseMMtoday.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpBaseMMtoday.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseMMtoday.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseMMtoday.BorderStyle = 2
            Me.dtpBaseMMtoday.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseMMtoday.CaptionName = "당일 발행 일자"
            Me.dtpBaseMMtoday.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseMMtoday.Enabled = False
            Me.dtpBaseMMtoday.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseMMtoday.Location = New System.Drawing.Point(71, 618)
            Me.dtpBaseMMtoday.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseMMtoday.MaxLength = 0
            Me.dtpBaseMMtoday.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseMMtoday.Name = "dtpBaseMMtoday"
            Me.dtpBaseMMtoday.ReadOnlys = False
            Me.dtpBaseMMtoday.SelectedText = ""
            Me.dtpBaseMMtoday.SelectionLength = 0
            Me.dtpBaseMMtoday.SelectionStart = 0
            Me.dtpBaseMMtoday.Size = New System.Drawing.Size(81, 20)
            Me.dtpBaseMMtoday.TabIndex = 27
            Me.dtpBaseMMtoday.Tag = "read;format(&&&&-&&);"
            Me.dtpBaseMMtoday.TextAlign = 0
            Me.dtpBaseMMtoday.TextValue = ""
            Me.dtpBaseMMtoday.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Location = New System.Drawing.Point(23, 623)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(43, 15)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "당 월"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(5, 542)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(803, 102)
            Me.picIo_2.TabIndex = 1581
            Me.picIo_2.TabStop = False
            '
            'NumYdPaperNum4
            '
            Me.NumYdPaperNum4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumYdPaperNum4.BackColor = System.Drawing.SystemColors.Window
            Me.NumYdPaperNum4.BorderColor = System.Drawing.Color.Empty
            Me.NumYdPaperNum4.BorderStyle = 2
            Me.NumYdPaperNum4.CaptionName = "증감무가"
            Me.NumYdPaperNum4.LengthPrecision = 15
            Me.NumYdPaperNum4.LengthScale = 0
            Me.NumYdPaperNum4.Location = New System.Drawing.Point(707, 597)
            Me.NumYdPaperNum4.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumYdPaperNum4.MaxLength = 32767
            Me.NumYdPaperNum4.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumYdPaperNum4.Name = "NumYdPaperNum4"
            Me.NumYdPaperNum4.ReadOnlys = False
            Me.NumYdPaperNum4.SelectedText = ""
            Me.NumYdPaperNum4.SelectionLength = 0
            Me.NumYdPaperNum4.SelectionStart = 1
            Me.NumYdPaperNum4.Size = New System.Drawing.Size(80, 20)
            Me.NumYdPaperNum4.TabIndex = 26
            Me.NumYdPaperNum4.Tag = Nothing
            Me.NumYdPaperNum4.TextValue = "0"
            Me.NumYdPaperNum4.ToolTipText = ""
            Me.NumYdPaperNum4.Visible = False
            '
            'NumYdPaperNum3
            '
            Me.NumYdPaperNum3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumYdPaperNum3.BackColor = System.Drawing.SystemColors.Window
            Me.NumYdPaperNum3.BorderColor = System.Drawing.Color.Empty
            Me.NumYdPaperNum3.BorderStyle = 2
            Me.NumYdPaperNum3.CaptionName = "증감유가"
            Me.NumYdPaperNum3.LengthPrecision = 15
            Me.NumYdPaperNum3.LengthScale = 0
            Me.NumYdPaperNum3.Location = New System.Drawing.Point(625, 597)
            Me.NumYdPaperNum3.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumYdPaperNum3.MaxLength = 32767
            Me.NumYdPaperNum3.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumYdPaperNum3.Name = "NumYdPaperNum3"
            Me.NumYdPaperNum3.ReadOnlys = False
            Me.NumYdPaperNum3.SelectedText = ""
            Me.NumYdPaperNum3.SelectionLength = 0
            Me.NumYdPaperNum3.SelectionStart = 1
            Me.NumYdPaperNum3.Size = New System.Drawing.Size(80, 20)
            Me.NumYdPaperNum3.TabIndex = 25
            Me.NumYdPaperNum3.Tag = Nothing
            Me.NumYdPaperNum3.TextValue = "0"
            Me.NumYdPaperNum3.ToolTipText = ""
            Me.NumYdPaperNum3.Visible = False
            '
            'NumFixedValPaperNum4
            '
            Me.NumFixedValPaperNum4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumFixedValPaperNum4.BackColor = System.Drawing.SystemColors.Window
            Me.NumFixedValPaperNum4.BorderColor = System.Drawing.Color.Empty
            Me.NumFixedValPaperNum4.BorderStyle = 2
            Me.NumFixedValPaperNum4.CaptionName = "당일무가"
            Me.NumFixedValPaperNum4.LengthPrecision = 15
            Me.NumFixedValPaperNum4.LengthScale = 0
            Me.NumFixedValPaperNum4.Location = New System.Drawing.Point(707, 619)
            Me.NumFixedValPaperNum4.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumFixedValPaperNum4.MaxLength = 32767
            Me.NumFixedValPaperNum4.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumFixedValPaperNum4.Name = "NumFixedValPaperNum4"
            Me.NumFixedValPaperNum4.ReadOnlys = False
            Me.NumFixedValPaperNum4.SelectedText = ""
            Me.NumFixedValPaperNum4.SelectionLength = 0
            Me.NumFixedValPaperNum4.SelectionStart = 1
            Me.NumFixedValPaperNum4.Size = New System.Drawing.Size(80, 20)
            Me.NumFixedValPaperNum4.TabIndex = 34
            Me.NumFixedValPaperNum4.Tag = "read;"
            Me.NumFixedValPaperNum4.TextValue = "0"
            Me.NumFixedValPaperNum4.ToolTipText = ""
            Me.NumFixedValPaperNum4.Visible = False
            '
            'NumFixedValPaperNum3
            '
            Me.NumFixedValPaperNum3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumFixedValPaperNum3.BackColor = System.Drawing.SystemColors.Window
            Me.NumFixedValPaperNum3.BorderColor = System.Drawing.Color.Empty
            Me.NumFixedValPaperNum3.BorderStyle = 2
            Me.NumFixedValPaperNum3.CaptionName = "당일유가"
            Me.NumFixedValPaperNum3.LengthPrecision = 15
            Me.NumFixedValPaperNum3.LengthScale = 0
            Me.NumFixedValPaperNum3.Location = New System.Drawing.Point(625, 619)
            Me.NumFixedValPaperNum3.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumFixedValPaperNum3.MaxLength = 32767
            Me.NumFixedValPaperNum3.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumFixedValPaperNum3.Name = "NumFixedValPaperNum3"
            Me.NumFixedValPaperNum3.ReadOnlys = False
            Me.NumFixedValPaperNum3.SelectedText = ""
            Me.NumFixedValPaperNum3.SelectionLength = 0
            Me.NumFixedValPaperNum3.SelectionStart = 1
            Me.NumFixedValPaperNum3.Size = New System.Drawing.Size(80, 20)
            Me.NumFixedValPaperNum3.TabIndex = 33
            Me.NumFixedValPaperNum3.Tag = "read;"
            Me.NumFixedValPaperNum3.TextValue = "0"
            Me.NumFixedValPaperNum3.ToolTipText = ""
            Me.NumFixedValPaperNum3.Visible = False
            '
            'NumCurValPaperNum4
            '
            Me.NumCurValPaperNum4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumCurValPaperNum4.BackColor = System.Drawing.SystemColors.Window
            Me.NumCurValPaperNum4.BorderColor = System.Drawing.Color.Empty
            Me.NumCurValPaperNum4.BorderStyle = 2
            Me.NumCurValPaperNum4.CaptionName = "전일무가"
            Me.NumCurValPaperNum4.LengthPrecision = 15
            Me.NumCurValPaperNum4.LengthScale = 0
            Me.NumCurValPaperNum4.Location = New System.Drawing.Point(707, 576)
            Me.NumCurValPaperNum4.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumCurValPaperNum4.MaxLength = 32767
            Me.NumCurValPaperNum4.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumCurValPaperNum4.Name = "NumCurValPaperNum4"
            Me.NumCurValPaperNum4.ReadOnlys = False
            Me.NumCurValPaperNum4.SelectedText = ""
            Me.NumCurValPaperNum4.SelectionLength = 0
            Me.NumCurValPaperNum4.SelectionStart = 1
            Me.NumCurValPaperNum4.Size = New System.Drawing.Size(80, 20)
            Me.NumCurValPaperNum4.TabIndex = 18
            Me.NumCurValPaperNum4.Tag = "read;"
            Me.NumCurValPaperNum4.TextValue = "0"
            Me.NumCurValPaperNum4.ToolTipText = ""
            Me.NumCurValPaperNum4.Visible = False
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Location = New System.Drawing.Point(707, 555)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(80, 18)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "기타유가2"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label1.Visible = False
            '
            'NumCurValPaperNum3
            '
            Me.NumCurValPaperNum3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumCurValPaperNum3.BackColor = System.Drawing.SystemColors.Window
            Me.NumCurValPaperNum3.BorderColor = System.Drawing.Color.Empty
            Me.NumCurValPaperNum3.BorderStyle = 2
            Me.NumCurValPaperNum3.CaptionName = "전일유가"
            Me.NumCurValPaperNum3.LengthPrecision = 15
            Me.NumCurValPaperNum3.LengthScale = 0
            Me.NumCurValPaperNum3.Location = New System.Drawing.Point(625, 576)
            Me.NumCurValPaperNum3.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumCurValPaperNum3.MaxLength = 32767
            Me.NumCurValPaperNum3.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumCurValPaperNum3.Name = "NumCurValPaperNum3"
            Me.NumCurValPaperNum3.ReadOnlys = False
            Me.NumCurValPaperNum3.SelectedText = ""
            Me.NumCurValPaperNum3.SelectionLength = 0
            Me.NumCurValPaperNum3.SelectionStart = 1
            Me.NumCurValPaperNum3.Size = New System.Drawing.Size(80, 20)
            Me.NumCurValPaperNum3.TabIndex = 17
            Me.NumCurValPaperNum3.Tag = "read;"
            Me.NumCurValPaperNum3.TextValue = "0"
            Me.NumCurValPaperNum3.ToolTipText = ""
            Me.NumCurValPaperNum3.Visible = False
            '
            'Label8
            '
            Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label8.BackColor = System.Drawing.Color.GhostWhite
            Me.Label8.Location = New System.Drawing.Point(625, 555)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(80, 18)
            Me.Label8.TabIndex = 9
            Me.Label8.Text = "기타유가1"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label8.Visible = False
            '
            'btnNew
            '
            Me.btnNew.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNew.Location = New System.Drawing.Point(677, 17)
            Me.btnNew.Name = "btnNew"
            Me.btnNew.Size = New System.Drawing.Size(109, 38)
            Me.btnNew.TabIndex = 1
            Me.btnNew.Text = "전월부수이월"
            Me.btnNew.UseVisualStyleBackColor = True
            '
            'NumYdPaperNum
            '
            Me.NumYdPaperNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumYdPaperNum.BackColor = System.Drawing.SystemColors.Window
            Me.NumYdPaperNum.BorderColor = System.Drawing.Color.Empty
            Me.NumYdPaperNum.BorderStyle = 2
            Me.NumYdPaperNum.CaptionName = "증감부수계"
            Me.NumYdPaperNum.LengthPrecision = 15
            Me.NumYdPaperNum.LengthScale = 0
            Me.NumYdPaperNum.Location = New System.Drawing.Point(426, 596)
            Me.NumYdPaperNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumYdPaperNum.MaxLength = 32767
            Me.NumYdPaperNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumYdPaperNum.Name = "NumYdPaperNum"
            Me.NumYdPaperNum.ReadOnlys = False
            Me.NumYdPaperNum.SelectedText = ""
            Me.NumYdPaperNum.SelectionLength = 0
            Me.NumYdPaperNum.SelectionStart = 1
            Me.NumYdPaperNum.Size = New System.Drawing.Size(92, 20)
            Me.NumYdPaperNum.TabIndex = 23
            Me.NumYdPaperNum.Tag = ""
            Me.NumYdPaperNum.TextValue = "0"
            Me.NumYdPaperNum.ToolTipText = ""
            '
            'NumFixedNoValPaperNum
            '
            Me.NumFixedNoValPaperNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumFixedNoValPaperNum.BackColor = System.Drawing.SystemColors.Window
            Me.NumFixedNoValPaperNum.BorderColor = System.Drawing.Color.Empty
            Me.NumFixedNoValPaperNum.BorderStyle = 2
            Me.NumFixedNoValPaperNum.CaptionName = "당일부수계"
            Me.NumFixedNoValPaperNum.LengthPrecision = 15
            Me.NumFixedNoValPaperNum.LengthScale = 0
            Me.NumFixedNoValPaperNum.Location = New System.Drawing.Point(426, 618)
            Me.NumFixedNoValPaperNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumFixedNoValPaperNum.MaxLength = 32767
            Me.NumFixedNoValPaperNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumFixedNoValPaperNum.Name = "NumFixedNoValPaperNum"
            Me.NumFixedNoValPaperNum.ReadOnlys = False
            Me.NumFixedNoValPaperNum.SelectedText = ""
            Me.NumFixedNoValPaperNum.SelectionLength = 0
            Me.NumFixedNoValPaperNum.SelectionStart = 1
            Me.NumFixedNoValPaperNum.Size = New System.Drawing.Size(92, 20)
            Me.NumFixedNoValPaperNum.TabIndex = 31
            Me.NumFixedNoValPaperNum.Tag = "read;"
            Me.NumFixedNoValPaperNum.TextValue = "0"
            Me.NumFixedNoValPaperNum.ToolTipText = ""
            '
            'NumCurValPaperNum
            '
            Me.NumCurValPaperNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumCurValPaperNum.BackColor = System.Drawing.SystemColors.Window
            Me.NumCurValPaperNum.BorderColor = System.Drawing.Color.Empty
            Me.NumCurValPaperNum.BorderStyle = 2
            Me.NumCurValPaperNum.CaptionName = "전일부수계"
            Me.NumCurValPaperNum.LengthPrecision = 15
            Me.NumCurValPaperNum.LengthScale = 0
            Me.NumCurValPaperNum.Location = New System.Drawing.Point(426, 575)
            Me.NumCurValPaperNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumCurValPaperNum.MaxLength = 32767
            Me.NumCurValPaperNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumCurValPaperNum.Name = "NumCurValPaperNum"
            Me.NumCurValPaperNum.ReadOnlys = False
            Me.NumCurValPaperNum.SelectedText = ""
            Me.NumCurValPaperNum.SelectionLength = 0
            Me.NumCurValPaperNum.SelectionStart = 1
            Me.NumCurValPaperNum.Size = New System.Drawing.Size(92, 20)
            Me.NumCurValPaperNum.TabIndex = 15
            Me.NumCurValPaperNum.Tag = "read;"
            Me.NumCurValPaperNum.TextValue = "0"
            Me.NumCurValPaperNum.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label9.BackColor = System.Drawing.Color.GhostWhite
            Me.Label9.Location = New System.Drawing.Point(426, 554)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(92, 18)
            Me.Label9.TabIndex = 7
            Me.Label9.Text = "무가부수"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'NumYdPaperNumT
            '
            Me.NumYdPaperNumT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumYdPaperNumT.BackColor = System.Drawing.SystemColors.Window
            Me.NumYdPaperNumT.BorderColor = System.Drawing.Color.Empty
            Me.NumYdPaperNumT.BorderStyle = 2
            Me.NumYdPaperNumT.CaptionName = "증감부수계"
            Me.NumYdPaperNumT.LengthPrecision = 15
            Me.NumYdPaperNumT.LengthScale = 0
            Me.NumYdPaperNumT.Location = New System.Drawing.Point(524, 596)
            Me.NumYdPaperNumT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumYdPaperNumT.MaxLength = 32767
            Me.NumYdPaperNumT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumYdPaperNumT.Name = "NumYdPaperNumT"
            Me.NumYdPaperNumT.ReadOnlys = False
            Me.NumYdPaperNumT.SelectedText = ""
            Me.NumYdPaperNumT.SelectionLength = 0
            Me.NumYdPaperNumT.SelectionStart = 1
            Me.NumYdPaperNumT.Size = New System.Drawing.Size(97, 20)
            Me.NumYdPaperNumT.TabIndex = 24
            Me.NumYdPaperNumT.Tag = "read;"
            Me.NumYdPaperNumT.TextValue = "0"
            Me.NumYdPaperNumT.ToolTipText = ""
            '
            'NumFixedNoValPaperNumT
            '
            Me.NumFixedNoValPaperNumT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumFixedNoValPaperNumT.BackColor = System.Drawing.SystemColors.Window
            Me.NumFixedNoValPaperNumT.BorderColor = System.Drawing.Color.Empty
            Me.NumFixedNoValPaperNumT.BorderStyle = 2
            Me.NumFixedNoValPaperNumT.CaptionName = "당일부수계"
            Me.NumFixedNoValPaperNumT.LengthPrecision = 15
            Me.NumFixedNoValPaperNumT.LengthScale = 0
            Me.NumFixedNoValPaperNumT.Location = New System.Drawing.Point(524, 618)
            Me.NumFixedNoValPaperNumT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumFixedNoValPaperNumT.MaxLength = 32767
            Me.NumFixedNoValPaperNumT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumFixedNoValPaperNumT.Name = "NumFixedNoValPaperNumT"
            Me.NumFixedNoValPaperNumT.ReadOnlys = False
            Me.NumFixedNoValPaperNumT.SelectedText = ""
            Me.NumFixedNoValPaperNumT.SelectionLength = 0
            Me.NumFixedNoValPaperNumT.SelectionStart = 1
            Me.NumFixedNoValPaperNumT.Size = New System.Drawing.Size(97, 20)
            Me.NumFixedNoValPaperNumT.TabIndex = 32
            Me.NumFixedNoValPaperNumT.Tag = "read;"
            Me.NumFixedNoValPaperNumT.TextValue = "0"
            Me.NumFixedNoValPaperNumT.ToolTipText = ""
            '
            'NumCurValPaperNumT
            '
            Me.NumCurValPaperNumT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.NumCurValPaperNumT.BackColor = System.Drawing.SystemColors.Window
            Me.NumCurValPaperNumT.BorderColor = System.Drawing.Color.Empty
            Me.NumCurValPaperNumT.BorderStyle = 2
            Me.NumCurValPaperNumT.CaptionName = "전일부수계"
            Me.NumCurValPaperNumT.LengthPrecision = 15
            Me.NumCurValPaperNumT.LengthScale = 0
            Me.NumCurValPaperNumT.Location = New System.Drawing.Point(524, 575)
            Me.NumCurValPaperNumT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.NumCurValPaperNumT.MaxLength = 32767
            Me.NumCurValPaperNumT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.NumCurValPaperNumT.Name = "NumCurValPaperNumT"
            Me.NumCurValPaperNumT.ReadOnlys = False
            Me.NumCurValPaperNumT.SelectedText = ""
            Me.NumCurValPaperNumT.SelectionLength = 0
            Me.NumCurValPaperNumT.SelectionStart = 1
            Me.NumCurValPaperNumT.Size = New System.Drawing.Size(97, 20)
            Me.NumCurValPaperNumT.TabIndex = 16
            Me.NumCurValPaperNumT.Tag = "read;"
            Me.NumCurValPaperNumT.TextValue = "0"
            Me.NumCurValPaperNumT.ToolTipText = ""
            '
            'Label10
            '
            Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label10.BackColor = System.Drawing.Color.GhostWhite
            Me.Label10.Location = New System.Drawing.Point(524, 554)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(97, 18)
            Me.Label10.TabIndex = 8
            Me.Label10.Text = "부수계"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtEmployee_R
            '
            Me.txtEmployee_R.BackColor = System.Drawing.SystemColors.Window
            Me.txtEmployee_R.BorderColor = System.Drawing.Color.Empty
            Me.txtEmployee_R.BorderStyle = 2
            Me.txtEmployee_R.CaptionName = "담당 명"
            Me.txtEmployee_R.Location = New System.Drawing.Point(273, 15)
            Me.txtEmployee_R.MaxLength = 32767
            Me.txtEmployee_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtEmployee_R.Multiline = False
            Me.txtEmployee_R.Name = "txtEmployee_R"
            Me.txtEmployee_R.ReadOnlys = False
            Me.txtEmployee_R.SelectedText = ""
            Me.txtEmployee_R.SelectionLength = 0
            Me.txtEmployee_R.SelectionStart = 0
            Me.txtEmployee_R.Size = New System.Drawing.Size(115, 20)
            Me.txtEmployee_R.TabIndex = 1585
            Me.txtEmployee_R.Tag = Nothing
            Me.txtEmployee_R.TextAlign = 0
            Me.txtEmployee_R.TextValue = ""
            Me.txtEmployee_R.ToolTipText = ""
            Me.txtEmployee_R.Visible = False
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(202, 18)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(65, 15)
            Me.Label11.TabIndex = 1584
            Me.Label11.Text = "담당명"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label11.Visible = False
            '
            'txtBranchNm_R
            '
            Me.txtBranchNm_R.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm_R.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm_R.BorderStyle = 2
            Me.txtBranchNm_R.CaptionName = "지국 명"
            Me.txtBranchNm_R.Location = New System.Drawing.Point(102, 37)
            Me.txtBranchNm_R.MaxLength = 32767
            Me.txtBranchNm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm_R.Multiline = False
            Me.txtBranchNm_R.Name = "txtBranchNm_R"
            Me.txtBranchNm_R.ReadOnlys = False
            Me.txtBranchNm_R.SelectedText = ""
            Me.txtBranchNm_R.SelectionLength = 0
            Me.txtBranchNm_R.SelectionStart = 0
            Me.txtBranchNm_R.Size = New System.Drawing.Size(286, 20)
            Me.txtBranchNm_R.TabIndex = 1583
            Me.txtBranchNm_R.Tag = Nothing
            Me.txtBranchNm_R.TextAlign = 0
            Me.txtBranchNm_R.TextValue = ""
            Me.txtBranchNm_R.ToolTipText = ""
            '
            'lblReaderNm_2
            '
            Me.lblReaderNm_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReaderNm_2.Location = New System.Drawing.Point(31, 40)
            Me.lblReaderNm_2.Name = "lblReaderNm_2"
            Me.lblReaderNm_2.Size = New System.Drawing.Size(65, 15)
            Me.lblReaderNm_2.TabIndex = 1582
            Me.lblReaderNm_2.Text = "지국명"
            Me.lblReaderNm_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optExpAmt4)
            Me.Opt2.Controls.Add(Me.optExpAmt3)
            Me.Opt2.Controls.Add(Me.optExpAmt1)
            Me.Opt2.Controls.Add(Me.optExpAmt2)
            Me.Opt2.Location = New System.Drawing.Point(3, 67)
            Me.Opt2.MaximumSize = New System.Drawing.Size(500, 100)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(469, 47)
            Me.Opt2.TabIndex = 1635
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optExpAmt4
            '
            Me.optExpAmt4.AutoSize = True
            Me.optExpAmt4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt4.Location = New System.Drawing.Point(235, 26)
            Me.optExpAmt4.Name = "optExpAmt4"
            Me.optExpAmt4.Size = New System.Drawing.Size(207, 16)
            Me.optExpAmt4.TabIndex = 345
            Me.optExpAmt4.Text = "담당별 본사 월 유가부수 증감내역"
            Me.optExpAmt4.UseVisualStyleBackColor = False
            '
            'optExpAmt3
            '
            Me.optExpAmt3.AutoSize = True
            Me.optExpAmt3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt3.Location = New System.Drawing.Point(235, 5)
            Me.optExpAmt3.Name = "optExpAmt3"
            Me.optExpAmt3.Size = New System.Drawing.Size(163, 16)
            Me.optExpAmt3.TabIndex = 344
            Me.optExpAmt3.Text = "독자부수 변동사항 총괄표"
            Me.optExpAmt3.UseVisualStyleBackColor = False
            '
            'optExpAmt1
            '
            Me.optExpAmt1.AutoSize = True
            Me.optExpAmt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt1.Checked = True
            Me.optExpAmt1.Location = New System.Drawing.Point(15, 5)
            Me.optExpAmt1.Name = "optExpAmt1"
            Me.optExpAmt1.Size = New System.Drawing.Size(203, 16)
            Me.optExpAmt1.TabIndex = 342
            Me.optExpAmt1.TabStop = True
            Me.optExpAmt1.Text = "지국별 독자부수 변동사항 총괄표"
            Me.optExpAmt1.UseVisualStyleBackColor = False
            '
            'optExpAmt2
            '
            Me.optExpAmt2.AutoSize = True
            Me.optExpAmt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt2.Location = New System.Drawing.Point(15, 25)
            Me.optExpAmt2.Name = "optExpAmt2"
            Me.optExpAmt2.Size = New System.Drawing.Size(203, 16)
            Me.optExpAmt2.TabIndex = 343
            Me.optExpAmt2.Text = "담당별 독자부수 변동사항 총괄표"
            Me.optExpAmt2.UseVisualStyleBackColor = False
            '
            'Label12
            '
            Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label12.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label12.Location = New System.Drawing.Point(478, 72)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(327, 37)
            Me.Label12.TabIndex = 1675
            Me.Label12.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(474, 67)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(332, 47)
            Me.PictureBox1.TabIndex = 1676
            Me.PictureBox1.TabStop = False
            '
            'PNH201
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.txtEmployee_R)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.txtBranchNm_R)
            Me.Controls.Add(Me.lblReaderNm_2)
            Me.Controls.Add(Me.NumYdPaperNumT)
            Me.Controls.Add(Me.NumFixedNoValPaperNumT)
            Me.Controls.Add(Me.NumCurValPaperNumT)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.NumYdPaperNum)
            Me.Controls.Add(Me.NumFixedNoValPaperNum)
            Me.Controls.Add(Me.NumCurValPaperNum)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.btnNew)
            Me.Controls.Add(Me.NumYdPaperNum4)
            Me.Controls.Add(Me.NumYdPaperNum3)
            Me.Controls.Add(Me.NumFixedValPaperNum4)
            Me.Controls.Add(Me.NumFixedValPaperNum3)
            Me.Controls.Add(Me.NumCurValPaperNum4)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.NumCurValPaperNum3)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.NumYdPaperNumYT)
            Me.Controls.Add(Me.NumYdPaperNum2)
            Me.Controls.Add(Me.NumYdPaperNum1)
            Me.Controls.Add(Me.NumFixedValPaperNumYT)
            Me.Controls.Add(Me.NumFixedValPaperNum2)
            Me.Controls.Add(Me.NumFixedValPaperNum1)
            Me.Controls.Add(Me.NumCurValPaperNumYT)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.NumCurValPaperNum2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.numCurValPaperNum1)
            Me.Controls.Add(Me.Label40)
            Me.Controls.Add(Me.dtpBaseMMBefore)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpBaseMMtoday)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.picIo_2)
            Me.Controls.Add(Me.dtpBaseYear)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNH201"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dtpBaseYear As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents NumYdPaperNumYT As ubiLease.CommonControls.num
        Friend WithEvents NumYdPaperNum2 As ubiLease.CommonControls.num
        Friend WithEvents NumYdPaperNum1 As ubiLease.CommonControls.num
        Friend WithEvents NumFixedValPaperNumYT As ubiLease.CommonControls.num
        Friend WithEvents NumFixedValPaperNum2 As ubiLease.CommonControls.num
        Friend WithEvents NumFixedValPaperNum1 As ubiLease.CommonControls.num
        Friend WithEvents NumCurValPaperNumYT As ubiLease.CommonControls.num
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents NumCurValPaperNum2 As ubiLease.CommonControls.num
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents numCurValPaperNum1 As ubiLease.CommonControls.num
        Friend WithEvents Label40 As System.Windows.Forms.Label
        Friend WithEvents dtpBaseMMBefore As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpBaseMMtoday As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents NumYdPaperNum4 As ubiLease.CommonControls.num
        Friend WithEvents NumYdPaperNum3 As ubiLease.CommonControls.num
        Friend WithEvents NumFixedValPaperNum4 As ubiLease.CommonControls.num
        Friend WithEvents NumFixedValPaperNum3 As ubiLease.CommonControls.num
        Friend WithEvents NumCurValPaperNum4 As ubiLease.CommonControls.num
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents NumCurValPaperNum3 As ubiLease.CommonControls.num
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents btnNew As ubiLease.CommonControls.btn
        Friend WithEvents NumYdPaperNum As ubiLease.CommonControls.num
        Friend WithEvents NumFixedNoValPaperNum As ubiLease.CommonControls.num
        Friend WithEvents NumCurValPaperNum As ubiLease.CommonControls.num
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents NumYdPaperNumT As ubiLease.CommonControls.num
        Friend WithEvents NumFixedNoValPaperNumT As ubiLease.CommonControls.num
        Friend WithEvents NumCurValPaperNumT As ubiLease.CommonControls.num
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtEmployee_R As ubiLease.CommonControls.txt
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm_R As ubiLease.CommonControls.txt
        Friend WithEvents lblReaderNm_2 As System.Windows.Forms.Label
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optExpAmt4 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt3 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt1 As System.Windows.Forms.RadioButton
        Friend WithEvents optExpAmt2 As System.Windows.Forms.RadioButton
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox


    End Class

End Namespace
