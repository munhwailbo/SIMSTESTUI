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
    Partial Class PNC502

        '====================================================================================================
        Public Sub NewData()
            Me.grd_1.AddRow()
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing


            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptStDt", Me.dtpReceiptDtFrom.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptEdDt", Me.dtpReceiptDtTo.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsultationCd", Me.cboConsultationDivCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeNm", Me.txtSubscriberNm_2.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABizEmpNum", Me.popEmployeeNumber.CodeText)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMonitorResultCd", Me.cboMonitorResultCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", Me.cboExpandDivCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.PopBranchCd.CodeText)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACnsltEmpNum", Me.PopMonitorEmpCd.CodeText)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.PopCompanyCd.CodeText)



            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC502_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub SaveData()

            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC502_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)


            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            'If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

            '    GmainsqlParameters = Nothing

            '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            '    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC502_CUD", True, False, GmainsqlParameters)

            '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            '    GmainCommonFunction.SaveDataMessage(Me)

            'End If

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

            'Dim AsqlParameters() As SqlParameter = Nothing

            'With GmainCommonFunction
            '    .SetSqlParameter(AsqlParameters, "@AReceiptStDt", Me.dtpReceiptDtFrom.TextValue)
            '    .SetSqlParameter(AsqlParameters, "@AReceiptEdDt", Me.dtpReceiptDtTo.TextValue)
            '    '.SetSqlParameter(AsqlParameters, "@AConsultationCd", Me.cboConsultationDivCd.TextValue)
            '    '.SetSqlParameter(AsqlParameters, "@ASubscribeNm", Me.txtSubscriberNm_2.TextValue)
            '    '.SetSqlParameter(AsqlParameters, "@ABizEmpNum", Me.popEmployeeNumber.CodeText)
            '    '.SetSqlParameter(AsqlParameters, "@AStateCd", Me.cboStateCd.TextValue)
            '    '.SetSqlParameter(AsqlParameters, "@AExpandDivCd", Me.cboExpandDivCd.TextValue)
            '    '.SetSqlParameter(AsqlParameters, "@ABranchCd", Me.PopBranchCd.CodeText)
            '    '.SetSqlParameter(AsqlParameters, "@ACnsltEmpNum", Me.PopMonitorEmpCd.CodeText)

            '    'Dim AAAA As String = ""
            '    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            '    Dim AformulaParameters() As SqlParameter = Nothing

            '    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            '    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            '    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            '    .SetExportCrystalDataParameter("PNC502_C_R.rpt", "PNC502_C_R;PNC502_1_C_R;", "", AsqlParameters, AformulaParameters)
            'End With

        End Sub

    End Class

End Namespace
'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptStDt", Me.dtpReceiptDtFrom.TextValue)
'            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptEdDt", Me.dtpReceiptDtTo.TextValue)
'            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsultationCd", Me.cboConsultationDivCd.TextValue)
'            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeNm", Me.txtSubscriberNm_2.TextValue)
'            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABizEmpNum", Me.popEmployeeNumber.CodeText)
'            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AStateCd", Me.cboStateCd.TextValue)
'            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", Me.cboExpandDivCd.TextValue)
'            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.PopBranchCd.CodeText)
'            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACnsltEmpNum", Me.PopMonitorEmpCd.CodeT