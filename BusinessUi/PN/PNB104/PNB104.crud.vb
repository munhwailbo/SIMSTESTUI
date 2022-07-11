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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic


Namespace ubiLease.UI.BusinessUi.PN

    Partial Class PNB104

        '====================================================================================================
        Public Sub NewData()

            'GmainCommonFunction.ControlNewData(Me, Me.picCriteria_1)

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            'GmainsqlParameters = Nothing

            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProjectID", Me.popProjectID.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemID", Me.popSystemID.TextValue)

            'Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB104_R", False, True, GmainsqlParameters)
            'Me.grd_1.SetDataSet(reciveDataSet)
            'reciveDataSet = Nothing

            'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            'If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        ' ���α׷� ����Ʈ 
        Public Function ProgramListRequestData(Optional ByVal AprocessMessage As Boolean = True) As DataSet

            ProgramListRequestData = Nothing

            'GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProjectID", Me.popProjectID.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemID", Me.popSystemID.TextValue)

            'Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB104_3_R", False, True, GmainsqlParameters)

            'ProgramListRequestData = reciveDataSet

            'reciveDataSet = Nothing

        End Function

        ' ���μ��� ������
        Public Function ProcessStepRequestData(Optional ByVal AprocessMessage As Boolean = True) As DataSet

            ProcessStepRequestData = Nothing

            'GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProjectID", Me.popProjectID.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemID", Me.popSystemID.TextValue)

            'Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB104_4_R", False, True, GmainsqlParameters)

            'ProcessStepRequestData = reciveDataSet

            'reciveDataSet = Nothing

        End Function

        ' ���� ��� 
        Public Sub GetTempletPath(Optional ByVal AprocessMessage As Boolean = True)

            'GmainsqlParameters = Nothing

            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemID", "")
            'Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("GetTempletPath", False, True, GmainsqlParameters)

            'strFilePath = reciveDataSet.Tables(0).Rows(0).Item(0).ToString
            'Me.lblPath.Text = Me.lblPath.Text + strFilePath
            'reciveDataSet = Nothing

        End Sub

        '====================================================================================================
        Public Sub SaveData()

            If Validation() = True Then

                'GmainsqlParameters = Nothing

                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                'GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB104_CUD", True, False, GmainsqlParameters)

                'If GmainExecuteDbCommand.GerrorNumber = 0 Then
                '    GmainCommonFunction.SaveDataMessage(Me)
                'Else
                '    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                'End If

                'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            Else
                'GmainExecuteDbCommand.GerrorNumber = 1
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                'GmainsqlParameters = Nothing

                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

                'GmainExecuteDbCommand.ExecuteStoredProcedure("PNB104_CUD", True, False, GmainsqlParameters)

                'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                'MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Sub

        Public Function Validation() As Boolean

            Validation = False

            'With Me.grd_1
            '    For inti As Integer = .FixedRows To .Rows - 1

            '        If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
            '            If IsNumeric(.get_TextMatrix(inti, .get_ColIndex("IoCnt"))) = False Then
            '                MessageBox.Show("������ó���Ǽ��� �ٽ� �Է��� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If
            '            If IsNumeric(.get_TextMatrix(inti, .get_ColIndex("Cycle"))) = False Then
            '                MessageBox.Show("�߻��ֱ⸦ �ٽ� �Է��� �ּ���  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If
            '            If .get_TextMatrix(inti, .get_ColIndex("ProgramID")) = "" Then
            '                MessageBox.Show("���α׷�ID�� �ݵ�� �Է��� �ּ���  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If

            '        End If
            '    Next inti
            'End With

            Validation = True

        End Function


    End Class

End Namespace
