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

    Public Class PND301
        Inherits CommonControls.UiControl
        '====================================================================================================
        

#Region "폼 초기화"

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
            gridAttributes = gridAttributes & "|Pkey;Pkey;4;;;" & "io;n;y;4;"       '(10)
            gridAttributes = gridAttributes & "|회차;MtOrders;4;;;" & "io;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|프로모션 명;PromotionNm;30;;;" & "io;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|투입 확장처 코드;CompanyCd;4;;;" & "io;n;n;4;확장처 명;CompanyHangulNm"       '(40)
            gridAttributes = gridAttributes & "|확장처 명;CompanyHangulNm;50;;;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|투입 주소;CompanyAddr;90;;c;" & "io;n;y;50;"       '(60)
            gridAttributes = gridAttributes & "|유가 부수;ValPaperNum;4;#,##0;r;" & "io;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|담당 지국 코드;ProBranchNum;9;;c;" & "io;n;n;9;지국코드;BranchNm"       '(70)
            gridAttributes = gridAttributes & "|지국 명;BranchNm;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|담당자 사번;ProEmployeeNumber;8;;c;" & "io;n;n;8;영업사원 명;EmployeeNameHangul"       '(80)
            'gridAttributes = gridAttributes & "|영업사원 명;EmployeeNameHangul;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|담당자;EmployeeNameHangul;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|적요;Remak;200;;;" & "io;n;n;200;"       '(90)
            gridAttributes = gridAttributes & "|시작 일자;StartDate;8;;;" & "io;n;n;8;"       '(100)
            gridAttributes = gridAttributes & "|종료 예정 일자;PlanEndDate;8;;;" & "io;n;n;8;"       '(110)
            gridAttributes = gridAttributes & "|종료 일자;EndDate;8;;;" & "io;n;n;8;"       '(120)
            gridAttributes = gridAttributes & "|진행상태코드;IngStateCd;5;;;" & "io;n;n;5;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "IngStateCd;진행상태코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PND301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

        
    End Class

End Namespace
