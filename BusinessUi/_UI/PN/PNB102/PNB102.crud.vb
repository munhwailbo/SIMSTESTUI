
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

    Partial Class PNB102

        '====================================================================================================
        Public Sub NewData()

            lblRecordState.Text = "�ű�"
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_3)

            If popBranchCd_R.TextValue.ToString().Length > 0 Then
                With Me.grd_1
                    .AddRow()
                    For intII As Integer = .Rows - 1 To .FixedRows Step -1
                        If intII = .FixedRows Then
                            For intJJ As Integer = 1 To .Cols - 1
                                .set_TextMatrix(intII, intJJ, "")
                            Next
                            .set_TextMatrix(intII, .get_ColIndex("BranchCd"), Me.popBranchCd_R.TextValue)
                            .set_TextMatrix(intII, .get_ColIndex("BranchNm"), Me.popBranchCd_R.NameText)
                            .set_TextMatrix(intII, .get_ColIndex("TransferDate"), "�ű�")
                        Else
                            For intJJ As Integer = 1 To .Cols - 1
                                .set_TextMatrix(intII, intJJ, .get_TextMatrix(intII - 1, intJJ))
                            Next
                        End If
                    Next

                    '' '' '' .set_TextMatrix(.Rows - 1, .get_ColIndex("BranchCd"), .get_TextMatrix(.Rows - 2, .get_ColIndex("BranchCd")))
                    ' ''.set_TextMatrix(.Rows - 1, .get_ColIndex("BranchCd"), Me.popBranchCd_R.TextValue)
                    ' ''.set_TextMatrix(.Rows - 1, .get_ColIndex("TransferDate"), "�ű�")
                End With
                Me.RequestData_2()
            End If

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            If popBranchCd_R.TextValue.ToString().Length < 1 Then
                MsgBox("�����ڵ带 �Է� �ϼ���", MsgBoxStyle.Information, "Ȯ���ϼ���")
                popBranchCd_R.Focus()
                Exit Sub
            End If

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpBaseDt.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))    '' ������ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferDate", Me.grd_1.GetCurrentRowCellValue("TransferDate"))  '' ��������

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_2_R", False, True, GmainsqlParameters)
            If reciveDataSet.Tables.Count > 0 Then
                If Me.grd_1.GetCurrentRowCellValue("TransferDate") = "�ű�" Then
                    lblRecordState.Text = "�ű�"
                Else
                    lblRecordState.Text = "��ȸ"
                End If
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            End If

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)

            '' ''GmainsqlParameters = Nothing

            '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))    '' ������ȣ
            '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferDate", Me.grd_1.GetCurrentRowCellValue("TransferDate"))  '' ��������

            '' ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_2_R", False, True, GmainsqlParameters)
            '' ''If reciveDataSet.Tables.Count > 0 Then
            '' ''    lblRecordState.Text = "��ȸ"
            '' ''    GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            '' ''End If

            '' ''reciveDataSet = Nothing

            '' ''GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            '' ''If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub


        '' ''Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)
        '' ''    GmainsqlParameters = Nothing

        '' ''    With GmainCommonFunction
        '' ''        .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_2.GetCurrentRowCellValue("BranchCd"))
        '' ''        Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_3_R", False, True, GmainsqlParameters)
        '' ''        GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
        '' ''        reciveDataSet = Nothing
        '' ''        .SetAllBusinessUiInitialValue(Me)
        '' ''        If AprocessMessage = True Then .RequestDataMessage(Me)
        '' ''        GrecordProcessMode = "2"
        '' ''    End With

        '' ''End Sub

        '====================================================================================================
        Public Sub SaveData()

            'If Validation() = True Then

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", IIf(lblRecordState.Text = "�ű�", "1", "2"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", popBranchCd.TextValue)             '' '' �����ڵ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferDate", dtpTransferDate.TextValue)     '' '' ��������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferNum", numTransferNum.TextValue)       '' '' ����Ƚ��	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProcessDivCd", popProcessDivCd.TextValue)     '' '' ó�������ڵ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractDivCd", popContractDivCd.TextValue)   '' '' ��౸���ڵ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerNm", txtOwnerNm.TextValue)               '' '' �����ָ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerPhoneNum", txtOwnerPhoneNum.TextValue)   '' '' �ǹ��� ����ó	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APostNum", popPostNum.TextValue)               '' '' ���������ȣ	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr1", txtAddr1.TextValue)                   '' '' �����ּ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr2", txtAddr2.TextValue)                   '' '' �����ּ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASiteArea", numSiteArea.TextValue)             '' '' �������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABuildingArea", numBuildingArea.TextValue)     '' '' �ǹ����	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUseArea", numUseArea.TextValue)               '' '' ������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFloor", txtFloor.TextValue)                   '' '' ������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ALimitedItem", txtLimitedItem.TextValue)       '' '' ���ѹ���	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AObligation", txtObligation.TextValue)         '' '' ä��Ȯ��	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractStDt", dtpContractStDt.TextValue)      '' '' ��������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractEdDt", dtpContractEdDt.TextValue)      '' '' ��������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityOwnerNm", txtSecurityOwnerNm.TextValue)    '' '' �빰�㺸-�����ڸ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityPostNum", popSecurityPostNum.TextValue)    '' '' �빰�㺸-�����ȣ	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityAddr1", txtSecurityAddr1.TextValue)        '' '' �빰�㺸-�ּ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityAddr2", txtSecurityAddr2.TextValue)        '' '' �빰�㺸-�ּ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecuritySiteArea", numSecuritySiteArea.TextValue)  '' '' �빰�㺸-�������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityBuildingArea", numSecurityBuildingArea.TextValue)    '' '' �빰�㺸-�ǹ����	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityLimitedItem", txtSecurityLimitedItem.TextValue)      '' '' �빰�㺸-���ѹ���
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARentDepositAmt", numRentDepositAmt.TextValue)      '' '' ����������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARentAmt", numRentAmt.TextValue)                    '' '' ������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeferPaymentYn", chkdeferPaymentYn.Checked)        '' '' ������������	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AVatYn", chkVatYn.Checked)                          '' '' VAT���Կ���	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABankCd", popBankCd.TextValue)                      '' '' ���౸���ڵ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAccountNum", txtAccountNum.TextValue)              '' '' ���¹�ȣ	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositorNm", txtDepositorNm.TextValue)            '' '' �����ָ�	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerRelation", txtOwnerRelation.TextValue)        '' '' �ǹ��ֿ��ǰ���	
            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", popBranchCd.TextValue)             '' '' �����ڵ�
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferDate", dtpTransferDate.TextValue)     '' '' ��������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferNum", numTransferNum.TextValue)       '' '' ����Ƚ��	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProcessDivCd", popProcessDivCd.TextValue)     '' '' ó�������ڵ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractDivCd", popContractDivCd.TextValue)   '' '' ��౸���ڵ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerNm", txtOwnerNm.TextValue)               '' '' �����ָ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerPhoneNum", txtOwnerPhoneNum.TextValue)   '' '' �ǹ��� ����ó	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APostNum", popPostNum.TextValue)               '' '' ���������ȣ	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr1", txtAddr1.TextValue)                   '' '' �����ּ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr2", txtAddr2.TextValue)                   '' '' �����ּ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASiteArea", numSiteArea.TextValue)             '' '' �������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABuildingArea", numBuildingArea.TextValue)     '' '' �ǹ����	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUseArea", numUseArea.TextValue)               '' '' ������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFloor", txtFloor.TextValue)                   '' '' ������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ALimitedItem", txtLimitedItem.TextValue)       '' '' ���ѹ���	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AObligation", txtObligation.TextValue)         '' '' ä��Ȯ��	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractStDt", dtpContractStDt.TextValue)      '' '' ��������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractEdDt", dtpContractEdDt.TextValue)      '' '' ��������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityOwnerNm", txtSecurityOwnerNm.TextValue)    '' '' �빰�㺸-�����ڸ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityPostNum", popSecurityPostNum.TextValue)    '' '' �빰�㺸-�����ȣ	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityAddr1", txtSecurityAddr1.TextValue)        '' '' �빰�㺸-�ּ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityAddr2", txtSecurityAddr2.TextValue)        '' '' �빰�㺸-�ּ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecuritySiteArea", numSecuritySiteArea.TextValue)  '' '' �빰�㺸-�������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityBuildingArea", numSecurityBuildingArea.TextValue)    '' '' �빰�㺸-�ǹ����	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityLimitedItem", txtSecurityLimitedItem.TextValue)      '' '' �빰�㺸-���ѹ���
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARentDepositAmt", numRentDepositAmt.TextValue)      '' '' ����������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARentAmt", numRentAmt.TextValue)                    '' '' ������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeferPaymentYn", chkdeferPaymentYn.Checked)        '' '' ������������	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AVatYn", chkVatYn.Checked)                          '' '' VAT���Կ���	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABankCd", popBankCd.TextValue)                      '' '' ���౸���ڵ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAccountNum", txtAccountNum.TextValue)              '' '' ���¹�ȣ	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositorNm", txtDepositorNm.TextValue)            '' '' �����ָ�	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerRelation", txtOwnerRelation.TextValue)        '' '' �ǹ��ֿ��ǰ���	

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.DeleteDataMessage(Me)
                    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    GmainExecuteDbCommand.GerrorNumber = 1
                End If

            End If

        End Sub


        Public Sub ExportData()

            Dim AsqlParameters() As SqlParameter = Nothing
            If optMonAmtList.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNB102_1_C_R.rpt", "PNB102_1_C_R", "", AsqlParameters, AformulaParameters)
                End With


            ElseIf optMonthTotal.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNB102_2_C_R.rpt", "PNB102_2_C_R", "", AsqlParameters, AformulaParameters)
                End With

            ElseIf optMonthDepositBack.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNB102_3_C_R.rpt", "PNB102_3_C_R", "", AsqlParameters, AformulaParameters)
                End With
            ElseIf optBranchHp.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNB102_4_C_R.rpt", "PNB102_4_C_R", "", AsqlParameters, AformulaParameters)
                End With
            ElseIf optsend.Checked = True Then
                With GmainCommonFunction
                    '.SetSqlParameter(AsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AYYYYMMDD ", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
                    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

                    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
                    .SetExportCrystalDataParameter("PNB302_C_R.rpt", "PNB302_C_R", "", AsqlParameters, AformulaParameters)
                End With
            End If


        End Sub
        Public Function Validation() As Boolean

            'Validation = False

            ''With Me.grd_2
            ''For inti As Integer = .FixedRows To .Rows - 1

            ''    If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
            ''        If Trim(.get_TextMatrix(inti, .get_ColIndex("ColumnName"))).Length < 1 Then
            ''            MessageBox.Show("�÷� �������� �ݵ�� �Է��� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ''            Exit Function
            ''        End If

            ''        If .get_TextMatrix(inti, .get_ColIndex("ColLen")) <> "" Then
            ''            .set_TextMatrix(inti, .get_ColIndex("ColLen"), "(" & .get_TextMatrix(inti, .get_ColIndex("ColLen")) & ")")
            ''        End If

            ''    End If
            ''Next inti
            ''End With

            'Validation = True

        End Function


    End Class

End Namespace
