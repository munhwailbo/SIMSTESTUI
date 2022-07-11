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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.BM

    Partial Class BMB101

        ''' <summary>
        ''' �Լ��� : NewData 
        ''' ��  �� : �ű� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()
        End Sub
        ''' <summary>
        ''' �Լ��� : RequestData
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@AMutualYearMonth", Me.dtpMutualYearMonth.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "BMB101_R", False, True, GmainsqlParameters)

                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing

                'Fixed �÷� Merge
                Me.grd_1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                For i As Integer = 0 To Me.grd_1.get_ColIndex("ChargeEmpNumNm")
                    Me.grd_1.ColumnCollection(i).AllowMerging = True
                Next

                For i As Integer = Me.grd_1.FixedRows - 1 To Me.grd_1.Row - 1
                    Me.grd_1.set_MergeRow(i, True)
                Next

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub

        ''' <summary>
        ''' �Լ��� : SaveData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            If Me.grd_1.Rows < 1 Then
                Exit Sub
            End If

            If Me.Validation = True Then

                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMutualYearMonth", Me.dtpMutualYearMonth.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "BMB101_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    GmainCommonFunction.GRequestDataNumber = 1
                End If
            Else
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

        End Sub

        ''' <summary>
        ''' �Լ��� : DeleteData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            If MessageBox.Show("�����͸� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMutualYearMonth", Me.dtpMutualYearMonth.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "BMB101_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�������Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GmainCommonFunction.GRequestDataNumber = 1
                    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        Private Function Validation() As Boolean
            Validation = False
            Dim strMutualDate As String = ""

            For intForNumber As Integer = 0 To Me.grd_1.Rows - 1
                If Me.grd_1.GetCellCheck(intForNumber, Me.grd_1.get_ColIndex("����")) = CheckEnum.Checked Then

                    'If Me.grd_1.get_TextMatrix(intForNumber, Me.grd_1.get_ColIndex("MutualBranchCode")) = "" Then
                    '    MessageBox.Show("���������ڵ带 �ݵ�� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Exit Function
                    'End If


                    'strMutualDate = Me.grd_1.get_ColIndex("MutualYearMonth") + "-01"

                    'If IsDate(Me.grd_1.get_TextMatrix(intForNumber, strMutualDate)) = False Then
                    '    MessageBox.Show("��������� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Exit Function
                    'End If

                    'If IsDate(Me.grd_1.get_TextMatrix(intForNumber, Me.grd_1.get_ColIndex("JoinDate"))) = True Then
                    '    If Me.grd_1.GetCellCheck(intForNumber, Me.grd_1.get_ColIndex("SubjectYON")) = CheckEnum.Unchecked Then
                    '        MessageBox.Show("�������ڰ� ��ϵǾ� ������� ���Կ��� üũ�� �ϼž� �մϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '        Exit Function
                    '    End If
                    'End If
                End If
            Next intForNumber
            Validation = True
        End Function

    End Class

End Namespace
