Namespace ubiLease.CommonPopup
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmExistReader
        Inherits System.Windows.Forms.Form

        'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Windows Form 디자이너에 필요합니다.
        Private components As System.ComponentModel.IContainer

        '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
        '수정하려면 Windows Form 디자이너를 사용하십시오.  
        '코드 편집기를 사용하여 수정하지 마십시오.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExistReader))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picMain = New ubiLease.CommonControls.picpanel
            Me.Chk4 = New ubiLease.CommonControls.chk
            Me.Chk3 = New ubiLease.CommonControls.chk
            Me.Chk2 = New ubiLease.CommonControls.chk
            Me.Chk1 = New ubiLease.CommonControls.chk
            Me.Label1 = New System.Windows.Forms.Label
            Me.TxtAddr = New ubiLease.CommonControls.txt
            Me.lblCode = New System.Windows.Forms.Label
            Me.lblName = New System.Windows.Forms.Label
            Me.txtDokName = New ubiLease.CommonControls.txt
            Me.txtTelNum = New ubiLease.CommonControls.txt
            Me.btnRequestData = New ubiLease.CommonControls.btn
            Me.btnNo = New ubiLease.CommonControls.btn
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.picMain.SuspendLayout()
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
            Me.grd_1.Location = New System.Drawing.Point(0, 80)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(516, 378)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 15
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picMain
            '
            Me.picMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picMain.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picMain.Controls.Add(Me.Chk4)
            Me.picMain.Controls.Add(Me.Chk3)
            Me.picMain.Controls.Add(Me.Chk2)
            Me.picMain.Controls.Add(Me.Chk1)
            Me.picMain.Controls.Add(Me.Label1)
            Me.picMain.Controls.Add(Me.TxtAddr)
            Me.picMain.Controls.Add(Me.lblCode)
            Me.picMain.Controls.Add(Me.lblName)
            Me.picMain.Controls.Add(Me.txtDokName)
            Me.picMain.Controls.Add(Me.txtTelNum)
            Me.picMain.Controls.Add(Me.btnRequestData)
            Me.picMain.Location = New System.Drawing.Point(0, 2)
            Me.picMain.Name = "picMain"
            Me.picMain.Size = New System.Drawing.Size(516, 72)
            Me.picMain.TabIndex = 14
            '
            'Chk4
            '
            Me.Chk4.AutoSize = True
            Me.Chk4.CaptionName = Nothing
            Me.Chk4.Location = New System.Drawing.Point(215, 92)
            Me.Chk4.Name = "Chk4"
            Me.Chk4.ReadOnlys = False
            Me.Chk4.Size = New System.Drawing.Size(100, 16)
            Me.Chk4.TabIndex = 8
            Me.Chk4.Tag = Nothing
            Me.Chk4.Text = "사원확장 포함"
            Me.Chk4.TextValue = "0"
            Me.Chk4.UseVisualStyleBackColor = True
            '
            'Chk3
            '
            Me.Chk3.AutoSize = True
            Me.Chk3.CaptionName = Nothing
            Me.Chk3.Location = New System.Drawing.Point(65, 92)
            Me.Chk3.Name = "Chk3"
            Me.Chk3.ReadOnlys = False
            Me.Chk3.Size = New System.Drawing.Size(100, 16)
            Me.Chk3.TabIndex = 7
            Me.Chk3.Tag = Nothing
            Me.Chk3.Text = "지국확장 포함"
            Me.Chk3.TextValue = "0"
            Me.Chk3.UseVisualStyleBackColor = True
            '
            'Chk2
            '
            Me.Chk2.AutoSize = True
            Me.Chk2.CaptionName = Nothing
            Me.Chk2.Location = New System.Drawing.Point(215, 70)
            Me.Chk2.Name = "Chk2"
            Me.Chk2.ReadOnlys = False
            Me.Chk2.Size = New System.Drawing.Size(72, 16)
            Me.Chk2.TabIndex = 6
            Me.Chk2.Tag = Nothing
            Me.Chk2.Text = "기존독자"
            Me.Chk2.TextValue = "0"
            Me.Chk2.UseVisualStyleBackColor = True
            '
            'Chk1
            '
            Me.Chk1.AutoSize = True
            Me.Chk1.CaptionName = Nothing
            Me.Chk1.Location = New System.Drawing.Point(65, 70)
            Me.Chk1.Name = "Chk1"
            Me.Chk1.ReadOnlys = False
            Me.Chk1.Size = New System.Drawing.Size(72, 16)
            Me.Chk1.TabIndex = 5
            Me.Chk1.Tag = Nothing
            Me.Chk1.Text = "과거독자"
            Me.Chk1.TextValue = "0"
            Me.Chk1.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(3, 39)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(56, 20)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "주소"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtAddr
            '
            Me.TxtAddr.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAddr.BorderColor = System.Drawing.Color.Empty
            Me.TxtAddr.BorderStyle = 2
            Me.TxtAddr.CaptionName = Nothing
            Me.TxtAddr.Location = New System.Drawing.Point(65, 39)
            Me.TxtAddr.MaxLength = 32767
            Me.TxtAddr.MinimumSize = New System.Drawing.Size(20, 20)
            Me.TxtAddr.Multiline = False
            Me.TxtAddr.Name = "TxtAddr"
            Me.TxtAddr.ReadOnlys = False
            Me.TxtAddr.SelectedText = ""
            Me.TxtAddr.SelectionLength = 0
            Me.TxtAddr.SelectionStart = 0
            Me.TxtAddr.Size = New System.Drawing.Size(367, 20)
            Me.TxtAddr.TabIndex = 3
            Me.TxtAddr.Tag = Nothing
            Me.TxtAddr.TextAlign = 0
            Me.TxtAddr.TextValue = ""
            Me.TxtAddr.ToolTipText = ""
            '
            'lblCode
            '
            Me.lblCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.lblCode.Location = New System.Drawing.Point(3, 15)
            Me.lblCode.Name = "lblCode"
            Me.lblCode.Size = New System.Drawing.Size(56, 20)
            Me.lblCode.TabIndex = 0
            Me.lblCode.Text = "독자명"
            Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblName
            '
            Me.lblName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.lblName.Location = New System.Drawing.Point(220, 15)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(56, 20)
            Me.lblName.TabIndex = 1
            Me.lblName.Text = "전화번호"
            Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtDokName
            '
            Me.txtDokName.BackColor = System.Drawing.SystemColors.Window
            Me.txtDokName.BorderColor = System.Drawing.Color.Empty
            Me.txtDokName.BorderStyle = 2
            Me.txtDokName.CaptionName = Nothing
            Me.txtDokName.Location = New System.Drawing.Point(65, 15)
            Me.txtDokName.MaxLength = 32767
            Me.txtDokName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDokName.Multiline = False
            Me.txtDokName.Name = "txtDokName"
            Me.txtDokName.ReadOnlys = False
            Me.txtDokName.SelectedText = ""
            Me.txtDokName.SelectionLength = 0
            Me.txtDokName.SelectionStart = 0
            Me.txtDokName.Size = New System.Drawing.Size(150, 20)
            Me.txtDokName.TabIndex = 0
            Me.txtDokName.Tag = Nothing
            Me.txtDokName.TextAlign = 0
            Me.txtDokName.TextValue = ""
            Me.txtDokName.ToolTipText = ""
            '
            'txtTelNum
            '
            Me.txtTelNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtTelNum.BorderColor = System.Drawing.Color.Empty
            Me.txtTelNum.BorderStyle = 2
            Me.txtTelNum.CaptionName = Nothing
            Me.txtTelNum.Location = New System.Drawing.Point(282, 15)
            Me.txtTelNum.MaxLength = 32767
            Me.txtTelNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtTelNum.Multiline = False
            Me.txtTelNum.Name = "txtTelNum"
            Me.txtTelNum.ReadOnlys = False
            Me.txtTelNum.SelectedText = ""
            Me.txtTelNum.SelectionLength = 0
            Me.txtTelNum.SelectionStart = 0
            Me.txtTelNum.Size = New System.Drawing.Size(150, 20)
            Me.txtTelNum.TabIndex = 1
            Me.txtTelNum.Tag = Nothing
            Me.txtTelNum.TextAlign = 0
            Me.txtTelNum.TextValue = ""
            Me.txtTelNum.ToolTipText = ""
            '
            'btnRequestData
            '
            Me.btnRequestData.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnRequestData.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnRequestData.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnRequestData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnRequestData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnRequestData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnRequestData.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnRequestData.Location = New System.Drawing.Point(438, 15)
            Me.btnRequestData.Name = "btnRequestData"
            Me.btnRequestData.Size = New System.Drawing.Size(61, 20)
            Me.btnRequestData.TabIndex = 2
            Me.btnRequestData.Text = "조회"
            Me.btnRequestData.UseVisualStyleBackColor = False
            '
            'btnNo
            '
            Me.btnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnNo.Location = New System.Drawing.Point(394, 464)
            Me.btnNo.Name = "btnNo"
            Me.btnNo.Size = New System.Drawing.Size(88, 19)
            Me.btnNo.TabIndex = 12
            Me.btnNo.Text = "닫기"
            Me.btnNo.UseVisualStyleBackColor = False
            '
            'frmExistReader
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(517, 486)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picMain)
            Me.Controls.Add(Me.btnNo)
            Me.Name = "frmExistReader"
            Me.Text = "과거독자조회"
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.picMain.ResumeLayout(False)
            Me.picMain.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents picMain As ubiLease.CommonControls.picpanel
        Friend WithEvents lblCode As System.Windows.Forms.Label
        Friend WithEvents lblName As System.Windows.Forms.Label
        Friend WithEvents txtDokName As ubiLease.CommonControls.txt
        Friend WithEvents txtTelNum As ubiLease.CommonControls.txt
        Friend WithEvents btnRequestData As ubiLease.CommonControls.btn
        Friend WithEvents btnNo As ubiLease.CommonControls.btn
        Friend WithEvents Chk4 As ubiLease.CommonControls.chk
        Friend WithEvents Chk3 As ubiLease.CommonControls.chk
        Friend WithEvents Chk2 As ubiLease.CommonControls.chk
        Friend WithEvents Chk1 As ubiLease.CommonControls.chk
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TxtAddr As ubiLease.CommonControls.txt
        Friend WithEvents grd_1 As ubiLease.GridControl.grd

    End Class

End Namespace
