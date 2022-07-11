'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 사원별 프로그램 권한현황
' form 설명 : 사원별 프로그램 권한현황을 조회한다.			
' 작성자 : 황인중
' 작성일 : 2007-02-02 토요일
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDA15
        Inherits CommonControls.UiControl

        Private Sub SMDA15_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================


        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code    

            gridAttributes = gridAttributes & "||선택;선택;20;;4;" & "i;n;y;"
            gridAttributes = gridAttributes & "|점검일자;CheckDate;100;;c;" & "io;y;y;30;"
            gridAttributes = gridAttributes & "|업무구분;WorkDivision;70;;l;" & "io;y;n;30;"
            gridAttributes = gridAttributes & "|순번;Seq;35;;r;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|점검ID;CheckID;350;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|상태코드;StateCode;80;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|오류건수;ErrorCount;80;;r;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|점검내역;CheckContent;450;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|처리일자;TreatDate;60;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|처리자;TreatEmployee;40;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|처리결과;TreatResult;40;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|;;50;;c;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "PlanDiligenceLazinessCode;근태 코드 명"
            'gridCodeNameList = gridCodeNameList & "/WorkDiligenceLazinessCode;근태 코드 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1

            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;20;;4;" & "i;n;y;"
            gridAttributes = gridAttributes & "|점검일자;CheckDate;100;;c;" & "io;y;y;30;"
            gridAttributes = gridAttributes & "|업무구분;WorkDivision;70;;l;" & "io;y;y;30;"
            gridAttributes = gridAttributes & "|순번;Seq;35;;r;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|점검ID;CheckID;350;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|상태코드;StateCode;80;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|오류건수;ErrorCount;80;;r;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|점검내역;CheckContent;500;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|처리일자;TreatDate;60;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|처리자;TreatEmployee;40;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|처리결과;TreatResult;40;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"                   '더미


            'grid code combo
            gridCodeNameList = ""

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

            Me.grd_2.ExplorerBar = 3

        End Sub

    End Class

End Namespace
