Namespace ubiLease.UI.BusinessUi.BM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class BMA103
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMA103))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblStandardDate = New System.Windows.Forms.Label
            Me.dtpStandardDate = New ubiLease.CommonControls.dtp
            Me.chkSubjectYON = New ubiLease.CommonControls.chk
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 46)
            Me.picCriteria_1.TabIndex = 2
            Me.picCriteria_1.TabStop = False
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
            Me.grd_1.Font = New System.Drawing.Font("����", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 57)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 583)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblStandardDate
            '
            Me.lblStandardDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lblStandardDate.Font = New System.Drawing.Font("����ü", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblStandardDate.Location = New System.Drawing.Point(29, 21)
            Me.lblStandardDate.Name = "lblStandardDate"
            Me.lblStandardDate.Size = New System.Drawing.Size(61, 15)
            Me.lblStandardDate.TabIndex = 1679
            Me.lblStandardDate.Text = "��������"
            Me.lblStandardDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpStandardDate
            '
            Me.dtpStandardDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpStandardDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpStandardDate.BorderStyle = 2
            Me.dtpStandardDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpStandardDate.CaptionName = "��������"
            Me.dtpStandardDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpStandardDate.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpStandardDate.Location = New System.Drawing.Point(95, 18)
            Me.dtpStandardDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpStandardDate.MaxLength = 0
            Me.dtpStandardDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpStandardDate.Name = "dtpStandardDate"
            Me.dtpStandardDate.ReadOnlys = False
            Me.dtpStandardDate.SelectedText = ""
            Me.dtpStandardDate.SelectionLength = 0
            Me.dtpStandardDate.SelectionStart = 0
            Me.dtpStandardDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpStandardDate.TabIndex = 1678
            Me.dtpStandardDate.Tag = "need;format(####-##-##);"
            Me.dtpStandardDate.TextAlign = 0
            Me.dtpStandardDate.TextValue = ""
            Me.dtpStandardDate.ToolTipText = ""
            '
            'chkSubjectYON
            '
            Me.chkSubjectYON.AutoSize = True
            Me.chkSubjectYON.BackColor = System.Drawing.Color.GhostWhite
            Me.chkSubjectYON.CaptionName = "Ż�������Կ���"
            Me.chkSubjectYON.FlatAppearance.CheckedBackColor = System.Drawing.Color.GhostWhite
            Me.chkSubjectYON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite
            Me.chkSubjectYON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.chkSubjectYON.Font = New System.Drawing.Font("����ü", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.chkSubjectYON.Location = New System.Drawing.Point(201, 20)
            Me.chkSubjectYON.Name = "chkSubjectYON"
            Me.chkSubjectYON.ReadOnlys = False
            Me.chkSubjectYON.Size = New System.Drawing.Size(84, 16)
            Me.chkSubjectYON.TabIndex = 1682
            Me.chkSubjectYON.Tag = ""
            Me.chkSubjectYON.Text = "Ż��������"
            Me.chkSubjectYON.TextValue = "0"
            Me.chkSubjectYON.UseVisualStyleBackColor = False
            '
            'BMA103
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblStandardDate)
            Me.Controls.Add(Me.chkSubjectYON)
            Me.Controls.Add(Me.dtpStandardDate)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "BMA103"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.dtpStandardDate, 0)
            Me.Controls.SetChildIndex(Me.chkSubjectYON, 0)
            Me.Controls.SetChildIndex(Me.lblStandardDate, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblStandardDate As System.Windows.Forms.Label
        Friend WithEvents dtpStandardDate As ubiLease.CommonControls.dtp
        Friend WithEvents chkSubjectYON As ubiLease.CommonControls.chk

    End Class

End Namespace
