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

Namespace ubiLease.UI.BusinessUi.PN

    Partial Class PNI102

        ''' <summary>
        ''' �Լ��� : NewData 
        ''' ��  �� : �ű� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()

            'if me.popBranchCd.NameText = "" then '�˾� ��Ʈ�� ��� ���ɽ� �̰ɷ� �ٲ�.
            If popBranchNum.TextValue = "" Then
                MessageBox.Show("������ȣ�� �ݵ�� ������ �ű� �۾��� �ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Me.txtOrders.TextValue = "" Then
                MessageBox.Show("������ Ȯ���� �ű� �۾��� �ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            With Me.grd_2
                .AddRow()
                .set_TextMatrix(.Rows - 1, .get_ColIndex("CalYearMonths"), Me.dtpCalYearMonths_2.TextValue)
                .set_TextMatrix(.Rows - 1, .get_ColIndex("BranchNum"), popBranchNum.TextValue)
                .set_TextMatrix(.Rows - 1, .get_ColIndex("Orders"), Me.txtOrders.TextValue)
                .set_TextMatrix(.Rows - 1, .get_ColIndex("CalAmt"), 0)
            End With
        End Sub

        ''' <summary>
        ''' �Լ��� : RequestData
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainCommonFunction.ControlNewData(Me, Me.picIo_1)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ACalYearMonths", Me.dtpCalYearMonths.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI102_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)

                If IsNothing(reciveDataSet) = False Then
                    If reciveDataSet.Tables.Count > 0 Then
                        If reciveDataSet.Tables(0).Rows.Count > 0 Then
                            Me.dtpCalYearMonths_2.TextValue = reciveDataSet.Tables(0).Rows(0).Item("CalYearMonths")
                            Me.popBranchNum.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchNum")
                            Me.txtOrders.TextValue = reciveDataSet.Tables(0).Rows(0).Item("Orders")
                        End If
                    End If
                End If

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : RequestData_2
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ACalYearMonths", Me.grd_1.GetCurrentRowCellValue("CalYearMonths"))
                .SetSqlParameter(GmainsqlParameters, "@AOrders", Me.grd_1.GetCurrentRowCellValue("Orders"))
                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.grd_1.GetCurrentRowCellValue("BranchNum"))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI102_2_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : SaveData 
        ''' ��  �� : ����
        ''' �ۼ��� : Ȳ����
        ''' �ۼ��� : 2006-09-19
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ACalYearMonths", Me.dtpCalYearMonths_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.popBranchNum.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AOrders", Me.txtOrders.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI102_CUD", True, False, GmainsqlParameters)
            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

        End Sub

        ''' <summary>
        ''' �Լ��� : DeleteData 
        ''' ��  �� : ����
        ''' �ۼ��� : Ȳ����
        ''' �ۼ��� : 2006-09-19
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()
            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ACalYearMonths", Me.dtpCalYearMonths_2.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.popBranchNum.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AOrders", Me.txtOrders.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI102_CUD", True, False, GmainsqlParameters)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If
        End Sub

        Private Function Validation() As Boolean
            Validation = False
            With Me.grd_2
                For intForNumber As Integer = 0 To .Rows - 1
                    If .GetCellCheck(intForNumber, .get_ColIndex("����")) = CheckEnum.Checked Then

                        'If .get_TextMatrix(intForNumber, .get_ColIndex("SettlementCode")) = "" Then
                        '    MessageBox.Show("�����ڵ带 �ݵ�� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    Exit Function
                        'End If

                        If IsNumeric(.get_TextMatrix(intForNumber, Me.txtOrders.TextValue)) = False Then
                            MessageBox.Show("������ �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Function
                        End If

                        If IsNumeric(.get_TextMatrix(intForNumber, .get_ColIndex("CalAmt"))) = False Then
                            MessageBox.Show("����ݾ��� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Function
                        End If
                        
                    End If
                Next intForNumber
            End With

            Validation = True
        End Function

    End Class

End Namespace
