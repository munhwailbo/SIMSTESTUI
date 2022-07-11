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

    Partial Class PNI311

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
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1)
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

            ' ''GmainsqlParameters = Nothing
            ' ''With GmainCommonFunction
            ' ''    .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", Me.dtpYYYYMM.TextValue)
            ' ''    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI311_R", False, True, GmainsqlParameters)
            ' ''    GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            ' ''    reciveDataSet = Nothing
            ' ''    .SetAllBusinessUiInitialValue(Me)
            ' ''    If AprocessMessage = True Then .RequestDataMessage(Me)
            ' ''End With

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

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ArecordProcessMode", "1")  '' 1:ó��, 3:����
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", dtpYYYYMM.TextValue)   '' ������
                .SetSqlParameter(GmainsqlParameters, "@ATransferDt1", dtpTransferDt1.TextValue)   '' ��ü����(From)
                .SetSqlParameter(GmainsqlParameters, "@ATransferDt2", dtpTransferDt2.TextValue)   '' ��ü����(To)

                .SetSqlParameter(GmainsqlParameters, "@AchkExp11", Me.chkExp11.Checked)   '' ������ݱ����� ��ü ���� 
                .SetSqlParameter(GmainsqlParameters, "@AchkExp21", Me.chkExp21.Checked)   '' ����Ȯ��� ��ü ����     
                .SetSqlParameter(GmainsqlParameters, "@AchkExp31", Me.chkExp31.Checked)   '' ��ǥ������ ��ü ����     
                .SetSqlParameter(GmainsqlParameters, "@AchkExp32", Me.chkExp32.Checked)   '' ���������� ��ü ����     
                .SetSqlParameter(GmainsqlParameters, "@AchkExp33", Me.chkExp33.Checked)   '' ������ ��ü ����         
                .SetSqlParameter(GmainsqlParameters, "@AchkExp34", Me.chkExp34.Checked)   '' �̻絶�� ��ü ����       
                .SetSqlParameter(GmainsqlParameters, "@AchkExp41", Me.chkExp41.Checked)   '' ���Ȯ���� ��ü ����     
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI311_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

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

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ArecordProcessMode", "3")  '' 1:ó��, 3:����
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                    .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", dtpYYYYMM.TextValue)   '' ������
                    .SetSqlParameter(GmainsqlParameters, "@ATransferDt1", dtpTransferDt1.TextValue)   '' ��ü����(From)
                    .SetSqlParameter(GmainsqlParameters, "@ATransferDt2", dtpTransferDt2.TextValue)   '' ��ü����(To)

                    .SetSqlParameter(GmainsqlParameters, "@AchkExp11", Me.chkExp11.Checked)   '' ������ݱ����� ��ü ���� 
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp21", Me.chkExp21.Checked)   '' ����Ȯ��� ��ü ����     
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp31", Me.chkExp31.Checked)   '' ��ǥ������ ��ü ����     
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp32", Me.chkExp32.Checked)   '' ���������� ��ü ����     
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp33", Me.chkExp33.Checked)   '' ������ ��ü ����         
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp34", Me.chkExp34.Checked)   '' �̻絶�� ��ü ����       
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp41", Me.chkExp41.Checked)   '' ���Ȯ���� ��ü ����     
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI311_CUD", True, False, GmainsqlParameters)
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

        '''' <summary>
        '''' �Լ��� : ExportData 
        '''' ��  �� : ���
        '''' �ۼ��� : 
        '''' �ۼ��� : 2008.09.01
        '''' ������ : 
        '''' ������ : 
        '''' </summary>
        '''' <remarks></remarks>
        Public Sub ExportData()

            ' '' ''Dim AsqlParameters() As SqlParameter = Nothing
            ' '' ''If optExpAmt1.Checked = True Then
            ' '' ''    With GmainCommonFunction
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpYYYYMM.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABranchNm", Me.popBranchCd_R.TextValue)
            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' '' ''        .SetExportCrystalDataParameter("PNI303_1_C_R.rpt", "PNI303_1_C_R", "", AsqlParameters, AformulaParameters)
            ' '' ''    End With
            ' '' ''ElseIf optExpAmt2.Checked = True Then

            ' '' ''    With GmainCommonFunction
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpYYYYMM.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AChargeEmpNum_R", Me.txtChargeEmpNum_R.TextValue)
            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' '' ''        .SetExportCrystalDataParameter("PNI303_2_C_R.rpt", "PNI303_2_C_R", "", AsqlParameters, AformulaParameters)
            ' '' ''    End With
            ' '' ''ElseIf optExpAmt3.Checked = True Then

            ' '' ''    With GmainCommonFunction
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpYYYYMM.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABranchNum", Me.popBranchCd_R.TextValue)
            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' '' ''        .SetExportCrystalDataParameter("PNI303_3_C_R.rpt", "PNI303_3_C_R", "", AsqlParameters, AformulaParameters)
            ' '' ''    End With
            ' '' ''End If
        End Sub
    End Class

End Namespace
