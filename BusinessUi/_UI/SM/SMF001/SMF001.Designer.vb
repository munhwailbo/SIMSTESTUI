Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMF001
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMF001))
            Me.picIo_2_2 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.txtSubject = New ubiLease.CommonControls.txt
            Me.lblUIID = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.cboSystemDivision = New ubiLease.CommonControls.cbo
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.dtpReceiptDateFrom = New ubiLease.CommonControls.dtp
            Me.lblDongCode = New System.Windows.Forms.Label
            Me.picIo_2_1 = New System.Windows.Forms.PictureBox
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.lblEmployee = New System.Windows.Forms.Label
            Me.cboReceiptDivision = New ubiLease.CommonControls.cbo
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtInFirmTelephoneNumber = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpManagementTerm = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.cboUnderwriter = New ubiLease.CommonControls.cbo
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.cboWorkStates = New ubiLease.CommonControls.cbo
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpManagementProgramDate = New ubiLease.CommonControls.dtp
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.cboWorker = New ubiLease.CommonControls.cbo
            Me.popProgramID = New ubiLease.CommonControls.pop
            Me.dtpManagementDate = New ubiLease.CommonControls.dtp
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.txtDemandMatters = New ubiLease.CommonControls.txt
            Me.txtManagementInternalUse = New ubiLease.CommonControls.txt
            Me.txtOccurrenceCause = New ubiLease.CommonControls.txt
            Me.numOrders = New ubiLease.CommonControls.num
            Me.numbbsSeq = New ubiLease.CommonControls.num
            Me.cboSystemDivision_2 = New ubiLease.CommonControls.cbo
            Me.dtpReceiptDate_2 = New ubiLease.CommonControls.dtp
            Me.Label14 = New System.Windows.Forms.Label
            Me.Label15 = New System.Windows.Forms.Label
            Me.dtpReceiptDateTo = New ubiLease.CommonControls.dtp
            Me.Label16 = New System.Windows.Forms.Label
            Me.btnReceiptCopy = New ubiLease.CommonControls.btn
            Me.txtReceiptDate = New ubiLease.CommonControls.txt
            Me.Label17 = New System.Windows.Forms.Label
            Me.cboWorkDivision = New ubiLease.CommonControls.cbo
            Me.Label18 = New System.Windows.Forms.Label
            Me.txtDemandMattersDummy = New System.Windows.Forms.TextBox
            Me.txtManagementInternalUseDummy = New System.Windows.Forms.TextBox
            Me.txtOccurrenceCauseDummy = New System.Windows.Forms.TextBox
            Me.TabControl1 = New System.Windows.Forms.TabControl
            Me.TabPage1 = New System.Windows.Forms.TabPage
            Me.TabPage2 = New System.Windows.Forms.TabPage
            Me.TabPage3 = New System.Windows.Forms.TabPage
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'picIo_2_2
            '
            Me.picIo_2_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_2.Location = New System.Drawing.Point(5, 341)
            Me.picIo_2_2.Name = "picIo_2_2"
            Me.picIo_2_2.Size = New System.Drawing.Size(800, 303)
            Me.picIo_2_2.TabIndex = 8
            Me.picIo_2_2.TabStop = False
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
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
            Me.grd_1.Location = New System.Drawing.Point(5, 58)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(496, 279)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 100
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'txtSubject
            '
            Me.txtSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSubject.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubject.BorderColor = System.Drawing.Color.Empty
            Me.txtSubject.BorderStyle = 2
            Me.txtSubject.CaptionName = "화면 ID"
            Me.txtSubject.Location = New System.Drawing.Point(71, 350)
            Me.txtSubject.MaxLength = 255
            Me.txtSubject.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSubject.Multiline = False
            Me.txtSubject.Name = "txtSubject"
            Me.txtSubject.ReadOnlys = False
            Me.txtSubject.SelectedText = ""
            Me.txtSubject.SelectionLength = 0
            Me.txtSubject.SelectionStart = 0
            Me.txtSubject.Size = New System.Drawing.Size(727, 20)
            Me.txtSubject.TabIndex = 16
            Me.txtSubject.Tag = ""
            Me.txtSubject.TextAlign = 0
            Me.txtSubject.TextValue = ""
            Me.txtSubject.ToolTipText = ""
            '
            'lblUIID
            '
            Me.lblUIID.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblUIID.Location = New System.Drawing.Point(18, 351)
            Me.lblUIID.Name = "lblUIID"
            Me.lblUIID.Size = New System.Drawing.Size(35, 16)
            Me.lblUIID.TabIndex = 12
            Me.lblUIID.Text = "제목"
            Me.lblUIID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 6)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(800, 47)
            Me.picCriteria.TabIndex = 70
            Me.picCriteria.TabStop = False
            '
            'cboSystemDivision
            '
            Me.cboSystemDivision.CaptionName = "시스템 구분 명"
            Me.cboSystemDivision.ListCount = 0
            Me.cboSystemDivision.Location = New System.Drawing.Point(92, 18)
            Me.cboSystemDivision.Name = "cboSystemDivision"
            Me.cboSystemDivision.ReadOnlys = False
            Me.cboSystemDivision.Size = New System.Drawing.Size(94, 20)
            Me.cboSystemDivision.TabIndex = 1
            Me.cboSystemDivision.Tag = "code(시스템 구분 명|전체);"
            Me.cboSystemDivision.TextValue = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(18, 22)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(72, 18)
            Me.lblCodeDivisionHangulName.TabIndex = 0
            Me.lblCodeDivisionHangulName.Text = "시스템 구분"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpReceiptDateFrom
            '
            Me.dtpReceiptDateFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateFrom.BorderStyle = 2
            Me.dtpReceiptDateFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateFrom.CaptionName = "배부 년 월"
            Me.dtpReceiptDateFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateFrom.Location = New System.Drawing.Point(259, 18)
            Me.dtpReceiptDateFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateFrom.MaxLength = 0
            Me.dtpReceiptDateFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateFrom.Name = "dtpReceiptDateFrom"
            Me.dtpReceiptDateFrom.ReadOnlys = False
            Me.dtpReceiptDateFrom.SelectedText = ""
            Me.dtpReceiptDateFrom.SelectionLength = 0
            Me.dtpReceiptDateFrom.SelectionStart = 0
            Me.dtpReceiptDateFrom.Size = New System.Drawing.Size(94, 20)
            Me.dtpReceiptDateFrom.TabIndex = 2
            Me.dtpReceiptDateFrom.TabStop = False
            Me.dtpReceiptDateFrom.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDateFrom.TextAlign = 0
            Me.dtpReceiptDateFrom.TextValue = Nothing
            Me.dtpReceiptDateFrom.ToolTipText = ""
            '
            'lblDongCode
            '
            Me.lblDongCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDongCode.Location = New System.Drawing.Point(202, 23)
            Me.lblDongCode.Name = "lblDongCode"
            Me.lblDongCode.Size = New System.Drawing.Size(54, 12)
            Me.lblDongCode.TabIndex = 469
            Me.lblDongCode.Text = "접수일자"
            Me.lblDongCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picIo_2_1
            '
            Me.picIo_2_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_1.Location = New System.Drawing.Point(507, 58)
            Me.picIo_2_1.Name = "picIo_2_1"
            Me.picIo_2_1.Size = New System.Drawing.Size(298, 279)
            Me.picIo_2_1.TabIndex = 471
            Me.picIo_2_1.TabStop = False
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "년도 차수 코드"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 60
            Me.popEmployeeNumber.Location = New System.Drawing.Point(595, 132)
            Me.popEmployeeNumber.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popEmployeeNumber.MaxLength = 6
            Me.popEmployeeNumber.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeNumber.Name = "popEmployeeNumber"
            Me.popEmployeeNumber.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeNumber.NameText = ""
            Me.popEmployeeNumber.ReadOnlys = False
            Me.popEmployeeNumber.SelectedText = ""
            Me.popEmployeeNumber.SelectionLength = 0
            Me.popEmployeeNumber.SelectionStart = 0
            Me.popEmployeeNumber.Size = New System.Drawing.Size(203, 20)
            Me.popEmployeeNumber.TabIndex = 7
            Me.popEmployeeNumber.Tag = "code(사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'lblEmployee
            '
            Me.lblEmployee.BackColor = System.Drawing.Color.GhostWhite
            Me.lblEmployee.Location = New System.Drawing.Point(540, 136)
            Me.lblEmployee.Name = "lblEmployee"
            Me.lblEmployee.Size = New System.Drawing.Size(54, 14)
            Me.lblEmployee.TabIndex = 472
            Me.lblEmployee.Text = "요청자"
            Me.lblEmployee.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboReceiptDivision
            '
            Me.cboReceiptDivision.CaptionName = "시스템 구분 명"
            Me.cboReceiptDivision.ListCount = 0
            Me.cboReceiptDivision.Location = New System.Drawing.Point(595, 180)
            Me.cboReceiptDivision.Name = "cboReceiptDivision"
            Me.cboReceiptDivision.ReadOnlys = False
            Me.cboReceiptDivision.Size = New System.Drawing.Size(203, 20)
            Me.cboReceiptDivision.TabIndex = 9
            Me.cboReceiptDivision.Tag = "need;code(수정 요청서 접수 구분|선택하세요.);"
            Me.cboReceiptDivision.TextValue = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(534, 183)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(60, 14)
            Me.Label1.TabIndex = 475
            Me.Label1.Text = "접수구분"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtInFirmTelephoneNumber
            '
            Me.txtInFirmTelephoneNumber.BackColor = System.Drawing.SystemColors.Window
            Me.txtInFirmTelephoneNumber.BorderColor = System.Drawing.Color.Empty
            Me.txtInFirmTelephoneNumber.BorderStyle = 2
            Me.txtInFirmTelephoneNumber.CaptionName = "화면 ID"
            Me.txtInFirmTelephoneNumber.Location = New System.Drawing.Point(595, 154)
            Me.txtInFirmTelephoneNumber.MaxLength = 20
            Me.txtInFirmTelephoneNumber.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtInFirmTelephoneNumber.Multiline = False
            Me.txtInFirmTelephoneNumber.Name = "txtInFirmTelephoneNumber"
            Me.txtInFirmTelephoneNumber.ReadOnlys = False
            Me.txtInFirmTelephoneNumber.SelectedText = ""
            Me.txtInFirmTelephoneNumber.SelectionLength = 0
            Me.txtInFirmTelephoneNumber.SelectionStart = 0
            Me.txtInFirmTelephoneNumber.Size = New System.Drawing.Size(203, 23)
            Me.txtInFirmTelephoneNumber.TabIndex = 8
            Me.txtInFirmTelephoneNumber.Tag = ""
            Me.txtInFirmTelephoneNumber.TextAlign = 0
            Me.txtInFirmTelephoneNumber.TextValue = ""
            Me.txtInFirmTelephoneNumber.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Location = New System.Drawing.Point(548, 160)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 14)
            Me.Label2.TabIndex = 478
            Me.Label2.Text = "연락처"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpManagementTerm
            '
            Me.dtpManagementTerm.BackColor = System.Drawing.SystemColors.Window
            Me.dtpManagementTerm.BorderColor = System.Drawing.Color.Empty
            Me.dtpManagementTerm.BorderStyle = 2
            Me.dtpManagementTerm.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpManagementTerm.CaptionName = "배부 년 월"
            Me.dtpManagementTerm.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpManagementTerm.Location = New System.Drawing.Point(595, 246)
            Me.dtpManagementTerm.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpManagementTerm.MaxLength = 0
            Me.dtpManagementTerm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpManagementTerm.Name = "dtpManagementTerm"
            Me.dtpManagementTerm.ReadOnlys = False
            Me.dtpManagementTerm.SelectedText = ""
            Me.dtpManagementTerm.SelectionLength = 0
            Me.dtpManagementTerm.SelectionStart = 0
            Me.dtpManagementTerm.Size = New System.Drawing.Size(94, 20)
            Me.dtpManagementTerm.TabIndex = 12
            Me.dtpManagementTerm.TabStop = False
            Me.dtpManagementTerm.Tag = "format(&&&&-&&-&&);"
            Me.dtpManagementTerm.TextAlign = 0
            Me.dtpManagementTerm.TextValue = Nothing
            Me.dtpManagementTerm.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(540, 249)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(54, 14)
            Me.Label3.TabIndex = 479
            Me.Label3.Text = "처리기한"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboUnderwriter
            '
            Me.cboUnderwriter.CaptionName = "시스템 구분 명"
            Me.cboUnderwriter.ListCount = 0
            Me.cboUnderwriter.Location = New System.Drawing.Point(595, 225)
            Me.cboUnderwriter.Name = "cboUnderwriter"
            Me.cboUnderwriter.ReadOnlys = False
            Me.cboUnderwriter.Size = New System.Drawing.Size(203, 20)
            Me.cboUnderwriter.TabIndex = 11
            Me.cboUnderwriter.Tag = "need;code(개발자 코드|선택하세요.);"
            Me.cboUnderwriter.TextValue = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(534, 229)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(60, 14)
            Me.Label4.TabIndex = 481
            Me.Label4.Text = "접수자"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Location = New System.Drawing.Point(548, 113)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(46, 14)
            Me.Label5.TabIndex = 483
            Me.Label5.Text = "화면ID"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboWorkStates
            '
            Me.cboWorkStates.CaptionName = "시스템 구분 명"
            Me.cboWorkStates.ListCount = 0
            Me.cboWorkStates.Location = New System.Drawing.Point(595, 268)
            Me.cboWorkStates.Name = "cboWorkStates"
            Me.cboWorkStates.ReadOnlys = False
            Me.cboWorkStates.Size = New System.Drawing.Size(203, 20)
            Me.cboWorkStates.TabIndex = 13
            Me.cboWorkStates.Tag = "need;code(작업 상태|선택하세요.);"
            Me.cboWorkStates.TextValue = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(525, 271)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(69, 14)
            Me.Label6.TabIndex = 485
            Me.Label6.Text = "작업상태"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpManagementProgramDate
            '
            Me.dtpManagementProgramDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpManagementProgramDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpManagementProgramDate.BorderStyle = 2
            Me.dtpManagementProgramDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpManagementProgramDate.CaptionName = "배부 년 월"
            Me.dtpManagementProgramDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpManagementProgramDate.Location = New System.Drawing.Point(595, 290)
            Me.dtpManagementProgramDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpManagementProgramDate.MaxLength = 0
            Me.dtpManagementProgramDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpManagementProgramDate.Name = "dtpManagementProgramDate"
            Me.dtpManagementProgramDate.ReadOnlys = False
            Me.dtpManagementProgramDate.SelectedText = ""
            Me.dtpManagementProgramDate.SelectionLength = 0
            Me.dtpManagementProgramDate.SelectionStart = 0
            Me.dtpManagementProgramDate.Size = New System.Drawing.Size(94, 20)
            Me.dtpManagementProgramDate.TabIndex = 14
            Me.dtpManagementProgramDate.TabStop = False
            Me.dtpManagementProgramDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpManagementProgramDate.TextAlign = 0
            Me.dtpManagementProgramDate.TextValue = Nothing
            Me.dtpManagementProgramDate.ToolTipText = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(516, 294)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(78, 14)
            Me.Label7.TabIndex = 487
            Me.Label7.Text = "처리예정일자"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(240, 209)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(52, 16)
            Me.Label8.TabIndex = 481
            Me.Label8.Text = "작업자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.Label8.Visible = False
            '
            'cboWorker
            '
            Me.cboWorker.CaptionName = "시스템 구분 명"
            Me.cboWorker.ListCount = 0
            Me.cboWorker.Location = New System.Drawing.Point(293, 206)
            Me.cboWorker.Name = "cboWorker"
            Me.cboWorker.ReadOnlys = False
            Me.cboWorker.Size = New System.Drawing.Size(67, 20)
            Me.cboWorker.TabIndex = 10
            Me.cboWorker.Tag = "code(개발자 코드|전체);"
            Me.cboWorker.TextValue = ""
            Me.cboWorker.Visible = False
            '
            'popProgramID
            '
            Me.popProgramID.BorderColor = System.Drawing.Color.Empty
            Me.popProgramID.BorderStyle = 2
            Me.popProgramID.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popProgramID.CaptionName = "년도 차수 코드"
            Me.popProgramID.CodeText = ""
            Me.popProgramID.CodeWidth = 60
            Me.popProgramID.Location = New System.Drawing.Point(595, 109)
            Me.popProgramID.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popProgramID.MaxLength = 6
            Me.popProgramID.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popProgramID.Name = "popProgramID"
            Me.popProgramID.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popProgramID.NameText = ""
            Me.popProgramID.ReadOnlys = False
            Me.popProgramID.SelectedText = ""
            Me.popProgramID.SelectionLength = 0
            Me.popProgramID.SelectionStart = 0
            Me.popProgramID.Size = New System.Drawing.Size(203, 20)
            Me.popProgramID.TabIndex = 6
            Me.popProgramID.Tag = "code(프로그램 명);"
            Me.popProgramID.TextAlign = 0
            Me.popProgramID.TextValue = ""
            Me.popProgramID.ToolTipText = ""
            '
            'dtpManagementDate
            '
            Me.dtpManagementDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpManagementDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpManagementDate.BorderStyle = 2
            Me.dtpManagementDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpManagementDate.CaptionName = "배부 년 월"
            Me.dtpManagementDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpManagementDate.Location = New System.Drawing.Point(595, 311)
            Me.dtpManagementDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpManagementDate.MaxLength = 0
            Me.dtpManagementDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpManagementDate.Name = "dtpManagementDate"
            Me.dtpManagementDate.ReadOnlys = False
            Me.dtpManagementDate.SelectedText = ""
            Me.dtpManagementDate.SelectionLength = 0
            Me.dtpManagementDate.SelectionStart = 0
            Me.dtpManagementDate.Size = New System.Drawing.Size(94, 20)
            Me.dtpManagementDate.TabIndex = 15
            Me.dtpManagementDate.TabStop = False
            Me.dtpManagementDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpManagementDate.TextAlign = 0
            Me.dtpManagementDate.TextValue = Nothing
            Me.dtpManagementDate.ToolTipText = ""
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(540, 313)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(54, 14)
            Me.Label11.TabIndex = 501
            Me.Label11.Text = "처리일자"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.GhostWhite
            Me.Label13.Location = New System.Drawing.Point(369, 211)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(70, 11)
            Me.Label13.TabIndex = 478
            Me.Label13.Text = "게시판 순번"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.Label13.Visible = False
            '
            'txtDemandMatters
            '
            Me.txtDemandMatters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtDemandMatters.AutoScroll = True
            Me.txtDemandMatters.BackColor = System.Drawing.SystemColors.Window
            Me.txtDemandMatters.BorderColor = System.Drawing.Color.Empty
            Me.txtDemandMatters.BorderStyle = 1
            Me.txtDemandMatters.CaptionName = "내용"
            Me.txtDemandMatters.Location = New System.Drawing.Point(279, 235)
            Me.txtDemandMatters.MaximumSize = New System.Drawing.Size(776, 75)
            Me.txtDemandMatters.MaxLength = 99999999
            Me.txtDemandMatters.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDemandMatters.Multiline = True
            Me.txtDemandMatters.Name = "txtDemandMatters"
            Me.txtDemandMatters.ReadOnlys = False
            Me.txtDemandMatters.SelectedText = ""
            Me.txtDemandMatters.SelectionLength = 0
            Me.txtDemandMatters.SelectionStart = 0
            Me.txtDemandMatters.Size = New System.Drawing.Size(72, 31)
            Me.txtDemandMatters.TabIndex = 20
            Me.txtDemandMatters.Tag = ""
            Me.txtDemandMatters.TextAlign = 0
            Me.txtDemandMatters.TextValue = ""
            Me.txtDemandMatters.ToolTipText = ""
            Me.txtDemandMatters.Visible = False
            '
            'txtManagementInternalUse
            '
            Me.txtManagementInternalUse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtManagementInternalUse.AutoScroll = True
            Me.txtManagementInternalUse.BackColor = System.Drawing.SystemColors.Window
            Me.txtManagementInternalUse.BorderColor = System.Drawing.Color.Empty
            Me.txtManagementInternalUse.BorderStyle = 1
            Me.txtManagementInternalUse.CaptionName = "내용"
            Me.txtManagementInternalUse.Location = New System.Drawing.Point(357, 235)
            Me.txtManagementInternalUse.MaximumSize = New System.Drawing.Size(776, 75)
            Me.txtManagementInternalUse.MaxLength = 99999999
            Me.txtManagementInternalUse.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtManagementInternalUse.Multiline = True
            Me.txtManagementInternalUse.Name = "txtManagementInternalUse"
            Me.txtManagementInternalUse.ReadOnlys = False
            Me.txtManagementInternalUse.SelectedText = ""
            Me.txtManagementInternalUse.SelectionLength = 0
            Me.txtManagementInternalUse.SelectionStart = 0
            Me.txtManagementInternalUse.Size = New System.Drawing.Size(65, 31)
            Me.txtManagementInternalUse.TabIndex = 21
            Me.txtManagementInternalUse.Tag = ""
            Me.txtManagementInternalUse.TextAlign = 0
            Me.txtManagementInternalUse.TextValue = ""
            Me.txtManagementInternalUse.ToolTipText = ""
            Me.txtManagementInternalUse.Visible = False
            '
            'txtOccurrenceCause
            '
            Me.txtOccurrenceCause.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOccurrenceCause.AutoScroll = True
            Me.txtOccurrenceCause.BackColor = System.Drawing.SystemColors.Window
            Me.txtOccurrenceCause.BorderColor = System.Drawing.Color.Empty
            Me.txtOccurrenceCause.BorderStyle = 1
            Me.txtOccurrenceCause.CaptionName = "내용"
            Me.txtOccurrenceCause.Location = New System.Drawing.Point(428, 235)
            Me.txtOccurrenceCause.MaximumSize = New System.Drawing.Size(776, 75)
            Me.txtOccurrenceCause.MaxLength = 99999999
            Me.txtOccurrenceCause.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtOccurrenceCause.Multiline = True
            Me.txtOccurrenceCause.Name = "txtOccurrenceCause"
            Me.txtOccurrenceCause.ReadOnlys = False
            Me.txtOccurrenceCause.SelectedText = ""
            Me.txtOccurrenceCause.SelectionLength = 0
            Me.txtOccurrenceCause.SelectionStart = 0
            Me.txtOccurrenceCause.Size = New System.Drawing.Size(64, 31)
            Me.txtOccurrenceCause.TabIndex = 22
            Me.txtOccurrenceCause.Tag = ""
            Me.txtOccurrenceCause.TextAlign = 0
            Me.txtOccurrenceCause.TextValue = ""
            Me.txtOccurrenceCause.ToolTipText = ""
            Me.txtOccurrenceCause.Visible = False
            '
            'numOrders
            '
            Me.numOrders.BackColor = System.Drawing.SystemColors.Window
            Me.numOrders.BorderColor = System.Drawing.Color.Empty
            Me.numOrders.BorderStyle = 2
            Me.numOrders.CaptionName = "총 지급액"
            Me.numOrders.LengthPrecision = 15
            Me.numOrders.LengthScale = 0
            Me.numOrders.Location = New System.Drawing.Point(706, 289)
            Me.numOrders.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numOrders.MaxLength = 0
            Me.numOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numOrders.Name = "numOrders"
            Me.numOrders.ReadOnlys = False
            Me.numOrders.SelectedText = ""
            Me.numOrders.SelectionLength = 0
            Me.numOrders.SelectionStart = 1
            Me.numOrders.Size = New System.Drawing.Size(72, 20)
            Me.numOrders.TabIndex = 530
            Me.numOrders.Tag = "format(#,###);"
            Me.numOrders.TextValue = "0"
            Me.numOrders.ToolTipText = ""
            Me.numOrders.Visible = False
            '
            'numbbsSeq
            '
            Me.numbbsSeq.BackColor = System.Drawing.SystemColors.Window
            Me.numbbsSeq.BorderColor = System.Drawing.Color.Empty
            Me.numbbsSeq.BorderStyle = 2
            Me.numbbsSeq.CaptionName = "총 지급액"
            Me.numbbsSeq.LengthPrecision = 15
            Me.numbbsSeq.LengthScale = 0
            Me.numbbsSeq.Location = New System.Drawing.Point(445, 207)
            Me.numbbsSeq.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numbbsSeq.MaxLength = 0
            Me.numbbsSeq.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numbbsSeq.Name = "numbbsSeq"
            Me.numbbsSeq.ReadOnlys = False
            Me.numbbsSeq.SelectedText = ""
            Me.numbbsSeq.SelectionLength = 0
            Me.numbbsSeq.SelectionStart = 1
            Me.numbbsSeq.Size = New System.Drawing.Size(47, 20)
            Me.numbbsSeq.TabIndex = 6
            Me.numbbsSeq.Tag = ""
            Me.numbbsSeq.TextValue = "0"
            Me.numbbsSeq.ToolTipText = ""
            Me.numbbsSeq.Visible = False
            '
            'cboSystemDivision_2
            '
            Me.cboSystemDivision_2.CaptionName = "시스템 구분 명"
            Me.cboSystemDivision_2.ListCount = 0
            Me.cboSystemDivision_2.Location = New System.Drawing.Point(595, 62)
            Me.cboSystemDivision_2.Name = "cboSystemDivision_2"
            Me.cboSystemDivision_2.ReadOnlys = False
            Me.cboSystemDivision_2.Size = New System.Drawing.Size(94, 20)
            Me.cboSystemDivision_2.TabIndex = 4
            Me.cboSystemDivision_2.Tag = "code(시스템 구분 명|전체);"
            Me.cboSystemDivision_2.TextValue = ""
            '
            'dtpReceiptDate_2
            '
            Me.dtpReceiptDate_2.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDate_2.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDate_2.BorderStyle = 2
            Me.dtpReceiptDate_2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDate_2.CaptionName = "배부 년 월"
            Me.dtpReceiptDate_2.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDate_2.Location = New System.Drawing.Point(595, 85)
            Me.dtpReceiptDate_2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDate_2.MaxLength = 0
            Me.dtpReceiptDate_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDate_2.Name = "dtpReceiptDate_2"
            Me.dtpReceiptDate_2.ReadOnlys = False
            Me.dtpReceiptDate_2.SelectedText = ""
            Me.dtpReceiptDate_2.SelectionLength = 0
            Me.dtpReceiptDate_2.SelectionStart = 0
            Me.dtpReceiptDate_2.Size = New System.Drawing.Size(94, 20)
            Me.dtpReceiptDate_2.TabIndex = 5
            Me.dtpReceiptDate_2.TabStop = False
            Me.dtpReceiptDate_2.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDate_2.TextAlign = 0
            Me.dtpReceiptDate_2.TextValue = Nothing
            Me.dtpReceiptDate_2.ToolTipText = ""
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label14.Location = New System.Drawing.Point(522, 67)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(72, 16)
            Me.Label14.TabIndex = 0
            Me.Label14.Text = "시스템 구분"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label15.Location = New System.Drawing.Point(540, 90)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(54, 12)
            Me.Label15.TabIndex = 469
            Me.Label15.Text = "접수일자"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpReceiptDateTo
            '
            Me.dtpReceiptDateTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDateTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDateTo.BorderStyle = 2
            Me.dtpReceiptDateTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDateTo.CaptionName = "배부 년 월"
            Me.dtpReceiptDateTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDateTo.Location = New System.Drawing.Point(371, 18)
            Me.dtpReceiptDateTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDateTo.MaxLength = 0
            Me.dtpReceiptDateTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDateTo.Name = "dtpReceiptDateTo"
            Me.dtpReceiptDateTo.ReadOnlys = False
            Me.dtpReceiptDateTo.SelectedText = ""
            Me.dtpReceiptDateTo.SelectionLength = 0
            Me.dtpReceiptDateTo.SelectionStart = 0
            Me.dtpReceiptDateTo.Size = New System.Drawing.Size(94, 20)
            Me.dtpReceiptDateTo.TabIndex = 3
            Me.dtpReceiptDateTo.TabStop = False
            Me.dtpReceiptDateTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDateTo.TextAlign = 0
            Me.dtpReceiptDateTo.TextValue = Nothing
            Me.dtpReceiptDateTo.ToolTipText = ""
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label16.Location = New System.Drawing.Point(356, 23)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(14, 12)
            Me.Label16.TabIndex = 469
            Me.Label16.Text = "~"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnReceiptCopy
            '
            Me.btnReceiptCopy.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnReceiptCopy.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnReceiptCopy.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnReceiptCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnReceiptCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnReceiptCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnReceiptCopy.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnReceiptCopy.Location = New System.Drawing.Point(475, 18)
            Me.btnReceiptCopy.Name = "btnReceiptCopy"
            Me.btnReceiptCopy.Size = New System.Drawing.Size(87, 20)
            Me.btnReceiptCopy.TabIndex = 531
            Me.btnReceiptCopy.TabStop = False
            Me.btnReceiptCopy.Text = "접수 내역 복사"
            Me.btnReceiptCopy.UseVisualStyleBackColor = True
            '
            'txtReceiptDate
            '
            Me.txtReceiptDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtReceiptDate.BackColor = System.Drawing.SystemColors.Window
            Me.txtReceiptDate.BorderColor = System.Drawing.Color.Empty
            Me.txtReceiptDate.BorderStyle = 2
            Me.txtReceiptDate.CaptionName = "화면 ID"
            Me.txtReceiptDate.Location = New System.Drawing.Point(706, 311)
            Me.txtReceiptDate.MaxLength = 255
            Me.txtReceiptDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReceiptDate.Multiline = False
            Me.txtReceiptDate.Name = "txtReceiptDate"
            Me.txtReceiptDate.ReadOnlys = False
            Me.txtReceiptDate.SelectedText = ""
            Me.txtReceiptDate.SelectionLength = 0
            Me.txtReceiptDate.SelectionStart = 0
            Me.txtReceiptDate.Size = New System.Drawing.Size(72, 20)
            Me.txtReceiptDate.TabIndex = 14
            Me.txtReceiptDate.Tag = ""
            Me.txtReceiptDate.TextAlign = 0
            Me.txtReceiptDate.TextValue = ""
            Me.txtReceiptDate.ToolTipText = ""
            Me.txtReceiptDate.Visible = False
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label17.Location = New System.Drawing.Point(534, 205)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(60, 14)
            Me.Label17.TabIndex = 475
            Me.Label17.Text = "작업구분"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboWorkDivision
            '
            Me.cboWorkDivision.CaptionName = "시스템 구분 명"
            Me.cboWorkDivision.ListCount = 0
            Me.cboWorkDivision.Location = New System.Drawing.Point(595, 202)
            Me.cboWorkDivision.Name = "cboWorkDivision"
            Me.cboWorkDivision.ReadOnlys = False
            Me.cboWorkDivision.Size = New System.Drawing.Size(203, 20)
            Me.cboWorkDivision.TabIndex = 10
            Me.cboWorkDivision.Tag = "need;code(작업 구분|선택하세요.);"
            Me.cboWorkDivision.TextValue = ""
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label18.Location = New System.Drawing.Point(570, 22)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(225, 12)
            Me.Label18.TabIndex = 469
            Me.Label18.Text = "* 작업 완료시만 처리일자를 기입하세요"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtDemandMattersDummy
            '
            Me.txtDemandMattersDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDemandMattersDummy.Location = New System.Drawing.Point(0, 0)
            Me.txtDemandMattersDummy.Multiline = True
            Me.txtDemandMattersDummy.Name = "txtDemandMattersDummy"
            Me.txtDemandMattersDummy.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtDemandMattersDummy.Size = New System.Drawing.Size(777, 237)
            Me.txtDemandMattersDummy.TabIndex = 17
            '
            'txtManagementInternalUseDummy
            '
            Me.txtManagementInternalUseDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtManagementInternalUseDummy.Location = New System.Drawing.Point(0, 0)
            Me.txtManagementInternalUseDummy.Multiline = True
            Me.txtManagementInternalUseDummy.Name = "txtManagementInternalUseDummy"
            Me.txtManagementInternalUseDummy.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtManagementInternalUseDummy.Size = New System.Drawing.Size(781, 237)
            Me.txtManagementInternalUseDummy.TabIndex = 18
            '
            'txtOccurrenceCauseDummy
            '
            Me.txtOccurrenceCauseDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtOccurrenceCauseDummy.Location = New System.Drawing.Point(0, 0)
            Me.txtOccurrenceCauseDummy.Multiline = True
            Me.txtOccurrenceCauseDummy.Name = "txtOccurrenceCauseDummy"
            Me.txtOccurrenceCauseDummy.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtOccurrenceCauseDummy.Size = New System.Drawing.Size(781, 237)
            Me.txtOccurrenceCauseDummy.TabIndex = 19
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Location = New System.Drawing.Point(13, 376)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(785, 258)
            Me.TabControl1.TabIndex = 532
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.txtDemandMattersDummy)
            Me.TabPage1.Location = New System.Drawing.Point(4, 21)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(777, 233)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "요청사항"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.txtManagementInternalUseDummy)
            Me.TabPage2.Location = New System.Drawing.Point(4, 21)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(777, 233)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "처리내용"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.txtOccurrenceCauseDummy)
            Me.TabPage3.Location = New System.Drawing.Point(4, 21)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Size = New System.Drawing.Size(777, 233)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "발생요인"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'SMF001
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtOccurrenceCause)
            Me.Controls.Add(Me.txtManagementInternalUse)
            Me.Controls.Add(Me.txtDemandMatters)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.txtReceiptDate)
            Me.Controls.Add(Me.btnReceiptCopy)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.dtpReceiptDate_2)
            Me.Controls.Add(Me.cboSystemDivision_2)
            Me.Controls.Add(Me.numbbsSeq)
            Me.Controls.Add(Me.numOrders)
            Me.Controls.Add(Me.dtpManagementDate)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.popProgramID)
            Me.Controls.Add(Me.dtpManagementProgramDate)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.cboWorkStates)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.cboWorker)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.cboUnderwriter)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.dtpManagementTerm)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtInFirmTelephoneNumber)
            Me.Controls.Add(Me.cboWorkDivision)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.cboReceiptDivision)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.lblEmployee)
            Me.Controls.Add(Me.picIo_2_1)
            Me.Controls.Add(Me.dtpReceiptDateTo)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.dtpReceiptDateFrom)
            Me.Controls.Add(Me.Label18)
            Me.Controls.Add(Me.lblDongCode)
            Me.Controls.Add(Me.cboSystemDivision)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.lblUIID)
            Me.Controls.Add(Me.txtSubject)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picIo_2_2)
            Me.Name = "SMF001"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picIo_2_2 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents txtSubject As ubiLease.CommonControls.txt
        Friend WithEvents lblUIID As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents cboSystemDivision As ubiLease.CommonControls.cbo
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateFrom As ubiLease.CommonControls.dtp
        Friend WithEvents lblDongCode As System.Windows.Forms.Label
        Friend WithEvents picIo_2_1 As System.Windows.Forms.PictureBox
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents lblEmployee As System.Windows.Forms.Label
        Friend WithEvents cboReceiptDivision As ubiLease.CommonControls.cbo
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtInFirmTelephoneNumber As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpManagementTerm As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboUnderwriter As ubiLease.CommonControls.cbo
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cboWorkStates As ubiLease.CommonControls.cbo
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpManagementProgramDate As ubiLease.CommonControls.dtp
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cboWorker As ubiLease.CommonControls.cbo
        Friend WithEvents popProgramID As ubiLease.CommonControls.pop
        Friend WithEvents dtpManagementDate As ubiLease.CommonControls.dtp
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtDemandMatters As ubiLease.CommonControls.txt
        Friend WithEvents txtManagementInternalUse As ubiLease.CommonControls.txt
        Friend WithEvents txtOccurrenceCause As ubiLease.CommonControls.txt
        Friend WithEvents numOrders As ubiLease.CommonControls.num
        Friend WithEvents numbbsSeq As ubiLease.CommonControls.num
        Friend WithEvents cboSystemDivision_2 As ubiLease.CommonControls.cbo
        Friend WithEvents dtpReceiptDate_2 As ubiLease.CommonControls.dtp
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDateTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents btnReceiptCopy As ubiLease.CommonControls.btn
        Friend WithEvents txtReceiptDate As ubiLease.CommonControls.txt
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents cboWorkDivision As ubiLease.CommonControls.cbo
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents txtDemandMattersDummy As System.Windows.Forms.TextBox
        Friend WithEvents txtManagementInternalUseDummy As System.Windows.Forms.TextBox
        Friend WithEvents txtOccurrenceCauseDummy As System.Windows.Forms.TextBox
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage

    End Class

End Namespace
