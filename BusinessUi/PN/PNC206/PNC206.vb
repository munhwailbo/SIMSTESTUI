' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : ����Ȯ���������ڵ��
' form���� : ����Ȯ���������ڵ����(��) �Ѵ�
' �ۼ��� : ������
' �ۼ��� : 2008-09-18
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

    Public Class PNC206
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
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;89;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;SatStat;43;;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ϵ��ڸ�;SubscribeCd2;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|����;Orders;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscribeNm;107;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ;PhoneNum1;102;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�޴�����ȣ;MobileNum;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;145;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;162;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���Կ�û����;FixedStDt;88;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������ȣ;BranchPhoneNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������;BranchNm;78;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������ڵ�;ChargeEmpNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�������;ChargeEmpNm;72;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������� ��ȭ;ChargeEmpPhNum;0;;1;" & "o;n;y;30;"
9:          gridAttributes = gridAttributes & "|������� �ڵ���;ChargeEmpMbNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;                       "

            gridAttributes = gridAttributes & "|;Dummy;100;;l;" & "o;n;n;10;"       '(60)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            '' ''gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;���������ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;���������ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '' ''gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;200;;l;" & "o;n;n;30;"       ' ������ȣ        
            '' ''gridAttributes = gridAttributes & "|����;Orders;200;;l;" & "o;n;y;30;"       ' ����            
            '' ''gridAttributes = gridAttributes & "|(���)���� ��;SatReaderNm;200;;l;" & "o;n;n;30;"       ' ����� ���� ��
            '' ''gridAttributes = gridAttributes & "|(���)��������;SatReceiptDt;200;;l;" & "o;n;n;30;"       ' ��������        
            '' ''gridAttributes = gridAttributes & "|(���)�����ȣ;SatOldPostNum;200;;l;" & "o;n;y;30;"       ' �������ȣ      
            '' ''gridAttributes = gridAttributes & "|(���)�ּ�;SatOldAddr1;200;;l;" & "o;n;n;30;"       ' �ּ�            
            '' ''gridAttributes = gridAttributes & "|(���)���ּ�;SatOldAddr2;200;;l;" & "o;n;n;30;"       ' ���ּ�        
            '' ''gridAttributes = gridAttributes & "|(���)��ȭ��ȣ;SatPhoneNum1;200;;l;" & "o;n;n;30;"       ' ��ȭ��ȣ        
            '' ''gridAttributes = gridAttributes & "|(���)�޴�����ȣ;SatMobileNum;200;;l;" & "o;n;n;30;"       ' �޴�����ȣ      
            '' ''gridAttributes = gridAttributes & "|(���)�����ڵ�;SatBranchCd;200;;l;" & "o;n;n;30;"       ' �����ڵ�        
            '' ''gridAttributes = gridAttributes & "|(���)���Կ�û��;SatDeliveryReqDt;200;;l;" & "o;n;n;30;"       ' ���Կ�û��      
            '' ''gridAttributes = gridAttributes & "|(���)�������;SatRealEdDt;200;;l;" & "o;n;y;30;"       ' ��������ڵ�    
            '' ''gridAttributes = gridAttributes & "|(���)��������;SatIngStateCd;200;;l;" & "o;n;y;30;"       ' ��������        
            '' ''gridAttributes = gridAttributes & "|(���)��޿���;SatDeliveryYn;200;;l;" & "o;n;y;30;"       ' ��޿���        
            '' ''gridAttributes = gridAttributes & "|(���)�뺸����;SatResultYn;200;;l;" & "o;n;y;30;"       ' �뺸����        
            '' ''gridAttributes = gridAttributes & "|(����)���ڸ�;ReaderNm;200;;l;" & "o;n;n;30;"       ' ���ڸ�          
            '' ''gridAttributes = gridAttributes & "|(����)��ȭ��ȣ1;PhoneNum1;200;;l;" & "o;n;n;30;"       ' ��ȭ��ȣ1       
            '' ''gridAttributes = gridAttributes & "|(����)��ȭ��ȣ2;PhoneNum2;200;;l;" & "o;n;n;30;"       ' ��ȭ��ȣ2       
            '' ''gridAttributes = gridAttributes & "|(����)�ڵ�����ȣ;MobileNum;200;;l;" & "o;n;n;30;"       ' �ڵ�����ȣ      
            '' ''gridAttributes = gridAttributes & "|(����)�������ȣ;OldPostNum;200;;l;" & "o;n;y;30;"       ' �������ȣ      
            '' ''gridAttributes = gridAttributes & "|(����)�ּ�;OldAddr1;200;;l;" & "o;n;n;30;"       ' ���ּ�          
            '' ''gridAttributes = gridAttributes & "|(����)���ּ�;OldAddr2;200;;l;" & "o;n;n;30;"       ' �����ּ�      
            '' ''gridAttributes = gridAttributes & "|(����)���������ڵ�;DeliveryBranchCd;200;;l;" & "o;n;n;30;"       ' ���������ڵ�    
            '' ''gridAttributes = gridAttributes & "|(����)������ȣ;BranchPhoneNum;200;;l;" & "o;n;n;30;"       ' ������ȣ        
            '' ''gridAttributes = gridAttributes & "|(����)��������ڵ�;BizChargeCd;200;;l;" & "o;n;y;30;"       ' ��������ڵ�    
            '' ''gridAttributes = gridAttributes & "|(����)�������;ChargeEmpNum;200;;l;" & "o;n;n;30;"       ' �������        
            '' ''gridAttributes = gridAttributes & "|(����)������� ��ȭ;ChargePhoneNum  ;200;;l;" & "o;n;y;30;"       ' ������� ��ȭ   

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

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNC206_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC206_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            ' ''���ڱ�������ȭ������ �̵�
            ''If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            ''Dim strSubscribeCd As String '������ȣ
            ''Dim strSubscriberNm As String '���ڸ�

            ''strSubscribeCd = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscribeCd")) '������ȣ
            ''strSubscriberNm = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscriberNm")) '���ڸ�

            ''GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC201;" & strSubscribeCd & ";" & strSubscriberNm)
            ''Me.ShowUiControl("PNC201", strSubscribeCd)
        End Sub

        Private Sub chkState1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkState1.CheckedChanged
            sbSetState()
        End Sub

        Private Sub chkState2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkState2.CheckedChanged
            sbSetState()
        End Sub

        Private Sub sbSetState()
            lblReaderStateCd_R.Visible = True
            cboReaderStateCd.Visible = True
            If chkState1.Checked = True Or chkState2.Checked = True Then
                lblReaderStateCd_R.Visible = False
                cboReaderStateCd.Visible = False
            End If
        End Sub

    End Class

End Namespace
