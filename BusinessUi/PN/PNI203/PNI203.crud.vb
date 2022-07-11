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

    Partial Class PNI203

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

            GmainCommonFunction.ControlNewData(Me, Me.picIo_1)

            Me.dtpClosingYearMonths.TextValue = System.DateTime.Now
            Me.dtpClosingDt.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            Me.cboClosingType.TextValue = "02"    '' û�� ����
            cboClosingType.Enabled = False

            Me.RequestData()

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
                .SetSqlParameter(GmainsqlParameters, "@AClosingType", Me.cboClosingType.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "GetMaxCloseDate", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        '====================================================================================================
        Public Function GetCloseDate(Optional ByVal AprocessMessage As Boolean = True) As Boolean

            Return True
            'GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@NextCloseMonth", Me.dtpClosingYearMonths.TextValue)
            'Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI203_R", False, True, GmainsqlParameters)

            'Dim CloseDateCount As String = reciveDataSet.Tables(0).Rows(0).Item("CloseDateCount").ToString

            'reciveDataSet = Nothing

            'If CloseDateCount = "0" Then
            '    Return True
            'Else
            '    Return False
            'End If

            'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        End Function


        '====================================================================================================
        Public Sub SaveData()
            Dim message As String = Me.dtpNextClosingYearMonths.TextValue.Substring(0, 4) & "�� " & Me.dtpNextClosingYearMonths.TextValue.Substring(4, 2) & "��"
            If MsgBox(message & vbCrLf & "���� ó�� �Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "1")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingYearMonths", Me.dtpNextClosingYearMonths.TextValue)  ' ���� �ô� ���� �� ���
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingType", Me.cboClosingType.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingMode", "1")  '' '' 1:����ó�� , 2: �������
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI203_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                    GmainCommonFunction.GRequestDataNumber = 1
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            Dim message As String = Me.dtpClosingYearMonths.TextValue.Substring(0, 4) & "�� " & Me.dtpClosingYearMonths.TextValue.Substring(4, 2) & "��"
            If MsgBox(message & vbCrLf & "���� ��� �Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingYearMonths", Me.dtpClosingYearMonths.TextValue)  '���� ��� �ô� �����Ǿ� �ִ� ���
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingType", Me.cboClosingType.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingMode", "2")  '' '' 1:����ó�� , 2: �������
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI203_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.GRequestDataNumber = 1
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                'MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Sub

    End Class

End Namespace
