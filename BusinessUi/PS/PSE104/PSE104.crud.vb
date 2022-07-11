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
 
    Partial Class PSE104 
 
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
                .SetSqlParameter(GmainsqlParameters, "@AStYYmm", dtpStYYmm_R.TextValue)    ''정산년월
                .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", cboDeliType_R.TextValue)    ''배달비 구분
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSE104_1_R", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                SetSubTotal_1()

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub


        '그리드 합계행 추가
        Private Sub SetSubTotal_1()
            With Me.grd_1
                '' Type A ------------------
                '    For II As Integer = .FixedRows To .Rows - 1
                '        If .get_TextMatrix(II, .get_ColIndex("DispDate")).ToString.Replace(" ", "") = "소계" Then
                '            .set_Cell(CellPropertySettings.flexcpBackColor, II, .get_ColIndex("선택"), II, .get_ColIndex("col_adjust"), Color.LightSteelBlue)
                '        End If
                '    Next
                '' Type B ------------------
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DeliBusu"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DeliAmt"), "합계")
                    .set_TextMatrix(.FixedRows, .get_ColIndex("CustomerNm"), "합  계")
                    .FrozenRows = 1
                End If
            End With
        End Sub


        '''' -------------------------------------------------------------------
        ''''  SaveData 
        '''' -------------------------------------------------------------------

        Public Sub SaveData()

            If MsgBox("전표 처리를 하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", 1)
                    .SetSqlParameter(GmainsqlParameters, "@AStYYmm", Me.dtpStYYmm_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", Me.cboDeliType_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    '.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSE104_CUD", True, False, GmainsqlParameters)

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
            If MsgBox("처리된 전표를 삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing

                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordProcessMode", 3)
                    .SetSqlParameter(GmainsqlParameters, "@AStYYmm", Me.dtpStYYmm_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ASaleTypeCd", Me.cboDeliType_R.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PS", "PSE104_CUD", True, False, GmainsqlParameters)

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
         '       .SetExportCrystalDataParameter("PSE104.rpt", "PSE104_R", "", AsqlParameters, AformulaParameters) 
         '   End With 
 
        End Sub 
 
    End Class 
 
End Namespace 
 