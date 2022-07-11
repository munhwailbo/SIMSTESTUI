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

    Public Class PNI991
        Inherits CommonControls.UiControl

        Private Sub PNI991_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|마감 구분 코드;ClosingType;80;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|마감 구분 명;ClosingTypeNm;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|마감 일자;ClosingYearMonths;100;####-##-##;l;" & "o;y;n;30;"
            gridAttributes = gridAttributes & "|마감 처리 일자;ClosingDt;100;####-##-##;l;" & "o;y;n;30;"
            gridAttributes = gridAttributes & "|작업자사번;ClosingEmployee;100;;c;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|작업자명;ClosingEmployeeNm;100;;l;" & "o;n;n;10;"       '(20)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            '' ''gridCodeNameList = gridCodeNameList & "BizTypeCd;휴간구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            RequestData()

        End Sub
#End Region

    End Class

End Namespace
