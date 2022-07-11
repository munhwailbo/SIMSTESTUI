Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA403
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA403))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.lblCompanyHangulNmr = New System.Windows.Forms.Label
            Me.txtCouponCorpNm = New ubiLease.CommonControls.txt
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
            Me.lblCompanyHangulNmr.Text = "소속사 명"
            Me.lblCompanyHangulNmr.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtCouponCorpNm
            '
            Me.txtCouponCorpNm.BackColor = System.Drawing.Color.White
            Me.txtCouponCorpNm.BorderColor = System.Drawing.Color.Empty
            Me.txtCouponCorpNm.BorderStyle = 2
            Me.txtCouponCorpNm.CaptionName = "소속사 명"
            Me.txtCouponCorpNm.ForeColor = System.Drawing.Color.Black
            Me.txtCouponCorpNm.Location = New System.Drawing.Point(108, 19)
            Me.txtCouponCorpNm.MaxLength = 50
            Me.txtCouponCorpNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCouponCorpNm.Multiline = False
            Me.txtCouponCorpNm.Name = "txtCouponCorpNm"
            Me.txtCouponCorpNm.ReadOnlys = False
            Me.txtCouponCorpNm.SelectedText = ""
            Me.txtCouponCorpNm.SelectionLength = 0
            Me.txtCouponCorpNm.SelectionStart = 0
            Me.txtCouponCorpNm.Size = New System.Drawing.Size(272, 20)
            Me.txtCouponCorpNm.TabIndex = 1092
            Me.txtCouponCorpNm.Tag = ""
            Me.txtCouponCorpNm.TextAlign = 0
            Me.txtCouponCorpNm.TextValue = ""
            Me.txtCouponCorpNm.ToolTipText = ""
            '
            'PNA403
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtCouponCorpNm)
            Me.Controls.Add(Me.lblCompanyHangulNmr)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNA403"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents lblCompanyHangulNmr As System.Windows.Forms.Label
        Friend WithEvents txtCouponCorpNm As ubiLease.CommonControls.txt

    End Class

End Namespace
