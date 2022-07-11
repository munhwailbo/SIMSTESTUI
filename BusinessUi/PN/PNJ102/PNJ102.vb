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

    Public Class PNJ102
        Inherits CommonControls.UiControl

        Private Sub PNJ102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|구분;TreePath;80;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;80;;c;" & "o;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;110;;l;" & "o;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|발행년월;PublishDt;70;;c;" & "io;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|발행부수;CirculationNum;70;#,##0;c;" & "o;n;n;4;"       '(70)
            gridAttributes = gridAttributes & "|구독권발행코드;CouponPublicCd;1;;c;" & "io;n;y;10;"       '(10)
            gridAttributes = gridAttributes & "|발행순번;Orders;65;;c;" & "io;n;n;20;"       '(30)
            gridAttributes = gridAttributes & "|발행상세순번;DetailOrders;90;;c;" & "io;n;n;20;"       '(110)
            gridAttributes = gridAttributes & "|발행바코드;PublishBarCode;140;;c;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|발행시작번호;PublishStNum;1;;l;" & "o;n;y;30;"       '(50)
            gridAttributes = gridAttributes & "|발행종료번호;PublishEdNum;1;;l;" & "o;n;y;8;"       '(60)

            gridAttributes = gridAttributes & "|발행단가;UnitCost;60;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|비고;Note;100;;l;" & "o;n;n;1000;"       '(90)
            gridAttributes = gridAttributes & "|출력일자;PrintDt;100;;c;" & "o;n;n;20;"       '(130)
            gridAttributes = gridAttributes & "| ;Dummy;5;;c;" & "o;n;n;20;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub
#End Region

        
    End Class

End Namespace
