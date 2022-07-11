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

    Public Class PNE453
        Inherits CommonControls.UiControl

        Private Sub PNE453_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;116;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;1;;4;" & "o;n;n;40;확장처 명;CompanyNm"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;126;;1;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|청구유형;BillType;1;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;1;;1;" & "o;n;n;y;"

            gridAttributes = gridAttributes & "|청구상태;DmdStateCd;80;;c;" & "o;n;n;5;"

            ''gridAttributes = gridAttributes & "|수금형태;CollectionDivCd;0;;1;" & "o;n;y;40;"
            ''gridAttributes = gridAttributes & "|청구방법;BillDivCd;88;;1;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|청구주기;BillPeriodCd;88;;1;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|구독기간;CalYearMonths;117;;4;" & "o;n;n;40;"
            ''gridAttributes = gridAttributes & "|유료구독시작년월;FixedStDt;108;;4;" & "o;n;n;40;"
            ''gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;77;#,###;7;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;75;#,###;7;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|청구대상총액;TotDmdAmount;1;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|1월금액;DmdAmount_01;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|2월금액;DmdAmount_02;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|3월금액;DmdAmount_03;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|4월금액;DmdAmount_04;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|5월금액;DmdAmount_05;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|6월금액;DmdAmount_06;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|7월금액;DmdAmount_07;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|8월금액;DmdAmount_08;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|9월금액;DmdAmount_09;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|10월금액;DmdAmount_10;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|11월금액;DmdAmount_11;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|12월금액;DmdAmount_12;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "DmdStateCd;본사수금청구상태코드"
            gridCodeNameList = gridCodeNameList & "/BillType;청구유형명"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            ''gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            ''gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
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