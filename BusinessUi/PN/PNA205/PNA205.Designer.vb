Namespace ubiLease.UI.BusinessUi.AC 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA205
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA205))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.btnCodeIn = New System.Windows.Forms.Button
            Me.txtCustomerCode_2 = New ubiLease.CommonControls.txt
            Me.lblCustomerCode_2 = New System.Windows.Forms.Label
            Me.lblRepresentativeName_2 = New System.Windows.Forms.Label
            Me.txtRepresentativeName_2 = New ubiLease.CommonControls.txt
            Me.cboCustomerDivision_2 = New ubiLease.CommonControls.cbo
            Me.lblCustomerDivision_2 = New System.Windows.Forms.Label
            Me.lblBizRegNumber_2 = New System.Windows.Forms.Label
            Me.txtBizRegNumber_2 = New ubiLease.CommonControls.txt
            Me.lblResRegNumber_2 = New System.Windows.Forms.Label
            Me.txtResRegNumber_2 = New ubiLease.CommonControls.txt
            Me.cboIndividualBizDivision_2 = New ubiLease.CommonControls.cbo
            Me.lblIndividualBizDivision_2 = New System.Windows.Forms.Label
            Me.lblFirmName_2 = New System.Windows.Forms.Label
            Me.txtFirmName_2 = New ubiLease.CommonControls.txt
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.Label1 = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(790, 73)
            Me.picCriteria.TabIndex = 4
            Me.picCriteria.TabStop = False
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
            Me.grd_1.Location = New System.Drawing.Point(5, 132)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 505)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 3
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'btnCodeIn
            '
            Me.btnCodeIn.Location = New System.Drawing.Point(96, 91)
            Me.btnCodeIn.Name = "btnCodeIn"
            Me.btnCodeIn.Size = New System.Drawing.Size(91, 26)
            Me.btnCodeIn.TabIndex = 135
            Me.btnCodeIn.Text = "코드반영"
            Me.btnCodeIn.UseVisualStyleBackColor = True
            '
            'txtCustomerCode_2
            '
            Me.txtCustomerCode_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtCustomerCode_2.BorderColor = System.Drawing.Color.Empty
            Me.txtCustomerCode_2.BorderStyle = 2
            Me.txtCustomerCode_2.CaptionName = "거래처 코드"
            Me.txtCustomerCode_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtCustomerCode_2.Location = New System.Drawing.Point(107, 17)
            Me.txtCustomerCode_2.MaxLength = 7
            Me.txtCustomerCode_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCustomerCode_2.Multiline = False
            Me.txtCustomerCode_2.Name = "txtCustomerCode_2"
            Me.txtCustomerCode_2.ReadOnlys = False
            Me.txtCustomerCode_2.SelectedText = ""
            Me.txtCustomerCode_2.SelectionLength = 0
            Me.txtCustomerCode_2.SelectionStart = 0
            Me.txtCustomerCode_2.Size = New System.Drawing.Size(80, 20)
            Me.txtCustomerCode_2.TabIndex = 149
            Me.txtCustomerCode_2.Tag = ""
            Me.txtCustomerCode_2.TextAlign = 0
            Me.txtCustomerCode_2.TextValue = ""
            Me.txtCustomerCode_2.ToolTipText = "거래처 코드"
            '
            'lblCustomerCode_2
            '
            Me.lblCustomerCode_2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblCustomerCode_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCustomerCode_2.Location = New System.Drawing.Point(16, 22)
            Me.lblCustomerCode_2.Name = "lblCustomerCode_2"
            Me.lblCustomerCode_2.Size = New System.Drawing.Size(80, 15)
            Me.lblCustomerCode_2.TabIndex = 148
            Me.lblCustomerCode_2.Text = "거래처 코드"
            Me.lblCustomerCode_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblRepresentativeName_2
            '
            Me.lblRepresentativeName_2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRepresentativeName_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRepresentativeName_2.Location = New System.Drawing.Point(203, 48)
            Me.lblRepresentativeName_2.Name = "lblRepresentativeName_2"
            Me.lblRepresentativeName_2.Size = New System.Drawing.Size(60, 15)
            Me.lblRepresentativeName_2.TabIndex = 147
            Me.lblRepresentativeName_2.Text = "대표자 명"
            Me.lblRepresentativeName_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtRepresentativeName_2
            '
            Me.txtRepresentativeName_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtRepresentativeName_2.BorderColor = System.Drawing.Color.Empty
            Me.txtRepresentativeName_2.BorderStyle = 2
            Me.txtRepresentativeName_2.CaptionName = "대표자 명"
            Me.txtRepresentativeName_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtRepresentativeName_2.Location = New System.Drawing.Point(269, 43)
            Me.txtRepresentativeName_2.MaxLength = 30
            Me.txtRepresentativeName_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRepresentativeName_2.Multiline = False
            Me.txtRepresentativeName_2.Name = "txtRepresentativeName_2"
            Me.txtRepresentativeName_2.ReadOnlys = False
            Me.txtRepresentativeName_2.SelectedText = ""
            Me.txtRepresentativeName_2.SelectionLength = 0
            Me.txtRepresentativeName_2.SelectionStart = 0
            Me.txtRepresentativeName_2.Size = New System.Drawing.Size(100, 20)
            Me.txtRepresentativeName_2.TabIndex = 146
            Me.txtRepresentativeName_2.Tag = ""
            Me.txtRepresentativeName_2.TextAlign = 0
            Me.txtRepresentativeName_2.TextValue = ""
            Me.txtRepresentativeName_2.ToolTipText = "대표자 명"
            '
            'cboCustomerDivision_2
            '
            Me.cboCustomerDivision_2.BackColor = System.Drawing.SystemColors.Window
            Me.cboCustomerDivision_2.CaptionName = "거래처 구분"
            Me.cboCustomerDivision_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboCustomerDivision_2.ListCount = 0
            Me.cboCustomerDivision_2.Location = New System.Drawing.Point(481, 43)
            Me.cboCustomerDivision_2.MaxLength = 165
            Me.cboCustomerDivision_2.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboCustomerDivision_2.Name = "cboCustomerDivision_2"
            Me.cboCustomerDivision_2.ReadOnlys = False
            Me.cboCustomerDivision_2.Size = New System.Drawing.Size(100, 20)
            Me.cboCustomerDivision_2.TabIndex = 144
            Me.cboCustomerDivision_2.Tag = "code(거래처 구분 명|전체);"
            Me.cboCustomerDivision_2.TextValue = ""
            '
            'lblCustomerDivision_2
            '
            Me.lblCustomerDivision_2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblCustomerDivision_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblCustomerDivision_2.Location = New System.Drawing.Point(390, 45)
            Me.lblCustomerDivision_2.Name = "lblCustomerDivision_2"
            Me.lblCustomerDivision_2.Size = New System.Drawing.Size(80, 15)
            Me.lblCustomerDivision_2.TabIndex = 145
            Me.lblCustomerDivision_2.Text = "거래처 구분"
            Me.lblCustomerDivision_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblBizRegNumber_2
            '
            Me.lblBizRegNumber_2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblBizRegNumber_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblBizRegNumber_2.Location = New System.Drawing.Point(375, 22)
            Me.lblBizRegNumber_2.Name = "lblBizRegNumber_2"
            Me.lblBizRegNumber_2.Size = New System.Drawing.Size(95, 15)
            Me.lblBizRegNumber_2.TabIndex = 142
            Me.lblBizRegNumber_2.Text = "사업자등록 번호"
            Me.lblBizRegNumber_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtBizRegNumber_2
            '
            Me.txtBizRegNumber_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtBizRegNumber_2.BorderColor = System.Drawing.Color.Empty
            Me.txtBizRegNumber_2.BorderStyle = 2
            Me.txtBizRegNumber_2.CaptionName = "사업자 등록 번호"
            Me.txtBizRegNumber_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtBizRegNumber_2.Location = New System.Drawing.Point(481, 17)
            Me.txtBizRegNumber_2.MaxLength = 12
            Me.txtBizRegNumber_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBizRegNumber_2.Multiline = False
            Me.txtBizRegNumber_2.Name = "txtBizRegNumber_2"
            Me.txtBizRegNumber_2.ReadOnlys = False
            Me.txtBizRegNumber_2.SelectedText = ""
            Me.txtBizRegNumber_2.SelectionLength = 0
            Me.txtBizRegNumber_2.SelectionStart = 0
            Me.txtBizRegNumber_2.Size = New System.Drawing.Size(100, 20)
            Me.txtBizRegNumber_2.TabIndex = 140
            Me.txtBizRegNumber_2.Tag = "format(###-##-#####);"
            Me.txtBizRegNumber_2.TextAlign = 0
            Me.txtBizRegNumber_2.TextValue = Nothing
            Me.txtBizRegNumber_2.ToolTipText = "사업자 등록 번호"
            '
            'lblResRegNumber_2
            '
            Me.lblResRegNumber_2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblResRegNumber_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblResRegNumber_2.Location = New System.Drawing.Point(587, 22)
            Me.lblResRegNumber_2.Name = "lblResRegNumber_2"
            Me.lblResRegNumber_2.Size = New System.Drawing.Size(90, 15)
            Me.lblResRegNumber_2.TabIndex = 143
            Me.lblResRegNumber_2.Text = "주민등록 번호"
            Me.lblResRegNumber_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtResRegNumber_2
            '
            Me.txtResRegNumber_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtResRegNumber_2.BorderColor = System.Drawing.Color.Empty
            Me.txtResRegNumber_2.BorderStyle = 2
            Me.txtResRegNumber_2.CaptionName = "주민 등록 번호"
            Me.txtResRegNumber_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtResRegNumber_2.Location = New System.Drawing.Point(685, 17)
            Me.txtResRegNumber_2.MaxLength = 14
            Me.txtResRegNumber_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtResRegNumber_2.Multiline = False
            Me.txtResRegNumber_2.Name = "txtResRegNumber_2"
            Me.txtResRegNumber_2.ReadOnlys = False
            Me.txtResRegNumber_2.SelectedText = ""
            Me.txtResRegNumber_2.SelectionLength = 0
            Me.txtResRegNumber_2.SelectionStart = 0
            Me.txtResRegNumber_2.Size = New System.Drawing.Size(100, 20)
            Me.txtResRegNumber_2.TabIndex = 141
            Me.txtResRegNumber_2.Tag = "format(######-#######);"
            Me.txtResRegNumber_2.TextAlign = 0
            Me.txtResRegNumber_2.TextValue = Nothing
            Me.txtResRegNumber_2.ToolTipText = "주민 등록 번호"
            '
            'cboIndividualBizDivision_2
            '
            Me.cboIndividualBizDivision_2.BackColor = System.Drawing.SystemColors.Window
            Me.cboIndividualBizDivision_2.CaptionName = "개인 사업자 구분"
            Me.cboIndividualBizDivision_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboIndividualBizDivision_2.ListCount = 0
            Me.cboIndividualBizDivision_2.Location = New System.Drawing.Point(107, 43)
            Me.cboIndividualBizDivision_2.MaxLength = 165
            Me.cboIndividualBizDivision_2.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboIndividualBizDivision_2.Name = "cboIndividualBizDivision_2"
            Me.cboIndividualBizDivision_2.ReadOnlys = False
            Me.cboIndividualBizDivision_2.Size = New System.Drawing.Size(80, 20)
            Me.cboIndividualBizDivision_2.TabIndex = 138
            Me.cboIndividualBizDivision_2.Tag = "code(개인 사업자 구분 명|전체);"
            Me.cboIndividualBizDivision_2.TextValue = ""
            '
            'lblIndividualBizDivision_2
            '
            Me.lblIndividualBizDivision_2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblIndividualBizDivision_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblIndividualBizDivision_2.Location = New System.Drawing.Point(21, 48)
            Me.lblIndividualBizDivision_2.Name = "lblIndividualBizDivision_2"
            Me.lblIndividualBizDivision_2.Size = New System.Drawing.Size(80, 15)
            Me.lblIndividualBizDivision_2.TabIndex = 139
            Me.lblIndividualBizDivision_2.Text = "개인/사업자"
            Me.lblIndividualBizDivision_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblFirmName_2
            '
            Me.lblFirmName_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFirmName_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblFirmName_2.Location = New System.Drawing.Point(203, 22)
            Me.lblFirmName_2.Name = "lblFirmName_2"
            Me.lblFirmName_2.Size = New System.Drawing.Size(60, 15)
            Me.lblFirmName_2.TabIndex = 137
            Me.lblFirmName_2.Text = "상호 명"
            Me.lblFirmName_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtFirmName_2
            '
            Me.txtFirmName_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtFirmName_2.BorderColor = System.Drawing.Color.Empty
            Me.txtFirmName_2.BorderStyle = 1
            Me.txtFirmName_2.CaptionName = "상호 명"
            Me.txtFirmName_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtFirmName_2.Location = New System.Drawing.Point(269, 17)
            Me.txtFirmName_2.MaxLength = 32767
            Me.txtFirmName_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtFirmName_2.Multiline = False
            Me.txtFirmName_2.Name = "txtFirmName_2"
            Me.txtFirmName_2.ReadOnlys = False
            Me.txtFirmName_2.SelectedText = ""
            Me.txtFirmName_2.SelectionLength = 0
            Me.txtFirmName_2.SelectionStart = 0
            Me.txtFirmName_2.Size = New System.Drawing.Size(100, 20)
            Me.txtFirmName_2.TabIndex = 136
            Me.txtFirmName_2.Tag = Nothing
            Me.txtFirmName_2.TextAlign = 0
            Me.txtFirmName_2.TextValue = ""
            Me.txtFirmName_2.ToolTipText = "상호 명"
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(7, 84)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(790, 42)
            Me.PictureBox1.TabIndex = 150
            Me.PictureBox1.TabStop = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.Label1.Location = New System.Drawing.Point(203, 96)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(429, 20)
            Me.Label1.TabIndex = 151
            Me.Label1.Text = "회계시스템의 거래처 정보로 업데이트 합니다.!!"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PNA205
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtCustomerCode_2)
            Me.Controls.Add(Me.lblCustomerCode_2)
            Me.Controls.Add(Me.lblRepresentativeName_2)
            Me.Controls.Add(Me.txtRepresentativeName_2)
            Me.Controls.Add(Me.cboCustomerDivision_2)
            Me.Controls.Add(Me.lblCustomerDivision_2)
            Me.Controls.Add(Me.lblBizRegNumber_2)
            Me.Controls.Add(Me.txtBizRegNumber_2)
            Me.Controls.Add(Me.lblResRegNumber_2)
            Me.Controls.Add(Me.txtResRegNumber_2)
            Me.Controls.Add(Me.cboIndividualBizDivision_2)
            Me.Controls.Add(Me.lblIndividualBizDivision_2)
            Me.Controls.Add(Me.lblFirmName_2)
            Me.Controls.Add(Me.txtFirmName_2)
            Me.Controls.Add(Me.btnCodeIn)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNA205"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.btnCodeIn, 0)
            Me.Controls.SetChildIndex(Me.txtFirmName_2, 0)
            Me.Controls.SetChildIndex(Me.lblFirmName_2, 0)
            Me.Controls.SetChildIndex(Me.lblIndividualBizDivision_2, 0)
            Me.Controls.SetChildIndex(Me.cboIndividualBizDivision_2, 0)
            Me.Controls.SetChildIndex(Me.txtResRegNumber_2, 0)
            Me.Controls.SetChildIndex(Me.lblResRegNumber_2, 0)
            Me.Controls.SetChildIndex(Me.txtBizRegNumber_2, 0)
            Me.Controls.SetChildIndex(Me.lblBizRegNumber_2, 0)
            Me.Controls.SetChildIndex(Me.lblCustomerDivision_2, 0)
            Me.Controls.SetChildIndex(Me.cboCustomerDivision_2, 0)
            Me.Controls.SetChildIndex(Me.txtRepresentativeName_2, 0)
            Me.Controls.SetChildIndex(Me.lblRepresentativeName_2, 0)
            Me.Controls.SetChildIndex(Me.lblCustomerCode_2, 0)
            Me.Controls.SetChildIndex(Me.txtCustomerCode_2, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub


        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents btnCodeIn As System.Windows.Forms.Button
        Friend WithEvents txtCustomerCode_2 As ubiLease.CommonControls.txt
        Friend WithEvents lblCustomerCode_2 As System.Windows.Forms.Label
        Friend WithEvents lblRepresentativeName_2 As System.Windows.Forms.Label
        Friend WithEvents txtRepresentativeName_2 As ubiLease.CommonControls.txt
        Friend WithEvents cboCustomerDivision_2 As ubiLease.CommonControls.cbo
        Friend WithEvents lblCustomerDivision_2 As System.Windows.Forms.Label
        Friend WithEvents lblBizRegNumber_2 As System.Windows.Forms.Label
        Friend WithEvents txtBizRegNumber_2 As ubiLease.CommonControls.txt
        Friend WithEvents lblResRegNumber_2 As System.Windows.Forms.Label
        Friend WithEvents txtResRegNumber_2 As ubiLease.CommonControls.txt
        Friend WithEvents cboIndividualBizDivision_2 As ubiLease.CommonControls.cbo
        Friend WithEvents lblIndividualBizDivision_2 As System.Windows.Forms.Label
        Friend WithEvents lblFirmName_2 As System.Windows.Forms.Label
        Friend WithEvents txtFirmName_2 As ubiLease.CommonControls.txt
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label1 As System.Windows.Forms.Label

    End Class
 
End Namespace 