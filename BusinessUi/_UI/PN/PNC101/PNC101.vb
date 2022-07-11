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
Imports System.Collections.Generic

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC101
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
            gridAttributes = gridAttributes & "|�������ڹ�ȣ;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;145;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;94;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;97;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;0;;4;" & "o;n;y;10;�����ȣ;CodeHangulName"
            gridAttributes = gridAttributes & "|�ּ�;CodeHangulName;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;207;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;224;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��������;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|����;Orders;0;;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|�ſ����ȣ;NewPostNum;0;;4;" & "o;n;y;10;�����ȣ;CodeHangulName"
            gridAttributes = gridAttributes & "|�ּ�;CodeHangulName;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|���ּ�;NewAddr1;0;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|�Ż��ּ�;NewAddr2;0;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;0;;1;" & "o;n;y;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|���� ��;DeliveryBranchNm;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;88;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ޱ����ڵ�;DeliveryDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;62;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|�����ڵ�;SubscribeCd;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����Ȯ���ȣ;BranchExpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|���ڻ����ڵ�;ReaderStateCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ä���ڵ�;DeliveryChnlCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|������ڵ�;EmployeeNumber;70;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            Me.popEmployeeNumber.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            Me.NewData()

            '' '' ''==============================================================
            '' '' ''  grid_2 �� �ʱ�ȭ �Ѵ�.
            '' '' ''--------------------------------------------------------------
            ' '' ''gridAttributes = ""
            '' '' ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            ' '' ''gridAttributes = gridAttributes & "n;r;y"

            '' '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            ' '' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            ' '' ''gridAttributes = gridAttributes & "|�����ڵ�;SubscribeCd;100;;l;" & "o;n;n;10;"       '(10)
            ' '' ''gridAttributes = gridAttributes & "|�����ڵ�;ReaderCd;80;;l;" & "o;n;n;8;"       '(10)
            ' '' ''gridAttributes = gridAttributes & "|���ڸ�;ReaderNm;100;;l;" & "o;n;n;10;"       '(20)
            '' '' ''gridAttributes = gridAttributes & "|�����ڵ�;ReaderCd;80;;l;" & "o;n;n;8;"       '(20)
            ' '' ''gridAttributes = gridAttributes & "|����;Orders;40;;r;" & "o;n;y;4;"       '(30)
            ' '' ''gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;200;;l;" & "o;n;n;30;"       '(30)
            ' '' ''gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;200;;l;" & "o;n;n;30;"       '(40)

            ' '' ''gridAttributes = gridAttributes & "|���������ڵ�;SubscribeStateCd;100;;l;" & "o;n;n;10;"       '(40)
            ' '' ''gridAttributes = gridAttributes & "|Ȯ�屸���ڵ�;ExpandDivCd;100;;l;" & "o;n;n;10;"       '(50)
            ' '' ''gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;200;;l;" & "o;n;n;30;"       '(50)
            ' '' ''gridAttributes = gridAttributes & "|�ſ����ȣ;NewPostNum;100;;l;" & "o;n;n;10;"       '(60)
            ' '' ''gridAttributes = gridAttributes & "|���ڱ����ڵ�;ReaderDivCd;100;;l;" & "o;n;n;10;"       '(60)
            ' '' ''gridAttributes = gridAttributes & "|���ڻ����ڵ�;ReaderStateCd;100;;l;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|���ּ�;NewAddr1;200;;l;" & "o;n;n;50;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|�Ż��ּ�;NewAddr2;200;;l;" & "o;n;n;100;"       '(80)
            ' '' ''gridAttributes = gridAttributes & "|���ó�����ڵ�;DeliveryRegionCd;100;;l;" & "o;n;n;10;"       '(80)
            ' '' ''gridAttributes = gridAttributes & "|��ޱ����ڵ�;DeliveryDivCd;100;;l;" & "o;n;n;10;"       '(90)
            ' '' ''gridAttributes = gridAttributes & "|�������ȣ;OldPostNum;100;;l;" & "o;n;n;10;�����ȣ;CodeHangulName"
            ' '' ''gridAttributes = gridAttributes & "|�ּ�;CodeHangulName;90;;c;" & "o;n;y;5;"          '(90)
            ' '' ''gridAttributes = gridAttributes & "|���ּ�;OldAddr1;200;;l;" & "o;n;n;50;"       '(100)
            ' '' ''gridAttributes = gridAttributes & "|���絶�ڱ����ڵ�;MHReaderDivCd;100;;l;" & "o;n;n;10;"       '(100)
            ' '' ''gridAttributes = gridAttributes & "|���˿���;PromotionYN;10;;c;" & "o;n;n;1;"       '(110)
            ' '' ''gridAttributes = gridAttributes & "|�����ּ�;OldAddr2;200;;l;" & "o;n;n;100;"       '(110)
            ' '' ''gridAttributes = gridAttributes & "|���˻����;PromotionEmpNm;200;;l;" & "o;n;n;30;"       '(120)
            ' '' ''gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;100;;l;" & "o;n;n;10;"       '(130)
            ' '' ''gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;100;;l;" & "o;n;n;10;"       '(140)
            ' '' ''gridAttributes = gridAttributes & "|û���ֱ��ڵ�;BillPeriodCd;100;;l;" & "o;n;n;10;"       '(150)
            ' '' ''gridAttributes = gridAttributes & "|��������;ContactDt;80;;l;" & "o;n;n;8;"       '(160)
            ' '' ''gridAttributes = gridAttributes & "|��������;FixedStDt;80;;l;" & "o;n;n;8;"       '(170)
            ' '' ''gridAttributes = gridAttributes & "|������������;FixedEdDt;80;;l;" & "o;n;n;8;"       '(180)
            ' '' ''gridAttributes = gridAttributes & "|��������;StopDt;80;;l;" & "o;n;n;8;"       '(190)
            ' '' ''gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceTerm;40;;r;" & "o;n;n;4;"       '(200)
            ' '' ''gridAttributes = gridAttributes & "|�����μ�;ContactPaperNum;40;;r;" & "o;n;n;4;"       '(210)
            ' '' ''gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;40;;r;" & "o;n;n;4;"       '(220)
            ' '' ''gridAttributes = gridAttributes & "|���Ժμ�;SubscribePagerNum;40;;r;" & "o;n;n;4;"       '(230)
            ' '' ''gridAttributes = gridAttributes & "|�����μ�;StopPaperNum;40;;r;" & "o;n;n;4;"       '(240)
            ' '' ''gridAttributes = gridAttributes & "|���ݽ��۳��;CollectionYYYYMM;60;;l;" & "o;n;n;6;"       '(250)
            ' '' ''gridAttributes = gridAttributes & "|���������ڵ�;ReceiptBranchCd;70;;l;" & "o;n;n;7;�����ڵ�;BranchNm"       '(300)
            ' '' ''gridAttributes = gridAttributes & "|���� ��;BranchNm;70;;l;" & "o;n;y;7;"
            ' '' ''gridAttributes = gridAttributes & "|���������ڵ�;SubscribeBranchCd;70;;l;" & "o;n;n;7;�����ڵ�;BranchNm"       '(300)
            ' '' ''gridAttributes = gridAttributes & "|�������� ��;BranchNm;70;;l;" & "o;n;n;7;"       '(310)
            ' '' ''gridAttributes = gridAttributes & "|���������ڵ�;ReceiptMoneyBranchCd;70;;l;" & "o;n;n;7;�����ڵ�;BranchNm"       '(300)
            ' '' ''gridAttributes = gridAttributes & "|�������� ��;BranchNm;70;;l;" & "o;n;n;7;"       '(320)
            ' '' ''gridAttributes = gridAttributes & "|���������ڵ�;ValPaperBranchCd;70;;l;" & "o;n;n;7;�����ڵ�;BranchNm"       '(300)
            ' '' ''gridAttributes = gridAttributes & "|�������� ��;BranchNm;70;;l;" & "o;n;n;7;"       '(330)
            ' '' ''gridAttributes = gridAttributes & "|���;Note;200;;l;" & "o;n;n;20;"       '(340)

            '' '' ''grid_2 code combo    
            ' '' ''gridCodeNameList = ""
            ' '' ''gridCodeNameList = gridCodeNameList & "SubscribeStateCd;���������ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/CollectionDivCd;���������ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"
            ' '' ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;û���ֱ��ڵ�"
            ' '' ''grd_3.Initialize(gridAttributes, gridCodeNameList)
            ' '' '' ''Me.grd_2.ExplorerBar = Me.grd_2.get_ColIndex("EmployeeNumber")

        End Sub
