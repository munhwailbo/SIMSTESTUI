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

    Public Class PNF302
        Inherits CommonControls.UiControl

        Private Sub PNF302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|확장구분;ExpandDivCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|지역코드;BranchRegionCd;62;;4;" & "o;n;n;10;지국지역코드;"
            gridAttributes = gridAttributes & "|지역명;BranchRegionNm;112;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지국코드;DeliveryBranchCd;62;;4;" & "o;n;n;7;지국코드;DeliveryBranchNm"
            gridAttributes = gridAttributes & "|지국명;DeliveryBranchNm;62;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|접수부수;PaperNum1;62;#,##0;7;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|반송부수;PaperNum2;0;#,##0;7;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|실부수;PaperNum3;50;#,##0;7;" & "o;y;7;;;"
            gridAttributes = gridAttributes & "|통과부수;PaperNum4;62;#,##0;7;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|미통과부수;PaperNum5;74;#,##0;7;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|중지부수;PaperNum6;62;#,##0;7;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|투입부수;PaperNum7;0;#,##0;7;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|지국장명;BrChiefNm;62;;1;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|지국연락처;BrPhoneNum1;114;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국장핸드폰;BrMobileNum;106;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            '' '' ''gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '--------------------------------------------------------------


            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|독자번호;SubscribeCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수독자번호;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;87;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국 명;DeliveryBranchNm;54;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;50;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;106;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;74;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;0;;4;" & "o;n;y;10;우편번호;OldPostNm"
            gridAttributes = gridAttributes & "|주소;OldPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;139;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;225;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|확장일자;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|수금년월;CollectionYYYYMM;63;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|확장자;TrAdEmployeeNm;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|확장구분;ExpandDivCd;73;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|독자상태코드;ReaderStateCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;62;#,##0;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|배달구분코드;DeliveryDivCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|배달처코드;DeliveryRegionCd;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|본사독자구분;MHReaderDivCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|모니터처리코드;MonitoringResultCd;99;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|모니터내용;MonitoringRemark;83;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;0;;4;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10; "

            'grid_2 code combo    
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"
            gridCodeNameList = gridCodeNameList & "/MonitoringResultCd;모니터결과처리코드"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3
            '--------------------------------------------------------------

        End Sub
#End Region

        Private Sub grd_2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_2.DoubleClick

            '지국확장 독자 등록 화면으로 JUMP.
            If Me.grd_2.Rows <= Me.grd_2.FixedRows Then Exit Sub
            Dim strCode As String '접수독자번호
            strCode = Me.grd_2.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("화면 전환", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)
        End Sub

    End Class

End Namespace
