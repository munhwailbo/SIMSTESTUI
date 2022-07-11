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

    Partial Class PNC203

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
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_3_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_4_R", False, True, GmainsqlParameters)
                Me.grd_3.SetDataSet(reciveDataSet)

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

            Dim sDate As String
            sDate = System.DateTime.Now

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '���ڸ�
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '��ȭ��ȣ1
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '��ȭ��ȣ2
                .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '�ڵ�����ȣ
                .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", "") '�ſ����ȣ
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", "") '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '�Ż��ּ�
                .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", "") '�������ȣ
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", "") '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '�����ּ�
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_CUD", True, False, GmainsqlParameters)

            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            '------------------------------------------------------------------------------------------
            ' ���� ���� ����� �̷� �߰�
            '------------------------------------------------------------------------------------------
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", 0) '�Ϸù�ȣ
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '���������ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '���ڸ�
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '��ȭ��ȣ1
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '��ȭ��ȣ2
                .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '�ڵ�����ȣ
                .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", "") '�ſ����ȣ
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", "") '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '�Ż��ּ�
                .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", "") '�������ȣ
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", "") '���ּ�
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '�����ּ�
                .SetSqlParameter(GmainsqlParameters, "@AProcessDt", sDate.Replace("-", "").Substring(0, 8)) '�����ּ�
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_CUD", True, False, GmainsqlParameters)

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
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            Dim sDate As String
            sDate = System.DateTime.Now

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", 3) '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '���ڸ�
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '��ȭ��ȣ1
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '��ȭ��ȣ2
                    .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '�ڵ�����ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", "") '�ſ����ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", "") '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '�Ż��ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", "") '�������ȣ
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", "") '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '�����ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                '------------------------------------------------------------------------------------------
                ' ���� ���� ����� �̷� �߰�
                '------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", 0) '�Ϸù�ȣ
                    .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '���������ڵ�
                    .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '���ڸ�
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '��ȭ��ȣ1
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '��ȭ��ȣ2
                    .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '�ڵ�����ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", "") '�ſ����ȣ
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", "") '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '�Ż��ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", "") '�������ȣ
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", "") '���ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '�����ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AProcessDt", sDate.Replace("-", "").Substring(0, 8)) '�����ּ�
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_CUD", True, False, GmainsqlParameters)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GrecordProcessMode = "2"
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

            End If

        End Sub

    End Class

End Namespace
