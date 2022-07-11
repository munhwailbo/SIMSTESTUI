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
 
    Partial Class PSD101 
 
        Public Sub NewData() 
           ' If grd_2.Focused = True Then 
           '     Me.NewData_2() 
           '     Exit Sub 
           ' End If 
            'Me.grd_1.AddRow()

            '   
            'grd_1.Rows = grd_1.FixedRows
            NewDataSingle()
            'grd_1.AddRow()
            '   
            ' '컨트롤 초기값 설정 
            ' Me.SetControlInAdvance()
        End Sub

        Public Sub NewDataSingle()

            GrecordProcessMode = 1
            lblRecordState.Text = "신규"
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
            dtpReceiptDate.TextValue = Now.ToString

        End Sub

        '''' -------------------------------------------------------------------
        ''''  RequestData 
        '''' -------------------------------------------------------------------

        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            ' If grd_2.Focused = True Then  
            '     Me.RequestData_2() 
            '     Exit Sub 
            ' End If 

            grd_1.Rows = grd_1.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDateFr", dtpReceiptDateFr_R.TextValue)    ''입금시작일자
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDateTo", dtpReceiptDateTo_R.TextValue)    ''입금종료일자
                .SetSqlParameter(GmainsqlParameters, "@ACustomerCode", popCustomerCode_R.TextValue)      ''거래처코드
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)      ''매출구분
                .SetSqlParameter(GmainsqlParameters, "@ABillType", cboBillType_R.TextValue)      ''청구유형
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD101_1_R", False, True, GmainsqlParameters)

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

            NewDataSingle()
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                ''.SetSqlParameter(GmainsqlParameters, "@AReceiptDateFr", dtpReceiptDateFr_R.TextValue)    ''입금시작일자
                ''.SetSqlParameter(GmainsqlParameters, "@AReceiptDateFr", dtpReceiptDateFr_R.TextValue)    ''입금시작일자
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.grd_1.GetCurrentRowCellValue("ReceiptDate"))  '' 작성종료일자
                .SetSqlParameter(GmainsqlParameters, "@AReceiptSeq", Me.grd_1.GetCurrentRowCellValue("ReceiptSeq"))  '' 작성종료일자
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD101_2_R", False, True, GmainsqlParameters)

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
            GmainsqlParameters = Nothing
			With GmainCommonFunction 
                ''.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode  )  '1:신규,2:수정 <<수정하세요>>
                .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", IIf(lblRecordState.Text = "신규", "1", "2"))  '1:신규,2:수정 <<수정하세요>>
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.dtpReceiptDate.TextValue)  '입금일자 
				.SetSqlParameter(GmainsqlParameters, "@AReceiptSeq", Me.txtReceiptSeq.TextValue)  '입금순번 
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd.TextValue)      ''판매매출코드
                .SetSqlParameter(GmainsqlParameters, "@ABillType", cboBillType.TextValue)      ''청구유형
                .SetSqlParameter(GmainsqlParameters, "@AReceiptType", Me.cboReceiptType.TextValue)  '입금시제코드 
				.SetSqlParameter(GmainsqlParameters, "@ACustomerCode", Me.popCustomerCode.TextValue)  '거래처코드 
                .SetSqlParameter(GmainsqlParameters, "@ARcptAccNumCd", Me.cboRcptAccNumCd.TextValue)  '계좌코드 
                .SetSqlParameter(GmainsqlParameters, "@AManagementNum", Me.txtManagementNum.TextValue)  '어음번호 
                .SetSqlParameter(GmainsqlParameters, "@AReceiptAmt", Me.numReceiptAmt.TextValue)  '입금액 
                .SetSqlParameter(GmainsqlParameters, "@AReceiptFeeAmt", Me.numReceiptFeeAmt.TextValue)  '수수료금액 
                .SetSqlParameter(GmainsqlParameters, "@ARemark", Me.txtRemark.TextValue)  '적요 
                ''.SetSqlParameter(GmainsqlParameters, "@AAccSlipNum", Me.txtAccSlipNum.TextValue)  '회계전표번호 
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD101_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                Me.RequestData()
            End If

        End Sub


        '''' -------------------------------------------------------------------
        ''''  DeleteData 
        '''' -------------------------------------------------------------------

        Public Sub DeleteData()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")  ' 삭제
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDate", Me.dtpReceiptDate.TextValue)  '입금일자 
                .SetSqlParameter(GmainsqlParameters, "@AReceiptSeq", Me.txtReceiptSeq.TextValue)  '입금순번 
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd.TextValue)      ''판매매출코드
                .SetSqlParameter(GmainsqlParameters, "@ABillType", cboBillType.TextValue)      ''청구유형
                .SetSqlParameter(GmainsqlParameters, "@AReceiptType", Me.cboReceiptType.TextValue)  '입금시제코드 
                .SetSqlParameter(GmainsqlParameters, "@ACustomerCode", Me.popCustomerCode.TextValue)  '거래처코드 
                .SetSqlParameter(GmainsqlParameters, "@ARcptAccNumCd", Me.cboRcptAccNumCd.TextValue)  '계좌코드 
                .SetSqlParameter(GmainsqlParameters, "@AManagementNum", Me.txtManagementNum.TextValue)  '어음번호 
                .SetSqlParameter(GmainsqlParameters, "@AReceiptAmt", Me.numReceiptAmt.TextValue)  '입금액 
                .SetSqlParameter(GmainsqlParameters, "@AReceiptFeeAmt", Me.numReceiptFeeAmt.TextValue)  '수수료금액 
                .SetSqlParameter(GmainsqlParameters, "@ARemark", Me.txtRemark.TextValue)  '적요 
                ''.SetSqlParameter(GmainsqlParameters, "@AAccSlipNum", Me.txtAccSlipNum.TextValue)  '회계전표번호 
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSD101_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .DeleteDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                Me.RequestData()
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
         '       .SetExportCrystalDataParameter("PSD101.rpt", "PSD101_R", "", AsqlParameters, AformulaParameters) 
         '   End With 
 
        End Sub 
 
    End Class 
 
End Namespace 
 