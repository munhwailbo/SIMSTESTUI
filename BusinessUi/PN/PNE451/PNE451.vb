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

    Public Class PNE451
        Inherits CommonControls.UiControl

        Private Sub PNE451_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;1;;4;" & "o;n;n;40;확장처 명;CompanyNm"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;126;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;116;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|접수일자;ExpandDt;79;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|수금형태;CollectionDivCd;0;;1;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|청구유형;BillType;1;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구방법;BillDivCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기;BillPeriodCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독기간;CalYearMonths;117;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|유료구독시작년월;FixedStDt;108;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;77;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;75;#,###;7;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|청 구;Amount_A;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|청 구;Amount_B;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|청 구;Amount_C;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|청 구;Amount_D;0;#,##0;4;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|수 금;Amount_E;90;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|수 금;Amount_F;90;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|배 분;Amount_G;90;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|배 분;Amount_H;90;#,##0;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|(I)배분2차;Amount_I;90;#,##0;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|(J)미배분2차;Amount_J;90;#,##0;7;" & "o;n;n;10;"
            '' '' '' ''gridAttributes = gridAttributes & "|전월 구독료 누계;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            '' '' '' ''gridAttributes = gridAttributes & "|본사수금구독료;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            '' '' '' ''gridAttributes = gridAttributes & "|공제액;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            '' '' '' ''gridAttributes = gridAttributes & "|이체액;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            '' '' '' ''gridAttributes = gridAttributes & "|미처리 구독료;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            gridCodeNameList = gridCodeNameList & "/BillType;청구유형명"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '----그리드 행병합--------------------------------- 
            Dim i As Integer = 0
            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "선택"
            strColName2 = strColName2 & ControlChars.Tab & "확장처코드"
            strColName2 = strColName2 & ControlChars.Tab & "확장처명"
            strColName2 = strColName2 & ControlChars.Tab & "사원확장번호"
            strColName2 = strColName2 & ControlChars.Tab & "확장명"

            strColName2 = strColName2 & ControlChars.Tab & "접수일자"
            strColName2 = strColName2 & ControlChars.Tab & "수금형태"
            strColName2 = strColName2 & ControlChars.Tab & "청구유형"
            strColName2 = strColName2 & ControlChars.Tab & "청구방법"
            strColName2 = strColName2 & ControlChars.Tab & "청구주기"
            strColName2 = strColName2 & ControlChars.Tab & "구독기간"
            strColName2 = strColName2 & ControlChars.Tab & "유료구독시작년월"
            strColName2 = strColName2 & ControlChars.Tab & "구독료단가"
            strColName2 = strColName2 & ControlChars.Tab & "확정부수"

            strColName2 = strColName2 & ControlChars.Tab & "(A)청구대상총액"
            strColName2 = strColName2 & ControlChars.Tab & "(B)총청구액"
            strColName2 = strColName2 & ControlChars.Tab & "(C)미청구총액"
            strColName2 = strColName2 & ControlChars.Tab & "(D)미청구액"
            strColName2 = strColName2 & ControlChars.Tab & "(E)수금총액"
            strColName2 = strColName2 & ControlChars.Tab & "(F)미수금액"
            strColName2 = strColName2 & ControlChars.Tab & "(G)배분"
            strColName2 = strColName2 & ControlChars.Tab & "(H)미배분"
            '''' --- 
            strColName2 = strColName2 & ControlChars.Tab & ""

            With Me.grd_1
                .AddItem(strColName2)
                .FixedRows = 2
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly
                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next
                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next
            End With
            '-------------------------------------------------- 


            Me.grd_1.ExplorerBar = 3

        End Sub

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '사원확장 청구계획 상세 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '사원확장번호
            strCode = Me.dtpBaseYear.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum")
            GmainBusinessFunction.SetValue("화면 전환", "PNE452;" & strCode)
            Me.ShowUiControl("PNE452", strCode)

        End Sub

    End Class

End Namespace