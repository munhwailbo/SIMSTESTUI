Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Imports System.Reflection

Namespace ubiLease.UI.MainUi
    Partial Class frmMainUi

        '====================================================================================================
        Private Sub pnlRight_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlRight.Resize
            'If IsNothing(Me.picRight.Controls(GmainCommonFunction.GactiveUiControlName)) = False Then
            '    Me.SuspendLayout()

            '    If Me.Width >= 1024 Then
            '        Me.picRight.Controls(GmainCommonFunction.GactiveUiControlName).Width = Me.pnlRight.Width - 2
            '    Else
            '        Me.picRight.Controls(GmainCommonFunction.GactiveUiControlName).Width = 811
            '    End If

            '    If Me.Height >= 768 Then
            '        Me.picRight.Controls(GmainCommonFunction.GactiveUiControlName).Height = Me.pnlRight.Height - 2
            '    Else
            '        Me.picRight.Controls(GmainCommonFunction.GactiveUiControlName).Height = 647
            '    End If

            '    Me.ResumeLayout(True)
            'End If
        End Sub

        '====================================================================================================
        

        '====================================================================================================
        Private Sub frmMainUi_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
            Try
                MbusinessSelectForm.Show()
                MbusinessSelectForm.CheckCreadedProgram(GmainCommonFunction.GbusinessDivisionCode, False)
                '' °æ±¤µî Æû ´Ý±â
                AlarmClose()
            Catch ex As Exception
                Gexception.getException(ex)
                'Debug.WriteLine(ex.Message)
            End Try
        End Sub

        '====================================================================================================
        Private Sub picOpenedProgram_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOpenedProgram.MouseEnter
            sender.Image = Global.My.Resources.List_screen_up
            Me.Cursor = Cursors.Hand
        End Sub

        '====================================================================================================
        Private Sub picOpenedProgram_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOpenedProgram.MouseLeave
            sender.Image = Global.My.Resources.List_screen
            Me.Cursor = Cursors.Default
        End Sub

        '====================================================================================================
        Private Sub picClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.MouseEnter
            sender.Image = Global.My.Resources.Close_screen_up
            Me.Cursor = Cursors.Hand
        End Sub

        '====================================================================================================
        Private Sub picClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.MouseLeave
            sender.Image = Global.My.Resources.Close_screen
            Me.Cursor = Cursors.Default
        End Sub

        '====================================================================================================
        Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
            Me.tmrMain.Interval = 50000
            Me.lblCurrentTime.Text = Format(Now, "HH:mm:ss")
        End Sub

    End Class
End Namespace
