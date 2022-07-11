Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMEA01
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMEA01))
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.txtBusinessPlaceCode = New ubiLease.CommonControls.txt
            Me.popPostNumber = New ubiLease.CommonControls.pop
            Me.lblFirmName_2 = New System.Windows.Forms.Label
            Me.lblBusinessPlaceCode = New System.Windows.Forms.Label
            Me.txtFirmName_2 = New ubiLease.CommonControls.txt
            Me.txtBusinessesNumber = New ubiLease.CommonControls.txt
            Me.lblBusinessesNumber = New System.Windows.Forms.Label
            Me.lblJuridicalPersonNumber = New System.Windows.Forms.Label
            Me.lblFaxNumber = New System.Windows.Forms.Label
            Me.lblPhoneNumber = New System.Windows.Forms.Label
            Me.lblAddress2 = New System.Windows.Forms.Label
            Me.lblPostNumber = New System.Windows.Forms.Label
            Me.lblRepresentativeName = New System.Windows.Forms.Label
            Me.lblBusinessConditions = New System.Windows.Forms.Label
            Me.lblItem = New System.Windows.Forms.Label
            Me.lblTaxOfficeCode = New System.Windows.Forms.Label
            Me.lblTaxOfficeName = New System.Windows.Forms.Label
            Me.lblNote = New System.Windows.Forms.Label
            Me.txtItem = New ubiLease.CommonControls.txt
            Me.txtBusinessConditions = New ubiLease.CommonControls.txt
            Me.txtFaxNumber = New ubiLease.CommonControls.txt
            Me.txtPhoneNumber = New ubiLease.CommonControls.txt
            Me.txtJuridicalPersonNumber = New ubiLease.CommonControls.txt
            Me.txtRepresentativeName = New ubiLease.CommonControls.txt
            Me.txtAddress2 = New ubiLease.CommonControls.txt
            Me.txtTaxOfficeCode = New ubiLease.CommonControls.txt
            Me.txtTaxOfficeName = New ubiLease.CommonControls.txt
            Me.txtNote = New ubiLease.CommonControls.txt
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblFirmName = New System.Windows.Forms.Label
            Me.txtFirmName = New ubiLease.CommonControls.txt
            Me.txtHomeTaxID = New ubiLease.CommonControls.txt
            Me.lblHomeTaxID = New System.Windows.Forms.Label
            Me.dtpFiscalYear = New ubiLease.CommonControls.dtp
            Me.lblFiscalYear = New System.Windows.Forms.Label
            Me.txtUpjongCode = New ubiLease.CommonControls.txt
            Me.lblUpjongCode = New System.Windows.Forms.Label
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picIo_2
            '
            Me.picIo_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(318, 61)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(487, 583)
            Me.picIo_2.TabIndex = 8
            Me.picIo_2.TabStop = False
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
            Me.grd_1.Location = New System.Drawing.Point(5, 61)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(307, 583)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 8
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'txtBusinessPlaceCode
            '
            Me.txtBusinessPlaceCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtBusinessPlaceCode.BorderColor = System.Drawing.Color.Empty
            Me.txtBusinessPlaceCode.BorderStyle = 2
            Me.txtBusinessPlaceCode.CaptionName = "사업장 코드"
            Me.txtBusinessPlaceCode.Location = New System.Drawing.Point(432, 94)
            Me.txtBusinessPlaceCode.MaxLength = 3
            Me.txtBusinessPlaceCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBusinessPlaceCode.Multiline = False
            Me.txtBusinessPlaceCode.Name = "txtBusinessPlaceCode"
            Me.txtBusinessPlaceCode.ReadOnlys = False
            Me.txtBusinessPlaceCode.SelectedText = ""
            Me.txtBusinessPlaceCode.SelectionLength = 0
            Me.txtBusinessPlaceCode.SelectionStart = 0
            Me.txtBusinessPlaceCode.Size = New System.Drawing.Size(30, 20)
            Me.txtBusinessPlaceCode.TabIndex = 42
            Me.txtBusinessPlaceCode.Tag = "need;format(###);"
            Me.txtBusinessPlaceCode.TextAlign = 0
            Me.txtBusinessPlaceCode.TextValue = Nothing
            Me.txtBusinessPlaceCode.ToolTipText = ""
            '
            'popPostNumber
            '
            Me.popPostNumber.BorderColor = System.Drawing.Color.Empty
            Me.popPostNumber.BorderStyle = 2
            Me.popPostNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popPostNumber.CaptionName = "우편번호"
            Me.popPostNumber.CodeText = ""
            Me.popPostNumber.CodeWidth = 50
            Me.popPostNumber.Location = New System.Drawing.Point(432, 254)
            Me.popPostNumber.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popPostNumber.MaxLength = 0
            Me.popPostNumber.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popPostNumber.Name = "popPostNumber"
            Me.popPostNumber.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popPostNumber.NameText = ""
            Me.popPostNumber.ReadOnlys = False
            Me.popPostNumber.SelectedText = ""
            Me.popPostNumber.SelectionLength = 0
            Me.popPostNumber.SelectionStart = 0
            Me.popPostNumber.Size = New System.Drawing.Size(362, 20)
            Me.popPostNumber.TabIndex = 41
            Me.popPostNumber.Tag = "need;code(우편번호);format(###-###);"
            Me.popPostNumber.TextAlign = 0
            Me.popPostNumber.TextValue = Nothing
            Me.popPostNumber.ToolTipText = ""
            '
            'lblFirmName_2
            '
            Me.lblFirmName_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFirmName_2.Location = New System.Drawing.Point(326, 123)
            Me.lblFirmName_2.Name = "lblFirmName_2"
            Me.lblFirmName_2.Size = New System.Drawing.Size(100, 17)
            Me.lblFirmName_2.TabIndex = 40
            Me.lblFirmName_2.Text = "상호"
            Me.lblFirmName_2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblBusinessPlaceCode
            '
            Me.lblBusinessPlaceCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBusinessPlaceCode.Location = New System.Drawing.Point(326, 97)
            Me.lblBusinessPlaceCode.Name = "lblBusinessPlaceCode"
            Me.lblBusinessPlaceCode.Size = New System.Drawing.Size(100, 17)
            Me.lblBusinessPlaceCode.TabIndex = 43
            Me.lblBusinessPlaceCode.Text = "사업장 코드"
            Me.lblBusinessPlaceCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtFirmName_2
            '
            Me.txtFirmName_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtFirmName_2.BorderColor = System.Drawing.Color.Empty
            Me.txtFirmName_2.BorderStyle = 2
            Me.txtFirmName_2.CaptionName = "상호"
            Me.txtFirmName_2.Location = New System.Drawing.Point(432, 120)
            Me.txtFirmName_2.MaxLength = 40
            Me.txtFirmName_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtFirmName_2.Multiline = False
            Me.txtFirmName_2.Name = "txtFirmName_2"
            Me.txtFirmName_2.ReadOnlys = False
            Me.txtFirmName_2.SelectedText = ""
            Me.txtFirmName_2.SelectionLength = 0
            Me.txtFirmName_2.SelectionStart = 0
            Me.txtFirmName_2.Size = New System.Drawing.Size(362, 20)
            Me.txtFirmName_2.TabIndex = 44
            Me.txtFirmName_2.Tag = "need;"
            Me.txtFirmName_2.TextAlign = 0
            Me.txtFirmName_2.TextValue = ""
            Me.txtFirmName_2.ToolTipText = ""
            '
            'txtBusinessesNumber
            '
            Me.txtBusinessesNumber.BackColor = System.Drawing.SystemColors.Window
            Me.txtBusinessesNumber.BorderColor = System.Drawing.Color.Empty
            Me.txtBusinessesNumber.BorderStyle = 2
            Me.txtBusinessesNumber.CaptionName = "사업자 등록번호"
            Me.txtBusinessesNumber.Location = New System.Drawing.Point(432, 146)
            Me.txtBusinessesNumber.MaxLength = 12
            Me.txtBusinessesNumber.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBusinessesNumber.Multiline = False
            Me.txtBusinessesNumber.Name = "txtBusinessesNumber"
            Me.txtBusinessesNumber.ReadOnlys = False
            Me.txtBusinessesNumber.SelectedText = ""
            Me.txtBusinessesNumber.SelectionLength = 0
            Me.txtBusinessesNumber.SelectionStart = 0
            Me.txtBusinessesNumber.Size = New System.Drawing.Size(100, 20)
            Me.txtBusinessesNumber.TabIndex = 45
            Me.txtBusinessesNumber.Tag = "need;format(###-##-#####)"
            Me.txtBusinessesNumber.TextAlign = 0
            Me.txtBusinessesNumber.TextValue = Nothing
            Me.txtBusinessesNumber.ToolTipText = ""
            '
            'lblBusinessesNumber
            '
            Me.lblBusinessesNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBusinessesNumber.Location = New System.Drawing.Point(326, 149)
            Me.lblBusinessesNumber.Name = "lblBusinessesNumber"
            Me.lblBusinessesNumber.Size = New System.Drawing.Size(100, 17)
            Me.lblBusinessesNumber.TabIndex = 46
            Me.lblBusinessesNumber.Tag = ""
            Me.lblBusinessesNumber.Text = "사업자 등록번호"
            Me.lblBusinessesNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblJuridicalPersonNumber
            '
            Me.lblJuridicalPersonNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblJuridicalPersonNumber.Location = New System.Drawing.Point(326, 175)
            Me.lblJuridicalPersonNumber.Name = "lblJuridicalPersonNumber"
            Me.lblJuridicalPersonNumber.Size = New System.Drawing.Size(100, 17)
            Me.lblJuridicalPersonNumber.TabIndex = 47
            Me.lblJuridicalPersonNumber.Text = "법인 등록번호"
            Me.lblJuridicalPersonNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblFaxNumber
            '
            Me.lblFaxNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFaxNumber.Location = New System.Drawing.Point(326, 336)
            Me.lblFaxNumber.Name = "lblFaxNumber"
            Me.lblFaxNumber.Size = New System.Drawing.Size(100, 17)
            Me.lblFaxNumber.TabIndex = 48
            Me.lblFaxNumber.Text = "팩스 번호"
            Me.lblFaxNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblPhoneNumber
            '
            Me.lblPhoneNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblPhoneNumber.Location = New System.Drawing.Point(326, 310)
            Me.lblPhoneNumber.Name = "lblPhoneNumber"
            Me.lblPhoneNumber.Size = New System.Drawing.Size(100, 17)
            Me.lblPhoneNumber.TabIndex = 49
            Me.lblPhoneNumber.Text = "전화 번호"
            Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblAddress2
            '
            Me.lblAddress2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblAddress2.Location = New System.Drawing.Point(326, 283)
            Me.lblAddress2.Name = "lblAddress2"
            Me.lblAddress2.Size = New System.Drawing.Size(100, 17)
            Me.lblAddress2.TabIndex = 50
            Me.lblAddress2.Text = "상세주소"
            Me.lblAddress2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblPostNumber
            '
            Me.lblPostNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblPostNumber.Location = New System.Drawing.Point(326, 257)
            Me.lblPostNumber.Name = "lblPostNumber"
            Me.lblPostNumber.Size = New System.Drawing.Size(100, 17)
            Me.lblPostNumber.TabIndex = 51
            Me.lblPostNumber.Text = "우편 번호"
            Me.lblPostNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblRepresentativeName
            '
            Me.lblRepresentativeName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRepresentativeName.Location = New System.Drawing.Point(326, 231)
            Me.lblRepresentativeName.Name = "lblRepresentativeName"
            Me.lblRepresentativeName.Size = New System.Drawing.Size(100, 17)
            Me.lblRepresentativeName.TabIndex = 52
            Me.lblRepresentativeName.Text = "대표자 명"
            Me.lblRepresentativeName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblBusinessConditions
            '
            Me.lblBusinessConditions.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBusinessConditions.Location = New System.Drawing.Point(367, 363)
            Me.lblBusinessConditions.Name = "lblBusinessConditions"
            Me.lblBusinessConditions.Size = New System.Drawing.Size(59, 17)
            Me.lblBusinessConditions.TabIndex = 54
            Me.lblBusinessConditions.Text = "업태"
            Me.lblBusinessConditions.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblItem
            '
            Me.lblItem.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblItem.Location = New System.Drawing.Point(326, 388)
            Me.lblItem.Name = "lblItem"
            Me.lblItem.Size = New System.Drawing.Size(100, 17)
            Me.lblItem.TabIndex = 55
            Me.lblItem.Text = "종목"
            Me.lblItem.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblTaxOfficeCode
            '
            Me.lblTaxOfficeCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTaxOfficeCode.Location = New System.Drawing.Point(326, 440)
            Me.lblTaxOfficeCode.Name = "lblTaxOfficeCode"
            Me.lblTaxOfficeCode.Size = New System.Drawing.Size(100, 17)
            Me.lblTaxOfficeCode.TabIndex = 56
            Me.lblTaxOfficeCode.Text = "관할 세무서 코드"
            Me.lblTaxOfficeCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblTaxOfficeName
            '
            Me.lblTaxOfficeName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTaxOfficeName.Location = New System.Drawing.Point(326, 466)
            Me.lblTaxOfficeName.Name = "lblTaxOfficeName"
            Me.lblTaxOfficeName.Size = New System.Drawing.Size(100, 17)
            Me.lblTaxOfficeName.TabIndex = 57
            Me.lblTaxOfficeName.Text = "관할 세무서 명"
            Me.lblTaxOfficeName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblNote
            '
            Me.lblNote.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblNote.Location = New System.Drawing.Point(326, 518)
            Me.lblNote.Name = "lblNote"
            Me.lblNote.Size = New System.Drawing.Size(100, 17)
            Me.lblNote.TabIndex = 58
            Me.lblNote.Text = "비고"
            Me.lblNote.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtItem
            '
            Me.txtItem.BackColor = System.Drawing.SystemColors.Window
            Me.txtItem.BorderColor = System.Drawing.Color.Empty
            Me.txtItem.BorderStyle = 2
            Me.txtItem.CaptionName = "종목"
            Me.txtItem.Location = New System.Drawing.Point(432, 385)
            Me.txtItem.MaxLength = 30
            Me.txtItem.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtItem.Multiline = False
            Me.txtItem.Name = "txtItem"
            Me.txtItem.ReadOnlys = False
            Me.txtItem.SelectedText = ""
            Me.txtItem.SelectionLength = 0
            Me.txtItem.SelectionStart = 0
            Me.txtItem.Size = New System.Drawing.Size(362, 20)
            Me.txtItem.TabIndex = 59
            Me.txtItem.Tag = ""
            Me.txtItem.TextAlign = 0
            Me.txtItem.TextValue = ""
            Me.txtItem.ToolTipText = ""
            '
            'txtBusinessConditions
            '
            Me.txtBusinessConditions.BackColor = System.Drawing.SystemColors.Window
            Me.txtBusinessConditions.BorderColor = System.Drawing.Color.Empty
            Me.txtBusinessConditions.BorderStyle = 2
            Me.txtBusinessConditions.CaptionName = "업태"
            Me.txtBusinessConditions.Location = New System.Drawing.Point(432, 359)
            Me.txtBusinessConditions.MaxLength = 30
            Me.txtBusinessConditions.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBusinessConditions.Multiline = False
            Me.txtBusinessConditions.Name = "txtBusinessConditions"
            Me.txtBusinessConditions.ReadOnlys = False
            Me.txtBusinessConditions.SelectedText = ""
            Me.txtBusinessConditions.SelectionLength = 0
            Me.txtBusinessConditions.SelectionStart = 0
            Me.txtBusinessConditions.Size = New System.Drawing.Size(362, 20)
            Me.txtBusinessConditions.TabIndex = 60
            Me.txtBusinessConditions.Tag = ""
            Me.txtBusinessConditions.TextAlign = 0
            Me.txtBusinessConditions.TextValue = ""
            Me.txtBusinessConditions.ToolTipText = ""
            '
            'txtFaxNumber
            '
            Me.txtFaxNumber.BackColor = System.Drawing.SystemColors.Window
            Me.txtFaxNumber.BorderColor = System.Drawing.Color.Empty
            Me.txtFaxNumber.BorderStyle = 2
            Me.txtFaxNumber.CaptionName = "팩스번호"
            Me.txtFaxNumber.Location = New System.Drawing.Point(432, 333)
            Me.txtFaxNumber.MaxLength = 15
            Me.txtFaxNumber.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtFaxNumber.Multiline = False
            Me.txtFaxNumber.Name = "txtFaxNumber"
            Me.txtFaxNumber.ReadOnlys = False
            Me.txtFaxNumber.SelectedText = ""
            Me.txtFaxNumber.SelectionLength = 0
            Me.txtFaxNumber.SelectionStart = 0
            Me.txtFaxNumber.Size = New System.Drawing.Size(80, 20)
            Me.txtFaxNumber.TabIndex = 61
            Me.txtFaxNumber.Tag = ""
            Me.txtFaxNumber.TextAlign = 0
            Me.txtFaxNumber.TextValue = ""
            Me.txtFaxNumber.ToolTipText = ""
            '
            'txtPhoneNumber
            '
            Me.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNumber.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNumber.BorderStyle = 2
            Me.txtPhoneNumber.CaptionName = "전화번호"
            Me.txtPhoneNumber.Location = New System.Drawing.Point(432, 307)
            Me.txtPhoneNumber.MaxLength = 15
            Me.txtPhoneNumber.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNumber.Multiline = False
            Me.txtPhoneNumber.Name = "txtPhoneNumber"
            Me.txtPhoneNumber.ReadOnlys = False
            Me.txtPhoneNumber.SelectedText = ""
            Me.txtPhoneNumber.SelectionLength = 0
            Me.txtPhoneNumber.SelectionStart = 0
            Me.txtPhoneNumber.Size = New System.Drawing.Size(80, 20)
            Me.txtPhoneNumber.TabIndex = 62
            Me.txtPhoneNumber.Tag = "need;"
            Me.txtPhoneNumber.TextAlign = 0
            Me.txtPhoneNumber.TextValue = ""
            Me.txtPhoneNumber.ToolTipText = ""
            '
            'txtJuridicalPersonNumber
            '
            Me.txtJuridicalPersonNumber.BackColor = System.Drawing.SystemColors.Window
            Me.txtJuridicalPersonNumber.BorderColor = System.Drawing.Color.Empty
            Me.txtJuridicalPersonNumber.BorderStyle = 2
            Me.txtJuridicalPersonNumber.CaptionName = "법인 등록번호"
            Me.txtJuridicalPersonNumber.Location = New System.Drawing.Point(432, 172)
            Me.txtJuridicalPersonNumber.MaxLength = 14
            Me.txtJuridicalPersonNumber.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtJuridicalPersonNumber.Multiline = False
            Me.txtJuridicalPersonNumber.Name = "txtJuridicalPersonNumber"
            Me.txtJuridicalPersonNumber.ReadOnlys = False
            Me.txtJuridicalPersonNumber.SelectedText = ""
            Me.txtJuridicalPersonNumber.SelectionLength = 0
            Me.txtJuridicalPersonNumber.SelectionStart = 0
            Me.txtJuridicalPersonNumber.Size = New System.Drawing.Size(100, 20)
            Me.txtJuridicalPersonNumber.TabIndex = 64
            Me.txtJuridicalPersonNumber.Tag = "need;format(######-#######);"
            Me.txtJuridicalPersonNumber.TextAlign = 0
            Me.txtJuridicalPersonNumber.TextValue = Nothing
            Me.txtJuridicalPersonNumber.ToolTipText = ""
            '
            'txtRepresentativeName
            '
            Me.txtRepresentativeName.BackColor = System.Drawing.SystemColors.Window
            Me.txtRepresentativeName.BorderColor = System.Drawing.Color.Empty
            Me.txtRepresentativeName.BorderStyle = 2
            Me.txtRepresentativeName.CaptionName = "대표자 명"
            Me.txtRepresentativeName.Location = New System.Drawing.Point(432, 228)
            Me.txtRepresentativeName.MaxLength = 30
            Me.txtRepresentativeName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRepresentativeName.Multiline = False
            Me.txtRepresentativeName.Name = "txtRepresentativeName"
            Me.txtRepresentativeName.ReadOnlys = False
            Me.txtRepresentativeName.SelectedText = ""
            Me.txtRepresentativeName.SelectionLength = 0
            Me.txtRepresentativeName.SelectionStart = 0
            Me.txtRepresentativeName.Size = New System.Drawing.Size(100, 20)
            Me.txtRepresentativeName.TabIndex = 65
            Me.txtRepresentativeName.Tag = "need;"
            Me.txtRepresentativeName.TextAlign = 0
            Me.txtRepresentativeName.TextValue = ""
            Me.txtRepresentativeName.ToolTipText = ""
            '
            'txtAddress2
            '
            Me.txtAddress2.BackColor = System.Drawing.SystemColors.Window
            Me.txtAddress2.BorderColor = System.Drawing.Color.Empty
            Me.txtAddress2.BorderStyle = 2
            Me.txtAddress2.CaptionName = "상세 주소"
            Me.txtAddress2.Location = New System.Drawing.Point(432, 280)
            Me.txtAddress2.MaxLength = 40
            Me.txtAddress2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAddress2.Multiline = False
            Me.txtAddress2.Name = "txtAddress2"
            Me.txtAddress2.ReadOnlys = False
            Me.txtAddress2.SelectedText = ""
            Me.txtAddress2.SelectionLength = 0
            Me.txtAddress2.SelectionStart = 0
            Me.txtAddress2.Size = New System.Drawing.Size(362, 20)
            Me.txtAddress2.TabIndex = 66
            Me.txtAddress2.Tag = ""
            Me.txtAddress2.TextAlign = 0
            Me.txtAddress2.TextValue = ""
            Me.txtAddress2.ToolTipText = ""
            '
            'txtTaxOfficeCode
            '
            Me.txtTaxOfficeCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtTaxOfficeCode.BorderColor = System.Drawing.Color.Empty
            Me.txtTaxOfficeCode.BorderStyle = 2
            Me.txtTaxOfficeCode.CaptionName = "관할 세무서 코드"
            Me.txtTaxOfficeCode.Location = New System.Drawing.Point(432, 437)
            Me.txtTaxOfficeCode.MaxLength = 3
            Me.txtTaxOfficeCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtTaxOfficeCode.Multiline = False
            Me.txtTaxOfficeCode.Name = "txtTaxOfficeCode"
            Me.txtTaxOfficeCode.ReadOnlys = False
            Me.txtTaxOfficeCode.SelectedText = ""
            Me.txtTaxOfficeCode.SelectionLength = 0
            Me.txtTaxOfficeCode.SelectionStart = 0
            Me.txtTaxOfficeCode.Size = New System.Drawing.Size(40, 20)
            Me.txtTaxOfficeCode.TabIndex = 67
            Me.txtTaxOfficeCode.Tag = "format(###);"
            Me.txtTaxOfficeCode.TextAlign = 0
            Me.txtTaxOfficeCode.TextValue = Nothing
            Me.txtTaxOfficeCode.ToolTipText = ""
            '
            'txtTaxOfficeName
            '
            Me.txtTaxOfficeName.BackColor = System.Drawing.SystemColors.Window
            Me.txtTaxOfficeName.BorderColor = System.Drawing.Color.Empty
            Me.txtTaxOfficeName.BorderStyle = 2
            Me.txtTaxOfficeName.CaptionName = "세무서 명"
            Me.txtTaxOfficeName.Location = New System.Drawing.Point(432, 463)
            Me.txtTaxOfficeName.MaxLength = 30
            Me.txtTaxOfficeName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtTaxOfficeName.Multiline = False
            Me.txtTaxOfficeName.Name = "txtTaxOfficeName"
            Me.txtTaxOfficeName.ReadOnlys = False
            Me.txtTaxOfficeName.SelectedText = ""
            Me.txtTaxOfficeName.SelectionLength = 0
            Me.txtTaxOfficeName.SelectionStart = 0
            Me.txtTaxOfficeName.Size = New System.Drawing.Size(362, 20)
            Me.txtTaxOfficeName.TabIndex = 68
            Me.txtTaxOfficeName.Tag = ""
            Me.txtTaxOfficeName.TextAlign = 0
            Me.txtTaxOfficeName.TextValue = ""
            Me.txtTaxOfficeName.ToolTipText = ""
            '
            'txtNote
            '
            Me.txtNote.BackColor = System.Drawing.SystemColors.Window
            Me.txtNote.BorderColor = System.Drawing.Color.Empty
            Me.txtNote.BorderStyle = 2
            Me.txtNote.CaptionName = "비고"
            Me.txtNote.Location = New System.Drawing.Point(432, 515)
            Me.txtNote.MaxLength = 250
            Me.txtNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtNote.Multiline = False
            Me.txtNote.Name = "txtNote"
            Me.txtNote.ReadOnlys = False
            Me.txtNote.SelectedText = ""
            Me.txtNote.SelectionLength = 0
            Me.txtNote.SelectionStart = 0
            Me.txtNote.Size = New System.Drawing.Size(362, 20)
            Me.txtNote.TabIndex = 69
            Me.txtNote.Tag = ""
            Me.txtNote.TextAlign = 0
            Me.txtNote.TextValue = ""
            Me.txtNote.ToolTipText = ""
            '
            'picCriteria
            '
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(800, 50)
            Me.picCriteria.TabIndex = 70
            Me.picCriteria.TabStop = False
            '
            'lblFirmName
            '
            Me.lblFirmName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFirmName.Location = New System.Drawing.Point(28, 28)
            Me.lblFirmName.Name = "lblFirmName"
            Me.lblFirmName.Size = New System.Drawing.Size(34, 15)
            Me.lblFirmName.TabIndex = 71
            Me.lblFirmName.Text = "상호"
            '
            'txtFirmName
            '
            Me.txtFirmName.BackColor = System.Drawing.SystemColors.Window
            Me.txtFirmName.BorderColor = System.Drawing.Color.Empty
            Me.txtFirmName.BorderStyle = 2
            Me.txtFirmName.CaptionName = "호실"
            Me.txtFirmName.Location = New System.Drawing.Point(68, 23)
            Me.txtFirmName.MaxLength = 8
            Me.txtFirmName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtFirmName.Multiline = False
            Me.txtFirmName.Name = "txtFirmName"
            Me.txtFirmName.ReadOnlys = False
            Me.txtFirmName.SelectedText = ""
            Me.txtFirmName.SelectionLength = 0
            Me.txtFirmName.SelectionStart = 0
            Me.txtFirmName.Size = New System.Drawing.Size(392, 20)
            Me.txtFirmName.TabIndex = 72
            Me.txtFirmName.Tag = ""
            Me.txtFirmName.TextAlign = 0
            Me.txtFirmName.TextValue = ""
            Me.txtFirmName.ToolTipText = ""
            '
            'txtHomeTaxID
            '
            Me.txtHomeTaxID.BackColor = System.Drawing.SystemColors.Window
            Me.txtHomeTaxID.BorderColor = System.Drawing.Color.Empty
            Me.txtHomeTaxID.BorderStyle = 2
            Me.txtHomeTaxID.CaptionName = "홈 택스 ID"
            Me.txtHomeTaxID.Location = New System.Drawing.Point(432, 489)
            Me.txtHomeTaxID.MaxLength = 10
            Me.txtHomeTaxID.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtHomeTaxID.Multiline = False
            Me.txtHomeTaxID.Name = "txtHomeTaxID"
            Me.txtHomeTaxID.ReadOnlys = False
            Me.txtHomeTaxID.SelectedText = ""
            Me.txtHomeTaxID.SelectionLength = 0
            Me.txtHomeTaxID.SelectionStart = 0
            Me.txtHomeTaxID.Size = New System.Drawing.Size(80, 20)
            Me.txtHomeTaxID.TabIndex = 74
            Me.txtHomeTaxID.Tag = ""
            Me.txtHomeTaxID.TextAlign = 0
            Me.txtHomeTaxID.TextValue = ""
            Me.txtHomeTaxID.ToolTipText = ""
            '
            'lblHomeTaxID
            '
            Me.lblHomeTaxID.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblHomeTaxID.Location = New System.Drawing.Point(326, 492)
            Me.lblHomeTaxID.Name = "lblHomeTaxID"
            Me.lblHomeTaxID.Size = New System.Drawing.Size(100, 17)
            Me.lblHomeTaxID.TabIndex = 73
            Me.lblHomeTaxID.Text = "홈텍스 ID"
            Me.lblHomeTaxID.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpFiscalYear
            '
            Me.dtpFiscalYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFiscalYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpFiscalYear.BorderStyle = 2
            Me.dtpFiscalYear.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFiscalYear.CaptionName = "회계 년 도"
            Me.dtpFiscalYear.DateTimeFormatText = "yyyy"
            Me.dtpFiscalYear.Location = New System.Drawing.Point(432, 198)
            Me.dtpFiscalYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFiscalYear.MaxLength = 0
            Me.dtpFiscalYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFiscalYear.Name = "dtpFiscalYear"
            Me.dtpFiscalYear.ReadOnlys = False
            Me.dtpFiscalYear.SelectedText = ""
            Me.dtpFiscalYear.SelectionLength = 0
            Me.dtpFiscalYear.SelectionStart = 0
            Me.dtpFiscalYear.Size = New System.Drawing.Size(85, 20)
            Me.dtpFiscalYear.TabIndex = 739
            Me.dtpFiscalYear.TabStop = False
            Me.dtpFiscalYear.Tag = "need;format(&&&&);"
            Me.dtpFiscalYear.TextAlign = 0
            Me.dtpFiscalYear.TextValue = Nothing
            Me.dtpFiscalYear.ToolTipText = ""
            '
            'lblFiscalYear
            '
            Me.lblFiscalYear.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFiscalYear.Location = New System.Drawing.Point(326, 201)
            Me.lblFiscalYear.Name = "lblFiscalYear"
            Me.lblFiscalYear.Size = New System.Drawing.Size(100, 17)
            Me.lblFiscalYear.TabIndex = 740
            Me.lblFiscalYear.Text = "회계 년도"
            Me.lblFiscalYear.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtUpjongCode
            '
            Me.txtUpjongCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtUpjongCode.BorderColor = System.Drawing.Color.Empty
            Me.txtUpjongCode.BorderStyle = 2
            Me.txtUpjongCode.CaptionName = "주 업종코드"
            Me.txtUpjongCode.Location = New System.Drawing.Point(432, 411)
            Me.txtUpjongCode.MaxLength = 6
            Me.txtUpjongCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtUpjongCode.Multiline = False
            Me.txtUpjongCode.Name = "txtUpjongCode"
            Me.txtUpjongCode.ReadOnlys = False
            Me.txtUpjongCode.SelectedText = ""
            Me.txtUpjongCode.SelectionLength = 0
            Me.txtUpjongCode.SelectionStart = 0
            Me.txtUpjongCode.Size = New System.Drawing.Size(80, 20)
            Me.txtUpjongCode.TabIndex = 742
            Me.txtUpjongCode.Tag = ""
            Me.txtUpjongCode.TextAlign = 0
            Me.txtUpjongCode.TextValue = ""
            Me.txtUpjongCode.ToolTipText = ""
            '
            'lblUpjongCode
            '
            Me.lblUpjongCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblUpjongCode.Location = New System.Drawing.Point(326, 414)
            Me.lblUpjongCode.Name = "lblUpjongCode"
            Me.lblUpjongCode.Size = New System.Drawing.Size(100, 17)
            Me.lblUpjongCode.TabIndex = 741
            Me.lblUpjongCode.Text = "주 업종코드"
            Me.lblUpjongCode.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'SMEA01
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtUpjongCode)
            Me.Controls.Add(Me.lblUpjongCode)
            Me.Controls.Add(Me.lblFiscalYear)
            Me.Controls.Add(Me.dtpFiscalYear)
            Me.Controls.Add(Me.txtHomeTaxID)
            Me.Controls.Add(Me.lblHomeTaxID)
            Me.Controls.Add(Me.txtFirmName)
            Me.Controls.Add(Me.lblFirmName)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.txtNote)
            Me.Controls.Add(Me.txtTaxOfficeName)
            Me.Controls.Add(Me.txtTaxOfficeCode)
            Me.Controls.Add(Me.txtAddress2)
            Me.Controls.Add(Me.txtRepresentativeName)
            Me.Controls.Add(Me.txtJuridicalPersonNumber)
            Me.Controls.Add(Me.txtPhoneNumber)
            Me.Controls.Add(Me.txtFaxNumber)
            Me.Controls.Add(Me.txtBusinessConditions)
            Me.Controls.Add(Me.txtItem)
            Me.Controls.Add(Me.lblNote)
            Me.Controls.Add(Me.lblTaxOfficeName)
            Me.Controls.Add(Me.lblTaxOfficeCode)
            Me.Controls.Add(Me.lblItem)
            Me.Controls.Add(Me.lblBusinessConditions)
            Me.Controls.Add(Me.lblRepresentativeName)
            Me.Controls.Add(Me.lblPostNumber)
            Me.Controls.Add(Me.lblAddress2)
            Me.Controls.Add(Me.lblPhoneNumber)
            Me.Controls.Add(Me.lblFaxNumber)
            Me.Controls.Add(Me.lblJuridicalPersonNumber)
            Me.Controls.Add(Me.lblBusinessesNumber)
            Me.Controls.Add(Me.txtBusinessesNumber)
            Me.Controls.Add(Me.txtFirmName_2)
            Me.Controls.Add(Me.lblBusinessPlaceCode)
            Me.Controls.Add(Me.txtBusinessPlaceCode)
            Me.Controls.Add(Me.popPostNumber)
            Me.Controls.Add(Me.lblFirmName_2)
            Me.Controls.Add(Me.picIo_2)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMEA01"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents txtBusinessPlaceCode As ubiLease.CommonControls.txt
        Friend WithEvents popPostNumber As ubiLease.CommonControls.pop
        Friend WithEvents lblFirmName_2 As System.Windows.Forms.Label
        Friend WithEvents lblBusinessPlaceCode As System.Windows.Forms.Label
        Friend WithEvents txtFirmName_2 As ubiLease.CommonControls.txt
        Friend WithEvents txtBusinessesNumber As ubiLease.CommonControls.txt
        Friend WithEvents lblBusinessesNumber As System.Windows.Forms.Label
        Friend WithEvents lblJuridicalPersonNumber As System.Windows.Forms.Label
        Friend WithEvents lblFaxNumber As System.Windows.Forms.Label
        Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
        Friend WithEvents lblAddress2 As System.Windows.Forms.Label
        Friend WithEvents lblPostNumber As System.Windows.Forms.Label
        Friend WithEvents lblRepresentativeName As System.Windows.Forms.Label
        Friend WithEvents lblBusinessConditions As System.Windows.Forms.Label
        Friend WithEvents lblItem As System.Windows.Forms.Label
        Friend WithEvents lblTaxOfficeCode As System.Windows.Forms.Label
        Friend WithEvents lblTaxOfficeName As System.Windows.Forms.Label
        Friend WithEvents lblNote As System.Windows.Forms.Label
        Friend WithEvents txtItem As ubiLease.CommonControls.txt
        Friend WithEvents txtBusinessConditions As ubiLease.CommonControls.txt
        Friend WithEvents txtFaxNumber As ubiLease.CommonControls.txt
        Friend WithEvents txtPhoneNumber As ubiLease.CommonControls.txt
        Friend WithEvents txtJuridicalPersonNumber As ubiLease.CommonControls.txt
        Friend WithEvents txtRepresentativeName As ubiLease.CommonControls.txt
        Friend WithEvents txtAddress2 As ubiLease.CommonControls.txt
        Friend WithEvents txtTaxOfficeCode As ubiLease.CommonControls.txt
        Friend WithEvents txtTaxOfficeName As ubiLease.CommonControls.txt
        Friend WithEvents txtNote As ubiLease.CommonControls.txt
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblFirmName As System.Windows.Forms.Label
        Friend WithEvents txtFirmName As ubiLease.CommonControls.txt
        Friend WithEvents txtHomeTaxID As ubiLease.CommonControls.txt
        Friend WithEvents lblHomeTaxID As System.Windows.Forms.Label
        Friend WithEvents dtpFiscalYear As ubiLease.CommonControls.dtp
        Friend WithEvents lblFiscalYear As System.Windows.Forms.Label
        Friend WithEvents txtUpjongCode As ubiLease.CommonControls.txt
        Friend WithEvents lblUpjongCode As System.Windows.Forms.Label

    End Class

End Namespace
