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
 
    Partial Class PSC105 
 
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
                sCriteria = sCriteria & "매출구분:" & cboSaleTypeCd_R.Text & ", "
                sCriteria = sCriteria & "거래처코드:" & IIf(popCustomerCode_R.TextValue.ToString.Length < 1, "전체", popCustomerCode_R.TextValue & ":" & popCustomerCode_R.NameText) & ", "
                If Me.optGb1.Checked Then    ' 발행년월 조건기준일때 
                    .SetSqlParameter(GmainsqlParameters, "@APubDateFr", dtpPubYYmm_R.TextValue & "01")    ''발행일자
                    .SetSqlParameter(GmainsqlParameters, "@APubDateTo", dtpPubYYmm_R.TextValue & "31")    ''발행일자
                    sCriteria = sCriteria & "기준년월:" & dtpPubYYmm_R.TextValue & " "
                Else
                    .SetSqlParameter(GmainsqlParameters, "@APubDateFr", dtpPubDateFr_R.TextValue)    ''발행일자
                    .SetSqlParameter(GmainsqlParameters, "@APubDateTo", dtpPubDateTo_R.TextValue)    ''발행일자
                    sCriteria = sCriteria & "기준일자:" & dtpPubDateFr_R.TextValue & " ~ " & dtpPubDateTo_R.TextValue & " "
                End If
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)    ''매출구분코드
                .SetSqlParameter(GmainsqlParameters, "@ACustomerCode", popCustomerCode_R.TextValue)    ''매출구분코드
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSC105_1_R", False, True, GmainsqlParameters)

                lblCriteria.Text = sCriteria
                lblCriteria.AutoSize = True
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                If chkSumView.Checked Then SetSubTotal()

            End With
        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Tree.Column = .get_ColIndex("ChargeEmpNm")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData    '' 'BelowData   '' AboveData

                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal2).ForeColor = Color.Blue

                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue

                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue


                    ' '' =============================================================================
                    '' '' '' 그리드 팀 소계행 추가
                    ' '' =============================================================================
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 2, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("Qty"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 2, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("ttAmt"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 2, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("srAmt"), "{0} 소계")
                    ' '' =============================================================================

                    ' '' =============================================================================
                    '' '' '' 그리드 판매매출구분 소계행 추가
                    ' '' =============================================================================
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("SaleTypeCd"), .get_ColIndex("Qty"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("SaleTypeCd"), .get_ColIndex("ttAmt"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("SaleTypeCd"), .get_ColIndex("srAmt"), "{0} 소계")
                    ' '' =============================================================================

                    ' '' =============================================================================
                    '' '' '' 그리드 합계행 추가
                    ' '' =============================================================================
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Qty"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ttAmt"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("srAmt"), "합계")
                    ' '' =============================================================================
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        ' ''그리드 합계행 추가
        ''Private Sub SetSubTotal_1()
        ''    With Me.grd_1
        ''        For II As Integer = .FixedRows To .Rows - 1
        ''            If .get_TextMatrix(II, .get_ColIndex("DispDate")).ToString.Replace(" ", "") = "소계" Then
        ''                .set_Cell(CellPropertySettings.flexcpBackColor, II, .get_ColIndex("선택"), II, .get_ColIndex("col_adjust"), Color.LightSteelBlue)
        ''            End If
        ''        Next
        ''    End With
        ''End Sub

 '''' -------------------------------------------------------------------
 ''''  SaveData 
 '''' -------------------------------------------------------------------
 
 '''' -------------------------------------------------------------------
 ''''  DeleteData 
 '''' -------------------------------------------------------------------
 
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
         '       .SetExportCrystalDataParameter("PSC105.rpt", "PSC105_R", "", AsqlParameters, AformulaParameters) 
         '   End With 
 
        End Sub 
 
    End Class 
 
End Namespace 
 