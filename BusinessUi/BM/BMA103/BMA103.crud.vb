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

    Partial Class BMA103

        Public Sub NewData()
        End Sub

        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AStandardDate", Me.dtpStandardDate.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubjectYON", Me.chkSubjectYON.Checked)
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "BMA103_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            'Fixed ÄÃ·³ Merge
            Me.grd_1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
            For i As Integer = 0 To Me.grd_1.get_ColIndex("ChargeEmpNumNm")
                Me.grd_1.ColumnCollection(i).AllowMerging = True
            Next

            For i As Integer = Me.grd_1.FixedRows - 1 To Me.grd_1.Row - 1
                Me.grd_1.set_MergeRow(i, True)
            Next

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        Public Sub SaveData()

        End Sub

        Public Sub DeleteData()

        End Sub

    End Class

End Namespace
