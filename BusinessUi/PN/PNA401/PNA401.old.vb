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

    Public Class PNA401
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
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;60;;c;" & "io;n;n;12;"
            gridAttributes = gridAttributes & "|확장처한글명;CompanyHangulNm;70;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|상위확장처코드;ParentCompanyCd;60;;c;" & "io;n;n;5;확장처 명;ParentCompanyNm;"
            gridAttributes = gridAttributes & "|상위확장처명;ParentCompanyNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|유형코드;GroupCd;60;;c;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|출력제외여부;PrintYesOrNo;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|사용여부;UseYN;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|우편번호;PostNum;70;;c;" & "io;n;n;40;우편번호;CodeHangulName"
            gridAttributes = gridAttributes & "|주소;Addr1;120;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|상세주소;Addr2;100;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|업태;BusiStatus;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|사업자번호;BusinessNum;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|대표자명;CorparationNm;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|종목;BusiType;70;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|담당자정보;ExChargeEmpInfo;70;;c;" & "io;n;n40;"
            gridAttributes = gridAttributes & "|담당자연락처;ExChargeEmpPhoneNum1;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|비고;Note;60;;l;" & "io;n;n;5;"


            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "GroupCd;확장 유형 코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNA401_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub


    End Class

End Namespace
