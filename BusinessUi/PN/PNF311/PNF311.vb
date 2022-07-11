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

    Public Class PNF311
        Inherits CommonControls.UiControl

        Private Sub PNF311_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "n;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;171;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국코드;DeliveryBranchCd;65;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국 명;DeliveryBranchNm;103;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;74;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;83;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;56;#,##0;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당확인여부;IsAccept;76;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;0;;4;" & "o;n;y;10;우편번호;OldPostNm"
            gridAttributes = gridAttributes & "|주소;OldPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;178;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;179;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|확장일자;ContactDt;79;yyyy-MM-dd;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;79;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|만료일자;FixedEdDt;76;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|서비스기간;ServiceTerm;1;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|수금년월;CollectionYYYYMM;67;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|메모;Memo;100;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;66;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|독자번호;SubscribeCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수독자번호;ReceiptCd;70;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|WEB접수번호;WebPkey;50;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10; "

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            '' ''gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            '' ''gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;구독상태코드"
            '' ''gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            '' ''gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '지국확장 독자 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '접수독자번호
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("화면 전환", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)
        End Sub

        Private Sub btnPRB002_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRB002.Click

            '지국확장 독자 등록 화면으로 JUMP.
            '''' If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
            If Me.grd_1.GetCurrentRowCellValue("ReceiptCd").ToString.Length > 1 Then
                MsgBox("접수 처리 된 자료입니다.")
                Exit Sub
            End If

            Dim strCode As String '접수독자번호
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("WebPkey") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm") _
                      & ";" & "5"    '' '' 처리구분  2:이사 독자 신규, 3:재확장 신규, 5:WEB접수 전환
            GmainBusinessFunction.SetValue("화면 전환", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)

        End Sub
    End Class

End Namespace
