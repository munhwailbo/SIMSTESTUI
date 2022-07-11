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

    Partial Class PNC202

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
            lblRecordState.Text = "�ű�"
            GmainCommonFunction.ControlNewData(Me, Me.picIo_3)
            '''''''''''' GmainCommonFunction.ControlNewData(Me, Me.picIo_4)
            Me.dtpDeliveryReqDt.TextValue = System.DateTime.Now
            Me.dtpReceiptDt.TextValue = System.DateTime.Now
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
                .SetSqlParameter(GmainsqlParameters, "@AdeliveryBranchCd", Me.popDeliveryBranchCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)


                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

            End With
        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            '''' picIo_4 ���� ���� (���� ���� �� ǥ��)
            With GmainCommonFunction
                If grd_1.Rows > 1 Then
                    .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))

                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_2_R", False, True, GmainsqlParameters)
                    'GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                    Me.txtReaderCd.Text = reciveDataSet.Tables(0).Rows(0).Item("ReaderCd").ToString
                    Me.txtReaderNm.Text = reciveDataSet.Tables(0).Rows(0).Item("ReaderNm").ToString
                    Me.txtPhoneNum1.Text = reciveDataSet.Tables(0).Rows(0).Item("PhoneNum1").ToString
                    Me.txtPhoneNum2.Text = reciveDataSet.Tables(0).Rows(0).Item("PhoneNum2").ToString
                    Me.txtMobileNum.Text = reciveDataSet.Tables(0).Rows(0).Item("MobileNum").ToString
                    Me.popOldPostNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("OldPostNum").ToString
                    Me.txtOldAddr1.Text = reciveDataSet.Tables(0).Rows(0).Item("OldAddr1").ToString
                    Me.txtOldAddr2.Text = reciveDataSet.Tables(0).Rows(0).Item("OldAddr2").ToString
                    Me.popNewPostNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("NewPostNum").ToString
                    Me.txtNewAddr1.Text = reciveDataSet.Tables(0).Rows(0).Item("NewAddr1").ToString
                    Me.txtNewAddr2.Text = reciveDataSet.Tables(0).Rows(0).Item("NewAddr2").ToString
                    Me.popDeliveryBranchCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DeliveryBranchCd").ToString
                    'Me.txtBranchPhoneNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchPhoneNum").ToString

                    Me.txtBranchPhoneNum.TextValue = ""
                    Me.popBizChargeCd.CodeText = reciveDataSet.Tables(0).Rows(0).Item("BizChargeCd").ToString
                    Me.txtChargePhoneNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ChargePhoneNum").ToString

                    reciveDataSet = Nothing

                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)

                End If


                

            End With

            '' ' grd_3 ��䰡�� ��� �׸��� ǥ�� 
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_3_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            End With

        End Sub


        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainCommonFunction.ControlNewData(Me, Me.picIo_3)
            If grd_2.Rows <= grd_2.FixedRows Then Exit Sub

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                '' ''.SetSqlParameter(GmainsqlParameters, "@AReceiptDt", IIf(Me.grd_2.GetCurrentRowCellValue("ReceiptDt") = "|", "", Me.grd_2.GetCurrentRowCellValue("ReceiptDt")))
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", IIf(Me.grd_2.GetCurrentRowCellValue("ReaderCd") = "|", "", Me.grd_2.GetCurrentRowCellValue("ReaderCd")))
                .SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(IsNumeric(Me.grd_2.GetCurrentRowCellValue("Orders")), Me.grd_2.GetCurrentRowCellValue("Orders"), 0))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_4_R", False, True, GmainsqlParameters)
                If reciveDataSet.Tables.Count > 0 Then
                    lblRecordState.Text = "��ȸ"
                    GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                End If

                '' '' ''txtNewAddr1.Text = reciveDataSet.Tables(0).Rows(0).Item("NewAddr1").ToString
                '' '' ''txtOldAddr1.Text = reciveDataSet.Tables(0).Rows(0).Item("OldAddr1").ToString
                '' '' ''Me.dtpDeliveryReqDt.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DeliveryReqDt").ToString
                '' '' ''Me.dtpReceiptDt.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ReceiptDt").ToString
                '' '' ''Me.txtIngStateCd.Text = reciveDataSet.Tables(0).Rows(0).Item("IngStateCd").ToString
                '' '' ''Me.popBranchCd.Text = reciveDataSet.Tables(0).Rows(0).Item("BranchCd").ToString
                '' '' ''Me.txtSatReceipName.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchNm").ToString
                '' '' ''Me.popBizEmpNumber.Text = reciveDataSet.Tables(0).Rows(0).Item("BizEmpNumber").ToString
                '' '' ''Me.txtName.Text = reciveDataSet.Tables(0).Rows(0).Item("Name").ToString

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

            End With

        End Sub

        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) '

                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.txtReaderCd.TextValue)         '�����ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(Me.txtOrders.TextValue.ToString().Length < 1, "0", Me.txtOrders.TextValue)) '����
                .SetSqlParameter(GmainsqlParameters, "@ASatReaderNm", Me.txtSatReaderNm.TextValue)   '��䵶�ڸ�
                .SetSqlParameter(GmainsqlParameters, "@ASatPhoneNum1", Me.txtSatPhoneNum1.TextValue) '������ȭ��ȣ
                .SetSqlParameter(GmainsqlParameters, "@ASatMobileNum", Me.txtSatMobileNum.TextValue) '�����ڵ�����ȣ

                .SetSqlParameter(GmainsqlParameters, "@ASatOldPostNum", Me.popSatOldPostNum.TextValue) '�������ȣ
                .SetSqlParameter(GmainsqlParameters, "@ASatOldAddr1", Me.txtSatOldAddr1.TextValue)   '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@ASatOldAddr2", Me.txtSatOldAddr2.TextValue)   '�����ּ�
                .SetSqlParameter(GmainsqlParameters, "@ASatNewPostNum", Me.popSatNewPostNum.TextValue) '�ſ����ȣ
                .SetSqlParameter(GmainsqlParameters, "@ASatNewAddr1", Me.txtSatNewAddr1.TextValue)   '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@ASatNewAddr2", Me.txtSatNewAddr2.TextValue)   '�Ż��ּ�

                .SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue)  '��������
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryReqDt", Me.dtpDeliveryReqDt.TextValue) '���Կ�û��
                .SetSqlParameter(GmainsqlParameters, "@ARealEdDt", IIf(Me.dtpRealEdDt.TextValue.ToString.Length < 1, "", Me.dtpRealEdDt.TextValue)) '��������
                .SetSqlParameter(GmainsqlParameters, "@ASatBranchCd", Me.popSatBranchCd.TextValue)   '�����ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AIngStateCd", Me.txtIngStateCd.TextValue)     '��������ڵ�  

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryYn", Me.chkDeliveryYn.Checked)     '��޿���  
                .SetSqlParameter(GmainsqlParameters, "@AResultYn", Me.chkResultYn.Checked)     '�뺸����  

                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_CUD", True, False, GmainsqlParameters)

            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GrecordProcessMode = "2"
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        Public Sub DeleteData()

            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")             '���������ڵ�

                    .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.txtReaderCd.TextValue)         '�����ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(Me.txtOrders.TextValue.ToString().Length < 1, "0", Me.txtOrders.TextValue)) '����
                    .SetSqlParameter(GmainsqlParameters, "@ASatReaderNm", Me.txtSatReaderNm.TextValue)   '��䵶�ڸ�
                    .SetSqlParameter(GmainsqlParameters, "@ASatPhoneNum1", Me.txtSatPhoneNum1.TextValue) '������ȭ��ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ASatMobileNum", Me.txtSatMobileNum.TextValue) '�����ڵ�����ȣ

                    .SetSqlParameter(GmainsqlParameters, "@ASatOldPostNum", Me.popSatOldPostNum.TextValue) '�������ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ASatOldAddr1", Me.txtSatOldAddr1.TextValue)   '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@ASatOldAddr2", Me.txtSatOldAddr2.TextValue)   '�����ּ�
                    .SetSqlParameter(GmainsqlParameters, "@ASatNewPostNum", Me.popSatNewPostNum.TextValue) '�ſ����ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ASatNewAddr1", Me.txtSatNewAddr1.TextValue)   '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@ASatNewAddr2", Me.txtSatNewAddr2.TextValue)   '�Ż��ּ�

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue)  '��������
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryReqDt", Me.dtpDeliveryReqDt.TextValue) '���Կ�û��
                    .SetSqlParameter(GmainsqlParameters, "@ARealEdDt", IIf(Me.dtpRealEdDt.TextValue.ToString.Length < 1, "", Me.dtpRealEdDt.TextValue)) '��������
                    .SetSqlParameter(GmainsqlParameters, "@ASatBranchCd", Me.popSatBranchCd.TextValue)   '�����ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AIngStateCd", Me.txtIngStateCd.TextValue)     '��������ڵ�  

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryYn", Me.chkDeliveryYn.Checked)     '��޿���  
                    .SetSqlParameter(GmainsqlParameters, "@AResultYn", Me.chkResultYn.Checked)     '�뺸����  

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_CUD", True, False, GmainsqlParameters)

                End With

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End Sub


    End Class

End Namespace
