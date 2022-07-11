Imports Microsoft.VisualBasic
Imports VBN = Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Configuration

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Imports System.Reflection
Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.UI

Namespace ubiLease.UI.Login

    Public Class frmBusinessSelect

        'Private WithEvents BizSelect As ubiLease.CommonFunction.ubiUtility.BusinessSelect
        'Sub New()

        '    InitializeComponent()
        '    ''
        '    BizSelect = New ubiUtility.BusinessSelect
        '    BizSelect.Register(New ubiUtility.BusinessSelect._businessSelect(AddressOf selectBiz))
        'End Sub

        'Private Sub selectBiz(ByVal businessid As String)

        'End Sub


        Private Declare Function ReleaseCapture Lib "user32" () As Integer
        Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParm As Integer, ByRef lParm As String) As Long
        Private Gexception As DAT.CustomException = New DAT.CustomException

        'Private testName As frmAlarm.Alarm = Nothing

        Public GbusinessPalceCode As String = "" '사업장 코드
        Public GbusinessPalceName As String = "" '사업장 명

        'Public GorganizationCode As String = "" '조직 코드

        Public GbranchCode As String = "" '점 코드
        Public GbranchName As String = "" '지점 명

        Public GteamCode As String = "" '팀 코드
        Public GteamName As String = "" '팀 명

        Public GpartCode As String = "" '파트 코드
        Public GpartName As String = "" '파트 명

        Public GpcCode As String = "" 'pc 코드
        Public GpcName As String = "" 'pc 명

        Public GcornerCode As String = "" '코너 코드
        Public GcornerName As String = "" '코너 명

        Public GLoginId As String = "" '로그인 id
        Public GLoginName As String = "" '로그인 명

        Public GMngEmpYN As String = ""

        Public GRoleEmpNum As String = "" ' 대행자 사번

        Public GUserGrade As String = "" ' 담다아자 역활

        Public GBizEmpYN As String = "" ' 영업담당자 여부




        Public GLoginPassword As String = "" '로그인 패스워드

        ' 게시판 추가에 따른 맴버 객체
        Private GmainCommonFunction As CommonFunction.Common = Nothing
        Private GmainExecuteDbCommand As DAT.ExecuteDbCommand = Nothing
        Private GmainsqlParameters() As SqlParameter = Nothing

        Private IsPermitionSettingApply As Boolean = False

        Private MloginForm As Form = Nothing


        '' 수정할 사항 Static Value 를 사용하여 처리할 방식
        '====================================================================================================
        Public Sub Login(ByVal AinputForm As Object)

            MloginForm = AinputForm
            Me.Show()

            For Each eachItem As Object In Me.notifyMenuStripMain.Items
                eachItem.Enabled = False
            Next
            ' 권한 적용 1
            If IsPermitionSettingApply = False Then
                CheckBusinessPermition()
            End If
        End Sub

        Private Sub frmLogin_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown, picMain.MouseDown
            Call ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0&)
        End Sub

        Public Sub frmBusinessSelect_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
            Me.notifyIconMain.Dispose()
        End Sub

        ' 초기값 로드
        '====================================================================================================
        Private Sub frmBusinessSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            GmainCommonFunction = New CommonFunction.Common
            '' 공지사항 웹사이트 주소
            '' Me.WebBrowser1.Url = New System.Uri(ConfigurationManager.AppSettings("NoticeWebPagePath").ToString(), System.UriKind.Absolute)

            LoadImage()
            LoadBusinessList()


            '===================================================================
            '' CTI 등록
            Dim cti As ComRegDeploy = New ComRegDeploy()
            cti.CtiRegistor()
        End Sub

        Private Sub LoadBusinessList()

            Dim onClick As EventHandler = New EventHandler(AddressOf picBusiness_Click)
            Dim tempCommonFunction As New ubiLease.CommonFunction.Common
            Dim tempExecuteDbCommand As New DAT.ExecuteDbCommand
            Dim cmd As String = "select code, codeHangulName from commoncode where codedivision = '900' order by note4"
            Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), cmd)
            Dim titleFont As Font = New System.Drawing.Font("맑은 고딕", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))

            If System.IO.File.Exists("C:\windows\fonts\H2HDRM.TTF") Then
                titleFont = New System.Drawing.Font("HY헤드라인M", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            End If


            ' =================================================
            ' 업무 트래이 추가 , Disable 처리함.
            Me.notifyMenuStripMain.Items.Clear()
            Me.flp_BusinessBtn.FlowDirection = FlowDirection.LeftToRight

            For Each dr As DataRow In reciveDataSet.Tables(0).Rows

                '' ==============================================================
                '' 트래이에 업무 추가
                Me.notifyMenuStripMain.Items.Add(dr("codeHangulName", DataRowVersion.Current).ToString(), Nothing, onClick)

                ''===============================================================
                '' 플로우에 업부 버튼 생성

                Dim imgbtn_tmp As ubiLease.CommonControls.imgbtn = New ubiLease.CommonControls.imgbtn()

                With imgbtn_tmp
                    '.BackColor = System.Drawing.Color.WhiteSmoke
                    '.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
                    .Border = False
                    .BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
                    '.BorderColor = Color.WhiteSmoke
                    .Font = titleFont
                    '.ForeColor = Color.WhiteSmoke
                    .ForeColor = Color.Black
                    .GroupKey = Nothing
                    .BackgroundImage = Global.My.Resources.Resources.bizB02
                    .BackgroundImageLayout = ImageLayout.Center
                    .HoverColor = System.Drawing.Color.Empty
                    '.HoverForeColor = System.Drawing.Color.White
                    .HoverImage = Global.My.Resources.Resources.bizB01
                    '.Image = Global.My.Resources.Resources.bizbg02
                    '.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
                    .Selected = False
                    .SelectedColor = System.Drawing.Color.LightGray
                    '.Size = New System.Drawing.Size(411, 40)
                    '.Size = New System.Drawing.Size(350, 60)
                    .Size = New System.Drawing.Size(355, 55)
                    .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    .Name = "imgbtn2_" + dr("code", DataRowVersion.Current).ToString()
                    .Text = Space(5) + dr("codeHangulName", DataRowVersion.Current).ToString() + " 업무"
                    .Tag = dr("codeHangulName", DataRowVersion.Current).ToString()
                End With

                ' '' ==============================================================
                ' '' 버튼 추가
                Me.flp_BusinessBtn.Controls.Add(imgbtn_tmp)
                AddHandler imgbtn_tmp.Click, onClick

            Next
            Me.notifyMenuStripMain.Items.Add("-")
            Me.notifyMenuStripMain.Items.Add("종료", Nothing, onClick)

            For Each item As ToolStripItem In Me.notifyMenuStripMain.Items
                For Each dr As DataRow In reciveDataSet.Tables(0).Rows
                    If item.Text = dr("codehangulname", DataRowVersion.Current) Then
                        item.Name = "notiyMenu_" + dr("code", DataRowVersion.Current)
                        item.Enabled = False
                    End If
                Next
                If item.Text = "종료" Then
                    item.Name = "notiyMenu_Exit"
                End If
                item.Select()
            Next

            ' =================================================
            ' 업무 버튼을 Disable 처리함.
            picZS.Enabled = False
            picZS.Visible = False
            For Each eachItem As Control In Me.flp_BusinessBtn.Controls
                Dim getedType As Type = eachItem.GetType
                If getedType.Name = "imgbtn" Then
                    eachItem.Visible = False
                End If
            Next
        End Sub




        Private MmainUiForm() As Object = Nothing
        Private MrunProgramCount As Integer = 0

        ''====================================================================================================
        '' 권한 관리 (메뉴 권한)
        '' 권한은 메인 메뉴에서 처리하도록합니다.
        '' 메인에서 사원번호로 프로그램 접근 권한을 체크 할수 있도록 합니다.
        '' get 업무 접근 권한
        Private Sub CheckBusinessPermition()
            ' 버튼 컨트롤을 가져온다.
            If IsPermitionSettingApply = False Then

                Dim tempCommonFunction As New ubiLease.CommonFunction.Common
                Dim tempExecuteDbCommand As New DAT.ExecuteDbCommand

                Dim tempSqlParameter() As SqlClient.SqlParameter = Nothing
                tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", GLoginId)

                Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "GetBusinessPermintionByUser", False, True, tempSqlParameter)

                If IsNothing(reciveDataSet.Tables.Count) = False Then
                    For i As Integer = 0 To reciveDataSet.Tables(0).Rows.Count - 1

                        ' =================================================
                        ' 해당 권한이 이없으면 업무 버튼을 보이게 처리함.
                        For Each eachItem As Control In Me.flp_BusinessBtn.Controls
                            Dim getedType As Type = eachItem.GetType
                            If getedType.Name = "imgbtn" Then
                                If reciveDataSet.Tables(0).Rows(i).Item(0).ToString = Strings.Right(eachItem.Name, 2) Then
                                    eachItem.Visible = True
                                    If reciveDataSet.Tables(0).Rows(i).Item(0).ToString = "SM" Then
                                        picZS.Enabled = True
                                        picZS.Visible = True
                                        eachItem.Visible = False
                                    End If
                                End If
                            End If
                        Next

                        ' ==============================================
                        ' 트래이 아이콘에 업무 명을 비활성화 합니다.
                        ' 트래이 아이콘의 업무 리스트를 보이게 합니다.

                        For Each eachItem As Object In Me.notifyMenuStripMain.Items
                            If reciveDataSet.Tables(0).Rows(i).Item(0).ToString = Strings.Right(eachItem.Name, 2) Then
                                eachItem.Enabled = True
                                eachItem.Visible = True
                            End If
                        Next
                    Next i
                End If
                ' ===================================================
                ' 종료 활성화
                Me.notifyMenuStripMain.Items("notiyMenu_Exit").Enabled = True

                reciveDataSet = Nothing
                tempExecuteDbCommand = Nothing
                tempCommonFunction = Nothing
                tempSqlParameter = Nothing
                IsPermitionSettingApply = True
            End If

        End Sub

        Private Sub picSysSetting_Click(sender As Object, e As EventArgs) Handles picZS.Click

            'LoadBusinessList()
            If sender.enabled Then
                sender.name = "SelectSM"
                sender.text = "시스템관리"
                picBusiness_Click(sender, e)
            End If

        End Sub

        '====================================================================================================
        ' 해당 업무 선택
        Private Sub picBusiness_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            If ProcessExit(sender.Name) = True Then
                Exit Sub
            End If

            '' 폼을 숨김
            Me.Visible = False


            '' 새로운 메인 폼을 실행할지 결정
            If CheckCreadedProgram(sender.Name, True) = False Then
                Exit Sub
            End If

            ''  
            Dim businessDivisionName As String = ""

            If Replace(sender.Tag, " ", "") <> "" Then
                businessDivisionName = Replace(sender.Tag, " ", "")
            Else
                businessDivisionName = Replace(sender.Text, "", "")
            End If

            ''
            If InStr(sender.Name, "Select") = 0 Then
                sender.Name = "Select" & Strings.Right(sender.Name, 9)
            End If

            ''

            If IsNothing(MmainUiForm) = True Then
                ReDim MmainUiForm(0)
            Else
                ReDim Preserve MmainUiForm(MmainUiForm.Length)
            End If


            ''
            MmainUiForm(MmainUiForm.Length - 1) = New UI.MainUi.frmMainUi


            ''
            With MmainUiForm(MmainUiForm.Length - 1)


                .GmainBusinessFunction.SetValue("사업장 코드", GbusinessPalceCode)
                .GmainBusinessFunction.SetValue("사업장 명", GbusinessPalceName)

                .GmainBusinessFunction.SetValue("점 코드", GbranchCode)
                .GmainBusinessFunction.SetValue("점 명", GbranchName)

                .GmainBusinessFunction.SetValue("팀 코드", GteamCode)
                .GmainBusinessFunction.SetValue("팀 명", GteamName)

                .GmainBusinessFunction.SetValue("파트 코드", GpartCode)
                .GmainBusinessFunction.SetValue("파트 명", GpartName)

                .GmainBusinessFunction.SetValue("PC 코드", GpcCode)
                .GmainBusinessFunction.SetValue("PC 명", GpcName)

                .GmainBusinessFunction.SetValue("코너 코드", GcornerCode)
                .GmainBusinessFunction.SetValue("코너 명", GcornerName)

                ' 로그인 정보 전달
                .GmainBusinessFunction.SetValue("로그인 ID", GLoginId)

                .GmainBusinessFunction.SetValue("로그인 명", GLoginName)

                .GmainBusinessFunction.SetValue("역할대행사번", GRoleEmpNum)

                .GmainBusinessFunction.SetValue("사용자등급", GUserGrade)

                .GmainBusinessFunction.SetValue("영업담당여부", GBizEmpYN)

                .GmainBusinessFunction.SetValue("관리담당여부", GMngEmpYN)


                .lblLogin.Text = GpartName & " / " & GLoginName
                .lblLoginTime.Text = Format(Now, "HH:mm:ss")

                ' 업무 선택정보 전달
                Try
                    .BusinessSelect(Me, Strings.Right(sender.Name, 2), businessDivisionName)

                Catch ex As Exception
                    Gexception.getException(ex)
                End Try

            End With

            'Debug.Print(Strings.Right(sender.Name, 2), Replace(sender.Text, " ", ""))
        End Sub

        Private Declare Sub SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer)
        Private Const HWND_TOP = 0
        Private Const SWP_SHOWWINDOW = &H40

        '====================================================================================================
        ' 업무 MainForm 호출 여부 판단
        Public Function CheckCreadedProgram(ByVal AbusinessDivision As String, ByVal ACheck As Boolean) As Boolean

            CheckCreadedProgram = False

            If IsNothing(MmainUiForm) = False Then
                For forNumber As Integer = 0 To MmainUiForm.Length - 1 Step 1
                    If IsNothing(MmainUiForm(forNumber)) = False Then
                        If MmainUiForm(forNumber).GmainCommonFunction.GbusinessDivisionCode = Strings.Right(AbusinessDivision, 2) Then
                            If ACheck = True Then
                                MmainUiForm(forNumber).show()
                                Dim tempHandle As Integer = CInt(MmainUiForm(forNumber).Handle.ToString)

                                SetWindowPos(
                                    tempHandle, HWND_TOP, MmainUiForm(forNumber).Left, MmainUiForm(forNumber).Top, MmainUiForm(forNumber).Width, MmainUiForm(forNumber).Height - 1, SWP_SHOWWINDOW
                                )

                                Exit Function
                            Else
                                MmainUiForm(forNumber) = Nothing
                            End If
                        End If
                    End If
                Next forNumber
            End If

            If ACheck = True Then
                MrunProgramCount += 1
            Else
                MrunProgramCount -= 1
            End If

            For Each eachItem As Object In Me.notifyMenuStripMain.Items
                If Strings.Right(AbusinessDivision, 2) = Strings.Right(eachItem.Name, 2) Then
                    eachItem.Checked = ACheck
                    Exit For
                End If
            Next

            If ACheck = False Then
                For Each eachItem As Object In Me.flp_BusinessBtn.Controls
                    If _
                        Strings.Right(AbusinessDivision, 2) = Strings.Right(eachItem.Name, 2) _
                        And InStr(eachItem.Name, "imgbtn") >= 1 _
                        Then
                        eachItem.Name = Replace(eachItem.Name, "Select", "")
                        Exit For
                    End If
                Next
            End If

            CheckCreadedProgram = True

        End Function

        Private Sub LoadNotifyIconData()

            Dim tempExecuteDbCommand As New DAT.ExecuteDbCommand
            Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), " select Code, CodeHangulName from CommonCode " _
             + "where codeDivisionHangulName = '시스템 구분 명'" +
             +"and PrivateUseYesOrNo = '1'"
            )

        End Sub

        '====================================================================================================
        ' 해당 업무 공지 더블 클릭
        Private Sub notifyIconMain_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles notifyIconMain.DoubleClick

            Me.Show()

        End Sub

        '====================================================================================================
        ' 업무 선택 화면 닫기 클릭
        Private Sub picClose_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
            Handles picClose.MouseClick _
            , picMinimumSize.MouseClick

            If sender.Name = "picClose" Then
                ProcessExit("Exit")
            ElseIf sender.Name = "picMinimumSize" Then
                Me.Hide()
            End If

        End Sub

        '====================================================================================================
        ' 업무 종료 처리 (실행되고 있는 업무 영역 종료 처리)
        Private Function ProcessExit(ByVal AmenuString As String) As Boolean
            If Strings.Right(AmenuString, 4) = "Exit" Then
                Dim returnMessageNumber As Integer = MsgBoxResult.Yes

                If MrunProgramCount >= 1 Then
                    Dim tempCommonFunction As New CommonFunction.Common

                    returnMessageNumber = MsgBox(
                        "'" & MrunProgramCount & "'" _
                        & "개의 개별 업무 프로그램이 실행 중입니다." _
                        & vbCrLf & "그래도 종료하시겠습니까?",
                        MsgBoxStyle.YesNo,
                        tempCommonFunction.GmessageTile
                    )
                    tempCommonFunction = Nothing
                End If

                If returnMessageNumber = MsgBoxResult.Yes Then
                    If IsNothing(MmainUiForm) = False Then
                        For forNumber As Integer = 0 To MmainUiForm.Length - 1 Step 1
                            If IsNothing(MmainUiForm(forNumber)) = False Then
                                MmainUiForm(forNumber).Close()

                                Try
                                    MmainUiForm(forNumber).Dispose()
                                Catch ex As Exception
                                    Gexception.getException(ex)
                                    Debug.WriteLine(ex.Message)
                                End Try
                            End If
                        Next forNumber
                    End If

                    MmainUiForm = Nothing

                    MloginForm.Close()
                    MloginForm.Dispose()

                    Me.notifyIconMain.Dispose()

                    LogOut()
                    Me.Close()
                    Me.Dispose()
                End If

                ProcessExit = True
            End If
        End Function
        Private Sub picZS_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picZS.MouseEnter
            Me.Cursor = Cursors.Hand
            Try
                If sender.Name = "picZS" Then
                    sender.Image = Global.My.Resources.settings_on
                Else
                    sender.Image = Global.My.Resources.settings_on
                End If
            Catch ex As Exception
                Gexception.getException(ex)
                Debug.WriteLine(ex.Message)
            End Try
        End Sub
        Private Sub picZS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picZS.MouseLeave

            Me.Cursor = Cursors.Default
            Try
                If sender.Name = "picZS" Then
                    sender.Image = Global.My.Resources.settings
                Else
                    sender.Image = Global.My.Resources.settings
                End If
            Catch ex As Exception
                Gexception.getException(ex)
                Debug.WriteLine(ex.Message)
            End Try
        End Sub


        '====================================================================================================
        ' 업무 선택 화면 프로그램 종료버튼 활성화
        Private Sub picClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
           Handles picClose.MouseEnter _
           , picMinimumSize.MouseEnter

            Me.Cursor = Cursors.Hand
            Try
                If sender.Name = "picClose" Then
                    sender.Image = Global.My.Resources.close01
                ElseIf sender.Name = "picMinimumSize" Then
                    sender.Image = Global.My.Resources.최소화_01
                End If
            Catch ex As Exception
                Gexception.getException(ex)
                Debug.WriteLine(ex.Message)
            End Try
        End Sub

        '====================================================================================================
        ' 업무 선택 화면 프로그램 종료버튼 비활성화
        Private Sub picClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles picClose.MouseLeave _
            , picMinimumSize.MouseLeave

            Me.Cursor = Cursors.Default
            Try
                If sender.Name = "picClose" Then
                    sender.Image = Global.My.Resources.close
                ElseIf sender.Name = "picMinimumSize" Then
                    sender.Image = Global.My.Resources.최소화_00
                End If
            Catch ex As Exception
                Gexception.getException(ex)
                Debug.WriteLine(ex.Message)
            End Try
        End Sub

        '====================================================================================================
        ' 업무 선택 화면 프로그램 종료
        Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles picClose.Click _
            , picMinimumSize.Click

            If sender.Name = "picClose" Then
                LogOut()
                Me.Close()
                Me.Dispose()
            ElseIf sender.Name = "picMinimumSize" Then
                Me.Hide()
            End If
        End Sub

        '====================================================================================================
        ' 프로그램 종료(로그 아웃 처리)
        Private Sub LogOut()
            Dim QueryString As String = vbNullString
            Dim tempCommonFunction As New ubiLease.CommonFunction.Business
            Dim tempExecuteDbCommand As New DAT.ExecuteDbCommand

            'Dim tempSqlParameter() As SqlParameter = Nothing
            'tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", GLoginId)
            'Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteStoredProcedure("GetBusinessPermintionByUser", False, True, tempSqlParameter)

            QueryString = QueryString & "chkUserLogOut '" & tempCommonFunction.GetValue("로그인 ID") & "','" & ubiLease.DAT.localhostinfo.localIPAddress() & "'"
            Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), "Exec " & QueryString)

            reciveDataSet = Nothing
            tempExecuteDbCommand = Nothing
            tempCommonFunction = Nothing
        End Sub

        ' 버전 표시
        Private Sub frmBusinessSelect_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
            Me.lblVersion.Text = ConfigurationManager.AppSettings("SystemTitle").ToString() & Space(2) & GmainCommonFunction.versionInfo()
            Me.lblApplication.Text = Me.CompanyName & Space(2) & Me.GLoginId & Space(2) & Me.GLoginName
        End Sub

        ' 질문과 답변
        Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
            Process.Start(ConfigurationManager.AppSettings("CustomRequestPagePath").ToString() & "?id=" & Me.GLoginId & "&pwd=" & Me.GLoginPassword)
        End Sub

        Public Sub LoadImage()
            Me.imgListMain.Images.Clear()
        End Sub

        ' 트레이 아이콘 제거/ 경광등 프로그램 제거

        Private Sub frmBusinessSelect_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            notifyIconMain.Dispose()
        End Sub

    End Class
End Namespace

