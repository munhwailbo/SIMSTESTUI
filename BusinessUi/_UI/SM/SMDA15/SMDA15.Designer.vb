Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMDA15
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMDA15))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.lblCheckDate_R = New System.Windows.Forms.Label
            Me.dtpCheckDate_R = New ubiLease.CommonControls.dtp
            Me.cboWorkDivision_R = New ubiLease.CommonControls.cbo
            Me.lblWorkDivision_R = New System.Windows.Forms.Label
            Me.grd_2 = New ubiLease.GridControl.grd
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.Location = New System.Drawing.Point(5, 64)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(802, 276)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 22
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(802, 53)
            Me.picCriteria_1.TabIndex = 424
            Me.picCriteria_1.TabStop = False
            '
            'lblCheckDate_R
            '
            Me.lblCheckDate_R.AutoSize = True
            Me.lblCheckDate_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCheckDate_R.Location = New System.Drawing.Point(31, 26)
            Me.lblCheckDate_R.Name = "lblCheckDate_R"
            Me.lblCheckDate_R.Size = New System.Drawing.Size(57, 12)
            Me.lblCheckDate_R.TabIndex = 461
            Me.lblCheckDate_R.Text = "점검 일자"
            Me.lblCheckDate_R.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpCheckDate_R
            '
            Me.dtpCheckDate_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCheckDate_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpCheckDate_R.BorderStyle = 2
            Me.dtpCheckDate_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCheckDate_R.CaptionName = "기준 일자"
            Me.dtpCheckDate_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpCheckDate_R.Location = New System.Drawing.Point(94, 22)
            Me.dtpCheckDate_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCheckDate_R.MaxLength = 0
            Me.dtpCheckDate_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCheckDate_R.Name = "dtpCheckDate_R"
            Me.dtpCheckDate_R.ReadOnlys = False
            Me.dtpCheckDate_R.SelectedText = ""
            Me.dtpCheckDate_R.SelectionLength = 0
            Me.dtpCheckDate_R.SelectionStart = 0
            Me.dtpCheckDate_R.Size = New System.Drawing.Size(116, 20)
            Me.dtpCheckDate_R.TabIndex = 460
            Me.dtpCheckDate_R.Tag = "format(####-##-##);"
            Me.dtpCheckDate_R.TextAlign = 0
            Me.dtpCheckDate_R.TextValue = ""
            Me.dtpCheckDate_R.ToolTipText = ""
            '
            'cboWorkDivision_R
            '
            Me.cboWorkDivision_R.CaptionName = "업무 구분 정의 명"
            Me.cboWorkDivision_R.ListCount = 0
            Me.cboWorkDivision_R.Location = New System.Drawing.Point(328, 22)
            Me.cboWorkDivision_R.Name = "cboWorkDivision_R"
            Me.cboWorkDivision_R.ReadOnlys = False
            Me.cboWorkDivision_R.Size = New System.Drawing.Size(134, 20)
            Me.cboWorkDivision_R.TabIndex = 457
            Me.cboWorkDivision_R.Tag = "code(업무 구분 정의 명|전체);"
            Me.cboWorkDivision_R.TextValue = ""
            '
            'lblWorkDivision_R
            '
            Me.lblWorkDivision_R.AutoSize = True
            Me.lblWorkDivision_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblWorkDivision_R.Location = New System.Drawing.Point(265, 26)
            Me.lblWorkDivision_R.Name = "lblWorkDivision_R"
            Me.lblWorkDivision_R.Size = New System.Drawing.Size(57, 12)
            Me.lblWorkDivision_R.TabIndex = 456
            Me.lblWorkDivision_R.Text = "업무 구분"
            Me.lblWorkDivision_R.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_2.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_2.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_2.Cols = 2
            Me.grd_2.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(5, 346)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(802, 298)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 462
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'SMDA15
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.lblCheckDate_R)
            Me.Controls.Add(Me.dtpCheckDate_R)
            Me.Controls.Add(Me.cboWorkDivision_R)
            Me.Controls.Add(Me.lblWorkDivision_R)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "SMDA15"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblWorkDivision_R, 0)
            Me.Controls.SetChildIndex(Me.cboWorkDivision_R, 0)
            Me.Controls.SetChildIndex(Me.dtpCheckDate_R, 0)
            Me.Controls.SetChildIndex(Me.lblCheckDate_R, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblCheckDate_R As System.Windows.Forms.Label
        Friend WithEvents dtpCheckDate_R As ubiLease.CommonControls.dtp
        Friend WithEvents cboWorkDivision_R As ubiLease.CommonControls.cbo
        Friend WithEvents lblWorkDivision_R As System.Windows.Forms.Label
        Friend WithEvents grd_2 As ubiLease.GridControl.grd

    End Class

End Namespace
