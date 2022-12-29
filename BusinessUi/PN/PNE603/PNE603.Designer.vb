Namespace ubiLease.UI.BusinessUi.SM

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class PNE603
        Inherits CommonControls.UiControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE603))
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox()
            Me.grd_1 = New ubiLease.GridControl.grd()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpExpandDt = New ubiLease.CommonControls.dtp()
            Me.btnBasketPrint = New System.Windows.Forms.Button()
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
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 46)
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
            Me.grd_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(5, 56)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(802, 586)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 2
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(26, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 20)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "확장일"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpExpandDt
            '
            Me.dtpExpandDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpExpandDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpExpandDt.BorderStyle = 2
            Me.dtpExpandDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpExpandDt.CaptionName = "확장일자"
            Me.dtpExpandDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpExpandDt.Location = New System.Drawing.Point(94, 18)
            Me.dtpExpandDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpExpandDt.MaxLength = 0
            Me.dtpExpandDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpExpandDt.Name = "dtpExpandDt"
            Me.dtpExpandDt.ReadOnlys = False
            Me.dtpExpandDt.SelectedText = ""
            Me.dtpExpandDt.SelectionLength = 0
            Me.dtpExpandDt.SelectionStart = 0
            Me.dtpExpandDt.Size = New System.Drawing.Size(135, 20)
            Me.dtpExpandDt.TabIndex = 9
            Me.dtpExpandDt.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpExpandDt.TextAlign = 0
            Me.dtpExpandDt.TextValue = ""
            Me.dtpExpandDt.ToolTipText = ""
            '
            'btnBasketPrint
            '
            Me.btnBasketPrint.Location = New System.Drawing.Point(576, 13)
            Me.btnBasketPrint.Name = "btnBasketPrint"
            Me.btnBasketPrint.Size = New System.Drawing.Size(142, 25)
            Me.btnBasketPrint.TabIndex = 1678
            Me.btnBasketPrint.Text = "바스켓 그룹 출력"
            Me.btnBasketPrint.UseVisualStyleBackColor = True
            '
            'PNE603
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.btnBasketPrint)
            Me.Controls.Add(Me.dtpExpandDt)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNE603"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.dtpExpandDt, 0)
            Me.Controls.SetChildIndex(Me.btnBasketPrint, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpExpandDt As CommonControls.dtp
        Friend WithEvents btnBasketPrint As System.Windows.Forms.Button
    End Class

End Namespace
