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

    Partial Class PNJ301

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
            Me.grd_1.AddRow()
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("YYYYMM"), Me.dtpBaseYear.Text)
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("BranchNum"), Me.popBranchNum_R.TextValue)
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("BranchNm"), Me.popBranchNum_R.NameText)
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("PayYYYYMM"), Me.dtpBaseYear.Text)

            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("RedeemPaperNum"), "0")
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("PayTotAmt"), "0")
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("TransferAmt"), "0")
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("DemandCollectCirculation"), "0")
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("DeductAmt"), "0")

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
                .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.popCouponCorpCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.popBranchNum_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGB", "1")
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ301_R", False, True, GmainsqlParameters)
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
                    ''.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    ''.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

                    '' ''For intII As Integer = 0 To 16  '''' .Cols - 11
                    '' ''    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("YYYYMM"), .get_ColIndex("cnt_" & (intII + 1).ToString()), "{0} �Ұ�")
                    '' ''Next
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("RedeemPaperNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PlanDmdAmount"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PreDmdAmount"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NoDmdAmount"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DemandCollectCirculation"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ProcDmdAmount"), "�հ�")
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

            If ValidationCheck() = True Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ301_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                End With

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    GmainCommonFunction.GRequestDataNumber = 1
                End If
            Else
                GmainExecuteDbCommand.GerrorNumber = 1
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

            If MessageBox.Show("�����͸� ���� �Ͻðڽ��ϱ�? ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ301_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                                    GmainCommonFunction.GRequestDataNumber = 1
            End If

        End Sub


        Public Function ValidationCheck() As Boolean
            ValidationCheck = False

            If Me.grd_1.Rows > 1 Then

                Dim strProcDt As String = ""
                For inti As Integer = 0 To Me.grd_1.Rows - 1
                    If Me.grd_1.GetCellCheck(inti, Me.grd_1.get_ColIndex("����")) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                        strProcDt = Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("ProcDt"))
                        If IsDate(strProcDt) = False Then
                            MessageBox.Show("ó�����ڸ� Ȯ���� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If

                        'If Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("BranchNum")) = "" Then
                        '    MessageBox.Show("������ȣ�� �ݵ�� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Function
                        'End If
                        'If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("RedeemPaperNum"))) = False Then
                        '    MessageBox.Show("ȸ���μ��踦 Ȯ���� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Function
                        'End If
                        'If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("PayTotAmt"))) = False Then
                        '    MessageBox.Show("�������Ѿ��� Ȯ���� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Function
                        'End If
                        'If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("TransferAmt"))) = False Then
                        '    MessageBox.Show("��ü�ݾ��� Ȯ���� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Function
                        'End If
                        If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("DemandCollectCirculation"))) = False Then
                            MessageBox.Show("û��ȸ���μ��� Ȯ���� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                        If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("ProcDmdAmount"))) = False Then
                            MessageBox.Show("û������ Ȯ���� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                    End If
                Next inti
            End If

            ValidationCheck = True
        End Function

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
        End Sub
    End Class

End Namespace
