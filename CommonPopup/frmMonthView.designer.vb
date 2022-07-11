Namespace ubiLease.CommonPopup

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMonthView
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
            Me.clnUserControl = New System.Windows.Forms.MonthCalendar
            Me.picBack = New System.Windows.Forms.PictureBox
            CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'clnUserControl
            '
            Me.clnUserControl.BackColor = System.Drawing.SystemColors.Window
            Me.clnUserControl.Location = New System.Drawing.Point(4, 4)
            Me.clnUserControl.Margin = New System.Windows.Forms.Padding(0)
            Me.clnUserControl.MaxSelectionCount = 1
            Me.clnUserControl.Name = "clnUserControl"
            Me.clnUserControl.ShowTodayCircle = False
            Me.clnUserControl.TabIndex = 0
            '
            'picBack
            '
            Me.picBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picBack.Location = New System.Drawing.Point(0, 0)
            Me.picBack.Name = "picBack"
            Me.picBack.Size = New System.Drawing.Size(144, 150)
            Me.picBack.TabIndex = 1
            Me.picBack.TabStop = False
            '
            'frmMonthView
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
            Me.BackColor = System.Drawing.SystemColors.Window
            Me.ClientSize = New System.Drawing.Size(145, 150)
            Me.ControlBox = False
            Me.Controls.Add(Me.clnUserControl)
            Me.Controls.Add(Me.picBack)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmMonthView"
            Me.Opacity = 0.85
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "달력"
            CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents picBack As System.Windows.Forms.PictureBox
        Friend WithEvents clnUserControl As System.Windows.Forms.MonthCalendar

    End Class

End Namespace

