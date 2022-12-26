Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class PNE702
        Inherits CommonControls.UiControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE702))
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label()
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox()
            Me.grd_1 = New ubiLease.GridControl.grd()
            Me.cboAdDivision = New ubiLease.CommonControls.cbo()
            Me.dtpYYYY = New ubiLease.CommonControls.dtp()
            Me.Label1 = New System.Windows.Forms.Label()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(200, 18)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(123, 20)
            Me.lblCodeDivisionHangulName.TabIndex = 0
            Me.lblCodeDivisionHangulName.Text = "광고 구분"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 46)
            Me.picCriteria_1.TabIndex = 2
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
            Me.grd_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 56)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(802, 586)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'cboAdDivision
            '
            Me.cboAdDivision.CaptionName = "사원확장 광고 구분"
            Me.cboAdDivision.ListCount = 0
            Me.cboAdDivision.Location = New System.Drawing.Point(329, 18)
            Me.cboAdDivision.Name = "cboAdDivision"
            Me.cboAdDivision.ReadOnlys = False
            Me.cboAdDivision.Size = New System.Drawing.Size(140, 20)
            Me.cboAdDivision.TabIndex = 3
            Me.cboAdDivision.Tag = "code(사원확장 광고 구분|전체);"
            Me.cboAdDivision.TextValue = ""
            '
            'dtpYYYY
            '
            Me.dtpYYYY.BackColor = System.Drawing.SystemColors.Window
            Me.dtpYYYY.BorderColor = System.Drawing.Color.Empty
            Me.dtpYYYY.BorderStyle = 2
            Me.dtpYYYY.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpYYYY.CaptionName = "���س��"
            Me.dtpYYYY.DateTimeFormatText = "yyyy"
            Me.dtpYYYY.Location = New System.Drawing.Point(94, 18)
            Me.dtpYYYY.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpYYYY.MaxLength = 0
            Me.dtpYYYY.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpYYYY.Name = "dtpYYYY"
            Me.dtpYYYY.ReadOnlys = False
            Me.dtpYYYY.SelectedText = ""
            Me.dtpYYYY.SelectionLength = 0
            Me.dtpYYYY.SelectionStart = 0
            Me.dtpYYYY.Size = New System.Drawing.Size(100, 20)
            Me.dtpYYYY.TabIndex = 4
            Me.dtpYYYY.Tag = "format(&&&&);"
            Me.dtpYYYY.TextAlign = 0
            Me.dtpYYYY.TextValue = ""
            Me.dtpYYYY.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(26, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 20)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "관리년도"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PNE702
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpYYYY)
            Me.Controls.Add(Me.cboAdDivision)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNE702"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.cboAdDivision, 0)
            Me.Controls.SetChildIndex(Me.dtpYYYY, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents cboAdDivision As ubiLease.CommonControls.cbo
        Friend WithEvents dtpYYYY As CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class

End Namespace
