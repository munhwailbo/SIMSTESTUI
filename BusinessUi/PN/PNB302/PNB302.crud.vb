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

Namespace ubiLease.UI.BusinessUi.PN

    Partial Class PNB302

        '====================================================================================================
        Public Sub NewData()

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AYYYYMM", Me.dtpBaseDt.TextValue)


            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB302_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub


        '====================================================================================================
        Public Sub SaveData()


        End Sub

        '====================================================================================================
        Public Sub DeleteData()



        End Sub

        Public Sub ExportData()

            Dim AsqlParameters() As SqlParameter = Nothing

            With GmainCommonFunction
                .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseDt.TextValue)

                'Dim AAAA As String = ""
                'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                Dim AformulaParameters() As SqlParameter = Nothing

                '.SetSqlParameter(AsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                '.SetSqlParameter(AsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                ' 공통변수의정의가생성시에발생될수있도록유도한다.
                .SetExportCrystalDataParameter("PNB302_C_R.rpt", "PNB302_C_R", "", AsqlParameters, AformulaParameters)
            End With

        End Sub

    End Class

End Namespace
