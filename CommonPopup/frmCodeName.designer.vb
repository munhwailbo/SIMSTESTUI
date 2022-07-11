Namespace ubiLease.CommonPopup

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCodeName
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodeName))
            Me.pnlMain = New System.Windows.Forms.Panel
            Me.picMain = New ubiLease.CommonControls.picpanel
            Me.lblCode = New System.Windows.Forms.Label
            Me.lblName = New System.Windows.Forms.Label
            Me.txtCode = New ubiLease.CommonControls.txt
            Me.txtName = New ubiLease.CommonControls.txt
            Me.btnRequestData = New ubiLease.CommonControls.btn
            Me.txtName2 = New ubiLease.CommonControls.txt
            Me.lblName2 = New System.Windows.Forms.Label
            Me.txtWhere = New ubiLease.CommonControls.txt
            Me.btnYes = New ubiLease.CommonControls.btn
            Me.btnNo = New ubiLease.CommonControls.btn
            Me.grdMain = New ubiLease.GridControl.grd
            Me.pnlMain.SuspendLayout()
            Me.picMain.SuspendLayout()
            CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.GhostWhite
            Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlMain.Controls.Add(Me.picMain)
            Me.pnlMain.Controls.Add(Me.txtName2)
            Me.pnlMain.Controls.Add(Me.lblName2)
            Me.pnlMain.Controls.Add(Me.txtWhere)
            Me.pnlMain.Controls.Add(Me.btnYes)
            Me.pnlMain.Controls.Add(Me.btnNo)
            Me.pnlMain.Controls.Add(Me.grdMain)
            resources.ApplyResources(Me.pnlMain, "pnlMain")
            Me.pnlMain.Name = "pnlMain"
            '
            'picMain
            '
            resources.ApplyResources(Me.picMain, "picMain")
            Me.picMain.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picMain.Controls.Add(Me.lblCode)
            Me.picMain.Controls.Add(Me.lblName)
            Me.picMain.Controls.Add(Me.txtCode)
            Me.picMain.Controls.Add(Me.txtName)
            Me.picMain.Controls.Add(Me.btnRequestData)
            Me.picMain.Name = "picMain"
            '
            'lblCode
            '
            Me.lblCode.BackColor = System.Drawing.Color.WhiteSmoke
            resources.ApplyResources(Me.lblCode, "lblCode")
            Me.lblCode.Name = "lblCode"
            '
            'lblName
            '
            Me.lblName.BackColor = System.Drawing.Color.WhiteSmoke
            resources.ApplyResources(Me.lblName, "lblName")
            Me.lblName.Name = "lblName"
            '
            'txtCode
            '
            Me.txtCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtCode.BorderColor = System.Drawing.Color.Empty
            Me.txtCode.BorderStyle = 2
            Me.txtCode.CaptionName = Nothing
            resources.ApplyResources(Me.txtCode, "txtCode")
            Me.txtCode.MaxLength = 32767
            Me.txtCode.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCode.Multiline = False
            Me.txtCode.Name = "txtCode"
            Me.txtCode.ReadOnlys = False
            Me.txtCode.SelectedText = ""
            Me.txtCode.SelectionLength = 0
            Me.txtCode.SelectionStart = 0
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
            resources.ApplyResources(Me.txtName, "txtName")
            Me.txtName.MaxLength = 32767
            Me.txtName.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtName.Multiline = False
            Me.txtName.Name = "txtName"
            Me.txtName.ReadOnlys = False
            Me.txtName.SelectedText = ""
            Me.txtName.SelectionLength = 0
            Me.txtName.SelectionStart = 0
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
            resources.ApplyResources(Me.btnRequestData, "btnRequestData")
            Me.btnRequestData.Name = "btnRequestData"
            Me.btnRequestData.UseVisualStyleBackColor = False
            '
            'txtName2
            '
            Me.txtName2.BackColor = System.Drawing.SystemColors.Window
            Me.txtName2.BorderColor = System.Drawing.Color.Empty
            Me.txtName2.BorderStyle = 2
            Me.txtName2.CaptionName = Nothing
            resources.ApplyResources(Me.txtName2, "txtName2")
            Me.txtName2.MaxLength = 32767
            Me.txtName2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtName2.Multiline = False
            Me.txtName2.Name = "txtName2"
            Me.txtName2.ReadOnlys = False
            Me.txtName2.SelectedText = ""
            Me.txtName2.SelectionLength = 0
            Me.txtName2.SelectionStart = 0
            Me.txtName2.Tag = Nothing
            Me.txtName2.TextAlign = 0
            Me.txtName2.TextValue = ""
            Me.txtName2.ToolTipText = ""
            '
            'lblName2
            '
            Me.lblName2.BackColor = System.Drawing.Color.WhiteSmoke
            resources.ApplyResources(Me.lblName2, "lblName2")
            Me.lblName2.Name = "lblName2"
            '
            'txtWhere
            '
            resources.ApplyResources(Me.txtWhere, "txtWhere")
            Me.txtWhere.BackColor = System.Drawing.SystemColors.Window
            Me.txtWhere.BorderColor = System.Drawing.Color.Empty
            Me.txtWhere.BorderStyle = 2
            Me.txtWhere.CaptionName = Nothing
            Me.txtWhere.MaxLength = 32767
            Me.txtWhere.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtWhere.Multiline = False
            Me.txtWhere.Name = "txtWhere"
            Me.txtWhere.ReadOnlys = False
            Me.txtWhere.SelectedText = ""
            Me.txtWhere.SelectionLength = 0
            Me.txtWhere.SelectionStart = 0
            Me.txtWhere.Tag = Nothing
            Me.txtWhere.TextAlign = 0
            Me.txtWhere.TextValue = ""
            Me.txtWhere.ToolTipText = ""
            '
            'btnYes
            '
            resources.ApplyResources(Me.btnYes, "btnYes")
            Me.btnYes.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnYes.Name = "btnYes"
            Me.btnYes.UseVisualStyleBackColor = False
            '
            'btnNo
            '
            resources.ApplyResources(Me.btnNo, "btnNo")
            Me.btnNo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnNo.Name = "btnNo"
            Me.btnNo.UseVisualStyleBackColor = False
            '
            'grdMain
            '
            Me.grdMain.AllowBigSelection = False
            Me.grdMain.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grdMain.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            resources.ApplyResources(Me.grdMain, "grdMain")
            Me.grdMain.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grdMain.Cols = 5
            Me.grdMain.ExplorerBar = 0
            Me.grdMain.ExtendLastCol = True
            Me.grdMain.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grdMain.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grdMain.Name = "grdMain"
            Me.grdMain.NodeClosedPicture = Nothing
            Me.grdMain.NodeOpenPicture = Nothing
            Me.grdMain.OutlineCol = -1
            Me.grdMain.RowHeightMax = 18
            Me.grdMain.RowHeightMin = 15
            Me.grdMain.Rows = 1
            Me.grdMain.StyleInfo = resources.GetString("grdMain.StyleInfo")
            Me.grdMain.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grdMain.TreeColor = System.Drawing.Color.DarkGray
            '
            'frmCodeName
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlMain)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmCodeName"
            Me.ShowInTaskbar = False
            Me.pnlMain.ResumeLayout(False)
            Me.picMain.ResumeLayout(False)
            CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents txtName As CommonControls.txt
        Friend WithEvents txtCode As CommonControls.txt
        Friend WithEvents lblName As System.Windows.Forms.Label
        Friend WithEvents lblCode As System.Windows.Forms.Label
        Friend WithEvents grdMain As GridControl.grd
        Friend WithEvents btnRequestData As ubiLease.CommonControls.btn
        Friend WithEvents btnYes As ubiLease.CommonControls.btn
        Friend WithEvents btnNo As ubiLease.CommonControls.btn
        Friend WithEvents txtWhere As ubiLease.CommonControls.txt
        Friend WithEvents txtName2 As ubiLease.CommonControls.txt
        Friend WithEvents lblName2 As System.Windows.Forms.Label
        Friend WithEvents picMain As ubiLease.CommonControls.picpanel
    End Class

End Namespace


