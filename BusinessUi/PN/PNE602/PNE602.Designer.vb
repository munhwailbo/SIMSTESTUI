Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE602
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE602))
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpExpandYearMonthFr = New ubiLease.CommonControls.dtp
            Me.dtpExpandYearMonthTo = New ubiLease.CommonControls.dtp
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(15, 24)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(64, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 5
            Me.lblCodeDivisionHangulName.Text = "Ȯ�� ���"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(3, 4)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 50)
            Me.picCriteria_1.TabIndex = 1697
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
            Me.grd_1.Font = New System.Drawing.Font("����", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(3, 60)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(803, 584)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(172, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 15)
            Me.Label1.TabIndex = 1701
            Me.Label1.Text = "~"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpExpandYearMonthFr
            '
            Me.dtpExpandYearMonthFr.BackColor = System.Drawing.SystemColors.Window
            Me.dtpExpandYearMonthFr.BorderColor = System.Drawing.Color.Empty
            Me.dtpExpandYearMonthFr.BorderStyle = 2
            Me.dtpExpandYearMonthFr.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpExpandYearMonthFr.CaptionName = "���� �� ��"
            Me.dtpExpandYearMonthFr.DateTimeFormatText = "yyyy-MM"
            Me.dtpExpandYearMonthFr.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpExpandYearMonthFr.Location = New System.Drawing.Point(85, 20)
            Me.dtpExpandYearMonthFr.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpExpandYearMonthFr.MaxLength = 0
            Me.dtpExpandYearMonthFr.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpExpandYearMonthFr.Name = "dtpExpandYearMonthFr"
            Me.dtpExpandYearMonthFr.ReadOnlys = False
            Me.dtpExpandYearMonthFr.SelectedText = ""
            Me.dtpExpandYearMonthFr.SelectionLength = 0
            Me.dtpExpandYearMonthFr.SelectionStart = 0
            Me.dtpExpandYearMonthFr.Size = New System.Drawing.Size(80, 20)
            Me.dtpExpandYearMonthFr.TabIndex = 1704
            Me.dtpExpandYearMonthFr.Tag = "need;format(&&&&-&&);"
            Me.dtpExpandYearMonthFr.TextAlign = 0
            Me.dtpExpandYearMonthFr.TextValue = ""
            Me.dtpExpandYearMonthFr.ToolTipText = ""
            '
            'dtpExpandYearMonthTo
            '
            Me.dtpExpandYearMonthTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpExpandYearMonthTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpExpandYearMonthTo.BorderStyle = 2
            Me.dtpExpandYearMonthTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpExpandYearMonthTo.CaptionName = "���� �� ��"
            Me.dtpExpandYearMonthTo.DateTimeFormatText = "yyyy-MM"
            Me.dtpExpandYearMonthTo.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpExpandYearMonthTo.Location = New System.Drawing.Point(191, 19)
            Me.dtpExpandYearMonthTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpExpandYearMonthTo.MaxLength = 0
            Me.dtpExpandYearMonthTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpExpandYearMonthTo.Name = "dtpExpandYearMonthTo"
            Me.dtpExpandYearMonthTo.ReadOnlys = False
            Me.dtpExpandYearMonthTo.SelectedText = ""
            Me.dtpExpandYearMonthTo.SelectionLength = 0
            Me.dtpExpandYearMonthTo.SelectionStart = 0
            Me.dtpExpandYearMonthTo.Size = New System.Drawing.Size(80, 20)
            Me.dtpExpandYearMonthTo.TabIndex = 1705
            Me.dtpExpandYearMonthTo.Tag = "need;format(&&&&-&&);"
            Me.dtpExpandYearMonthTo.TextAlign = 0
            Me.dtpExpandYearMonthTo.TextValue = ""
            Me.dtpExpandYearMonthTo.ToolTipText = ""
            '
            'PNE602
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpExpandYearMonthTo)
            Me.Controls.Add(Me.dtpExpandYearMonthFr)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNE602"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.dtpExpandYearMonthFr, 0)
            Me.Controls.SetChildIndex(Me.dtpExpandYearMonthTo, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpExpandYearMonthFr As ubiLease.CommonControls.dtp
        Friend WithEvents dtpExpandYearMonthTo As ubiLease.CommonControls.dtp


    End Class

End Namespace
