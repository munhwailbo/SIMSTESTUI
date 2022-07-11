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

    Partial Class PNC105

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
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_3)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_4)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_5)

            'Me.dtpContactDt.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            dtpMonitoringProcDt.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")

            Me.cboExpandDivCd.Enabled = False   'Ȯ�屸�� : 1.���Ȯ�� ����
            ''Me.popEmployeeExpNum.Enabled = False   '���Ȯ���ȣ ���� �Ұ�
            Me.popCompanyCd.Enabled = False   'Ȯ��ó�ڵ� ���� �Ұ�

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
            'If popCompanyCd.TextValue.ToString.Length < 1 _
            '    And popDeliveryPlace.TextValue.ToString.Length < 1 _
            '    And txtReceiptCd_2.TextValue.ToString.Length < 1 _
            '    And txtSubscriberNm_2.TextValue.ToString.Length < 1 _
            '    And txtPhoneNum_2.TextValue.ToString.Length < 1 _
            '    And txtAddr_2.TextValue.ToString.Length < 1 _
            '    And txtAdEmployeeNm_R.TextValue.ToString.Length < 1 Then
            '    blnRequestYesOrNo = False
            '    MessageBox.Show("�ϳ� �̻��� �˻� ������ �Է� �ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'End If
            If blnRequestYesOrNo Then

                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum  ", Me.popEmployeeExpNum_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd  ", Me.popCompanyCd_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryPlace   ", Me.popDeliveryPlace_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_2_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", IIf(IsNothing(Me.dtpReceiptDtFrom.TextValue), "", Me.dtpReceiptDtFrom.TextValue))
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", IIf(IsNothing(Me.dtpReceiptDtTo.TextValue), "", Me.dtpReceiptDtTo.TextValue)) 'Me.dtpReceiptDtTo.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringResultCd", Me.cboMonitoringResultCd_r.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_R", False, True, GmainsqlParameters)
                    Me.grd_1.SetDataSet(reciveDataSet)
                    Me.txtReceiptCd_2_R.TextValue = vbNullString  '�������ڹ�ȣ
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
            Dim sToDate As String

            sToDate = Format(Now, "yyyy-MM-dd")
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.grd_1.GetCurrentRowCellValue("ReceiptCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                popMonitoringEmpNum.TextValue = IIf(Me.popMonitoringEmpNum.TextValue.Length < 1, GmainBusinessFunction.GetValue("�α��� ID"), Me.popMonitoringEmpNum.TextValue)
                dtpMonitoringProcDt.TextValue = IIf(Me.dtpMonitoringProcDt.TextValue.Length < 1, sToDate, Me.dtpMonitoringProcDt.TextValue)
                ''txtMonitoringRemark.Text = reciveDataSet.Tables(0).Rows(0)("MonitoringRemark").ToString.Replace("_&!@&_", vbCrLf)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            'If popMonitoringEmpNum.TextValue = "" Then popMonitoringEmpNum.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
        End Sub


    
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' ''Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
        ' ''    GmainsqlParameters = Nothing

        ' ''    With GmainCommonFunction
        ' ''        .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.grd_1.GetCurrentRowCellValue("ReceiptCd"))
        ' ''        Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_2_R", False, True, GmainsqlParameters)
        ' ''        GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
        ' ''        ''txtMonitoringRemark.Text = reciveDataSet.Tables(0).Rows(0)("MonitoringRemark").ToString.Replace("_&!@&_", vbCrLf)
        ' ''        reciveDataSet = Nothing
        ' ''        .SetAllBusinessUiInitialValue(Me)
        ' ''        If AprocessMessage = True Then .RequestDataMessage(Me)
        ' ''    End With
        ' ''    If popMonitoringEmpNum.TextValue = "" Then popMonitoringEmpNum.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
        ' ''End Sub
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''' <summary>
        ''' �Լ��� : RequestData_3
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            'GmainsqlParameters = Nothing
            'With GmainCommonFunction

            '    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_3_R", False, True, GmainsqlParameters)
            '    Me.grd_3.SetDataSet(reciveDataSet)
            '    reciveDataSet = Nothing
            '    .SetAllBusinessUiInitialValue(Me)
            '    If AprocessMessage = True Then .RequestDataMessage(Me)
            'End With

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
                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode)    '�����ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue)        '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AContactDt", IIf(IsNothing(dtpContactDt.TextValue), "", dtpContactDt.TextValue)) 'dtpContactDt.TextValue)             '��������
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue)       '���ڸ�
                .SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", cboExpandDivCd.TextValue)         'Ȯ�� ����
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue)     '���ڻ����ڵ�
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue)         '��ȭ��ȣ1
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue)         '��ȭ��ȣ2
                .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue)         '�ڵ�����ȣ
                .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", popOldPostNum.TextValue)       '�������ȣ
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", txtOldAddr1.TextValue)           '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue)           '�����ּ�
                .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", popNewPostNum.TextValue)       '�ſ����ȣ
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", txtNewAddr1.TextValue)           '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue)           '�Ż��ּ�

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchCd", popDeliveryBranchCd.TextValue) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", popBizChargeCd.TextValue)           '�������
                .SetSqlParameter(GmainsqlParameters, "@AFixedStDt", IIf(IsNothing(dtpFixedStDt.TextValue), "", dtpFixedStDt.TextValue))               '��������
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(dtpFixedEdDt.TextValue), "", dtpFixedEdDt.TextValue)) 'dtpFixedEdDt.TextValue)                '������������
                .SetSqlParameter(GmainsqlParameters, "@ACollectionYYYYMM", IIf(IsNothing(dtpCollectionYYYYMM.TextValue), "", dtpCollectionYYYYMM.TextValue)) 'dtpCollectionYYYYMM.TextValue)  '���ݳ��
                .SetSqlParameter(GmainsqlParameters, "@AContactPaperNum", numContactPaperNum.TextValue)    '�����μ�
                .SetSqlParameter(GmainsqlParameters, "@AFixedPagerNum", numFixedPagerNum.TextValue)        '���Ժμ�
                .SetSqlParameter(GmainsqlParameters, "@AServiceTerm", numServiceTerm.TextValue)            '���񽺱Ⱓ
                .SetSqlParameter(GmainsqlParameters, "@ABranchMessage", txtBranchMessage.TextValue)        '�������޻���

                .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", popEmployeeExpNum.TextValue)     '���Ȯ���ȣ
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", popCompanyCd.TextValue)               'Ȯ��ó
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue)     '����ó�ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ASalWtListYn", chkSalWtListYn.Checked)             '�Ǹű��ۼ����
                .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", cboCollectionTypeCd.TextValue)  '���ݱ����ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ABillPeriodCd", cboBillPeriodCd.TextValue)            '�����ֱ��ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryRegionCd", cboDeliveryRegionCd.TextValue)  '���ó�����ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryDivCd", cboDeliveryDivCd.TextValue)        '��ޱ����ڵ�

                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNum", popTrAdEmployeeNum.TextValue)        '�ֱ����ڻ��
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", popTrAdEmployeeNum.NameText)          '�ֱ����ڸ�
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptCd", popTrAdEmployeeDeptCd.TextValue)  '�ֱ����ںμ�
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptNm", popTrAdEmployeeDeptCd.NameText)   '�ֱ����ںμ���
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNum", popAdEmployeeNum.TextValue)            '�����ڻ��
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", popAdEmployeeNum.NameText)              '�����ڸ�
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptCd", popAdEmployeeDeptCd.TextValue)      '�����ںμ�
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptNm", popAdEmployeeDeptCd.NameText)       '�����ںμ���
                .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue)                                 '���

                '' '' -------  ����� ó��/ ������
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringResultCd", Me.cboMonitoringResultCd.TextValue) '�����ó���ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.cboRefuseReasonCd.TextValue)         '����������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringRemark", Me.txtMonitoringRemark.Text)          '����ͺ��
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", Me.popMonitoringEmpNum.TextValue)          '�����
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringProcDt", IIf(IsNothing(dtpMonitoringProcDt.TextValue), "", dtpMonitoringProcDt.TextValue)) 'Me.dtpMonitoringProcDt.TextValue)          'ó������
                .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked)                      '�������뺸����
                .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", IIf(IsNothing(dtpSolicitorNotifyDt.TextValue), "", dtpSolicitorNotifyDt.TextValue)) 'dtpSolicitorNotifyDt.TextValue)  '�������뺸����
                .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", chkApprovalYN.Checked)                  '���ο���

                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                'GrecordProcessMode = "2"
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

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
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", "3")       '����
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue)        '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AContactDt", IIf(IsNothing(dtpContactDt.TextValue), "", dtpContactDt.TextValue)) 'dtpContactDt.TextValue)             '��������
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue)       '���ڸ�
                    .SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", cboExpandDivCd.TextValue)         'Ȯ�� ����
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue)     '���ڻ����ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue)         '��ȭ��ȣ1
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue)         '��ȭ��ȣ2
                    .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue)         '�ڵ�����ȣ
                    .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", popOldPostNum.TextValue)       '�������ȣ
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", txtOldAddr1.TextValue)           '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue)           '�����ּ�
                    .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", popNewPostNum.TextValue)       '�ſ����ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", txtNewAddr1.TextValue)           '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue)           '�Ż��ּ�

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchCd", popDeliveryBranchCd.TextValue) '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", popBizChargeCd.TextValue)           '�������
                    .SetSqlParameter(GmainsqlParameters, "@AFixedStDt", IIf(IsNothing(dtpFixedStDt.TextValue), "", dtpFixedStDt.TextValue)) 'dtpFixedStDt.TextValue)                '��������
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(dtpFixedEdDt.TextValue), "", dtpFixedEdDt.TextValue)) 'dtpFixedEdDt.TextValue)                '������������
                    .SetSqlParameter(GmainsqlParameters, "@ACollectionYYYYMM", IIf(IsNothing(dtpCollectionYYYYMM.TextValue), "", dtpCollectionYYYYMM.TextValue)) ' dtpCollectionYYYYMM.TextValue)  '���ݳ��
                    .SetSqlParameter(GmainsqlParameters, "@AContactPaperNum", numContactPaperNum.TextValue)    '�����μ�
                    .SetSqlParameter(GmainsqlParameters, "@AFixedPagerNum", numFixedPagerNum.TextValue)        '���Ժμ�
                    .SetSqlParameter(GmainsqlParameters, "@AServiceTerm", numServiceTerm.TextValue)            '���񽺱Ⱓ
                    .SetSqlParameter(GmainsqlParameters, "@ABranchMessage", txtBranchMessage.TextValue)        '�������޻���

                    .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", popEmployeeExpNum.TextValue)     '���Ȯ���ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", popCompanyCd.TextValue)               'Ȯ��ó
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue)     '����ó�ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ASalWtListYn", chkSalWtListYn.Checked)             '�Ǹű��ۼ����
                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", cboCollectionTypeCd.TextValue)  '���ݱ����ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ABillPeriodCd", cboBillPeriodCd.TextValue)            '�����ֱ��ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryRegionCd", cboDeliveryRegionCd.TextValue)  '���ó�����ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryDivCd", cboDeliveryDivCd.TextValue)        '��ޱ����ڵ�

                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNum", popTrAdEmployeeNum.TextValue)        '�ֱ����ڻ��
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", popTrAdEmployeeNum.NameText)          '�ֱ����ڸ�
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptCd", popTrAdEmployeeDeptCd.TextValue)  '�ֱ����ںμ�
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptNm", popTrAdEmployeeDeptCd.NameText)   '�ֱ����ںμ���
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNum", popAdEmployeeNum.TextValue)            '�����ڻ��
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", popAdEmployeeNum.NameText)              '�����ڸ�
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptCd", popAdEmployeeDeptCd.TextValue)      '�����ںμ�
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptNm", popAdEmployeeDeptCd.NameText)       '�����ںμ���
                    .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue)                                 '���

                    '' '' -------  ����� ó��/ ������
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringResultCd", Me.cboMonitoringResultCd.TextValue) '�����ó���ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.cboRefuseReasonCd.TextValue)         '����������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringRemark", Me.txtMonitoringRemark.Text)          '����ͺ��
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", Me.popMonitoringEmpNum.TextValue)          '�����
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringProcDt", IIf(IsNothing(dtpMonitoringProcDt.TextValue), "", dtpMonitoringProcDt.TextValue)) ' Me.dtpMonitoringProcDt.TextValue)          'ó������
                    .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked)                      '�������뺸����
                    .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", IIf(IsNothing(dtpSolicitorNotifyDt.TextValue), "", dtpSolicitorNotifyDt.TextValue)) ' dtpSolicitorNotifyDt.TextValue)  '�������뺸����
                    .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", chkApprovalYN.Checked)                  '���ο���

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_CUD", True, False, GmainsqlParameters)
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
