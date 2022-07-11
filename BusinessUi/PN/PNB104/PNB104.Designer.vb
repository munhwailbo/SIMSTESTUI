Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNB104
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNB104))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.Dtp1 = New ubiLease.CommonControls.dtp
            Me.Txt1 = New ubiLease.CommonControls.txt
            Me.Label27 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.Pop3 = New ubiLease.CommonControls.pop
            Me.Label13 = New System.Windows.Forms.Label
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
            Me.grd_1.Location = New System.Drawing.Point(3, 82)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 521)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(580, 21)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(54, 20)
            Me.Label1.TabIndex = 1018
            Me.Label1.Text = "지급년월"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Dtp1
            '
            Me.Dtp1.BackColor = System.Drawing.SystemColors.Window
            Me.Dtp1.BorderColor = System.Drawing.Color.Empty
            Me.Dtp1.BorderStyle = 2
            Me.Dtp1.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Dtp1.CaptionName = "업무일지일자"
            Me.Dtp1.DateTimeFormatText = "yyyy-MM-dd"
            Me.Dtp1.Location = New System.Drawing.Point(640, 21)
            Me.Dtp1.MaximumSize = New System.Drawing.Size(500, 20)
            Me.Dtp1.MaxLength = 0
            Me.Dtp1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Dtp1.Name = "Dtp1"
            Me.Dtp1.ReadOnlys = True
            Me.Dtp1.SelectedText = ""
            Me.Dtp1.SelectionLength = 0
            Me.Dtp1.SelectionStart = 0
            Me.Dtp1.Size = New System.Drawing.Size(104, 20)
            Me.Dtp1.TabIndex = 1017
            Me.Dtp1.TabStop = False
            Me.Dtp1.Tag = "format(&&&&-&&-&&);"
            Me.Dtp1.TextAlign = 0
            Me.Dtp1.TextValue = Nothing
            Me.Dtp1.ToolTipText = ""
            '
            'Txt1
            '
            Me.Txt1.BackColor = System.Drawing.SystemColors.Window
            Me.Txt1.BorderColor = System.Drawing.Color.Empty
            Me.Txt1.BorderStyle = 2
            Me.Txt1.CaptionName = "차수"
            Me.Txt1.Enabled = False
            Me.Txt1.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.Txt1.Location = New System.Drawing.Point(432, 23)
            Me.Txt1.MaxLength = 50
            Me.Txt1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Txt1.Multiline = False
            Me.Txt1.Name = "Txt1"
            Me.Txt1.ReadOnlys = False
            Me.Txt1.SelectedText = ""
            Me.Txt1.SelectionLength = 0
            Me.Txt1.SelectionStart = 0
            Me.Txt1.Size = New System.Drawing.Size(83, 20)
            Me.Txt1.TabIndex = 1015
            Me.Txt1.Tag = ""
            Me.Txt1.TextAlign = 0
            Me.Txt1.TextValue = ""
            Me.Txt1.ToolTipText = ""
            Me.Txt1.Visible = True
            '
            'Label27
            '
            Me.Label27.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label27.Location = New System.Drawing.Point(373, 22)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(53, 19)
            Me.Label27.TabIndex = 1014
            Me.Label27.Text = "이전횟수"
            Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(805, 73)
            Me.PictureBox1.TabIndex = 1010
            Me.PictureBox1.TabStop = False
            '
            'Pop3
            '
            Me.Pop3.BorderColor = System.Drawing.Color.Empty
            Me.Pop3.BorderStyle = 2
            Me.Pop3.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.Pop3.CaptionName = "사원 명"
            Me.Pop3.CodeText = ""
            Me.Pop3.CodeWidth = 60
            Me.Pop3.Location = New System.Drawing.Point(130, 23)
            Me.Pop3.MaximumSize = New System.Drawing.Size(800, 20)
            Me.Pop3.MaxLength = 6
            Me.Pop3.MinimumSize = New System.Drawing.Size(19, 20)
            Me.Pop3.Name = "Pop3"
            Me.Pop3.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.Pop3.NameText = ""
            Me.Pop3.ReadOnlys = False
            Me.Pop3.SelectedText = ""
            Me.Pop3.SelectionLength = 0
            Me.Pop3.SelectionStart = 0
            Me.Pop3.Size = New System.Drawing.Size(177, 20)
            Me.Pop3.TabIndex = 1093
            Me.Pop3.Tag = "need;code(사원 명);"
            Me.Pop3.TextAlign = 0
            Me.Pop3.TextValue = ""
            Me.Pop3.ToolTipText = ""
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label13.Location = New System.Drawing.Point(71, 23)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(53, 20)
            Me.Label13.TabIndex = 1090
            Me.Label13.Text = "지국코드"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PNB104
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Pop3)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Dtp1)
            Me.Controls.Add(Me.Txt1)
            Me.Controls.Add(Me.Label27)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNB104"
            Me.Size = New System.Drawing.Size(811, 606)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Dtp1 As ubiLease.CommonControls.dtp
        Friend WithEvents Txt1 As ubiLease.CommonControls.txt
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents Pop3 As ubiLease.CommonControls.pop
        Friend WithEvents Label13 As System.Windows.Forms.Label

    End Class

End Namespace
