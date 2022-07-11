Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Collections
Imports ubiLease.CommonFunction
Imports System.Configuration
Imports System.Diagnostics

Namespace ubiLease.UI.MainUi
    Partial Class frmMainUi

        Private Function DownloadReport(ByVal sReportFileName As String, ByVal m_strReportDir As String) As String
            ' 문자열 합치기 및 레포트가 있는지를 검사한다.
            ' 레포트를 특정 경로에 다운 받는다.(구현 예정)
            Dim fullFileName As String
            'GmainCommonFunction.GreportName = 
            'fullFileName = m_strReportDir + sReportName
            'fullFileName = GmainCommonFunction.GapplicationRootPath & m_strReportDir & "\" & sReportFileName
            fullFileName = GmainCommonFunction.GapplicationRootPath & m_strReportDir & "/" & sReportFileName

            Return fullFileName
        End Function
        Private Function rptObject(ByVal RptObjName As String) As Object
            Dim rpt As Object = Nothing
            rpt = GmainCommonFunction.GetAssemblyObject( _
                "http://" & _
                ConfigurationManager.AppSettings("DLLServer").ToString() & _
                ConfigurationManager.AppSettings("AppRootName").ToString() & _
                "/UI/Reports" & "/" & RptObjName.Substring(0, 2) & "/" & ConfigurationManager.AppSettings("DLLPath").ToString() & RptObjName.Substring(0, 2) & "ReportData.dll", Split(RptObjName, ".")(0))

            Return rpt
        End Function

        Friend Function ViewReport(ByVal strReportDir As String, ByVal sReportFileName As String, ByVal SPName As String, Optional ByVal sSelectionFormula As String = "", Optional ByVal param() As SqlParameter = Nothing, Optional ByVal param2() As SqlParameter = Nothing, Optional ByVal directPrint As Boolean = False) As Boolean

            Dim intCounter As Integer
            Dim intCounter1 As Integer
            Dim frmPrint As frmCrystalPrint = frmPrintBase
            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo

            Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue
            Dim currValue As CrystalDecisions.Shared.ParameterValues

            Dim mySubReportObject As CrystalDecisions.CrystalReports.Engine.SubreportObject
            Dim mySubRepDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            Dim sFileName As String
            Dim index As Integer


            Try
                sFileName = DownloadReport(sReportFileName, strReportDir)
                objReport = rptObject(sReportFileName)
                'objReport.Load(sFileName)
                'objReport.Load(sFileName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                If IsNothing(objReport) Then
                    Debug.Print("=================================================================")
                    Debug.Print(sReportFileName & " 레포트 화일을 찾을수 없습니다.")
                    Debug.Print("=================================================================")
                    Exit Function
                End If

                If IsNothing(objReport.DataDefinition.ParameterFields.Count) Then
                    intCounter = 0
                Else
                    intCounter = objReport.DataDefinition.ParameterFields.Count
                End If

                If intCounter > 0 Then
                    For i As Integer = 0 To intCounter - 1
                        'If InStr(objReport.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
                        Dim strParamName As String() = objReport.DataDefinition.ParameterFields(0).ParameterFieldName.Split(".")
                        If strParamName(0).StartsWith("Pm-") Then
                            intCounter = intCounter - 1
                        End If
                        'End If
                    Next i

                End If

                ' 레포트 파라메터 매개 변수 적용
                If intCounter > 0 And IsNothing(param) = False Then
                    For Each parameterItem As SqlParameter In param
                        currValue = objReport.DataDefinition.ParameterFields(parameterItem.ParameterName).CurrentValues
                        currValue.AddValue(parameterItem.Value)
                        objReport.DataDefinition.ParameterFields(parameterItem.ParameterName).ApplyCurrentValues(currValue)
                    Next parameterItem
                End If

                ' 레포트 파라메터 수식 변수 적용
                Dim intCounter2 As Integer = objReport.DataDefinition.FormulaFields.Count
                If intCounter2 > 0 And IsNothing(param2) = False Then
                    For Each parameterItem As SqlParameter In param2
                        objReport.DataDefinition.FormulaFields.Item(parameterItem.ParameterName).Text = parameterItem.Value
                    Next parameterItem
                End If

                ' 데이터 베이스 연결 정보 적용
                'Dim ConnectionInfo As String() = Split(DAT.SqlConnectionString.SqlConnectionStringText(), ";")

                'ConInfo.ConnectionInfo.UserID = "ipark" 'Split(ConnectionInfo(2), "=")(1) ' "sa" 'objDataBase.UserName
                'ConInfo.ConnectionInfo.Password = "iparkadmin" 'Split(ConnectionInfo(3), "=")(1) '"Net&Admin" ' objDataBase.Password
                'ConInfo.ConnectionInfo.ServerName = Split(ConnectionInfo(0), "=")(1) '"222.110.74.225" ' objDataBase.Server
                'ConInfo.ConnectionInfo.DatabaseName = Split(ConnectionInfo(1), "=")(1) '"IRIS-TEST" ' objDataBase.Database

                ' 데이터 테이블 연결
                For intCounter = 0 To objReport.Database.Tables.Count - 1
                    'objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
                Next

                ' 섹션별 서브 레포트 인식 및 서브 레포트 테이블 연결
                For index = 0 To objReport.ReportDefinition.Sections.Count - 1 ' 섹션
                    For intCounter = 0 To objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1 '섹션에 포함된 레포트 오브젝트 
                        With objReport.ReportDefinition.Sections(index)
                            ' 섹션에 포함된 서브레포트가 있다면 문서를 읽어온다
                            If .ReportObjects(intCounter).Kind = CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
                                mySubReportObject = CType(.ReportObjects(intCounter), CrystalDecisions.CrystalReports.Engine.SubreportObject)
                                mySubRepDoc = mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)
                                ' 읽어온 서브레포트의 데이터 베이스 연결 정보를 갱신한다.
                                For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
                                    'mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                                Next
                            End If
                        End With
                    Next
                Next

                ' 원하는 조건만 출력하도록 조건 주는거
                If sSelectionFormula.Length > 0 Then
                    objReport.RecordSelectionFormula = sSelectionFormula
                End If

                ' 서브레포트 프로그램 작성


                Dim SPNames As String() = Split(SPName, ";") 'SP 명 가져오기
                Dim ExecuteDbCommand As New ubiLease.DAT.ExecuteDbCommand '객체 생성
                Dim reciveDataSets As New DataSet
                Dim nPage As Integer = 0

                Dim tempSpNameSplit As String() = Split(SPNames(0), ".") '다른 db상의 sp 호출 시 db.dao를 자르기 위해

                If SPNames.Length > 0 Then

                    If SPNames.Length = 1 Then

                        reciveDataSets = ExecuteDbCommand.ExecuteStoredProcedure(tempSpNameSplit(0).Trim().Substring(0, 2), SPNames(0), False, True, param)

                        'IRIS 배포시 if else 문 주석 처리 할 것
                        If tempSpNameSplit.Length > 1 Then '접속된 DB에서 조회가 아닌, 다른 DB상의 테이블이나 쿼리 호출 시 테이블의 이름에서 db.dao 제거
                            reciveDataSets.Tables(0).TableName = tempSpNameSplit(2)
                        Else
                            reciveDataSets.Tables(0).TableName = SPNames(0)
                        End If
                        'reciveDataSets.Tables(0).TableName = SPNames(0)

                        If (reciveDataSets.Tables.Count > 0) Then
                            If (objReport.Database.Tables(0).Name = reciveDataSets.Tables(0).TableName) Then
                                objReport.SetDataSource(reciveDataSets.Tables(0))
                            End If
                        End If
                    Else

                        'reciveDataSets = ExecuteDbCommand.ExecuteStoredProcedure(tempSpNameSplit(0).Trim().Substring(0, 2), SPNames(0), False, True, 500, param)
                        reciveDataSets = ExecuteDbCommand.ExecuteStoredProcedure(tempSpNameSplit(0).Trim().Substring(0, 2), SPNames(0), False, True, param)

                        'IRIS 배포시 if else 문 주석 처리 할 것
                        If tempSpNameSplit.Length > 1 Then '접속된 DB에서 조회가 아닌, 다른 DB상의 테이블이나 쿼리 호출 시 테이블의 이름에서 db.dao 제거
                            reciveDataSets.Tables(0).TableName = tempSpNameSplit(2)
                        Else
                            reciveDataSets.Tables(0).TableName = SPNames(0)
                        End If
                        'reciveDataSets.Tables(0).TableName = SPNames(0)

                        If (reciveDataSets.Tables.Count > 0) Then
                            If (objReport.Database.Tables(0).Name = reciveDataSets.Tables(0).TableName) Then
                                objReport.SetDataSource(reciveDataSets.Tables(0))

                                Debug.Print("프린트할 페이지 : " & reciveDataSets.Tables(0).Rows.Count)
                                nPage = reciveDataSets.Tables(0).Rows.Count

                            End If
                        End If

                        For index = 0 To objReport.ReportDefinition.Sections.Count - 1 ' 섹션
                            For intCounter = 0 To objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1 '섹션에 포함된 레포트 오브젝트 
                                With objReport.ReportDefinition.Sections(index)
                                    ' 섹션에 포함된 서브레포트가 있다면 문서를 읽어온다
                                    If .ReportObjects(intCounter).Kind = CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
                                        mySubReportObject = CType(.ReportObjects(intCounter), CrystalDecisions.CrystalReports.Engine.SubreportObject)
                                        mySubRepDoc = mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)

                                        ' 읽어온 서브레포트의 데이터 베이스 연결 정보를 갱신한다.
                                        For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
                                            'mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                                            'MsgBox(mySubRepDoc.Database.Tables(intCounter1).Name)

                                            Dim RptTableName As String = mySubRepDoc.Database.Tables(intCounter1).Name

                                            Dim subReportDataSet As New DataSet(RptTableName)
                                            Dim sp_name As String = ""
                                            For Each str As String In SPNames
                                                If str.EndsWith(RptTableName) Then
                                                    sp_name = str
                                                End If
                                            Next

                                            'subReportDataSet = ExecuteDbCommand.ExecuteStoredProcedure(RptTableName, False, True, CType(ReturnParameters(RptTableName, param), System.Data.SqlClient.SqlParameter))
                                            subReportDataSet = ExecuteDbCommand.ExecuteStoredProcedure(sp_name.Trim().Substring(0, 2), sp_name, False, True, ReturnParameters(RptTableName, param))
                                            subReportDataSet.Tables(0).TableName = RptTableName
                                            mySubRepDoc.Database.Tables(RptTableName).SetDataSource(subReportDataSet.Tables(RptTableName))
                                        Next
                                    End If
                                End With
                            Next
                        Next

                    End If

                End If

                'reciveDataSets2 = ExecuteDbCommand.ExecuteStoredProcedure(SPNames(1), False, True, Param5)
                'reciveDataSets2.Tables(0).TableName = SPNames(1)

                'If (reciveDataSets2.Tables.Count > 0) Then
                '    If (mySubRepDoc.Database.Tables(0).Name = reciveDataSets2.Tables(0).TableName) Then
                '        mySubRepDoc.Database.Tables(0).SetDataSource(reciveDataSets2.Tables(0))
                '    End If
                'End If

                With frmPrint

                    .rptViewer.ReportSource = Nothing

                    .rptViewer.ReportSource = objReport



                    If directPrint Then

                        ''Dim intPageCount As Integer = objReport.FormatEngine.GetLastPageNumber(New CrystalDecisions.Shared.ReportPageRequestContext)
                        Dim intPageCount As Integer = nPage
                        Dim myprint As New System.Drawing.Printing.PrintDocument
                        Dim msg As String = "전체 페이지가 ( " & myprint.PrinterSettings.PrinterName & " )프린터로 출력됩니다." & System.Environment.NewLine & "인쇄 하시겠습니까?"

                        If MsgBox(msg, MsgBoxStyle.OkCancel, "레포트 인쇄") = 1 Then
                            'Dim myprint As New System.Drawing.Printing.PrintDocument
                            objReport.PrintOptions.PrinterName = myprint.PrinterSettings.PrinterName

                            objReport.PrintToPrinter(1, True, 1, intPageCount)
                            '.rptViewer.PrintReport()

                        End If


                    Else
                        .rptViewer.Show()
                        .rptViewer.ShowExportButton = True
                        .rptViewer.DisplayGroupTree = False
                        .ShowDialog()
                    End If

                End With


                MyBase.Visible = True
                Me.BringToFront()

                Return True

            Catch ex As System.Exception
                Gexception.getException(ex)
                'MsgBox(ex.Message)
            End Try
        End Function

        Private Function ReturnParameters(ByVal SpName As String, Optional ByVal SpParameters() As SqlParameter = Nothing) As SqlParameter()

            ' 파라메터 값 가져오기
            Dim ExecuteDbCommand As New ubiLease.DAT.ExecuteDbCommand '객체 생성
            Dim AstoredProcedureName As New SqlParameter
            Dim ParametersDataSet As New DataSet
            Dim returnParams() As SqlParameter = Nothing
            Dim GmainCommonFunction As New ubiLease.CommonFunction.Common


            AstoredProcedureName.ParameterName = "@AstoredProcedureName"
            AstoredProcedureName.Value = SpName

            ParametersDataSet = Nothing

            If IsNothing(SpParameters) Then
                ParametersDataSet = ExecuteDbCommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "GetStoredProcedureParameters", False, True, AstoredProcedureName)

                'If ParametersDataSet.Tables.Count > 0 Then
                '    For i As Integer = 0 To ParametersDataSet.Tables(0).Rows.Count - 1

                '        returnParams(i).ParameterName = ParametersDataSet.Tables(0).Rows(i).Item(0).ToString

                '        If ParametersDataSet.Tables(0).Rows(i).Item(1).ToString() = "String" Then
                '            returnParams(i).Value = ""
                '        Else
                '            returnParams(i).Value = Nothing
                '        End If
                '    Next i
                'End If
            Else

                For i As Integer = 0 To SpParameters.Length - 1
                    GmainCommonFunction.SetSqlParameter(returnParams, SpParameters(i).ParameterName, SpParameters(i).Value)
                Next i

            End If


            Return returnParams
        End Function

    End Class
End Namespace

