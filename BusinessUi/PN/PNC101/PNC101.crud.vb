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

    [Partial] Class PNC101

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
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_3)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_4)

            'Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            'Me.dtpReceiptDtTo.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            Me.dtpContactDt.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            Me.popMonitoringEmpNum.TextValue = GmainBusinessFunction.GetValue("로그인 ID")

            cboExpandDivCd.TextValue = "2"
            cboCollectionTypeCd.TextValue = "2"
            numContactPaperNum.TextValue = "1"
        End Sub

        Public Sub NewData(ByVal dtpContactDtStr As String)

            'GmainCommonFunction.ControlNewData(Me, Me.picCriteria)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_3)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_4)

            'Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            'Me.dtpReceiptDtTo.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            Me.dtpContactDt.TextValue = dtpContactDtStr
            Me.popMonitoringEmpNum.TextValue = GmainBusinessFunction.GetValue("로그인 ID")

            cboExpandDivCd.TextValue = "2"
            cboCollectionTypeCd.TextValue = "2"
            numContactPaperNum.TextValue = "1"
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
            '' ''If txtReceiptCd_2.TextValue.ToString.Length < 1 _
            '' ''    And txtSubscriberNm_2.TextValue.ToString.Length < 1 _
            '' ''    And popDeliveryBranchCd_2.TextValue.ToString.Length < 1 _
            '' ''    And popEmployeeNumber.TextValue.ToString.Length < 1 _
            '' ''    And txtPhoneNum_2.TextValue.ToString.Length < 1 _
            '' ''    And txtAddr_2.TextValue.ToString.Length < 1 Then
            '' ''    blnRequestYesOrNo = False
            '' ''    MessageBox.Show("하나 이상의 검색 조건을 입력 하세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''End If
            If blnRequestYesOrNo Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AdeliveryBranchCd", Me.popDeliveryBranchCd_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_R", False, True, GmainsqlParameters)
                    Me.grd_1.SetDataSet(reciveDataSet)
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
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.grd_1.GetCurrentRowCellValue("ReceiptCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                GrecordProcessMode = "2"
            End With

        End Sub

        ''' <summary>
        ''' 함수명 : RequestDataSubscribeRemove
        ''' 기  능 : 이사 독자 신규 입력을 위한 독자 정보 조회
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestDataSubscribeRemove(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                ' '' ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_2_R", False, True, GmainsqlParameters)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGB", "2")      '' '' ''처리 구분 2:이사 독자 신규, 3:재확장 신규
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_5_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                dtpFixedStDt.TextValue = ""

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                GrecordProcessMode = "1"
            End With

        End Sub

        ''' <summary>
        ''' 함수명 : RequestDataSubscribeReExpand
        ''' 기  능 : 재확장 신규 입력을 위한 독자 정보 조회
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestDataSubscribeReExpand(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                ' '' ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_2_R", False, True, GmainsqlParameters)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGB", "3")      '' '' ''처리 구분 2:이사 독자 신규, 3:재확장 신규
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_5_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                dtpFixedStDt.TextValue = ""

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                GrecordProcessMode = "1"
            End With

        End Sub

        ''' <summary>
        ''' 함수명 : RequestDataWebExpand
        ''' 기  능 : WEB접수 독자 신규 입력을 위한 독자 정보 조회
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestDataWebExpand(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                ' '' ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_2_R", False, True, GmainsqlParameters)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", txtReceiptCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGB", "5")      '' '' ''처리 구분 2:이사 독자 신규, 3:재확장 신규, 5:WEB접수 전환
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_5_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                'dtpFixedStDt.TextValue = ""

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                GrecordProcessMode = "1"
            End With

        End Sub

        '''' <summary>
        '''' 함수명 : RequestData_3
        '''' 기  능 : 조회
        '''' 작성자 : 
        '''' 작성일 : 
        '''' 수정자 : 
        '''' 수정일 : 
        '''' </summary>
        '''' <param name="AprocessMessage"></param>
        '''' <remarks></remarks>
        Public Sub ChngAddResult()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                If dtpContactDt.TextValue = "" Then
                    MsgBox("접수일을 입력하세요.")
                    Return
                ElseIf txtTemp.TextValue = "" Then
                    MsgBox("우편번호를 확인하세요.")
                End If
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", txtTemp.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AContactDt", dtpContactDt.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_4_R", False, True, GmainsqlParameters)


                If Not IsNothing(reciveDataSet) Then
                    If reciveDataSet.Tables(0).Rows.Count > 0 Then

                        Me.popDeliveryBranchCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchCd")
                        Me.popAdBranchCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchCd")
                        Me.txtTrAdEmployeeNm.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchName")
                        Me.txtAdEmployeeNm.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchName")
                    Else
                        Exit Sub
                    End If
                Else
                    'popDeliveryBranchCd.TextValue = txtOldSubscribeCd.TextValue
                    'popAdBranchCd.TextValue = txtOldSubscribeCd.TextValue
                    Exit Sub
                End If
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

                .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue) '접수독자코드
                .SetSqlParameter(GmainsqlParameters, "@AContactDt", dtpContactDt.TextValue) '접수일자
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue) '독자명
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue) '독자상태코드

                .SetSqlParameter(GmainsqlParameters, "@AOldSubscribeCd", Me.txtOldSubscribeCd.TextValue) '독자 코드
                .SetSqlParameter(GmainsqlParameters, "@AOldSubscriberReceiptCd", Me.txtOldSubscriberReceiptCd.TextValue) '이전 접수독자코드
                .SetSqlParameter(GmainsqlParameters, "@AWebPkey", Me.numWebPkey.TextValue) 'Web접수독자 Pkey

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue) '투입처코드
                .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", Me.chkApprovalYN.Checked) '승인여부

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
                .SetSqlParameter(GmainsqlParameters, "@AAdBranchCd", popAdBranchCd.TextValue) '권유지국코드
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", txtTrAdEmployeeNm.TextValue) '권유자 명
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", txtAdEmployeeNm.TextValue) '실 권유자 명

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

                .SetSqlParameter(GmainsqlParameters, "@ASolicitorCorpCd", popSolicitorCorpCd.TextValue) '소속사코드
                .SetSqlParameter(GmainsqlParameters, "@ACouponReaderYN", chkCouponReaderYN.Checked) '구독권독자여부
                .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked) '권유자통보여부
                .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", dtpSolicitorNotifyDt.TextValue) '권유자통보일자
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", popMonitoringEmpNum.TextValue) '모니터 담당
                .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue) '비고
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GrecordProcessMode = "2"
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            Me.txtTemp.TextValue = ""

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
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", "3") 'Record 삭제
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptCd", txtReceiptCd.TextValue) '접수독자코드
                    .SetSqlParameter(GmainsqlParameters, "@AContactDt", dtpContactDt.TextValue) '접수일자
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", txtSubscriberNm.TextValue) '독자명
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", cboReaderStateCd.TextValue) '독자상태코드

                    .SetSqlParameter(GmainsqlParameters, "@AOldSubscribeCd", Me.txtOldSubscribeCd.TextValue) '독자 코드
                    .SetSqlParameter(GmainsqlParameters, "@AOldSubscriberReceiptCd", Me.txtReceiptCd.TextValue) '이전 접수독자코드
                    .SetSqlParameter(GmainsqlParameters, "@AWebPkey", Me.numWebPkey.TextValue) 'Web접수독자 Pkey

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", popDeliveryChnlCd.TextValue) '투입처코드
                    .SetSqlParameter(GmainsqlParameters, "@AApprovalYN", Me.chkApprovalYN.Checked) '승인여부

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
                    .SetSqlParameter(GmainsqlParameters, "@AAdBranchCd", popAdBranchCd.TextValue) '권유지국코드
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", txtTrAdEmployeeNm.TextValue) '권유자 명
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", txtAdEmployeeNm.TextValue) '실 권유자 명

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

                    .SetSqlParameter(GmainsqlParameters, "@ASolicitorCorpCd", popSolicitorCorpCd.TextValue) '소속사코드
                    .SetSqlParameter(GmainsqlParameters, "@ACouponReaderYN", chkCouponReaderYN.Checked) '구독권독자여부
                    .SetSqlParameter(GmainsqlParameters, "@ANotifyYN", chkNotifyYN.Checked) '권유자통보여부
                    .SetSqlParameter(GmainsqlParameters, "@ASolicitorNotifyDt", dtpSolicitorNotifyDt.TextValue) '권유자통보일자
                    .SetSqlParameter(GmainsqlParameters, "@AMonitoringEmpNum", popMonitoringEmpNum.TextValue) '모니터 담당
                    .SetSqlParameter(GmainsqlParameters, "@ANote", txtNote.TextValue) '비고
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_CUD", True, False, GmainsqlParameters)
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

