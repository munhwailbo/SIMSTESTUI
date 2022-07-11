Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Namespace ubiLease.UI.BusinessUi.SM

    Partial Class SMDB04

        '====================================================================================================
        Public Sub NewData()
            Me.grd_1.NewData()
            GrecordProcessMode = 1
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessDateFrom", Me.dtpBusinessDateFrom.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessDateTo", Me.dtpBusinessDateTo.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.cboEmployee_R.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesPositionDepartmentCode", Me.popOnesPositionDepartmentCode.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB04_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            'Me.numOrders.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Orders")
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            Me.grd_1.AutoSizeRows()

        End Sub

        '====================================================================================================
        Public Sub SaveData()

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

        End Sub

        '====================================================================================================
        Public Function Validation() As Boolean

            Validation = False

            Validation = True

        End Function

        '====================================================================================================
        Public Sub ExportData()

            '��� �μⰡ �ƴ� ȭ���� grid �μ��� ��� ����ϴ� �Լ�
            'arguments 1 : print ���� - ȭ�� caption ��
            'arguments 2 : print grid  - grd_1
            'arguments 3 : print �μ� ���� - ����
            'arguments 4 : print font size - 10
            'GmainCommonFunction.SetExportGridData("������ ����", "grd_2", False, 8, "AccountCode")

            Dim AsqlParameters() As SqlParameter = Nothing
            Dim AformulaParameters() As SqlParameter = Nothing

            GmainCommonFunction.SetSqlParameter(AsqlParameters, "@ABusinessDateFrom", Me.dtpBusinessDateFrom.TextValue)
            GmainCommonFunction.SetSqlParameter(AsqlParameters, "@ABusinessDateTo", Me.dtpBusinessDateTo.TextValue)
            GmainCommonFunction.SetSqlParameter(AsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

            'GmainCommonFunction.SetSqlParameter(AformulaParameters, "�ۼ���ID", "'" & GmainBusinessFunction.GetValue("�α��� ID") & "'")
            'GmainCommonFunction.SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��� ��") & "'")

            GmainCommonFunction.SetExportCrystalDataParameter("SMDB04_C_R.rpt", "SMDB04_C_R;", "", AsqlParameters, AformulaParameters)
            GmainCommonFunction.GdataProcessing = False

        End Sub
    End Class

End Namespace
