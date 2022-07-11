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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic


Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI321
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNI321_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���;ChargeEmpNm;120;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���;ChargeEmpNum;90;;l;" & "o;n;y;10;"

            gridAttributes = gridAttributes & "|�� ��;BranchNum;80;;l;" & "o;n;n;9;"       '(30)
            gridAttributes = gridAttributes & "|�� ��;BranchCd;60;;c;" & "o;n;y;5;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|�� ��;BranchNm;115;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������;CalYearMonths;60;;l;" & "o;n;n;6;"       '(10)

            gridAttributes = gridAttributes & "|�Աݰ�;ColAmt_Tot;120;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�����Ա�;ColAmt_1;100;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�������;ColAmt_2;100;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�������;ColAmt_21;1;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�������;ColAmt_22;1;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�������;ColAmt_3;100;#,##0;r;" & "o;n;n;15;"       '(80)

            gridAttributes = gridAttributes & "|�� ü;ColAmt_4;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�� ü;ColAmt_5;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�� ü;ColAmt_6;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�� ü;ColAmt_7;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�� ü;ColAmt_8;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�� ü;ColAmt_9;90;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "| ;uZZALCA;200;;l;" & "o;n;n;1000;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "BankCd;�����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            'Me.popChargeEmpNum_R.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            'Me.popChargeEmpNum_R.Enabled = GmainBusinessFunction.GetValue("�α��� ID") = "999999"
            '----�׸��� �ິ��--------------------------------- 
            Dim i As Integer = 0
            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "����"
            strColName2 = strColName2 & ControlChars.Tab & "���"
            strColName2 = strColName2 & ControlChars.Tab & "���"

            strColName2 = strColName2 & ControlChars.Tab & "������ȣ"
            strColName2 = strColName2 & ControlChars.Tab & "�����ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "������"
            strColName2 = strColName2 & ControlChars.Tab & "������"

            strColName2 = strColName2 & ControlChars.Tab & "�Աݰ�"
            strColName2 = strColName2 & ControlChars.Tab & "�����Ա�"
            strColName2 = strColName2 & ControlChars.Tab & "�Ǹ�"
            strColName2 = strColName2 & ControlChars.Tab & "�Ǹ�(��꼭)"
            strColName2 = strColName2 & ControlChars.Tab & "�Ǹ�(��+��)"
            strColName2 = strColName2 & ControlChars.Tab & "����"

            strColName2 = strColName2 & ControlChars.Tab & "����Ȯ��"
            strColName2 = strColName2 & ControlChars.Tab & "��ǥ����"
            strColName2 = strColName2 & ControlChars.Tab & "��������"
            strColName2 = strColName2 & ControlChars.Tab & "������"
            strColName2 = strColName2 & ControlChars.Tab & "�̻�"
            strColName2 = strColName2 & ControlChars.Tab & "���Ȯ��"
            '''' --- 
            strColName2 = strColName2 & ControlChars.Tab & ""

            With Me.grd_1
                .AddItem(strColName2)
                .FixedRows = 2
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly
                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next
                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next
            End With
            '-------------------------------------------------- 
           
            '����� ����
            popChargeEmpNum_R.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popChargeEmpNum_R.Enabled = False
                popChargeEmpNum_R.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("�α��� ID"), _
                                                  GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

        End Sub
#End Region

        '' '' ''Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '' '' ''    SetTotalValue(e.row)
        '' '' ''End Sub

        '' '' ''Private Sub SetTotalValue(ByVal CurruntRow As Long)

        '' '' ''    Dim TotalValue As Long
        '' '' '' ''    Dim CurruntRow As Long

        '' '' ''    With grd_1
        '' '' ''        If .Rows > 1 Then
        '' '' '' ''            CurruntRow = .GetCurrentRowCellValue("")

        '' '' ''            '��ü �ݾ� ó�� (Ȯ��� - ��ü�ݾ� = ��ü�ݾ�)
        '' '' ''            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupAmt")).ToString.Replace(",", "")) _
        '' '' ''                             - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
        '' '' ''            .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
        '' '' ''        End If
        '' '' ''    End With

        '' '' ''End Sub

    End Class

End Namespace
