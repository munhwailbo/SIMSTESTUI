<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgress
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgress))
        Me.Progress1 = New ubiLease.CommonControls.Progress
        Me.SuspendLayout()
        '
        'Progress1
        '
        Me.Progress1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progress1.Location = New System.Drawing.Point(12, 12)
        Me.Progress1.Maximum = 100
        Me.Progress1.Name = "Progress1"
        Me.Progress1.Size = New System.Drawing.Size(377, 68)
        Me.Progress1.Step = 10
        Me.Progress1.TabIndex = 0
        Me.Progress1.Value = 0
        '
        'frmProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 86)
        Me.Controls.Add(Me.Progress1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProgress"
        Me.Text = "frmProgress"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Progress1 As ubiLease.CommonControls.Progress
End Class
