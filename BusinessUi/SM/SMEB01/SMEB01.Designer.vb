Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMEB01
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMEB01))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.txtProgramID = New ubiLease.CommonControls.txt
            Me.lblUINAME = New System.Windows.Forms.Label
            Me.lblUIID = New System.Windows.Forms.Label
            Me.txtProgramName = New ubiLease.CommonControls.txt
            Me.txtUiDescription = New ubiLease.CommonControls.txt
            Me.lblUiDescription = New System.Windows.Forms.Label
            Me.lblSkillExplanation = New System.Windows.Forms.Label
            Me.lblAfterFactManagement = New System.Windows.Forms.Label
            Me.lblDictionaryManagement = New System.Windows.Forms.Label
            Me.lblAttentionItem = New System.Windows.Forms.Label
            Me.lblTerms = New System.Windows.Forms.Label
            Me.lblPreconditionItem = New System.Windows.Forms.Label
            Me.txtAttentionItem = New ubiLease.CommonControls.txt
            Me.txtDictionaryManagement = New ubiLease.CommonControls.txt
            Me.txtAfterFactManagement = New ubiLease.CommonControls.txt
            Me.txtTerms = New ubiLease.CommonControls.txt
            Me.txtPreconditionItem = New ubiLease.CommonControls.txt
            Me.cboSystemDivision = New ubiLease.CommonControls.cbo
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.BtnImageOpen1 = New ubiLease.CommonControls.btn
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.BtnImageSave = New ubiLease.CommonControls.btn
            Me.cboPrivateUseYesOrNo = New ubiLease.CommonControls.cbo
            Me.Label1 = New System.Windows.Forms.Label
            Me.picUiImage = New System.Windows.Forms.PictureBox
            Me.UIImage = New System.Windows.Forms.Label
            Me.chkCreateYesOrNo = New ubiLease.CommonControls.chk
            Me.chkDeleteYesOrNo = New ubiLease.CommonControls.chk
            Me.chkRequestYesOrNo = New ubiLease.CommonControls.chk
            Me.chkUpdateYesOrNo = New ubiLease.CommonControls.chk
            Me.btnDefault = New ubiLease.CommonControls.btn
            Me.chkPrintYesOrNo = New ubiLease.CommonControls.chk
            Me.txtUiID = New ubiLease.CommonControls.txt
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.txtSkillExplanation = New ubiLease.CommonControls.txt
            Me.btnAutoImage = New System.Windows.Forms.Button
            Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picUiImage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
            Me.grd_1.Size = New System.Drawing.Size(524, 304)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'txtProgramID
            '
            Me.txtProgramID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtProgramID.BackColor = System.Drawing.SystemColors.Window
            Me.txtProgramID.BorderColor = System.Drawing.Color.Empty
            Me.txtProgramID.BorderStyle = 1
            Me.txtProgramID.CaptionName = "화면 ID"
            Me.txtProgramID.Location = New System.Drawing.Point(94, 379)
            Me.txtProgramID.MaxLength = 10
            Me.txtProgramID.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtProgramID.Multiline = False
            Me.txtProgramID.Name = "txtProgramID"
            Me.txtProgramID.ReadOnlys = False
            Me.txtProgramID.SelectedText = ""
            Me.txtProgramID.SelectionLength = 0
            Me.txtProgramID.SelectionStart = 0
            Me.txtProgramID.Size = New System.Drawing.Size(291, 20)
            Me.txtProgramID.TabIndex = 13
            Me.txtProgramID.Tag = "read;"
            Me.txtProgramID.TextAlign = 0
            Me.txtProgramID.TextValue = ""
            Me.txtProgramID.ToolTipText = ""
            '
            'lblUINAME
            '
            Me.lblUINAME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblUINAME.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblUINAME.Location = New System.Drawing.Point(10, 406)
            Me.lblUINAME.Name = "lblUINAME"
            Me.lblUINAME.Size = New System.Drawing.Size(78, 16)
            Me.lblUINAME.TabIndex = 14
            Me.lblUINAME.Text = "화면 명"
            Me.lblUINAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblUIID
            '
            Me.lblUIID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblUIID.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblUIID.Location = New System.Drawing.Point(10, 380)
            Me.lblUIID.Name = "lblUIID"
            Me.lblUIID.Size = New System.Drawing.Size(78, 16)
            Me.lblUIID.TabIndex = 12
            Me.lblUIID.Text = "화면 ID"
            Me.lblUIID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtProgramName
            '
            Me.txtProgramName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtProgramName.BackColor = System.Drawing.SystemColors.Window
            Me.txtProgramName.BorderColor = System.Drawing.Color.Empty
            Me.txtProgramName.BorderStyle = 1
            Me.txtProgramName.CaptionName = "화면 명"
            Me.txtProgramName.Location = New System.Drawing.Point(94, 405)
            Me.txtProgramName.MaxLength = 40
            Me.txtProgramName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtProgramName.Multiline = False
            Me.txtProgramName.Name = "txtProgramName"
            Me.txtProgramName.ReadOnlys = False
            Me.txtProgramName.SelectedText = ""
            Me.txtProgramName.SelectionLength = 0
            Me.txtProgramName.SelectionStart = 0
            Me.txtProgramName.Size = New System.Drawing.Size(291, 20)
            Me.txtProgramName.TabIndex = 15
            Me.txtProgramName.Tag = "read;"
            Me.txtProgramName.TextAlign = 0
            Me.txtProgramName.TextValue = ""
            Me.txtProgramName.ToolTipText = ""
            '
            'txtUiDescription
            '
            Me.txtUiDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtUiDescription.BackColor = System.Drawing.SystemColors.Window
            Me.txtUiDescription.BorderColor = System.Drawing.Color.Empty
            Me.txtUiDescription.BorderStyle = 1
            Me.txtUiDescription.CaptionName = "화면 개요"
            Me.txtUiDescription.Location = New System.Drawing.Point(94, 431)
            Me.txtUiDescription.MaximumSize = New System.Drawing.Size(291, 53)
            Me.txtUiDescription.MaxLength = 1000
            Me.txtUiDescription.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtUiDescription.Multiline = True
            Me.txtUiDescription.Name = "txtUiDescription"
            Me.txtUiDescription.ReadOnlys = False
            Me.txtUiDescription.SelectedText = ""
            Me.txtUiDescription.SelectionLength = 0
            Me.txtUiDescription.SelectionStart = 0
            Me.txtUiDescription.Size = New System.Drawing.Size(291, 53)
            Me.txtUiDescription.TabIndex = 17
            Me.txtUiDescription.Tag = ""
            Me.txtUiDescription.TextAlign = 0
            Me.txtUiDescription.TextValue = ""
            Me.txtUiDescription.ToolTipText = ""
            '
            'lblUiDescription
            '
            Me.lblUiDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblUiDescription.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblUiDescription.Location = New System.Drawing.Point(10, 432)
            Me.lblUiDescription.Name = "lblUiDescription"
            Me.lblUiDescription.Size = New System.Drawing.Size(78, 16)
            Me.lblUiDescription.TabIndex = 16
            Me.lblUiDescription.Tag = ""
            Me.lblUiDescription.Text = "화면 개요"
            Me.lblUiDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSkillExplanation
            '
            Me.lblSkillExplanation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblSkillExplanation.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSkillExplanation.Location = New System.Drawing.Point(884, 405)
            Me.lblSkillExplanation.Name = "lblSkillExplanation"
            Me.lblSkillExplanation.Size = New System.Drawing.Size(78, 16)
            Me.lblSkillExplanation.TabIndex = 33
            Me.lblSkillExplanation.Text = "사용 방법"
            Me.lblSkillExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblAfterFactManagement
            '
            Me.lblAfterFactManagement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblAfterFactManagement.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblAfterFactManagement.Location = New System.Drawing.Point(10, 553)
            Me.lblAfterFactManagement.Name = "lblAfterFactManagement"
            Me.lblAfterFactManagement.Size = New System.Drawing.Size(78, 16)
            Me.lblAfterFactManagement.TabIndex = 22
            Me.lblAfterFactManagement.Text = "사후 처리"
            Me.lblAfterFactManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDictionaryManagement
            '
            Me.lblDictionaryManagement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblDictionaryManagement.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDictionaryManagement.Location = New System.Drawing.Point(10, 514)
            Me.lblDictionaryManagement.Name = "lblDictionaryManagement"
            Me.lblDictionaryManagement.Size = New System.Drawing.Size(78, 16)
            Me.lblDictionaryManagement.TabIndex = 20
            Me.lblDictionaryManagement.Text = "사전 처리"
            Me.lblDictionaryManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblAttentionItem
            '
            Me.lblAttentionItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblAttentionItem.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblAttentionItem.Location = New System.Drawing.Point(10, 646)
            Me.lblAttentionItem.Name = "lblAttentionItem"
            Me.lblAttentionItem.Size = New System.Drawing.Size(78, 15)
            Me.lblAttentionItem.TabIndex = 26
            Me.lblAttentionItem.Text = "주의 사항"
            Me.lblAttentionItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTerms
            '
            Me.lblTerms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTerms.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTerms.Location = New System.Drawing.Point(10, 490)
            Me.lblTerms.Name = "lblTerms"
            Me.lblTerms.Size = New System.Drawing.Size(78, 16)
            Me.lblTerms.TabIndex = 18
            Me.lblTerms.Text = "처리 주기"
            Me.lblTerms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblPreconditionItem
            '
            Me.lblPreconditionItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblPreconditionItem.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblPreconditionItem.Location = New System.Drawing.Point(10, 604)
            Me.lblPreconditionItem.Name = "lblPreconditionItem"
            Me.lblPreconditionItem.Size = New System.Drawing.Size(78, 15)
            Me.lblPreconditionItem.TabIndex = 24
            Me.lblPreconditionItem.Text = "필수 항목"
            Me.lblPreconditionItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtAttentionItem
            '
            Me.txtAttentionItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtAttentionItem.BackColor = System.Drawing.SystemColors.Window
            Me.txtAttentionItem.BorderColor = System.Drawing.Color.Empty
            Me.txtAttentionItem.BorderStyle = 1
            Me.txtAttentionItem.CaptionName = "주의 사항"
            Me.txtAttentionItem.Location = New System.Drawing.Point(94, 646)
            Me.txtAttentionItem.MaximumSize = New System.Drawing.Size(291, 70)
            Me.txtAttentionItem.MaxLength = 10000
            Me.txtAttentionItem.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAttentionItem.Multiline = True
            Me.txtAttentionItem.Name = "txtAttentionItem"
            Me.txtAttentionItem.ReadOnlys = False
            Me.txtAttentionItem.SelectedText = ""
            Me.txtAttentionItem.SelectionLength = 0
            Me.txtAttentionItem.SelectionStart = 0
            Me.txtAttentionItem.Size = New System.Drawing.Size(291, 70)
            Me.txtAttentionItem.TabIndex = 27
            Me.txtAttentionItem.Tag = ""
            Me.txtAttentionItem.TextAlign = 0
            Me.txtAttentionItem.TextValue = ""
            Me.txtAttentionItem.ToolTipText = ""
            '
            'txtDictionaryManagement
            '
            Me.txtDictionaryManagement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtDictionaryManagement.AutoScroll = True
            Me.txtDictionaryManagement.BackColor = System.Drawing.SystemColors.Window
            Me.txtDictionaryManagement.BorderColor = System.Drawing.Color.Empty
            Me.txtDictionaryManagement.BorderStyle = 1
            Me.txtDictionaryManagement.CaptionName = "사전 처리"
            Me.txtDictionaryManagement.Location = New System.Drawing.Point(94, 514)
            Me.txtDictionaryManagement.MaximumSize = New System.Drawing.Size(291, 33)
            Me.txtDictionaryManagement.MaxLength = 10000
            Me.txtDictionaryManagement.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDictionaryManagement.Multiline = False
            Me.txtDictionaryManagement.Name = "txtDictionaryManagement"
            Me.txtDictionaryManagement.ReadOnlys = False
            Me.txtDictionaryManagement.SelectedText = ""
            Me.txtDictionaryManagement.SelectionLength = 0
            Me.txtDictionaryManagement.SelectionStart = 0
            Me.txtDictionaryManagement.Size = New System.Drawing.Size(291, 33)
            Me.txtDictionaryManagement.TabIndex = 21
            Me.txtDictionaryManagement.Tag = ""
            Me.txtDictionaryManagement.TextAlign = 0
            Me.txtDictionaryManagement.TextValue = ""
            Me.txtDictionaryManagement.ToolTipText = ""
            '
            'txtAfterFactManagement
            '
            Me.txtAfterFactManagement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtAfterFactManagement.BackColor = System.Drawing.SystemColors.Window
            Me.txtAfterFactManagement.BorderColor = System.Drawing.Color.Empty
            Me.txtAfterFactManagement.BorderStyle = 1
            Me.txtAfterFactManagement.CaptionName = "사후 처리"
            Me.txtAfterFactManagement.Location = New System.Drawing.Point(94, 553)
            Me.txtAfterFactManagement.MaximumSize = New System.Drawing.Size(291, 41)
            Me.txtAfterFactManagement.MaxLength = 10000
            Me.txtAfterFactManagement.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAfterFactManagement.Multiline = True
            Me.txtAfterFactManagement.Name = "txtAfterFactManagement"
            Me.txtAfterFactManagement.ReadOnlys = False
            Me.txtAfterFactManagement.SelectedText = ""
            Me.txtAfterFactManagement.SelectionLength = 0
            Me.txtAfterFactManagement.SelectionStart = 0
            Me.txtAfterFactManagement.Size = New System.Drawing.Size(291, 41)
            Me.txtAfterFactManagement.TabIndex = 23
            Me.txtAfterFactManagement.Tag = ""
            Me.txtAfterFactManagement.TextAlign = 0
            Me.txtAfterFactManagement.TextValue = ""
            Me.txtAfterFactManagement.ToolTipText = ""
            '
            'txtTerms
            '
            Me.txtTerms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtTerms.BackColor = System.Drawing.SystemColors.Window
            Me.txtTerms.BorderColor = System.Drawing.Color.Empty
            Me.txtTerms.BorderStyle = 1
            Me.txtTerms.CaptionName = "처리 주기"
            Me.txtTerms.Location = New System.Drawing.Point(94, 489)
            Me.txtTerms.MaxLength = 0
            Me.txtTerms.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtTerms.Multiline = False
            Me.txtTerms.Name = "txtTerms"
            Me.txtTerms.ReadOnlys = False
            Me.txtTerms.SelectedText = ""
            Me.txtTerms.SelectionLength = 0
            Me.txtTerms.SelectionStart = 0
            Me.txtTerms.Size = New System.Drawing.Size(291, 20)
            Me.txtTerms.TabIndex = 19
            Me.txtTerms.Tag = ""
            Me.txtTerms.TextAlign = 0
            Me.txtTerms.TextValue = ""
            Me.txtTerms.ToolTipText = ""
            '
            'txtPreconditionItem
            '
            Me.txtPreconditionItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtPreconditionItem.BackColor = System.Drawing.SystemColors.Window
            Me.txtPreconditionItem.BorderColor = System.Drawing.Color.Empty
            Me.txtPreconditionItem.BorderStyle = 1
            Me.txtPreconditionItem.CaptionName = "필수 항목"
            Me.txtPreconditionItem.Location = New System.Drawing.Point(94, 600)
            Me.txtPreconditionItem.MaximumSize = New System.Drawing.Size(291, 40)
            Me.txtPreconditionItem.MaxLength = 10000
            Me.txtPreconditionItem.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPreconditionItem.Multiline = True
            Me.txtPreconditionItem.Name = "txtPreconditionItem"
            Me.txtPreconditionItem.ReadOnlys = False
            Me.txtPreconditionItem.SelectedText = ""
            Me.txtPreconditionItem.SelectionLength = 0
            Me.txtPreconditionItem.SelectionStart = 0
            Me.txtPreconditionItem.Size = New System.Drawing.Size(291, 40)
            Me.txtPreconditionItem.TabIndex = 25
            Me.txtPreconditionItem.Tag = ""
            Me.txtPreconditionItem.TextAlign = 0
            Me.txtPreconditionItem.TextValue = ""
            Me.txtPreconditionItem.ToolTipText = ""
            '
            'cboSystemDivision
            '
            Me.cboSystemDivision.CaptionName = "시스템 구분 명"
            Me.cboSystemDivision.ListCount = 0
            Me.cboSystemDivision.Location = New System.Drawing.Point(107, 17)
            Me.cboSystemDivision.Name = "cboSystemDivision"
            Me.cboSystemDivision.ReadOnlys = False
            Me.cboSystemDivision.Size = New System.Drawing.Size(219, 20)
            Me.cboSystemDivision.TabIndex = 1
            Me.cboSystemDivision.Tag = "code(시스템 구분 명|전체);"
            Me.cboSystemDivision.TextValue = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(27, 21)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(72, 18)
            Me.lblCodeDivisionHangulName.TabIndex = 0
            Me.lblCodeDivisionHangulName.Text = "시스템 구분"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'BtnImageOpen1
            '
            Me.BtnImageOpen1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnImageOpen1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.BtnImageOpen1.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnImageOpen1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.BtnImageOpen1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.BtnImageOpen1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.BtnImageOpen1.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.BtnImageOpen1.Location = New System.Drawing.Point(805, 22)
            Me.BtnImageOpen1.Name = "BtnImageOpen1"
            Me.BtnImageOpen1.Size = New System.Drawing.Size(43, 20)
            Me.BtnImageOpen1.TabIndex = 0
            Me.BtnImageOpen1.TabStop = False
            Me.BtnImageOpen1.Text = "열기1"
            Me.BtnImageOpen1.UseVisualStyleBackColor = True
            Me.BtnImageOpen1.Visible = False
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            '
            'BtnImageSave
            '
            Me.BtnImageSave.BackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnImageSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.BtnImageSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnImageSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.BtnImageSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.BtnImageSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.BtnImageSave.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.BtnImageSave.Location = New System.Drawing.Point(854, 22)
            Me.BtnImageSave.Name = "BtnImageSave"
            Me.BtnImageSave.Size = New System.Drawing.Size(50, 20)
            Me.BtnImageSave.TabIndex = 5
            Me.BtnImageSave.TabStop = False
            Me.BtnImageSave.Text = "저장"
            Me.BtnImageSave.UseVisualStyleBackColor = True
            Me.BtnImageSave.Visible = False
            '
            'cboPrivateUseYesOrNo
            '
            Me.cboPrivateUseYesOrNo.CaptionName = "사용 여부"
            Me.cboPrivateUseYesOrNo.ListCount = 0
            Me.cboPrivateUseYesOrNo.Location = New System.Drawing.Point(435, 17)
            Me.cboPrivateUseYesOrNo.Name = "cboPrivateUseYesOrNo"
            Me.cboPrivateUseYesOrNo.ReadOnlys = False
            Me.cboPrivateUseYesOrNo.Size = New System.Drawing.Size(126, 20)
            Me.cboPrivateUseYesOrNo.TabIndex = 3
            Me.cboPrivateUseYesOrNo.Tag = "code(사용 여부 명|전체);"
            Me.cboPrivateUseYesOrNo.TextValue = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(361, 21)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(68, 16)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "사용 여부"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picUiImage
            '
            Me.picUiImage.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picUiImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picUiImage.Location = New System.Drawing.Point(620, 29)
            Me.picUiImage.Name = "picUiImage"
            Me.picUiImage.Size = New System.Drawing.Size(156, 18)
            Me.picUiImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picUiImage.TabIndex = 466
            Me.picUiImage.TabStop = False
            Me.picUiImage.Visible = False
            '
            'UIImage
            '
            Me.UIImage.BackColor = System.Drawing.Color.WhiteSmoke
            Me.UIImage.Location = New System.Drawing.Point(620, 11)
            Me.UIImage.Name = "UIImage"
            Me.UIImage.Size = New System.Drawing.Size(156, 12)
            Me.UIImage.TabIndex = 5
            Me.UIImage.Text = "화면 이미지"
            Me.UIImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.UIImage.Visible = False
            '
            'chkCreateYesOrNo
            '
            Me.chkCreateYesOrNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkCreateYesOrNo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkCreateYesOrNo.CaptionName = "생성 여부"
            Me.chkCreateYesOrNo.Location = New System.Drawing.Point(497, 379)
            Me.chkCreateYesOrNo.Name = "chkCreateYesOrNo"
            Me.chkCreateYesOrNo.ReadOnlys = False
            Me.chkCreateYesOrNo.Size = New System.Drawing.Size(76, 16)
            Me.chkCreateYesOrNo.TabIndex = 29
            Me.chkCreateYesOrNo.Tag = ""
            Me.chkCreateYesOrNo.Text = "생성 여부"
            Me.chkCreateYesOrNo.TextValue = "0"
            Me.chkCreateYesOrNo.UseVisualStyleBackColor = False
            '
            'chkDeleteYesOrNo
            '
            Me.chkDeleteYesOrNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkDeleteYesOrNo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkDeleteYesOrNo.CaptionName = "삭제 여부"
            Me.chkDeleteYesOrNo.Location = New System.Drawing.Point(672, 379)
            Me.chkDeleteYesOrNo.Name = "chkDeleteYesOrNo"
            Me.chkDeleteYesOrNo.ReadOnlys = False
            Me.chkDeleteYesOrNo.Size = New System.Drawing.Size(76, 16)
            Me.chkDeleteYesOrNo.TabIndex = 31
            Me.chkDeleteYesOrNo.Tag = ""
            Me.chkDeleteYesOrNo.Text = "삭제 여부"
            Me.chkDeleteYesOrNo.TextValue = "0"
            Me.chkDeleteYesOrNo.UseVisualStyleBackColor = False
            '
            'chkRequestYesOrNo
            '
            Me.chkRequestYesOrNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkRequestYesOrNo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkRequestYesOrNo.CaptionName = "조회 여부"
            Me.chkRequestYesOrNo.Location = New System.Drawing.Point(412, 379)
            Me.chkRequestYesOrNo.Name = "chkRequestYesOrNo"
            Me.chkRequestYesOrNo.ReadOnlys = False
            Me.chkRequestYesOrNo.Size = New System.Drawing.Size(76, 16)
            Me.chkRequestYesOrNo.TabIndex = 28
            Me.chkRequestYesOrNo.Tag = ""
            Me.chkRequestYesOrNo.Text = "조회 여부"
            Me.chkRequestYesOrNo.TextValue = "0"
            Me.chkRequestYesOrNo.UseVisualStyleBackColor = False
            '
            'chkUpdateYesOrNo
            '
            Me.chkUpdateYesOrNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkUpdateYesOrNo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkUpdateYesOrNo.CaptionName = "정수 여부"
            Me.chkUpdateYesOrNo.Location = New System.Drawing.Point(583, 379)
            Me.chkUpdateYesOrNo.Name = "chkUpdateYesOrNo"
            Me.chkUpdateYesOrNo.ReadOnlys = False
            Me.chkUpdateYesOrNo.Size = New System.Drawing.Size(76, 16)
            Me.chkUpdateYesOrNo.TabIndex = 30
            Me.chkUpdateYesOrNo.Tag = ""
            Me.chkUpdateYesOrNo.Text = "수정 여부"
            Me.chkUpdateYesOrNo.TextValue = "0"
            Me.chkUpdateYesOrNo.UseVisualStyleBackColor = False
            '
            'btnDefault
            '
            Me.btnDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnDefault.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnDefault.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnDefault.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnDefault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDefault.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnDefault.Location = New System.Drawing.Point(412, 406)
            Me.btnDefault.Name = "btnDefault"
            Me.btnDefault.Size = New System.Drawing.Size(60, 20)
            Me.btnDefault.TabIndex = 34
            Me.btnDefault.TabStop = False
            Me.btnDefault.Text = "Default"
            Me.btnDefault.UseVisualStyleBackColor = True
            '
            'chkPrintYesOrNo
            '
            Me.chkPrintYesOrNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkPrintYesOrNo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkPrintYesOrNo.CaptionName = "력출 여부"
            Me.chkPrintYesOrNo.Location = New System.Drawing.Point(761, 379)
            Me.chkPrintYesOrNo.Name = "chkPrintYesOrNo"
            Me.chkPrintYesOrNo.ReadOnlys = False
            Me.chkPrintYesOrNo.Size = New System.Drawing.Size(76, 16)
            Me.chkPrintYesOrNo.TabIndex = 467
            Me.chkPrintYesOrNo.Tag = ""
            Me.chkPrintYesOrNo.Text = "출력 여부"
            Me.chkPrintYesOrNo.TextValue = "0"
            Me.chkPrintYesOrNo.UseVisualStyleBackColor = False
            '
            'txtUiID
            '
            Me.txtUiID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtUiID.BackColor = System.Drawing.SystemColors.Window
            Me.txtUiID.BorderColor = System.Drawing.Color.Empty
            Me.txtUiID.BorderStyle = 1
            Me.txtUiID.CaptionName = "화면 ID"
            Me.txtUiID.Location = New System.Drawing.Point(488, 405)
            Me.txtUiID.MaxLength = 10
            Me.txtUiID.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtUiID.Multiline = False
            Me.txtUiID.Name = "txtUiID"
            Me.txtUiID.ReadOnlys = False
            Me.txtUiID.SelectedText = ""
            Me.txtUiID.SelectionLength = 0
            Me.txtUiID.SelectionStart = 0
            Me.txtUiID.Size = New System.Drawing.Size(41, 20)
            Me.txtUiID.TabIndex = 468
            Me.txtUiID.Tag = "read;"
            Me.txtUiID.TextAlign = 0
            Me.txtUiID.TextValue = ""
            Me.txtUiID.ToolTipText = ""
            Me.txtUiID.Visible = False
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(5, 368)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(1020, 358)
            Me.picIo_2.TabIndex = 469
            Me.picIo_2.TabStop = False
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(1020, 49)
            Me.picCriteria.TabIndex = 470
            Me.picCriteria.TabStop = False
            '
            'txtSkillExplanation
            '
            Me.txtSkillExplanation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtSkillExplanation.AutoScroll = True
            Me.txtSkillExplanation.BackColor = System.Drawing.SystemColors.Window
            Me.txtSkillExplanation.BorderColor = System.Drawing.Color.Empty
            Me.txtSkillExplanation.BorderStyle = 1
            Me.txtSkillExplanation.CaptionName = "사용 방법"
            Me.txtSkillExplanation.Location = New System.Drawing.Point(412, 432)
            Me.txtSkillExplanation.MaximumSize = New System.Drawing.Size(550, 280)
            Me.txtSkillExplanation.MaxLength = 99999999
            Me.txtSkillExplanation.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSkillExplanation.Multiline = True
            Me.txtSkillExplanation.Name = "txtSkillExplanation"
            Me.txtSkillExplanation.ReadOnlys = False
            Me.txtSkillExplanation.SelectedText = ""
            Me.txtSkillExplanation.SelectionLength = 0
            Me.txtSkillExplanation.SelectionStart = 0
            Me.txtSkillExplanation.Size = New System.Drawing.Size(550, 280)
            Me.txtSkillExplanation.TabIndex = 472
            Me.txtSkillExplanation.Tag = ""
            Me.txtSkillExplanation.TextAlign = 0
            Me.txtSkillExplanation.TextValue = ""
            Me.txtSkillExplanation.ToolTipText = ""
            '
            'btnAutoImage
            '
            Me.btnAutoImage.Location = New System.Drawing.Point(909, 11)
            Me.btnAutoImage.Name = "btnAutoImage"
            Me.btnAutoImage.Size = New System.Drawing.Size(50, 31)
            Me.btnAutoImage.TabIndex = 473
            Me.btnAutoImage.Text = "이미지연속등록^^"
            Me.btnAutoImage.UseVisualStyleBackColor = True
            Me.btnAutoImage.Visible = False
            '
            'WebBrowser1
            '
            Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.WebBrowser1.Location = New System.Drawing.Point(535, 58)
            Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowser1.Name = "WebBrowser1"
            Me.WebBrowser1.Size = New System.Drawing.Size(490, 304)
            Me.WebBrowser1.TabIndex = 474
            '
            'SMEB01
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.WebBrowser1)
            Me.Controls.Add(Me.BtnImageOpen1)
            Me.Controls.Add(Me.UIImage)
            Me.Controls.Add(Me.BtnImageSave)
            Me.Controls.Add(Me.picUiImage)
            Me.Controls.Add(Me.lblUIID)
            Me.Controls.Add(Me.btnAutoImage)
            Me.Controls.Add(Me.txtSkillExplanation)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.txtUiID)
            Me.Controls.Add(Me.cboSystemDivision)
            Me.Controls.Add(Me.lblUINAME)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.chkPrintYesOrNo)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtProgramID)
            Me.Controls.Add(Me.chkDeleteYesOrNo)
            Me.Controls.Add(Me.txtProgramName)
            Me.Controls.Add(Me.cboPrivateUseYesOrNo)
            Me.Controls.Add(Me.chkUpdateYesOrNo)
            Me.Controls.Add(Me.txtUiDescription)
            Me.Controls.Add(Me.chkCreateYesOrNo)
            Me.Controls.Add(Me.txtPreconditionItem)
            Me.Controls.Add(Me.lblUiDescription)
            Me.Controls.Add(Me.txtTerms)
            Me.Controls.Add(Me.txtAfterFactManagement)
            Me.Controls.Add(Me.txtDictionaryManagement)
            Me.Controls.Add(Me.btnDefault)
            Me.Controls.Add(Me.lblSkillExplanation)
            Me.Controls.Add(Me.txtAttentionItem)
            Me.Controls.Add(Me.lblAfterFactManagement)
            Me.Controls.Add(Me.lblPreconditionItem)
            Me.Controls.Add(Me.chkRequestYesOrNo)
            Me.Controls.Add(Me.lblTerms)
            Me.Controls.Add(Me.lblDictionaryManagement)
            Me.Controls.Add(Me.lblAttentionItem)
            Me.Controls.Add(Me.picIo_2)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "SMEB01"
            Me.Size = New System.Drawing.Size(1028, 731)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.picIo_2, 0)
            Me.Controls.SetChildIndex(Me.lblAttentionItem, 0)
            Me.Controls.SetChildIndex(Me.lblDictionaryManagement, 0)
            Me.Controls.SetChildIndex(Me.lblTerms, 0)
            Me.Controls.SetChildIndex(Me.chkRequestYesOrNo, 0)
            Me.Controls.SetChildIndex(Me.lblPreconditionItem, 0)
            Me.Controls.SetChildIndex(Me.lblAfterFactManagement, 0)
            Me.Controls.SetChildIndex(Me.txtAttentionItem, 0)
            Me.Controls.SetChildIndex(Me.lblSkillExplanation, 0)
            Me.Controls.SetChildIndex(Me.btnDefault, 0)
            Me.Controls.SetChildIndex(Me.txtDictionaryManagement, 0)
            Me.Controls.SetChildIndex(Me.txtAfterFactManagement, 0)
            Me.Controls.SetChildIndex(Me.txtTerms, 0)
            Me.Controls.SetChildIndex(Me.lblUiDescription, 0)
            Me.Controls.SetChildIndex(Me.txtPreconditionItem, 0)
            Me.Controls.SetChildIndex(Me.chkCreateYesOrNo, 0)
            Me.Controls.SetChildIndex(Me.txtUiDescription, 0)
            Me.Controls.SetChildIndex(Me.chkUpdateYesOrNo, 0)
            Me.Controls.SetChildIndex(Me.cboPrivateUseYesOrNo, 0)
            Me.Controls.SetChildIndex(Me.txtProgramName, 0)
            Me.Controls.SetChildIndex(Me.chkDeleteYesOrNo, 0)
            Me.Controls.SetChildIndex(Me.txtProgramID, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.chkPrintYesOrNo, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblUINAME, 0)
            Me.Controls.SetChildIndex(Me.cboSystemDivision, 0)
            Me.Controls.SetChildIndex(Me.txtUiID, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.txtSkillExplanation, 0)
            Me.Controls.SetChildIndex(Me.btnAutoImage, 0)
            Me.Controls.SetChildIndex(Me.lblUIID, 0)
            Me.Controls.SetChildIndex(Me.picUiImage, 0)
            Me.Controls.SetChildIndex(Me.BtnImageSave, 0)
            Me.Controls.SetChildIndex(Me.UIImage, 0)
            Me.Controls.SetChildIndex(Me.BtnImageOpen1, 0)
            Me.Controls.SetChildIndex(Me.WebBrowser1, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picUiImage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents txtProgramID As ubiLease.CommonControls.txt
        Friend WithEvents lblUINAME As System.Windows.Forms.Label
        Friend WithEvents lblUIID As System.Windows.Forms.Label
        Friend WithEvents txtProgramName As ubiLease.CommonControls.txt
        Friend WithEvents txtUiDescription As ubiLease.CommonControls.txt
        Friend WithEvents lblUiDescription As System.Windows.Forms.Label
        Friend WithEvents lblSkillExplanation As System.Windows.Forms.Label
        Friend WithEvents lblAfterFactManagement As System.Windows.Forms.Label
        Friend WithEvents lblDictionaryManagement As System.Windows.Forms.Label
        Friend WithEvents lblAttentionItem As System.Windows.Forms.Label
        Friend WithEvents lblTerms As System.Windows.Forms.Label
        Friend WithEvents lblPreconditionItem As System.Windows.Forms.Label
        Friend WithEvents txtAttentionItem As ubiLease.CommonControls.txt
        Friend WithEvents txtDictionaryManagement As ubiLease.CommonControls.txt
        Friend WithEvents txtAfterFactManagement As ubiLease.CommonControls.txt
        Friend WithEvents txtTerms As ubiLease.CommonControls.txt
        Friend WithEvents txtPreconditionItem As ubiLease.CommonControls.txt
        Friend WithEvents cboSystemDivision As ubiLease.CommonControls.cbo
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents BtnImageOpen1 As ubiLease.CommonControls.btn
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents BtnImageSave As ubiLease.CommonControls.btn
        Friend WithEvents cboPrivateUseYesOrNo As ubiLease.CommonControls.cbo
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents picUiImage As System.Windows.Forms.PictureBox
        Friend WithEvents UIImage As System.Windows.Forms.Label
        Friend WithEvents chkCreateYesOrNo As ubiLease.CommonControls.chk
        Friend WithEvents chkDeleteYesOrNo As ubiLease.CommonControls.chk
        Friend WithEvents chkRequestYesOrNo As ubiLease.CommonControls.chk
        Friend WithEvents chkUpdateYesOrNo As ubiLease.CommonControls.chk
        Friend WithEvents btnDefault As ubiLease.CommonControls.btn
        Friend WithEvents chkPrintYesOrNo As ubiLease.CommonControls.chk
        Friend WithEvents txtUiID As ubiLease.CommonControls.txt
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents txtSkillExplanation As ubiLease.CommonControls.txt
        Friend WithEvents btnAutoImage As System.Windows.Forms.Button
        Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

    End Class

End Namespace
