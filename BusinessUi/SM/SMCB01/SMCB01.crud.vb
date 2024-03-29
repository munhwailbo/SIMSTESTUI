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

Namespace ubiLease.UI.BusinessUi.AC

    Partial Class SMCB01

        '====================================================================================================
        Public Sub NewData()
            ' Me.grd_1.NewData()
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            'If Me.cboRoleCode.TextValue.Length < 1 Then
            '    Exit Sub
            'End If
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARoleCode", Me.cboRoleCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesPositionDepartmentCode", popOnesPositionDepartmentCode.CodeText)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        ''====================================================================================================
        'Public Sub SaveData()
        '    GmainsqlParameters = Nothing
        '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
        '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

        '    GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_CUD", True, False, GmainsqlParameters)

        '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        '    GmainCommonFunction.SaveDataMessage(Me)
        'End Sub

        ''====================================================================================================
        'Public Sub DeleteData()
        '    GmainsqlParameters = Nothing
        '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
        '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

        '    GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_CUD", True, False, GmainsqlParameters)

        '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        '    GmainCommonFunction.SaveDataMessage(Me)
        'End Sub

    End Class

End Namespace
