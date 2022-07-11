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

    Partial Class PNC301

        '====================================================================================================
        Public Sub NewData()

            GmainCommonFunction.ControlNewData(Me, Me.picCriteria_1, Me.picIo_2)


            Me.dtpReceiptDt.Text = Format(System.DateTime.Now, "yyyy-MM-dd")
            Me.txtDateTime.Text = Format(System.DateTime.Now, "HH:MM:ss")

            With Me.grd_1
                Me.txtReaderNmNote.TextValue = Me.grd_1.GetCurrentRowCellValue("ReaderNm")
                Me.txtPhoneNumNote.TextValue = Me.grd_1.GetCurrentRowCellValue("PhoneNum1")
            End With
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            Dim blnRequstYesOrNo As Boolean = True
            If txtReaderCd.TextValue.ToString.Length < 1 _
               And txtReaderNm.TextValue.ToString.Length < 1 _
               And txtPhoneNum.TextValue.ToString.Length < 1 _
               And txtNewAddr.TextValue.ToString.Length < 1 Then
                blnRequstYesOrNo = False
                MessageBox.Show("�˻� ������ �Է��ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If blnRequstYesOrNo Then
                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReaderCd", Me.txtReaderCd.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReaderNm", Me.txtReaderNm.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum", Me.txtPhoneNum.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANewAddr", Me.txtNewAddr.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC301_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            End If
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFromReceiptDt", Me.dtpFromReceiptDt.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AToReceiptDt", Me.dtpToReceiptDt.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", Me.grd_1.GetCurrentRowCellValue("SubscribeCd"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC301_2_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub


        '====================================================================================================
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.grd_2.GetCurrentRowCellValue("ReceiptDt"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(IsNumeric(Me.grd_2.GetCurrentRowCellValue("Orders")) = False, 0, Me.grd_2.GetCurrentRowCellValue("Orders")))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", Me.grd_2.GetCurrentRowCellValue("SubscribeCd"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC301_3_R", False, True, GmainsqlParameters)
            GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

            Me.dtpReceiptDt.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ReceiptDt").ToString
            'Me.dtpReceiptDt.Text = reciveDataSet.Tables(0).Rows(0).Item("ReceiptTime").ToString
            Me.txtDateTime.Text = reciveDataSet.Tables(0).Rows(0).Item("ReceiptTime").ToString
            Me.cboDivCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DivCd").ToString().Split(".")(0)
            Me.txtReaderNmNote.Text = reciveDataSet.Tables(0).Rows(0).Item("ReaderNmNote").ToString
            Me.txtPhoneNumNote.Text = reciveDataSet.Tables(0).Rows(0).Item("PhoneNumNote").ToString
            Me.txtAddrNote.Text = reciveDataSet.Tables(0).Rows(0).Item("AddrNote").ToString
            Me.txtBranchNmNote.Text = reciveDataSet.Tables(0).Rows(0).Item("BranchNmNote").ToString
            Me.txtDeptNm.Text = reciveDataSet.Tables(0).Rows(0).Item("DeptNm").ToString
            Me.txtContent.Text = reciveDataSet.Tables(0).Rows(0).Item("Content").ToString
            Me.txtSubscribeCd.Text = reciveDataSet.Tables(0).Rows(0).Item("SubscribeCd").ToString

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        Public Sub SaveData()
            Dim sSubscribe As String
            sSubscribe = grd_1.GetCurrentRowCellValue("SubscribeCd")
            Dim sDateTime As String
            sDateTime = Format(Now, "HH:MM:ss")

            'If Me.txtChiefCd.Text.Replace(" ", "") = "" Then
            '    GrecordProcessMode = "1"
            'Else
            '    GrecordProcessMode = "2"
            'End If

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue.Replace("-", "").Substring(1, 6))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.grd_2.GetCurrentRowCellValue("Orders"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptTime", sDateTime) 'Me.cboBusinessPlaceCode.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", Me.txtName.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", Me.txtSubscribeCd.Text) ' �ٽ� �߰� (20081224 ����)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADivCd", Me.cboDivCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReaderNmNote", Me.txtReaderNmNote.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNumNote", Me.txtPhoneNumNote.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddrNote", Me.txtAddrNote.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNmNote", Me.txtBranchNmNote.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptNm", Me.txtDeptNm.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContent", Me.txtContent.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", sSubscribe)


            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC301_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            Dim sSubscribe As String
            sSubscribe = grd_1.GetCurrentRowCellValue("SubscribeCd")
            Dim sDateTime As String
            sDateTime = Format(Now, "HH:MM:ss")
            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue.Replace("-", "").Substring(1, 6))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(IsNumeric(Me.grd_2.GetCurrentRowCellValue("Orders")) = False, 0, Me.grd_2.GetCurrentRowCellValue("Orders")))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptTime", sDateTime) 'Me.cboBusinessPlaceCode.TextValue)

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", Me.txtSubscribeCd.Text) ' �ٽ� �߰� (20081224 ����)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADivCd", Me.cboDivCd.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReaderNmNote", Me.txtReaderNmNote.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNumNote", Me.txtPhoneNumNote.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddrNote", Me.txtAddrNote.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNmNote", Me.txtBranchNmNote.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptNm", Me.txtDeptNm.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContent", Me.txtContent.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", sSubscribe)

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC301_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

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
                .SetSqlParameter(AsqlParameters, "@AReaderNm", Me.txtReaderNm.TextValue)
                
                .SetSqlParameter(AsqlParameters, "@AReceiptDt", Me.grd_2.GetCurrentRowCellValue("ReceiptDt"))

                'Dim AAAA As String = ""
                'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                Dim AformulaParameters() As SqlParameter = Nothing

                'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                .SetExportCrystalDataParameter("PNC301_1_C_R.rpt", "PNC301_1_C_R", "", AsqlParameters, AformulaParameters)
            End With

        End Sub
    End Class

End Namespace