#End Region

#Region "�� �̺�Ʈ"

        Private Sub PNC101_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
            Me.txtTemp.TextValue = ""
        End Sub
        ''' <summary>
        ''' �Լ��� : PNC101_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
            Dim dtpContactDtStr As String = Me.dtpContactDt.TextValue
            SaveData()
            RequestData()
            NewData(dtpContactDtStr)
            Me.txtTemp.TextValue = ""
            GrecordProcessMode = "1"
            txtSubscriberNm.Focus()
        End Sub

        ''' <summary>
        ''' �Լ��� : PNC101_Enter 
        ''' ��  �� : ȭ�� ��ȯ(����Ȯ�� ���� ���� ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC101_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                If ShareParameters.Length = 5 Then
                    SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), "1")
                ElseIf ShareParameters.Length = 6 Then
                    SetRequest2(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5))
                ElseIf ShareParameters.Length = 9 Then
                    SetRequest3(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5), ShareParameters(6), ShareParameters(7), ShareParameters(8))
                End If
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
                              ByVal strReceiptCd As String, ByVal strSubscriberNm As String, _
                              Optional ByVal strProcGb As String = "1")

            GmainCommonFunction.ControlNewData(Me, Me.picCriteria)

            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '��������
            Me.dtpReceiptDtTo.TextValue = strToDt      '��������
            Me.txtReceiptCd_2.TextValue = strReceiptCd  '�������ڹ�ȣ
            Me.txtSubscriberNm_2.TextValue = strSubscriberNm  '�������ڸ�

            If strProcGb = "1" Then   'ó�� ���� 1:���� ��ȸ
                GrecordProcessMode = "2"   ' ��ȸ ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestData", CallType.Method)
            ElseIf strProcGb = "2" Then   'ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�, 5:WEB���� ��ȯ
                GrecordProcessMode = "1"   ' �ű� ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeRemove", CallType.Method)
            ElseIf strProcGb = "3" Then   'ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�, 5:WEB���� ��ȯ
                GrecordProcessMode = "1"   ' �ű� ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeReExpand", CallType.Method)
                Me.cboReaderStateCd.TextValue = "2"
            ElseIf strProcGb = "5" Then   'ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�, 5:WEB���� ��ȯ
                GrecordProcessMode = "1"   ' �ű� ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataWebExpand", CallType.Method)
                Me.cboReaderStateCd.TextValue = "1"
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
        Public Sub SetRequest2(ByVal strFromDt As String, ByVal strToDt As String, _
                              ByVal strReceiptCd As String, ByVal strSubscriberNm As String, _
                              Optional ByVal strProcGb As String = "1")

            GmainCommonFunction.ControlNewData(Me, Me.picCriteria)

            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '��������
            Me.dtpReceiptDtTo.TextValue = strToDt      '��������
            Me.txtReceiptCd_2.TextValue = strReceiptCd  '�������ڹ�ȣ
            Me.txtSubscriberNm_2.TextValue = strSubscriberNm  '�������ڸ�

            If strProcGb = "1" Then   'ó�� ���� 1:���� ��ȸ
                GrecordProcessMode = "2"   ' ��ȸ ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestData", CallType.Method)
            ElseIf strProcGb = "2" Then   'ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�, 5:WEB���� ��ȯ
                GrecordProcessMode = "1"   ' �ű� ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeRemove", CallType.Method)
            ElseIf strProcGb = "3" Then   'ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�, 5:WEB���� ��ȯ
                GrecordProcessMode = "1"   ' �ű� ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeReExpand", CallType.Method)
                Me.cboReaderStateCd.TextValue = "2"
            ElseIf strProcGb = "5" Then   'ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�, 5:WEB���� ��ȯ
                GrecordProcessMode = "1"   ' �ű� ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataWebExpand", CallType.Method)
                Me.cboReaderStateCd.TextValue = "1"
                'ElseIf strProcGb = "4" Then   'ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�
                '    GrecordProcessMode = "2"   ' ��ȸ ���� ����
                '    Me.dtpReceiptDtFrom.TextValue = "2000-01-01"
                '    Me.txtReceiptCd_2.TextValue = ""
                '    'Me.GmainCommonFunction.GRequestDataNumber = 9
                '    CallByName(Me, "RequestData", CallType.Method)

                '    CallByName(Me, "NewData", CallType.Method)

            End If

            
        End Sub
        'SetSendMessage("ȭ�� ��ȯ", "PNC101",
        '           string.Format(@"{0};{1};{2};{3};{4};{5};{6};{7};{8};4", "PNC101",
        '       // 0
        '       clsConsulation.vPkey.Substring(0, 6) + "01", // ��ȸ������
        '       // 1 // ������
        '       CTICommonFun.GetDate(DateTime.Now).ToString(),
        '       // 2 // ���ڸ�
        '        clsConsulation.SubscribeNm.ToString(),
        '       // 3 // �����ȣ
        '        clsConsulation.PostNum.ToString(),
        '       // 4 // �ּ�
        '        clsConsulation.Addr1.ToString(),
        '       // 5 // ���ּ�
        '        clsConsulation.Addr2.ToString(),
        '       // 6 // �����ڵ�
        '        clsConsulation.BranchCd.ToString(),
        '       // 7 // �������ڵ�
        '        clsConsulation.BranchChiefCd.ToString(),
        '       // 8 // ����������ڵ�
        '        clsConsulation.ChargeEmpNum.ToString()
        '       ), LogInfo);

        ''' <summary>
        ''' �Լ��� : Request
        ''' ��  �� : �ٸ� ȭ�鿡�� �ڵ� �� �޾Ƽ� �ش� ������ ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetRequest3(ByVal strReciptDt As String, _
                               ByVal strSubscribeNm As String, _
                               ByVal strPhoneNumber As String, _
                               ByVal strPostNum As String, _
                               ByVal strAddr1 As String, _
                               ByVal strAddr2 As String, _
                               ByVal strBranchCd As String, _
                               ByVal strBranchChiefNm As String _
                               )
            '' ��ȸó��

            Me.dtpReceiptDtFrom.TextValue = "2000-01-01"
            Me.txtSubscriberNm_2.TextValue = strSubscribeNm
            Me.txtPhoneNum_2.TextValue = strPhoneNumber
            Me.popEmployeeNumber.CodeText = ""
            Me.popEmployeeNumber.TextValue = ""
            Me.txtReceiptCd_2.TextValue = ""
            CallByName(Me, "RequestData", CallType.Method)

            '' �ű� ó��
            CallByName(Me, "NewData", CallType.Method)
            GrecordProcessMode = "1"
            Me.dtpContactDt.TextValue = strReciptDt
            Me.txtSubscriberNm.TextValue = strSubscribeNm
            Me.txtPhoneNum1.TextValue = strPhoneNumber
            Me.popOldPostNum.CodeText = strPostNum
            Me.txtOldAddr1.TextValue = strAddr1
            Me.txtOldAddr2.TextValue = strAddr2
            Me.popDeliveryBranchCd.CodeText = strBranchCd
            Me.txtTrAdEmployeeNm.TextValue = strBranchChiefNm




        End Sub



        Private Sub btnPRB002_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRB002.Click

            '����� ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '�������ڹ�ȣ
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("EmployeeNumber")
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC103;" & strCode)
            ShowUiControl("PNC103", strCode)

        End Sub
        ''' <summary>
        ''' 1. ���� ������� �ԷµǸ� 1���� �����Ͽ� �������������� �Ѹ���.
        ''' 2. ���� ������� �ԷµǸ� ���������Ϻ��� ���ݳ������ ����Ͽ� ���� ������ �Ѹ���.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub dtpCollectionYYYYMM_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCollectionYYYYMM.Leave
            '' ���� ������ ���
            If dtpCollectionYYYYMM.TextValue <> "" Then
                dtpFixedEdDt.TextValue = "99991231"
            End If
            '' ���� ���� ���
            If dtpFixedStDt.TextValue <> "" And dtpCollectionYYYYMM.TextValue <> "" Then
                Dim sdt As DateTime = dtpFixedStDt.Value()
                Dim cdt As DateTime = dtpCollectionYYYYMM.Value()
                Dim rtnMonth As Integer = 0

                If sdt.Year = cdt.Year Then
                    rtnMonth = cdt.Month - sdt.Month
                Else
                    If sdt.Year - cdt.Year <> 0 Then
                        Dim YearEndMonth As DateTime = sdt.ToString("yyyy-12-31")
                        Dim m1 As Integer = YearEndMonth.Month - sdt.Month
                        Dim m2 As Integer = cdt.Month
                        rtnMonth = m1 + m2
                    End If

                End If
                numServiceTerm.Text = rtnMonth
            End If

        End Sub


        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

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


        Private Sub txtTemp_TextChanged1() Handles txtTemp.TextChanged
            '��������/���� ����/ �����ڸ�/�� �����ڸ� ��������
            If txtTemp.TextValue <> "" Then
                ChngAddResult()
                Me.txtTemp.TextValue = ""
            End If
        End Sub

        Private Sub txtOldAddr1_TextChanged() Handles txtOldAddr1.TextChanged
            '��������/���� ����/ �����ڸ�/�� �����ڸ� ��������
            If Me.popOldPostNum.TextValue <> "" And txtTemp.TextValue <> "" Then
                ChngAddResult()
                Me.txtTemp.TextValue = ""
            End If
        End Sub

        Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click

            Dim rtnVal As String = vbNullString
            With grd_1
                For intII As Integer = 1 To .Cols - 1
                    rtnVal = rtnVal & vbCrLf _
                                    & "[" & intII.ToString & "]" & " " _
                                    & "|" & intII.ToString & "" & ";" _
                                    & .get_ColKey(intII) & ";" _
                                    & .get_ColWidth(intII) & ";" _
                                    & .get_ColFormat(intII) & ";" _
                                    & .get_ColAlignment(intII) & ";" _
                                    & " & " & .get_ColData(intII).ToString & vbTab
                Next
            End With
            ''gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;100;;l;" & "o;n;y;10;�����ȣ;CodeHangulName"

            MsgBox(rtnVal)
        End Sub

        Private Sub picIo_2_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picIo_2_4.Click

        End Sub

        Private Sub btnExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpand.Click

        End Sub

        Private Sub PNC101_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

            Me.txtTemp.TextValue = ""
        End Sub

        Private Sub popOldPostNum_UserCodeTextChange() Handles popOldPostNum.UserCodeTextChange
            If Me.txtTemp.TextValue = "" Then

            Else
                ChngAddResult()

                Me.txtTemp.TextValue = ""
            End If
        End Sub

        Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
            GmainCommonFunction.LoadCustomForm("CommonPopup2.dll", "frmExistReader", txtSubscriberNm_2.TextValue, txtAddr_2.TextValue, txtPhoneNum_2.TextValue)
        End Sub
    End Class

End Namespace
