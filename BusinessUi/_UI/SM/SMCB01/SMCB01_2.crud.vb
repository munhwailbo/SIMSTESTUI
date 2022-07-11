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
        Public Sub NewData_2()
            Me.grd_2.NewData()
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARoleCode", Me.cboRoleCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesPositionDepartmentCode", popOnesPositionDepartmentCode.CodeText)
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_2_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub SaveData()
            GmainsqlParameters = Nothing
            ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbranchCode", Me.txtBranchCode.TextValue)
            ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbudgetYears", Me.dtpBudgetYears.TextValue)
            ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbudgetMonths", Me.txtBudgetMonths.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbusinessPlaceCode", GmainBusinessFunction.GetValue("사업장 코드"))
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

            'GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_2_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            GmainsqlParameters = Nothing
            ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbranchCode", Me.txtBranchCode.TextValue)
            ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbudgetYears", Me.dtpBudgetYears.TextValue)
            ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbudgetMonths", Me.txtBudgetMonths.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbusinessPlaceCode", GmainBusinessFunction.GetValue("사업장 코드"))
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))

            'GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_2_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)
        End Sub

    End Class

End Namespace
