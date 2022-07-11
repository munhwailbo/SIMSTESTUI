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


Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC202
        Inherits CommonControls.UiControl
        '====================================================================================================


#Region "폼 초기화"

        Public Sub Initialize()

            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|독자코드;ReaderCd;80;;l;" & "o;n;n;8;"       '(10)
            gridAttributes = gridAttributes & "|독자명;ReaderNm;100;;l;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;200;;l;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;200;;l;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;200;;l;" & "o;n;n;30;"       '(50)
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;100;;l;" & "o;n;n;10;"       '(90)
            gridAttributes = gridAttributes & "|주소;OldAddr1;200;;l;" & "o;n;n;50;"       '(100)
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;200;;l;" & "o;n;n;100;"       '(110)
            gridAttributes = gridAttributes & "|신우편번호;NewPostNum;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|신주소;NewAddr1;200;;l;" & "o;n;y;50;"       '(70)
            gridAttributes = gridAttributes & "|신상세주소;NewAddr2;200;;l;" & "o;n;y;100;"       '(80)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|독자코드;ReaderCd;80;;l;" & "io;n;y;8;"         '(10)
            gridAttributes = gridAttributes & "|순번;Orders;80;;l;" & "io;n;y;8;"         '(10)
            gridAttributes = gridAttributes & "|토요독자명;SatReaderNm;200;;l;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|독자전화번호;SatPhoneNum1;200;;l;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|핸드폰번호;SatMobileNum;200;;l;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|지국코드;SatBranchCd;100;;l;" & "io;n;n;10;지국명;SatBranchNm"       '(10)
            gridAttributes = gridAttributes & "|지국명;SatBranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|우편번호;SatOldPostNum;100;;l;" & "io;n;n;10;"   '(60)
            gridAttributes = gridAttributes & "|주소;SatOldAddr1;200;;l;" & "io;n;n;50;"          '(70)
            gridAttributes = gridAttributes & "|상세주소;SatOldAddr2;200;;l;" & "io;n;n;100;"     '(80)
            gridAttributes = gridAttributes & "|(신)우편번호;SatNewPostNum;200;;l;" & "io;n;y;30;"   '(30)
            gridAttributes = gridAttributes & "|(신)주소;SatNewAddr1;200;;l;" & "io;n;y;30;"         '(40)
            gridAttributes = gridAttributes & "|(신)상세주소;SatNewAddr2;200;;l;" & "io;n;y;30;"     '(50)
            gridAttributes = gridAttributes & "|투입요청일;DeliveryReqDt;100;;l;" & "io;n;n;10;" '(90)
            gridAttributes = gridAttributes & "|접수일자;ReceiptDt;200;;l;" & "io;n;n;50;"       '(100)
            gridAttributes = gridAttributes & "|진행상태코드;IngStateCd;200;;l;" & "io;n;n;100;" '(110)

            'grid_2 code combo    
            gridCodeNameList = ""

            'gridCodeNameList = gridCodeNameList & "SubscribeStateCd;구독상태코드"
            'gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"


            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3

            lblRecordState.Text = "준비"

        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : ACA003_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ACA003_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        ''' <summary>
        ''' 함수명 : PNC202_Enter 
        ''' 기  능 : 화면 전환(토요가정배달 접수 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC202_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4))
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
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, _
                              ByVal strReceiptCd As String, ByVal strSubscriberNm As String )
            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '시작일자
            Me.dtpReceiptDtTo.TextValue = strToDt      '종료일자
            Me.txtReceiptCd_R.TextValue = strReceiptCd  '접수독자번호
            Me.txtSubscriberNm_R.TextValue = strSubscriberNm  '접수독자명

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            'Me.GmainCommonFunction.GRequestDataNumber = 9
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub grd_2_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

            Me.grd_2.Editable = EditableSettings.flexEDNone

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

        ''' <summary>
        ''' 평일 투입지국전화
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtBranchPhoneNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))
        End Sub

        ''' <summary>
        ''' 평일 지국담당자 전화
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtChargePhoneNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))
        End Sub

        ''' <summary>
        ''' 토요배달 지국전화
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtSatBranchPhoneNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))
        End Sub

        ''' <summary>
        ''' 토요배달 영업담당자 전화
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtSatChargePhoneNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))
        End Sub


    End Class

End Namespace
