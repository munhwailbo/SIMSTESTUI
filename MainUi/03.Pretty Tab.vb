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
            '' Ʈ����� ���� �ڵ�
            '' 1. sender = TreeNode �̰ų� ToolStripMenuItems
            '' 2. 6�ڸ��� ó����
            '' ====================================================

            '' ====================================================
            '' ��ü�� ���������� ������ �����Ѵ�.
            If sender Is Nothing Then
                Return
            End If
            If sender.Name Is Nothing Then
                Return
            ElseIf sender.Name = "" Then
                Return
            End If

            '' ====================================================
            '' ���� Ư���̸� �����ϰ� ȭ���̸� ������ ó���Ѵ�.
            '' 1. ���� �޴����� Ŭ���� ó��
            Dim Screen_id = Replace(sender.Name, "mnu", "").Replace("00", "")

            '' ====================================================
            '' Ʈ������ Ŭ���� ó��
            Dim strs() As String
            If sender.Tag Is Nothing Then

            Else
                strs = sender.Tag.ToString().Split(CChar(";"))

                If strs(2).ToString() = "1" Then
                    Debug.Print("���α׷� ���� : " + strs(2))
                ElseIf strs(2).ToString() = "" Then
                    Return
                End If

            End If



            'ȭ�麰 ����� ����/���� ���� ���� �����κ�
            'Me.ControlDisable()
            If IsNothing(sender) = False Then
                If sender.ForeColor.Name = "Silver" Then
                    MessageBox.Show("(" & sender.Text & ")ȭ���� ����� �� �ִ� ������ �����ϴ�.")
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
                ' ���õ� item ����
                Dim ItemIndex As Integer
                For i As Integer = 0 To Me.cntMnuMain.Items.Count - 1
                    If Me.cntMnuMain.Items(i).Name = menuName Then
                        ItemIndex = i
                    End If
                Next

                Me.cntMnuMain.Items.Remove(Me.cntMnuMain.Items(menuName))

                '' ��� ���� �����
                'Me.ControlDisable() '��� ��Ʈ�� �ʱ�ȭ - Disable

                '' ������ ��Ŀ��(����) ó��
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
