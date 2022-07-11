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

    Partial Class PNE202

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
            Me.grd_1.AddRow()
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
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFromPayYearMonths", Me.dtpFromPayYearMonths.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AToPayYearMonths", Me.dtpToPayYearMonths.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.popTrAdEmployeeNum.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptCode", Me.popDeptName.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AprocGb", "1")   ' 처리구분 1:조회, 2:신규

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            If reciveDataSet.Tables(0).Rows(0).Item("CloseYesOrNo") = True Then
                Me.btnApplyClose.Enabled = False
                Me.btnCancelClose.Enabled = True
                Me.btnCreateSale.Enabled = False
            Else
                Me.btnApplyClose.Enabled = True
                Me.btnCancelClose.Enabled = False
                Me.btnCreateSale.Enabled = True
            End If


            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
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
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ExpPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewStopPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReStopPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewRealPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReRealPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpAmount"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpAmountBelow50"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpAmountBelow100"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpAmountAbove101"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SupportAmt"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("IncomeTax"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("InhabitantsTax"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SumTax"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ExpAmount"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("OneMillionWon"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("HundredThousandWon"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TenThousandWon"), "합  계")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("PayYearMonths"), "합   계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        'gridAttributes = gridAttributes & "|신규확장부수;NewExpPaperNum;90;#,##0;c;" & "o;n;n;4;"    '(70) 신규확장부수
        '   gridAttributes = gridAttributes & "|재확장부수;ReExpPaperNum;90;#,##0;c;" & "o;n;n;4;"       '(70) 재확장부수
        '   gridAttributes = gridAttributes & "|확장부수계;ExpPaperNum;90;#,##0;c;" & "o;n;n;4;"         '(70) 확장부수계
        '   gridAttributes = gridAttributes & "|조정부수;StopPaperNum;90;#,##0;c;" & "o;n;n;4;"          '(70) 중지부수
        '   gridAttributes = gridAttributes & "|정산부수;RealPaperNum;90;#,##0;c;" & "o;n;n;4;"          '(70) 중지부수
        'gridAttributes = gridAttributes & "|과세고료;SupportAmt;90;#,##0;r;" & "o;n;n;4;"      '(70) 과세고료
        '          gridAttributes = gridAttributes & "|소득세;IncomeTax;90;#,##0;r;" & "o;n;n;4;"           '(70) 원천세 - 소득세
        '          gridAttributes = gridAttributes & "|주민세;InhabitantsTax;90;#,##0;r;" & "o;n;n;4;"      '(70) 원천세 - 주민세
        '          gridAttributes = gridAttributes & "|확장비금액;ExpAmount;90;#,##0;r;" & "o;n;n;4;"        '(70) 확장비(실지급액)
        'Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)

        '    GmainsqlParameters = Nothing
        '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APayYearMonths", Me.dtpPayYearMonths.TextValue)
        '    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AprocGb", "2")   ' 처리구분 1:조회, 2:신규

        '    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_R", False, True, GmainsqlParameters)
        '    Me.grd_1.SetDataSet(reciveDataSet)
        '    reciveDataSet = Nothing

        '    Dim intII As Integer
        '    For intII = 1 To grd_1.Rows - grd_1.FixedRows
        '        grd_1.set_TextMatrix(intII, 0, "신규")
        '        Me.grd_1.SetCellCheck(intII, Me.grd_1.get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
        '    Next

        '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        '    If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        'End Sub

        'Private Sub SetSubTotal()
        '    '' ''With Me.grd_1
        '    '' ''    If .Rows > .FixedRows Then
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
        '    '' ''        .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
        '    '' ''        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
        '    '' ''        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("UnColAmt"), "합계")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SalesAmt"), "합계")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TotalDemandAmt"), "합계")

        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNumTot"), "합계")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NoValPaperNumTot"), "합계")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum1"), "합계")

        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale1"), "합계")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum2"), "합계")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale2"), "합계")

        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum3"), "합계")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale3"), "합계")
        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum4"), "합계")

        '    '' ''        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperSale4"), "합계")




        '    '' ''        .set_TextMatrix(.FixedRows, .get_ColIndex("CollectYYYYMM"), "합   계")
        '    '' ''        Me.grd_1.FrozenRows = 1
        '    '' ''    End If
        '    '' ''End With
        'End Sub

        '====================================================================================================
        Public Sub SaveData()

            Dim message As String = "기존 자료를 삭제 후 재생성 처리 합니다."
            If MsgBox(message & vbCrLf & "처리 하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "1")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpPayYearMonths.TextValue)  ' 사원확장비 지급 년월
                ''''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_CUD", True, False, GmainsqlParameters)


                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                    RequestData()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            End If

        End Sub

        Public Sub SaveData_2(ByVal RecordProcessMode As String)

            If MsgBox("처리 하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", RecordProcessMode)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpReversionYearMonth.TextValue)  '마감처리일자

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_2_CUD", True, False, GmainsqlParameters)


                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                    RequestData()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            ' ''If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

            ' ''    GmainsqlParameters = Nothing

            ' ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ' ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            ' ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE202_CUD", True, False, GmainsqlParameters)

            ' ''    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            ' ''    MessageBox.Show("데이타가 삭제 되었습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ''End If

        End Sub

    End Class

End Namespace
