' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 중지독자 조회
' form설명 : 중지독자 조회 한다
' 작성자 : 
' 작성일 : 2009-04-08
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

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC207
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
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|독자번호;SubscribeCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수독자번호;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|확장구분;ExpandDivCd;84;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|독자상태;ReaderStateCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|구독상태;SubscribeStateCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;140;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;106;;1;" & "o;n;n;30; "
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;0;;4;" & "o;n;y;10;우편번호;OldPostNm "
            gridAttributes = gridAttributes & "|주소;OldPostNm;0;;4;" & "o;n;y;5; "
            gridAttributes = gridAttributes & "|주소;OldAddr1;285;;1;" & "o;n;n;50; "
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;190;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|확장일자;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;87;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국 명;DeliveryBranchNm;62;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;62;#,##0;4;" & "o;n;n;10; "
            gridAttributes = gridAttributes & "|배달구분;DeliveryDivCd;62;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|배달처;DeliveryRegionCd;61;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|본사독자구분;MHReaderDivCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;85;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|만료일자;FixedEdDt;85;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|서비스기간;ServiceTerm;74;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|수금년월;CollectionYYYYMM;63;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|(신)우편번호;NewPostNum;0;;4;" & "o;n;y;10;우편번호;NewPostNm"
            gridAttributes = gridAttributes & "|(신)주소;NewPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|(신)주소;NewAddr1;0;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|(신)상세주소;NewAddr2;0;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;62;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|판매국작성명단여부;SalWtListYn;124;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;108;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|투입처코드;DeliveryChnlCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|투입처명;DeliveryChnlNm;84;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|구독권독자여부;CouponReaderYN;99;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|소속사코드;CouponSeriesNum;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|중지일자;RealEdDt;85;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;구독상태코드"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            ''gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;투입지국코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            Me.NewData()

            '' =============================================================
            popEmployeeNumber.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popEmployeeNumber.Enabled = False
                popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("로그인 ID"), _
                                                  GmainBusinessFunction.GetValue("역할대행사번"))
            End If
            '' =============================================================
            'chkState1.Checked = True
            'sbSetState()

        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC207_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC207_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            SaveData()
            NewData()
        End Sub

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

        'Private Sub chkState1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    sbSetState()
        'End Sub

        'Private Sub chkState2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    sbSetState()
        'End Sub

        'Private Sub sbSetState()
        '    lblReaderStateCd_R.Visible = True
        '    cboReaderStateCd.Visible = True
        '    If chkState1.Checked = True Or chkState2.Checked = True Then
        '        lblReaderStateCd_R.Visible = False
        '        cboReaderStateCd.Visible = False
        '    End If
        'End Sub

    End Class

End Namespace
