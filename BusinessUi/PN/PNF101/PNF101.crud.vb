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

    Partial Class PNF101

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
            Me.grd_1.AddRow()
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("BaseYear"), Me.dtpBaseYear.TextValue)

            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("JanGoalPapeNum"), "0")   '' 1����ǥ�μ�   
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FebGoalPaperNum"), "0")   '' 2����ǥ�μ�   
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("MarGoalPaperNum"), "0")   '' 3����ǥ�μ�   
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("AprGoalPaperNum"), "0")   '' 4����ǥ�μ�   
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("MayGoalPaperNum"), "0")   '' 5����ǥ�μ�   
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("JunGoalPaperNum"), "0")   '' 6����ǥ�μ�   
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("JulGoalPaperNum"), "0")   '' 7����ǥ�μ�   
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("AugGoalPaperNum"), "0")   '' 8����ǥ�μ�   
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("SepGoalPaperNum"), "0")   '' 9����ǥ�μ�   
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("OctGoalPaperNum"), "0")   '' 10����ǥ�μ�  
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NovGoalPaperNum"), "0")   '' 11����ǥ�μ�  
            grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("DecGoalPaperNum"), "0")   '' 12����ǥ�μ�  
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

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYear", Me.dtpBaseYear.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", Me.popChargeEmpNum.TextValue)   ' �������
                .SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)  '�������
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", "1")   '1:��ȸ , 2:�ű�
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNF101_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            Call SetSubTotal()
        End Sub

        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Tree.Column = .get_ColIndex("TreePath")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData    '' 'BelowData   '' AboveData

                    '' =========================================================================
                    ''    ����
                    '' =========================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue
                    For intII As Integer = .get_ColIndex("GoalPaperNum") To .get_ColIndex("DecGoalPaperNum")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), intII, "{0} �Ұ�")
                    Next

                    '' =========================================================================
                    ''    ��ü��
                    '' =========================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    For intII As Integer = .get_ColIndex("GoalPaperNum") To .get_ColIndex("DecGoalPaperNum")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, intII, "�հ�")
                    Next
                    Me.grd_1.FrozenRows = 1

                End If
            End With
        End Sub

        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYear", Me.dtpBaseYear.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", Me.popChargeEmpNum.TextValue)   ' �������
                .SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)  '�������
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", "2")    '1:��ȸ , 2:�ű�
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNF101_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            Dim intII As Integer
            For intII = 1 To grd_1.Rows - grd_1.FixedRows
                grd_1.set_TextMatrix(intII, 0, "�ű�")
                Me.grd_1.SetCellCheck(intII, Me.grd_1.get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
            Next

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
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNF101_CUD", True, False, GmainsqlParameters)
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
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNF101_CUD", True, False, GmainsqlParameters)
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

            Dim AsqlParameters() As SqlParameter = Nothing
            If optReceipt.Checked = True Then

                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABaseYear", Me.dtpBaseYear.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AChargeEmpNum ", Me.popChargeEmpNum.TextValue)
                    .SetSqlParameter(AsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNF101_C_R.rpt", "PNF101_C_R", "", AsqlParameters, AformulaParameters)
                End With

            ElseIf optMonPa.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABaseYear", Me.dtpBaseYear.TextValue)
                    '.SetSqlParameter(AsqlParameters, "@AChargeEmpNum ", Me.popChargeEmpNum.TextValue)
                    '.SetSqlParameter(AsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNF101_2_C_R.rpt", "PNF101_2_C_R", "", AsqlParameters, AformulaParameters)
                End With
            End If
        End Sub


    End Class


End Namespace
