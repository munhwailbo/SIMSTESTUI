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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNJ301
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNJ301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|청구년월;YYYYMM;60;;l;" & "io;y;n;6;"
            gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;1;;c;" & "io;n;y;40;"
            gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;120;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|회수년월;PayYYYYMM;1;####-##;l;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|회수부수;RedeemPaperNum;80;#,##0;c;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|배분금액;PlanDmdAmount;110;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|기청구액;PreDmdAmount;90;#,##0;r;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|청구예정액;NoDmdAmount;90;#,##0;r;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|청구부수회수;DemandCollectCirculation;90;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|청구액;ProcDmdAmount;90;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|처리일자;ProcDt;90;;c;" & "io;y;n;15;"

            ' ''gridAttributes = gridAttributes & "|이체금액;TransferAmt;100;#,##0;r;" & "io;n;n;15;"
            ' ''gridAttributes = gridAttributes & "|공제금액;DeductAmt;100;#,##0;r;" & "io;n;n;15;"
            ''gridAttributes = gridAttributes & "|신규;NewGubn;40;;l;" & "o;n;y;6;"
            gridAttributes = gridAttributes & "| ;Dumi;50;;l;" & "o;n;n;6;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            ' '' '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ' '' '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            '' '' ''gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            '' '' ''gridAttributes = gridAttributes & "|발행년월;YYYYMM;60;;l;" & "io;y;n;6;"
            '' '' ''gridAttributes = gridAttributes & "|지대년월;PayYYYYMM;60;####-##;l;" & "io;n;n;6;"
            '' '' ''gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;l;" & "io;y;n;9;지국코드;BranchNm"
            '' '' ''gridAttributes = gridAttributes & "|지국명;BranchNm;100;;l;" & "o;n;n;9;"
            '' '' ''gridAttributes = gridAttributes & "|회수부수계;RedeemPaperNum;80;#,##0;r;" & "io;n;n;4;"
            '' '' ''gridAttributes = gridAttributes & "|구독권총액;PayTotAmt;100;#,##0;r;" & "io;n;n;15;"
            '' '' ''gridAttributes = gridAttributes & "|이체금액;TransferAmt;100;#,##0;r;" & "io;n;n;15;"
            '' '' ''gridAttributes = gridAttributes & "|공제금액;DeductAmt;100;#,##0;r;" & "io;n;n;15;"
            '' '' ''gridAttributes = gridAttributes & "|신규;NewGubn;40;;l;" & "o;n;y;6;"
            '' '' ''gridAttributes = gridAttributes & "|;Dumi;50;;l;" & "o;n;n;6;"
            ' '' '' ''grid_1 code combo    
            '' '' ''Dim gridCodeNameList As String = ""
            '' '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                If blnApprovalAll = False Then
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
                                    .set_TextMatrix(inti, .get_ColIndex("ProcDt"), dtpProcDT.Text)
                                    .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = True
                Else
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
                                    '' ''.SetCellCheck(inti, .get_ColIndex("ApprovalYN"), CheckEnum.Unchecked)
                                    .set_TextMatrix(inti, .get_ColIndex("ProcDt"), "")
                                    .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = False
                End If
                ''btnApprovalAll.Text = IIf(blnApprovalAll, "일괄 취소", "일괄 적용")
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub
    End Class

End Namespace
