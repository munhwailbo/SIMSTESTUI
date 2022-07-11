'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 로그정보 조회
' form 설명 : 로그 정보를 조회한다.			
' 작성자 : 황인중
' 작성일 : 2006-06-13 토고전 7시간 전
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDA01
        Inherits CommonControls.UiControl

        Private Sub SMDA01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;100;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|사원 명;EmployeeName;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|IP 주소;IPAdress;100;;c;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|접속 일 시;BeginningHour;80;;c;" & "o;n;n;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            'grd_1.FrozenCols = 3
            grd_1.ExplorerBar = 3
        End Sub

        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
            'Call sbSetGridToControl()
        End Sub

    End Class

End Namespace
