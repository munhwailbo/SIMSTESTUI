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

    Public Class PNI205
        Inherits CommonControls.UiControl

        Private Sub PNI205_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code

            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;40;;r;" & "io;n;y;4;"       '(10)

            gridAttributes = gridAttributes & "|매출처구분;SalesDiviCd;200;;l;" & "o;n;n;30;"       '(160)
            gridAttributes = gridAttributes & "|매출처코드;SalesCd;200;;l;" & "o;n;n;30;"       '(170)
            gridAttributes = gridAttributes & "|매출처명;SalesNm;200;;l;" & "o;n;y;30;"       '(170)

            gridAttributes = gridAttributes & "|상호(법인명);ConsumerCorpNm;200;;l;" & "o;n;n;30;"       '(130)
            gridAttributes = gridAttributes & "|사업자(주민)번호;ConsumerBusinessNum;200;;l;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|대표자성명;ConsumerPresidentNm;200;;l;" & "o;n;n;30;"       '(140)

            gridAttributes = gridAttributes & "|계산서발행일자;TaxAccPublishDt;80;;l;" & "o;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|작성일자;WriteDt;80;;l;" & "o;n;y;8;"       '(180)
            gridAttributes = gridAttributes & "|공급가액;SupplyTotalAmt;150;#,##0;r;" & "o;n;n;15;"       '(200)
            gridAttributes = gridAttributes & "|세액;TaxTotAmt;150;;r;" & "o;n;y;15;"       '(210)
            gridAttributes = gridAttributes & "|비고;Note;200;;l;" & "o;n;n;1000;"       '(220)

            gridAttributes = gridAttributes & "|책번호-권;BillGroupNum;40;;r;" & "o;n;y;4;"       '(30)
            gridAttributes = gridAttributes & "|책번호-호;BillGroupSeriesNum;40;;r;" & "o;n;y;4;"       '(40)
            gridAttributes = gridAttributes & "|계산서일련번호;BillSeriesNum;40;;r;" & "o;n;y;4;"       '(50)

            gridAttributes = gridAttributes & "|공급받는자-우편번호;ConsumePostNum;200;;l;" & "o;n;y;1000;"       '(150)
            gridAttributes = gridAttributes & "|공급받는자-사업장주소;ConsumerAddr;200;;l;" & "o;n;y;1000;"       '(150)
            gridAttributes = gridAttributes & "|공급받는자-사업장상세주소;ConsumerAddr2;200;;l;" & "o;n;y;1000;"       '(150)
            gridAttributes = gridAttributes & "|공급받는자-업태코드;ConsumerBusiStatusCd;200;;l;" & "o;n;y;30;"       '(160)
            gridAttributes = gridAttributes & "|공급받는자-종목코드;ConsumerBusiTypeCd;200;;l;" & "o;n;y;30;"       '(170)
            gridAttributes = gridAttributes & "| ;Dummy;200;;l;" & "o;n;n;1000;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SalesDiviCd;매출처구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "k;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;60;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|순번;Orders;40;;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|작성일자;YYYYMMDD;80;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|품목;Item;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|규격;Standard;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|수량;SupplyNum;70;#,##0;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|단가;UnitCost;80;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|공급가액;SupplyPrice;80;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|세액;TaxAmt;80;#,##0;r;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|적요;Note;200;;l;" & "io;n;y;1000;"
            gridAttributes = gridAttributes & "| ;Dummy;200;;l;" & "o;n;n;1000;"

            'grid_2 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_2.ExplorerBar = Me.grd_2.get_ColIndex("EmployeeNumber")

            dtpTaxAccPublishDt_R1.TextValue = DateTime.Now().ToString.Substring(0, 8) & "01"
            dtpTaxAccPublishDt_R2.TextValue = DateTime.Now().ToString

            lblRecordState.Text = "준비"
            sbSetSalesCd_R("9")
            sbSetSalesCd_R(cboSalesDivCd_R.TextValue)
            sbSetSalesCd(cboSalesDiviCd.TextValue)

        End Sub
