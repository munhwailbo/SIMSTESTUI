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

    Partial Class PNC105

        ''' <summary>
        ''' 함수명 : NewData 
        ''' 기  능 : 신규 
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()
            'GmainCommonFunction.ControlNewData(Me, Me.picCriteria)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_3)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_4)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_5)

            'Me.dtpContactDt.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            dtpMonitoringProcDt.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")

            Me.cboExpandDivCd.Enabled = False   '확장구분 : 1.사원확장 고정
            ''Me.popEmployeeExpNum.Enabled = False   '사원확장번호 변경 불가
            Me.popCompanyCd.Enabled = False   '확장처코드 변경 불가

        End Sub
        ''' <summary>
        ''' 함수명 : RequestData 
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            Dim blnRequestYesOrNo As Boolean = True
            'If popCompanyCd.TextValue.ToString.Length < 1 _
            '    And popDeliveryPlace.TextValue.ToString.Length < 1 _
            '    And txtReceiptCd_2.TextValue.ToString.Length < 1 _
            '    And txtSubscriberNm_2.TextValue.ToString.Length < 1 _
            '    And txtPhoneNum_2.TextValue.ToString.Length < 1 _
            '    And txtAddr_2.TextValue.ToString.Length < 1 _
            '    And txtAdEmployeeNm_R.TextValue.ToString.Length < 1 Then
            '    blnRequestYesOrNo = False
            '    MessageBox.Show("하나 이상의 검색 조건을 입력 하세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'End If
            If blnRequestYesOrNo Then

                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum  ", Me.popEmployeeExpNum_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd  ", Me.popCompanyCd_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryPlace   ", Me.popDeliveryPlace_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_2_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", IIf(IsNothing(Me.dtpReceiptDtFrom.TextValue), "", Me.dtpReceiptDtFrom.TextValue))
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", IIf(IsNothing(Me.dtpReceiptDtTo.TextValue), "", Me.dtpReceiptDtTo.TextValue)) 'Me.dtpReceiptDtTo.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringResultCd", Me.cboMonitoringResultCd_r.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_R", False, True, GmainsqlParameters)
                    Me.grd_1.SetDataSet(reciveDataSet)
                    Me.txtReceiptCd_2_R.TextValue = vbNullString  '접수독자번호
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
            End If
        End Sub
        ''' <summary>
        ''' 함수명 : RequestData_2
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            Dim sToDate As String

            sToDate = Format(Now, "yyyy-MM-dd")
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.grd_1.GetCurrentRowCellValue("ReceiptCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                popMonitoringEmpNum.TextValue = IIf(Me.popMonitoringEmpNum.TextValue.Length < 1, GmainBusinessFunction.GetValue("로그인 ID"), Me.popMonitoringEmpNum.TextValue)
                dtpMonitoringProcDt.TextValue = IIf(Me.dtpMonitoringProcDt.TextValue.Length < 1, sToDate, Me.dtpMonitoringProcDt.TextValue)
                ''txtMonitoringRemark.Text = reciveDataSet.Tables(0).Rows(0)("MonitoringRemark").ToString.Replace("_&!@&_", vbCrLf)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            'If popMonitoringEmpNum.TextValue = "" Then popMonitoringEmpNum.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
        End Sub


    
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' ''Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
        ' ''    GmainsqlParameters = Nothing

        ' ''    With GmainCommonFunction
        ' ''        .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.grd_1.GetCurrentRowCellValue("ReceiptCd"))
        ' ''        Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_2_R", False, True, GmainsqlParameters)
        ' ''        GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
        ' ''        ''txtMonitoringRemark.Text = reciveDataSet.Tables(0).Rows(0)("MonitoringRemark").ToString.Replace("_&!@&_", vbCrLf)
        ' ''        reciveDataSet = Nothing
        ' ''        .SetAllBusinessUiInitialValue(Me)
        ' ''        If AprocessMessage = True Then .RequestDataMessage(Me)
        ' ''    End With
        ' ''    If popMonitoringEmpNum.TextValue = "" Then popMonitoringEmpNum.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
        ' ''End Sub
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''' <summary>
        ''' 함수명 : RequestData_3
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            'GmainsqlParameters = Nothing
            'With GmainCommonFunction

            '    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_3_R", False, True, GmainsqlParameters)
            '    Me.grd_3.SetDataSet(reciveDataSet)
            '    reciveDataSet = Nothing
            '    .SetAllBusinessUiInitialValue(Me)
            '    If AprocessMessage = True Then .RequestDataMessage(Me)
            'End With

        End Sub

        ''' <summary>
        ''' 함수명 : SaveData 
        ''' 기  능 : 저장
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode)    '상태코드
                .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue)        '접수독자코드
                .SetSqlParameter(GmainsqlParameters, "@AContactDt", IIf(IsNothing(dtpContactDt.TextValue), "", dtpContactDt.TextValue)) 'dtpContactDt.TextValue)             '접수일자
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue)       '독자명
                .SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", cboExpandDivCd.TextValue)         '확장 구분
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue)     '독자상태코드
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue)         '전화번호1
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue)         '전화번호2
                .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue)         '핸드폰번호
                .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", popOldPostNum.TextValue)       '구우편번호
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", txtOldAddr1.TextValue)           '구주소
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue)           '구상세주소
                .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", popNewPostNum.TextValue)       '신우편번호
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", txtNewAddr1.TextValue)           '신주소
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue)           '신상세주소

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchCd", popDeliveryBranchCd.TextValue) '투입지국코드
                .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", popBizChargeCd.TextValue)           '영업담당
                .SetSqlParameter(GmainsqlParameters, "@AFixedStDt", IIf(IsNothing(dtpFixedStDt.TextValue), "", dtpFixedStDt.TextValue))               '투입일자
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(dtpFixedEdDt.TextValue), "", dtpFixedEdDt.TextValue)) 'dtpFixedEdDt.TextValue)                '구독만료일자
                .SetSqlParameter(GmainsqlParameters, "@ACollectionYYYYMM", IIf(IsNothing(dtpCollectionYYYYMM.TextValue), "", dtpCollectionYYYYMM.TextValue)) 'dtpCollectionYYYYMM.TextValue)  '수금년월
                .SetSqlParameter(GmainsqlParameters, "@AContactPaperNum", numContactPaperNum.TextValue)    '접수부수
                .SetSqlParameter(GmainsqlParameters, "@AFixedPagerNum", numFixedPagerNum.TextValue)        '투입부수
                .SetSqlParameter(GmainsqlParameters, "@AServiceTerm", numServiceTerm.TextValue)            '서비스기간
                .SetSqlParameter(GmainsqlParameters, "@ABranchMessage", txtBranchMessage.TextValue)        '지국전달사항

                .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", popEmployeeExpNum.TextValue)     '사원확장번호
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", popCompanyCd.TextValue)               '확장처
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue)     '투입처코드
                .SetSqlParameter(GmainsqlParameters, "@ASalWtListYn", chkSalWtListYn.Checked)             '판매국작성명단
                .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", cboCollectionTypeCd.TextValue)  '수금구분코드
                .SetSqlParameter(GmainsqlParameters, "@ABillPeriodCd", cboBillPeriodCd.TextValue)            '수금주기코드
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryRegionCd", cboDeliveryRegionCd.TextValue)  '배달처구분코드
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryDivCd", cboDeliveryDivCd.TextValue)        '배달구분코드

                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNum", popTrAdEmployeeNum.TextValue)        '주권유자사번
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", popTrAdEmployeeNum.NameText)          '주권유자명
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptCd", popTrAdEmployeeDeptCd.TextValue)  '주권유자부서
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptNm", popTrAdEmployeeDeptCd.NameText)   '주권유자부서명
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNum", popAdEmployeeNum.TextValue)            '권유자사번
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", popAdEmployeeNum.NameText)              '권유자명
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptCd", popAdEmployeeDeptCd.TextValue)      '권유자부서
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptNm", popAdEmployeeDeptCd.NameText)       '권유자부서명
                .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue)                                 '비고

                '' '' -------  모니터 처리/ 권유자
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringResultCd", Me.cboMonitoringResultCd.TextValue) '모니터처리코드
                .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.cboRefuseReasonCd.TextValue)         '미통과사유코드
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringRemark", Me.txtMonitoringRemark.Text)          '모니터비고
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", Me.popMonitoringEmpNum.TextValue)          '담당자
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringProcDt", IIf(IsNothing(dtpMonitoringProcDt.TextValue), "", dtpMonitoringProcDt.TextValue)) 'Me.dtpMonitoringProcDt.TextValue)          '처리일자
                .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked)                      '권유자통보여부
                .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", IIf(IsNothing(dtpSolicitorNotifyDt.TextValue), "", dtpSolicitorNotifyDt.TextValue)) 'dtpSolicitorNotifyDt.TextValue)  '권유자통보일자
                .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", chkApprovalYN.Checked)                  '승인여부

                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                'GrecordProcessMode = "2"
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        ''' <summary>
        ''' 함수명 : DeleteData 
        ''' 기  능 : 삭제 
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", "3")       '삭제
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue)        '접수독자코드
                    .SetSqlParameter(GmainsqlParameters, "@AContactDt", IIf(IsNothing(dtpContactDt.TextValue), "", dtpContactDt.TextValue)) 'dtpContactDt.TextValue)             '접수일자
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue)       '독자명
                    .SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", cboExpandDivCd.TextValue)         '확장 구분
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue)     '독자상태코드
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue)         '전화번호1
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue)         '전화번호2
                    .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue)         '핸드폰번호
                    .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", popOldPostNum.TextValue)       '구우편번호
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", txtOldAddr1.TextValue)           '구주소
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue)           '구상세주소
                    .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", popNewPostNum.TextValue)       '신우편번호
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", txtNewAddr1.TextValue)           '신주소
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue)           '신상세주소

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchCd", popDeliveryBranchCd.TextValue) '투입지국코드
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", popBizChargeCd.TextValue)           '영업담당
                    .SetSqlParameter(GmainsqlParameters, "@AFixedStDt", IIf(IsNothing(dtpFixedStDt.TextValue), "", dtpFixedStDt.TextValue)) 'dtpFixedStDt.TextValue)                '투입일자
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(dtpFixedEdDt.TextValue), "", dtpFixedEdDt.TextValue)) 'dtpFixedEdDt.TextValue)                '구독만료일자
                    .SetSqlParameter(GmainsqlParameters, "@ACollectionYYYYMM", IIf(IsNothing(dtpCollectionYYYYMM.TextValue), "", dtpCollectionYYYYMM.TextValue)) ' dtpCollectionYYYYMM.TextValue)  '수금년월
                    .SetSqlParameter(GmainsqlParameters, "@AContactPaperNum", numContactPaperNum.TextValue)    '접수부수
                    .SetSqlParameter(GmainsqlParameters, "@AFixedPagerNum", numFixedPagerNum.TextValue)        '투입부수
                    .SetSqlParameter(GmainsqlParameters, "@AServiceTerm", numServiceTerm.TextValue)            '서비스기간
                    .SetSqlParameter(GmainsqlParameters, "@ABranchMessage", txtBranchMessage.TextValue)        '지국전달사항

                    .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", popEmployeeExpNum.TextValue)     '사원확장번호
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", popCompanyCd.TextValue)               '확장처
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue)     '투입처코드
                    .SetSqlParameter(GmainsqlParameters, "@ASalWtListYn", chkSalWtListYn.Checked)             '판매국작성명단
                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", cboCollectionTypeCd.TextValue)  '수금구분코드
                    .SetSqlParameter(GmainsqlParameters, "@ABillPeriodCd", cboBillPeriodCd.TextValue)            '수금주기코드
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryRegionCd", cboDeliveryRegionCd.TextValue)  '배달처구분코드
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryDivCd", cboDeliveryDivCd.TextValue)        '배달구분코드

                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNum", popTrAdEmployeeNum.TextValue)        '주권유자사번
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", popTrAdEmployeeNum.NameText)          '주권유자명
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptCd", popTrAdEmployeeDeptCd.TextValue)  '주권유자부서
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptNm", popTrAdEmployeeDeptCd.NameText)   '주권유자부서명
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNum", popAdEmployeeNum.TextValue)            '권유자사번
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", popAdEmployeeNum.NameText)              '권유자명
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptCd", popAdEmployeeDeptCd.TextValue)      '권유자부서
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptNm", popAdEmployeeDeptCd.NameText)       '권유자부서명
                    .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue)                                 '비고

                    '' '' -------  모니터 처리/ 권유자
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringResultCd", Me.cboMonitoringResultCd.TextValue) '모니터처리코드
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.cboRefuseReasonCd.TextValue)         '미통과사유코드
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringRemark", Me.txtMonitoringRemark.Text)          '모니터비고
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", Me.popMonitoringEmpNum.TextValue)          '담당자
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringProcDt", IIf(IsNothing(dtpMonitoringProcDt.TextValue), "", dtpMonitoringProcDt.TextValue)) ' Me.dtpMonitoringProcDt.TextValue)          '처리일자
                    .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked)                      '권유자통보여부
                    .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", IIf(IsNothing(dtpSolicitorNotifyDt.TextValue), "", dtpSolicitorNotifyDt.TextValue)) ' dtpSolicitorNotifyDt.TextValue)  '권유자통보일자
                    .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", chkApprovalYN.Checked)                  '승인여부

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC105_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If   '' Result end

        End Sub

    End Class

End Namespace
