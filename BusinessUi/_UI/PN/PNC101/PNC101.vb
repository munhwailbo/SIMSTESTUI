' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 지국확장접수독자등록
' form설명 : 지국확장접수독자등록을(를) 한다
' 작성자 : 신현갑
' 작성일 : 2008-09-18
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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
Imports System.Collections.Generic

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC101
        Inherits CommonControls.UiControl

#Region "폼 초기화"

        ''' <summary>
        ''' 함수명 : Initialize
        ''' 리턴값 : 
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 
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
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|접수독자번호;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;145;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;94;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;97;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;0;;4;" & "o;n;y;10;우편번호;CodeHangulName"
            gridAttributes = gridAttributes & "|주소;CodeHangulName;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;207;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;224;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수일자;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|순번;Orders;0;;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|신우편번호;NewPostNum;0;;4;" & "o;n;y;10;우편번호;CodeHangulName"
            gridAttributes = gridAttributes & "|주소;CodeHangulName;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|신주소;NewAddr1;0;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|신상세주소;NewAddr2;0;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;0;;1;" & "o;n;y;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국 명;DeliveryBranchNm;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;88;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|배달구분코드;DeliveryDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;62;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|구독코드;SubscribeCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지국확장번호;BranchExpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|독자상태코드;ReaderStateCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|투입채널코드;DeliveryChnlCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당자코드;EmployeeNumber;70;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;투입지국코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            Me.popEmployeeNumber.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
            Me.NewData()

            '' '' ''==============================================================
            '' '' ''  grid_2 를 초기화 한다.
            '' '' ''--------------------------------------------------------------
            ' '' ''gridAttributes = ""
            '' '' ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            ' '' ''gridAttributes = gridAttributes & "n;r;y"

            '' '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            ' '' ''gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            ' '' ''gridAttributes = gridAttributes & "|구독코드;SubscribeCd;100;;l;" & "o;n;n;10;"       '(10)
            ' '' ''gridAttributes = gridAttributes & "|독자코드;ReaderCd;80;;l;" & "o;n;n;8;"       '(10)
            ' '' ''gridAttributes = gridAttributes & "|독자명;ReaderNm;100;;l;" & "o;n;n;10;"       '(20)
            '' '' ''gridAttributes = gridAttributes & "|독자코드;ReaderCd;80;;l;" & "o;n;n;8;"       '(20)
            ' '' ''gridAttributes = gridAttributes & "|순번;Orders;40;;r;" & "o;n;y;4;"       '(30)
            ' '' ''gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;200;;l;" & "o;n;n;30;"       '(30)
            ' '' ''gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;200;;l;" & "o;n;n;30;"       '(40)

            ' '' ''gridAttributes = gridAttributes & "|구독상태코드;SubscribeStateCd;100;;l;" & "o;n;n;10;"       '(40)
            ' '' ''gridAttributes = gridAttributes & "|확장구분코드;ExpandDivCd;100;;l;" & "o;n;n;10;"       '(50)
            ' '' ''gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;200;;l;" & "o;n;n;30;"       '(50)
            ' '' ''gridAttributes = gridAttributes & "|신우편번호;NewPostNum;100;;l;" & "o;n;n;10;"       '(60)
            ' '' ''gridAttributes = gridAttributes & "|독자구분코드;ReaderDivCd;100;;l;" & "o;n;n;10;"       '(60)
            ' '' ''gridAttributes = gridAttributes & "|독자상태코드;ReaderStateCd;100;;l;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|신주소;NewAddr1;200;;l;" & "o;n;n;50;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|신상세주소;NewAddr2;200;;l;" & "o;n;n;100;"       '(80)
            ' '' ''gridAttributes = gridAttributes & "|배달처구분코드;DeliveryRegionCd;100;;l;" & "o;n;n;10;"       '(80)
            ' '' ''gridAttributes = gridAttributes & "|배달구분코드;DeliveryDivCd;100;;l;" & "o;n;n;10;"       '(90)
            ' '' ''gridAttributes = gridAttributes & "|구우편번호;OldPostNum;100;;l;" & "o;n;n;10;우편번호;CodeHangulName"
            ' '' ''gridAttributes = gridAttributes & "|주소;CodeHangulName;90;;c;" & "o;n;y;5;"          '(90)
            ' '' ''gridAttributes = gridAttributes & "|구주소;OldAddr1;200;;l;" & "o;n;n;50;"       '(100)
            ' '' ''gridAttributes = gridAttributes & "|본사독자구분코드;MHReaderDivCd;100;;l;" & "o;n;n;10;"       '(100)
            ' '' ''gridAttributes = gridAttributes & "|판촉여부;PromotionYN;10;;c;" & "o;n;n;1;"       '(110)
            ' '' ''gridAttributes = gridAttributes & "|구상세주소;OldAddr2;200;;l;" & "o;n;n;100;"       '(110)
            ' '' ''gridAttributes = gridAttributes & "|판촉사원명;PromotionEmpNm;200;;l;" & "o;n;n;30;"       '(120)
            ' '' ''gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;100;;l;" & "o;n;n;10;"       '(130)
            ' '' ''gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;100;;l;" & "o;n;n;10;"       '(140)
            ' '' ''gridAttributes = gridAttributes & "|청구주기코드;BillPeriodCd;100;;l;" & "o;n;n;10;"       '(150)
            ' '' ''gridAttributes = gridAttributes & "|접수일자;ContactDt;80;;l;" & "o;n;n;8;"       '(160)
            ' '' ''gridAttributes = gridAttributes & "|투입일자;FixedStDt;80;;l;" & "o;n;n;8;"       '(170)
            ' '' ''gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;80;;l;" & "o;n;n;8;"       '(180)
            ' '' ''gridAttributes = gridAttributes & "|중지일자;StopDt;80;;l;" & "o;n;n;8;"       '(190)
            ' '' ''gridAttributes = gridAttributes & "|서비스기간;ServiceTerm;40;;r;" & "o;n;n;4;"       '(200)
            ' '' ''gridAttributes = gridAttributes & "|접수부수;ContactPaperNum;40;;r;" & "o;n;n;4;"       '(210)
            ' '' ''gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;40;;r;" & "o;n;n;4;"       '(220)
            ' '' ''gridAttributes = gridAttributes & "|투입부수;SubscribePagerNum;40;;r;" & "o;n;n;4;"       '(230)
            ' '' ''gridAttributes = gridAttributes & "|중지부수;StopPaperNum;40;;r;" & "o;n;n;4;"       '(240)
            ' '' ''gridAttributes = gridAttributes & "|수금시작년월;CollectionYYYYMM;60;;l;" & "o;n;n;6;"       '(250)
            ' '' ''gridAttributes = gridAttributes & "|접수지국코드;ReceiptBranchCd;70;;l;" & "o;n;n;7;지국코드;BranchNm"       '(300)
            ' '' ''gridAttributes = gridAttributes & "|지국 명;BranchNm;70;;l;" & "o;n;y;7;"
            ' '' ''gridAttributes = gridAttributes & "|투입지국코드;SubscribeBranchCd;70;;l;" & "o;n;n;7;지국코드;BranchNm"       '(300)
            ' '' ''gridAttributes = gridAttributes & "|투입지국 명;BranchNm;70;;l;" & "o;n;n;7;"       '(310)
            ' '' ''gridAttributes = gridAttributes & "|수금지국코드;ReceiptMoneyBranchCd;70;;l;" & "o;n;n;7;지국코드;BranchNm"       '(300)
            ' '' ''gridAttributes = gridAttributes & "|수금지국 명;BranchNm;70;;l;" & "o;n;n;7;"       '(320)
            ' '' ''gridAttributes = gridAttributes & "|유가지국코드;ValPaperBranchCd;70;;l;" & "o;n;n;7;지국코드;BranchNm"       '(300)
            ' '' ''gridAttributes = gridAttributes & "|유가지국 명;BranchNm;70;;l;" & "o;n;n;7;"       '(330)
            ' '' ''gridAttributes = gridAttributes & "|비고;Note;200;;l;" & "o;n;n;20;"       '(340)

            '' '' ''grid_2 code combo    
            ' '' ''gridCodeNameList = ""
            ' '' ''gridCodeNameList = gridCodeNameList & "SubscribeStateCd;구독상태코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/CollectionDivCd;수금형태코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;청구주기코드"
            ' '' ''grd_3.Initialize(gridAttributes, gridCodeNameList)
            ' '' '' ''Me.grd_2.ExplorerBar = Me.grd_2.get_ColIndex("EmployeeNumber")

        End Sub
#End Region

#Region "폼 이벤트"

        Private Sub PNC101_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
            Me.txtTemp.TextValue = ""
        End Sub
        ''' <summary>
        ''' 함수명 : PNC101_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
            Dim dtpContactDtStr As String = Me.dtpContactDt.TextValue
            SaveData()
            RequestData()
            NewData(dtpContactDtStr)
            Me.txtTemp.TextValue = ""
            GrecordProcessMode = "1"
            txtSubscriberNm.Focus()
        End Sub

        ''' <summary>
        ''' 함수명 : PNC101_Enter 
        ''' 기  능 : 화면 전환(지국확장 독자 접수 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC101_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters(0) = Me.Name Then
                If ShareParameters.Length = 5 Then
                    SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), "1")
                ElseIf ShareParameters.Length = 6 Then
                    SetRequest2(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5))
                ElseIf ShareParameters.Length = 9 Then
                    SetRequest3(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5), ShareParameters(6), ShareParameters(7), ShareParameters(8))
                End If
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
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, _
                              ByVal strReceiptCd As String, ByVal strSubscriberNm As String, _
                              Optional ByVal strProcGb As String = "1")

            GmainCommonFunction.ControlNewData(Me, Me.picCriteria)

            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '시작일자
            Me.dtpReceiptDtTo.TextValue = strToDt      '종료일자
            Me.txtReceiptCd_2.TextValue = strReceiptCd  '접수독자번호
            Me.txtSubscriberNm_2.TextValue = strSubscriberNm  '접수독자명

            If strProcGb = "1" Then   '처리 구분 1:정상 조회
                GrecordProcessMode = "2"   ' 조회 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestData", CallType.Method)
            ElseIf strProcGb = "2" Then   '처리 구분 2:이사 독자 신규, 3:재확장 신규, 5:WEB접수 전환
                GrecordProcessMode = "1"   ' 신규 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeRemove", CallType.Method)
            ElseIf strProcGb = "3" Then   '처리 구분 2:이사 독자 신규, 3:재확장 신규, 5:WEB접수 전환
                GrecordProcessMode = "1"   ' 신규 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeReExpand", CallType.Method)
                Me.cboReaderStateCd.TextValue = "2"
            ElseIf strProcGb = "5" Then   '처리 구분 2:이사 독자 신규, 3:재확장 신규, 5:WEB접수 전환
                GrecordProcessMode = "1"   ' 신규 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataWebExpand", CallType.Method)
                Me.cboReaderStateCd.TextValue = "1"
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
        Public Sub SetRequest2(ByVal strFromDt As String, ByVal strToDt As String, _
                              ByVal strReceiptCd As String, ByVal strSubscriberNm As String, _
                              Optional ByVal strProcGb As String = "1")

            GmainCommonFunction.ControlNewData(Me, Me.picCriteria)

            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '시작일자
            Me.dtpReceiptDtTo.TextValue = strToDt      '종료일자
            Me.txtReceiptCd_2.TextValue = strReceiptCd  '접수독자번호
            Me.txtSubscriberNm_2.TextValue = strSubscriberNm  '접수독자명

            If strProcGb = "1" Then   '처리 구분 1:정상 조회
                GrecordProcessMode = "2"   ' 조회 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestData", CallType.Method)
            ElseIf strProcGb = "2" Then   '처리 구분 2:이사 독자 신규, 3:재확장 신규, 5:WEB접수 전환
                GrecordProcessMode = "1"   ' 신규 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeRemove", CallType.Method)
            ElseIf strProcGb = "3" Then   '처리 구분 2:이사 독자 신규, 3:재확장 신규, 5:WEB접수 전환
                GrecordProcessMode = "1"   ' 신규 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeReExpand", CallType.Method)
                Me.cboReaderStateCd.TextValue = "2"
            ElseIf strProcGb = "5" Then   '처리 구분 2:이사 독자 신규, 3:재확장 신규, 5:WEB접수 전환
                GrecordProcessMode = "1"   ' 신규 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataWebExpand", CallType.Method)
                Me.cboReaderStateCd.TextValue = "1"
                'ElseIf strProcGb = "4" Then   '처리 구분 2:이사 독자 신규, 3:재확장 신규
                '    GrecordProcessMode = "2"   ' 조회 모드로 변경
                '    Me.dtpReceiptDtFrom.TextValue = "2000-01-01"
                '    Me.txtReceiptCd_2.TextValue = ""
                '    'Me.GmainCommonFunction.GRequestDataNumber = 9
                '    CallByName(Me, "RequestData", CallType.Method)

                '    CallByName(Me, "NewData", CallType.Method)

            End If

            
        End Sub
        'SetSendMessage("화면 전환", "PNC101",
        '           string.Format(@"{0};{1};{2};{3};{4};{5};{6};{7};{8};4", "PNC101",
        '       // 0
        '       clsConsulation.vPkey.Substring(0, 6) + "01", // 조회시작일
        '       // 1 // 접수일
        '       CTICommonFun.GetDate(DateTime.Now).ToString(),
        '       // 2 // 독자명
        '        clsConsulation.SubscribeNm.ToString(),
        '       // 3 // 우편번호
        '        clsConsulation.PostNum.ToString(),
        '       // 4 // 주소
        '        clsConsulation.Addr1.ToString(),
        '       // 5 // 상세주소
        '        clsConsulation.Addr2.ToString(),
        '       // 6 // 지국코드
        '        clsConsulation.BranchCd.ToString(),
        '       // 7 // 지국장코드
        '        clsConsulation.BranchChiefCd.ToString(),
        '       // 8 // 지국담당자코드
        '        clsConsulation.ChargeEmpNum.ToString()
        '       ), LogInfo);

        ''' <summary>
        ''' 함수명 : Request
        ''' 기  능 : 다른 화면에서 코드 를 받아서 해당 내역을 조회 한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Public Sub SetRequest3(ByVal strReciptDt As String, _
                               ByVal strSubscribeNm As String, _
                               ByVal strPhoneNumber As String, _
                               ByVal strPostNum As String, _
                               ByVal strAddr1 As String, _
                               ByVal strAddr2 As String, _
                               ByVal strBranchCd As String, _
                               ByVal strBranchChiefNm As String _
                               )
            '' 조회처리

            Me.dtpReceiptDtFrom.TextValue = "2000-01-01"
            Me.txtSubscriberNm_2.TextValue = strSubscribeNm
            Me.txtPhoneNum_2.TextValue = strPhoneNumber
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.TextValue = ""
            Me.txtReceiptCd_2.TextValue = ""
            CallByName(Me, "RequestData", CallType.Method)

            '' 신규 처리
            CallByName(Me, "NewData", CallType.Method)
            GrecordProcessMode = "1"
            Me.dtpContactDt.TextValue = strReciptDt
            Me.txtSubscriberNm.TextValue = strSubscribeNm
            Me.txtPhoneNum1.TextValue = strPhoneNumber
            Me.popOldPostNum.CodeText = strPostNum
            Me.txtOldAddr1.TextValue = strAddr1
            Me.txtOldAddr2.TextValue = strAddr2
            Me.popDeliveryBranchCd.CodeText = strBranchCd
            Me.txtTrAdEmployeeNm.TextValue = strBranchChiefNm




        End Sub



        Private Sub btnPRB002_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRB002.Click

            '모니터 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '접수독자번호
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("EmployeeNumber")
            GmainBusinessFunction.SetValue("화면 전환", "PNC103;" & strCode)
            ShowUiControl("PNC103", strCode)

        End Sub
        ''' <summary>
        ''' 1. 수금 년월일이 입력되면 1년을 개산하여 구독종료일자을 뿌린다.
        ''' 2. 수금 년월일이 입력되면 구독시작일부터 구금년월일을 계산하여 서비스 개월을 뿌린다.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub dtpCollectionYYYYMM_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCollectionYYYYMM.Leave
            '' 구독 종료일 계산
            If dtpCollectionYYYYMM.TextValue <> "" Then
                dtpFixedEdDt.TextValue = "99991231"
            End If
            '' 서비스 개월 계산
            If dtpFixedStDt.TextValue <> "" And dtpCollectionYYYYMM.TextValue <> "" Then
                Dim sdt As DateTime = dtpFixedStDt.Value()
                Dim cdt As DateTime = dtpCollectionYYYYMM.Value()
                Dim rtnMonth As Integer = 0

                If sdt.Year = cdt.Year Then
                    rtnMonth = cdt.Month - sdt.Month
                Else
                    If sdt.Year - cdt.Year <> 0 Then
                        Dim YearEndMonth As DateTime = sdt.ToString("yyyy-12-31")
                        Dim m1 As Integer = YearEndMonth.Month - sdt.Month
                        Dim m2 As Integer = cdt.Month
                        rtnMonth = m1 + m2
                    End If

                End If
                numServiceTerm.Text = rtnMonth
            End If

        End Sub


        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum1.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum2.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))

        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtMobileNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))

        End Sub


        Private Sub txtTemp_TextChanged1() Handles txtTemp.TextChanged
            '투입지국/권유 지국/ 권유자명/실 권유자명 가져오기
            If txtTemp.TextValue <> "" Then
                ChngAddResult()
                Me.txtTemp.TextValue = ""
            End If
        End Sub

        Private Sub txtOldAddr1_TextChanged() Handles txtOldAddr1.TextChanged
            '투입지국/권유 지국/ 권유자명/실 권유자명 가져오기
            If Me.popOldPostNum.TextValue <> "" And txtTemp.TextValue <> "" Then
                ChngAddResult()
                Me.txtTemp.TextValue = ""
            End If
        End Sub

        Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click

            Dim rtnVal As String = vbNullString
            With grd_1
                For intII As Integer = 1 To .Cols - 1
                    rtnVal = rtnVal & vbCrLf _
                                    & "[" & intII.ToString & "]" & " " _
                                    & "|" & intII.ToString & "" & ";" _
                                    & .get_ColKey(intII) & ";" _
                                    & .get_ColWidth(intII) & ";" _
                                    & .get_ColFormat(intII) & ";" _
                                    & .get_ColAlignment(intII) & ";" _
                                    & " & " & .get_ColData(intII).ToString & vbTab
                Next
            End With
            ''gridAttributes = gridAttributes & "|우편번호;OldPostNum;100;;l;" & "o;n;y;10;우편번호;CodeHangulName"

            MsgBox(rtnVal)
        End Sub

        Private Sub picIo_2_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picIo_2_4.Click

        End Sub

        Private Sub btnExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpand.Click

        End Sub

        Private Sub PNC101_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

            Me.txtTemp.TextValue = ""
        End Sub

        Private Sub popOldPostNum_UserCodeTextChange() Handles popOldPostNum.UserCodeTextChange
            If Me.txtTemp.TextValue = "" Then

            Else
                ChngAddResult()

                Me.txtTemp.TextValue = ""
            End If
        End Sub

        Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
            GmainCommonFunction.LoadCustomForm("CommonPopup2.dll", "frmExistReader", txtSubscriberNm_2.TextValue, txtAddr_2.TextValue, txtPhoneNum_2.TextValue)
        End Sub
    End Class

End Namespace
