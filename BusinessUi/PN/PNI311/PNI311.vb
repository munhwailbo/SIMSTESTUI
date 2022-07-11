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

    Public Class PNI311
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNI311_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            '' '' '' ''==============================================================
            '' '' '' ''  grid_1 를 초기화 한다.
            '' '' '' ''--------------------------------------------------------------
            ' '' '' ''Dim gridAttributes As String = ""
            '' '' '' ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            ' '' '' ''gridAttributes = gridAttributes & "a;r;y"

            '' '' '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' '' '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            ' '' '' ''gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            ' '' '' ''gridAttributes = gridAttributes & "|입금일자;ColDt;80;;c;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|순번;ColOrders;60;;r;" & "o;n;y;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|입금구분코드;ColTypeCd;85;;c;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|입금계좌번호;ColBankCd;85;;c;" & "o;n;n;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|계좌번호;ColAccountNum;85;;c;" & "o;n;y;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|입금자명;Recipient;85;;c;" & "o;n;n;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|입금금액;ColAmt;60;#,###;r;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|적요;Note;120;;l;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|지대입금년월;CalYearMonths;85;;c;" & "o;n;n;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|지국번호;BranchNum;85;;c;" & "o;n;n;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|지국코드;BranchCd;85;;c;" & "o;n;y;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|지국명;BranchNm;85;;l;" & "o;n;n;40;"

            ' '' '' ''gridAttributes = gridAttributes & "|지국장성명;BranchChiefCdName;80;;c;" & "o;n;n;10;"
            ' '' '' ''gridAttributes = gridAttributes & "|영업담당명;ChargeEmpNm;90;;l;" & "o;n;n;10;"
            ' '' '' ''gridAttributes = gridAttributes & "|입금담당명;ProcEmpNm;85;;l;" & "o;n;n;40;"

            ' '' '' ''gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;85;;c;" & "o;n;n;40;지국장코드;BranchChiefCdName"
            ' '' '' ''gridAttributes = gridAttributes & "|영업담당;ChargeEmpNum;90;;c;" & "o;n;n;10;사원번호;ChargeEmpNm;"
            ' '' '' ''gridAttributes = gridAttributes & "|입금담당사번;ProcEmpNum;85;;c;" & "o;n;n;40;"

            ' '' '' ''gridAttributes = gridAttributes & "| ;Jiral;85;;l;" & "o;n;n;40;"

            '' '' '' ''grid code combo
            ' '' '' ''Dim gridCodeNameList As String = ""
            ' '' '' ''gridCodeNameList = gridCodeNameList & "ColBankCd;입금계좌코드"
            ' '' '' ''gridCodeNameList = gridCodeNameList & "/ColTypeCd;입금구분코드"
            '' '' '' ''gridCodeNameList = gridCodeNameList & "ProjectID;프로젝트 명"

            ' '' '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' '' ''--------------------------------------------------
            ' '' '' ''Me.grd_1.ExplorerBar = 0
            ' '' '' ''grd_1.ExplorerBar = 3

        End Sub
#End Region

        Private Sub btnExec1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExec1.Click
            '' 대체 처리
            SaveData()
        End Sub

        Private Sub btnExec2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExec2.Click
            '' 대체 취소
            DeleteData()
        End Sub
    End Class

End Namespace
