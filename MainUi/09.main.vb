Option Explicit On
Option Strict Off

Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.UI
Imports ubiLease.UI.Alarm
Imports ubiLease.DAT
Imports System.Configuration
Imports System.Reflection

Namespace ubiLease.UI.MainUi
    Public Class frmMainUi

        '' 공용변수 선언
        Public GmainCommonFunction As New Common
        Public GmainBusinessFunction As New Business
        Public GmainExecuteDbCommand As New ExecuteDbCommand
        Public frmPrintBase As New frmCrystalPrint()
        Public GetSmtpServerIp As String = ""
        Public GetMasterEmailAddress As String = ""

        '' 지역변수 선언
        Private mnutrv As TreeViewContext = New TreeViewContext()
        Private ToolbarType As String = ""
        Private HardCopyType As String = ""  '1:print, 2:ImageSave
        Private HardCopyPath As String = ""

        ' 알람 폼
        Private MAlarmForm As frmAlarm = Nothing

        '' 프로그램 진입점
        Private Sub frmMainUi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            Me.GmainCommonFunction.GmessageTile = ConfigurationManager.AppSettings("SystemTitle").ToString.Trim()
            Me.Text = "(" & Me.SbusinessDivisionName & ")" & ConfigurationManager.AppSettings("SystemTitle").ToString() '"자산관리시스템"

            sttMain.Items("lblVersion").Text = Space(5) & ConfigurationManager.AppSettings("SystemTitle").ToString.Trim() & Space(2) & GmainCommonFunction.versionInfo()
            'Me.lblApplication.Text = Me.CompanyName & Space(2) & Me.GLoginId & Space(2) & Me.GLoginName

            If CBool(ConfigurationManager.AppSettings("AuthorizationCheck").ToString()) = True Then
                ControlDisable()
            End If

            'picLeftTopHeader.BackColor = Color.DarkBlue  
            'lblLeftTitle.BackColor = Color.DarkBlue  

            sttMain.Items("lblStatus1").Text = "[ " & ConfigurationManager.AppSettings("Slogan").ToString() & " ]"
            sttMain.Items("lblStatus1").Width = sttMain.Items("lblStatus1").Text.ToString.Length * 11

            lblLogin.Visible = False
            sttMain.Items("lblStatus1").Text = "[ " & Me.lblLogin.Text & " ]"
            sttMain.Items("lblStatus1").Width = sttMain.Items("lblStatus1").Text.ToString.Length * 11

            GetSmtpServerIp = ConfigurationManager.AppSettings("SMTP").ToString()
            GetMasterEmailAddress = ConfigurationManager.AppSettings("MasterEmailAddress").ToString()

            ToolbarType = ConfigurationManager.AppSettings("ToolbarType").ToString()
            HardCopyType = ConfigurationManager.AppSettings("HardCopyType").ToString()
            HardCopyPath = ConfigurationManager.AppSettings("HardCopyPath").ToString()

            GmainBusinessFunction.SetValue("툴바타입", ToolbarType)

            With tlbMain
                ' 툴바타입 '1:상단툴바 , 2:좌측툴바 , 3:우측툴바 
                If GmainBusinessFunction.GetValue("툴바타입").ToString = "1" Then
                    .Dock = DockStyle.Top  ' .Right
                ElseIf GmainBusinessFunction.GetValue("툴바타입").ToString = "2" Then
                    .Dock = DockStyle.Left   ' .Right
                ElseIf GmainBusinessFunction.GetValue("툴바타입").ToString = "3" Then
                    .Dock = DockStyle.Right   ' .Right
                Else
                    .Dock = DockStyle.Top  ' .Right
                End If
            End With

            GetSmtpServerIp = ConfigurationManager.AppSettings("SMTP").ToString()
            GetMasterEmailAddress = ConfigurationManager.AppSettings("MasterEmailAddress").ToString()

            '' CTI 모듈 로딩(좌측하단용)
            ''  Load_cti_module()   
        End Sub

        'Private GmainsqlParameters() As SqlParameter = Nothing
        'Private GmainCollection As New Collection

        'Public Function GmainCollectionGetValue(ByVal collectionKey As String) As String
        '    GmainCollectionGetValue = GmainCollection.Item(collectionKey).ToString()
        '    If GmainCollectionGetValue = "" Then
        '        GmainCollectionGetValue = collectionKey + " 없음."
        '    End If
        'End Function

        'Public Sub GmainCollectionSetValue(ByVal collectionValue As String, ByVal collectionKey As String)
        '    ' 중복 방지 로직 추가
        '    GmainCollection.Add(collectionValue, collectionKey)
        'End Sub

        '====================================================================================================
        ' 조기 경보 팝업 사용자 확인

        Public Function ConfirmationID(ByVal GLoginId As String) As Boolean

            Dim tempSqlParameter() As SqlParameter = Nothing
            Dim tempCommonFunction As New ubiLease.CommonFunction.Common

            tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", GLoginId)

            Dim tempExecuteDbCommand As New ubiLease.DAT.ExecuteDbCommand

            'Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteStoredProcedure("CheckAlramUser", False, True, tempSqlParameter)

            Dim strLocCode As String = ""
            strLocCode = "SELECT CodeHangulName,Note1, Note2 FROM dbo.CommonCode WHERE CodeDivision = '999' AND Note1 = '" + GLoginId + "'"

            Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), strLocCode)

            'If reciveDataSet.Tables(0).Rows.Count = 0 Then
            '    Return False
            'Else
            '    Return True
            'End If

        End Function

        '====================================================================================================
        ' 조기 경보 창띄우기

        Public Sub AlarmShow(ByVal SbusinessDivisionCode As String, ByVal LoginID As String, Optional ByVal AlarmKind As String = "")

            If IsNothing(MAlarmForm) Then
                MAlarmForm = New frmAlarm()
            End If

            If MAlarmForm.Visible = False Then
                MAlarmForm.Visible = True
            End If

            '로그인 정보를 팝업에 넘겨 준다.
            MAlarmForm.LogInfomation = LoginID.Trim()

            MAlarmForm.BusinessDivisionCode = SbusinessDivisionCode.Trim()

            MAlarmForm.Show()

            AddHandler MAlarmForm.OnChageMessageEventHandler, AddressOf OnAlarmMessage

        End Sub


        '' 화면 전환

        Public Sub OnAlarmMessage(ByVal sender As Object, ByVal e As AlarmMessageEventArgs)
            Me.Focus()
            GmainBusinessFunction.SetValue("화면 전환", e.CriteriaValue)

            If GmainCommonFunction.AddUiControl(Me.Controls("pnlRight"), e.ScreenID) = True Then
                Dim UiControlName As String = GmainBusinessFunction.UiControlName(e.ScreenID)
                GmainCommonFunction.AddPrettyTab(Me.Controls("pnlTop").Controls("pnlTopLeft"), New CommonControls.PrettyTab, e.ScreenID, UiControlName)
                GmainCommonFunction.GactiveUiControlName = e.ScreenID
                CType(GmainCommonFunction.GactiveUiControl, ubiLease.CommonControls.UiControl).Hide()
                CType(GmainCommonFunction.GactiveUiControl, ubiLease.CommonControls.UiControl).ShowUiControl(e.ScreenID)
                Me.TopMost = True
                Me.TopMost = False
            Else
                GmainBusinessFunction.SetValue("화면 전환", "")
            End If
            '' 추가로 stripMemu 메뉴에 목록을 추가하는 로직 필요함
        End Sub
        'CTI 폼
        Private MCTITransForm As frmCTIMain = Nothing

        '====================================================================================================
        ' CTI 팝업 Show

        Public Sub CTITransShow(ByVal SbusinessDivisionCode As String, ByVal LoginID As String, Optional ByVal AlarmKind As String = "")

            If IsNothing(MCTITransForm) Then
                Dim tempSqlParameter() As SqlParameter = Nothing
                Dim tempCommonFunction As New ubiLease.CommonFunction.Common

                tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AEmployeeNumber", LoginID.Trim())

                Dim tempExecuteDbCommand As New ubiLease.DAT.ExecuteDbCommand
                Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "CallCenterUserCheck", False, True, tempSqlParameter)

                '' 테이블 체크
                If reciveDataSet.Tables.Count > 0 Then
                Else
                    Exit Sub
                End If

                '' 행 체크
                If reciveDataSet.Tables(0).Rows.Count > 0 Then
                Else
                    Exit Sub
                End If

                If IsNothing(MAlarmForm) Then
                    MCTITransForm = New frmCTIMain(LoginID.Trim())
                End If

                If MCTITransForm.Visible = False Then
                    MCTITransForm.Visible = True
                End If

                '로그인 정보를 팝업에 넘겨 준다.
                MCTITransForm.LogInfomation = LoginID.Trim()
                MCTITransForm.BusinessDivisionCode = SbusinessDivisionCode.Trim()
                MCTITransForm.Show()

                '' CTI용 이벤트 헨들러 추가
                AddHandler MCTITransForm.OnChageMessageEventHandler, AddressOf OnCtiMessage
            Else
                MCTITransForm.Activate()
            End If

        End Sub

        '=========================================================
        'CTI 화면 전환
        '=========================================================
        Public Sub OnCtiMessage(ByVal sender As Object, ByVal e As CtiMessageEventArgs)

            'Me.Activate()

            If e.ScreenID = "CTI종료" Then
                MCTITransForm = Nothing
                Exit Sub
            End If

            GmainBusinessFunction.SetValue("화면 전환", e.CriteriaValue)

            If GmainCommonFunction.AddUiControl(Me.Controls("pnlRight"), e.ScreenID) = True Then
                Dim UiControlName As String = GmainBusinessFunction.UiControlName(e.ScreenID)
                GmainCommonFunction.AddPrettyTab(Me.Controls("pnlTop").Controls("pnlTopLeft"), New CommonControls.PrettyTab, e.ScreenID, UiControlName)
                GmainCommonFunction.GactiveUiControlName = e.ScreenID
                CType(GmainCommonFunction.GactiveUiControl, ubiLease.CommonControls.UiControl).Hide()
                CType(GmainCommonFunction.GactiveUiControl, ubiLease.CommonControls.UiControl).ShowUiControl(e.ScreenID)
                Me.Activate()
            Else
                GmainBusinessFunction.SetValue("화면 전환", "")
            End If

            '' 추가로 stripMemu 메뉴에 목록을 추가하는 로직 필요함
        End Sub

        Public Sub addEvent(ByVal sender As Object)
            AddHandler CType(sender, ubiLease.CommonControls.UiControl).OnUiEventMessageHandler, AddressOf OnUiMessage

        End Sub

        Public Sub OnUiMessage(ByVal sender As Object, ByVal e As ubiLease.CommonControls.UiEventMessageArgs)

            If CType(e.CustomArgs, Collections.IDictionary).Contains("민원접수일") Then
                If IsNothing(MCTITransForm) Then
                    'MCTITransForm = New frmCTIMain(e.UserID.Trim())
                    'MCTITransForm.Show()

                Else
                    MCTITransForm.ShowConsultation(e.CustomArgs("민원접수키"), e.CustomArgs("민원접수일"), e.CustomArgs("순번"))
                End If
            Else
                If IsNothing(MCTITransForm) Then
                Else
                    MCTITransForm.CallPhoneNumber = CType(e.CustomArgs, Dictionary(Of String, Object))
                End If
            End If



            'MCTITransForm.CallPhoneNumber = CType(e.CustomArgs, Collections.IDictionary)("PhoneNumber").ToString()
            'MCTITransForm.CallPhoneNumber = CType(e.CustomArgs, Collections.IDictionary)("ReciptNumber").ToString()
            'MCTITransForm.CallPhoneNumber = CType(e.CustomArgs, Collections.IDictionary)("ReaderNNumber").ToString()
            'MCTITransForm.CallPhoneNumber = CType(e.CustomArgs, Collections.IDictionary)("ExDivNumber").ToString()
        End Sub


        Public Sub AlarmClose()
            If Not (MAlarmForm Is Nothing) Then
                MAlarmForm.notifyIcon1.Dispose()
                MAlarmForm.Dispose()
            End If
        End Sub

        Private Sub frmMainUi_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            ' 계약 선택후 조기 경보 팝업 조회 권한자 일경우 조기경보 팝업 호출
            'If SbusinessDivisionCode = "CO" And Me.ConfirmationID(CStr(GmainBusinessFunction.GetValue("로그인 ID"))) = True Then
            '    Me.AlarmShow(SbusinessDivisionCode, Me.ConfirmationID(GmainBusinessFunction.GetValue("로그인 ID").ToString()).ToString())
            'End If
            Me.CTITransShow(SbusinessDivisionCode, GmainBusinessFunction.GetValue("로그인 ID").ToString())
        End Sub

        Private Sub trvMain_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trvMain.MouseClick

            mnutrv.ContextShow(sender, e, GmainBusinessFunction.GetValue("로그인 ID").ToString())

        End Sub

        Private Sub trvLeftBottom_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trvLeftBottom.MouseClick

            mnutrv.ContextShow(sender, e, GmainBusinessFunction.GetValue("로그인 ID").ToString())

        End Sub

        

        ''' <summary>
        ''' CTI 로그인
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnCTIShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCTIShow.Click
            Me.CTITransShow(SbusinessDivisionCode, GmainBusinessFunction.GetValue("로그인 ID").ToString())
        End Sub

        ''' <summary>
        ''' CTI 로그아웃
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnCTI_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCTI_Logout.Click
            If Not IsNothing(MCTITransForm) Then
                MCTITransForm.Close()
                MCTITransForm = Nothing
            End If
        End Sub

        
        Private Sub frmMainUi_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

            Dim returnMessageNumber As Integer = MsgBox( _
                            GmainCommonFunction.GbusinessDivisionName & " 프로그램을 종료하시겠습니까?", MsgBoxStyle.YesNo, GmainCommonFunction.GmessageTile _
                        )

            If returnMessageNumber = MsgBoxResult.No Then
                If IsNothing(e) = False Then
                    e.Cancel = True
                End If
                Exit Sub
            End If

            If IsNothing(e) = True Then
                Me.Dispose()
            End If

            If Not IsNothing(MCTITransForm) Then
                MCTITransForm.Close()
                MCTITransForm = Nothing
            End If
        End Sub

    End Class

End Namespace
