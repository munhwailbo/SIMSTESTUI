Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PND101
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PND101))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.dtpRscDateFrom = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.popRscCompanyCd = New ubiLease.CommonControls.pop
            Me.Label22 = New System.Windows.Forms.Label
            Me.dtpRscDateTo = New ubiLease.CommonControls.dtp
            Me.Label14 = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtRscTitle = New ubiLease.CommonControls.txt
            Me.txtRscCompanyNm = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
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
            Me.picCriteria.Location = New System.Drawing.Point(6, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(799, 72)
            Me.picCriteria.TabIndex = 851
            Me.picCriteria.TabStop = False
            '
            'dtpRscDateFrom
            '
            Me.dtpRscDateFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpRscDateFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpRscDateFrom.BorderStyle = 2
            Me.dtpRscDateFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpRscDateFrom.CaptionName = "기준 일자 1"
            Me.dtpRscDateFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpRscDateFrom.Location = New System.Drawing.Point(117, 23)
            Me.dtpRscDateFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpRscDateFrom.MaxLength = 0
            Me.dtpRscDateFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpRscDateFrom.Name = "dtpRscDateFrom"
            Me.dtpRscDateFrom.ReadOnlys = False
            Me.dtpRscDateFrom.SelectedText = ""
            Me.dtpRscDateFrom.SelectionLength = 0
            Me.dtpRscDateFrom.SelectionStart = 0
            Me.dtpRscDateFrom.Size = New System.Drawing.Size(115, 20)
            Me.dtpRscDateFrom.TabIndex = 0
            Me.dtpRscDateFrom.TabStop = False
            Me.dtpRscDateFrom.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpRscDateFrom.TextAlign = 0
            Me.dtpRscDateFrom.TextValue = ""
            Me.dtpRscDateFrom.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(29, 25)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(82, 15)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "조사일자"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popRscCompanyCd
            '
            Me.popRscCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popRscCompanyCd.BorderStyle = 2
            Me.popRscCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popRscCompanyCd.CaptionName = "확장처코드"
            Me.popRscCompanyCd.CodeText = ""
            Me.popRscCompanyCd.CodeWidth = 90
            Me.popRscCompanyCd.Location = New System.Drawing.Point(466, 23)
            Me.popRscCompanyCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popRscCompanyCd.MaxLength = 13
            Me.popRscCompanyCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popRscCompanyCd.Name = "popRscCompanyCd"
            Me.popRscCompanyCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popRscCompanyCd.NameText = ""
            Me.popRscCompanyCd.ReadOnlys = False
            Me.popRscCompanyCd.SelectedText = ""
            Me.popRscCompanyCd.SelectionLength = 0
            Me.popRscCompanyCd.SelectionStart = 0
            Me.popRscCompanyCd.Size = New System.Drawing.Size(296, 20)
            Me.popRscCompanyCd.TabIndex = 2
            Me.popRscCompanyCd.Tag = "code(확장처 명);"
            Me.popRscCompanyCd.TextAlign = 0
            Me.popRscCompanyCd.TextValue = ""
            Me.popRscCompanyCd.ToolTipText = ""
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label22.Location = New System.Drawing.Point(397, 22)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(63, 20)
            Me.Label22.TabIndex = 7
            Me.Label22.Text = "투입처"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpRscDateTo
            '
            Me.dtpRscDateTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpRscDateTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpRscDateTo.BorderStyle = 2
            Me.dtpRscDateTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpRscDateTo.CaptionName = "기준 일자 2"
            Me.dtpRscDateTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpRscDateTo.Location = New System.Drawing.Point(261, 23)
            Me.dtpRscDateTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpRscDateTo.MaxLength = 0
            Me.dtpRscDateTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpRscDateTo.Name = "dtpRscDateTo"
            Me.dtpRscDateTo.ReadOnlys = False
            Me.dtpRscDateTo.SelectedText = ""
            Me.dtpRscDateTo.SelectionLength = 0
            Me.dtpRscDateTo.SelectionStart = 0
            Me.dtpRscDateTo.Size = New System.Drawing.Size(115, 20)
            Me.dtpRscDateTo.TabIndex = 1
            Me.dtpRscDateTo.TabStop = False
            Me.dtpRscDateTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpRscDateTo.TextAlign = 0
            Me.dtpRscDateTo.TextValue = ""
            Me.dtpRscDateTo.ToolTipText = ""
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label14.Location = New System.Drawing.Point(238, 23)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(17, 20)
            Me.Label14.TabIndex = 6
            Me.Label14.Text = "~"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 82)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 561)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(29, 47)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 15)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "제목"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtRscTitle
            '
            Me.txtRscTitle.BackColor = System.Drawing.SystemColors.Window
            Me.txtRscTitle.BorderColor = System.Drawing.Color.Empty
            Me.txtRscTitle.BorderStyle = 2
            Me.txtRscTitle.CaptionName = Nothing
            Me.txtRscTitle.Location = New System.Drawing.Point(117, 47)
            Me.txtRscTitle.MaxLength = 32767
            Me.txtRscTitle.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRscTitle.Multiline = False
            Me.txtRscTitle.Name = "txtRscTitle"
            Me.txtRscTitle.ReadOnlys = False
            Me.txtRscTitle.SelectedText = ""
            Me.txtRscTitle.SelectionLength = 0
            Me.txtRscTitle.SelectionStart = 0
            Me.txtRscTitle.Size = New System.Drawing.Size(259, 20)
            Me.txtRscTitle.TabIndex = 3
            Me.txtRscTitle.Tag = Nothing
            Me.txtRscTitle.TextAlign = 0
            Me.txtRscTitle.TextValue = ""
            Me.txtRscTitle.ToolTipText = ""
            '
            'txtRscCompanyNm
            '
            Me.txtRscCompanyNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtRscCompanyNm.BorderColor = System.Drawing.Color.Empty
            Me.txtRscCompanyNm.BorderStyle = 2
            Me.txtRscCompanyNm.CaptionName = Nothing
            Me.txtRscCompanyNm.Location = New System.Drawing.Point(466, 47)
            Me.txtRscCompanyNm.MaxLength = 32767
            Me.txtRscCompanyNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRscCompanyNm.Multiline = False
            Me.txtRscCompanyNm.Name = "txtRscCompanyNm"
            Me.txtRscCompanyNm.ReadOnlys = False
            Me.txtRscCompanyNm.SelectedText = ""
            Me.txtRscCompanyNm.SelectionLength = 0
            Me.txtRscCompanyNm.SelectionStart = 0
            Me.txtRscCompanyNm.Size = New System.Drawing.Size(296, 20)
            Me.txtRscCompanyNm.TabIndex = 852
            Me.txtRscCompanyNm.Tag = Nothing
            Me.txtRscCompanyNm.TextAlign = 0
            Me.txtRscCompanyNm.TextValue = ""
            Me.txtRscCompanyNm.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(378, 47)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(82, 15)
            Me.Label2.TabIndex = 853
            Me.Label2.Text = "투입처 명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PND101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtRscCompanyNm)
            Me.Controls.Add(Me.txtRscTitle)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.dtpRscDateTo)
            Me.Controls.Add(Me.popRscCompanyCd)
            Me.Controls.Add(Me.Label22)
            Me.Controls.Add(Me.dtpRscDateFrom)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PND101"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.dtpRscDateFrom, 0)
            Me.Controls.SetChildIndex(Me.Label22, 0)
            Me.Controls.SetChildIndex(Me.popRscCompanyCd, 0)
            Me.Controls.SetChildIndex(Me.dtpRscDateTo, 0)
            Me.Controls.SetChildIndex(Me.Label14, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.txtRscTitle, 0)
            Me.Controls.SetChildIndex(Me.txtRscCompanyNm, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents dtpRscDateFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents popRscCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents dtpRscDateTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtRscTitle As ubiLease.CommonControls.txt
        Friend WithEvents txtRscCompanyNm As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label


    End Class

End Namespace