#End Region


        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            ''Dim SupplyNum As Long    '' 수량
            ''Dim UnitCost As Long     '' 단가
            Dim SupplyPrice As Long  '' 공급가액
            ''Dim CurruntRow As Long

            With grd_3
                If .Rows > 1 Then
                    'CurruntRow = .GetCurrentRowCellValue("") + 1
                    '' ''계 처리
                    ' ''SupplyNum = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupplyNum")).ToString.Replace(",", ""))
                    ' ''UnitCost = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("UnitCost")).ToString.Replace(",", "")) 
                    ' ''SupplyPrice = SupplyNum + UnitCost
                    SupplyPrice = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupplyNum")).ToString.Replace(",", "")) _
                                    * Val(.get_TextMatrix(CurruntRow, .get_ColIndex("UnitCost")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("SupplyPrice"), SupplyPrice.ToString)
                End If
            End With
        End Sub
        Private Sub grd_1_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            With Me.grd_1
                If .Rows > 1 Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
                    Select Case .ColSel
                        Case .get_ColIndex("BranchNum")
                            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    End Select
                End If
            End With

        End Sub

        Private Sub grd_3_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_3.AfterEdit
            If e.Col = grd_3.get_ColIndex("SupplyNum") Then SetTotalValue(e.Row)
            If e.Col = grd_3.get_ColIndex("UnitCost") Then SetTotalValue(e.Row)
        End Sub

        Private Sub grd_3_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_3.EnterCell

            With Me.grd_3
                If .Rows > 1 Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
                    Select Case .ColSel
                        Case .get_ColIndex("Orders")
                            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone

                    End Select
                End If
            End With

        End Sub

        Private Sub cboSalesDviCd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSalesDiviCd.SelectedIndexChanged
            sbSetSalesCd(cboSalesDiviCd.TextValue)
        End Sub

        Private Sub sbSetSalesCd(ByVal SaleDviCd As String)

            popSalesCd.Enabled = True
            If SaleDviCd = "1" Then
                Label12.Text = "확장처코드"
                popSalesCd.Tag = "code(확장처 명);"
                If popSalesCd.TextValue.ToString().Length <> 12 Then popSalesCd.TextValue = ""
                popSalesCd.MaxLength = 12
            ElseIf SaleDviCd = "2" Then
                Label12.Text = "소속사코드"
                popSalesCd.Tag = "code(소속사 명);"
                If popSalesCd.TextValue.ToString().Length <> 4 Then popSalesCd.TextValue = ""
                popSalesCd.MaxLength = 4
            ElseIf SaleDviCd = "3" Then
                Label12.Text = "지국번호"
                popSalesCd.Tag = "code(지국번호);"
                If popSalesCd.TextValue.ToString().Length <> 9 Then popSalesCd.TextValue = ""
                popSalesCd.MaxLength = 9
            Else
                Label12.Text = "기타매출처"
                ''popSalesCd.Tag = "read;"
                popSalesCd.Enabled = False
            End If

        End Sub

        Private Sub btnBusiDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusiDt.Click
            If Me.cboSalesDiviCd.TextValue.Length < 1 Or Me.popSalesCd.TextValue.Length < 1 Then
                MessageBox.Show("반드시 확장처 또는 지국 또는 소속사 코드를 선택하셔야 합니다.  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            Else
                Call BusinessDetail()
            End If
        End Sub

        Private Sub cboSalesDivCd_R_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSalesDivCd_R.SelectedIndexChanged
            sbSetSalesCd_R(cboSalesDivCd_R.TextValue)
        End Sub


        Private Sub sbSetSalesCd_R(ByVal SaleDviCd As String)
            popSalesCd_R.Enabled = True
            If SaleDviCd = "1" Then
                lblCodeDivisionHangulName.Text = "확장처코드"
                popSalesCd_R.Tag = "code(확장처 명);"
                popSalesCd_R.TextValue = ""
                popSalesCd_R.MaxLength = 12
            ElseIf SaleDviCd = "2" Then
                lblCodeDivisionHangulName.Text = "소속사코드"
                popSalesCd_R.Tag = "code(소속사 명);"
                popSalesCd_R.TextValue = ""
                popSalesCd_R.MaxLength = 4
            ElseIf SaleDviCd = "3" Then
                lblCodeDivisionHangulName.Text = "지국번호"
                popSalesCd_R.Tag = "code(지국번호);"
                popSalesCd_R.TextValue = ""
                popSalesCd_R.MaxLength = 9
            Else
                lblCodeDivisionHangulName.Text = "기타매출처"
                ''popSalesCd_R.Tag = "read;"
                popSalesCd_R.Enabled = False
            End If

        End Sub


    End Class

End Namespace
