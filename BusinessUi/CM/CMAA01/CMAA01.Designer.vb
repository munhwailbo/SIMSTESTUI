Namespace ubiLease.UI.BusinessUi.CM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CMAA01
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CMAA01))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblTitle = New System.Windows.Forms.Label
            Me.lblContent = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtTitle1 = New System.Windows.Forms.TextBox
            Me.chkAnounceYesOrNo = New System.Windows.Forms.CheckBox
            Me.lblAnounceYesOrNo = New System.Windows.Forms.Label
            Me.numSEQ = New ubiLease.CommonControls.num
            Me.txtTitle = New ubiLease.CommonControls.txt
            Me.txtContent = New ubiLease.CommonControls.txt
            Me.txtRegistrationIP = New ubiLease.CommonControls.txt
            Me.picio_2 = New ubiLease.CommonControls.picpanel
            Me.picCriteria_1 = New ubiLease.CommonControls.picpanel
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.picio_2.SuspendLayout()
            Me.picCriteria_1.SuspendLayout()
            Me.SuspendLayout()
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
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
            Me.grd_1.Location = New System.Drawing.Point(5, 59)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 358)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle.Location = New System.Drawing.Point(23, 14)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(46, 18)
            Me.lblTitle.TabIndex = 6
            Me.lblTitle.Text = "제목"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblContent
            '
            Me.lblContent.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblContent.Location = New System.Drawing.Point(23, 38)
            Me.lblContent.Name = "lblContent"
            Me.lblContent.Size = New System.Drawing.Size(46, 18)
            Me.lblContent.TabIndex = 7
            Me.lblContent.Text = "내용"
            Me.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(3, 11)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 18)
            Me.Label1.TabIndex = 18
            Me.Label1.Text = "제목 :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtTitle1
            '
            Me.txtTitle1.Location = New System.Drawing.Point(55, 8)
            Me.txtTitle1.Name = "txtTitle1"
            Me.txtTitle1.Size = New System.Drawing.Size(263, 21)
            Me.txtTitle1.TabIndex = 19
            '
            'chkAnounceYesOrNo
            '
            Me.chkAnounceYesOrNo.AutoSize = True
            Me.chkAnounceYesOrNo.BackColor = System.Drawing.Color.Transparent
            Me.chkAnounceYesOrNo.Location = New System.Drawing.Point(623, 341)
            Me.chkAnounceYesOrNo.Name = "chkAnounceYesOrNo"
            Me.chkAnounceYesOrNo.Size = New System.Drawing.Size(15, 14)
            Me.chkAnounceYesOrNo.TabIndex = 35
            Me.chkAnounceYesOrNo.Tag = "need;"
            Me.chkAnounceYesOrNo.UseVisualStyleBackColor = False
            Me.chkAnounceYesOrNo.Visible = False
            '
            'lblAnounceYesOrNo
            '
            Me.lblAnounceYesOrNo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblAnounceYesOrNo.Location = New System.Drawing.Point(644, 341)
            Me.lblAnounceYesOrNo.Name = "lblAnounceYesOrNo"
            Me.lblAnounceYesOrNo.Size = New System.Drawing.Size(60, 15)
            Me.lblAnounceYesOrNo.TabIndex = 34
            Me.lblAnounceYesOrNo.Text = "확정여부"
            Me.lblAnounceYesOrNo.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.lblAnounceYesOrNo.Visible = False
            '
            'numSEQ
            '
            Me.numSEQ.BackColor = System.Drawing.SystemColors.Window
            Me.numSEQ.BorderColor = System.Drawing.Color.Empty
            Me.numSEQ.BorderStyle = 2
            Me.numSEQ.CaptionName = "행 번호"
            Me.numSEQ.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.numSEQ.LengthPrecision = 4
            Me.numSEQ.LengthScale = 0
            Me.numSEQ.Location = New System.Drawing.Point(710, 341)
            Me.numSEQ.MaximumSize = New System.Drawing.Size(438, 20)
            Me.numSEQ.MaxLength = 32767
            Me.numSEQ.MinimumSize = New System.Drawing.Size(18, 20)
            Me.numSEQ.Name = "numSEQ"
            Me.numSEQ.ReadOnlys = False
            Me.numSEQ.SelectedText = ""
            Me.numSEQ.SelectionLength = 0
            Me.numSEQ.SelectionStart = 1
            Me.numSEQ.Size = New System.Drawing.Size(45, 20)
            Me.numSEQ.TabIndex = 37
            Me.numSEQ.Tag = "need;"
            Me.numSEQ.TextValue = "0"
            Me.numSEQ.ToolTipText = ""
            Me.numSEQ.Visible = False
            '
            'txtTitle
            '
            Me.txtTitle.BackColor = System.Drawing.SystemColors.Window
            Me.txtTitle.BorderColor = System.Drawing.Color.Empty
            Me.txtTitle.BorderStyle = 2
            Me.txtTitle.CaptionName = "적요 1"
            Me.txtTitle.Location = New System.Drawing.Point(92, 12)
            Me.txtTitle.MaxLength = 50
            Me.txtTitle.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtTitle.Multiline = False
            Me.txtTitle.Name = "txtTitle"
            Me.txtTitle.ReadOnlys = False
            Me.txtTitle.SelectedText = ""
            Me.txtTitle.SelectionLength = 0
            Me.txtTitle.SelectionStart = 0
            Me.txtTitle.Size = New System.Drawing.Size(700, 20)
            Me.txtTitle.TabIndex = 38
            Me.txtTitle.Tag = ""
            Me.txtTitle.TextAlign = 0
            Me.txtTitle.TextValue = ""
            Me.txtTitle.ToolTipText = ""
            '
            'txtContent
            '
            Me.txtContent.BackColor = System.Drawing.SystemColors.Window
            Me.txtContent.BorderColor = System.Drawing.Color.Empty
            Me.txtContent.BorderStyle = 2
            Me.txtContent.CaptionName = "적요 1"
            Me.txtContent.Location = New System.Drawing.Point(92, 38)
            Me.txtContent.MaximumSize = New System.Drawing.Size(700, 165)
            Me.txtContent.MaxLength = 10000
            Me.txtContent.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtContent.Multiline = True
            Me.txtContent.Name = "txtContent"
            Me.txtContent.ReadOnlys = False
            Me.txtContent.SelectedText = ""
            Me.txtContent.SelectionLength = 0
            Me.txtContent.SelectionStart = 0
            Me.txtContent.Size = New System.Drawing.Size(700, 165)
            Me.txtContent.TabIndex = 39
            Me.txtContent.Tag = ""
            Me.txtContent.TextAlign = 0
            Me.txtContent.TextValue = ""
            Me.txtContent.ToolTipText = ""
            '
            'txtRegistrationIP
            '
            Me.txtRegistrationIP.BackColor = System.Drawing.SystemColors.Window
            Me.txtRegistrationIP.BorderColor = System.Drawing.Color.Empty
            Me.txtRegistrationIP.BorderStyle = 2
            Me.txtRegistrationIP.CaptionName = "적요 1"
            Me.txtRegistrationIP.Location = New System.Drawing.Point(640, 361)
            Me.txtRegistrationIP.MaxLength = 50
            Me.txtRegistrationIP.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRegistrationIP.Multiline = False
            Me.txtRegistrationIP.Name = "txtRegistrationIP"
            Me.txtRegistrationIP.ReadOnlys = False
            Me.txtRegistrationIP.SelectedText = ""
            Me.txtRegistrationIP.SelectionLength = 0
            Me.txtRegistrationIP.SelectionStart = 0
            Me.txtRegistrationIP.Size = New System.Drawing.Size(64, 20)
            Me.txtRegistrationIP.TabIndex = 40
            Me.txtRegistrationIP.Tag = ""
            Me.txtRegistrationIP.TextAlign = 0
            Me.txtRegistrationIP.TextValue = ""
            Me.txtRegistrationIP.ToolTipText = ""
            Me.txtRegistrationIP.Visible = False
            '
            'picio_2
            '
            Me.picio_2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picio_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picio_2.Controls.Add(Me.lblTitle)
            Me.picio_2.Controls.Add(Me.lblContent)
            Me.picio_2.Controls.Add(Me.txtContent)
            Me.picio_2.Controls.Add(Me.txtTitle)
            Me.picio_2.Location = New System.Drawing.Point(5, 423)
            Me.picio_2.Name = "picio_2"
            Me.picio_2.Size = New System.Drawing.Size(799, 221)
            Me.picio_2.TabIndex = 41
            '
            'picCriteria_1
            '
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Controls.Add(Me.Label1)
            Me.picCriteria_1.Controls.Add(Me.txtTitle1)
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 3)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 50)
            Me.picCriteria_1.TabIndex = 42
            '
            'CMAA01
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.picio_2)
            Me.Controls.Add(Me.txtRegistrationIP)
            Me.Controls.Add(Me.numSEQ)
            Me.Controls.Add(Me.chkAnounceYesOrNo)
            Me.Controls.Add(Me.lblAnounceYesOrNo)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "CMAA01"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.picio_2.ResumeLayout(False)
            Me.picCriteria_1.ResumeLayout(False)
            Me.picCriteria_1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        'Friend WithEvents picIo_2 As ubiLease.CommonControls.picpanel
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblContent As System.Windows.Forms.Label
        'Friend WithEvents picCriteria_1 As ubiLease.CommonControls.picpanel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtTitle1 As System.Windows.Forms.TextBox
        Friend WithEvents chkAnounceYesOrNo As System.Windows.Forms.CheckBox
        Friend WithEvents lblAnounceYesOrNo As System.Windows.Forms.Label
        Friend WithEvents numSEQ As ubiLease.CommonControls.num
        Friend WithEvents txtTitle As ubiLease.CommonControls.txt
        Friend WithEvents txtContent As ubiLease.CommonControls.txt
        Friend WithEvents txtRegistrationIP As ubiLease.CommonControls.txt
        Friend WithEvents picio_2 As ubiLease.CommonControls.picpanel
        Friend WithEvents picCriteria_1 As ubiLease.CommonControls.picpanel

    End Class

End Namespace
