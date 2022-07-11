Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE305
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE305))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.dtpToExpand = New ubiLease.CommonControls.dtp
            Me.lblExpandDt = New System.Windows.Forms.Label
            Me.dtpFromExpand = New ubiLease.CommonControls.dtp
            Me.lblBranchNm = New System.Windows.Forms.Label
            Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.Location = New System.Drawing.Point(3, 71)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 573)
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
            Me.picCriteria.Size = New System.Drawing.Size(805, 64)
            Me.picCriteria.TabIndex = 911
            Me.picCriteria.TabStop = False
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(193, 17)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(18, 20)
            Me.Label5.TabIndex = 923
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
            Me.dtpToExpand.Location = New System.Drawing.Point(213, 17)
            Me.dtpToExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToExpand.MaxLength = 0
            Me.dtpToExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToExpand.Name = "dtpToExpand"
            Me.dtpToExpand.ReadOnlys = False
            Me.dtpToExpand.SelectedText = ""
            Me.dtpToExpand.SelectionLength = 0
            Me.dtpToExpand.SelectionStart = 0
            Me.dtpToExpand.Size = New System.Drawing.Size(96, 20)
            Me.dtpToExpand.TabIndex = 1
            Me.dtpToExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpToExpand.TextAlign = 0
            Me.dtpToExpand.TextValue = ""
            Me.dtpToExpand.ToolTipText = ""
            '
            'lblExpandDt
            '
            Me.lblExpandDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblExpandDt.Location = New System.Drawing.Point(28, 20)
            Me.lblExpandDt.Name = "lblExpandDt"
            Me.lblExpandDt.Size = New System.Drawing.Size(69, 15)
            Me.lblExpandDt.TabIndex = 921
            Me.lblExpandDt.Text = "접수일자"
            Me.lblExpandDt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpFromExpand
            '
            Me.dtpFromExpand.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFromExpand.BorderColor = System.Drawing.Color.Empty
            Me.dtpFromExpand.BorderStyle = 2
            Me.dtpFromExpand.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFromExpand.CaptionName = "회계 일자"
            Me.dtpFromExpand.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFromExpand.Location = New System.Drawing.Point(100, 17)
            Me.dtpFromExpand.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromExpand.MaxLength = 0
            Me.dtpFromExpand.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromExpand.Name = "dtpFromExpand"
            Me.dtpFromExpand.ReadOnlys = False
            Me.dtpFromExpand.SelectedText = ""
            Me.dtpFromExpand.SelectionLength = 0
            Me.dtpFromExpand.SelectionStart = 0
            Me.dtpFromExpand.Size = New System.Drawing.Size(96, 20)
            Me.dtpFromExpand.TabIndex = 0
            Me.dtpFromExpand.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpFromExpand.TextAlign = 0
            Me.dtpFromExpand.TextValue = ""
            Me.dtpFromExpand.ToolTipText = ""
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(28, 40)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(69, 20)
            Me.lblBranchNm.TabIndex = 1102
            Me.lblBranchNm.Text = "확장처"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dlgOpenFile
            '
            Me.dlgOpenFile.FileName = "OpenFileDialog1"
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "확장처 코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 90
            Me.popCompanyCd.Location = New System.Drawing.Point(100, 40)
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
            Me.popCompanyCd.Size = New System.Drawing.Size(262, 20)
            Me.popCompanyCd.TabIndex = 2
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'PNE305
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpToExpand)
            Me.Controls.Add(Me.dtpFromExpand)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.lblExpandDt)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNE305"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblExpandDt, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.lblBranchNm, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd, 0)
            Me.Controls.SetChildIndex(Me.dtpFromExpand, 0)
            Me.Controls.SetChildIndex(Me.dtpToExpand, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpToExpand As ubiLease.CommonControls.dtp
        Friend WithEvents lblExpandDt As System.Windows.Forms.Label
        Friend WithEvents dtpFromExpand As ubiLease.CommonControls.dtp
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label
        Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop


    End Class

End Namespace
