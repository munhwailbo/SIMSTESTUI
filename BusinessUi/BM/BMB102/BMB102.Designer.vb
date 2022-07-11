Namespace ubiLease.UI.BusinessUi.BM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class BMB102
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMB102))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.dtpMutualYearMonthFrom = New ubiLease.CommonControls.dtp
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpMutualYearMonthTo = New ubiLease.CommonControls.dtp
            Me.popBranchChiefCd = New ubiLease.CommonControls.pop
            Me.lblCodeDivision = New System.Windows.Forms.Label
            Me.chkPaymentPerson = New ubiLease.CommonControls.chk
            Me.chkPersonInArrears = New ubiLease.CommonControls.chk
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
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 46)
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
            Me.grd_1.Font = New System.Drawing.Font("±¼¸²", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 57)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 582)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpMutualYearMonthFrom
            '
            Me.dtpMutualYearMonthFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpMutualYearMonthFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpMutualYearMonthFrom.BorderStyle = 2
            Me.dtpMutualYearMonthFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpMutualYearMonthFrom.CaptionName = "°øÁ¦ ³â¿ùFrom"
            Me.dtpMutualYearMonthFrom.DateTimeFormatText = "yyyy-MM"
            Me.dtpMutualYearMonthFrom.Font = New System.Drawing.Font("±¼¸²", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpMutualYearMonthFrom.Location = New System.Drawing.Point(84, 18)
            Me.dtpMutualYearMonthFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpMutualYearMonthFrom.MaxLength = 0
            Me.dtpMutualYearMonthFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpMutualYearMonthFrom.Name = "dtpMutualYearMonthFrom"
            Me.dtpMutualYearMonthFrom.ReadOnlys = False
            Me.dtpMutualYearMonthFrom.SelectedText = ""
            Me.dtpMutualYearMonthFrom.SelectionLength = 0
            Me.dtpMutualYearMonthFrom.SelectionStart = 0
            Me.dtpMutualYearMonthFrom.Size = New System.Drawing.Size(92, 20)
            Me.dtpMutualYearMonthFrom.TabIndex = 1675
            Me.dtpMutualYearMonthFrom.Tag = "need;format(####-##);"
            Me.dtpMutualYearMonthFrom.TextAlign = 0
            Me.dtpMutualYearMonthFrom.TextValue = ""
            Me.dtpMutualYearMonthFrom.ToolTipText = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.GhostWhite
            Me.Label7.Font = New System.Drawing.Font("±¼¸²Ã¼", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label7.Location = New System.Drawing.Point(22, 21)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(57, 15)
            Me.Label7.TabIndex = 1676
            Me.Label7.Text = "³³ºÎ³â¿ù"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Font = New System.Drawing.Font("±¼¸²Ã¼", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(182, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(17, 16)
            Me.Label1.TabIndex = 1677
            Me.Label1.Text = "~"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpMutualYearMonthTo
            '
            Me.dtpMutualYearMonthTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpMutualYearMonthTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpMutualYearMonthTo.BorderStyle = 2
            Me.dtpMutualYearMonthTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpMutualYearMonthTo.CaptionName = "°øÁ¦ ³â¿ùFrom"
            Me.dtpMutualYearMonthTo.DateTimeFormatText = "yyyy-MM"
            Me.dtpMutualYearMonthTo.Font = New System.Drawing.Font("±¼¸²", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpMutualYearMonthTo.Location = New System.Drawing.Point(205, 18)
            Me.dtpMutualYearMonthTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpMutualYearMonthTo.MaxLength = 0
            Me.dtpMutualYearMonthTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpMutualYearMonthTo.Name = "dtpMutualYearMonthTo"
            Me.dtpMutualYearMonthTo.ReadOnlys = False
            Me.dtpMutualYearMonthTo.SelectedText = ""
            Me.dtpMutualYearMonthTo.SelectionLength = 0
            Me.dtpMutualYearMonthTo.SelectionStart = 0
            Me.dtpMutualYearMonthTo.Size = New System.Drawing.Size(92, 20)
            Me.dtpMutualYearMonthTo.TabIndex = 1678
            Me.dtpMutualYearMonthTo.Tag = "need;format(####-##);"
            Me.dtpMutualYearMonthTo.TextAlign = 0
            Me.dtpMutualYearMonthTo.TextValue = ""
            Me.dtpMutualYearMonthTo.ToolTipText = ""
            '
            'popBranchChiefCd
            '
            Me.popBranchChiefCd.BorderColor = System.Drawing.Color.Empty
            Me.popBranchChiefCd.BorderStyle = 2
            Me.popBranchChiefCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchChiefCd.CaptionName = "Áö±¹Àå ÄÚµå"
            Me.popBranchChiefCd.CodeText = ""
            Me.popBranchChiefCd.CodeWidth = 50
            Me.popBranchChiefCd.Location = New System.Drawing.Point(352, 18)
            Me.popBranchChiefCd.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popBranchChiefCd.MaxLength = 10
            Me.popBranchChiefCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchChiefCd.Name = "popBranchChiefCd"
            Me.popBranchChiefCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchChiefCd.NameText = ""
            Me.popBranchChiefCd.ReadOnlys = False
            Me.popBranchChiefCd.SelectedText = ""
            Me.popBranchChiefCd.SelectionLength = 0
            Me.popBranchChiefCd.SelectionStart = 0
            Me.popBranchChiefCd.Size = New System.Drawing.Size(182, 20)
            Me.popBranchChiefCd.TabIndex = 1680
            Me.popBranchChiefCd.Tag = "code(Áö±¹Àå ¸í);"
            Me.popBranchChiefCd.TextAlign = 0
            Me.popBranchChiefCd.TextValue = ""
            Me.popBranchChiefCd.ToolTipText = ""
            '
            'lblCodeDivision
            '
            Me.lblCodeDivision.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivision.Location = New System.Drawing.Point(303, 20)
            Me.lblCodeDivision.Name = "lblCodeDivision"
            Me.lblCodeDivision.Size = New System.Drawing.Size(43, 17)
            Me.lblCodeDivision.TabIndex = 1679
            Me.lblCodeDivision.Text = "Áö±¹Àå"
            Me.lblCodeDivision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'chkPaymentPerson
            '
            Me.chkPaymentPerson.BackColor = System.Drawing.Color.GhostWhite
            Me.chkPaymentPerson.CaptionName = "³³ºÎÀÚ"
            Me.chkPaymentPerson.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkPaymentPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkPaymentPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkPaymentPerson.Font = New System.Drawing.Font("±¼¸²Ã¼", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkPaymentPerson.Location = New System.Drawing.Point(540, 20)
            Me.chkPaymentPerson.Name = "chkPaymentPerson"
            Me.chkPaymentPerson.ReadOnlys = False
            Me.chkPaymentPerson.Size = New System.Drawing.Size(60, 17)
            Me.chkPaymentPerson.TabIndex = 1681
            Me.chkPaymentPerson.Tag = ""
            Me.chkPaymentPerson.Text = "³³ºÎÀÚ"
            Me.chkPaymentPerson.TextValue = "0"
            Me.chkPaymentPerson.UseVisualStyleBackColor = False
            '
            'chkPersonInArrears
            '
            Me.chkPersonInArrears.AutoSize = True
            Me.chkPersonInArrears.BackColor = System.Drawing.Color.GhostWhite
            Me.chkPersonInArrears.CaptionName = "¹Ì³³ÀÚ"
            Me.chkPersonInArrears.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkPersonInArrears.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkPersonInArrears.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkPersonInArrears.Font = New System.Drawing.Font("±¼¸²Ã¼", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkPersonInArrears.Location = New System.Drawing.Point(606, 20)
            Me.chkPersonInArrears.Name = "chkPersonInArrears"
            Me.chkPersonInArrears.ReadOnlys = False
            Me.chkPersonInArrears.Size = New System.Drawing.Size(60, 16)
            Me.chkPersonInArrears.TabIndex = 1682
            Me.chkPersonInArrears.Tag = ""
            Me.chkPersonInArrears.Text = "¹Ì³³ÀÚ"
            Me.chkPersonInArrears.TextValue = "0"
            Me.chkPersonInArrears.UseVisualStyleBackColor = False
            '
            'BMB102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.chkPersonInArrears)
            Me.Controls.Add(Me.chkPaymentPerson)
            Me.Controls.Add(Me.popBranchChiefCd)
            Me.Controls.Add(Me.lblCodeDivision)
            Me.Controls.Add(Me.dtpMutualYearMonthTo)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpMutualYearMonthFrom)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "BMB102"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.dtpMutualYearMonthFrom, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.dtpMutualYearMonthTo, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivision, 0)
            Me.Controls.SetChildIndex(Me.popBranchChiefCd, 0)
            Me.Controls.SetChildIndex(Me.chkPaymentPerson, 0)
            Me.Controls.SetChildIndex(Me.chkPersonInArrears, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents dtpMutualYearMonthFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpMutualYearMonthTo As ubiLease.CommonControls.dtp
        Friend WithEvents popBranchChiefCd As ubiLease.CommonControls.pop
        Friend WithEvents lblCodeDivision As System.Windows.Forms.Label
        Friend WithEvents chkPaymentPerson As ubiLease.CommonControls.chk
        Friend WithEvents chkPersonInArrears As ubiLease.CommonControls.chk

    End Class

End Namespace
