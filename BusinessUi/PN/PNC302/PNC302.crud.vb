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

    Partial Class PNC302

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
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
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
                .SetSqlParameter(GmainsqlParameters, "@AReaderNm", Me.txtReaderNm.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReaderCd", Me.txtReaderCd.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ADivCd", Me.cboDivCd.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub


        ''====================================================================================================
        'Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

        '    GmainsqlParameters = Nothing
        '    With GmainCommonFunction
        '        .SetSqlParameter(GmainsqlParameters, "@AReaderCd", Me.grd_1.GetCurrentRowCellValue(""))
        '        Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_2_R", False, True, GmainsqlParameters)
        '        Me.grd_2.SetDataSet(reciveDataSet)
        '        reciveDataSet = Nothing
        '        .SetAllBusinessUiInitialValue(Me)
        '        If AprocessMessage = True Then .RequestDataMessage(Me)
        '    End With

        'End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
                GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.grd_1.GetCurrentRowCellValue("민원접수일"))
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADivCd", Me.grd_1.GetCurrentRowCellValue("민원구분코드"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", Me.grd_1.GetCurrentRowCellValue("구독코드"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.grd_1.GetCurrentRowCellValue("순번"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                Me.cboDivCd_1.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DivCd").ToString().Split(".")(0)
                'Me.cboIngStateCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("IngStateCd").ToString().Split(".")(0)

                reciveDataSet = Nothing
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
                'Me.cboDivCd_1.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DivCd").ToString().Split(".")(0)




            End With
        End Sub

        Public Sub SaveData()
            GmainsqlParameters = Nothing

            'If Me.grd_1.GetCurrentRowCellValue("구독코드") = dtpReceiptDt.TextValue Then
            '    GrecordProcessMode = 2
            'Else
            '    GrecordProcessMode = 1
            'End If
            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@ARecordprocessMode", GrecordProcessMode)
                .SetSqlParameter(GmainsqlParameters, "@ALoginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDt_1", dtpReceiptDt.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AOrders", txtOrders.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ADivCd_1", cboDivCd.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReaderNmNote", txtReaderNmNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@APhoneNumNote", txtPhoneNumNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AAddrNote", txtAddrNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchNmNote", txtBranchNmNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AContent", txtContent.Text)
                .SetSqlParameter(GmainsqlParameters, "@ADeptNm", txtDeptNm.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AResultInformCd", cboResultInformCd.TextValue)          ' 지국 통보
                .SetSqlParameter(GmainsqlParameters, "@AIngStateCd", cboIngStateCd.TextValue)                  ' 진행상태
                .SetSqlParameter(GmainsqlParameters, "@AResultNote", txtResultNote.TextValue)                  ' 처리결교ㅑ 
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringProcDt", dtpMonitoringProcDt.TextValue)      ' 처리일자
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_CUD", True, False, GmainsqlParameters)

                ',   @AReceiptDt_1                               nvarchar(8)           ----(10)   접수일자
                '   ,   @AOrders int
                '   ,   @ADivCd_1                                   nvarchar(10)          ----(50)   민원구분코드
                '   ,   @AReaderNmNote                            nvarchar(100)         ----(60)   독자명비고
                '   ,   @APhoneNumNote                            nvarchar(30)          ----(70)   전화번호비고
                '   ,   @AAddrNote                                nvarchar(100)         ----(80)   주소비고
                '   ,   @ABranchNmNote                            nvarchar(30)          ----(90)   지국명비고
                '   ,   @ADeptNm                                  nvarchar(30)          ----(100)  부명
                '   ,   @AContent                                 nvarchar(1000)        ----(110)  내용
                '   ,   @AResultInformCd                          nvarchar(10)          ----(120)  지국통보코드
                '   ,   @AIngStateCd
                '   ,   @AResultNote                              nvarchar(1000)        ----(130)  처리결과
                '   ,   @AMonitoringProcDt                        nvarchar(8)           ----(150)  모니터처리일자

                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub



        Public Sub DeleteData()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                GrecordProcessMode = 3
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordprocessMode", GrecordProcessMode)
                    .SetSqlParameter(GmainsqlParameters, "@ALoginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDt_1", dtpReceiptDt.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ADivCd_1", cboDivCd.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReaderNmNote", txtReaderNmNote.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNumNote", txtPhoneNumNote.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AAddrNote", txtAddrNote.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ABranchNmNote", txtBranchNmNote.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AContent", txtContent.Text)
                    .SetSqlParameter(GmainsqlParameters, "@ADeptNm", txtDeptNm.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AResultInformCd", cboResultInformCd.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AIngStateCd", cboIngStateCd.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AResultNote", txtResultNote.TextValue)

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_3_CUD", True, False, GmainsqlParameters)
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