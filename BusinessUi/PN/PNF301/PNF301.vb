'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 코드관리
' form 설명 : 문화일보 코드 관리
' 작성자 : 권진성
' 작성일 : 2008.09.01
'////////////////////////////////////////////////////////////////////////////////////////////////////

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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNF301
        Inherits CommonControls.UiControl

        Private Sub PNF301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "폼 초기화"
        ''' <summary>
        ''' 함수명 : Initialize
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
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
            gridAttributes = gridAttributes & "n;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"


            'gridAttributes = gridAttributes & "|모니터담당;MonitoringEmpNum;50;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|독자번호;SubscribeCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수독자번호;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|확장구분;ExpandDivCd;73;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|독자상태코드;ReaderStateCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|구독상태코드;SubscribeStateCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;161;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;93;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;100;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;0;;4;" & "o;n;y;10;우편번호;OldPostNm "
            gridAttributes = gridAttributes & "|주소;OldPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;193;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;232;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|확장일자;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;1;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국 명;DeliveryBranchNm;55;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;59;#,##0;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|배달구분코드;DeliveryDivCd;84;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|배달처코드;DeliveryRegionCd;68;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|본사독자구분;MHReaderDivCd;80;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;78;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|만료일자;FixedEdDt;1;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|서비스기간;ServiceTerm;74;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|수금년월;CollectionYYYYMM;63;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|(신)우편번호;NewPostNum;0;;4;" & "o;n;y;10;우편번호;NewPostNm"
            gridAttributes = gridAttributes & "|(신)주소;NewPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|(신)주소;NewAddr1;0;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|(신)상세주소;NewAddr2;0;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;62;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|판매국작성명단여부;SalWtListYn;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|투입처코드;DeliveryChnlCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|투입처명;DeliveryChnlNm;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|구독권독자여부;CouponReaderYN;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|소속사코드;CouponSeriesNum;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;구독상태코드"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '담당자 셋팅
            popEmployeeNumber.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popEmployeeNumber.Enabled = False
                popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("로그인 ID"), _
                                                  GmainBusinessFunction.GetValue("역할대행사번"))
            End If

        End Sub
#End Region

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '지국확장 독자 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '접수독자번호
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("화면 전환", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)
        End Sub

  
     
        Private Sub popEmployeeNumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popEmployeeNumber.Load

        End Sub
    End Class

End Namespace
