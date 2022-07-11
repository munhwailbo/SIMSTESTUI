Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMCB05
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMCB05))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.popEarningsOrganizationCode = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            Me.popProgramList = New ubiLease.CommonControls.pop
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(3, 57)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 582)
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
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 46)
            Me.picCriteria_1.TabIndex = 424
            Me.picCriteria_1.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(26, 22)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(57, 12)
            Me.Label4.TabIndex = 452
            Me.Label4.Text = "조직 코드"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popEarningsOrganizationCode
            '
            Me.popEarningsOrganizationCode.BorderColor = System.Drawing.Color.Empty
            Me.popEarningsOrganizationCode.BorderStyle = 2
            Me.popEarningsOrganizationCode.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEarningsOrganizationCode.CaptionName = "파트 명"
            Me.popEarningsOrganizationCode.CodeText = ""
            Me.popEarningsOrganizationCode.CodeWidth = 60
            Me.popEarningsOrganizationCode.Location = New System.Drawing.Point(93, 18)
            Me.popEarningsOrganizationCode.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEarningsOrganizationCode.MaxLength = 7
            Me.popEarningsOrganizationCode.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEarningsOrganizationCode.Name = "popEarningsOrganizationCode"
            Me.popEarningsOrganizationCode.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEarningsOrganizationCode.NameText = ""
            Me.popEarningsOrganizationCode.ReadOnlys = False
            Me.popEarningsOrganizationCode.SelectedText = ""
            Me.popEarningsOrganizationCode.SelectionLength = 0
            Me.popEarningsOrganizationCode.SelectionStart = 0
            Me.popEarningsOrganizationCode.Size = New System.Drawing.Size(271, 20)
            Me.popEarningsOrganizationCode.TabIndex = 453
            Me.popEarningsOrganizationCode.Tag = "code(파트 명);"
            Me.popEarningsOrganizationCode.TextAlign = 0
            Me.popEarningsOrganizationCode.TextValue = ""
            Me.popEarningsOrganizationCode.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(370, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(53, 12)
            Me.Label1.TabIndex = 454
            Me.Label1.Text = "프로그램"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popProgramList
            '
            Me.popProgramList.BorderColor = System.Drawing.Color.Empty
            Me.popProgramList.BorderStyle = 2
            Me.popProgramList.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popProgramList.CaptionName = "프로그램 ID"
            Me.popProgramList.CodeText = ""
            Me.popProgramList.CodeWidth = 60
            Me.popProgramList.Location = New System.Drawing.Point(429, 18)
            Me.popProgramList.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popProgramList.MaxLength = 10
            Me.popProgramList.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popProgramList.Name = "popProgramList"
            Me.popProgramList.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popProgramList.NameText = ""
            Me.popProgramList.ReadOnlys = False
            Me.popProgramList.SelectedText = ""
            Me.popProgramList.SelectionLength = 0
            Me.popProgramList.SelectionStart = 0
            Me.popProgramList.Size = New System.Drawing.Size(271, 20)
            Me.popProgramList.TabIndex = 455
            Me.popProgramList.Tag = "code(프로그램 명);"
            Me.popProgramList.TextAlign = 0
            Me.popProgramList.TextValue = ""
            Me.popProgramList.ToolTipText = ""
            '
            'SMCB05
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.popProgramList)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.popEarningsOrganizationCode)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMCB05"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents popEarningsOrganizationCode As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents popProgramList As ubiLease.CommonControls.pop

    End Class

End Namespace
