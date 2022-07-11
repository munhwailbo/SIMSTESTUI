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

    Public Class PNE452
        Inherits CommonControls.UiControl

        Private Sub PNE452_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            gridAttributes = gridAttributes & "|접수일자;ExpandDt;79;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|수금형태;CollectionDivCd;0;;1;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|청구방법;BillDivCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기;BillPeriodCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독기간;DmdDt;117;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|유료구독시작년월;FixedStDt;108;;c;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;77;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;75;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구대상총액;Amount_A;90;#,##0;r;" & "o;n;n;15;"

            gridAttributes = gridAttributes & "|청구상태;DmdStateCd;80;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구년월;CalYearMonths;60;;c;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|청구대상액;PlanDemandAmt;90;#,##0;r;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|청구액;Amount_B;90;#,##0;r;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|수금액;Amount_E;90;#,##0;r;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|배분금액;Amount_G;90;#,##0;r;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|배분부수;Amount_H;1;#,##0;r;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|미배분금액;Amount_I;90;#,##0;r;" & "o;n;n;10;"

            ' '' ''gridAttributes = gridAttributes & "|전월 구독료 누계;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|본사수금구독료;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|공제액;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|이체액;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|미처리 구독료;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            gridCodeNameList = gridCodeNameList & "/DmdStateCd;본사수금청구상태코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3

        End Sub


        ''' <summary>
        ''' 함수명 : PNE421_Enter 
        ''' 기  능 : 화면 전환(사원확장 청구계획 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 5
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNE452_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
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
        Public Sub SetRequest(ByVal strBaseDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strEmployeeExpNum As String)
            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.dtpBaseYear.TextValue = strBaseDt  '기준일자
            Me.popCompanyCd.TextValue = strCompanyCd  '확장처번호
            Me.popCompanyCd.NameText = strCompanyNm  '확장처명
            Me.popEmployeeExpNum_R.TextValue = strEmployeeExpNum  '확장접수번호

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
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