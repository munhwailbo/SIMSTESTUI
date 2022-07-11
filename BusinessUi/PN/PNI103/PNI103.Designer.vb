Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI103
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
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.popClosingEmployee = New ubiLease.CommonControls.pop
            Me.Label33 = New System.Windows.Forms.Label
            Me.dtpNextClosingYearMonths = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.cboClosingType = New ubiLease.CommonControls.cbo
            Me.btnClosingCancel = New System.Windows.Forms.Button
            Me.btnClosing = New System.Windows.Forms.Button
            Me.Label20 = New System.Windows.Forms.Label
            Me.lblClosingDt = New System.Windows.Forms.Label
            Me.dtpClosingDt = New ubiLease.CommonControls.dtp
            Me.lblClosingType = New System.Windows.Forms.Label
            Me.dtpClosingYearMonths = New ubiLease.CommonControls.dtp
            Me.lblClosingYearMonths = New System.Windows.Forms.Label
            Me.picIo_1 = New System.Windows.Forms.PictureBox
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Location = New System.Drawing.Point(234, 411)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(336, 15)
            Me.Label4.TabIndex = 1547
            Me.Label4.Text = "=================================================================================" & _
                "================="
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Location = New System.Drawing.Point(234, 302)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(336, 15)
            Me.Label3.TabIndex = 1546
            Me.Label3.Text = "=================================================================================" & _
                "================="
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Location = New System.Drawing.Point(234, 183)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(336, 15)
            Me.Label2.TabIndex = 1545
            Me.Label2.Text = "=================================================================================" & _
                "================="
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'popClosingEmployee
            '
            Me.popClosingEmployee.BorderColor = System.Drawing.Color.Empty
            Me.popClosingEmployee.BorderStyle = 2
            Me.popClosingEmployee.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popClosingEmployee.CaptionName = "담당자"
            Me.popClosingEmployee.CodeText = ""
            Me.popClosingEmployee.CodeWidth = 60
            Me.popClosingEmployee.Enabled = False
            Me.popClosingEmployee.Location = New System.Drawing.Point(358, 279)
            Me.popClosingEmployee.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popClosingEmployee.MaxLength = 32767
            Me.popClosingEmployee.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popClosingEmployee.Name = "popClosingEmployee"
            Me.popClosingEmployee.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popClosingEmployee.NameText = ""
            Me.popClosingEmployee.ReadOnlys = False
            Me.popClosingEmployee.SelectedText = ""
            Me.popClosingEmployee.SelectionLength = 0
            Me.popClosingEmployee.SelectionStart = 0
            Me.popClosingEmployee.Size = New System.Drawing.Size(176, 20)
            Me.popClosingEmployee.TabIndex = 1543
            Me.popClosingEmployee.Tag = "code(사원 명);"
            Me.popClosingEmployee.TextAlign = 0
            Me.popClosingEmployee.TextValue = ""
            Me.popClosingEmployee.ToolTipText = ""
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.GhostWhite
            Me.Label33.Location = New System.Drawing.Point(253, 282)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(99, 15)
            Me.Label33.TabIndex = 1544
            Me.Label33.Text = "처리 담당자"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpNextClosingYearMonths
            '
            Me.dtpNextClosingYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpNextClosingYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpNextClosingYearMonths.BorderStyle = 2
            Me.dtpNextClosingYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpNextClosingYearMonths.CaptionName = "다음 마감년월"
            Me.dtpNextClosingYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpNextClosingYearMonths.Enabled = False
            Me.dtpNextClosingYearMonths.Location = New System.Drawing.Point(378, 329)
            Me.dtpNextClosingYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpNextClosingYearMonths.MaxLength = 0
            Me.dtpNextClosingYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpNextClosingYearMonths.Name = "dtpNextClosingYearMonths"
            Me.dtpNextClosingYearMonths.ReadOnlys = False
            Me.dtpNextClosingYearMonths.SelectedText = ""
            Me.dtpNextClosingYearMonths.SelectionLength = 0
            Me.dtpNextClosingYearMonths.SelectionStart = 0
            Me.dtpNextClosingYearMonths.Size = New System.Drawing.Size(81, 20)
            Me.dtpNextClosingYearMonths.TabIndex = 1542
            Me.dtpNextClosingYearMonths.TabStop = False
            Me.dtpNextClosingYearMonths.Tag = "need;format(&&&&-&&);"
            Me.dtpNextClosingYearMonths.TextAlign = 0
            Me.dtpNextClosingYearMonths.TextValue = Nothing
            Me.dtpNextClosingYearMonths.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Location = New System.Drawing.Point(273, 334)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(99, 15)
            Me.Label1.TabIndex = 1541
            Me.Label1.Text = "청산 마감 년월"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboClosingType
            '
            Me.cboClosingType.CaptionName = "확장구분"
            Me.cboClosingType.Enabled = False
            Me.cboClosingType.ListCount = 0
            Me.cboClosingType.Location = New System.Drawing.Point(358, 201)
            Me.cboClosingType.Name = "cboClosingType"
            Me.cboClosingType.ReadOnlys = False
            Me.cboClosingType.Size = New System.Drawing.Size(176, 20)
            Me.cboClosingType.TabIndex = 1540
            Me.cboClosingType.Tag = "need;code(마감구분 명|전체);"
            Me.cboClosingType.TextValue = ""
            '
            'btnClosingCancel
            '
            Me.btnClosingCancel.Location = New System.Drawing.Point(405, 368)
            Me.btnClosingCancel.Name = "btnClosingCancel"
            Me.btnClosingCancel.Size = New System.Drawing.Size(132, 36)
            Me.btnClosingCancel.TabIndex = 1539
            Me.btnClosingCancel.Text = "마감취소"
            Me.btnClosingCancel.UseVisualStyleBackColor = True
            '
            'btnClosing
            '
            Me.btnClosing.Location = New System.Drawing.Point(255, 368)
            Me.btnClosing.Name = "btnClosing"
            Me.btnClosing.Size = New System.Drawing.Size(132, 36)
            Me.btnClosing.TabIndex = 1538
            Me.btnClosing.Text = "마감"
            Me.btnClosing.UseVisualStyleBackColor = True
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label20.Location = New System.Drawing.Point(5, 7)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(62, 12)
            Me.Label20.TabIndex = 1537
            Me.Label20.Text = "정산 마감"
            '
            'lblClosingDt
            '
            Me.lblClosingDt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblClosingDt.Location = New System.Drawing.Point(253, 253)
            Me.lblClosingDt.Name = "lblClosingDt"
            Me.lblClosingDt.Size = New System.Drawing.Size(99, 18)
            Me.lblClosingDt.TabIndex = 1536
            Me.lblClosingDt.Text = "처리 일자"
            Me.lblClosingDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpClosingDt
            '
            Me.dtpClosingDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpClosingDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpClosingDt.BorderStyle = 2
            Me.dtpClosingDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpClosingDt.CaptionName = "최종 마감 처리 일자"
            Me.dtpClosingDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpClosingDt.Enabled = False
            Me.dtpClosingDt.Location = New System.Drawing.Point(358, 253)
            Me.dtpClosingDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpClosingDt.MaxLength = 0
            Me.dtpClosingDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpClosingDt.Name = "dtpClosingDt"
            Me.dtpClosingDt.ReadOnlys = False
            Me.dtpClosingDt.SelectedText = ""
            Me.dtpClosingDt.SelectionLength = 0
            Me.dtpClosingDt.SelectionStart = 0
            Me.dtpClosingDt.Size = New System.Drawing.Size(101, 20)
            Me.dtpClosingDt.TabIndex = 1535
            Me.dtpClosingDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpClosingDt.TextAlign = 0
            Me.dtpClosingDt.TextValue = Nothing
            Me.dtpClosingDt.ToolTipText = ""
            '
            'lblClosingType
            '
            Me.lblClosingType.BackColor = System.Drawing.Color.GhostWhite
            Me.lblClosingType.Location = New System.Drawing.Point(253, 206)
            Me.lblClosingType.Name = "lblClosingType"
            Me.lblClosingType.Size = New System.Drawing.Size(99, 15)
            Me.lblClosingType.TabIndex = 1534
            Me.lblClosingType.Text = "마감 구분"
            Me.lblClosingType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpClosingYearMonths
            '
            Me.dtpClosingYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpClosingYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpClosingYearMonths.BorderStyle = 2
            Me.dtpClosingYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpClosingYearMonths.CaptionName = "최종 마감 년월"
            Me.dtpClosingYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpClosingYearMonths.Enabled = False
            Me.dtpClosingYearMonths.Location = New System.Drawing.Point(358, 227)
            Me.dtpClosingYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpClosingYearMonths.MaxLength = 0
            Me.dtpClosingYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpClosingYearMonths.Name = "dtpClosingYearMonths"
            Me.dtpClosingYearMonths.ReadOnlys = False
            Me.dtpClosingYearMonths.SelectedText = ""
            Me.dtpClosingYearMonths.SelectionLength = 0
            Me.dtpClosingYearMonths.SelectionStart = 0
            Me.dtpClosingYearMonths.Size = New System.Drawing.Size(81, 20)
            Me.dtpClosingYearMonths.TabIndex = 1533
            Me.dtpClosingYearMonths.TabStop = False
            Me.dtpClosingYearMonths.Tag = "need;format(&&&&-&&);"
            Me.dtpClosingYearMonths.TextAlign = 0
            Me.dtpClosingYearMonths.TextValue = Nothing
            Me.dtpClosingYearMonths.ToolTipText = ""
            '
            'lblClosingYearMonths
            '
            Me.lblClosingYearMonths.BackColor = System.Drawing.Color.GhostWhite
            Me.lblClosingYearMonths.Location = New System.Drawing.Point(253, 232)
            Me.lblClosingYearMonths.Name = "lblClosingYearMonths"
            Me.lblClosingYearMonths.Size = New System.Drawing.Size(99, 15)
            Me.lblClosingYearMonths.TabIndex = 1532
            Me.lblClosingYearMonths.Text = "최종 마감 년월"
            Me.lblClosingYearMonths.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picIo_1
            '
            Me.picIo_1.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_1.Location = New System.Drawing.Point(7, 22)
            Me.picIo_1.Name = "picIo_1"
            Me.picIo_1.Size = New System.Drawing.Size(799, 617)
            Me.picIo_1.TabIndex = 1531
            Me.picIo_1.TabStop = False
            '
            'PNI103
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.popClosingEmployee)
            Me.Controls.Add(Me.Label33)
            Me.Controls.Add(Me.dtpNextClosingYearMonths)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cboClosingType)
            Me.Controls.Add(Me.btnClosingCancel)
            Me.Controls.Add(Me.btnClosing)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.lblClosingDt)
            Me.Controls.Add(Me.dtpClosingDt)
            Me.Controls.Add(Me.lblClosingType)
            Me.Controls.Add(Me.dtpClosingYearMonths)
            Me.Controls.Add(Me.lblClosingYearMonths)
            Me.Controls.Add(Me.picIo_1)
            Me.Name = "PNI103"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popClosingEmployee As ubiLease.CommonControls.pop
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents dtpNextClosingYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cboClosingType As ubiLease.CommonControls.cbo
        Friend WithEvents btnClosingCancel As System.Windows.Forms.Button
        Friend WithEvents btnClosing As System.Windows.Forms.Button
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents lblClosingDt As System.Windows.Forms.Label
        Friend WithEvents dtpClosingDt As ubiLease.CommonControls.dtp
        Friend WithEvents lblClosingType As System.Windows.Forms.Label
        Friend WithEvents dtpClosingYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents lblClosingYearMonths As System.Windows.Forms.Label
        Friend WithEvents picIo_1 As System.Windows.Forms.PictureBox


    End Class

End Namespace
