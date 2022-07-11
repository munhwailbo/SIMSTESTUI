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

    Partial Class PNC205

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
            cboExpandDivCd.Enabled = False
            GmainCommonFunction.ControlNewData(Me, Me.picCriteria)

            Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            Me.dtpReceiptDtTo.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")

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
                    .SetSqlParameter(GmainsqlParameters, "@AExpandDivCd", Me.cboExpandDivCd.TextValue)    '' 확장구분
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)    '' 구독상태구분
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd_R.TextValue)    '' 확장처코드
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC205_R", False, True, GmainsqlParameters)
                    Me.grd_1.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
            End If

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
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC205_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                ' ''GrecordProcessMode = "2"
                GmainCommonFunction.SaveDataMessage(Me)
                RequestData()
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

            ' ''Dim result As DialogResult
            ' ''result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            ' ''If result = DialogResult.OK Then   '' Result Start
            ' ''    GmainsqlParameters = Nothing
            ' ''    With GmainCommonFunction
            ' ''        .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", "3") 'Record 삭제
            ' ''        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

            ' ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC205_CUD", True, False, GmainsqlParameters)
            ' ''        .SetAllBusinessUiInitialValue(Me)
            ' ''        '' .SaveDataMessage(Me)
            ' ''    End With
            ' ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ' ''        MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ' ''    Else
            ' ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ' ''    End If
            ' ''End If   '' Result end

        End Sub

    End Class

End Namespace

