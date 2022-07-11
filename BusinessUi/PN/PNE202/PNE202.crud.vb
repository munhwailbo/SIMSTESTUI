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

    Partial Class PNE202

        ''' <summary>
        ''' �Լ��� : NewData 
        ''' ��  �� : �ű� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()
            Me.grd_1.AddRow()
        End Sub
        ''' <summary>
        ''' �Լ��� : RequestData
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFromPayYearMonths", Me.dtpFromPayYearMonths.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AToPayYearMonths", Me.dtpToPayYearMonths.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.popTrAdEmployeeNum.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptCode", Me.popDeptName.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AprocGb", "1")   ' ó������ 1:��ȸ, 2:�ű�

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            If reciveDataSet.Tables(0).Rows(0).Item("CloseYesOrNo") = True Then
                Me.btnApplyClose.Enabled = False
                Me.btnCancelClose.Enabled = True
                Me.btnCreateSale.Enabled = False
            Else
                Me.btnApplyClose.Enabled = True
                Me.btnCancelClose.Enabled = False
                Me.btnCreateSale.Enabled = True
            End If


            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
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
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ExpPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewStopPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReStopPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewRealPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReRealPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpAmount"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpAmountBelow50"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpAmountBelow100"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpAmountAbove101"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SupportAmt"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("IncomeTax"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("InhabitantsTax"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SumTax"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ExpAmount"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("OneMillionWon"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("HundredThousandWon"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TenThousandWon"), "��  ��")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("PayYearMonths"), "��   ��")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        'gridAttributes = gridAttributes & "|�ű�Ȯ��μ�;NewExpPaperNum;90;#,##0;c;" & "o;n;n;4;"    '(70) �ű�Ȯ��μ�
        '   gridAttributes = gridAttributes & "|��Ȯ��μ�;ReExpPaperNum;90;#,##0;c;" & "o;n;n;4;"       '(70) ��Ȯ��μ�
        '   gridAttributes = gridAttributes & "|Ȯ��μ���;ExpPaperNum;90;#,##0;c;" & "o;n;n;4;"         '(70) Ȯ��μ���
        '   gridAttributes = gridAttributes & "|�����μ�;StopPaperNum;90;#,##0;c;" & "o;n;n;4;"          '(70) �����μ�
        '   gridAttributes = gridAttributes & "|����μ�;RealPaperNum;90;#,##0;c;" & "o;n;n;4;"          '(70) �����μ�
        'gridAttributes = gridAttributes & "|�������;SupportAmt;90;#,##0;r;" & "o;n;n;4;"      '(70) �������
        '          gridAttributes = gridAttributes & "|�ҵ漼;IncomeTax;90;#,##0;r;" & "o;n;n;4;"           '(70) ��õ�� - �ҵ漼
        '          gridAttributes = gridAttributes & "|�ֹμ�;InhabitantsTax;90;#,##0;r;" & "o;n;n;4;"      '(70) ��õ�� - �ֹμ�
        '          gridAttributes = gridAttributes & "|Ȯ���ݾ�;ExpAmount;90;#,##0;r;" & "o;n;n;4;"        '(70) Ȯ���(�����޾�)
        'Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)

        '    GmainsqlParameters = Nothing
        '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APayYearMonths", Me.dtpPayYearMonths.TextValue)
        '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AprocGb", "2")   ' ó������ 1:��ȸ, 2:�ű�

        '    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_R", False, True, GmainsqlParameters)
        '    Me.grd_1.SetDataSet(reciveDataSet)
        '    reciveDataSet = Nothing

        '    Dim intII As Integer
        '    For intII = 1 To grd_1.Rows - grd_1.FixedRows
        '        grd_1.set_TextMatrix(intII, 0, "�ű�")
        '        Me.grd_1.SetCellCheck(intII, Me.grd_1.get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
        '    Next

        '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        '    If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        'End Sub

        'Private Sub SetSubTotal()
        '    '' ''With Me.grd_1
        '    '' ''    If .Rows > .FixedRows Then
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
        '    '' ''        .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
        '    '' ''        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
        '    '' ''        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("UnColAmt"), "�հ�")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SalesAmt"), "�հ�")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TotalDemandAmt"), "�հ�")

        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNumTot"), "�հ�")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NoValPaperNumTot"), "�հ�")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum1"), "�հ�")

        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale1"), "�հ�")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum2"), "�հ�")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale2"), "�հ�")

        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum3"), "�հ�")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale3"), "�հ�")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum4"), "�հ�")

        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale4"), "�հ�")




        '    '' ''        .set_TextMatrix(.FixedRows, .get_ColIndex("CollectYYYYMM"), "��   ��")
        '    '' ''        Me.grd_1.FrozenRows = 1
        '    '' ''    End If
        '    '' ''End With
        'End Sub

        '====================================================================================================
        Public Sub SaveData()

            Dim message As String = "���� �ڷḦ ���� �� ����� ó�� �մϴ�."
            If MsgBox(message & vbCrLf & "ó�� �Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "1")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpPayYearMonths.TextValue)  ' ���Ȯ��� ���� ���
                ''''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_CUD", True, False, GmainsqlParameters)


                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                    RequestData()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            End If

        End Sub

        Public Sub SaveData_2(ByVal RecordProcessMode As String)

            If MsgBox("ó�� �Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", RecordProcessMode)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpReversionYearMonth.TextValue)  '����ó������

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_2_CUD", True, False, GmainsqlParameters)


                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                    RequestData()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            ' ''If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

            ' ''    GmainsqlParameters = Nothing

            ' ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            ' ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            ' ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_CUD", True, False, GmainsqlParameters)

            ' ''    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            ' ''    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ''End If

        End Sub

    End Class

End Namespace
