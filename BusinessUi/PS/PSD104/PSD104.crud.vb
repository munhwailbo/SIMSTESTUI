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
 
    Partial Class PSD104 
 
        Public Sub NewData() 
           ' If grd_2.Focused = True Then 
           '     Me.NewData_2() 
           '     Exit Sub 
            ' End If 
            ''-----------------------------
            'Me.grd_2.AddRow()
            'grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("PubYYmm"), Me.grd_1.GetCurrentRowCellValue("PubYYmm"))
            'grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("PubSeq"), Me.grd_1.GetCurrentRowCellValue("PubSeq"))
            ''-----------------------------
            NewDataSingle()

            'GrecordProcessMode = 1
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_3)
           '   
            '컨트롤 초기값 설정 
            'Me.SetControlInAdvance()
        End Sub 

        Public Sub NewDataSingle()

            GrecordProcessMode = 1
            lblRecordState.Text = "신규"
            GmainCommonFunction.ControlNewData(Me, Me.picIo_3)
            dtpReceiptDate.TextValue = Me.grd_1.GetCurrentRowCellValue("ReceiptDate")
            txtReceiptSeq.TextValue = Me.grd_1.GetCurrentRowCellValue("ReceiptSeq")
            dtpEpReceiptDate.TextValue = Now.ToString

            Dim CustomerCode As String = ""
            CustomerCode = Me.grd_1.GetCurrentRowCellValue("CustomerCode")
            popCustomerCode.TextValue = CustomerCode
            cboBillType.TextValue = Me.grd_1.GetCurrentRowCellValue("BillType")
            cboBillType.Text = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("BillType"))  ''   .GetCurrentRowCellValue("BillType")
            If cboBillType.TextValue = "D3" Then
                lblTaxNumber.Enabled = False
                popTaxNumber.Visible = False
                popTaxNumber.Text = ""
            Else
                lblTaxNumber.Enabled = True
                popTaxNumber.Visible = True
            End If

        End Sub

 '''' -------------------------------------------------------------------
 ''''  RequestData 
 '''' -------------------------------------------------------------------
 
		Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)  
 
           ' If grd_2.Focused = True Then  
           '     Me.RequestData_2() 
           '     Exit Sub 
           ' End If 
 
            Me.grd_2.Rows = Me.grd_2.FixedRows
            Me.grd_1.Rows = Me.grd_1.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                lblCriteria.Text = ""
                Dim sCriteria As String = "[검색조건] "
                'sCriteria = sCriteria & "매출구분:" & cboSaleTypeCd_R.Text & ", "
                'sCriteria = sCriteria & "거래처코드:" & IIf(popCustomerCode_R.TextValue.ToString.Length < 1, "전체", popCustomerCode_R.TextValue & ":" & popCustomerCode_R.NameText) & ", "
                'sCriteria = sCriteria & "계산서번호:" & IIf(dtpPubYYmm_R.TextValue.ToString.Length < 1, "전체", dtpPubYYmm_R.TextValue & "-" & numPubSeq_R.TextValue.ToString) & ", "
                'sCriteria = sCriteria & "기준일자:" & dtpPubDateFr_R.TextValue & "~" & dtpPubDateTo_R.TextValue & " "
                'lblCriteria.Text = sCriteria
                'lblCriteria.AutoSize = True

                '.SetSqlParameter(GmainsqlParameters, "@APubDateFr", dtpPubDateFr_R.TextValue)    ''기준일자Fr
                '.SetSqlParameter(GmainsqlParameters, "@APubDateTo", dtpPubDateTo_R.TextValue)    ''기준일자To
                '.SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)    ''매출구분코드
                '.SetSqlParameter(GmainsqlParameters, "@ACustomerCode", popCustomerCode_R.TextValue)    ''거래처코드
                '.SetSqlParameter(GmainsqlParameters, "@APubYYmm", dtpPubYYmm_R.TextValue)    ''계산서발행년월
                '.SetSqlParameter(GmainsqlParameters, "@APubSeq", IIf(numPubSeq_R.TextValue.ToString.Length < 1, "0", numPubSeq_R.TextValue))    ''계산서번호

                sCriteria = sCriteria & "매출구분코드:" & IIf(cboSaleTypeCd_R.TextValue.ToString.Length < 1, "전체", cboSaleTypeCd_R.Text) & ", "
                sCriteria = sCriteria & "확장유형:" & IIf(cboBillType_R.TextValue.ToString.Length < 1, "전체", cboBillType_R.Text) & ", "
                sCriteria = sCriteria & "거래처코드:" & IIf(popCustomerCode_R.TextValue.ToString.Length < 1, "전체", popCustomerCode_R.TextValue & ":" & popCustomerCode_R.NameText) & ", "
                sCriteria = sCriteria & "입금일자:" & dtpReceiptDateFr_R.TextValue & " ~ " & dtpReceiptDateTo_R.TextValue & " "
                ''If popTaxNumber_R.NameText.ToString.Length > 0 Then sCriteria = sCriteria & ", 계산서번호:" & popTaxNumber_R.Text & " "
                If popReceiptNumber_R.NameText.ToString.Length > 0 Then sCriteria = sCriteria & ", 입금번호:" & popReceiptNumber_R.Text & " "
                lblCriteria.Text = sCriteria
                lblCriteria.AutoSize = True

                .SetSqlParameter(GmainsqlParameters, "@AReceiptDateFr", dtpReceiptDateFr_R.TextValue)    ''입금시작일자
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDateTo", dtpReceiptDateTo_R.TextValue)    ''입금종료일자
                .SetSqlParameter(GmainsqlParameters, "@ACustomerCode", popCustomerCode_R.TextValue)      ''거래처코드
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)      ''거래처코드
                .SetSqlParameter(GmainsqlParameters, "@ABillType", cboBillType_R.TextValue)      ''청구유형
                .SetSqlParameter(GmainsqlParameters, "@AReceiptNumber", popReceiptNumber_R.TextValue)      ''입금번호
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD103_1_R", False, True, GmainsqlParameters)

                ''If Me.optGb1.Checked Then    ' 발행년월 조건기준일때 
                ''    .SetSqlParameter(GmainsqlParameters, "@APubDateFr", dtpPubYYmm_R.TextValue & "01")    ''발행일자
                ''    .SetSqlParameter(GmainsqlParameters, "@APubDateTo", dtpPubYYmm_R.TextValue & "31")    ''발행일자
                ''Else
                ''    .SetSqlParameter(GmainsqlParameters, "@APubDateFr", dtpPubDateFr_R.TextValue)    ''발행일자
                ''    .SetSqlParameter(GmainsqlParameters, "@APubDateTo", dtpPubDateTo_R.TextValue)    ''발행일자
                ''End If
                ''.SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)    ''매출구분코드
                ''.SetSqlParameter(GmainsqlParameters, "@ACustomerCode", popCustomerCode_R.TextValue)    ''매출구분코드
                ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD104_1_R", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)
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

            NewDataSingle()
            Dim CustomerCode As String = ""
            CustomerCode = Me.grd_1.GetCurrentRowCellValue("CustomerCode")
            popCustomerCode.TextValue = CustomerCode
            popTaxNumber.Tag = "code(PS계산서번호);rtnvalue(numRtnValue1,numRtnValue2,txtRcRemark,popCustomerCode,dtpPubYYmm,txtPubSeq);" & "where(tm.CustomerCode = '" & CustomerCode & "');"
            popTaxNumber.MaxLength = 12
            lblCriteria_2.Text = popTaxNumber.Tag

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                lblCriteria_2.Text = ""
                Dim sCriteria As String = "[검색조건] "
                sCriteria = sCriteria & "입금번호:" & Me.grd_1.GetCurrentRowCellValue("ReceiptNumber") & "  "
                lblCriteria_2.Text = sCriteria
                lblCriteria_2.AutoSize = True

                ''.SetSqlParameter(GmainsqlParameters, "@APubYYmm", Me.grd_1.GetCurrentRowCellValue("PubYYmm"))  '' PubYYmm
                ''.SetSqlParameter(GmainsqlParameters, "@APubSeq", Me.grd_1.GetCurrentRowCellValue("PubSeq"))  '' PubSeq
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.grd_1.GetCurrentRowCellValue("ReceiptDate"))  '' PubYYmm
                .SetSqlParameter(GmainsqlParameters, "@AReceiptSeq", Me.grd_1.GetCurrentRowCellValue("ReceiptSeq"))  '' PubSeq
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD104_2_R", False, True, GmainsqlParameters)

                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub

        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)
            If grd_2.Rows <= grd_2.FixedRows Then Exit Sub

            ' If grd_2.Focused = True Then  
            '     Me.RequestData_2() 
            '     Exit Sub 
            ' End If 

            NewDataSingle()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AEpReceiptDate", Me.grd_2.GetCurrentRowCellValue("EpReceiptDate"))  '' PubYYmm
                .SetSqlParameter(GmainsqlParameters, "@AEpReceiptSeq", Me.grd_2.GetCurrentRowCellValue("EpReceiptSeq"))  '' PubSeq
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD104_3_R", False, True, GmainsqlParameters)

                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                If reciveDataSet.Tables.Count > 0 Then
                    lblRecordState.Text = "조회"
                    .SetDataSetToControls(reciveDataSet, Me)
                End If
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub
 
 '''' -------------------------------------------------------------------
 ''''  SaveData 
 '''' -------------------------------------------------------------------
 
		Public Sub SaveData()  
  
            Dim strMode As String
            If Me.txtReceiptSeq.TextValue = "" Then
                strMode = "1" '신규
            Else
                strMode = "2" '수정
            End If

            If Me.dtpReceiptDate.TextValue.Length < 8 Or Me.txtReceiptSeq.TextValue.Length < 1 Or Me.txtReceiptSeq.TextValue = "0" Then
                MessageBox.Show("입금번호 : " & Me.dtpReceiptDate.TextValue & "-" & Me.txtReceiptSeq.TextValue & "는 유효하지 않습니다.", "확인", MessageBoxButtons.OK)
            End If
            GmainsqlParameters = Nothing
            If MsgBox("저장하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    ''.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode  )  '1:신규,2:수정 <<수정하세요>>
                    .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", IIf(lblRecordState.Text = "신규", "1", "2"))  '1:신규,2:수정 <<수정하세요>>
                    .SetSqlParameter(GmainsqlParameters, "@AEpReceiptDate", Me.dtpEpReceiptDate.TextValue)  '수납일자 
                    .SetSqlParameter(GmainsqlParameters, "@AEpReceiptSeq", Me.txtEpReceiptSeq.TextValue)  '수납순번 
                    .SetSqlParameter(GmainsqlParameters, "@APubYYmm", Me.dtpPubYYmm.TextValue)  '계산서발행년월 
                    .SetSqlParameter(GmainsqlParameters, "@APubSeq", Me.txtPubSeq.TextValue)  '발행순번 
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.dtpReceiptDate.TextValue)  '입금일자 
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptSeq", Me.txtReceiptSeq.TextValue)  '입금순번 
                    .SetSqlParameter(GmainsqlParameters, "@AEpReceiptAmt", Me.numEpReceiptAmt.TextValue)  '수납금액 
                    ''''''.SetSqlParameter(GmainsqlParameters, "@ACustomerCode", Me.popCustomerCode.TextValue)  '거래처코드 
                    .SetSqlParameter(GmainsqlParameters, "@ARemark", Me.txtRemark.TextValue)  '적요 
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD104_CUD", True, False, GmainsqlParameters)

                    .SetAllBusinessUiInitialValue(Me)
                    .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    Me.RequestData()
                End If
            End If

        End Sub


        '''' -------------------------------------------------------------------
        ''''  DeleteData 
        '''' -------------------------------------------------------------------

        Public Sub DeleteData()

            If Me.dtpReceiptDate.TextValue.Length < 8 Or Me.txtReceiptSeq.TextValue.Length < 1 Or Me.txtReceiptSeq.TextValue = "0" Then
                MessageBox.Show("입금번호 : " & Me.dtpReceiptDate.TextValue & "-" & Me.txtReceiptSeq.TextValue & "는 유효하지 않습니다.", "확인", MessageBoxButtons.OK)
            End If
            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing

                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")  ' 삭제
                    .SetSqlParameter(GmainsqlParameters, "@AEpReceiptDate", Me.dtpEpReceiptDate.TextValue)  '수납일자 
                    .SetSqlParameter(GmainsqlParameters, "@AEpReceiptSeq", Me.txtEpReceiptSeq.TextValue)  '수납순번 
                    .SetSqlParameter(GmainsqlParameters, "@APubYYmm", Me.dtpPubYYmm.TextValue)  '계산서발행년월 
                    .SetSqlParameter(GmainsqlParameters, "@APubSeq", Me.txtPubSeq.TextValue)  '발행순번 
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.dtpReceiptDate.TextValue)  '입금일자 
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptSeq", Me.txtReceiptSeq.TextValue)  '입금순번 
                    .SetSqlParameter(GmainsqlParameters, "@AEpReceiptAmt", Me.numEpReceiptAmt.TextValue)  '수납금액 
                    '''''.SetSqlParameter(GmainsqlParameters, "@ACustomerCode", Me.popCustomerCode.TextValue)  '거래처코드 
                    .SetSqlParameter(GmainsqlParameters, "@ARemark", Me.txtRemark.TextValue)  '적요 
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD104_CUD", True, False, GmainsqlParameters)

                    .SetAllBusinessUiInitialValue(Me)
                    .DeleteDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    Me.RequestData()
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
         '       .SetExportCrystalDataParameter("PSD104.rpt", "PSD104_R", "", AsqlParameters, AformulaParameters) 
         '   End With 
 
        End Sub 
 
    End Class 
 
End Namespace 
 