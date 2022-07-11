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

    Partial Class PNE303

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

            If optReceipt.Checked = True Then
                Me.Grd_1.Visible = True
                Me.Grd_2.Visible = False
                Me.Grd_3.Visible = False
                Me.grd_4.Visible = False
                Me.grd_5.Visible = False

                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                      '권유자(부서)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '지국 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 '확장처 
                    .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", "")                                   '접수번호 2017.12.28 권경원 추가-명단부수차이조정 화면이랑 맞춰주기 위해 편법으로 파라미터 넘김
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                  '영업담당  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '독자상태 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               '청구 방법

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_R", False, True, GmainsqlParameters)
                    Me.Grd_1.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal()
            ElseIf optMonitor.Checked = True Then
                Me.Grd_1.Visible = False
                Me.Grd_2.Visible = True
                Me.Grd_3.Visible = False
                Me.grd_4.Visible = False
                Me.grd_5.Visible = False
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '권유자(부서)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '지국 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                '확장처 
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '영업담당  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '독자상태 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              '청구 방법

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_2_R", False, True, GmainsqlParameters)
                    Me.Grd_2.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal_1()
            ElseIf optstop.Checked = True Then
                Me.Grd_1.Visible = False
                Me.Grd_2.Visible = False
                Me.Grd_2.Visible = True
                Me.grd_4.Visible = False
                Me.grd_5.Visible = False
                GmainsqlParameters = Nothing

                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '지국
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 '확장처
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '영업담당
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_3_R", False, True, GmainsqlParameters)
                    Me.Grd_3.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal_2()
            ElseIf Me.optHeadOfficeDelivery.Checked = True Then
                Me.Grd_1.Visible = False
                Me.Grd_2.Visible = False
                Me.Grd_3.Visible = False
                Me.grd_4.Visible = True
                Me.grd_5.Visible = False
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '권유자(부서)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '지국 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                '확장처 
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '영업담당  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '독자상태 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              '청구 방법

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_4_R", False, True, GmainsqlParameters)
                    Me.grd_4.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal_3()
            ElseIf Me.optBranchDelivery.Checked = True Then
                Me.Grd_1.Visible = False
                Me.Grd_2.Visible = False
                Me.Grd_3.Visible = False
                Me.grd_4.Visible = False
                Me.grd_5.Visible = True
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '권유자(부서)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '지국 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                '확장처 
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '영업담당  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '독자상태 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              '청구 방법

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_5_R", False, True, GmainsqlParameters)
                    Me.grd_5.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
                Call SetSubTotal_4()
            End If
        End Sub

        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum1"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SubscribePagerNum"), "합계")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "합   계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        Private Sub SetSubTotal_1()
            With Me.Grd_2
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "합계")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "합   계")
                    Me.Grd_2.FrozenRows = 1
                End If
            End With
        End Sub
        Private Sub SetSubTotal_2()
            With Me.Grd_3
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum1"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "합계")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "합   계")
                    Me.Grd_3.FrozenRows = 1
                End If
            End With
        End Sub

        Private Sub SetSubTotal_3()
            With Me.grd_4
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum1"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "합계")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "합   계")
                    Me.grd_4.FrozenRows = 1
                End If
            End With
        End Sub

        Private Sub SetSubTotal_4()
            With Me.grd_5
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum1"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "합계")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("ContactDt4"), "합   계")
                    Me.grd_5.FrozenRows = 1
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

            Dim AsqlParameters() As SqlParameter = Nothing
            If optReceipt.Checked = True Then
                With GmainCommonFunction

                    .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
                    .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                    '주권유자명
                    .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '지국 
                    .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 '확장처 
                    .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                  '영업담당  
                    .SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)         '독자상태 
                    .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)               '청구 방법

                    .SetSqlParameter(AsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
                    .SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
                    .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                    .SetSqlParameter(AsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
                    .SetSqlParameter(AsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
                    .SetSqlParameter(AsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNE301_1_C_R.rpt", "PNE301_1_C_R", "", AsqlParameters, AformulaParameters)

                End With

            ElseIf optMonitor.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
                    .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '권유자(부서)
                    .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '지국 
                    .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                '확장처 
                    .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '영업담당  
                    .SetSqlParameter(AsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '독자상태 
                    .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              '청구 방법

                    .SetSqlParameter(AsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
                    .SetSqlParameter(AsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
                    .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                    .SetSqlParameter(AsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
                    .SetSqlParameter(AsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
                    .SetSqlParameter(AsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

                    Dim AformulaParameters() As SqlParameter = Nothing
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNE301_2_C_R.rpt", "PNE301_2_C_R", "", AsqlParameters, AformulaParameters)

                End With
            ElseIf optstop.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)
                    .SetSqlParameter(AsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태
                    .SetSqlParameter(AsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)        '지국
                    .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                 '확장처
                    .SetSqlParameter(AsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '영업담당
                    .SetSqlParameter(AsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명

                    Dim AformulaParameters() As SqlParameter = Nothing
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNE303_3_C_R.rpt", "PNE303_3_C_R", "", AsqlParameters, AformulaParameters)
                End With
            End If

        End Sub

        '====================================================================================================
        Public Function GetDataSet(Optional ByVal AprocessMessage As Boolean = True) As DataSet

            If Me.optHeadOfficeDelivery.Checked = True Then
                Me.grd_1.Visible = False
                Me.grd_2.Visible = False
                Me.grd_3.Visible = False
                Me.grd_4.Visible = True
                Me.grd_5.Visible = False
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
                    .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '권유자(부서)
                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.popDeliveryBranchNm.Text)       '지국 
                    .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)                '확장처 
                    .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.popBizChargeCd.Text)                 '영업담당  
                    .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '독자상태 
                    .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              '청구 방법

                    .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.PopDeliveryChnlNm.TextValue)       '투입처 
                    .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
                    .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                    .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
                    .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
                    .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_9_R", False, True, GmainsqlParameters)
                    GetDataSet = reciveDataSet
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With

            ElseIf Me.optBranchDelivery.Checked = True Then
                Me.grd_1.Visible = False
                Me.grd_2.Visible = False
                Me.grd_3.Visible = False
                Me.grd_4.Visible = False
                Me.grd_5.Visible = True
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    '.SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                    '.SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

                    '.SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", Me.cboCollectionTypeCd.TextValue)   '수금 형태      
                    '.SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", Me.txtDeptNm.Text)                     '권유자(부서)
                    '.SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.txtDeliveryBranchNm.TextValue)       '지국 
                    '.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.txtCompanyCd.TextValue)                '확장처 
                    '.SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", Me.txtBizChargeCd.Text)                 '영업담당  
                    '.SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", Me.cboReaderStateCd.TextValue)        '독자상태 
                    '.SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillTypeCd.TextValue)              '청구 방법

                    '.SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", Me.txtDeliveryChnlNm.TextValue)       '투입처 
                    '.SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", Me.txtAdEmployeeNm.Text)                '보조 권유자  
                    '.SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", Me.txtSubscriberNm.TextValue)           '독자 명
                    '.SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", Me.CboMonitoringResultCd.TextValue)   '모니터 통과
                    '.SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", IIf(IsNothing(Me.dtpFixedEdDt.TextValue), "", Me.dtpFixedEdDt.TextValue))  '구독종료일자
                    '.SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)

                    'Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("IRIS_SR.dbo.SRF001_10_R", False, True, GmainsqlParameters)
                    'GetDataSet = reciveDataSet
                    'reciveDataSet = Nothing
                    '.SetAllBusinessUiInitialValue(Me)
                    'If AprocessMessage = True Then .RequestDataMessage(Me)
                End With

            End If
        End Function

    End Class

End Namespace
