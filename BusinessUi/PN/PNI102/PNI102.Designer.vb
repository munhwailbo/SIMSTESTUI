Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI102
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI102))
            Me.Label19 = New System.Windows.Forms.Label
            Me.dtpCalYearMonths = New ubiLease.CommonControls.dtp
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.picIo_1 = New System.Windows.Forms.PictureBox
            Me.popBranchNum = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtOrders = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            Me.dtpCalYearMonths_2 = New ubiLease.CommonControls.dtp
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label19.Location = New System.Drawing.Point(41, 23)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(55, 15)
            Me.Label19.TabIndex = 997
            Me.Label19.Text = "정산년월"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpCalYearMonths
            '
            Me.dtpCalYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCalYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpCalYearMonths.BorderStyle = 2
            Me.dtpCalYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCalYearMonths.CaptionName = Nothing
            Me.dtpCalYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpCalYearMonths.Location = New System.Drawing.Point(102, 20)
            Me.dtpCalYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCalYearMonths.MaxLength = 0
            Me.dtpCalYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCalYearMonths.Name = "dtpCalYearMonths"
            Me.dtpCalYearMonths.ReadOnlys = False
            Me.dtpCalYearMonths.SelectedText = ""
            Me.dtpCalYearMonths.SelectionLength = 0
            Me.dtpCalYearMonths.SelectionStart = 0
            Me.dtpCalYearMonths.Size = New System.Drawing.Size(100, 20)
            Me.dtpCalYearMonths.TabIndex = 996
            Me.dtpCalYearMonths.Tag = "need;format(&&&&-&&);"
            Me.dtpCalYearMonths.TextAlign = 0
            Me.dtpCalYearMonths.TextValue = Nothing
            Me.dtpCalYearMonths.ToolTipText = ""
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(799, 50)
            Me.picCriteria.TabIndex = 994
            Me.picCriteria.TabStop = False
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
            Me.grd_1.Location = New System.Drawing.Point(5, 61)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 274)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1037
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
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
            Me.grd_2.Location = New System.Drawing.Point(5, 397)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(799, 242)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 1038
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(208, 356)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 20)
            Me.Label1.TabIndex = 1130
            Me.Label1.Text = "지국번호"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picIo_1
            '
            Me.picIo_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_1.Location = New System.Drawing.Point(5, 341)
            Me.picIo_1.Name = "picIo_1"
            Me.picIo_1.Size = New System.Drawing.Size(799, 50)
            Me.picIo_1.TabIndex = 1206
            Me.picIo_1.TabStop = False
            '
            'popBranchNum
            '
            Me.popBranchNum.BorderColor = System.Drawing.Color.Empty
            Me.popBranchNum.BorderStyle = 2
            Me.popBranchNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchNum.CaptionName = "지국코드"
            Me.popBranchNum.CodeText = ""
            Me.popBranchNum.CodeWidth = 90
            Me.popBranchNum.Location = New System.Drawing.Point(272, 356)
            Me.popBranchNum.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popBranchNum.MaxLength = 9
            Me.popBranchNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchNum.Name = "popBranchNum"
            Me.popBranchNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchNum.NameText = ""
            Me.popBranchNum.ReadOnlys = False
            Me.popBranchNum.SelectedText = ""
            Me.popBranchNum.SelectionLength = 0
            Me.popBranchNum.SelectionStart = 0
            Me.popBranchNum.Size = New System.Drawing.Size(250, 20)
            Me.popBranchNum.TabIndex = 1207
            Me.popBranchNum.Tag = "need;code(지국코드);"
            Me.popBranchNum.TextAlign = 0
            Me.popBranchNum.TextValue = ""
            Me.popBranchNum.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(528, 356)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(39, 20)
            Me.Label2.TabIndex = 1208
            Me.Label2.Text = "순번"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtOrders
            '
            Me.txtOrders.BackColor = System.Drawing.SystemColors.Window
            Me.txtOrders.BorderColor = System.Drawing.Color.Empty
            Me.txtOrders.BorderStyle = 2
            Me.txtOrders.CaptionName = "순번"
            Me.txtOrders.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtOrders.Location = New System.Drawing.Point(573, 356)
            Me.txtOrders.MaxLength = 30
            Me.txtOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtOrders.Multiline = False
            Me.txtOrders.Name = "txtOrders"
            Me.txtOrders.ReadOnlys = False
            Me.txtOrders.SelectedText = ""
            Me.txtOrders.SelectionLength = 0
            Me.txtOrders.SelectionStart = 0
            Me.txtOrders.Size = New System.Drawing.Size(74, 20)
            Me.txtOrders.TabIndex = 1209
            Me.txtOrders.Tag = "need;"
            Me.txtOrders.TextAlign = 0
            Me.txtOrders.TextValue = ""
            Me.txtOrders.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(41, 359)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 15)
            Me.Label3.TabIndex = 1211
            Me.Label3.Text = "정산년월"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpCalYearMonths_2
            '
            Me.dtpCalYearMonths_2.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCalYearMonths_2.BorderColor = System.Drawing.Color.Empty
            Me.dtpCalYearMonths_2.BorderStyle = 2
            Me.dtpCalYearMonths_2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCalYearMonths_2.CaptionName = Nothing
            Me.dtpCalYearMonths_2.DateTimeFormatText = "yyyy-MM"
            Me.dtpCalYearMonths_2.Location = New System.Drawing.Point(102, 356)
            Me.dtpCalYearMonths_2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCalYearMonths_2.MaxLength = 0
            Me.dtpCalYearMonths_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCalYearMonths_2.Name = "dtpCalYearMonths_2"
            Me.dtpCalYearMonths_2.ReadOnlys = False
            Me.dtpCalYearMonths_2.SelectedText = ""
            Me.dtpCalYearMonths_2.SelectionLength = 0
            Me.dtpCalYearMonths_2.SelectionStart = 0
            Me.dtpCalYearMonths_2.Size = New System.Drawing.Size(100, 20)
            Me.dtpCalYearMonths_2.TabIndex = 1210
            Me.dtpCalYearMonths_2.Tag = "need;format(&&&&-&&);"
            Me.dtpCalYearMonths_2.TextAlign = 0
            Me.dtpCalYearMonths_2.TextValue = Nothing
            Me.dtpCalYearMonths_2.ToolTipText = ""
            '
            'PNI102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpCalYearMonths_2)
            Me.Controls.Add(Me.txtOrders)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.popBranchNum)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Label19)
            Me.Controls.Add(Me.dtpCalYearMonths)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.picIo_1)
            Me.Name = "PNI102"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents dtpCalYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents picIo_1 As System.Windows.Forms.PictureBox
        Friend WithEvents popBranchNum As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtOrders As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpCalYearMonths_2 As ubiLease.CommonControls.dtp


    End Class

End Namespace
