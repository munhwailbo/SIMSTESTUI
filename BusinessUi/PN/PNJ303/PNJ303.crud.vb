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

    Partial Class PNJ303

        ''' <summary>
        ''' �Լ��� : NewData 
        ''' ��  �� : �ű� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()

            If grd_1.Rows > 1 Then
                Me.grd_2.AddRow()
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CalYearMonths"), Me.grd_1.GetCurrentRowCellValue("DmdYYMM"))
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CouponCorpCd"), Me.grd_1.GetCurrentRowCellValue("CouponCorpCd"))
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CouponCorpNm"), Me.grd_1.GetCurrentRowCellValue("CouponCorpNm"))
                ' ''grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CompanyCd"), Me.grd_1.GetCurrentRowCellValue("CompanyCd"))
                ' ''grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CompanyNm"), Me.grd_1.GetCurrentRowCellValue("CompanyNm"))
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("DisYearMonths"), IIf(dtpBaseDt_R.TextValue.ToString.Length < 1, "", dtpBaseDt_R.TextValue))
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("DisYearMonths2"), IIf(dtpBaseDt_R.TextValue.ToString.Length < 1, "", dtpBaseDt_R.TextValue))
            End If

        End Sub
        ''' <summary>
        ''' �Լ��� : RequestData
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            'Dim sdate As String
            'sdate = dtpBaseYear.TextValue.Substring(0, 4) + "01"

            Dim chkState As String = ""
            If chkDmd1.Checked And chkDmd2.Checked = False Then chkState = "1"
            If chkDmd1.Checked = False And chkDmd2.Checked Then chkState = "2"
            If chkDmd1.Checked And chkDmd2.Checked Then chkState = "3"

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYYMM", Me.dtpBaseDt_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpBaseDt2_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ADmdYMFr", IIf(Me.dtpDmdYMFr.Enabled, Me.dtpDmdYMFr.TextValue, ""))
                .SetSqlParameter(GmainsqlParameters, "@ADmdYMTo", IIf(Me.dtpDmdYMTo.Enabled, Me.dtpDmdYMTo.TextValue, ""))
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.popCouponCorpCd_R.Text)
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", chkState)    '' 1:û���ϷḸ����,  2:��û��������, 3:��ü
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : RequestData2
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            'Dim sdate As String
            'sdate = dtpBaseYear.TextValue.Substring(0, 4) + "01"

            If grd_1.Rows <= grd_1.FixedRows Then Exit Sub

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.grd_1.GetCurrentRowCellValue("DmdYYMM"))
                .SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpBaseDt2_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.grd_1.GetCurrentRowCellValue("CouponCorpCd"))
                .SetSqlParameter(GmainsqlParameters, "@ABaseYYMM", Me.dtpBaseDt_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", "1")       '' 1:��ȸ, 2:�ű�
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_2_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            Call SetSubTotal_2()

        End Sub

        ''' <summary>
        ''' �Լ��� : RequestData2
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)
            'Dim sdate As String
            'sdate = dtpBaseYear.TextValue.Substring(0, 4) + "01"

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.grd_1.GetCurrentRowCellValue("DmdYYMM"))
                .SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpBaseDt2_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.grd_1.GetCurrentRowCellValue("CouponCorpCd"))
                .SetSqlParameter(GmainsqlParameters, "@ABaseYYMM", Me.dtpBaseDt_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", "2")       '' 1:��ȸ, 2:�ű�
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_2_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            Dim intII As Integer
            For intII = 1 To grd_2.Rows - grd_2.FixedRows
                grd_2.set_TextMatrix(intII, 0, "�ű�")
                Me.grd_2.SetCellCheck(intII, Me.grd_2.get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
            Next

            Call SetSubTotal_2()
        End Sub

        '�׸��� �հ��� �߰�
        Private Sub SetSubTotal_2()
            With Me.grd_2
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PaperNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SubscriptionAmt"), "�հ�")
                    ''.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DistributionAmt"), "�հ�")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("BranchNum"), "��   ��")
                    Me.grd_2.FrozenRows = 1
                End If
            End With
        End Sub

        ''' <summary>
        ''' �Լ��� : SaveData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub
        ''' <summary>
        ''' �Լ��� : DeleteData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If   '' Result end

        End Sub
        ''' <summary>
        ''' �Լ��� : ExportData 
        ''' ��  �� : ���
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ExportData()
            '' '' '' '' ''Dim AsqlParameters() As SqlParameter = Nothing
            '' '' '' '' ''If optExpAmt1.Checked = True Then
            '' '' '' '' ''    With GmainCommonFunction
            '' '' '' '' ''        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
            '' '' '' '' ''        '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            '' '' '' '' ''        'Dim AAAA As String = ""
            '' '' '' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            '' '' '' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            '' '' '' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            '' '' '' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            '' '' '' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            '' '' '' '' ''        .SetExportCrystalDataParameter("PNI201_1_C_R.rpt", "PNI201_1_C_R", "", AsqlParameters, AformulaParameters)
            '' '' '' '' ''    End With

            '' '' '' '' ''ElseIf optExpAmt2.Checked = True Then

            '' '' '' '' ''    With GmainCommonFunction
            '' '' '' '' ''        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
            '' '' '' '' ''        '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            '' '' '' '' ''        'Dim AAAA As String = ""
            '' '' '' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            '' '' '' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            '' '' '' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            '' '' '' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            '' '' '' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            '' '' '' '' ''        .SetExportCrystalDataParameter("PNI201_2_C_R.rpt", "PNI201_2_C_R", "", AsqlParameters, AformulaParameters)
            '' '' '' '' ''    End With
            '' '' '' '' ''ElseIf optExpAmt3.Checked = True Then

            '' '' '' '' ''    With GmainCommonFunction
            '' '' '' '' ''        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
            '' '' '' '' ''        '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            '' '' '' '' ''        'Dim AAAA As String = ""
            '' '' '' '' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            '' '' '' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            '' '' '' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            '' '' '' '' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            '' '' '' '' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            '' '' '' '' ''        .SetExportCrystalDataParameter("PNI201_3_C_R.rpt", "PNI201_3_C_R", "", AsqlParameters, AformulaParameters)
            '' '' '' '' ''    End With
            '' '' '' '' ''End If

        End Sub

    End Class

End Namespace
