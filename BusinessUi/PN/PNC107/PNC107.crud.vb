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

    Partial Class PNC107

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
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)

            cboExpandDivCd_2.Enabled = False
            cboExpandDivCd_2.TextValue = "1"
            grd_1.Rows = 1

            cboMonitoringResultCd_E.Text = ""
            cboRefuseReasonCd_E.Text = ""
            popMonitoringEmpNum_E.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
            ' ''popMonitoringEmpNum_E.NameText = ""
            dtpMonitoringProcDt_E.Text = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10)
            txtMonitoringRemark_E.Text = "일괄 통과"

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

            '''''' btnApprovalAll.Text = "일괄 적용"
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AexpandDivCd", Me.cboExpandDivCd_2.TextValue)   ' 확장구분
                .SetSqlParameter(GmainsqlParameters, "@AreceiptDtFrom", Me.dtpReceiptDtFrom.TextValue) '접수일자1
                .SetSqlParameter(GmainsqlParameters, "@AreceiptDtTo", Me.dtpReceiptDtTo.TextValue) ' 접수일자2
                .SetSqlParameter(GmainsqlParameters, "@AmonitoringResultCd", Me.cboMonitoringResultCd_R.TextValue)  '모니터처리결과
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue) ' 모니터 담당 
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd  ", Me.PopCompanyCd_R.TextValue)   '확장처
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm  ", Me.txtAdEmployeeNm_R.TextValue)  '권유자

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC107_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            Call SetSubTotal()
        End Sub

        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue


                    ' '' =============================================================================
                    '' '' '' 그리드 합계행 추가
                    ' '' =============================================================================
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ContactPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPagerNum"), "합  계")
                    
                    .set_TextMatrix(.FixedRows, .get_ColIndex("ReaderStateCd"), "합   계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        'gridAttributes = gridAttributes & "|접수부수;ContactPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)
        '   gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;40;;c;" & "o;n;n;4;"       '(30)
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.grd_1.GetCurrentRowCellValue("ReceiptCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC103_2_R", False, True, GmainsqlParameters)
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
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC107_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
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

        End Sub
    End Class

End Namespace
