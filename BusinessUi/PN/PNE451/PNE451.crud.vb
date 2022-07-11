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

    Partial Class PNE451

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
            'If grd_2.Focused = True Then
            '    Me.NewData_2()
            '    Exit Sub
            'End If
            'Me.grd_1.AddRow()
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

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYear", Me.dtpBaseYear.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.Text)
                .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", Me.popEmployeeExpNum_R.Text)
                .SetSqlParameter(GmainsqlParameters, "@ABillType", Me.cboBillType_R.TextValue)  '' û������ [2505]
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE451_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                SetSubTotal()
            End With

        End Sub

        '�׸��� �հ��� �߰�
        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

                    If chkSumView.Checked Then
                        .Tree.Column = .get_ColIndex("CompanyCd")
                        ' '' =============================================================================
                        '' '' '' Ȯ��ó ���� �߰�
                        ' '' =============================================================================
                        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue

                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("CompanyCd"), "Ȯ��ó:{0}")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("FixedPaperNum"), "Ȯ��ó:{0}")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("Amount_A"), "Ȯ��ó:{0}")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("Amount_B"), "Ȯ��ó:{0}")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("Amount_C"), "Ȯ��ó:{0}")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("Amount_D"), "Ȯ��ó:{0}")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("Amount_E"), "Ȯ��ó:{0}")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("Amount_F"), "Ȯ��ó:{0}")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("Amount_G"), "Ȯ��ó:{0}")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("CompanyCd"), .get_ColIndex("Amount_H"), "Ȯ��ó:{0}")
                    End If

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amount_A"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amount_B"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amount_C"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amount_D"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amount_E"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amount_F"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amount_G"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amount_H"), "�հ�")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("EmployeeNameHangul"), "��  ��")
                    Me.grd_1.FrozenRows = 1
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

            'GmainsqlParameters = Nothing
            'With GmainCommonFunction
            '    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE451_CUD", True, False, GmainsqlParameters)
            '    .SetAllBusinessUiInitialValue(Me)
            '    '' .SaveDataMessage(Me)
            'End With
            'If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '    GmainCommonFunction.SaveDataMessage(Me)
            'Else
            '    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'End If

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

            'Dim result As DialogResult
            'result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            'If result = DialogResult.OK Then   '' Result Start
            '    GmainsqlParameters = Nothing
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE451_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '        '' .SaveDataMessage(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            'End If   '' Result end

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
            ' ''Dim AsqlParameters() As SqlParameter = Nothing
            ' ''If optExpAmt1.Checked = True Then
            ' ''    With GmainCommonFunction
            ' ''        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
            ' ''        '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            ' ''        'Dim AAAA As String = ""
            ' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' ''        .SetExportCrystalDataParameter("PNI201_1_C_R.rpt", "PNI201_1_C_R", "", AsqlParameters, AformulaParameters)
            ' ''    End With

            ' ''ElseIf optExpAmt2.Checked = True Then

            ' ''    With GmainCommonFunction
            ' ''        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
            ' ''        '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            ' ''        'Dim AAAA As String = ""
            ' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' ''        .SetExportCrystalDataParameter("PNI201_2_C_R.rpt", "PNI201_2_C_R", "", AsqlParameters, AformulaParameters)
            ' ''    End With
            ' ''ElseIf optExpAmt3.Checked = True Then

            ' ''    With GmainCommonFunction
            ' ''        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
            ' ''        '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            ' ''        'Dim AAAA As String = ""
            ' ''        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            ' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            ' ''        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            ' ''        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            ' ''        .SetExportCrystalDataParameter("PNI201_3_C_R.rpt", "PNI201_3_C_R", "", AsqlParameters, AformulaParameters)
            ' ''    End With
            ' ''End If

        End Sub

    End Class

End Namespace
