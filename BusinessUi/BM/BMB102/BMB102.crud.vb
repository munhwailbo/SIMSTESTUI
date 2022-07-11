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

Namespace ubiLease.UI.BusinessUi.BM

    Partial Class BMB102

        Public Sub NewData()
        End Sub

        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction

                Dim chkState As String = ""
                If chkPaymentPerson.Checked And chkPersonInArrears.Checked = False Then chkState = "1"
                If chkPaymentPerson.Checked = False And chkPersonInArrears.Checked Then chkState = "2"
                If chkPaymentPerson.Checked And chkPersonInArrears.Checked Then chkState = "3"

                .SetSqlParameter(GmainsqlParameters, "@AMutualYearMonthFrom", Me.dtpMutualYearMonthFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AMutualYearMonthTo", Me.dtpMutualYearMonthTo.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.popBranchChiefCd.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AState", chkState)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "BMB102_R", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing

                'Fixed 컬럼 Merge
                Me.grd_1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                For i As Integer = 0 To Me.grd_1.get_ColIndex("ChargeEmpNumNm")
                    Me.grd_1.ColumnCollection(i).AllowMerging = True
                Next

                For i As Integer = Me.grd_1.FixedRows - 1 To Me.grd_1.Row - 1
                    Me.grd_1.set_MergeRow(i, True)
                Next

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            With Me.grd_1
                .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData  ' .BelowData
                .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)

                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue
                '소계
                .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNumNm"), .get_ColIndex("MutualAmount"), "{0} 소계")
                ''그리드 합계행 추가
                .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("MutualAmount"), "합계")
            End With

            SetBackColor()
        End Sub

        Private Sub SetBackColor()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    For inti As Integer = 0 To Me.grd_1.Rows - 1
                        If .get_TextMatrix(inti, .get_ColIndex("UserDivisionCode")) = "소 계" Then
                            .set_Cell(CellPropertySettings.flexcpBackColor, inti, .get_ColIndex("선택"), inti, .get_ColIndex("Dumi"), Color.LightYellow)
                            .set_Cell(CellPropertySettings.flexcpForeColor, inti, .get_ColIndex("선택"), inti, .get_ColIndex("RePaymentOccurrenceAmount"), Color.MediumBlue)
                        ElseIf .get_TextMatrix(inti, .get_ColIndex("UserDivisionCode")) = "합 계" Then
                            .set_Cell(CellPropertySettings.flexcpBackColor, inti, .get_ColIndex("선택"), inti, .get_ColIndex("RePaymentOccurrenceAmount"), Color.Snow)
                            .set_Cell(CellPropertySettings.flexcpForeColor, inti, .get_ColIndex("선택"), inti, .get_ColIndex("RePaymentOccurrenceAmount"), Color.Red)
                        End If
                    Next
                End If
            End With
        End Sub

        Public Sub SaveData()

        End Sub

        Public Sub DeleteData()

        End Sub

    End Class

End Namespace
