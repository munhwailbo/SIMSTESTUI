Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNH202
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
            Me.picIo_1 = New System.Windows.Forms.PictureBox
            Me.dtpClosingYearMonths = New ubiLease.CommonControls.dtp
            Me.lblClosingYearMonths = New System.Windows.Forms.Label
            Me.lblClosingType = New System.Windows.Forms.Label
            Me.lblClosingDt = New System.Windows.Forms.Label
            Me.dtpClosingDt = New ubiLease.CommonControls.dtp
            Me.Label20 = New System.Windows.Forms.Label
            Me.btnClosingCancel = New System.Windows.Forms.Button
            Me.btnClosing = New System.Windows.Forms.Button
            Me.cboClosingType = New ubiLease.CommonControls.cbo
            Me.dtpNextClosingYearMonths = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.popClosingEmployee = New ubiLease.CommonControls.pop
            Me.Label33 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picIo_1
            '
            Me.picIo_1.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_1.Location = New System.Drawing.Point(6, 27)
            Me.picIo_1.Name = "picIo_1"
            Me.picIo_1.Size = New System.Drawing.Size(799, 617)
            Me.picIo_1.TabIndex = 815
            Me.picIo_1.TabStop = False
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
            Me.dtpClosingYearMonths.Location = New System.Drawing.Point(357, 232)
            Me.dtpClosingYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpClosingYearMonths.MaxLength = 0
            Me.dtpClosingYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpClosingYearMonths.Name = "dtpClosingYearMonths"
            Me.dtpClosingYearMonths.ReadOnlys = False
            Me.dtpClosingYearMonths.SelectedText = ""
            Me.dtpClosingYearMonths.SelectionLength = 0
            Me.dtpClosingYearMonths.SelectionStart = 0
            Me.dtpClosingYearMonths.Size = New System.Drawing.Size(81, 20)
            Me.dtpClosingYearMonths.TabIndex = 857
            Me.dtpClosingYearMonths.TabStop = False
            Me.dtpClosingYearMonths.Tag = "need;format(&&&&-&&);"
            Me.dtpClosingYearMonths.TextAlign = 0
            Me.dtpClosingYearMonths.TextValue = Nothing
            Me.dtpClosingYearMonths.ToolTipText = ""
            '
            'lblClosingYearMonths
            '
            Me.lblClosingYearMonths.BackColor = System.Drawing.Color.GhostWhite
            Me.lblClosingYearMonths.Location = New System.Drawing.Point(252, 237)
            Me.lblClosingYearMonths.Name = "lblClosingYearMonths"
            Me.lblClosingYearMonths.Size = New System.Drawing.Size(99, 15)
            Me.lblClosingYearMonths.TabIndex = 856
            Me.lblClosingYearMonths.Text = "최종 마감 년월"
            Me.lblClosingYearMonths.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblClosingType
            '
            Me.lblClosingType.BackColor = System.Drawing.Color.GhostWhite
            Me.lblClosingType.Location = New System.Drawing.Point(252, 211)
            Me.lblClosingType.Name = "lblClosingType"
            Me.lblClosingType.Size = New System.Drawing.Size(99, 15)
            Me.lblClosingType.TabIndex = 1123
            Me.lblClosingType.Text = "마감 구분"
            Me.lblClosingType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblClosingDt
            '
            Me.lblClosingDt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblClosingDt.Location = New System.Drawing.Point(252, 258)
            Me.lblClosingDt.Name = "lblClosingDt"
            Me.lblClosingDt.Size = New System.Drawing.Size(99, 18)
            Me.lblClosingDt.TabIndex = 1127
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
            Me.dtpClosingDt.Location = New System.Drawing.Point(357, 258)
            Me.dtpClosingDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpClosingDt.MaxLength = 0
            Me.dtpClosingDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpClosingDt.Name = "dtpClosingDt"
            Me.dtpClosingDt.ReadOnlys = False
            Me.dtpClosingDt.SelectedText = ""
            Me.dtpClosingDt.SelectionLength = 0
            Me.dtpClosingDt.SelectionStart = 0
            Me.dtpClosingDt.Size = New System.Drawing.Size(101, 20)
            Me.dtpClosingDt.TabIndex = 1126
            Me.dtpClosingDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpClosingDt.TextAlign = 0
            Me.dtpClosingDt.TextValue = Nothing
            Me.dtpClosingDt.ToolTipText = ""
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label20.Location = New System.Drawing.Point(4, 12)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(62, 12)
            Me.Label20.TabIndex = 1482
            Me.Label20.Text = "부수 마감"
            '
            'btnClosingCancel
            '
            Me.btnClosingCancel.Location = New System.Drawing.Point(404, 373)
            Me.btnClosingCancel.Name = "btnClosingCancel"
            Me.btnClosingCancel.Size = New System.Drawing.Size(132, 36)
            Me.btnClosingCancel.TabIndex = 1505
            Me.btnClosingCancel.Text = "마감취소"
            Me.btnClosingCancel.UseVisualStyleBackColor = True
            '
            'btnClosing
            '
            Me.btnClosing.Location = New System.Drawing.Point(254, 373)
            Me.btnClosing.Name = "btnClosing"
            Me.btnClosing.Size = New System.Drawing.Size(132, 36)
            Me.btnClosing.TabIndex = 1504
            Me.btnClosing.Text = "마감"
            Me.btnClosing.UseVisualStyleBackColor = True
            '
            'cboClosingType
            '
            Me.cboClosingType.CaptionName = "확장구분"
            Me.cboClosingType.Enabled = False
            Me.cboClosingType.ListCount = 0
            Me.cboClosingType.Location = New System.Drawing.Point(357, 206)
            Me.cboClosingType.Name = "cboClosingType"
            Me.cboClosingType.ReadOnlys = False
            Me.cboClosingType.Size = New System.Drawing.Size(176, 20)
            Me.cboClosingType.TabIndex = 1506
            Me.cboClosingType.Tag = "need;code(마감구분 명|전체);"
            Me.cboClosingType.TextValue = ""
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
            Me.dtpNextClosingYearMonths.Location = New System.Drawing.Point(377, 334)
            Me.dtpNextClosingYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpNextClosingYearMonths.MaxLength = 0
            Me.dtpNextClosingYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpNextClosingYearMonths.Name = "dtpNextClosingYearMonths"
            Me.dtpNextClosingYearMonths.ReadOnlys = False
            Me.dtpNextClosingYearMonths.SelectedText = ""
            Me.dtpNextClosingYearMonths.SelectionLength = 0
            Me.dtpNextClosingYearMonths.SelectionStart = 0
            Me.dtpNextClosingYearMonths.Size = New System.Drawing.Size(81, 20)
            Me.dtpNextClosingYearMonths.TabIndex = 1508
            Me.dtpNextClosingYearMonths.TabStop = False
            Me.dtpNextClosingYearMonths.Tag = "need;format(&&&&-&&);"
            Me.dtpNextClosingYearMonths.TextAlign = 0
            Me.dtpNextClosingYearMonths.TextValue = Nothing
            Me.dtpNextClosingYearMonths.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Location = New System.Drawing.Point(272, 339)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(99, 15)
            Me.Label1.TabIndex = 1507
            Me.Label1.Text = "부수 마감 년월"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.popClosingEmployee.Location = New System.Drawing.Point(357, 284)
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
            Me.popClosingEmployee.TabIndex = 1509
            Me.popClosingEmployee.Tag = "code(사원 명);"
            Me.popClosingEmployee.TextAlign = 0
            Me.popClosingEmployee.TextValue = ""
            Me.popClosingEmployee.ToolTipText = ""
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.GhostWhite
            Me.Label33.Location = New System.Drawing.Point(252, 287)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(99, 15)
            Me.Label33.TabIndex = 1510
            Me.Label33.Text = "처리 담당자"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Location = New System.Drawing.Point(233, 188)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(336, 15)
            Me.Label2.TabIndex = 1511
            Me.Label2.Text = "=================================================================================" & _
                "================="
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Location = New System.Drawing.Point(233, 307)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(336, 15)
            Me.Label3.TabIndex = 1512
            Me.Label3.Text = "=================================================================================" & _
                "================="
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Location = New System.Drawing.Point(233, 416)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(336, 15)
            Me.Label4.TabIndex = 1513
            Me.Label4.Text = "=================================================================================" & _
                "================="
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PNH202
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
            Me.Name = "PNH202"
            Me.Size = New System.Drawing.Size(811, 647)
            CType(Me.picIo_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents picIo_1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpClosingYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents lblClosingYearMonths As System.Windows.Forms.Label
        Friend WithEvents lblClosingType As System.Windows.Forms.Label
        Friend WithEvents lblClosingDt As System.Windows.Forms.Label
        Friend WithEvents dtpClosingDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents btnClosingCancel As System.Windows.Forms.Button
        Friend WithEvents btnClosing As System.Windows.Forms.Button
        Friend WithEvents cboClosingType As ubiLease.CommonControls.cbo
        Friend WithEvents dtpNextClosingYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents popClosingEmployee As ubiLease.CommonControls.pop
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label


    End Class

End Namespace
