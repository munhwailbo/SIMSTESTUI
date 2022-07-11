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

    Partial Class PNE301

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
                .SetSqlParameter(GmainsqlParameters, "@AdeliveryBranchCd", Me.popDeliveryBranchCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AreceiptCd", Me.txtReceiptCd_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@Aaddr", Me.txtAddr_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtFrom", Me.dtpReceiptDtFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDtTo", Me.dtpReceiptDtTo.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AcboReaderIn", Me.cboReaderInCd_r.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_R", False, True, GmainsqlParameters)
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
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPagerNum"), "합  계")


                    .set_TextMatrix(.FixedRows, .get_ColIndex("ExpandDivCd"), "    합  계")
                    Me.grd_1.FrozenRows = 1
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
            '    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE301_R", False, True, GmainsqlParameters)
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
            '        .SetExportCrystalDataParameter("PNE301_1_C_R.rpt", "PNE301_1_C_R", "", AsqlParameters, AformulaParameters)

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
            '    .SetExportCrystalDataParameter("PNE301_2_C_R.rpt", "PNE301_2_C_R", "", AsqlParameters, AformulaParameters)

            'End With

            'End If
          

        End Sub
    
    End Class

End Namespace
