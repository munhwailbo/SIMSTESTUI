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

    Partial Class PNF311

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
                .SetSqlParameter(GmainsqlParameters, "@AdeliveryBranchCd", Me.popDeliveryBranchCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AcboMonitoringResult", Me.cboMonitoringResultCd_r.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNF311_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
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

            '' ''GmainsqlParameters = Nothing
            '' ''With GmainCommonFunction
            '' ''    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '' ''    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '' ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNF311_CUD", True, False, GmainsqlParameters)
            '' ''    .SetAllBusinessUiInitialValue(Me)
            '' ''    '' .SaveDataMessage(Me)
            '' ''End With
            '' ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '' ''    GmainCommonFunction.SaveDataMessage(Me)
            '' ''Else
            '' ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''End If

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

            '' ''Dim result As DialogResult
            '' ''result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            '' ''If result = DialogResult.OK Then   '' Result Start
            '' ''    GmainsqlParameters = Nothing
            '' ''    With GmainCommonFunction
            '' ''        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '' ''        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '' ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNF311_CUD", True, False, GmainsqlParameters)
            '' ''        .SetAllBusinessUiInitialValue(Me)
            '' ''        '' .SaveDataMessage(Me)
            '' ''    End With
            '' ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '' ''        MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''    Else
            '' ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''    End If
            '' ''End If   '' Result end

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

            '' ''Dim AsqlParameters() As SqlParameter = Nothing

            '' ''With GmainCommonFunction
            '' ''    .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpReceiptDtTo.TextValue)
            '' ''    .SetSqlParameter(AsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)
            '' ''    .SetSqlParameter(AsqlParameters, "@ABranchNm", Me.popDeliveryBranchCd_2.TextValue)

            '' ''    'Dim AAAA As String = ""
            '' ''    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            '' ''    Dim AformulaParameters() As SqlParameter = Nothing

            '' ''    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            '' ''    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            '' ''    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            '' ''    .SetExportCrystalDataParameter("PNF311_3_C_R.rpt", "PNF311_3_C_R", "", AsqlParameters, AformulaParameters)
            '' ''End With

            ' '' ''ElseIf optExpAmt2.Checked = True Then

            ' '' ''    With GmainCommonFunction
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpReceiptDtTo.TextValue)


            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' '' ''        .SetExportCrystalDataParameter("PNF311_3_C_R.rpt", "PNF311_3_C_R", "", AsqlParameters, AformulaParameters)
            ' '' ''    End With

        End Sub

    End Class
End Namespace
