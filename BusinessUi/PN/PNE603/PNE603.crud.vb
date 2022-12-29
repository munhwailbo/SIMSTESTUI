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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.SM

    Partial Class PNE603

        '====================================================================================================
        Public Sub NewData()


        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AExpandDt", Me.dtpExpandDt.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AGubn", 0)
            End With

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE603_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub SaveData()

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

        End Sub

        Public Sub ExportData()
            ExportExcel(0)
        End Sub

#Region "엑셀 출력하기"
        Public Sub ExportExcel(Gubn As Integer)
            Dim reciveDataSet As DataSet = New DataSet()

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AExpandDt", Me.dtpExpandDt.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGubn", Gubn)
            reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE603_R", False, True, GmainsqlParameters)

            If reciveDataSet Is Nothing Then Exit Sub

            '조회된 데이터가 없으면 나감
            If reciveDataSet.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("선택한 건의 결과 데이타가 없습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim xlApp As Object
            Dim xlBook As Object
            Dim xlsheet As Object
            Dim xlData(reciveDataSet.Tables(0).Rows.Count, reciveDataSet.Tables(0).Columns.Count - 1) As Object
            'Dim xlData_2(reciveDataSet.Tables(1).Rows.Count, reciveDataSet.Tables(1).Columns.Count - 1) As Object

            xlApp = CreateObject("Excel.Application")
            xlApp.DisplayAlerts = False

            xlBook = xlApp.Workbooks.Open("http://simsapp.munhwa.com/SIMS_DLL/Excel/PNE603.xlsx") '엑셀 양식지 열기

            'xlBook = xlApp.Workbooks.Add
            xlsheet = xlBook.Worksheets(1)

            Try
                '1. 년도 채우기
                xlsheet.Range("A4").Value = "신문읽기캠페인 판매전환 내역(" & RemoveZeroInDateStr(Me.dtpExpandDt.TextValue.Substring(4, 2)) & "/" & RemoveZeroInDateStr(Me.dtpExpandDt.TextValue.Substring(6, 2)) & ")"

                '2. 데이터 채우기
                Dim startCell As Object = xlsheet.Cells(8, 1)
                Dim endCell As Object = xlsheet.Cells(reciveDataSet.Tables(0).Rows.Count + 7, reciveDataSet.Tables(0).Columns.Count + 1)
                Dim writeRange As Object = xlsheet.Range(startCell, endCell)

                For i As Integer = 0 To reciveDataSet.Tables(0).Rows.Count - 1 '행 인덱스
                    For j As Integer = 0 To reciveDataSet.Tables(0).Columns.Count - 1 '열 인덱스
                        If j = 0 Then reciveDataSet.Tables(0).Rows(i).Item(j) = reciveDataSet.Tables(0).Rows(i).Item(j).SubString(0, 4) & "." + reciveDataSet.Tables(0).Rows(i).Item(j).SubString(4, 2) & "." + reciveDataSet.Tables(0).Rows(i).Item(j).SubString(6, 2)
                        xlData(i, j) = reciveDataSet.Tables(0).Rows(i).Item(j)
                    Next
                Next

                writeRange.Value2 = xlData

                ''3. 양식 감추기
                Dim hiddenStr = (reciveDataSet.Tables(0).Rows.Count.ToString + 8) & ":" & (37).ToString
                xlsheet.Rows(hiddenStr).Hidden = True

                '4. 마무리
                xlsheet.Application.Visible = True
                xlsheet = Nothing
                xlBook = Nothing
                xlApp = Nothing

            Catch ex As Exception

                MessageBox.Show(ex.Message, "Exception Handler")

                xlsheet.Application.Visible = True

                xlsheet = Nothing
                xlBook = Nothing
                'xlApp.Quit()
                xlApp = Nothing

            End Try
        End Sub
#End Region

#Region "문자열 앞에 0 제거"
        Private Function RemoveZeroInDateStr(ByVal str As String) As String
            Dim temp = Integer.Parse(str)
            str = temp.ToString()
            Return str
        End Function
#End Region

    End Class



End Namespace
