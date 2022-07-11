'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : SP 목록 등록
' form 설명 : SP 목록 등록 한다.
' 작성자 : 황인중
' 작성일 : 2007-07-12
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB302
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code

            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지급일자;PaymentDt;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;70;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchNm;70;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|이전일자;TransferDate;60;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|지급년월;PayYYYYMM;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|임차료;RentAmt;80;#,##0;r;" & "io;n;n;30;"

            gridAttributes = gridAttributes & "|담당 명;EmployeeNameHangul;10;;;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|은행코드;BankCd;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|건물주와의관계;OwnerRelation;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|비고;Note;60;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|;dumi;150;;l;" & "o;n;n;30;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

        End Sub


        Private Sub PNB302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub



    End Class

End Namespace

