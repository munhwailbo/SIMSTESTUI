Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Configuration

Namespace ubiLease.CommonPopup
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReaderInfo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReaderInfo))
            Me.picMain = New ubiLease.CommonControls.picpanel
            Me.Label1 = New System.Windows.Forms.Label
            Me.lblCode = New System.Windows.Forms.Label
            Me.lblName = New System.Windows.Forms.Label
            Me.Txt1 = New ubiLease.CommonControls.txt
            Me.txtCode = New ubiLease.CommonControls.txt
            Me.txtName = New ubiLease.CommonControls.txt
            Me.btnRequestData = New ubiLease.CommonControls.btn
            Me.txtName2 = New ubiLease.CommonControls.txt
            Me.txtWhere = New ubiLease.CommonControls.txt
            Me.btnNewReader = New ubiLease.CommonControls.btn
            Me.btnNo = New ubiLease.CommonControls.btn
            Me.grdMain = New ubiLease.GridControl.grd
            Me.btnReReader = New ubiLease.CommonControls.btn
            Me.btnMoveReader = New ubiLease.CommonControls.btn
            Me.btnStopReader = New ubiLease.CommonControls.btn
            Me.picMain.SuspendLayout()
            CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picMain
            '
            Me.picMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picMain.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picMain.Controls.Add(Me.Label1)
            Me.picMain.Controls.Add(Me.lblCode)
            Me.picMain.Controls.Add(Me.lblName)
            Me.picMain.Controls.Add(Me.Txt1)
            Me.picMain.Controls.Add(Me.txtCode)
            Me.picMain.Controls.Add(Me.txtName)
            Me.picMain.Controls.Add(Me.btnRequestData)
            Me.picMain.Location = New System.Drawing.Point(1, 2)
            Me.picMain.Name = "picMain"
            Me.picMain.Size = New System.Drawing.Size(498, 69)
            Me.picMain.TabIndex = 13
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(3, 36)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(56, 20)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "주소"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblCode
            '
            Me.lblCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.lblCode.Location = New System.Drawing.Point(3, 10)
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
            Me.lblName.Location = New System.Drawing.Point(186, 10)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(56, 20)
            Me.lblName.TabIndex = 1
            Me.lblName.Text = "전화번호"
            Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Txt1
            '
            Me.Txt1.BackColor = System.Drawing.SystemColors.Window
            Me.Txt1.BorderColor = System.Drawing.Color.Empty
            Me.Txt1.BorderStyle = 2
            Me.Txt1.CaptionName = Nothing
            Me.Txt1.Location = New System.Drawing.Point(65, 36)
            Me.Txt1.MaxLength = 32767
            Me.Txt1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Txt1.Multiline = False
            Me.Txt1.Name = "Txt1"
            Me.Txt1.ReadOnlys = False
            Me.Txt1.SelectedText = ""
            Me.Txt1.SelectionLength = 0
            Me.Txt1.SelectionStart = 0
            Me.Txt1.Size = New System.Drawing.Size(333, 20)
            Me.Txt1.TabIndex = 0
            Me.Txt1.Tag = Nothing
            Me.Txt1.TextAlign = 0
            Me.Txt1.TextValue = ""
            Me.Txt1.ToolTipText = ""
            '
            'txtCode
            '
            Me.txtCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtCode.BorderColor = System.Drawing.Color.Empty
            Me.txtCode.BorderStyle = 2
            Me.txtCode.CaptionName = Nothing
            Me.txtCode.Location = New System.Drawing.Point(65, 10)
            Me.txtCode.MaxLength = 32767
            Me.txtCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCode.Multiline = False
            Me.txtCode.Name = "txtCode"
            Me.txtCode.ReadOnlys = False
            Me.txtCode.SelectedText = ""
            Me.txtCode.SelectionLength = 0
            Me.txtCode.SelectionStart = 0
            Me.txtCode.Size = New System.Drawing.Size(110, 20)
            Me.txtCode.TabIndex = 0
            Me.txtCode.Tag = Nothing
            Me.txtCode.TextAlign = 0
            Me.txtCode.TextValue = ""
            Me.txtCode.ToolTipText = ""
            '
            'txtName
            '
            Me.txtName.BackColor = System.Drawing.SystemColors.Window
            Me.txtName.BorderColor = System.Drawing.Color.Empty
            Me.txtName.BorderStyle = 2
            Me.txtName.CaptionName = Nothing
            Me.txtName.Location = New System.Drawing.Point(248, 10)
            Me.txtName.MaxLength = 32767
            Me.txtName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtName.Multiline = False
            Me.txtName.Name = "txtName"
            Me.txtName.ReadOnlys = False
            Me.txtName.SelectedText = ""
            Me.txtName.SelectionLength = 0
            Me.txtName.SelectionStart = 0
            Me.txtName.Size = New System.Drawing.Size(150, 20)
            Me.txtName.TabIndex = 1
            Me.txtName.Tag = Nothing
            Me.txtName.TextAlign = 0
            Me.txtName.TextValue = ""
            Me.txtName.ToolTipText = ""
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
            Me.btnRequestData.Location = New System.Drawing.Point(418, 9)
            Me.btnRequestData.Name = "btnRequestData"
            Me.btnRequestData.Size = New System.Drawing.Size(61, 46)
            Me.btnRequestData.TabIndex = 2
            Me.btnRequestData.Text = "조회"
            Me.btnRequestData.UseVisualStyleBackColor = False
            '
            'txtName2
            '
            Me.txtName2.BackColor = System.Drawing.SystemColors.Window
            Me.txtName2.BorderColor = System.Drawing.Color.Empty
            Me.txtName2.BorderStyle = 2
            Me.txtName2.CaptionName = Nothing
            Me.txtName2.Location = New System.Drawing.Point(306, 332)
            Me.txtName2.MaxLength = 32767
            Me.txtName2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtName2.Multiline = False
            Me.txtName2.Name = "txtName2"
            Me.txtName2.ReadOnlys = False
            Me.txtName2.SelectedText = ""
            Me.txtName2.SelectionLength = 0
            Me.txtName2.SelectionStart = 0
            Me.txtName2.Size = New System.Drawing.Size(20, 20)
            Me.txtName2.TabIndex = 8
            Me.txtName2.Tag = Nothing
            Me.txtName2.TextAlign = 0
            Me.txtName2.TextValue = ""
            Me.txtName2.ToolTipText = ""
            Me.txtName2.Visible = False
            '
            'txtWhere
            '
            Me.txtWhere.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtWhere.BackColor = System.Drawing.SystemColors.Window
            Me.txtWhere.BorderColor = System.Drawing.Color.Empty
            Me.txtWhere.BorderStyle = 2
            Me.txtWhere.CaptionName = Nothing
            Me.txtWhere.Location = New System.Drawing.Point(1, 332)
            Me.txtWhere.MaxLength = 32767
            Me.txtWhere.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtWhere.Multiline = False
            Me.txtWhere.Name = "txtWhere"
            Me.txtWhere.ReadOnlys = False
            Me.txtWhere.SelectedText = ""
            Me.txtWhere.SelectionLength = 0
            Me.txtWhere.SelectionStart = 0
            Me.txtWhere.Size = New System.Drawing.Size(299, 20)
            Me.txtWhere.TabIndex = 12
            Me.txtWhere.Tag = Nothing
            Me.txtWhere.TextAlign = 0
            Me.txtWhere.TextValue = ""
            Me.txtWhere.ToolTipText = ""
            Me.txtWhere.Visible = False
            '
            'btnNewReader
            '
            Me.btnNewReader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNewReader.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNewReader.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnNewReader.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNewReader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnNewReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnNewReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNewReader.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnNewReader.Location = New System.Drawing.Point(7, 358)
            Me.btnNewReader.Name = "btnNewReader"
            Me.btnNewReader.Size = New System.Drawing.Size(84, 27)
            Me.btnNewReader.TabIndex = 10
            Me.btnNewReader.Text = "신규독자"
            Me.btnNewReader.UseVisualStyleBackColor = False
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
            Me.btnNo.Location = New System.Drawing.Point(438, 358)
            Me.btnNo.Name = "btnNo"
            Me.btnNo.Size = New System.Drawing.Size(61, 27)
            Me.btnNo.TabIndex = 11
            Me.btnNo.Text = "취소"
            Me.btnNo.UseVisualStyleBackColor = False
            '
            'grdMain
            '
            Me.grdMain.AllowBigSelection = False
            Me.grdMain.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grdMain.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grdMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grdMain.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grdMain.Cols = 5
            Me.grdMain.ColumnInfo = resources.GetString("grdMain.ColumnInfo")
            Me.grdMain.ExplorerBar = 0
            Me.grdMain.ExtendLastCol = True
            Me.grdMain.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grdMain.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grdMain.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grdMain.Location = New System.Drawing.Point(1, 77)
            Me.grdMain.Name = "grdMain"
            Me.grdMain.NodeClosedPicture = Nothing
            Me.grdMain.NodeOpenPicture = Nothing
            Me.grdMain.OutlineCol = -1
            Me.grdMain.RowHeightMax = 18
            Me.grdMain.RowHeightMin = 15
            Me.grdMain.Rows = 1
            Me.grdMain.Size = New System.Drawing.Size(498, 275)
            Me.grdMain.StyleInfo = resources.GetString("grdMain.StyleInfo")
            Me.grdMain.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grdMain.TabIndex = 9
            Me.grdMain.TreeColor = System.Drawing.Color.DarkGray
            '
            'btnReReader
            '
            Me.btnReReader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnReReader.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnReReader.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnReReader.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnReReader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnReReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnReReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnReReader.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnReReader.Location = New System.Drawing.Point(97, 358)
            Me.btnReReader.Name = "btnReReader"
            Me.btnReReader.Size = New System.Drawing.Size(84, 27)
            Me.btnReReader.TabIndex = 14
            Me.btnReReader.Text = "재확장"
            Me.btnReReader.UseVisualStyleBackColor = False
            '
            'btnMoveReader
            '
            Me.btnMoveReader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnMoveReader.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMoveReader.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnMoveReader.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnMoveReader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnMoveReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnMoveReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnMoveReader.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnMoveReader.Location = New System.Drawing.Point(187, 358)
            Me.btnMoveReader.Name = "btnMoveReader"
            Me.btnMoveReader.Size = New System.Drawing.Size(84, 27)
            Me.btnMoveReader.TabIndex = 15
            Me.btnMoveReader.Text = "이사독자"
            Me.btnMoveReader.UseVisualStyleBackColor = False
            '
            'btnStopReader
            '
            Me.btnStopReader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnStopReader.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnStopReader.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnStopReader.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnStopReader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnStopReader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnStopReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnStopReader.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnStopReader.Location = New System.Drawing.Point(277, 358)
            Me.btnStopReader.Name = "btnStopReader"
            Me.btnStopReader.Size = New System.Drawing.Size(84, 27)
            Me.btnStopReader.TabIndex = 16
            Me.btnStopReader.Text = "중지독자"
            Me.btnStopReader.UseVisualStyleBackColor = False
            '
            'frmReaderInfo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(501, 388)
            Me.Controls.Add(Me.btnStopReader)
            Me.Controls.Add(Me.btnMoveReader)
            Me.Controls.Add(Me.btnReReader)
            Me.Controls.Add(Me.picMain)
            Me.Controls.Add(Me.txtName2)
            Me.Controls.Add(Me.txtWhere)
            Me.Controls.Add(Me.btnNewReader)
            Me.Controls.Add(Me.btnNo)
            Me.Controls.Add(Me.grdMain)
            Me.Name = "frmReaderInfo"
            Me.Text = "frmReaderInfo"
            Me.picMain.ResumeLayout(False)
            CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents picMain As ubiLease.CommonControls.picpanel
        Friend WithEvents lblCode As System.Windows.Forms.Label
        Friend WithEvents lblName As System.Windows.Forms.Label
        Friend WithEvents txtCode As ubiLease.CommonControls.txt
        Friend WithEvents txtName As ubiLease.CommonControls.txt
        Friend WithEvents btnRequestData As ubiLease.CommonControls.btn
        Friend WithEvents txtName2 As ubiLease.CommonControls.txt
        Friend WithEvents txtWhere As ubiLease.CommonControls.txt
        Friend WithEvents btnNewReader As ubiLease.CommonControls.btn
        Friend WithEvents btnNo As ubiLease.CommonControls.btn
        Friend WithEvents grdMain As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Txt1 As ubiLease.CommonControls.txt
        Friend WithEvents btnReReader As ubiLease.CommonControls.btn
        Friend WithEvents btnMoveReader As ubiLease.CommonControls.btn
        Friend WithEvents btnStopReader As ubiLease.CommonControls.btn
    End Class
End Namespace
