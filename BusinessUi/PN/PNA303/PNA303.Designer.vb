Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNA303
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNA303))
            Me.Label2 = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblRepresentativeName = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.txtRepresentativeName = New ubiLease.CommonControls.txt
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Location = New System.Drawing.Point(3, 52)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(434, 14)
            Me.Label2.TabIndex = 794
            Me.Label2.Text = "지국-담당자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.grd_1.Location = New System.Drawing.Point(3, 69)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(805, 520)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 790
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblRepresentativeName
            '
            Me.lblRepresentativeName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRepresentativeName.Location = New System.Drawing.Point(12, 19)
            Me.lblRepresentativeName.Name = "lblRepresentativeName"
            Me.lblRepresentativeName.Size = New System.Drawing.Size(51, 14)
            Me.lblRepresentativeName.TabIndex = 784
            Me.lblRepresentativeName.Text = "담당자"
            Me.lblRepresentativeName.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(3, 3)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(805, 46)
            Me.picCriteria_1.TabIndex = 781
            Me.picCriteria_1.TabStop = False
            '
            'txtRepresentativeName
            '
            Me.txtRepresentativeName.BackColor = System.Drawing.Color.White
            Me.txtRepresentativeName.BorderColor = System.Drawing.Color.Empty
            Me.txtRepresentativeName.BorderStyle = 2
            Me.txtRepresentativeName.CaptionName = "지국장 명"
            Me.txtRepresentativeName.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.txtRepresentativeName.Location = New System.Drawing.Point(69, 13)
            Me.txtRepresentativeName.MaxLength = 50
            Me.txtRepresentativeName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRepresentativeName.Multiline = False
            Me.txtRepresentativeName.Name = "txtRepresentativeName"
            Me.txtRepresentativeName.ReadOnlys = False
            Me.txtRepresentativeName.SelectedText = ""
            Me.txtRepresentativeName.SelectionLength = 0
            Me.txtRepresentativeName.SelectionStart = 0
            Me.txtRepresentativeName.Size = New System.Drawing.Size(130, 20)
            Me.txtRepresentativeName.TabIndex = 1092
            Me.txtRepresentativeName.Tag = ""
            Me.txtRepresentativeName.TextAlign = 0
            Me.txtRepresentativeName.TextValue = ""
            Me.txtRepresentativeName.ToolTipText = ""
            '
            'PNA303
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.txtRepresentativeName)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.lblRepresentativeName)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Name = "PNA303"
            Me.Size = New System.Drawing.Size(811, 592)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents lblRepresentativeName As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents txtRepresentativeName As ubiLease.CommonControls.txt


    End Class

End Namespace
