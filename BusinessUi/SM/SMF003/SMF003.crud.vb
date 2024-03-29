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

    Partial Class SMF003

        '====================================================================================================
        Public Sub NewData()
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.cboSystemDivision.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDateFrom", Me.dtpReceiptDateFrom.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDateTo", Me.dtpReceiptDateTo.TextValue)
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMF003_R", False, True, GmainsqlParameters)
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

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMF003_2_R", False, True, GmainsqlParameters)
                'GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                Me.txtReceiptDate.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ReceiptDate").ToString()
                Me.numOrders.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Orders").ToString()
                Me.popProgramID.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ProgramID").ToString()
                Me.numbbsSeq.TextValue = reciveDataSet.Tables(0).Rows(0).Item("bbsSeq").ToString()
                Me.popEmployeeNumber.TextValue = reciveDataSet.Tables(0).Rows(0).Item("EmployeeNumber").ToString()
                Me.txtInFirmTelephoneNumber.TextValue = reciveDataSet.Tables(0).Rows(0).Item("InFirmTelephoneNumber").ToString()
                Me.cboReceiptDivision.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ReceiptDivision").ToString()
                Me.cboWorkDivision.TextValue = reciveDataSet.Tables(0).Rows(0).Item("WorkDivision").ToString()
                Me.cboUnderwriter.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Underwriter").ToString()
                Me.dtpManagementTerm.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ManagementTerm").ToString()
                Me.cboWorker.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Worker").ToString()
                Me.cboWorkStates.TextValue = reciveDataSet.Tables(0).Rows(0).Item("WorkStates").ToString()
                Me.dtpManagementProgramDate.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ManagementProgramDate").ToString()
                Me.dtpManagementDate.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ManagementDate").ToString()
                Me.txtSubject.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Subject").ToString()
                Me.txtNote.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Note").ToString()

                Me.txtDemandMattersDummy.Text = reciveDataSet.Tables(0).Rows(0).Item("DemandMatters").ToString()
                Me.txtOccurrenceCauseDummy.Text = reciveDataSet.Tables(0).Rows(0).Item("OccurrenceCause").ToString()
                Me.txtManagementInternalUseDummy.Text = reciveDataSet.Tables(0).Rows(0).Item("ManagementInternalUse").ToString()
                'Me.txtDemandMatters.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DemandMatters").ToString()
                'Me.txtOccurrenceCause.TextValue = reciveDataSet.Tables(0).Rows(0).Item("OccurrenceCause").ToString()
                'Me.txtManagementInternalUse.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ManagementInternalUse").ToString()

                reciveDataSet = Nothing

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            End If
        End Sub

        '====================================================================================================
        Public Sub SaveData()

            If Me.grd_1.Rows > 1 Then
                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 2)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.grd_1.GetCurrentRowCellValue("ReceiptDate"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.grd_1.GetCurrentRowCellValue("Orders"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementProgramDate", Me.dtpManagementProgramDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementDate", Me.dtpManagementDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkStates", Me.cboWorkStates.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubject", Me.txtSubject.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", Me.txtNote.TextValue)

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADemandMatters", Me.txtDemandMattersDummy.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOccurrenceCause", Me.txtOccurrenceCauseDummy.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementInternalUse", Me.txtManagementInternalUseDummy.Text)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADemandMatters", Me.txtDemandMatters.TextValue)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOccurrenceCause", Me.txtOccurrenceCause.TextValue)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementInternalUse", Me.txtManagementInternalUse.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMF003_2_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            'GmainsqlParameters = Nothing

            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.dtpReceiptDateTo.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.numOrders.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementProgramDate", Me.dtpManagementProgramDate.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementDate", Me.dtpManagementDate.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkStates", Me.cboWorkStates.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubject", Me.txtSubject.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADemandMatters", Me.txtDemandMatters.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOccurrenceCause", Me.txtOccurrenceCause.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManagementInternalUse", Me.txtManagementInternalUse.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

            'GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMF003_2_CUD", True, False, GmainsqlParameters)

            'If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '    MessageBox.Show("데이타가삭제되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    GmainCommonFunction.GRequestDataNumber = 1
            'Else
            '    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'End If

            'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub

    End Class

End Namespace
