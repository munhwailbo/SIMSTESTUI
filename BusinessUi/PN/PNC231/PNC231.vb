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

    Public Class PNC231
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNC231_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;90;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;90;;l;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;l;" & "o;n;n;9;"       '(30)
            gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;y;5;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|발송부수;BalPapNum;60;#,##0;c;" & "o;n;n;6;"       '(10)
            gridAttributes = gridAttributes & "|본사유가부수;BonPapNum;60;#,##0;c;" & "o;n;n;6;"       '(10)

            gridAttributes = gridAttributes & "|계;TotExpNum;80;#,##0;c;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|지국확장;JiExpNum;80;#,##0;c;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|사원확장;SaExpNum;80;#,##0;c;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|본사신청;BonExpNum;80;#,##0;c;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|구독권;GuExpNum;80;#,##0;c;" & "o;n;n;15;"       '(80)

            gridAttributes = gridAttributes & "| ;uZZALCA;200;;l;" & "o;n;n;1000;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ' '' ''gridCodeNameList = gridCodeNameList & "ColTypeCd;입금구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            'Me.popChargeEmpNum_R.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
            'Me.popChargeEmpNum_R.Enabled = GmainBusinessFunction.GetValue("로그인 ID") = "999999"

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
