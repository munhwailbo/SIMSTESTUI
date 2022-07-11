Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMBA01
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMBA01))
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.txtCodeDivisionHangulName = New ubiLease.CommonControls.txt
            Me.lblCodeDivision = New System.Windows.Forms.Label
            Me.txtCodeDivision = New ubiLease.CommonControls.txt
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New ubiLease.CommonControls.picpanel
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.picCriteria_1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(25, 18)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(111, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 0
            Me.lblCodeDivisionHangulName.Text = "코드 구분 한글 명"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtCodeDivisionHangulName
            '
            Me.txtCodeDivisionHangulName.BackColor = System.Drawing.SystemColors.Window
            Me.txtCodeDivisionHangulName.BorderColor = System.Drawing.Color.Empty
            Me.txtCodeDivisionHangulName.BorderStyle = 2
            Me.txtCodeDivisionHangulName.CaptionName = "코드 구분 한글 명"
            Me.txtCodeDivisionHangulName.Location = New System.Drawing.Point(142, 13)
            Me.txtCodeDivisionHangulName.MaxLength = 30
            Me.txtCodeDivisionHangulName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCodeDivisionHangulName.Multiline = False
            Me.txtCodeDivisionHangulName.Name = "txtCodeDivisionHangulName"
            Me.txtCodeDivisionHangulName.ReadOnlys = False
            Me.txtCodeDivisionHangulName.SelectedText = ""
            Me.txtCodeDivisionHangulName.SelectionLength = 0
            Me.txtCodeDivisionHangulName.SelectionStart = 0
            Me.txtCodeDivisionHangulName.Size = New System.Drawing.Size(239, 20)
            Me.txtCodeDivisionHangulName.TabIndex = 0
            Me.txtCodeDivisionHangulName.Tag = ""
            Me.txtCodeDivisionHangulName.TextAlign = 0
            Me.txtCodeDivisionHangulName.TextValue = ""
            Me.txtCodeDivisionHangulName.ToolTipText = ""
            '
            'lblCodeDivision
            '
            Me.lblCodeDivision.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivision.Location = New System.Drawing.Point(430, 18)
            Me.lblCodeDivision.Name = "lblCodeDivision"
            Me.lblCodeDivision.Size = New System.Drawing.Size(61, 15)
            Me.lblCodeDivision.TabIndex = 1
            Me.lblCodeDivision.Text = "코드 구분"
            Me.lblCodeDivision.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtCodeDivision
            '
            Me.txtCodeDivision.BackColor = System.Drawing.SystemColors.Window
            Me.txtCodeDivision.BorderColor = System.Drawing.Color.Empty
            Me.txtCodeDivision.BorderStyle = 2
            Me.txtCodeDivision.CaptionName = "코드 구분"
            Me.txtCodeDivision.Location = New System.Drawing.Point(496, 13)
            Me.txtCodeDivision.MaxLength = 3
            Me.txtCodeDivision.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCodeDivision.Multiline = False
            Me.txtCodeDivision.Name = "txtCodeDivision"
            Me.txtCodeDivision.ReadOnlys = False
            Me.txtCodeDivision.SelectedText = ""
            Me.txtCodeDivision.SelectionLength = 0
            Me.txtCodeDivision.SelectionStart = 0
            Me.txtCodeDivision.Size = New System.Drawing.Size(86, 20)
            Me.txtCodeDivision.TabIndex = 1
            Me.txtCodeDivision.Tag = ""
            Me.txtCodeDivision.TextAlign = 0
            Me.txtCodeDivision.TextValue = ""
            Me.txtCodeDivision.ToolTipText = ""
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
            Me.grd_1.Location = New System.Drawing.Point(6, 56)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 308)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
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
            Me.grd_2.Location = New System.Drawing.Point(6, 370)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(799, 269)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 3
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.picCriteria_1.Controls.Add(Me.txtCodeDivision)
            Me.picCriteria_1.Controls.Add(Me.lblCodeDivision)
            Me.picCriteria_1.Controls.Add(Me.txtCodeDivisionHangulName)
            Me.picCriteria_1.Location = New System.Drawing.Point(6, 7)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 43)
            Me.picCriteria_1.TabIndex = 4
            '
            'SMBA01
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMBA01"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.picCriteria_1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents txtCodeDivisionHangulName As ubiLease.CommonControls.txt
        Friend WithEvents lblCodeDivision As System.Windows.Forms.Label
        Friend WithEvents txtCodeDivision As ubiLease.CommonControls.txt
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As ubiLease.CommonControls.picpanel

    End Class

End Namespace
