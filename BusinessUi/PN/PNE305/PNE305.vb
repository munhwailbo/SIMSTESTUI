'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 재연장관리
' form 설명 : 재연장 항목을 관리하는 프로그램
' 작성자 : 김동욱
' 작성일 : 2009-02-28
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
Imports System.ComponentModel
Imports System.Data.SqlClient

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE305
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;91;;1;" & "io;n;n;"
            gridAttributes = gridAttributes & "|확장일자;ExpandDt;93;yyyy-MM-dd;4;" & "o;n;n;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;90;;1;" & "o;n;n;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;90;;1;" & "o;n;n;"
            gridAttributes = gridAttributes & "|확장 명;ExpandNm;150;;1;" & "o;n;n;"
            gridAttributes = gridAttributes & "|기존부수;TargetPaperTotNum;60;;1;" & "o;n;n;"
            '재연장부수
            gridAttributes = gridAttributes & "|재연장부수;ReContPapNum;60;;1;" & "io;n;n;"
            '중지부수


            gridAttributes = gridAttributes & "|구독시작일자;FixedStDt;91;yyyy-MM-dd;4;" & "o;n;n;"
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;82;yyyy-MM-dd;4;" & "o;n;n;"
            '권유자
            gridAttributes = gridAttributes & "|권유자사번;SolicitorEmpNum;82;;4;" & "o;n;n;"
            '완료여부

            '비고
            gridAttributes = gridAttributes & "|비고;Note;82;;4;" & " o;n;n;"


            'gridAttributes = gridAttributes & "|순번;Orders;74;;1; " & " o;n;n;40"
            'gridAttributes = gridAttributes & "|신규확장;NewExpPapNum;58;;1; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|재확장;ReExpPapNum;55;;1; " & " o;n;n;4"
            'gridAttributes = gridAttributes & "|명단없는부수;NoListPapNum;61;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;56;;1; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|투입부수;SubscribePagerNum;51;;1; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|미투입부수;NoSubscribePapNum;50;;1; " & " o;n;n"
            'gridAttributes = gridAttributes & "|명단상태코드(2401);ListStatCd;70;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|수금형태코드(2323);CollectionDivCd;78;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|청구방법코드(2321);BillDivCd;99;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|청구주기코드(2111);BillPeriodCd;92;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;78;;1; " & " o;n;n"
            'gridAttributes = gridAttributes & "|지국전달사항;BranchNote;84;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|승인여부;ApprovalYN;77;;1; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|비고;Note;117;;1; " & " o;n;n;40"
            'gridAttributes = gridAttributes & "|승인일자;ApprovalDt;79;yyyy-MM-dd;4; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|이전사원확장번호;OldEmployeeExpNum;92;;1; " & " o;"
            'gridAttributes = gridAttributes & "|생성자;CreateEmployee;93;;1; " & " o;n;n;4"
            'gridAttributes = gridAttributes & "|생성 일시;CreateDateTime;81;yyyy-MM-dd:HH:mm:ss;4; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|수정자;UpdateEmployee;149;;1; " & " o;n;n;4"
            'gridAttributes = gridAttributes & "|수정 일시;UpdateDateTime;149;yyyy-MM-dd:HH:mm:ss;4; " & " o;n;n;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ListStatCd;명단상태코드"    '' 2401
            'gridCodeNameList = gridCodeNameList & "/CollectionDivCd;수금형태코드"   ''2323
            'gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            'gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNE305_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

       

        ''' <summary>
        ''' 콤보 값 셋팅
        ''' </summary>
        ''' <param name="_grd">셋팅할 그리드</param>
        ''' <param name="row">셋팅할 행번호</param>
        ''' <param name="colName">세팅할 컬럼명</param>
        ''' <param name="key">콤보 값</param>
        ''' <remarks>콤보 값을 명과 함께 그리드에 표시한다.</remarks>
        Private Sub ComboValueSetting(ByVal _grd As ubiLease.GridControl.grd, ByVal row As Integer, ByVal colName As String, ByVal key As String)
            Dim strs() As String = _grd.get_ColComboList(_grd.get_ColIndex(colName)).Split("|")
            For Each str As String In strs
                If str.Split(".")(0) = key Then
                    _grd.SetData(row, colName, str)
                    Exit For
                End If
            Next
        End Sub
    End Class

End Namespace
