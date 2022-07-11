Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE102
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE102))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.Label5 = New System.Windows.Forms.Label
            Me.dtpToExpand = New ubiLease.CommonControls.dtp
            Me.lblExpandDt = New System.Windows.Forms.Label
            Me.dtpFromExpand = New ubiLease.CommonControls.dtp
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.lblFormDivisionCode = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
            Me.grd_1.Location = New System.Drawing.Point(3, 68)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(803, 255)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 852
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
            Me.picCriteria.Size = New System.Drawing.Size(805, 45)
            Me.picCriteria.TabIndex = 851
            Me.picCriteria.TabStop = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(1, 51)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(290, 14)
            Me.Label3.TabIndex = 853
            Me.Label3.Text = "사원확장 "
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(3, 326)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(428, 14)
            Me.Label1.TabIndex = 920
            Me.Label1.Text = "사원 확장 권유자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.grd_2.Location = New System.Drawing.Point(3, 343)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(803, 301)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 931
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(218, 15)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(18, 20)
            Me.Label5.TabIndex = 935
            Me.Label5.Text = "~"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpToExpand
            '
            Me.dtpToExpand.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToExpand.BorderColor = System.Drawing.Color.Empty
            Me.dtpToExpand.BorderStyle = 2
            Me.dtpToExpand.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToExpand.CaptionName = "회계 일자"
            Me.dtpToExpand.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpToExpand.Location = New System.Drawing.Point(242, 15)
            Me.dtpToExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToExpand.MaxLength = 0
            Me.dtpToExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToExpand.Name = "dtpToExpand"
            Me.dtpToExpand.ReadOnlys = False
            Me.dtpToExpand.SelectedText = ""
            Me.dtpToExpand.SelectionLength = 0
            Me.dtpToExpand.SelectionStart = 0
            Me.dtpToExpand.Size = New System.Drawing.Size(100, 20)
            Me.dtpToExpand.TabIndex = 934
            Me.dtpToExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpToExpand.TextAlign = 0
            Me.dtpToExpand.TextValue = Nothing
            Me.dtpToExpand.ToolTipText = ""
            '
            'lblExpandDt
            '
            Me.lblExpandDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblExpandDt.Location = New System.Drawing.Point(23, 18)
            Me.lblExpandDt.Name = "lblExpandDt"
            Me.lblExpandDt.Size = New System.Drawing.Size(87, 15)
            Me.lblExpandDt.TabIndex = 933
            Me.lblExpandDt.Text = "확장일자"
            Me.lblExpandDt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dtpFromExpand
            '
            Me.dtpFromExpand.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFromExpand.BorderColor = System.Drawing.Color.Empty
            Me.dtpFromExpand.BorderStyle = 2
            Me.dtpFromExpand.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFromExpand.CaptionName = "회계 일자"
            Me.dtpFromExpand.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFromExpand.Location = New System.Drawing.Point(116, 15)
            Me.dtpFromExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromExpand.MaxLength = 0
            Me.dtpFromExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromExpand.Name = "dtpFromExpand"
            Me.dtpFromExpand.ReadOnlys = False
            Me.dtpFromExpand.SelectedText = ""
            Me.dtpFromExpand.SelectionLength = 0
            Me.dtpFromExpand.SelectionStart = 0
            Me.dtpFromExpand.Size = New System.Drawing.Size(100, 20)
            Me.dtpFromExpand.TabIndex = 932
            Me.dtpFromExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpFromExpand.TextAlign = 0
            Me.dtpFromExpand.TextValue = Nothing
            Me.dtpFromExpand.ToolTipText = ""
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "확장처 코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 90
            Me.popCompanyCd.Location = New System.Drawing.Point(415, 15)
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
            Me.popCompanyCd.Size = New System.Drawing.Size(290, 20)
            Me.popCompanyCd.TabIndex = 1207
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'lblFormDivisionCode
            '
            Me.lblFormDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFormDivisionCode.Location = New System.Drawing.Point(344, 18)
            Me.lblFormDivisionCode.Name = "lblFormDivisionCode"
            Me.lblFormDivisionCode.Size = New System.Drawing.Size(65, 15)
            Me.lblFormDivisionCode.TabIndex = 1208
            Me.lblFormDivisionCode.Text = "확장처"
            Me.lblFormDivisionCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNE102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.lblFormDivisionCode)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.dtpToExpand)
            Me.Controls.Add(Me.lblExpandDt)
            Me.Controls.Add(Me.dtpFromExpand)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNE102"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpToExpand As ubiLease.CommonControls.dtp
        Friend WithEvents lblExpandDt As System.Windows.Forms.Label
        Friend WithEvents dtpFromExpand As ubiLease.CommonControls.dtp
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents lblFormDivisionCode As System.Windows.Forms.Label


    End Class

End Namespace
