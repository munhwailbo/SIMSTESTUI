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

    Public Class PNI311
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNI311_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            '' '' '' ''==============================================================
            '' '' '' ''  grid_1 �� �ʱ�ȭ �Ѵ�.
            '' '' '' ''--------------------------------------------------------------
            ' '' '' ''Dim gridAttributes As String = ""
            '' '' '' ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            ' '' '' ''gridAttributes = gridAttributes & "a;r;y"

            '' '' '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' '' '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            ' '' '' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            ' '' '' ''gridAttributes = gridAttributes & "|�Ա�����;ColDt;80;;c;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|����;ColOrders;60;;r;" & "o;n;y;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|�Աݱ����ڵ�;ColTypeCd;85;;c;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|�Աݰ��¹�ȣ;ColBankCd;85;;c;" & "o;n;n;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|���¹�ȣ;ColAccountNum;85;;c;" & "o;n;y;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|�Ա��ڸ�;Recipient;85;;c;" & "o;n;n;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|�Աݱݾ�;ColAmt;60;#,###;r;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|����;Note;120;;l;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|�����Աݳ��;CalYearMonths;85;;c;" & "o;n;n;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|������ȣ;BranchNum;85;;c;" & "o;n;n;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;85;;c;" & "o;n;y;40;"
            ' '' '' ''gridAttributes = gridAttributes & "|������;BranchNm;85;;l;" & "o;n;n;40;"

            ' '' '' ''gridAttributes = gridAttributes & "|�����强��;BranchChiefCdName;80;;c;" & "o;n;n;10;"
            ' '' '' ''gridAttributes = gridAttributes & "|��������;ChargeEmpNm;90;;l;" & "o;n;n;10;"
            ' '' '' ''gridAttributes = gridAttributes & "|�Աݴ���;ProcEmpNm;85;;l;" & "o;n;n;40;"

            ' '' '' ''gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;85;;c;" & "o;n;n;40;�������ڵ�;BranchChiefCdName"
            ' '' '' ''gridAttributes = gridAttributes & "|�������;ChargeEmpNum;90;;c;" & "o;n;n;10;�����ȣ;ChargeEmpNm;"
            ' '' '' ''gridAttributes = gridAttributes & "|�Աݴ����;ProcEmpNum;85;;c;" & "o;n;n;40;"

            ' '' '' ''gridAttributes = gridAttributes & "| ;Jiral;85;;l;" & "o;n;n;40;"

            '' '' '' ''grid code combo
            ' '' '' ''Dim gridCodeNameList As String = ""
            ' '' '' ''gridCodeNameList = gridCodeNameList & "ColBankCd;�Աݰ����ڵ�"
            ' '' '' ''gridCodeNameList = gridCodeNameList & "/ColTypeCd;�Աݱ����ڵ�"
            '' '' '' ''gridCodeNameList = gridCodeNameList & "ProjectID;������Ʈ ��"

            ' '' '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' '' ''--------------------------------------------------
            ' '' '' ''Me.grd_1.ExplorerBar = 0
            ' '' '' ''grd_1.ExplorerBar = 3

        End Sub
#End Region

        Private Sub btnExec1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExec1.Click
            '' ��ü ó��
            SaveData()
        End Sub

        Private Sub btnExec2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExec2.Click
            '' ��ü ���
            DeleteData()
        End Sub
    End Class

End Namespace
