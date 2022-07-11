'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���̺� ���Ǽ� ���
' form ���� : ���̺� ���Ǽ��� ��� �Ѵ�.
' �ۼ��� : Ȳ����
' �ۼ��� : 2007-07-11
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


Imports System.IO

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB102
        Inherits CommonControls.UiControl

        '' ���ø� ���� ��� ����
        'Public strFilePath As String = ""

        '' ���̺� ���Ǽ� ���� ��� ����
        'Public strSaveFilePath As String = ""

        '' ���̺� ��ũ��Ʈ ���� ��� ����
        'Public strScriptSaveFilePath As String = ""

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;c;" & "o;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;30;"

            gridAttributes = gridAttributes & "|��������;TransferDate;8;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|����Ƚ��;TransferNum;4;;c;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|ó������;ProcessDivCd;10;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��౸��;ContractDivCd;10;;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|�ǹ���;OwnerNm;30;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����������;RentDepositAmt;15;#,##0;r;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|����;RentAmt;15;#,##0;r;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|������������;DeferPaymentYn;10;;l;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|VAT���Կ���;VatYn;10;;l;" & "o;n;y;10;"

            gridAttributes = gridAttributes & "|�������;ContractStDt;8;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|��ุ������;ContractEdDt;8;;l;" & "o;n;n;8;"

            gridAttributes = gridAttributes & "|���������ȣ;PostNum;10;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�����ּ�;Addr;100;;l;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|ä��Ȯ��;Obligation;30;;l;" & "o;n;n;30;"

            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;10;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;30;;l;" & "o;n;n;30;"

            '' '' ''2009.01.23 ����ȣ ���忡 ���Ͽ� ���� ���� ��(�׸��� �׸� ��ü ������)
            gridAttributes = gridAttributes & "|�൵�̹������ϰ��;OutlineMapFilePath;0;;l;" & "o;n;y;0;"
            gridAttributes = gridAttributes & "|�������;SiteArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|�ǹ����;BuildingArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|������;UseArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|������;Floor;10;;l;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|���ѹ���;LimitedItem;30;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�빰�㺸-�����ڸ�;SecurityOwnerNm;30;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�빰�㺸-�����ȣ;SecurityPostNum;10;;l;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�빰�㺸-�ּ�;SecurityAddr;100;;l;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|�빰�㺸-�������;SecuritySiteArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|�빰�㺸-�ǹ����;SecurityBuildingArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|�빰�㺸-���ѹ���;SecurityLimitedItem;50;;l;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;30;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�ǹ��ֿ��ǰ���;OwnerRelation;10;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "| ;jIrAL;10;;;" & "o;n;y;10;"    '���ڸ� ���߱� ��

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ProcessDivCd;�����繫��ó�������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ContractDivCd;�����繫�ǰ�౸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/BankCd;�����ڵ�"
            ''gridCodeNameList = gridCodeNameList & "/OwnerRelation;�ǹ��ֿ��ǰ���"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            'Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 3

            lblRecordState.Text = "�غ�"

            ''grid�� �ʱ�ȭ �Ѵ�.
            ''--------------------------------------------------
            'gridAttributes = ""


            '' '' ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            ' '' ''gridAttributes = gridAttributes & "a;r;y"

            '' '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            ' '' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            ' '' ''gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;c;" & "o;n;n;7;�����ڵ�;BranchNm"
            ' '' ''gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;y;30;"

            ' '' ''gridAttributes = gridAttributes & "|��������;TransferDate;8;;l;" & "o;n;n;8;"
            ' '' ''gridAttributes = gridAttributes & "|����Ƚ��;TransferNum;4;;c;" & "o;n;n;4;"

            ' '' ''gridAttributes = gridAttributes & "|ó�������ڵ�;ProcessDivCd;10;;c;" & "o;n;n;10;"
            ' '' ''gridAttributes = gridAttributes & "|��౸���ڵ�;ContractDivCd;10;;c;" & "o;n;n;10;"

            ' '' ''gridAttributes = gridAttributes & "|�ǹ���;OwnerNm;30;;l;" & "o;n;n;30;"
            ' '' ''gridAttributes = gridAttributes & "|����������;RentDepositAmt;15;#,##0;r;" & "o;n;n;15;"
            ' '' ''gridAttributes = gridAttributes & "|����;RentAmt;15;#,##0;r;" & "o;n;n;15;"
            ' '' ''gridAttributes = gridAttributes & "|����������;ContractStDt;8;;l;" & "o;n;n;8;"
            ' '' ''gridAttributes = gridAttributes & "|��ุ������;ContractEdDt;8;;l;" & "o;n;n;8;"

            ' '' ''gridAttributes = gridAttributes & "|���������ȣ;PostNum;10;;c;" & "o;n;y;10;"
            ' '' ''gridAttributes = gridAttributes & "|�����ּ�;Addr;100;;l;" & "o;n;n;100;"
            ' '' ''gridAttributes = gridAttributes & "|ä��Ȯ��;Obligation;30;;l;" & "o;n;n;30;"

            ' '' ''gridAttributes = gridAttributes & "|���౸���ڵ�;BankCd;10;;l;" & "o;n;n;10;"
            ' '' ''gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;30;;l;" & "o;n;n;30;"

            '' '' ''grid code combo
            ' '' ''gridCodeNameList = ""
            ' '' ''gridCodeNameList = gridCodeNameList & "ProcessDivCd;�����繫��ó�������ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/ContractDivCd;�����繫�ǰ�౸���ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/BankCd;���౸���ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/OwnerRelation;�ǹ��ֿ��ǰ���"
            ' '' ''grd_2.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''--------------------------------------------------
            '' '' ''Me.grd_2.ExplorerBar = 0
            ' '' ''Me.grd_2.ExplorerBar = 3


        End Sub

        Private Sub PNB102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            ''RequestData2()
        End Sub

    End Class

End Namespace

