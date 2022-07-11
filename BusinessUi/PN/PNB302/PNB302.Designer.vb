Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNB302
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNB302))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.lblBaseDt = New System.Windows.Forms.Label
            Me.dtpBaseDt = New ubiLease.CommonControls.dtp
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.Location = New System.Drawing.Point(3, 70)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 533)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(805, 61)
            Me.PictureBox1.TabIndex = 992
            Me.PictureBox1.TabStop = False
            '
            'lblBaseDt
            '
            Me.lblBaseDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBaseDt.Location = New System.Drawing.Point(30, 23)
            Me.lblBaseDt.Name = "lblBaseDt"
            Me.lblBaseDt.Size = New System.Drawing.Size(53, 20)
            Me.lblBaseDt.TabIndex = 1093
            Me.lblBaseDt.Text = "기준일자"
            Me.lblBaseDt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpBaseDt
            '
            Me.dtpBaseDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseDt.BorderStyle = 2
            Me.dtpBaseDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseDt.CaptionName = "기준년월"
            Me.dtpBaseDt.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseDt.Location = New System.Drawing.Point(89, 23)
            Me.dtpBaseDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseDt.MaxLength = 0
            Me.dtpBaseDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseDt.Name = "dtpBaseDt"
            Me.dtpBaseDt.ReadOnlys = False
            Me.dtpBaseDt.SelectedText = ""
            Me.dtpBaseDt.SelectionLength = 0
            Me.dtpBaseDt.SelectionStart = 0
            Me.dtpBaseDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseDt.TabIndex = 1092
            Me.dtpBaseDt.Tag = "format(&&&&-&&);"
            Me.dtpBaseDt.TextAlign = 0
            Me.dtpBaseDt.TextValue = ""
            Me.dtpBaseDt.ToolTipText = ""
            '
            'PNB302
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblBaseDt)
            Me.Controls.Add(Me.dtpBaseDt)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNB302"
            Me.Size = New System.Drawing.Size(811, 606)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblBaseDt As System.Windows.Forms.Label
        Friend WithEvents dtpBaseDt As ubiLease.CommonControls.dtp

    End Class

End Namespace
