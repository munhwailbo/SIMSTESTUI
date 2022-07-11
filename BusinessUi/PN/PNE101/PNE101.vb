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
Imports System.ComponentModel
Imports System.Data.SqlClient

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE101
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
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;0;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|접수일자;ExpandDt;85;yyyy-MM-dd;4;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|순번;Orders;0;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;100;;100;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;98;;4;" & "io;n;n;40;확장처 명;CompanyNm"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;149;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|접수;TargetPaperTotNum;37;;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|신규;NewExpPapNum;37;;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|재확장;ReExpPapNum;50;;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|명단없는부수;NoListPapNum;87;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|확정;FixedPaperNum;37;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|투입;SubscribePagerNum;37;#,###;7;" & "o;n;y;5;"         '임시로 숨김 02/17
            gridAttributes = gridAttributes & "|미투입;NoSubscribePagerNum;50;#,###;7;" & "o;n;y;5;"     '임시로 숨김 02/17  
            gridAttributes = gridAttributes & "|명단상태코드;ListStatCd;105;;1;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;87;;1;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|청구유형;BillType;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;93;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기코드;BillPeriodCd;87;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;74;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|구독시작일자;FixedStDt;87;yyyy-MM-dd;4;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;87;yyyy-MM-dd;4;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|지국전달사항;BranchNote;269;;1;" & "io;n;n;200;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;62;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|승인일자;ApprovalDt;62;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|비고;Note;291;;1;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|이전사원확장번호;OldEmployeeExpNum;0;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|;Dummy;70;;4;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ListStatCd;명단상태코드"    '' 2401
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;수금형태코드"   ''2323
            gridCodeNameList = gridCodeNameList & "/BillType;청구유형명"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3


            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;0;;1;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;0;;1;" & "io;n;y;13;"
            gridAttributes = gridAttributes & "|접수일자;ContactDt;85;yyyy-MM-dd;4;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|순번;Orders;48;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;185;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|접수;ContactPaperNum;37;#,##0;4;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|투입;FixedPagerNum;37;#,##0;4;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|전화1;PhoneNum1;99;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰;MobileNum;103;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|독자상태코드;ReaderStateCd;87;;1;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|수금형태코드;CollectionTypeCd;87;;1;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|수금주기코드;BillPeriodCd;87;;1;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|배달처구분코드;DeliveryRegionCd;99;;1;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|배달구분코드;DeliveryDivCd;87;;1;" & "io;n;n;7;"

            gridAttributes = gridAttributes & "|주권유자;TrAdEmployeeNum;80;;c;" & "io;y;n;;사원 명;TrAdEmployeeNm"
            gridAttributes = gridAttributes & "|주권유자;TrAdEmployeeNm;80;;c;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|주권유자;TrAdEmployeeDeptCd;90;;c;" & "io;y;n;;부서 명;TrAdEmployeeDeptNm"
            gridAttributes = gridAttributes & "|주권유자;TrAdEmployeeDeptNm;100;;c;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|권유자;AdEmployeeNum;80;;c;" & "io;y;n;;사원 명;AdEmployeeNm"
            gridAttributes = gridAttributes & "|권유자;AdEmployeeNm;80;;c;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|권유자;AdEmployeeDeptCd;90;;c;" & "io;y;n;;부서 명;AdEmployeeDeptNm"
            gridAttributes = gridAttributes & "|권유자;AdEmployeeDeptNm;100;;c;" & "o;y;n;;"

            gridAttributes = gridAttributes & "|우편번호;OldPostNum;0;;4;" & "io;n;y;10;우편번호;OldAddr1"
            gridAttributes = gridAttributes & "|주소;OldAddr1;0;;1;" & "io;n;y;50;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;0;;1;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;0;;4;" & "io;n;y;7;지국코드;DeliveryBranchNm "
            gridAttributes = gridAttributes & "|투입지국명;DeliveryBranchNm;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|지국전달사항;BranchNote;0;;1;" & "io;n;y;200;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;0;yyyy-MM-dd;4;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;0;yyyy-MM-dd;4;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|이전접수번호;OldReceiptCd;0;;1;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|이전독자번호;OldSubscribeCd;0;;1;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|;Dumi;30;;l;" & "o;n;n;30;"

            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            gridCodeNameList = gridCodeNameList & "/CollectionTypeCd;수금형태코드"
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"

            grd_2.Initialize(gridAttributes, gridCodeNameList)

            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "선택"
            strColName2 = strColName2 & ControlChars.Tab & "사원확장번호"
            strColName2 = strColName2 & ControlChars.Tab & "접수독자코드"
            strColName2 = strColName2 & ControlChars.Tab & "접수일자"
            strColName2 = strColName2 & ControlChars.Tab & "순번"
            strColName2 = strColName2 & ControlChars.Tab & "독자명"
            strColName2 = strColName2 & ControlChars.Tab & "접수"
            strColName2 = strColName2 & ControlChars.Tab & "투입"
            strColName2 = strColName2 & ControlChars.Tab & "전화1"
            strColName2 = strColName2 & ControlChars.Tab & "핸드폰"
            strColName2 = strColName2 & ControlChars.Tab & "독자상태코드"
            strColName2 = strColName2 & ControlChars.Tab & "수금형태코드"
            strColName2 = strColName2 & ControlChars.Tab & "수금주기코드"
            strColName2 = strColName2 & ControlChars.Tab & "배달처구분코드"
            strColName2 = strColName2 & ControlChars.Tab & "배달구분코드"

            strColName2 = strColName2 & ControlChars.Tab & "사번"
            strColName2 = strColName2 & ControlChars.Tab & "이름"
            strColName2 = strColName2 & ControlChars.Tab & "부서코드"
            strColName2 = strColName2 & ControlChars.Tab & "부서명"

            strColName2 = strColName2 & ControlChars.Tab & "사번"
            strColName2 = strColName2 & ControlChars.Tab & "이름"
            strColName2 = strColName2 & ControlChars.Tab & "부서코드"
            strColName2 = strColName2 & ControlChars.Tab & "부서명"

            strColName2 = strColName2 & ControlChars.Tab & "우편번호"
            strColName2 = strColName2 & ControlChars.Tab & "주소"
            strColName2 = strColName2 & ControlChars.Tab & "상세주소"
            strColName2 = strColName2 & ControlChars.Tab & "투입지국코드"
            strColName2 = strColName2 & ControlChars.Tab & "투입지국명"

            strColName2 = strColName2 & ControlChars.Tab & "지국전달사항"
            strColName2 = strColName2 & ControlChars.Tab & "투입일자"
            strColName2 = strColName2 & ControlChars.Tab & "구독만료일자"

            strColName2 = strColName2 & ControlChars.Tab & "이전접수번호"
            strColName2 = strColName2 & ControlChars.Tab & "이전독자번호"

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



            Me.grd_2.ExplorerBar = 3

            Me.dtpFromExpand.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            Me.dtpToExpand.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")


        End Sub

        Private Sub PNE101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
            RequestData2()
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            SaveData2()
        End Sub

        Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
            DeleteData2()
        End Sub
        Private Sub BtnNewLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLine.Click

            If grd_1.Rows > 1 Then
                Me.grd_2.AddRow()
                AddReciptReader(grd_2.Rows)
            End If
        End Sub

        Private Sub AddReciptReader(ByVal row As Integer)

            If grd_1.Rows > 1 Then
                grd_2.SetData(row - 1, "EmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))
                grd_2.SetData(row - 1, "ReceiptCd", Me.grd_1.GetCurrentRowCellValue("ExpandDt")) '' 접수독자번호
                grd_2.SetData(row - 1, "ContactDt", Me.grd_1.GetCurrentRowCellValue("ExpandDt")) '' 접수일자
                grd_2.SetData(row - 1, "ContactPaperNum", 1) '' 접수부수
                grd_2.SetData(row - 1, "FixedPagerNum", 1) '' 투입부수

                ComboValueSetting(grd_2, row - 1, "ReaderStateCd", "1") ' "|독자상태코드;ReaderStateCd;7;;c;" & "io;n;n;7;"     '독자상태코드"
                ComboValueSetting(grd_2, row - 1, "CollectionTypeCd", Me.grd_1.GetCurrentRowCellValue("CollectionDivCd")) '"|수금형태코드;CollectionTypeCd;7;;c;" & "io;n;n;7;"     '수금구분코드"
                ComboValueSetting(grd_2, row - 1, "BillPeriodCd", "1") ' "|수금주기코드;BillPeriodCd;7;;c;" & "io;n;n;7;"     '수금주기코드"
                ComboValueSetting(grd_2, row - 1, "DeliveryRegionCd", "E") ' "|배달처구분코드;DeliveryRegionCd;7;;c;" & "io;n;n;7;"     '배달처구분코드"
                ComboValueSetting(grd_2, row - 1, "DeliveryDivCd", "1") ' "|배달구분코드;DeliveryDivCd;7;;c;" & "io;n;n;7;"     '배달구분코드"

                grd_2.SetData(row - 1, "BranchNote", Me.grd_1.GetCurrentRowCellValue("BranchNote")) '' BranchNote 지국전달사항
                grd_2.SetData(row - 1, "FixedStDt", Me.grd_1.GetCurrentRowCellValue("FixedStDt")) '' FixedStDt 투입시작일자
                grd_2.SetData(row - 1, "FixedEdDt", Me.grd_1.GetCurrentRowCellValue("FixedEdDt"))  '' FixedEdDt 투입종료일자

                CheckPaperNum()
            End If

        End Sub

        '' 확장 접수부수와 투입부수가 넘어서는지 확인한다.
        Private Sub CheckPaperNum()

            If grd_1.Rows > 1 Then
                Me.TxtContactPaperNumTot.Text = Me.grd_1.GetCurrentRowCellValue("TargetPaperTotNum") '' 접수부수
                Dim FixPagNum As Integer = 0
                For i As Integer = 2 To grd_2.Rows - 1
                    FixPagNum = FixPagNum + Convert.ToInt32(Me.grd_2.GetData(i, "FixedPagerNum"))
                Next
                Me.TxtFixedPagerNum.Text = FixPagNum

                If Convert.ToInt32(TxtContactPaperNumTot.Text) < Convert.ToInt32(TxtFixedPagerNum.Text) Then
                    MsgBox("투입부수 합계가 확장 접수부수 보다 많습니다.")

                End If
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
        

        ''' <summary>
        ''' 함수명 : btnOpenExcel_Click 
        ''' 기  능 : import할 엑셀 파일 열기
        ''' 작성자 : 강동훈
        ''' 작성일 : 2007-08-27
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnOpenExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenExcel.Click

            Dim strFileName As String = ""      '파일 명
           
            With Me.dlgOpenFile
                .CheckPathExists = True
                .Multiselect = False
                .Title = "업로드할 엑셀 파일을 선택하세요"
                .DefaultExt = "xls"
                .Filter = "엑셀 파일(*.xls;*.csv)|*.xls;*.csv"
                .InitialDirectory = "C:\"
                .FileName = ""
                .ShowDialog()

                If .FileName = "" Then
                    Exit Sub
                End If

                ExcelReader(.FileName)

            End With

        End Sub

        ''엑셀
        Private Sub ExcelReader(ByVal strFileName As String)

            Dim intExcelRow As Integer = 0      '엑셀 행 번호
            Dim intGridRow As Integer = 0       '그리드 행 번호
            Dim intRowCnt As Integer = 0        '전체 행 수


            Dim excTemp As Object = CreateObject("Excel.Application") '엑셀 작업 개체 변수
            Dim wrbTemp As Object = Nothing '
            Dim shtTemp As Object = Nothing '실 작업 sheet 개체

            '파일 에러 체크
            Try
                wrbTemp = excTemp.Workbooks.Open(strFileName)
            Catch ex As Exception
                shtTemp = Nothing
                wrbTemp = Nothing
                excTemp = Nothing
                MessageBox.Show(ex.Message, "엑셀 파일 열기 에러", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            '첫번 째 시트가 로드 됨
            shtTemp = wrbTemp.Sheets(1)

            '첫 행은 제목 표시 행
            For intExcelRow = 1 To 1000 Step 1
                If Trim(shtTemp.Cells(intExcelRow, 1).Value) = "" Then
                    intRowCnt = intExcelRow - 2
                    Exit For
                End If
            Next intExcelRow

            '엑셀 데이터 체크
            If intExcelRow <= 0 Then
                shtTemp = Nothing
                wrbTemp = Nothing
                excTemp = Nothing
                MessageBox.Show("엑셀 첫번째 쉬트에 데이터가 존재하지 않습니다.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor()
            '그리드에 쓰기
            With Me.grd_2
                .Rows = .FixedRows
                '' 독자명	접수부수	투입부수	
                '' 전화번호1	핸드폰번호	
                '' 독자상태코드	수금형태코드	수금주기코드  배달처구분코드	
                '' 지국전달사항	투입일자	구독만료일자

                For intGridRow = 1 To intRowCnt
                    .AddRow()
                    .SetData(intGridRow + 1, 0, intGridRow)
                    .SetData(intGridRow + 1, .get_ColIndex("EmployeeExpNum"), Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))     '사원확장번호
                    .SetData(intGridRow + 1, .get_ColIndex("ReceiptCd"), "")    '접수코드
                    .SetData(intGridRow + 1, .get_ColIndex("ContactDt"), Me.grd_1.GetCurrentRowCellValue("ExpandDt"))    '접수일자
                    .SetData(intGridRow + 1, .get_ColIndex("Orders"), intGridRow.ToString)    '순번

                    .SetData(intGridRow + 1, .get_ColIndex("SubscriberNm"), shtTemp.Cells(intGridRow + 1, 1).Value)     '독자명
                    .SetData(intGridRow + 1, .get_ColIndex("ContactPaperNum"), shtTemp.Cells(intGridRow + 1, 2).Value)     '접수부수
                    .SetData(intGridRow + 1, .get_ColIndex("FixedPagerNum"), shtTemp.Cells(intGridRow + 1, 3).Value)     '투입부수
                    .SetData(intGridRow + 1, .get_ColIndex("PhoneNum1"), shtTemp.Cells(intGridRow + 1, 4).Value)     '전화번호1
                    .SetData(intGridRow + 1, .get_ColIndex("MobileNum"), shtTemp.Cells(intGridRow + 1, 5).Value)     '핸드폰번호

                    ComboValueSetting(grd_2, intGridRow + 1, "ReaderStateCd", shtTemp.Cells(intGridRow + 1, 6).Value)     '독자상태코드"
                    ComboValueSetting(grd_2, intGridRow + 1, "CollectionTypeCd", Me.grd_1.GetCurrentRowCellValue("CollectionDivCd")) '"|수금형태코드;CollectionTypeCd;7;;c;" & "io;n;n;7;"     '수금구분코드"
                    ComboValueSetting(grd_2, intGridRow + 1, "BillPeriodCd", Me.grd_1.GetCurrentRowCellValue("BillPeriodCd")) ' "|수금주기코드;BillPeriodCd;7;;c;" & "io;n;n;7;"     '수금주기코드"
                    ComboValueSetting(grd_2, intGridRow + 1, "DeliveryRegionCd", shtTemp.Cells(intGridRow + 1, 9).Value) ' "|배달처구분코드;DeliveryRegionCd;7;;c;" & "io;n;n;7;"     '배달처구분코드"
                    ComboValueSetting(grd_2, intGridRow + 1, "DeliveryDivCd", shtTemp.Cells(intGridRow + 1, 10).Value) ' "|배달구분코드;DeliveryDivCd;7;;c;" & "io;n;n;7;"     '배달구분코드"

                    .SetData(intGridRow + 1, "BranchNote", Me.grd_1.GetCurrentRowCellValue("BranchNote")) '' BranchNote 지국전달사항
                    .SetData(intGridRow + 1, .get_ColIndex("FixedStDt"), Me.grd_1.GetCurrentRowCellValue("FixedStDt"))     '투입일자
                    .SetData(intGridRow + 1, .get_ColIndex("FixedEdDt"), Me.grd_1.GetCurrentRowCellValue("FixedEdDt"))     '구독만료일자


                    Application.DoEvents()
                Next intGridRow
            End With
            Me.Cursor = Cursors.Default()
            MessageBox.Show("엑셀 업로드가 완료 되었습니다.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            shtTemp = Nothing '실 작업 sheet 개체
            wrbTemp = Nothing '
            'excTemp = Nothing ' '엑셀 작업 개체 변수
            excTemp.Workbooks.Close()
        End Sub


        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            ''Dim CurruntRow As Long

            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("TargetPaperTotNum"), "0")    '|접수부수
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NewExpPapNum"), "0")         '|신규부수
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("ReExpPapNum"), "0")          '|재확장부수
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NoListPapNum"), "0")         '|명단없는부수
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedPaperNum"), "0")        '|확정부수
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("SubscribePagerNum"), "0")    '|투입부수
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NoSubscribePagerNum"), "0")  '|미투입부수
            With grd_1
                If .Rows > 1 Then
                    '' ''CurruntRow = .GetCurrentRowCellValue("")
                    '확정부수 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("NewExpPapNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("ReExpPapNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedPaperNum"), TotalValue.ToString)
                End If
            End With
        End Sub

        '지국 수금일 경우 시작 , 종료 일자 날짜 셋팅
        Private Sub SetDateSetting()

            Dim sdate As Date
            Dim tmpDate As String
            Dim tmpDate2 As String


            tmpDate = grd_1.GetCurrentRowCellValue("ExpandDt") ' 확장접수일
            tmpDate2 = grd_1.GetCurrentRowCellValue("FixedStDt") ' 구독시작일자

            If Len(tmpDate) = 0 Then
                sdate = dtpFromExpand.Text
            Else
                sdate = CDate(VB6.Format(tmpDate, "@@@@-@@-@@"))
                'sdate = CDate(Format(tmpDate.Substring(0, 4) + "-" + tmpDate.Substring(4, 2) + tmpDate.Substring(6, 2), "####-##-##"))
            End If


            If grd_1.GetCurrentRowCellValue("CollectionDivCd") = "2" Then
                If grd_1.get_ColKey(grd_1.CursorCell.c1) = "FixedStDt" Then
                    'Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedStDt"), DateAdd(DateInterval.Day, +1, sdate))
                    Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Year, 1, sdate))))
                ElseIf grd_1.get_ColKey(grd_1.CursorCell.c1) = "CollectionDivCd" Then
                    Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedStDt"), DateAdd(DateInterval.Day, +1, sdate))
                    Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Year, 1, sdate))))
                End If

            End If

                If Len(tmpDate2) = 0 Then Exit Sub

                ''시작일 변경시 종료일 셋팅
                Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Year, 1, CDate(VB6.Format(tmpDate2, "@@@@-@@-@@"))))))

        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.Row)
            SetDateSetting()
        End Sub

        ''' <summary>
        ''' 함수명 : btnEmExReader_Click 
        ''' 기  능 : 화면 Jump!
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnEmExReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmExReader.Click

            '사원확장 권유자 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '사원확장번호
            strCode = Me.dtpFromExpand.TextValue & ";" & Me.dtpToExpand.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum")
            GmainBusinessFunction.SetValue("화면 전환", "PNE102;" & strCode)
            Me.ShowUiControl("PNE102", strCode)

        End Sub

        Private Sub grd_2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_2.DoubleClick

            '사원확장 독자 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '접수독자번호
            strCode = Me.dtpFromExpand.TextValue & ";" & Me.dtpToExpand.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("화면 전환", "PNC102;" & strCode)
            Me.ShowUiControl("PNC102", strCode)

        End Sub

        '' '' 재확장 처리  
        Private Sub brnReExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnReExt.Click
            Dim intRow As Integer = grd_1.Rows - 1
            With grd_1
                For intII As Integer = 2 To intRow
                    If .GetCellCheck(intII, .get_ColIndex("선택")) = CheckEnum.Checked Then
                        .AddRow()
                        .set_TextMatrix(.Rows - 1, 0, "신규")
                        For intJJ As Integer = .get_ColIndex("ExpandDt") To .get_ColIndex("Dummy")
                            .set_TextMatrix(.Rows - 1, intJJ, .get_TextMatrix(intII, intJJ))
                        Next
                        .set_TextMatrix(.Rows - 1, .get_ColIndex("OldEmployeeExpNum"), .get_TextMatrix(intII, .get_ColIndex("EmployeeExpNum")))
                        .SetCellCheck(intII, .get_ColIndex("선택"), CheckEnum.Unchecked)
                    End If
                Next
            End With
        End Sub

        Private Sub btnExecDemand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecDemand.Click

            '사원확장 청구계획 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '사원확장번호
            strCode = Me.dtpFromExpand.TextValue & ";" & Me.dtpToExpand.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum")
            GmainBusinessFunction.SetValue("화면 전환", "PNE421;" & strCode)
            Me.ShowUiControl("PNE421", strCode)

        End Sub

        Private Sub grd_2_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_2.AfterEdit
            Call UpdateSelectedSum()
        End Sub

        Private Sub grd_2_AfterRowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles grd_2.AfterRowColChange
            Call UpdateSelectedSum()
        End Sub

        Private Sub UpdateSelectedSum()
            Dim sumRow As Integer = 0

            With grd_2

                For i As Integer = 2 To grd_2.Rows - 1
                    If .GetCellCheck(i, .get_ColIndex("선택")) = CheckEnum.Checked Then
                        sumRow += .get_TextMatrix(i, .get_ColIndex("ContactPaperNum"))
                    End If
                Next

            End With

            Me.txtSelectedNum.TextValue = sumRow
        End Sub

        Private Sub btnBulkApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBulkApply.Click
            With grd_2
                For i As Integer = 2 To grd_2.Rows - 1
                    If .GetCellCheck(i, .get_ColIndex("선택")) = CheckEnum.Checked Then
                        .set_TextMatrix(i, .get_ColIndex("TrAdEmployeeNum"), Me.popTrAdEmployeeNum.TextValue)
                        .set_TextMatrix(i, .get_ColIndex("TrAdEmployeeNm"), Me.popTrAdEmployeeNum.NameText)
                        .set_TextMatrix(i, .get_ColIndex("TrAdEmployeeDeptCd"), Me.popTrAdEmployeeDeptCd.TextValue)
                        .set_TextMatrix(i, .get_ColIndex("TrAdEmployeeDeptNm"), Me.popTrAdEmployeeDeptCd.NameText)
                        .set_TextMatrix(i, .get_ColIndex("AdEmployeeNum"), Me.popAdEmployeeNum.TextValue)
                        .set_TextMatrix(i, .get_ColIndex("AdEmployeeNm"), Me.popAdEmployeeNum.NameText)
                        .set_TextMatrix(i, .get_ColIndex("AdEmployeeDeptCd"), Me.popAdEmployeeDeptCd.TextValue)
                        .set_TextMatrix(i, .get_ColIndex("AdEmployeeDeptNm"), Me.popAdEmployeeDeptCd.NameText)
                    End If

                    '.SetCellCheck(i, .get_ColIndex("선택"), CheckEnum.Unchecked)
                Next

            End With
        End Sub

        Private Sub grd_1_AfterSelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
            Call RequestData_2()


            '2020.12.04 모니터실 요청으로 업데이트 막음
            'Me.popTrAdEmployeeDeptCd.TextValue = ""
            'Me.popTrAdEmployeeNum.TextValue = ""
            'Me.popAdEmployeeDeptCd.TextValue = ""
            'Me.popAdEmployeeNum.TextValue = ""
        End Sub
    End Class

End Namespace
