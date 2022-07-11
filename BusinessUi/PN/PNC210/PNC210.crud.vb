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

    Partial Class PNC210

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
            If blnRequestYesOrNo Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)  '접수일자1
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)      '접수일자2
                    .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_2.TextValue)        ' 독자번호
                    .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)  ' 독자명
                    .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2.TextValue)          ' 전화번호1
                    .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2.TextValue)                  ' 주소
                    .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.popDeliveryBranchCd_2.TextValue)  ' 지국코드
                    .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue) ' 영업담당
                    ''.SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)    '' 구독상태구분
                    ''.SetSqlParameter(GmainsqlParameters, "@AState1", Me.chkState1.Checked)    '' 구독상태1
                    ''.SetSqlParameter(GmainsqlParameters, "@AState2", Me.chkState2.Checked)    '' 구독상태2
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC210_R", False, True, GmainsqlParameters)
                    Me.grd_1.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
            End If

            Call SetSubTotal()
        End Sub

        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    ''''' .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.RestrictAll
                    '-- cell merging
                    .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.RestrictRows
                    .ColumnCollection(.get_ColIndex("SubscribeCd")).AllowMerging = True
                    .ColumnCollection(.get_ColIndex("SubscribeCd2")).AllowMerging = True
                    .ColumnCollection(.get_ColIndex("Orders")).AllowMerging = True

                    ' ''        .Tree.Column = .get_ColIndex("ExpandDivCd")

                    ' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    ' ''        .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData    '' 'BelowData   '' AboveData

                    ' ''        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    ' ''        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

                    ' ''        ' '' =============================================================================
                    ' ''        '' '' '' 그리드 합계행 추가
                    ' ''        ' '' =============================================================================
                    ' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPagerNum"), "합계")
                    ' ''        ' '' =============================================================================
                    ' ''        Me.grd_1.FrozenRows = 1
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

            '' ''GmainsqlParameters = Nothing
            '' ''With GmainCommonFunction
            '' ''    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", GrecordProcessMode) 'Record
            '' ''    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

            '' ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC210_CUD", True, False, GmainsqlParameters)
            '' ''    .SetAllBusinessUiInitialValue(Me)
            '' ''    '' .SaveDataMessage(Me)
            '' ''End With
            '' ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '' ''    GrecordProcessMode = "2"
            '' ''    GmainCommonFunction.SaveDataMessage(Me)
            '' ''Else
            '' ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''End If

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

            ' ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC210_CUD", True, False, GmainsqlParameters)
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

