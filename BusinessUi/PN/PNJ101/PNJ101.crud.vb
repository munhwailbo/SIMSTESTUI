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

    Partial Class PNJ101

        ''' <summary>
        ''' �Լ��� : NewData 
        ''' ��  �� : �ű� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : Ȳ����
        ''' ������ : 2008.11.13
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()

            Me.grd_1.AddRow()
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("PublishStNum"), 1)

            'Exit Sub
            'If grd_1.Focused = True Then
            '    Me.grd_1.AddRow()
            '    Exit Sub
            'Else
            '    If Me.grd_1.GetCurrentRowCellValue("CouponPublicCd") <> "" Then
            '        Me.grd_2.AddRow()
            '        Me.grd_2.set_TextMatrix(Me.grd_2.Rows - 1, Me.grd_2.get_ColIndex("CouponSeriesNum"), Me.grd_1.GetCurrentRowCellValue("CouponPublicCd"))
            '    Else
            '        MessageBox.Show("�����ǹ����ڵ带 Ȯ���� �ű� �۾��� �ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    End If
            'End If
        End Sub

        ''' <summary>
        ''' �Լ��� : RequestData
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : Ȳ����
        ''' ������ : 2008.11.13     
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@APublishYearMonthFrom", Me.dtpPublishYearMonthFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@APublishYearMonthTo", Me.dtpPublishYearMonthTo.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.popCouponCorpCd.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            Call SetSubTotal()
        End Sub
        Private Sub SetSubTotal()

            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Tree.Column = .get_ColIndex("TreePath")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData

                    ' '' =============================================================================
                    '' '' '' �׸��� �հ��� �߰�
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("CirculationNum"), "�հ�")
                    '.set_TextMatrix(.FixedRows, .get_ColIndex("ChargeEmpNm"), "��   ��")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                If grd_1.Rows > 1 Then
                    .SetSqlParameter(GmainsqlParameters, "@ACouponPublicCd", grd_1.GetCurrentRowCellValue("CouponPublicCd"))
                    .SetSqlParameter(GmainsqlParameters, "@AOrders", grd_1.GetCurrentRowCellValue("Orders"))

                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_R", False, True, GmainsqlParameters)
                    Me.grd_2.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End If
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : SaveData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : Ȳ����
        ''' ������ : 2008.11.13
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            If Me.ValidationCheck = False Then
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Sub
            End If

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            'If grd_1.Focused = True Then
            '    If Me.ValidationCheck(Me.grd_1) = False Then
            '        Exit Sub
            '    End If
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        GmainCommonFunction.SaveDataMessage(Me)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            'ElseIf Me.grd_2.Focus = True Then
            '    If Me.ValidationCheck(Me.grd_2) = False Then
            '        Exit Sub
            '    End If
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        GmainCommonFunction.SaveDataMessage(Me)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '        GmainExecuteDbCommand.GerrorNumber = 1
            '    End If
            'End If
        End Sub

        Public Sub DetailSave()
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
                Call RequestData_2()
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If
        End Sub

        Private Sub saveImage(ByVal bytBuffer() As Byte)

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhotoFilePath", bytBuffer)   '�ֹι�ȣ

            Try
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    '.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    '.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", txtChiefCd.Text.Trim())
                    '.SetSqlParameter(GmainsqlParameters, "@APhotoFilePath", bytBuffer)
                    'GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_2_CUD", True, False, GmainsqlParameters)
                    '.SetAllBusinessUiInitialValue(Me)
                    '.SaveDataMessage(Me)
                End With

                MessageBox.Show("�̹����� ���� �Ǿ����ϴ�.", "�߰�", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        End Sub

        ''' <summary>
        ''' �Լ��� : DeleteData 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : Ȳ����
        ''' ������ : 2008.11.13        
        ''' ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            If MessageBox.Show("�����͸� ���� �Ͻðڽ��ϱ�? ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                MessageBox.Show("����Ÿ�������Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)


            'If Me.grd_1.Focus = True Then
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        MessageBox.Show("����Ÿ�������Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            'ElseIf Me.grd_2.Focus = True Then
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        MessageBox.Show("����Ÿ�������Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            'End If
        End Sub

        Public Sub DetailDelete()

            If Me.grd_2.Rows < 2 Then
                MessageBox.Show("������ ������ �����ϴ� Ȯ���� �۾��ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If MessageBox.Show("���� �����͸� ���� �Ͻðڽ��ϱ�? ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                MessageBox.Show("����Ÿ�������Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call RequestData_2()
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        End Sub


        ''' <summary>
        ''' �Լ��� : ValidationCheck
        ''' �� ��  : ����, ������ ���ռ� üũ
        ''' �ۼ��� : Ȳ����
        ''' �ۼ��� : 2008.11.13
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ValidationCheck() As Boolean
            ValidationCheck = False

            If Me.grd_1.Rows > 1 Then

                Dim strPublishYearMonth As String = ""
                For inti As Integer = 0 To Me.grd_1.Rows - 1
                    If Me.grd_1.GetCellCheck(inti, Me.grd_1.get_ColIndex("����")) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                        strPublishYearMonth = Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("PublishYearMonth")) & "-01"
                        If IsDate(strPublishYearMonth) = False Then
                            MessageBox.Show("�������� Ȯ���� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                        If Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("CouponCorpCd")) = "" Then
                            MessageBox.Show("�Ҽӻ��ڵ带 �ݵ�� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                        If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("CirculationNum"))) = False Then
                            MessageBox.Show("����μ��� Ȯ���� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                        If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("UnitCost"))) = False Then
                            MessageBox.Show("�ܰ��� Ȯ���� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                    End If
                Next inti
            End If

            ValidationCheck = True
        End Function

        ''' <summary>
        ''' �Լ��� : ExportData 
        ''' ��  �� : ���
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ExportData()

         '   Dim AsqlParameters() As SqlParameter = Nothing
         '
         '   With GmainCommonFunction
         '       .SetSqlParameter(AsqlParameters, "@AcodeDivisionHangulName", Me.txtCodeDivisionHangulName.TextValue)
         '       .SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)
         '
         '       'Dim AAAA As String = ""
         '       'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"
         '
         '       Dim AformulaParameters() As SqlParameter = Nothing
         '
         '       'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
         '       .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")
         '
         '       ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
         '       .SetExportCrystalDataParameter("PNJ101.rpt", "PNJ101_R", "", AsqlParameters, AformulaParameters)
         '   End With

        End Sub

    End Class

End Namespace
