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

Namespace ubiLease.UI.BusinessUi.SM

    Partial Class SMBA01

        ''' <summary>
        ''' 함수명 : NewData 
        ''' 기  능 : 신규 
        ''' 작성자 : 
        ''' 작성일 : 2006-08-17
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()
            If grd_2.Focused = True Then
                Me.NewData_2()
                Exit Sub
            End If
            Me.grd_1.AddRow()
        End Sub
        ''' <summary>
        ''' 함수명 : RequestData
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 2006-08-17
        ''' 수정자 : 
        ''' 수정일 :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            If grd_2.Focused = True Then
                Me.RequestData_2()
                Exit Sub
            End If
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AcodeDivisionHangulName", Me.txtCodeDivisionHangulName.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMBA01_R", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)
                'Me.grd_1.SetDataSetsToGrid(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub
        ''' <summary>
        ''' 함수명 : SaveData 
        ''' 기  능 : 저장
        ''' 작성자 : 
        ''' 작성일 : 2006-08-17
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()
            'Dim i As Integer
            'grd_1.get_RowData(grd_1.SelectedRow(
            'For i = 1 To grd_1.Rows - 1
            '    If Len(grd_1.get_TextMatrix(i, grd_1.get_ColIndex("CodeDivision_2"))) > 0 Then
            '        MsgBox("마스터 코드를 지정해야합니다.", MsgBoxStyle.OkOnly, "범위 오류")
            '    End If

            'Next i
            If grd_2.Focused = True Then
                Me.SaveData_2()
                Exit Sub
            End If

            If grd_1.CheckNeedValue(grd_1) Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMBA01_CUD", True, False, GmainsqlParameters)

                    .SetAllBusinessUiInitialValue(Me)
                    .SaveDataMessage(Me)
                End With

                Me.RequestData()
            End If
        End Sub
        ''' <summary>
        ''' 함수명 : DeleteData 
        ''' 기  능 : 삭제
        ''' 작성자 : 
        ''' 작성일 : 2006-08-17
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()
            If grd_2.Focused = True Then
                Me.DeleteData_2()
                Exit Sub
            End If
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMBA01_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .DeleteDataMessage(Me)
            End With

            Me.RequestData()
        End Sub
        ''' <summary>
        ''' 함수명 : ExportData 
        ''' 기  능 : 출력
        ''' 작성자 : 
        ''' 작성일 : 2006-08-17
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ExportData()

            Dim AsqlParameters() As SqlParameter = Nothing

            With GmainCommonFunction
                .SetSqlParameter(AsqlParameters, "@AcodeDivisionHangulName", Me.txtCodeDivisionHangulName.TextValue)
                .SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

                'Dim AAAA As String = ""
                'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                Dim AformulaParameters() As SqlParameter = Nothing

                'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                ' 공통변수의정의가생성시에발생될수있도록유도한다.
                .SetExportCrystalDataParameter("SMBA01.rpt", "SMBA01_R", "", AsqlParameters, AformulaParameters)
            End With

        End Sub

    End Class

End Namespace
