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

    Partial Class PNE503

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
            'Dim sdate As String
            'sdate = dtpBaseYear.TextValue.Substring(0, 4) + "01"

            '  판매보급비(배달비) 지급현황
            If optExpAmt1.Checked Then
                grd_1.Rows = grd_1.FixedRows
            End If

            '  판매보급비(배달비) 공제현황
            If optExpAmt1.Checked Then
                grd_2.Rows = grd_2.FixedRows
            End If
            'Grid_Initialize()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.Text)
                .SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", Me.popEmployeeExpNum_R.Text)
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.popBranchCd_R.Text)
                .SetSqlParameter(GmainsqlParameters, "@ABillTypeCd", Me.cboBillType_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AchkRemark", IIf(chkRemark.Checked, 1, 0))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE503_R", False, True, GmainsqlParameters)

                '  판매보급비(배달비) 지급현황
                If optExpAmt1.Checked Then
                    Me.grd_1.SetDataSet(reciveDataSet)
                    SetSubTotal_1()
                End If

                '  판매보급비(배달비) 공제현황
                If optExpAmt2.Checked Then
                    Me.grd_2.SetDataSet(reciveDataSet)
                    SetSubTotal_2()
                End If

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal_1()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    'If optExpAmt1.Checked Then   '판매보급비(배달비) 지급현황
                    .Tree.Column = .get_ColIndex("EmployeeExpNum")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData


                    ' '' =============================================================================
                    '' '' '' 지국  소계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue

                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("EmployeeExpNum"), "접수번호:{0}")
                    '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Max, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("GsPaperNum"), "{0} ")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("NewExpPapNum"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("ReExpPapNum"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("PaperNum"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("Amt"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("DeductAmt"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("TransferAmt"), "{0} 소계")

                    ''For intII As Integer = 1 To 9
                    ''    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ColAmt_" & intII.ToString), "{0} 소계")
                    ''Next
                    ' '' =============================================================================

                    '.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    '.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    ' ''.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("EmployeeExpNum"), "합계")
                    ' ''.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, -1, .get_ColIndex("EmployeeExpNum"), "소계")

                    '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("GsPaperNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PaperNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amt"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DeductAmt"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TransferAmt"), "합계")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("EmployeeExpNum"), "합  계")
                    Me.grd_1.FrozenRows = 1
                    ' End If
                End If
            End With
        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal_2()
            With Me.grd_2
                If .Rows > .FixedRows Then
                    'If optExpAmt2.Checked Then   ' 판매보급비(배달비) 공제현황
                    .Tree.Column = .get_ColIndex("EmployeeExpNum")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData


                    ' '' =============================================================================
                    '' '' '' 지국  소계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue

                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("EmployeeExpNum"), "접수번호:{0}")
                    '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Max, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("GsPaperNum"), "{0} ")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("NewExpPapNum"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("ReExpPapNum"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("PaperNum"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("Amt"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("DeductAmt"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("EmployeeExpNum"), .get_ColIndex("TransferAmt"), "{0} 소계")

                    ''For intII As Integer = 1 To 9
                    ''    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ColAmt_" & intII.ToString), "{0} 소계")
                    ''Next
                    ' '' =============================================================================

                    '.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    '.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    ' ''.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("EmployeeExpNum"), "합계")
                    ' ''.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, -1, .get_ColIndex("EmployeeExpNum"), "소계")

                    '.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("GsPaperNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PaperNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amt"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DeductAmt"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TransferAmt"), "합계")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("EmployeeExpNum"), "합  계")
                    Me.grd_2.FrozenRows = 1
                    'End If
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

            'GmainsqlParameters = Nothing
            'With GmainCommonFunction
            '    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE503_CUD", True, False, GmainsqlParameters)
            '    .SetAllBusinessUiInitialValue(Me)
            '    '' .SaveDataMessage(Me)
            'End With
            'If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '    GmainCommonFunction.SaveDataMessage(Me)
            'Else
            '    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'End If

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

            'Dim result As DialogResult
            'result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            'If result = DialogResult.OK Then   '' Result Start
            '    GmainsqlParameters = Nothing
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE503_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '        '' .SaveDataMessage(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            'End If   '' Result end

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

            If optExpAmt1.Checked = True Then
                '  판매보급비(배달비) 지급현황
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
                    .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.Text)
                    .SetSqlParameter(AsqlParameters, "@AEmployeeExpNum", Me.popEmployeeExpNum_R.Text)
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.Text)
                    .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillType_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AchkRemark", IIf(chkRemark.Checked, 1, 0))

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNE503_1_C_R.rpt", "PNE503_R", "", AsqlParameters, AformulaParameters)
                End With

            ElseIf optExpAmt2.Checked = True Then
                '  판매보급비(배달비) 공제현황

                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
                    .SetSqlParameter(AsqlParameters, "@ACompanyCd", Me.popCompanyCd.Text)
                    .SetSqlParameter(AsqlParameters, "@AEmployeeExpNum", Me.popEmployeeExpNum_R.Text)
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.Text)
                    .SetSqlParameter(AsqlParameters, "@ABillTypeCd", Me.cboBillType_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AchkRemark", IIf(chkRemark.Checked, 1, 0))

                    Dim AAAA As String = ""
                    AAAA = "{@장표ID}=" & "'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    '공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNE503_2_C_R.rpt", "PNE503_R", "", AsqlParameters, AformulaParameters)
                End With
                'ElseIf optExpAmt3.Checked = True Then

                'With GmainCommonFunction
                '    .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
                '    '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

                '    'Dim AAAA As String = ""
                '    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                '    Dim AformulaParameters() As SqlParameter = Nothing

                '    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                '    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                '    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                '    .SetExportCrystalDataParameter("PNI201_3_C_R.rpt", "PNI201_3_C_R", "", AsqlParameters, AformulaParameters)
                'End With
            End If

        End Sub

    End Class

End Namespace
