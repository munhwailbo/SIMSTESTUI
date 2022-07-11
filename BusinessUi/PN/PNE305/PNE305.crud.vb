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
    Partial Class PNE305

        '====================================================================================================
        Public Sub NewData()

            Me.grd_1.AddRow()
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("ExpandDt"), dtpFromExpand.Text)

            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("TargetPaperTotNum"), "0")    '|�����μ�
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NewExpPapNum"), "0")         '|�űԺμ�
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("ReExpPapNum"), "0")          '|��Ȯ��μ�
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NoListPapNum"), "0")         '|��ܾ��ºμ�
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedPaperNum"), "0")        '|Ȯ���μ�
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("SubscribePagerNum"), "0")    '|���Ժμ�
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NoSubscribePagerNum"), "0")  '|�����Ժμ�

            'If grd_1.GetCurrentRowCellValue("CollectionDivCd") = "2" Then

            '    Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedStDt"), DateAdd(DateInterval.Day, -1, sdate))
            '    Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, sdate))))

            'End If

        End Sub


        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFromExpandDt", Me.dtpFromExpand.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AToExpandDt", Me.dtpToExpand.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.Text)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE305_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            Call SetSubTotal()
        End Sub
        Private Sub SetSubTotal()
            '    With Me.grd_1
            '        If .Rows > .FixedRows Then

            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
            '            .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
            '            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
            '            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue


            '            ' '' =============================================================================
            '            '' '' '' �׸��� �հ��� �߰�
            '            ' '' =============================================================================
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "��  ��")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPapNum"), "��  ��")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum"), "��  ��")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NoListPapNum"), "��  ��")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "��  ��")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SubscribePagerNum"), "��  ��")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NoSubscribePagerNum"), "��  ��")
            '            .set_TextMatrix(.FixedRows, .get_ColIndex("ExpandDt"), "��   ��")
            '            Me.grd_1.FrozenRows = 1
            '        End If
            '    End With
        End Sub
        '            gridAttributes = gridAttributes & "|�����μ�;TargetPaperTotNum;60;;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|�űԺμ�;NewExpPapNum;60;;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|��Ȯ��μ�;ReExpPapNum;60;;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|��ܾ��ºμ�;NoListPapNum;60;#,###;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;60;#,###;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|���Ժμ�;SubscribePagerNum;60;#,###;r;" & "o;n;n;5;"
        '            gridAttributes = gridAttributes & "|�����Ժμ�;NoSubscribePagerNum;60;#,###;r;" & "o;n;n;5;"
        '====================================================================================================


        '====================================================================================================

        '====================================================================================================
        Public Sub SaveData()


            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE305_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                GmainsqlParameters = Nothing

                GmainExecuteDbCommand.GerrorNumber = 1
                GmainExecuteDbCommand.GerrorDescription = "�������"
            End If

        End Sub


        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE305_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)

            End If

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

            With GmainCommonFunction
                .SetSqlParameter(AsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))   ' ��� Ȯ�� ��ȣ
                .SetSqlParameter(AsqlParameters, "@AContactPaperNum", Me.grd_1.GetCurrentRowCellValue("FixedPaperNum"))  'Ȯ�� �μ�


                'Dim AAAA As String = ""
                'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                Dim AformulaParameters() As SqlParameter = Nothing

                'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                .SetExportCrystalDataParameter("PNE305_1_C_R.rpt", "PNE305_1_C_R", "", AsqlParameters, AformulaParameters)

            End With

        End Sub

        ''���� ������ ��� ���� , ���� ���� ��¥ ����
        'Private Sub grd_1_CellChanged(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.CellChanged

        '    Dim sdate As Date

        '    sdate = IIf(grd_1.GetCurrentRowCellValue("ExpandDt") = "" Or grd_1.GetCurrentRowCellValue("ExpandDt"), dtpFromExpand.Text, grd_1.GetCurrentRowCellValue("ExpandDt"))


        '    'If sdate <> "" And grd_1.GetCurrentRowCellValue("CollectionDivCd") = "2" Then
        '    '    If grd_1.GetCurrentRowCellValue("FixedStDt") <> "" Or grd_1.GetCurrentRowCellValue("FixedEdDt") <> "" Then

        '    '        Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedStDt"), DateAdd(DateInterval.Day, -1, sdate))
        '    '        Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, sdate))))

        '    '    End If
        '    'End If


        'End Sub

    End Class

End Namespace
