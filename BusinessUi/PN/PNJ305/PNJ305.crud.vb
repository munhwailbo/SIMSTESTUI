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

    Partial Class PNJ305

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
            Me.popEmployeeNumber.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
            Me.popEmployeeNumber.Enabled = GmainBusinessFunction.GetValue("로그인 ID") = "999999"
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
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AbranchNm", Me.txtBranchNm.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.popEmployeeNumber.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ305_R", False, True, GmainsqlParameters)
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
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData

                    ' '' =============================================================================
                    '' '' '' 그리드 담당 소계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).ForeColor = Color.Blue
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    For intII As Integer = .get_ColIndex("PaperNum") To .get_ColIndex("TransferAmt")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 2, .get_ColIndex("EmployeeNameHangul"), intII, "{0} 소계")
                    Next

                    ' '' =============================================================================
                    '' '' '' 그리드 팀 소계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue
                    ''.set_MergeCol(Me.grd_1.get_ColIndex("DeptNm"), True)
                    For intII As Integer = .get_ColIndex("PaperNum") To .get_ColIndex("TransferAmt")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("DeptNm"), intII, "{0} 소계")
                    Next
                    ''=============================================================================
                    '' '' 그리드 합계행 추가
                    '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    For intII As Integer = .get_ColIndex("PaperNum") To .get_ColIndex("TransferAmt")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, intII, "합 계")
                    Next

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

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ305_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '' '' '' 구독료 배분 생성
        '' ''Public Sub SaveData2()

        '' ''    Dim message As String = "기존 자료를 삭제 후 재생성 처리 합니다."
        '' ''    If MsgBox(message & vbCrLf & "처리 하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

        '' ''        GmainsqlParameters = Nothing

        '' ''        GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
        '' ''        GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "1")
        '' ''        GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)
        '' ''        ''''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

        '' ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ305_2_CUD", True, False, GmainsqlParameters)


        '' ''        If GmainExecuteDbCommand.GerrorNumber = 0 Then
        '' ''            GmainCommonFunction.SaveDataMessage(Me)
        '' ''        Else
        '' ''            MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '' ''        End If

        '' ''        GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        '' ''    End If

        '' ''End Sub

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
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ305_CUD", True, False, GmainsqlParameters)
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
         '       .SetExportCrystalDataParameter("PNJ305.rpt", "PNJ305_R", "", AsqlParameters, AformulaParameters)
         '   End With

        End Sub

    End Class

End Namespace
