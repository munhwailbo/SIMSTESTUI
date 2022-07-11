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
    Partial Class PNE305

        '====================================================================================================
        Public Sub NewData()

            Me.grd_1.AddRow()
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("ExpandDt"), dtpFromExpand.Text)

            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("TargetPaperTotNum"), "0")    '|접수부수
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NewExpPapNum"), "0")         '|신규부수
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("ReExpPapNum"), "0")          '|재확장부수
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NoListPapNum"), "0")         '|명단없는부수
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedPaperNum"), "0")        '|확정부수
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("SubscribePagerNum"), "0")    '|투입부수
            Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NoSubscribePagerNum"), "0")  '|미투입부수

            'If grd_1.GetCurrentRowCellValue("CollectionDivCd") = "2" Then

            '    Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedStDt"), DateAdd(DateInterval.Day, -1, sdate))
            '    Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, sdate))))

            'End If

        End Sub


        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFromExpandDt", Me.dtpFromExpand.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AToExpandDt", Me.dtpToExpand.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.Text)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE305_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            Call SetSubTotal()
        End Sub
        Private Sub SetSubTotal()
            '    With Me.grd_1
            '        If .Rows > .FixedRows Then

            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
            '            .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
            '            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
            '            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue


            '            ' '' =============================================================================
            '            '' '' '' 그리드 합계행 추가
            '            ' '' =============================================================================
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "합  계")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NewExpPapNum"), "합  계")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReExpPapNum"), "합  계")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NoListPapNum"), "합  계")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "합  계")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SubscribePagerNum"), "합  계")
            '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("NoSubscribePagerNum"), "합  계")
            '            .set_TextMatrix(.FixedRows, .get_ColIndex("ExpandDt"), "합   계")
            '            Me.grd_1.FrozenRows = 1
            '        End If
            '    End With
        End Sub
        '            gridAttributes = gridAttributes & "|접수부수;TargetPaperTotNum;60;;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|신규부수;NewExpPapNum;60;;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|재확장부수;ReExpPapNum;60;;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|명단없는부수;NoListPapNum;60;#,###;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;60;#,###;r;" & "io;n;n;5;"
        '            gridAttributes = gridAttributes & "|투입부수;SubscribePagerNum;60;#,###;r;" & "o;n;n;5;"
        '            gridAttributes = gridAttributes & "|미투입부수;NoSubscribePagerNum;60;#,###;r;" & "o;n;n;5;"
        '====================================================================================================


        '====================================================================================================

        '====================================================================================================
        Public Sub SaveData()


            If MsgBox("저장하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE305_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                GmainsqlParameters = Nothing

                GmainExecuteDbCommand.GerrorNumber = 1
                GmainExecuteDbCommand.GerrorDescription = "저장취소"
            End If

        End Sub


        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE305_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)

            End If

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

            With GmainCommonFunction
                .SetSqlParameter(AsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))   ' 사원 확장 번호
                .SetSqlParameter(AsqlParameters, "@AContactPaperNum", Me.grd_1.GetCurrentRowCellValue("FixedPaperNum"))  '확정 부수


                'Dim AAAA As String = ""
                'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                Dim AformulaParameters() As SqlParameter = Nothing

                'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                ' 공통변수의정의가생성시에발생될수있도록유도한다.
                .SetExportCrystalDataParameter("PNE305_1_C_R.rpt", "PNE305_1_C_R", "", AsqlParameters, AformulaParameters)

            End With

        End Sub

        ''지국 수금일 경우 시작 , 종료 일자 날짜 셋팅
        'Private Sub grd_1_CellChanged(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.CellChanged

        '    Dim sdate As Date

        '    sdate = IIf(grd_1.GetCurrentRowCellValue("ExpandDt") = "" Or grd_1.GetCurrentRowCellValue("ExpandDt"), dtpFromExpand.Text, grd_1.GetCurrentRowCellValue("ExpandDt"))


        '    'If sdate <> "" And grd_1.GetCurrentRowCellValue("CollectionDivCd") = "2" Then
        '    '    If grd_1.GetCurrentRowCellValue("FixedStDt") <> "" Or grd_1.GetCurrentRowCellValue("FixedEdDt") <> "" Then

        '    '        Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedStDt"), DateAdd(DateInterval.Day, -1, sdate))
        '    '        Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Month, 1, sdate))))

        '    '    End If
        '    'End If


        'End Sub

    End Class

End Namespace
