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

    Partial Class SMCB05

        '====================================================================================================
        Public Sub NewData()
            Me.grd_1.NewData()
            GmainCommonFunction.ControlNewData(Me, Me.picCriteria_1)
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesPositionDepartmentCode", Me.popEarningsOrganizationCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProgramID", Me.popProgramList.TextValue)
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB05_R", False, True, GmainsqlParameters)

            DynamicInitialize(reciveDataSet)

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
            MsgBox("조회 화면에서 삭제는 할수 없습니다")
        End Sub

    End Class

End Namespace
