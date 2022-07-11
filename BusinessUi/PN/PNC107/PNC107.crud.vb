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

    Partial Class PNC107

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
            'GmainCommonFunction.ControlNewData(Me, Me.picCriteria)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)

            cboExpandDivCd_2.Enabled = False
            cboExpandDivCd_2.TextValue = "1"
            grd_1.Rows = 1

            cboMonitoringResultCd_E.Text = ""
            cboRefuseReasonCd_E.Text = ""
            popMonitoringEmpNum_E.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            ' ''popMonitoringEmpNum_E.NameText = ""
            dtpMonitoringProcDt_E.Text = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10)
            txtMonitoringRemark_E.Text = "�ϰ� ���"

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

            '''''' btnApprovalAll.Text = "�ϰ� ����"
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AexpandDivCd", Me.cboExpandDivCd_2.TextValue)   ' Ȯ�屸��
                .SetSqlParameter(GmainsqlParameters, "@AreceiptDtFrom", Me.dtpReceiptDtFrom.TextValue) '��������1
                .SetSqlParameter(GmainsqlParameters, "@AreceiptDtTo", Me.dtpReceiptDtTo.TextValue) ' ��������2
                .SetSqlParameter(GmainsqlParameters, "@AmonitoringResultCd", Me.cboMonitoringResultCd_R.TextValue)  '�����ó�����
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue) ' ����� ��� 
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd  ", Me.PopCompanyCd_R.TextValue)   'Ȯ��ó
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm  ", Me.txtAdEmployeeNm_R.TextValue)  '������

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC107_R", False, True, GmainsqlParameters)
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

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue


                    ' '' =============================================================================
                    '' '' '' �׸��� �հ��� �߰�
                    ' '' =============================================================================
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ContactPaperNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPagerNum"), "��  ��")
                    
                    .set_TextMatrix(.FixedRows, .get_ColIndex("ReaderStateCd"), "��   ��")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        'gridAttributes = gridAttributes & "|�����μ�;ContactPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)
        '   gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;40;;c;" & "o;n;n;4;"       '(30)
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.grd_1.GetCurrentRowCellValue("ReceiptCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC103_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                ''txtMonitoringRemark.Text = reciveDataSet.Tables(0).Rows(0)("MonitoringRemark").ToString.Replace("_&!@&_", vbCrLf)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : SaveData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC107_CUD", True, False, GmainsqlParameters)
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
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-08-17
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

        End Sub
    End Class

End Namespace
