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

    Public Class PNI302
        Inherits CommonControls.UiControl

#Region "폼 초기화"

        Public Sub Initialize()

            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input out'put); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code

            gridAttributes = gridAttributes & "||선택;선택;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|입금일자;ColDt;85;yyyy-MM-dd;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|순번;ColOrders;0;;7;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|입금구분코드;ColTypeCd;155;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|입금계좌번호;ColBankCd;170;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|계좌번호;ColAccountNum;0;;4;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|입금자명;Recipient;66;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|입금금액;ColAmt;62;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|적요;Note;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지대입금년월;CalYearMonths;87;yyyy-MM;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;76;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;0;;4;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;50;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|지국장성명;BranchChiefCdName;74;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|영업담당명;ChargeEmpNm;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|입금담당명;ProcEmpNm;74;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;84;;4;" & "o;n;n;40;지국장코드;BranchChiefCdName "
            gridAttributes = gridAttributes & "|영업담당;ChargeEmpNum;62;;4;" & "o;n;n;10;사원번호;ChargeEmpNm"
            gridAttributes = gridAttributes & "|입금담당사번;ProcEmpNum;87;;4;" & "o;n;n;40; "
            gridAttributes = gridAttributes & "|;Jiral;85;;1;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ColBankCd;입금계좌코드"
            gridCodeNameList = gridCodeNameList & "/ColTypeCd;입금구분코드"
            'gridCodeNameList = gridCodeNameList & "ProjectID;프로젝트 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

            lblRecordState.Text = "준비"
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3

            Me.NewData()

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
        Private Sub PNI302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


    End Class

End Namespace
