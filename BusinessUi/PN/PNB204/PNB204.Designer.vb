Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNB204
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNB204))
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpContractDtTo = New ubiLease.CommonControls.dtp
            Me.btnApprovalAll = New System.Windows.Forms.Button
            Me.lbl = New System.Windows.Forms.Label
            Me.dtpContractDtFrom = New ubiLease.CommonControls.dtp
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optAll = New System.Windows.Forms.RadioButton
            Me.optNotApproval = New System.Windows.Forms.RadioButton
            Me.optApproval = New System.Windows.Forms.RadioButton
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(229, 22)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(20, 15)
            Me.Label2.TabIndex = 813
            Me.Label2.Text = "~"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpContractDtTo
            '
            Me.dtpContractDtTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpContractDtTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpContractDtTo.BorderStyle = 2
            Me.dtpContractDtTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpContractDtTo.CaptionName = "±‚¡ÿ ≥‚"
            Me.dtpContractDtTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpContractDtTo.Location = New System.Drawing.Point(255, 17)
            Me.dtpContractDtTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpContractDtTo.MaxLength = 0
            Me.dtpContractDtTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpContractDtTo.Name = "dtpContractDtTo"
            Me.dtpContractDtTo.ReadOnlys = False
            Me.dtpContractDtTo.SelectedText = ""
            Me.dtpContractDtTo.SelectionLength = 0
            Me.dtpContractDtTo.SelectionStart = 0
            Me.dtpContractDtTo.Size = New System.Drawing.Size(100, 20)
            Me.dtpContractDtTo.TabIndex = 812
            Me.dtpContractDtTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpContractDtTo.TextAlign = 0
            Me.dtpContractDtTo.TextValue = ""
            Me.dtpContractDtTo.ToolTipText = ""
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.Location = New System.Drawing.Point(676, 16)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(100, 25)
            Me.btnApprovalAll.TabIndex = 811
            Me.btnApprovalAll.Text = "¿œ∞˝ Ω¬¿Œ"
            Me.btnApprovalAll.UseVisualStyleBackColor = False
            '
            'lbl
            '
            Me.lbl.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lbl.Location = New System.Drawing.Point(55, 22)
            Me.lbl.Name = "lbl"
            Me.lbl.Size = New System.Drawing.Size(62, 15)
            Me.lbl.TabIndex = 810
            Me.lbl.Text = "∞Ëæ‡ ¿œ¿⁄"
            Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpContractDtFrom
            '
            Me.dtpContractDtFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpContractDtFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpContractDtFrom.BorderStyle = 2
            Me.dtpContractDtFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpContractDtFrom.CaptionName = "±‚¡ÿ ≥‚"
            Me.dtpContractDtFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpContractDtFrom.Location = New System.Drawing.Point(123, 17)
            Me.dtpContractDtFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpContractDtFrom.MaxLength = 0
            Me.dtpContractDtFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpContractDtFrom.Name = "dtpContractDtFrom"
            Me.dtpContractDtFrom.ReadOnlys = False
            Me.dtpContractDtFrom.SelectedText = ""
            Me.dtpContractDtFrom.SelectionLength = 0
            Me.dtpContractDtFrom.SelectionStart = 0
            Me.dtpContractDtFrom.Size = New System.Drawing.Size(100, 20)
            Me.dtpContractDtFrom.TabIndex = 809
            Me.dtpContractDtFrom.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpContractDtFrom.TextAlign = 0
            Me.dtpContractDtFrom.TextValue = ""
            Me.dtpContractDtFrom.ToolTipText = ""
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
            Me.grd_1.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("±º∏≤", 9.75!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 56)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(800, 418)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 807
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(6, 6)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(800, 45)
            Me.picCriteria.TabIndex = 808
            Me.picCriteria.TabStop = False
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optAll)
            Me.Opt2.Controls.Add(Me.optNotApproval)
            Me.Opt2.Controls.Add(Me.optApproval)
            Me.Opt2.Location = New System.Drawing.Point(377, 15)
            Me.Opt2.MaximumSize = New System.Drawing.Size(500, 50)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(192, 28)
            Me.Opt2.TabIndex = 814
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optAll
            '
            Me.optAll.AutoSize = True
            Me.optAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optAll.Location = New System.Drawing.Point(129, 5)
            Me.optAll.Name = "optAll"
            Me.optAll.Size = New System.Drawing.Size(47, 16)
            Me.optAll.TabIndex = 344
            Me.optAll.Text = "¿¸√º"
            Me.optAll.UseVisualStyleBackColor = False
            '
            'optNotApproval
            '
            Me.optNotApproval.AutoSize = True
            Me.optNotApproval.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optNotApproval.Checked = True
            Me.optNotApproval.Location = New System.Drawing.Point(11, 5)
            Me.optNotApproval.Name = "optNotApproval"
            Me.optNotApproval.Size = New System.Drawing.Size(59, 16)
            Me.optNotApproval.TabIndex = 342
            Me.optNotApproval.TabStop = True
            Me.optNotApproval.Text = "πÃΩ¬¿Œ"
            Me.optNotApproval.UseVisualStyleBackColor = False
            '
            'optApproval
            '
            Me.optApproval.AutoSize = True
            Me.optApproval.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optApproval.Location = New System.Drawing.Point(76, 5)
            Me.optApproval.Name = "optApproval"
            Me.optApproval.Size = New System.Drawing.Size(47, 16)
            Me.optApproval.TabIndex = 343
            Me.optApproval.Text = "Ω¬¿Œ"
            Me.optApproval.UseVisualStyleBackColor = False
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_2.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_2.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_2.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("±º∏≤", 9.75!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(6, 496)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 15
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(800, 148)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 815
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(4, 479)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 15)
            Me.Label1.TabIndex = 816
            Me.Label1.Text = "∆Û±π «ˆ»≤"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNB204
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpContractDtTo)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.lbl)
            Me.Controls.Add(Me.dtpContractDtFrom)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNB204"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpContractDtTo As ubiLease.CommonControls.dtp
        Friend WithEvents btnApprovalAll As System.Windows.Forms.Button
        Friend WithEvents lbl As System.Windows.Forms.Label
        Friend WithEvents dtpContractDtFrom As ubiLease.CommonControls.dtp
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optAll As System.Windows.Forms.RadioButton
        Friend WithEvents optNotApproval As System.Windows.Forms.RadioButton
        Friend WithEvents optApproval As System.Windows.Forms.RadioButton
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label


    End Class

End Namespace
