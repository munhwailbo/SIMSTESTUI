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
    Partial Class PNE421

        '====================================================================================================
        Public Sub NewData()

            Me.grd_2.AddRow()
            grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("EmployeeExpNum"), Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))
            grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("ExpandNm"), Me.grd_1.GetCurrentRowCellValue("ExpandNm"))
            grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CompanyCd"), Me.grd_1.GetCurrentRowCellValue("CompanyCd"))
            grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CompanyNm"), Me.grd_1.GetCurrentRowCellValue("CompanyNm"))
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFromExpandDt", Me.dtpFromExpand.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AToExpandDt", Me.dtpToExpand.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", Me.popEmployeeExpNum_R.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillType", Me.cboBillType_R.TextValue)  '' 청구유형 [2505]

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE421_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing
            SetSubTotal_1()

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE421_2_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            ''SetSubTotal_2()

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE421_3_R", False, True, GmainsqlParameters)
            Me.grd_3.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            SetSubTotal_3()

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE421_30_R", False, True, GmainsqlParameters)
            Me.grd_3.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

            Dim intII As Integer
            For intII = 1 To grd_3.Rows - grd_3.FixedRows
                grd_3.set_TextMatrix(intII, 0, "신규")
                Me.grd_3.SetCellCheck(intII, Me.grd_3.get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
            Next
            SetSubTotal_3()

        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal_1()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "합계")
                    ''.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DmdAmount"), "합계")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("EmployeeNameHangul"), "합  계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal_3()
            With Me.grd_3
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DmdPapNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DmdAmount"), "합계")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("EmployeeNameHangul"), "합  계")
                    Me.grd_3.FrozenRows = 1
                End If
            End With
        End Sub

        '====================================================================================================
        Public Sub SaveData()
            Dim blnChk2 As Boolean = False
            Dim blnChk3 As Boolean = False

            If MsgBox("저장하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                '' =====================================================================
                '' =====  청구 이력 저장
                '' =====================================================================
                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE421_2_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    ''GmainCommonFunction.SaveDataMessage(Me)
                    blnChk2 = True
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                '' =====================================================================
                '' =====  상세 계획 저장
                '' =====================================================================
                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE421_3_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    ''GmainCommonFunction.SaveDataMessage(Me)
                    blnChk3 = True
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                If blnChk2 Then RequestData_2()
                If blnChk3 Then RequestData_3()

            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            Dim blnChk2 As Boolean = False
            Dim blnChk3 As Boolean = False

            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                '' =====================================================================
                '' =====  청구 이력 삭제
                '' =====================================================================
                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE421_2_CUD", True, False, GmainsqlParameters)
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    ''MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    blnChk2 = True
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "청구 이력 삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                '' =====================================================================
                '' =====  상세 계획 삭제
                '' =====================================================================
                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(True))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE421_3_CUD", True, False, GmainsqlParameters)
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    ''MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    blnChk3 = True
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "상세 계획 삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                If blnChk2 Then RequestData_2()
                If blnChk3 Then RequestData_3()
            End If

        End Sub


    End Class

End Namespace
