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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC205
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
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|독자번호;SubscribeCd;200;;l;" & "io;n;y;30;"       '(40)
            gridAttributes = gridAttributes & "|접수독자번호;ReceiptCd;200;;l;" & "o;n;y;30;"       '(40)
            gridAttributes = gridAttributes & "|확장구분;ExpandDivCd;200;;l;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|독자상태;ReaderStateCd;100;;l;" & "o;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|구독상태;SubscribeStateCd;100;;l;" & "io;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|중지일자;RealEdDt;100;yyyy-mm-dd;l;" & "io;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|명단일자;MngStopDt;100;yyyy-mm-dd;l;" & "io;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;200;;l;" & "o;n;n;30;"       '(40)

            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;100;;l;" & "o;n;n;10;"       '(60)
            gridAttributes = gridAttributes & "|확장일자;ContactDt;80;;l;" & "o;n;n;8;"       '(20) 접수일자

            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;200;;l;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;200;;l;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;100;;l;" & "o;n;y;10;우편번호;OldPostNm"
            gridAttributes = gridAttributes & "|주소;OldPostNm;90;;c;" & "o;n;y;5;"       '(130)
            gridAttributes = gridAttributes & "|주소;OldAddr1;200;;l;" & "o;n;n;50;"       '(140)
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;200;;l;" & "o;n;n;100;"       '(150)

            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;200;;l;" & "o;n;y;30;"       '(10)
            '' 'gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;70;;l;" & "o;n;n;7;지국코드;DeliveryBranchNm"       '(300)
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;70;;l;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국 명;DeliveryBranchNm;70;;l;" & "o;n;n;7;"

            gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;20;#,##0;c;" & "o;n;n;10;"       '(230)투입부수
            gridAttributes = gridAttributes & "|배달구분;DeliveryDivCd;100;;l;" & "o;n;n;10;"       '(230) 배달구분코드(2313) 
            gridAttributes = gridAttributes & "|배달처;DeliveryRegionCd;100;;l;" & "o;n;n;10;"       '(410) 배달처구분코드(2314)
            gridAttributes = gridAttributes & "|본사독자구분;MHReaderDivCd;100;;l;" & "o;n;n;10;"       '(410) 본사독자구분코드(2316)

            gridAttributes = gridAttributes & "|투입일자;FixedStDt;100;;l;" & "o;n;n;10;"       '(410)
            gridAttributes = gridAttributes & "|만료일자;FixedEdDt;100;;l;" & "o;n;n;10;"       '(410)
            gridAttributes = gridAttributes & "|서비스기간;ServiceTerm;100;;c;" & "o;n;n;10;"       '(410)
            gridAttributes = gridAttributes & "|수금년월;CollectionYYYYMM;100;;l;" & "o;n;n;10;"       '(410)

            gridAttributes = gridAttributes & "|(신)우편번호;NewPostNum;100;;l;" & "o;n;y;10;우편번호;NewPostNm"
            gridAttributes = gridAttributes & "|(신)주소;NewPostNm;90;;c;" & "o;n;y;5;"       '(100)
            gridAttributes = gridAttributes & "|(신)주소;NewAddr1;200;;l;" & "o;n;y;50;"       '(110)
            gridAttributes = gridAttributes & "|(신)상세주소;NewAddr2;200;;l;" & "o;n;y;100;"       '(120)

            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;10;;c;" & "o;n;n;1;"       '(390)
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|판매국작성명단여부;SalWtListYn;100;;l;" & "o;n;n;10;"       '(60)
            gridAttributes = gridAttributes & "|투입처코드;DeliveryChnlCd;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|투입처명;DeliveryChnlNm;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|구독권독자여부;CouponReaderYN;100;;l;" & "o;n;y;10;"       '(410)
            gridAttributes = gridAttributes & "|소속사코드;CouponSeriesNum;100;;l;" & "o;n;y;10;"       '(410)

            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;200;;l;" & "o;n;y;30;"       '(80)
            gridAttributes = gridAttributes & "|;Dummy;100;;l;" & "o;n;n;10;"       '(60)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;구독상태코드"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;투입지국코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3

            Me.NewData()

        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC205_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC205_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        ''' <summary>
        ''' 함수명 : grd_1_DoubleClick 
        ''' 기  능 : 
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick
            '독자구독정보화면으로 이동
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim strSubscribeCd As String '구독번호
            Dim strSubscriberNm As String '독자명

            strSubscribeCd = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscribeCd")) '구독번호
            strSubscriberNm = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscriberNm")) '독자명

            GmainBusinessFunction.SetValue("화면 전환", "PNC201;" & strSubscribeCd & ";" & strSubscriberNm)
            Me.ShowUiControl("PNC201", strSubscribeCd)
        End Sub

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Try
                With grd_1
                    If (.Rows > .FixedRows) Then
                        For intII As Integer = .FixedRows To .Rows - 1
                            If .GetCellCheck(intII, .get_ColIndex("선택")) = CheckEnum.Checked Then
                                .set_TextMatrix(intII, .get_ColIndex("SubscribeStateCd"), cboReaderStateCd_E.Text)
                                .set_TextMatrix(intII, .get_ColIndex("RealEdDt"), dtpRealEdDt.Text)
                                .set_TextMatrix(intII, .get_ColIndex("MngStopDt"), dtpRealEdDt.Text)
                                .SetCellCheck(intII, .get_ColIndex("선택"), CheckEnum.Checked)
                            End If
                        Next intII
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End Sub
    End Class

End Namespace
