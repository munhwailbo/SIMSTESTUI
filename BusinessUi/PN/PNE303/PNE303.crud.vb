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

    Partial Class PNE303

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

            If optReceipt.Checked = True Then
                Me.Grd_1.Visible = True
                Me.Grd_2.Visible = False
                Me.Grd_3.Visible = False
                Me.grd_4.Visible = False
                Me.grd_5.Visible = False

                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                      '������(�μ�)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '���� 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 'Ȯ��ó 
                    .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", "")                                   '������ȣ 2017.12.28 �ǰ�� �߰�-��ܺμ��������� ȭ���̶� �����ֱ� ���� ������� �Ķ���� �ѱ�
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                  '�������  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '���ڻ��� 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               'û�� ���

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_R", False, True, GmainsqlParameters)
                    Me.Grd_1.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal()
            ElseIf optMonitor.Checked = True Then
                Me.Grd_1.Visible = False
                Me.Grd_2.Visible = True
                Me.Grd_3.Visible = False
                Me.grd_4.Visible = False
                Me.grd_5.Visible = False
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '������(�μ�)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '���� 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                'Ȯ��ó 
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '�������  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '���ڻ��� 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              'û�� ���

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_2_R", False, True, GmainsqlParameters)
                    Me.Grd_2.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal_1()
            ElseIf optstop.Checked = True Then
                Me.Grd_1.Visible = False
                Me.Grd_2.Visible = False
                Me.Grd_2.Visible = True
                Me.grd_4.Visible = False
                Me.grd_5.Visible = False
                GmainsqlParameters = Nothing

                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '����
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 'Ȯ��ó
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '�������
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_3_R", False, True, GmainsqlParameters)
                    Me.Grd_3.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal_2()
            ElseIf Me.optHeadOfficeDelivery.Checked = True Then
                Me.Grd_1.Visible = False
                Me.Grd_2.Visible = False
                Me.Grd_3.Visible = False
                Me.grd_4.Visible = True
                Me.grd_5.Visible = False
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '������(�μ�)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '���� 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                'Ȯ��ó 
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '�������  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '���ڻ��� 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              'û�� ���

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_4_R", False, True, GmainsqlParameters)
                    Me.grd_4.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal_3()
            ElseIf Me.optBranchDelivery.Checked = True Then
                Me.Grd_1.Visible = False
                Me.Grd_2.Visible = False
                Me.Grd_3.Visible = False
                Me.grd_4.Visible = False
                Me.grd_5.Visible = True
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '������(�μ�)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '���� 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                'Ȯ��ó 
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '�������  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '���ڻ��� 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              'û�� ���

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_5_R", False, True, GmainsqlParameters)
                    Me.grd_5.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal_4()
            End If
        End Sub

        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum1"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SubscribePagerNum"), "�հ�")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "��   ��")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        Private Sub SetSubTotal_1()
            With Me.Grd_2
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "�հ�")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "��   ��")
                    Me.Grd_2.FrozenRows = 1
                End If
            End With
        End Sub
        Private Sub SetSubTotal_2()
            With Me.Grd_3
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum1"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "�հ�")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "��   ��")
                    Me.Grd_3.FrozenRows = 1
                End If
            End With
        End Sub

        Private Sub SetSubTotal_3()
            With Me.grd_4
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum1"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "�հ�")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "��   ��")
                    Me.grd_4.FrozenRows = 1
                End If
            End With
        End Sub

        Private Sub SetSubTotal_4()
            With Me.grd_5
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum1"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "�հ�")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "��   ��")
                    Me.grd_5.FrozenRows = 1
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

            Dim AsqlParameters() As SqlParameter = Nothing
            If optReceipt.Checked = True Then
                With GmainCommonFunction

                    .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
                    .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                    '�ֱ����ڸ�
                    .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '���� 
                    .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 'Ȯ��ó 
                    .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                  '�������  
                    .SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '���ڻ��� 
                    .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               'û�� ���

                    .SetSqlParameter(AsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
                    .SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
                    .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                    .SetSqlParameter(AsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
                    .SetSqlParameter(AsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
                    .SetSqlParameter(AsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    'Dim AAAA As String = ""
                    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNE301_1_C_R.rpt", "PNE301_1_C_R", "", AsqlParameters, AformulaParameters)

                End With

            ElseIf optMonitor.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
                    .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '������(�μ�)
                    .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '���� 
                    .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                'Ȯ��ó 
                    .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '�������  
                    .SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '���ڻ��� 
                    .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              'û�� ���

                    .SetSqlParameter(AsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
                    .SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
                    .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                    .SetSqlParameter(AsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
                    .SetSqlParameter(AsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
                    .SetSqlParameter(AsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

                    Dim AformulaParameters() As SqlParameter = Nothing
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNE301_2_C_R.rpt", "PNE301_2_C_R", "", AsqlParameters, AformulaParameters)

                End With
            ElseIf optstop.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)
                    .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����
                    .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '����
                    .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 'Ȯ��ó
                    .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '�������
                    .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��

                    Dim AformulaParameters() As SqlParameter = Nothing
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNE303_3_C_R.rpt", "PNE303_3_C_R", "", AsqlParameters, AformulaParameters)
                End With
            End If

        End Sub

        '====================================================================================================
        Public Function GetDataSet(Optional ByVal AprocessMessage As Boolean = True) As DataSet

            If Me.optHeadOfficeDelivery.Checked = True Then
                Me.grd_1.Visible = False
                Me.grd_2.Visible = False
                Me.grd_3.Visible = False
                Me.grd_4.Visible = True
                Me.grd_5.Visible = False
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '������(�μ�)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '���� 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                'Ȯ��ó 
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '�������  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '���ڻ��� 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              'û�� ���

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '����ó 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_9_R", False, True, GmainsqlParameters)
                    GetDataSet = reciveDataSet
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With

            ElseIf Me.optBranchDelivery.Checked = True Then
                Me.grd_1.Visible = False
                Me.grd_2.Visible = False
                Me.grd_3.Visible = False
                Me.grd_4.Visible = False
                Me.grd_5.Visible = True
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    '.SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    '.SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    '.SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '���� ����      
                    '.SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '������(�μ�)
                    '.SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.txtDeliveryBranchNm.TextValue)       '���� 
                    '.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.txtCompanyCd.TextValue)                'Ȯ��ó 
                    '.SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.txtBizChargeCd.Text)                 '�������  
                    '.SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '���ڻ��� 
                    '.SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              'û�� ���

                    '.SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.txtDeliveryChnlNm.TextValue)       '����ó 
                    '.SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '���� ������  
                    '.SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '���� ��
                    '.SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '����� ���
                    '.SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '������������
                    '.SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

                    'Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("IRIS_SR.dbo.SRF001_10_R", False, True, GmainsqlParameters)
                    'GetDataSet = reciveDataSet
                    'reciveDataSet = Nothing
                    '.SetAllBusinessUiInitialValue(Me)
                    'If AprocessMessage = True Then .RequestDataMessage(Me)
                End With

            End If
        End Function

    End Class

End Namespace
