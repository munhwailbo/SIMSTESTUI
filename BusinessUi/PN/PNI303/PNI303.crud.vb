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

    Partial Class PNI303

        '====================================================================================================
        Public Sub NewData()
            ''With Me.grd_2
            ''    .AddRow()
            ''    .set_TextMatrix(.Rows - 1, .get_ColIndex("ReceiptDt"), System.DateTime.Today)
            ''    .set_TextMatrix(.Rows - 1, .get_ColIndex("BranchNum"), Me.grd_1.GetCurrentRowCellValue("BranchNum"))
            ''End With
            'GmainCommonFunction.ControlNewData(Me, Me.picCriteria_1)
            Me.cboOldOrNew.SelectedIndex = "0"
            'cboOldOrNew.Enabled = True
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOldOrNew", Me.cboOldOrNew.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI303_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            Call SetSubTotal()
        End Sub
        'gridAttributes = gridAttributes & "|전월적립누계액;LastDepositAmt;120;#,##0;r;" & "o;n;n;15;"       '(40)
        '          gridAttributes = gridAttributes & "|당월적립액;ThisInDepositAmt;120;#,##0;r;" & "o;n;n;15;"       '(50)
        '          gridAttributes = gridAttributes & "|당월환불액;ThisOutDepositAmt;120;#,##0;r;" & "o;n;n;15;"       '(60)
        '          gridAttributes = gridAttributes & "|당월적립누계액;ThisDepositAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
        Private Sub SetSubTotal()

            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Tree.Column = .get_ColIndex("TreePath")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData

                    ' '' =============================================================================
                    '' '' '' 그리드 담당 소계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    For intII As Integer = .get_ColIndex("UnColAmt") To .get_ColIndex("ThisDepositAmt")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), intII, "{0} 소계")
                    Next



                    ' '' =============================================================================
                    '' '' '' 그리드 합계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    For intII As Integer = .get_ColIndex("UnColAmt") To .get_ColIndex("ThisDepositAmt")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, intII, "합 계")
                    Next

                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
       
        '====================================================================================================
        Public Sub SaveData()

            ' ''GmainsqlParameters = Nothing

            ' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

            ' ''GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI303_CUD", True, False, GmainsqlParameters)

            ' ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ' ''    GmainCommonFunction.SaveDataMessage(Me)
            ' ''Else
            ' ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ' ''End If

            ' ''GmainCommonFunction.SetAllBusinessUiInitialValue(Me)


        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            ' ''If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

            ' ''    GmainsqlParameters = Nothing

            ' ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ' ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))

            ' ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI303_CUD", True, False, GmainsqlParameters)

            ' ''    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            ' ''    MessageBox.Show("데이타가 삭제 되었습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ''End If

        End Sub
        Public Sub ExportData()

            Dim AsqlParameters() As SqlParameter = Nothing

            With GmainCommonFunction
                .SetSqlParameter(AsqlParameters, "@ABaseYear", Me.dtpBaseYearMonths.TextValue)
                .SetSqlParameter(AsqlParameters, "@AOldOrNew", Me.cboOldOrNew.TextValue)
                'Dim AAAA As String = ""
                'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                Dim AformulaParameters() As SqlParameter = Nothing

                'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                ' 공통변수의정의가생성시에발생될수있도록유도한다.
                .SetExportCrystalDataParameter("PNI303_4_C_R.rpt", "PNI303_4_C_R", "", AsqlParameters, AformulaParameters)
            End With

        End Sub
        'Public Sub ExportData()

        '    Dim AsqlParameters() As SqlParameter = Nothing

        '    With GmainCommonFunction
        '        .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)

        '        'Dim AAAA As String = ""
        '        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

        '        Dim AformulaParameters() As SqlParameter = Nothing

        '        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
        '        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

        '        ' 공통변수의정의가생성시에발생될수있도록유도한다.
        '        .SetExportCrystalDataParameter("PNI303_2_C_R.rpt", "PNI303_2_C_R", "", AsqlParameters, AformulaParameters)
        '    End With

        'End Sub
        'Public Sub ExportData()

        '    Dim AsqlParameters() As SqlParameter = Nothing

        '    With GmainCommonFunction
        '        .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpBaseYearMonths.TextValue)

        '        'Dim AAAA As String = ""
        '        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

        '        Dim AformulaParameters() As SqlParameter = Nothing

        '        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
        '        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

        '        ' 공통변수의정의가생성시에발생될수있도록유도한다.
        '        .SetExportCrystalDataParameter("PNI303_3_C_R.rpt", "PNI303_3_C_R", "", AsqlParameters, AformulaParameters)
        '    End With

        'End Sub
    End Class

End Namespace
