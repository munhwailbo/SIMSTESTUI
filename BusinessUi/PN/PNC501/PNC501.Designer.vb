Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNC501
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNC501))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.dtpReceiptDtFrom = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpReceiptDtTo = New ubiLease.CommonControls.dtp
            Me.Label8 = New System.Windows.Forms.Label
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.Label33 = New System.Windows.Forms.Label
            Me.txtPhoneNum_2 = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtSubscriberNm_2 = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            Me.cboConsultationDivCd = New ubiLease.CommonControls.cbo
            Me.Label7 = New System.Windows.Forms.Label
            Me.cboStateCd = New ubiLease.CommonControls.cbo
            Me.Label1 = New System.Windows.Forms.Label
            Me.PopBranchCd = New ubiLease.CommonControls.pop
            Me.Label4 = New System.Windows.Forms.Label
            Me.PopMonitorEmpCd = New ubiLease.CommonControls.pop
            Me.Label5 = New System.Windows.Forms.Label
            Me.cboExpandDivCd = New ubiLease.CommonControls.cbo
            Me.Label9 = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(3, 92)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 552)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(805, 83)
            Me.picCriteria.TabIndex = 8
            Me.picCriteria.TabStop = False
            '
            'dtpReceiptDtFrom
            '
            Me.dtpReceiptDtFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDtFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDtFrom.BorderStyle = 2
            Me.dtpReceiptDtFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDtFrom.CaptionName = "접수 일자"
            Me.dtpReceiptDtFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDtFrom.Location = New System.Drawing.Point(83, 11)
            Me.dtpReceiptDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtFrom.MaxLength = 0
            Me.dtpReceiptDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtFrom.Name = "dtpReceiptDtFrom"
            Me.dtpReceiptDtFrom.ReadOnlys = False
            Me.dtpReceiptDtFrom.SelectedText = ""
            Me.dtpReceiptDtFrom.SelectionLength = 0
            Me.dtpReceiptDtFrom.SelectionStart = 0
            Me.dtpReceiptDtFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtFrom.TabIndex = 1539
            Me.dtpReceiptDtFrom.Tag = "need;format(####-##-##);"
            Me.dtpReceiptDtFrom.TextAlign = 0
            Me.dtpReceiptDtFrom.TextValue = ""
            Me.dtpReceiptDtFrom.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(173, 14)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 15)
            Me.Label6.TabIndex = 1545
            Me.Label6.Text = "~"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpReceiptDtTo
            '
            Me.dtpReceiptDtTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDtTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDtTo.BorderStyle = 2
            Me.dtpReceiptDtTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDtTo.CaptionName = "접수 일자 2"
            Me.dtpReceiptDtTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDtTo.Location = New System.Drawing.Point(194, 11)
            Me.dtpReceiptDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtTo.MaxLength = 0
            Me.dtpReceiptDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtTo.Name = "dtpReceiptDtTo"
            Me.dtpReceiptDtTo.ReadOnlys = False
            Me.dtpReceiptDtTo.SelectedText = ""
            Me.dtpReceiptDtTo.SelectionLength = 0
            Me.dtpReceiptDtTo.SelectionStart = 0
            Me.dtpReceiptDtTo.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtTo.TabIndex = 1540
            Me.dtpReceiptDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDtTo.TextAlign = 0
            Me.dtpReceiptDtTo.TextValue = ""
            Me.dtpReceiptDtTo.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(15, 14)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(61, 15)
            Me.Label8.TabIndex = 1544
            Me.Label8.Text = "접수일자"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popEmployeeNumber
            '
            Me.popEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeNumber.BorderStyle = 2
            Me.popEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeNumber.CaptionName = "담당자"
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.CodeWidth = 60
            Me.popEmployeeNumber.Location = New System.Drawing.Point(355, 59)
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
            Me.popEmployeeNumber.Size = New System.Drawing.Size(150, 20)
            Me.popEmployeeNumber.TabIndex = 1543
            Me.popEmployeeNumber.Tag = "code(영업사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label33.Location = New System.Drawing.Point(285, 62)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(65, 15)
            Me.Label33.TabIndex = 1548
            Me.Label33.Text = "지국담당자"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPhoneNum_2
            '
            Me.txtPhoneNum_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhoneNum_2.BorderColor = System.Drawing.Color.Empty
            Me.txtPhoneNum_2.BorderStyle = 2
            Me.txtPhoneNum_2.CaptionName = "전화번호1"
            Me.txtPhoneNum_2.Location = New System.Drawing.Point(355, 36)
            Me.txtPhoneNum_2.MaxLength = 14
            Me.txtPhoneNum_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPhoneNum_2.Multiline = False
            Me.txtPhoneNum_2.Name = "txtPhoneNum_2"
            Me.txtPhoneNum_2.ReadOnlys = False
            Me.txtPhoneNum_2.SelectedText = ""
            Me.txtPhoneNum_2.SelectionLength = 0
            Me.txtPhoneNum_2.SelectionStart = 0
            Me.txtPhoneNum_2.Size = New System.Drawing.Size(150, 20)
            Me.txtPhoneNum_2.TabIndex = 1542
            Me.txtPhoneNum_2.Tag = ""
            Me.txtPhoneNum_2.TextAlign = 0
            Me.txtPhoneNum_2.TextValue = ""
            Me.txtPhoneNum_2.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(284, 39)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 15)
            Me.Label2.TabIndex = 1547
            Me.Label2.Text = "전화번호"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtSubscriberNm_2
            '
            Me.txtSubscriberNm_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubscriberNm_2.BorderColor = System.Drawing.Color.Empty
            Me.txtSubscriberNm_2.BorderStyle = 2
            Me.txtSubscriberNm_2.CaptionName = Nothing
            Me.txtSubscriberNm_2.Location = New System.Drawing.Point(83, 36)
            Me.txtSubscriberNm_2.MaxLength = 32767
            Me.txtSubscriberNm_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSubscriberNm_2.Multiline = False
            Me.txtSubscriberNm_2.Name = "txtSubscriberNm_2"
            Me.txtSubscriberNm_2.ReadOnlys = False
            Me.txtSubscriberNm_2.SelectedText = ""
            Me.txtSubscriberNm_2.SelectionLength = 0
            Me.txtSubscriberNm_2.SelectionStart = 0
            Me.txtSubscriberNm_2.Size = New System.Drawing.Size(150, 20)
            Me.txtSubscriberNm_2.TabIndex = 1541
            Me.txtSubscriberNm_2.Tag = Nothing
            Me.txtSubscriberNm_2.TextAlign = 0
            Me.txtSubscriberNm_2.TextValue = ""
            Me.txtSubscriberNm_2.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(15, 39)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(61, 15)
            Me.Label3.TabIndex = 1546
            Me.Label3.Text = "독자명"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboConsultationDivCd
            '
            Me.cboConsultationDivCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboConsultationDivCd.CaptionName = "상담구분코드"
            Me.cboConsultationDivCd.Enabled = False
            Me.cboConsultationDivCd.ListCount = 0
            Me.cboConsultationDivCd.Location = New System.Drawing.Point(355, 11)
            Me.cboConsultationDivCd.Name = "cboConsultationDivCd"
            Me.cboConsultationDivCd.ReadOnlys = False
            Me.cboConsultationDivCd.Size = New System.Drawing.Size(150, 20)
            Me.cboConsultationDivCd.TabIndex = 1549
            Me.cboConsultationDivCd.Tag = "code(민원구분코드|전체)"
            Me.cboConsultationDivCd.TextValue = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(296, 14)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(57, 15)
            Me.Label7.TabIndex = 1550
            Me.Label7.Text = "민원구분"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboStateCd
            '
            Me.cboStateCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboStateCd.CaptionName = "민원상태코드"
            Me.cboStateCd.Enabled = False
            Me.cboStateCd.ListCount = 0
            Me.cboStateCd.Location = New System.Drawing.Point(640, 12)
            Me.cboStateCd.Name = "cboStateCd"
            Me.cboStateCd.ReadOnlys = False
            Me.cboStateCd.Size = New System.Drawing.Size(150, 20)
            Me.cboStateCd.TabIndex = 1551
            Me.cboStateCd.Tag = "code(민원상태코드|전체)"
            Me.cboStateCd.TextValue = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(552, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 16)
            Me.Label1.TabIndex = 1552
            Me.Label1.Text = "민원처리상태"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PopBranchCd
            '
            Me.PopBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.PopBranchCd.BorderStyle = 2
            Me.PopBranchCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopBranchCd.CaptionName = "담당자"
            Me.PopBranchCd.CodeText = ""
            Me.PopBranchCd.CodeWidth = 60
            Me.PopBranchCd.Location = New System.Drawing.Point(83, 59)
            Me.PopBranchCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.PopBranchCd.MaxLength = 32767
            Me.PopBranchCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.PopBranchCd.Name = "PopBranchCd"
            Me.PopBranchCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.PopBranchCd.NameText = ""
            Me.PopBranchCd.ReadOnlys = False
            Me.PopBranchCd.SelectedText = ""
            Me.PopBranchCd.SelectionLength = 0
            Me.PopBranchCd.SelectionStart = 0
            Me.PopBranchCd.Size = New System.Drawing.Size(150, 20)
            Me.PopBranchCd.TabIndex = 1553
            Me.PopBranchCd.Tag = "code(지국코드);"
            Me.PopBranchCd.TextAlign = 0
            Me.PopBranchCd.TextValue = ""
            Me.PopBranchCd.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(13, 62)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(65, 15)
            Me.Label4.TabIndex = 1554
            Me.Label4.Text = "지국"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PopMonitorEmpCd
            '
            Me.PopMonitorEmpCd.BorderColor = System.Drawing.Color.Empty
            Me.PopMonitorEmpCd.BorderStyle = 2
            Me.PopMonitorEmpCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopMonitorEmpCd.CaptionName = "담당자"
            Me.PopMonitorEmpCd.CodeText = ""
            Me.PopMonitorEmpCd.CodeWidth = 60
            Me.PopMonitorEmpCd.Location = New System.Drawing.Point(640, 59)
            Me.PopMonitorEmpCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.PopMonitorEmpCd.MaxLength = 32767
            Me.PopMonitorEmpCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.PopMonitorEmpCd.Name = "PopMonitorEmpCd"
            Me.PopMonitorEmpCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.PopMonitorEmpCd.NameText = ""
            Me.PopMonitorEmpCd.ReadOnlys = False
            Me.PopMonitorEmpCd.SelectedText = ""
            Me.PopMonitorEmpCd.SelectionLength = 0
            Me.PopMonitorEmpCd.SelectionStart = 0
            Me.PopMonitorEmpCd.Size = New System.Drawing.Size(150, 20)
            Me.PopMonitorEmpCd.TabIndex = 1555
            Me.PopMonitorEmpCd.Tag = "code(모니터담당 명);"
            Me.PopMonitorEmpCd.TextAlign = 0
            Me.PopMonitorEmpCd.TextValue = ""
            Me.PopMonitorEmpCd.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(570, 62)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 15)
            Me.Label5.TabIndex = 1556
            Me.Label5.Text = "민원담당자"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboExpandDivCd
            '
            Me.cboExpandDivCd.BackColor = System.Drawing.SystemColors.Window
            Me.cboExpandDivCd.CaptionName = "상담구분코드"
            Me.cboExpandDivCd.Enabled = False
            Me.cboExpandDivCd.ListCount = 0
            Me.cboExpandDivCd.Location = New System.Drawing.Point(640, 36)
            Me.cboExpandDivCd.Name = "cboExpandDivCd"
            Me.cboExpandDivCd.ReadOnlys = False
            Me.cboExpandDivCd.Size = New System.Drawing.Size(150, 20)
            Me.cboExpandDivCd.TabIndex = 1557
            Me.cboExpandDivCd.Tag = "code(확장구분코드|전체)"
            Me.cboExpandDivCd.TextValue = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(581, 37)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(57, 15)
            Me.Label9.TabIndex = 1558
            Me.Label9.Text = "확장구분"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNC501
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.cboExpandDivCd)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.PopMonitorEmpCd)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.PopBranchCd)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.cboStateCd)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cboConsultationDivCd)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.dtpReceiptDtFrom)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpReceiptDtTo)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.Label33)
            Me.Controls.Add(Me.txtPhoneNum_2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtSubscriberNm_2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNC501"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.txtSubscriberNm_2, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.txtPhoneNum_2, 0)
            Me.Controls.SetChildIndex(Me.Label33, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeNumber, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtTo, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtFrom, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.cboConsultationDivCd, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.cboStateCd, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.PopBranchCd, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.PopMonitorEmpCd, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.cboExpandDivCd, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents dtpReceiptDtFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents txtPhoneNum_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtSubscriberNm_2 As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboConsultationDivCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cboStateCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PopBranchCd As ubiLease.CommonControls.pop
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents PopMonitorEmpCd As ubiLease.CommonControls.pop
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cboExpandDivCd As ubiLease.CommonControls.cbo
        Friend WithEvents Label9 As System.Windows.Forms.Label

    End Class

End Namespace
