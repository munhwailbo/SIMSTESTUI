'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 확장처 등록
' form 설명 : 확장처를 등록합니다.
' 작성자 : 반영철
' 작성일 : 2008-09-22
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

    Public Class PNC503
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"

            gridAttributes = gridAttributes & "|발송자;Name;60;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|부서;DeptNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|발송번호;CALLBACK;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|수신자;DEST_NAME;70;;l;" & "o;n;n;40;"


            gridAttributes = gridAttributes & "|수신번호;PHONE_NUMBER;60;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|전송상태;RESULT;60;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|발송일시;SEND_DATE;60;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|발송메세지;SMS_MSG;60;;l;" & "o;n;n;50;"


            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ConsultationCd;민원구분코드"
            'gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            'gridCodeNameList = gridCodeNameList & "/StateCd;민원상태코드"
            'gridCodeNameList = gridCodeNameList & "/MonitorResultCd;모니터결과처리코드"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNC503_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

    End Class

End Namespace
