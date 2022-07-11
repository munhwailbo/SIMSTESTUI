' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 
' form설명 :
' 작성자 : 
' 작성일 : 
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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
Imports System.Collections.Generic

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC103
        Inherits CommonControls.UiControl

#Region "폼 초기화"

        ''' <summary>
        ''' 함수명 : Initialize
        ''' 리턴값 : 
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()
            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|모니터처리코드;MonitoringResultCd;99;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;157;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;97;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;95;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;198;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;211;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|신우편번호;NewPostNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|신주소;NewAddr1;0;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|신상세주소;NewAddr2;0;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|투입지국명;DeliveryBranchNm;74;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;94;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수일자;ContactDt;77;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|순번;Orders;48;;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|담당자코드;EmployeeNumber;74;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|;Merong;40;;7;" & "o;n;n;4;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "MonitoringResultCd;모니터결과처리코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC103_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC103_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        ''' <summary>
        ''' 함수명 : PNC103_Enter 
        ''' 기  능 : 화면 전환(모니터 등록)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC103_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5))
                GmainBusinessFunction.SetValue("화면 전환", vbNullString)
            End If
        End Sub

        ''' <summary>
        ''' 함수명 : Request
        ''' 기  능 : 다른 화면에서 코드 를 받아서 해당 내역을 조회 한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, ByVal strReceiptCd As String, ByVal strSubscriberNm As String, ByVal strEmployeeNm As String)

            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.dtpContactDtFrom.TextValue = strFromDt          '시작일자
            Me.dtpContactDtTo.TextValue = strToDt              '종료일자
            Me.txtReceiptCd_2.TextValue = strReceiptCd         '접수독자번호
            Me.txtSubscriberNm_2.TextValue = strSubscriberNm   '접수독자명

            Me.popEmployeeNumber.TextValue = strEmployeeNm     '담당자 코드

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            ' '' 1. 확장구분 cboExpandDivCd
            ' '' 2. 접수번호 txtReceiptCd
            ' '' 3. 독자번호
            ' '' 4. 전화번호
            ' ''    --> 확장구분코드|신규);where(Note1='사확'

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum1.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum2.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))

        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtMobileNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))

        End Sub
    End Class

End Namespace
