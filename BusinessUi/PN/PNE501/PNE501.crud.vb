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

    Partial Class PNE501

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
            dtpProcYM_R.Text = Now.ToString
            numBaseDay_R.TextValue = 14

            grd_2.Rows = grd_2.FixedRows
            grd_1.Rows = grd_1.FixedRows

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

            grd_1.Rows = grd_1.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AprocYM", Me.dtpProcYM_R.TextValue)    ' 배분월
                .SetSqlParameter(GmainsqlParameters, "@AbaseDay", Me.numBaseDay_R.TextValue)   ' 기준일 (통상적으로 월의 중간일 14일로 함)
                .SetSqlParameter(GmainsqlParameters, "@AbranchCd", Me.popBranchCd_R.TextValue)   ' 지국
                .SetSqlParameter(GmainsqlParameters, "@AcompanyCd", Me.popCompanyCd_R.TextValue)   ' 접수처
                .SetSqlParameter(GmainsqlParameters, "@AemployeeExpNum", Me.popEmployeeExpNum_R.TextValue)   ' 접수번호
                .SetSqlParameter(GmainsqlParameters, "@AbillDivCd", Me.cboBillDivCd_R.TextValue)   ' 구분(접수유형) D1:판매(계산서) , D2:광고 , D3:판매(지+현)
                .SetSqlParameter(GmainsqlParameters, "@AallChek", IIf(chkAll.Checked, "1", "2"))   ' 구분(접수유형) D1:판매(계산서) , D2:광고 , D3:판매(지+현)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE501_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            'If Chkreceipt.Checked = True Then
            '    Call ExportData()
            'ElseIf ChkMonitor.Checked = True Then
            '    Call ExportData_2()
            'End If
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
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Cnt"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("diffPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amt"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DeductAmt"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TransferAmt"), "합  계")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("BillDivCd"), "    합  계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            grd_2.Rows = grd_2.FixedRows
            With GmainCommonFunction

                '.SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum").ToString.Substring(0, 8))
                '.SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum").ToString.Substring(0, 8))

                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.grd_1.GetCurrentRowCellValue("EmployeeExpDt"))
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.grd_1.GetCurrentRowCellValue("EmployeeExpDt"))

                .SetSqlParameter(GmainsqlParameters, "@ACollectionTypeCd", "1")   '수금 형태:1.본사수금, 2.지국수금, 0.      
                .SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNm", "")                      '권유자(부서)
                .SetSqlParameter(GmainsqlParameters, "@ADeliveryBranchNm", Me.grd_1.GetCurrentRowCellValue("BranchCd"))        '지국 
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.grd_1.GetCurrentRowCellValue("CompanyCd"))               '확장처 
                .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))          '접수번호 2017.12.28 권경원 추가 
                .SetSqlParameter(GmainsqlParameters, "@ABizChargeCd", "")                  '영업담당  
                .SetSqlParameter(GmainsqlParameters, "@AReaderStateCd", "")         '독자상태 
                .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", "")               '청구 방법

                .SetSqlParameter(GmainsqlParameters, "@ADeliveryChnlCd", "")       '투입처 
                .SetSqlParameter(GmainsqlParameters, "@AAdEmployeeNm", "")                '보조 권유자  
                .SetSqlParameter(GmainsqlParameters, "@ASubscriberNm", "")           '독자 명
                .SetSqlParameter(GmainsqlParameters, "@ARefuseReasonCd", "")   '모니터 통과
                .SetSqlParameter(GmainsqlParameters, "@AFixedEdDt", "")  '구독종료일자
                .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", "")

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE303_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            Call SetSubTotal2()
            'Call SetSubTotal()
        End Sub
        Private Sub SetSubTotal2()
            With Me.grd_2
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
                    Me.grd_2.FrozenRows = 1
                End If
            End With
        End Sub
        'gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;20;#,##0;c;" & "o;n;n;10;"       '(230)투입부수
        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)

            Dim RowCount As Integer = 0
            ''rowcount = me.grd_1.ge
            'GmainsqlParameters = Nothing
            'With GmainCommonFunction
            '    .SetSqlParameter(GmainsqlParameters, "@ABizDt", Me.dtpBizDt.TextValue)
            '    .SetSqlParameter(GmainsqlParameters, "@AprocGb", "2") '신규
            '    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE501_R", False, True, GmainsqlParameters)
            '    Me.grd_1.SetDataSet(reciveDataSet)
            '    reciveDataSet = Nothing
            '    .SetAllBusinessUiInitialValue(Me)

            '    Dim intII As Integer
            '    For intII = 1 To grd_1.Rows - grd_1.FixedRows
            '        grd_2.set_TextMatrix(intII, 0, "신규")
            '        Me.grd_2.SetCellCheck(intII, Me.grd_1.get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
            '    Next

            '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            '    If AprocessMessage = True Then .RequestDataMessage(Me)

            '    ''''Me.GrdSetColor()
            'End With

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

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE501_CUD", True, False, GmainsqlParameters)
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
            ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE501_CUD", True, False, GmainsqlParameters)
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

            'Dim AsqlParameters() As SqlParameter = Nothing
            'If optreceipt.Checked = True Then
            '    With GmainCommonFunction

            '        ' .SetSqlParameter(AsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)
            '        .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            '        .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            '        'Dim AAAA As String = ""
            '        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            '        Dim AformulaParameters() As SqlParameter = Nothing

            '        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            '        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            '        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            '        .SetExportCrystalDataParameter("PNE501_1_C_R.rpt", "PNE501_1_C_R", "", AsqlParameters, AformulaParameters)

            '    End With

            'ElseIf optMonitor.Checked = True Then
            'With GmainCommonFunction
            '    ''.SetSqlParameter(AsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))   ' 사원 확장 번호
            '    '.SetSqlParameter(AsqlParameters, "@AContactPaperNum", Me.grd_1.GetCurrentRowCellValue("FixedPaperNum"))  '확정 부수
            '    .SetSqlParameter(AsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
            '    .SetSqlParameter(AsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)

            '    'Dim AAAA As String = ""
            '    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            '    Dim AformulaParameters() As SqlParameter = Nothing

            '    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            '    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            '    ' 공통변수의정의가생성시에발생될수있도록유도한다.
            '    .SetExportCrystalDataParameter("PNE501_2_C_R.rpt", "PNE501_2_C_R", "", AsqlParameters, AformulaParameters)

            'End With

            'End If
          

        End Sub
    
    End Class

End Namespace
