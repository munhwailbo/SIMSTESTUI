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

Imports Microsoft.Office.Interop

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE502
        Inherits CommonControls.UiControl

        Private Sub PNE502_BACK_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "폼 초기화"
        ''' <summary>
        ''' 함수명 : Initialize
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.11.19
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            ''If optreceipt.Checked = True Then
            Dim gridAttributes As String = ""

            ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            'gridAttributes = gridAttributes & "a;r;n"

            ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            'gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"

            'gridAttributes = gridAttributes & "|접수일자;ContactDt4;85;yyyy-MM-dd;4;" & "o;n;n;30;"

            'gridAttributes = gridAttributes & "|접수처;CompanyNm;119;;1;" & "o;n;n;30;"

            'gridAttributes = gridAttributes & "|접수자(1);TrAdEmployeeNm;62;;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|접유자명(1);BizEmpNm;1;;4;" & "o;n;n;7;"
            'gridAttributes = gridAttributes & "|접수자(2);AdEmployeeNm;62;;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|접유자명(2);BizEmpNm;1;;4;" & "o;n;n;7;"

            'gridAttributes = gridAttributes & "|독자명;SubscriberNm;191;;1;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|주소;OldAddr1;231;;1;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|상세주소;OldAddr2;232;;1;" & "o;n;n;30;"

            'gridAttributes = gridAttributes & "|접수신규;NewPapNum;62;;7;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|접수재확장;ReExpPapNum;1;74;;7;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|접수계;TargetPaperTotNum;50;;7;" & "o;n;n;30;"

            'gridAttributes = gridAttributes & "|확정신규;NewExpPapNum;1;;7;" & "o;n;n;50;"
            'gridAttributes = gridAttributes & "|확정재확장;ReExpPapNum;1;;7;" & "o;n;n;100;"
            'gridAttributes = gridAttributes & "|확정계;FixedPaperNum;1;;7;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|투입;SubscribePagerNum;1;;7;" & "o;n;n;8;"

            'gridAttributes = gridAttributes & "|지국명;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            'gridAttributes = gridAttributes & "|영업담당;EmployeeNm;62;;4;" & "o;n;n;7;"
            'gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;87;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|청구방법코드;BillTypeCd;87;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;74;;7;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|수금년월;CollectionYYYY;63;yyyy-MM;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|모니터결과;Refuse;1;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|모니터미통과사유;RefuseReasonCd;1;;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|독자상태;ReaderStateCd;74;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|구독상태;SubscribeStateCd;70;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|투입일자;FixedStDt3;85;yyyy-MM-dd;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|구독시작일;FixedStDt1;85;dd;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|구독종료일;FixedEdDt;85;dd;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|서비스기간;ServiceTerm;74;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|중지일자;StopDt;62;yyyy-MM-dd;4;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|중지사유;ReturnCd;1;;1;" & "o;n;n;50;"
            'gridAttributes = gridAttributes & "|판매국작성;SalWtList;1;;1;" & "o;n;n;100;"

            'gridAttributes = gridAttributes & "|확장명;ExpandNm;1;;1;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|투입처;DeliveryChnlNm;128;;1;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|전화1;PhoneNum1;116;;1;" & "o;n;n;10;"

            Me.dtpFixedEdDt.TextValue = ""

            ''grid_1 code combo    
            Dim gridCodeNameList As String = ""

            'Grd_1.Initialize(gridAttributes, gridCodeNameList)
            'Me.Grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|접수일자;ContactDt4;85;yyyy-MM-dd;4;" & "o;n;n;30;"

            gridAttributes = gridAttributes & "|접수자(1);TrAdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수자명(1);TrAdEmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|접수자(2);AdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수자명(2);AdEmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|접수자부서;AdEmployeeDeptCd;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|접수자부서명;AdEmployeeDeptNm;75;;1;" & "o;n;n;50;"

            ''gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|캠페인명;ExpandNm;80;;4;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|접수처;CompanyNm;114;;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;180;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;246;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;271;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|구독상태;SubscribeStateCd;87;;1;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|자택전화번호;PhoneNum1;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|직장전화번호;PhoneNum2;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;1;;1;" & "o;n;y;30;"

            gridAttributes = gridAttributes & "|투입지국;DeliveryBranchNm;62;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|영업담당;EmployeeNm;74;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|접수계;TargetPaperTotNum;50;#,##0;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|신규확장;NewExpPapNum;62;#,##0;c;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|재확장;ReExpPapNum;50;#,##0;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;87;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;87;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;85;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|중지일자;MngStopDt;85;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국전달사항;BranchMessage;227;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|비고;Note;232;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;10;"       '(80)


            gridCodeNameList = ""
            Grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.Grd_1.ExplorerBar = 3

            '' ''==============================================================
            '' ''  grid_3 를 초기화 한다.
            '' ''--------------------------------------------------------------
            ' ''gridAttributes = ""

            '' ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            ' ''gridAttributes = gridAttributes & "a;r;n"
            '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            ' ''gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            ' ''gridAttributes = gridAttributes & "|접수일자;ContactDt4;85;yyyy-MM-dd;4;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|확장처;CompanyNm;119;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|독자명;SubscriberNm;191;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|자택전화번호;PhoneNum1;116;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|직장전화번호;PhoneNum2;99;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;106;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|주소;OldAddr1;231;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|상세주소;OldAddr2;232;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|접수신규;NewPapNum;62;;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|접수재확장;ReExpPapNum1;74;;7;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|접수계;TargetPaperTotNum;50;;7;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|지국명;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|영업담당;EmployeeNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;87;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;74;;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|투입일자;FixedStDt3;85;yyyy-MM-dd;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|비고;Note;232;;1;" & "o;n;n;50;"

            ' ''gridCodeNameList = ""
            ' ''Grd_3.Initialize(gridAttributes, gridCodeNameList)
            ' ''Me.Grd_3.ExplorerBar = 3

            '' ''==============================================================
            '' ''  grid_4 를 초기화 한다.
            '' ''--------------------------------------------------------------
            ' ''gridAttributes = ""

            '' ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            ' ''gridAttributes = gridAttributes & "a;r;y"
            '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            ' ''gridAttributes = gridAttributes & "||순번;seq;119;;1;" & "o;n;y;30;"
            ' ''gridAttributes = gridAttributes & "|접수;ContactDt4;85;;4;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|확장처;CompanyNm;119;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|투입처;DeliveryChnlNm;128;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|독자명;SubscriberNm;191;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|전화;PhoneNum1;116;;1;" & "o;n;n;10;"
            '' ''gridAttributes = gridAttributes & "|핸드폰;MobileNum;116;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|주소;OldAddr1;231;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|상세주소;OldAddr2;232;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|신규;NewPapNum;62;;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|재확장;ReExpPapNum1;74;;7;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|계;TargetPaperTotNum;50;;7;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|지국명;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|영업담당;EmployeeNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|수금;CollectionDivCd;87;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|모니터;Refuse;1;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|구독시작;FixedStDt1;85;;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|구독종료;FixedEdDt;85;;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|배달확인;DeliveryConfirm;74;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|미배달;NotDelivery;62;;4;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|미배달사유;NotDeliveryReason;1;;1;" & "o;n;n;50;"
            ' ''gridAttributes = gridAttributes & "|조치사항;MeasuresSubject;1;;1;" & "o;n;n;100;"
            ' ''gridAttributes = gridAttributes & "|결과;Result;1;;1;" & "o;n;n;100;"

            '' ''grid_4 code combo    
            ' ''gridCodeNameList = ""

            ' ''grd_4.Initialize(gridAttributes, gridCodeNameList)
            ' ''Me.grd_4.ExplorerBar = 3

            '' ''==============================================================
            '' ''  grid_5 를 초기화 한다.
            '' ''--------------------------------------------------------------
            ' ''gridAttributes = ""

            '' ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            ' ''gridAttributes = gridAttributes & "a;r;y"
            '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            ' ''gridAttributes = gridAttributes & "||순번;seq;119;;1;" & "o;n;y;30;"
            ' ''gridAttributes = gridAttributes & "|접수;ContactDt4;85;;4;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|확장처;CompanyNm;119;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|투입처;DeliveryChnlNm;128;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|독자명;SubscriberNm;191;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|전화1;PhoneNum1;116;;1;" & "o;n;n;10;"
            '' ''gridAttributes = gridAttributes & "|핸드폰;MobileNum;116;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|주소;OldAddr1;231;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|상세주소;OldAddr2;232;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|신규;NewPapNum;62;;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|재확장;ReExpPapNum1;74;;7;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|계;TargetPaperTotNum;50;;7;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|지국명;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|영업담당;EmployeeNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|수금;CollectionDivCd;87;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|모니터;Refuse;1;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|구독시작;FixedStDt1;85;dd;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|1년시점;OneYearPoint;85;;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|배달확인;DeliveryConfirm;74;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|미배달;NotDelivery;62;;4;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|미배달사유;NotDeliveryReason;1;;1;" & "o;n;n;50;"
            ' ''gridAttributes = gridAttributes & "|조치사항;MeasuresSubject;1;;1;" & "o;n;n;100;"
            ' ''gridAttributes = gridAttributes & "|중지일자;FixedEdDt;1;;1;" & "o;n;n;100;"

            '' ''grid_5 code combo    
            ' ''gridCodeNameList = ""

            ' ''grd_5.Initialize(gridAttributes, gridCodeNameList)
            ' ''Me.grd_5.ExplorerBar = 3

            '담당자 셋팅
            popBizChargeCd.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popBizChargeCd.Enabled = False
                popBizChargeCd.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                               GmainBusinessFunction.GetValue("로그인 ID"), _
                                               GmainBusinessFunction.GetValue("역할대행사번"))
            End If

            '' 2010.10.26영업팀장 권한체크 추가
            If GmainBusinessFunction.GetValue("사용자등급") = "04" Then
                popBizChargeCd.Enabled = True
            End If

            Me.Grd_1.Visible = True

        End Sub
