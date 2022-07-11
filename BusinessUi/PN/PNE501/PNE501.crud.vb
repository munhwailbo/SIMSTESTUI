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

    Partial Class PNE501

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
            dtpProcYM_R.Text = Now.ToString
            numBaseDay_R.TextValue = 14

            grd_2.Rows = grd_2.FixedRows
            grd_1.Rows = grd_1.FixedRows

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

            grd_1.Rows = grd_1.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AprocYM", Me.dtpProcYM_R.TextValue)    ' ��п�
                .SetSqlParameter(GmainsqlParameters, "@AbaseDay", Me.numBaseDay_R.TextValue)   ' ������ (��������� ���� �߰��� 14�Ϸ� ��)
                .SetSqlParameter(GmainsqlParameters, "@AbranchCd", Me.popBranchCd_R.TextValue)   ' ����
                .SetSqlParameter(GmainsqlParameters, "@AcompanyCd", Me.popCompanyCd_R.TextValue)   ' ����ó
                .SetSqlParameter(GmainsqlParameters, "@AemployeeExpNum", Me.popEmployeeExpNum_R.TextValue)   ' ������ȣ
                .SetSqlParameter(GmainsqlParameters, "@AbillDivCd", Me.cboBillDivCd_R.TextValue)   ' ����(��������) D1:�Ǹ�(��꼭) , D2:���� , D3:�Ǹ�(��+��)
                .SetSqlParameter(GmainsqlParameters, "@AallChek", IIf(chkAll.Checked, "1", "2"))   ' ����(��������) D1:�Ǹ�(��꼭) , D2:���� , D3:�Ǹ�(��+��)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE501_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            'If Chkreceipt.Checked = True Then
            '    Call ExportData()
            'ElseIf ChkMonitor.Checked = True Then
            '    Call ExportData_2()
            'End If
            Call SetSubTotal()
        End Sub
        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue


                    ' '' =============================================================================
                    '' '' '' �׸��� �հ��� �߰�
                    ' '' =============================================================================
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Cnt"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("diffPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amt"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DeductAmt"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TransferAmt"), "��  ��")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("BillDivCd"), "    ��  ��")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            grd_2.Rows = grd_2.FixedRows
            With GmainCommonFunction

                '.SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum").ToString.Substring(0, 8))
                '.SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum").ToString.Substring(0, 8))

                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.grd_1.GetCurrentRowCellValue("EmployeeExpDt"))
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.grd_1.GetCurrentRowCellValue("EmployeeExpDt"))

                .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", "1")   '���� ����:1.�������, 2.��������, 0.      
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", "")                      '������(�μ�)
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.grd_1.GetCurrentRowCellValue("BranchCd"))        '���� 
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.grd_1.GetCurrentRowCellValue("CompanyCd"))               'Ȯ��ó 
                .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))          '������ȣ 2017.12.28 �ǰ�� �߰� 
                .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", "")                  '�������  
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", "")         '���ڻ��� 
                .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", "")               'û�� ���

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", "")       '����ó 
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", "")                '���� ������  
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", "")           '���� ��
                .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", "")   '����� ���
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", "")  '������������
                .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", "")

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            Call SetSubTotal2()
            'Call SetSubTotal()
        End Sub
        Private Sub SetSubTotal2()
            With Me.grd_2
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum1"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SubscribePagerNum"), "�հ�")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "��   ��")
                    Me.grd_2.FrozenRows = 1
                End If
            End With
        End Sub
        'gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;20;#,##0;c;" & "o;n;n;10;"       '(230)���Ժμ�
        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)

            Dim RowCount As Integer = 0
            ''rowcount = me.grd_1.ge
            'GmainsqlParameters = Nothing
            'With GmainCommonFunction
            '    .SetSqlParameter(GmainsqlParameters, "@ABizDt", Me.dtpBizDt.TextValue)
            '    .SetSqlParameter(GmainsqlParameters, "@AprocGb", "2") '�ű�
            '    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE501_R", False, True, GmainsqlParameters)
            '    Me.grd_1.SetDataSet(reciveDataSet)
            '    reciveDataSet = Nothing
            '    .SetAllBusinessUiInitialValue(Me)

            '    Dim intII As Integer
            '    For intII = 1 To grd_1.Rows - grd_1.FixedRows
            '        grd_2.set_TextMatrix(intII, 0, "�ű�")
            '        Me.grd_2.SetCellCheck(intII, Me.grd_1.get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
            '    Next

            '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            '    If AprocessMessage = True Then .RequestDataMessage(Me)

            '    ''''Me.GrdSetColor()
            'End With

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

            Dim RowCount As Integer = 0

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE501_CUD", True, False, GmainsqlParameters)
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
            Dim RowCount As Integer = 0

            ''Dim result As DialogResult
            ''result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            ''If result = DialogResult.OK Then   '' Result Start
            ''    GmainsqlParameters = Nothing
            ''    With GmainCommonFunction
            ''        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            ''        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE501_CUD", True, False, GmainsqlParameters)
            ''        .SetAllBusinessUiInitialValue(Me)
            ''        '' .SaveDataMessage(Me)
            ''    End With
            ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ''        MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''    Else
            ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''    End If
            ''End If   '' Result end

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

            'Dim AsqlParameters() As SqlParameter = Nothing
            'If optreceipt.Checked = True Then
            '    With GmainCommonFunction

            '        ' .SetSqlParameter(AsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)
            '        .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            '        .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            '        'Dim AAAA As String = ""
            '        'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            '        Dim AformulaParameters() As SqlParameter = Nothing

            '        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            '        .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            '        ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            '        .SetExportCrystalDataParameter("PNE501_1_C_R.rpt", "PNE501_1_C_R", "", AsqlParameters, AformulaParameters)

            '    End With

            'ElseIf optMonitor.Checked = True Then
            'With GmainCommonFunction
            '    ''.SetSqlParameter(AsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))   ' ��� Ȯ�� ��ȣ
            '    '.SetSqlParameter(AsqlParameters, "@AContactPaperNum", Me.grd_1.GetCurrentRowCellValue("FixedPaperNum"))  'Ȯ�� �μ�
            '    .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            '    .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            '    'Dim AAAA As String = ""
            '    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            '    Dim AformulaParameters() As SqlParameter = Nothing

            '    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            '    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            '    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            '    .SetExportCrystalDataParameter("PNE501_2_C_R.rpt", "PNE501_2_C_R", "", AsqlParameters, AformulaParameters)

            'End With

            'End If
          

        End Sub
    
    End Class

End Namespace
