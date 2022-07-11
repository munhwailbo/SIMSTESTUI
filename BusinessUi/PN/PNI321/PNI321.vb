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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic


Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI321
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNI321_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|담당;ChargeEmpNm;120;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당;ChargeEmpNum;90;;l;" & "o;n;y;10;"

            gridAttributes = gridAttributes & "|지 국;BranchNum;80;;l;" & "o;n;n;9;"       '(30)
            gridAttributes = gridAttributes & "|지 국;BranchCd;60;;c;" & "o;n;y;5;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지 국;BranchNm;115;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지대년월;CalYearMonths;60;;l;" & "o;n;n;6;"       '(10)

            gridAttributes = gridAttributes & "|입금계;ColAmt_Tot;120;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|지대입금;ColAmt_1;100;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|본사수금;ColAmt_2;100;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|본사수금;ColAmt_21;1;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|본사수금;ColAmt_22;1;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|본사수금;ColAmt_3;100;#,##0;r;" & "o;n;n;15;"       '(80)

            gridAttributes = gridAttributes & "|대 체;ColAmt_4;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|대 체;ColAmt_5;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|대 체;ColAmt_6;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|대 체;ColAmt_7;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|대 체;ColAmt_8;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|대 체;ColAmt_9;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "| ;uZZALCA;200;;l;" & "o;n;n;1000;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "BankCd;은행코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            'Me.popChargeEmpNum_R.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
            'Me.popChargeEmpNum_R.Enabled = GmainBusinessFunction.GetValue("로그인 ID") = "999999"
            '----그리드 행병합--------------------------------- 
            Dim i As Integer = 0
            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "선택"
            strColName2 = strColName2 & ControlChars.Tab & "담당"
            strColName2 = strColName2 & ControlChars.Tab & "사번"

            strColName2 = strColName2 & ControlChars.Tab & "지국번호"
            strColName2 = strColName2 & ControlChars.Tab & "지국코드"
            strColName2 = strColName2 & ControlChars.Tab & "지국명"
            strColName2 = strColName2 & ControlChars.Tab & "지대년월"

            strColName2 = strColName2 & ControlChars.Tab & "입금계"
            strColName2 = strColName2 & ControlChars.Tab & "지대입금"
            strColName2 = strColName2 & ControlChars.Tab & "판매"
            strColName2 = strColName2 & ControlChars.Tab & "판매(계산서)"
            strColName2 = strColName2 & ControlChars.Tab & "판매(계+지)"
            strColName2 = strColName2 & ControlChars.Tab & "광고"

            strColName2 = strColName2 & ControlChars.Tab & "지국확장"
            strColName2 = strColName2 & ControlChars.Tab & "목표지원"
            strColName2 = strColName2 & ControlChars.Tab & "조직지원"
            strColName2 = strColName2 & ControlChars.Tab & "기증지"
            strColName2 = strColName2 & ControlChars.Tab & "이사"
            strColName2 = strColName2 & ControlChars.Tab & "배달확인"
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
           
            '담당자 셋팅
            popChargeEmpNum_R.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popChargeEmpNum_R.Enabled = False
                popChargeEmpNum_R.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("로그인 ID"), _
                                                  GmainBusinessFunction.GetValue("역할대행사번"))
            End If

        End Sub
#End Region

        '' '' ''Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '' '' ''    SetTotalValue(e.row)
        '' '' ''End Sub

        '' '' ''Private Sub SetTotalValue(ByVal CurruntRow As Long)

        '' '' ''    Dim TotalValue As Long
        '' '' '' ''    Dim CurruntRow As Long

        '' '' ''    With grd_1
        '' '' ''        If .Rows > 1 Then
        '' '' '' ''            CurruntRow = .GetCurrentRowCellValue("")

        '' '' ''            '이체 금액 처리 (확장비 - 대체금액 = 이체금액)
        '' '' ''            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupAmt")).ToString.Replace(",", "")) _
        '' '' ''                             - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
        '' '' ''            .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
        '' '' ''        End If
        '' '' ''    End With

        '' '' ''End Sub

    End Class

End Namespace
