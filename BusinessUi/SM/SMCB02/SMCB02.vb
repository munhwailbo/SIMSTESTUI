'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 입퇴점관리
' form 설명 : 입점 퇴점 이력을 조회, 추가, 수정, 삭제한다.			
' 작성자 : 박민정
' 작성일 : 2006-03-09
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

    Public Class SMCB02
        Inherits CommonControls.UiControl

        Private Sub SMCB02_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code    

            gridAttributes = gridAttributes & "||선택;선택;40;;c;" & "io;n;n;"
            gridAttributes = gridAttributes & "|역할 코드;RoleCode;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|프로그램 ID;ProgramID;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|프로그램 명;ProgramName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|조회 여부;RequestYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|저장 여부;SaveYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|삭제 여부;DeleteYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|출력 여부;PrintYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|엑셀변환 여부;ExcellRepYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|활성화 여부;ActivationYesOrNo;300;;c;" & "io;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "BusinessPlaceCode;사업장 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
        End Sub
    End Class

End Namespace
