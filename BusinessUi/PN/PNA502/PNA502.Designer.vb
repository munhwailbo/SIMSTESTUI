Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA502
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA502))
            Me.Label4 = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.PopZipCd = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.PopBranchCd = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.cboChargeTypeCd = New ubiLease.CommonControls.cbo
            Me.popChargeEmpNum = New ubiLease.CommonControls.pop
            Me.lblRepresentativeName = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.BackColor = System.Drawing.SystemColors.Control
            Me.Label4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(3, 70)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(805, 14)
            Me.Label4.TabIndex = 847
            Me.Label4.Text = "우편번호-지국"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.grd_1.Location = New System.Drawing.Point(3, 87)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 557)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 846
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'PopZipCd
            '
            Me.PopZipCd.BorderColor = System.Drawing.Color.Empty
            Me.PopZipCd.BorderStyle = 2
            Me.PopZipCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopZipCd.CaptionName = "우편번호"
            Me.PopZipCd.CodeText = ""
            Me.PopZipCd.CodeWidth = 50
            Me.PopZipCd.Cursor = System.Windows.Forms.Cursors.Default
            Me.PopZipCd.Location = New System.Drawing.Point(79, 12)
            Me.PopZipCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.PopZipCd.MaxLength = 6
            Me.PopZipCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.PopZipCd.Name = "PopZipCd"
            Me.PopZipCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.PopZipCd.NameText = ""
            Me.PopZipCd.ReadOnlys = False
            Me.PopZipCd.SelectedText = ""
            Me.PopZipCd.SelectionLength = 0
            Me.PopZipCd.SelectionStart = 0
            Me.PopZipCd.Size = New System.Drawing.Size(201, 20)
            Me.PopZipCd.TabIndex = 845
            Me.PopZipCd.Tag = "code(우편번호);"
            Me.PopZipCd.TextAlign = 0
            Me.PopZipCd.TextValue = ""
            Me.PopZipCd.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(16, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(57, 15)
            Me.Label2.TabIndex = 844
            Me.Label2.Text = "우편번호"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria
            '
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(805, 64)
            Me.picCriteria.TabIndex = 843
            Me.picCriteria.TabStop = False
            '
            'PopBranchCd
            '
            Me.PopBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.PopBranchCd.BorderStyle = 2
            Me.PopBranchCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopBranchCd.CaptionName = "지국코드"
            Me.PopBranchCd.CodeText = ""
            Me.PopBranchCd.CodeWidth = 50
            Me.PopBranchCd.Location = New System.Drawing.Point(343, 12)
            Me.PopBranchCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.PopBranchCd.MaxLength = 6
            Me.PopBranchCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.PopBranchCd.Name = "PopBranchCd"
            Me.PopBranchCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.PopBranchCd.NameText = ""
            Me.PopBranchCd.ReadOnlys = False
            Me.PopBranchCd.SelectedText = ""
            Me.PopBranchCd.SelectionLength = 0
            Me.PopBranchCd.SelectionStart = 0
            Me.PopBranchCd.Size = New System.Drawing.Size(183, 20)
            Me.PopBranchCd.TabIndex = 855
            Me.PopBranchCd.Tag = "code(사원 명);"
            Me.PopBranchCd.TextAlign = 0
            Me.PopBranchCd.TextValue = ""
            Me.PopBranchCd.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(290, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 15)
            Me.Label1.TabIndex = 854
            Me.Label1.Text = "지국"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.Label5.Location = New System.Drawing.Point(274, 41)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(63, 17)
            Me.Label5.TabIndex = 859
            Me.Label5.Text = "담당유형"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboChargeTypeCd
            '
            Me.cboChargeTypeCd.CaptionName = "담당 유형"
            Me.cboChargeTypeCd.ListCount = 0
            Me.cboChargeTypeCd.Location = New System.Drawing.Point(343, 37)
            Me.cboChargeTypeCd.Name = "cboChargeTypeCd"
            Me.cboChargeTypeCd.ReadOnlys = False
            Me.cboChargeTypeCd.Size = New System.Drawing.Size(100, 20)
            Me.cboChargeTypeCd.TabIndex = 858
            Me.cboChargeTypeCd.Tag = "code(담당자유형코드);"
            Me.cboChargeTypeCd.TextValue = ""
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum.BorderStyle = 2
            Me.popChargeEmpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum.CaptionName = "담당자"
            Me.popChargeEmpNum.CodeText = ""
            Me.popChargeEmpNum.CodeWidth = 50
            Me.popChargeEmpNum.Location = New System.Drawing.Point(79, 38)
            Me.popChargeEmpNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popChargeEmpNum.MaxLength = 6
            Me.popChargeEmpNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum.Name = "popChargeEmpNum"
            Me.popChargeEmpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum.NameText = ""
            Me.popChargeEmpNum.ReadOnlys = False
            Me.popChargeEmpNum.SelectedText = ""
            Me.popChargeEmpNum.SelectionLength = 0
            Me.popChargeEmpNum.SelectionStart = 0
            Me.popChargeEmpNum.Size = New System.Drawing.Size(150, 20)
            Me.popChargeEmpNum.TabIndex = 857
            Me.popChargeEmpNum.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum.TextAlign = 0
            Me.popChargeEmpNum.TextValue = ""
            Me.popChargeEmpNum.ToolTipText = ""
            '
            'lblRepresentativeName
            '
            Me.lblRepresentativeName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRepresentativeName.Location = New System.Drawing.Point(22, 43)
            Me.lblRepresentativeName.Name = "lblRepresentativeName"
            Me.lblRepresentativeName.Size = New System.Drawing.Size(51, 14)
            Me.lblRepresentativeName.TabIndex = 856
            Me.lblRepresentativeName.Text = "담당자"
            Me.lblRepresentativeName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PNA502
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.cboChargeTypeCd)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.lblRepresentativeName)
            Me.Controls.Add(Me.PopBranchCd)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PopZipCd)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNA502"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents PopZipCd As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents PopBranchCd As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cboChargeTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.pop
        Friend WithEvents lblRepresentativeName As System.Windows.Forms.Label


    End Class

End Namespace
