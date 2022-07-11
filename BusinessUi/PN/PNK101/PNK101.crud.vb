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

Namespace ubiLease.UI.BusinessUi.PN
    Partial Class PNK101

        '====================================================================================================
        Public Sub NewData()
            'Me.grd_1.AddRow()
        End Sub

        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AReaderName", Me.txtReaderName.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchName", Me.txtBranchName.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReaderHp", Me.txtReaderHp.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReaderTel1", Me.txtReaderTel1.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNK101_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub

        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNK101_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub
        Public Sub DeleteData()

            ''If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

            ''    GmainsqlParameters = Nothing

            ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNK101_CUD", True, False, GmainsqlParameters)

            ''    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            ''    GmainCommonFunction.SaveDataMessage(Me)

            ''End If

        End Sub


    End Class

End Namespace
