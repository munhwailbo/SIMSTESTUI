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

            '지국 코드 팝업 선택
            If popBaseBranchCd_R.TextValue.Length < 1 Then
                MsgBox("지국 코드를 선택하십시오.")
                Exit Sub
            End If

            ' '' 지국 코드에 해당하는 데이터 존재 여부
            ''If grd_1.Rows <= grd_1.FixedRows Then
            ''    MsgBox("먼저 지국코드를 선택한 후 데이타를 조회하십시오.")
            ''End If

            ''Me.popBranchCd.TextValue = Me.grd_1.GetCurrentRowCellValue("BranchCd")
            ''Me.popBranchCd.NameText = Me.grd_1.GetCurrentRowCellValue("BranchNm")
            ''Me.txtChangeNum.TextValue = (("0" & Me.grd_1.GetCurrentRowCellValue("ChangeNum").ToString() * 1) + 1).ToString

            ' 가장 최근의 부수 (본사 유가, 발송 부수) 가져오기 
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

                '납입보증금 계 보여주기
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_8_1_R", False, True, GmainsqlParameters)

                'Me.txt_napTkum.TextValue = reciveDataSet.Tables(0).Rows(0).Item(2).ToString()
                'Me.txt_wanTkum.TextValue = reciveDataSet.Tables(0).Rows(1).Item(2).ToString()

                ' 천단위마다 콤마 찍어주기로 표시(유비템즈 컨트롤)
                'Me.num_napTkum.TextValue = reciveDataSet.Tables(0).Rows(0).Item(2).ToString()  
                'Me.num_wanTkum.TextValue = reciveDataSet.Tables(0).Rows(1).Item(2).ToString() 
                ' 근데 모든 지국코드에 대해 반드시 납입과 완납이 발생하지 않으므로 각각 조회해서 뿌려줌

                Me.num_napTkum.TextValue = "0"
                If reciveDataSet.Tables(0).Rows.Count > 0 Then
                    Me.num_napTkum.TextValue = reciveDataSet.Tables(0).Rows(0).Item(2).ToString()
                End If
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '완납적립금 계 보이기
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
                strMode = "2" '수정
            Else
                strMode = "1" '입력
            End If

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", strMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.txtBranchNum.TextValue)   ' 지국번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.popBranchCd.TextValue)     ' 지국코드
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeNum", Me.txtChangeNum.TextValue)     ' 교체회수
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractDt", Me.dtpContractDt.TextValue)  ' 계약일자 
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractStDt", "")  ''Me.dtpContractStDt.TextValue)  '운영시작일자
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractEdDt", "")  ''Me.dtpContractEdDt.TextValue)  '운영종료일자
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractCancelDt", "")  ''Me.dtpContractCancelDt.TextValue)  '계약종료일자
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.popBranchChiefCd.TextValue)  ' 지국장코드
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.popBranchCd.NameText)             ' 지국명
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", "")  ''Me.popChargeEmpNum.TextValue)  ' 지국담당자사번
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeTypeCd", "")  ''Me.cboChargeTypeCd.TextValue)  ' 지국담당유형
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptCd", "")  ''Me.popDeptCd.TextValue)        ' 부서 코드
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptDivCd", "")  ''Me.cboDeptDivCd.TextValue)  ' 부서구분
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOpenYYYYMM", "")  '' Me.dtpOpenYYYYMM.TextValue)  ' 
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEndYYYYMM", "")  ''Me.dtpEndYYYYMM.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeDivCd", Me.cboChangeDivCd.TextValue)    ''교체구분코드
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManageDivCd", Me.cboManageDivCd.TextValue)      ' 지국운영구분코드
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACombiningWork", Me.txtCombiningWork.TextValue)  ' 겸영내용 
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APrintRegionCd", Me.cboPrintRegionCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchRegionCd", Me.cboBranchRegionCd.TextValue)   ' 지국지역코드
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum1", Me.txtPhoneNum1.TextValue)   ' 전화번호1
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum2", Me.txtPhoneNum2.TextValue)  ' 전화번호2
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFaxNum", Me.txtFaxNum.TextValue)        ' 팩스번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMobileNum", Me.txtMobileNum.TextValue)  ' 핸드폰번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOfficeNum", Me.numOfficeNum.TextValue)  ' 분국수
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AHouseNum", Me.numHouseNum.TextValue)    ' 가구수
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositAmt", Me.numDepositAmt.TextValue)   ' 지국보증금
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositorNm", Me.txtDepositorNm.TextValue) ' 예금주명
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABankCd", Me.cboBankCd.TextValue)      ' 은행코드
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAccountNum", Me.txtAccountNum.TextValue)    ' 계좌번호
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUnitCost", "")  ''Me.numUnitCost.TextValue)      ' 일반단가
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASpecUnitCost", "")  ''Me.numSpecUnitCost.TextValue)  ' 특수단가
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeliveryPaperNum", Me.numDeliveryPaperNum.TextValue)   '발송부수
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribePaperNum", Me.numSubscribePaperNum.TextValue)   '독자부수
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AValPaperNum", Me.numValPaperNum.TextValue)             '본사유가
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAm7PaperNum", Me.numAm7PaperNum.TextValue)             'AM7부수
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchValPaperNum", Me.numBranchValPaperNum.TextValue) '지국유가
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATajirelation", Me.txtTajirelation.TextValue)      '타지국장과의 관계
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeReason", Me.txtChangeReason.TextValue)      '교체사유
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorNm", Me.txtGuarantorNm.TextValue)        '보증인성명
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorRelation", Me.txtGuarantorRelation.TextValue)  '보증인관계

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPostNum", Me.popGuarantorPostNum.TextValue)  '보증인 우편번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorAddr1", Me.txtGuarantorAddr1.TextValue)  '보증인 주소
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorAddr2", Me.txtGuarantorAddr2.TextValue)  '보증인 상세주소
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPhoneNum", Me.txtGuarantorPhoneNum.TextValue)  '보증인 연락처
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorMobileNum", Me.txtGuarantorMobileNum.TextValue)  '보증인 핸드폰

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorSocialNum", VBN.IIf(IsNothing(Me.txtGuarantorSocialNum.TextValue), "", Me.txtGuarantorSocialNum.TextValue))      '보증인주민번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPropertyTaxAmt", Me.chkGuarantorPropertyTaxAmt.Checked) '보증인재산세납부
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorName", Me.txtOperatorName.TextValue)                     '운영자성명
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorRelation", Me.txtOperatorRelation.TextValue)     '운영자관계(계약자관계) 
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorSocialNum", VBN.IIf(IsNothing(Me.txtOperatorSocialNum.TextValue), "", Me.txtOperatorSocialNum.TextValue))           '운영자주민번호
            '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractYN", Me.chkContractYN.Checked)            '계약완결여부
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorTelNum1", Me.txtOperatorTelNum1.TextValue)      '운영자 사무실번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorTelNum2", Me.txtOperatorTelNum2.TextValue)      '운영자 자택번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorMobileNum", Me.txtOperatorMobileNum.TextValue)  '운영자 핸드폰번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorFaxNum", Me.txtOperatorFaxNum.TextValue)        '운영자 팩스번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorPostNum", Me.popOperatorPostNum.TextValue)      '운영자 우편번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorAddr1", Me.txtOperatorAddr1.TextValue)          '운영자 주소
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorAddr2", Me.txtOperatorAddr2.TextValue)          '운영자 상세주소

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASpecialIssue", Me.TxtSpecialIssue.TextValue)            '특이사항
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APropertyTaxPayAmt", Me.numPropertyTaxPayAmt.TextValue)  '재산세 납부액


            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
                ''''''''''popBaseBranchCd_R.TextValue = popBranchCd.NameText
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.txtBranchNum.TextValue)   ' 지국번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.popBranchCd.TextValue)     ' 지국코드
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeNum", Me.txtChangeNum.TextValue)     ' 교체회수
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractDt", Me.dtpContractDt.TextValue)  ' 계약일자 
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractStDt", "")  ''Me.dtpContractStDt.TextValue)  '운영시작일자
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractEdDt", "")  ''Me.dtpContractEdDt.TextValue)  '운영종료일자
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractCancelDt", "")  ''Me.dtpContractCancelDt.TextValue)  '계약종료일자
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.popBranchChiefCd.TextValue)  ' 지국장코드
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.popBranchCd.NameText)             ' 지국명
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", "")  ''Me.popChargeEmpNum.TextValue)  ' 지국담당자사번
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeTypeCd", "")  ''Me.cboChargeTypeCd.TextValue)  ' 지국담당유형
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptCd", "")  ''Me.popDeptCd.TextValue)        ' 부서 코드
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptDivCd", "")  ''Me.cboDeptDivCd.TextValue)  ' 부서구분
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOpenYYYYMM", "")  '' Me.dtpOpenYYYYMM.TextValue)  ' 
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEndYYYYMM", "")  ''Me.dtpEndYYYYMM.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeDivCd", Me.cboChangeDivCd.TextValue)    ''교체구분코드
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AManageDivCd", Me.cboManageDivCd.TextValue)      ' 지국운영구분코드
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACombiningWork", Me.txtCombiningWork.TextValue)  ' 겸영내용 
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APrintRegionCd", Me.cboPrintRegionCd.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchRegionCd", Me.cboBranchRegionCd.TextValue)   ' 지국지역코드
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum1", Me.txtPhoneNum1.TextValue)   ' 전화번호1
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum2", Me.txtPhoneNum2.TextValue)  ' 전화번호2
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFaxNum", Me.txtFaxNum.TextValue)        ' 팩스번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMobileNum", Me.txtMobileNum.TextValue)  ' 핸드폰번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOfficeNum", Me.numOfficeNum.TextValue)  ' 분국수
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AHouseNum", Me.numHouseNum.TextValue)    ' 가구수
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositAmt", Me.numDepositAmt.TextValue)   ' 지국보증금
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositorNm", Me.txtDepositorNm.TextValue) ' 예금주명
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABankCd", Me.cboBankCd.TextValue)      ' 은행코드
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAccountNum", Me.txtAccountNum.TextValue)    ' 계좌번호
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUnitCost", "")  ''Me.numUnitCost.TextValue)      ' 일반단가
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASpecUnitCost", "")  ''Me.numSpecUnitCost.TextValue)  ' 특수단가
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeliveryPaperNum", Me.numDeliveryPaperNum.TextValue)   '발송부수
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribePaperNum", Me.numSubscribePaperNum.TextValue)   '독자부수
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AValPaperNum", Me.numValPaperNum.TextValue)             '본사유가
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAm7PaperNum", Me.numAm7PaperNum.TextValue)             'AM7부수
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchValPaperNum", Me.numBranchValPaperNum.TextValue) '지국유가
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATajirelation", Me.txtTajirelation.TextValue)      '타지국장과의 관계
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChangeReason", Me.txtChangeReason.TextValue)      '교체사유
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorNm", Me.txtGuarantorNm.TextValue)        '보증인성명
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorRelation", Me.txtGuarantorRelation.TextValue)  '보증인관계

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPostNum", Me.popGuarantorPostNum.TextValue)  '보증인 우편번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorAddr1", Me.txtGuarantorAddr1.TextValue)  '보증인 주소
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorAddr2", Me.txtGuarantorAddr2.TextValue)  '보증인 상세주소
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPhoneNum", Me.txtGuarantorPhoneNum.TextValue)  '보증인 연락처
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorMobileNum", Me.txtGuarantorMobileNum.TextValue)  '보증인 핸드폰

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorSocialNum", VBN.IIf(IsNothing(Me.txtGuarantorSocialNum.TextValue), "", Me.txtGuarantorSocialNum.TextValue))      '보증인주민번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGuarantorPropertyTaxAmt", Me.chkGuarantorPropertyTaxAmt.Checked) '보증인재산세납부
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorName", Me.txtOperatorName.TextValue)                     '운영자성명
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorRelation", Me.txtOperatorRelation.TextValue)      '운영자관계(계약자관계) 
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorSocialNum", VBN.IIf(IsNothing(Me.txtOperatorSocialNum.TextValue), "", Me.txtOperatorSocialNum.TextValue))           '운영자주민번호
                    '' '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractYN", Me.chkContractYN.Checked)            '계약완결여부
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorTelNum1", Me.txtOperatorTelNum1.TextValue)      '운영자 사무실번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorTelNum2", Me.txtOperatorTelNum2.TextValue)      '운영자 자택번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorMobileNum", Me.txtOperatorMobileNum.TextValue)  '운영자 핸드폰번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorFaxNum", Me.txtOperatorFaxNum.TextValue)    '운영자 팩스번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorPostNum", Me.popOperatorPostNum.TextValue)  '운영자 우편번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorAddr1", Me.txtOperatorAddr1.TextValue)      '운영자 주소
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOperatorAddr2", Me.txtOperatorAddr2.TextValue)      '운영자 상세주소

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASpecialIssue", Me.TxtSpecialIssue.TextValue)            '특이사항
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APropertyTaxPayAmt", Me.numPropertyTaxPayAmt.TextValue)  '재산세 납부액

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_CUD", True, False, GmainsqlParameters)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_2()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_2_CUD", True, False, GmainsqlParameters)
            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_2()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_2_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_3()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_4.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_3_CUD", True, False, GmainsqlParameters)
            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_3()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_4.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_3_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_4()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_5.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_4_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_4()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_5.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_4_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_5()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_6.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_5_CUD", True, False, GmainsqlParameters)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_5()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_6.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_5_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_6()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_7.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_7_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_6()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_7.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_7_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_7()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_8.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_8_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_7()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_8.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_8_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_8()
            '''' 단가
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_9.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_9_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_8()

            '''' 단가
            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_9.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_9_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub
        Public Sub SaveData_10()
            '''' 단가
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_10.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_A_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub
        '====================================================================================================
        Public Sub DeleteData_10()

            '''' 단가
            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_10.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB202_A_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub


        Public Sub GetNm()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                'If popBaseBranchCd_R.TextValue.Length < 1 Then
                '    MsgBox("지국 코드를 선택하십시오.")
                '    Exit Sub
                'Else
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", popBaseBranchCd_R.TextValue)
                'End If

                ' 본사 유가,발송 부수 설정
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

                ' 독자 부수
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
