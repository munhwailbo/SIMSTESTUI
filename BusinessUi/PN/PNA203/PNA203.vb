'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 소속등록
' form 설명 : 
' 작성자 : 권진성
' 작성일 : 2008-09-30
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

    Public Class PNA203
        Inherits CommonControls.UiControl
        Private Sub PNA203_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

        Public Sub Initialize()
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|부서코드;DeptCd;100;;l;" & "io;n;n;10;"       '(10)
            gridAttributes = gridAttributes & "|부서명;DeptNm;200;;l;" & "io;n;n;30;"       '(20)
            gridAttributes = gridAttributes & "|부서레벨;DeptLvl;100;;l;" & "io;n;n;10;"       '(30)
            gridAttributes = gridAttributes & "|상위부서코드;ParentDeptCd;100;;l;" & "io;n;n;10;부서 명;ParentDeptNm;"       '(10)
            gridAttributes = gridAttributes & "|상위부서명;ParentDeptNm;200;;l;" & "o;n;n;30;"       '(20)
            gridAttributes = gridAttributes & "|최종여부;FinalYesOrNo;10;;c;" & "io;n;n;1;"       '(40)
            gridAttributes = gridAttributes & "|사용여부;UseYN;10;;c;" & "io;n;n;1;"       '(40)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "DeptLvl;부서 레벨"
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

        End Sub

    End Class

End Namespace
