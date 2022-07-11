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
 
    Partial Class PSB102 
 
        Public Sub NewData() 
           ' If grd_2.Focused = True Then 
           '     Me.NewData_2() 
           '     Exit Sub 
           ' End If 
           ' Me.grd_1.AddRow() 
           '   
            GrecordProcessMode = 1
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_2)

            Me.grd_1.Rows = Me.grd_1.FixedRows
            Me.grd_2.Rows = Me.grd_2.FixedRows

            chkSaleDateYesOrNo.Visible = False
            chkSaleDateYesOrNo.Checked = False
            ''dtpSaleDate_All.Visible = False
            ''btnSaleDate_All.Visible = False

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
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB102_1_R", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)
                If grd_1.Rows > grd_1.FixedRows Then
                    chkSaleDateYesOrNo.Visible = True
                End If
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub
 
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            ''grd_2.Rows = grd_2.FixedRows
            ''If grd_1.Rows <= grd_1.FixedRows Then Exit Sub

            ' '' If grd_2.Focused = True Then  
            ' ''     Me.RequestData_2() 
            ' ''     Exit Sub 
            ' '' End If 

            ''GmainsqlParameters = Nothing
            ''With GmainCommonFunction
            ''    .SetSqlParameter(GmainsqlParameters, "@APubYYmm", Me.grd_1.GetCurrentRowCellValue("PubYYmm"))  '' 매출시작일자
            ''    .SetSqlParameter(GmainsqlParameters, "@APubSeq", Me.grd_1.GetCurrentRowCellValue("PubSeq"))  '' 매출시작일자
            ''    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB102_2_R", False, True, GmainsqlParameters)

            ''    Me.grd_2.SetDataSet(reciveDataSet)
            ''    reciveDataSet = Nothing

            ''    .SetAllBusinessUiInitialValue(Me)
            ''    If AprocessMessage = True Then .RequestDataMessage(Me)
            ''End With
        End Sub

        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)
            'If grd_1.Rows <= grd_1.FixedRows Then Exit Sub

            ' If grd_2.Focused = True Then  
            '     Me.RequestData_2() 
            '     Exit Sub 
            ' End If 

            NewData()
            Me.grd_1.Rows = Me.grd_1.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ACustomerCode", popCustomerCode_R.TextValue)    ''발행년월
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)    ''매출구분코드
                .SetSqlParameter(GmainsqlParameters, "@ASaleDateFr", dtpSaleDateFr_R.TextValue)  '' 매출시작일자
                .SetSqlParameter(GmainsqlParameters, "@ASaleDateTo", dtpSaleDateTo_R.TextValue)  '' 매출종료일자
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB102_3_R", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                With grd_1
                    If .Rows > .FixedRows Then
                        For i As Integer = .FixedRows To .Rows - 1
                            .SetData(i, 0, "신규")
                        Next
                        chkSaleDateYesOrNo.Visible = True
                    End If
                End With
            End With
        End Sub

 '''' -------------------------------------------------------------------
 ''''  SaveData 
 '''' -------------------------------------------------------------------
 
		Public Sub SaveData()  
  

            If grd_1.Rows <= grd_1.FixedRows Then
                MessageBox.Show("저장할 자료가 한건도 없습니다." & vbCrLf & " 확인후 작업하세요", "확인", MessageBoxButtons.OK)
                Exit Sub
            End If

            'If dtpPubDate.TextValue.ToString.Length < 1 Then
            '    MessageBox.Show("발행일자를 입력하세요.." & vbCrLf & " 확인후 작업하세요", "확인", MessageBoxButtons.OK)
            '    Exit Sub
            'End If

            'If popCustomerCode.NameText.ToString.Length < 1 Then
            '    MessageBox.Show("거래처코드를 입력하세요.." & vbCrLf & " 확인후 작업하세요", "확인", MessageBoxButtons.OK)
            '    Exit Sub
            'End If

            'If cboSaleTypeCd_R.TextValue <> cboSaleTypeCd.TextValue Then
            '    MessageBox.Show("매출구분코드를 확인하세요." & vbCrLf & " 확인후 작업하세요", "확인", MessageBoxButtons.OK)
            '    Exit Sub
            'End If

            If MsgBox("저장하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB102_CUD", True, False, GmainsqlParameters)

                    .SetAllBusinessUiInitialValue(Me)
                    .SaveDataMessage(Me)

                    If GmainExecuteDbCommand.GerrorNumber = 0 Then
                        Me.RequestData()
                    End If
                End With

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
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB102_CUD", True, False, GmainsqlParameters)

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
         '       .SetExportCrystalDataParameter("PSB102.rpt", "PSB102_R", "", AsqlParameters, AformulaParameters) 
         '   End With 
 
        End Sub 
 
    End Class 
 
End Namespace 
 