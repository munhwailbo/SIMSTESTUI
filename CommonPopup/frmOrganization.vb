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
Imports System.Configuration

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic
Imports ubiLease.CommonFunction
Imports ubiLease.DAT

Namespace ubiLease.CommonPopup

    Public Class frmOrganization
        Private Gexception As DAT.CustomException = New DAT.CustomException

        Dim GmainCommonFunction As New ubiLease.CommonFunction.Common
        Dim GmainsqlParameters() As System.Data.SqlClient.SqlParameter
        Dim ds As New System.Data.DataSet
        Dim GmainExecuteDbCommand As New ubiLease.DAT.ExecuteDbCommand

        Private Sub frmOrganization_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
            Me.Hide()
        End Sub

        '====================================================================================================
        ' Form Load
        '====================================================================================================
        Private Sub frmOrganization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.TreeViewInitialize()
            trv1.SelectedNode = trv1.Nodes(0)
        End Sub

        '====================================================================================================
        ' Form Iniitalize()
        '====================================================================================================
        Public Sub Initialize(ByVal AcodeDivisionHangulName As String, Optional ByVal Awhere As String = "")
            TreeViewInitialize()
        End Sub

        '====================================================================================================
        ' 트리뷰 초기화
        '====================================================================================================
        Private Sub TreeViewInitialize()
            Dim RootNode As New System.Windows.Forms.TreeNode
            Dim NewNode As New System.Windows.Forms.TreeNode

            Try
                trv1.Nodes.Clear()

                RootNode = trv1.Nodes.Add("000000000000", "문화일보")

                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@OrganizationCode", "")
                    .SetSqlParameter(GmainsqlParameters, "@OrganizationName", "")
                End With

                Using ds = GmainExecuteDbCommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "sp_Organization", False, True, GmainsqlParameters)
                    For Each Row As System.Data.DataRow In ds.Tables(0).Select("UpperOrganizationCode='000000000000'")
                        NewNode = RootNode.Nodes.Add(Row("OrganizationCode").ToString(), Row("OrganizationName").ToString())
                        If (Row.IsNull("OrganizationCode")) Then
                            NewNode.Tag = ""
                        Else
                            NewNode.Tag = Row("UpperOrganizationCode").ToString()
                            Me.TreeViewSubNode(ds.Tables(0), NewNode)
                            ' trv1.ExpandAll()
                        End If
                    Next Row
                End Using

            Catch ex As Exception
                Gexception.getException(ex)
                System.Windows.Forms.MessageBox.Show(ex.Message, ex.Source, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            End Try
        End Sub
        '====================================================================================================
        ' SUB NODE
        '====================================================================================================
        Private Sub TreeViewSubNode(ByVal NewDt As System.Data.DataTable, ByVal UpperNode As TreeNode)
            Dim NewNode As New System.Windows.Forms.TreeNode

            Try
                For Each Row As System.Data.DataRow In NewDt.Select("UpperOrganizationCode='" & UpperNode.Name & "'")
                    NewNode = UpperNode.Nodes.Add(Row("OrganizationCode").ToString(), Row("OrganizationName").ToString())
                    If (Row.IsNull("OrganizationCode")) Then
                        NewNode.Tag = ""
                    Else
                        NewNode.Tag = Row("UpperOrganizationCode").ToString()
                        Me.TreeViewSubNode(NewDt, NewNode)
                        ' trv1.ExpandAll()
                    End If
                Next Row
            Catch ex As Exception
                Gexception.getException(ex)
                System.Windows.Forms.MessageBox.Show(ex.Message, ex.Source, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)

            End Try
        End Sub
        '====================================================================================================
        ' 트리뷰 Node Double Clck 
        '====================================================================================================
        Private Sub trv1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trv1.DoubleClick
            txtCode.Text = trv1.SelectedNode.Name
            txtName.Text = trv1.SelectedNode.Text
        End Sub
        '====================================================================================================
        ' 트리뷰 Node 선택
        '====================================================================================================
        Private Sub trv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trv1.AfterSelect
            txtCode.Text = e.Node.Name
            txtName.Text = e.Node.Text
        End Sub

        Public GcurrentPop As Object = Nothing

        '====================================================================================================
        Private Sub frmOrganization_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
            'Me.grdMain.GParentObject = Me

            If TypeOf GcurrentPop Is CommonControls.pop Then
                If VBN.Left(GcurrentPop.TextValue, 1) = ";" Then
                    ' 명칭으로 검색
                    Me.txtCode.Text = vbNullString
                    Me.txtName.Text = VBN.Mid(GcurrentPop.TextValue, 2, VBN.Len(GcurrentPop.TextValue))

                Else
                    ' 코드로검색
                    Me.txtCode.Text = Trim(GcurrentPop.TextValue)
                    Me.txtName.Text = vbNullString

                    Me.txtCode.Text = TreeViewSearch(Trim(GcurrentPop.TextValue))
                End If
                Me.txtName.Focus()
            Else
                With GcurrentPop
                    Me.txtCode.Text = .get_TextMatrix(.Row, .Col)
                End With
            End If
        End Sub
        ''' <summary>
        '''  키값으로 트리의 노드 검색
        ''' </summary>
        ''' <param name="keyValue">입력받은 키값</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function TreeViewSearch(ByVal keyValue As String) As String
            ' 키값으로 노드 검색
            Dim ResultValue As String = keyValue
            ResultValue = ChkCodeLength(ResultValue, 12)
            If Me.trv1.Nodes.Find(ResultValue, True).Length >= 1 Then
                Me.txtName.Text = Me.trv1.Nodes.Find(ResultValue, True)(0).Text
            End If

            Return ResultValue
        End Function

        Private Function ChkCodeLength(ByVal GetCodeValue As String, ByVal MaxLength As Integer) As String
            Dim FixedCodeValue As String = GetCodeValue
            If FixedCodeValue.Length > 0 Then
                For i As Integer = FixedCodeValue.Length To MaxLength - 1
                    FixedCodeValue += "0"
                Next i
            Else
                Me.txtCode.Text = ""
                Me.txtName.Text = ""
            End If
            Return FixedCodeValue
        End Function

        Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
            With Me.trv1
                If TypeOf GcurrentPop Is CommonControls.pop Then
                    GcurrentPop.TextValue = Me.txtCode.Text.Trim()
                    GcurrentPop.NameText = Me.txtName.Text.Trim()
                    GcurrentPop.txtUserControl.Select()
                    GcurrentPop.txtUserControl.Focus()
                Else
                    Dim colDatas() As String = Split(GcurrentPop.get_ColData(GcurrentPop.Col), ";")
                    Dim nameColKey As String = ""

                    If UBound(colDatas) >= 5 Then
                        If _
                            Trim(colDatas(5)) <> "" _
                            And Trim(colDatas(5)) <> "0" _
                            Then
                            nameColKey = Trim(colDatas(5))
                        End If
                    End If

                    If nameColKey = "" Then
                        nameColKey = GcurrentPop.get_ColKey(GcurrentPop.Col) & "Name"
                    End If

                    GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.Col, Me.txtCode.Text.Trim())
                    GcurrentPop.set_TextMatrix( _
                        GcurrentPop.Row _
                        , GcurrentPop.get_ColIndex(nameColKey) _
                        , Me.txtName.Text.Trim() _
                    )
                End If
            End With
            Me.Hide()
        End Sub

        Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
            Me.Hide()
        End Sub
    End Class

End Namespace
