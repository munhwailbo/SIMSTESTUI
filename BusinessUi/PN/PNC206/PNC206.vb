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

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC206
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|독자번호;SubscribeCd;89;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|구분;SatStat;43;;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|평일독자명;SubscribeCd2;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|순번;Orders;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|독자명;SubscribeNm;107;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호;PhoneNum1;102;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|휴대폰번호;MobileNum;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;145;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;162;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|투입요청일자;FixedStDt;88;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|지국번호;BranchPhoneNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;78;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|영업담당코드;ChargeEmpNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|영업담당;ChargeEmpNm;72;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|영업담당 전화;ChargeEmpPhNum;0;;1;" & "o;n;y;30;"
9:          gridAttributes = gridAttributes & "|영업담당 핸드폰;ChargeEmpMbNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;                       "

            gridAttributes = gridAttributes & "|;Dummy;100;;l;" & "o;n;n;10;"       '(60)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            '' ''gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            '' ''gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;구독상태코드"
            '' ''gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;투입지국코드"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            '' ''gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '' ''gridAttributes = gridAttributes & "|독자번호;SubscribeCd;200;;l;" & "o;n;n;30;"       ' 구독번호        
            '' ''gridAttributes = gridAttributes & "|순번;Orders;200;;l;" & "o;n;y;30;"       ' 순번            
            '' ''gridAttributes = gridAttributes & "|(토요)독자 명;SatReaderNm;200;;l;" & "o;n;n;30;"       ' 토요배달 독자 명
            '' ''gridAttributes = gridAttributes & "|(토요)접수일자;SatReceiptDt;200;;l;" & "o;n;n;30;"       ' 접수일자        
            '' ''gridAttributes = gridAttributes & "|(토요)우편번호;SatOldPostNum;200;;l;" & "o;n;y;30;"       ' 구우편번호      
            '' ''gridAttributes = gridAttributes & "|(토요)주소;SatOldAddr1;200;;l;" & "o;n;n;30;"       ' 주소            
            '' ''gridAttributes = gridAttributes & "|(토요)상세주소;SatOldAddr2;200;;l;" & "o;n;n;30;"       ' 상세주소        
            '' ''gridAttributes = gridAttributes & "|(토요)전화번호;SatPhoneNum1;200;;l;" & "o;n;n;30;"       ' 전화번호        
            '' ''gridAttributes = gridAttributes & "|(토요)휴대폰번호;SatMobileNum;200;;l;" & "o;n;n;30;"       ' 휴대폰번호      
            '' ''gridAttributes = gridAttributes & "|(토요)지국코드;SatBranchCd;200;;l;" & "o;n;n;30;"       ' 지국코드        
            '' ''gridAttributes = gridAttributes & "|(토요)투입요청일;SatDeliveryReqDt;200;;l;" & "o;n;n;30;"       ' 투입요청일      
            '' ''gridAttributes = gridAttributes & "|(토요)진행상태;SatRealEdDt;200;;l;" & "o;n;y;30;"       ' 진행상태코드    
            '' ''gridAttributes = gridAttributes & "|(토요)중지일자;SatIngStateCd;200;;l;" & "o;n;y;30;"       ' 중지일자        
            '' ''gridAttributes = gridAttributes & "|(토요)배달여부;SatDeliveryYn;200;;l;" & "o;n;y;30;"       ' 배달여부        
            '' ''gridAttributes = gridAttributes & "|(토요)통보여부;SatResultYn;200;;l;" & "o;n;y;30;"       ' 통보여부        
            '' ''gridAttributes = gridAttributes & "|(평일)독자명;ReaderNm;200;;l;" & "o;n;n;30;"       ' 독자명          
            '' ''gridAttributes = gridAttributes & "|(평일)전화번호1;PhoneNum1;200;;l;" & "o;n;n;30;"       ' 전화번호1       
            '' ''gridAttributes = gridAttributes & "|(평일)전화번호2;PhoneNum2;200;;l;" & "o;n;n;30;"       ' 전화번호2       
            '' ''gridAttributes = gridAttributes & "|(평일)핸드폰번호;MobileNum;200;;l;" & "o;n;n;30;"       ' 핸드폰번호      
            '' ''gridAttributes = gridAttributes & "|(평일)구우편번호;OldPostNum;200;;l;" & "o;n;y;30;"       ' 구우편번호      
            '' ''gridAttributes = gridAttributes & "|(평일)주소;OldAddr1;200;;l;" & "o;n;n;30;"       ' 구주소          
            '' ''gridAttributes = gridAttributes & "|(평일)상세주소;OldAddr2;200;;l;" & "o;n;n;30;"       ' 구상세주소      
            '' ''gridAttributes = gridAttributes & "|(평일)투입지국코드;DeliveryBranchCd;200;;l;" & "o;n;n;30;"       ' 투입지국코드    
            '' ''gridAttributes = gridAttributes & "|(평일)지국번호;BranchPhoneNum;200;;l;" & "o;n;n;30;"       ' 지국번호        
            '' ''gridAttributes = gridAttributes & "|(평일)영업담당코드;BizChargeCd;200;;l;" & "o;n;y;30;"       ' 영업담당코드    
            '' ''gridAttributes = gridAttributes & "|(평일)영업담당;ChargeEmpNum;200;;l;" & "o;n;n;30;"       ' 영업담당        
            '' ''gridAttributes = gridAttributes & "|(평일)영업담당 전화;ChargePhoneNum  ;200;;l;" & "o;n;y;30;"       ' 영업담당 전화   

            '담당자 셋팅
            popEmployeeNumber.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popEmployeeNumber.Enabled = False
                popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("로그인 ID"), _
                                                  GmainBusinessFunction.GetValue("역할대행사번"))
            End If

        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC206_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC206_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            ' ''독자구독정보화면으로 이동
            ''If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            ''Dim strSubscribeCd As String '구독번호
            ''Dim strSubscriberNm As String '독자명

            ''strSubscribeCd = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscribeCd")) '구독번호
            ''strSubscriberNm = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscriberNm")) '독자명

            ''GmainBusinessFunction.SetValue("화면 전환", "PNC201;" & strSubscribeCd & ";" & strSubscriberNm)
            ''Me.ShowUiControl("PNC201", strSubscribeCd)
        End Sub

        Private Sub chkState1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkState1.CheckedChanged
            sbSetState()
        End Sub

        Private Sub chkState2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkState2.CheckedChanged
            sbSetState()
        End Sub

        Private Sub sbSetState()
            lblReaderStateCd_R.Visible = True
            cboReaderStateCd.Visible = True
            If chkState1.Checked = True Or chkState2.Checked = True Then
                lblReaderStateCd_R.Visible = False
                cboReaderStateCd.Visible = False
            End If
        End Sub

    End Class

End Namespace
