Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports ubiLease.DAT
Imports System.Configuration
Imports ubiLease.UI.MainUi
Imports ubiLease.CommonFunction



Namespace ubiLease.UI.MainUi


    Public Class TreeViewContext

        Public UserContextMenu As ContextMenu

        Private bizStr As String = ""
        Private userIdStr As String = ""

        Private GmainCommonFunction As ubiLease.CommonFunction.Common = New ubiLease.CommonFunction.Common
        Private GmainDataCmd As ubiLease.DAT.ExecuteDbCommand = New ubiLease.DAT.ExecuteDbCommand


        Private _prgUserid As String = ""
        Private _prgid As String = ""
        Private _prgkey As String = ""
        Private _prgtxt As String = ""

        Private _tmp_trv As TreeView

        '' 폴더 추가 이벤트 생성

        Private Sub onAddFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Dim cmd As String = ""
            cmd = "insert into FavoritesMenu ("
            cmd = cmd & " UserID, UDFName, Property,DLevel,ProgramID ,ParentPkey,UseYesOrNo "
            cmd = cmd & " ) values ("
            cmd = cmd & "'" & _prgUserid & "',"
            cmd = cmd & "'" & _prgtxt & "',"
            cmd = cmd & "'1',"
            cmd = cmd & "'',"
            cmd = cmd & "'" & _prgid & "',"
            cmd = cmd & "'',"
            cmd = cmd & "1"
            cmd = cmd & " )"

            Dim reciveDataSet As DataSet = GmainDataCmd.ExecuteSql(ConfigurationManager.AppSettings("SystemDb"), cmd)

            '' 다시 Load


        End Sub

        '' 프로그램 추가 이벤트 생성

        Private Sub onAddProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Dim cmd As String = ""
            cmd = "insert into FavoritesMenu ("
            cmd = cmd & " UserID, UDFName, Property,DLevel,ProgramID ,ParentPkey,UseYesOrNo "
            cmd = cmd & " ) values ("
            cmd = cmd & "'" & _prgUserid & "',"                 ''[사용자 아이디]
            cmd = cmd & "'" & _prgtxt & "',"        ''[프로그램 명]
            cmd = cmd & "'2',"                      ''[1:폴더 / 2:프로그램 여부]
            cmd = cmd & "'',"                       ''[레벨]
            cmd = cmd & "'" & _prgid & "',"         ''[프로그램아이디]
            cmd = cmd & "'',"                       ''[상위폴더]
            cmd = cmd & "1"                         ''[사용여부]
            cmd = cmd & " )"

            Dim reciveDataSet As DataSet = GmainDataCmd.ExecuteSql(ConfigurationManager.AppSettings("SystemDb"), cmd)
            RefleshTreeview()
        End Sub

        '' 폴더 삭제 이벤트 생성

        Private Sub onDelFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim cmd As String = ""
            cmd = "insert into FavoritesMenu ("
            cmd = cmd & " UserID, UDFName, Property,DLevel,ProgramID ,ParentPkey,UseYesOrNo "
            cmd = cmd & " ) values ("
            cmd = cmd & "'" & _prgUserid & "',"                 ''[사용자 아이디]
            cmd = cmd & "'" & _prgtxt & "',"        ''[프로그램 명]
            cmd = cmd & "'2',"                      ''[1:폴더 / 2:프로그램 여부]
            cmd = cmd & "'',"                       ''[레벨]
            cmd = cmd & "'" & _prgid & "',"         ''[프로그램아이디]
            cmd = cmd & "'',"                       ''[상위폴더]
            cmd = cmd & "1"                         ''[사용여부]
            cmd = cmd & " )"


            Dim reciveDataSet As DataSet = GmainDataCmd.ExecuteSql(ConfigurationManager.AppSettings("SystemDb"), cmd)


            RefleshTreeview()
           
        End Sub

        '' 프로그램 삭제 이벤트 생성
        Private Sub onDelProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


            'DELETE FROM [SYSDB].[dbo].[FavoritesMenu]
            '      WHERE userid = '999999' and pkey = 3



            Dim cmd As String = ""
            cmd = "Delete From FavoritesMenu where "
            cmd = cmd & "userid ='" & _prgUserid & "' and "                   ''[사용자 아이디]
            cmd = cmd & "pkey = " & _prgkey & " and "                          ''[키]
            cmd = cmd & "programid = '" & _prgid & "'"         ''[프로그램아이디]

            Dim reciveDataSet As DataSet = GmainDataCmd.ExecuteSql(ConfigurationManager.AppSettings("SystemDb"), cmd)


            RefleshTreeview()

        End Sub

        Public Sub ContextShow(ByVal trv As Object, ByVal e As MouseEventArgs, ByVal AloginId As String)
            SetUser(AloginId)
            ContextShow(trv, e)
        End Sub
        Public Sub ContextShow(ByVal trv As Object, ByVal e As MouseEventArgs)

            _trv = trv

            If e.Button = MouseButtons.Right Then

                Dim nd As TreeNode = CType(trv, TreeView).GetNodeAt(e.X, e.Y)

                If nd.Nodes.Count = 0 Then
                Else
                    Return
                End If

                If nd Is Nothing <> True Then
                    _prgid = nd.Name
                    If nd.Tag Is Nothing Then
                    Else
                        _prgUserid = nd.Tag.ToString().Split(CChar(";"))(0)
                        _prgkey = nd.Tag.ToString().Split(CChar(";"))(1)
                    End If

                    _prgtxt = nd.Text
                Else
                    Return
                End If

                    'If nd.Nodes.Count = 0 Then
                    'Else
                    '    Exit Sub
                    'End If


                    '' =================================================
                    '' 컨텍스트 메뉴 생성
                    UserContextMenu = New ContextMenu()


                    ''======================================
                    '' 메뉴 추가


                    'Dim item1 As MenuItem = New MenuItem("즐겨찾기에 폴더 추가", AddressOf onAddFolder_Click)
                    'item1.Name = "mnuAddFolder"

                    'Dim item2 As MenuItem = New MenuItem("즐겨찾기에 폴더 삭제", AddressOf onDelFolder_Click)
                    'item2.Name = "mnuDelFoler"

                    'Dim item3 As MenuItem = New MenuItem("-")

                    Dim item4 As MenuItem = New MenuItem("즐겨찾기에 프로그램 추가", AddressOf onAddProgram_Click)
                    item4.Name = "mnuAddProg"

                    Dim item5 As MenuItem = New MenuItem("즐겨찾기에 프로그램 삭제", AddressOf onDelProgram_Click)
                    item5.Name = "mnuDelProg"

                    ''=================================================
                    '' 메뉴 바인딩

                    'UserContextMenu.MenuItems.Add(item1)
                    'UserContextMenu.MenuItems.Add(item2)
                    'UserContextMenu.MenuItems.Add(item3)
                    'UserContextMenu.MenuItems.Add(item4)
                    'UserContextMenu.MenuItems.Add(item5)




                    If trv.Name = "trvMain" Then
                        '' ========================================
                        '' 활성화
                        '' 1.즐겨 찾기에 프로그램 추가

                        UserContextMenu.MenuItems.Add(item4)


                        '' ========================================
                        '' 비활성화


                    ElseIf trv.Name = "trvLeftBottom" Then
                        '' ========================================
                        '' 활성화
                        '' 1. 프로그램 삭제
                        UserContextMenu.MenuItems.Add(item5)
                        '' ========================================
                        '' 비활성화

                    End If
                    UserContextMenu.Show(trv, New System.Drawing.Point(e.X, e.Y))


                End If

        End Sub
        Private _trv As TreeView = Nothing

        Private Sub RefleshTreeview()

            Dim c() As Control = _trv.Parent.Parent.Controls.Find("trvLeftBottom", True)

            Dim a As ubiLease.CommonFunction.Common = New ubiLease.CommonFunction.Common
            CType(c(0), TreeView).Nodes.Clear()
            a.AddWorkFlowList(c(0), a.GbusinessDivisionCode, _prgUserid)

        End Sub

        Public Function SetUser(ByVal Auserid As String) As Boolean
            _prgUserid = Auserid
        End Function


    End Class
End Namespace
