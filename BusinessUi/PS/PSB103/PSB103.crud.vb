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
 
    Partial Class PSB103 
 
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
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB103_1_R", False, True, GmainsqlParameters)

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
  
            MessageBox.Show("저장 기능이 없습니다.", "알림", MessageBoxButtons.OK)

            'If MsgBox("저장하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
            'GmainsqlParameters = Nothing 
            'With GmainCommonFunction 
            '	.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID")) 
            '	.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False)) 

            '	GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB103_1_CUD", True, False, GmainsqlParameters)  
            'If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '	.SetAllBusinessUiInitialValue(Me)                                                                                                          
            '	.SaveDataMessage(Me)    
            'Else
            'end if

            'End With                                                                                                                                     

            'Me.RequestData()                                                                                                                             
            'end if

        End Sub
 
 '''' -------------------------------------------------------------------
 ''''  DeleteData 
 '''' -------------------------------------------------------------------
   
		Public Sub DeleteData()  

            MessageBox.Show("삭제 기능이 없습니다.", "알림", MessageBoxButtons.OK)

            '' If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
            '        GmainsqlParameters = Nothing 

            '        With GmainCommonFunction 
            '.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID")) 
            '.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True)) 

            '            GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSB103_1_CUD", True, False, GmainsqlParameters) 
            ' If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '            .SetAllBusinessUiInitialValue(Me) 
            '            .DeleteDataMessage(Me) 
            'else
            'end if
            '        End With 

            '        Me.RequestData() 
            ' end if
        End Sub
 
        Public Sub ExportData() 
 

            Dim AsqlParameters() As SqlParameter = Nothing

            If optExpAmt1.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(AsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing
                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    '.SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PSB103_3_C_R.rpt", "PNI206_3_C_R", "", AsqlParameters, AformulaParameters)
                End With
            Else
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(AsqlParameters, "@AreceiptGubun", IIf(Me.optDemand.Checked = True, "1", "2")) '1.청구 2.영수
                    ''.SetSqlParameter(AsqlParameters, "@AreceiptGubun", "1") '1.청구 2.영수
                    .SetSqlParameter(AsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                    Dim AformulaParameters() As SqlParameter = Nothing
                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PSB103_1_C_R.rpt", "PSB103_1_C_R;PSB103_2_C_R", "", AsqlParameters, AformulaParameters)
                End With
            End If
            ' ''ElseIf optDemand.Checked = True Then
            ' ''With GmainCommonFunction
            ' ''    .SetSqlParameter(AsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ' ''    .SetSqlParameter(AsqlParameters, "@AreceiptGubun", IIf(Me.optDemand.Checked = True, "1", "2")) '1.청구 2.영수
            ' ''    ''.SetSqlParameter(AsqlParameters, "@AreceiptGubun", "1") '1.청구 2.영수
            ' ''    .SetSqlParameter(AsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            ' ''    Dim AformulaParameters() As SqlParameter = Nothing
            ' ''    ' 공통변수의정의가생성시에발생될수있도록유도한다.
            ' ''    .SetExportCrystalDataParameter("PSB103_1_C_R.rpt", "PSB103_1_C_R;PSB103_2_C_R", "", AsqlParameters, AformulaParameters)
            ' ''End With
            ' ''ElseIf optReceipt.Checked = True Then
            ' ''With GmainCommonFunction
            ' ''    .SetSqlParameter(AsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ' ''    .SetSqlParameter(AsqlParameters, "@AreceiptGubun", IIf(Me.optDemand.Checked = True, "1", "2")) '1.청구 2.영수
            ' ''    .SetSqlParameter(AsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            ' ''    Dim AformulaParameters() As SqlParameter = Nothing
            ' ''    ' 공통변수의정의가생성시에발생될수있도록유도한다.
            ' ''    .SetExportCrystalDataParameter("PSB103_1_C_R.rpt", "PSB103_1_C_R;PSB103_2_C_R;", "", AsqlParameters, AformulaParameters)
            ' ''End With
            ' ''End If

            'Dim AsqlParameters() As SqlParameter = Nothing

            'With GmainCommonFunction
            '    .SetSqlParameter(AsqlParameters, "@AcodeDivisionHangulName", Me.txtCodeDivisionHangulName.TextValue)
            '    .SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            '    'Dim AAAA As String = "" 
            '    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'" 

            '    Dim AformulaParameters() As SqlParameter = Nothing

            '    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'") 
            '    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            '    ' 공통변수의정의가생성시에발생될수있도록유도한다. 
            '    .SetExportCrystalDataParameter("PSB103.rpt", "PSB103_R", "", AsqlParameters, AformulaParameters)
            'End With

        End Sub
 
    End Class 
 
End Namespace 
 