#End Region

#Region "이벤트"

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grd_1.DoubleClick

            ''사원확장 독자 등록 화면으로 JUMP.
            'If Me.Grd_1.Rows <= Me.Grd_1.FixedRows Then Exit Sub
            'Dim strCode As String '접수독자번호
            'Dim sdate As String
            'sdate = dtpBaseYear.TextValue.Substring(0, 4) + "-" + "01"
            'strCode = Me.dtpBaseYear.TextValue _
            '          & ";" & Me.Grd_1.GetCurrentRowCellValue("BranchNum") _
            '          & ";" & sdate
            'GmainBusinessFunction.SetValue("화면 전환", "PNI403;" & strCode)
            'Me.ShowUiControl("PNI403", strCode)

        End Sub


#End Region


#Region "사용않함"

        Private Sub btnExcelExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelExport.Click
            Call CreateXLS(GetDataSet)
        End Sub

        ' 엑셀 내보내기
        Public Sub CreateXLS(ByVal tmpDataSet As DataSet)

            ' 조회된데이타가없으면패쑤~
            If tmpDataSet.Tables.Count < 1 Then
                Exit Sub
            End If
            If tmpDataSet.Tables(0).Rows.Count < 1 Then
                Exit Sub
            End If

            Dim strToday As String = Replace(Date.Today, "-", "").Substring(2, 2) & "." & Replace(Date.Today, "-", "").Substring(4, 2) & "." & Replace(Date.Today, "-", "").Substring(6, 2)

            'Dim ProcExcel As Process() = Process.GetProcesses()
            'Dim ExcelID() As Integer

            'For ii As Integer = 0 To ProcExcel.Length - 1
            '    ExcelID(ii) = Process.GetProcessesByName("EXCEL").Length
            'Next

            Dim xlsApp As Object = CreateObject("Excel.Application")

            Dim dlgSave As New SaveFileDialog
            Dim sFileName As String = ""

            ' 엑셀 객체 생성

            dlgSave.Filter = "Excel file (*.xls)|*.xls|All files (*.*)|*.*"

            Dim dr As DialogResult = dlgSave.ShowDialog()

            If dr = DialogResult.OK Then
                sFileName = dlgSave.FileName
            Else
                Exit Sub
            End If

            Try
                Me.Cursor = Cursors.WaitCursor

                Const xlContinuous = 1 ' // 일반 선을 말합니다.  종류엔 점선,, 쇄선등이 있져..
                Const xlEdgeRight = 10 ' // 어느쪽에 라인을 그을거냐.. 옵션이져.  left, top , bottom 
                Const xlEdgeLeft = 7 '
                Const xlEdgeTop = 8
                Const xlEdgeBottom = 9

                Const xlCenter = -4108 '가운데 정렬
                Const xlRight = -4152 '오른쪽 정렬

                '엑셀파일 실행(보여줌)
                'excTemp.Visible = True

                xlsApp.Workbooks.Add()
                'xlsApp.Visible = True

                Dim intWorkSheetCount As Integer
                '' 기존의 워크 쉬트 제거 빈거 제거
                For intWorkSheetCount = xlsApp.Worksheets.Count To 2 Step -1
                    xlsApp.Worksheets(intWorkSheetCount).Delete()
                Next intWorkSheetCount

                ''==============본사수금독자 배달확인=====================
                'If Me.optHeadOfficeDelivery.Checked = True Then

                '    'xlsApp.Selection.HorizontalAlignment() = xlCenter
                '    xlsApp.Workbooks(1).Sheets(1).Name = "본사수금독자 배달확인"

                '    '전체행의 높이 설정
                '    xlsApp.Cells.Resize.RowHeight = 18.75
                '    '전체 셀서식 텍스트 설정
                '    xlsApp.Cells.NumberFormatLocal = "@"
                '    '전체 셀글자수 넘어갈시 자동으로 글자 크기 맞추는 설정
                '    xlsApp.Cells.ShrinkToFit = True

                '    '제목줄 폰트, 사이즈, 행높이 셋팅
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).Font.Size = 20
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).Font.Bold = True
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).RowHeight = 19.5

                '    xlsApp.Workbooks(1).Sheets(1).Cells(1, 1) = "사원확장 본사수금독자 배달확인"
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).Merge()

                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).HorizontalAlignment = xlCenter '수평
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).VerticalAlignment = xlCenter '수직

                '    '날짜줄 행높이
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 3 & ":T" & 3).RowHeight = 13.5
                '    xlsApp.Workbooks(1).Sheets(1).Range("Q" & 3 & ":T" & 3).Merge()
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 3 & ":T" & 3).HorizontalAlignment = xlRight '수평

                '    xlsApp.Workbooks(1).Sheets(1).Cells(3, 17) = "<출력일자:" & strToday & ">"

                '    xlsApp.Workbooks(1).Sheets(1).columns("A:A").columnwidth = 4.11
                '    xlsApp.Workbooks(1).Sheets(1).columns("B:B").columnwidth = 7.89
                '    xlsApp.Workbooks(1).Sheets(1).columns("C:C").columnwidth = 8.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("D:D").columnwidth = 31.76

                '    xlsApp.Workbooks(1).Sheets(1).columns("E:E").columnwidth = 10.56
                '    xlsApp.Workbooks(1).Sheets(1).columns("F:F").columnwidth = 23.67
                '    xlsApp.Workbooks(1).Sheets(1).columns("G:G").columnwidth = 44.11
                '    xlsApp.Workbooks(1).Sheets(1).columns("H:H").columnwidth = 4.11

                '    xlsApp.Workbooks(1).Sheets(1).columns("I:I").columnwidth = 5.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("J:J").columnwidth = 4.11
                '    xlsApp.Workbooks(1).Sheets(1).columns("K:K").columnwidth = 7.44
                '    xlsApp.Workbooks(1).Sheets(1).columns("L:L").columnwidth = 7.44

                '    xlsApp.Workbooks(1).Sheets(1).columns("M:M").columnwidth = 4.11
                '    xlsApp.Workbooks(1).Sheets(1).columns("N:N").columnwidth = 7.89
                '    xlsApp.Workbooks(1).Sheets(1).columns("O:O").columnwidth = 7.89
                '    xlsApp.Workbooks(1).Sheets(1).columns("P:P").columnwidth = 7.44

                '    xlsApp.Workbooks(1).Sheets(1).columns("Q:Q").columnwidth = 5.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("R:R").columnwidth = 10.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("S:S").columnwidth = 10.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("T:T").columnwidth = 4.11

                '    '컬럼 
                '    For j As Integer = 1 To tmpDataSet.Tables(0).Columns.Count - 1
                '        xlsApp.Workbooks(1).Sheets(1).Cells(4, j) = tmpDataSet.Tables(0).Rows(0).Item(j - 1).ToString
                '        xlsApp.Workbooks(1).Sheets(1).Range("A" & 4 & ":T" & 4).HorizontalAlignment = xlCenter '수평
                '    Next

                '    Dim i As Integer = 0
                '    '데이터
                '    For i = 5 To tmpDataSet.Tables(0).Rows.Count + 3
                '        For j As Integer = 1 To tmpDataSet.Tables(0).Columns.Count - 1
                '            xlsApp.Workbooks(1).Sheets(1).Cells(i, j) = tmpDataSet.Tables(0).Rows(i - 4).Item(j - 1)
                '        Next
                '    Next

                '    '합계행 폰트 굵게~~
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & i - 1 & ":T" & i - 1).Font.Bold = True

                '    '전체 컬럼 길이 자동으로 셋팅
                '    'xlsApp.Workbooks(1).Sheets(1).Columns.AutoFit()

                '    Dim intCols As Integer = 0

                '    '세로라인 그리기
                '    For intCols = 1 To tmpDataSet.Tables(0).Columns.Count - 1
                '        xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(4, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count - 1, intCols)).Borders(xlEdgeRight).LineStyle = xlContinuous
                '        xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(4, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count - 1, intCols)).Borders(xlEdgeLeft).LineStyle = xlContinuous
                '    Next
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & tmpDataSet.Tables(0).Rows.Count + 3).Borders(xlEdgeLeft).LineStyle = xlContinuous
                '    xlsApp.Workbooks(1).Sheets(1).Range("T" & tmpDataSet.Tables(0).Rows.Count + 3).Borders(xlEdgeRight).LineStyle = xlContinuous

                '    Dim intRows As Integer = 0
                '    '가로라인 그리기
                '    For intRows = 3 To tmpDataSet.Tables(0).Rows.Count + 3
                '        xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":T" & intRows).Borders(xlEdgeBottom).LineStyle = xlContinuous
                '    Next
                '    '==========지국수금독자 배달확인=====================
                '    'ElseIf Me.optBranchDelivery.Checked = True Then
                '    '    '컬럼 
                '    '    For j As Integer = 1 To Me.grd_5.Cols - 1
                '    '        xlsApp.Cells(1, j) = Me.grd_5.get_TextMatrix(0, j)
                '    '    Next
                '    '    ' 데이터
                '    '    For i As Integer = 2 To Me.grd_5.Rows - 1
                '    '        For j As Integer = 2 To Me.grd_5.Cols - 1
                '    '            xlsApp.Cells(i, j) = Me.grd_5.Item(i, j)
                '    '        Next
                '    '    Next
                '    '    xlsApp.Columns.AutoFit()
                '    '    Dim intCols As Integer = 0

                '    '    For intCols = 1 To Me.grd_5.Cols - 1
                '    '        'xlsApp.Sheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Sheets(1).Cells(xlsApp.Sheets(1).UsedRange.Rows.Count, intCols)).Select()
                '    '        'xlsApp.Selection.Borders(xlEdgeRight).LineStyle = xlContinuous
                '    '        'xlsApp.Selection.Borders(xlEdgeLeft).LineStyle = xlContinuous
                '    '    Next

                '    '    Dim intRows As Integer = 0

                '    '    For intRows = 1 To Me.grd_5.Rows - 1
                '    '        xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Borders(xlEdgeBottom).LineStyle = xlContinuous
                '    '    Next
                'End If

                MessageBox.Show("엑셀 내보내기 완료", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

                xlsApp.Workbooks(1).SaveAs(sFileName)
                xlsApp.Application.Quit()
                xlsApp = Nothing
                GC.Collect()

                Me.Cursor = Cursors.Default

            Catch ex As Exception
                MessageBox.Show(ex.ToString(), "Xls2Grd")
            End Try
        End Sub


        ' 엑셀 내보내기
        'Public Sub CreateXLS()

        '    'Dim ProcExcel As Process() = Process.GetProcesses()
        '    'Dim ExcelID() As Integer

        '    'For ii As Integer = 0 To ProcExcel.Length - 1
        '    '    ExcelID(ii) = Process.GetProcessesByName("EXCEL").Length
        '    'Next


        '    Dim xlsApp As Object = CreateObject("Excel.Application")

        '    Dim dlgSave As New SaveFileDialog
        '    Dim sFileName As String = ""

        '    ' 엑셀 객체 생성

        '    dlgSave.Filter = "Excel file (*.xls)|*.xls|All files (*.*)|*.*"

        '    Dim dr As DialogResult = dlgSave.ShowDialog()

        '    If dr = DialogResult.OK Then
        '        sFileName = dlgSave.FileName
        '    Else
        '        Exit Sub
        '    End If

        '    Try
        '        Me.Cursor = Cursors.WaitCursor

        '        Const xlContinuous = 1 ' // 일반 선을 말합니다.  종류엔 점선,, 쇄선등이 있져..
        '        Const xlEdgeRight = 10 ' // 어느쪽에 라인을 그을거냐.. 옵션이져.  left, top , bottom 
        '        Const xlEdgeLeft = 7 '
        '        Const xlEdgeTop = 8
        '        Const xlEdgeBottom = 9

        '        '엑셀파일 실행(보여줌)
        '        'excTemp.Visible = True

        '        xlsApp.Workbooks.Add()


        '        xlsApp.Visible = True
        '        '==============본사수금독자 배달확인=====================
        '        If Me.optHeadOfficeDelivery.Checked = True Then

        '            xlsApp.Workbooks(1).Sheets(1).Name = "본사수금독자 배달확인"

        '            '컬럼 
        '            For j As Integer = 1 To Me.grd_4.Cols - 1
        '                xlsApp.Workbooks(1).Sheets(1).Cells(1, j) = Me.grd_4.get_TextMatrix(0, j)
        '            Next

        '            ' 데이터
        '            For i As Integer = 2 To Me.grd_4.Rows - 1
        '                For j As Integer = 1 To Me.grd_4.Cols - 1
        '                    xlsApp.Workbooks(1).Sheets(1).Cells(i, j) = Me.grd_4.Item(i - 1, j)
        '                Next
        '            Next

        '            '' 데이터
        '            'For i As Integer = 2 To tmpDataSet.Tables(0).Rows.Count - 1
        '            '    For j As Integer = 1 To tmpDataSet.Tables(0).Columns.Count - 1
        '            '        xlsApp.Workbooks(1).Sheets(1).Cells(i, j) = tmpDataSet.Tables(0).Rows(i).Item(j)
        '            '    Next
        '            'Next
        '            xlsApp.Workbooks(1).Sheets(1).Columns.AutoFit()

        '            Dim intCols As Integer = 0

        '            '세로라인 그리기
        '            For intCols = 1 To Me.grd_4.Cols - 1
        '                'xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count, intCols)).Select()
        '                xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count, intCols)).Borders(xlEdgeRight).LineStyle = xlContinuous
        '                xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count, intCols)).Borders(xlEdgeLeft).LineStyle = xlContinuous
        '                'xlsApp.Workbooks(1).Worksheets(1).Borders(xlEdgeRight).LineStyle = xlContinuous
        '                'xlsApp.Workbooks(1).Worksheets(1).Selection.Borders(xlEdgeLeft).LineStyle = xlContinuous
        '            Next

        '            Dim intRows As Integer = 0
        '            '가로라인 그리기
        '            For intRows = 1 To Me.grd_4.Rows - 1
        '                'xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Select()
        '                xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Borders(xlEdgeBottom).LineStyle = xlContinuous
        '                'xlsApp.Workbooks(1).Sheets(1).Selection.Borders(xlEdgeBottom).LineStyle = xlContinuous
        '            Next
        '            '==========지국수금독자 배달확인=====================
        '        ElseIf Me.optBranchDelivery.Checked = True Then
        '            '컬럼 
        '            For j As Integer = 1 To Me.grd_5.Cols - 1
        '                xlsApp.Cells(1, j) = Me.grd_5.get_TextMatrix(0, j)
        '            Next
        '            ' 데이터
        '            For i As Integer = 2 To Me.grd_5.Rows - 1
        '                For j As Integer = 2 To Me.grd_5.Cols - 1
        '                    xlsApp.Cells(i, j) = Me.grd_5.Item(i, j)
        '                Next
        '            Next
        '            xlsApp.Columns.AutoFit()
        '            Dim intCols As Integer = 0

        '            For intCols = 1 To Me.grd_5.Cols - 1
        '                'xlsApp.Sheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Sheets(1).Cells(xlsApp.Sheets(1).UsedRange.Rows.Count, intCols)).Select()
        '                'xlsApp.Selection.Borders(xlEdgeRight).LineStyle = xlContinuous
        '                'xlsApp.Selection.Borders(xlEdgeLeft).LineStyle = xlContinuous
        '            Next

        '            Dim intRows As Integer = 0

        '            For intRows = 1 To Me.grd_5.Rows - 1
        '                'xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Select()
        '                xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Borders(xlEdgeBottom).LineStyle = xlContinuous
        '            Next
        '        End If

        '        MessageBox.Show("엑셀 내보내기 성공!")

        '        xlsApp.Workbooks(1).SaveAs(sFileName)
        '        xlsApp.Application.Quit()
        '        xlsApp = Nothing
        '        GC.Collect()

        '        Me.Cursor = Cursors.Default

        '        'Dim pro() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
        '        'For Each i As Process In pro
        '        '    i.Kill()
        '        'Next

        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString(), "Xls2Grd")
        '    End Try
        'End Sub
#End Region

    End Class

End Namespace
