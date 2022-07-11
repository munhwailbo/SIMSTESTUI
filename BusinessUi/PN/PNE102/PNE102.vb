'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 관리비항목수정삭제
' form 설명 : 관리비 항목을 등록 수정 합니다.
' 작성자 : 임종성
' 작성일 : 2006-03-07
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

    Public Class PNE102
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|접수일자;ExpandDt;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|순번;Orders;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;70;;c;" & "o;n;n;40;확장처 명;CompanyNm;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;70;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|접수;TargetPaperTotNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|신규;NewExpPapNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|재확장;ReExpPapNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|명단없는부수;NoListPapNum;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|확정;FixedPaperNum;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|투입;SubscribePagerNum;60;#,###;r;" & "o;n;y;5;"   '임시 변경 02.18
            gridAttributes = gridAttributes & "|미투입;NoSubscribePagerNum;60;#,###;r;" & "o;n;y;5;" '임시 변경 02.18

            gridAttributes = gridAttributes & "|명단상태코드;ListStatCd;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기코드;BillPeriodCd;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독시작일자;FixedStDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|지국전달사항;BranchNote;70;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|승인일자;ApprovalDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|비고;Note;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ListStatCd;명단상태코드"    '' 2401
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;수금형태코드"   ''2323
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            '--------------------------------------------------
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3

            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;80;#,###;c;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;60;#,###;r;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|권유자구분코드;SolicitorDivCd;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|권유자코드;SolicitorEmpNum;80;;c;" & "io;n;n;5;사원 명;EmployeeNameHangul,SoliDeptCd,SoliDeptNm"
            gridAttributes = gridAttributes & "|사원명;EmployeeNameHangul;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|권유부서코드;SoliDeptCd;80;;c;" & "io;n;n;40;부서 명;SoliDeptNm;"
            gridAttributes = gridAttributes & "|권유부서명;SoliDeptNm;80;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|신규확장;FixedPaperNum;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|재확장;ReFixedPaperNum;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|사원확장;TargetPaperTotNum;70;#,###;r;" & "io;n;n;5;"
            'gridAttributes = gridAttributes & "|중지부수;StopPaperNum;70;#,###;r;" & "io;n;n;40;"
            'gridAttributes = gridAttributes & "|개인실적여부;IndividualYN;80;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|권유자정보;RealSolicitorInfo;70;;c;" & "io;n;y;40;"
            gridAttributes = gridAttributes & "|비 고;PayRemark;100;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "SolicitorDivCd;권유자구분코드"
            Dim gridCriteriaPopupCodeList As String = ""
            gridCriteriaPopupCodeList = gridCriteriaPopupCodeList & "EmployeeNameHangul;권유부서코드,권유부서명"
            grd_2.Initialize(gridAttributes, gridCodeNameList, gridCriteriaPopupCodeList)
            Me.grd_2.ExplorerBar = 3

        End Sub

        Private Sub PNE102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
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
        Private Sub PNE102_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5))
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
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strEmployeeExpNum As String)
            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.dtpFromExpand.TextValue = strFromDt  '시작일자
            Me.dtpToExpand.TextValue = strToDt      '종료일자
            Me.popCompanyCd.TextValue = strCompanyCd  '확장처번호
            Me.popCompanyCd.NameText = strCompanyNm  '확장처명
            ''Me.popCompanyCd.TextValue = strEmployeeExpNum  '확장접수번호

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            ''Dim CurruntRow As Long

            With grd_2
                If .Rows > 1 Then
                    ''CurruntRow = .GetCurrentRowCellValue("")
                    '확정부수 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("ReFixedPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("TargetPaperTotNum"), TotalValue.ToString)
                End If
            End With
        End Sub

        Private Sub grd_2_AfterEdit1(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_2.AfterEdit
            SetTotalValue(e.Row)
        End Sub

    End Class

End Namespace
