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

Imports System.Text
Imports System.IO

Imports C1.Win.C1FlexGrid

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE601
        Inherits CommonControls.UiControl

        Private Sub PNE601_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            '=================== grid1 초기화 한다. =================== 
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;r;" & "io;n;n;"
            gridAttributes = gridAttributes & "|순번;Orders;40;;c;" & "io;y;n;;"
            gridAttributes = gridAttributes & "|확장일자;ExpandDt;80;;c;" & "io;y;n;;"
            gridAttributes = gridAttributes & "|사원확장 코드;EmployeeExpMapping;90;;l;" & "io;y;n;;"
            gridAttributes = gridAttributes & "|확장처 코드;EmployeeExpNum;90;;l;" & "io;y;n;;확장처 명;EmployeeExpName;"
            gridAttributes = gridAttributes & "|확장처 명;EmployeeExpName;130;;l;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|확장부서 코드;SoliDeptCd;80;;l;" & "io;y;n;;사원확장 부서;SoliDeptName;"
            gridAttributes = gridAttributes & "|확장부서 명;SoliDeptName;100;;l;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpPapNum;60;#,###;r;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpPapNum;60;#,###;r;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpPapNum;60;#,###;r;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|광고금액;AdAmount;80;#,###;r;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|광고구분;AdDivision;60;;l;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|매출일자;SalesDate;100;;l;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|전환금;ChangeAmount;80;#,###;r;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|대행비율;AgencyPercent;60;;r;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|게재일자;PublishDate;100;;l;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|게재일비고;PublishNote;100;;l;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|면;Pages;50;;c;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|담당자코드;PersonInChargeCd;80;;c;" & "io;n;n;5;사원 명;PersonInChargeName"
            gridAttributes = gridAttributes & "|담당자명;PersonInChargeName;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|비고;Remark;200;;l;" & "io;n;n;;"



            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "EmployeeExpNum;사원확장 부서"
            gridCodeNameList = gridCodeNameList & "AdDivision;사원확장 광고 구분"
            ''gridCodeNameList = gridCodeNameList & "ProvisionSubtractionYesOrNo;급여 항목 구분 명/" '503
            'gridCodeNameList = gridCodeNameList & "AverageAllowanceDivisionCode;평균임금 구분 명/"
            'gridCodeNameList = gridCodeNameList & "AllowanceProvisionWay;급여 지급 방법 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '-- 컬럼 고정 시키기
            grd_1.ExplorerBar = 1
            grd_1.FrozenCols = 3

            '=================== grid2 초기화 한다. =================== 
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;r;" & "io;n;n;"
            gridAttributes = gridAttributes & "|확장부서 코드;SoliDeptCd;80;;l;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|확장부서 명;SoliDeptName;100;;l;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumMon;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumTues;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumWed;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumThurs;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumFri;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumWeek;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumMon;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumTues;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumWed;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumThurs;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumFri;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumWeek;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumMon;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumTues;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumWed;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumThurs;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumFri;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumWeek;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)



            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "ProvisionSubtractionYesOrNo;지급 공제 명/"  '525
            ''gridCodeNameList = gridCodeNameList & "ProvisionSubtractionYesOrNo;급여 항목 구분 명/" '503
            'gridCodeNameList = gridCodeNameList & "AverageAllowanceDivisionCode;평균임금 구분 명/"
            'gridCodeNameList = gridCodeNameList & "AllowanceProvisionWay;급여 지급 방법 명"

            grd_2.Initialize(gridAttributes, gridCodeNameList)

            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "선택"
            strColName2 = strColName2 & ControlChars.Tab & "확장부서 코드"
            strColName2 = strColName2 & ControlChars.Tab & "확장부서 명"

            strColName2 = strColName2 & ControlChars.Tab & "월"
            strColName2 = strColName2 & ControlChars.Tab & "화"
            strColName2 = strColName2 & ControlChars.Tab & "수"
            strColName2 = strColName2 & ControlChars.Tab & "목"
            strColName2 = strColName2 & ControlChars.Tab & "금"
            strColName2 = strColName2 & ControlChars.Tab & "계"

            strColName2 = strColName2 & ControlChars.Tab & "월"
            strColName2 = strColName2 & ControlChars.Tab & "화"
            strColName2 = strColName2 & ControlChars.Tab & "수"
            strColName2 = strColName2 & ControlChars.Tab & "목"
            strColName2 = strColName2 & ControlChars.Tab & "금"
            strColName2 = strColName2 & ControlChars.Tab & "계"

            strColName2 = strColName2 & ControlChars.Tab & "월"
            strColName2 = strColName2 & ControlChars.Tab & "화"
            strColName2 = strColName2 & ControlChars.Tab & "수"
            strColName2 = strColName2 & ControlChars.Tab & "목"
            strColName2 = strColName2 & ControlChars.Tab & "금"
            strColName2 = strColName2 & ControlChars.Tab & "계"

            With Me.grd_2

                Dim i As Integer

                .AddItem(strColName2)

                .FixedRows = 3
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly

                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next

                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next

            End With

            '-- 컬럼 고정 시키기
            grd_2.ExplorerBar = 1
            grd_2.FrozenCols = 3

            '=================== grid3 초기화 한다. =================== 
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;r;" & "io;n;n;"
            gridAttributes = gridAttributes & "|확장부서 코드;SoliDeptCd;80;;l;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|확장부서 명;SoliDeptName;100;;l;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumJan;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumFeb;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumMar;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumApr;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumMay;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumJune;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumJuly;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumAug;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumSept;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumOct;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumNov;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumDec;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpNumMonth;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumJan;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumFeb;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumMar;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumApr;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumMay;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumJune;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumJuly;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumAug;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumSept;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumOct;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumNov;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumDec;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpNumMonth;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumJan;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumFeb;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumMar;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumApr;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumMay;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumJune;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumJuly;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumAug;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumSept;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumOct;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumNov;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumDec;50;#,###;r;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpNumMonth;50;#,###;r;" & "o;y;n;;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "ProvisionSubtractionYesOrNo;지급 공제 명/"  '525
            ''gridCodeNameList = gridCodeNameList & "ProvisionSubtractionYesOrNo;급여 항목 구분 명/" '503
            'gridCodeNameList = gridCodeNameList & "AverageAllowanceDivisionCode;평균임금 구분 명/"
            'gridCodeNameList = gridCodeNameList & "AllowanceProvisionWay;급여 지급 방법 명"

            grd_3.Initialize(gridAttributes, gridCodeNameList)

            strColName2 = " "
            strColName2 = strColName2 & ControlChars.Tab & "선택"
            strColName2 = strColName2 & ControlChars.Tab & "확장부서 코드"
            strColName2 = strColName2 & ControlChars.Tab & "확장부서 명"

            strColName2 = strColName2 & ControlChars.Tab & "1월"
            strColName2 = strColName2 & ControlChars.Tab & "2월"
            strColName2 = strColName2 & ControlChars.Tab & "3월"
            strColName2 = strColName2 & ControlChars.Tab & "4월"
            strColName2 = strColName2 & ControlChars.Tab & "5월"
            strColName2 = strColName2 & ControlChars.Tab & "6월"
            strColName2 = strColName2 & ControlChars.Tab & "7월"
            strColName2 = strColName2 & ControlChars.Tab & "8월"
            strColName2 = strColName2 & ControlChars.Tab & "9월"
            strColName2 = strColName2 & ControlChars.Tab & "10월"
            strColName2 = strColName2 & ControlChars.Tab & "11월"
            strColName2 = strColName2 & ControlChars.Tab & "12월"
            strColName2 = strColName2 & ControlChars.Tab & "계"

            strColName2 = strColName2 & ControlChars.Tab & "1월"
            strColName2 = strColName2 & ControlChars.Tab & "2월"
            strColName2 = strColName2 & ControlChars.Tab & "3월"
            strColName2 = strColName2 & ControlChars.Tab & "4월"
            strColName2 = strColName2 & ControlChars.Tab & "5월"
            strColName2 = strColName2 & ControlChars.Tab & "6월"
            strColName2 = strColName2 & ControlChars.Tab & "7월"
            strColName2 = strColName2 & ControlChars.Tab & "8월"
            strColName2 = strColName2 & ControlChars.Tab & "9월"
            strColName2 = strColName2 & ControlChars.Tab & "10월"
            strColName2 = strColName2 & ControlChars.Tab & "11월"
            strColName2 = strColName2 & ControlChars.Tab & "12월"
            strColName2 = strColName2 & ControlChars.Tab & "계"

            strColName2 = strColName2 & ControlChars.Tab & "1월"
            strColName2 = strColName2 & ControlChars.Tab & "2월"
            strColName2 = strColName2 & ControlChars.Tab & "3월"
            strColName2 = strColName2 & ControlChars.Tab & "4월"
            strColName2 = strColName2 & ControlChars.Tab & "5월"
            strColName2 = strColName2 & ControlChars.Tab & "6월"
            strColName2 = strColName2 & ControlChars.Tab & "7월"
            strColName2 = strColName2 & ControlChars.Tab & "8월"
            strColName2 = strColName2 & ControlChars.Tab & "9월"
            strColName2 = strColName2 & ControlChars.Tab & "10월"
            strColName2 = strColName2 & ControlChars.Tab & "11월"
            strColName2 = strColName2 & ControlChars.Tab & "12월"
            strColName2 = strColName2 & ControlChars.Tab & "계"

            With Me.grd_3

                Dim i As Integer

                .AddItem(strColName2)

                .FixedRows = 3
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly

                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next

                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next

            End With


            '-- 컬럼 고정 시키기
            grd_3.ExplorerBar = 1
            grd_3.FrozenCols = 3
        End Sub
