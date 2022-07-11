' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : ���Ȯ���������ڵ��
' form���� : ���Ȯ���������ڵ�� �Ѵ�
' �ۼ��� : ������
' �ۼ��� : 2008-09-19
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
Imports System.Collections.Generic

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC105
        Inherits CommonControls.UiControl

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
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;12;;;" & "o;n;y;12;"       '(190)
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;13;;;" & "o;n;y;13;"       '(10)
            gridAttributes = gridAttributes & "|�����ó���ڵ�;MonitoringResultCd;100;;l;" & "o;n;n;10;"       '(370)
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;100;;l;" & "o;n;n;10;"       '(370)
            gridAttributes = gridAttributes & "|��������;ContactDt;8;;;" & "o;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|����;Orders;4;;;" & "o;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;30;;;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|����;ContactPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)
            gridAttributes = gridAttributes & "|��ȭ1;PhoneNum1;30;;;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|�ڵ���;MobileNum;30;;;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;10;;;" & "o;n;n;10;�����ȣ;OldAddr1;"       '(130)
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;50;;;" & "o;n;n;50;"       '(140)
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;100;;;" & "o;n;n;100;"       '(150)
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;7;c;;" & "o;n;n;7;�����ڵ�;DeliveryBranchNm;"       '(160)
            gridAttributes = gridAttributes & "|����������;DeliveryBranchNm;7;;;" & "o;n;n;7;"       '(160)
            gridAttributes = gridAttributes & "|�������޻���;Note2;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;8;;;" & "o;n;n;8;"       '(62)
            gridAttributes = gridAttributes & "|������������;FixedEdDt;8;;;" & "o;n;n;8;"       '(63)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "MonitoringResultCd;����Ͱ��ó���ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------

            Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            Me.dtpReceiptDtTo.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")

            Me.NewData()

        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNC105_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC105_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        ''' <summary>
        ''' �Լ��� : PNC105_Enter 
        ''' ��  �� : ȭ�� ��ȯ(����� ���)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC105_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4))
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
            End If
        End Sub

        ''' <summary>
        ''' �Լ��� : Request
        ''' ��  �� : �ٸ� ȭ�鿡�� �ڵ� �� �޾Ƽ� �ش� ������ ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, ByVal strReceiptCd As String, ByVal strSubscriberNm As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '��������
            Me.dtpReceiptDtTo.TextValue = strToDt      '��������
            Me.txtReceiptCd_2_R.TextValue = strReceiptCd  '�������ڹ�ȣ
            Me.txtSubscriberNm_2_R.TextValue = strSubscriberNm  '�������ڸ�

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub


        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            ' '' 1. Ȯ�屸�� cboExpandDivCd
            ' '' 2. ������ȣ txtReceiptCd
            ' '' 3. ���ڹ�ȣ
            ' '' 4. ��ȭ��ȣ
            ' ''    --> Ȯ�屸���ڵ�|�ű�);where(Note1='��Ȯ'

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum1.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum2.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))

        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtMobileNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))

        End Sub
    End Class

End Namespace
