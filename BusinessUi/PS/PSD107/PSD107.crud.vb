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

Namespace ubiLease.UI.BusinessUi.PS  
 
    Partial Class PSD107 
 
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


            lblCriteria.Text = ""
            Dim sCriteria As String = "[검색조건] "
            Me.grd_1.Rows = Me.grd_1.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                sCriteria = sCriteria & "거래처코드:" & IIf(popCustomerCode_R.TextValue.ToString.Length < 1, "전체", popCustomerCode_R.TextValue & ":" & popCustomerCode_R.NameText) & ", "
                sCriteria = sCriteria & "입금일자:" & dtpReceiptDateFr_R.TextValue & " ~ " & dtpReceiptDateTo_R.TextValue & " "
                sCriteria = sCriteria & "매출구분코드:" & IIf(cboSaleTypeCd_R.TextValue.ToString.Length < 1, "전체", cboSaleTypeCd_R.Text) & ", "
                sCriteria = sCriteria & "확장유형:" & IIf(cboBillType_R.TextValue.ToString.Length < 1, "전체", cboBillType_R.Text) & ", "
                'If popTaxNumber_R.NameText.ToString.Length > 0 Then sCriteria = sCriteria & ", 계산서번호:" & popTaxNumber_R.Text & " "
                'If popReceiptNumber_R.NameText.ToString.Length > 0 Then sCriteria = sCriteria & ", 입금표번호:" & popReceiptNumber_R.Text & " "

                .SetSqlParameter(GmainsqlParameters, "@AReceiptDateFr", dtpReceiptDateFr_R.TextValue)    ''입금시작일자
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDateTo", dtpReceiptDateTo_R.TextValue)    ''입금종료일자
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)      ''매출구분코드
                .SetSqlParameter(GmainsqlParameters, "@ABillType", cboBillType_R.TextValue)      ''청구유형
                .SetSqlParameter(GmainsqlParameters, "@ACustomerCode", popCustomerCode_R.TextValue)      ''거래처코드
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD107_1_R", False, True, GmainsqlParameters)

                lblCriteria.Text = sCriteria
                lblCriteria.AutoSize = True
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                SetSubTotal_1()

            End With
        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal_1()
            With Me.grd_1
                '' Type A ------------------
                With Me.grd_1
                    For II As Integer = .FixedRows To .Rows - 1
                        If .get_TextMatrix(II, .get_ColIndex("DispDate")).ToString.Replace(" ", "") = "소계" Then
                            .set_Cell(CellPropertySettings.flexcpBackColor, II, .get_ColIndex("선택"), II, .get_ColIndex("col_adjust"), Color.LightSteelBlue)
                        End If
                    Next
                End With
                '    For II As Integer = .FixedRows To .Rows - 1
                '        If .get_TextMatrix(II, .get_ColIndex("DispDate")).ToString.Replace(" ", "") = "소계" Then
                '            .set_Cell(CellPropertySettings.flexcpBackColor, II, .get_ColIndex("선택"), II, .get_ColIndex("col_adjust"), Color.LightSteelBlue)
                '        End If
                '    Next
                '' Type B ------------------
                'If .Rows > .FixedRows Then
                '    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                '    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                '    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                '    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                '    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReceiptAmt"), "합계")
                '    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ReceiptFeeAmt"), "합계")
                '    .set_TextMatrix(.FixedRows, .get_ColIndex("ReceiptNumber"), "합  계")
                '    .FrozenRows = 1
                'End If
            End With
        End Sub

 
 '''' -------------------------------------------------------------------
 ''''  SaveData 
 '''' -------------------------------------------------------------------
 
		Public Sub SaveData()  
  
            ''GmainsqlParameters = Nothing 
            ''With GmainCommonFunction 
            ''	.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID")) 
            ''	.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False)) 

            ''	GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD107_1_CUD", True, False, GmainsqlParameters)  
            ' If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ''	.SetAllBusinessUiInitialValue(Me)                                                                                                          
            ''	.SaveDataMessage(Me)   
            'else
            'end if
            ''End With                                                                                                                                     

            ''Me.RequestData()                                                                                                                             
   
        End Sub                                                                                                                                    
                                                                                                         
 
 '''' -------------------------------------------------------------------
 ''''  DeleteData 
 '''' -------------------------------------------------------------------
   
		Public Sub DeleteData()  
 
            ''        GmainsqlParameters = Nothing 

            ''        With GmainCommonFunction 
            ''.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID")) 
            ''.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True)) 

            ''            GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD107_1_CUD", True, False, GmainsqlParameters) 
            ' If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ''            .SetAllBusinessUiInitialValue(Me) 
            ''            .DeleteDataMessage(Me) 
            'else
            'end if
            ''        End With 

            ''        Me.RequestData() 
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
         '       .SetExportCrystalDataParameter("PSD107.rpt", "PSD107_R", "", AsqlParameters, AformulaParameters) 
         '   End With 
 
        End Sub 
 
    End Class 
 
End Namespace 
 