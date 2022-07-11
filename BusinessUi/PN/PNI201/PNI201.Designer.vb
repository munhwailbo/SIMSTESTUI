Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI201
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI201))
            Me.dtpCollectYYYYMM = New ubiLease.CommonControls.dtp
            Me.lblCollect = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.btnCreateSale = New ubiLease.CommonControls.btn
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.lblBranchNm = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpCollectYYYYMM
            '
            Me.dtpCollectYYYYMM.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCollectYYYYMM.BorderColor = System.Drawing.Color.Empty
            Me.dtpCollectYYYYMM.BorderStyle = 2
            Me.dtpCollectYYYYMM.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCollectYYYYMM.CaptionName = "접수년"
            Me.dtpCollectYYYYMM.DateTimeFormatText = "yyyy-MM"
            Me.dtpCollectYYYYMM.Location = New System.Drawing.Point(103, 17)
            Me.dtpCollectYYYYMM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCollectYYYYMM.MaxLength = 0
            Me.dtpCollectYYYYMM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCollectYYYYMM.Name = "dtpCollectYYYYMM"
            Me.dtpCollectYYYYMM.ReadOnlys = False
            Me.dtpCollectYYYYMM.SelectedText = ""
            Me.dtpCollectYYYYMM.SelectionLength = 0
            Me.dtpCollectYYYYMM.SelectionStart = 0
            Me.dtpCollectYYYYMM.Size = New System.Drawing.Size(115, 20)
            Me.dtpCollectYYYYMM.TabIndex = 0
            Me.dtpCollectYYYYMM.TabStop = False
            Me.dtpCollectYYYYMM.Tag = "format(&&&&-&&);"
            Me.dtpCollectYYYYMM.TextAlign = 0
            Me.dtpCollectYYYYMM.TextValue = ""
            Me.dtpCollectYYYYMM.ToolTipText = ""
            '
            'lblCollect
            '
            Me.lblCollect.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCollect.Location = New System.Drawing.Point(32, 20)
            Me.lblCollect.Name = "lblCollect"
            Me.lblCollect.Size = New System.Drawing.Size(65, 15)
            Me.lblCollect.TabIndex = 3
            Me.lblCollect.Text = "청구년월"
            Me.lblCollect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.grd_1.Location = New System.Drawing.Point(6, 54)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 587)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
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
            Me.picCriteria_1.TabIndex = 1141
            Me.picCriteria_1.TabStop = False
            '
            'btnCreateSale
            '
            Me.btnCreateSale.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCreateSale.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCreateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCreateSale.Location = New System.Drawing.Point(679, 14)
            Me.btnCreateSale.Name = "btnCreateSale"
            Me.btnCreateSale.Size = New System.Drawing.Size(109, 26)
            Me.btnCreateSale.TabIndex = 2
            Me.btnCreateSale.Text = "청구 생성"
            Me.btnCreateSale.UseVisualStyleBackColor = True
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "확장처 코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 90
            Me.popCompanyCd.Location = New System.Drawing.Point(317, 17)
            Me.popCompanyCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCompanyCd.MaxLength = 32767
            Me.popCompanyCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCompanyCd.Name = "popCompanyCd"
            Me.popCompanyCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCompanyCd.NameText = ""
            Me.popCompanyCd.ReadOnlys = False
            Me.popCompanyCd.SelectedText = ""
            Me.popCompanyCd.SelectionLength = 0
            Me.popCompanyCd.SelectionStart = 0
            Me.popCompanyCd.Size = New System.Drawing.Size(295, 20)
            Me.popCompanyCd.TabIndex = 1
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(260, 17)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(53, 20)
            Me.lblBranchNm.TabIndex = 1690
            Me.lblBranchNm.Text = "확장처"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNI201
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.btnCreateSale)
            Me.Controls.Add(Me.dtpCollectYYYYMM)
            Me.Controls.Add(Me.lblCollect)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "PNI201"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dtpCollectYYYYMM As ubiLease.CommonControls.dtp
        Friend WithEvents lblCollect As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents btnCreateSale As ubiLease.CommonControls.btn
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label


    End Class

End Namespace
