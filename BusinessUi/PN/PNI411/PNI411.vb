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

    Public Class PNI411
        Inherits CommonControls.UiControl

        Private Sub PNI411_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;70;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;70;;c;" & "o;n;n;40;확장처 명;CompanyNm;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;70;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|청구기간;CalYearMonths;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기코드;BillPeriodCd;60;;c;" & "o;n;n;5;"

            '' ''eoeksgks dlgofur... 
            ''If GmainBusinessFunction.GetValue("로그인 ID") = "999999" Then gridAttributes = gridAttributes & "|청구회차;DemandOrders;1;#,##0;c;" & "o;n;n;15;" '(40)

            gridAttributes = gridAttributes & "|청구누계;TotDemandAmt;120;#,##0;r;" & "o;n;n;15;"       '(50)
            gridAttributes = gridAttributes & "|수금건수;Colcnt;120;#,##0;c;" & "o;n;y;15;"       '(60)
            gridAttributes = gridAttributes & "|수금누계;ColAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|미수잔액;RemainAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)

            gridAttributes = gridAttributes & "|전월 구독료 누계;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|본사수금구독료;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|공제액;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|이체액;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|미처리 구독료;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)
            '' ''gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;80;;c;" & "o;n;n;7;"       '(10)
            '' ''gridAttributes = gridAttributes & "|지국번호;BranchNum;80;;c;" & "o;n;n;9;"       '(20)
            '' ''gridAttributes = gridAttributes & "|운영자구분코드;OperatorDivCd;90;;c;" & "o;n;n;10;"       '(30)
            '' ''gridAttributes = gridAttributes & "|보증금;DepositAmt;120;;r;" & "o;n;n;15;"       '(40)
            '' ''gridAttributes = gridAttributes & "|완납적립금누계;FullPaymentAmt;120;;r;" & "o;n;n;15;"       '(50)
            '' ''gridAttributes = gridAttributes & "|미수금누계;UnColAmt;120;;r;" & "o;n;n;15;"       '(60)
            '' ''gridAttributes = gridAttributes & "|미수처리구분코드;ProcDivCd;100;;c;" & "o;n;n;10;"       '(70)
            '' ''gridAttributes = gridAttributes & "|비고;Note;200;;l;" & "o;n;n;1000;"       '(80)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

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

       
    End Class

End Namespace