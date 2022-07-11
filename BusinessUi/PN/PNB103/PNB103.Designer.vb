Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNB103
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNB103))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.lblBaseDt = New System.Windows.Forms.Label
            Me.dtpPayYYYYMM = New ubiLease.CommonControls.dtp
            Me.btnCreate = New ubiLease.CommonControls.btn
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpPaymentDt = New ubiLease.CommonControls.dtp
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.grd_1.Location = New System.Drawing.Point(3, 57)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 546)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 3
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(805, 51)
            Me.PictureBox1.TabIndex = 992
            Me.PictureBox1.TabStop = False
            '
            'lblBaseDt
            '
            Me.lblBaseDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBaseDt.Location = New System.Drawing.Point(35, 20)
            Me.lblBaseDt.Name = "lblBaseDt"
            Me.lblBaseDt.Size = New System.Drawing.Size(93, 20)
            Me.lblBaseDt.TabIndex = 4
            Me.lblBaseDt.Text = "임차료 생성 월"
            Me.lblBaseDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpPayYYYYMM
            '
            Me.dtpPayYYYYMM.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPayYYYYMM.BorderColor = System.Drawing.Color.Empty
            Me.dtpPayYYYYMM.BorderStyle = 2
            Me.dtpPayYYYYMM.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPayYYYYMM.CaptionName = "기준년월"
            Me.dtpPayYYYYMM.DateTimeFormatText = "yyyy-MM"
            Me.dtpPayYYYYMM.Location = New System.Drawing.Point(134, 20)
            Me.dtpPayYYYYMM.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPayYYYYMM.MaxLength = 0
            Me.dtpPayYYYYMM.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPayYYYYMM.Name = "dtpPayYYYYMM"
            Me.dtpPayYYYYMM.ReadOnlys = False
            Me.dtpPayYYYYMM.SelectedText = ""
            Me.dtpPayYYYYMM.SelectionLength = 0
            Me.dtpPayYYYYMM.SelectionStart = 0
            Me.dtpPayYYYYMM.Size = New System.Drawing.Size(100, 20)
            Me.dtpPayYYYYMM.TabIndex = 0
            Me.dtpPayYYYYMM.Tag = "format(&&&&-&&);"
            Me.dtpPayYYYYMM.TextAlign = 0
            Me.dtpPayYYYYMM.TextValue = ""
            Me.dtpPayYYYYMM.ToolTipText = ""
            '
            'btnCreate
            '
            Me.btnCreate.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCreate.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCreate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnCreate.Location = New System.Drawing.Point(656, 13)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(121, 32)
            Me.btnCreate.TabIndex = 2
            Me.btnCreate.Text = "월 임차료 생성"
            Me.btnCreate.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(269, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(107, 20)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "임차료 지급 일자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpPaymentDt
            '
            Me.dtpPaymentDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpPaymentDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpPaymentDt.BorderStyle = 2
            Me.dtpPaymentDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpPaymentDt.CaptionName = "임차료 지급일자"
            Me.dtpPaymentDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpPaymentDt.Location = New System.Drawing.Point(376, 20)
            Me.dtpPaymentDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpPaymentDt.MaxLength = 0
            Me.dtpPaymentDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpPaymentDt.Name = "dtpPaymentDt"
            Me.dtpPaymentDt.ReadOnlys = False
            Me.dtpPaymentDt.SelectedText = ""
            Me.dtpPaymentDt.SelectionLength = 0
            Me.dtpPaymentDt.SelectionStart = 0
            Me.dtpPaymentDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpPaymentDt.TabIndex = 1
            Me.dtpPaymentDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpPaymentDt.TextAlign = 0
            Me.dtpPaymentDt.TextValue = ""
            Me.dtpPaymentDt.ToolTipText = ""
            '
            'PNB103
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpPaymentDt)
            Me.Controls.Add(Me.btnCreate)
            Me.Controls.Add(Me.lblBaseDt)
            Me.Controls.Add(Me.dtpPayYYYYMM)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNB103"
            Me.Size = New System.Drawing.Size(811, 606)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblBaseDt As System.Windows.Forms.Label
        Friend WithEvents dtpPayYYYYMM As ubiLease.CommonControls.dtp
        Friend WithEvents btnCreate As ubiLease.CommonControls.btn
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpPaymentDt As ubiLease.CommonControls.dtp

    End Class

End Namespace
