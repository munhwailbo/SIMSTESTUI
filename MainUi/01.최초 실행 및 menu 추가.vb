

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

        Private MbusinessSelectForm As Object

        Public SbusinessDivisionCode As String = "" ' businessDivisionName을 담을 스트링 변수
        Public SbusinessDivisionName As String = ""
        '====================================================================================================
        Public Sub BusinessSelect(ByVal AbusinessSelectForm As Form, ByVal AbusinessDivisionCode As String, ByVal AbusinessDivisionName As String)
            MbusinessSelectForm = AbusinessSelectForm
            Me.Text = "(" & AbusinessDivisionName & ")" & GmainCommonFunction.GmessageTile
            SbusinessDivisionName = AbusinessDivisionName
            Me.pnlTop.Height = 0

            SbusinessDivisionCode = AbusinessDivisionCode

            GmainCommonFunction.SetUserAndEnvironmentInfo(AbusinessDivisionCode, AbusinessDivisionName)

            ' 사원 번호

            ''==================================
            '' 메인 화면 추가

            GmainCommonFunction.AddExplorerBusinessMenu(Me.trvMain, AbusinessDivisionCode, GmainBusinessFunction.GetValue("로그인 ID"))

            ''==================================
            '' 즐겨찾기 화면 추가
            GmainCommonFunction.AddWorkFlowList(Me.trvLeftBottom, AbusinessDivisionCode, GmainBusinessFunction.GetValue("로그인 ID"))

            ''==================================
            '' Main Menu에 업무 추가 (메인화면)
            AddFromExplorerMenuToPullDownMenu(Me.trvMain, Me.mnuMain)

            ''==================================
            '' Main Menu에 업무 추가 (즐겨찾기)
            'AddFromExplorerMenuToPullDownMenu(Me.trvMain, Me.mnuMain)

            Me.Show()

        End Sub

        '====================================================================================================
        Public Sub AddFromExplorerMenuToPullDownMenu(ByVal AinputTreeView As TreeView, ByVal AinputMenuStrip As MenuStrip)

            For forNumber As Integer = 0 To AinputTreeView.GetNodeCount(False) - 1 Step 1
                Dim getedNode As System.Windows.Forms.TreeNode = AinputTreeView.Nodes(forNumber)
                Dim menuStrip1 As New System.Windows.Forms.ToolStripMenuItem

                menuStrip1.Name = "mnu" & getedNode.Name
                menuStrip1.Text = getedNode.Text
                AinputMenuStrip.Items.Add(menuStrip1)

                AddHandler menuStrip1.Click, AddressOf MainMenu_Click

                For forNumber2 As Integer = 0 To getedNode.GetNodeCount(False) - 1 Step 1
                    Dim menuStrip2 As New System.Windows.Forms.ToolStripMenuItem
                    Dim getedNode2 As System.Windows.Forms.TreeNode = getedNode.Nodes(forNumber2)

                    menuStrip2.Name = "mnu" & getedNode2.Name
                    menuStrip2.Text = getedNode2.Text

                    If getedNode2.ForeColor = Color.Silver Then
                        menuStrip2.ForeColor = Color.Silver
                    End If

                    menuStrip1.DropDownItems.Add(menuStrip2)

                    AddHandler menuStrip2.Click, AddressOf MainMenu_Click

                    For forNumber3 As Integer = 0 To getedNode2.GetNodeCount(False) - 1 Step 1
                        Dim menuStrip3 As New System.Windows.Forms.ToolStripMenuItem
                        Dim getedNode3 As System.Windows.Forms.TreeNode = getedNode2.Nodes(forNumber3)

                        menuStrip3.Name = "mnu" & getedNode3.Name
                        menuStrip3.Text = getedNode3.Text

                        If getedNode3.ForeColor = Color.Silver Then
                            menuStrip3.ForeColor = Color.Silver
                        End If

                        menuStrip2.DropDownItems.Add(menuStrip3)
                        AddHandler menuStrip3.Click, AddressOf MainMenu_Click

                    Next forNumber3
                Next forNumber2
            Next forNumber
        End Sub

    End Class
End Namespace
