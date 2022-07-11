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

Namespace ubiLease.UI.BusinessUi.PN

    Partial Class PNB203

        '====================================================================================================
        Public Sub NewData()
            With Me.grd_2
                .AddRow()
                .set_TextMatrix(.Rows - 1, .get_ColIndex("ReceiptDt"), System.DateTime.Today)
                .set_TextMatrix(.Rows - 1, .get_ColIndex("BranchNum"), Me.grd_1.GetCurrentRowCellValue("BranchNum"))
            End With

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpBaseDt.Text)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB203_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchCd"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB203_2_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub SaveData()

            'If Validation() = True Then

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB203_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            'Else
            'GmainExecuteDbCommand.GerrorNumber = 1
            'End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB203_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                MessageBox.Show("데이타가 삭제 되었습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Sub

        Public Function Validation() As Boolean

            'Validation = False

            'With Me.grd_1
            '    For inti As Integer = .FixedRows To .Rows - 1

            '        If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
            '            If .get_TextMatrix(inti, .get_ColIndex("ProjectID")).Length <> 4 Or Trim(.get_TextMatrix(inti, .get_ColIndex("ProjectName"))) = "" Then
            '                MessageBox.Show("프로젝트 ID를 반드시 입력해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If
            '            If .get_TextMatrix(inti, .get_ColIndex("SystemID")).Length <> 5 Or Trim(.get_TextMatrix(inti, .get_ColIndex("SystemName"))) = "" Then
            '                MessageBox.Show("시스템 ID를 반드시 입력해 주세요  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If
            '            If .get_TextMatrix(inti, .get_ColIndex("RefProID")) <> "" Then
            '                If .get_TextMatrix(inti, .get_ColIndex("RefProID")).Length <> 5 Or Trim(.get_TextMatrix(inti, .get_ColIndex("ProcName"))) = "" Then
            '                    MessageBox.Show("관련 프로세스를 다시 입력해 주세요  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                    Exit Function
            '                End If
            '            End If

            '            If IsNumeric(.get_TextMatrix(inti, .get_ColIndex("RowSize"))) = False Then
            '                MessageBox.Show("RowSize를 다시 입력해 주세요  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If
            '            If IsNumeric(.get_TextMatrix(inti, .get_ColIndex("TableVolum"))) = False Then
            '                MessageBox.Show("테이블 볼륨을 다시 입력해 주세요  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If
            '            If IsNumeric(.get_TextMatrix(inti, .get_ColIndex("IncreasingRate"))) = False Then
            '                MessageBox.Show("증가율을 다시 입력해 주세요  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If

            '        End If
            '    Next inti
            'End With

            'Validation = True

        End Function
    End Class

End Namespace
