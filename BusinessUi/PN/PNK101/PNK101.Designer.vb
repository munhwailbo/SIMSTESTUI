Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNK101
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNK101))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblBranchName = New System.Windows.Forms.Label
            Me.txtBranchName = New ubiLease.CommonControls.txt
            Me.lblReaderName = New System.Windows.Forms.Label
            Me.txtReaderName = New ubiLease.CommonControls.txt
            Me.txtReaderHp = New ubiLease.CommonControls.txt
            Me.lblReaderHp = New System.Windows.Forms.Label
            Me.txtReaderTel1 = New ubiLease.CommonControls.txt
            Me.lblReaderTel1 = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(805, 73)
            Me.picCriteria.TabIndex = 765
            Me.picCriteria.TabStop = False
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
            Me.grd_1.Location = New System.Drawing.Point(3, 82)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 562)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 764
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblBranchName
            '
            Me.lblBranchName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchName.Location = New System.Drawing.Point(33, 49)
            Me.lblBranchName.Name = "lblBranchName"
            Me.lblBranchName.Size = New System.Drawing.Size(94, 13)
            Me.lblBranchName.TabIndex = 773
            Me.lblBranchName.Text = "지국 명"
            Me.lblBranchName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtBranchName
            '
            Me.txtBranchName.BackColor = System.Drawing.Color.White
            Me.txtBranchName.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchName.BorderStyle = 2
            Me.txtBranchName.CaptionName = "부서 명"
            Me.txtBranchName.ForeColor = System.Drawing.Color.Black
            Me.txtBranchName.Location = New System.Drawing.Point(132, 43)
            Me.txtBranchName.MaxLength = 50
            Me.txtBranchName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchName.Multiline = False
            Me.txtBranchName.Name = "txtBranchName"
            Me.txtBranchName.ReadOnlys = False
            Me.txtBranchName.SelectedText = ""
            Me.txtBranchName.SelectionLength = 0
            Me.txtBranchName.SelectionStart = 0
            Me.txtBranchName.Size = New System.Drawing.Size(97, 23)
            Me.txtBranchName.TabIndex = 1092
            Me.txtBranchName.Tag = ""
            Me.txtBranchName.TextAlign = 0
            Me.txtBranchName.TextValue = ""
            Me.txtBranchName.ToolTipText = ""
            '
            'lblReaderName
            '
            Me.lblReaderName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReaderName.Location = New System.Drawing.Point(34, 20)
            Me.lblReaderName.Name = "lblReaderName"
            Me.lblReaderName.Size = New System.Drawing.Size(94, 13)
            Me.lblReaderName.TabIndex = 1093
            Me.lblReaderName.Text = "독자 명"
            Me.lblReaderName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtReaderName
            '
            Me.txtReaderName.BackColor = System.Drawing.Color.White
            Me.txtReaderName.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderName.BorderStyle = 2
            Me.txtReaderName.CaptionName = "부서 명"
            Me.txtReaderName.ForeColor = System.Drawing.Color.Black
            Me.txtReaderName.Location = New System.Drawing.Point(132, 14)
            Me.txtReaderName.MaxLength = 50
            Me.txtReaderName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderName.Multiline = False
            Me.txtReaderName.Name = "txtReaderName"
            Me.txtReaderName.ReadOnlys = False
            Me.txtReaderName.SelectedText = ""
            Me.txtReaderName.SelectionLength = 0
            Me.txtReaderName.SelectionStart = 0
            Me.txtReaderName.Size = New System.Drawing.Size(167, 23)
            Me.txtReaderName.TabIndex = 1
            Me.txtReaderName.Tag = ""
            Me.txtReaderName.TextAlign = 0
            Me.txtReaderName.TextValue = ""
            Me.txtReaderName.ToolTipText = ""
            '
            'txtReaderHp
            '
            Me.txtReaderHp.BackColor = System.Drawing.Color.White
            Me.txtReaderHp.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderHp.BorderStyle = 2
            Me.txtReaderHp.CaptionName = "부서 명"
            Me.txtReaderHp.ForeColor = System.Drawing.Color.Black
            Me.txtReaderHp.Location = New System.Drawing.Point(419, 14)
            Me.txtReaderHp.MaxLength = 50
            Me.txtReaderHp.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderHp.Multiline = False
            Me.txtReaderHp.Name = "txtReaderHp"
            Me.txtReaderHp.ReadOnlys = False
            Me.txtReaderHp.SelectedText = ""
            Me.txtReaderHp.SelectionLength = 0
            Me.txtReaderHp.SelectionStart = 0
            Me.txtReaderHp.Size = New System.Drawing.Size(167, 23)
            Me.txtReaderHp.TabIndex = 1096
            Me.txtReaderHp.Tag = ""
            Me.txtReaderHp.TextAlign = 0
            Me.txtReaderHp.TextValue = ""
            Me.txtReaderHp.ToolTipText = ""
            '
            'lblReaderHp
            '
            Me.lblReaderHp.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReaderHp.Location = New System.Drawing.Point(316, 20)
            Me.lblReaderHp.Name = "lblReaderHp"
            Me.lblReaderHp.Size = New System.Drawing.Size(94, 13)
            Me.lblReaderHp.TabIndex = 1095
            Me.lblReaderHp.Text = "핸드폰"
            Me.lblReaderHp.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtReaderTel1
            '
            Me.txtReaderTel1.BackColor = System.Drawing.Color.White
            Me.txtReaderTel1.BorderColor = System.Drawing.Color.Empty
            Me.txtReaderTel1.BorderStyle = 2
            Me.txtReaderTel1.CaptionName = "부서 명"
            Me.txtReaderTel1.ForeColor = System.Drawing.Color.Black
            Me.txtReaderTel1.Location = New System.Drawing.Point(419, 43)
            Me.txtReaderTel1.MaxLength = 50
            Me.txtReaderTel1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtReaderTel1.Multiline = False
            Me.txtReaderTel1.Name = "txtReaderTel1"
            Me.txtReaderTel1.ReadOnlys = False
            Me.txtReaderTel1.SelectedText = ""
            Me.txtReaderTel1.SelectionLength = 0
            Me.txtReaderTel1.SelectionStart = 0
            Me.txtReaderTel1.Size = New System.Drawing.Size(167, 23)
            Me.txtReaderTel1.TabIndex = 1098
            Me.txtReaderTel1.Tag = ""
            Me.txtReaderTel1.TextAlign = 0
            Me.txtReaderTel1.TextValue = ""
            Me.txtReaderTel1.ToolTipText = ""
            '
            'lblReaderTel1
            '
            Me.lblReaderTel1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblReaderTel1.Location = New System.Drawing.Point(316, 49)
            Me.lblReaderTel1.Name = "lblReaderTel1"
            Me.lblReaderTel1.Size = New System.Drawing.Size(94, 13)
            Me.lblReaderTel1.TabIndex = 1097
            Me.lblReaderTel1.Text = "전화번호1"
            Me.lblReaderTel1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PNK101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtReaderTel1)
            Me.Controls.Add(Me.lblReaderTel1)
            Me.Controls.Add(Me.txtReaderHp)
            Me.Controls.Add(Me.lblReaderHp)
            Me.Controls.Add(Me.txtReaderName)
            Me.Controls.Add(Me.lblReaderName)
            Me.Controls.Add(Me.txtBranchName)
            Me.Controls.Add(Me.lblBranchName)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNK101"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.lblBranchName, 0)
            Me.Controls.SetChildIndex(Me.txtBranchName, 0)
            Me.Controls.SetChildIndex(Me.lblReaderName, 0)
            Me.Controls.SetChildIndex(Me.txtReaderName, 0)
            Me.Controls.SetChildIndex(Me.lblReaderHp, 0)
            Me.Controls.SetChildIndex(Me.txtReaderHp, 0)
            Me.Controls.SetChildIndex(Me.lblReaderTel1, 0)
            Me.Controls.SetChildIndex(Me.txtReaderTel1, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblBranchName As System.Windows.Forms.Label
        Friend WithEvents txtBranchName As ubiLease.CommonControls.txt
        Friend WithEvents lblReaderName As System.Windows.Forms.Label
        Friend WithEvents txtReaderName As ubiLease.CommonControls.txt
        Friend WithEvents txtReaderHp As ubiLease.CommonControls.txt
        Friend WithEvents lblReaderHp As System.Windows.Forms.Label
        Friend WithEvents txtReaderTel1 As ubiLease.CommonControls.txt
        Friend WithEvents lblReaderTel1 As System.Windows.Forms.Label


    End Class

End Namespace
