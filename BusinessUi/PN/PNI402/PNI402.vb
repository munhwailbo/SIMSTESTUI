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

    Public Class PNI402
        Inherits CommonControls.UiControl

        Private Sub PNI402_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|구분;TreePath;102;;1;" & "io;n;n;5;"
            
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;50;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지국코드;BranchNum;1;;4;" & "o;n;n;10;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;56;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;0;;4;" & "o;n;y;10;지국지역코드;;"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|지국장명;BranchChiefNm;50;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|운영구분;OldOrNew;57;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|운영시작일자;ContractDt;70;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|폐국일자;CloseDate;70;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지대년월;YearMonths;63;yyyy-MM;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|전월미수액;LastUnColAmt;84;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|당월매출액;ThisSaleAmt;78;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|당월청구계;ThisDemandAmt;78;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|대체수금액;ThisDeduAmt;69;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|입금수금액;ThisTransAmt;74;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|당월수금계;ThisInComAmt;78;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|수금율;ColRate;50;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|당월미수액;ThisUnColAmt;78;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|전체미수액;TotUnColAmt;78;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|예수보증금;DepositAmt1;85;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|완납적립금;DepositAmt2;85;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|보증금계;DepositAmtT;85;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|발송부수;DeliveryPaperNum;62;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|본사유가;ValPaperNum;62;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;200;;1;" & "o;n;n;1000;"
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
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '담당자 셋팅
            popChargeEmpNum.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popChargeEmpNum.Enabled = False
                popChargeEmpNum.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                GmainBusinessFunction.GetValue("로그인 ID"), _
                                                GmainBusinessFunction.GetValue("역할대행사번"))
            End If

        End Sub

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '사원확장 독자 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '접수독자번호
            Dim sdate As String
            sdate = dtpBaseYear.TextValue.Substring(0, 4) + "-" + "01"
            strCode = Me.dtpBaseYear.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("BranchNum") _
                      & ";" & sdate
            GmainBusinessFunction.SetValue("화면 전환", "PNI403;" & strCode)
            Me.ShowUiControl("PNI403", strCode)

        End Sub

    End Class

End Namespace