'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 코드관리
' form 설명 : 문화센터 코드 관리
' 작성자 : 고재민
' 작성일 : 2006-04-06
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDA11
        Inherits CommonControls.UiControl

        Private Sub SMDA11_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;;"
            gridAttributes = gridAttributes & "|시스템 구분;SystemDivision;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|프로그램 ID;ProgramId;80;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|프로그램 명;ProgramName;150;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|1주 누계;Weeks;80;#,##0;r;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|1개월 누계;Months;80;#,##0;r;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|3개월 누계;ThreeMonths;80;#,##0;r;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|6개월 누계;SixMonths;80;#,##0;r;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|1년 누계;Years;80;#,##0;r;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|;Dummy;20;;l;" & "o;n;n;50;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

        End Sub

    End Class

End Namespace
