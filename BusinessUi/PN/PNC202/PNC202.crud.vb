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

    Partial Class PNC202

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
            lblRecordState.Text = "신규"
            GmainCommonFunction.ControlNewData(Me, Me.picIo_3)
            '''''''''''' GmainCommonFunction.ControlNewData(Me, Me.picIo_4)
            Me.dtpDeliveryReqDt.TextValue = System.DateTime.Now
            Me.dtpReceiptDt.TextValue = System.DateTime.Now
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
                .SetSqlParameter(GmainsqlParameters, "@AdeliveryBranchCd", Me.popDeliveryBranchCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)


                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

            End With
        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            '''' picIo_4 강제 셋팅 (구독 정보 상세 표시)
            With GmainCommonFunction
                If grd_1.Rows > 1 Then
                    .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))

                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_2_R", False, True, GmainsqlParameters)
                    'GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                    Me.txtReaderCd.Text = reciveDataSet.Tables(0).Rows(0).Item("ReaderCd").ToString
                    Me.txtReaderNm.Text = reciveDataSet.Tables(0).Rows(0).Item("ReaderNm").ToString
                    Me.txtPhoneNum1.Text = reciveDataSet.Tables(0).Rows(0).Item("PhoneNum1").ToString
                    Me.txtPhoneNum2.Text = reciveDataSet.Tables(0).Rows(0).Item("PhoneNum2").ToString
                    Me.txtMobileNum.Text = reciveDataSet.Tables(0).Rows(0).Item("MobileNum").ToString
                    Me.popOldPostNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("OldPostNum").ToString
                    Me.txtOldAddr1.Text = reciveDataSet.Tables(0).Rows(0).Item("OldAddr1").ToString
                    Me.txtOldAddr2.Text = reciveDataSet.Tables(0).Rows(0).Item("OldAddr2").ToString
                    Me.popNewPostNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("NewPostNum").ToString
                    Me.txtNewAddr1.Text = reciveDataSet.Tables(0).Rows(0).Item("NewAddr1").ToString
                    Me.txtNewAddr2.Text = reciveDataSet.Tables(0).Rows(0).Item("NewAddr2").ToString
                    Me.popDeliveryBranchCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DeliveryBranchCd").ToString
                    'Me.txtBranchPhoneNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchPhoneNum").ToString

                    Me.txtBranchPhoneNum.TextValue = ""
                    Me.popBizChargeCd.CodeText = reciveDataSet.Tables(0).Rows(0).Item("BizChargeCd").ToString
                    Me.txtChargePhoneNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ChargePhoneNum").ToString

                    reciveDataSet = Nothing

                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)

                End If


                

            End With

            '' ' grd_3 토요가정 배달 그리드 표시 
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_3_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            End With

        End Sub


        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainCommonFunction.ControlNewData(Me, Me.picIo_3)
            If grd_2.Rows <= grd_2.FixedRows Then Exit Sub

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                '' ''.SetSqlParameter(GmainsqlParameters, "@AReceiptDt", IIf(Me.grd_2.GetCurrentRowCellValue("ReceiptDt") = "|", "", Me.grd_2.GetCurrentRowCellValue("ReceiptDt")))
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", IIf(Me.grd_2.GetCurrentRowCellValue("ReaderCd") = "|", "", Me.grd_2.GetCurrentRowCellValue("ReaderCd")))
                .SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(IsNumeric(Me.grd_2.GetCurrentRowCellValue("Orders")), Me.grd_2.GetCurrentRowCellValue("Orders"), 0))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_4_R", False, True, GmainsqlParameters)
                If reciveDataSet.Tables.Count > 0 Then
                    lblRecordState.Text = "조회"
                    GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                End If

                '' '' ''txtNewAddr1.Text = reciveDataSet.Tables(0).Rows(0).Item("NewAddr1").ToString
                '' '' ''txtOldAddr1.Text = reciveDataSet.Tables(0).Rows(0).Item("OldAddr1").ToString
                '' '' ''Me.dtpDeliveryReqDt.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DeliveryReqDt").ToString
                '' '' ''Me.dtpReceiptDt.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ReceiptDt").ToString
                '' '' ''Me.txtIngStateCd.Text = reciveDataSet.Tables(0).Rows(0).Item("IngStateCd").ToString
                '' '' ''Me.popBranchCd.Text = reciveDataSet.Tables(0).Rows(0).Item("BranchCd").ToString
                '' '' ''Me.txtSatReceipName.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchNm").ToString
                '' '' ''Me.popBizEmpNumber.Text = reciveDataSet.Tables(0).Rows(0).Item("BizEmpNumber").ToString
                '' '' ''Me.txtName.Text = reciveDataSet.Tables(0).Rows(0).Item("Name").ToString

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

            End With

        End Sub

        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) '

                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.txtReaderCd.TextValue)         '독자코드
                .SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(Me.txtOrders.TextValue.ToString().Length < 1, "0", Me.txtOrders.TextValue)) '순번
                .SetSqlParameter(GmainsqlParameters, "@ASatReaderNm", Me.txtSatReaderNm.TextValue)   '토요독자명
                .SetSqlParameter(GmainsqlParameters, "@ASatPhoneNum1", Me.txtSatPhoneNum1.TextValue) '독자전화번호
                .SetSqlParameter(GmainsqlParameters, "@ASatMobileNum", Me.txtSatMobileNum.TextValue) '독자핸드폰번호

                .SetSqlParameter(GmainsqlParameters, "@ASatOldPostNum", Me.popSatOldPostNum.TextValue) '구우편번호
                .SetSqlParameter(GmainsqlParameters, "@ASatOldAddr1", Me.txtSatOldAddr1.TextValue)   '구주소
                .SetSqlParameter(GmainsqlParameters, "@ASatOldAddr2", Me.txtSatOldAddr2.TextValue)   '구상세주소
                .SetSqlParameter(GmainsqlParameters, "@ASatNewPostNum", Me.popSatNewPostNum.TextValue) '신우편번호
                .SetSqlParameter(GmainsqlParameters, "@ASatNewAddr1", Me.txtSatNewAddr1.TextValue)   '신주소
                .SetSqlParameter(GmainsqlParameters, "@ASatNewAddr2", Me.txtSatNewAddr2.TextValue)   '신상세주소

                .SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue)  '접수일자
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryReqDt", Me.dtpDeliveryReqDt.TextValue) '투입요청일
                .SetSqlParameter(GmainsqlParameters, "@ARealEdDt", IIf(Me.dtpRealEdDt.TextValue.ToString.Length < 1, "", Me.dtpRealEdDt.TextValue)) '중지일자
                .SetSqlParameter(GmainsqlParameters, "@ASatBranchCd", Me.popSatBranchCd.TextValue)   '지국코드
                .SetSqlParameter(GmainsqlParameters, "@AIngStateCd", Me.txtIngStateCd.TextValue)     '진행상태코드  

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryYn", Me.chkDeliveryYn.Checked)     '배달여부  
                .SetSqlParameter(GmainsqlParameters, "@AResultYn", Me.chkResultYn.Checked)     '통보여부  

                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_CUD", True, False, GmainsqlParameters)

            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GrecordProcessMode = "2"
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        Public Sub DeleteData()

            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")             '접수독자코드

                    .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.txtReaderCd.TextValue)         '독자코드
                    .SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(Me.txtOrders.TextValue.ToString().Length < 1, "0", Me.txtOrders.TextValue)) '순번
                    .SetSqlParameter(GmainsqlParameters, "@ASatReaderNm", Me.txtSatReaderNm.TextValue)   '토요독자명
                    .SetSqlParameter(GmainsqlParameters, "@ASatPhoneNum1", Me.txtSatPhoneNum1.TextValue) '독자전화번호
                    .SetSqlParameter(GmainsqlParameters, "@ASatMobileNum", Me.txtSatMobileNum.TextValue) '독자핸드폰번호

                    .SetSqlParameter(GmainsqlParameters, "@ASatOldPostNum", Me.popSatOldPostNum.TextValue) '구우편번호
                    .SetSqlParameter(GmainsqlParameters, "@ASatOldAddr1", Me.txtSatOldAddr1.TextValue)   '구주소
                    .SetSqlParameter(GmainsqlParameters, "@ASatOldAddr2", Me.txtSatOldAddr2.TextValue)   '구상세주소
                    .SetSqlParameter(GmainsqlParameters, "@ASatNewPostNum", Me.popSatNewPostNum.TextValue) '신우편번호
                    .SetSqlParameter(GmainsqlParameters, "@ASatNewAddr1", Me.txtSatNewAddr1.TextValue)   '신주소
                    .SetSqlParameter(GmainsqlParameters, "@ASatNewAddr2", Me.txtSatNewAddr2.TextValue)   '신상세주소

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue)  '접수일자
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryReqDt", Me.dtpDeliveryReqDt.TextValue) '투입요청일
                    .SetSqlParameter(GmainsqlParameters, "@ARealEdDt", IIf(Me.dtpRealEdDt.TextValue.ToString.Length < 1, "", Me.dtpRealEdDt.TextValue)) '중지일자
                    .SetSqlParameter(GmainsqlParameters, "@ASatBranchCd", Me.popSatBranchCd.TextValue)   '지국코드
                    .SetSqlParameter(GmainsqlParameters, "@AIngStateCd", Me.txtIngStateCd.TextValue)     '진행상태코드  

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryYn", Me.chkDeliveryYn.Checked)     '배달여부  
                    .SetSqlParameter(GmainsqlParameters, "@AResultYn", Me.chkResultYn.Checked)     '통보여부  

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC202_CUD", True, False, GmainsqlParameters)

                End With

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                MessageBox.Show("데이타가 삭제 되었습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End Sub


    End Class

End Namespace
