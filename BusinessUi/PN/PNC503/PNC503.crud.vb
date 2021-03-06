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
    Partial Class PNC503
        Inherits CommonControls.UiControl
        '====================================================================================================
        Public Sub NewData()
            Me.grd_1.AddRow()
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASend_Date_From", Me.dtpSEND_DATEFrom.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASend_Date_To", Me.dtpSEND_DATETo.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AName", Me.txtName.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACALLBACK", Me.txtCALLBACK.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADEST_NAME", Me.TxtDEST_NAME.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APHONE_NUMBER", Me.txtPHONE_NUMBER.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptCd", Me.popTrAdEmployeeDeptCd.CodeText)

          



            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC503_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub SaveData()

            'If MsgBox("?????????????????", MsgBoxStyle.OkCancel, "??????????.") = MsgBoxResult.Ok Then

            '    GmainsqlParameters = Nothing

            '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("?????? ID"))
            '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

            '    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC503_CUD", True, False, GmainsqlParameters)

            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        GmainCommonFunction.SaveDataMessage(Me)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "????????", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If

            '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)


            'End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            'If MsgBox("?????????????????", MsgBoxStyle.OkCancel, "??????????.") = MsgBoxResult.Ok Then

            '    GmainsqlParameters = Nothing

            '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("?????? ID"))
            '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            '    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC503_CUD", True, False, GmainsqlParameters)

            '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            '    GmainCommonFunction.SaveDataMessage(Me)

            'End If

        End Sub
        ''' <summary>
        ''' ?????? : ExportData 
        ''' ??  ?? : ????
        ''' ?????? : 
        ''' ?????? : 2008.09.01
        ''' ?????? : 
        ''' ?????? : 
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
            '    'AAAA = "{@????ID}=" &"'" & GmainBusinessFunction.GetValue("??????ID") & "'"

            '    Dim AformulaParameters() As SqlParameter = Nothing

            '    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "????ID", "'" & GmainBusinessFunction.GetValue("??????ID") & "'")
            '    .SetSqlParameter(AformulaParameters, "??????", "'" & GmainBusinessFunction.GetValue("????????") & "'")

            '    ' ??????????????????????????????????????????????.
            '    .SetExportCrystalDataParameter("PNC503_C_R.rpt", "PNC503_C_R;PNC503_1_C_R;", "", AsqlParameters, AformulaParameters)
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