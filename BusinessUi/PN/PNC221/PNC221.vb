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

    Public Class PNC221
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNC221_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            ''gridAttributes = gridAttributes & "|����;ChargeEmpNm;90;;l;" & "o;n;n;10;"
            ''gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;90;;l;" & "o;n;y;10;"
            ''gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;l;" & "o;n;n;9;"       '(30)
            ''gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;c;" & "o;n;y;5;�����ڵ�;BranchNm"
            ''gridAttributes = gridAttributes & "|������;BranchNm;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|����;YYYYMM;60;;l;" & "o;n;n;6;"       '(10)

            gridAttributes = gridAttributes & "|�߼ۺμ�(����+����);PNum110;80;#,##0;r;" & "o;n;n;15;"       '(11)
            gridAttributes = gridAttributes & "|���������μ�;PNum120;80;#,##0;r;" & "o;n;n;15;"       '(12)

            gridAttributes = gridAttributes & "|���������μ���;PNum200;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|���������μ�-�����μ�;PNum210;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|���������μ�-�������;PNum220;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|���������μ�-������;PNum230;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|���������μ�-�����û;PNum240;80;#,##0;r;" & "o;n;n;15;"       '(21)

            gridAttributes = gridAttributes & "|Ȯ��μ�-����;PNum310;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|Ȯ��μ�-���Ȯ��-�ű�;PNum321;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|Ȯ��μ�-���Ȯ��-��Ȯ��;PNum322;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|Ȯ��μ�-���Ȯ��-��;PNum320;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|Ȯ��μ�-������;PNum330;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|Ȯ��μ�-����;PNum340;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|Ȯ��μ�-��û;PNum350;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|Ȯ��μ�-��Ÿ(��ü�̵�);PNum360;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|Ȯ��μ�-��(A);PNum300;80;#,##0;r;" & "o;n;n;15;"       '(21)

            gridAttributes = gridAttributes & "|�����μ�-����;PNum410;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|�����μ�-���Ȯ��-����;PNum421;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|�����μ�-���Ȯ��-��ü����;PNum422;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|�����μ�-���Ȯ��-��Ȯ��;PNum423;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|�����μ�-���Ȯ��-��;PNum420;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|�����μ�-������;PNum430;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|�����μ�-����;PNum440;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|�����μ�-����;PNum450;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|�����μ�-��(B);PNum400;80;#,##0;r;" & "o;n;n;15;"       '(21)

            gridAttributes = gridAttributes & "|����(A-B);PNum500;80;#,##0;r;" & "o;n;n;15;"       '(21)
            gridAttributes = gridAttributes & "|���;Remark;80;;l;" & "o;n;n;15;"       '(21)

            gridAttributes = gridAttributes & "| ;uZZALCA;200;;l;" & "o;n;n;1000;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ColTypeCd;�Աݱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            'Me.popChargeEmpNum_R.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            'Me.popChargeEmpNum_R.Enabled = GmainBusinessFunction.GetValue("�α��� ID") = "999999"

        End Sub
#End Region

        '' '' ''Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '' '' ''    SetTotalValue(e.row)
        '' '' ''End Sub

        '' '' ''Private Sub SetTotalValue(ByVal CurruntRow As Long)

        '' '' ''    Dim TotalValue As Long
        '' '' ''    ''Dim CurruntRow As Long

        '' '' ''    With grd_1
        '' '' ''        If .Rows > 1 Then
        '' '' ''            ''CurruntRow = .GetCurrentRowCellValue("")

        '' '' ''            '��ü �ݾ� ó�� (Ȯ��� - ��ü�ݾ� = ��ü�ݾ�)
        '' '' ''            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupAmt")).ToString.Replace(",", "")) _
        '' '' ''                             - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
        '' '' ''            .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
        '' '' ''        End If
        '' '' ''    End With

        '' '' ''End Sub

    End Class

End Namespace
