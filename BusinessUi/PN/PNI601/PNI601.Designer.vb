Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI601
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI601))
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.lblSlipDivision = New System.Windows.Forms.Label
            Me.btnExecute = New System.Windows.Forms.Button
            Me.btnCancel = New System.Windows.Forms.Button
            Me.cboSlipDivision = New ubiLease.CommonControls.cbo
            Me.DtpSlipDateSt = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtCriteria = New ubiLease.CommonControls.num
            Me.picIo_1 = New System.Windows.Forms.PictureBox
            Me.dtpSlipDate = New ubiLease.CommonControls.dtp
            Me.lbldtpOriginSlipDate = New System.Windows.Forms.Label
            Me.DtpSlipDateEd = New ubiLease.CommonControls.dtp
            Me.Label4 = New System.Windows.Forms.Label
            Me.DtpExpDate = New ubiLease.CommonControls.dtp
            Me.lblExp = New System.Windows.Forms.Label
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(790, 70)
            Me.picCriteria.TabIndex = 6
            Me.picCriteria.TabStop = False
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
            Me.grd_1.Location = New System.Drawing.Point(5, 133)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(790, 504)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 32
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'lblSlipDivision
            '
            Me.lblSlipDivision.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSlipDivision.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblSlipDivision.Location = New System.Drawing.Point(14, 32)
            Me.lblSlipDivision.Name = "lblSlipDivision"
            Me.lblSlipDivision.Size = New System.Drawing.Size(95, 15)
            Me.lblSlipDivision.TabIndex = 1
            Me.lblSlipDivision.Text = "전표 유형 코드"
            Me.lblSlipDivision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnExecute
            '
            Me.btnExecute.Location = New System.Drawing.Point(584, 92)
            Me.btnExecute.Name = "btnExecute"
            Me.btnExecute.Size = New System.Drawing.Size(100, 25)
            Me.btnExecute.TabIndex = 7
            Me.btnExecute.Text = "전표 유형 처리"
            Me.btnExecute.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.Location = New System.Drawing.Point(690, 92)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(100, 25)
            Me.btnCancel.TabIndex = 8
            Me.btnCancel.Text = "전표 유형 취소"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'cboSlipDivision
            '
            Me.cboSlipDivision.BackColor = System.Drawing.SystemColors.Window
            Me.cboSlipDivision.CaptionName = "전표 유형 코드"
            Me.cboSlipDivision.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.cboSlipDivision.ListCount = 0
            Me.cboSlipDivision.Location = New System.Drawing.Point(115, 29)
            Me.cboSlipDivision.MaxLength = 165
            Me.cboSlipDivision.MinimumSize = New System.Drawing.Size(20, 0)
            Me.cboSlipDivision.Name = "cboSlipDivision"
            Me.cboSlipDivision.ReadOnlys = False
            Me.cboSlipDivision.Size = New System.Drawing.Size(222, 20)
            Me.cboSlipDivision.TabIndex = 129
            Me.cboSlipDivision.Tag = "code(전표 유형 명, 조건|선택하세요);"
            Me.cboSlipDivision.TextValue = ""
            '
            'DtpSlipDateSt
            '
            Me.DtpSlipDateSt.BackColor = System.Drawing.SystemColors.Window
            Me.DtpSlipDateSt.BorderColor = System.Drawing.Color.Empty
            Me.DtpSlipDateSt.BorderStyle = 2
            Me.DtpSlipDateSt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.DtpSlipDateSt.CaptionName = "전표 일자"
            Me.DtpSlipDateSt.DateTimeFormatText = "yyyy-MM-dd"
            Me.DtpSlipDateSt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.DtpSlipDateSt.Location = New System.Drawing.Point(455, 29)
            Me.DtpSlipDateSt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.DtpSlipDateSt.MaxLength = 0
            Me.DtpSlipDateSt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.DtpSlipDateSt.Name = "DtpSlipDateSt"
            Me.DtpSlipDateSt.ReadOnlys = False
            Me.DtpSlipDateSt.SelectedText = ""
            Me.DtpSlipDateSt.SelectionLength = 0
            Me.DtpSlipDateSt.SelectionStart = 0
            Me.DtpSlipDateSt.Size = New System.Drawing.Size(100, 20)
            Me.DtpSlipDateSt.TabIndex = 132
            Me.DtpSlipDateSt.Tag = "format(&&&&-&&-&&);"
            Me.DtpSlipDateSt.TextAlign = 0
            Me.DtpSlipDateSt.TextValue = ""
            Me.DtpSlipDateSt.ToolTipText = "전표 일자"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label1.Location = New System.Drawing.Point(373, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(76, 44)
            Me.Label1.TabIndex = 131
            Me.Label1.Text = "전표일자" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(예정일자)"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtCriteria
            '
            Me.txtCriteria.BackColor = System.Drawing.SystemColors.Window
            Me.txtCriteria.BorderColor = System.Drawing.Color.Empty
            Me.txtCriteria.BorderStyle = 2
            Me.txtCriteria.CaptionName = "조건"
            Me.txtCriteria.LengthPrecision = 7
            Me.txtCriteria.LengthScale = 3
            Me.txtCriteria.Location = New System.Drawing.Point(768, 29)
            Me.txtCriteria.MaximumSize = New System.Drawing.Size(500, 20)
            Me.txtCriteria.MaxLength = 32767
            Me.txtCriteria.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtCriteria.Name = "txtCriteria"
            Me.txtCriteria.ReadOnlys = False
            Me.txtCriteria.SelectedText = ""
            Me.txtCriteria.SelectionLength = 0
            Me.txtCriteria.SelectionStart = 1
            Me.txtCriteria.Size = New System.Drawing.Size(22, 20)
            Me.txtCriteria.TabIndex = 757
            Me.txtCriteria.Tag = ""
            Me.txtCriteria.TextValue = "4"
            Me.txtCriteria.ToolTipText = ""
            Me.txtCriteria.Visible = False
            '
            'picIo_1
            '
            Me.picIo_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picIo_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_1.Location = New System.Drawing.Point(5, 80)
            Me.picIo_1.Name = "picIo_1"
            Me.picIo_1.Size = New System.Drawing.Size(790, 47)
            Me.picIo_1.TabIndex = 771
            Me.picIo_1.TabStop = False
            '
            'dtpSlipDate
            '
            Me.dtpSlipDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpSlipDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpSlipDate.BorderStyle = 2
            Me.dtpSlipDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpSlipDate.CaptionName = "전표 일자"
            Me.dtpSlipDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpSlipDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpSlipDate.Location = New System.Drawing.Point(383, 95)
            Me.dtpSlipDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpSlipDate.MaxLength = 0
            Me.dtpSlipDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpSlipDate.Name = "dtpSlipDate"
            Me.dtpSlipDate.ReadOnlys = False
            Me.dtpSlipDate.SelectedText = ""
            Me.dtpSlipDate.SelectionLength = 0
            Me.dtpSlipDate.SelectionStart = 0
            Me.dtpSlipDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpSlipDate.TabIndex = 777
            Me.dtpSlipDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpSlipDate.TextAlign = 0
            Me.dtpSlipDate.TextValue = ""
            Me.dtpSlipDate.ToolTipText = "전표 일자"
            '
            'lbldtpOriginSlipDate
            '
            Me.lbldtpOriginSlipDate.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lbldtpOriginSlipDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lbldtpOriginSlipDate.Location = New System.Drawing.Point(292, 98)
            Me.lbldtpOriginSlipDate.Name = "lbldtpOriginSlipDate"
            Me.lbldtpOriginSlipDate.Size = New System.Drawing.Size(89, 15)
            Me.lbldtpOriginSlipDate.TabIndex = 776
            Me.lbldtpOriginSlipDate.Text = "전표 처리 일자"
            Me.lbldtpOriginSlipDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'DtpSlipDateEd
            '
            Me.DtpSlipDateEd.BackColor = System.Drawing.SystemColors.Window
            Me.DtpSlipDateEd.BorderColor = System.Drawing.Color.Empty
            Me.DtpSlipDateEd.BorderStyle = 2
            Me.DtpSlipDateEd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.DtpSlipDateEd.CaptionName = "전표 일자"
            Me.DtpSlipDateEd.DateTimeFormatText = "yyyy-MM-dd"
            Me.DtpSlipDateEd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.DtpSlipDateEd.Location = New System.Drawing.Point(596, 29)
            Me.DtpSlipDateEd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.DtpSlipDateEd.MaxLength = 0
            Me.DtpSlipDateEd.MinimumSize = New System.Drawing.Size(20, 20)
            Me.DtpSlipDateEd.Name = "DtpSlipDateEd"
            Me.DtpSlipDateEd.ReadOnlys = False
            Me.DtpSlipDateEd.SelectedText = ""
            Me.DtpSlipDateEd.SelectionLength = 0
            Me.DtpSlipDateEd.SelectionStart = 0
            Me.DtpSlipDateEd.Size = New System.Drawing.Size(100, 20)
            Me.DtpSlipDateEd.TabIndex = 778
            Me.DtpSlipDateEd.Tag = "format(&&&&-&&-&&);"
            Me.DtpSlipDateEd.TextAlign = 0
            Me.DtpSlipDateEd.TextValue = ""
            Me.DtpSlipDateEd.ToolTipText = "전표 일자"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label4.Location = New System.Drawing.Point(566, 33)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(18, 15)
            Me.Label4.TabIndex = 779
            Me.Label4.Text = "~"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'DtpExpDate
            '
            Me.DtpExpDate.BackColor = System.Drawing.SystemColors.Window
            Me.DtpExpDate.BorderColor = System.Drawing.Color.Empty
            Me.DtpExpDate.BorderStyle = 2
            Me.DtpExpDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.DtpExpDate.CaptionName = "전표 일자"
            Me.DtpExpDate.DateTimeFormatText = "yyyy-MM"
            Me.DtpExpDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.DtpExpDate.Location = New System.Drawing.Point(115, 95)
            Me.DtpExpDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.DtpExpDate.MaxLength = 0
            Me.DtpExpDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.DtpExpDate.Name = "DtpExpDate"
            Me.DtpExpDate.ReadOnlys = False
            Me.DtpExpDate.SelectedText = ""
            Me.DtpExpDate.SelectionLength = 0
            Me.DtpExpDate.SelectionStart = 0
            Me.DtpExpDate.Size = New System.Drawing.Size(100, 20)
            Me.DtpExpDate.TabIndex = 781
            Me.DtpExpDate.Tag = "format(&&&&-&&);"
            Me.DtpExpDate.TextAlign = 0
            Me.DtpExpDate.TextValue = ""
            Me.DtpExpDate.ToolTipText = "전표 일자"
            '
            'lblExp
            '
            Me.lblExp.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblExp.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblExp.Location = New System.Drawing.Point(53, 98)
            Me.lblExp.Name = "lblExp"
            Me.lblExp.Size = New System.Drawing.Size(60, 15)
            Me.lblExp.TabIndex = 780
            Me.lblExp.Text = "정산 년월"
            Me.lblExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNI601
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.DtpExpDate)
            Me.Controls.Add(Me.lblExp)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.DtpSlipDateEd)
            Me.Controls.Add(Me.dtpSlipDate)
            Me.Controls.Add(Me.lbldtpOriginSlipDate)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnExecute)
            Me.Controls.Add(Me.txtCriteria)
            Me.Controls.Add(Me.DtpSlipDateSt)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cboSlipDivision)
            Me.Controls.Add(Me.lblSlipDivision)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picIo_1)
            Me.Name = "PNI601"
            Me.Size = New System.Drawing.Size(800, 640)
            Me.Controls.SetChildIndex(Me.picIo_1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.lblSlipDivision, 0)
            Me.Controls.SetChildIndex(Me.cboSlipDivision, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.DtpSlipDateSt, 0)
            Me.Controls.SetChildIndex(Me.txtCriteria, 0)
            Me.Controls.SetChildIndex(Me.btnExecute, 0)
            Me.Controls.SetChildIndex(Me.btnCancel, 0)
            Me.Controls.SetChildIndex(Me.lbldtpOriginSlipDate, 0)
            Me.Controls.SetChildIndex(Me.dtpSlipDate, 0)
            Me.Controls.SetChildIndex(Me.DtpSlipDateEd, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.lblExp, 0)
            Me.Controls.SetChildIndex(Me.DtpExpDate, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents lblSlipDivision As System.Windows.Forms.Label


        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents btnExecute As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents cboSlipDivision As ubiLease.CommonControls.cbo
        Friend WithEvents DtpSlipDateSt As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtCriteria As ubiLease.CommonControls.num
        Friend WithEvents picIo_1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpSlipDate As ubiLease.CommonControls.dtp
        Friend WithEvents lbldtpOriginSlipDate As System.Windows.Forms.Label
        Friend WithEvents DtpSlipDateEd As ubiLease.CommonControls.dtp
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents DtpExpDate As ubiLease.CommonControls.dtp
        Friend WithEvents lblExp As System.Windows.Forms.Label

    End Class

End Namespace