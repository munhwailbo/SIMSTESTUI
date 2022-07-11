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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN
    Partial Class PNE201

        '====================================================================================================
        Public Sub NewData()
            'Me.grd_1.AddRow()
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFromExpandDt", Me.dtpFromExpand.TextValue)  ' 확장일자(From)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AToExpandDt", Me.dtpToExpand.TextValue)      ' 확장일자(To)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.Text)              ' 확장처
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeNum", Me.popTrAdEmployeeNum.Text)  ' 권유자
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATrAdEmployeeDeptCd", Me.popTrAdEmployeeDeptCd.Text)    ' 권유부서

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE201_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
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
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("TargetPaperTotNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReFixedPaperNum"), "합  계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("StopPaperNum"), "합  계")
                   
                    .set_TextMatrix(.FixedRows, .get_ColIndex("EmployeeExpNum"), "합   계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        'gridAttributes = gridAttributes & "|접수부수;TargetPaperTotNum;70;#,###;r;" & "o;n;n;5;"
        'gridAttributes = gridAttributes & "|신규확장부수;FixedPaperNum;70;#,###;r;" & "o;n;n;5;"
        'gridAttributes = gridAttributes & "|재확장부수;ReFixedPaperNum;70;#,###;r;" & "o;n;n;5;"
        'gridAttributes = gridAttributes & "|조정부수;StopPaperNum;70;#,###;r;" & "io;n;n;40;"

        '====================================================================================================
        Public Sub SaveData()

            If MsgBox("저장하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE201_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)


            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE201_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)

            End If

        End Sub

        
       
        Public Sub ExportData()

            Dim AsqlParameters() As SqlParameter = Nothing
            If optReceipt.Checked = True Then
                With GmainCommonFunction

                    ' .SetSqlParameter(AsqlParameters, "@AsubscriberNm", Me.txtSubscriberNm_2.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AFromExpandDt", Me.dtpFromExpand.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AToExpandDt", Me.dtpToExpand.TextValue)
                    .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNum", Me.popTrAdEmployeeNum.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNE201_1_C_R.rpt", "PNE201_1_C_R", "", AsqlParameters, AformulaParameters)

                End With

            ElseIf optMonitor.Checked = True Then
                With GmainCommonFunction
                    ''.SetSqlParameter(AsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))   ' 사원 확장 번호
                    '.SetSqlParameter(AsqlParameters, "@AContactPaperNum", Me.grd_1.GetCurrentRowCellValue("FixedPaperNum"))  '확정 부수
                    .SetSqlParameter(AsqlParameters, "@AFromExpandDt", Me.dtpFromExpand.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AToExpandDt", Me.dtpToExpand.TextValue)
                    .SetSqlParameter(AsqlParameters, "@ATrAdEmployeeNum", Me.popTrAdEmployeeNum.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNE201_3_C_R.rpt", "PNE201_1_C_R", "", AsqlParameters, AformulaParameters)

                End With

            End If


        End Sub
    End Class

End Namespace
