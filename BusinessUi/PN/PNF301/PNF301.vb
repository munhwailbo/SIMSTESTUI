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

    Public Class PNF301
        Inherits CommonControls.UiControl

        Private Sub PNF301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "n;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"


            'gridAttributes = gridAttributes & "|����ʹ��;MonitoringEmpNum;50;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�������ڹ�ȣ;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|Ȯ�屸��;ExpandDivCd;73;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ڻ����ڵ�;ReaderStateCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���������ڵ�;SubscribeStateCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;161;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;93;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;100;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;0;;4;" & "o;n;y;10;�����ȣ;OldPostNm "
            gridAttributes = gridAttributes & "|�ּ�;OldPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;193;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;232;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|Ȯ������;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;1;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���� ��;DeliveryBranchNm;55;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;59;#,##0;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��ޱ����ڵ�;DeliveryDivCd;84;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ó�ڵ�;DeliveryRegionCd;68;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���絶�ڱ���;MHReaderDivCd;80;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;78;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;FixedEdDt;1;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceTerm;74;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ݳ��;CollectionYYYYMM;63;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|(��)�����ȣ;NewPostNum;0;;4;" & "o;n;y;10;�����ȣ;NewPostNm"
            gridAttributes = gridAttributes & "|(��)�ּ�;NewPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|(��)�ּ�;NewAddr1;0;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|(��)���ּ�;NewAddr2;0;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;62;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�Ǹű��ۼ���ܿ���;SalWtListYn;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ó�ڵ�;DeliveryChnlCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ó��;DeliveryChnlNm;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�����ǵ��ڿ���;CouponReaderYN;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponSeriesNum;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '����� ����
            popEmployeeNumber.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popEmployeeNumber.Enabled = False
                popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("�α��� ID"), _
                                                  GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

        End Sub
#End Region

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '����Ȯ�� ���� ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '�������ڹ�ȣ
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)
        End Sub

  
     
        Private Sub popEmployeeNumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popEmployeeNumber.Load

        End Sub
    End Class

End Namespace
