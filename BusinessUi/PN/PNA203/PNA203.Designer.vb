Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA203
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA203))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtDeptNm = New ubiLease.CommonControls.txt
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
            Me.picCriteria.Size = New System.Drawing.Size(805, 43)
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
            Me.grd_1.Location = New System.Drawing.Point(3, 52)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 592)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 764
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(15, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(94, 13)
            Me.Label2.TabIndex = 773
            Me.Label2.Text = "부서 명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtDeptNm
            '
            Me.txtDeptNm.BackColor = System.Drawing.Color.White
            Me.txtDeptNm.BorderColor = System.Drawing.Color.Empty
            Me.txtDeptNm.BorderStyle = 2
            Me.txtDeptNm.CaptionName = "부서 명"
            Me.txtDeptNm.ForeColor = System.Drawing.Color.Black
            Me.txtDeptNm.Location = New System.Drawing.Point(125, 14)
            Me.txtDeptNm.MaxLength = 50
            Me.txtDeptNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDeptNm.Multiline = False
            Me.txtDeptNm.Name = "txtDeptNm"
            Me.txtDeptNm.ReadOnlys = False
            Me.txtDeptNm.SelectedText = ""
            Me.txtDeptNm.SelectionLength = 0
            Me.txtDeptNm.SelectionStart = 0
            Me.txtDeptNm.Size = New System.Drawing.Size(243, 23)
            Me.txtDeptNm.TabIndex = 1092
            Me.txtDeptNm.Tag = ""
            Me.txtDeptNm.TextAlign = 0
            Me.txtDeptNm.TextValue = ""
            Me.txtDeptNm.ToolTipText = ""
            '
            'PNA203
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtDeptNm)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNA203"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtDeptNm As ubiLease.CommonControls.txt


    End Class

End Namespace
