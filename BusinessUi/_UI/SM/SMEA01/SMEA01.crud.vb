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

Namespace ubiLease.UI.BusinessUi.SM

    Partial Class SMEA01

        '====================================================================================================
        Public Sub NewData()
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)

            '신규 버튼 클릭후 컨트롤 세팅
            Me.txtBusinessPlaceCode.Enabled = True
            Me.txtTaxOfficeCode.Enabled = True

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AfirmName", Me.txtFirmName.Text)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEA01_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        'Public Sub SaveData()
        '    'GmainsqlParameters = Nothing
        '    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
        '    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

        '    'GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEA01_CUD", True, False, GmainsqlParameters)

        '    'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        '    'GmainCommonFunction.SaveDataMessage(Me)
        'End Sub

        '====================================================================================================
        'Public Sub DeleteData()
        '    'GmainsqlParameters = Nothing

        '    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
        '    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

        '    'GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEA01_CUD", True, False, GmainsqlParameters)

        '    'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        '    'GmainCommonFunction.SaveDataMessage(Me)

        'End Sub

    End Class

End Namespace
