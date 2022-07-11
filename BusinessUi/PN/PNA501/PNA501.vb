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

    Public Class PNA501
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            '==============================================================
            '  grid_1 를 초기화 한다.   <지국M>
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;90;;c;" & "o;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|담당자;ChargeEmpNum;80;;c;" & "o;n;n;10;사원 명;ChargeEmpNumNm"
            gridAttributes = gridAttributes & "|담당자명;ChargeEmpNumNm;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당자유형;ChargeTypeCd;120;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '끝자리 맞추기 용

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ChargeTypeCd;담당자유형코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;10;;;" & "io;n;y;10;"       '(20)
            gridAttributes = gridAttributes & "|순번;SeriesNum;10;;;" & "io;n;y;10;"       '(20)
            gridAttributes = gridAttributes & "|우편번호;ZipSeriesNum;10;;;" & "io;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|주소;Addr;30;;;" & "o;n;n;30;"       '(30)
            'grid_1 code combo    
            gridCodeNameList = ""
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3

            '==============================================================
            '  grid_3 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;10;;;" & "io;n;n;10;지국 명;BranchNm"       '(20)
            gridAttributes = gridAttributes & "|지국명;BranchNm;10;;;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|순번;SeriesNum;10;;;" & "io;n;y;10;"       '(20)
            gridAttributes = gridAttributes & "|우편번호;ZipSeriesNum;10;;;" & "io;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|주소;Addr;30;;;" & "o;n;n;30;"       '(30)
            'grid_1 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_3.ExplorerBar = 3


        End Sub

        Private Sub PNA501_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

    End Class

End Namespace
