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

    Partial Class PNH101

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
            Me.grd_1.AddRow()
            With grd_1
                .set_TextMatrix(.Rows - 1, .get_ColIndex("YYYYMM"), String.Format("{0:yyyy-MM}", dtpBaseYear.Value))
                .set_TextMatrix(.Rows - 1, .get_ColIndex("DD"), dtpBaseYear.Value.Day.ToString())
            End With
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
                .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AEmployee", Me.txtEmployee_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", "1")    '' 1:조회, 2:신규
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNH101_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            Call SetSubTotal()
        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal()

            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Tree.Column = .get_ColIndex("TreePath")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData

                    ' '' =============================================================================
                    '' '' '' 그리드 담당 소계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).ForeColor = Color.Blue
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    For intII As Integer = .get_ColIndex("YdPaperNumY") To .get_ColIndex("PrintPaperNumT")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 2, .get_ColIndex("EmployeeNameHangul"), intII, "{0} 소계")
                    Next

                    ' '' =============================================================================
                    '' '' '' 그리드 팀 소계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    For intII As Integer = .get_ColIndex("YdPaperNumY") To .get_ColIndex("PrintPaperNumT")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("DeptNm"), intII, "{0} 소계")
                    Next

                    ' '' =============================================================================
                    '' '' '' 그리드 합계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    For intII As Integer = .get_ColIndex("YdPaperNumY") To .get_ColIndex("PrintPaperNumT")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, intII, "합 계")
                    Next

                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AEmployee", Me.txtEmployee_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", "2")    '' 1:조회, 2:신규
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNH101_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)

                Dim intII As Integer
                For intII = 1 To grd_1.Rows - grd_1.FixedRows
                    grd_1.set_TextMatrix(intII, 0, "신규")
                    Me.grd_1.SetCellCheck(intII, Me.grd_1.get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                Next

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            Call SetSubTotal()
        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            If grd_1.Rows > 1 Then
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", Me.grd_1.GetCurrentRowCellValue("YYYYMM"))
                    .SetSqlParameter(GmainsqlParameters, "@ADD", Me.grd_1.GetCurrentRowCellValue("DD"))
                    .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))
                    .SetSqlParameter(GmainsqlParameters, "@APrintOfficeCd", Me.grd_1.GetCurrentRowCellValue("PrintOfficeCd"))
                    .SetSqlParameter(GmainsqlParameters, "@APrintPlateCd", Me.grd_1.GetCurrentRowCellValue("PrintPlateCd"))

                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNH101_2_R", False, True, GmainsqlParameters)
                    If reciveDataSet.Tables.Count > 0 Then
                        GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                    End If

                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)

                    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
            End If

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

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNH101_CUD", True, False, GmainsqlParameters)
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

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNH101_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If   '' Result end

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

            '   Dim AsqlParameters() As SqlParameter = Nothing
            '
            '   With GmainCommonFunction
            '       .SetSqlParameter(AsqlParameters, "@AcodeDivisionHangulName", Me.txtCodeDivisionHangulName.TextValue)
            '       .SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)
            '
            '       'Dim AAAA As String = ""
            '       'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"
            '
            '       Dim AformulaParameters() As SqlParameter = Nothing
            '
            '       'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            '       .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")
            '
            '       ' 공통변수의정의가생성시에발생될수있도록유도한다.
            '       .SetExportCrystalDataParameter("PNH101.rpt", "PNH101_R", "", AsqlParameters, AformulaParameters)
            '   End With

        End Sub

    End Class

End Namespace
