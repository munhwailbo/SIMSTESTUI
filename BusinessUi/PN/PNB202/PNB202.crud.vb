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
    Partial Class PNB202

        '====================================================================================================
        Public Sub NewData()
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_3)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_4)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_5)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_6)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_7)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_8)

            '���� �ڵ� �˾� ����
            If popBaseBranchCd_R.TextValue.Length < 1 Then
                MsgBox("���� �ڵ带 �����Ͻʽÿ�.")
                Exit Sub
            End If

            ' '' ���� �ڵ忡 �ش��ϴ� ������ ���� ����
            ''If grd_1.Rows <= grd_1.FixedRows Then
            ''    MsgBox("���� �����ڵ带 ������ �� ����Ÿ�� ��ȸ�Ͻʽÿ�.")
            ''End If

            ''Me.popBranchCd.TextValue = Me.grd_1.GetCurrentRowCellValue("BranchCd")
            ''Me.popBranchCd.NameText = Me.grd_1.GetCurrentRowCellValue("BranchNm")
            ''Me.txtChangeNum.TextValue = (("0" & Me.grd_1.GetCurrentRowCellValue("ChangeNum").ToString() * 1) + 1).ToString

            ' ���� �ֱ��� �μ� (���� ����, �߼� �μ�) �������� 
            GetNm()

            Me.grd_3.Rows = 1
            Me.grd_4.Rows = 1
            Me.grd_5.Rows = 1
            Me.grd_6.Rows = 1
            Me.grd_7.Rows = 1
            Me.grd_8.Rows = 1
            Me.grd_9.Rows = 1
            Me.grd_10.Rows = 1


            ''Me.txtNewGubn.TextValue = ""
            ''numDepositAmt.TextValue = 0
            ' ''numUnitCost.TextValue = 0
            ''numOfficeNum.TextValue = 0
            ''numHouseNum.TextValue = 0
            ' ''numUnitCost.TextValue = 0
            ' ''numSpecUnitCost.TextValue = 0
            ''numValPaperNum.TextValue = 0
            ''numSubscribePaperNum.TextValue = 0
            ''numDeliveryPaperNum.TextValue = 0

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AbaseBranchCd", Me.popBaseBranchCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AchargeEmpNum", Me.popChargeEmpNum.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            If grd_1.Rows < grd_1.FixedRows Then Exit Sub

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_2_R", False, True, GmainsqlParameters)

            GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            If grd_1.Rows < grd_1.FixedRows Then Exit Sub
            GmainsqlParameters = Nothing

            With GmainCommonFunction

                '---grd_3------------------------------------------------------------------------------------------------------------------------
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_3_R", False, True, GmainsqlParameters)

                Me.grd_3.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_4------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_4_R", False, True, GmainsqlParameters)

                Me.grd_4.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_5------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_5_R", False, True, GmainsqlParameters)

                Me.grd_5.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_6------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_6_R", False, True, GmainsqlParameters)

                Me.grd_6.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_7------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_7_R", False, True, GmainsqlParameters)

                Me.grd_7.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_8------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_8_R", False, True, GmainsqlParameters)

                Me.grd_8.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '���Ժ����� �� �����ֱ�
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_8_1_R", False, True, GmainsqlParameters)

                'Me.txt_napTkum.TextValue = reciveDataSet.Tables(0).Rows(0).Item(2).ToString()
                'Me.txt_wanTkum.TextValue = reciveDataSet.Tables(0).Rows(1).Item(2).ToString()

                ' õ�������� �޸� ����ֱ�� ǥ��(�������� ��Ʈ��)
                'Me.num_napTkum.TextValue = reciveDataSet.Tables(0).Rows(0).Item(2).ToString()  
                'Me.num_wanTkum.TextValue = reciveDataSet.Tables(0).Rows(1).Item(2).ToString() 
                ' �ٵ� ��� �����ڵ忡 ���� �ݵ�� ���԰� �ϳ��� �߻����� �����Ƿ� ���� ��ȸ�ؼ� �ѷ���

                Me.num_napTkum.TextValue = "0"
                If reciveDataSet.Tables(0).Rows.Count > 0 Then
                    Me.num_napTkum.TextValue = reciveDataSet.Tables(0).Rows(0).Item(2).ToString()
                End If
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '�ϳ������� �� ���̱�
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_8_3_R", False, True, GmainsqlParameters)

                Me.num_wanTkum.TextValue = "0"
                If reciveDataSet.Tables(0).Rows.Count > 0 Then
                    Me.num_wanTkum.TextValue = reciveDataSet.Tables(0).Rows(0).Item(2).ToString()
                End If
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_9------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_9_R", False, True, GmainsqlParameters)

                Me.grd_9.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_10------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_A_R", False, True, GmainsqlParameters)

                Me.grd_10.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

            End With

        End Sub

        '====================================================================================================
        Public Sub SaveData()

            Dim strMode As String = ""
            If Me.txtNewGubn.TextValue <> "" Then
                strMode = "2" '����
            Else
                strMode = "1" '�Է�
            End If

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", strMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.txtBranchNum.TextValue)   ' ������ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.popBranchCd.TextValue)     ' �����ڵ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeNum", Me.txtChangeNum.TextValue)     ' ��üȸ��
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractDt", Me.dtpContractDt.TextValue)  ' ������� 
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractStDt", "")  ''Me.dtpContractStDt.TextValue)  '���������
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractEdDt", "")  ''Me.dtpContractEdDt.TextValue)  '���������
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractCancelDt", "")  ''Me.dtpContractCancelDt.TextValue)  '�����������
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.popBranchChiefCd.TextValue)  ' �������ڵ�
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.popBranchCd.NameText)             ' ������
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", "")  ''Me.popChargeEmpNum.TextValue)  ' ��������ڻ��
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeTypeCd", "")  ''Me.cboChargeTypeCd.TextValue)  ' �����������
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptCd", "")  ''Me.popDeptCd.TextValue)        ' �μ� �ڵ�
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptDivCd", "")  ''Me.cboDeptDivCd.TextValue)  ' �μ�����
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOpenYYYYMM", "")  '' Me.dtpOpenYYYYMM.TextValue)  ' 
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEndYYYYMM", "")  ''Me.dtpEndYYYYMM.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeDivCd", Me.cboChangeDivCd.TextValue)    ''��ü�����ڵ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManageDivCd", Me.cboManageDivCd.TextValue)      ' ����������ڵ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACombiningWork", Me.txtCombiningWork.TextValue)  ' �⿵���� 
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APrintRegionCd", Me.cboPrintRegionCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchRegionCd", Me.cboBranchRegionCd.TextValue)   ' ���������ڵ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum1", Me.txtPhoneNum1.TextValue)   ' ��ȭ��ȣ1
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum2", Me.txtPhoneNum2.TextValue)  ' ��ȭ��ȣ2
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFaxNum", Me.txtFaxNum.TextValue)        ' �ѽ���ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMobileNum", Me.txtMobileNum.TextValue)  ' �ڵ�����ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOfficeNum", Me.numOfficeNum.TextValue)  ' �б���
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AHouseNum", Me.numHouseNum.TextValue)    ' ������
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositAmt", Me.numDepositAmt.TextValue)   ' ����������
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositorNm", Me.txtDepositorNm.TextValue) ' �����ָ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABankCd", Me.cboBankCd.TextValue)      ' �����ڵ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAccountNum", Me.txtAccountNum.TextValue)    ' ���¹�ȣ
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUnitCost", "")  ''Me.numUnitCost.TextValue)      ' �Ϲݴܰ�
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASpecUnitCost", "")  ''Me.numSpecUnitCost.TextValue)  ' Ư���ܰ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeliveryPaperNum", Me.numDeliveryPaperNum.TextValue)   '�߼ۺμ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribePaperNum", Me.numSubscribePaperNum.TextValue)   '���ںμ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AValPaperNum", Me.numValPaperNum.TextValue)             '��������
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAm7PaperNum", Me.numAm7PaperNum.TextValue)             'AM7�μ�
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchValPaperNum", Me.numBranchValPaperNum.TextValue) '��������
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATajirelation", Me.txtTajirelation.TextValue)      'Ÿ��������� ����
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeReason", Me.txtChangeReason.TextValue)      '��ü����
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorNm", Me.txtGuarantorNm.TextValue)        '�����μ���
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorRelation", Me.txtGuarantorRelation.TextValue)  '�����ΰ���

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPostNum", Me.popGuarantorPostNum.TextValue)  '������ �����ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorAddr1", Me.txtGuarantorAddr1.TextValue)  '������ �ּ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorAddr2", Me.txtGuarantorAddr2.TextValue)  '������ ���ּ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPhoneNum", Me.txtGuarantorPhoneNum.TextValue)  '������ ����ó
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorMobileNum", Me.txtGuarantorMobileNum.TextValue)  '������ �ڵ���

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorSocialNum", VBN.IIf(IsNothing(Me.txtGuarantorSocialNum.TextValue), "", Me.txtGuarantorSocialNum.TextValue))      '�������ֹι�ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPropertyTaxAmt", Me.chkGuarantorPropertyTaxAmt.Checked) '��������꼼����
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorName", Me.txtOperatorName.TextValue)                     '��ڼ���
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorRelation", Me.txtOperatorRelation.TextValue)     '��ڰ���(����ڰ���) 
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorSocialNum", VBN.IIf(IsNothing(Me.txtOperatorSocialNum.TextValue), "", Me.txtOperatorSocialNum.TextValue))           '����ֹι�ȣ
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractYN", Me.chkContractYN.Checked)            '���ϰῩ��
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorTelNum1", Me.txtOperatorTelNum1.TextValue)      '��� �繫�ǹ�ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorTelNum2", Me.txtOperatorTelNum2.TextValue)      '��� ���ù�ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorMobileNum", Me.txtOperatorMobileNum.TextValue)  '��� �ڵ�����ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorFaxNum", Me.txtOperatorFaxNum.TextValue)        '��� �ѽ���ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorPostNum", Me.popOperatorPostNum.TextValue)      '��� �����ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorAddr1", Me.txtOperatorAddr1.TextValue)          '��� �ּ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorAddr2", Me.txtOperatorAddr2.TextValue)          '��� ���ּ�

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASpecialIssue", Me.TxtSpecialIssue.TextValue)            'Ư�̻���
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APropertyTaxPayAmt", Me.numPropertyTaxPayAmt.TextValue)  '��꼼 ���ξ�


            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
                ''''''''''popBaseBranchCd_R.TextValue = popBranchCd.NameText
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.txtBranchNum.TextValue)   ' ������ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.popBranchCd.TextValue)     ' �����ڵ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeNum", Me.txtChangeNum.TextValue)     ' ��üȸ��
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractDt", Me.dtpContractDt.TextValue)  ' ������� 
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractStDt", "")  ''Me.dtpContractStDt.TextValue)  '���������
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractEdDt", "")  ''Me.dtpContractEdDt.TextValue)  '���������
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractCancelDt", "")  ''Me.dtpContractCancelDt.TextValue)  '�����������
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.popBranchChiefCd.TextValue)  ' �������ڵ�
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.popBranchCd.NameText)             ' ������
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", "")  ''Me.popChargeEmpNum.TextValue)  ' ��������ڻ��
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeTypeCd", "")  ''Me.cboChargeTypeCd.TextValue)  ' �����������
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptCd", "")  ''Me.popDeptCd.TextValue)        ' �μ� �ڵ�
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptDivCd", "")  ''Me.cboDeptDivCd.TextValue)  ' �μ�����
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOpenYYYYMM", "")  '' Me.dtpOpenYYYYMM.TextValue)  ' 
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEndYYYYMM", "")  ''Me.dtpEndYYYYMM.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeDivCd", Me.cboChangeDivCd.TextValue)    ''��ü�����ڵ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManageDivCd", Me.cboManageDivCd.TextValue)      ' ����������ڵ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACombiningWork", Me.txtCombiningWork.TextValue)  ' �⿵���� 
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APrintRegionCd", Me.cboPrintRegionCd.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchRegionCd", Me.cboBranchRegionCd.TextValue)   ' ���������ڵ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum1", Me.txtPhoneNum1.TextValue)   ' ��ȭ��ȣ1
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum2", Me.txtPhoneNum2.TextValue)  ' ��ȭ��ȣ2
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFaxNum", Me.txtFaxNum.TextValue)        ' �ѽ���ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMobileNum", Me.txtMobileNum.TextValue)  ' �ڵ�����ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOfficeNum", Me.numOfficeNum.TextValue)  ' �б���
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AHouseNum", Me.numHouseNum.TextValue)    ' ������
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositAmt", Me.numDepositAmt.TextValue)   ' ����������
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositorNm", Me.txtDepositorNm.TextValue) ' �����ָ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABankCd", Me.cboBankCd.TextValue)      ' �����ڵ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAccountNum", Me.txtAccountNum.TextValue)    ' ���¹�ȣ
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUnitCost", "")  ''Me.numUnitCost.TextValue)      ' �Ϲݴܰ�
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASpecUnitCost", "")  ''Me.numSpecUnitCost.TextValue)  ' Ư���ܰ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeliveryPaperNum", Me.numDeliveryPaperNum.TextValue)   '�߼ۺμ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribePaperNum", Me.numSubscribePaperNum.TextValue)   '���ںμ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AValPaperNum", Me.numValPaperNum.TextValue)             '��������
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAm7PaperNum", Me.numAm7PaperNum.TextValue)             'AM7�μ�
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchValPaperNum", Me.numBranchValPaperNum.TextValue) '��������
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATajirelation", Me.txtTajirelation.TextValue)      'Ÿ��������� ����
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeReason", Me.txtChangeReason.TextValue)      '��ü����
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorNm", Me.txtGuarantorNm.TextValue)        '�����μ���
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorRelation", Me.txtGuarantorRelation.TextValue)  '�����ΰ���

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPostNum", Me.popGuarantorPostNum.TextValue)  '������ �����ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorAddr1", Me.txtGuarantorAddr1.TextValue)  '������ �ּ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorAddr2", Me.txtGuarantorAddr2.TextValue)  '������ ���ּ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPhoneNum", Me.txtGuarantorPhoneNum.TextValue)  '������ ����ó
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorMobileNum", Me.txtGuarantorMobileNum.TextValue)  '������ �ڵ���

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorSocialNum", VBN.IIf(IsNothing(Me.txtGuarantorSocialNum.TextValue), "", Me.txtGuarantorSocialNum.TextValue))      '�������ֹι�ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPropertyTaxAmt", Me.chkGuarantorPropertyTaxAmt.Checked) '��������꼼����
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorName", Me.txtOperatorName.TextValue)                     '��ڼ���
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorRelation", Me.txtOperatorRelation.TextValue)      '��ڰ���(����ڰ���) 
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorSocialNum", VBN.IIf(IsNothing(Me.txtOperatorSocialNum.TextValue), "", Me.txtOperatorSocialNum.TextValue))           '����ֹι�ȣ
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractYN", Me.chkContractYN.Checked)            '���ϰῩ��
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorTelNum1", Me.txtOperatorTelNum1.TextValue)      '��� �繫�ǹ�ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorTelNum2", Me.txtOperatorTelNum2.TextValue)      '��� ���ù�ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorMobileNum", Me.txtOperatorMobileNum.TextValue)  '��� �ڵ�����ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorFaxNum", Me.txtOperatorFaxNum.TextValue)    '��� �ѽ���ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorPostNum", Me.popOperatorPostNum.TextValue)  '��� �����ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorAddr1", Me.txtOperatorAddr1.TextValue)      '��� �ּ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorAddr2", Me.txtOperatorAddr2.TextValue)      '��� ���ּ�

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASpecialIssue", Me.TxtSpecialIssue.TextValue)            'Ư�̻���
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APropertyTaxPayAmt", Me.numPropertyTaxPayAmt.TextValue)  '��꼼 ���ξ�

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_CUD", True, False, GmainsqlParameters)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_2()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_2_CUD", True, False, GmainsqlParameters)
            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_2()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_2_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_3()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_4.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_3_CUD", True, False, GmainsqlParameters)
            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_3()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_4.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_3_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_4()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_5.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_4_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_4()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_5.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_4_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_5()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_6.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_5_CUD", True, False, GmainsqlParameters)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_5()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_6.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_5_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_6()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_7.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_7_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_6()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_7.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_7_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_7()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_8.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_8_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_7()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_8.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_8_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_8()
            '''' �ܰ�
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_9.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_9_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_8()

            '''' �ܰ�
            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_9.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_9_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub
        Public Sub SaveData_10()
            '''' �ܰ�
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_10.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_A_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub
        '====================================================================================================
        Public Sub DeleteData_10()

            '''' �ܰ�
            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_10.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_A_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub


        Public Sub GetNm()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                'If popBaseBranchCd_R.TextValue.Length < 1 Then
                '    MsgBox("���� �ڵ带 �����Ͻʽÿ�.")
                '    Exit Sub
                'Else
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", popBaseBranchCd_R.TextValue)
                'End If

                ' ���� ����,�߼� �μ� ����
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_10_R", False, True, GmainsqlParameters)

                If Not IsNothing(reciveDataSet) Then
                    If reciveDataSet.Tables(0).Rows.Count > 0 Then

                        Me.numValPaperNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ValPaperNum1")
                        Me.numDeliveryPaperNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("SendingNm")
                        reciveDataSet = Nothing
                    Else
                        Exit Sub
                    End If
                Else
                    numValPaperNum.TextValue = "0"
                    numDeliveryPaperNum.TextValue = "0"
                    Exit Sub
                End If

                ' ���� �μ�
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_11_R", False, True, GmainsqlParameters)

                If Not IsNothing(reciveDataSet) Then
                    If reciveDataSet.Tables(0).Rows.Count > 0 Then

                        Me.numSubscribePaperNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("SubscribePaperNum")
                        reciveDataSet = Nothing
                    Else
                        Exit Sub
                    End If
                Else
                    numSubscribePaperNum.TextValue = "0"

                    Exit Sub
                End If

            End With


        End Sub

    End Class

End Namespace
