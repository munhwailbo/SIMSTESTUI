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

    Public Class PNI312
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNI312_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;96;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;1;;1;" & "o;n;n;9;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;0;;4;" & "o;n;y;5;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;66;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지대년월;CalYearMonths;61;yyyy-MM;4;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|입금계;ColAmt_Tot;78;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|지대입금;ColAmt_1;78;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|본사수금(판매);ColAmt_2;86;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|본사수금(광고);ColAmt_3;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|지국확장;ColAmt_4;62;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|목표지원;ColAmt_5;62;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|조직지원;ColAmt_6;62;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|기증지;ColAmt_7;50;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|이사;ColAmt_8;47;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|배달확인;ColAmt_9;62;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|;uZZALCA;200;;1;" & "o;n;n;1000;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "BankCd;은행코드"
            'gridCodeNameList = gridCodeNameList & "/DivCd;지원비구분코드"
            'gridCodeNameList = gridCodeNameList & "/BankCd;은행코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            ' '' ''Me.popChargeEmpNum_R.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
            ' '' ''Me.popChargeEmpNum_R.Enabled = GmainBusinessFunction.GetValue("로그인 ID") = "999999"

        End Sub
#End Region

        '' ''Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '' ''    SetTotalValue(e.row)
        '' ''End Sub

        '' ''Private Sub SetTotalValue(ByVal CurruntRow As Long)

        '' ''    Dim TotalValue As Long
        '' '' ''    Dim CurruntRow As Long

        '' ''    With grd_1
        '' ''        If .Rows > 1 Then
        '' '' ''            CurruntRow = .GetCurrentRowCellValue("")

        '' ''            '이체 금액 처리 (확장비 - 대체금액 = 이체금액)
        '' ''            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupAmt")).ToString.Replace(",", "")) _
        '' ''                             - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
        '' ''            .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
        '' ''        End If
        '' ''    End With

        '' ''End Sub

    End Class

End Namespace
