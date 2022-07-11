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

    [Partial] Class PNC101

        ''' <summary>
        ''' �Լ��� : NewData 
        ''' ��  �� : �ű� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()

            'GmainCommonFunction.ControlNewData(Me, Me.picCriteria)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_3)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_4)

            'Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            'Me.dtpReceiptDtTo.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            Me.dtpContactDt.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            Me.popMonitoringEmpNum.TextValue = GmainBusinessFunction.GetValue("�α��� ID")

            cboExpandDivCd.TextValue = "2"
            cboCollectionTypeCd.TextValue = "2"
            numContactPaperNum.TextValue = "1"
        End Sub

        Public Sub NewData(ByVal dtpContactDtStr As String)

            'GmainCommonFunction.ControlNewData(Me, Me.picCriteria)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_3)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_4)

            'Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            'Me.dtpReceiptDtTo.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            Me.dtpContactDt.TextValue = dtpContactDtStr
            Me.popMonitoringEmpNum.TextValue = GmainBusinessFunction.GetValue("�α��� ID")

            cboExpandDivCd.TextValue = "2"
            cboCollectionTypeCd.TextValue = "2"
            numContactPaperNum.TextValue = "1"
        End Sub

        ''' <summary>
        ''' �Լ��� : RequestData 
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            Dim blnRequestYesOrNo As Boolean = True
            '' ''If txtReceiptCd_2.TextValue.ToString.Length < 1 _
            '' ''    And txtSubscriberNm_2.TextValue.ToString.Length < 1 _
            '' ''    And popDeliveryBranchCd_2.TextValue.ToString.Length < 1 _
            '' ''    And popEmployeeNumber.TextValue.ToString.Length < 1 _
            '' ''    And txtPhoneNum_2.TextValue.ToString.Length < 1 _
            '' ''    And txtAddr_2.TextValue.ToString.Length < 1 Then
            '' ''    blnRequestYesOrNo = False
            '' ''    MessageBox.Show("�ϳ� �̻��� �˻� ������ �Է� �ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''End If
            If blnRequestYesOrNo Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AdeliveryBranchCd", Me.popDeliveryBranchCd_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_R", False, True, GmainsqlParameters)
                    Me.grd_1.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
            End If

        End Sub

        ''' <summary>
        ''' �Լ��� : RequestData_2
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.grd_1.GetCurrentRowCellValue("ReceiptCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                GrecordProcessMode = "2"
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : RequestDataSubscribeRemove
        ''' ��  �� : �̻� ���� �ű� �Է��� ���� ���� ���� ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestDataSubscribeRemove(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                ' '' ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_2_R", False, True, GmainsqlParameters)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGB", "2")      '' '' ''ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_5_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                dtpFixedStDt.TextValue = ""

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                GrecordProcessMode = "1"
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : RequestDataSubscribeReExpand
        ''' ��  �� : ��Ȯ�� �ű� �Է��� ���� ���� ���� ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestDataSubscribeReExpand(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                ' '' ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_2_R", False, True, GmainsqlParameters)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGB", "3")      '' '' ''ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_5_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                dtpFixedStDt.TextValue = ""

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                GrecordProcessMode = "1"
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : RequestDataWebExpand
        ''' ��  �� : WEB���� ���� �ű� �Է��� ���� ���� ���� ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestDataWebExpand(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                ' '' ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_2_R", False, True, GmainsqlParameters)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGB", "5")      '' '' ''ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�, 5:WEB���� ��ȯ
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_5_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                'dtpFixedStDt.TextValue = ""

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                GrecordProcessMode = "1"
            End With

        End Sub

        '''' <summary>
        '''' �Լ��� : RequestData_3
        '''' ��  �� : ��ȸ
        '''' �ۼ��� : 
        '''' �ۼ��� : 
        '''' ������ : 
        '''' ������ : 
        '''' </summary>
        '''' <param name="AprocessMessage"></param>
        '''' <remarks></remarks>
        Public Sub ChngAddResult()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                If dtpContactDt.TextValue = "" Then
                    MsgBox("�������� �Է��ϼ���.")
                    Return
                ElseIf txtTemp.TextValue = "" Then
                    MsgBox("�����ȣ�� Ȯ���ϼ���.")
                End If
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", txtTemp.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AContactDt", dtpContactDt.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_4_R", False, True, GmainsqlParameters)


                If Not IsNothing(reciveDataSet) Then
                    If reciveDataSet.Tables(0).Rows.Count > 0 Then

                        Me.popDeliveryBranchCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchCd")
                        Me.popAdBranchCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchCd")
                        Me.txtTrAdEmployeeNm.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchName")
                        Me.txtAdEmployeeNm.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchName")
                    Else
                        Exit Sub
                    End If
                Else
                    'popDeliveryBranchCd.TextValue = txtOldSubscribeCd.TextValue
                    'popAdBranchCd.TextValue = txtOldSubscribeCd.TextValue
                    Exit Sub
                End If
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : SaveData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) 'Record

                .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AContactDt", dtpContactDt.TextValue) '��������
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue) '���ڸ�
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue) '���ڻ����ڵ�

                .SetSqlParameter(GmainsqlParameters, "@AOldSubscribeCd", Me.txtOldSubscribeCd.TextValue) '���� �ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AOldSubscriberReceiptCd", Me.txtOldSubscriberReceiptCd.TextValue) '���� ���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AWebPkey", Me.numWebPkey.TextValue) 'Web�������� Pkey

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue) '����ó�ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", Me.chkApprovalYN.Checked) '���ο���

                .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '��ȭ��ȣ1
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '��ȭ��ȣ2
                .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '�ڵ�����ȣ
                .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", popNewPostNum.TextValue) '�ſ����ȣ
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", txtNewAddr1.TextValue) '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '�Ż��ּ�
                .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", popOldPostNum.TextValue) '�������ȣ
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", txtOldAddr1.TextValue) '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '�����ּ�

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchCd", popDeliveryBranchCd.TextValue) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AAdBranchCd", popAdBranchCd.TextValue) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", txtTrAdEmployeeNm.TextValue) '������ ��
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", txtAdEmployeeNm.TextValue) '�� ������ ��

                .SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", cboExpandDivCd.TextValue) 'Ȯ�� ����
                .SetSqlParameter(GmainsqlParameters, "@AMHReaderDivCd", cboMHReaderDivCd.TextValue) '���絶�ڱ����ڵ� 
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryRegionCd", cboDeliveryRegionCd.TextValue) '���ó�����ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryDivCd", cboDeliveryDivCd.TextValue) '��ޱ����ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", cboCollectionTypeCd.TextValue) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ABillPeriodCd", cboBillPeriodCd.TextValue) '�����ֱ��ڵ�

                .SetSqlParameter(GmainsqlParameters, "@AContactPaperNum", numContactPaperNum.TextValue) '�����μ�
                .SetSqlParameter(GmainsqlParameters, "@AFixedPagerNum", numFixedPagerNum.TextValue) '���Ժμ�
                .SetSqlParameter(GmainsqlParameters, "@AFixedStDt", dtpFixedStDt.TextValue) '��������
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", dtpFixedEdDt.TextValue) '������������
                .SetSqlParameter(GmainsqlParameters, "@ACollectionYYYYMM", dtpCollectionYYYYMM.TextValue) '���ݳ��
                .SetSqlParameter(GmainsqlParameters, "@AServiceTerm", numServiceTerm.TextValue) '���񽺱Ⱓ

                .SetSqlParameter(GmainsqlParameters, "@ASolicitorCorpCd", popSolicitorCorpCd.TextValue) '�Ҽӻ��ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ACouponReaderYN", chkCouponReaderYN.Checked) '�����ǵ��ڿ���
                .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked) '�������뺸����
                .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", dtpSolicitorNotifyDt.TextValue) '�������뺸����
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", popMonitoringEmpNum.TextValue) '����� ���
                .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue) '���
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GrecordProcessMode = "2"
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            Me.txtTemp.TextValue = ""

        End Sub

        ''' <summary>
        ''' �Լ��� : DeleteData 
        ''' ��  �� : ���� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", "3") 'Record ����
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue) '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AContactDt", dtpContactDt.TextValue) '��������
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue) '���ڸ�
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue) '���ڻ����ڵ�

                    .SetSqlParameter(GmainsqlParameters, "@AOldSubscribeCd", Me.txtOldSubscribeCd.TextValue) '���� �ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AOldSubscriberReceiptCd", Me.txtReceiptCd.TextValue) '���� ���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AWebPkey", Me.numWebPkey.TextValue) 'Web�������� Pkey

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue) '����ó�ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", Me.chkApprovalYN.Checked) '���ο���

                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '��ȭ��ȣ1
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '��ȭ��ȣ2
                    .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '�ڵ�����ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", popNewPostNum.TextValue) '�ſ����ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", txtNewAddr1.TextValue) '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '�Ż��ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", popOldPostNum.TextValue) '�������ȣ
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", txtOldAddr1.TextValue) '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '�����ּ�

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchCd", popDeliveryBranchCd.TextValue) '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AAdBranchCd", popAdBranchCd.TextValue) '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", txtTrAdEmployeeNm.TextValue) '������ ��
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", txtAdEmployeeNm.TextValue) '�� ������ ��

                    .SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", cboExpandDivCd.TextValue) 'Ȯ�� ����
                    .SetSqlParameter(GmainsqlParameters, "@AMHReaderDivCd", cboMHReaderDivCd.TextValue) '���絶�ڱ����ڵ� 
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryRegionCd", cboDeliveryRegionCd.TextValue) '���ó�����ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryDivCd", cboDeliveryDivCd.TextValue) '��ޱ����ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", cboCollectionTypeCd.TextValue) '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ABillPeriodCd", cboBillPeriodCd.TextValue) '�����ֱ��ڵ�

                    .SetSqlParameter(GmainsqlParameters, "@AContactPaperNum", numContactPaperNum.TextValue) '�����μ�
                    .SetSqlParameter(GmainsqlParameters, "@AFixedPagerNum", numFixedPagerNum.TextValue) '���Ժμ�
                    .SetSqlParameter(GmainsqlParameters, "@AFixedStDt", dtpFixedStDt.TextValue) '��������
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", dtpFixedEdDt.TextValue) '������������
                    .SetSqlParameter(GmainsqlParameters, "@ACollectionYYYYMM", dtpCollectionYYYYMM.TextValue) '���ݳ��
                    .SetSqlParameter(GmainsqlParameters, "@AServiceTerm", numServiceTerm.TextValue) '���񽺱Ⱓ

                    .SetSqlParameter(GmainsqlParameters, "@ASolicitorCorpCd", popSolicitorCorpCd.TextValue) '�Ҽӻ��ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ACouponReaderYN", chkCouponReaderYN.Checked) '�����ǵ��ڿ���
                    .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked) '�������뺸����
                    .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", dtpSolicitorNotifyDt.TextValue) '�������뺸����
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", popMonitoringEmpNum.TextValue) '����� ���
                    .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue) '���
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If   '' Result end

        End Sub

    End Class

End Namespace

