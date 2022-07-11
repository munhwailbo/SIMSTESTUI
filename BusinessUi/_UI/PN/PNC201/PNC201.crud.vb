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

    Partial Class PNC201

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
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_3)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_4)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_5)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_6)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_7)
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

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AsubscribeCd", popSubscribeCd_R.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                ''txtMonitoringRemark.Text = reciveDataSet.Tables(0).Rows(0)("MonitoringRemark").ToString.Replace("_&!@&_", vbCrLf)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
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

                .SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", txtSubscribeCd.TextValue) '���ڹ�ȣ
                .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AContactDt", dtpContactDt.TextValue) '��������
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue) '���ڸ�
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue) '���ڻ����ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ASubscribeStateCd", cboSubscribeStateCd.TextValue) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ARealEdDt", IIf(dtpRealEdDt.TextValue.ToString.Length < 1, "", dtpRealEdDt.TextValue)) '��������

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue) '����ó�ڵ�
                '''''''.SetSqlParameter(GmainsqlParameters, "@AApprovalYN", Me.chkApprovalYN.Checked) '���ο���

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
                .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", popBizChargeCd.TextValue) '���������

                ''.SetSqlParameter(GmainsqlParameters, "@AAdBranchCd", popAdBranchCd.TextValue) '���������ڵ�
                ''.SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", txtTrAdEmployeeNm.TextValue) '������ ��
                ''.SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", txtAdEmployeeNm.TextValue) '�� ������ ��

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

                ' 2015.01.29 ��ܰ��� �߰�
                .SetSqlParameter(GmainsqlParameters, "@AMngStopDt", dtpMngStopDt.TextValue) '��ܰ�������
                .SetSqlParameter(GmainsqlParameters, "@AMngRemark", txtMngRemark.TextValue) '��ܺ��
                ' 2015.01.29 ��ܰ��� �߰�

                .SetSqlParameter(GmainsqlParameters, "@ASolicitorCorpCd", popSolicitorCorpCd.TextValue) '�Ҽӻ��ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ACouponReaderYN", chkCouponReaderYN.Checked) '�����ǵ��ڿ���
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked) '�������뺸����
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", dtpSolicitorNotifyDt.TextValue) '�������뺸����

                '' '' -------  ����� ó��/ ������
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNum", popTrAdEmployeeNum.TextValue) '�ֱ����ڸ�
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptCd", popTrAdEmployeeDeptCd.TextValue)         '�ֱ����ںμ�
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNum", popAdEmployeeNum.TextValue)          '�����ڸ�
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptCd", popAdEmployeeDeptCd.TextValue)     '�����ںμ�
                .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue) '���
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringResultCd", cboMonitoringResultCd.TextValue) '�����ó������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", cboRefuseReasonCd.TextValue)         '����������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", popMonitoringEmpNum.TextValue)     '�����
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringRemark", txtMonitoringRemark.Text)          '����ͺ��
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringProcDt", dtpMonitoringProcDt.TextValue)     'ó������
                .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked)                      '�������뺸����
                .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", dtpSolicitorNotifyDt.TextValue)  '�������뺸����
                .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", chkApprovalYN.Checked)                  '���ο���

                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GrecordProcessMode = "2"
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub
        ''' <summary>
        ''' �Լ��� : DeleteData 
        ''' ��  �� : ����
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-08-17
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            'Dim result As DialogResult
            'result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            'If result = DialogResult.OK Then   '' Result Start
            '    GmainsqlParameters = Nothing
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", 3) '���������ڵ�
            '        .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '���������ڵ�
            '        .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '���ڸ�
            '        .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '��ȭ��ȣ1
            '        .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '��ȭ��ȣ2
            '        .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '�ڵ�����ȣ
            '        .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", popNewPostNum.TextValue) '�ſ����ȣ
            '        .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", txtNewAddr1.TextValue) '���ּ�
            '        .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '�Ż��ּ�
            '        .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", popOldPostNum.TextValue) '�������ȣ
            '        .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", txtOldAddr1.TextValue) '���ּ�
            '        .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '�����ּ�
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '        '' .SaveDataMessage(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            'End If   '' Result end

        End Sub

    End Class

End Namespace
