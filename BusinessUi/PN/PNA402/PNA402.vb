'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 관리비항목수정삭제
' form 설명 : 관리비 항목을 등록 수정 합니다.
' 작성자 : 임종성
' 작성일 : 2006-03-07
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

    Public Class PNA402
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|프로젝트 ID;ProjectID;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|프로젝트 명;ProjectName;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|사업 코드;CumpanyCode;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|거래처 코드;Customercode;70;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ProjectID;프로젝트 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNA402_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub


    End Class

End Namespace
