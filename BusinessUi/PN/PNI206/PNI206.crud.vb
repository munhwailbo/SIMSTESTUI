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

Namespace ubiLease.UI.BusinessUi.PN

    Partial Class PNI206

        ''' <summary>
        ''' 함수명 : NewData 
        ''' 기  능 : 신규 
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()
            ''If grd_2.Focused = True Then
            ''    Me.NewData_2()
            ''    Exit Sub
            ''End If
            ''Me.grd_1.AddRow()
        End Sub
        ''' <summary>
        ''' 함수명 : RequestData
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                '' ''.SetSqlParameter(GmainsqlParameters, "@AYYYYMMDD", Me.dtpBaseDt_R1.TextValue)
                ' '' ''.SetSqlParameter(GmainsqlParameters, "@ASeriesNum", Me.grd_1.GetCurrentRowCellValue("SeriesNum"))
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt", Me.dtpTaxAccPublishDt.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt2", Me.dtpTaxAccPublishDt2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ASalesDivCd", Me.cboSalesDivCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ASalesCd", Me.popSalesCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", "")

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI206_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        ''' <summary>
        ''' 함수명 : SaveData 
        ''' 기  능 : 저장
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

        End Sub

        ''' <summary>
        ''' 함수명 : DeleteData 
        ''' 기  능 : 삭제
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

        End Sub

        ''' <summary>
        ''' 함수명 : ExportData 
        ''' 기  능 : 출력
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
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
                    .SetExportCrystalDataParameter("PNI206_3_C_R.rpt", "PNI206_3_C_R", "", AsqlParameters, AformulaParameters)
                End With

            ElseIf optDemand.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(AsqlParameters, "@AreceiptGubun", IIf(Me.optDemand.Checked = True, "1", "2")) '1.청구 2.영수
                    .SetSqlParameter(AsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                    Dim AformulaParameters() As SqlParameter = Nothing
                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNI206_1_C_R.rpt", "PNI206_1_C_R;PNI206_2_C_R;", "", AsqlParameters, AformulaParameters)
                End With

            ElseIf optReceipt.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(AsqlParameters, "@AreceiptGubun", IIf(Me.optDemand.Checked = True, "1", "2")) '1.청구 2.영수
                    .SetSqlParameter(AsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                    Dim AformulaParameters() As SqlParameter = Nothing
                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNI206_1_C_R.rpt", "PNI206_1_C_R;PNI206_2_C_R;", "", AsqlParameters, AformulaParameters)
                End With
            End If
        End Sub

    End Class

End Namespace
