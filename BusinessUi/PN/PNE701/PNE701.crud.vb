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

Imports System.Xml
Imports System.IO

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic


Namespace ubiLease.UI.BusinessUi.PR

    Partial Class PNE701

        '====================================================================================================
        Public Sub NewData()
            With Me.grd_1
                .AddRow()
            End With
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManageYear", Me.dtpYear.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABasketCd", Me.popBasketCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyHangulNm", Me.txtCompanyHangulNm.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE701_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub SaveData()

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManageYear", Me.dtpYear.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE701_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If
        End Sub


        '====================================================================================================
        Public Sub DeleteData()
            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManageYear", Me.dtpYear.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE701_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If


        End Sub

        Public Sub SaveData_2()

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABeforeYear", Me.dtpBeforeYear.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAfterYear", Me.dtpAfterYear.TextValue)

            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE701_2_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            Me.dtpYear.TextValue = Me.dtpAfterYear.TextValue
            Me.RequestData()

        End Sub

        Public Sub SetData()

            Dim message As String = "미분류된 확장처 코드들은 99(기타 기업)으로 설정됩니다."
            If MsgBox(message & vbCrLf & "이전하시겠습니까?", MsgBoxStyle.OkCancel, "미분류 확장처 코드 이전") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManageYear", Me.dtpYear.TextValue)

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE701_3_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Me.RequestData()
            End If
        End Sub


        '====================================================================================================
        ' ��¹�
        '====================================================================================================
        Public Sub ExportData()

            'Dim AsqlParameters() As SqlParameter = Nothing
            'Dim AformulaParameters() As SqlParameter = Nothing

            'With GmainCommonFunction
            '    .SetSqlParameter(AsqlParameters, "@AAllowanceYearMonth", Me.dtpYear.TextValue)
            '    .SetExportCrystalDataParameter("PNE701.rpt", "PNE701_C_R", "", AsqlParameters, AformulaParameters)
            'End With

        End Sub

        '====================================================================================================
        'Validation Check
        '====================================================================================================
        Public Function Validation() As Boolean

        End Function

    End Class

End Namespace
