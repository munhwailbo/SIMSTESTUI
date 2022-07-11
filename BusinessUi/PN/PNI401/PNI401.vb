' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명   :[PNI401] 미수채권정보 등록	
' form설명 :미수채권정보 등록을(를) 한다	
' 작성자   :김성훈
' 작성일   :2008-09-22 18:41:53
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

    Public Class PNI401
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;y;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;80;;c;" & "io;n;n;5;지국명;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|지국장명;Name;100;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;100;;c;" & "io;n;n;5;영업사원 명;EmployeeNameHangul"
            'gridAttributes = gridAttributes & "|영업사원 명;EmployeeNameHangul;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|담당자;EmployeeNameHangul;100;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|운영개시 년월;OpenYYYYMM;100;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|운영종료 년월;EndYYYYMM;100;;c;" & "io;n;n;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1

            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;100;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;100;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|담당자명;EmployeeNameHangul;100;;c;" & "o;n;n;30;영업사원 명;EmployeeNameHangul"
            'gridAttributes = gridAttributes & "|영업사원 명;EmployeeNameHangul;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|담당자;EmployeeNameHangul;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|운영자구분코드;OperatorDivCd;100;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|보증금;DepositAmt;70;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|완납적립누계;FullPaymentAmt;100;;c;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|미수금누계;UnColAmt;100;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|미수금처리구분코드;ProcDivCd;120;;c;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|비고;Note;60;;l;" & "io;n;y;60;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ProcDivCd;미수금처리구분코드"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

            Me.grd_2.ExplorerBar = 0
        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNI401_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNI401_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub
#End Region

    End Class

End Namespace
