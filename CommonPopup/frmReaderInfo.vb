Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Configuration

Namespace ubiLease.CommonPopup
    Public Class frmReaderInfo

        '=================
        ' 0.지역변수 선언
        '=================

        '=================
        ' 0.초기화
        '=================
        ''' <summary>
        ''' 화면 초기화
        ''' </summary>
        Public Sub Initialize()

            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            '--------------------------------------------------
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|확장구분코드;ExpandDivCd;100;;l;" & "o;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;13;;;" & "io;n;y;13;"       '(10)
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;30;;;" & "io;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|종료일자;EdDt;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|사용여부;UseYN;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|비고;Note;70;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"
            '--------------------------------------------------
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            '--------------------------------------------------
            Me.grdMain.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grdMain.ExplorerBar = 0
            Me.grdMain.ExplorerBar = 3

        End Sub

        '=================
        ' 0.값 받기
        '=================

        '=================
        ' 1.조회
        '=================

        '=================
        ' 2.값 선택
        '=================

        '=================
        ' 3.이벤트 구분
        '=================

        '=================
        ' 4.타겟 화면 호출
        '=================

        '=================
        ' 5.화면에 값 전달
        '=================


        'Private McodeDivisionHangulName() As String = Nothing
        'Private MReturnKey() As String = Nothing

        'Private stringMcodeDivisionHangulName As String = ""
        'Private stringMReturnKey As String = ""

        'Private McodeSqlParameterName As String = ""
        'Private MnameSqlParameterName As String = ""

        'Private MwhereSqlParameterName As String = ""
        'Private McodeGridName As String = ""

        'Private MnameGridName As String = ""
        'Private MsubCode As String = ""

        'Private MpopupLayout As Generic.IDictionary(Of String, Object)
        'Private popupmanager As popupManager = New popupManager()

        'Private _popupType As Boolean

        '' 팝업 숨기기
        'Private strActvateOrHide As String = "1"

        'Public Property PopupType() As Boolean

        '    Get
        '        Return _popupType
        '    End Get

        '    Set(ByVal value As Boolean)
        '        _popupType = value
        '    End Set

        'End Property


        ''====================================================================================================
        'Public Sub Initialize(ByVal AcodeDivisionHangulName As String, Optional ByVal Awhere As String = "" _
        '                        , Optional ByVal AreturnKey As String = "", Optional ByVal AsubCode As String = "")

        '    Dim reciveDataSet As DataSet
        '    Dim strSql As String = ""
        '    Dim CodeDivision As String = ""
        '    Dim intII As Integer = 0

        '    Dim strColLogNm As String = ""      '컬럼 논리명
        '    Dim strColPhyNm As String = ""      '컬럼 물리명
        '    Dim strColWidth As String = ""      '컬럼 넓이명
        '    Dim strColVisible As String = ""    '표시 여부

        '    Debug.Print("팝업 where 절 : " & Awhere)

        '    ' 팝업이 아예 뜨지 않게
        '    If Awhere = "Escape" Then
        '        strActvateOrHide = "0"
        '    End If

        '    McodeDivisionHangulName = Split(AcodeDivisionHangulName, ",") '차재윤 추가
        '    MReturnKey = Split(AreturnKey, ",")
        '    stringMcodeDivisionHangulName = AcodeDivisionHangulName '차재윤 추가
        '    stringMReturnKey = AreturnKey '차재윤 추가

        '    MsubCode = AsubCode

        '    Me.Text = McodeDivisionHangulName(0) & " 조회"


        '    strSql = " select IsNull(max(CodeDivision),'') as CodeDivision from CommonCodeDivision " & _
        '              " where len(CodeDivision) = 4 and CodeDivision like '8%' " & _
        '              "    and CodeDivisionHangulName  = '" & McodeDivisionHangulName(0) & "'"

        '    reciveDataSet = GmainExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), strSql)

        '    If reciveDataSet.Tables(0).Rows.Count > 0 Then
        '        CodeDivision = (reciveDataSet.Tables(0).Rows(0)(0)) ' 바로 위 쿼리의 결과를 대입 한다.
        '    End If

        '    If CodeDivision.ToString().Length > 0 Then   '공통 코드 아닐 경우
        '        McodeSqlParameterName = "@Acode"
        '        MnameSqlParameterName = "@AcodeName"

        '        McodeGridName = "Code"
        '        MnameGridName = "CodeHangulName"
        '    Else
        '        McodeSqlParameterName = "@Acode"
        '        MnameSqlParameterName = "@AcodeName"

        '        McodeGridName = "Code"
        '        MnameGridName = "CodeHangulName"
        '    End If

        '    ' Where 조건 절 (and 뒤에 붙는다.)

        '    MwhereSqlParameterName = ""
        '    If Awhere <> "" Then
        '        If Awhere.Substring(0, 3) = "Pro" And Awhere.Length = 16 Then
        '            MwhereSqlParameterName = " and " & Awhere.Remove(Awhere.Length - 1, 1)
        '        Else
        '            Debug.Print("팝업 where 절 : " & Awhere)
        '            MwhereSqlParameterName = " and " & Awhere
        '        End If
        '    End If

        '    'VSFlexGrid를 초기화 한다.
        '    '--------------------------------------------------
        '    Dim gridAttributes As String = ""

        '    '수정 mode(0 - 불가, 1 - 키보드, 2 - 키보드 & 마우스); 선택 mode(1 - cell, 2 - row); 자동 Size Y/N(1/0))
        '    gridAttributes = gridAttributes & "0;2;1"

        '    If McodeDivisionHangulName.Length < 2 Then   ' 멀티리턴이 아닌 것만 추가하고 멀티리턴은 아래 추가된곳에 기술한다.

        '        gridAttributes = gridAttributes & "|"
        '        If CodeDivision.ToString().Length > 0 Then     '공통 코드 아닐 경우
        '            '==========================================================================
        '            ' 공통 코드 상세
        '            '==========================================================================
        '            strSql = "select Note1, Note2, Note3, Note4  From CommonCode " & _
        '                     " where len(CodeDivision) = 4 and CodeDivision like '8%' and Note1 > '' and CodeDivision = '" & _
        '                     CodeDivision.ToString() & "' " & _
        '                     " order by Code  "

        '            reciveDataSet = GmainExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), strSql)
        '            ' 결과 만큼 루프를 돌면서 셋팅 
        '            For intII = 0 To reciveDataSet.Tables(0).Rows.Count - 1     ' 공통코드 8xxx 비고1:컬럼캡션명, 비고2:물리명, 비고3:width, 비고4:visible 
        '                strColLogNm = reciveDataSet.Tables(0).Rows(intII)("Note1")      '컬럼 논리명
        '                strColPhyNm = reciveDataSet.Tables(0).Rows(intII)("Note2")      '컬럼 물리명
        '                strColWidth = reciveDataSet.Tables(0).Rows(intII)("Note3")      '컬럼 넓이명
        '                strColVisible = reciveDataSet.Tables(0).Rows(intII)("Note4")    '표시 여부

        '                gridAttributes = gridAttributes & "|" & strColLogNm & ";" & strColPhyNm & ";" & _
        '                                                  IIf(strColWidth.ToString.Length > 1, strColWidth, 0) & _
        '                                                  ";;1;" & "o;n;" & IIf(strColVisible.ToString.Length > 1, strColVisible, 0) & ";0;"
        '                'gridAttributes = gridAttributes & "|" & Mid(McodeDivisionHangulName(0), 1, Len(McodeDivisionHangulName(0)) - 1) & "코드;" & McodeGridName & ";100;;4;" & "o;n;n;0;"
        '                'gridAttributes = gridAttributes & "|" & McodeDivisionHangulName(0) & ";" & MnameGridName & ";100;;1;" & "o;n;n;0;"
        '            Next
        '        Else
        '            gridAttributes = gridAttributes & "|" & Mid(McodeDivisionHangulName(0), 1, Len(McodeDivisionHangulName(0)) - 1) & "코드;" & McodeGridName & ";100;;4;" & "o;n;n;0;"
        '            gridAttributes = gridAttributes & "|" & McodeDivisionHangulName(0) & ";" & MnameGridName & ";100;;1;" & "o;n;n;0;"
        '        End If


        '    ElseIf McodeDivisionHangulName.Length >= 2 Then '만약 common Popup에서 조건이 code(계약자 명, 표준 적요 명); 처럼 두개가 들어올 경우?
        '        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        '        '멀티 리턴일 경우에 만 다음과 같은 형식으로 추가한다. 

        '        If stringMcodeDivisionHangulName = "계약자 명,사용 호실,부과 시작 일자,부과 완료 일자" Then
        '            gridAttributes = gridAttributes & "||계약자 ID;" & McodeGridName & ";100;;4;" & "o;n;n;0;"
        '            gridAttributes = gridAttributes & "|계약자 명;" & MnameGridName & ";100;;1;" & "o;n;n;0;"

        '        ElseIf stringMcodeDivisionHangulName = "품의서 제목,기안자,품의 금액,월 품의 액" Then
        '            gridAttributes = gridAttributes & "||품의서 관리 번호;" & McodeGridName & ";100;;4;" & "o;n;n;0;"
        '            gridAttributes = gridAttributes & "|품의서 제목;" & MnameGridName & ";100;;1;" & "o;n;n;0;"
        '        End If

        '    End If

        '    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        '    If MReturnKey.Length = McodeDivisionHangulName.Length Then  '추가 리턴 값이 있고 리턴 명과 컬럼의 수가 맞을 경우
        '        For mcodeDivisionHangulNameCount As Integer = 1 To UBound(McodeDivisionHangulName) Step 1
        '            gridAttributes = gridAttributes & "|" & McodeDivisionHangulName(mcodeDivisionHangulNameCount) & ";" & MReturnKey(mcodeDivisionHangulNameCount) & ";100;;4;" & "o;n;n;0;"
        '        Next
        '    Else
        '        Debug.Print("리턴명과 대상 컬럼의 수가 맞지 않습니다.")
        '        Exit Sub
        '    End If

        '    grdMain.Initialize(gridAttributes)
        '    grdMain.ExplorerBar = 3 'c1.Win.C1FlexGrid.DragModeEnum. ' flexExMove ' 1
        '    reciveDataSet = Nothing
        'End Sub

        'Public GcurrentPop As Object = Nothing

        ''====================================================================================================

        'Private Sub frmCodeName_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        '    If Me.strActvateOrHide = "0" Then
        '        Me.Hide()
        '    End If

        '    Me.grdMain.GParentObject = Me

        '    If TypeOf GcurrentPop Is CommonControls.pop Then
        '        If VBN.Left(GcurrentPop.TextValue, 1) = ";" Then
        '            Me.txtCode.Text = vbNullString
        '            Me.txtName.Text = VBN.Mid(GcurrentPop.TextValue, 2, VBN.Len(GcurrentPop.TextValue))
        '            Me.txtWhere.Text = MwhereSqlParameterName
        '        Else
        '            Me.txtCode.Text = Trim(GcurrentPop.TextValue)
        '            Me.txtName.Text = vbNullString
        '            Me.txtWhere.Text = MwhereSqlParameterName
        '        End If
        '        Me.txtCode.Focus()
        '    Else

        '        '' 팝업이 로드 되었을때 

        '        beforeEditGridRowDataSave()

        '        With GcurrentPop

        '            If MwhereSqlParameterName <> "" Then
        '                SetCirteriaCollection(MwhereSqlParameterName)
        '                Me.txtCode.Text = .get_TextMatrix(.Row, .Col)
        '                Me.txtWhere.Text = MwhereSqlParameterName
        '                Debug.Print("팝업 MwhereSqlParameterName 절 : " & MwhereSqlParameterName)
        '            Else
        '                Me.txtCode.Text = .get_TextMatrix(.Row, .Col)
        '                Debug.Print("팝업 MwhereSqlParameterName 절 : " & MwhereSqlParameterName)
        '            End If
        '            'Me.txtWhere.Text = MwhereSqlParameterName '추가 - 차재윤20060626
        '        End With
        '    End If


        '    '' 코드 & 코드명을 인수로 받았을 시 자동으로 조회 버튼 클릭 
        '    If Me.txtCode.Text.Length > 0 Or Me.txtName.Text.Length > 0 Then


        '    End If

        'End Sub

        'Private CirteriaCollection As New Collection


        'Private Sub SetCirteriaCollection(ByVal WhereSqlParameter As String)

        '    If WhereSqlParameter <> "" Then
        '        Debug.Print(WhereSqlParameter)
        '        CirteriaCollection.Clear()
        '        Dim strings() As String = Split(WhereSqlParameter, " and ")


        '        For Each whereString As String In strings
        '            If LCase(whereString).Trim <> "" Then
        '                If Split(LCase(whereString), "=").Length > 1 Then
        '                    Dim key As String = Split(LCase(whereString), "=")(0)
        '                    Dim value As String = Split(LCase(whereString), "=")(1)
        '                    CirteriaCollection.Add(value, key)
        '                ElseIf Split(LCase(whereString), "like").Length > 1 Then
        '                    Dim key As String = Split(LCase(whereString), "like")(0)
        '                    Dim value As String = Split(LCase(whereString), "like")(1)
        '                End If
        '            Else

        '            End If
        '        Next


        '    End If
        'End Sub

        'Public GmainExecuteDbCommand As New DAT.ExecuteDbCommand
        'Public GmainCommonFunction As New ubiLease.CommonFunction.Common
        'Private MmainsqlParameters() As Data.SqlClient.SqlParameter

        ''====================================================================================================
        'Private Sub btnRequestData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequestData.Click
        '    Debug.Print("팝업 MwhereSqlParameterName 절 : " & MwhereSqlParameterName)
        '    SetCriteriaWhereString()

        '    Dim privateSubCode As String = ""

        '    ' 실행 위치 지정

        '    If MsubCode = "" Then
        '        privateSubCode = "popfrm"
        '    Else
        '        privateSubCode = "popfrm;" & MsubCode
        '    End If

        '    ' 일반 팝업 처리
        '    Dim reciveDataSet As Object = GmainCommonFunction.GetPopupRecordset( _
        '        GcurrentPop _
        '        , stringMcodeDivisionHangulName _
        '        , Trim(Me.txtCode.Text) _
        '        , Trim(Me.txtName.Text) _
        '        , Trim(Me.txtWhere.Text) _
        '        , stringMReturnKey _
        '        , privateSubCode _
        '    )

        '    If IsNothing(reciveDataSet) = False Then
        '        GmainExecuteDbCommand.GrequestCount = 1
        '        Me.grdMain.SetDataSet(reciveDataSet)
        '        Me.grdMain.Focus()
        '    End If
        'End Sub
        '''' <summary>
        '''' 
        '''' </summary>
        '''' <remarks></remarks>
        'Private Sub SetCriteriaWhereString()
        '    Dim strTemp As String = ""

        '    'stringMcodeDivisionHangulName 이 감면명..... 일때
        '    'CirteriaCollection 키값을로 Value 가져와서 Where 절을 만들고 txtWhere에 저장한후 
        '    ' 다음을 진행한다.
        '    Debug.Print("팝업 Awhere TextBox 절 : " & Me.txtWhere.Text)

        '    If stringMcodeDivisionHangulName = "감면 명,감면 율,시작 년월,종료 년월" Then

        '        Me.txtWhere.Text = ""
        '        If CirteriaCollection.Count > 0 Then
        '            Me.txtWhere.Text = " and " + Replace(CirteriaCollection.Item("RequestCriteriaYearsMonth").ToString, "-", "") + " between ApplicationBeginningDate and ApplicationEndDate "
        '            'Me.txtWhere.Visible = True
        '        End If

        '    ElseIf stringMcodeDivisionHangulName = "계약자 명,사용 호실,부과 시작 일자,부과 완료 일자" Then
        '        Me.txtWhere.Text = ""
        '        If CirteriaCollection.Count > 0 Then
        '            Me.txtWhere.Text = Replace(Replace(CirteriaCollection.Item("BugaCriteriaDate").ToString, "-", ""), "'", "").ToString
        '        End If

        '    ElseIf stringMcodeDivisionHangulName = "관리 계정 명" Then

        '        If Me.txtWhere.Text = "" Then
        '            Me.txtWhere.Text = GcurrentPop.Parent.Controls(0).TextValue
        '        Else
        '            Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim().Substring(0, 6)
        '        End If


        '        'ElseIf stringMcodeDivisionHangulName = "관리 계정 명1" Then
        '        '    Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim()
        '        'ElseIf stringMcodeDivisionHangulName = "관리 계정 명2" Then
        '        '    Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim()
        '        'ElseIf stringMcodeDivisionHangulName = "관리 계정 명3" Then
        '        '    Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim()
        '        'ElseIf stringMcodeDivisionHangulName = "관리 계정 명4" Then
        '        '    Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim()
        '    ElseIf stringMcodeDivisionHangulName = "품의서 제목,기안자,품의 금액,월 품의 액" Then

        '        Me.txtWhere.Text = ""
        '        If CirteriaCollection.Count > 0 Then
        '            strTemp = CirteriaCollection.Item("BudgetYears").ToString().Replace("'", "") + CirteriaCollection.Item("BudgetMonths").ToString().Replace("'", "")
        '            Me.txtWhere.Text = " and left(t1.ValidBeginDate, 6) <= '" & strTemp & "' and left(t1.ValidEndDate, 6) >= '" & strTemp & "' and left(t1.OrganizationCode, 8) = '" & CirteriaCollection.Item("OrganizationCode").ToString().Replace("'", "") & "' and t1.AccountCode = '" & CirteriaCollection.Item("AccountCode").ToString().Replace("'", "") & "' "

        '        End If

        '    ElseIf stringMcodeDivisionHangulName = "관리비 분류 명, 관리비 항목 코드, 관리비 항목 명,단가" Then

        '        Me.txtWhere.Text = ""
        '        If CirteriaCollection.Count > 0 Then
        '            Me.txtWhere.Text = Replace(Replace(CirteriaCollection.Item("BugaYearsMonths").ToString, "-", ""), "'", "").ToString
        '            Me.txtWhere.Text = Replace(Replace(CirteriaCollection.Item("SaYongRoomCode").ToString, "-", ""), "'", "").ToString
        '        End If

        '        ' 차재윤 추가
        '    ElseIf stringMcodeDivisionHangulName = "차수별 급여 항목 명" Then
        '        Me.txtWhere.Text = ""
        '        If CirteriaCollection.Count > 0 Then
        '            Me.txtWhere.Text = " and t1.AllowanceYearMonth = " & CirteriaCollection.Item("AllowanceYearMonth").ToString & " " _
        '                             & " and t1.[Order] = " & CirteriaCollection.Item("Order").ToString & " " _
        '                             & " and t3.AllowanceDivisionCode = (select AllowanceDivisionCode from PersnalAffairsHeader where employeeNumber = " & CirteriaCollection.Item("employeeNumber").ToString & ") "
        '        End If

        '    ElseIf stringMcodeDivisionHangulName = "수익 조직 명" Then

        '        Me.txtWhere.Text = ""
        '        If CirteriaCollection.Count > 0 Then
        '            Me.txtWhere.Text = " and t1.Years = '" & Trim(Replace(Replace(CirteriaCollection.Item("distributionYearsMonths").ToString, "-", ""), "'", "").ToString.Substring(0, 4)) & "'"
        '            Me.txtWhere.Text = Me.txtWhere.Text & " and t1.Months = '" & Trim(Replace(Replace(CirteriaCollection.Item("distributionYearsMonths").ToString, "-", ""), "'", "").ToString.Substring(4, 2)) & "'"
        '        End If

        '        'ElseIf stringMcodeDivisionHangulName = "지원 조직 명" Then

        '        '    'Me.txtWhere.Text = ""
        '        '    Me.txtWhere.Text = Trim(Replace(Replace(Me.txtWhere.Text, "and", ""), "'", ""))

        '        'If CirteriaCollection.Count > 0 Then
        '        '    Me.txtWhere.Text = " and t1.Years = '" & Trim(Replace(Replace(CirteriaCollection.Item("distributionYearsMonths").ToString, "-", ""), "'", "").ToString.Substring(0, 4)) & "'"
        '        '    Me.txtWhere.Text = Me.txtWhere.Text & " and t1.Months = '" & Trim(Replace(Replace(CirteriaCollection.Item("distributionYearsMonths").ToString, "-", ""), "'", "").ToString.Substring(4, 2)) & "'"
        '        'End If

        '    ElseIf stringMcodeDivisionHangulName = "정산 계약자 명,사용호실,정산 금액,면제 금액" Then

        '        Me.txtWhere.Text = ""
        '        If CirteriaCollection.Count > 0 Then
        '            Me.txtWhere.Text = " and " + Replace(Replace(CirteriaCollection.Item("ExactCalculationYearsMonths").ToString, "-", ""), "'", "").ToString
        '        End If

        '    ElseIf stringMcodeDivisionHangulName = "관리 항목 명" Then

        '        Me.txtWhere.Text = ""
        '        'If CirteriaCollection.Count > 0 Then
        '        strTemp = CType(Me.GcurrentPop, ubiLease.CommonControls.pop).Parent.Controls("lblManagementItemNumber").Text
        '        If strTemp = "계좌번호" Then
        '            Me.txtWhere.Text = " and BankBranchCode LIKE '" + CType(CType(Me.GcurrentPop, ubiLease.CommonControls.pop).Parent.Controls("popSideItemCode"), ubiLease.CommonControls.pop).TextValue + "' + '%' "
        '        ElseIf strTemp = "호실번호" Then
        '            Me.txtWhere.Text = " and BankBranchCode LIKE '" + CType(CType(Me.GcurrentPop, ubiLease.CommonControls.pop).Parent.Controls("popSideItemCode"), ubiLease.CommonControls.pop).TextValue + "' + '%' "
        '        End If
        '        'End If
        '    ElseIf stringMcodeDivisionHangulName = "거래처 명" Then
        '        Dim strAddWhere As String = ""
        '        Dim strResidentRegistrationNumber As String = ""
        '        Dim strWorkRegistrationNumber As String = ""
        '        Dim strRepresentativeName As String = ""

        '        strResidentRegistrationNumber = CType(Me.Controls.Find("txtJuminNumber", True)(0), ubiLease.CommonControls.txt).TextValue
        '        strWorkRegistrationNumber = CType(Me.Controls.Find("txtBizNumber", True)(0), ubiLease.CommonControls.txt).TextValue
        '        strRepresentativeName = CType(Me.Controls.Find("txtRepresentativeName", True)(0), ubiLease.CommonControls.txt).TextValue

        '        Me.txtWhere.Text = ""
        '        ''If CirteriaCollection.Count > 0 Then
        '        strAddWhere += " AND ResidentRegistrationNumber LIKE '" & strResidentRegistrationNumber & "' + '%' "
        '        strAddWhere += " AND WorkRegistrationNumber LIKE '" & strWorkRegistrationNumber & "'  + '%' "
        '        strAddWhere += " AND RepresentativeName LIKE '" & strRepresentativeName & "'  + '%' "

        '        Me.txtWhere.Text = strAddWhere
        '        'End If
        '    ElseIf stringMcodeDivisionHangulName = "기표 거래처 명" Then
        '        Dim strAddWhere As String = ""
        '        Dim strResidentRegistrationNumber As String = ""
        '        Dim strWorkRegistrationNumber As String = ""
        '        Dim strRepresentativeName As String = ""

        '        strResidentRegistrationNumber = CType(Me.Controls.Find("txtJuminNumber", True)(0), ubiLease.CommonControls.txt).TextValue
        '        strWorkRegistrationNumber = CType(Me.Controls.Find("txtBizNumber", True)(0), ubiLease.CommonControls.txt).TextValue
        '        strRepresentativeName = CType(Me.Controls.Find("txtRepresentativeName", True)(0), ubiLease.CommonControls.txt).TextValue

        '        Me.txtWhere.Text = ""
        '        ''If CirteriaCollection.Count > 0 Then
        '        strAddWhere += " AND ResidentRegistrationNumber LIKE '" & strResidentRegistrationNumber & "' + '%' "
        '        strAddWhere += " AND WorkRegistrationNumber LIKE '" & strWorkRegistrationNumber & "'  + '%' "
        '        strAddWhere += " AND RepresentativeName LIKE '" & strRepresentativeName & "'  + '%' "
        '        Me.txtWhere.Text = strAddWhere

        '    ElseIf stringMcodeDivisionHangulName = "그룹 계열사 명" Then
        '        Dim strAddWhere As String = ""
        '        Dim strResidentRegistrationNumber As String = ""
        '        Dim strWorkRegistrationNumber As String = ""
        '        Dim strRepresentativeName As String = ""

        '        strResidentRegistrationNumber = CType(Me.Controls.Find("txtJuminNumber", True)(0), ubiLease.CommonControls.txt).TextValue
        '        strWorkRegistrationNumber = CType(Me.Controls.Find("txtBizNumber", True)(0), ubiLease.CommonControls.txt).TextValue
        '        strRepresentativeName = CType(Me.Controls.Find("txtRepresentativeName", True)(0), ubiLease.CommonControls.txt).TextValue

        '        Me.txtWhere.Text = ""
        '        ''If CirteriaCollection.Count > 0 Then
        '        strAddWhere += " AND ResidentRegistrationNumber LIKE '" & strResidentRegistrationNumber & "' + '%' "
        '        strAddWhere += " AND WorkRegistrationNumber LIKE '" & strWorkRegistrationNumber & "'  + '%' "
        '        strAddWhere += " AND RepresentativeName LIKE '" & strRepresentativeName & "'  + '%' "
        '        strAddWhere += " AND CustomerType = '01' "
        '        Me.txtWhere.Text = strAddWhere

        '    ElseIf stringMcodeDivisionHangulName = "중장기 사업계획 조직 명" Then

        '        Me.txtWhere.Text = ""
        '        If CirteriaCollection.Count > 0 Then
        '            Me.txtWhere.Text = " and t1.PlanYears = " & Trim(CirteriaCollection.Item("PlanYears")) & " "
        '            Me.txtWhere.Text = Me.txtWhere.Text & " and t1.PlanOrders = " & Trim(CirteriaCollection.Item("PlanOrders").ToString()) & " "
        '        End If

        '    End If

        'End Sub

        ''====================================================================================================
        'Private Sub btnYesNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        '    Handles btnNo.Click

        '    With Me.grdMain
        '        If sender.Name = "btnYes" Then

        '            If .Rows <= .FixedRows Then
        '                'MsgBox("선택된 행이 없습니다.", MsgBoxStyle.Information, GmainCommonFunction.GmessageTile)
        '                Exit Sub
        '            End If
        '            Dim SelDataCollection As Collection = New Collection
        '            If TypeOf GcurrentPop Is CommonControls.pop Then

        '                If .Cols > 2 Then

        '                    SelDataCollection.Clear()

        '                    For ColNum As Integer = 1 To .Cols - 1 Step 1
        '                        SelDataCollection.Add(.GetData(.Row, ColNum), .get_ColKey(ColNum))
        '                    Next
        '                    CType(GcurrentPop, ubiLease.CommonControls.pop).SelRowDataCollection = SelDataCollection
        '                End If

        '                Dim strstag As String() = CType(GcurrentPop, ubiLease.CommonControls.pop).Tag.Split(";")

        '                Dim i As Integer = 1

        '                For Each s As String In strstag
        '                    If s.Trim.ToLower.StartsWith("rtnvalue(") Then
        '                        s = s.Replace("rtnvalue(", "")
        '                        s = s.Replace(")", "")
        '                        Dim strs() As String = s.Split(",")

        '                        For Each ss As String In strs
        '                            For Each c As Control In CType(GcurrentPop, ubiLease.CommonControls.pop).Parent.Controls

        '                                If c.Name.Trim.ToLower = ss.Trim.ToLower Then
        '                                    If TypeOf c Is ubiLease.CommonControls.pop Then
        '                                        CType(c, Object).CodeText = SelDataCollection("rtnValue" & i.ToString()).ToString()
        '                                    Else
        '                                        CType(c, Object).TextValue = SelDataCollection("rtnValue" & i.ToString()).ToString()

        '                                    End If
        '                                    i = i + 1
        '                                End If
        '                            Next
        '                        Next
        '                    End If
        '                Next

        '                GcurrentPop.popFormAction = True

        '                GcurrentPop.TextValue = .get_TextMatrix(.Row, .get_ColIndex(McodeGridName))
        '                GcurrentPop.NameText = .get_TextMatrix(.Row, .get_ColIndex(MnameGridName))


        '                GcurrentPop.popFormAction = False

        '                GcurrentPop.txtUserControl.Select()
        '                GcurrentPop.txtUserControl.Focus()
        '                'End If

        '            Else
        '                Dim colDatas() As String = Split(GcurrentPop.get_ColData(GcurrentPop.Col), ";")
        '                Dim nameColKey As String = ""
        '                Dim returnKey() As String = Split(Trim(colDatas(5)), ",")
        '                Dim returnCount As Integer = returnKey.Length

        '                If colDatas.Length >= 6 Then

        '                    If _
        '                        Trim(colDatas(5)) <> "" _
        '                        And Trim(colDatas(5)) <> "0" _
        '                        Then

        '                        GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.Col, .get_TextMatrix(.Row, .get_ColIndex(McodeGridName)))
        '                        GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(Split(colDatas(5), ",")(0)), .get_TextMatrix(.Row, .get_ColIndex(MnameGridName)) _
        '                        )
        '                        If returnKey.Length >= 2 Then
        '                            For returnKeyNumber As Integer = 1 To returnCount - 1 Step 1
        '                                GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(Split(colDatas(5), ",")(returnKeyNumber)), .get_TextMatrix(.Row, .get_ColIndex(returnKey(returnKeyNumber))))
        '                                If Me.grdMain.get_ColIndex(returnKey(returnKeyNumber).ToString()) > 0 Then
        '                                    Debug.Print(":")
        '                                End If

        '                                Debug.Print("멀티리턴 : 선택값 : " & " 행 : " & .Row & " 열 :" & .get_ColIndex(returnKey(returnKeyNumber).ToString()) & " : " & returnKey(returnKeyNumber).ToString() & " : " & .get_TextMatrix(.Row, .get_ColIndex(returnKey(returnKeyNumber).ToString())).ToString())
        '                                Debug.Print("멀티리턴 : 적용된 값 : " & " 행 : " & GcurrentPop.Row & " 열 : " & " : " & GcurrentPop.get_ColIndex(Split(colDatas(5), ",")(returnKeyNumber)) & Split(colDatas(5), ",")(returnKeyNumber).ToString() & " : " & GcurrentPop.get_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(Split(colDatas(5), ",")(returnKeyNumber))))
        '                            Next
        '                        End If

        '                        afterEditGridRowDataChangeCheck()
        '                    Else
        '                        nameColKey = Trim(colDatas(5))
        '                        If nameColKey = "" Then
        '                            nameColKey = GcurrentPop.get_ColKey(GcurrentPop.Col) & "Name"
        '                        End If
        '                        GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.Col, .get_TextMatrix(.Row, .get_ColIndex(McodeGridName)))
        '                        GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(nameColKey), .get_TextMatrix(.Row, .get_ColIndex(MnameGridName)) _
        '                        )

        '                        afterEditGridRowDataChangeCheck()
        '                    End If


        '                Else
        '                    nameColKey = Trim(colDatas(4))
        '                    If nameColKey = "" Then
        '                        nameColKey = GcurrentPop.get_ColKey(GcurrentPop.Col) & "Name"
        '                    End If
        '                    GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.Col, .get_TextMatrix(.Row, .get_ColIndex(McodeGridName)))
        '                    GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(nameColKey), .get_TextMatrix(.Row, .get_ColIndex(MnameGridName)) _
        '                    )

        '                    afterEditGridRowDataChangeCheck()

        '                End If
        '            End If

        '        End If

        '    End With

        '    Me.Hide()
        'End Sub

        'Private tmpRowDatas As Collection

        'Private Sub beforeEditGridRowDataSave()

        '    If IsNothing(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.Data) Then

        '    Else
        '        tmpRowDatas = New Collection
        '        For i As Integer = CType(GcurrentPop, ubiLease.GridControl.grd).FixedCols To CType(GcurrentPop, ubiLease.GridControl.grd).Cols - CType(GcurrentPop, ubiLease.GridControl.grd).FixedCols

        '            If IsNothing(CType(GcurrentPop, ubiLease.GridControl.grd).get_TextMatrix(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.r1, i)) Then

        '                tmpRowDatas.Add("", CType(GcurrentPop, ubiLease.GridControl.grd).get_ColKey(i))
        '            Else
        '                tmpRowDatas.Add(CType(GcurrentPop, ubiLease.GridControl.grd).get_TextMatrix(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.r1, i), CType(GcurrentPop, ubiLease.GridControl.grd).get_ColKey(i))
        '            End If

        '        Next
        '    End If

        'End Sub

        'Private Sub afterEditGridRowDataChangeCheck()

        '    If IsNothing(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.Data) Then

        '    Else
        '        If IsNothing(tmpRowDatas) Then
        '        Else

        '            Dim dataDiff As Boolean = False

        '            For i As Integer = CType(GcurrentPop, ubiLease.GridControl.grd).FixedCols To CType(GcurrentPop, ubiLease.GridControl.grd).Cols - CType(GcurrentPop, ubiLease.GridControl.grd).FixedCols

        '                If tmpRowDatas(CType(GcurrentPop, ubiLease.GridControl.grd).get_ColKey(i)) = CType(GcurrentPop, ubiLease.GridControl.grd).get_TextMatrix(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.r1, i) Then

        '                Else
        '                    dataDiff = True
        '                End If

        '            Next
        '            If dataDiff = True Then
        '                Dim 선택컬럼 As Integer = 0
        '                선택컬럼 = CType(GcurrentPop, ubiLease.GridControl.grd).get_ColIndex("선택")
        '                If 선택컬럼 > 0 Then
        '                    CType(GcurrentPop, ubiLease.GridControl.grd).set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpChecked, GcurrentPop.Row, 선택컬럼, C1.Win.C1FlexGrid.Classic.CellCheckedSettings.flexChecked)
        '                End If
        '            End If
        '        End If
        '    End If

        'End Sub

        '====================================================================================================
        Private Sub frmCodeName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
            If e.KeyCode = Keys.Enter Then

                If Me.btnRequestData.Focused = True Then



                End If

            ElseIf e.KeyCode = Keys.Escape Then
                Me.Hide()
            End If
        End Sub


        ''====================================================================================================
        'Private Sub grdMain_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
        '    btnYesNo_Click(Me.btnYes, Nothing)
        'End Sub

        ''====================================================================================================
        'Private Sub grdMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdMain.KeyPress
        '    If e.KeyChar = ChrW(Keys.Return) Then
        '        btnYesNo_Click(Me.btnYes, Nothing)
        '    End If
        'End Sub

        '====================================================================================================
        Private Sub frmCodeName_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
            Me.Hide()
        End Sub



        Private Sub frmCodeName_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
            Me.StartPosition = FormStartPosition.CenterParent
        End Sub


    End Class
End Namespace

