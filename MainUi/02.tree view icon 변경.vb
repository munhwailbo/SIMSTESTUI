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
        Private Sub trvMain_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvMain.AfterSelect, trvLeftBottom.AfterSelect
            SetTreeNodeImage(e.Node)
            MainMenu_Click(sender.SelectedNode, New System.EventArgs)
        End Sub

        '====================================================================================================
        Private Sub trvMain_AfterExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvMain.AfterExpand, trvLeftBottom.AfterExpand
            If e.Node.Nodes.Count >= 1 Then
                e.Node.ImageIndex = 1

                For forNumber As Integer = 0 To e.Node.Nodes.Count - 1 Step 1
                    SetTreeNodeImage(e.Node.Nodes(forNumber))
                Next forNumber
            End If
        End Sub

        '====================================================================================================
        Private Sub trvMain_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles trvMain.DoubleClick, trvLeftBottom.DoubleClick

            SetTreeNodeImage(sender.SelectedNode)

            If IsNothing(sender) = False Then
                If Me.GmainCommonFunction.GactiveUiControlName <> sender.Name Then
                    MainMenu_Click(sender.SelectedNode, New System.EventArgs)
                End If
            End If

        End Sub

        '====================================================================================================
        Private Sub SetTreeNodeImage(ByVal Anode As TreeNode)

            If IsNothing(Anode) = True Then
                Exit Sub
            End If

            If Anode.TreeView.Name = "trvMain" Then
                If Anode.Nodes.Count = 0 Then
                    ChangeIcon(Anode)
                Else
                    If Anode.IsExpanded = True Then
                        Anode.ImageIndex = 1
                        Anode.SelectedImageIndex = 1
                    Else
                        Anode.ImageIndex = 0
                        Anode.SelectedImageIndex = 0
                    End If
                End If
            Else
                IconSetting(Anode)
            End If

        End Sub

        '' ====================================================================================================
        Private Sub trvMain_AfterCollapse(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvMain.AfterCollapse
            e.Node.ImageIndex = 0
        End Sub

        Private Sub IconSetting(ByVal tn As TreeNode)

            If IsNothing(tn) = True Then
                Exit Sub
            End If

            Dim strs1() As String = tn.Tag.ToString().Split(CChar(";"))

            If strs1(2) = "1" Then
                tn.ImageIndex = 0 '' 폴더 모양
            Else

                tn.ImageIndex = 3 '' 프로그램 모양
                ChangeIcon(tn)
            End If

            For Each Subtn As TreeNode In tn.Nodes

                If Subtn.Nodes.Count > 0 Then

                    IconSetting(Subtn)
                Else

                    Dim strs2() As String = tn.Tag.ToString().Split(CChar(";"))

                    If strs2(2) = "1" Then
                        tn.ImageIndex = 0 '' 폴더 모양
                    Else
                        tn.ImageIndex = 3 '' 프로그램 모양
                        ChangeIcon(tn)
                    End If
                End If
            Next

        End Sub

        Private Sub ChangeIcon(ByVal tn As TreeNode)
            If _
                        Strings.Right(tn.Text.Trim, 2) = "현황" _
                        Or Strings.Right(tn.Text.Trim, 2) = "내역" _
                        Or Strings.Right(tn.Text.Trim, 2) = "조회" _
                        Or Strings.Right(tn.Text.Trim, 2) = "인쇄" _
                        Or Strings.Right(tn.Text.Trim, 2) = "통계" _
                        Or Strings.Right(tn.Text.Trim, 3) = "리스트" _
                        Or VBN.InStr(tn.Text.Trim, "출력") >= 1 _
                        Or VBN.InStr(tn.Text.Trim, "집계표") >= 1 _
                        Then
                tn.ImageIndex = 2
                tn.SelectedImageIndex = 2
            Else
                tn.ImageIndex = 3
                tn.SelectedImageIndex = 3
            End If
        End Sub

    End Class
End Namespace
