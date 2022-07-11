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
Imports ubiLease
Imports ubiLease.CommonControls

Namespace ubiLease.UI.BusinessUi.CM

    Partial Class CMAA01

        '====================================================================================================
        Public Sub NewData()
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Title", Me.txtTitle1.Text)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("CM", "CMAA01_R", False, True, 0, GmainsqlParameters)

            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, Me.grd_1.GetCurrentRowCellValue("SEQ"), Me.txtTitle.Text)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, Me.grd_1.GetCurrentRowCellValue("SEQ"), Me.txtContent.Text)

        End Sub

    End Class

End Namespace
