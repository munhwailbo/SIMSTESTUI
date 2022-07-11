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

Namespace ubiLease.UI.BusinessUi.CO

    Partial Class SMBB02

        '====================================================================================================
        Public Sub NewData()
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
            '-- 그리드 초기화
            Me.grd_1.AddRow()
            'me.grd_1.ColumnCollection.Item(0).
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbusinessPlaceCode", Me.cboBusinessPlaceCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbranchCode", Me.cboBranchCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATeamCode", Me.cboTeamCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APartCode", Me.cboPartCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APCCode", Me.cboPCCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACornerCode", Me.cboCornerCode.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMBB02_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub SaveData()
            GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMBB02_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMBB02_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)

        End Sub

    End Class

End Namespace
