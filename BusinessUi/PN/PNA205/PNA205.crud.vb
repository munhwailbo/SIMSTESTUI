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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.AC  
 
    Partial Class PNA205

        ''' <summary>
        ''' ?¨ìˆ˜ëª?: NewData 
        ''' ê¸? ??: ? ê·œ
        ''' ?‘ì„±??: 
        ''' ?‘ì„±??: 2012-07-19
        ''' ?˜ì •??: 
        ''' ?˜ì •??: 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()

        End Sub
        ''' <summary>
        ''' ?¨ìˆ˜ëª?: RequestData 
        ''' ê¸? ??: ê·¸ë¦¬??ì¡°íšŒ
        ''' ?‘ì„±??: 
        ''' ?‘ì„±??: 2012-07-19
        ''' ?˜ì •??: 
        ''' ?˜ì •??: 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            If Me.txtCustomerCode_2.TextValue = "" And Me.txtFirmName_2.TextValue = "" And Me.txtBizRegNumber_2.TextValue = "" And Me.txtResRegNumber_2.TextValue = "" _
               And Me.txtRepresentativeName_2.TextValue = "" And Me.cboIndividualBizDivision_2.TextValue = "" And Me.cboCustomerDivision_2.TextValue = "" Then
                MessageBox.Show("°Ë»ö Á¶°ÇÀº Àû¾îµµ ÇÑ °³ ÀÌ»óÀ» ÀÔ·ÂÇÏ½Ê½Ã¿À.")
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Sub
            End If

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AcustomerCode", Me.txtCustomerCode_2.Text)                            '°Å·¡Ã³ ÄÚµå
                .SetSqlParameter(GmainsqlParameters, "@AfirmName", Me.txtFirmName_2.Text)                                    '»óÈ£ ¸í
                .SetSqlParameter(GmainsqlParameters, "@AbizRegNumber", Me.txtBizRegNumber_2.Text)                            '»ç¾÷ÀÚ ¹øÈ£
                .SetSqlParameter(GmainsqlParameters, "@AresRegNumber", Me.txtResRegNumber_2.Text)                            'ÁÖ¹Î µî·Ï ¹øÈ£
                .SetSqlParameter(GmainsqlParameters, "@ArepresentativeName", Me.txtRepresentativeName_2.Text)                '´ëÇ¥ÀÚ¸í
                .SetSqlParameter(GmainsqlParameters, "@AindividualBizDivision", Me.cboIndividualBizDivision_2.Text)          '°³ÀÎ/»ç¾÷ÀÚ ±¸ºĞ
                .SetSqlParameter(GmainsqlParameters, "@AcustomerDivision", Me.cboCustomerDivision_2.Text)                    '°Å·¡Ã³ ±¸ºĞ

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNA205_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub
        ''' <summary>
        ''' ?¨ìˆ˜ëª?: SaveData 
        ''' ê¸? ??: ?€??
        ''' ?‘ì„±??: 
        ''' ?‘ì„±??: 2012-07-19
        ''' ?˜ì •??: 
        ''' ?˜ì •??: 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("·Î±×ÀÎ ID"))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNA205_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .SaveDataMessage(Me)
            End With

        End Sub
        ''' <summary>
        ''' ?¨ìˆ˜ëª?: DeleteData 
        ''' ê¸? ??: ?? œ
        ''' ?‘ì„±??: 
        ''' ?‘ì„±??: 2012-07-19
        ''' ?˜ì •??: 
        ''' ?˜ì •??: 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            'GmainsqlParameters = Nothing

            'With GmainCommonFunction
            '    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("ë¡œê·¸??ID"))
            '    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            '    GmainExecuteDbCommand.ExecuteStoredProcedure("AC", "PNA205_CUD", True, False, GmainsqlParameters)

            '    .SetAllBusinessUiInitialValue(Me)
            '    .DeleteDataMessage(Me)
            'End With

        End Sub
        ''' <summary>
        ''' ?¨ìˆ˜ëª?: ExportData 
        ''' ê¸? ??: ë¯¸ë¦¬ë³´ê¸°(ì¶œë ¥)
        ''' ?‘ì„±??: 
        ''' ?‘ì„±??: 2012-07-19
        ''' ?˜ì •??: 
        ''' ?˜ì •??: 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ExportData()

            '   Dim AsqlParameters() As SqlParameter = Nothing 
            ' 
            '   With GmainCommonFunction 
            '       .SetSqlParameter(AsqlParameters, "@AcodeDivisionHangulName", Me.txtCodeDivisionHangulName.TextValue) 
            '       .SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue) 
            ' 
            '       'Dim AAAA As String = "" 
            '       'AAAA = "{@?¥í‘œID}=" &"'" & GmainBusinessFunction.GetValue("ë¡œê·¸?¸ID") & "'" 
            ' 
            '       Dim AformulaParameters() As SqlParameter = Nothing 
            ' 
            '       'GmainCommonFunction.SetSqlParameter(AformulaParameters, "?¥í‘œID", "'" & GmainBusinessFunction.GetValue("ë¡œê·¸?¸ID") & "'") 
            '       .SetSqlParameter(AformulaParameters, "?‘ì„±??, "'" & GmainBusinessFunction.GetValue("ë¡œê·¸?¸ëª…") & "'") 
            ' 
            '       ' ê³µí†µë³€?˜ì˜?•ì˜ê°€?ì„±?œì—ë°œìƒ? ìˆ˜?ˆë„ë¡ìœ ?„í•œ?? 
            '       .SetExportCrystalDataParameter("PNA205.rpt", "PNA205_R", "", AsqlParameters, AformulaParameters) 
            '   End With 

        End Sub

    End Class
 
End Namespace 
 