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
        Public Sub MainMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            '' ====================================================
            '' 트리노드 구분 코드
            '' 1. sender = TreeNode 이거나 ToolStripMenuItems
            '' 2. 6자리를 처리함
            '' ====================================================

            '' ====================================================
            '' 객체가 정상적이지 않으면 종료한다.
            If sender Is Nothing Then
                Return
            End If
            If sender.Name Is Nothing Then
                Return
            ElseIf sender.Name = "" Then
                Return
            End If

            '' ====================================================
            '' 폴더 특성이면 종료하고 화면이면 다음을 처리한다.
            '' 1. 메인 메뉴에서 클릭시 처리
            Dim Screen_id = Replace(sender.Name, "mnu", "").Replace("00", "")

            '' ====================================================
            '' 트리에서 클릭시 처리
            Dim strs() As String
            If sender.Tag Is Nothing Then

            Else
                strs = sender.Tag.ToString().Split(CChar(";"))

                If strs(2).ToString() = "1" Then
                    Debug.Print("프로그램 여부 : " + strs(2))
                ElseIf strs(2).ToString() = "" Then
                    Return
                End If

            End If



            '화면별 사용자 수정/삭제 권한 관련 수정부분
            'Me.ControlDisable()
            If IsNothing(sender) = False Then
                If sender.ForeColor.Name = "Silver" Then
                    MessageBox.Show("(" & sender.Text & ")화면을 사용할 수 있는 권한이 없습니다.")
                Else
                    'sttMainLableClear()
                    If GmainCommonFunction.AddUiControl(Me.pnlRight, Screen_id) = True Then
                        Dim menuText As String = GmainCommonFunction.AddPrettyTab(Me.pnlTopLeft, New CommonControls.PrettyTab, sender.Name, sender.ToString)

                        If menuText <> "" Then

                            Dim cntMnuItmAddedUiControl As New System.Windows.Forms.ToolStripMenuItem
                            GmainCommonFunction.GactiveUiControlName = Replace(sender.name, "mnu", "")
                            cntMnuItmAddedUiControl.Name = sender.Name
                            cntMnuItmAddedUiControl.Text = menuText
                            Me.cntMnuMain.Items.Add(cntMnuItmAddedUiControl)
                            AddHandler cntMnuItmAddedUiControl.Click, AddressOf cntMnuItmAddedUiControl_Click
                        End If
                    End If
                End If
            End If
        End Sub


        Private Sub sttMainLableClear()
            Me.lblMessage.Text = ""
            Me.lblRequestData.Text = "0"
            Me.lblDeleteData.Text = "0"
            Me.lblCreateData.Text = "0"
            Me.lblUpdateData.Text = "0"

        End Sub

        '====================================================================================================
        Private Sub cntMnuItmAddedUiControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            MainMenu_Click(sender, Nothing)
        End Sub

        '====================================================================================================
        Private Sub picOpenedProgram_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picOpenedProgram.Click
            Static isFirstShow As Boolean = True

pntAgain:

            Dim tempPointToScreen As New Point(Me.picOpenedProgram.PointToScreen(New Point))

            Me.cntMnuMain.SuspendLayout()
            Me.cntMnuMain.Show(Me, New Point(5000, 5000))

            Dim memuLeft As Integer = (tempPointToScreen.X + Me.picOpenedProgram.Width - cntMnuMain.Width) - Me.TopLevelControl.Left
            Dim memuTop As Integer = (tempPointToScreen.Y + Me.picOpenedProgram.Height) - Me.TopLevelControl.Top - 2

            Me.cntMnuMain.Left = memuLeft
            Me.cntMnuMain.Top = memuTop

            Me.cntMnuMain.ResumeLayout(True)

            tempPointToScreen = Nothing

            If isFirstShow = True Then
                isFirstShow = False
                GoTo pntAgain
            End If
        End Sub

        '====================================================================================================
        Public Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
            Dim menuName As String = GmainCommonFunction.DeletePrettyTab(Me.pnlTopLeft)

            If menuName <> "" Then
                ' 선택된 item 제거
                Dim ItemIndex As Integer
                For i As Integer = 0 To Me.cntMnuMain.Items.Count - 1
                    If Me.cntMnuMain.Items(i).Name = menuName Then
                        ItemIndex = i
                    End If
                Next

                Me.cntMnuMain.Items.Remove(Me.cntMnuMain.Items(menuName))

                '' 모든 권한 지우기
                'Me.ControlDisable() '모든 컨트롤 초기화 - Disable

                '' 지운후 포커스(권한) 처리
                '' MainMenu_Click(trvMain.SelectedNode, New System.EventArgs)
            End If

        End Sub

        'Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
        '    Dim menuName As String = GmainCommonFunction.DeletePrettyTab(Me.pnlTopLeft)

        '    If menuName <> "" Then
        '        Me.cntMnuMain.Items.Remove(Me.cntMnuMain.Items(menuName))
        '    End If

        'End Sub

        Private Sub picAllClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAllClose.Click
            Dim menuName As String = GmainCommonFunction.DeleteAllPrettyTab(Me.pnlTopLeft)

            If menuName <> "" Then
                Dim delMenu() As String
                delMenu = menuName.Split(vbTab)
                For i As Integer = 0 To delMenu.Length - 1
                    If delMenu(i) <> "" Then
                        Me.cntMnuMain.Items.Remove(Me.cntMnuMain.Items(delMenu(i)))
                    End If
                Next
            End If

            'Me.cntMnuMain.Items.Clear()
            'For i As Integer = 0 To Me.cntMnuMain.Items.Count
            '    Me.cntMnuMain.Items.Clear()
            'Next


        End Sub


    End Class
End Namespace
