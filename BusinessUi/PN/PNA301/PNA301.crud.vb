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
    Partial Class PNA301

        '====================================================================================================
        Public Sub NewData()

        End Sub
        

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.popChargeEmpNum.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ADeptCd", Me.popDeptCd.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AChargeTypeCd", Me.cboChargeTypeCd.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.PopBranchCd.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNA301_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub



        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", Me.grd_1.GetCurrentRowCellValue("ChargeEmpNum"))
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                .SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.grd_1.GetCurrentRowCellValue("BranchNm"))


                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNA301_2_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            End With

        End Sub



        '====================================================================================================
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", Me.grd_1.GetCurrentRowCellValue("ChargeEmpNum"))
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                .SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.grd_1.GetCurrentRowCellValue("BranchNm"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNA301_3_R", False, True, GmainsqlParameters)
                Me.grd_3.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub




        '====================================================================================================
        Public Sub SaveData()


           

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

           

        End Sub


    End Class

End Namespace
