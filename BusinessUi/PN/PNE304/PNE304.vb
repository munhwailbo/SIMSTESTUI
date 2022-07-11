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

    Public Class PNE304
        Inherits CommonControls.UiControl

        Private Sub PNE304_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "�� �ʱ�ȭ"
        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.11.19
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            ''If optreceipt.Checked = True Then
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|�μ�;TrAdEmployeeDeptCd;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�μ�;TrAdEmployeeDeptNm;92;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�μ�(����);DeptCd;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�μ�(����);DeptNm;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������;TrAdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������;TrAdEmployeeNm;95;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyCd;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;112;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;183;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ1;PhoneNum1;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ2;PhoneNum2;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ���;MobileNum;93;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;161;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr2;139;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;BranchCd;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;BranchNm;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�������;ChargeEmpNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�������;ChargeEmpNm;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ű�Ȯ��μ�;FixedPNum_new;80;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��Ȯ��μ�;FixedPNum_re;80;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ȯ��μ���;FixedPNum_tot;80;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;80;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;DokjaState;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ڻ���;ReaderStateCd;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;SubscribeStateCd;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;CollectionTypeCd;80;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ȯ����������;ContactDt;80;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;RealEdDt;80;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;FixedEdDt;80;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���;Remark;80;;1;" & "o;n;n;30;"


            Me.dtpFixedEdDtFr.TextValue = ""
            Me.dtpFixedEdDtTo.TextValue = ""

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/CollectionTypeCd;���������ڵ�"
            ' ''gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            ' ''gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;���������ڵ�"
            ' ''gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            ' ''gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            ' ''gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3


            ' ''����� ����
            ''popBizChargeCd.Enabled = True
            ''If GmainBusinessFunction.GetValue("������翩��") = "0" Then
            ''    popBizChargeCd.Enabled = False
            ''    popBizChargeCd.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
            ''                                   GmainBusinessFunction.GetValue("�α��� ID"), _
            ''                                   GmainBusinessFunction.GetValue("���Ҵ�����"))
            ''End If

        End Sub
#End Region
      


    End Class

End Namespace
