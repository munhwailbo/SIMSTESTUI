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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE501
        Inherits CommonControls.UiControl

        Private Sub PNE501_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "폼 초기화"
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
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|구분코드;BillDivCd;50;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수유형;BillDivCdNm;90;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;1;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;100;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수처;CompanyCd;1;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|접수처명;CompanyNm;200;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수번호;EmployeeExpNum;100;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|건수;Cnt;1;#,###;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|배분부수;PaperNum;60;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|명단부수;FixedPaperNum;60;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|차이부수;diffPaperNum;60;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수명;ExpandNm;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|금액;Amt;120;#,##0;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지대공제;DeductAmt;120;#,##0;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|이체금액;TransferAmt;120;#,##0;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;100;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수일자;EmployeeExpDt;100;;1;" & "o;n;y;30;"

            gridAttributes = gridAttributes & "|지국전달사항;BranchNote;269;;1;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|접수;TargetPaperTotNum;37;;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|신규;NewExpPapNum;37;;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|재확장;ReExpPapNum;50;;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|명단없는부수;NoListPapNum;87;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|확정;FixedPaperNum2;37;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|투입;SubscribePagerNum;37;#,###;7;" & "o;n;y;5;"         '임시로 숨김 02/17
            gridAttributes = gridAttributes & "|미투입;NoSubscribePagerNum;50;#,###;7;" & "o;n;y;5;"     '임시로 숨김 02/17  
            gridAttributes = gridAttributes & "|명단상태코드;ListStatCd;105;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;87;;1;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|청구유형;BillType;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|방법코드;BillDivCd2;93;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|주기코드;BillPeriodCd;87;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;74;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독시작일자;FixedStDt;87;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;87;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;62;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|승인일자;ApprovalDt;62;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|비고;Note;291;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|이전사원확장번호;OldEmployeeExpNum;0;;4;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|;Dummy;10;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ListStatCd;명단상태코드"    '' 2401
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;수금형태코드"   ''2323
            'gridCodeNameList = gridCodeNameList & "/BillType;청구유형명"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd2;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111

            With grd_1
                .Initialize(gridAttributes, gridCodeNameList)
                .ExplorerBar = 3
                .FrozenCols = .get_ColIndex("ExpandNm")
            End With

            ' ''담당자 셋팅
            ''popEmployeeNumber.Enabled = True
            ''If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
            ''    popEmployeeNumber.Enabled = False
            ''    popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
            ''                                      GmainBusinessFunction.GetValue("로그인 ID"), _
            ''                                      GmainBusinessFunction.GetValue("역할대행사번"))
            ''End If



            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|접수일자;ContactDt4;85;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|확장처;CompanyNm;119;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|투입처;DeliveryChnlNm;128;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;191;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수독자번호;ReceiptCd;1;;1;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|독자번호;SubscribeCd;1;;1;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|전화1;PhoneNum1;116;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;231;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;232;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수신규;NewPapNum;62;;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|접수재확장;ReExpPapNum1;74;;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|접수계;TargetPaperTotNum;50;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|확정신규;NewExpPapNum;1;;c;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|확정재확장;ReExpPapNum;1;;c;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|확정계;FixedPaperNum;1;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|투입;SubscribePagerNum;1;;c;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|지국명;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|영업담당;EmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|주권유자;TrAdEmployeeNm;62;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|권유자명;BizEmpNm;1;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|청구방법코드;BillTypeCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;74;;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|수금년월;CollectionYYYY;63;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|모니터결과;Refuse;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|모니터미통과사유;RefuseReasonCd;1;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|독자상태;ReaderStateCd;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|구독상태;SubscribeStateCd;70;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt3;85;yyyy-MM-dd;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|구독시작일;FixedStDt1;85;dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|구독종료일;FixedEdDt;85;dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|서비스기간;ServiceTerm;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|중지일자;StopDt;70;yyyy-MM-dd;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|중지사유;ReturnCd;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|판매국작성;SalWtList;1;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|명단일자;MngStopDt;90;yyyy-MM-dd;1;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|명단적요;MngRemark;150;;1;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|;Dummy;10;;1;" & "o;n;n;10;"
            'grid_1 code combo    
            gridCodeNameList = ""

            With grd_2
                .Initialize(gridAttributes, gridCodeNameList)
                .ExplorerBar = 3
                .FrozenCols = .get_ColIndex("SubscriberNm")
            End With


            '==============================================================
            dtpProcYM_R.Text = Now.ToString
            numBaseDay_R.TextValue = 14
            '==============================================================

        End Sub
#End Region

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            ''사원확장 독자 등록 화면으로 JUMP.
            'If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            'Dim strCode As String '접수독자번호
            'strCode = "" _
            '          & ";" & "" _"
            '          & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
            '          & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
            '          & ";" & "" _
            '          & ";" & ""
            'GmainBusinessFunction.SetValue("화면 전환", "PNC102;" & strCode)
            'Me.ShowUiControl("PNC102", strCode)

        End Sub


#Region "화면 스플릿"
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
            Dim ppicTitle2 As Point = New Point(picTitle2.Location.X, picBar2.Location.Y + picTitle2.Location.Y - picBar.Location.Y)
            Dim plblTitle2 As Point = New Point(lblTitle2.Location.X, picBar2.Location.Y + lblTitle2.Location.Y - picBar.Location.Y)
            Dim pGrd2 As Point = New Point(grd_2.Location.X, picBar2.Location.Y + grd_2.Location.Y - picBar.Location.Y)
            '' PictureBox1, PictureBox2
            picBar2.Visible = False
            If pBar.Y >= grd_1.Location.Y + 20 And pBar.Y + 20 <= Me.Height Then
                picBar.Location = pBar
                ''grd_1.Width = 5
                picTitle2.Location = ppicTitle2
                '

                lblTitle2.Location = plblTitle2
                grd_2.Location = pGrd2

                Dim sGrd1 As Size = New Size(picBar.Width, picBar.Location.Y - grd_1.Location.Y)
                grd_1.Size = sGrd1
                Dim sGrd2 As Size = New Size(grd_2.Width, Me.Height - grd_2.Location.Y - 5)
                grd_2.Size = sGrd2
            End If
        End Sub
        Private Sub picBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseMove
            Dim p As Point = New Point(picBar.Location.X, picBar.Location.Y + e.Y)
            picBar2.Location = p
        End Sub
#End Region

        Private Sub btnBatchApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatchApply.Click
            With Me.grd_2
                For i As Integer = 1 To .Rows - 1
                    If .GetCellCheck(i, .get_ColIndex("선택")) = CheckEnum.Checked Then
                        .set_TextMatrix(i, .get_ColIndex("MngStopDt"), Me.dtpDisYearMonth.Text)
                    End If
                Next
            End With
            
        End Sub
    End Class

End Namespace
