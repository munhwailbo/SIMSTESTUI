Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNB105
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNB105))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.lblBaseDt = New System.Windows.Forms.Label
            Me.dtpYYYYMM = New ubiLease.CommonControls.dtp
            Me.chkOpenCheck = New ubiLease.CommonControls.chk
            Me.chkCloseCheck = New ubiLease.CommonControls.chk
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.Size = New System.Drawing.Size(805, 546)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 3
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
            Me.PictureBox1.Size = New System.Drawing.Size(805, 51)
            Me.PictureBox1.TabIndex = 992
            Me.PictureBox1.TabStop = False
            '
            'lblBaseDt
            '
            Me.lblBaseDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBaseDt.Location = New System.Drawing.Point(35, 20)
            Me.lblBaseDt.Name = "lblBaseDt"
            Me.lblBaseDt.Size = New System.Drawing.Size(93, 20)
            Me.lblBaseDt.TabIndex = 4
            Me.lblBaseDt.Text = "기준일자"
            Me.lblBaseDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpYYYYMM
            '
            Me.dtpYYYYMM.BackColor = System.Drawing.SystemColors.Window
            Me.dtpYYYYMM.BorderColor = System.Drawing.Color.Empty
            Me.dtpYYYYMM.BorderStyle = 2
            Me.dtpYYYYMM.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpYYYYMM.CaptionName = "기준년월"
            Me.dtpYYYYMM.DateTimeFormatText = "yyyy-MM"
            Me.dtpYYYYMM.Location = New System.Drawing.Point(134, 20)
            Me.dtpYYYYMM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpYYYYMM.MaxLength = 0
            Me.dtpYYYYMM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpYYYYMM.Name = "dtpYYYYMM"
            Me.dtpYYYYMM.ReadOnlys = False
            Me.dtpYYYYMM.SelectedText = ""
            Me.dtpYYYYMM.SelectionLength = 0
            Me.dtpYYYYMM.SelectionStart = 0
            Me.dtpYYYYMM.Size = New System.Drawing.Size(100, 20)
            Me.dtpYYYYMM.TabIndex = 0
            Me.dtpYYYYMM.Tag = "format(&&&&-&&);"
            Me.dtpYYYYMM.TextAlign = 0
            Me.dtpYYYYMM.TextValue = ""
            Me.dtpYYYYMM.ToolTipText = ""
            '
            'chkOpenCheck
            '
            Me.chkOpenCheck.AutoSize = True
            Me.chkOpenCheck.CaptionName = Nothing
            Me.chkOpenCheck.Location = New System.Drawing.Point(653, 20)
            Me.chkOpenCheck.Name = "chkOpenCheck"
            Me.chkOpenCheck.ReadOnlys = False
            Me.chkOpenCheck.Size = New System.Drawing.Size(72, 16)
            Me.chkOpenCheck.TabIndex = 1162
            Me.chkOpenCheck.Tag = Nothing
            Me.chkOpenCheck.Text = "전체지국"
            Me.chkOpenCheck.TextValue = "0"
            Me.chkOpenCheck.UseVisualStyleBackColor = True
            '
            'chkCloseCheck
            '
            Me.chkCloseCheck.AutoSize = True
            Me.chkCloseCheck.CaptionName = Nothing
            Me.chkCloseCheck.Location = New System.Drawing.Point(550, 20)
            Me.chkCloseCheck.Name = "chkCloseCheck"
            Me.chkCloseCheck.ReadOnlys = False
            Me.chkCloseCheck.Size = New System.Drawing.Size(60, 16)
            Me.chkCloseCheck.TabIndex = 1161
            Me.chkCloseCheck.Tag = Nothing
            Me.chkCloseCheck.Text = "폐지국"
            Me.chkCloseCheck.TextValue = "0"
            Me.chkCloseCheck.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox2.Location = New System.Drawing.Point(527, 11)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(217, 35)
            Me.PictureBox2.TabIndex = 1163
            Me.PictureBox2.TabStop = False
            '
            'PNB105
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.chkOpenCheck)
            Me.Controls.Add(Me.chkCloseCheck)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.lblBaseDt)
            Me.Controls.Add(Me.dtpYYYYMM)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNB105"
            Me.Size = New System.Drawing.Size(811, 606)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.dtpYYYYMM, 0)
            Me.Controls.SetChildIndex(Me.lblBaseDt, 0)
            Me.Controls.SetChildIndex(Me.PictureBox2, 0)
            Me.Controls.SetChildIndex(Me.chkCloseCheck, 0)
            Me.Controls.SetChildIndex(Me.chkOpenCheck, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblBaseDt As System.Windows.Forms.Label
        Friend WithEvents dtpYYYYMM As ubiLease.CommonControls.dtp
        Friend WithEvents chkOpenCheck As ubiLease.CommonControls.chk
        Friend WithEvents chkCloseCheck As ubiLease.CommonControls.chk
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

    End Class

End Namespace
