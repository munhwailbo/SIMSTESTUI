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

Namespace ubiLease.UI.BusinessUi.SM

    Partial Class SMEB03

        '====================================================================================================
        Public Sub NewData()
            With Me.grd_1
                .AddRow()
                .set_TextMatrix(.Rows - 1, .get_ColIndex("SystemClass"), Me.cboSystemClass.Text)  '�ý��� ����    
            End With
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@SystemClass", Me.cboSystemClass.TextValue)
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEB03_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub SaveData()
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False)) 'save

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEB03_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True)) 'true

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEB03_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)
        End Sub

    End Class

End Namespace
