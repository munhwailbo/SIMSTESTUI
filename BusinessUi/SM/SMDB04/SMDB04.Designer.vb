Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMDB04
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMDB04))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.dtpBusinessDateFrom = New ubiLease.CommonControls.dtp
            Me.lblDongCode = New System.Windows.Forms.Label
            Me.dtpBusinessDateTo = New ubiLease.CommonControls.dtp
            Me.Label16 = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label4 = New System.Windows.Forms.Label
            Me.cboEmployee_R = New ubiLease.CommonControls.cbo
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 6)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(800, 49)
            Me.picCriteria_1.TabIndex = 70
            Me.picCriteria_1.TabStop = False
            '
            'dtpBusinessDateFrom
            '
            Me.dtpBusinessDateFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBusinessDateFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpBusinessDateFrom.BorderStyle = 2
            Me.dtpBusinessDateFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBusinessDateFrom.CaptionName = ""
            Me.dtpBusinessDateFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBusinessDateFrom.Location = New System.Drawing.Point(82, 19)
            Me.dtpBusinessDateFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBusinessDateFrom.MaxLength = 0
            Me.dtpBusinessDateFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBusinessDateFrom.Name = "dtpBusinessDateFrom"
            Me.dtpBusinessDateFrom.ReadOnlys = False
            Me.dtpBusinessDateFrom.SelectedText = ""
            Me.dtpBusinessDateFrom.SelectionLength = 0
            Me.dtpBusinessDateFrom.SelectionStart = 0
            Me.dtpBusinessDateFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpBusinessDateFrom.TabIndex = 0
            Me.dtpBusinessDateFrom.TabStop = False
            Me.dtpBusinessDateFrom.Tag = "format(&&&&-&&-&&);"
            Me.dtpBusinessDateFrom.TextAlign = 0
            Me.dtpBusinessDateFrom.TextValue = ""
            Me.dtpBusinessDateFrom.ToolTipText = ""
            '
            'lblDongCode
            '
            Me.lblDongCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDongCode.Location = New System.Drawing.Point(22, 23)
            Me.lblDongCode.Name = "lblDongCode"
            Me.lblDongCode.Size = New System.Drawing.Size(54, 14)
            Me.lblDongCode.TabIndex = 469
            Me.lblDongCode.Text = "업무일자"
            Me.lblDongCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpBusinessDateTo
            '
            Me.dtpBusinessDateTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBusinessDateTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpBusinessDateTo.BorderStyle = 2
            Me.dtpBusinessDateTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBusinessDateTo.CaptionName = ""
            Me.dtpBusinessDateTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBusinessDateTo.Location = New System.Drawing.Point(198, 19)
            Me.dtpBusinessDateTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBusinessDateTo.MaxLength = 0
            Me.dtpBusinessDateTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBusinessDateTo.Name = "dtpBusinessDateTo"
            Me.dtpBusinessDateTo.ReadOnlys = False
            Me.dtpBusinessDateTo.SelectedText = ""
            Me.dtpBusinessDateTo.SelectionLength = 0
            Me.dtpBusinessDateTo.SelectionStart = 0
            Me.dtpBusinessDateTo.Size = New System.Drawing.Size(94, 20)
            Me.dtpBusinessDateTo.TabIndex = 1
            Me.dtpBusinessDateTo.TabStop = False
            Me.dtpBusinessDateTo.Tag = "format(&&&&-&&-&&);"
            Me.dtpBusinessDateTo.TextAlign = 0
            Me.dtpBusinessDateTo.TextValue = ""
            Me.dtpBusinessDateTo.ToolTipText = ""
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label16.Location = New System.Drawing.Point(181, 22)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(12, 14)
            Me.Label16.TabIndex = 9
            Me.Label16.Text = "~"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.grd_1.Size = New System.Drawing.Size(800, 583)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 605
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            Me.grd_1.WordWrap = True
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(321, 23)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(36, 14)
            Me.Label4.TabIndex = 616
            Me.Label4.Text = "사원"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboEmployee_R
            '
            Me.cboEmployee_R.CaptionName = "작업 분류"
            Me.cboEmployee_R.ListCount = 0
            Me.cboEmployee_R.Location = New System.Drawing.Point(363, 21)
            Me.cboEmployee_R.Name = "cboEmployee_R"
            Me.cboEmployee_R.ReadOnlys = False
            Me.cboEmployee_R.Size = New System.Drawing.Size(203, 20)
            Me.cboEmployee_R.TabIndex = 624
            Me.cboEmployee_R.Tag = "code(요청사원 명|선택하세요);"
            Me.cboEmployee_R.TextValue = ""
            '
            'SMDB04
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.cboEmployee_R)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.dtpBusinessDateTo)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.dtpBusinessDateFrom)
            Me.Controls.Add(Me.lblDongCode)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "SMDB04"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblDongCode, 0)
            Me.Controls.SetChildIndex(Me.dtpBusinessDateFrom, 0)
            Me.Controls.SetChildIndex(Me.Label16, 0)
            Me.Controls.SetChildIndex(Me.dtpBusinessDateTo, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.cboEmployee_R, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpBusinessDateFrom As ubiLease.CommonControls.dtp
        Friend WithEvents lblDongCode As System.Windows.Forms.Label
        Friend WithEvents dtpBusinessDateTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cboEmployee_R As ubiLease.CommonControls.cbo

    End Class

End Namespace
