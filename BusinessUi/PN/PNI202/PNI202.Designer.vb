Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI202
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI202))
            Me.btnCreateSale = New ubiLease.CommonControls.btn
            Me.dtpCollectYYYYMM = New ubiLease.CommonControls.dtp
            Me.lblCollect = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.dtpColEndDt = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCreateSale
            '
            Me.btnCreateSale.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCreateSale.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreateSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCreateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCreateSale.Location = New System.Drawing.Point(676, 16)
            Me.btnCreateSale.Name = "btnCreateSale"
            Me.btnCreateSale.Size = New System.Drawing.Size(109, 26)
            Me.btnCreateSale.TabIndex = 3
            Me.btnCreateSale.Text = "청구 생성"
            Me.btnCreateSale.UseVisualStyleBackColor = True
            '
            'dtpCollectYYYYMM
            '
            Me.dtpCollectYYYYMM.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCollectYYYYMM.BorderColor = System.Drawing.Color.Empty
            Me.dtpCollectYYYYMM.BorderStyle = 2
            Me.dtpCollectYYYYMM.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCollectYYYYMM.CaptionName = "접수년"
            Me.dtpCollectYYYYMM.DateTimeFormatText = "yyyy-MM"
            Me.dtpCollectYYYYMM.Location = New System.Drawing.Point(107, 19)
            Me.dtpCollectYYYYMM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCollectYYYYMM.MaxLength = 0
            Me.dtpCollectYYYYMM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCollectYYYYMM.Name = "dtpCollectYYYYMM"
            Me.dtpCollectYYYYMM.ReadOnlys = False
            Me.dtpCollectYYYYMM.SelectedText = ""
            Me.dtpCollectYYYYMM.SelectionLength = 0
            Me.dtpCollectYYYYMM.SelectionStart = 0
            Me.dtpCollectYYYYMM.Size = New System.Drawing.Size(96, 20)
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
            Me.lblCollect.Location = New System.Drawing.Point(36, 22)
            Me.lblCollect.Name = "lblCollect"
            Me.lblCollect.Size = New System.Drawing.Size(65, 15)
            Me.lblCollect.TabIndex = 4
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
            Me.grd_1.Location = New System.Drawing.Point(5, 57)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 585)
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
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(801, 49)
            Me.picCriteria_1.TabIndex = 1621
            Me.picCriteria_1.TabStop = False
            '
            'dtpColEndDt
            '
            Me.dtpColEndDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpColEndDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpColEndDt.BorderStyle = 2
            Me.dtpColEndDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpColEndDt.CaptionName = "수납마감일"
            Me.dtpColEndDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpColEndDt.Location = New System.Drawing.Point(313, 19)
            Me.dtpColEndDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpColEndDt.MaxLength = 0
            Me.dtpColEndDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpColEndDt.Name = "dtpColEndDt"
            Me.dtpColEndDt.ReadOnlys = False
            Me.dtpColEndDt.SelectedText = ""
            Me.dtpColEndDt.SelectionLength = 0
            Me.dtpColEndDt.SelectionStart = 0
            Me.dtpColEndDt.Size = New System.Drawing.Size(106, 20)
            Me.dtpColEndDt.TabIndex = 1
            Me.dtpColEndDt.TabStop = False
            Me.dtpColEndDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpColEndDt.TextAlign = 0
            Me.dtpColEndDt.TextValue = ""
            Me.dtpColEndDt.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(231, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(76, 15)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "수납마감일자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNI202
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpColEndDt)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnCreateSale)
            Me.Controls.Add(Me.dtpCollectYYYYMM)
            Me.Controls.Add(Me.lblCollect)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "PNI202"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCreateSale As ubiLease.CommonControls.btn
        Friend WithEvents dtpCollectYYYYMM As ubiLease.CommonControls.dtp
        Friend WithEvents lblCollect As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpColEndDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label


    End Class

End Namespace
