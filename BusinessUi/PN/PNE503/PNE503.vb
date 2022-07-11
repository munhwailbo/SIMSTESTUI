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

    Public Class PNE503
        Inherits CommonControls.UiControl

        Private Sub PNE503_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub


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
            Grid_Initialize()
        End Sub
        Private Sub Grid_Initialize()


            '  판매보급비(배달비) 지급현황
            'If optExpAmt1.Checked Then
            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|접수번호;EmployeeExpNum;1;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|배달비지급년월;YYYYMM;100;;l;" & "o;n;n;;"

            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;87;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|청구방법;BillDivCdNm;1;;1;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|지국번호;BranchNum;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|영업담당사번;ChargeEmpNum;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|영업담당;ChargeEmpNm;80;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|독자번호;SubscribeCd;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;200;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|주소;Addr1;180;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|상세주소;Addr2;180;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|배달비지급부수;GsPaperNum;80;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|접수계;PaperNum;60;#,##0;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|신규;NewExpPapNum;60;#,##0;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|재확장;ReExpPapNum;60;#,##0;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|금액;Amt;100;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지대대체;DeductAmt;100;#,##0;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|이체금액;TransferAmt;100;#,##0;r;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|배달단가;SubscriptionAmt;100;#,##0;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|투입기간;FixedStEdDt;120;;l;" & "o;n;y;;"
            gridAttributes = gridAttributes & "|배달비지급개시월;CollectionYYYYMM;80;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|배달비지급월;MM;80;;l;" & "o;n;y;;"

            gridAttributes = gridAttributes & "|배분기준년월;DisYearMonths;80;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|접수자(*);TrAdEmployeeNum;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수자명(*);TrAdEmployeeNm;62;;4;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|접수자;AdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수자명;AdEmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|접수자부서;AdEmployeeDeptCd;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|접수자부서명;AdEmployeeDeptNm;75;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|접수처코드;CompanyCd;1;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|접수처명;CompanyNm;120;;l;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|접수일자;ContactDt;1;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;1;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|중지일자;MngStopDt;85;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|비고;Memo;80;;l;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|SO;SortOrders;1;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;80;;l;" & "o;n;y;5;"
            'gridAttributes = gridAttributes & "|배달비지급년도;YYYY;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|배달비지급월;MM;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|시작일자;FixedStDt;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|종료일자;FixedEdDt;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|서비스기간;ServiceMM;1;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|대체일자;TransferDt;80;;l;" & "o;n;y;;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;1000;"       '(80)

            'gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            ''gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3
            'End If

            '' 판매보급비(배달비) 공제현황
            'If optExpAmt2.Checked Then
            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            'grid_1 code combo    
            gridCodeNameList = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|접수번호;EmployeeExpNum;1;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|배달비지급년월;YYYYMM;100;;l;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|투입기간;FixedStEdDt;120;;l;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|배달비지급개시년월;CollectionYYYYMM;80;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|배달단가;SubscriptionAmt;100;#,##0;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|배달비지급월;MM;80;;l;" & "o;n;y;;"

            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;87;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|청구방법;BillDivCdNm;1;;1;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|배달비지급부수;GsPaperNum;80;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|접수처코드;CompanyCd;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|접수처명;CompanyNm;120;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|접수자(*);TrAdEmployeeNum;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수자명(*);TrAdEmployeeNm;62;;4;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|접수자;AdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수자명;AdEmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|접수자부서;AdEmployeeDeptCd;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|접수자부서명;AdEmployeeDeptNm;75;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|영업담당사번;ChargeEmpNum;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|영업담당;ChargeEmpNm;80;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|배분기준년월;DisYearMonths;80;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|접수계;PaperNum;60;#,##0;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|신규;NewExpPapNum;60;#,##0;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|재확장;ReExpPapNum;60;#,##0;c;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|금액;Amt;100;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지대대체;DeductAmt;100;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|이체금액;TransferAmt;100;#,##0;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|독자번호;SubscribeCd;1;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;200;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|주소;Addr1;180;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|상세주소;Addr2;180;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|접수일자;ContactDt;1;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;1;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|중지일자;MngStopDt;85;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|비고;Memo;80;;l;" & "o;n;n;5;"

            'gridAttributes = gridAttributes & "|SO;SortOrders;1;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;80;;l;" & "o;n;y;5;"
            'gridAttributes = gridAttributes & "|배달비지급년도;YYYY;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|배달비지급월;MM;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|시작일자;FixedStDt;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|종료일자;FixedEdDt;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|서비스기간;ServiceMM;1;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|대체일자;TransferDt;80;;l;" & "o;n;y;;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;1000;"       '(80)

            'gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            ''gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_2.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_2.ExplorerBar = 3
            'End If

        End Sub

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '' ''사원확장 독자 등록 화면으로 JUMP.
            ' ''If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            ' ''Dim strCode As String '접수독자번호
            ' ''Dim sdate As String
            ' ''sdate = dtpBaseYear.TextValue.Substring(0, 4) + "-" + "01"
            ' ''strCode = Me.dtpBaseYear.TextValue _
            ' ''          & ";" & Me.grd_1.GetCurrentRowCellValue("BranchNum") _
            ' ''          & ";" & sdate
            ' ''GmainBusinessFunction.SetValue("화면 전환", "PNI403;" & strCode)
            ' ''Me.ShowUiControl("PNI403", strCode)

        End Sub


        Private Sub optExpAmt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optExpAmt1.CheckedChanged, optExpAmt2.CheckedChanged

            grd_1.Visible = optExpAmt1.Checked
            grd_2.Visible = optExpAmt2.Checked

            chkRemark.Visible = optExpAmt1.Checked
        End Sub

    End Class

End Namespace