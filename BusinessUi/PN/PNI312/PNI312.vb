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

    Public Class PNI312
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNI312_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|����;ChargeEmpNm;96;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;1;;1;" & "o;n;n;9;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;0;;4;" & "o;n;y;5;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;66;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������;CalYearMonths;61;yyyy-MM;4;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|�Աݰ�;ColAmt_Tot;78;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|�����Ա�;ColAmt_1;78;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|�������(�Ǹ�);ColAmt_2;86;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|�������(����);ColAmt_3;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|����Ȯ��;ColAmt_4;62;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��ǥ����;ColAmt_5;62;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��������;ColAmt_6;62;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|������;ColAmt_7;50;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|�̻�;ColAmt_8;47;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|���Ȯ��;ColAmt_9;62;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|;uZZALCA;200;;1;" & "o;n;n;1000;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "BankCd;�����ڵ�"
            'gridCodeNameList = gridCodeNameList & "/DivCd;�����񱸺��ڵ�"
            'gridCodeNameList = gridCodeNameList & "/BankCd;�����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            ' '' ''Me.popChargeEmpNum_R.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            ' '' ''Me.popChargeEmpNum_R.Enabled = GmainBusinessFunction.GetValue("�α��� ID") = "999999"

        End Sub
#End Region

        '' ''Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '' ''    SetTotalValue(e.row)
        '' ''End Sub

        '' ''Private Sub SetTotalValue(ByVal CurruntRow As Long)

        '' ''    Dim TotalValue As Long
        '' '' ''    Dim CurruntRow As Long

        '' ''    With grd_1
        '' ''        If .Rows > 1 Then
        '' '' ''            CurruntRow = .GetCurrentRowCellValue("")

        '' ''            '��ü �ݾ� ó�� (Ȯ��� - ��ü�ݾ� = ��ü�ݾ�)
        '' ''            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupAmt")).ToString.Replace(",", "")) _
        '' ''                             - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
        '' ''            .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
        '' ''        End If
        '' ''    End With

        '' ''End Sub

    End Class

End Namespace
