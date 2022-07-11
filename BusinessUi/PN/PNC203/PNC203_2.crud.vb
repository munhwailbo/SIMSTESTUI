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

    Partial Class PNC203

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
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_3_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", Me.grd_1.GetCurrentRowCellValue("ReaderCd"))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_4_R", False, True, GmainsqlParameters)
                Me.grd_3.SetDataSet(reciveDataSet)

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

            Dim sDate As String
            sDate = System.DateTime.Now

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) '접수독자코드
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '접수독자코드
                .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '독자명
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '전화번호1
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '전화번호2
                .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '핸드폰번호
                .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", "") '신우편번호
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", "") '신주소
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '신상세주소
                .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", "") '구우편번호
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", "") '구주소
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '구상세주소
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_CUD", True, False, GmainsqlParameters)

            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            '------------------------------------------------------------------------------------------
            ' 독자 정보 변경시 이력 추가
            '------------------------------------------------------------------------------------------
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) '접수독자코드
                .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", 0) '일련번호
                .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '접수독자코드
                .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '독자명
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '전화번호1
                .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '전화번호2
                .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '핸드폰번호
                .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", "") '신우편번호
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", "") '신주소
                .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '신상세주소
                .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", "") '구우편번호
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", "") '구주소
                .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '구상세주소
                .SetSqlParameter(GmainsqlParameters, "@AProcessDt", sDate.Replace("-", "").Substring(0, 8)) '구상세주소
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_CUD", True, False, GmainsqlParameters)

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
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            Dim sDate As String
            sDate = System.DateTime.Now

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", 3) '접수독자코드
                    .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '접수독자코드
                    .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '독자명
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '전화번호1
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '전화번호2
                    .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '핸드폰번호
                    .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", "") '신우편번호
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", "") '신주소
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '신상세주소
                    .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", "") '구우편번호
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", "") '구주소
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '구상세주소
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC201_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                '------------------------------------------------------------------------------------------
                ' 독자 정보 변경시 이력 추가
                '------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) '접수독자코드
                    .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", 0) '일련번호
                    .SetSqlParameter(GmainsqlParameters, "@AreaderCd", txtReaderCd.TextValue) '접수독자코드
                    .SetSqlParameter(GmainsqlParameters, "@AreaderNm", txtReaderNm.TextValue) '독자명
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum1", txtPhoneNum1.TextValue) '전화번호1
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNum2", txtPhoneNum2.TextValue) '전화번호2
                    .SetSqlParameter(GmainsqlParameters, "@AMobileNum", txtMobileNum.TextValue) '핸드폰번호
                    .SetSqlParameter(GmainsqlParameters, "@ANewPostNum", "") '신우편번호
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr1", "") '신주소
                    .SetSqlParameter(GmainsqlParameters, "@ANewAddr2", txtNewAddr2.TextValue) '신상세주소
                    .SetSqlParameter(GmainsqlParameters, "@AOldPostNum", "") '구우편번호
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr1", "") '구주소
                    .SetSqlParameter(GmainsqlParameters, "@AOldAddr2", txtOldAddr2.TextValue) '구상세주소
                    .SetSqlParameter(GmainsqlParameters, "@AProcessDt", sDate.Replace("-", "").Substring(0, 8)) '구상세주소
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC203_CUD", True, False, GmainsqlParameters)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GrecordProcessMode = "2"
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

            End If

        End Sub

    End Class

End Namespace
