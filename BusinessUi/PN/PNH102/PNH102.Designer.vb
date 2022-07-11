Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNH102
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNH102))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.txtEmployee_R = New ubiLease.CommonControls.txt
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtBranchNm_R = New ubiLease.CommonControls.txt
            Me.lblReaderNm_2 = New System.Windows.Forms.Label
            Me.dtpBaseYear = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optBranchPa1 = New System.Windows.Forms.RadioButton
            Me.optBranchPa2 = New System.Windows.Forms.RadioButton
            Me.Label2 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
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
            Me.picCriteria_1.Size = New System.Drawing.Size(802, 47)
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
            Me.grd_1.Location = New System.Drawing.Point(5, 91)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(803, 553)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'txtEmployee_R
            '
            Me.txtEmployee_R.BackColor = System.Drawing.SystemColors.Window
            Me.txtEmployee_R.BorderColor = System.Drawing.Color.Empty
            Me.txtEmployee_R.BorderStyle = 2
            Me.txtEmployee_R.CaptionName = "담당 명"
            Me.txtEmployee_R.Location = New System.Drawing.Point(279, 20)
            Me.txtEmployee_R.MaxLength = 32767
            Me.txtEmployee_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtEmployee_R.Multiline = False
            Me.txtEmployee_R.Name = "txtEmployee_R"
            Me.txtEmployee_R.ReadOnlys = False
            Me.txtEmployee_R.SelectedText = ""
            Me.txtEmployee_R.SelectionLength = 0
            Me.txtEmployee_R.SelectionStart = 0
            Me.txtEmployee_R.Size = New System.Drawing.Size(115, 20)
            Me.txtEmployee_R.TabIndex = 1462
            Me.txtEmployee_R.Tag = Nothing
            Me.txtEmployee_R.TextAlign = 0
            Me.txtEmployee_R.TextValue = ""
            Me.txtEmployee_R.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(226, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 15)
            Me.Label1.TabIndex = 1461
            Me.Label1.Text = "담당명"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtBranchNm_R
            '
            Me.txtBranchNm_R.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm_R.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm_R.BorderStyle = 2
            Me.txtBranchNm_R.CaptionName = "지국 명"
            Me.txtBranchNm_R.Location = New System.Drawing.Point(476, 20)
            Me.txtBranchNm_R.MaxLength = 32767
            Me.txtBranchNm_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm_R.Multiline = False
            Me.txtBranchNm_R.Name = "txtBranchNm_R"
            Me.txtBranchNm_R.ReadOnlys = False
            Me.txtBranchNm_R.SelectedText = ""
            Me.txtBranchNm_R.SelectionLength = 0
            Me.txtBranchNm_R.SelectionStart = 0
            Me.txtBranchNm_R.Size = New System.Drawing.Size(115, 20)
            Me.txtBranchNm_R.TabIndex = 1460
            Me.txtBranchNm_R.Tag = Nothing
            Me.txtBranchNm_R.TextAlign = 0
            Me.txtBranchNm_R.TextValue = ""
            Me.txtBranchNm_R.ToolTipText = ""
            '
            'lblReaderNm_2
            '
            Me.lblReaderNm_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReaderNm_2.Location = New System.Drawing.Point(421, 23)
            Me.lblReaderNm_2.Name = "lblReaderNm_2"
            Me.lblReaderNm_2.Size = New System.Drawing.Size(49, 15)
            Me.lblReaderNm_2.TabIndex = 1459
            Me.lblReaderNm_2.Text = "지국명"
            Me.lblReaderNm_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpBaseYear
            '
            Me.dtpBaseYear.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseYear.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseYear.BorderStyle = 2
            Me.dtpBaseYear.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseYear.CaptionName = "발행 년월"
            Me.dtpBaseYear.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseYear.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseYear.Location = New System.Drawing.Point(89, 20)
            Me.dtpBaseYear.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYear.MaxLength = 0
            Me.dtpBaseYear.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYear.Name = "dtpBaseYear"
            Me.dtpBaseYear.ReadOnlys = False
            Me.dtpBaseYear.SelectedText = ""
            Me.dtpBaseYear.SelectionLength = 0
            Me.dtpBaseYear.SelectionStart = 0
            Me.dtpBaseYear.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYear.TabIndex = 1464
            Me.dtpBaseYear.Tag = "format(&&&&-&&);"
            Me.dtpBaseYear.TextAlign = 0
            Me.dtpBaseYear.TextValue = ""
            Me.dtpBaseYear.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(26, 23)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(60, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 1463
            Me.lblCodeDivisionHangulName.Text = "발행년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optBranchPa1)
            Me.Opt2.Controls.Add(Me.optBranchPa2)
            Me.Opt2.Location = New System.Drawing.Point(5, 55)
            Me.Opt2.MaximumSize = New System.Drawing.Size(500, 100)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 30)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(421, 32)
            Me.Opt2.TabIndex = 1625
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optBranchPa1
            '
            Me.optBranchPa1.AutoSize = True
            Me.optBranchPa1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optBranchPa1.Checked = True
            Me.optBranchPa1.Location = New System.Drawing.Point(19, 8)
            Me.optBranchPa1.Name = "optBranchPa1"
            Me.optBranchPa1.Size = New System.Drawing.Size(155, 16)
            Me.optBranchPa1.TabIndex = 342
            Me.optBranchPa1.TabStop = True
            Me.optBranchPa1.Text = "지국별 부수 및 판매현황"
            Me.optBranchPa1.UseVisualStyleBackColor = False
            '
            'optBranchPa2
            '
            Me.optBranchPa2.AutoSize = True
            Me.optBranchPa2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optBranchPa2.Location = New System.Drawing.Point(192, 8)
            Me.optBranchPa2.Name = "optBranchPa2"
            Me.optBranchPa2.Size = New System.Drawing.Size(207, 16)
            Me.optBranchPa2.TabIndex = 343
            Me.optBranchPa2.Text = "지국별 본사 월 유가부수 증감내역"
            Me.optBranchPa2.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label2.Location = New System.Drawing.Point(437, 60)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(365, 24)
            Me.Label2.TabIndex = 1671
            Me.Label2.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(428, 55)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(379, 32)
            Me.PictureBox1.TabIndex = 1672
            Me.PictureBox1.TabStop = False
            '
            'PNH102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.dtpBaseYear)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.txtEmployee_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtBranchNm_R)
            Me.Controls.Add(Me.lblReaderNm_2)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNH102"
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
        Friend WithEvents txtEmployee_R As ubiLease.CommonControls.txt
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm_R As ubiLease.CommonControls.txt
        Friend WithEvents lblReaderNm_2 As System.Windows.Forms.Label
        Friend WithEvents dtpBaseYear As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optBranchPa1 As System.Windows.Forms.RadioButton
        Friend WithEvents optBranchPa2 As System.Windows.Forms.RadioButton
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

    End Class

End Namespace