#Region "포스트잇 출력화면 개발"
        Private Sub btnPlanningTeamPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanningTeamPost.Click
            Dim oExcel As Object
            Dim oBook As Object
            Dim oSheet As Object

            Dim ResultDataSet As DataSet = TableListRequest(1)

            If ResultDataSet Is Nothing Then Exit Sub

            '조회된 데이터가 없으면 나감
            If ResultDataSet.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("선택한 건의 결과 데이타가 없습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Try
                '파일복사
                If Not System.IO.Directory.Exists("C:\MH_EXCEL\") Then
                    System.IO.Directory.CreateDirectory("C:\MH_EXCEL\")
                End If

                'Start a new workbook in Excel
                oExcel = CreateObject("Excel.Application") '엑셀 정의
                oExcel.DisplayAlerts = False

                oBook = oExcel.Workbooks.Open("http://simsapp.munhwa.com/sims_dll/excel/PNE601.xlsx") '엑셀 양식지 열기

                oSheet = oBook.Sheets("default") '1번 워크시트 열기

                '1. 데이터 넣기
                Dim xlData(ResultDataSet.Tables(0).Rows.Count, ResultDataSet.Tables(0).Columns.Count) As Object

                For i As Integer = 0 To ResultDataSet.Tables(0).Rows.Count - 1 '행 인덱스
                    For j As Integer = 0 To ResultDataSet.Tables(0).Columns.Count - 3
                        xlData(i, j) = ResultDataSet.Tables(0).Rows(i).Item(j)
                    Next
                Next

                Dim startCell As Object = oSheet.Cells(1, 1)
                Dim endCell As Object = oSheet.Cells(ResultDataSet.Tables(0).Rows.Count + 1, ResultDataSet.Tables(0).Columns.Count)
                Dim writeRange As Object = oSheet.Range(startCell, endCell)

                writeRange.Value2 = xlData

                '2. 서식 지정
                For i As Integer = 0 To ResultDataSet.Tables(0).Rows.Count - 1 '행 인덱스

                    If Strings.Left(ResultDataSet.Tables(0).Rows(i).Item(4).ToString, 1) = "-" Then '신규/재접수 타이틀
                        oSheet.Range("A" & i + 1 & ":D" & i + 1).Merge()
                        oSheet.Range("A" & i + 1).Font.Bold() = True
                        oSheet.Range("A" & i + 1).Font.Underline() = True
                        oSheet.Range("A" & i + 1).Font.Size() = 9

                    ElseIf Strings.Right(ResultDataSet.Tables(0).Rows(i).Item(4).ToString, 1) = "1" Then '부서 타이틀
                        oSheet.Range("A" & i + 1 & ":C" & i + 1).Font.Bold = True
                        oSheet.Range("A" & i + 1 & ":C" & i + 1).HorizontalAlignment = -4108
                        oSheet.Range("B" & i + 1).Font.Underline = True

                        oSheet.Range("A" & i + 1 & ":B" & i + 1).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray) '세부부수
                    ElseIf Strings.Right(ResultDataSet.Tables(0).Rows(i).Item(4).ToString, 1) = "2" Then
                        oSheet.Range("A" & i + 1 & ":D" & i + 1).Merge()
                    End If
                Next

                '글자수 넘으면 밑으로 내림
                Dim blank As Long = 2
                Dim idx As Integer = 5

                'While (1)

                '    '종료시점 설정
                '    If (oSheet.Range("A" & idx).Value Is Nothing) Then
                '        blank = blank - 1

                '        If (blank = 0) Then
                '            Exit While
                '        Else
                '            idx = idx + 1
                '            Continue While
                '        End If
                '    End If

                '    If oSheet.Range("A" & idx).Value.Substring(1, 1) = "-" And oSheet.Range("A" & idx).Value.Length > 22 Then
                '        Dim splitChar(7) As String
                '        Dim sumLength As Integer = 0

                '        splitChar = Split(oSheet.Range("A" & idx).Value, Chr(32))

                '        For i As Integer = 0 To splitChar.Length - 1
                '            sumLength = sumLength + splitChar(i).Length

                '            If splitChar(i) = "(협찬" Or splitChar(i) = "(광고" Then

                '                oSheet.Rows(idx).Copy()
                '                oSheet.Rows(idx).Insert()

                '                Dim row_1 As String = ""
                '                Dim row_2 As String = "   "

                '                For j As Integer = 0 To i - 1
                '                    row_1 = row_1 & splitChar(j) & Chr(32)
                '                Next
                '                For j As Integer = i To splitChar.Length - 1
                '                    row_2 = row_2 & splitChar(j) & Chr(32)
                '                Next

                '                oSheet.Range("A" & idx).Value = row_1
                '                oSheet.Range("A" & idx + 1).Value = row_2

                '                idx = idx + 1

                '                Exit For

                '            End If

                '        Next
                '    End If

                '    idx = idx + 1

                'End While

                '숫자 두껍게

                blank = 2
                idx = 1

                While (1)

                    '종료시점 설정
                    If (oSheet.Range("A" & idx).Value Is Nothing) Then
                        blank = blank - 1

                        If (blank = 0) Then
                            Exit While
                        Else
                            idx = idx + 1
                            Continue While
                        End If
                    End If

                    If oSheet.Range("A" & idx).Value.Substring(1, 1) = "-" Then
                        Dim numLength As Integer = 0
                        Dim splitChar(7) As String

                        splitChar = Split(oSheet.Range("A" & idx).Value, Chr(32))

                        If splitChar.Length > 3 Then
                            If Strings.Left(splitChar(3), 1) <> "(" Then
                                numLength = splitChar(3).Length

                                oSheet.Range("A" & idx).Characters(splitChar(1).Length + splitChar(2).Length + 4, numLength).Font.Bold = True
                            End If
                        End If
                    End If

                    idx = idx + 1

                End While

                blank = 2
                idx = 1

                '종료 조건
                Do While (1)

                    If oSheet.Range("A" & idx).Value = "" Then
                        blank = blank - 1

                        If blank = 0 Then
                            Exit Do
                        Else
                            idx = idx + 1
                        End If

                    End If

                    '글자 나누기
                    If Mid(oSheet.Range("A" & idx).Value, 2, 1) = "-" And Encoding.Default.GetByteCount(oSheet.Range("A" & idx).Value) > 38 Then
                        Dim splitChar()
                        Dim sumLength As Integer
                        Dim i, j As Integer

                        sumLength = 0

                        splitChar = Split(oSheet.Range("A" & idx).Value, " ")

                        For i = 0 To UBound(splitChar)
                            sumLength = sumLength + UBound(splitChar) + 1

                            If splitChar(i) = "(협찬" Or splitChar(i) = "(광고" Then

                                oSheet.Rows(idx).Copy
                                oSheet.Rows(idx).Insert

                                Dim row_1 As String
                                Dim row_2 As String

                                row_1 = ""
                                row_2 = "   "

                                For j = 0 To i - 1
                                    row_1 = row_1 & splitChar(j) & Chr(32)
                                Next

                                For j = i To UBound(splitChar)
                                    row_2 = row_2 & splitChar(j) & Chr(32)
                                Next

                                oSheet.Range("A" & idx).Value = row_1
                                oSheet.Range("A" & idx + 1).Value = row_2
                                Dim numLength As Integer = Len(splitChar(3))

                                oSheet.Range("A" & idx).Characters(Len(splitChar(1)) + Len(splitChar(2)) + 4, numLength).Font.Bold = True

                                idx = idx + 1

                                Exit For

                            End If


                        Next


                    End If

                    idx = idx + 1

                Loop




                '파일 저장
                Dim strFileFullPath As String = Path.Combine(Me.txtPath.Text, "Postit_" & Me.dtpExpandDt.TextValue & ".xlsx") '파일 생성 경로

                '존재하는 파일은 삭제할지 여부를 묻고 파일을 생성한다.
                If File.Exists(strFileFullPath) = True Then
                    If MessageBox.Show("기존에 생성된 파일이 존재합니다." + vbCrLf + "삭제하고 다시 생성하시겠습니까?", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        File.Delete(strFileFullPath)
                        oBook.SaveAs(strFileFullPath, 51)
                    Else
                        oBook.SaveAs(strFileFullPath, 51)
                    End If
                Else
                    '디렉토리가 존재하지 않는다면 생성한다. 
                    If Directory.Exists(Me.txtPath.Text) = False Then
                        Directory.CreateDirectory(Me.txtPath.Text)
                        oBook.SaveAs(strFileFullPath, 51)
                    Else
                        oBook.SaveAs(strFileFullPath, 51)
                    End If
                End If

                oExcel.Visible = True
                My.Computer.Clipboard.Clear()

            Catch ex As Exception
                Throw ex

                oExcel.Visible = True
                My.Computer.Clipboard.Clear()
            End Try
        End Sub
#End Region

#Region "Stored Procesure 불러오기"

        Public Function TableListRequest(ByVal Gubn As Integer, Optional ByVal AprocessMessage As Boolean = True) As DataSet

            Dim reciveDataSet As DataSet = New DataSet()

            GmainsqlParameters = Nothing
            If Gubn = 1 Then
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AExpandDt", Me.dtpExpandDt.TextValue)
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE601_C_R", False, True, GmainsqlParameters)
            ElseIf Gubn = 2 Then
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AExpandDt", Me.dtpExpandDt.TextValue)
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE601_2_C_R", False, True, GmainsqlParameters)
            ElseIf Gubn = 3 Then
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AExpandDt", Me.dtpExpandDt.TextValue)
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE601_3_C_R", False, True, GmainsqlParameters)

            End If

            TableListRequest = reciveDataSet

        End Function

#End Region

#Region "화면 스필릿1"
        ''' <summary>
        ''' ' 화면 스플릿 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>

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
            Dim SizeAll As Integer = grd_1.Height + grd_2.Height
            'Dim pPBox1 As Point = New Point(picCriteria_3.Location.X, picBar2.Location.Y + picCriteria_3.Location.Y - picBar.Location.Y)

            'Dim plblTitle2 As Point = New Point(lblTitle2.Location.X, picBar2.Location.Y + lblTitle2.Location.Y - picBar.Location.Y)
            'Dim plblBillPeriodCd As Point = New Point(lblBillPeriodCd.Location.X, picBar2.Location.Y + lblBillPeriodCd.Location.Y - picBar.Location.Y)
            'Dim pcboBillPeriodCd As Point = New Point(cboBillPeriodCd.Location.X, picBar2.Location.Y + cboBillPeriodCd.Location.Y - picBar.Location.Y)
            'Dim pbtnReqSale As Point = New Point(btnReqSale.Location.X, picBar2.Location.Y + btnReqSale.Location.Y - picBar.Location.Y)
            'Dim pbtnRowAdd As Point = New Point(btnRowAdd.Location.X, picBar2.Location.Y + btnRowAdd.Location.Y - picBar.Location.Y)

            'Dim pPBox2 As Point = New Point(PictureBox2.Location.X, picBar2.Location.Y + PictureBox2.Location.Y - picBar.Location.Y)
            Dim pGrd2 As Point = New Point(grd_2.Location.X, picBar2.Location.Y + grd_2.Location.Y - picBar.Location.Y)
            '' PictureBox1, PictureBox2
            picBar2.Visible = False
            If pBar.Y >= grd_1.Location.Y + 20 And pBar.Y + 20 <= grd_3.Location.Y Then
                picBar.Location = pBar
                ''grd_1.Width = 5
                'picCriteria_3.Location = pPBox1
                'lblTitle2.Location = plblTitle2
                'lblBillPeriodCd.Location = plblBillPeriodCd
                'cboBillPeriodCd.Location = pcboBillPeriodCd
                'btnReqSale.Location = pbtnReqSale
                'btnRowAdd.Location = pbtnRowAdd

                'PictureBox2.Location = pPBox2
                grd_2.Location = pGrd2

                Dim sGrd1 As Size = New Size(picBar.Width, picBar.Location.Y - grd_1.Location.Y)
                grd_1.Size = sGrd1
                Dim sGrd2 As Size = New Size(grd_1.Width, SizeAll - grd_1.Height)
                grd_2.Size = sGrd2
            End If
        End Sub

        Private Sub picBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseMove
            Dim p As Point = New Point(picBar.Location.X, picBar.Location.Y + e.Y)
            picBar2.Location = p
        End Sub
#End Region

#Region "화면 스필릿2"
        ''' <summary>
        ''' ' 화면 스플릿 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>

        Private Sub picBar3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBar3.MouseHover
            Me.picBar3.BackColor = Color.DarkGray
        End Sub

        Private Sub picBar3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBar3.MouseLeave
            Me.picBar3.BackColor = Color.WhiteSmoke
        End Sub

        Private Sub picBar3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar3.MouseDown
            picBar4.Visible = True
        End Sub

        Private Sub picBar3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar3.MouseUp
            Dim pBar3 As Point = New Point(picBar4.Location.X, picBar4.Location.Y)
            'Dim pPBox1 As Point = New Point(picCriteria_3.Location.X, picBar4.Location.Y + picCriteria_3.Location.Y - picBar3.Location.Y)

            'Dim plblTitle2 As Point = New Point(lblTitle2.Location.X, picBar4.Location.Y + lblTitle2.Location.Y - picBar3.Location.Y)
            'Dim plblBillPeriodCd As Point = New Point(lblBillPeriodCd.Location.X, picBar4.Location.Y + lblBillPeriodCd.Location.Y - picBar3.Location.Y)
            'Dim pcboBillPeriodCd As Point = New Point(cboBillPeriodCd.Location.X, picBar4.Location.Y + cboBillPeriodCd.Location.Y - picBar3.Location.Y)
            'Dim pbtnReqSale As Point = New Point(btnReqSale.Location.X, picBar4.Location.Y + btnReqSale.Location.Y - picBar3.Location.Y)
            'Dim pbtnRowAdd As Point = New Point(btnRowAdd.Location.X, picBar4.Location.Y + btnRowAdd.Location.Y - picBar3.Location.Y)

            'Dim pPBox2 As Point = New Point(PictureBox2.Location.X, picBar4.Location.Y + PictureBox2.Location.Y - picBar3.Location.Y)
            Dim pGrd3 As Point = New Point(grd_3.Location.X, picBar4.Location.Y + grd_3.Location.Y - picBar3.Location.Y)
            '' PictureBox1, PictureBox2
            picBar4.Visible = False
            If pBar3.Y >= grd_2.Location.Y + 20 And pBar3.Y + 20 <= Me.Height Then
                picBar3.Location = pBar3
                ''grd_3.Width = 5
                'picCriteria_3.Location = pPBox1
                'lblTitle2.Location = plblTitle2
                'lblBillPeriodCd.Location = plblBillPeriodCd
                'cboBillPeriodCd.Location = pcboBillPeriodCd
                'btnReqSale.Location = pbtnReqSale
                'btnRowAdd.Location = pbtnRowAdd

                'PictureBox2.Location = pPBox2
                grd_3.Location = pGrd3

                Dim sGrd2 As Size = New Size(picBar3.Width, picBar3.Location.Y - grd_2.Location.Y)
                grd_2.Size = sGrd2
                Dim sGrd3 As Size = New Size(grd_3.Width, Me.Height - grd_3.Location.Y - 5)
                grd_3.Size = sGrd3
            End If
        End Sub

        Private Sub picBar3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar3.MouseMove
            Dim p As Point = New Point(picBar3.Location.X, picBar3.Location.Y + e.Y)
            picBar4.Location = p
        End Sub
#End Region


#Region "기초자료 불러오기"
        Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AExpandDt", Me.dtpExpandDt.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE601_R_2", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing

                With Me.grd_1
                    If .Rows > 1 Then
                        For inti As Integer = .FixedRows To .Rows - 1 Step 1
                            .set_TextMatrix(inti, 0, "신규")
                            .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
                        Next inti
                    End If
                End With
            End With

            SetSubTotal()
        End Sub
#End Region

#Region "기획팀 집계표"
        Private Sub btnPlanningTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanningTeam.Click
            Dim oExcel As Object
            Dim oBook As Object
            Dim oSheet As Object

            Dim ResultDataSet As DataSet = TableListRequest(2)

            If ResultDataSet Is Nothing Then Exit Sub

            '조회된 데이터가 없으면 나감
            If ResultDataSet.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("선택한 건의 결과 데이타가 없습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Try
                'Start a new workbook in Excel
                oExcel = CreateObject("Excel.Application") '엑셀 정의
                oExcel.DisplayAlerts = False

                oBook = oExcel.Workbooks.Open("http://simsapp.munhwa.com/sims_dll/excel/PNE601_2_new.xlsx") '엑셀 양식지 열기

                oSheet = oBook.Sheets("default") '1번 워크시트 열기

                Dim xlData(ResultDataSet.Tables(0).Rows.Count, ResultDataSet.Tables(0).Columns.Count) As Object

                For i As Integer = 0 To ResultDataSet.Tables(0).Rows.Count - 1
                    For j As Integer = 0 To ResultDataSet.Tables(0).Columns.Count - 1
                        xlData(i, j) = ResultDataSet.Tables(0).Rows(i).Item(j)
                    Next
                Next

                Dim startCell As Object = oSheet.Cells(7, 3)
                Dim endCell As Object = oSheet.Cells(ResultDataSet.Tables(0).Rows.Count + 6, ResultDataSet.Tables(0).Columns.Count + 2)
                Dim writeRange As Object = oSheet.Range(startCell, endCell)

                writeRange.Value2 = xlData


                '재접수 합계 주간
                Dim xlData2(ResultDataSet.Tables(1).Rows.Count, ResultDataSet.Tables(1).Columns.Count) As Object

                For i As Integer = 0 To ResultDataSet.Tables(1).Rows.Count - 1
                    For j As Integer = 0 To ResultDataSet.Tables(1).Columns.Count - 1
                        xlData2(i, j) = ResultDataSet.Tables(1).Rows(i).Item(j)
                    Next
                Next

                Dim startCell2 As Object = oSheet.Cells(32, 29)
                Dim endCell2 As Object = oSheet.Cells(ResultDataSet.Tables(1).Rows.Count + 31, ResultDataSet.Tables(1).Columns.Count + 28)
                Dim writeRange2 As Object = oSheet.Range(startCell2, endCell2)

                writeRange2.Value2 = xlData2

                '타이틀 셋팅
                oSheet.Range("A2") = ResultDataSet.Tables(2).Rows(0).Item("Strapline").ToString
                'oSheet.Range("C4") = ResultDataSet.Tables(2).Rows(0).Item("LastYearExpTitle").ToString
                oSheet.Range("C4") = ResultDataSet.Tables(2).Rows(0).Item("AllExpTitle").ToString
                oSheet.Range("P4") = ResultDataSet.Tables(2).Rows(0).Item("ReExpTitle").ToString
                oSheet.Range("AC4") = ResultDataSet.Tables(2).Rows(0).Item("WeekExpTitle").ToString
                oSheet.Range("AI4") = ResultDataSet.Tables(2).Rows(0).Item("NewExpTitle").ToString

                oSheet.Range("AD6") = ResultDataSet.Tables(2).Rows(0).Item("MonTitle").ToString
                oSheet.Range("AE6") = ResultDataSet.Tables(2).Rows(0).Item("TuesTitle").ToString
                oSheet.Range("AF6") = ResultDataSet.Tables(2).Rows(0).Item("WedTitle").ToString
                oSheet.Range("AG6") = ResultDataSet.Tables(2).Rows(0).Item("ThurTitle").ToString
                oSheet.Range("AH6") = ResultDataSet.Tables(2).Rows(0).Item("FriTitle").ToString

                oSheet.Range("AC3") = ResultDataSet.Tables(2).Rows(0).Item("DateTitle").ToString

                '숨김셀 지정
                If Me.dtpExpandDt.TextValue.Substring(4, 2) = "01" Then
                    oSheet.Columns("F:N").Hidden() = True
                    oSheet.Columns("S:AA").Hidden() = True
                    oSheet.Columns("AL:AT").Hidden() = True
                    oSheet.Range("C31").Font.Bold() = True
                    oSheet.Range("P31").Font.Bold() = True
                    oSheet.Range("AI31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "02" Then
                    oSheet.Columns("F:N").Hidden() = True
                    oSheet.Columns("S:AA").Hidden() = True
                    oSheet.Columns("AL:AT").Hidden() = True
                    oSheet.Range("D31").Font.Bold() = True
                    oSheet.Range("J31").Font.Bold() = True
                    oSheet.Range("AJ31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "03" Then
                    oSheet.Columns("F:N").Hidden() = True
                    oSheet.Columns("S:AA").Hidden() = True
                    oSheet.Columns("AL:AT").Hidden() = True
                    oSheet.Range("E31").Font.Bold() = True
                    oSheet.Range("R31").Font.Bold() = True
                    oSheet.Range("AK31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "04" Then
                    oSheet.Columns("C:C").Hidden() = True
                    oSheet.Columns("G:N").Hidden() = True
                    oSheet.Columns("P:P").Hidden() = True
                    oSheet.Columns("T:AA").Hidden() = True
                    oSheet.Columns("AI:AI").Hidden() = True
                    oSheet.Columns("AM:AT").Hidden() = True
                    oSheet.Range("F31").Font.Bold() = True
                    oSheet.Range("S31").Font.Bold() = True
                    oSheet.Range("AL31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "05" Then
                    oSheet.Columns("C:D").Hidden() = True
                    oSheet.Columns("H:N").Hidden() = True
                    oSheet.Columns("P:Q").Hidden() = True
                    oSheet.Columns("U:AA").Hidden() = True
                    oSheet.Columns("AI:AJ").Hidden() = True
                    oSheet.Columns("AN:AT").Hidden() = True
                    oSheet.Range("G31").Font.Bold() = True
                    oSheet.Range("T31").Font.Bold() = True
                    oSheet.Range("AM31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "06" Then
                    oSheet.Columns("C:E").Hidden() = True
                    oSheet.Columns("I:N").Hidden() = True
                    oSheet.Columns("P:R").Hidden() = True
                    oSheet.Columns("V:AA").Hidden() = True
                    oSheet.Columns("AI:AK").Hidden() = True
                    oSheet.Columns("AO:AT").Hidden() = True
                    oSheet.Range("H31").Font.Bold() = True
                    oSheet.Range("U31").Font.Bold() = True
                    oSheet.Range("AN31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "07" Then
                    oSheet.Columns("C:F").Hidden() = True
                    oSheet.Columns("J:N").Hidden() = True
                    oSheet.Columns("P:S").Hidden() = True
                    oSheet.Columns("W:AA").Hidden() = True
                    oSheet.Columns("AI:AL").Hidden() = True
                    oSheet.Columns("AP:AT").Hidden() = True
                    oSheet.Range("I31").Font.Bold() = True
                    oSheet.Range("V31").Font.Bold() = True
                    oSheet.Range("AO31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "08" Then
                    oSheet.Columns("C:G").Hidden() = True
                    oSheet.Columns("K:N").Hidden() = True
                    oSheet.Columns("P:T").Hidden() = True
                    oSheet.Columns("X:AA").Hidden() = True
                    oSheet.Columns("AI:AM").Hidden() = True
                    oSheet.Columns("AQ:AT").Hidden() = True
                    oSheet.Range("J31").Font.Bold() = True
                    oSheet.Range("W31").Font.Bold() = True
                    oSheet.Range("AP31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "09" Then
                    oSheet.Columns("C:H").Hidden() = True
                    oSheet.Columns("L:N").Hidden() = True
                    oSheet.Columns("P:U").Hidden() = True
                    oSheet.Columns("Y:AA").Hidden() = True
                    oSheet.Columns("AI:AN").Hidden() = True
                    oSheet.Columns("AR:AT").Hidden() = True
                    oSheet.Range("K31").Font.Bold() = True
                    oSheet.Range("X31").Font.Bold() = True
                    oSheet.Range("AQ31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "10" Then
                    oSheet.Columns("C:I").Hidden() = True
                    oSheet.Columns("M:N").Hidden() = True
                    oSheet.Columns("P:V").Hidden() = True
                    oSheet.Columns("Z:AA").Hidden() = True
                    oSheet.Columns("AI:AO").Hidden() = True
                    oSheet.Columns("AS:AT").Hidden() = True
                    oSheet.Range("L31").Font.Bold() = True
                    oSheet.Range("Y31").Font.Bold() = True
                    oSheet.Range("AR31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "11" Then
                    oSheet.Columns("C:J").Hidden() = True
                    oSheet.Columns("N:N").Hidden() = True
                    oSheet.Columns("P:W").Hidden() = True
                    oSheet.Columns("AA:AA").Hidden() = True
                    oSheet.Columns("AI:AP").Hidden() = True
                    oSheet.Columns("AT:AT").Hidden() = True
                    oSheet.Range("M31").Font.Bold() = True
                    oSheet.Range("Z31").Font.Bold() = True
                    oSheet.Range("AS31").Font.Bold() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) = "12" Then
                    oSheet.Columns("C:K").Hidden() = True
                    oSheet.Columns("P:X").Hidden() = True
                    oSheet.Columns("AI:AQ").Hidden() = True
                    oSheet.Range("N31").Font.Bold() = True
                    oSheet.Range("AA31").Font.Bold() = True
                    oSheet.Range("AT31").Font.Bold() = True

                End If

                '포스트잇 첨부

                'Dim activeCell As Object = oSheet.Range("AW4")
                'activeCell.Activate()

                'Dim oleObject As IOleObject = oSheet.OleObjects.Add("c:\excel\Postit_20220420.xlsx", False, False)
                Dim rng As Microsoft.Office.Interop.Excel.Range = oSheet.Range("AW4")
                Dim objs As Microsoft.Office.Interop.Excel.OLEObjects = oSheet.OLEObjects()
                Dim obj As Microsoft.Office.Interop.Excel.OLEObject = objs.Add(Filename:=Path.Combine(Me.txtPath.Text, "Postit_" & Me.dtpExpandDt.TextValue & ".xlsx"), Link:=False, DisplayAsIcon:=False, Left:=rng.Left, Top:=rng.Top, Width:=rng.Width)
                obj.Select()


                '파일 저장
                Dim strFileFullPath As String = Path.Combine(Me.txtPath.Text, "Subtotal_" & Me.dtpExpandDt.TextValue & ".xlsx") '파일 생성 경로

                '존재하는 파일은 삭제할지 여부를 묻고 파일을 생성한다.
                If File.Exists(strFileFullPath) = True Then
                    If MessageBox.Show("기존에 생성된 파일이 존재합니다." + vbCrLf + "삭제하고 다시 생성하시겠습니까?", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        File.Delete(strFileFullPath)
                        oBook.SaveAs(strFileFullPath, 51)
                    Else
                        oBook.SaveAs(strFileFullPath, 51)
                    End If
                Else
                    '디렉토리가 존재하지 않는다면 생성한다. 
                    If Directory.Exists(Me.txtPath.Text) = False Then
                        Directory.CreateDirectory(Me.txtPath.Text)
                        oBook.SaveAs(strFileFullPath, 51)
                    Else
                        oBook.SaveAs(strFileFullPath, 51)
                    End If
                End If

                oExcel.Visible = True
                My.Computer.Clipboard.Clear()

            Catch ex As Exception
                Throw ex

                oExcel.Visible = True
                My.Computer.Clipboard.Clear()
            End Try
        End Sub
#End Region

#Region "판매국 집계표"
        Private Sub btnSaleTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaleTeam.Click
            Dim oExcel As Object
            Dim oBook As Object
            Dim oSheet As Object

            Dim ResultDataSet As DataSet = TableListRequest(3)

            If ResultDataSet Is Nothing Then Exit Sub

            '조회된 데이터가 없으면 나감
            If ResultDataSet.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("선택한 건의 결과 데이타가 없습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Try
                'Start a new workbook in Excel
                oExcel = CreateObject("Excel.Application") '엑셀 정의
                oExcel.DisplayAlerts = False

                oBook = oExcel.Workbooks.Open("http://simsapp.munhwa.com/sims_dll/excel/PNE601_3.xlsx") '엑셀 양식지 열기

                oSheet = oBook.Sheets("default") '1번 워크시트 열기

                '전체 데이터 셋팅
                Dim xlData(ResultDataSet.Tables(0).Rows.Count, ResultDataSet.Tables(0).Columns.Count) As Object

                For i As Integer = 0 To ResultDataSet.Tables(0).Rows.Count - 1
                    For j As Integer = 0 To ResultDataSet.Tables(0).Columns.Count - 1
                        xlData(i, j) = ResultDataSet.Tables(0).Rows(i).Item(j)
                    Next
                Next

                Dim startCell As Object = oSheet.Cells(7, 3)
                Dim endCell As Object = oSheet.Cells(ResultDataSet.Tables(0).Rows.Count + 6, ResultDataSet.Tables(0).Columns.Count + 2)
                Dim writeRange As Object = oSheet.Range(startCell, endCell)

                writeRange.Value2 = xlData

                '신규 재접수 합계 월간
                Dim xlData2(ResultDataSet.Tables(1).Rows.Count, ResultDataSet.Tables(1).Columns.Count) As Object

                For i As Integer = 0 To ResultDataSet.Tables(1).Rows.Count - 1
                    For j As Integer = 0 To ResultDataSet.Tables(1).Columns.Count - 1
                        xlData2(i, j) = ResultDataSet.Tables(1).Rows(i).Item(j)
                    Next
                Next

                Dim startCell2 As Object = oSheet.Cells(29, 7)
                Dim endCell2 As Object = oSheet.Cells(ResultDataSet.Tables(1).Rows.Count + 28, ResultDataSet.Tables(1).Columns.Count + 6)
                Dim writeRange2 As Object = oSheet.Range(startCell2, endCell2)

                writeRange2.Value2 = xlData2

                '신규 재접수 합계 주간
                Dim xlData3(ResultDataSet.Tables(2).Rows.Count, ResultDataSet.Tables(2).Columns.Count) As Object

                For i As Integer = 0 To ResultDataSet.Tables(2).Rows.Count - 1
                    For j As Integer = 0 To ResultDataSet.Tables(2).Columns.Count - 1
                        xlData3(i, j) = ResultDataSet.Tables(2).Rows(i).Item(j)
                    Next
                Next

                Dim startCell3 As Object = oSheet.Cells(29, 26)
                Dim endCell3 As Object = oSheet.Cells(ResultDataSet.Tables(2).Rows.Count + 28, ResultDataSet.Tables(2).Columns.Count + 25)
                Dim writeRange3 As Object = oSheet.Range(startCell3, endCell3)

                writeRange3.Value2 = xlData3


                '타이틀 셋팅
                oSheet.Range("A2") = ResultDataSet.Tables(3).Rows(0).Item("Strapline").ToString
                oSheet.Range("D4") = ResultDataSet.Tables(3).Rows(0).Item("LastYearExpTitle").ToString
                oSheet.Range("G4") = ResultDataSet.Tables(3).Rows(0).Item("AllExpFirstHalfTitle").ToString
                oSheet.Range("H4") = ResultDataSet.Tables(3).Rows(0).Item("AllExpFirstHalfTitle").ToString
                oSheet.Range("O4") = ResultDataSet.Tables(3).Rows(0).Item("AllExpSecondHalfTitle").ToString
                oSheet.Range("P4") = ResultDataSet.Tables(3).Rows(0).Item("AllExpSecondHalfTitle").ToString
                oSheet.Range("W4") = ResultDataSet.Tables(3).Rows(0).Item("AllExpTitle").ToString
                oSheet.Range("Z4") = ResultDataSet.Tables(3).Rows(0).Item("WeekExpTitle").ToString

                oSheet.Range("AA5") = ResultDataSet.Tables(3).Rows(0).Item("MonTitle").ToString
                oSheet.Range("AB5") = ResultDataSet.Tables(3).Rows(0).Item("TuesTitle").ToString
                oSheet.Range("AC5") = ResultDataSet.Tables(3).Rows(0).Item("WedTitle").ToString
                oSheet.Range("AD5") = ResultDataSet.Tables(3).Rows(0).Item("ThurTitle").ToString
                oSheet.Range("AE5") = ResultDataSet.Tables(3).Rows(0).Item("FriTitle").ToString

                oSheet.Range("AC3") = ResultDataSet.Tables(3).Rows(0).Item("DateTitle").ToString

                '숨김셀 지정
                If Me.dtpExpandDt.TextValue.Substring(4, 2) >= "01" And Me.dtpExpandDt.TextValue.Substring(4, 2) <= "06" Then
                    oSheet.Columns("P:V").Hidden() = True

                ElseIf Me.dtpExpandDt.TextValue.Substring(4, 2) >= "07" And Me.dtpExpandDt.TextValue.Substring(4, 2) <= "12" Then
                    oSheet.Columns("H:N").Hidden() = True
                End If


                oExcel.Visible = True
                My.Computer.Clipboard.Clear()

            Catch ex As Exception
                Throw ex

                oExcel.Visible = True
                My.Computer.Clipboard.Clear()
            End Try
        End Sub
#End Region

        Private Sub btnSalesReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesReport.Click
            Dim oExcel As Object
            Dim oBook As Object
            Dim oSheet As Object

            Dim ResultDataSet As DataSet = TableListRequest(2)

            If ResultDataSet Is Nothing Then Exit Sub

            '조회된 데이터가 없으면 나감
            If ResultDataSet.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("선택한 건의 결과 데이타가 없습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Try
                'Start a new workbook in Excel
                oExcel = CreateObject("Excel.Application") '엑셀 정의
                oExcel.DisplayAlerts = False

                oBook = oExcel.Workbooks.Open("http://simsapp.munhwa.com/sims_dll/excel/PNE601_4.xlsx") '엑셀 양식지 열기


                oExcel.Visible = True
                My.Computer.Clipboard.Clear()

            Catch ex As Exception
                Throw ex

                oExcel.Visible = True
                My.Computer.Clipboard.Clear()
            End Try
        End Sub

        Private Sub btnSearchDir_Click(sender As Object, e As EventArgs) Handles btnSearchDir.Click
            Me.lblPath.Visible = False

            Me.FolderBrowserDialog1.SelectedPath() = "C:\"
            If FolderBrowserDialog1.ShowDialog <> DialogResult.Cancel Then
                Me.txtPath.Text = FolderBrowserDialog1.SelectedPath()
            End If
        End Sub
    End Class
End Namespace