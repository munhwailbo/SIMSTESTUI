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

    Public Class PNI207
        Inherits CommonControls.UiControl

        Private Sub PNI207_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|년도;YYYY;60;;l;" & "o;n;y;6;"       '(10)

            gridAttributes = gridAttributes & "|지국코드;BranchCd;10;;c;" & "o;n;y;10;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;80;;l;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|표시구분;DispGb;50;;c;" & "o;n;y;10;;"
            gridAttributes = gridAttributes & "|업체코드;CustCd;1;;c;" & "o;n;n;1;;"
            gridAttributes = gridAttributes & "|업체명;CustNm;120;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|계;MM_00;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|01;MM_01;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|02;MM_02;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|03;MM_03;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|04;MM_04;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|05;MM_05;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|06;MM_06;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|07;MM_07;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|08;MM_08;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|09;MM_09;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|10;MM_10;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|11;MM_11;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|12;MM_12;60;#,##0;r;" & "o;n;n;4;"       '(60)

            gridAttributes = gridAttributes & "|청구방법;BillDivCd;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|청구주기;BillPeriodCd;60;;c;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '==============================================================


            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|년도;YYYY;60;;l;" & "o;n;y;6;"       '(10)

            gridAttributes = gridAttributes & "|지국코드;BranchCd;1;;c;" & "o;n;n;10;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;80;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|표시구분;DispGb;70;;l;" & "o;n;n;10;;"
            gridAttributes = gridAttributes & "|업체코드;CustCd;1;;c;" & "o;n;n;1;;"
            gridAttributes = gridAttributes & "|업체명;CustNm;120;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|계;MM_00;80;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|01;MM_01;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|02;MM_02;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|03;MM_03;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|04;MM_04;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|05;MM_05;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|06;MM_06;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|07;MM_07;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|08;MM_08;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|09;MM_09;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|10;MM_10;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|11;MM_11;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|12;MM_12;70;#,##0;r;" & "o;n;n;4;"       '(60)

            gridAttributes = gridAttributes & "|청구방법;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기;BillPeriodCd;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_2 code combo    
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3
            '==============================================================

            '==============================================================
            '  grid_3 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|년도;YYYY;60;;l;" & "o;n;y;6;"       '(10)

            gridAttributes = gridAttributes & "|지국코드;BranchCd;10;;c;" & "o;n;y;10;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;80;;l;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|표시구분;DispGb;50;;c;" & "o;n;y;10;;"
            gridAttributes = gridAttributes & "|업체코드;CustCd;1;;c;" & "o;n;n;1;;"
            gridAttributes = gridAttributes & "|업체명;CustNm;120;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|계;MM_00;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|01;MM_01;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|02;MM_02;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|03;MM_03;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|04;MM_04;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|05;MM_05;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|06;MM_06;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|07;MM_07;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|08;MM_08;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|09;MM_09;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|10;MM_10;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|11;MM_11;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|12;MM_12;60;#,##0;r;" & "o;n;n;4;"       '(60)

            gridAttributes = gridAttributes & "|청구방법;BillDivCd;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|청구주기;BillPeriodCd;60;;c;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_3 code combo    
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_3.ExplorerBar = 3
            '==============================================================

        End Sub
#End Region

        Private Sub optBranchPa1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBranchPa1.CheckedChanged
            grd_1.Visible = True
            grd_2.Visible = False
            grd_3.Visible = False
        End Sub

        Private Sub optBranchPa2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBranchPa2.CheckedChanged
            grd_1.Visible = False
            grd_2.Visible = True
            grd_3.Visible = False
        End Sub

        Private Sub optBranchPa3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBranchPa3.CheckedChanged
            grd_1.Visible = False
            grd_2.Visible = False
            grd_3.Visible = True
        End Sub
    End Class

End Namespace
