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

    Partial Class SMDB03

        '====================================================================================================
        Public Sub NewData()
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
            Me.dtpBusinessLogDate.TextValue = Date.Today '�⺻ ��¥�� ���÷� ����
            Me.txtBusinessLogContent.Text = ""
            Me.numProgressRate.TextValue = "0"
            Me.numWorkTime.TextValue = "0"
            Me.cboEmployee.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            GrecordProcessMode = 1
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            Me.grd_1.NewData()
            Me.grd_3.NewData()
            Me.grd_4.NewData()

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessDateFrom", Me.dtpBusinessDateFrom.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessDateTo", Me.dtpBusinessDateTo.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.cboEmployee_R.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesPositionDepartmentCode", Me.popOnesPositionDepartmentCode.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB03_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessLogDate", Me.grd_1.GetCurrentRowCellValue("BusinessLogDate"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.grd_1.GetCurrentRowCellValue("EmployeeNumber"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(Me.grd_1.GetCurrentRowCellValue("Orders") = "|", 0, Me.grd_1.GetCurrentRowCellValue("Orders")))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB03_2_R", False, True, GmainsqlParameters)
            GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

            Me.txtBusinessLogContent.Text = reciveDataSet.Tables(0).Rows(0).Item("BusinessLogContent")
            If reciveDataSet.Tables(0).Rows.Count > 0 Then GrecordProcessMode = 2

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction

                If strDivisionReques = "1" Then
                    .SetSqlParameter(GmainsqlParameters, "@ABusinessLogDate", Me.dtpBusinessLogDate.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.cboEmployee.TextValue)
                Else
                    .SetSqlParameter(GmainsqlParameters, "@ABusinessLogDate", strBusinessLogDate)
                    .SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", strEmployeeNumber)
                End If

                .SetSqlParameter(GmainsqlParameters, "@AReceiptDivision", "1")

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB03_3_R", False, True, GmainsqlParameters)
                Me.grd_3.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                strDivisionReques = "1"
            End With

        End Sub

        '====================================================================================================
        Public Sub RequestData_4(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            If strDivisionReques = "1" Then
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessLogDate", Me.dtpBusinessLogDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.cboEmployee.TextValue)
            Else
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessLogDate", strBusinessLogDate)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", strEmployeeNumber)
            End If

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDivision", "2")

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB03_3_R", False, True, GmainsqlParameters)
            Me.grd_4.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

            strDivisionReques = "1"

        End Sub


        '====================================================================================================
        Public Sub InitRequestData_1(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessLogDate", Me.dtpBusinessLogDate.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", GmainBusinessFunction.GetValue("�α��� ID"))

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDivision", "1")

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB03_3_R", False, True, GmainsqlParameters)
            Me.grd_3.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub


        '====================================================================================================
        Public Sub InitRequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessLogDate", Me.dtpBusinessLogDate.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", GmainBusinessFunction.GetValue("�α��� ID"))

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDivision", "2")

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB03_3_R", False, True, GmainsqlParameters)
            Me.grd_4.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub SaveData()

            If Me.Validation = True Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessLogDate", Me.dtpBusinessLogDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.cboEmployee.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ALogTitle", Me.txtLogTitle.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessLogContent", Me.txtBusinessLogContent.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.numOrders.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProgressRate", Me.numProgressRate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkTime", Me.numWorkTime.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARemark", Me.txtRemark.TextValue)

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB03_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            Else
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            Dim result As DialogResult = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?  ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessLogDate", Me.dtpBusinessLogDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.cboEmployee.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ALogTitle", Me.txtLogTitle.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessLogContent", Me.txtBusinessLogContent.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.grd_1.GetCurrentRowCellValue("Orders"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProgressRate", Me.numProgressRate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWorkTime", Me.numWorkTime.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARemark", Me.txtRemark.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMDB03_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

                GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
                Me.txtBusinessLogContent.Text = ""

            Else
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

        End Sub

        '====================================================================================================
        Public Function Validation() As Boolean

            Validation = False

            If IsDate(Me.dtpBusinessLogDate.Text) = False Then
                MessageBox.Show("���� ���ڸ� �ٽ� �Է��� �ּ��� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.dtpBusinessLogDate.Focus()
                Exit Function
            End If

            'If Trim(Me.cboEmployee.TextValue).Length <> 6 Then
            '    MessageBox.Show("����� �ٽ� ������ �ּ��� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Me.cboEmployee.Focus()
            '    Exit Function
            'End If

            If Trim(Me.txtBusinessLogContent.Text).Length < 1 Then
                MessageBox.Show("���� ������ �Է��� �ּ��� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtBusinessLogContent.Focus()
                Exit Function
            End If

            If IsNumeric(Me.numProgressRate.TextValue) = False Or (Me.numProgressRate.TextValue > 100 Or Me.numProgressRate.TextValue < 0) Then
                MessageBox.Show("�������� �ٽ� �Է��� �ּ��� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.numProgressRate.Focus()
                Exit Function
            End If

            If IsNumeric(Me.numWorkTime.TextValue) = False Then
                MessageBox.Show("�۾� �ð��� �ٽ� �ּ��� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.numWorkTime.Focus()
                Exit Function
            End If

            Validation = True

        End Function

    End Class

End Namespace
