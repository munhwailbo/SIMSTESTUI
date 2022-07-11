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
        ''' ?�수�?: NewData 
        ''' �? ??: ?�규
        ''' ?�성??: 
        ''' ?�성??: 2012-07-19
        ''' ?�정??: 
        ''' ?�정??: 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()

        End Sub
        ''' <summary>
        ''' ?�수�?: RequestData 
        ''' �? ??: 그리??조회
        ''' ?�성??: 
        ''' ?�성??: 2012-07-19
        ''' ?�정??: 
        ''' ?�정??: 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            If Me.txtCustomerCode_2.TextValue = "" And Me.txtFirmName_2.TextValue = "" And Me.txtBizRegNumber_2.TextValue = "" And Me.txtResRegNumber_2.TextValue = "" _
               And Me.txtRepresentativeName_2.TextValue = "" And Me.cboIndividualBizDivision_2.TextValue = "" And Me.cboCustomerDivision_2.TextValue = "" Then
                MessageBox.Show("�˻� ������ ��� �� �� �̻��� �Է��Ͻʽÿ�.")
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Sub
            End If

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AcustomerCode", Me.txtCustomerCode_2.Text)                            '�ŷ�ó �ڵ�
                .SetSqlParameter(GmainsqlParameters, "@AfirmName", Me.txtFirmName_2.Text)                                    '��ȣ ��
                .SetSqlParameter(GmainsqlParameters, "@AbizRegNumber", Me.txtBizRegNumber_2.Text)                            '����� ��ȣ
                .SetSqlParameter(GmainsqlParameters, "@AresRegNumber", Me.txtResRegNumber_2.Text)                            '�ֹ� ��� ��ȣ
                .SetSqlParameter(GmainsqlParameters, "@ArepresentativeName", Me.txtRepresentativeName_2.Text)                '��ǥ�ڸ�
                .SetSqlParameter(GmainsqlParameters, "@AindividualBizDivision", Me.cboIndividualBizDivision_2.Text)          '����/����� ����
                .SetSqlParameter(GmainsqlParameters, "@AcustomerDivision", Me.cboCustomerDivision_2.Text)                    '�ŷ�ó ����

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNA205_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub
        ''' <summary>
        ''' ?�수�?: SaveData 
        ''' �? ??: ?�??
        ''' ?�성??: 
        ''' ?�성??: 2012-07-19
        ''' ?�정??: 
        ''' ?�정??: 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNA205_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .SaveDataMessage(Me)
            End With

        End Sub
        ''' <summary>
        ''' ?�수�?: DeleteData 
        ''' �? ??: ??��
        ''' ?�성??: 
        ''' ?�성??: 2012-07-19
        ''' ?�정??: 
        ''' ?�정??: 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            'GmainsqlParameters = Nothing

            'With GmainCommonFunction
            '    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그??ID"))
            '    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            '    GmainExecuteDbCommand.ExecuteStoredProcedure("AC", "PNA205_CUD", True, False, GmainsqlParameters)

            '    .SetAllBusinessUiInitialValue(Me)
            '    .DeleteDataMessage(Me)
            'End With

        End Sub
        ''' <summary>
        ''' ?�수�?: ExportData 
        ''' �? ??: 미리보기(출력)
        ''' ?�성??: 
        ''' ?�성??: 2012-07-19
        ''' ?�정??: 
        ''' ?�정??: 
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
            '       'AAAA = "{@?�표ID}=" &"'" & GmainBusinessFunction.GetValue("로그?�ID") & "'" 
            ' 
            '       Dim AformulaParameters() As SqlParameter = Nothing 
            ' 
            '       'GmainCommonFunction.SetSqlParameter(AformulaParameters, "?�표ID", "'" & GmainBusinessFunction.GetValue("로그?�ID") & "'") 
            '       .SetSqlParameter(AformulaParameters, "?�성??, "'" & GmainBusinessFunction.GetValue("로그?�명") & "'") 
            ' 
            '       ' 공통변?�의?�의가?�성?�에발생?�수?�도록유?�한?? 
            '       .SetExportCrystalDataParameter("PNA205.rpt", "PNA205_R", "", AsqlParameters, AformulaParameters) 
            '   End With 

        End Sub

    End Class
 
End Namespace 
 