Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI104
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI104))
            Me.dtpBaseYearMonths = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.btnCreateSale = New ubiLease.CommonControls.btn
            Me.chkValPaper1 = New ubiLease.CommonControls.chk
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.chkValPaper2 = New ubiLease.CommonControls.chk
            Me.chkValPaper4 = New ubiLease.CommonControls.chk
            Me.chkValPaper3 = New ubiLease.CommonControls.chk
            Me.chkPaperNum = New ubiLease.CommonControls.chk
            Me.chkUnitAmount = New ubiLease.CommonControls.chk
            Me.Label1 = New System.Windows.Forms.Label
            Me.popChargeEmpNum = New ubiLease.CommonControls.pop
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpBaseYearMonths
            '
            Me.dtpBaseYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYearMonths.BorderStyle = 2
            Me.dtpBaseYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYearMonths.CaptionName = "기준 일자"
            Me.dtpBaseYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseYearMonths.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYearMonths.Location = New System.Drawing.Point(123, 18)
            Me.dtpBaseYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYearMonths.MaxLength = 0
            Me.dtpBaseYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYearMonths.Name = "dtpBaseYearMonths"
            Me.dtpBaseYearMonths.ReadOnlys = False
            Me.dtpBaseYearMonths.SelectedText = ""
            Me.dtpBaseYearMonths.SelectionLength = 0
            Me.dtpBaseYearMonths.SelectionStart = 0
            Me.dtpBaseYearMonths.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYearMonths.TabIndex = 1612
            Me.dtpBaseYearMonths.Tag = "format(&&&&-&&);"
            Me.dtpBaseYearMonths.TextAlign = 0
            Me.dtpBaseYearMonths.TextValue = ""
            Me.dtpBaseYearMonths.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(38, 21)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(79, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 1609
            Me.lblCodeDivisionHangulName.Text = "기준 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 3)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(802, 46)
            Me.picCriteria_1.TabIndex = 1610
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
            Me.grd_1.Location = New System.Drawing.Point(5, 96)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(803, 548)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1611
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'btnCreateSale
            '
            Me.btnCreateSale.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCreateSale.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCreateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCreateSale.Location = New System.Drawing.Point(682, 16)
            Me.btnCreateSale.Name = "btnCreateSale"
            Me.btnCreateSale.Size = New System.Drawing.Size(109, 26)
            Me.btnCreateSale.TabIndex = 1619
            Me.btnCreateSale.Text = "매출 생성"
            Me.btnCreateSale.UseVisualStyleBackColor = True
            Me.btnCreateSale.Visible = False
            '
            'chkValPaper1
            '
            Me.chkValPaper1.AutoSize = True
            Me.chkValPaper1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkValPaper1.CaptionName = Nothing
            Me.chkValPaper1.Location = New System.Drawing.Point(60, 65)
            Me.chkValPaper1.Name = "chkValPaper1"
            Me.chkValPaper1.ReadOnlys = False
            Me.chkValPaper1.Size = New System.Drawing.Size(78, 16)
            Me.chkValPaper1.TabIndex = 1620
            Me.chkValPaper1.Tag = Nothing
            Me.chkValPaper1.Text = "일반유가1"
            Me.chkValPaper1.TextValue = "0"
            Me.chkValPaper1.UseVisualStyleBackColor = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(5, 52)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(802, 39)
            Me.PictureBox1.TabIndex = 1621
            Me.PictureBox1.TabStop = False
            '
            'chkValPaper2
            '
            Me.chkValPaper2.AutoSize = True
            Me.chkValPaper2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkValPaper2.CaptionName = Nothing
            Me.chkValPaper2.Location = New System.Drawing.Point(154, 65)
            Me.chkValPaper2.Name = "chkValPaper2"
            Me.chkValPaper2.ReadOnlys = False
            Me.chkValPaper2.Size = New System.Drawing.Size(78, 16)
            Me.chkValPaper2.TabIndex = 1622
            Me.chkValPaper2.Tag = Nothing
            Me.chkValPaper2.Text = "일반유가2"
            Me.chkValPaper2.TextValue = "0"
            Me.chkValPaper2.UseVisualStyleBackColor = False
            '
            'chkValPaper4
            '
            Me.chkValPaper4.AutoSize = True
            Me.chkValPaper4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkValPaper4.CaptionName = Nothing
            Me.chkValPaper4.Location = New System.Drawing.Point(311, 65)
            Me.chkValPaper4.Name = "chkValPaper4"
            Me.chkValPaper4.ReadOnlys = False
            Me.chkValPaper4.Size = New System.Drawing.Size(54, 16)
            Me.chkValPaper4.TabIndex = 1624
            Me.chkValPaper4.Tag = Nothing
            Me.chkValPaper4.Text = "기타2"
            Me.chkValPaper4.TextValue = "0"
            Me.chkValPaper4.UseVisualStyleBackColor = False
            Me.chkValPaper4.Visible = False
            '
            'chkValPaper3
            '
            Me.chkValPaper3.AutoSize = True
            Me.chkValPaper3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkValPaper3.CaptionName = Nothing
            Me.chkValPaper3.Location = New System.Drawing.Point(247, 65)
            Me.chkValPaper3.Name = "chkValPaper3"
            Me.chkValPaper3.ReadOnlys = False
            Me.chkValPaper3.Size = New System.Drawing.Size(54, 16)
            Me.chkValPaper3.TabIndex = 1623
            Me.chkValPaper3.Tag = Nothing
            Me.chkValPaper3.Text = "기타1"
            Me.chkValPaper3.TextValue = "0"
            Me.chkValPaper3.UseVisualStyleBackColor = False
            Me.chkValPaper3.Visible = False
            '
            'chkPaperNum
            '
            Me.chkPaperNum.AutoSize = True
            Me.chkPaperNum.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkPaperNum.CaptionName = Nothing
            Me.chkPaperNum.Location = New System.Drawing.Point(483, 65)
            Me.chkPaperNum.Name = "chkPaperNum"
            Me.chkPaperNum.ReadOnlys = False
            Me.chkPaperNum.Size = New System.Drawing.Size(48, 16)
            Me.chkPaperNum.TabIndex = 1625
            Me.chkPaperNum.Tag = Nothing
            Me.chkPaperNum.Text = "부수"
            Me.chkPaperNum.TextValue = "0"
            Me.chkPaperNum.UseVisualStyleBackColor = False
            '
            'chkUnitAmount
            '
            Me.chkUnitAmount.AutoSize = True
            Me.chkUnitAmount.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkUnitAmount.CaptionName = Nothing
            Me.chkUnitAmount.Location = New System.Drawing.Point(540, 65)
            Me.chkUnitAmount.Name = "chkUnitAmount"
            Me.chkUnitAmount.ReadOnlys = False
            Me.chkUnitAmount.Size = New System.Drawing.Size(48, 16)
            Me.chkUnitAmount.TabIndex = 1626
            Me.chkUnitAmount.Tag = Nothing
            Me.chkUnitAmount.Text = "단가"
            Me.chkUnitAmount.TextValue = "0"
            Me.chkUnitAmount.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(259, 21)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(79, 15)
            Me.Label1.TabIndex = 1628
            Me.Label1.Text = "담당자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum.BorderStyle = 2
            Me.popChargeEmpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum.CaptionName = "담당자"
            Me.popChargeEmpNum.CodeText = ""
            Me.popChargeEmpNum.CodeWidth = 60
            Me.popChargeEmpNum.Location = New System.Drawing.Point(344, 18)
            Me.popChargeEmpNum.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popChargeEmpNum.MaxLength = 6
            Me.popChargeEmpNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum.Name = "popChargeEmpNum"
            Me.popChargeEmpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum.NameText = ""
            Me.popChargeEmpNum.ReadOnlys = False
            Me.popChargeEmpNum.SelectedText = ""
            Me.popChargeEmpNum.SelectionLength = 0
            Me.popChargeEmpNum.SelectionStart = 0
            Me.popChargeEmpNum.Size = New System.Drawing.Size(159, 20)
            Me.popChargeEmpNum.TabIndex = 1629
            Me.popChargeEmpNum.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum.TextAlign = 0
            Me.popChargeEmpNum.TextValue = ""
            Me.popChargeEmpNum.ToolTipText = ""
            '
            'PNI104
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.chkUnitAmount)
            Me.Controls.Add(Me.chkPaperNum)
            Me.Controls.Add(Me.chkValPaper4)
            Me.Controls.Add(Me.chkValPaper3)
            Me.Controls.Add(Me.chkValPaper2)
            Me.Controls.Add(Me.chkValPaper1)
            Me.Controls.Add(Me.btnCreateSale)
            Me.Controls.Add(Me.dtpBaseYearMonths)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNI104"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseYearMonths, 0)
            Me.Controls.SetChildIndex(Me.btnCreateSale, 0)
            Me.Controls.SetChildIndex(Me.chkValPaper1, 0)
            Me.Controls.SetChildIndex(Me.chkValPaper2, 0)
            Me.Controls.SetChildIndex(Me.chkValPaper3, 0)
            Me.Controls.SetChildIndex(Me.chkValPaper4, 0)
            Me.Controls.SetChildIndex(Me.chkPaperNum, 0)
            Me.Controls.SetChildIndex(Me.chkUnitAmount, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dtpBaseYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents btnCreateSale As ubiLease.CommonControls.btn
        Friend WithEvents chkValPaper1 As ubiLease.CommonControls.chk
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents chkValPaper2 As ubiLease.CommonControls.chk
        Friend WithEvents chkValPaper4 As ubiLease.CommonControls.chk
        Friend WithEvents chkValPaper3 As ubiLease.CommonControls.chk
        Friend WithEvents chkPaperNum As ubiLease.CommonControls.chk
        Friend WithEvents chkUnitAmount As ubiLease.CommonControls.chk
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.pop


    End Class

End Namespace
