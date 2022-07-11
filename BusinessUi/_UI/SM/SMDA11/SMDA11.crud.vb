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

    Partial Class SMDA11

        '====================================================================================================
        Public Sub NewData()

            GmainCommonFunction.ControlNewData(Me, Me.picCriteria_1)
            Me.grd_1.NewData()

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            Debug.Print(grd_1.FixedRows.ToString())
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.cboSystemDivision.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ARoleCode", Me.cboRoleCode.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AProcessState", Me.cboProcessState.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AStandardDate", Me.dtpStandardDate.TextValue)
            End With

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMDA11_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            ' SUBTOTAL 함수 호출
            Me.SubTotal()

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
#Region "SUBTOTAL 관련 함수"
        Private Sub SubTotal()
            Me.grd_1.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.SlateGray
            Me.grd_1.FrozenRows = Me.grd_1.FixedRows

            Me.grd_1.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, Me.grd_1.get_ColIndex("Weeks"), "합계")
            Me.grd_1.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, Me.grd_1.get_ColIndex("Months"), "합계")
            Me.grd_1.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, Me.grd_1.get_ColIndex("ThreeMonths"), "합계")
            Me.grd_1.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, Me.grd_1.get_ColIndex("SixMonths"), "합계")
            Me.grd_1.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, Me.grd_1.get_ColIndex("Years"), "합계")
            Me.grd_1.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, Me.grd_1.get_ColIndex("SumAmount"), "합계")
        End Sub
#End Region

        '====================================================================================================
        Public Sub DeleteData()

        End Sub

    End Class

End Namespace
