Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA601
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA601))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpBizDt = New ubiLease.CommonControls.dtp
            Me.lblBaseMonths = New System.Windows.Forms.Label
            Me.btnNew = New ubiLease.CommonControls.btn
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(6, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 46)
            Me.picCriteria_1.TabIndex = 18
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
            Me.grd_1.Location = New System.Drawing.Point(6, 55)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 588)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 19
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpBizDt
            '
            Me.dtpBizDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBizDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpBizDt.BorderStyle = 2
            Me.dtpBizDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBizDt.CaptionName = "업무 년월"
            Me.dtpBizDt.DateTimeFormatText = "yyyy-MM"
            Me.dtpBizDt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBizDt.Location = New System.Drawing.Point(163, 16)
            Me.dtpBizDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBizDt.MaxLength = 0
            Me.dtpBizDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBizDt.Name = "dtpBizDt"
            Me.dtpBizDt.ReadOnlys = False
            Me.dtpBizDt.SelectedText = ""
            Me.dtpBizDt.SelectionLength = 0
            Me.dtpBizDt.SelectionStart = 0
            Me.dtpBizDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpBizDt.TabIndex = 24
            Me.dtpBizDt.Tag = "format(&&&&-&&);"
            Me.dtpBizDt.TextAlign = 0
            Me.dtpBizDt.TextValue = Nothing
            Me.dtpBizDt.ToolTipText = ""
            '
            'lblBaseMonths
            '
            Me.lblBaseMonths.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBaseMonths.Location = New System.Drawing.Point(36, 21)
            Me.lblBaseMonths.Name = "lblBaseMonths"
            Me.lblBaseMonths.Size = New System.Drawing.Size(111, 15)
            Me.lblBaseMonths.TabIndex = 23
            Me.lblBaseMonths.Text = "업무 년 월"
            Me.lblBaseMonths.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'btnNew
            '
            Me.btnNew.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNew.Location = New System.Drawing.Point(404, 16)
            Me.btnNew.Name = "btnNew"
            Me.btnNew.Size = New System.Drawing.Size(133, 23)
            Me.btnNew.TabIndex = 25
            Me.btnNew.Text = "기초 자료 생성"
            Me.btnNew.UseVisualStyleBackColor = True
            '
            'PNA601
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.btnNew)
            Me.Controls.Add(Me.dtpBizDt)
            Me.Controls.Add(Me.lblBaseMonths)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNA601"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents dtpBizDt As ubiLease.CommonControls.dtp
        Friend WithEvents lblBaseMonths As System.Windows.Forms.Label
        Friend WithEvents btnNew As ubiLease.CommonControls.btn


    End Class

End Namespace
