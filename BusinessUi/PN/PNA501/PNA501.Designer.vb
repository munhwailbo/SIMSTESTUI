Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA501
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA501))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.btnLeft = New System.Windows.Forms.Button
            Me.btnRight = New System.Windows.Forms.Button
            Me.lblCorporationRegisterNumber = New System.Windows.Forms.Label
            Me.PopBranchCd = New ubiLease.CommonControls.pop
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.grd_3 = New ubiLease.GridControl.grd
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.popChargeEmpNum = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtBranchNm_2 = New ubiLease.CommonControls.txt
            Me.btnRequest3 = New System.Windows.Forms.Button
            Me.txtDong = New ubiLease.CommonControls.txt
            Me.Label3 = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(805, 51)
            Me.picCriteria.TabIndex = 8
            Me.picCriteria.TabStop = False
            '
            'btnLeft
            '
            Me.btnLeft.Location = New System.Drawing.Point(427, 433)
            Me.btnLeft.Name = "btnLeft"
            Me.btnLeft.Size = New System.Drawing.Size(27, 43)
            Me.btnLeft.TabIndex = 842
            Me.btnLeft.Text = "◀"
            Me.btnLeft.UseVisualStyleBackColor = True
            '
            'btnRight
            '
            Me.btnRight.Location = New System.Drawing.Point(427, 482)
            Me.btnRight.Name = "btnRight"
            Me.btnRight.Size = New System.Drawing.Size(27, 43)
            Me.btnRight.TabIndex = 841
            Me.btnRight.Text = "▶"
            Me.btnRight.UseVisualStyleBackColor = True
            '
            'lblCorporationRegisterNumber
            '
            Me.lblCorporationRegisterNumber.BackColor = System.Drawing.SystemColors.Control
            Me.lblCorporationRegisterNumber.Location = New System.Drawing.Point(456, 316)
            Me.lblCorporationRegisterNumber.Name = "lblCorporationRegisterNumber"
            Me.lblCorporationRegisterNumber.Size = New System.Drawing.Size(35, 15)
            Me.lblCorporationRegisterNumber.TabIndex = 836
            Me.lblCorporationRegisterNumber.Text = "지국"
            Me.lblCorporationRegisterNumber.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'PopBranchCd
            '
            Me.PopBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.PopBranchCd.BorderStyle = 2
            Me.PopBranchCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.PopBranchCd.CaptionName = "지국코드"
            Me.PopBranchCd.CodeText = ""
            Me.PopBranchCd.CodeWidth = 50
            Me.PopBranchCd.Location = New System.Drawing.Point(492, 311)
            Me.PopBranchCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.PopBranchCd.MaxLength = 7
            Me.PopBranchCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.PopBranchCd.Name = "PopBranchCd"
            Me.PopBranchCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.PopBranchCd.NameText = ""
            Me.PopBranchCd.ReadOnlys = False
            Me.PopBranchCd.SelectedText = ""
            Me.PopBranchCd.SelectionLength = 0
            Me.PopBranchCd.SelectionStart = 0
            Me.PopBranchCd.Size = New System.Drawing.Size(170, 20)
            Me.PopBranchCd.TabIndex = 838
            Me.PopBranchCd.Tag = "code(지국코드);"
            Me.PopBranchCd.TextAlign = 0
            Me.PopBranchCd.TextValue = ""
            Me.PopBranchCd.ToolTipText = ""
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.grd_2.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_2.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_2.Cols = 2
            Me.grd_2.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(3, 334)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(420, 310)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 827
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.SystemColors.Control
            Me.Label4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(3, 317)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(420, 14)
            Me.Label4.TabIndex = 831
            Me.Label4.Text = "우편번호-지국"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(496, 317)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(312, 14)
            Me.Label1.TabIndex = 844
            Me.Label1.Text = "우편번호-미지정"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'grd_3
            '
            Me.grd_3.AllowBigSelection = False
            Me.grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_3.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_3.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_3.Cols = 2
            Me.grd_3.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(460, 354)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(348, 290)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 843
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
            Me.grd_1.Location = New System.Drawing.Point(3, 60)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 245)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 845
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum.BorderStyle = 2
            Me.popChargeEmpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum.CaptionName = "담당자"
            Me.popChargeEmpNum.CodeText = ""
            Me.popChargeEmpNum.CodeWidth = 60
            Me.popChargeEmpNum.Location = New System.Drawing.Point(362, 19)
            Me.popChargeEmpNum.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popChargeEmpNum.MaxLength = 6
            Me.popChargeEmpNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum.Name = "popChargeEmpNum"
            Me.popChargeEmpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum.NameText = ""
            Me.popChargeEmpNum.ReadOnlys = False
            Me.popChargeEmpNum.SelectedText = ""
            Me.popChargeEmpNum.SelectionLength = 0
            Me.popChargeEmpNum.SelectionStart = 0
            Me.popChargeEmpNum.Size = New System.Drawing.Size(167, 20)
            Me.popChargeEmpNum.TabIndex = 1063
            Me.popChargeEmpNum.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum.TextAlign = 0
            Me.popChargeEmpNum.TextValue = ""
            Me.popChargeEmpNum.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(310, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 20)
            Me.Label2.TabIndex = 1062
            Me.Label2.Text = "담당자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label5.Location = New System.Drawing.Point(37, 19)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 20)
            Me.Label5.TabIndex = 1060
            Me.Label5.Text = "지국명"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtBranchNm_2
            '
            Me.txtBranchNm_2.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchNm_2.BorderColor = System.Drawing.Color.Empty
            Me.txtBranchNm_2.BorderStyle = 2
            Me.txtBranchNm_2.CaptionName = "지국 명"
            Me.txtBranchNm_2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtBranchNm_2.Location = New System.Drawing.Point(87, 19)
            Me.txtBranchNm_2.MaxLength = 6
            Me.txtBranchNm_2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtBranchNm_2.Multiline = False
            Me.txtBranchNm_2.Name = "txtBranchNm_2"
            Me.txtBranchNm_2.ReadOnlys = False
            Me.txtBranchNm_2.SelectedText = ""
            Me.txtBranchNm_2.SelectionLength = 0
            Me.txtBranchNm_2.SelectionStart = 0
            Me.txtBranchNm_2.Size = New System.Drawing.Size(167, 20)
            Me.txtBranchNm_2.TabIndex = 1061
            Me.txtBranchNm_2.Tag = ""
            Me.txtBranchNm_2.TextAlign = 0
            Me.txtBranchNm_2.TextValue = ""
            Me.txtBranchNm_2.ToolTipText = ""
            '
            'btnRequest3
            '
            Me.btnRequest3.Location = New System.Drawing.Point(664, 311)
            Me.btnRequest3.Name = "btnRequest3"
            Me.btnRequest3.Size = New System.Drawing.Size(29, 20)
            Me.btnRequest3.TabIndex = 1064
            Me.btnRequest3.Text = "☞"
            Me.btnRequest3.UseVisualStyleBackColor = True
            '
            'txtDong
            '
            Me.txtDong.BackColor = System.Drawing.SystemColors.Window
            Me.txtDong.BorderColor = System.Drawing.Color.Empty
            Me.txtDong.BorderStyle = 2
            Me.txtDong.CaptionName = "동"
            Me.txtDong.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.txtDong.Location = New System.Drawing.Point(492, 333)
            Me.txtDong.MaxLength = 6
            Me.txtDong.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDong.Multiline = False
            Me.txtDong.Name = "txtDong"
            Me.txtDong.ReadOnlys = False
            Me.txtDong.SelectedText = ""
            Me.txtDong.SelectionLength = 0
            Me.txtDong.SelectionStart = 0
            Me.txtDong.Size = New System.Drawing.Size(143, 20)
            Me.txtDong.TabIndex = 1065
            Me.txtDong.Tag = ""
            Me.txtDong.TextAlign = 0
            Me.txtDong.TextValue = ""
            Me.txtDong.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Font = New System.Drawing.Font("굴림체", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label3.Location = New System.Drawing.Point(641, 333)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(21, 20)
            Me.Label3.TabIndex = 1066
            Me.Label3.Text = "동"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNA501
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtDong)
            Me.Controls.Add(Me.btnRequest3)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtBranchNm_2)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.btnLeft)
            Me.Controls.Add(Me.btnRight)
            Me.Controls.Add(Me.PopBranchCd)
            Me.Controls.Add(Me.lblCorporationRegisterNumber)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.Label1)
            Me.Name = "PNA501"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents btnLeft As System.Windows.Forms.Button
        Friend WithEvents btnRight As System.Windows.Forms.Button
        Friend WithEvents lblCorporationRegisterNumber As System.Windows.Forms.Label
        Friend WithEvents PopBranchCd As ubiLease.CommonControls.pop
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtBranchNm_2 As ubiLease.CommonControls.txt
        Friend WithEvents btnRequest3 As System.Windows.Forms.Button
        Friend WithEvents txtDong As ubiLease.CommonControls.txt
        Friend WithEvents Label3 As System.Windows.Forms.Label

    End Class

End Namespace
