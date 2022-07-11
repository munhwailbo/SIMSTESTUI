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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Partial Class PNA202

        '====================================================================================================
        Public Sub NewData()
            If Trim(Me.txtEmployeeNumber.TextValue) = "" Then
                Exit Sub
            End If
            Me.grd_2.AddRow()
            Me.grd_2.set_TextMatrix(grd_2.Rows - 1, Me.grd_2.get_ColIndex("EmployeeNumber"), Trim(Me.txtEmployeeNumber.TextValue))
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASeviceStatesCode2", Me.cboSeviceStatesCode2.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNameHangul", Me.txtEmployeeNameHangul_2.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA202_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@EmployeeNumber", Me.grd_1.GetCurrentRowCellValue("EmployeeNumber"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA202_2_R", False, True, GmainsqlParameters)
            GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            reciveDataSet = Nothing

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.grd_1.GetCurrentRowCellValue("EmployeeNumber"))
            reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA202_2_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@EmployeeNumber", Me.txtEmployeeNumber.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA202_3_R", False, True, GmainsqlParameters)
            Dim bytBuffer() As Byte

            '-- ���� ���� �ʱ�ȭ 
            Me.OpenFileDialog1.Reset()

            '-- ��� �̹����� �ʱ�ȭ
            If Not PictureBox1.Image Is Nothing Then
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Nothing
            End If

            If reciveDataSet.Tables.Count >= 1 And reciveDataSet.Tables(0).Rows.Count >= 1 Then
                If reciveDataSet.Tables(0).Rows(0).Item("EmployeeImage").GetType.Name = "Byte[]" Then
                    bytBuffer = reciveDataSet.Tables(0).Rows(0).Item("EmployeeImage")
                    PictureBox1.Image = fnGetImage(bytBuffer)
                End If
            End If
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        Private Function fnGetImage(ByVal bytBuffer() As Byte) As Image
            GmainCommonFunction.setImage(bytBuffer)

            fnGetImage = GmainCommonFunction.getImage()
        End Function

        '====================================================================================================
        Public Sub SaveData()
            If Validation() = True Then
                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA202_2_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Else
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

            Me.GmainCommonFunction.GRequestDataNumber = 1

        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            Dim result As DialogResult = MessageBox.Show("����Ÿ�� ���� ���� �Ͻðڽ��ϱ�?  ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
                GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA202_2_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

            End If

            Me.GmainCommonFunction.GRequestDataNumber = 1

        End Sub

        Public Function Validation() As Boolean

            Validation = False

            With Me.grd_2
                For inti As Integer = .FixedRows To .Rows - 1
                    If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
                        If Trim(.get_TextMatrix(inti, .get_ColIndex("EmployeeNumber"))).Length < 1 Then
                            MessageBox.Show("��� ��ȣ�� �ٽ� �Է��� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                        If IsDate(.get_TextMatrix(inti, .get_ColIndex("AnnouncementOfAppointmentDate"))) = False Or .get_TextMatrix(inti, .get_ColIndex("AnnouncementOfAppointmentDate")).Length <> 10 Then
                            MessageBox.Show("�߷� ���ڸ� �ٽ� �Է��� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If

                    End If
                Next inti
            End With
            Validation = True
        End Function
    End Class

End Namespace
