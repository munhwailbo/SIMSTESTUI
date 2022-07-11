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

    Partial Class SMCB02

        '====================================================================================================
        Public Sub NewData()
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
            'Me.grd_1.NewData()
            Me.grd_1.AddRow()
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("RoleCode"), Me.cboRoleCode.TextValue)
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProgramID", Me.cboProgramID.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARoleCode", Me.cboRoleCode.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB02_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub SaveData()

            If Me.Validation = True Then
                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB02_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)

                If GmainExecuteDbCommand.GerrorNumber > 0 Then
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GmainExecuteDbCommand.GerrorNumber = 1
                Else
                    GmainCommonFunction.SaveDataMessage(Me)
                End If
            Else
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Sub

            End If
        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB02_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Function Validation() As Boolean

            Validation = False

            If Me.cboRoleCode.TextValue = "" Then
                MessageBox.Show("역할 코드를 반드시 선택해 주세요 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.cboRoleCode.Focus()
                Exit Function
            End If

            Validation = True

        End Function
    End Class

End Namespace
