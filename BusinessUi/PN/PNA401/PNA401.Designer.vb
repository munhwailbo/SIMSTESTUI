Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA401
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA401))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblCompanyHangulNmr = New System.Windows.Forms.Label
            Me.txtCompanyHangulNm = New ubiLease.CommonControls.txt
            Me.popParentCompanyCd = New ubiLease.CommonControls.pop
            Me.Label12 = New System.Windows.Forms.Label
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
            Me.grd_1.Location = New System.Drawing.Point(3, 63)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 581)
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
            Me.picCriteria.Size = New System.Drawing.Size(805, 54)
            Me.picCriteria.TabIndex = 8
            Me.picCriteria.TabStop = False
            '
            'lblCompanyHangulNmr
            '
            Me.lblCompanyHangulNmr.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCompanyHangulNmr.Location = New System.Drawing.Point(24, 24)
            Me.lblCompanyHangulNmr.Name = "lblCompanyHangulNmr"
            Me.lblCompanyHangulNmr.Size = New System.Drawing.Size(78, 15)
            Me.lblCompanyHangulNmr.TabIndex = 765
            Me.lblCompanyHangulNmr.Text = "확장처 명"
            Me.lblCompanyHangulNmr.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtCompanyHangulNm
            '
            Me.txtCompanyHangulNm.BackColor = System.Drawing.Color.White
            Me.txtCompanyHangulNm.BorderColor = System.Drawing.Color.Empty
            Me.txtCompanyHangulNm.BorderStyle = 2
            Me.txtCompanyHangulNm.CaptionName = "확장처 명"
            Me.txtCompanyHangulNm.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.txtCompanyHangulNm.Location = New System.Drawing.Point(108, 19)
            Me.txtCompanyHangulNm.MaxLength = 50
            Me.txtCompanyHangulNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCompanyHangulNm.Multiline = False
            Me.txtCompanyHangulNm.Name = "txtCompanyHangulNm"
            Me.txtCompanyHangulNm.ReadOnlys = False
            Me.txtCompanyHangulNm.SelectedText = ""
            Me.txtCompanyHangulNm.SelectionLength = 0
            Me.txtCompanyHangulNm.SelectionStart = 0
            Me.txtCompanyHangulNm.Size = New System.Drawing.Size(183, 20)
            Me.txtCompanyHangulNm.TabIndex = 1092
            Me.txtCompanyHangulNm.Tag = ""
            Me.txtCompanyHangulNm.TextAlign = 0
            Me.txtCompanyHangulNm.TextValue = ""
            Me.txtCompanyHangulNm.ToolTipText = ""
            '
            'popParentCompanyCd
            '
            Me.popParentCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popParentCompanyCd.BorderStyle = 2
            Me.popParentCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popParentCompanyCd.CaptionName = "확장처 코드"
            Me.popParentCompanyCd.CodeText = ""
            Me.popParentCompanyCd.CodeWidth = 90
            Me.popParentCompanyCd.Location = New System.Drawing.Point(426, 19)
            Me.popParentCompanyCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popParentCompanyCd.MaxLength = 12
            Me.popParentCompanyCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popParentCompanyCd.Name = "popParentCompanyCd"
            Me.popParentCompanyCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popParentCompanyCd.NameText = ""
            Me.popParentCompanyCd.ReadOnlys = False
            Me.popParentCompanyCd.SelectedText = ""
            Me.popParentCompanyCd.SelectionLength = 0
            Me.popParentCompanyCd.SelectionStart = 0
            Me.popParentCompanyCd.Size = New System.Drawing.Size(304, 20)
            Me.popParentCompanyCd.TabIndex = 1537
            Me.popParentCompanyCd.Tag = "code(확장처 명);"
            Me.popParentCompanyCd.TextAlign = 0
            Me.popParentCompanyCd.TextValue = ""
            Me.popParentCompanyCd.ToolTipText = ""
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label12.Location = New System.Drawing.Point(337, 22)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(84, 15)
            Me.Label12.TabIndex = 1538
            Me.Label12.Text = "상위확장처"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNA401
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popParentCompanyCd)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.txtCompanyHangulNm)
            Me.Controls.Add(Me.lblCompanyHangulNmr)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNA401"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblCompanyHangulNmr As System.Windows.Forms.Label
        Friend WithEvents txtCompanyHangulNm As ubiLease.CommonControls.txt
        Friend WithEvents popParentCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents Label12 As System.Windows.Forms.Label

    End Class

End Namespace
