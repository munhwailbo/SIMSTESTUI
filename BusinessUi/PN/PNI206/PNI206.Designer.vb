Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI206
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI206))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.popSalesCd_R = New ubiLease.CommonControls.pop
            Me.cboSalesDivCd_R = New ubiLease.CommonControls.cbo
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.dtpTaxAccPublishDt2 = New ubiLease.CommonControls.dtp
            Me.dtpTaxAccPublishDt = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optDemand = New System.Windows.Forms.RadioButton
            Me.optReceipt = New System.Windows.Forms.RadioButton
            Me.Label1 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.optExpAmt1 = New System.Windows.Forms.RadioButton
            Me.Label3 = New System.Windows.Forms.Label
            Me.RadioButton1 = New System.Windows.Forms.RadioButton
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
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
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 101)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 539)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'popSalesCd_R
            '
            Me.popSalesCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popSalesCd_R.BorderStyle = 2
            Me.popSalesCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popSalesCd_R.CaptionName = "매출처 코드"
            Me.popSalesCd_R.CodeText = ""
            Me.popSalesCd_R.CodeWidth = 80
            Me.popSalesCd_R.Location = New System.Drawing.Point(111, 37)
            Me.popSalesCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popSalesCd_R.MaxLength = 12
            Me.popSalesCd_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popSalesCd_R.Name = "popSalesCd_R"
            Me.popSalesCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popSalesCd_R.NameText = ""
            Me.popSalesCd_R.ReadOnlys = False
            Me.popSalesCd_R.SelectedText = ""
            Me.popSalesCd_R.SelectionLength = 0
            Me.popSalesCd_R.SelectionStart = 0
            Me.popSalesCd_R.Size = New System.Drawing.Size(270, 20)
            Me.popSalesCd_R.TabIndex = 1
            Me.popSalesCd_R.Tag = "code(매출처코드 명);"
            Me.popSalesCd_R.TextAlign = 0
            Me.popSalesCd_R.TextValue = ""
            Me.popSalesCd_R.ToolTipText = ""
            '
            'cboSalesDivCd_R
            '
            Me.cboSalesDivCd_R.BackColor = System.Drawing.SystemColors.Window
            Me.cboSalesDivCd_R.CaptionName = "매출처구분코드"
            Me.cboSalesDivCd_R.Enabled = False
            Me.cboSalesDivCd_R.ListCount = 0
            Me.cboSalesDivCd_R.Location = New System.Drawing.Point(111, 14)
            Me.cboSalesDivCd_R.Name = "cboSalesDivCd_R"
            Me.cboSalesDivCd_R.ReadOnlys = False
            Me.cboSalesDivCd_R.Size = New System.Drawing.Size(111, 20)
            Me.cboSalesDivCd_R.TabIndex = 0
            Me.cboSalesDivCd_R.Tag = "code(매출처구분코드|전체);"
            Me.cboSalesDivCd_R.TextValue = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(29, 15)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(77, 18)
            Me.Label8.TabIndex = 5
            Me.Label8.Text = "매출처구분"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(594, 38)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(18, 18)
            Me.Label7.TabIndex = 8
            Me.Label7.Text = "~"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpTaxAccPublishDt2
            '
            Me.dtpTaxAccPublishDt2.BackColor = System.Drawing.SystemColors.Window
            Me.dtpTaxAccPublishDt2.BorderColor = System.Drawing.Color.Empty
            Me.dtpTaxAccPublishDt2.BorderStyle = 2
            Me.dtpTaxAccPublishDt2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpTaxAccPublishDt2.CaptionName = "발행 일자"
            Me.dtpTaxAccPublishDt2.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpTaxAccPublishDt2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpTaxAccPublishDt2.Location = New System.Drawing.Point(617, 37)
            Me.dtpTaxAccPublishDt2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpTaxAccPublishDt2.MaxLength = 0
            Me.dtpTaxAccPublishDt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpTaxAccPublishDt2.Name = "dtpTaxAccPublishDt2"
            Me.dtpTaxAccPublishDt2.ReadOnlys = False
            Me.dtpTaxAccPublishDt2.SelectedText = ""
            Me.dtpTaxAccPublishDt2.SelectionLength = 0
            Me.dtpTaxAccPublishDt2.SelectionStart = 0
            Me.dtpTaxAccPublishDt2.Size = New System.Drawing.Size(100, 20)
            Me.dtpTaxAccPublishDt2.TabIndex = 3
            Me.dtpTaxAccPublishDt2.Tag = "format(&&&&-&&-&&);"
            Me.dtpTaxAccPublishDt2.TextAlign = 0
            Me.dtpTaxAccPublishDt2.TextValue = ""
            Me.dtpTaxAccPublishDt2.ToolTipText = ""
            '
            'dtpTaxAccPublishDt
            '
            Me.dtpTaxAccPublishDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpTaxAccPublishDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpTaxAccPublishDt.BorderStyle = 2
            Me.dtpTaxAccPublishDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpTaxAccPublishDt.CaptionName = "발행 일자"
            Me.dtpTaxAccPublishDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpTaxAccPublishDt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpTaxAccPublishDt.Location = New System.Drawing.Point(493, 37)
            Me.dtpTaxAccPublishDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpTaxAccPublishDt.MaxLength = 0
            Me.dtpTaxAccPublishDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpTaxAccPublishDt.Name = "dtpTaxAccPublishDt"
            Me.dtpTaxAccPublishDt.ReadOnlys = False
            Me.dtpTaxAccPublishDt.SelectedText = ""
            Me.dtpTaxAccPublishDt.SelectionLength = 0
            Me.dtpTaxAccPublishDt.SelectionStart = 0
            Me.dtpTaxAccPublishDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpTaxAccPublishDt.TabIndex = 2
            Me.dtpTaxAccPublishDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpTaxAccPublishDt.TextAlign = 0
            Me.dtpTaxAccPublishDt.TextValue = ""
            Me.dtpTaxAccPublishDt.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(410, 40)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(77, 15)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "발행 일자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(29, 40)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(77, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 6
            Me.lblCodeDivisionHangulName.Text = "매출처코드"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(801, 59)
            Me.picCriteria_1.TabIndex = 1564
            Me.picCriteria_1.TabStop = False
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.Label3)
            Me.Opt2.Controls.Add(Me.optExpAmt1)
            Me.Opt2.Controls.Add(Me.optDemand)
            Me.Opt2.Controls.Add(Me.optReceipt)
            Me.Opt2.Location = New System.Drawing.Point(5, 67)
            Me.Opt2.MaximumSize = New System.Drawing.Size(1000, 100)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(240, 30)
            Me.Opt2.TabIndex = 1635
            Me.Opt2.Tag = Nothing
            '
            'optDemand
            '
            Me.optDemand.AutoSize = True
            Me.optDemand.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optDemand.Checked = True
            Me.optDemand.Location = New System.Drawing.Point(24, 5)
            Me.optDemand.Name = "optDemand"
            Me.optDemand.Size = New System.Drawing.Size(47, 16)
            Me.optDemand.TabIndex = 342
            Me.optDemand.TabStop = True
            Me.optDemand.Text = "청구"
            Me.optDemand.UseVisualStyleBackColor = False
            '
            'optReceipt
            '
            Me.optReceipt.AutoSize = True
            Me.optReceipt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optReceipt.Location = New System.Drawing.Point(86, 5)
            Me.optReceipt.Name = "optReceipt"
            Me.optReceipt.Size = New System.Drawing.Size(47, 16)
            Me.optReceipt.TabIndex = 343
            Me.optReceipt.Text = "영수"
            Me.optReceipt.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label1.Location = New System.Drawing.Point(364, 72)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(434, 22)
            Me.Label1.TabIndex = 1675
            Me.Label1.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(356, 67)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(450, 30)
            Me.PictureBox1.TabIndex = 1676
            Me.PictureBox1.TabStop = False
            '
            'optExpAmt1
            '
            Me.optExpAmt1.AutoSize = True
            Me.optExpAmt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optExpAmt1.Location = New System.Drawing.Point(168, 5)
            Me.optExpAmt1.Name = "optExpAmt1"
            Me.optExpAmt1.Size = New System.Drawing.Size(59, 16)
            Me.optExpAmt1.TabIndex = 344
            Me.optExpAmt1.Text = "청구서"
            Me.optExpAmt1.UseVisualStyleBackColor = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(139, 3)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(18, 18)
            Me.Label3.TabIndex = 1677
            Me.Label3.Text = "/"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'RadioButton1
            '
            Me.RadioButton1.AutoSize = True
            Me.RadioButton1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.RadioButton1.Location = New System.Drawing.Point(168, 5)
            Me.RadioButton1.Name = "RadioButton1"
            Me.RadioButton1.Size = New System.Drawing.Size(59, 16)
            Me.RadioButton1.TabIndex = 344
            Me.RadioButton1.Text = "청구서"
            Me.RadioButton1.UseVisualStyleBackColor = False
            '
            'PNI206
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.popSalesCd_R)
            Me.Controls.Add(Me.cboSalesDivCd_R)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.dtpTaxAccPublishDt2)
            Me.Controls.Add(Me.dtpTaxAccPublishDt)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNI206"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.dtpTaxAccPublishDt, 0)
            Me.Controls.SetChildIndex(Me.dtpTaxAccPublishDt2, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.cboSalesDivCd_R, 0)
            Me.Controls.SetChildIndex(Me.popSalesCd_R, 0)
            Me.Controls.SetChildIndex(Me.Opt2, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents popSalesCd_R As ubiLease.CommonControls.pop
        Friend WithEvents cboSalesDivCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpTaxAccPublishDt2 As ubiLease.CommonControls.dtp
        Friend WithEvents dtpTaxAccPublishDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optDemand As System.Windows.Forms.RadioButton
        Friend WithEvents optReceipt As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents optExpAmt1 As System.Windows.Forms.RadioButton
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton


    End Class

End Namespace
