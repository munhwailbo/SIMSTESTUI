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

    Partial Class SMDA15

        '====================================================================================================
        Public Sub NewData()
            Me.grd_1.NewData()

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@CheckDate", Me.dtpCheckDate_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@WorkDivision", Me.cboWorkDivision_R.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "dbo.SMDA15_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            End With

        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@CheckDate", Me.dtpCheckDate_R.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@CheckID", Me.grd_1.GetCurrentRowCellValue("CheckID"))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "dbo.SMDA15_1_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            End With

            Me.Cursor = Cursors.Default

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

        End Sub

    End Class

End Namespace
