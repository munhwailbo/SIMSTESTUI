' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : �������� ��ȸ
' form���� : �������� ��ȸ �Ѵ�
' �ۼ��� : 
' �ۼ��� : 2009-04-08
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

    Public Class PNC207
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"

        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ���ϰ� : 
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
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
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�������ڹ�ȣ;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|Ȯ�屸��;ExpandDivCd;84;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ڻ���;ReaderStateCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;SubscribeStateCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;140;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;106;;1;" & "o;n;n;30; "
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;0;;4;" & "o;n;y;10;�����ȣ;OldPostNm "
            gridAttributes = gridAttributes & "|�ּ�;OldPostNm;0;;4;" & "o;n;y;5; "
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;285;;1;" & "o;n;n;50; "
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;190;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|Ȯ������;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;87;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���� ��;DeliveryBranchNm;62;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;62;#,##0;4;" & "o;n;n;10; "
            gridAttributes = gridAttributes & "|��ޱ���;DeliveryDivCd;62;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ó;DeliveryRegionCd;61;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���絶�ڱ���;MHReaderDivCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;85;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;FixedEdDt;85;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceTerm;74;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ݳ��;CollectionYYYYMM;63;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|(��)�����ȣ;NewPostNum;0;;4;" & "o;n;y;10;�����ȣ;NewPostNm"
            gridAttributes = gridAttributes & "|(��)�ּ�;NewPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|(��)�ּ�;NewAddr1;0;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|(��)���ּ�;NewAddr2;0;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;62;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�Ǹű��ۼ���ܿ���;SalWtListYn;124;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;108;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����ó�ڵ�;DeliveryChnlCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ó��;DeliveryChnlNm;84;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����ǵ��ڿ���;CouponReaderYN;99;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponSeriesNum;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;RealEdDt;85;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            ''gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            Me.NewData()

            '' =============================================================
            popEmployeeNumber.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popEmployeeNumber.Enabled = False
                popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("�α��� ID"), _
                                                  GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If
            '' =============================================================
            'chkState1.Checked = True
            'sbSetState()

        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNC207_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC207_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            SaveData()
            NewData()
        End Sub

        ''' <summary>
        ''' �Լ��� : grd_1_DoubleClick 
        ''' ��  �� : 
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick
            '���ڱ�������ȭ������ �̵�
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim strSubscribeCd As String '������ȣ
            Dim strSubscriberNm As String '���ڸ�

            strSubscribeCd = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscribeCd")) '������ȣ
            strSubscriberNm = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscriberNm")) '���ڸ�

            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC201;" & strSubscribeCd & ";" & strSubscriberNm)
            Me.ShowUiControl("PNC201", strSubscribeCd)
        End Sub

        'Private Sub chkState1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    sbSetState()
        'End Sub

        'Private Sub chkState2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    sbSetState()
        'End Sub

        'Private Sub sbSetState()
        '    lblReaderStateCd_R.Visible = True
        '    cboReaderStateCd.Visible = True
        '    If chkState1.Checked = True Or chkState2.Checked = True Then
        '        lblReaderStateCd_R.Visible = False
        '        cboReaderStateCd.Visible = False
        '    End If
        'End Sub

    End Class

End Namespace
