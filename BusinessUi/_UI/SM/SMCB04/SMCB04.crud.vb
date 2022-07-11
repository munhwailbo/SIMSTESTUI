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

Namespace ubiLease.UI.BusinessUi.AC

    Partial Class SMCB04

        '====================================================================================================
        Public Sub NewData()

            GmainCommonFunction.ControlNewData(Me, Me.picCriteria_1)
            Me.grd_1.NewData()
            Me.grd_2.NewData()
            Me.grd_2.RemoveItem(1)
            Me.grd_3.NewData()
            Me.grd_3.RemoveItem(1)
            Me.grd_4.NewData()
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            Dim strFlag As String = ""

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesPositionDepartmentCode", popOnesPositionDepartmentCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.popEmployeeNumber.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASeviceStatesCode", Me.cboSeviceStatesCode.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB04_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.cboSystemDivision.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.grd_1.GetCurrentRowCellValue("EmployeeNumber"))
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB04_2_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            Me.txtEmployeeNumber.TextValue = Me.grd_1.GetCurrentRowCellValue("EmployeeNumber")

        End Sub

        '====================================================================================================
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", Me.cboSystemDivision.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.grd_1.GetCurrentRowCellValue("EmployeeNumber"))
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB04_3_R", False, True, GmainsqlParameters)
            Me.grd_3.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage  = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub RequestData_4(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASystemDivision", (Me.grd_2.GetCurrentRowCellValue("SystemDivision").Substring(0, 2)))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARoleCode", Me.grd_2.GetCurrentRowCellValue("RoleCode"))
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB04_4_R", False, True, GmainsqlParameters)
            Me.grd_4.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        Public Sub SaveData()
            '역할자 추가

            Dim intCount As Integer = 0
            With Me.grd_3
                If .Rows > 1 Then
                    For inti As Integer = .FixedRows To .Rows - 1
                        If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
                            intCount = intCount + 1
                            Exit For
                        End If
                    Next

                    If intCount = 0 Then
                        Exit Sub
                    End If

                    GmainsqlParameters = Nothing
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.txtEmployeeNumber.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", .GetXmlData(False))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB04_2_CUD", True, False, GmainsqlParameters)

                    If GmainExecuteDbCommand.GerrorNumber > 0 Then
                        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        GmainExecuteDbCommand.GerrorNumber = 1
                    Else
                        GmainCommonFunction.SaveDataMessage(Me)
                        CallByName(Me, "RequestData", CallType.Method)
                    End If
                Else
                    GmainExecuteDbCommand.GerrorNumber = 1

                End If
            End With

        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            '역할자 삭제 
            Dim intCount As Integer = 0
            If Me.grd_2.Rows > 1 Then
                For inti As Integer = Me.grd_2.FixedRows To Me.grd_2.Rows - 1
                    If Me.grd_2.GetCellCheck(inti, Me.grd_2.get_ColIndex("선택")) = CheckEnum.Checked Then
                        intCount = intCount + 1
                        Exit For
                    End If
                Next

                If intCount = 0 Then
                    Exit Sub
                End If

                Dim result As DialogResult = MessageBox.Show("정녕 데이타를 삭제 하시겠습니까? ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    GmainsqlParameters = Nothing
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB04_CUD", True, False, GmainsqlParameters)

                    If GmainExecuteDbCommand.GerrorNumber > 0 Then
                        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        GmainExecuteDbCommand.GerrorNumber = 1
                    Else
                        MessageBox.Show("데이타가 삭제 되었습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CallByName(Me, "RequestData", CallType.Method)
                    End If

                End If
            End If


        End Sub

    End Class

End Namespace
