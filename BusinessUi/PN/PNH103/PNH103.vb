'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 코드관리
' form 설명 : 문화일보 코드 관리
' 작성자 : 권진성
' 작성일 : 2008.09.01
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

    Public Class PNH103
        Inherits CommonControls.UiControl

        Private Sub PNH103_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "폼 초기화"
        ''' <summary>
        ''' 함수명 : Initialize
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|구분;TreePath;121;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|년월;YYYYMM;56;yyyy-MM;4;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|일;DD;27;dd;4;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|부서명;DeptNm;66;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|부서코드;DeptCd;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|담당자명;ChargeEmpNm;57;;1;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;54;;4;" & "o;n;n;10;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;67;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|인쇄부수;PrintPaperNum;62;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|유가부수;PrintValPaperNum;62;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|무가부수;PrintNoValPaperNum;62;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|공장구분코드;PrintOfficeCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|판구분코드;PrintPlateCd;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;87;;4;" & "o;n;n;10;지국지역코드;"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;112;;4;" & "o;n;n;10;                   "
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "PrintOfficeCd;공장구분코드"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            ' '' '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ' '' '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            '' '' ''gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            '' '' ''gridAttributes = gridAttributes & "|년월;YYYYMM;60;;l;" & "o;n;n;6;"       '(10)
            '' '' ''gridAttributes = gridAttributes & "|일;DD;20;;l;" & "o;n;n;2;"       '(20)
            '' '' ''gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;c;" & "io;n;n;10;"
            '' '' ''gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;n;5;지국코드;BranchNm"
            '' '' ''gridAttributes = gridAttributes & "|지국명;BranchNm;60;;l;" & "o;n;n;5;"
            '' '' ''gridAttributes = gridAttributes & "|공장구분코드;PrintOfficeCd;100;;l;" & "o;n;n;10;"       '(40)
            '' '' ''gridAttributes = gridAttributes & "|판구분코드;PrintPlateCd;100;;l;" & "o;n;n;10;"       '(50)
            '' '' ''gridAttributes = gridAttributes & "|인쇄부수;PrintPaperNum;40;;r;" & "o;n;n;4;"       '(60)
            '' '' ''gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            ' '' '' ''grid_1 code combo    
            '' '' ''Dim gridCodeNameList As String = ""
            '' '' ''gridCodeNameList = gridCodeNameList & "PrintOfficeCd;공장구분코드"
            '' '' ''gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            '' '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click

        End Sub
    End Class

End Namespace
