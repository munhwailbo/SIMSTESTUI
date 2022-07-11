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

    Partial Class SMDA13

        '====================================================================================================
        Public Sub NewData()
            Me.grd_1.NewData()
            GmainCommonFunction.ControlNewData(Me, Me.picCriteria_1)
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.cboSystemDivision.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARoleCode", Me.cboRoleCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesPositionDepartmentCode", Me.popEarningsOrganizationCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.popEmployeeNumber.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AStDate", Me.dtpStDate.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEdDate", Me.dtpEdDate.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMDA13_R", False, True, GmainsqlParameters)

            DynamicInitialize(reciveDataSet)

            Me.grd_1.SetDataSet(reciveDataSet)

            ' SubTotal �Լ� ȣ��
            Me.SubTotal(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
#Region "SUBTOTAL ���� �Լ�"
        Private Sub SubTotal(ByRef reciveDataSet As DataSet)
            Dim intCol As Integer = 0
            Dim intII As Integer = 0
            Me.grd_1.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.SlateGray
            Me.grd_1.FrozenRows = 1
            Me.grd_1.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, Me.grd_1.get_ColIndex("Tot"), "�հ�")

            Dim colName As String = ""
            If reciveDataSet.Tables(1).Rows.Count <> 0 Then
                With reciveDataSet.Tables(1)
                    For intII = 3 To .Columns.Count - 1
                        intCol += 1
                        colName = ""
                        colName = "UiId_" & VBN.Right("000" & CStr(intCol), 3)
                        Me.grd_1.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, Me.grd_1.get_ColIndex(colName), "�հ�")
                    Next
                End With
            End If
        End Sub
#End Region

        '====================================================================================================
        Public Sub DeleteData()
            MsgBox("��ȸ ȭ�鿡�� ������ �Ҽ� �����ϴ�")
        End Sub

    End Class

End Namespace
