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
 
    Partial Class PSA103 
 
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

            grd_1.Rows = grd_1.FixedRows
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ASaleDateFr", dtpSaleDateFr_R.TextValue)    ''매출시작일자
                .SetSqlParameter(GmainsqlParameters, "@ASaleDateTo", dtpSaleDateTo_R.TextValue)    ''매출종료일자
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", "")
                '.SetSqlParameter(GmainsqlParameters, "@ACalYearMonths", dtpCalYearMonths_R.TextValue)  '' 정산시작년월
                '.SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", popChargeEmpNum_R.TextValue)    ''영업담당자
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSA103_2_R", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                With grd_1
                    If .Rows > .FixedRows Then
                        For i As Integer = .FixedRows To .Rows - 1
                            .SetData(i, 0, "신규")
                        Next
                    End If
                End With

                .SetAllBusinessUiInitialValue(Me)
                .RequestDataMessage(Me)
            End With
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
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", "")
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSA103_1_R", False, True, GmainsqlParameters)
 
                Me.grd_1.SetDataSet(reciveDataSet)  
                reciveDataSet = Nothing  
 
                .SetAllBusinessUiInitialValue(Me) 
                If AprocessMessage = True Then .RequestDataMessage(Me) 
            End With 
        End Sub 
 
        'Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)  
        '     If grd_1.Rows <= grd_1.FixedRows Then Exit Sub  

        '         ' If grd_2.Focused = True Then  
        '         '     Me.RequestData_2() 
        '         '     Exit Sub 
        '         ' End If 

        '          GmainsqlParameters = Nothing  
        '          With GmainCommonFunction 
        '              .SetSqlParameter(GmainsqlParameters, "@AProcDT", Me.grd_2.GetCurrentRowCellValue("ProcDT"))  '' 작성시작일자
        '              .SetSqlParameter(GmainsqlParameters, "@AProcDT", Me.grd_2.GetCurrentRowCellValue("ProcDT"))  '' 작성종료일자
        '              Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSA103_2_R", False, True, GmainsqlParameters) 

        '              Me.grd_2.SetDataSet(reciveDataSet)  
        '              reciveDataSet = Nothing  

        '              .SetAllBusinessUiInitialValue(Me) 
        '              If AprocessMessage = True Then .RequestDataMessage(Me) 
        '          End With 
        '      End Sub 
 
 '''' -------------------------------------------------------------------
 ''''  SaveData 
 '''' -------------------------------------------------------------------
 
		Public Sub SaveData()  
  
            If MsgBox("저장하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    '.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)  '1:신규,2:수정 <<수정하세요>>
                    .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 1)  '1:신규,2:수정 <<수정하세요>>
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSA103_CUD", True, False, GmainsqlParameters)

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
 
            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing

                With GmainCommonFunction
                    '.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)  '1:신규,2:수정 <<수정하세요>>
                    .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)  '1:신규,2:수정 <<수정하세요>>
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSA103_CUD", True, False, GmainsqlParameters)

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
         '       .SetExportCrystalDataParameter("PSA103.rpt", "PSA103_R", "", AsqlParameters, AformulaParameters) 
         '   End With 
 
        End Sub 
 
    End Class 
 
End Namespace 
 