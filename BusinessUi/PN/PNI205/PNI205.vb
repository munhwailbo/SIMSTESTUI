'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �ڵ����
' form ���� : ��ȭ�Ϻ� �ڵ� ����
' �ۼ��� : ������
' �ۼ��� : 2008.09.01
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

#Region "�� �ʱ�ȭ"
        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code

            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;40;;r;" & "io;n;y;4;"       '(10)

            gridAttributes = gridAttributes & "|����ó����;SalesDiviCd;200;;l;" & "o;n;n;30;"       '(160)
            gridAttributes = gridAttributes & "|����ó�ڵ�;SalesCd;200;;l;" & "o;n;n;30;"       '(170)
            gridAttributes = gridAttributes & "|����ó��;SalesNm;200;;l;" & "o;n;y;30;"       '(170)

            gridAttributes = gridAttributes & "|��ȣ(���θ�);ConsumerCorpNm;200;;l;" & "o;n;n;30;"       '(130)
            gridAttributes = gridAttributes & "|�����(�ֹ�)��ȣ;ConsumerBusinessNum;200;;l;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|��ǥ�ڼ���;ConsumerPresidentNm;200;;l;" & "o;n;n;30;"       '(140)

            gridAttributes = gridAttributes & "|��꼭��������;TaxAccPublishDt;80;;l;" & "o;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|�ۼ�����;WriteDt;80;;l;" & "o;n;y;8;"       '(180)
            gridAttributes = gridAttributes & "|���ް���;SupplyTotalAmt;150;#,##0;r;" & "o;n;n;15;"       '(200)
            gridAttributes = gridAttributes & "|����;TaxTotAmt;150;;r;" & "o;n;y;15;"       '(210)
            gridAttributes = gridAttributes & "|���;Note;200;;l;" & "o;n;n;1000;"       '(220)

            gridAttributes = gridAttributes & "|å��ȣ-��;BillGroupNum;40;;r;" & "o;n;y;4;"       '(30)
            gridAttributes = gridAttributes & "|å��ȣ-ȣ;BillGroupSeriesNum;40;;r;" & "o;n;y;4;"       '(40)
            gridAttributes = gridAttributes & "|��꼭�Ϸù�ȣ;BillSeriesNum;40;;r;" & "o;n;y;4;"       '(50)

            gridAttributes = gridAttributes & "|���޹޴���-�����ȣ;ConsumePostNum;200;;l;" & "o;n;y;1000;"       '(150)
            gridAttributes = gridAttributes & "|���޹޴���-������ּ�;ConsumerAddr;200;;l;" & "o;n;y;1000;"       '(150)
            gridAttributes = gridAttributes & "|���޹޴���-�������ּ�;ConsumerAddr2;200;;l;" & "o;n;y;1000;"       '(150)
            gridAttributes = gridAttributes & "|���޹޴���-�����ڵ�;ConsumerBusiStatusCd;200;;l;" & "o;n;y;30;"       '(160)
            gridAttributes = gridAttributes & "|���޹޴���-�����ڵ�;ConsumerBusiTypeCd;200;;l;" & "o;n;y;30;"       '(170)
            gridAttributes = gridAttributes & "| ;Dummy;200;;l;" & "o;n;n;1000;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SalesDiviCd;����ó�����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "k;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;60;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|����;Orders;40;;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�ۼ�����;YYYYMMDD;80;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|ǰ��;Item;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�԰�;Standard;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;SupplyNum;70;#,##0;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�ܰ�;UnitCost;80;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|���ް���;SupplyPrice;80;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|����;TaxAmt;80;#,##0;r;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|����;Note;200;;l;" & "io;n;y;1000;"
            gridAttributes = gridAttributes & "| ;Dummy;200;;l;" & "o;n;n;1000;"

            'grid_2 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_2.ExplorerBar = Me.grd_2.get_ColIndex("EmployeeNumber")

            dtpTaxAccPublishDt_R1.TextValue = DateTime.Now().ToString.Substring(0, 8) & "01"
            dtpTaxAccPublishDt_R2.TextValue = DateTime.Now().ToString

            lblRecordState.Text = "�غ�"
            sbSetSalesCd_R("9")
            sbSetSalesCd_R(cboSalesDivCd_R.TextValue)
            sbSetSalesCd(cboSalesDiviCd.TextValue)

        End Sub
#End Region


        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            ''Dim SupplyNum As Long    '' ����
            ''Dim UnitCost As Long     '' �ܰ�
            Dim SupplyPrice As Long  '' ���ް���
            ''Dim CurruntRow As Long

            With grd_3
                If .Rows > 1 Then
                    'CurruntRow = .GetCurrentRowCellValue("") + 1
                    '' ''�� ó��
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
                Label12.Text = "Ȯ��ó�ڵ�"
                popSalesCd.Tag = "code(Ȯ��ó ��);"
                If popSalesCd.TextValue.ToString().Length <> 12 Then popSalesCd.TextValue = ""
                popSalesCd.MaxLength = 12
            ElseIf SaleDviCd = "2" Then
                Label12.Text = "�Ҽӻ��ڵ�"
                popSalesCd.Tag = "code(�Ҽӻ� ��);"
                If popSalesCd.TextValue.ToString().Length <> 4 Then popSalesCd.TextValue = ""
                popSalesCd.MaxLength = 4
            ElseIf SaleDviCd = "3" Then
                Label12.Text = "������ȣ"
                popSalesCd.Tag = "code(������ȣ);"
                If popSalesCd.TextValue.ToString().Length <> 9 Then popSalesCd.TextValue = ""
                popSalesCd.MaxLength = 9
            Else
                Label12.Text = "��Ÿ����ó"
                ''popSalesCd.Tag = "read;"
                popSalesCd.Enabled = False
            End If

        End Sub

        Private Sub btnBusiDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusiDt.Click
            If Me.cboSalesDiviCd.TextValue.Length < 1 Or Me.popSalesCd.TextValue.Length < 1 Then
                MessageBox.Show("�ݵ�� Ȯ��ó �Ǵ� ���� �Ǵ� �Ҽӻ� �ڵ带 �����ϼž� �մϴ�.  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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
                lblCodeDivisionHangulName.Text = "Ȯ��ó�ڵ�"
                popSalesCd_R.Tag = "code(Ȯ��ó ��);"
                popSalesCd_R.TextValue = ""
                popSalesCd_R.MaxLength = 12
            ElseIf SaleDviCd = "2" Then
                lblCodeDivisionHangulName.Text = "�Ҽӻ��ڵ�"
                popSalesCd_R.Tag = "code(�Ҽӻ� ��);"
                popSalesCd_R.TextValue = ""
                popSalesCd_R.MaxLength = 4
            ElseIf SaleDviCd = "3" Then
                lblCodeDivisionHangulName.Text = "������ȣ"
                popSalesCd_R.Tag = "code(������ȣ);"
                popSalesCd_R.TextValue = ""
                popSalesCd_R.MaxLength = 9
            Else
                lblCodeDivisionHangulName.Text = "��Ÿ����ó"
                ''popSalesCd_R.Tag = "read;"
                popSalesCd_R.Enabled = False
            End If

        End Sub


    End Class

End Namespace
