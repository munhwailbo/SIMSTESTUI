Namespace ubiLease.UI.BusinessUi.CO

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMBB01
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMBB01))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.lblOrgnizationLevel = New System.Windows.Forms.Label
            Me.cboBusinessPlaceCode = New ubiLease.CommonControls.cbo
            Me.lblCornerCode = New System.Windows.Forms.Label
            Me.cboCornerCode = New ubiLease.CommonControls.cbo
            Me.lblPCCode = New System.Windows.Forms.Label
            Me.cboPCCode = New ubiLease.CommonControls.cbo
            Me.lblPartCode = New System.Windows.Forms.Label
            Me.cboPartCode = New ubiLease.CommonControls.cbo
            Me.lblTeamCode = New System.Windows.Forms.Label
            Me.cboTeamCode = New ubiLease.CommonControls.cbo
            Me.lblBusinessPlaceCode = New System.Windows.Forms.Label
            Me.cboOrganizationLevel = New ubiLease.CommonControls.cbo
            Me.lblBranchCode = New System.Windows.Forms.Label
            Me.cboBranchCode = New ubiLease.CommonControls.cbo
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("����", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 84)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 555)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 22
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 3)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 75)
            Me.picCriteria_1.TabIndex = 424
            Me.picCriteria_1.TabStop = False
            '
            'lblOrgnizationLevel
            '
            Me.lblOrgnizationLevel.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblOrgnizationLevel.Location = New System.Drawing.Point(24, 23)
            Me.lblOrgnizationLevel.Name = "lblOrgnizationLevel"
            Me.lblOrgnizationLevel.Size = New System.Drawing.Size(33, 14)
            Me.lblOrgnizationLevel.TabIndex = 455
            Me.lblOrgnizationLevel.Tag = ""
            Me.lblOrgnizationLevel.Text = "����"
            '
            'cboBusinessPlaceCode
            '
            Me.cboBusinessPlaceCode.CaptionName = "���� �ڵ�"
            Me.cboBusinessPlaceCode.ListCount = 0
            Me.cboBusinessPlaceCode.Location = New System.Drawing.Point(64, 45)
            Me.cboBusinessPlaceCode.Name = "cboBusinessPlaceCode"
            Me.cboBusinessPlaceCode.ReadOnlys = False
            Me.cboBusinessPlaceCode.Size = New System.Drawing.Size(88, 20)
            Me.cboBusinessPlaceCode.TabIndex = 454
            Me.cboBusinessPlaceCode.Tag = "code(����� ��|��ü);"
            Me.cboBusinessPlaceCode.TextValue = ""
            '
            'lblCornerCode
            '
            Me.lblCornerCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCornerCode.Font = New System.Drawing.Font("����", 9.0!)
            Me.lblCornerCode.Location = New System.Drawing.Point(661, 49)
            Me.lblCornerCode.Name = "lblCornerCode"
            Me.lblCornerCode.Size = New System.Drawing.Size(32, 15)
            Me.lblCornerCode.TabIndex = 468
            Me.lblCornerCode.Text = "�ڳ�"
            Me.lblCornerCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboCornerCode
            '
            Me.cboCornerCode.CaptionName = "�ڳ� �ڵ�"
            Me.cboCornerCode.ListCount = 0
            Me.cboCornerCode.Location = New System.Drawing.Point(699, 45)
            Me.cboCornerCode.Name = "cboCornerCode"
            Me.cboCornerCode.ReadOnlys = False
            Me.cboCornerCode.Size = New System.Drawing.Size(93, 20)
            Me.cboCornerCode.TabIndex = 461
            Me.cboCornerCode.Tag = "code(�ڳ� ��, ���� �ڵ�, �� �ڵ�, �� �ڵ�, ��Ʈ �ڵ�, PC �ڵ�|��ü);"
            Me.cboCornerCode.TextValue = ""
            '
            'lblPCCode
            '
            Me.lblPCCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblPCCode.Font = New System.Drawing.Font("����", 9.0!)
            Me.lblPCCode.Location = New System.Drawing.Point(533, 49)
            Me.lblPCCode.Name = "lblPCCode"
            Me.lblPCCode.Size = New System.Drawing.Size(26, 15)
            Me.lblPCCode.TabIndex = 467
            Me.lblPCCode.Text = "PC"
            Me.lblPCCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboPCCode
            '
            Me.cboPCCode.CaptionName = "PC �ڵ�"
            Me.cboPCCode.ListCount = 0
            Me.cboPCCode.Location = New System.Drawing.Point(565, 45)
            Me.cboPCCode.Name = "cboPCCode"
            Me.cboPCCode.ReadOnlys = False
            Me.cboPCCode.Size = New System.Drawing.Size(80, 20)
            Me.cboPCCode.TabIndex = 460
            Me.cboPCCode.Tag = "code(PC ��, ���� �ڵ�, �� �ڵ�, �� �ڵ�, ��Ʈ �ڵ�|��ü);"
            Me.cboPCCode.TextValue = ""
            '
            'lblPartCode
            '
            Me.lblPartCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblPartCode.Font = New System.Drawing.Font("����", 9.0!)
            Me.lblPartCode.Location = New System.Drawing.Point(402, 49)
            Me.lblPartCode.Name = "lblPartCode"
            Me.lblPartCode.Size = New System.Drawing.Size(30, 15)
            Me.lblPartCode.TabIndex = 466
            Me.lblPartCode.Text = "��Ʈ"
            Me.lblPartCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboPartCode
            '
            Me.cboPartCode.CaptionName = "��Ʈ �ڵ�"
            Me.cboPartCode.ListCount = 0
            Me.cboPartCode.Location = New System.Drawing.Point(438, 45)
            Me.cboPartCode.Name = "cboPartCode"
            Me.cboPartCode.ReadOnlys = False
            Me.cboPartCode.Size = New System.Drawing.Size(89, 20)
            Me.cboPartCode.TabIndex = 459
            Me.cboPartCode.Tag = "code(��Ʈ ��, ���� �ڵ�, �� �ڵ�, �� �ڵ�|��ü);"
            Me.cboPartCode.TextValue = ""
            '
            'lblTeamCode
            '
            Me.lblTeamCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTeamCode.Font = New System.Drawing.Font("����", 9.0!)
            Me.lblTeamCode.Location = New System.Drawing.Point(288, 49)
            Me.lblTeamCode.Name = "lblTeamCode"
            Me.lblTeamCode.Size = New System.Drawing.Size(19, 15)
            Me.lblTeamCode.TabIndex = 465
            Me.lblTeamCode.Text = "��"
            Me.lblTeamCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboTeamCode
            '
            Me.cboTeamCode.CaptionName = "�� �ڵ�"
            Me.cboTeamCode.ListCount = 0
            Me.cboTeamCode.Location = New System.Drawing.Point(313, 45)
            Me.cboTeamCode.Name = "cboTeamCode"
            Me.cboTeamCode.ReadOnlys = False
            Me.cboTeamCode.Size = New System.Drawing.Size(80, 20)
            Me.cboTeamCode.TabIndex = 458
            Me.cboTeamCode.Tag = "code(�� ��, ���� �ڵ�, �� �ڵ�|��ü);"
            Me.cboTeamCode.TextValue = ""
            '
            'lblBusinessPlaceCode
            '
            Me.lblBusinessPlaceCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBusinessPlaceCode.Font = New System.Drawing.Font("����", 9.0!)
            Me.lblBusinessPlaceCode.Location = New System.Drawing.Point(25, 49)
            Me.lblBusinessPlaceCode.Name = "lblBusinessPlaceCode"
            Me.lblBusinessPlaceCode.Size = New System.Drawing.Size(33, 15)
            Me.lblBusinessPlaceCode.TabIndex = 463
            Me.lblBusinessPlaceCode.Text = "����"
            Me.lblBusinessPlaceCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboOrganizationLevel
            '
            Me.cboOrganizationLevel.CaptionName = ""
            Me.cboOrganizationLevel.ListCount = 0
            Me.cboOrganizationLevel.Location = New System.Drawing.Point(64, 17)
            Me.cboOrganizationLevel.Name = "cboOrganizationLevel"
            Me.cboOrganizationLevel.ReadOnlys = False
            Me.cboOrganizationLevel.Size = New System.Drawing.Size(89, 20)
            Me.cboOrganizationLevel.Sorted = True
            Me.cboOrganizationLevel.TabIndex = 456
            Me.cboOrganizationLevel.Tag = "need;code(�ͼ� ���� ��);"
            Me.cboOrganizationLevel.TextValue = ""
            '
            'lblBranchCode
            '
            Me.lblBranchCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchCode.Font = New System.Drawing.Font("����", 9.0!)
            Me.lblBranchCode.Location = New System.Drawing.Point(164, 49)
            Me.lblBranchCode.Name = "lblBranchCode"
            Me.lblBranchCode.Size = New System.Drawing.Size(19, 15)
            Me.lblBranchCode.TabIndex = 464
            Me.lblBranchCode.Text = "��"
            Me.lblBranchCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cboBranchCode
            '
            Me.cboBranchCode.CaptionName = "�� �ڵ�"
            Me.cboBranchCode.ListCount = 0
            Me.cboBranchCode.Location = New System.Drawing.Point(189, 45)
            Me.cboBranchCode.Name = "cboBranchCode"
            Me.cboBranchCode.ReadOnlys = False
            Me.cboBranchCode.Size = New System.Drawing.Size(88, 20)
            Me.cboBranchCode.TabIndex = 457
            Me.cboBranchCode.Tag = "code(���� ��,���� �ڵ�|��ü);"
            Me.cboBranchCode.TextValue = ""
            '
            'SMBB01
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblCornerCode)
            Me.Controls.Add(Me.cboCornerCode)
            Me.Controls.Add(Me.lblPCCode)
            Me.Controls.Add(Me.cboPCCode)
            Me.Controls.Add(Me.lblPartCode)
            Me.Controls.Add(Me.cboPartCode)
            Me.Controls.Add(Me.lblTeamCode)
            Me.Controls.Add(Me.cboTeamCode)
            Me.Controls.Add(Me.lblBusinessPlaceCode)
            Me.Controls.Add(Me.cboOrganizationLevel)
            Me.Controls.Add(Me.lblBranchCode)
            Me.Controls.Add(Me.cboBranchCode)
            Me.Controls.Add(Me.lblOrgnizationLevel)
            Me.Controls.Add(Me.cboBusinessPlaceCode)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMBB01"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblOrgnizationLevel As System.Windows.Forms.Label
        Friend WithEvents cboBusinessPlaceCode As ubiLease.CommonControls.cbo
        Friend WithEvents lblCornerCode As System.Windows.Forms.Label
        Friend WithEvents cboCornerCode As ubiLease.CommonControls.cbo
        Friend WithEvents lblPCCode As System.Windows.Forms.Label
        Friend WithEvents cboPCCode As ubiLease.CommonControls.cbo
        Friend WithEvents lblPartCode As System.Windows.Forms.Label
        Friend WithEvents cboPartCode As ubiLease.CommonControls.cbo
        Friend WithEvents lblTeamCode As System.Windows.Forms.Label
        Friend WithEvents cboTeamCode As ubiLease.CommonControls.cbo
        Friend WithEvents lblBusinessPlaceCode As System.Windows.Forms.Label
        Friend WithEvents cboOrganizationLevel As ubiLease.CommonControls.cbo
        Friend WithEvents lblBranchCode As System.Windows.Forms.Label
        Friend WithEvents cboBranchCode As ubiLease.CommonControls.cbo

    End Class

End Namespace
