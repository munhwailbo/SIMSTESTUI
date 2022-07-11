Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI303
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI303))
            Me.lblBranchNm = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.dtpBaseYearMonths = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.txtBranchNm = New ubiLease.CommonControls.txt
            Me.cboOldOrNew = New ubiLease.CommonControls.cbo
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(290, 19)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(53, 20)
            Me.lblBranchNm.TabIndex = 4
            Me.lblBranchNm.Text = "지국명"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblBranchNm.Visible = False
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
            Me.grd_1.Location = New System.Drawing.Point(6, 54)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 575)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(6, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 43)
            Me.picCriteria_1.TabIndex = 1087
            Me.picCriteria_1.TabStop = False
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
            Me.dtpBaseYearMonths.Location = New System.Drawing.Point(116, 19)
            Me.dtpBaseYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseYearMonths.MaxLength = 0
            Me.dtpBaseYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseYearMonths.Name = "dtpBaseYearMonths"
            Me.dtpBaseYearMonths.ReadOnlys = False
            Me.dtpBaseYearMonths.SelectedText = ""
            Me.dtpBaseYearMonths.SelectionLength = 0
            Me.dtpBaseYearMonths.SelectionStart = 0
            Me.dtpBaseYearMonths.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseYearMonths.TabIndex = 0
            Me.dtpBaseYearMonths.Tag = "format(&&&&-&&);"
            Me.dtpBaseYearMonths.TextAlign = 0
            Me.dtpBaseYearMonths.TextValue = ""
            Me.dtpBaseYearMonths.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(31, 22)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(79, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 3
            Me.lblCodeDivisionHangulName.Text = "기준 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtBranchNm
            '
            Me.txtBranchNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm.BorderStyle = 2
            Me.txtBranchNm.CaptionName = "차수"
            Me.txtBranchNm.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtBranchNm.Location = New System.Drawing.Point(349, 19)
            Me.txtBranchNm.MaxLength = 50
            Me.txtBranchNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm.Multiline = False
            Me.txtBranchNm.Name = "txtBranchNm"
            Me.txtBranchNm.ReadOnlys = False
            Me.txtBranchNm.SelectedText = ""
            Me.txtBranchNm.SelectionLength = 0
            Me.txtBranchNm.SelectionStart = 0
            Me.txtBranchNm.Size = New System.Drawing.Size(144, 20)
            Me.txtBranchNm.TabIndex = 1
            Me.txtBranchNm.Tag = ""
            Me.txtBranchNm.TextAlign = 0
            Me.txtBranchNm.TextValue = ""
            Me.txtBranchNm.ToolTipText = ""
            Me.txtBranchNm.Visible = False
            '
            'cboOldOrNew
            '
            Me.cboOldOrNew.CaptionName = "전임현임구분"
            Me.cboOldOrNew.Enabled = False
            Me.cboOldOrNew.ListCount = 0
            Me.cboOldOrNew.Location = New System.Drawing.Point(615, 17)
            Me.cboOldOrNew.Name = "cboOldOrNew"
            Me.cboOldOrNew.ReadOnlys = False
            Me.cboOldOrNew.Size = New System.Drawing.Size(114, 20)
            Me.cboOldOrNew.TabIndex = 1525
            Me.cboOldOrNew.Tag = "code(담당자구분코드);"
            Me.cboOldOrNew.TextValue = ""
            '
            'PNI303
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.cboOldOrNew)
            Me.Controls.Add(Me.dtpBaseYearMonths)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.txtBranchNm)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "PNI303"
            Me.Size = New System.Drawing.Size(811, 632)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.txtBranchNm, 0)
            Me.Controls.SetChildIndex(Me.lblBranchNm, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseYearMonths, 0)
            Me.Controls.SetChildIndex(Me.cboOldOrNew, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpBaseYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm As ubiLease.CommonControls.txt
        Friend WithEvents cboOldOrNew As ubiLease.CommonControls.cbo


    End Class

End Namespace
