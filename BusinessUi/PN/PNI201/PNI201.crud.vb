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

    Partial Class PNI201

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
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACollectYYYYMM", Me.dtpCollectYYYYMM.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AprocGb", "1")   '' ' 처리 구분 1:조회 , 2:신규

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI201_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            Call SetSubTotal()
        End Sub
        '그리드 합계행 추가
        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("FixedPaperNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("BillAmt"), "합계")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("EmployeeExpNum"), "      합   계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACollectYYYYMM", Me.dtpCollectYYYYMM.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popCompanyCd.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AprocGb", "2")   '' ' 처리 구분 1:조회 , 2:신규

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI201_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            Dim intII As Integer
            For intII = 1 To grd_1.Rows - grd_1.FixedRows
                grd_1.set_TextMatrix(intII, 0, "신규")
                Me.grd_1.SetCellCheck(intII, Me.grd_1.get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
            Next

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            Call SetSubTotal()

        End Sub

        '====================================================================================================
        Public Sub SaveData()

            Dim message As String = "기존 자료를 삭제 후 재생성 처리 합니다."
            If MsgBox(message & vbCrLf & "처리 하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "1")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpCollectYYYYMM.TextValue)  ' 대행구독료 청구 기준 년월
                ''''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI201_CUD", True, False, GmainsqlParameters)


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

            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpCollectYYYYMM.TextValue)  ' 대행구독료 청구 기준 년월
                ''''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI201_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            End If

        End Sub
        Public Sub ExportData()

          
        End Sub
    End Class

End Namespace
