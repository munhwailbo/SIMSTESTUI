Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Namespace ubiLease.UI.BusinessUi.SM

    Partial Class SMDB01

        '====================================================================================================
        Public Sub NewData()
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)

            'Me.txtManagementInternalUse.TextValue = ""
            'Me.txtOccurrenceCause.TextValue = ""
            'Me.txtDemandMatters.TextValue = ""

            Me.txtDemandMattersDummy.Text = ""
            Me.txtOccurrenceCauseDummy.Text = ""
            Me.txtManagementInternalUseDummy.Text = ""

            Me.txtReceiptDate.TextValue = "" '�ʱ�ȭ�� �� �ȵǴ� ��찡 �־� ������ �ʱ�ȭ
            Me.dtpReceiptDate_2.TextValue = Date.Today '�⺻ ��¥�� ���÷� ����
            Me.dtpManagementProgramDate.TextValue = Date.Today
            'Me.grd_1.Rows = 1
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProjectID", Me.popProjectID.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.popSystemID_R.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDateFrom", Me.dtpReceiptDateFrom.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDateTo", Me.dtpReceiptDateTo.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADivision", Me.cboDivision.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkStates", Me.cboWorkstats_2.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementDateFrom", Me.dtpManagementDateFrom.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementDateTo", Me.dtpManagementDateTo.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployee", Me.cboUnderwriter_R.TextValue)


            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB01_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            'GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            If Me.grd_1.Rows > 1 Then
                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.grd_1.GetCurrentRowCellValue("ReceiptDate"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.grd_1.GetCurrentRowCellValue("Orders"))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB01_2_R", False, True, GmainsqlParameters)
                'GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                Me.dtpReceiptDate_2.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ReceiptDate").ToString()
                Me.txtReceiptDate.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ReceiptDate").ToString() 'Ű ����
                Me.popSystemID_2.TextValue = reciveDataSet.Tables(0).Rows(0).Item("SystemDivision").ToString()
                Me.numOrders.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Orders").ToString()

                'Me.popProgramID.Tag = "code(���α׷� ��2);where( SystemID='case when " & reciveDataSet.Tables(0).Rows(0).Item("SystemDivision").ToString() & "' group by ProgramID);"
                Me.popProgramID.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ProgramID").ToString()
                Me.popProgramID.NameText = Me.grd_1.GetCurrentRowCellValue("ProgramName")

                Me.popProgramID_D.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DptmProgramID").ToString()
                Me.popProgramID_D.NameText = Me.grd_1.GetCurrentRowCellValue("DptmProgramName")
                Me.numbbsSeq.TextValue = reciveDataSet.Tables(0).Rows(0).Item("bbsSeq").ToString()
                Me.popEmployeeNumber.TextValue = reciveDataSet.Tables(0).Rows(0).Item("EmployeeNumber").ToString()
                Me.txtInFirmTelephoneNumber.TextValue = reciveDataSet.Tables(0).Rows(0).Item("InFirmTelephoneNumber").ToString()
                Me.cboReceiptDivision.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ReceiptDivision").ToString()
                Me.cboWorkDivision.TextValue = reciveDataSet.Tables(0).Rows(0).Item("WorkDivision").ToString()
                Me.cboUnderwriter.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Underwriter").ToString()
                Me.dtpManagementTerm.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ManagementTerm").ToString()
                Me.cboWorker_2.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Worker").ToString()
                Me.cboWorker.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Worker").ToString()

                Me.cboWorkStates.TextValue = reciveDataSet.Tables(0).Rows(0).Item("WorkStates").ToString()
                Me.dtpManagementProgramDate.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ManagementProgramDate").ToString()
                Me.dtpManagementDate.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ManagementDate").ToString()
                Me.txtSubject.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Subject").ToString()

                Me.txtDemandMatters.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DemandMatters").ToString()
                Me.txtOccurrenceCause.TextValue = reciveDataSet.Tables(0).Rows(0).Item("OccurrenceCause").ToString()
                Me.txtManagementInternalUse.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ManagementInternalUse").ToString()
                '���뿡�� �����Ǵ� ��Ʈ�� ��� ������ ���� ��Ʈ�� ���
                'Me.txtDemandMattersDummy.Text = reciveDataSet.Tables(0).Rows(0).Item("DemandMatters").ToString()
                'Me.txtOccurrenceCauseDummy.Text = reciveDataSet.Tables(0).Rows(0).Item("OccurrenceCause").ToString()
                'Me.txtManagementInternalUseDummy.Text = reciveDataSet.Tables(0).Rows(0).Item("ManagementInternalUse").ToString()

                Me.txtDemandMattersDummy.Text = Me.txtDemandMatters.TextValue
                Me.txtOccurrenceCauseDummy.Text = Me.txtOccurrenceCause.TextValue
                Me.txtManagementInternalUseDummy.Text = Me.txtManagementInternalUse.TextValue

                Me.txtWorkDetail.Text = reciveDataSet.Tables(0).Rows(0).Item("WorkDetail").ToString()
                Me.txtNote.Text = reciveDataSet.Tables(0).Rows(0).Item("Note").ToString()
                reciveDataSet = Nothing

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

                ''��Ÿ�� ��쿡�� �� �ؽ�Ʈ�ڽ� ������
                'If cboWorkDivision.SelectedIndex = 3 Then
                '    txtWorkDetail.Enabled = True
                'Else
                '    txtWorkDetail.Enabled = False
                '    txtWorkDetail.TextValue = ""
                'End If

            End If

            'GrecordProcessMode = 2
        End Sub

        '====================================================================================================
        Public Sub SaveData()

            ' �۾� ���°� �Ϸ� �̰� ó�� ���ڰ� �������
            If cboWorkStates.TextValue = "003" And IsDate(Me.dtpManagementDate.Text) = False Then

                MessageBox.Show("�۾����°� �Ϸ��� ��� ó�� ���ڸ� �ݵ�� �Է� ���ּ��� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If

            Dim tempReceiptDate As String = "" '�űԿ� ������Ʈ ������ ����
            If txtReceiptDate.TextValue.Length = 8 Then  '������Ʈ
                GrecordProcessMode = 2
                tempReceiptDate = Me.grd_1.GetCurrentRowCellValue("ReceiptDate")
            Else
                GrecordProcessMode = 1 '�ű�
                tempReceiptDate = Me.dtpReceiptDate_2.TextValue
            End If

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDate", tempReceiptDate)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.numOrders.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDivision", Me.cboReceiptDivision.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkDivision", Me.cboWorkDivision.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkDetail", Me.txtWorkDetail.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.popSystemID_2.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.popEmployeeNumber.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AInFirmTelephoneNumber", Me.txtInFirmTelephoneNumber.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementTerm", Me.dtpManagementTerm.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUnderwriter", Me.cboUnderwriter.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProgramID", Me.popProgramID.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADptmProgramID", Me.popProgramID_D.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementProgramDate", Me.dtpManagementProgramDate.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementDate", Me.dtpManagementDate.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorker", Me.cboWorker.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkStates", Me.cboWorkStates.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbbsSeq", Me.numbbsSeq.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubject", Me.txtSubject.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADemandMatters", Me.txtDemandMattersDummy.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOccurrenceCause", Me.txtOccurrenceCauseDummy.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementInternalUse", Me.txtManagementInternalUseDummy.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", Me.txtNote.Text)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADemandMatters", Me.txtDemandMatters.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOccurrenceCause", Me.txtOccurrenceCause.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementInternalUse", Me.txtManagementInternalUse.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB01_2_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            If Me.grd_1.Rows > 1 Then
                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.grd_1.GetCurrentRowCellValue("ReceiptDate"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.grd_1.GetCurrentRowCellValue("Orders"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDivision", Me.cboReceiptDivision.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkDivision", Me.cboWorkDivision.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkDetail", Me.txtWorkDetail.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.popSystemID_2.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.popEmployeeNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AInFirmTelephoneNumber", Me.txtInFirmTelephoneNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementTerm", Me.dtpManagementTerm.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUnderwriter", Me.cboUnderwriter.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProgramID", Me.popProgramID.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADptmProgramID", Me.popProgramID_D.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementProgramDate", Me.dtpManagementProgramDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementDate", Me.dtpManagementDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorker", Me.cboWorker_2.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkStates", Me.cboWorkStates.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbbsSeq", Me.numbbsSeq.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubject", Me.txtSubject.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADemandMatters", Me.txtDemandMattersDummy.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOccurrenceCause", Me.txtOccurrenceCauseDummy.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementInternalUse", Me.txtManagementInternalUseDummy.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", Me.txtNote.Text)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADemandMatters", Me.txtDemandMatters.TextValue)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOccurrenceCause", Me.txtOccurrenceCause.TextValue)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementInternalUse", Me.txtManagementInternalUse.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB01_2_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�������Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GmainCommonFunction.GRequestDataNumber = 1
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            End If
        End Sub

        '====================================================================================================
        Public Sub SaveData_2()

            If Me.grd_1.Rows > 1 Then
                GmainsqlParameters = Nothing ' ���� ������ ���� �� �� ���

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 1)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.grd_1.GetCurrentRowCellValue("ReceiptDate"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.numOrders.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDivision", Me.cboReceiptDivision.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkDivision", Me.cboWorkDivision.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkDetail", Me.txtWorkDetail.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.popSystemID_2.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.popEmployeeNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AInFirmTelephoneNumber", Me.txtInFirmTelephoneNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementTerm", Me.dtpManagementTerm.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUnderwriter", Me.cboUnderwriter.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProgramID", Me.popProgramID.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADptmProgramID", Me.popProgramID_D.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementProgramDate", Me.dtpManagementProgramDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementDate", Me.dtpManagementDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorker", Me.cboWorker_2.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkStates", Me.cboWorkStates.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbbsSeq", Me.numbbsSeq.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubject", Me.txtSubject.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADemandMatters", Me.txtDemandMattersDummy.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOccurrenceCause", Me.txtOccurrenceCauseDummy.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementInternalUse", Me.txtManagementInternalUseDummy.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", Me.txtNote.Text)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADemandMatters", Me.txtDemandMatters.TextValue)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOccurrenceCause", Me.txtOccurrenceCause.TextValue)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementInternalUse", Me.txtManagementInternalUse.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB01_2_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Me.RequestData()
            End If

        End Sub

    End Class

End Namespace
