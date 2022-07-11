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
 
Namespace ubiLease.UI.BusinessUi.PS  
 
    Partial Class PSB104 
 
        Public Sub NewData() 
           ' If grd_2.Focused = True Then 
           '     Me.NewData_2() 
           '     Exit Sub 
           ' End If 
           ' Me.grd_1.AddRow() 
           '   
           ' GrecordProcessMode = 1 
           ' GmainCommonFunction.ControlNewData(Me, Me.picIo_2) 
           '   
           ' '컨트롤 초기값 설정 
           ' 'Me.SetControlInAdvance() 
        End Sub 
 
 '''' -------------------------------------------------------------------
 ''''  RequestData 
 '''' -------------------------------------------------------------------
 
		Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)  
 
           ' If grd_2.Focused = True Then  
           '     Me.RequestData_2() 
           '     Exit Sub 
           ' End If 
 
            NewData()
            Me.grd_1.Rows = Me.grd_1.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                If Me.optGb1.Checked Then    ' 발행년월 조건기준일때 
                    .SetSqlParameter(GmainsqlParameters, "@APubDateFr", dtpPubYYmm_R.TextValue & "01")    ''발행일자
                    .SetSqlParameter(GmainsqlParameters, "@APubDateTo", dtpPubYYmm_R.TextValue & "31")    ''발행일자
                Else
                    .SetSqlParameter(GmainsqlParameters, "@APubDateFr", dtpPubDateFr_R.TextValue)    ''발행일자
                    .SetSqlParameter(GmainsqlParameters, "@APubDateTo", dtpPubDateTo_R.TextValue)    ''발행일자
                End If
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)    ''매출구분코드
                .SetSqlParameter(GmainsqlParameters, "@ACustomerCode", popCustomerCode_R.TextValue)    ''매출구분코드
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB104_1_R", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub 
 
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            If grd_1.Rows <= grd_1.FixedRows Then Exit Sub

            ' If grd_2.Focused = True Then  
            '     Me.RequestData_2() 
            '     Exit Sub 
            ' End If 
            grd_2.Rows = grd_2.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@APubYYmm", Me.grd_1.GetCurrentRowCellValue("PubYYmm"))  '' PubYYmm
                .SetSqlParameter(GmainsqlParameters, "@APubSeq", Me.grd_1.GetCurrentRowCellValue("PubSeq"))  '' PubSeq
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB104_2_R", False, True, GmainsqlParameters)

                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                SetSubTotal_2()
            End With
        End Sub

        '====================================================================================================
        Public Sub RequestData3(Optional ByVal AprocessMessage As Boolean = True)
            If grd_1.Rows <= grd_1.FixedRows Then Exit Sub

            GmainsqlParameters = Nothing

            grd_2.Rows = grd_2.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@APubYYmm", Me.grd_1.GetCurrentRowCellValue("PubYYmm"))  '' PubYYmm
                .SetSqlParameter(GmainsqlParameters, "@APubSeq", Me.grd_1.GetCurrentRowCellValue("PubSeq"))  '' PubSeq
                .SetSqlParameter(GmainsqlParameters, "@APeriodCd", cboBillPeriodCd.TextValue)  '' PubSeq
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB104_3_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

                Dim intII As Integer
                For intII = 1 To grd_2.Rows - grd_2.FixedRows
                    grd_2.set_TextMatrix(intII, 0, "신규")
                    Me.grd_2.SetCellCheck(intII, Me.grd_2.get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                Next
                SetSubTotal_2()
            End With

        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal_2()
            With Me.grd_2
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SalePlanAmt"), "합계")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("TaxNumber"), "합  계")
                    Me.grd_2.FrozenRows = 1
                End If
            End With
        End Sub

 '''' -------------------------------------------------------------------
 ''''  SaveData 
 '''' -------------------------------------------------------------------
 
		Public Sub SaveData()  
  
            If MsgBox("저장하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB104_CUD", True, False, GmainsqlParameters)

                    .SetAllBusinessUiInitialValue(Me)
                    .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    Me.RequestData_2()
                End If
            End If

        End Sub
                                                                                                       
 
 '''' -------------------------------------------------------------------
 ''''  DeleteData 
 '''' -------------------------------------------------------------------
   
		Public Sub DeleteData()  
 
            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing

                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB104_CUD", True, False, GmainsqlParameters)

                    .SetAllBusinessUiInitialValue(Me)
                    .DeleteDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    Me.RequestData_2()
                End If
            End If
        End Sub
 
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
         '       .SetExportCrystalDataParameter("PSB104.rpt", "PSB104_R", "", AsqlParameters, AformulaParameters) 
         '   End With 
 
        End Sub 
 
    End Class 
 
End Namespace 
 