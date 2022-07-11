Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMDA04
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMDA04))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.lblPrivateUseBeginningDate = New System.Windows.Forms.Label
            Me.dtpStartDate = New ubiLease.CommonControls.dtp
            Me.dtpEndDate = New ubiLease.CommonControls.dtp
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
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
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 46)
            Me.picCriteria_1.TabIndex = 424
            Me.picCriteria_1.TabStop = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(215, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(14, 12)
            Me.Label1.TabIndex = 428
            Me.Label1.Text = "~"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblPrivateUseBeginningDate
            '
            Me.lblPrivateUseBeginningDate.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblPrivateUseBeginningDate.Location = New System.Drawing.Point(27, 21)
            Me.lblPrivateUseBeginningDate.Name = "lblPrivateUseBeginningDate"
            Me.lblPrivateUseBeginningDate.Size = New System.Drawing.Size(61, 15)
            Me.lblPrivateUseBeginningDate.TabIndex = 426
            Me.lblPrivateUseBeginningDate.Text = "사용 일자"
            Me.lblPrivateUseBeginningDate.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpStartDate
            '
            Me.dtpStartDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpStartDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpStartDate.BorderStyle = 2
            Me.dtpStartDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpStartDate.CaptionName = "사용 일자"
            Me.dtpStartDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpStartDate.Location = New System.Drawing.Point(93, 18)
            Me.dtpStartDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpStartDate.MaxLength = 0
            Me.dtpStartDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpStartDate.Name = "dtpStartDate"
            Me.dtpStartDate.ReadOnlys = False
            Me.dtpStartDate.SelectedText = ""
            Me.dtpStartDate.SelectionLength = 0
            Me.dtpStartDate.SelectionStart = 0
            Me.dtpStartDate.Size = New System.Drawing.Size(116, 20)
            Me.dtpStartDate.TabIndex = 425
            Me.dtpStartDate.Tag = "need;"
            Me.dtpStartDate.TextAlign = 0
            Me.dtpStartDate.TextValue = Nothing
            Me.dtpStartDate.ToolTipText = ""
            '
            'dtpEndDate
            '
            Me.dtpEndDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpEndDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpEndDate.BorderStyle = 2
            Me.dtpEndDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpEndDate.CaptionName = "사용 일자"
            Me.dtpEndDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpEndDate.Location = New System.Drawing.Point(235, 18)
            Me.dtpEndDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpEndDate.MaxLength = 0
            Me.dtpEndDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpEndDate.Name = "dtpEndDate"
            Me.dtpEndDate.ReadOnlys = False
            Me.dtpEndDate.SelectedText = ""
            Me.dtpEndDate.SelectionLength = 0
            Me.dtpEndDate.SelectionStart = 0
            Me.dtpEndDate.Size = New System.Drawing.Size(116, 20)
            Me.dtpEndDate.TabIndex = 427
            Me.dtpEndDate.Tag = "need;"
            Me.dtpEndDate.TextAlign = 0
            Me.dtpEndDate.TextValue = Nothing
            Me.dtpEndDate.ToolTipText = ""
            '
            'SMDA04
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblPrivateUseBeginningDate)
            Me.Controls.Add(Me.dtpStartDate)
            Me.Controls.Add(Me.dtpEndDate)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMDA04"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblPrivateUseBeginningDate As System.Windows.Forms.Label
        Friend WithEvents dtpStartDate As ubiLease.CommonControls.dtp
        Friend WithEvents dtpEndDate As ubiLease.CommonControls.dtp

    End Class

End Namespace
