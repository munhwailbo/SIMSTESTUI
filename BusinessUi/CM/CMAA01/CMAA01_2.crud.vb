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

Namespace ubiLease.UI.BusinessUi.CM

    Partial Class CMAA01

        '====================================================================================================
        Public Sub NewData_2()
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            Dim strSEQ As String = ""
            strSEQ = Me.grd_1.GetCurrentRowCellValue("SEQ")

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@SEQ", IIf(strSEQ = "|", 0, Me.grd_1.GetCurrentRowCellValue("SEQ")))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("CM","CMAA01_2_R", False, True, GmainsqlParameters)
            GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub SaveData()
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@recordProcessMode", GrecordProcessMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@SEQ", Me.numSEQ.Text)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@SEQ", (GmainsqlParameters(1).SqlValue.Value())
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Title", Me.txtTitle.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Content", Me.txtContent.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RestrationIP", "222.110.75.234")
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RestrationIP", GmainExecuteDbCommand.localIPAddress())
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AnnouncementYesOrNo", Me.chkAnounceYesOrNo.Checked)

            GmainExecuteDbCommand.ExecuteStoredProcedure("CM","CMAA01_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)


        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@recordProcessMode", "3")
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@SEQ", Me.numSEQ.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Title", Me.txtTitle.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Content", Me.txtContent.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RestrationIP", "222.110.75.234")
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RestrationIP", GmainExecuteDbCommand.localIPAddress())
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AnnouncementYesOrNo", True) 'Me.chkAnounceYesOrNo.Checked)

            GmainExecuteDbCommand.ExecuteStoredProcedure("CM","CMAA01_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)

            txtTitle.Text = ""
            txtContent.Text = ""

        End Sub

    End Class

End Namespace
