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

    Public Class PNI204
        Inherits CommonControls.UiControl

        Private Sub PNI204_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|구분;TreePath;80;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|청구년월;CollectYYYYMM;60;;c;" & "io;y;n;5;"
            '' ''gridAttributes = gridAttributes & "|년월;CalYearMonths;60;;l;" & "o;n;n;6;"       '(10)
          
            gridAttributes = gridAttributes & "|영업담당;ChargeEmpNum;90;;c;" & "o;n;n;10;사원번호;ChargeEmpNm;"
            gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;90;;l;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;l;" & "o;n;n;9;"       '(30)
            gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;n;5;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;90;;c;" & "o;n;n;10;지국지역코드;BranchRegionNm;"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;90;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|전월미수액;UnColAmt;90;#,##0;r;" & "o;n;n;4;"          '(70) 매출액
            gridAttributes = gridAttributes & "|매출액;SalesAmt;90;#,##0;r;" & "o;n;n;4;"          '(70) 매출액
            gridAttributes = gridAttributes & "|청구액;TotalDemandAmt;90;#,##0;r;" & "o;n;n;4;"          '(70) 매출액

            gridAttributes = gridAttributes & "|유가부수계;ValPaperNumTot;90;#,##0;r;" & "o;n;y;4;"       '(60) 부수계
            gridAttributes = gridAttributes & "|무가부수계;NoValPaperNumTot;90;#,##0;r;" & "o;n;y;4;"     '(60) 부수계

            gridAttributes = gridAttributes & "|일반유가부수;ValPaperNum1;90;#,##0;r;" & "o;n;y;4;"     '(60) 유가부수1
            gridAttributes = gridAttributes & "|일반매출;ValPaperSale1;90;#,##0;r;" & "o;n;y;4;"    '(60) 유가부수1

            gridAttributes = gridAttributes & "|구독권유가부수;ValPaperNum2;90;#,##0;r;" & "o;n;y;4;"   '(70) 유가부수2
            gridAttributes = gridAttributes & "|구독권매출;ValPaperSale2;90;#,##0;r;" & "o;n;y;4;"  '(70) 유가부수2

            gridAttributes = gridAttributes & "|기타유가부수1;ValPaperNum3;90;#,##0;r;" & "o;n;y;4;"    '(80) 유가부수3
            gridAttributes = gridAttributes & "|기타매출1;ValPaperSale3;90;#,##0;r;" & "o;n;y;4;"   '(80) 유가부수3

            gridAttributes = gridAttributes & "|기타유가부수2;ValPaperNum4;90;#,##0;r;" & "o;n;y;4;"    '(90) 유가부수4
            gridAttributes = gridAttributes & "|기타매출2;ValPaperSale4;90;#,##0;r;" & "o;n;y;4;"   '(90) 유가부수4

            gridAttributes = gridAttributes & "|지대보증금;DepositAmt1;90;#,##0;r;" & "o;n;n;4;"    '(90) 유가부수4
            gridAttributes = gridAttributes & "|완납적립금;DepositAmt2;90;#,##0;r;" & "o;n;n;4;"   '(90) 유가부수4
            'gridAttributes = gridAttributes & "|적요;Remark;90;;r;" & "o;n;n;4;"     '(60) 부수계
            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "PrintOfficeCd;공장구분코드"
            ''gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

    End Class

End Namespace
