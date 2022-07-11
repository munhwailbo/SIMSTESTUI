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

    Public Class PNG203
        Inherits CommonControls.UiControl

        Private Sub PNG203_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|정산년월;YYYYMM;60;;l;" & "o;n;n;6;"       '(10)
            gridAttributes = gridAttributes & "|정산일자;CalDt;200;;l;" & "o;n;n;20;"       '(20)
            gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;l;" & "o;n;n;9;"       '(30)
            gridAttributes = gridAttributes & "|지원비구분코드;DivCd;100;;l;" & "o;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|부수;PaperNum;40;;r;" & "o;n;n;4;"       '(50)
            gridAttributes = gridAttributes & "|단가;UnitCost;150;;r;" & "o;n;n;15;"       '(60)
            gridAttributes = gridAttributes & "|지원비금액;SupAmt;150;;r;" & "o;n;n;15;"       '(70)
            gridAttributes = gridAttributes & "|이체금액;TransferAmt;150;;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|공제금액;DeductAmt;150;;r;" & "o;n;n;15;"       '(90)
            gridAttributes = gridAttributes & "|은행코드;BankCd;200;;l;" & "o;n;n;20;"       '(100)
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;200;;l;" & "o;n;n;20;"       '(110)
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;200;;l;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|비고;Note;200;;l;" & "o;n;n;1000;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub
#End Region

    End Class

End Namespace
