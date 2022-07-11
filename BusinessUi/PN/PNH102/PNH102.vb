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

    Public Class PNH102
        Inherits CommonControls.UiControl

        Private Sub PNH102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|구분;TreePath;113;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|년월;YYYYMM;60;yyyy-MM;4;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|부서명;DeptNm;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|부서코드;DeptCd;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당명;EmployeeNameHangul;53;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;79;;4;" & "o;n;n;10;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;68;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|평균;PrintPaperNum_avg;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|01;PrintPaperNum_01;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|02;PrintPaperNum_02;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|03;PrintPaperNum_03;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|04;PrintPaperNum_04;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|05;PrintPaperNum_05;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|06;PrintPaperNum_06;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|07;PrintPaperNum_07;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|08;PrintPaperNum_08;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|09;PrintPaperNum_09;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|10;PrintPaperNum_10;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|11;PrintPaperNum_11;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|12;PrintPaperNum_12;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|13;PrintPaperNum_13;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|14;PrintPaperNum_14;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|15;PrintPaperNum_15;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|16;PrintPaperNum_16;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|17;PrintPaperNum_17;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|18;PrintPaperNum_18;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|19;PrintPaperNum_19;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|20;PrintPaperNum_20;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|21;PrintPaperNum_21;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|22;PrintPaperNum_22;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|23;PrintPaperNum_23;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|24;PrintPaperNum_24;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|25;PrintPaperNum_25;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|26;PrintPaperNum_26;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|27;PrintPaperNum_27;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|28;PrintPaperNum_28;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|29;PrintPaperNum_29;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|30;PrintPaperNum_30;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|31;PrintPaperNum_31;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|공장구분;PrintOfficeCd;56;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|판구분;PrintPlateCd;53;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|계;PrintPaperNum_tot;60;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;0;;4;" & "o;n;y;10;지국지역코드;"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;60;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "PrintOfficeCd;공장구분코드"
            'gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '--------------------------------------------------------------------
            '---  2008.10.23 변경 ...  음 ... 이해력... 
            '--------------------------------------------------------------------
            'gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            'gridAttributes = gridAttributes & "|년월;YYYYMM;60;;l;" & "io;n;n;6;"       '(10)
            'gridAttributes = gridAttributes & "|일;DD;20;;l;" & "io;n;n;2;"       '(20)
            'gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;90;;c;" & "o;n;n;10;지국지역코드;;"
            'gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;90;;c;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;c;" & "io;n;n;10;지국코드;BranchNm"
            ' ''gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "io;n;n;5;지국코드;BranchNm"
            'gridAttributes = gridAttributes & "|지국명;BranchNm;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|공장구분코드;PrintOfficeCd;100;;l;" & "io;n;n;10;"       '(40)
            'gridAttributes = gridAttributes & "|판구분코드;PrintPlateCd;100;;l;" & "io;n;n;10;"       '(50)
            'gridAttributes = gridAttributes & "|인쇄부수;PrintPaperNum;40;#,##0;r;" & "io;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|적요;Remark;40;;l;" & "io;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            '--------------------------------------------------------------------

        End Sub
#End Region

        Private Sub lblCodeDivisionHangulName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
        Private Sub dtpBaseYear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

  
    End Class

End Namespace
