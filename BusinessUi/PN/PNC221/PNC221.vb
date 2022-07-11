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

    Public Class PNC221
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNC221_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            ''gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;90;;l;" & "o;n;n;10;"
            ''gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;90;;l;" & "o;n;y;10;"
            ''gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;l;" & "o;n;n;9;"       '(30)
            ''gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;y;5;지국코드;BranchNm"
            ''gridAttributes = gridAttributes & "|지국명;BranchNm;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|구분;YYYYMM;60;;l;" & "o;n;n;6;"       '(10)

            gridAttributes = gridAttributes & "|발송부수(지국+가판);PNum110;80;#,##0;r;" & "o;n;n;15;"       '(11)
            gridAttributes = gridAttributes & "|본사유가부수;PNum120;80;#,##0;r;" & "o;n;n;15;"       '(12)

            gridAttributes = gridAttributes & "|지국유가부수계;PNum200;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|지국유가부수-지국부수;PNum210;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|지국유가부수-사원지국;PNum220;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|지국유가부수-구독권;PNum230;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|지국유가부수-본사신청;PNum240;80;#,##0;r;" & "o;n;n;15;"       '(21)

            gridAttributes = gridAttributes & "|확장부수-지국;PNum310;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|확장부수-사원확장-신규;PNum321;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|확장부수-사원확장-재확장;PNum322;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|확장부수-사원확장-계;PNum320;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|확장부수-구독권;PNum330;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|확장부수-가판;PNum340;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|확장부수-신청;PNum350;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|확장부수-기타(자체이동);PNum360;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|확장부수-계(A);PNum300;80;#,##0;r;" & "o;n;n;15;"       '(21)

            gridAttributes = gridAttributes & "|중지부수-지국;PNum410;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|중지부수-사원확장-중지;PNum421;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|중지부수-사원확장-대체중지;PNum422;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|중지부수-사원확장-재확장;PNum423;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|중지부수-사원확장-계;PNum420;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|중지부수-구독권;PNum430;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|중지부수-이전;PNum440;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|중지부수-가판;PNum450;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|중지부수-계(B);PNum400;80;#,##0;r;" & "o;n;n;15;"       '(21)

            gridAttributes = gridAttributes & "|증감(A-B);PNum500;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|비고;Remark;80;;l;" & "o;n;n;15;"       '(21)

            gridAttributes = gridAttributes & "| ;uZZALCA;200;;l;" & "o;n;n;1000;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ColTypeCd;입금구분코드"
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
        '' '' ''    ''Dim CurruntRow As Long

        '' '' ''    With grd_1
        '' '' ''        If .Rows > 1 Then
        '' '' ''            ''CurruntRow = .GetCurrentRowCellValue("")

        '' '' ''            '이체 금액 처리 (확장비 - 대체금액 = 이체금액)
        '' '' ''            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupAmt")).ToString.Replace(",", "")) _
        '' '' ''                             - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
        '' '' ''            .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
        '' '' ''        End If
        '' '' ''    End With

        '' '' ''End Sub

    End Class

End Namespace
