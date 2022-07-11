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
    Partial Class PNE102

        '====================================================================================================
        Public Sub NewData()

            Me.grd_2.AddRow()
            grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("EmployeeExpNum"), Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFromExpandDt", Me.dtpFromExpand.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AToExpandDt", Me.dtpToExpand.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", "")   '' ''  Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum")

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE102_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE102_2_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            SetSubTotal()

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal()
            With Me.grd_2
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReFixedPaperNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "합계")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("EmployeeNameHangul"), "합  계")
                    Me.grd_2.FrozenRows = 1
                End If
            End With
        End Sub

        '====================================================================================================
        Public Sub SaveData()


            If MsgBox("저장하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE102_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)


            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE102_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)

            End If

        End Sub


    End Class

End Namespace
