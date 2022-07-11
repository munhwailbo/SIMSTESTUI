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

    Public Class PNF302
        Inherits CommonControls.UiControl

        Private Sub PNF302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|Ȯ�屸��;ExpandDivCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchRegionCd;62;;4;" & "o;n;n;10;���������ڵ�;"
            gridAttributes = gridAttributes & "|������;BranchRegionNm;112;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����ڵ�;DeliveryBranchCd;62;;4;" & "o;n;n;7;�����ڵ�;DeliveryBranchNm"
            gridAttributes = gridAttributes & "|������;DeliveryBranchNm;62;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����μ�;PaperNum1;62;#,##0;7;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�ݼۺμ�;PaperNum2;0;#,##0;7;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|�Ǻμ�;PaperNum3;50;#,##0;7;" & "o;y;7;;;"
            gridAttributes = gridAttributes & "|����μ�;PaperNum4;62;#,##0;7;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|������μ�;PaperNum5;74;#,##0;7;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����μ�;PaperNum6;62;#,##0;7;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���Ժμ�;PaperNum7;0;#,##0;7;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|�������;BrChiefNm;62;;1;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|��������ó;BrPhoneNum1;114;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�������ڵ���;BrMobileNum;106;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            '' '' ''gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '--------------------------------------------------------------


            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�������ڹ�ȣ;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;87;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���� ��;DeliveryBranchNm;54;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;50;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;106;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;74;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;0;;4;" & "o;n;y;10;�����ȣ;OldPostNm"
            gridAttributes = gridAttributes & "|�ּ�;OldPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;139;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;225;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|Ȯ������;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|���ݳ��;CollectionYYYYMM;63;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|Ȯ����;TrAdEmployeeNm;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|Ȯ�屸��;ExpandDivCd;73;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ڻ����ڵ�;ReaderStateCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;62;#,##0;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��ޱ����ڵ�;DeliveryDivCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ó�ڵ�;DeliveryRegionCd;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���絶�ڱ���;MHReaderDivCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����ó���ڵ�;MonitoringResultCd;99;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����ͳ���;MonitoringRemark;83;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;0;;4;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10; "

            'grid_2 code combo    
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/MonitoringResultCd;����Ͱ��ó���ڵ�"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3
            '--------------------------------------------------------------

        End Sub
#End Region

        Private Sub grd_2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_2.DoubleClick

            '����Ȯ�� ���� ��� ȭ������ JUMP.
            If Me.grd_2.Rows <= Me.grd_2.FixedRows Then Exit Sub
            Dim strCode As String '�������ڹ�ȣ
            strCode = Me.grd_2.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)
        End Sub

    End Class

End Namespace
