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

    Partial Class PNE304

        ''' <summary>
        ''' �Լ��� : NewData 
        ''' ��  �� : �ű� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()
            'If grd_2.Focused = True Then
            '    Me.NewData_2()
            '    Exit Sub
            'End If
            'Me.grd_1.AddRow()
        End Sub
        ''' <summary>
        ''' �Լ��� : RequestData
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                      '������(�μ�)
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '���� 
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 'Ȯ��ó 
                .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                  '�������  
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '���ڻ��� 
                .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               'û�� ���

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDtFr", IIf(IsNothing(Me.dtpFixedEdDtFr.TextValue), "", Me.dtpFixedEdDtFr.TextValue))  '������������
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDtTo", IIf(IsNothing(Me.dtpFixedEdDtTo.TextValue), "", Me.dtpFixedEdDtTo.TextValue))  '������������
                .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE304_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            Call SetSubTotal()

        End Sub

        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPNum_new"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPNum_re"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPNum_tot"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPagerNum"), "�հ�")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("TrAdEmployeeDeptNm"), "��   ��")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        ''' <summary>
        ''' �Լ��� : SaveData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            Dim RowCount As Integer = 0

            ''GmainsqlParameters = Nothing
            ''With GmainCommonFunction
            ''    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            ''    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_CUD", True, False, GmainsqlParameters)
            ''    .SetAllBusinessUiInitialValue(Me)
            ''    '' .SaveDataMessage(Me)
            ''End With
            ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ''    GmainCommonFunction.SaveDataMessage(Me)
            ''Else
            ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''End If

        End Sub

        ''' <summary>
        ''' �Լ��� : DeleteData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()
            Dim RowCount As Integer = 0

            ''Dim result As DialogResult
            ''result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            ''If result = DialogResult.OK Then   '' Result Start
            ''    GmainsqlParameters = Nothing
            ''    With GmainCommonFunction
            ''        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            ''        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_CUD", True, False, GmainsqlParameters)
            ''        .SetAllBusinessUiInitialValue(Me)
            ''        '' .SaveDataMessage(Me)
            ''    End With
            ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ''        MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''    Else
            ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''    End If
            ''End If   '' Result end

        End Sub

        ''' <summary>
        ''' �Լ��� : ExportData 
        ''' ��  �� : ���
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ExportData()

            ' '' ''Dim AsqlParameters() As SqlParameter = Nothing
            ' '' ''If optReceipt.Checked = True Then
            ' '' ''    With GmainCommonFunction

            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                    '�ֱ����ڸ�
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '���� 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 'Ȯ��ó 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                  '�������  
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '���ڻ��� 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               'û�� ���

            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' '' ''        .SetExportCrystalDataParameter("PNE301_1_C_R.rpt", "PNE301_1_C_R", "", AsqlParameters, AformulaParameters)

            ' '' ''    End With

            ' '' ''ElseIf optMonitor.Checked = True Then
            ' '' ''    With GmainCommonFunction

            ' '' ''        '.SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtDeptNm.Text)                      '������(�μ�)
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '���� 
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 'Ȯ��ó 
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.txtBizChargeCd.Text)                  '�������  
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '���ڻ��� 
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               'û�� ���

            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '������(�μ�)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '���� 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                'Ȯ��ó 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '�������  
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '���ڻ��� 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              'û�� ���

            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' '' ''        .SetExportCrystalDataParameter("PNE301_2_C_R.rpt", "PNE301_2_C_R", "", AsqlParameters, AformulaParameters)

            ' '' ''    End With
            ' '' ''ElseIf optstop.Checked = True Then
            ' '' ''    With GmainCommonFunction
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '����
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 'Ȯ��ó
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '�������
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��

            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' '' ''        .SetExportCrystalDataParameter("PNE304_3_C_R.rpt", "PNE304_3_C_R", "", AsqlParameters, AformulaParameters)
            ' '' ''    End With
            ' '' ''End If

        End Sub

    End Class

End Namespace
