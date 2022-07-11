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

Namespace ubiLease.UI.BusinessUi.CM

    Partial Class CMBB01

        '====================================================================================================
        Public Sub NewData()
            MsgBox("신규 등록이 안됩니다.", MsgBoxStyle.OkOnly)

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbusinessPlaceCode", "")
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbranchCode", "")
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATeamCode", "")
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APartCode", "")
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APCCode", "")
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACornerCode", "")
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACodeAttributeCode", "")

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("CM","CMBB01_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub


        '====================================================================================================
        Public Sub SaveData()

            If Validation() = True Then

                GmainsqlParameters = Nothing
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACodeAttributeCode", Me.cboOrganizationLevel.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("CM","CMBB01_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                GmainExecuteDbCommand.GerrorNumber = 1
            End If
           
        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            MsgBox("삭제 할수 없습니다.", MsgBoxStyle.OkOnly)
        End Sub

        Public Function Validation() As Boolean


            Validation = False

            With Me.grd_1

                If .Rows > 1 Then
                    For inti As Integer = .FixedRows To .Rows - 1
                        If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
                            '프로젝트 ID Validation Check

                            If IsNumeric(.get_TextMatrix(inti, .get_ColIndex("PrintOrder"))) = False Then
                                MessageBox.Show(" 출력 순서를 다시 입력해 주세요  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Function
                            End If

                        End If

                    Next
                End If

            End With

            Validation = True

        End Function

    End Class

End Namespace
