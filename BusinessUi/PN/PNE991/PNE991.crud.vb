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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Partial Class PNE991

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

            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)

            lblRecordState.Text = "�ű�"
            Me.dtpColDt.TextValue = "20081130" '''''System.DateTime.Now
            Me.popProcEmpNum.TextValue = GmainBusinessFunction.GetValue("�α��� ID")

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
            'GmainCommonFunction.ControlNewData(Me, Me.picCriteria_1, Me.picIo_1)

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFromColDt", Me.dtpFromColDt.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AToColDt", Me.dtpToColDt.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd_R.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE991_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

            End With
            Call SetSubTotal()
        End Sub
        '�׸��� �հ��� �߰�
        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ColAmt"), "�հ�")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ColDt"), "��   ��")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            If grd_1.Rows <= grd_1.FixedRows Then Exit Sub
            GmainsqlParameters = Nothing
            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@AColDt", Me.grd_1.GetCurrentRowCellValue("ColDt"))
                .SetSqlParameter(GmainsqlParameters, "@AColOrders", Me.grd_1.GetCurrentRowCellValue("ColOrders"))
                '' .SetSqlParameter(GmainsqlParameters, "@AColOrders", IIf(IsNumeric(Me.grd_1.GetCurrentRowCellValue("ColOrders")) = False, 0, Me.grd_1.GetCurrentRowCellValue("ColOrders")))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE991_2_R", False, True, GmainsqlParameters)
                If reciveDataSet.Tables.Count > 0 Then
                    lblRecordState.Text = "��ȸ"
                    .SetDataSetToControls(reciveDataSet, Me)
                End If

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        Public Sub SaveData()

            ''If Me.txtColOrders.Text = "" Then
            ''    GrecordProcessMode = "1"
            ''Else
            ''    GrecordProcessMode = "2"
            ''End If

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", IIf(lblRecordState.Text = "�ű�", "1", "2"))    '�����ڵ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColDt", Me.dtpColDt.TextValue)  '' �Ա�����    
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColOrders", Me.numColOrders.TextValue)  '' �Աݼ���     
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColTypeCd", Me.cboColTypeCd.TextValue)  '' �Աݱ����ڵ� 
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColBankCd", Me.cboColBankCd.TextValue)  '' �Ա������ڵ� 
            ' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColAccountNum", Me.txtColAccountNum.TextValue)  '' �Աݰ��¹�ȣ 
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARecipient", Me.txtRecipient.TextValue)  '' �Ա��ڸ�     
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", popEmployeeExpNum.TextValue)  '' ���Ȯ���ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)  '' Ȯ��ó�ڵ� 
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColAmt", Me.numColAmt.TextValue)  '' �Աݱݾ�     
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProcEmpNum", Me.popProcEmpNum.TextValue)  '' �۾��� ���  
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", Me.txtNote.TextValue)  '' ���         
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE991_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        End Sub

        Public Sub DeleteData()

            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", "3")   '' GrecordProcessMode)    '�����ڵ�
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColDt", Me.dtpColDt.TextValue)  '' �Ա�����    
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColOrders", Me.numColOrders.TextValue)  '' �Աݼ���     
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColTypeCd", Me.cboColTypeCd.TextValue)  '' �Աݱ����ڵ� 
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColBankCd", Me.cboColBankCd.TextValue)  '' �Ա������ڵ� 
                '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColAccountNum", Me.txtColAccountNum.TextValue)  '' �Աݰ��¹�ȣ 
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARecipient", Me.txtRecipient.TextValue)  '' �Ա��ڸ�     
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", popEmployeeExpNum.TextValue)  '' ���Ȯ���ȣ
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)  '' Ȯ��ó�ڵ� 
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AColAmt", Me.numColAmt.TextValue)  '' �Աݱݾ�     
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProcEmpNum", Me.popProcEmpNum.TextValue)  '' �۾��� ���  
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", Me.txtNote.TextValue)  '' ���         
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE991_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Sub

        Private Sub grd_1_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            'Me.grd_1.Editable = EditableSettings.flexEDNone

        End Sub
        Public Sub ExportData()

            Dim AsqlParameters() As SqlParameter = Nothing

            With GmainCommonFunction
                .SetSqlParameter(AsqlParameters, "@AYYYYMMDDFrom", Me.dtpFromColDt.TextValue)
                .SetSqlParameter(AsqlParameters, "@AYYYYMMDDTo", Me.dtpToColDt.TextValue)

                'Dim AAAA As String = ""
                'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                Dim AformulaParameters() As SqlParameter = Nothing

                'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                .SetExportCrystalDataParameter("PNE991_1_C_R.rpt", "PNE991_1_C_R", "", AsqlParameters, AformulaParameters)
            End With

        End Sub
    End Class

End Namespace
