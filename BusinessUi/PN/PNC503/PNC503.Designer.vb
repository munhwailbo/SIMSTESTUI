Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNC503
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNC503))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.txtCALLBACK = New ubiLease.CommonControls.txt
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtName = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            Me.TxtDEST_NAME = New ubiLease.CommonControls.txt
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtPHONE_NUMBER = New ubiLease.CommonControls.txt
            Me.Label4 = New System.Windows.Forms.Label
            Me.dtpSEND_DATEFrom = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpSEND_DATETo = New ubiLease.CommonControls.dtp
            Me.Label5 = New System.Windows.Forms.Label
            Me.popTrAdEmployeeDeptCd = New ubiLease.CommonControls.pop
            Me.Label7 = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.Location = New System.Drawing.Point(3, 92)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 508)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(805, 83)
            Me.picCriteria.TabIndex = 8
            Me.picCriteria.TabStop = False
            '
            'txtCALLBACK
            '
            Me.txtCALLBACK.BackColor = System.Drawing.SystemColors.Window
            Me.txtCALLBACK.BorderColor = System.Drawing.Color.Empty
            Me.txtCALLBACK.BorderStyle = 2
            Me.txtCALLBACK.CaptionName = "전화번호1"
            Me.txtCALLBACK.Location = New System.Drawing.Point(628, 18)
            Me.txtCALLBACK.MaxLength = 14
            Me.txtCALLBACK.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCALLBACK.Multiline = False
            Me.txtCALLBACK.Name = "txtCALLBACK"
            Me.txtCALLBACK.ReadOnlys = False
            Me.txtCALLBACK.SelectedText = ""
            Me.txtCALLBACK.SelectionLength = 0
            Me.txtCALLBACK.SelectionStart = 0
            Me.txtCALLBACK.Size = New System.Drawing.Size(150, 20)
            Me.txtCALLBACK.TabIndex = 1542
            Me.txtCALLBACK.Tag = ""
            Me.txtCALLBACK.TextAlign = 0
            Me.txtCALLBACK.TextValue = ""
            Me.txtCALLBACK.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(557, 21)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 15)
            Me.Label2.TabIndex = 1547
            Me.Label2.Text = "발송번호"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtName
            '
            Me.txtName.BackColor = System.Drawing.SystemColors.Window
            Me.txtName.BorderColor = System.Drawing.Color.Empty
            Me.txtName.BorderStyle = 2
            Me.txtName.CaptionName = Nothing
            Me.txtName.Location = New System.Drawing.Point(395, 18)
            Me.txtName.MaxLength = 32767
            Me.txtName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtName.Multiline = False
            Me.txtName.Name = "txtName"
            Me.txtName.ReadOnlys = False
            Me.txtName.SelectedText = ""
            Me.txtName.SelectionLength = 0
            Me.txtName.SelectionStart = 0
            Me.txtName.Size = New System.Drawing.Size(152, 20)
            Me.txtName.TabIndex = 1541
            Me.txtName.Tag = Nothing
            Me.txtName.TextAlign = 0
            Me.txtName.TextValue = ""
            Me.txtName.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(329, 21)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(61, 15)
            Me.Label3.TabIndex = 1546
            Me.Label3.Text = "발송자명"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtDEST_NAME
            '
            Me.TxtDEST_NAME.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDEST_NAME.BorderColor = System.Drawing.Color.Empty
            Me.TxtDEST_NAME.BorderStyle = 2
            Me.TxtDEST_NAME.CaptionName = Nothing
            Me.TxtDEST_NAME.Location = New System.Drawing.Point(395, 47)
            Me.TxtDEST_NAME.MaxLength = 32767
            Me.TxtDEST_NAME.MinimumSize = New System.Drawing.Size(20, 20)
            Me.TxtDEST_NAME.Multiline = False
            Me.TxtDEST_NAME.Name = "TxtDEST_NAME"
            Me.TxtDEST_NAME.ReadOnlys = False
            Me.TxtDEST_NAME.SelectedText = ""
            Me.TxtDEST_NAME.SelectionLength = 0
            Me.TxtDEST_NAME.SelectionStart = 0
            Me.TxtDEST_NAME.Size = New System.Drawing.Size(152, 20)
            Me.TxtDEST_NAME.TabIndex = 1548
            Me.TxtDEST_NAME.Tag = Nothing
            Me.TxtDEST_NAME.TextAlign = 0
            Me.TxtDEST_NAME.TextValue = ""
            Me.TxtDEST_NAME.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(329, 50)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(61, 15)
            Me.Label1.TabIndex = 1549
            Me.Label1.Text = "수신자명"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPHONE_NUMBER
            '
            Me.txtPHONE_NUMBER.BackColor = System.Drawing.SystemColors.Window
            Me.txtPHONE_NUMBER.BorderColor = System.Drawing.Color.Empty
            Me.txtPHONE_NUMBER.BorderStyle = 2
            Me.txtPHONE_NUMBER.CaptionName = "전화번호1"
            Me.txtPHONE_NUMBER.Location = New System.Drawing.Point(628, 47)
            Me.txtPHONE_NUMBER.MaxLength = 14
            Me.txtPHONE_NUMBER.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPHONE_NUMBER.Multiline = False
            Me.txtPHONE_NUMBER.Name = "txtPHONE_NUMBER"
            Me.txtPHONE_NUMBER.ReadOnlys = False
            Me.txtPHONE_NUMBER.SelectedText = ""
            Me.txtPHONE_NUMBER.SelectionLength = 0
            Me.txtPHONE_NUMBER.SelectionStart = 0
            Me.txtPHONE_NUMBER.Size = New System.Drawing.Size(150, 20)
            Me.txtPHONE_NUMBER.TabIndex = 1550
            Me.txtPHONE_NUMBER.Tag = ""
            Me.txtPHONE_NUMBER.TextAlign = 0
            Me.txtPHONE_NUMBER.TextValue = ""
            Me.txtPHONE_NUMBER.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(557, 50)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(65, 15)
            Me.Label4.TabIndex = 1551
            Me.Label4.Text = "수신번호"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpSEND_DATEFrom
            '
            Me.dtpSEND_DATEFrom.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSEND_DATEFrom.BorderColor = System.Drawing.Color.Empty
            Me.dtpSEND_DATEFrom.BorderStyle = 2
            Me.dtpSEND_DATEFrom.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSEND_DATEFrom.CaptionName = "접수 일자"
            Me.dtpSEND_DATEFrom.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSEND_DATEFrom.Location = New System.Drawing.Point(97, 16)
            Me.dtpSEND_DATEFrom.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSEND_DATEFrom.MaxLength = 0
            Me.dtpSEND_DATEFrom.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSEND_DATEFrom.Name = "dtpSEND_DATEFrom"
            Me.dtpSEND_DATEFrom.ReadOnlys = False
            Me.dtpSEND_DATEFrom.SelectedText = ""
            Me.dtpSEND_DATEFrom.SelectionLength = 0
            Me.dtpSEND_DATEFrom.SelectionStart = 0
            Me.dtpSEND_DATEFrom.Size = New System.Drawing.Size(93, 20)
            Me.dtpSEND_DATEFrom.TabIndex = 1552
            Me.dtpSEND_DATEFrom.Tag = "need;format(####-##-##);"
            Me.dtpSEND_DATEFrom.TextAlign = 0
            Me.dtpSEND_DATEFrom.TextValue = ""
            Me.dtpSEND_DATEFrom.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(187, 19)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 15)
            Me.Label6.TabIndex = 1554
            Me.Label6.Text = "~"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpSEND_DATETo
            '
            Me.dtpSEND_DATETo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSEND_DATETo.BorderColor = System.Drawing.Color.Empty
            Me.dtpSEND_DATETo.BorderStyle = 2
            Me.dtpSEND_DATETo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSEND_DATETo.CaptionName = "접수 일자 2"
            Me.dtpSEND_DATETo.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSEND_DATETo.Location = New System.Drawing.Point(208, 16)
            Me.dtpSEND_DATETo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSEND_DATETo.MaxLength = 0
            Me.dtpSEND_DATETo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSEND_DATETo.Name = "dtpSEND_DATETo"
            Me.dtpSEND_DATETo.ReadOnlys = False
            Me.dtpSEND_DATETo.SelectedText = ""
            Me.dtpSEND_DATETo.SelectionLength = 0
            Me.dtpSEND_DATETo.SelectionStart = 0
            Me.dtpSEND_DATETo.Size = New System.Drawing.Size(93, 20)
            Me.dtpSEND_DATETo.TabIndex = 1553
            Me.dtpSEND_DATETo.Tag = "need;format(&&&&-&&-&&);"
            Me.dtpSEND_DATETo.TextAlign = 0
            Me.dtpSEND_DATETo.TextValue = ""
            Me.dtpSEND_DATETo.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(30, 19)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(61, 15)
            Me.Label5.TabIndex = 1555
            Me.Label5.Text = "발송일자"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popTrAdEmployeeDeptCd
            '
            Me.popTrAdEmployeeDeptCd.BorderColor = System.Drawing.Color.Empty
            Me.popTrAdEmployeeDeptCd.BorderStyle = 2
            Me.popTrAdEmployeeDeptCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popTrAdEmployeeDeptCd.CaptionName = "부서 명"
            Me.popTrAdEmployeeDeptCd.CodeText = ""
            Me.popTrAdEmployeeDeptCd.CodeWidth = 50
            Me.popTrAdEmployeeDeptCd.Location = New System.Drawing.Point(97, 46)
            Me.popTrAdEmployeeDeptCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popTrAdEmployeeDeptCd.MaxLength = 5
            Me.popTrAdEmployeeDeptCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popTrAdEmployeeDeptCd.Name = "popTrAdEmployeeDeptCd"
            Me.popTrAdEmployeeDeptCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popTrAdEmployeeDeptCd.NameText = ""
            Me.popTrAdEmployeeDeptCd.ReadOnlys = False
            Me.popTrAdEmployeeDeptCd.SelectedText = ""
            Me.popTrAdEmployeeDeptCd.SelectionLength = 0
            Me.popTrAdEmployeeDeptCd.SelectionStart = 0
            Me.popTrAdEmployeeDeptCd.Size = New System.Drawing.Size(204, 20)
            Me.popTrAdEmployeeDeptCd.TabIndex = 1556
            Me.popTrAdEmployeeDeptCd.Tag = "code(부서 명);"
            Me.popTrAdEmployeeDeptCd.TextAlign = 0
            Me.popTrAdEmployeeDeptCd.TextValue = ""
            Me.popTrAdEmployeeDeptCd.ToolTipText = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(32, 47)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(59, 18)
            Me.Label7.TabIndex = 1557
            Me.Label7.Text = "부서"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNC503
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.popTrAdEmployeeDeptCd)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.dtpSEND_DATEFrom)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpSEND_DATETo)
            Me.Controls.Add(Me.txtPHONE_NUMBER)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TxtDEST_NAME)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.txtCALLBACK)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNC503"
            Me.Size = New System.Drawing.Size(811, 603)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.txtName, 0)
            Me.Controls.SetChildIndex(Me.txtCALLBACK, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.TxtDEST_NAME, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.txtPHONE_NUMBER, 0)
            Me.Controls.SetChildIndex(Me.dtpSEND_DATETo, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.dtpSEND_DATEFrom, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.popTrAdEmployeeDeptCd, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents txtCALLBACK As ubiLease.CommonControls.txt
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtName As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents TxtDEST_NAME As ubiLease.CommonControls.txt
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtPHONE_NUMBER As ubiLease.CommonControls.txt
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dtpSEND_DATEFrom As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpSEND_DATETo As ubiLease.CommonControls.dtp
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents popTrAdEmployeeDeptCd As ubiLease.CommonControls.pop
        Friend WithEvents Label7 As System.Windows.Forms.Label

    End Class

End Namespace
