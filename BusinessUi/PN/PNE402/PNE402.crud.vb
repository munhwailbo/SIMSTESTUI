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

    Partial Class PNE402

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
            Me.popEmployeeNumber.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            Me.popEmployeeNumber.Enabled = GmainBusinessFunction.GetValue("�α��� ID") = "999999"
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
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AbranchNm", Me.txtBranchNm.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE402_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            Call SetSubTotal()
        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AbranchNm", Me.txtBranchNm.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE402_2_R", False, True, GmainsqlParameters)

                Me.grd_2.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
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
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SubscriptionAmt"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DeductAmt"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TransferAmt"), "��  ��")
                
                    .set_TextMatrix(.FixedRows, .get_ColIndex("CalYearMonths"), "��   ��")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        'gridAttributes = gridAttributes & "|�μ�;PaperNum;80;#,##0;c;" & "o;n;n;4;"       '(80)
        '  gridAttributes = gridAttributes & "|�ܰ�;SubsUnitAmt;80;#,##0;c;" & "o;n;n;4;"       '(80)
        '  gridAttributes = gridAttributes & "|������ݱ�����;SubscriptionAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)
        '  gridAttributes = gridAttributes & "|��ü�ݾ�;DeductAmt;80;#,##0;r;" & "io;n;n;4;"       '(80)
        '  gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)

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
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE402_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '' '' '' ������ ��� ����
        '' ''Public Sub SaveData2()

        '' ''    Dim message As String = "���� �ڷḦ ���� �� ����� ó�� �մϴ�."
        '' ''    If MsgBox(message & vbCrLf & "ó�� �Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

        '' ''        GmainsqlParameters = Nothing

        '' ''        GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
        '' ''        GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "1")
        '' ''        GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)
        '' ''        ''''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

        '' ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE402_2_CUD", True, False, GmainsqlParameters)


        '' ''        If GmainExecuteDbCommand.GerrorNumber = 0 Then
        '' ''            GmainCommonFunction.SaveDataMessage(Me)
        '' ''        Else
        '' ''            MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '' ''        End If

        '' ''        GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        '' ''    End If

        '' ''End Sub

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
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE402_CUD", True, False, GmainsqlParameters)
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

         '   Dim AsqlParameters() As SqlParameter = Nothing
         '
         '   With GmainCommonFunction
         '       .SetSqlParameter(AsqlParameters, "@AcodeDivisionHangulName", Me.txtCodeDivisionHangulName.TextValue)
         '       .SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)
         '
         '       'Dim AAAA As String = ""
         '       'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"
         '
         '       Dim AformulaParameters() As SqlParameter = Nothing
         '
         '       'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
         '       .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")
         '
         '       ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
         '       .SetExportCrystalDataParameter("PNE402.rpt", "PNE402_R", "", AsqlParameters, AformulaParameters)
         '   End With

        End Sub

    End Class

End Namespace
