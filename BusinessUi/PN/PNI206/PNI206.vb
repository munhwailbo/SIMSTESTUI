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

    Public Class PNI206
        Inherits CommonControls.UiControl

        Private Sub PNI206_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;40;;r;" & "io;n;y;4;"                         '(10)
            gridAttributes = gridAttributes & "|계산서발행 일자;TaxAccPublishDt;80;;l;" & "io;n;n;8;"             '(20)

            gridAttributes = gridAttributes & "|매출처구분;SalesDiviCd;200;;l;" & "o;n;n;30;"       '(160)
            gridAttributes = gridAttributes & "|매출처코드;SalesCd;200;;l;" & "o;n;n;30;"       '(170)
            gridAttributes = gridAttributes & "|매출처명;SalesNm;200;;l;" & "o;n;y;30;"       '(170)

            gridAttributes = gridAttributes & "|상호(법인명);ConsumerCorpNm;200;;l;" & "o;n;n;30;"       '(130)
            gridAttributes = gridAttributes & "|사업자번호;ConsumerBusinessNum;200;;l;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|주민번호;Jumin_reg_no;200;;l;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|대표자성명;ConsumerPresidentNm;200;;l;" & "o;n;n;30;"       '(140)
            gridAttributes = gridAttributes & "|공급가액;SupplyTotalAmt;150;#,##0;r;" & "o;n;n;15;"       '(200)
            gridAttributes = gridAttributes & "|세액;TaxTotAmt;150;#,##0;r;" & "o;n;y;15;"       '(210)

            gridAttributes = gridAttributes & "|사업장주소;ConsumerAddr;200;;l;" & "o;n;n;1000;"      '(150)

            gridAttributes = gridAttributes & "|책번호-권;BillGroupNum;40;;r;" & "o;n;y;4;"                      '(30)
            gridAttributes = gridAttributes & "|책번호-호;BillGroupSeriesNum;40;;r;" & "o;n;y;4;"                '(40)
            gridAttributes = gridAttributes & "|계산서일련번호;BillSeriesNum;40;;r;" & "o;n;y;4;"                '(50)

            gridAttributes = gridAttributes & "| ;jIrAL;40;;r;" & "o;n;n;4;"                      '(30)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SalesDiviCd;매출처구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3

            dtpTaxAccPublishDt.TextValue = DateTime.Now().ToString.Substring(0, 8) & "01"
            dtpTaxAccPublishDt2.TextValue = DateTime.Now().ToString

        End Sub

#End Region


        Private Sub cboSalesDivCd_R_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSalesDivCd_R.SelectedIndexChanged

            'popSalesCd_R.Enabled = True
            'If cboSalesDivCd_R.TextValue = "1" Then
            '    lblCodeDivisionHangulName.Text = "확장처코드"
            '    popSalesCd_R.Tag = "code(확장처 명);"
            '    popSalesCd_R.TextValue = ""
            '    popSalesCd_R.MaxLength = 12
            'ElseIf cboSalesDivCd_R.TextValue = "2" Then
            '    lblCodeDivisionHangulName.Text = "소속사코드"
            '    popSalesCd_R.Tag = "code(소속사 명);"
            '    popSalesCd_R.TextValue = ""
            '    popSalesCd_R.MaxLength = 4
            'ElseIf cboSalesDivCd_R.TextValue = "3" Then
            '    lblCodeDivisionHangulName.Text = "지국번호"
            '    popSalesCd_R.Tag = "code(지국번호);"
            '    popSalesCd_R.TextValue = ""
            '    popSalesCd_R.MaxLength = 9
            'Else
            '    lblCodeDivisionHangulName.Text = "기타매출처"
            '    popSalesCd_R.Enabled = False
            'End If

        End Sub
    End Class

End Namespace
