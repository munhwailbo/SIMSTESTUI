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

    Public Class PNA403
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;100;;c;" & "io;y;n;4;"
            gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;150;;l;" & "io;y;n;30;"
            gridAttributes = gridAttributes & "|독자명단여부;ReaderListYN;200;;l;" & "io;n;n;100;"

            ' ------ 2013.11.01 거래처코드 매핑 위하여 추가
            gridAttributes = gridAttributes & "|거래처코드;CustomerCode;80;;c;" & "io;n;n;30;거래처코드;CustomerName"
            gridAttributes = gridAttributes & "|거래처명;CustomerName;150;;c;" & "o;n;n;30;"
            ' ------ 2013.11.01 거래처코드 매핑 위하여 추가

            gridAttributes = gridAttributes & "|사업자등록번호;BusinessNum;100;;c;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|상호;FirmNm;150;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|대표자명;PresidentNm;150;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|우편번호;PostNum;80;;c;" & "o;n;y;7;우편번호;Addr1"
            gridAttributes = gridAttributes & "|주소;Addr1;200;;l;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|상세주소;Addr2;200;;l;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|업태;BusiStatus;150;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|종목;BusiType;150;;c;" & "o;n;y;30;"


            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNA403_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub


    End Class

End Namespace
