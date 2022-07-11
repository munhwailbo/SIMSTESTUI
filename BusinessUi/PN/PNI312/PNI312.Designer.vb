Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI312
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI312))
            Me.popBranchCd_R = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpYYYYMM = New ubiLease.CommonControls.dtp
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.popChargeEmpNum_R = New ubiLease.CommonControls.pop
            Me.Label20 = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'popBranchCd_R
            '
            Me.popBranchCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd_R.BorderStyle = 2
            Me.popBranchCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd_R.CaptionName = "지국 명"
            Me.popBranchCd_R.CodeText = ""
            Me.popBranchCd_R.CodeWidth = 60
            Me.popBranchCd_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popBranchCd_R.Location = New System.Drawing.Point(435, 43)
            Me.popBranchCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchCd_R.MaxLength = 7
            Me.popBranchCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd_R.Name = "popBranchCd_R"
            Me.popBranchCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd_R.NameText = ""
            Me.popBranchCd_R.ReadOnlys = False
            Me.popBranchCd_R.SelectedText = ""
            Me.popBranchCd_R.SelectionLength = 0
            Me.popBranchCd_R.SelectionStart = 0
            Me.popBranchCd_R.Size = New System.Drawing.Size(231, 20)
            Me.popBranchCd_R.TabIndex = 3
            Me.popBranchCd_R.Tag = "code(지국코드);"
            Me.popBranchCd_R.TextAlign = 0
            Me.popBranchCd_R.TextValue = ""
            Me.popBranchCd_R.ToolTipText = ""
            Me.popBranchCd_R.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(366, 46)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(63, 15)
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "지국 명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.Label2.Visible = False
            '
            'dtpYYYYMM
            '
            Me.dtpYYYYMM.BackColor = System.Drawing.SystemColors.Window
            Me.dtpYYYYMM.BorderColor = System.Drawing.Color.Empty
            Me.dtpYYYYMM.BorderStyle = 2
            Me.dtpYYYYMM.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpYYYYMM.CaptionName = "기준 년월"
            Me.dtpYYYYMM.DateTimeFormatText = "yyyy-MM"
            Me.dtpYYYYMM.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpYYYYMM.Location = New System.Drawing.Point(105, 19)
            Me.dtpYYYYMM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpYYYYMM.MaxLength = 0
            Me.dtpYYYYMM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpYYYYMM.Name = "dtpYYYYMM"
            Me.dtpYYYYMM.ReadOnlys = False
            Me.dtpYYYYMM.SelectedText = ""
            Me.dtpYYYYMM.SelectionLength = 0
            Me.dtpYYYYMM.SelectionStart = 0
            Me.dtpYYYYMM.Size = New System.Drawing.Size(100, 20)
            Me.dtpYYYYMM.TabIndex = 0
            Me.dtpYYYYMM.Tag = "format(&&&&-&&);"
            Me.dtpYYYYMM.TextAlign = 0
            Me.dtpYYYYMM.TextValue = ""
            Me.dtpYYYYMM.ToolTipText = ""
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(35, 22)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(64, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 5
            Me.lblCodeDivisionHangulName.Text = "기준 년월"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(3, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 66)
            Me.picCriteria_1.TabIndex = 1697
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
            Me.grd_1.Location = New System.Drawing.Point(3, 76)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(804, 566)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'popChargeEmpNum_R
            '
            Me.popChargeEmpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum_R.BorderStyle = 2
            Me.popChargeEmpNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum_R.CaptionName = "영업사원 명"
            Me.popChargeEmpNum_R.CodeText = ""
            Me.popChargeEmpNum_R.CodeWidth = 50
            Me.popChargeEmpNum_R.Enabled = False
            Me.popChargeEmpNum_R.Location = New System.Drawing.Point(105, 43)
            Me.popChargeEmpNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popChargeEmpNum_R.MaxLength = 6
            Me.popChargeEmpNum_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum_R.Name = "popChargeEmpNum_R"
            Me.popChargeEmpNum_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum_R.NameText = ""
            Me.popChargeEmpNum_R.ReadOnlys = False
            Me.popChargeEmpNum_R.SelectedText = ""
            Me.popChargeEmpNum_R.SelectionLength = 0
            Me.popChargeEmpNum_R.SelectionStart = 0
            Me.popChargeEmpNum_R.Size = New System.Drawing.Size(226, 20)
            Me.popChargeEmpNum_R.TabIndex = 2
            Me.popChargeEmpNum_R.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum_R.TextAlign = 0
            Me.popChargeEmpNum_R.TextValue = ""
            Me.popChargeEmpNum_R.ToolTipText = ""
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label20.Location = New System.Drawing.Point(25, 43)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(74, 20)
            Me.Label20.TabIndex = 7
            Me.Label20.Text = "영업담당자"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNI312
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popChargeEmpNum_R)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.popBranchCd_R)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpYYYYMM)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNI312"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents popBranchCd_R As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpYYYYMM As ubiLease.CommonControls.dtp
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents popChargeEmpNum_R As ubiLease.CommonControls.pop
        Friend WithEvents Label20 As System.Windows.Forms.Label


    End Class

End Namespace
