Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PND301
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PND301))
            Me.PopCompanyCd = New ubiLease.CommonControls.pop
            Me.Label22 = New System.Windows.Forms.Label
            Me.Label20 = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.txtMtOrders = New ubiLease.CommonControls.txt
            Me.Label8 = New System.Windows.Forms.Label
            Me.TxtPromotionNm = New ubiLease.CommonControls.txt
            Me.grd_1 = New ubiLease.GridControl.grd
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'PopCompanyCd
            '
            Me.PopCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.PopCompanyCd.BorderStyle = 2
            Me.PopCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopCompanyCd.CaptionName = "확장처 명"
            Me.PopCompanyCd.CodeText = ""
            Me.PopCompanyCd.CodeWidth = 90
            Me.PopCompanyCd.Location = New System.Drawing.Point(481, 25)
            Me.PopCompanyCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.PopCompanyCd.MaxLength = 13
            Me.PopCompanyCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.PopCompanyCd.Name = "PopCompanyCd"
            Me.PopCompanyCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.PopCompanyCd.NameText = ""
            Me.PopCompanyCd.ReadOnlys = False
            Me.PopCompanyCd.SelectedText = ""
            Me.PopCompanyCd.SelectionLength = 0
            Me.PopCompanyCd.SelectionStart = 0
            Me.PopCompanyCd.Size = New System.Drawing.Size(289, 20)
            Me.PopCompanyCd.TabIndex = 1219
            Me.PopCompanyCd.Tag = "code(확장처 명);"
            Me.PopCompanyCd.TextAlign = 0
            Me.PopCompanyCd.TextValue = ""
            Me.PopCompanyCd.ToolTipText = ""
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label22.Location = New System.Drawing.Point(396, 25)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(67, 20)
            Me.Label22.TabIndex = 1218
            Me.Label22.Text = "투입확장처"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label20.Location = New System.Drawing.Point(25, 51)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(70, 20)
            Me.Label20.TabIndex = 1214
            Me.Label20.Text = "프로모션명"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(805, 83)
            Me.picCriteria.TabIndex = 1207
            Me.picCriteria.TabStop = False
            '
            'txtMtOrders
            '
            Me.txtMtOrders.BackColor = System.Drawing.SystemColors.Window
            Me.txtMtOrders.BorderColor = System.Drawing.Color.Empty
            Me.txtMtOrders.BorderStyle = 2
            Me.txtMtOrders.CaptionName = Nothing
            Me.txtMtOrders.Location = New System.Drawing.Point(100, 25)
            Me.txtMtOrders.MaxLength = 32767
            Me.txtMtOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtMtOrders.Multiline = False
            Me.txtMtOrders.Name = "txtMtOrders"
            Me.txtMtOrders.ReadOnlys = False
            Me.txtMtOrders.SelectedText = ""
            Me.txtMtOrders.SelectionLength = 0
            Me.txtMtOrders.SelectionStart = 0
            Me.txtMtOrders.Size = New System.Drawing.Size(89, 20)
            Me.txtMtOrders.TabIndex = 1282
            Me.txtMtOrders.Tag = Nothing
            Me.txtMtOrders.TextAlign = 0
            Me.txtMtOrders.TextValue = ""
            Me.txtMtOrders.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(25, 25)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(70, 20)
            Me.Label8.TabIndex = 1281
            Me.Label8.Text = "회의차수"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtPromotionNm
            '
            Me.TxtPromotionNm.BackColor = System.Drawing.SystemColors.Window
            Me.TxtPromotionNm.BorderColor = System.Drawing.Color.Empty
            Me.TxtPromotionNm.BorderStyle = 2
            Me.TxtPromotionNm.CaptionName = Nothing
            Me.TxtPromotionNm.Location = New System.Drawing.Point(100, 51)
            Me.TxtPromotionNm.MaxLength = 32767
            Me.TxtPromotionNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.TxtPromotionNm.Multiline = False
            Me.TxtPromotionNm.Name = "TxtPromotionNm"
            Me.TxtPromotionNm.ReadOnlys = False
            Me.TxtPromotionNm.SelectedText = ""
            Me.TxtPromotionNm.SelectionLength = 0
            Me.TxtPromotionNm.SelectionStart = 0
            Me.TxtPromotionNm.Size = New System.Drawing.Size(273, 20)
            Me.TxtPromotionNm.TabIndex = 1283
            Me.TxtPromotionNm.Tag = Nothing
            Me.TxtPromotionNm.TextAlign = 0
            Me.TxtPromotionNm.TextValue = ""
            Me.TxtPromotionNm.ToolTipText = ""
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
            Me.grd_1.Location = New System.Drawing.Point(3, 92)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 525)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1278
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'PND301
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.TxtPromotionNm)
            Me.Controls.Add(Me.txtMtOrders)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.PopCompanyCd)
            Me.Controls.Add(Me.Label22)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PND301"
            Me.Size = New System.Drawing.Size(811, 628)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PopCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents txtMtOrders As ubiLease.CommonControls.txt
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents TxtPromotionNm As ubiLease.CommonControls.txt


    End Class

End Namespace
