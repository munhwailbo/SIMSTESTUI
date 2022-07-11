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

Namespace ubiLease.UI.BusinessUi.BM

    Public Class BMB102
        Inherits CommonControls.UiControl

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
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|부서;DeptNm;1253;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|담당자;ChargeEmpNumNm;1253;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|지국장 코드;BranchChiefCd;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지국장 명;BranchChiefCdName;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|순번;Orders;1253;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|납부년월;MutualYearMonth;1253;####-##;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|상조회비;MutualSocietyDues;1253;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|납부여부;MutualYesOrNo;1253;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|납부금액;MutualAmount;1253;#,##0;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|납부지국코드;MutualBranchCode;3000;;l;" & "o;n;y;200;지국코드;MutualBranchCodeName"
            gridAttributes = gridAttributes & "|납부지국명;MutualBranchCodeName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|겸업지국;SideJobBranchName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|적요;Note;1358;;l;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|가입일자;JoinDate;80;####-##-##;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|탈퇴일자;SecessionDate;70;####-##-##;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|탈퇴여부;SecessionYON;50;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|;Dumi;50;;l;" & "o;n;n"

            'grid code combo
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '--------------------------------------------------
            Me.chkPaymentPerson.Checked = True
        End Sub
#End Region

#Region "폼 이벤트"

        Private Sub BMB102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Dock = DockStyle.Fill
        End Sub

#End Region

        Private Sub chkPaymentPerson_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPaymentPerson.CheckedChanged
            If chkPaymentPerson.Visible Then
                If chkPaymentPerson.Checked = False And chkPersonInArrears.Checked = False Then
                    chkPaymentPerson.Checked = True
                End If
            End If
        End Sub

        Private Sub chkPersonInArrears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPersonInArrears.CheckedChanged
            If chkPersonInArrears.Visible Then
                If chkPersonInArrears.Checked = False And chkPaymentPerson.Checked = False Then
                    chkPersonInArrears.Checked = True
                End If
            End If
        End Sub
    End Class

End Namespace
