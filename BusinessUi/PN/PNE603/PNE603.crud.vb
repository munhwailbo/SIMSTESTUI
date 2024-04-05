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
                .SetSqlParameter(GmainsqlParameters, "@APrintMode", 0)
            End With

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE603_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            If Me.grd_1.Rows > Me.grd_1.FixedRows Then
                SetSubTotal()
            End If

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

#Region "���� ����ϱ�"
        Public Sub ExportExcel(Gubn As Integer)
            Dim reciveDataSet As DataSet = New DataSet()
            If Gubn = 0 Then
                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AExpandDt", Me.dtpExpandDt.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGubn", Gubn)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APrintMode", 1)
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE603_R", False, True, GmainsqlParameters)

                If reciveDataSet Is Nothing Then Exit Sub

                '��ȸ�� �����Ͱ� ������ ����
                If reciveDataSet.Tables(0).Rows.Count < 1 Then
                    MessageBox.Show("������ ���� ��� ����Ÿ�� �����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim xlApp As Object
                Dim xlBook As Object
                Dim xlsheet As Object
                Dim xlData(reciveDataSet.Tables(0).Rows.Count, reciveDataSet.Tables(0).Columns.Count) As Object

                'MessageBox.Show(reciveDataSet.Tables(0).Rows.Count)
                'MessageBox.Show(reciveDataSet.Tables(0).Columns.Count)

                xlApp = CreateObject("Excel.Application")
                xlApp.DisplayAlerts = False

                xlBook = xlApp.Workbooks.Open("http://simsapp.munhwa.com/SIMS_DLL/Excel/PNE603.xlsx") '���� ����� ����

                'xlBook = xlApp.Workbooks.Add
                xlsheet = xlBook.Worksheets(1)

                Try
                    '1. �⵵ ä���
                    xlsheet.Range("A4").Value = "�Ź��б�ķ���� �Ǹ���ȯ ����(" & RemoveZeroInDateStr(Me.dtpExpandDt.TextValue.Substring(4, 2)) & "/" & RemoveZeroInDateStr(Me.dtpExpandDt.TextValue.Substring(6, 2)) & ")"

                    '2. ������ ä���
                    Dim startCell As Object = xlsheet.Cells(8, 1)
                    Dim endCell As Object = xlsheet.Cells(reciveDataSet.Tables(0).Rows.Count + 7, reciveDataSet.Tables(0).Columns.Count + 1)
                    Dim writeRange As Object = xlsheet.Range(startCell, endCell)

                    For i As Integer = 0 To reciveDataSet.Tables(0).Rows.Count - 1 '�� �ε���
                        For j As Integer = 0 To reciveDataSet.Tables(0).Columns.Count - 1 '�� �ε���
                            If j = 0 Then reciveDataSet.Tables(0).Rows(i).Item(j) = reciveDataSet.Tables(0).Rows(i).Item(j).SubString(0, 4) & "." + reciveDataSet.Tables(0).Rows(i).Item(j).SubString(4, 2) & "." + reciveDataSet.Tables(0).Rows(i).Item(j).SubString(6, 2)
                            xlData(i, j) = reciveDataSet.Tables(0).Rows(i).Item(j)
                        Next
                    Next

                    writeRange.Value2 = xlData

                    ''3. ��� ���߱�
                    Dim hiddenStr = (reciveDataSet.Tables(0).Rows.Count.ToString + 8) & ":" & (37).ToString
                    xlsheet.Rows(hiddenStr).Hidden = True
                    xlsheet.Columns(12).Hidden = True

                    '4. ������
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
            ElseIf Gubn = 1 Then
                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AExpandDt", Me.dtpExpandDt.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGubn", Gubn)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APrintMode", 1)
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE603_R", False, True, GmainsqlParameters)

                If reciveDataSet Is Nothing Then Exit Sub

                ' ��ȸ�� �����Ͱ� ������ ����
                If (reciveDataSet.Tables(0).Rows.Count + reciveDataSet.Tables(1).Rows.Count) < 1 Then
                    MessageBox.Show("������ ���� ��� ����Ÿ�� �����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim xlApp As Object
                Dim xlBook As Object
                Dim xlsheet As Object
                Dim xlData(reciveDataSet.Tables(0).Rows.Count, reciveDataSet.Tables(0).Columns.Count) As Object
                Dim xlData2(reciveDataSet.Tables(1).Rows.Count, reciveDataSet.Tables(1).Columns.Count) As Object

                ' MessageBox.Show(reciveDataSet.Tables(1).Rows.Count)
                'MessageBox.Show(reciveDataSet.Tables(1).Columns.Count)

                xlApp = CreateObject("Excel.Application")
                xlApp.DisplayAlerts = False

                xlBook = xlApp.Workbooks.Open("http://simsapp.munhwa.com/SIMS_DLL/Excel/PNE603_2.xlsx") '���� ����� ����

                'xlBook = xlApp.Workbooks.Add
                xlsheet = xlBook.Worksheets(1)

                Try
                    '1. �⵵ ä���
                    xlsheet.Range("A4").Value = "�Ź��б�ķ���� �Ǹ���ȯ ����(" & RemoveZeroInDateStr(Me.dtpExpandDt.TextValue.Substring(4, 2)) & "/" & RemoveZeroInDateStr(Me.dtpExpandDt.TextValue.Substring(6, 2)) & ")"

                    '2. ������ ä���
                    Dim startCell As Object = xlsheet.Cells(8, 1)
                    Dim endCell As Object = xlsheet.Cells(reciveDataSet.Tables(0).Rows.Count + 7, reciveDataSet.Tables(0).Columns.Count + 1)
                    Dim writeRange As Object = xlsheet.Range(startCell, endCell)

                    For i As Integer = 0 To reciveDataSet.Tables(0).Rows.Count - 1 '�� �ε���
                        For j As Integer = 0 To reciveDataSet.Tables(0).Columns.Count - 1 '�� �ε���
                            ' If j = 0 Then reciveDataSet.Tables(0).Rows(i).Item(j) = reciveDataSet.Tables(0).Rows(i).Item(j).SubString(0, 4) & "." + reciveDataSet.Tables(0).Rows(i).Item(j).SubString(4, 2) & "." + reciveDataSet.Tables(0).Rows(i).Item(j).SubString(6, 2)
                            xlData(i, j) = reciveDataSet.Tables(0).Rows(i).Item(j)
                        Next
                    Next

                    writeRange.Value2 = xlData

                    Dim startCell2 As Object = xlsheet.Cells(42, 1)
                    Dim endCell2 As Object = xlsheet.Cells(reciveDataSet.Tables((1)).Rows.Count + 42, reciveDataSet.Tables((1)).Columns.Count + 1)
                    Dim writeRange2 As Object = xlsheet.Range(startCell2, endCell2)

                    For i As Integer = 0 To reciveDataSet.Tables(1).Rows.Count - 1 '�� �ε���
                        For j As Integer = 0 To reciveDataSet.Tables(1).Columns.Count - 1 '�� �ε���
                            ' If j = 0 Then reciveDataSet.Tables(1).Rows(i).Item(j) = reciveDataSet.Tables(1).Rows(i).Item(j).SubString(1, 4) & "." + reciveDataSet.Tables(1).Rows(i).Item(j).SubString(4, 2) & "." + reciveDataSet.Tables(1).Rows(i).Item(j).SubString(6, 2)
                            xlData2(i, j) = reciveDataSet.Tables((1)).Rows(i).Item(j)
                        Next
                    Next

                    writeRange2.Value2 = xlData2

                    '3. ��� ���߱�
                    Dim hiddenStr = Nothing
                    If reciveDataSet.Tables(0).Rows.Count = 0 Then
                        hiddenStr = "6:39"
                    Else
                        hiddenStr = (reciveDataSet.Tables(0).Rows.Count.ToString + 8) & ":" & (37).ToString
                    End If
                    xlsheet.Rows(hiddenStr).Hidden = True

                    If reciveDataSet.Tables(1).Rows.Count = 0 Then
                        hiddenStr = "39:72"
                    Else
                        hiddenStr = (reciveDataSet.Tables(1).Rows.Count.ToString + 42) & ":" & (71).ToString
                    End If
                    xlsheet.Rows(hiddenStr).Hidden = True


                    xlsheet.Columns(12).Hidden = True

                    '4. ������
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
            End If


        End Sub
#End Region

#Region "���ڿ� �տ� 0 ����"
        Private Function RemoveZeroInDateStr(ByVal str As String) As String
            Dim temp = Integer.Parse(str)
            str = temp.ToString()
            Return str
        End Function
#End Region

#Region "�հ�"
        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue


                    ' '' =============================================================================
                    '' '' '' �׸��� �հ��� �߰�
                    ' '' =============================================================================
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, -1, -1, .get_ColIndex("SumExpPapNum"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, -1, -1, .get_ColIndex("ChangeAmount"), "��  ��")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, -1, -1, .get_ColIndex("AdAmount"), "��  ��")
                    .set_TextMatrix(.Rows - 1, .get_ColIndex("ExpandDt"), "��   ��")
                    Me.grd_1.FrozenRows = .Rows - 1
                End If
            End With
        End Sub
#End Region

    End Class



End Namespace
