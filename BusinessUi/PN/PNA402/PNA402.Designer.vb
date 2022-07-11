Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA402
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA402))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.Pop3 = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Pop2 = New ubiLease.CommonControls.pop
            Me.Pop1 = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            Me.lblCorporationRegisterNumber = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.Pop4 = New ubiLease.CommonControls.pop
            Me.Pop5 = New ubiLease.CommonControls.pop
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Pop6 = New ubiLease.CommonControls.pop
            Me.Label8 = New System.Windows.Forms.Label
            Me.Pop7 = New ubiLease.CommonControls.pop
            Me.Label9 = New System.Windows.Forms.Label
            Me.popCreateEmployeeNumber = New ubiLease.CommonControls.pop
            Me.lblRepresentativeName = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.Txt3 = New ubiLease.CommonControls.txt
            Me.Txt1 = New ubiLease.CommonControls.txt
            Me.Txt2 = New ubiLease.CommonControls.txt
            Me.Label11 = New System.Windows.Forms.Label
            Me.lblSideItemDivisionCode = New System.Windows.Forms.Label
            Me.cboSideItemDivisionCode = New ubiLease.CommonControls.cbo
            Me.Label12 = New System.Windows.Forms.Label
            Me.Txt4 = New ubiLease.CommonControls.txt
            Me.Txt5 = New ubiLease.CommonControls.txt
            Me.Label13 = New System.Windows.Forms.Label
            Me.Label14 = New System.Windows.Forms.Label
            Me.Txt6 = New ubiLease.CommonControls.txt
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria
            '
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(805, 62)
            Me.picCriteria.TabIndex = 8
            Me.picCriteria.TabStop = False
            '
            'Pop3
            '
            Me.Pop3.BorderColor = System.Drawing.Color.Empty
            Me.Pop3.BorderStyle = 2
            Me.Pop3.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Pop3.CaptionName = "회사 코드"
            Me.Pop3.CodeText = ""
            Me.Pop3.CodeWidth = 50
            Me.Pop3.Location = New System.Drawing.Point(113, 12)
            Me.Pop3.MaximumSize = New System.Drawing.Size(500, 20)
            Me.Pop3.MaxLength = 6
            Me.Pop3.MinimumSize = New System.Drawing.Size(19, 20)
            Me.Pop3.Name = "Pop3"
            Me.Pop3.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.Pop3.NameText = ""
            Me.Pop3.ReadOnlys = False
            Me.Pop3.SelectedText = ""
            Me.Pop3.SelectionLength = 0
            Me.Pop3.SelectionStart = 0
            Me.Pop3.Size = New System.Drawing.Size(150, 20)
            Me.Pop3.TabIndex = 826
            Me.Pop3.Tag = "code(회사 명);"
            Me.Pop3.TextAlign = 0
            Me.Pop3.TextValue = ""
            Me.Pop3.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(32, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(68, 15)
            Me.Label2.TabIndex = 825
            Me.Label2.Text = "확장처코드"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(3, 68)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(350, 17)
            Me.Label3.TabIndex = 842
            Me.Label3.Text = "확장처"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.grd_1.Location = New System.Drawing.Point(3, 88)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(238, 556)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 841
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Pop2
            '
            Me.Pop2.BorderColor = System.Drawing.Color.Empty
            Me.Pop2.BorderStyle = 2
            Me.Pop2.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Pop2.CaptionName = "작성 사원 번호"
            Me.Pop2.CodeText = ""
            Me.Pop2.CodeWidth = 50
            Me.Pop2.Location = New System.Drawing.Point(379, 174)
            Me.Pop2.MaximumSize = New System.Drawing.Size(500, 20)
            Me.Pop2.MaxLength = 6
            Me.Pop2.MinimumSize = New System.Drawing.Size(19, 20)
            Me.Pop2.Name = "Pop2"
            Me.Pop2.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.Pop2.NameText = ""
            Me.Pop2.ReadOnlys = False
            Me.Pop2.SelectedText = ""
            Me.Pop2.SelectionLength = 0
            Me.Pop2.SelectionStart = 0
            Me.Pop2.Size = New System.Drawing.Size(150, 20)
            Me.Pop2.TabIndex = 854
            Me.Pop2.Tag = "code(사원 명);"
            Me.Pop2.TextAlign = 0
            Me.Pop2.TextValue = ""
            Me.Pop2.ToolTipText = ""
            '
            'Pop1
            '
            Me.Pop1.BorderColor = System.Drawing.Color.Empty
            Me.Pop1.BorderStyle = 2
            Me.Pop1.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Pop1.CaptionName = "작성 사원 번호"
            Me.Pop1.CodeText = ""
            Me.Pop1.CodeWidth = 50
            Me.Pop1.Location = New System.Drawing.Point(379, 151)
            Me.Pop1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.Pop1.MaxLength = 6
            Me.Pop1.MinimumSize = New System.Drawing.Size(19, 20)
            Me.Pop1.Name = "Pop1"
            Me.Pop1.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.Pop1.NameText = ""
            Me.Pop1.ReadOnlys = False
            Me.Pop1.SelectedText = ""
            Me.Pop1.SelectionLength = 0
            Me.Pop1.SelectionStart = 0
            Me.Pop1.Size = New System.Drawing.Size(150, 20)
            Me.Pop1.TabIndex = 853
            Me.Pop1.Tag = "code(사원 명);"
            Me.Pop1.TextAlign = 0
            Me.Pop1.TextValue = ""
            Me.Pop1.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(285, 179)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(88, 15)
            Me.Label1.TabIndex = 852
            Me.Label1.Text = "그룹분류"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblCorporationRegisterNumber
            '
            Me.lblCorporationRegisterNumber.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCorporationRegisterNumber.Location = New System.Drawing.Point(295, 156)
            Me.lblCorporationRegisterNumber.Name = "lblCorporationRegisterNumber"
            Me.lblCorporationRegisterNumber.Size = New System.Drawing.Size(78, 15)
            Me.lblCorporationRegisterNumber.TabIndex = 851
            Me.lblCorporationRegisterNumber.Text = "그룹유형"
            Me.lblCorporationRegisterNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(247, 88)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(561, 556)
            Me.PictureBox1.TabIndex = 855
            Me.PictureBox1.TabStop = False
            '
            'Pop4
            '
            Me.Pop4.BorderColor = System.Drawing.Color.Empty
            Me.Pop4.BorderStyle = 2
            Me.Pop4.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Pop4.CaptionName = "작성 사원 번호"
            Me.Pop4.CodeText = ""
            Me.Pop4.CodeWidth = 50
            Me.Pop4.Location = New System.Drawing.Point(398, 35)
            Me.Pop4.MaximumSize = New System.Drawing.Size(500, 20)
            Me.Pop4.MaxLength = 6
            Me.Pop4.MinimumSize = New System.Drawing.Size(19, 20)
            Me.Pop4.Name = "Pop4"
            Me.Pop4.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.Pop4.NameText = ""
            Me.Pop4.ReadOnlys = False
            Me.Pop4.SelectedText = ""
            Me.Pop4.SelectionLength = 0
            Me.Pop4.SelectionStart = 0
            Me.Pop4.Size = New System.Drawing.Size(150, 20)
            Me.Pop4.TabIndex = 859
            Me.Pop4.Tag = "code(사원 명);"
            Me.Pop4.TextAlign = 0
            Me.Pop4.TextValue = ""
            Me.Pop4.ToolTipText = ""
            '
            'Pop5
            '
            Me.Pop5.BorderColor = System.Drawing.Color.Empty
            Me.Pop5.BorderStyle = 2
            Me.Pop5.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Pop5.CaptionName = "작성 사원 번호"
            Me.Pop5.CodeText = ""
            Me.Pop5.CodeWidth = 50
            Me.Pop5.Location = New System.Drawing.Point(398, 12)
            Me.Pop5.MaximumSize = New System.Drawing.Size(500, 20)
            Me.Pop5.MaxLength = 6
            Me.Pop5.MinimumSize = New System.Drawing.Size(19, 20)
            Me.Pop5.Name = "Pop5"
            Me.Pop5.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.Pop5.NameText = ""
            Me.Pop5.ReadOnlys = False
            Me.Pop5.SelectedText = ""
            Me.Pop5.SelectionLength = 0
            Me.Pop5.SelectionStart = 0
            Me.Pop5.Size = New System.Drawing.Size(150, 20)
            Me.Pop5.TabIndex = 858
            Me.Pop5.Tag = "code(사원 명);"
            Me.Pop5.TextAlign = 0
            Me.Pop5.TextValue = ""
            Me.Pop5.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(297, 40)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(88, 15)
            Me.Label5.TabIndex = 857
            Me.Label5.Text = "그룹분류"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(307, 17)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(78, 15)
            Me.Label6.TabIndex = 856
            Me.Label6.Text = "그룹유형"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label7.Location = New System.Drawing.Point(305, 104)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(68, 15)
            Me.Label7.TabIndex = 860
            Me.Label7.Text = "확장처코드"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Pop6
            '
            Me.Pop6.BorderColor = System.Drawing.Color.Empty
            Me.Pop6.BorderStyle = 2
            Me.Pop6.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Pop6.CaptionName = "작성 사원 번호"
            Me.Pop6.CodeText = ""
            Me.Pop6.CodeWidth = 50
            Me.Pop6.Location = New System.Drawing.Point(379, 200)
            Me.Pop6.MaximumSize = New System.Drawing.Size(500, 20)
            Me.Pop6.MaxLength = 6
            Me.Pop6.MinimumSize = New System.Drawing.Size(19, 20)
            Me.Pop6.Name = "Pop6"
            Me.Pop6.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.Pop6.NameText = ""
            Me.Pop6.ReadOnlys = False
            Me.Pop6.SelectedText = ""
            Me.Pop6.SelectionLength = 0
            Me.Pop6.SelectionStart = 0
            Me.Pop6.Size = New System.Drawing.Size(374, 20)
            Me.Pop6.TabIndex = 869
            Me.Pop6.Tag = "code(사원 명);"
            Me.Pop6.TextAlign = 0
            Me.Pop6.TextValue = ""
            Me.Pop6.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(297, 207)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(76, 13)
            Me.Label8.TabIndex = 868
            Me.Label8.Text = "우편번호"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Pop7
            '
            Me.Pop7.BorderColor = System.Drawing.Color.Empty
            Me.Pop7.BorderStyle = 2
            Me.Pop7.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Pop7.CaptionName = "작성 사원 번호"
            Me.Pop7.CodeText = ""
            Me.Pop7.CodeWidth = 50
            Me.Pop7.Location = New System.Drawing.Point(379, 249)
            Me.Pop7.MaximumSize = New System.Drawing.Size(500, 20)
            Me.Pop7.MaxLength = 6
            Me.Pop7.MinimumSize = New System.Drawing.Size(19, 20)
            Me.Pop7.Name = "Pop7"
            Me.Pop7.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.Pop7.NameText = ""
            Me.Pop7.ReadOnlys = False
            Me.Pop7.SelectedText = ""
            Me.Pop7.SelectionLength = 0
            Me.Pop7.SelectionStart = 0
            Me.Pop7.Size = New System.Drawing.Size(150, 20)
            Me.Pop7.TabIndex = 867
            Me.Pop7.Tag = "code(사원 명);"
            Me.Pop7.TextAlign = 0
            Me.Pop7.TextValue = ""
            Me.Pop7.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label9.Location = New System.Drawing.Point(322, 255)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(51, 14)
            Me.Label9.TabIndex = 866
            Me.Label9.Text = "업종"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'popCreateEmployeeNumber
            '
            Me.popCreateEmployeeNumber.BorderColor = System.Drawing.Color.Empty
            Me.popCreateEmployeeNumber.BorderStyle = 2
            Me.popCreateEmployeeNumber.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCreateEmployeeNumber.CaptionName = "작성 사원 번호"
            Me.popCreateEmployeeNumber.CodeText = ""
            Me.popCreateEmployeeNumber.CodeWidth = 50
            Me.popCreateEmployeeNumber.Location = New System.Drawing.Point(379, 275)
            Me.popCreateEmployeeNumber.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCreateEmployeeNumber.MaxLength = 6
            Me.popCreateEmployeeNumber.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCreateEmployeeNumber.Name = "popCreateEmployeeNumber"
            Me.popCreateEmployeeNumber.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCreateEmployeeNumber.NameText = ""
            Me.popCreateEmployeeNumber.ReadOnlys = False
            Me.popCreateEmployeeNumber.SelectedText = ""
            Me.popCreateEmployeeNumber.SelectionLength = 0
            Me.popCreateEmployeeNumber.SelectionStart = 0
            Me.popCreateEmployeeNumber.Size = New System.Drawing.Size(150, 20)
            Me.popCreateEmployeeNumber.TabIndex = 865
            Me.popCreateEmployeeNumber.Tag = "code(사원 명);"
            Me.popCreateEmployeeNumber.TextAlign = 0
            Me.popCreateEmployeeNumber.TextValue = ""
            Me.popCreateEmployeeNumber.ToolTipText = ""
            '
            'lblRepresentativeName
            '
            Me.lblRepresentativeName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRepresentativeName.Location = New System.Drawing.Point(322, 281)
            Me.lblRepresentativeName.Name = "lblRepresentativeName"
            Me.lblRepresentativeName.Size = New System.Drawing.Size(51, 14)
            Me.lblRepresentativeName.TabIndex = 864
            Me.lblRepresentativeName.Text = "업태"
            Me.lblRepresentativeName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label10.Location = New System.Drawing.Point(295, 125)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(76, 20)
            Me.Label10.TabIndex = 873
            Me.Label10.Text = "확장처명"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Txt3
            '
            Me.Txt3.BackColor = System.Drawing.SystemColors.Window
            Me.Txt3.BorderColor = System.Drawing.Color.Empty
            Me.Txt3.BorderStyle = 2
            Me.Txt3.CaptionName = "법인번호"
            Me.Txt3.Location = New System.Drawing.Point(379, 99)
            Me.Txt3.MaxLength = 14
            Me.Txt3.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Txt3.Multiline = False
            Me.Txt3.Name = "Txt3"
            Me.Txt3.ReadOnlys = False
            Me.Txt3.SelectedText = ""
            Me.Txt3.SelectionLength = 0
            Me.Txt3.SelectionStart = 0
            Me.Txt3.Size = New System.Drawing.Size(150, 20)
            Me.Txt3.TabIndex = 872
            Me.Txt3.Tag = "format(######-#######);"
            Me.Txt3.TextAlign = 0
            Me.Txt3.TextValue = Nothing
            Me.Txt3.ToolTipText = ""
            '
            'Txt1
            '
            Me.Txt1.BackColor = System.Drawing.SystemColors.Window
            Me.Txt1.BorderColor = System.Drawing.Color.Empty
            Me.Txt1.BorderStyle = 2
            Me.Txt1.CaptionName = "법인번호"
            Me.Txt1.Location = New System.Drawing.Point(379, 125)
            Me.Txt1.MaxLength = 14
            Me.Txt1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Txt1.Multiline = False
            Me.Txt1.Name = "Txt1"
            Me.Txt1.ReadOnlys = False
            Me.Txt1.SelectedText = ""
            Me.Txt1.SelectionLength = 0
            Me.Txt1.SelectionStart = 0
            Me.Txt1.Size = New System.Drawing.Size(220, 20)
            Me.Txt1.TabIndex = 871
            Me.Txt1.Tag = "format(######-#######);"
            Me.Txt1.TextAlign = 0
            Me.Txt1.TextValue = Nothing
            Me.Txt1.ToolTipText = ""
            '
            'Txt2
            '
            Me.Txt2.BackColor = System.Drawing.SystemColors.Window
            Me.Txt2.BorderColor = System.Drawing.Color.Empty
            Me.Txt2.BorderStyle = 2
            Me.Txt2.CaptionName = "법인번호"
            Me.Txt2.Location = New System.Drawing.Point(379, 226)
            Me.Txt2.MaxLength = 14
            Me.Txt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Txt2.Multiline = False
            Me.Txt2.Name = "Txt2"
            Me.Txt2.ReadOnlys = False
            Me.Txt2.SelectedText = ""
            Me.Txt2.SelectionLength = 0
            Me.Txt2.SelectionStart = 0
            Me.Txt2.Size = New System.Drawing.Size(374, 20)
            Me.Txt2.TabIndex = 874
            Me.Txt2.Tag = "format(######-#######);"
            Me.Txt2.TextAlign = 0
            Me.Txt2.TextValue = Nothing
            Me.Txt2.ToolTipText = ""
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label11.Location = New System.Drawing.Point(297, 230)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(76, 13)
            Me.Label11.TabIndex = 875
            Me.Label11.Text = "상세주소"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblSideItemDivisionCode
            '
            Me.lblSideItemDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSideItemDivisionCode.Location = New System.Drawing.Point(309, 396)
            Me.lblSideItemDivisionCode.Name = "lblSideItemDivisionCode"
            Me.lblSideItemDivisionCode.Size = New System.Drawing.Size(64, 15)
            Me.lblSideItemDivisionCode.TabIndex = 876
            Me.lblSideItemDivisionCode.Text = "사용여부"
            Me.lblSideItemDivisionCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboSideItemDivisionCode
            '
            Me.cboSideItemDivisionCode.CaptionName = "보조 항목 구분 코드"
            Me.cboSideItemDivisionCode.Enabled = False
            Me.cboSideItemDivisionCode.ListCount = 0
            Me.cboSideItemDivisionCode.Location = New System.Drawing.Point(379, 394)
            Me.cboSideItemDivisionCode.Name = "cboSideItemDivisionCode"
            Me.cboSideItemDivisionCode.ReadOnlys = False
            Me.cboSideItemDivisionCode.Size = New System.Drawing.Size(150, 20)
            Me.cboSideItemDivisionCode.TabIndex = 877
            Me.cboSideItemDivisionCode.Tag = "code(보조 항목 구분 명|전체);"
            Me.cboSideItemDivisionCode.TextValue = ""
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label12.Location = New System.Drawing.Point(251, 342)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(120, 20)
            Me.Label12.TabIndex = 881
            Me.Label12.Text = "확장처 담당 연락처1"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Txt4
            '
            Me.Txt4.BackColor = System.Drawing.SystemColors.Window
            Me.Txt4.BorderColor = System.Drawing.Color.Empty
            Me.Txt4.BorderStyle = 2
            Me.Txt4.CaptionName = "법인번호"
            Me.Txt4.Location = New System.Drawing.Point(379, 316)
            Me.Txt4.MaxLength = 14
            Me.Txt4.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Txt4.Multiline = False
            Me.Txt4.Name = "Txt4"
            Me.Txt4.ReadOnlys = False
            Me.Txt4.SelectedText = ""
            Me.Txt4.SelectionLength = 0
            Me.Txt4.SelectionStart = 0
            Me.Txt4.Size = New System.Drawing.Size(150, 20)
            Me.Txt4.TabIndex = 880
            Me.Txt4.Tag = "format(######-#######);"
            Me.Txt4.TextAlign = 0
            Me.Txt4.TextValue = Nothing
            Me.Txt4.ToolTipText = ""
            '
            'Txt5
            '
            Me.Txt5.BackColor = System.Drawing.SystemColors.Window
            Me.Txt5.BorderColor = System.Drawing.Color.Empty
            Me.Txt5.BorderStyle = 2
            Me.Txt5.CaptionName = "법인번호"
            Me.Txt5.Location = New System.Drawing.Point(379, 342)
            Me.Txt5.MaxLength = 14
            Me.Txt5.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Txt5.Multiline = False
            Me.Txt5.Name = "Txt5"
            Me.Txt5.ReadOnlys = False
            Me.Txt5.SelectedText = ""
            Me.Txt5.SelectionLength = 0
            Me.Txt5.SelectionStart = 0
            Me.Txt5.Size = New System.Drawing.Size(220, 20)
            Me.Txt5.TabIndex = 879
            Me.Txt5.Tag = "format(######-#######);"
            Me.Txt5.TextAlign = 0
            Me.Txt5.TextValue = Nothing
            Me.Txt5.ToolTipText = ""
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label13.Location = New System.Drawing.Point(278, 321)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(95, 15)
            Me.Label13.TabIndex = 878
            Me.Label13.Text = "확장처 담당자명"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label14.Location = New System.Drawing.Point(249, 368)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(122, 20)
            Me.Label14.TabIndex = 883
            Me.Label14.Text = "확장처 담당 연락처2"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Txt6
            '
            Me.Txt6.BackColor = System.Drawing.SystemColors.Window
            Me.Txt6.BorderColor = System.Drawing.Color.Empty
            Me.Txt6.BorderStyle = 2
            Me.Txt6.CaptionName = "법인번호"
            Me.Txt6.Location = New System.Drawing.Point(379, 368)
            Me.Txt6.MaxLength = 14
            Me.Txt6.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Txt6.Multiline = False
            Me.Txt6.Name = "Txt6"
            Me.Txt6.ReadOnlys = False
            Me.Txt6.SelectedText = ""
            Me.Txt6.SelectionLength = 0
            Me.Txt6.SelectionStart = 0
            Me.Txt6.Size = New System.Drawing.Size(220, 20)
            Me.Txt6.TabIndex = 882
            Me.Txt6.Tag = "format(######-#######);"
            Me.Txt6.TextAlign = 0
            Me.Txt6.TextValue = Nothing
            Me.Txt6.ToolTipText = ""
            '
            'PNA402
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.Txt6)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.Txt4)
            Me.Controls.Add(Me.Txt5)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.cboSideItemDivisionCode)
            Me.Controls.Add(Me.lblSideItemDivisionCode)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Txt2)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Txt3)
            Me.Controls.Add(Me.Txt1)
            Me.Controls.Add(Me.Pop6)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Pop7)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.popCreateEmployeeNumber)
            Me.Controls.Add(Me.lblRepresentativeName)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Pop4)
            Me.Controls.Add(Me.Pop5)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Pop2)
            Me.Controls.Add(Me.Pop1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblCorporationRegisterNumber)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.Pop3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.picCriteria)
            Me.Name = "PNA402"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents Pop3 As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Pop2 As ubiLease.CommonControls.pop
        Friend WithEvents Pop1 As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblCorporationRegisterNumber As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents Pop4 As ubiLease.CommonControls.pop
        Friend WithEvents Pop5 As ubiLease.CommonControls.pop
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Pop6 As ubiLease.CommonControls.pop
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Pop7 As ubiLease.CommonControls.pop
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents popCreateEmployeeNumber As ubiLease.CommonControls.pop
        Friend WithEvents lblRepresentativeName As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Txt3 As ubiLease.CommonControls.txt
        Friend WithEvents Txt1 As ubiLease.CommonControls.txt
        Friend WithEvents Txt2 As ubiLease.CommonControls.txt
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents lblSideItemDivisionCode As System.Windows.Forms.Label
        Friend WithEvents cboSideItemDivisionCode As ubiLease.CommonControls.cbo
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Txt4 As ubiLease.CommonControls.txt
        Friend WithEvents Txt5 As ubiLease.CommonControls.txt
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Txt6 As ubiLease.CommonControls.txt

    End Class

End Namespace
