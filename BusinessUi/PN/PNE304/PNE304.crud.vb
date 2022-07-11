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

    Partial Class PNE304

        ''' <summary>
        ''' 함수명 : NewData 
        ''' 기  능 : 신규 
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()
            'If grd_2.Focused = True Then
            '    Me.NewData_2()
            '    Exit Sub
            'End If
            'Me.grd_1.AddRow()
        End Sub
        ''' <summary>
        ''' 함수명 : RequestData
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                      '권유자(부서)
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '지국 
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 '확장처 
                .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                  '영업담당  
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '독자상태 
                .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               '청구 방법

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDtFr", IIf(IsNothing(Me.dtpFixedEdDtFr.TextValue), "", Me.dtpFixedEdDtFr.TextValue))  '구독종료일자
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDtTo", IIf(IsNothing(Me.dtpFixedEdDtTo.TextValue), "", Me.dtpFixedEdDtTo.TextValue))  '구독종료일자
                .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE304_R", False, True, GmainsqlParameters)
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
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPNum_new"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPNum_re"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPNum_tot"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPagerNum"), "합계")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("TrAdEmployeeDeptNm"), "합   계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        ''' <summary>
        ''' 함수명 : SaveData 
        ''' 기  능 : 저장
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            Dim RowCount As Integer = 0

            ''GmainsqlParameters = Nothing
            ''With GmainCommonFunction
            ''    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ''    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_CUD", True, False, GmainsqlParameters)
            ''    .SetAllBusinessUiInitialValue(Me)
            ''    '' .SaveDataMessage(Me)
            ''End With
            ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ''    GmainCommonFunction.SaveDataMessage(Me)
            ''Else
            ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''End If

        End Sub

        ''' <summary>
        ''' 함수명 : DeleteData 
        ''' 기  능 : 삭제
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()
            Dim RowCount As Integer = 0

            ''Dim result As DialogResult
            ''result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            ''If result = DialogResult.OK Then   '' Result Start
            ''    GmainsqlParameters = Nothing
            ''    With GmainCommonFunction
            ''        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ''        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_CUD", True, False, GmainsqlParameters)
            ''        .SetAllBusinessUiInitialValue(Me)
            ''        '' .SaveDataMessage(Me)
            ''    End With
            ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ''        MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''    Else
            ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ''    End If
            ''End If   '' Result end

        End Sub

        ''' <summary>
        ''' 함수명 : ExportData 
        ''' 기  능 : 출력
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ExportData()

            ' '' ''Dim AsqlParameters() As SqlParameter = Nothing
            ' '' ''If optReceipt.Checked = True Then
            ' '' ''    With GmainCommonFunction

            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                    '주권유자명
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '지국 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 '확장처 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                  '영업담당  
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '독자상태 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               '청구 방법

            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            ' '' ''        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            ' '' ''        .SetExportCrystalDataParameter("PNE301_1_C_R.rpt", "PNE301_1_C_R", "", AsqlParameters, AformulaParameters)

            ' '' ''    End With

            ' '' ''ElseIf optMonitor.Checked = True Then
            ' '' ''    With GmainCommonFunction

            ' '' ''        '.SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtDeptNm.Text)                      '권유자(부서)
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '지국 
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 '확장처 
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.txtBizChargeCd.Text)                  '영업담당  
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '독자상태 
            ' '' ''        '.SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               '청구 방법

            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '권유자(부서)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '지국 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                '확장처 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '영업담당  
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '독자상태 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              '청구 방법

            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            ' '' ''        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            ' '' ''        .SetExportCrystalDataParameter("PNE301_2_C_R.rpt", "PNE301_2_C_R", "", AsqlParameters, AformulaParameters)

            ' '' ''    End With
            ' '' ''ElseIf optstop.Checked = True Then
            ' '' ''    With GmainCommonFunction
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '지국
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 '확장처
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '영업담당
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명

            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            ' '' ''        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            ' '' ''        .SetExportCrystalDataParameter("PNE304_3_C_R.rpt", "PNE304_3_C_R", "", AsqlParameters, AformulaParameters)
            ' '' ''    End With
            ' '' ''End If

        End Sub

    End Class

End Namespace
