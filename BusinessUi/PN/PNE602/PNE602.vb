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

    Public Class PNE602
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNE602_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|확장년월;ExpandYearMonth;80;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|확장년월;ExpandYearMonth_2;80;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|확장부서 코드;SoliDeptCd;90;;l;" & "io;n;y;부서 명;SoliDeptName"
            gridAttributes = gridAttributes & "|확장부서 명;SoliDeptName;90;;l;" & "io;n;y;;"
            gridAttributes = gridAttributes & "|확장부서 코드;SoliDeptCd_2;90;;l;" & "o;n;n;부서 명;SoliDeptName"
            gridAttributes = gridAttributes & "|확장부서 명;SoliDeptName_2;90;;c;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|신규부수;NewExpPapNum;70;#,###;r;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|재접수부수;ReExpPapNum;70;#,###;r;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|총부수;SumExpPapNum;70;#,###;r;" & "o;n;n;;"
            'gridAttributes = gridAttributes & "|비고;Remark;200;;l;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
        End Sub
#End Region

    End Class

End Namespace
