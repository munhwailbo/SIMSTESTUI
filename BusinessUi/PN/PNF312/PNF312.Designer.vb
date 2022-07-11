Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNF312
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNF312))
            Me.dtpReceiptDtFrom = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpReceiptDtTo = New ubiLease.CommonControls.dtp
            Me.Label8 = New System.Windows.Forms.Label
            Me.popEmployeeNumber = New ubiLease.CommonControls.pop
            Me.Label33 = New System.Windows.Forms.Label
            Me.popDeliveryBranchCd_2 = New ubiLease.CommonControls.pop
            Me.lblFormDivisionCode = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.chkNewCheck = New ubiLease.CommonControls.chk
            Me.chkExistCheck = New ubiLease.CommonControls.chk
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpReceiptDtFrom
            '
            Me.dtpReceiptDtFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpReceiptDtFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpReceiptDtFrom.BorderStyle = 2
            Me.dtpReceiptDtFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpReceiptDtFrom.CaptionName = "접수 일자"
            Me.dtpReceiptDtFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpReceiptDtFrom.Location = New System.Drawing.Point(84, 20)
            Me.dtpReceiptDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtFrom.MaxLength = 0
            Me.dtpReceiptDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtFrom.Name = "dtpReceiptDtFrom"
            Me.dtpReceiptDtFrom.ReadOnlys = False
            Me.dtpReceiptDtFrom.SelectedText = ""
            Me.dtpReceiptDtFrom.SelectionLength = 0
            Me.dtpReceiptDtFrom.SelectionStart = 0
            Me.dtpReceiptDtFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtFrom.TabIndex = 0
            Me.dtpReceiptDtFrom.Tag = "need;format(####-##-##);"
            Me.dtpReceiptDtFrom.TextAlign = 0
            Me.dtpReceiptDtFrom.TextValue = ""
            Me.dtpReceiptDtFrom.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(174, 22)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 15)
            Me.Label6.TabIndex = 1571
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
            Me.dtpReceiptDtTo.Location = New System.Drawing.Point(195, 20)
            Me.dtpReceiptDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpReceiptDtTo.MaxLength = 0
            Me.dtpReceiptDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpReceiptDtTo.Name = "dtpReceiptDtTo"
            Me.dtpReceiptDtTo.ReadOnlys = False
            Me.dtpReceiptDtTo.SelectedText = ""
            Me.dtpReceiptDtTo.SelectionLength = 0
            Me.dtpReceiptDtTo.SelectionStart = 0
            Me.dtpReceiptDtTo.Size = New System.Drawing.Size(93, 20)
            Me.dtpReceiptDtTo.TabIndex = 1
            Me.dtpReceiptDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpReceiptDtTo.TextAlign = 0
            Me.dtpReceiptDtTo.TextValue = ""
            Me.dtpReceiptDtTo.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(16, 22)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(61, 15)
            Me.Label8.TabIndex = 1570
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
            Me.popEmployeeNumber.Location = New System.Drawing.Point(84, 48)
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
            Me.popEmployeeNumber.Size = New System.Drawing.Size(444, 20)
            Me.popEmployeeNumber.TabIndex = 3
            Me.popEmployeeNumber.Tag = "code(영업사원 명);"
            Me.popEmployeeNumber.TextAlign = 0
            Me.popEmployeeNumber.TextValue = ""
            Me.popEmployeeNumber.ToolTipText = ""
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label33.Location = New System.Drawing.Point(29, 51)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(50, 15)
            Me.Label33.TabIndex = 1567
            Me.Label33.Text = "담당자"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popDeliveryBranchCd_2
            '
            Me.popDeliveryBranchCd_2.BorderColor = System.Drawing.Color.Empty
            Me.popDeliveryBranchCd_2.BorderStyle = 2
            Me.popDeliveryBranchCd_2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popDeliveryBranchCd_2.CaptionName = "지사지국 코드"
            Me.popDeliveryBranchCd_2.CodeText = ""
            Me.popDeliveryBranchCd_2.CodeWidth = 60
            Me.popDeliveryBranchCd_2.Location = New System.Drawing.Point(365, 19)
            Me.popDeliveryBranchCd_2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popDeliveryBranchCd_2.MaxLength = 32767
            Me.popDeliveryBranchCd_2.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popDeliveryBranchCd_2.Name = "popDeliveryBranchCd_2"
            Me.popDeliveryBranchCd_2.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popDeliveryBranchCd_2.NameText = ""
            Me.popDeliveryBranchCd_2.ReadOnlys = False
            Me.popDeliveryBranchCd_2.SelectedText = ""
            Me.popDeliveryBranchCd_2.SelectionLength = 0
            Me.popDeliveryBranchCd_2.SelectionStart = 0
            Me.popDeliveryBranchCd_2.Size = New System.Drawing.Size(163, 20)
            Me.popDeliveryBranchCd_2.TabIndex = 2
            Me.popDeliveryBranchCd_2.Tag = "code(지국코드);"
            Me.popDeliveryBranchCd_2.TextAlign = 0
            Me.popDeliveryBranchCd_2.TextValue = ""
            Me.popDeliveryBranchCd_2.ToolTipText = ""
            '
            'lblFormDivisionCode
            '
            Me.lblFormDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFormDivisionCode.Location = New System.Drawing.Point(297, 22)
            Me.lblFormDivisionCode.Name = "lblFormDivisionCode"
            Me.lblFormDivisionCode.Size = New System.Drawing.Size(61, 15)
            Me.lblFormDivisionCode.TabIndex = 1566
            Me.lblFormDivisionCode.Text = "지사지국"
            Me.lblFormDivisionCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 4)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(801, 82)
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
            Me.grd_1.Location = New System.Drawing.Point(5, 92)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 550)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1560
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'chkNewCheck
            '
            Me.chkNewCheck.AutoSize = True
            Me.chkNewCheck.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkNewCheck.CaptionName = Nothing
            Me.chkNewCheck.Location = New System.Drawing.Point(614, 24)
            Me.chkNewCheck.Name = "chkNewCheck"
            Me.chkNewCheck.ReadOnlys = False
            Me.chkNewCheck.Size = New System.Drawing.Size(72, 16)
            Me.chkNewCheck.TabIndex = 1572
            Me.chkNewCheck.Tag = Nothing
            Me.chkNewCheck.Text = "신규독자"
            Me.chkNewCheck.TextValue = "0"
            Me.chkNewCheck.UseVisualStyleBackColor = False
            '
            'chkExistCheck
            '
            Me.chkExistCheck.AutoSize = True
            Me.chkExistCheck.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkExistCheck.CaptionName = Nothing
            Me.chkExistCheck.Location = New System.Drawing.Point(614, 50)
            Me.chkExistCheck.Name = "chkExistCheck"
            Me.chkExistCheck.ReadOnlys = False
            Me.chkExistCheck.Size = New System.Drawing.Size(72, 16)
            Me.chkExistCheck.TabIndex = 1573
            Me.chkExistCheck.Tag = Nothing
            Me.chkExistCheck.Text = "중복독자"
            Me.chkExistCheck.TextValue = "0"
            Me.chkExistCheck.UseVisualStyleBackColor = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(602, 14)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(157, 61)
            Me.PictureBox1.TabIndex = 1574
            Me.PictureBox1.TabStop = False
            '
            'PNF312
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.chkNewCheck)
            Me.Controls.Add(Me.chkExistCheck)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label33)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.lblFormDivisionCode)
            Me.Controls.Add(Me.dtpReceiptDtFrom)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpReceiptDtTo)
            Me.Controls.Add(Me.popDeliveryBranchCd_2)
            Me.Controls.Add(Me.popEmployeeNumber)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNF312"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeNumber, 0)
            Me.Controls.SetChildIndex(Me.popDeliveryBranchCd_2, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtTo, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.dtpReceiptDtFrom, 0)
            Me.Controls.SetChildIndex(Me.lblFormDivisionCode, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.Label33, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.chkExistCheck, 0)
            Me.Controls.SetChildIndex(Me.chkNewCheck, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dtpReceiptDtFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents popDeliveryBranchCd_2 As ubiLease.CommonControls.pop
        Friend WithEvents lblFormDivisionCode As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents chkNewCheck As ubiLease.CommonControls.chk
        Friend WithEvents chkExistCheck As ubiLease.CommonControls.chk
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox


    End Class

End Namespace
