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


Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC202
        Inherits CommonControls.UiControl
        '====================================================================================================


#Region "�� �ʱ�ȭ"

        Public Sub Initialize()

            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|�����ڵ�;ReaderCd;80;;l;" & "o;n;n;8;"       '(10)
            gridAttributes = gridAttributes & "|���ڸ�;ReaderNm;100;;l;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;200;;l;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;200;;l;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;200;;l;" & "o;n;n;30;"       '(50)
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;100;;l;" & "o;n;n;10;"       '(90)
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;200;;l;" & "o;n;n;50;"       '(100)
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;200;;l;" & "o;n;n;100;"       '(110)
            gridAttributes = gridAttributes & "|�ſ����ȣ;NewPostNum;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|���ּ�;NewAddr1;200;;l;" & "o;n;y;50;"       '(70)
            gridAttributes = gridAttributes & "|�Ż��ּ�;NewAddr2;200;;l;" & "o;n;y;100;"       '(80)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|�����ڵ�;ReaderCd;80;;l;" & "io;n;y;8;"         '(10)
            gridAttributes = gridAttributes & "|����;Orders;80;;l;" & "io;n;y;8;"         '(10)
            gridAttributes = gridAttributes & "|��䵶�ڸ�;SatReaderNm;200;;l;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|������ȭ��ȣ;SatPhoneNum1;200;;l;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;SatMobileNum;200;;l;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|�����ڵ�;SatBranchCd;100;;l;" & "io;n;n;10;������;SatBranchNm"       '(10)
            gridAttributes = gridAttributes & "|������;SatBranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����ȣ;SatOldPostNum;100;;l;" & "io;n;n;10;"   '(60)
            gridAttributes = gridAttributes & "|�ּ�;SatOldAddr1;200;;l;" & "io;n;n;50;"          '(70)
            gridAttributes = gridAttributes & "|���ּ�;SatOldAddr2;200;;l;" & "io;n;n;100;"     '(80)
            gridAttributes = gridAttributes & "|(��)�����ȣ;SatNewPostNum;200;;l;" & "io;n;y;30;"   '(30)
            gridAttributes = gridAttributes & "|(��)�ּ�;SatNewAddr1;200;;l;" & "io;n;y;30;"         '(40)
            gridAttributes = gridAttributes & "|(��)���ּ�;SatNewAddr2;200;;l;" & "io;n;y;30;"     '(50)
            gridAttributes = gridAttributes & "|���Կ�û��;DeliveryReqDt;100;;l;" & "io;n;n;10;" '(90)
            gridAttributes = gridAttributes & "|��������;ReceiptDt;200;;l;" & "io;n;n;50;"       '(100)
            gridAttributes = gridAttributes & "|��������ڵ�;IngStateCd;200;;l;" & "io;n;n;100;" '(110)

            'grid_2 code combo    
            gridCodeNameList = ""

            'gridCodeNameList = gridCodeNameList & "SubscribeStateCd;���������ڵ�"
            'gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"


            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3

            lblRecordState.Text = "�غ�"

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
        Private Sub ACA003_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        ''' <summary>
        ''' �Լ��� : PNC202_Enter 
        ''' ��  �� : ȭ�� ��ȯ(��䰡����� ���� ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC202_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
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
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, _
                              ByVal strReceiptCd As String, ByVal strSubscriberNm As String )
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '��������
            Me.dtpReceiptDtTo.TextValue = strToDt      '��������
            Me.txtReceiptCd_R.TextValue = strReceiptCd  '�������ڹ�ȣ
            Me.txtSubscriberNm_R.TextValue = strSubscriberNm  '�������ڸ�

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            'Me.GmainCommonFunction.GRequestDataNumber = 9
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub grd_2_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

            Me.grd_2.Editable = EditableSettings.flexEDNone

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

        ''' <summary>
        ''' ���� ����������ȭ
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtBranchPhoneNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))
        End Sub

        ''' <summary>
        ''' ���� ��������� ��ȭ
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtChargePhoneNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))
        End Sub

        ''' <summary>
        ''' ����� ������ȭ
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtSatBranchPhoneNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))
        End Sub

        ''' <summary>
        ''' ����� ��������� ��ȭ
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtSatChargePhoneNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))
        End Sub


    End Class

End Namespace
