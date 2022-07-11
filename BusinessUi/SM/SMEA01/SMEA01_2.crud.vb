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

    Partial Class SMEA01

        '====================================================================================================
        Public Sub NewData_2()
            'Me.grd_1.AddRow()
            'Me.grd_1.Selection(Me.grd_1.Rows)
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbusinessPlaceCode", Me.grd_1.GetCurrentRowCellValue("BusinessPlaceCode"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEA01_2_R", False, True, GmainsqlParameters)
            GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            Me.popPostNumber.NameText = reciveDataSet.Tables(0).Rows(0)("PostNumberName").ToString()    'SET Address1 
            reciveDataSet = Nothing

            '조회후 수정하지 말아햐 하는 컨트롤들 세팅
            Me.txtBusinessPlaceCode.Enabled = False
            Me.txtTaxOfficeCode.Enabled = False

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub SaveData()
            GmainsqlParameters = Nothing

            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
                .SetSqlParameter(GmainsqlParameters, "@AbusinessPlaceCode", Me.txtBusinessPlaceCode.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AfirmName", Me.txtFirmName_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AbusinessesNumber", Me.txtBusinessesNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AjuridicalPersonNumber", Me.txtJuridicalPersonNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AFiscalYear", Me.dtpFiscalYear.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ArepresentativeName", Me.txtRepresentativeName.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ApostNumber", Me.popPostNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Aaddress1", Me.popPostNumber.NameText)
                .SetSqlParameter(GmainsqlParameters, "@Aaddress2", Me.txtAddress2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AphoneNumber", Me.txtPhoneNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AfaxNumber", Me.txtFaxNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AbusinessConditions", Me.txtBusinessConditions.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Aitem", Me.txtItem.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AupjongCode", Me.txtUpjongCode.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AtaxOfficeCode", Me.txtTaxOfficeCode.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AtaxOfficeName", Me.txtTaxOfficeName.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AhomeTaxID", Me.txtHomeTaxID.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Anote", Me.txtNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEA01_2_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                .SaveDataMessage(Me)
            End With

        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")
                .SetSqlParameter(GmainsqlParameters, "@AbusinessPlaceCode", Me.txtBusinessPlaceCode.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AfirmName", Me.txtFirmName_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AbusinessesNumber", Me.txtBusinessesNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AjuridicalPersonNumber", Me.txtJuridicalPersonNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AFiscalYear", Me.dtpFiscalYear.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ArepresentativeName", Me.txtRepresentativeName.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ApostNumber", Me.popPostNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Aaddress1", Me.popPostNumber.NameText)
                .SetSqlParameter(GmainsqlParameters, "@Aaddress2", Me.txtAddress2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AphoneNumber", Me.txtPhoneNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AfaxNumber", Me.txtFaxNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AbusinessConditions", Me.txtBusinessConditions.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Aitem", Me.txtItem.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AupjongCode", Me.txtUpjongCode.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AtaxOfficeCode", Me.txtTaxOfficeCode.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AtaxOfficeName", Me.txtTaxOfficeName.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AhomeTaxID", Me.txtHomeTaxID.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Anote", Me.txtNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEA01_2_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .SaveDataMessage(Me)

                .ControlNewData(Me, Me.picIo_2)
            End With

        End Sub

    End Class

End Namespace
