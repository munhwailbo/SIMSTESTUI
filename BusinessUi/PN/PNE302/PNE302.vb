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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE302
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;60;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|확장일자;ExpandDt;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독시작일자;FixedStDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|D-M;Dday;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|순번;Orders;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;70;;c;" & "o;n;n;40;확장처 명;CompanyNm;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;70;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|접수부수;TargetPaperTotNum;60;;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|신규부수;NewExpPapNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|재확장부수;ReExpPapNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;60;#,###;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기코드;BillPeriodCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;60;#,###;r;" & "o;n;n;5;"

            'gridAttributes = gridAttributes & "|접수부수;TargetPaperTotNum;60;;r;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;60;#,###;r;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|투입부수;SubscribePagerNum;60;#,###;r;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|미투입부수;NotSubscribePagerNum;60;#,###;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|승인일자;ApprovalDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|비고;Note;70;;c;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|명단없는부수;NoListPapNum;60;#,###;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|투입부수;SubscribePagerNum;60;#,###;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|미투입부수;NoSubscribePagerNum;60;#,###;r;" & "o;n;y;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ProjectID;프로젝트 명"
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1


            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;12;;;" & "io;n;y;12;"       '(190)
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;13;;;" & "o;n;y;13;"       '(10)
            gridAttributes = gridAttributes & "|접수일자;ContactDt;8;;;" & "o;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|순번;Orders;4;#,##0;c;" & "o;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;30;;;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|신규부수;NewConPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)
            gridAttributes = gridAttributes & "|재확장부수;ReConPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)
            gridAttributes = gridAttributes & "|접수부수계;ContactPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)

            gridAttributes = gridAttributes & "|권유자명;AdEmployeeNm;70;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|권유자부서;AdEmployeeDeptNm;70;;c;" & "o;n;n;7;"

            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;30;;;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;30;;;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;10;;;" & "o;n;n;10;우편번호;OldAddr1;"       '(130)
            gridAttributes = gridAttributes & "|주소;OldAddr1;50;;;" & "o;n;n;50;"       '(140)
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;100;;;" & "o;n;n;100;"       '(150)
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;7;;c;" & "o;n;n;7;지국코드;DeliveryBranchNm;"       '(160)
            gridAttributes = gridAttributes & "|투입지국명;DeliveryBranchNm;7;;;" & "o;n;n;7;"       '(160)
            gridAttributes = gridAttributes & "|지국전달사항;BranchNote;70;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;8;;;" & "o;n;n;8;"       '(62)
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;8;;;" & "o;n;n;8;"       '(63)

            gridAttributes = gridAttributes & "|(모)처리코드;MonitoringResultCd;10;;;" & "o;n;n;10;"       '(370)
            gridAttributes = gridAttributes & "|(모)미통과사유코드;RefuseReasonCd;10;;;" & "o;n;n;10;"       '(380)
            gridAttributes = gridAttributes & "|(모)처리자사번;MonitoringEmpNum;7;;;" & "o;n;n;7;"       '(350)
            gridAttributes = gridAttributes & "|(모)처리자명;MonitoringEmpNm;7;;;" & "o;n;n;7;"       '(350)
            gridAttributes = gridAttributes & "|(모)처리일자;MonitoringProcDt;8;;;" & "o;n;n;8;"       '(360)

            gridAttributes = gridAttributes & "|권유자통보여부;NotifyYN;1;;;" & "o;n;n;1;"       '(330)
            gridAttributes = gridAttributes & "|권유자통보일자;SolicitorNotifyDt;8;;;" & "o;n;n;8;"       '(340)
            gridAttributes = gridAttributes & "|비고;Note;1000;;;" & "o;n;n;1000;"       '(400)

            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "MonitoringResultCd;모니터결과처리코드"
            gridCodeNameList = gridCodeNameList & "/RefuseReasonCd;모니터미통과사유코드"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3


            '==============================================================
            '  grid_3 를 초기화 한다.
            '--------------------------------------------------------------

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
            gridAttributes = gridAttributes & "|신규확장부수;FixedPaperNum;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|재확장부수;ReFixedPaperNum;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|사원확장부수;TargetPaperTotNum;70;#,###;r;" & "io;n;n;5;"
            'gridAttributes = gridAttributes & "|중지부수;StopPaperNum;70;#,###;r;" & "io;n;n;40;"
            'gridAttributes = gridAttributes & "|개인실적여부;IndividualYN;80;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|권유자정보;RealSolicitorInfo;70;;c;" & "io;n;y;40;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "SolicitorDivCd;권유자구분코드"
            Dim gridCriteriaPopupCodeList As String = ""
            gridCriteriaPopupCodeList = gridCriteriaPopupCodeList & "EmployeeNameHangul;권유부서코드,권유부서명"
            grd_3.Initialize(gridAttributes, gridCodeNameList, gridCriteriaPopupCodeList)
            Me.grd_3.ExplorerBar = 3

            Me.RequestData()

            '''''===========================================================================================
            '''' ====   김동욱과장님의 요청 사항으로 삭제 하지 않구 주석 처리 ㅋㅋ 
            '''''===========================================================================================
            ' ''gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            ' ''gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;12;;;" & "o;n;y;12;"       '(190)
            ' ''gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;13;;;" & "o;n;y;13;"       '(10)
            ' ''gridAttributes = gridAttributes & "|순번;Orders;4;;;" & "o;n;n;4;"       '(30)
            ' ''gridAttributes = gridAttributes & "|접수일자;ContactDt;8;;;" & "o;n;n;8;"       '(20)
            ' ''gridAttributes = gridAttributes & "|승인여부;ApprovalYN;1;;;" & "o;n;n;1;"       '(390)
            ' ''gridAttributes = gridAttributes & "|승인일자;ApprovalDt;1;;;" & "o;n;n;1;"       '(390)

            ' ''gridAttributes = gridAttributes & "|접수부수;ContactPaperNum;4;;;" & "o;n;n;4;"       '(61)
            ' ''gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;4;;;" & "o;n;n;4;"       '(64)

            ' ''gridAttributes = gridAttributes & "|모니터처리자아이디;MonitoringEmpNum;7;;;" & "o;n;n;7;"       '(350)
            ' ''gridAttributes = gridAttributes & "|모니터처리일자;MonitoringProcDt;8;;;" & "o;n;n;8;"       '(360)
            ' ''gridAttributes = gridAttributes & "|모니터처리코드;MonitoringResultCd;10;;;" & "o;n;n;10;"       '(370)
            ' ''gridAttributes = gridAttributes & "|미통과사유코드;RefuseReasonCd;10;;;" & "o;n;n;10;"       '(380)

            ' ''gridAttributes = gridAttributes & "|독자상태코드;ReaderStateCd;10;;;" & "o;n;n;10;"       '(50)
            ' ''gridAttributes = gridAttributes & "|독자명;SubscriberNm;30;;;" & "o;n;n;30;"       '(40)

            ' ''gridAttributes = gridAttributes & "|투입채널코드;DeliveryChnlCd;10;;;" & "o;n;n;10;"       '(60)
            ' ''gridAttributes = gridAttributes & "|투입일자;FixedStDt;8;;;" & "o;n;n;8;"       '(62)
            ' ''gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;8;;;" & "o;n;n;8;"       '(63)
            ' ''gridAttributes = gridAttributes & "|서비스기간;ServiceTerm;4;;;" & "o;n;n;4;"       '(65)
            ' ''gridAttributes = gridAttributes & "|수금년월;CollectionYYYYMM;6;;;" & "o;n;n;6;"       '(66)

            ' ''gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;30;;;" & "o;n;n;30;"       '(70)
            ' ''gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;30;;;" & "o;n;n;30;"       '(80)
            ' ''gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;30;;;" & "o;n;n;30;"       '(90)
            ' ''gridAttributes = gridAttributes & "|우편번호;OldPostNum;10;;;" & "o;n;n;10;"       '(130)
            ' ''gridAttributes = gridAttributes & "|주소;OldAddr1;50;;;" & "o;n;n;50;"       '(140)
            ' ''gridAttributes = gridAttributes & "|상세주소;OldAddr2;100;;;" & "o;n;n;100;"       '(150)
            ' ''gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;7;;;" & "o;n;n;7;"       '(160)

            ' ''gridAttributes = gridAttributes & "|(신)우편번호;NewPostNum;10;;;" & "o;n;n;10;"       '(100)
            ' ''gridAttributes = gridAttributes & "|(신)주소;NewAddr1;50;;;" & "o;n;n;50;"       '(110)
            ' ''gridAttributes = gridAttributes & "|(신)상세주소;NewAddr2;100;;;" & "o;n;n;100;"       '(120)
            ' ''gridAttributes = gridAttributes & "|소속사코드;SolicitorCorpCd;10;;;" & "o;n;n;10;"       '(170)
            ' ''gridAttributes = gridAttributes & "|지국확장번호;BranchExpNum;12;;;" & "o;n;n;12;"       '(180)
            ' ''gridAttributes = gridAttributes & "|독자유형코드;ReaderTypeCd;10;;;" & "o;n;n;10;"       '(200)
            ' ''gridAttributes = gridAttributes & "|독자구분코드;ReaderDivCd;10;;;" & "o;n;n;10;"       '(210)
            ' ''gridAttributes = gridAttributes & "|X배달처구분코드;DeliveryRegionCd;10;;;" & "o;n;n;10;"       '(220)
            ' ''gridAttributes = gridAttributes & "|배달구분코드;DeliveryDivCd;10;;;" & "o;n;n;10;"       '(230)
            ' ''gridAttributes = gridAttributes & "|수금형태코드;CollectionTypeCd;10;;;" & "o;n;n;10;"       '(240)
            ' ''gridAttributes = gridAttributes & "|청구방법코드;BillTypeCd;10;;;" & "o;n;n;10;"       '(250)
            ' ''gridAttributes = gridAttributes & "|구독권독자여부;CouponReaderYN;1;;;" & "o;n;n;1;"       '(320)
            ' ''gridAttributes = gridAttributes & "|권유자통보여부;NotifyYN;1;;;" & "o;n;n;1;"       '(330)
            ' ''gridAttributes = gridAttributes & "|권유자통보일자;SolicitorNotifyDt;8;;;" & "o;n;n;8;"       '(340)
            ' ''gridAttributes = gridAttributes & "|비고;Note;1000;;;" & "o;n;n;1000;"       '(400)
            ' ''gridAttributes = gridAttributes & "|구독코드;SubscribeCd;10;;;" & "o;n;n;10;"       '(410)
            ' ''gridAttributes = gridAttributes & "|구독권발행코드;CouponSeriesNum;10;;;" & "o;n;n;10;"       '(420)
            '''''===========================================================================================
            '''' ====   김동욱과장님의 요청 사항으로 삭제 하지 않구 주석 처리 ㅋㅋ 
            '''''===========================================================================================
            'grid_4 code combo    

        End Sub

        Private Sub PNE302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

        Private Sub grd_1_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            Me.grd_1.Editable = EditableSettings.flexEDKbdMouse

            If Me.grd_1.Rows > 1 Then
                With Me.grd_1
                    Select Case .ColSel
                        Case .get_ColIndex("EmployeeExpNum")
                            .Editable = EditableSettings.flexEDNone
                        Case Else
                            .Editable = EditableSettings.flexEDKbdMouse
                    End Select
                End With
            End If

        End Sub

        Private Sub optGrd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGrd3.CheckedChanged
            grd_2.Visible = optGrd2.Checked
            grd_3.Visible = optGrd3.Checked
        End Sub

        Private Sub optGrd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGrd2.CheckedChanged
            grd_2.Visible = optGrd2.Checked
            grd_3.Visible = optGrd3.Checked
        End Sub

        ''''''' <summary>
        ''''''' 함수명 : btnApprovalAll_Click 
        ''''''' 기  능 : 일괄 승인
        ''''''' 작성자 : 
        ''''''' 작성일 : 
        ''''''' 수정자 : 
        ''''''' 수정일 : 
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>

        '' ''Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    Dim inti As Integer
        '' ''    Try
        '' ''        If blnApprovalAll = False Then
        '' ''            With grd_1
        '' ''                If (.Rows > .FixedRows) Then
        '' ''                    For inti = .FixedRows To .Rows - 1
        '' ''                        If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
        '' ''                            .SetCellCheck(inti, .get_ColIndex("ApprovalYN"), CheckEnum.Checked)
        '' ''                            .set_TextMatrix(inti, .get_ColIndex("ApprovalDt"), dtpApprovalDt.Text)
        '' ''                            .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
        '' ''                        End If
        '' ''                    Next inti
        '' ''                End If
        '' ''            End With
        '' ''            blnApprovalAll = True
        '' ''        Else
        '' ''            With grd_1
        '' ''                If (.Rows > .FixedRows) Then
        '' ''                    For inti = .FixedRows To .Rows - 1
        '' ''                        If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
        '' ''                            .SetCellCheck(inti, .get_ColIndex("ApprovalYN"), CheckEnum.Unchecked)
        '' ''                            .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
        '' ''                        End If
        '' ''                    Next inti
        '' ''                End If
        '' ''            End With
        '' ''            blnApprovalAll = False
        '' ''        End If
        '' ''        btnApprovalAll.Text = IIf(blnApprovalAll, "승인 취소", "일괄 승인")
        '' ''    Catch ex As Exception
        '' ''        MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '' ''    End Try
        '' ''End Sub

    End Class

End Namespace
