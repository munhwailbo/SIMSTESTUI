Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNH103
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNH103))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpBaseYear = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.Opt1 = New System.Windows.Forms.RadioButton
            Me.optPrint = New System.Windows.Forms.RadioButton
            Me.optPaperNum = New System.Windows.Forms.RadioButton
            Me.Label2 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.txtEmployee_R = New ubiLease.CommonControls.txt
            Me.Label1 = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 42)
            Me.picCriteria_1.TabIndex = 2
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
            Me.grd_1.Location = New System.Drawing.Point(5, 84)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(804, 560)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpBaseYear
            '
            Me.dtpBaseYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYear.BorderStyle = 2
            Me.dtpBaseYear.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYear.CaptionName = "기준 일자"
            Me.dtpBaseYear.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBaseYear.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYear.Location = New System.Drawing.Point(151, 17)
            Me.dtpBaseYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYear.MaxLength = 0
            Me.dtpBaseYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYear.Name = "dtpBaseYear"
            Me.dtpBaseYear.ReadOnlys = False
            Me.dtpBaseYear.SelectedText = ""
            Me.dtpBaseYear.SelectionLength = 0
            Me.dtpBaseYear.SelectionStart = 0
            Me.dtpBaseYear.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYear.TabIndex = 24
            Me.dtpBaseYear.Tag = "format(&&&&-&&-&&);"
            Me.dtpBaseYear.TextAlign = 0
            Me.dtpBaseYear.TextValue = ""
            Me.dtpBaseYear.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(36, 20)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(111, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 23
            Me.lblCodeDivisionHangulName.Text = "기준 일자"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.Opt1)
            Me.Opt2.Controls.Add(Me.optPrint)
            Me.Opt2.Controls.Add(Me.optPaperNum)
            Me.Opt2.Location = New System.Drawing.Point(5, 49)
            Me.Opt2.MaximumSize = New System.Drawing.Size(500, 50)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(459, 32)
            Me.Opt2.TabIndex = 1625
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'Opt1
            '
            Me.Opt1.AutoSize = True
            Me.Opt1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt1.Location = New System.Drawing.Point(16, 8)
            Me.Opt1.Name = "Opt1"
            Me.Opt1.Size = New System.Drawing.Size(147, 16)
            Me.Opt1.TabIndex = 344
            Me.Opt1.Text = "인쇄처별 발행부수현황"
            Me.Opt1.UseVisualStyleBackColor = False
            '
            'optPrint
            '
            Me.optPrint.AutoSize = True
            Me.optPrint.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optPrint.Checked = True
            Me.optPrint.Location = New System.Drawing.Point(173, 8)
            Me.optPrint.Name = "optPrint"
            Me.optPrint.Size = New System.Drawing.Size(111, 16)
            Me.optPrint.TabIndex = 342
            Me.optPrint.TabStop = True
            Me.optPrint.Text = "인쇄부수 통보서"
            Me.optPrint.UseVisualStyleBackColor = False
            '
            'optPaperNum
            '
            Me.optPaperNum.AutoSize = True
            Me.optPaperNum.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optPaperNum.Location = New System.Drawing.Point(296, 8)
            Me.optPaperNum.Name = "optPaperNum"
            Me.optPaperNum.Size = New System.Drawing.Size(149, 16)
            Me.optPaperNum.TabIndex = 343
            Me.optPaperNum.Text = "부수증감 CHECK-LIST"
            Me.optPaperNum.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label2.Location = New System.Drawing.Point(477, 54)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(326, 24)
            Me.Label2.TabIndex = 1673
            Me.Label2.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(467, 49)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(341, 32)
            Me.PictureBox1.TabIndex = 1674
            Me.PictureBox1.TabStop = False
            '
            'txtEmployee_R
            '
            Me.txtEmployee_R.BackColor = System.Drawing.SystemColors.Window
            Me.txtEmployee_R.BorderColor = System.Drawing.Color.Empty
            Me.txtEmployee_R.BorderStyle = 2
            Me.txtEmployee_R.CaptionName = "담당 명"
            Me.txtEmployee_R.Location = New System.Drawing.Point(375, 17)
            Me.txtEmployee_R.MaxLength = 32767
            Me.txtEmployee_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtEmployee_R.Multiline = False
            Me.txtEmployee_R.Name = "txtEmployee_R"
            Me.txtEmployee_R.ReadOnlys = False
            Me.txtEmployee_R.SelectedText = ""
            Me.txtEmployee_R.SelectionLength = 0
            Me.txtEmployee_R.SelectionStart = 0
            Me.txtEmployee_R.Size = New System.Drawing.Size(140, 20)
            Me.txtEmployee_R.TabIndex = 1678
            Me.txtEmployee_R.Tag = Nothing
            Me.txtEmployee_R.TextAlign = 0
            Me.txtEmployee_R.TextValue = ""
            Me.txtEmployee_R.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(304, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(65, 15)
            Me.Label1.TabIndex = 1677
            Me.Label1.Text = "담당명"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNH103
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtEmployee_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.dtpBaseYear)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNH103"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents dtpBaseYear As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents Opt1 As System.Windows.Forms.RadioButton
        Friend WithEvents optPrint As System.Windows.Forms.RadioButton
        Friend WithEvents optPaperNum As System.Windows.Forms.RadioButton
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents txtEmployee_R As ubiLease.CommonControls.txt
        Friend WithEvents Label1 As System.Windows.Forms.Label

    End Class

End Namespace
