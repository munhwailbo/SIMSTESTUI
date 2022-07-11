Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PND201
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PND201))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.dtpMtDateFrom = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label14 = New System.Windows.Forms.Label
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.dtpMtDate = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.dtpMtDateTo = New ubiLease.CommonControls.dtp
            Me.Label11 = New System.Windows.Forms.Label
            Me.txtMtDesc_2 = New ubiLease.CommonControls.txt
            Me.txtMtOrders = New ubiLease.CommonControls.txt
            Me.txtLastContents = New System.Windows.Forms.TextBox
            Me.TxtMtDesc = New System.Windows.Forms.TextBox
            Me.txtThisContents = New System.Windows.Forms.TextBox
            Me.txtThisIssue = New System.Windows.Forms.TextBox
            Me.txtRemark = New System.Windows.Forms.TextBox
            Me.TxtPKey = New ubiLease.CommonControls.txt
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("±¼¸²", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 78)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 219)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 852
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(6, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(799, 67)
            Me.picCriteria.TabIndex = 851
            Me.picCriteria.TabStop = False
            '
            'dtpMtDateFrom
            '
            Me.dtpMtDateFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpMtDateFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpMtDateFrom.BorderStyle = 2
            Me.dtpMtDateFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpMtDateFrom.CaptionName = "°èÈ¹ ³â"
            Me.dtpMtDateFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpMtDateFrom.Location = New System.Drawing.Point(106, 12)
            Me.dtpMtDateFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpMtDateFrom.MaxLength = 0
            Me.dtpMtDateFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpMtDateFrom.Name = "dtpMtDateFrom"
            Me.dtpMtDateFrom.ReadOnlys = False
            Me.dtpMtDateFrom.SelectedText = ""
            Me.dtpMtDateFrom.SelectionLength = 0
            Me.dtpMtDateFrom.SelectionStart = 0
            Me.dtpMtDateFrom.Size = New System.Drawing.Size(115, 20)
            Me.dtpMtDateFrom.TabIndex = 858
            Me.dtpMtDateFrom.TabStop = False
            Me.dtpMtDateFrom.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpMtDateFrom.TextAlign = 0
            Me.dtpMtDateFrom.TextValue = ""
            Me.dtpMtDateFrom.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(18, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(82, 15)
            Me.Label3.TabIndex = 857
            Me.Label3.Text = "È¸ÀÇÀÏÀÚ"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label14.Location = New System.Drawing.Point(18, 43)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(82, 12)
            Me.Label14.TabIndex = 1017
            Me.Label14.Text = "°³¿ä"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(6, 303)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(799, 396)
            Me.picIo_2.TabIndex = 1052
            Me.picIo_2.TabStop = False
            '
            'Label8
            '
            Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Font = New System.Drawing.Font("±¼¸²", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label8.Location = New System.Drawing.Point(17, 311)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(60, 20)
            Me.Label8.TabIndex = 1155
            Me.Label8.Text = "È¸ÀÇÂ÷¼ö"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label9
            '
            Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Font = New System.Drawing.Font("±¼¸²", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label9.Location = New System.Drawing.Point(229, 312)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(60, 20)
            Me.Label9.TabIndex = 1169
            Me.Label9.Text = "°³¿ä"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Font = New System.Drawing.Font("±¼¸²", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label2.Location = New System.Drawing.Point(17, 355)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 20)
            Me.Label2.TabIndex = 1181
            Me.Label2.Text = "Áö³­³»¿ë"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Font = New System.Drawing.Font("±¼¸²", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label4.Location = New System.Drawing.Point(17, 587)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(60, 14)
            Me.Label4.TabIndex = 1184
            Me.Label4.Text = "ÀÌ½´"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpMtDate
            '
            Me.dtpMtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpMtDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpMtDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpMtDate.BorderStyle = 2
            Me.dtpMtDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpMtDate.CaptionName = "°èÈ¹ ³â"
            Me.dtpMtDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpMtDate.Location = New System.Drawing.Point(83, 332)
            Me.dtpMtDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpMtDate.MaxLength = 0
            Me.dtpMtDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpMtDate.Name = "dtpMtDate"
            Me.dtpMtDate.ReadOnlys = False
            Me.dtpMtDate.SelectedText = ""
            Me.dtpMtDate.SelectionLength = 0
            Me.dtpMtDate.SelectionStart = 0
            Me.dtpMtDate.Size = New System.Drawing.Size(115, 20)
            Me.dtpMtDate.TabIndex = 1187
            Me.dtpMtDate.TabStop = False
            Me.dtpMtDate.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpMtDate.TextAlign = 0
            Me.dtpMtDate.TextValue = ""
            Me.dtpMtDate.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Font = New System.Drawing.Font("±¼¸²", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label6.Location = New System.Drawing.Point(17, 335)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(60, 15)
            Me.Label6.TabIndex = 1186
            Me.Label6.Text = "È¸ÀÇÀÏÀÚ"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label7
            '
            Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Font = New System.Drawing.Font("±¼¸²", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label7.Location = New System.Drawing.Point(483, 587)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(70, 14)
            Me.Label7.TabIndex = 1188
            Me.Label7.Text = "±âÅ¸"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label10
            '
            Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label10.Font = New System.Drawing.Font("±¼¸²", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label10.Location = New System.Drawing.Point(483, 355)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(70, 20)
            Me.Label10.TabIndex = 1191
            Me.Label10.Text = "È¸ÀÇ¾È°Ç"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpMtDateTo
            '
            Me.dtpMtDateTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpMtDateTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpMtDateTo.BorderStyle = 2
            Me.dtpMtDateTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpMtDateTo.CaptionName = "°èÈ¹ ³â"
            Me.dtpMtDateTo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpMtDateTo.Location = New System.Drawing.Point(289, 12)
            Me.dtpMtDateTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpMtDateTo.MaxLength = 0
            Me.dtpMtDateTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpMtDateTo.Name = "dtpMtDateTo"
            Me.dtpMtDateTo.ReadOnlys = False
            Me.dtpMtDateTo.SelectedText = ""
            Me.dtpMtDateTo.SelectionLength = 0
            Me.dtpMtDateTo.SelectionStart = 0
            Me.dtpMtDateTo.Size = New System.Drawing.Size(115, 20)
            Me.dtpMtDateTo.TabIndex = 1193
            Me.dtpMtDateTo.TabStop = False
            Me.dtpMtDateTo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpMtDateTo.TextAlign = 0
            Me.dtpMtDateTo.TextValue = ""
            Me.dtpMtDateTo.ToolTipText = ""
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(238, 15)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(23, 15)
            Me.Label11.TabIndex = 1194
            Me.Label11.Text = "~"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtMtDesc_2
            '
            Me.txtMtDesc_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtMtDesc_2.BorderColor = System.Drawing.Color.Empty
            Me.txtMtDesc_2.BorderStyle = 2
            Me.txtMtDesc_2.CaptionName = Nothing
            Me.txtMtDesc_2.Location = New System.Drawing.Point(106, 38)
            Me.txtMtDesc_2.MaxLength = 32767
            Me.txtMtDesc_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtMtDesc_2.Multiline = False
            Me.txtMtDesc_2.Name = "txtMtDesc_2"
            Me.txtMtDesc_2.ReadOnlys = False
            Me.txtMtDesc_2.SelectedText = ""
            Me.txtMtDesc_2.SelectionLength = 0
            Me.txtMtDesc_2.SelectionStart = 0
            Me.txtMtDesc_2.Size = New System.Drawing.Size(627, 20)
            Me.txtMtDesc_2.TabIndex = 1195
            Me.txtMtDesc_2.Tag = Nothing
            Me.txtMtDesc_2.TextAlign = 0
            Me.txtMtDesc_2.TextValue = ""
            Me.txtMtDesc_2.ToolTipText = ""
            '
            'txtMtOrders
            '
            Me.txtMtOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtMtOrders.BackColor = System.Drawing.SystemColors.Window
            Me.txtMtOrders.BorderColor = System.Drawing.Color.Empty
            Me.txtMtOrders.BorderStyle = 2
            Me.txtMtOrders.CaptionName = Nothing
            Me.txtMtOrders.Location = New System.Drawing.Point(83, 311)
            Me.txtMtOrders.MaxLength = 32767
            Me.txtMtOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtMtOrders.Multiline = False
            Me.txtMtOrders.Name = "txtMtOrders"
            Me.txtMtOrders.ReadOnlys = False
            Me.txtMtOrders.SelectedText = ""
            Me.txtMtOrders.SelectionLength = 0
            Me.txtMtOrders.SelectionStart = 0
            Me.txtMtOrders.Size = New System.Drawing.Size(89, 20)
            Me.txtMtOrders.TabIndex = 1196
            Me.txtMtOrders.Tag = Nothing
            Me.txtMtOrders.TextAlign = 0
            Me.txtMtOrders.TextValue = ""
            Me.txtMtOrders.ToolTipText = ""
            '
            'txtLastContents
            '
            Me.txtLastContents.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtLastContents.Location = New System.Drawing.Point(20, 378)
            Me.txtLastContents.Multiline = True
            Me.txtLastContents.Name = "txtLastContents"
            Me.txtLastContents.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtLastContents.Size = New System.Drawing.Size(457, 201)
            Me.txtLastContents.TabIndex = 1205
            '
            'TxtMtDesc
            '
            Me.TxtMtDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtMtDesc.Location = New System.Drawing.Point(289, 312)
            Me.TxtMtDesc.Multiline = True
            Me.TxtMtDesc.Name = "TxtMtDesc"
            Me.TxtMtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.TxtMtDesc.Size = New System.Drawing.Size(503, 34)
            Me.TxtMtDesc.TabIndex = 1206
            '
            'txtThisContents
            '
            Me.txtThisContents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtThisContents.Location = New System.Drawing.Point(483, 378)
            Me.txtThisContents.Multiline = True
            Me.txtThisContents.Name = "txtThisContents"
            Me.txtThisContents.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtThisContents.Size = New System.Drawing.Size(309, 201)
            Me.txtThisContents.TabIndex = 1207
            '
            'txtThisIssue
            '
            Me.txtThisIssue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtThisIssue.Location = New System.Drawing.Point(20, 605)
            Me.txtThisIssue.Multiline = True
            Me.txtThisIssue.Name = "txtThisIssue"
            Me.txtThisIssue.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtThisIssue.Size = New System.Drawing.Size(457, 85)
            Me.txtThisIssue.TabIndex = 1208
            '
            'txtRemark
            '
            Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtRemark.Location = New System.Drawing.Point(483, 605)
            Me.txtRemark.Multiline = True
            Me.txtRemark.Name = "txtRemark"
            Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtRemark.Size = New System.Drawing.Size(309, 85)
            Me.txtRemark.TabIndex = 1209
            '
            'TxtPKey
            '
            Me.TxtPKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TxtPKey.BackColor = System.Drawing.SystemColors.Window
            Me.TxtPKey.BorderColor = System.Drawing.Color.Empty
            Me.TxtPKey.BorderStyle = 2
            Me.TxtPKey.CaptionName = Nothing
            Me.TxtPKey.Location = New System.Drawing.Point(178, 311)
            Me.TxtPKey.MaxLength = 32767
            Me.TxtPKey.MinimumSize = New System.Drawing.Size(20, 20)
            Me.TxtPKey.Multiline = False
            Me.TxtPKey.Name = "TxtPKey"
            Me.TxtPKey.ReadOnlys = False
            Me.TxtPKey.SelectedText = ""
            Me.TxtPKey.SelectionLength = 0
            Me.TxtPKey.SelectionStart = 0
            Me.TxtPKey.Size = New System.Drawing.Size(39, 20)
            Me.TxtPKey.TabIndex = 1210
            Me.TxtPKey.Tag = Nothing
            Me.TxtPKey.TextAlign = 0
            Me.TxtPKey.TextValue = ""
            Me.TxtPKey.ToolTipText = ""
            Me.TxtPKey.Visible = False
            '
            'PND201
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.TxtPKey)
            Me.Controls.Add(Me.txtRemark)
            Me.Controls.Add(Me.txtThisIssue)
            Me.Controls.Add(Me.txtThisContents)
            Me.Controls.Add(Me.TxtMtDesc)
            Me.Controls.Add(Me.txtLastContents)
            Me.Controls.Add(Me.txtMtOrders)
            Me.Controls.Add(Me.txtMtDesc_2)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.dtpMtDateTo)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.dtpMtDate)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.dtpMtDateFrom)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.picIo_2)
            Me.Name = "PND201"
            Me.Size = New System.Drawing.Size(811, 702)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents dtpMtDateFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dtpMtDate As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents dtpMtDateTo As ubiLease.CommonControls.dtp
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtMtDesc_2 As ubiLease.CommonControls.txt
        Friend WithEvents txtMtOrders As ubiLease.CommonControls.txt
        Friend WithEvents txtLastContents As System.Windows.Forms.TextBox
        Friend WithEvents TxtMtDesc As System.Windows.Forms.TextBox
        Friend WithEvents txtThisContents As System.Windows.Forms.TextBox
        Friend WithEvents txtThisIssue As System.Windows.Forms.TextBox
        Friend WithEvents txtRemark As System.Windows.Forms.TextBox
        Friend WithEvents TxtPKey As ubiLease.CommonControls.txt


    End Class

End Namespace
