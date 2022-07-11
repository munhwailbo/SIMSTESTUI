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

    Public Class PNI403
        Inherits CommonControls.UiControl

        Private Sub PNI403_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            'gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;90;;c;" & "o;n;y;10;지국지역코드;;"
            'gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;60;;c;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;90;;c;" & "o;n;y;10;;"
            'gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;60;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "||선택;선택;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|지국코드;BranchNum;1;;4;" & "o;n;n;10;지국코드;BranchNm "
            gridAttributes = gridAttributes & "|지국명;BranchNm;50;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지대년월;CalYearMonths;63;yyyy-MM;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|처리일자;ProcDt;85;yyyy-MM-dd;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|입금구분;ColTypeCd;144;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|전월미수액;LastUnColAmt;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|매출액;ThisSalesAmt;70;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|수금액;ThisColAmt;70;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|미수액;ThisUnColAmt;70;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|계좌수금액;ColAmt1;74;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|대체수금액;ColAmt2;74;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|부수;PaperNum;45;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|적요;Note;150;;l;" & "o;n;n;150;"
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
            gridCodeNameList = gridCodeNameList & "ColTypeCd;입금구분코드"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            dtpFromYearMonths.TextValue = "19910101"

            '담당자 셋팅
            popChargeEmpNum_r.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popChargeEmpNum_r.Enabled = False
                popChargeEmpNum_r.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("로그인 ID"), _
                                                  GmainBusinessFunction.GetValue("역할대행사번"))
            End If


        End Sub
        ''' <summary>
        ''' 함수명 : PNE102_Enter 
        ''' 기  능 : 화면 전환(사원확장 권유자 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNI403_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3))
                GmainBusinessFunction.SetValue("화면 전환", vbNullString)
            End If
        End Sub
        ' <summary
        ' 함수명 : Request
        ' 기  능 : 다른 화면에서 코드 를 받아서 해당 내역을 조회 한다.
        ' 작성자 : 강동훈
        ''작성일 : 2008-12-12
        ''수정자 : 
        ''수정일 : 
        '' </summary>
        Public Sub SetRequest(ByVal strBaseYear As String, ByVal strBranchNum As String, ByVal strFrYear As String)
            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.dtpFromYearMonths.TextValue = strFrYear '시작일자
            Me.dtpToYearMonths.TextValue = strBaseYear  '종료일자
            Me.popBranchNum.TextValue = strBranchNum '지국번호

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

    End Class

End Namespace
