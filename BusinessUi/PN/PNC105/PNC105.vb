' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 사원확장접수독자등록
' form설명 : 사원확장접수독자등록 한다
' 작성자 : 신현갑
' 작성일 : 2008-09-19
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

    Public Class PNC105
        Inherits CommonControls.UiControl

#Region "폼 초기화"

        Public Sub Initialize()
            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;12;;;" & "o;n;y;12;"       '(190)
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;13;;;" & "o;n;y;13;"       '(10)
            gridAttributes = gridAttributes & "|모니터처리코드;MonitoringResultCd;100;;l;" & "o;n;n;10;"       '(370)
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;100;;l;" & "o;n;n;10;"       '(370)
            gridAttributes = gridAttributes & "|접수일자;ContactDt;8;;;" & "o;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|순번;Orders;4;;;" & "o;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;30;;;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|접수;ContactPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)
            gridAttributes = gridAttributes & "|전화1;PhoneNum1;30;;;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|핸드폰;MobileNum;30;;;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;10;;;" & "o;n;n;10;우편번호;OldAddr1;"       '(130)
            gridAttributes = gridAttributes & "|주소;OldAddr1;50;;;" & "o;n;n;50;"       '(140)
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;100;;;" & "o;n;n;100;"       '(150)
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;7;c;;" & "o;n;n;7;지국코드;DeliveryBranchNm;"       '(160)
            gridAttributes = gridAttributes & "|투입지국명;DeliveryBranchNm;7;;;" & "o;n;n;7;"       '(160)
            gridAttributes = gridAttributes & "|지국전달사항;Note2;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;8;;;" & "o;n;n;8;"       '(62)
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;8;;;" & "o;n;n;8;"       '(63)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "MonitoringResultCd;모니터결과처리코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------

            Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            Me.dtpReceiptDtTo.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")

            Me.NewData()

        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC105_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC105_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        ''' <summary>
        ''' 함수명 : PNC105_Enter 
        ''' 기  능 : 화면 전환(모니터 등록)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC105_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
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
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, ByVal strReceiptCd As String, ByVal strSubscriberNm As String)
            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '시작일자
            Me.dtpReceiptDtTo.TextValue = strToDt      '종료일자
            Me.txtReceiptCd_2_R.TextValue = strReceiptCd  '접수독자번호
            Me.txtSubscriberNm_2_R.TextValue = strSubscriberNm  '접수독자명

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
