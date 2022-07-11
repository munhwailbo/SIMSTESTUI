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

    Public Class PNE421
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '' ===============================================================================================
            '' ====  본사수금구독료 사원확장 정보
            '' ===============================================================================================
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;116;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;1;;4;" & "o;n;n;40;확장처 명;CompanyNm"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;126;;1;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|확장일자;ExpandDt;79;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|수금형태;CollectionDivCd;1;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|청구유형;BillType;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구방법;BillDivCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기;BillPeriodCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독기간;FixedDt;117;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|구독시작일자;FixedStDt;1;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;1;;4;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;50;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;74;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;62;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|승인일자;ApprovalDt;62;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|비고;Note;100;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|이전사원확장번호;OldEmployeeExpNum;1;;4;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            gridCodeNameList = gridCodeNameList & "/BillType;청구유형명"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            '--------------------------------------------------
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3

            '' ===============================================================================================
            '' ====  본사수금구독료 청구 이력 
            '' ===============================================================================================
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;1;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;1;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;1;;4;" & "o;n;y;40;확장처 명;CompanyNm"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;1;;1;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|적용일자;ProcDt;79;;4;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|유료구독시작년월;CollectionYYYYMM;108;;4;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|공제단가;SubscriptionAmt;77;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;70;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|총청구금액;TotDemandAmt;90;#,###;7;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|수금형태;CollectionDivCd;1;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|청구방법;BillDivCd;1;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기;BillPeriodCd;1;;1;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|적요;Remark;120;;c;" & "io;n;n;40;"

            gridAttributes = gridAttributes & "|;Dummy;10;;c;" & "o;n;n;40;"

            'grid code combo
            gridCodeNameList = ""
            Dim gridCriteriaPopupCodeList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_2.Initialize(gridAttributes, gridCodeNameList, gridCriteriaPopupCodeList)
            Me.grd_2.ExplorerBar = 3

            '' ===============================================================================================
            '' ====  본사수금구독료 상세(월별) 청구 계획 
            '' ===============================================================================================
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;80;#,###;c;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;60;#,###;r;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|청구년월;DmdYYMM;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|청구구분;DmdDivCd;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|청구부수;DmdPapNum;70;#,###;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|청구금액;DmdAmount;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|청구상태;DmdStateCd;80;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "DmdDivCd;본사수금청구구분코드"
            gridCodeNameList = gridCodeNameList & "/DmdStateCd;본사수금청구상태코드"
            gridCriteriaPopupCodeList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList, gridCriteriaPopupCodeList)
            Me.grd_3.ExplorerBar = 3

        End Sub

        Private Sub PNE421_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        ''' <summary>
        ''' 함수명 : PNE421_Enter 
        ''' 기  능 : 화면 전환(사원확장 청구계획 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNE421_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
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
            Me.popEmployeeExpNum_R.TextValue = strEmployeeExpNum  '확장접수번호

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            ''Dim CurruntRow As Long

            ''With grd_2
            ''    If .Rows > 1 Then
            ''        ''CurruntRow = .GetCurrentRowCellValue("")
            ''        '확정부수 처리
            ''        TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedPaperNum")).ToString.Replace(",", "")) _
            ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("ReFixedPaperNum")).ToString.Replace(",", ""))
            ''        .set_TextMatrix(CurruntRow, .get_ColIndex("TargetPaperTotNum"), TotalValue.ToString)
            ''    End If
            ''End With
        End Sub

        Private Sub grd_2_AfterEdit1(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_3.AfterEdit
            SetTotalValue(e.Row)
        End Sub

        Private Sub btnInsRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsRow.Click
            grd_3.AddRow()
            grd_3.set_TextMatrix(grd_3.Rows - 1, grd_3.get_ColIndex("EmployeeExpNum"), Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))
        End Sub

        Private Sub picBar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBar.MouseHover
            Me.picBar.BackColor = Color.DarkGray
        End Sub

        Private Sub picBar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBar.MouseLeave
            Me.picBar.BackColor = Color.WhiteSmoke
        End Sub

        Private Sub picBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseDown
            picBar2.Visible = True
        End Sub

        Private Sub picBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseUp
            Dim pBar As Point = New Point(picBar2.Location.X, picBar2.Location.Y)
            Dim pGrd3 As Point = New Point(picBar2.Location.X + grd_3.Location.X - picBar.Location.X, grd_3.Location.Y)

            picBar2.Visible = False
            If pBar.X >= 20 And pBar.X + 20 <= Me.Width Then
                picBar.Location = pBar
                ' ''grd_2.Width = 5
                grd_3.Location = pGrd3

                Dim sGrd2 As Size = New Size(picBar.Location.X - grd_2.Location.X, grd_2.Height)
                grd_2.Size = sGrd2
                Dim sGrd3 As Size = New Size(Me.Width - grd_3.Location.X - 5, grd_3.Height)
                grd_3.Size = sGrd3
            End If
        End Sub

        Private Sub picBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseMove
            Dim p As Point = New Point(picBar.Location.X + e.X, picBar2.Location.Y)
            picBar2.Location = p
        End Sub

        Private Sub BtnNewLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLine.Click
            RequestData3()
        End Sub

    End Class

End Namespace
