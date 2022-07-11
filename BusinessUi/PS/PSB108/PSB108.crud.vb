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
 
    Partial Class PSB108 
 
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
                sCriteria = sCriteria & "계산서번호:" & IIf(dtpPubYYmm_R.TextValue.ToString.Length < 1, "전체", dtpPubYYmm_R.TextValue & "-" & numPubSeq_R.TextValue.ToString) & ", "
                sCriteria = sCriteria & "기준일자:" & dtpPubDateFr_R.TextValue & "~" & dtpPubDateTo_R.TextValue & " "

                .SetSqlParameter(GmainsqlParameters, "@APubDateFr", dtpPubDateFr_R.TextValue)    ''기준일자Fr
                .SetSqlParameter(GmainsqlParameters, "@APubDateTo", dtpPubDateTo_R.TextValue)    ''기준일자To
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)    ''매출구분코드
                .SetSqlParameter(GmainsqlParameters, "@ACustomerCode", popCustomerCode_R.TextValue)    ''거래처코드
                .SetSqlParameter(GmainsqlParameters, "@APubYYmm", dtpPubYYmm_R.TextValue)    ''계산서발행년월
                .SetSqlParameter(GmainsqlParameters, "@APubSeq", IIf(numPubSeq_R.TextValue.ToString.Length < 1, "0", numPubSeq_R.TextValue))    ''계산서번호
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB108_1_R", False, True, GmainsqlParameters)

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
                For II As Integer = .FixedRows To .Rows - 1
                    If .get_TextMatrix(II, .get_ColIndex("DispDate")).ToString.Replace(" ", "") = "소계" Then
                        .set_Cell(CellPropertySettings.flexcpBackColor, II, .get_ColIndex("선택"), II, .get_ColIndex("col_adjust"), Color.LightSteelBlue)
                    End If
                Next
            End With
        End Sub

        '''' -------------------------------------------------------------------
        ''''  SaveData 
        '''' -------------------------------------------------------------------
        Public Sub SaveData()

        End Sub

        '''' -------------------------------------------------------------------
        ''''  DeleteData 
        '''' -------------------------------------------------------------------
        Public Sub DeleteData()

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
            '       .SetExportCrystalDataParameter("PSB108.rpt", "PSB108_R", "", AsqlParameters, AformulaParameters) 
            '   End With 

        End Sub

    End Class
 
End Namespace 
 