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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE402
        Inherits CommonControls.UiControl

        Private Sub PNE402_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"

            gridAttributes = gridAttributes & "|청구년월;CalYearMonths;80;;l;" & "io;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|연번;Orders;40;;c;" & "io;n;y;4;"       '(30)
            gridAttributes = gridAttributes & "|배분년월;DisYearMonths;80;;l;" & "o;n;n;8;"       '(20)

            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;90;;c;" & "o;n;y;10;지국지역코드;;"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;60;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;90;;c;" & "o;n;y;10;;"
            gridAttributes = gridAttributes & "|담당명;EmployeeNameHangul;60;;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;70;;c;" & "o;n;y;40;확장처 명;CompanyNm;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|청구방법;BillDivCd;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|지국코드;BranchNum;120;;l;" & "o;n;n;12;지국 명;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;12;"       '(10)

            gridAttributes = gridAttributes & "|부수;PaperNum;80;#,##0;c;" & "o;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|단가;SubsUnitAmt;80;#,##0;c;" & "o;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|본사수금구독료;SubscriptionAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|대체금액;DeductAmt;80;#,##0;r;" & "io;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|이체금액;TransferAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)

            gridAttributes = gridAttributes & "|은행코드;BankCd;80;;l;" & "o;n;n;8;"            '(110)
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;80;;l;" & "o;n;n;8;"        '(110)
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;80;;l;" & "o;n;n;8;"       '(110)

            gridAttributes = gridAttributes & "|담당확인여부;RegYesOrNo;80;;l;" & "io;n;n;8;"       '(110)
            gridAttributes = gridAttributes & "|관리승인여부;ApplyYesOrNo;80;;l;" & "o;n;y;8;"       '(110)
            gridAttributes = gridAttributes & "|처리일자;ProcDt;80;;l;" & "o;n;y;8;"       '(110)
            gridAttributes = gridAttributes & "|비고;Note;80;;l;" & "o;n;y;8;"       '(110)

            gridAttributes = gridAttributes & "| ;JiRal;80;;l;" & "o;n;y;8;"       '(110)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BankCd;은행코드"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

            'Me.popEmployeeNumber.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
            'Me.popEmployeeNumber.Enabled = GmainBusinessFunction.GetValue("로그인 ID") = "999999"

            '담당자 셋팅
            popEmployeeNumber.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popEmployeeNumber.Enabled = False
                popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("로그인 ID"), _
                                                  GmainBusinessFunction.GetValue("역할대행사번"))
            End If

            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|납부년월;MutualYearMonth;1253;####-##;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|담당명;EmployeeNameHangul;60;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|납부지국명;MutualBranchCodeName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|지국장 명;BranchChiefCdName;1253;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|상조회비;MutualSocietyDues;1253;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|납부여부;MutualYesOrNo;1253;#,##0;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|납부금액;MutualAmount;1253;#,##0;r;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|겸업지국;SideJobBranchName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|적요;Note;1358;;l;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|가입일자;JoinDate;80;####-##-##;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;Dumi;50;;l;" & "o;n;n"

            'grid code combo
            gridCodeNameList = ""
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3
            '--------------------------------------------------

        End Sub
#End Region


        Private Sub SetTotalValue()

            Dim TotalValue As Long
            Dim CurruntRow As Long

            With grd_1
                If .Rows > 1 Then
                    CurruntRow = .GetCurrentRowCellValue("")
                    CurruntRow += .FixedRows

                    '이체 금액 처리 (확장비 - 대체금액 = 이체금액)
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SubscriptionAmt")).ToString.Replace(",", "")) _
                                     - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)

                    Call SetSubTotal()
                End If
            End With

        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue()
        End Sub

        Private Sub btnInsertDeductAmt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertDeductAmt.Click
            Dim iRow As Integer
            For iRow = 1 To grd_1.Rows - 1
                If grd_1.GetCellCheck(iRow, grd_1.get_ColIndex("선택")) = CheckEnum.Checked Then
                    grd_1.set_TextMatrix(iRow, grd_1.get_ColIndex("DeductAmt"), grd_1.get_TextMatrix(iRow, grd_1.get_ColIndex("TransferAmt")))
                End If
            Next
        End Sub
    End Class

End Namespace
