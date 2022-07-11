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

    Partial Class PNI205

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

            If grd_3.Focused = False Then

                '' ' ������ ���� �ʱ�ȭ
                GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
                Me.dtpTaxAccPublishDt.TextValue = DateTime.Now()
                Me.txtSeriesNum.TextValue = ""

                grd_3.Rows = grd_3.FixedRows
            End If

            '' ''  �׸��� �ʱ�ȭ ����
            If Me.grd_3.Rows - Me.grd_3.FixedRows > 4 Then Exit Sub

            lblRecordState.Text = "�ű�"
            Me.grd_3.AddRow()
            Me.grd_3.set_TextMatrix(grd_3.Rows - 1, Me.grd_3.get_ColIndex("SeriesNum"), Me.grd_1.GetCurrentRowCellValue("SeriesNum"))
            Me.grd_3.set_TextMatrix(grd_3.Rows - 1, Me.grd_3.get_ColIndex("Orders"), Me.grd_3.Rows - Me.grd_3.FixedRows)

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
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt", Me.dtpTaxAccPublishDt_R1.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt2", Me.dtpTaxAccPublishDt_R2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ASalesDivCd", Me.cboSalesDivCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ASalesCd", Me.popSalesCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", "")
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub

        ''' <summary>
        ''' �Լ��� : RequestData_2 
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("TaxAccPublishDt")).ToString.Replace("-", ""))
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt2", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("TaxAccPublishDt")).ToString.Replace("-", ""))
                .SetSqlParameter(GmainsqlParameters, "@ASalesDivCd", "")
                .SetSqlParameter(GmainsqlParameters, "@ASalesCd", "")
                .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("SeriesNum")))  'Me.txtSeriesNum.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_R", False, True, GmainsqlParameters)
                If reciveDataSet.Tables.Count > 0 Then
                    lblRecordState.Text = "��ȸ"
                    .SetDataSetToControls(reciveDataSet, Me)
                End If

                '' ''If reciveDataSet.Tables.Count >= 1 And reciveDataSet.Tables(0).Rows.Count >= 1 Then
                '' ''    Me.numSupplyTotalAmt.TextValue = Me.grd_1.GetCurrentRowCellValue("SupplyTotalAmt")
                '' ''    Me.popOldPostNum.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumePostNum")
                '' ''    Me.txtConsumerAddr.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerAddr")
                '' ''    Me.txtConsumerAddr2.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerAddr2")

                '' ''    Me.txtConsumerBusinessNum.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerBusinessNum")
                '' ''    Me.txtConsumerCorpNm.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerCorpNm")
                '' ''    Me.txtConsumerPresidentNm.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerPresidentNm")
                '' ''    Me.txtConsumerBusiStatusCd.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerBusiStatusCd")
                '' ''    Me.txtConsumerBusiTypeCd.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerBusiTypeCd")

                '' ''    Me.cboSalesDiviCd.TextValue = Me.grd_1.GetCurrentRowCellValue("SalesDiviCd")
                '' ''    Me.popSalesCd.TextValue = Me.grd_1.GetCurrentRowCellValue("SalesCd").ToString().Split(".")(0)
                '' ''    Me.dtpRcptDate.TextValue = Me.grd_1.GetCurrentRowCellValue("TaxAccPublishDt")
                '' ''    Me.txtSeriesNum.TextValue = Me.grd_1.GetCurrentRowCellValue("SeriesNum")
                '' ''End If

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        ''' <summary>
        ''' �Լ��� : RequestData_3 
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("SeriesNum")))  'Me.txtSeriesNum.TextValue)
                ' ''.SetSqlParameter(GmainsqlParameters, "@ASeriesNum", Me.txtSeriesNum.TextValue)  'Me.txtSeriesNum.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_2_R", False, True, GmainsqlParameters)
                Me.grd_3.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub

        Public Sub BusinessDetail()

            Dim ConsumerPostNum As String = vbNullString
            Dim ConsumerAddr As String = vbNullString
            Dim ConsumerAddr2 As String = vbNullString
            Dim ConsumerBusinessNum As String = vbNullString
            Dim ConsumerBusiStatusCd As String = vbNullString
            Dim ConsumerBusiTypeCd As String = vbNullString
            Dim ConsumerCorpNm As String = vbNullString
            Dim ConsumerPresidentNm As String = vbNullString

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ADegree", Me.cboSalesDiviCd.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popSalesCd.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_3_R", False, True, GmainsqlParameters)
                If reciveDataSet.Tables.Count > 0 Then
                    ConsumerPostNum = reciveDataSet.Tables(0).Rows(0).Item("PostNum")
                    ConsumerAddr = reciveDataSet.Tables(0).Rows(0).Item("Addr1")
                    ConsumerAddr2 = reciveDataSet.Tables(0).Rows(0).Item("Addr2")
                    ConsumerBusinessNum = reciveDataSet.Tables(0).Rows(0).Item("BusinessNum")
                    ConsumerBusiStatusCd = reciveDataSet.Tables(0).Rows(0).Item("BusiStatus")
                    ConsumerBusiTypeCd = reciveDataSet.Tables(0).Rows(0).Item("BusiType")
                    ConsumerCorpNm = reciveDataSet.Tables(0).Rows(0).Item("FirmNm")
                    ConsumerPresidentNm = reciveDataSet.Tables(0).Rows(0).Item("RepresenName")
                End If
                reciveDataSet = Nothing
            End With
            Me.popConsumerPostNum.TextValue = ConsumerPostNum
            Me.txtConsumerAddr.TextValue = ConsumerAddr
            Me.txtConsumerAddr2.TextValue = ConsumerAddr2
            Me.txtConsumerBusinessNum.TextValue = ConsumerBusinessNum
            Me.txtConsumerBusiStatusCd.TextValue = ConsumerBusiStatusCd
            Me.txtConsumerBusiTypeCd.TextValue = ConsumerBusiTypeCd
            Me.txtConsumerCorpNm.TextValue = ConsumerCorpNm
            Me.txtConsumerPresidentNm.TextValue = ConsumerPresidentNm


        End Sub

        '' <summary>
        '' �Լ��� : SaveData 
        '' ��  �� : ����
        '' �ۼ��� : 
        '' �ۼ��� : 2008.09.01
        '' ������ : 
        ' ������ : 
        '' </summary>
        '' <remarks></remarks>
        'Public Sub SaveData()


        '    If grd_3.Focused = True Then
        '        Me.SaveData_2()
        '        Exit Sub

        '    End If
        ''GmainsqlParameters = Nothing
        ''With GmainCommonFunction
        ''    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
        ''    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
        ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_CUD", True, False, GmainsqlParameters)
        ''    .SetAllBusinessUiInitialValue(Me)
        ''    '' .SaveDataMessage(Me)
        ''End With
        ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
        ''    GmainCommonFunction.SaveDataMessage(Me)
        ''Else
        ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        ''End If

        'End Sub

        '====================================================================================================
        Public Sub SaveData()

            Dim strMode As String = ""
            '' ''If grd_3.Focused = True Then
            '' ''    Me.SaveData2()
            '' ''    Exit Sub
            '' ''End If

            'If Me.grd_1.GetCurrentRowCellValue("SeriesNum").Length < 1 Then
            If Me.txtSeriesNum.TextValue = "" Then
                strMode = "1" '�ű�
            Else
                strMode = "2" '����
            End If
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", IIf(lblRecordState.Text = "�ű�", "1", "2"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASeriesNum", IIf((strMode = "1") = True, 0, Me.grd_1.GetCurrentRowCellValue("SeriesNum")))                       ' ������ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt", Me.dtpTaxAccPublishDt.TextValue)           ' ��������
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillGroupNum", Replace(Me.dtpTaxAccPublishDt.TextValue, "-", "").Substring(0, 6))              ' å��ȣ-��
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillGroupSeriesNum", Replace(Me.dtpTaxAccPublishDt.TextValue, "-", "").Substring(6, 2))        ' å��ȣ-ȣ 
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillSeriesNum", 0)

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASalesDiviCd", Me.cboSalesDiviCd.TextValue)                          ' ��������
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASalesCd", Me.popSalesCd.TextValue)                     ' �Ѱ��ޱݾ�
            ' 
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWriteDt", Me.dtpTaxAccPublishDt.TextValue)                          ' ��������
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASupplyTotalAmt", Me.TxtTotalSupAmt.TextValue)                ' �Ѱ��ޱݾ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusinessNum", Me.txtConsumerBusinessNum.TextValue)   ' ��Ϲ�ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerCorpNm", Me.txtConsumerCorpNm.TextValue)             ' ��ȣ(���θ�)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerPresidentNm", Me.txtConsumerPresidentNm.TextValue)   ' ����
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerPostNum", Me.popConsumerPostNum.TextValue)                ' �����ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerAddr", Me.txtConsumerAddr.TextValue)                             ' �ּ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerAddr2", Me.txtConsumerAddr2.TextValue)                            ' ���ּ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusiStatusCd", Me.txtConsumerBusiStatusCd.TextValue) ' �����ڵ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusiTypeCd", Me.txtConsumerBusiTypeCd.TextValue)      ' �����ڵ�
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABlankNum", 0)                     ' ����
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", "")

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(False))
            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
                Me.GmainCommonFunction.GRequestDataNumber = 1
                CallByName(Me, "RequestData", CallType.Method)
                ''''''''''popBaseBranchCd_R.TextValue = popBranchCd.NameText
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub


        '''''''' <summary>
        '''''''' �Լ��� : SaveData_2 
        '''''''' ��  �� : ����
        '''''''' �ۼ��� : 
        '''''''' �ۼ��� : 2008.09.01
        '''''''' ������ : 
        '''''''' ������ : 
        '''''''' </summary>
        '''''''' <remarks></remarks>
        ' '' ''Public Sub SaveData2()

        ' '' ''    GmainsqlParameters = Nothing
        ' '' ''    With GmainCommonFunction
        ' '' ''        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
        ' '' ''        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(False))
        ' '' ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_2_CUD", True, False, GmainsqlParameters)
        ' '' ''        '' .SaveDataMessage(Me)
        ' '' ''    End With
        ' '' ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
        ' '' ''        GmainCommonFunction.SaveDataMessage(Me)
        ' '' ''        Me.picIo_2.Select()
        ' '' ''        Me.RequestData()
        ' '' ''    Else
        ' '' ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        ' '' ''    End If
        ' '' ''    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        ' '' ''End Sub

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

            If grd_3.Focused = True Then
                Me.DeleteData2()
                Exit Sub
            End If

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                With GmainCommonFunction
                    GmainsqlParameters = Nothing
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASeriesNum", Me.grd_1.GetCurrentRowCellValue("SeriesNum"))                       ' ������ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt", Me.dtpTaxAccPublishDt.TextValue)           ' ��������
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillGroupNum", Replace(Me.dtpTaxAccPublishDt.TextValue, "-", "").Substring(0, 6))              ' å��ȣ-��
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillGroupSeriesNum", Replace(Me.dtpTaxAccPublishDt.TextValue, "-", "").Substring(6, 2))        ' å��ȣ-ȣ 
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillSeriesNum", 0)

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASalesDiviCd", Me.cboSalesDiviCd.TextValue)                          ' ��������
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASalesCd", Me.popSalesCd.TextValue)                     ' �Ѱ��ޱݾ�
                    ' 
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWriteDt", Me.dtpTaxAccPublishDt.TextValue)                          ' ��������
                    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASupplyTotalAmt", Me.TxtTotalSupAmt.TextValue)                ' �Ѱ��ޱݾ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusinessNum", Me.txtConsumerBusinessNum.TextValue)   ' ��Ϲ�ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerCorpNm", Me.txtConsumerCorpNm.TextValue)             ' ��ȣ(���θ�)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerPresidentNm", Me.txtConsumerPresidentNm.TextValue)   ' ����
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerPostNum", Me.popConsumerPostNum.TextValue)                ' �����ȣ
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerAddr", Me.txtConsumerAddr.TextValue)                             ' �ּ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerAddr2", Me.txtConsumerAddr2.TextValue)                            ' ���ּ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusiStatusCd", Me.txtConsumerBusiStatusCd.TextValue) ' �����ڵ�
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusiTypeCd", Me.txtConsumerBusiTypeCd.TextValue)      ' �����ڵ�
                    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABlankNum", 0)                     ' ����
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", "")

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_CUD", True, False, GmainsqlParameters)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Me.RequestData()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If


                '    GmainsqlParameters = Nothing
                '    With GmainCommonFunction
                '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
                '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_CUD", True, False, GmainsqlParameters)
                '        .SetAllBusinessUiInitialValue(Me)
                '        '' .SaveDataMessage(Me)
                '    End With
                '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
                '        MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Else
                '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    End If
            End If   '' Result end

        End Sub

        ''' <summary>
        ''' �Լ��� : DeleteData_2
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData2()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_2_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Me.RequestData_2()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If   '' Result end

        End Sub

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

            'Dim AsqlParameters() As SqlParameter = Nothing

            'With GmainCommonFunction
            '    .SetSqlParameter(AsqlParameters, "@AcodeDivisionHangulName", Me.txtBranchNum.TextValue)
            '    .SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            '    'Dim AAAA As String = ""
            '    'AAAA = "{@��ǥID}=" &"'" & GmainBusinessFunction.GetValue("�α���ID") & "'"

            '    Dim AformulaParameters() As SqlParameter = Nothing

            '    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "��ǥID", "'" & GmainBusinessFunction.GetValue("�α���ID") & "'")
            '    .SetSqlParameter(AformulaParameters, "�ۼ���", "'" & GmainBusinessFunction.GetValue("�α��θ�") & "'")

            '    ' ���뺯�������ǰ������ÿ��߻��ɼ��ֵ��������Ѵ�.
            '    .SetExportCrystalDataParameter("PNI205.rpt", "PNI205_R", "", AsqlParameters, AformulaParameters)
            'End With

        End Sub

    End Class

End Namespace
