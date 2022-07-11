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

    Partial Class SMDB02

        '====================================================================================================
        Public Sub NewData()

        End Sub

        Dim strWorkDivision As String = "����"

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            Dim strPeriod As String = ""

            If Me.optTotal.Checked = True Then
                strPeriod = "0"
            ElseIf Me.OptYear.Checked = True Then
                strPeriod = "1"
            ElseIf Me.OptMonth.Checked = True Then
                strPeriod = "2"
            End If

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProjectID", Me.popProjectID.TextValue)           ' ������Ʈ ����
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.popSystemID.TextValue)       ' �ý��� ����
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@FromDate", Me.dtpReceiptDateFrom.TextValue)       ' ��ȸ ��¥(from)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ToDate", Me.dtpReceiptDateTo.TextValue)           ' ��ȸ��¥(to)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APeriod", strPeriod)           ' �Ⱓ��


            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB02_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)


            'If Me.OptYear.Checked = True Then
            '    Me.dtpReceiptDateFrom.TextValue = Year(Me.dtpReceiptDateFrom.TextValue)
            '    Me.dtpReceiptDateTo.TextValue = Year(Me.dtpReceiptDateTo.TextValue)
            'ElseIf Me.OptMonth.Checked = True Then
            '    Me.dtpReceiptDateFrom.TextValue = Month(Me.dtpReceiptDateFrom.TextValue)
            '    Me.dtpReceiptDateTo.TextValue = Month(Me.dtpReceiptDateTo.TextValue)
            'Else
            '    Me.dtpReceiptDateFrom.TextValue = (Me.dtpReceiptDateFrom.TextValue)
            '    Me.dtpReceiptDateTo.TextValue = (Me.dtpReceiptDateTo.TextValue)
            'End If

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

            'Me.grd_1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
            'Me.grd_1.set_MergeCol(Me.grd_1.get_ColIndex("ProjectID"), True)
            'Me.grd_1.set_MergeCol(Me.grd_1.get_ColIndex("ProjectName"), True)
            Dim i As Integer
            With Me.grd_1
                .FixedRows = 2
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                For i = Me.grd_1.get_ColIndex("ReceiptCount") To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = False
                Next
            End With

        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            Dim strDivision As String = ""
            Dim strWorkState As String = ""


            If Me.optDivision1.Checked = True Then
                strDivision = "1" '����
                strWorkDivision = "����"
            ElseIf Me.optDivision2.Checked = True Then
                strDivision = "2" ' ó��
                strWorkDivision = "ó��"
            ElseIf Me.optreceipt.Checked = True Then
                strWorkState = "000" '������
                strWorkDivision = "����"
            ElseIf Me.opting.Checked = True Then
                strWorkState = "001"
                strWorkDivision = "����"
            ElseIf Me.optleft.Checked = True Then
                strWorkState = "002"
                strWorkDivision = "����"
            End If

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.grd_1.GetCurrentRowCellValue("SystemDivisionCode"))      ' �ý��� ����
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@FromDate", Me.dtpReceiptDateFrom.TextValue)                                   ' ��ȸ ��¥(from)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ToDate", Me.dtpReceiptDateTo.TextValue)                                       ' ��ȸ��¥(to)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADivision", strDivision)   '1:���� , 2:ó��
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkStates", strWorkState)   '000:������ 001:������ 002:����
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkDivision", Me.cboWorkDivision.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB02_2_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

            Me.Cursor = Cursors.Default

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

                .SetSqlParameter(AsqlParameters, "@AWorkDivision", strWorkDivision)
                .SetSqlParameter(AsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

                Dim AformulaParameters() As SqlParameter = Nothing

                .SetExportCrystalDataParameter("SMDB02_C_R.rpt", "SMDB02_C_R;", "", AsqlParameters, AformulaParameters)

            End With

        End Sub

    End Class

End Namespace
