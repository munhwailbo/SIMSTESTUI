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

    Partial Class PNE301

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

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AdeliveryBranchCd", Me.popDeliveryBranchCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_R", False, True, GmainsqlParameters)
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
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPagerNum"), "��  ��")


                    .set_TextMatrix(.FixedRows, .get_ColIndex("ExpandDivCd"), "    ��  ��")
                    Me.grd_1.FrozenRows = 1
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
            '    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_R", False, True, GmainsqlParameters)
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

            ''GmainsqlParameters = Nothing
            ''With GmainCommonFunction
            ''    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            ''    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_CUD", True, False, GmainsqlParameters)
            ''    .SetAllBusinessUiInitialValue(Me)
            ''    '' .SaveDataMessage(Me)
            ''End With
            ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ''    GmainCommonFunction.SaveDataMessage(Me)
            ''Else
            ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''End If

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
            ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_CUD", True, False, GmainsqlParameters)
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
            '        .SetExportCrystalDataParameter("PNE301_1_C_R.rpt", "PNE301_1_C_R", "", AsqlParameters, AformulaParameters)

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
            '    .SetExportCrystalDataParameter("PNE301_2_C_R.rpt", "PNE301_2_C_R", "", AsqlParameters, AformulaParameters)

            'End With

            'End If
          

        End Sub
    
    End Class

End Namespace
