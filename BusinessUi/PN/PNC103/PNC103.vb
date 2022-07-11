' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : 
' form���� :
' �ۼ��� : 
' �ۼ��� : 
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

    Public Class PNC103
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
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|�����ó���ڵ�;MonitoringResultCd;99;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;157;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;97;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;95;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;198;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;211;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|�ſ����ȣ;NewPostNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|���ּ�;NewAddr1;0;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|�Ż��ּ�;NewAddr2;0;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|����������;DeliveryBranchNm;74;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;94;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;ContactDt;77;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|����;Orders;48;;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|������ڵ�;EmployeeNumber;74;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|;Merong;40;;7;" & "o;n;n;4;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "MonitoringResultCd;����Ͱ��ó���ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNC103_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC103_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        ''' <summary>
        ''' �Լ��� : PNC103_Enter 
        ''' ��  �� : ȭ�� ��ȯ(����� ���)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC103_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5))
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
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, ByVal strReceiptCd As String, ByVal strSubscriberNm As String, ByVal strEmployeeNm As String)

            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpContactDtFrom.TextValue = strFromDt          '��������
            Me.dtpContactDtTo.TextValue = strToDt              '��������
            Me.txtReceiptCd_2.TextValue = strReceiptCd         '�������ڹ�ȣ
            Me.txtSubscriberNm_2.TextValue = strSubscriberNm   '�������ڸ�

            Me.popEmployeeNumber.TextValue = strEmployeeNm     '����� �ڵ�

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
