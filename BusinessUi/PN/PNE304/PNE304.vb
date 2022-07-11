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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE304
        Inherits CommonControls.UiControl

        Private Sub PNE304_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|부서;TrAdEmployeeDeptCd;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|부서;TrAdEmployeeDeptNm;92;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|부서(현재);DeptCd;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|부서(현재);DeptNm;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|권유자;TrAdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|권유자;TrAdEmployeeNm;95;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|확장처명;CompanyCd;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;112;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;183;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화1;PhoneNum1;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화2;PhoneNum2;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰;MobileNum;93;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;161;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|주소;OldAddr2;139;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|관할지국;BranchCd;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|관할지국;BranchNm;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|영업담당;ChargeEmpNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|영업담당;ChargeEmpNm;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|신규확장부수;FixedPNum_new;80;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|재확장부수;FixedPNum_re;80;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|확장부수계;FixedPNum_tot;80;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;80;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|중지상태;DokjaState;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|독자상태;ReaderStateCd;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|구독상태;SubscribeStateCd;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|수금형태;CollectionTypeCd;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|확장접수일자;ContactDt;80;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|중지일자;RealEdDt;80;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|만료일자;FixedEdDt;80;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|비고;Remark;80;;1;" & "o;n;n;30;"


            Me.dtpFixedEdDtFr.TextValue = ""
            Me.dtpFixedEdDtTo.TextValue = ""

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;구독상태코드"
            gridCodeNameList = gridCodeNameList & "/CollectionTypeCd;수금형태코드"
            ' ''gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            ' ''gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;투입지국코드"
            ' ''gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            ' ''gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            ' ''gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3


            ' ''담당자 셋팅
            ''popBizChargeCd.Enabled = True
            ''If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
            ''    popBizChargeCd.Enabled = False
            ''    popBizChargeCd.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
            ''                                   GmainBusinessFunction.GetValue("로그인 ID"), _
            ''                                   GmainBusinessFunction.GetValue("역할대행사번"))
            ''End If

        End Sub
#End Region
      


    End Class

End Namespace
