Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNG203
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNG203))
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpBaseDt_R1 = New ubiLease.CommonControls.dtp
            Me.popBranchNum = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(25, 25)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(111, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 0
            Me.lblCodeDivisionHangulName.Text = "기준 년도"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 46)
            Me.picCriteria_1.TabIndex = 2
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
            Me.grd_1.Location = New System.Drawing.Point(5, 273)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 370)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpBaseDt_R1
            '
            Me.dtpBaseDt_R1.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseDt_R1.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseDt_R1.BorderStyle = 2
            Me.dtpBaseDt_R1.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseDt_R1.CaptionName = "대체 일자"
            Me.dtpBaseDt_R1.DateTimeFormatText = "yyyy"
            Me.dtpBaseDt_R1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseDt_R1.Location = New System.Drawing.Point(152, 20)
            Me.dtpBaseDt_R1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseDt_R1.MaxLength = 0
            Me.dtpBaseDt_R1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseDt_R1.Name = "dtpBaseDt_R1"
            Me.dtpBaseDt_R1.ReadOnlys = False
            Me.dtpBaseDt_R1.SelectedText = ""
            Me.dtpBaseDt_R1.SelectionLength = 0
            Me.dtpBaseDt_R1.SelectionStart = 0
            Me.dtpBaseDt_R1.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseDt_R1.TabIndex = 16
            Me.dtpBaseDt_R1.Tag = "format(####);"
            Me.dtpBaseDt_R1.TextAlign = 0
            Me.dtpBaseDt_R1.TextValue = ""
            Me.dtpBaseDt_R1.ToolTipText = ""
            '
            'popBranchNum
            '
            Me.popBranchNum.BorderColor = System.Drawing.Color.Empty
            Me.popBranchNum.BorderStyle = 2
            Me.popBranchNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchNum.CaptionName = "지국 명"
            Me.popBranchNum.CodeText = ""
            Me.popBranchNum.CodeWidth = 60
            Me.popBranchNum.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.popBranchNum.Location = New System.Drawing.Point(419, 20)
            Me.popBranchNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchNum.MaxLength = 6
            Me.popBranchNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchNum.Name = "popBranchNum"
            Me.popBranchNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchNum.NameText = ""
            Me.popBranchNum.ReadOnlys = False
            Me.popBranchNum.SelectedText = ""
            Me.popBranchNum.SelectionLength = 0
            Me.popBranchNum.SelectionStart = 0
            Me.popBranchNum.Size = New System.Drawing.Size(231, 20)
            Me.popBranchNum.TabIndex = 31
            Me.popBranchNum.Tag = "code(지국 명);"
            Me.popBranchNum.TextAlign = 0
            Me.popBranchNum.TextValue = ""
            Me.popBranchNum.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(292, 22)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(111, 15)
            Me.Label2.TabIndex = 30
            Me.Label2.Text = "지국 명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PNG203
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popBranchNum)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpBaseDt_R1)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNG203"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents dtpBaseDt_R1 As ubiLease.CommonControls.dtp
        Friend WithEvents popBranchNum As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label

    End Class

End Namespace
