' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form��   : ���Ȯ��� û�� ���� ó��
' form���� : ���Ȯ���(����) û������ó�� �Ѵ�
' �ۼ���   : �輺��
' �ۼ���   : 2008-09-22
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI202
        Inherits CommonControls.UiControl
        '====================================================================================================


#Region "�� �ʱ�ȭ"

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
            gridAttributes = gridAttributes & "|����;TreePath;80;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|û�����;CollectYYYYMM;60;;c;" & "io;y;n;5;"
            '' ''gridAttributes = gridAttributes & "|���;CalYearMonths;60;;l;" & "o;n;n;6;"       '(10)

            gridAttributes = gridAttributes & "|�������;ChargeEmpNum;90;;c;" & "o;n;n;10;�����ȣ;ChargeEmpNm;"
            gridAttributes = gridAttributes & "|����;ChargeEmpNm;90;;l;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;l;" & "o;n;n;9;"       '(30)
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;c;" & "o;n;n;5;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;90;;c;" & "o;n;n;10;���������ڵ�;BranchRegionNm;"
            gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;90;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����̼���;UnColAmt;90;#,##0;r;" & "o;n;n;4;"          '(70) �����
            gridAttributes = gridAttributes & "|�����;SalesAmt;90;#,##0;r;" & "o;n;n;4;"          '(70) �����
            gridAttributes = gridAttributes & "|û����;TotalDemandAmt;90;#,##0;r;" & "o;n;n;4;"          '(70) �����

            gridAttributes = gridAttributes & "|�����μ���;ValPaperNumTot;90;#,##0;r;" & "o;n;y;4;"       '(60) �μ���
            gridAttributes = gridAttributes & "|�����μ���;NoValPaperNumTot;90;#,##0;r;" & "o;n;y;4;"     '(60) �μ���

            gridAttributes = gridAttributes & "|�Ϲ������μ�;ValPaperNum1;90;#,##0;r;" & "o;n;y;4;"     '(60) �����μ�1
            gridAttributes = gridAttributes & "|�Ϲݸ���;ValPaperSale1;90;#,##0;r;" & "o;n;y;4;"    '(60) �����μ�1

            gridAttributes = gridAttributes & "|�����������μ�;ValPaperNum2;90;#,##0;r;" & "o;n;y;4;"   '(70) �����μ�2
            gridAttributes = gridAttributes & "|�����Ǹ���;ValPaperSale2;90;#,##0;r;" & "o;n;y;4;"  '(70) �����μ�2

            gridAttributes = gridAttributes & "|��Ÿ�����μ�1;ValPaperNum3;90;#,##0;r;" & "o;n;y;4;"    '(80) �����μ�3
            gridAttributes = gridAttributes & "|��Ÿ����1;ValPaperSale3;90;#,##0;r;" & "o;n;y;4;"   '(80) �����μ�3

            gridAttributes = gridAttributes & "|��Ÿ�����μ�2;ValPaperNum4;90;#,##0;r;" & "o;n;y;4;"    '(90) �����μ�4
            gridAttributes = gridAttributes & "|��Ÿ����2;ValPaperSale4;90;#,##0;r;" & "o;n;y;4;"   '(90) �����μ�4

            'gridAttributes = gridAttributes & "|����;Remark;90;;r;" & "o;n;n;4;"     '(60) �μ���
            gridAttributes = gridAttributes & "|������������;ColEndDt;60;;c;" & "o;y;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "PrintOfficeCd;���屸���ڵ�"
            ''gridCodeNameList = gridCodeNameList & "/PrintPlateCd;�Ǳ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            dtpColEndDt.TextValue = Date.Today  'dtpCollectYYYYMM.TextValue & "20"


        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : ACA003_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNI202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If

        End Sub
#End Region

        Private Sub btnCreateSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSale.Click
            SaveData()
        End Sub

        Private Sub dtpCollectYYYYMM_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpCollectYYYYMM.Enter
            dtpColEndDt.TextValue = Date.Today   'dtpCollectYYYYMM.TextValue & "20"
        End Sub

    End Class

End Namespace
