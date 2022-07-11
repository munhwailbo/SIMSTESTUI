'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 우편번호 등록
' form 설명 : 우편번호 등록,수정,삭제 합니다.
' 작성자 : 
' 작성일 : 2008-12-03
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

    Public Class PNA503
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|우편번호코드;ZipSeriesNum;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|우편번호;ZipCd;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|도;Do;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|시;City;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|동;Dong;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|리;Ri;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|도서;Island;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|산;San;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|시작번지주;SHouseNumJu;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|시작번지부;SHouseNum1Bu;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|끝번지주;EHouseNumJu;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|끝번지부;EHouseNumBu;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|아파트명;ApartmentNm;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|아파트시작동;ApartmentSDong;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|아파트끝동;ApartmentEDong;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|변경일자;ProcessDt;20;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|주소;Addr;60;;l;" & "io;n;n;5;"
            'gridAttributes = gridAttributes & "|담당자유형코드;ChargeTypeCd;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;y;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ChargeTypeCd;담당자유형코드"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNA503_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub


        Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

        End Sub
    End Class

End Namespace
