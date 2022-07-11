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

    Partial Class PNJ205

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

            sbGridInit()
            Dim strProcMode As String = "0"

            If optMode1.Checked Then strProcMode = "1" '' optMode1 : 소속사별,  optMode2 : 거래선별,  optMode3 : 거래선/소속사별
            If optMode2.Checked Then strProcMode = "2" '' optMode1 : 소속사별,  optMode2 : 거래선별,  optMode3 : 거래선/소속사별
            If optMode3.Checked Then strProcMode = "3" '' optMode1 : 소속사별,  optMode2 : 거래선별,  optMode3 : 거래선/소속사별

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARedeemDt", Me.dtpRedeemDt.TextValue)               ' 회수년월
                .SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.popEmployeeNumber.TextValue)   ' 담당
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.popCouponCorpCd.TextValue)       ' 소속사코드
                .SetSqlParameter(GmainsqlParameters, "@AProcMode", strProcMode)       ' 처리구분'' optMode1 : 소속사별,  optMode2 : 거래선별,  optMode3 : 거래선/소속사별
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ205_R", False, True, GmainsqlParameters)
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
                    .Tree.Column = .get_ColIndex("TreePath")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData    '' 'BelowData   '' AboveData
                    If Not (optMode1.Checked) Then
                        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue

                        For intII As Integer = 0 To 16  '''' .Cols - 11
                            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("cnt_" & (intII + 1).ToString()), "{0} 소계")
                        Next
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("Amount"), "{0} 소계")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("total"), "{0} 소계")
                    End If
                    If (optMode3.Checked) Then
                        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).BackColor = Color.LightYellow
                        .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).ForeColor = Color.Blue

                        For intII As Integer = 0 To 16  '''' .Cols - 11
                            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 2, .get_ColIndex("BranchNm"), .get_ColIndex("cnt_" & (intII + 1).ToString()), "{0} 소계")
                        Next
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 2, .get_ColIndex("BranchNm"), .get_ColIndex("Amount"), "{0} 소계")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 2, .get_ColIndex("BranchNm"), .get_ColIndex("total"), "{0} 소계")
                    End If
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    For intII As Integer = 0 To 16  '''' .Cols - 11
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("cnt_" & (intII + 1).ToString()), "합계")
                    Next
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Amount"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("total"), "합계")
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

            '' ''GmainsqlParameters = Nothing
            '' ''With GmainCommonFunction
            '' ''    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '' ''    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '' ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ205_CUD", True, False, GmainsqlParameters)
            '' ''    .SetAllBusinessUiInitialValue(Me)
            '' ''    '' .SaveDataMessage(Me)
            '' ''End With
            '' ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '' ''    GmainCommonFunction.SaveDataMessage(Me)
            '' ''Else
            '' ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''End If

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

            '' ''Dim result As DialogResult
            '' ''result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            '' ''If result = DialogResult.OK Then   '' Result Start
            '' ''    GmainsqlParameters = Nothing
            '' ''    With GmainCommonFunction
            '' ''        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '' ''        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '' ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ205_CUD", True, False, GmainsqlParameters)
            '' ''        .SetAllBusinessUiInitialValue(Me)
            '' ''        '' .SaveDataMessage(Me)
            '' ''    End With
            '' ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '' ''        MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''    Else
            '' ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''    End If
            '' ''End If   '' Result end

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
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpRedeemDt.TextValue)
                    ''.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNJ301_1_C_R.rpt", "PNJ301_1_C_R", "", AsqlParameters, AformulaParameters)
                End With



            ElseIf optExpAmt2.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AYYYY", Me.dtpRedeemDt.TextValue)
                    ''.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNJ301_2_C_R.rpt", "PNJ301_2_C_R", "", AsqlParameters, AformulaParameters)
                End With



                'ElseIf optExpAmt3.Checked = True Then

                '    With GmainCommonFunction
                '        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpRedeemDt.TextValue)
                '        ''.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

                '        'Dim AAAA As String = ""
                '        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                '        Dim AformulaParameters() As SqlParameter = Nothing

                '        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                '        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                '        ' 공통변수의정의가생성시에발생될수있도록유도한다.
                '        .SetExportCrystalDataParameter("PNH202_1_C_R.rpt", "PNH202_1_C_R", "", AsqlParameters, AformulaParameters)
                '    End With
            End If

        End Sub


    End Class
End Namespace
