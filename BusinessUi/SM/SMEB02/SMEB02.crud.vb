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

    Partial Class SMEB02

        '====================================================================================================
        Public Sub NewData()
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ObjectType", Me.cboDBObjectGubun.TextValue)
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEB02_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            Dim inti As Integer = 0

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ObjectType", Me.grd_1.GetCurrentRowCellValue("ObjectType"))
                .SetSqlParameter(GmainsqlParameters, "@ObjectName", Me.grd_1.GetCurrentRowCellValue("ObjectName"))
            End With
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEB02_2_R", False, True, GmainsqlParameters)

            Me.txtContents.Text = ""
            If reciveDataSet.Tables(0).Rows.Count > 0 Then
                For inti = 0 To reciveDataSet.Tables(0).Rows.Count - 1
                    Me.txtContents.Text += reciveDataSet.Tables(0).Rows(inti).Item(0).ToString()
                Next inti
            End If

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

        '====================================================================================================
        ' 기등록된 데이터 체크박스 선택
        '====================================================================================================
        'Public Sub SetCheckBoxOfGrid(ByVal grd As ubiLease.GridControl.grd)
        '    Dim inti As Integer = 0

        '    With grd
        '        If (.Rows > .FixedRows) Then
        '            For inti = .FixedRows To .Rows - 1
        '                If .Cell(CellPropertySettings.flexcpText, inti, .get_ColIndex("InsertGubun")) = "U" Then
        '                    .Cell(CellPropertySettings.flexcpChecked, inti, .get_ColIndex("선택")) = CellCheckedSettings.flexChecked
        '                Else
        '                    .Cell(CellPropertySettings.flexcpChecked, inti, .get_ColIndex("선택")) = CellCheckedSettings.flexUnchecked
        '                End If
        '            Next inti
        '        End If
        '    End With

        'End Sub

    End Class

End Namespace
