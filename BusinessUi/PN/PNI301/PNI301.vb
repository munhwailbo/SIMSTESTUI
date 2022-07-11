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

    Public Class PNI301
        Inherits CommonControls.UiControl

#Region "폼 초기화"

        Public Sub Initialize()

            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input out'put); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"

            '''' ============================================================
            ''''   그리드 순서 2009.01.30 박근철 부장 최종 정리 확정
            '''' ============================================================
            gridAttributes = gridAttributes & "|청구년월;CalYearMonths;85;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|입금일자;ColDt;80;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|순번;ColOrders;60;;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|입금구분코드;ColTypeCd;85;;c;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|확장명;EmployeeExpNm;85;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;85;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;85;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;70;;c;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|수금년월;ColYearMonths;85;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|입금금액;ColAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기코드;BillPeriodCd;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|입금계좌;ColBankCd;85;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|계좌번호;ColAccountNum;85;;l;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|입금자명;Recipient;85;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|적요;Note;120;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;85;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|작업자사번;ProcEmpNum;85;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|작업자명;ProcEmpNm;85;;l;" & "o;n;n;40;"
            '''' ============================================================

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ColBankCd;은행코드"
            gridCodeNameList = gridCodeNameList & "ColBankCd;입금계좌코드"
            gridCodeNameList = gridCodeNameList & "/ColTypeCd;입금구분코드"   ''2323
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;수금형태코드"   ''2323
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3

            lblRecordState.Text = "준비"
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
        Private Sub PNI301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

        End Sub

        Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

        End Sub

        Private Sub dtpCalYearMonths_R_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCalYearMonths_R.Load

        End Sub
    End Class

End Namespace
