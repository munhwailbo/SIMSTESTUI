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

    Partial Class PNI104

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
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)  ' ���� ���� ���� ���
                .SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", Me.popChargeEmpNum.TextValue)  ' ��ȸ ���� ���

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI104_R", False, True, GmainsqlParameters)
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
                    .Tree.Column = .get_ColIndex("ChargeEmpNm")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData    '' 'BelowData   '' AboveData

                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue

                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

                    ' '' =============================================================================
                    '' '' '' �׸��� �� �Ұ��� �߰�
                    ' '' =============================================================================
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ValPaperNumT"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("SalesAmt"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("NoValPaperNum"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("PaperNumT"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ValPaperNum1"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ValPaperSale1"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ValPaperNum2"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ValPaperSale2"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ValPaperNum3"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ValPaperSale3"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ValPaperNum4"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ValPaperSale4"), "{0} �Ұ�")
                    ' '' =============================================================================


                    ' '' =============================================================================
                    '' '' '' �׸��� �հ��� �߰�
                    ' '' =============================================================================
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNumT"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SalesAmt"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NoValPaperNum"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PaperNumT"), "�հ�")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum1"), "�հ�")
                    '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperUnit1"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale1"), "�հ�")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum2"), "�հ�")
                    '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperUnit2"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale2"), "�հ�")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum3"), "�հ�")
                    '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperUnit3"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale3"), "�հ�")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum4"), "�հ�")
                    '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperUnit4"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale4"), "�հ�")
                    ' '' =============================================================================
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        '====================================================================================================
        Public Sub SaveData()

            ''Dim message As String = "���� �ڷḦ ���� �� ����� ó�� �մϴ�."
            ''If MsgBox(message & vbCrLf & "ó�� �Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then
            ''    GmainsqlParameters = Nothing

            ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "1")
            ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)  ' ���� ���� ���� ���
            ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

            ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI104_CUD", True, False, GmainsqlParameters)

            ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ''        GmainCommonFunction.SaveDataMessage(Me)
            ''        GmainCommonFunction.GRequestDataNumber = 1
            ''    Else
            ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''    End If

            ''    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            ''End If

        End Sub

        Public Sub DeleteData()

        End Sub
        Public Sub ExportData()

            Dim AsqlParameters() As SqlParameter = Nothing

            With GmainCommonFunction
                .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)  ' ���� ���� ���� ���
                .SetSqlParameter(AsqlParameters, "@AChargeEmpNum", Me.popChargeEmpNum.TextValue)  ' ��ȸ ���� ���

                'Dim AAAA As String = ""
                'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                Dim AformulaParameters() As SqlParameter = Nothing

                'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                .SetExportCrystalDataParameter("PNI104_1_C_R.rpt", "PNI104_1_C_R", "", AsqlParameters, AformulaParameters)
            End With

        End Sub
    End Class

End Namespace
