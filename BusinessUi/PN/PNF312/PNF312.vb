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

    Public Class PNF312
        Inherits CommonControls.UiControl

        Private Sub PNF312_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|지국명;BranchName;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|구독일자;SubscribeDate;73;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|청구일자;BillDate;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|확장처명;CompanyName;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|독자명;ReaderName;161;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화1;ReaderTel1;100;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화2;ReaderTel2;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|핸드폰;ReaderHp;93;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|우편번호;ReaderZipCode;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|주소;ReaderAddress1;193;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|상세주소;ReaderAddress2;232;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|투입부수;ThrowNo;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|등록일자;RegDate;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|모니터승인여부;IsAccept;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|담당코드;ChargeeEmpNum;232;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|담당명;ChrageEmpNm;232;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|기존독자여부;IsExist;0;;1;" & "o;n;y;30;"

            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ReaderStateCd;독자상태코드"
            'gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;구독상태코드"
            'gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            'gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"
            'gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            'gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

        'Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

        '    '지국확장 독자 등록 화면으로 JUMP.
        '    If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
        '    Dim strCode As String '접수독자번호
        '    strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
        '              & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
        '              & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
        '              & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm")
        '    GmainBusinessFunction.SetValue("화면 전환", "PNC101;" & strCode)
        '    Me.ShowUiControl("PNC101", strCode)
        'End Sub



    End Class

End Namespace
