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

    Partial Class PNC201

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
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_3)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_4)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_5)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_6)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1_7)
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

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AsubscribeCd", popSubscribeCd_R.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                ''txtMonitoringRemark.Text = reciveDataSet.Tables(0).Rows(0)("MonitoringRemark").ToString.Replace("_&!@&_", vbCrLf)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

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

                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) 'Record

                .SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", txtSubscribeCd.TextValue) '독자번호
                .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue) '접수독자코드
                .SetSqlParameter(GmainsqlParameters, "@AContactDt", dtpContactDt.TextValue) '접수일자
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue) '독자명
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue) '독자상태코드
                .SetSqlParameter(GmainsqlParameters, "@ASubscribeStateCd", cboSubscribeStateCd.TextValue) '구독상태코드
                .SetSqlParameter(GmainsqlParameters, "@ARealEdDt", IIf(dtpRealEdDt.TextValue.ToString.Length < 1, "", dtpRealEdDt.TextValue)) '중지일자

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue) '투입처코드
                '''''''.SetSqlParameter(GmainsqlParameters, "@AApprovalYN", Me.chkApprovalYN.Checked) '승인여부

                .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '전화번호1
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '전화번호2
                .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '핸드폰번호
                .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", popNewPostNum.TextValue) '신우편번호
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", txtNewAddr1.TextValue) '신주소
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '신상세주소
                .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", popOldPostNum.TextValue) '구우편번호
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", txtOldAddr1.TextValue) '구주소
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '구상세주소

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchCd", popDeliveryBranchCd.TextValue) '투입지국코드
                .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", popBizChargeCd.TextValue) '영업담당자

                ''.SetSqlParameter(GmainsqlParameters, "@AAdBranchCd", popAdBranchCd.TextValue) '권유지국코드
                ''.SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", txtTrAdEmployeeNm.TextValue) '권유자 명
                ''.SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", txtAdEmployeeNm.TextValue) '실 권유자 명

                .SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", cboExpandDivCd.TextValue) '확장 구분
                .SetSqlParameter(GmainsqlParameters, "@AMHReaderDivCd", cboMHReaderDivCd.TextValue) '본사독자구분코드 
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryRegionCd", cboDeliveryRegionCd.TextValue) '배달처구분코드
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryDivCd", cboDeliveryDivCd.TextValue) '배달구분코드
                .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", cboCollectionTypeCd.TextValue) '수금형태코드
                .SetSqlParameter(GmainsqlParameters, "@ABillPeriodCd", cboBillPeriodCd.TextValue) '수금주기코드

                .SetSqlParameter(GmainsqlParameters, "@AContactPaperNum", numContactPaperNum.TextValue) '접수부수
                .SetSqlParameter(GmainsqlParameters, "@AFixedPagerNum", numFixedPagerNum.TextValue) '투입부수
                .SetSqlParameter(GmainsqlParameters, "@AFixedStDt", dtpFixedStDt.TextValue) '투입일자
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", dtpFixedEdDt.TextValue) '구독만료일자
                .SetSqlParameter(GmainsqlParameters, "@ACollectionYYYYMM", dtpCollectionYYYYMM.TextValue) '수금년월
                .SetSqlParameter(GmainsqlParameters, "@AServiceTerm", numServiceTerm.TextValue) '서비스기간

                ' 2015.01.29 명단관리 추가
                .SetSqlParameter(GmainsqlParameters, "@AMngStopDt", dtpMngStopDt.TextValue) '명단관리일자
                .SetSqlParameter(GmainsqlParameters, "@AMngRemark", txtMngRemark.TextValue) '명단비고
                ' 2015.01.29 명단관리 추가

                .SetSqlParameter(GmainsqlParameters, "@ASolicitorCorpCd", popSolicitorCorpCd.TextValue) '소속사코드
                .SetSqlParameter(GmainsqlParameters, "@ACouponReaderYN", chkCouponReaderYN.Checked) '구독권독자여부
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked) '권유자통보여부
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", dtpSolicitorNotifyDt.TextValue) '권유자통보일자

                '' '' -------  모니터 처리/ 권유자
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNum", popTrAdEmployeeNum.TextValue) '주권유자명
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptCd", popTrAdEmployeeDeptCd.TextValue)         '주권유자부서
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNum", popAdEmployeeNum.TextValue)          '권유자명
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeDeptCd", popAdEmployeeDeptCd.TextValue)     '권유자부서
                .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue) '비고
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringResultCd", cboMonitoringResultCd.TextValue) '모니터처리결과코드
                .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", cboRefuseReasonCd.TextValue)         '미통과사유코드
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", popMonitoringEmpNum.TextValue)     '담당자
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringRemark", txtMonitoringRemark.Text)          '모니터비고
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringProcDt", dtpMonitoringProcDt.TextValue)     '처리일자
                .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked)                      '권유자통보여부
                .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", dtpSolicitorNotifyDt.TextValue)  '권유자통보일자
                .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", chkApprovalYN.Checked)                  '승인여부

                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GrecordProcessMode = "2"
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub
        ''' <summary>
        ''' 함수명 : DeleteData 
        ''' 기  능 : 삭제
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-08-17
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            'Dim result As DialogResult
            'result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            'If result = DialogResult.OK Then   '' Result Start
            '    GmainsqlParameters = Nothing
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", 3) '접수독자코드
            '        .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '접수독자코드
            '        .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '독자명
            '        .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '전화번호1
            '        .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '전화번호2
            '        .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '핸드폰번호
            '        .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", popNewPostNum.TextValue) '신우편번호
            '        .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", txtNewAddr1.TextValue) '신주소
            '        .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '신상세주소
            '        .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", popOldPostNum.TextValue) '구우편번호
            '        .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", txtOldAddr1.TextValue) '구주소
            '        .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '구상세주소
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '        '' .SaveDataMessage(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            'End If   '' Result end

        End Sub

    End Class

End Namespace
