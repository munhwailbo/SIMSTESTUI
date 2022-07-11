' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 
' form설명 :
' 작성자 : 
' 작성일 : 
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI303
        Inherits CommonControls.UiControl

#Region "폼 초기화"

        ''' <summary>
        ''' 함수명 : Initialize
        ''' 리턴값 : 
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>


        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;90;;1;" & "o;n;y;;;"
            gridAttributes = gridAttributes & "|구분;TreePath;95;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;50;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;80;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|지국코드;BranchNum;1;;4;" & "o;n;n;10;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|구분;OldOrNew;50;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지대년월;YearMonths;63;yyyy-MM;4;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|전월미수액;UnColAmt;60;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|당월매출액;SalesAmt;70;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|당월청구계;TotalDemandAmt;70;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|당월수금계;ColAmt;70;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|미입금액;DemandRemainAmt;67;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|미수누계;ThisMisuAmt;67;#,###;7;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|전월적립누계액;LastDepositAmt;91;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|당월적립액;ThisInDepositAmt;74;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|당월환불액;ThisOutDepositAmt;74;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|당월적립누계액;ThisDepositAmt;99;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;0;;4;" & "o;n;y;10;지국지역코드;BranchRegionNm"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|;Dummy;200;;1;" & "o;n;n;1000;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3

            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

        End Sub

#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : ACA003_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNI303_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

    End Class

End Namespace
