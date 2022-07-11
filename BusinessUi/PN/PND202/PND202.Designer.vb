Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PND202
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
            Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
            Me.lbsMsg31 = New System.Windows.Forms.Label
            Me.SuspendLayout()
            '
            'WebBrowser1
            '
            Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
            Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowser1.Name = "WebBrowser1"
            Me.WebBrowser1.Size = New System.Drawing.Size(805, 644)
            Me.WebBrowser1.TabIndex = 39
            Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
            '
            'lbsMsg31
            '
            Me.lbsMsg31.AutoSize = True
            Me.lbsMsg31.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lbsMsg31.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lbsMsg31.Location = New System.Drawing.Point(3, 9)
            Me.lbsMsg31.Name = "lbsMsg31"
            Me.lbsMsg31.Size = New System.Drawing.Size(252, 13)
            Me.lbsMsg31.TabIndex = 1700
            Me.lbsMsg31.Text = "인터넷 웹 브라우져 처럼 사용 하세요.."
            Me.lbsMsg31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lbsMsg31.Visible = False
            '
            'PND202
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.WebBrowser1)
            Me.Controls.Add(Me.lbsMsg31)
            Me.Name = "PND202"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
        Friend WithEvents lbsMsg31 As System.Windows.Forms.Label


    End Class

End Namespace
