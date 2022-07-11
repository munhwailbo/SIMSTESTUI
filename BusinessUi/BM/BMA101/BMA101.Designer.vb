Namespace ubiLease.UI.BusinessUi.BM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class BMA101
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMA101))
            Me.lblCodeDivision = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.popBranchChiefCd = New ubiLease.CommonControls.pop
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblCodeDivision
            '
            Me.lblCodeDivision.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivision.Location = New System.Drawing.Point(31, 21)
            Me.lblCodeDivision.Name = "lblCodeDivision"
            Me.lblCodeDivision.Size = New System.Drawing.Size(43, 17)
            Me.lblCodeDivision.TabIndex = 1
            Me.lblCodeDivision.Text = "지국장"
            Me.lblCodeDivision.TextAlign = System.Drawing.ContentAlignment.TopRight
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
            Me.grd_1.Location = New System.Drawing.Point(5, 57)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 582)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'popBranchChiefCd
            '
            Me.popBranchChiefCd.BorderColor = System.Drawing.Color.Empty
            Me.popBranchChiefCd.BorderStyle = 2
            Me.popBranchChiefCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchChiefCd.CaptionName = "지국장 코드"
            Me.popBranchChiefCd.CodeText = ""
            Me.popBranchChiefCd.CodeWidth = 50
            Me.popBranchChiefCd.Location = New System.Drawing.Point(80, 18)
            Me.popBranchChiefCd.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popBranchChiefCd.MaxLength = 10
            Me.popBranchChiefCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchChiefCd.Name = "popBranchChiefCd"
            Me.popBranchChiefCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchChiefCd.NameText = ""
            Me.popBranchChiefCd.ReadOnlys = False
            Me.popBranchChiefCd.SelectedText = ""
            Me.popBranchChiefCd.SelectionLength = 0
            Me.popBranchChiefCd.SelectionStart = 0
            Me.popBranchChiefCd.Size = New System.Drawing.Size(182, 20)
            Me.popBranchChiefCd.TabIndex = 1674
            Me.popBranchChiefCd.Tag = "code(지국장 명);"
            Me.popBranchChiefCd.TextAlign = 0
            Me.popBranchChiefCd.TextValue = ""
            Me.popBranchChiefCd.ToolTipText = ""
            '
            'BMA101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popBranchChiefCd)
            Me.Controls.Add(Me.lblCodeDivision)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "BMA101"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivision, 0)
            Me.Controls.SetChildIndex(Me.popBranchChiefCd, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents lblCodeDivision As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents popBranchChiefCd As ubiLease.CommonControls.pop

    End Class

End Namespace
