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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE402
        Inherits CommonControls.UiControl

        Private Sub PNE402_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"

            gridAttributes = gridAttributes & "|û�����;CalYearMonths;80;;l;" & "io;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|����;Orders;40;;c;" & "io;n;y;4;"       '(30)
            gridAttributes = gridAttributes & "|��г��;DisYearMonths;80;;l;" & "o;n;n;8;"       '(20)

            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;90;;c;" & "o;n;y;10;���������ڵ�;;"
            gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;60;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;90;;c;" & "o;n;y;10;;"
            gridAttributes = gridAttributes & "|����;EmployeeNameHangul;60;;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;70;;c;" & "o;n;y;40;Ȯ��ó ��;CompanyNm;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|û�����;BillDivCd;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�����ڵ�;BranchNum;120;;l;" & "o;n;n;12;���� ��;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;12;"       '(10)

            gridAttributes = gridAttributes & "|�μ�;PaperNum;80;#,##0;c;" & "o;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|�ܰ�;SubsUnitAmt;80;#,##0;c;" & "o;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|������ݱ�����;SubscriptionAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|��ü�ݾ�;DeductAmt;80;#,##0;r;" & "io;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)

            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;80;;l;" & "o;n;n;8;"            '(110)
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;80;;l;" & "o;n;n;8;"        '(110)
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;80;;l;" & "o;n;n;8;"       '(110)

            gridAttributes = gridAttributes & "|���Ȯ�ο���;RegYesOrNo;80;;l;" & "io;n;n;8;"       '(110)
            gridAttributes = gridAttributes & "|�������ο���;ApplyYesOrNo;80;;l;" & "o;n;y;8;"       '(110)
            gridAttributes = gridAttributes & "|ó������;ProcDt;80;;l;" & "o;n;y;8;"       '(110)
            gridAttributes = gridAttributes & "|���;Note;80;;l;" & "o;n;y;8;"       '(110)

            gridAttributes = gridAttributes & "| ;JiRal;80;;l;" & "o;n;y;8;"       '(110)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BankCd;�����ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

            'Me.popEmployeeNumber.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            'Me.popEmployeeNumber.Enabled = GmainBusinessFunction.GetValue("�α��� ID") = "999999"

            '����� ����
            popEmployeeNumber.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popEmployeeNumber.Enabled = False
                popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("�α��� ID"), _
                                                  GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���γ��;MutualYearMonth;1253;####-##;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;EmployeeNameHangul;60;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����������;MutualBranchCodeName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|������ ��;BranchChiefCdName;1253;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|����ȸ��;MutualSocietyDues;1253;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ο���;MutualYesOrNo;1253;#,##0;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|���αݾ�;MutualAmount;1253;#,##0;r;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|�������;SideJobBranchName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|����;Note;1358;;l;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|��������;JoinDate;80;####-##-##;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;Dumi;50;;l;" & "o;n;n"

            'grid code combo
            gridCodeNameList = ""
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3
            '--------------------------------------------------

        End Sub
#End Region


        Private Sub SetTotalValue()

            Dim TotalValue As Long
            Dim CurruntRow As Long

            With grd_1
                If .Rows > 1 Then
                    CurruntRow = .GetCurrentRowCellValue("")
                    CurruntRow += .FixedRows

                    '��ü �ݾ� ó�� (Ȯ��� - ��ü�ݾ� = ��ü�ݾ�)
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SubscriptionAmt")).ToString.Replace(",", "")) _
                                     - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)

                    Call SetSubTotal()
                End If
            End With

        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue()
        End Sub

        Private Sub btnInsertDeductAmt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertDeductAmt.Click
            Dim iRow As Integer
            For iRow = 1 To grd_1.Rows - 1
                If grd_1.GetCellCheck(iRow, grd_1.get_ColIndex("����")) = CheckEnum.Checked Then
                    grd_1.set_TextMatrix(iRow, grd_1.get_ColIndex("DeductAmt"), grd_1.get_TextMatrix(iRow, grd_1.get_ColIndex("TransferAmt")))
                End If
            Next
        End Sub
    End Class

End Namespace
