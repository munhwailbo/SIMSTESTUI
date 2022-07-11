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

    Public Class PNG201
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNG201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||선택;선택;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|구분;TreePath;71;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|정산년월;YYYYMM;63;yyyy-MM;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|정산일자;CalDt;0;yyyy-MM-dd;4;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|담당사번;ChargeEmpNum;1;;4;" & "io;n;n;9;담당사번;ChargeEmpNm"
            gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;50;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;62;;4;" & "io;n;n;9;지국번호;BranchNumNm"
            gridAttributes = gridAttributes & "|지국명;BranchNumNm;62;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|지원항목코드;DivCd;87;;4;" & "io;n;n;10;지원항목 명;DivNm "
            gridAttributes = gridAttributes & "|지원항목명;DivNm;99;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|담당확인여부;RegYesOrNo;87;;1;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|관리승인여부;ApplyYesOrNo;87;;1;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|부수;PaperNum;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|단가;UnitCost;0;#,##0;7;" & "io;n;y;15;"
            gridAttributes = gridAttributes & "|지원비금액;SupAmt;74;#,##0;7;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|대체여부;DeductYN;62;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|대체일자;DeductDt;62;yyyy-MM-dd;4;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|대체금액;DeductAmt;62;#,##0;7;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|이체금액;TransferAmt;62;#,##0;7;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|은행코드;BankCd;0;;1;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;0;;1;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;0;;1;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|비고;Note;37;;1;" & "io;n;n;1000;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BankCd;은행코드"
            'gridCodeNameList = gridCodeNameList & "/DivCd;지원비구분코드"
            'gridCodeNameList = gridCodeNameList & "/BankCd;은행코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub
#End Region

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.Row)
        End Sub

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            ''Dim CurruntRow As Long

            With grd_1
                If .Rows > 1 Then
                    ''CurruntRow = .GetCurrentRowCellValue("")

                    '이체 금액 처리 (확장비 - 대체금액 = 이체금액)
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupAmt")).ToString.Replace(",", "")) _
                                     - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
                End If
            End With

        End Sub

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                If blnApprovalAll = False Then
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
                                    .set_TextMatrix(inti, .get_ColIndex("DeductDt"), dtpDeductDt.Text)
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
                                    .set_TextMatrix(inti, .get_ColIndex("DeductDt"), "")
                                    .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = False
                End If
                btnApprovalAll.Text = IIf(blnApprovalAll, "일괄 취소", "일괄 적용")
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

    End Class

End Namespace
