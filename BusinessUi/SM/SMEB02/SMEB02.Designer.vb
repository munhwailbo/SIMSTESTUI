Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SMEB02
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMEB02))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.txtContents = New System.Windows.Forms.RichTextBox
            Me.lblDebitCreditCardDivision = New System.Windows.Forms.Label
            Me.cboDBObjectGubun = New ubiLease.CommonControls.cbo
            Me.lblSaveDir = New System.Windows.Forms.Label
            Me.txtPath = New ubiLease.CommonControls.txt
            Me.btnSearchDir = New ubiLease.CommonControls.btn
            Me.btnTaxBill = New ubiLease.CommonControls.btn
            Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.grd_1.Location = New System.Drawing.Point(5, 65)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(800, 233)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 130
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 7)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(800, 52)
            Me.picCriteria.TabIndex = 136
            Me.picCriteria.TabStop = False
            '
            'txtContents
            '
            Me.txtContents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtContents.BackColor = System.Drawing.SystemColors.Info
            Me.txtContents.Location = New System.Drawing.Point(5, 304)
            Me.txtContents.Name = "txtContents"
            Me.txtContents.Size = New System.Drawing.Size(800, 340)
            Me.txtContents.TabIndex = 440
            Me.txtContents.Text = ""
            '
            'lblDebitCreditCardDivision
            '
            Me.lblDebitCreditCardDivision.BackColor = System.Drawing.Color.GhostWhite
            Me.lblDebitCreditCardDivision.Location = New System.Drawing.Point(18, 29)
            Me.lblDebitCreditCardDivision.Name = "lblDebitCreditCardDivision"
            Me.lblDebitCreditCardDivision.Size = New System.Drawing.Size(59, 15)
            Me.lblDebitCreditCardDivision.TabIndex = 442
            Me.lblDebitCreditCardDivision.Text = "객체 구분"
            '
            'cboDBObjectGubun
            '
            Me.cboDBObjectGubun.CaptionName = "DB 객체 구분 명"
            Me.cboDBObjectGubun.ListCount = 0
            Me.cboDBObjectGubun.Location = New System.Drawing.Point(83, 24)
            Me.cboDBObjectGubun.Name = "cboDBObjectGubun"
            Me.cboDBObjectGubun.ReadOnlys = False
            Me.cboDBObjectGubun.Size = New System.Drawing.Size(142, 20)
            Me.cboDBObjectGubun.TabIndex = 441
            Me.cboDBObjectGubun.Tag = "code(DB 객체 구분 명|전체);"
            Me.cboDBObjectGubun.TextValue = ""
            '
            'lblSaveDir
            '
            Me.lblSaveDir.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaveDir.Location = New System.Drawing.Point(231, 30)
            Me.lblSaveDir.Name = "lblSaveDir"
            Me.lblSaveDir.Size = New System.Drawing.Size(59, 15)
            Me.lblSaveDir.TabIndex = 446
            Me.lblSaveDir.Text = "저장 폴더"
            '
            'txtPath
            '
            Me.txtPath.BackColor = System.Drawing.SystemColors.Window
            Me.txtPath.BorderColor = System.Drawing.Color.Empty
            Me.txtPath.BorderStyle = 1
            Me.txtPath.CaptionName = "폴더경로"
            Me.txtPath.Enabled = False
            Me.txtPath.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.txtPath.Location = New System.Drawing.Point(296, 24)
            Me.txtPath.MaxLength = 50
            Me.txtPath.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPath.Multiline = False
            Me.txtPath.Name = "txtPath"
            Me.txtPath.ReadOnlys = False
            Me.txtPath.SelectedText = ""
            Me.txtPath.SelectionLength = 0
            Me.txtPath.SelectionStart = 0
            Me.txtPath.Size = New System.Drawing.Size(277, 20)
            Me.txtPath.TabIndex = 445
            Me.txtPath.Tag = ""
            Me.txtPath.TextAlign = 0
            Me.txtPath.TextValue = ""
            Me.txtPath.ToolTipText = ""
            '
            'btnSearchDir
            '
            Me.btnSearchDir.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnSearchDir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnSearchDir.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnSearchDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnSearchDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnSearchDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnSearchDir.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.btnSearchDir.Location = New System.Drawing.Point(579, 24)
            Me.btnSearchDir.Name = "btnSearchDir"
            Me.btnSearchDir.Size = New System.Drawing.Size(77, 20)
            Me.btnSearchDir.TabIndex = 444
            Me.btnSearchDir.TabStop = False
            Me.btnSearchDir.Text = "폴더 선택"
            Me.btnSearchDir.UseVisualStyleBackColor = True
            '
            'btnTaxBill
            '
            Me.btnTaxBill.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnTaxBill.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnTaxBill.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnTaxBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnTaxBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnTaxBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnTaxBill.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.btnTaxBill.Location = New System.Drawing.Point(662, 24)
            Me.btnTaxBill.Name = "btnTaxBill"
            Me.btnTaxBill.Size = New System.Drawing.Size(119, 20)
            Me.btnTaxBill.TabIndex = 443
            Me.btnTaxBill.TabStop = False
            Me.btnTaxBill.Text = "스크립트 파일 생성"
            Me.btnTaxBill.UseVisualStyleBackColor = True
            '
            'SMEB02
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblSaveDir)
            Me.Controls.Add(Me.txtPath)
            Me.Controls.Add(Me.btnSearchDir)
            Me.Controls.Add(Me.btnTaxBill)
            Me.Controls.Add(Me.lblDebitCreditCardDivision)
            Me.Controls.Add(Me.cboDBObjectGubun)
            Me.Controls.Add(Me.txtContents)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "SMEB02"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents txtContents As System.Windows.Forms.RichTextBox
        Friend WithEvents lblDebitCreditCardDivision As System.Windows.Forms.Label
        Friend WithEvents cboDBObjectGubun As ubiLease.CommonControls.cbo
        Friend WithEvents lblSaveDir As System.Windows.Forms.Label
        Friend WithEvents txtPath As ubiLease.CommonControls.txt
        Friend WithEvents btnSearchDir As ubiLease.CommonControls.btn
        Friend WithEvents btnTaxBill As ubiLease.CommonControls.btn
        Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

    End Class

End Namespace
