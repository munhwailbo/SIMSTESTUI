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
 
    Partial Class PSA104 
 
        Public Sub NewData() 
            'If grd_2.Focused = True Then
            '    Me.NewData_2()
            '    Exit Sub
            'End If
            Me.grd_1.AddRow()
            '   
            ' GrecordProcessMode = 1 
            ' GmainCommonFunction.ControlNewData(Me, Me.picIo_2) 
            '   
            ' '컨트롤 초기값 설정 
            ' 'Me.SetControlInAdvance() 

            '' ---- 해당 없음
            ''grd_1.Rows = grd_1.FixedRows
            ''GmainsqlParameters = Nothing
            ''With GmainCommonFunction
            ''    .SetSqlParameter(GmainsqlParameters, "@ASaleDateFr", dtpSaleDateFr_R.TextValue)    ''매출시작일자
            ''    .SetSqlParameter(GmainsqlParameters, "@ASaleDateTo", dtpSaleDateTo_R.TextValue)    ''매출종료일자
            ''    .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboSaleTypeCd_R.TextValue)    ''매출종료일자
            ''    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSA104_2_R", False, True, GmainsqlParameters)

            ''    Me.grd_1.SetDataSet(reciveDataSet)
            ''    reciveDataSet = Nothing
            ''    With grd_1
            ''        If .Rows > .FixedRows Then
            ''            For i As Integer = .FixedRows To .Rows - 1
            ''                .SetData(i, 0, "신규")
            ''            Next
            ''        End If
            ''    End With

            ''    .SetAllBusinessUiInitialValue(Me)
            ''    .RequestDataMessage(Me)
            ''End With
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
                .SetSqlParameter(GmainsqlParameters, "@ASaleDateFr", dtpSaleDateFr_R.TextValue)    ''매출시작일자
                .SetSqlParameter(GmainsqlParameters, "@ASaleDateTo", dtpSaleDateTo_R.TextValue)    ''매출종료일자
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cbosaletypecd_r.TextValue)    ''매출종료일자
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSA104_1_R", False, True, GmainsqlParameters)
 
                Me.grd_1.SetDataSet(reciveDataSet)  
                reciveDataSet = Nothing  
 
                .SetAllBusinessUiInitialValue(Me) 
                If AprocessMessage = True Then .RequestDataMessage(Me) 
            End With 
        End Sub 
 
 '''' -------------------------------------------------------------------
 ''''  SaveData 
 '''' -------------------------------------------------------------------
 
		Public Sub SaveData()  
  
			GmainsqlParameters = Nothing 
			With GmainCommonFunction 
				.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID")) 
				.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False)) 
   
                GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSA104_CUD", True, False, GmainsqlParameters)

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
 
            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing

                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSA104_CUD", True, False, GmainsqlParameters)

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
         '       .SetExportCrystalDataParameter("PSA104.rpt", "PSA104_R", "", AsqlParameters, AformulaParameters) 
         '   End With 
 
        End Sub 
 
    End Class 
 
End Namespace 
 