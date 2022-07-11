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

    Partial Class PNJ201

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
                If Me.txtABarCode.TextValue = "" Then
                    .SetSqlParameter(GmainsqlParameters, "@ADetailOrders", Me.txtABarCode.TextValue)
                Else
                    If Me.txtABarCode.TextValue.Length = 16 Then
                        Me.popCouponCorpCd.TextValue = Me.txtABarCode.TextValue.Substring(0, 4)
                        Me.dtpPublishYearMonthFrom.TextValue = Me.txtABarCode.TextValue.Substring(4, 6) + "01"
                        Me.dtpPublishYearMonthTo.TextValue = Me.txtABarCode.TextValue.Substring(4, 6) + "01"
                        .SetSqlParameter(GmainsqlParameters, "@ADetailOrders", Me.txtABarCode.TextValue.Substring(10, 6))
                    Else
                        MsgBox("�Է��� �����ǹ�ȣ�� �� ���Ǿ����ϴ�.")
                        GmainExecuteDbCommand.GerrorNumber = 1
                        Return
                    End If

                End If
                If chkRedeemDt.Checked = True Then
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt_FR", IIf(dtpRedeemDt_FR.TextValue.ToString.Length < 1, "", Me.dtpRedeemDt_FR.TextValue))
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt_To", IIf(dtpRedeemDt_To.TextValue.ToString.Length < 1, "", Me.dtpRedeemDt_To.TextValue))
                Else
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt_FR", "")
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt_To", "")
                End If

                .SetSqlParameter(GmainsqlParameters, "@APublishYearMonthFrom", Me.dtpPublishYearMonthFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@APublishYearMonthTo", Me.dtpPublishYearMonthTo.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.popCouponCorpCd.TextValue)



                'If IsNothing(Me.txtDetailOrders.TextValue) = True Then
                '    Me.txtDetailOrders.TextValue = ""
                'End If

                '.SetSqlParameter(GmainsqlParameters, "@ADetailOrders", Me.txtDetailOrders.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ201_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

            End With


        End Sub


        Public Sub RequestData_BarcodeChk(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@APublishBarCode", Me.txtBarCode.TextValue)

                'If IsNothing(Me.txtDetailOrders.TextValue) = True Then
                '    Me.txtDetailOrders.TextValue = ""  
                'End If

                '.SetSqlParameter(GmainsqlParameters, "@ADetailOrders", Me.txtDetailOrders.TextValue)


                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ201_3_R", False, True, GmainsqlParameters)
                If IsNothing(reciveDataSet) Then

                    'gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
                    'gridAttributes = gridAttributes & "|������;PublishYearMonth;100;####-##;c;" & "o;n;n;4;"
                    'gridAttributes = gridAttributes & "|ȸ��������ȣ;RedeemBranchNum;100;;l;" & "io;n;n;9;�����ڵ�;BranchNm"
                    'gridAttributes = gridAttributes & "|ȸ��������;BranchNm;120;;l;" & "o;n;n;9;"
                    'gridAttributes = gridAttributes & "|�����ǹ����ڵ�;CouponPublicCd_2;100;;l;" & "io;n;y;8;"
                    'gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;80;;l;" & "o;n;n;8;"
                    'gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;100;;l;" & "o;n;n;8;"
                    'gridAttributes = gridAttributes & "|����󼼼���;DetailOrders;100;;r;" & "io;n;n;4;"
                    'gridAttributes = gridAttributes & "|��������;PublishDt;100;####-##-##;c;" & "o;n;n;4;"
                    'gridAttributes = gridAttributes & "|ȸ������;RedeemDt;100;####-##-##;l;" & "io;n;n;8;"
                    'gridAttributes = gridAttributes & "|����;Orders;40;;r;" & "io;n;y;4;"
                    'gridAttributes = gridAttributes & "|���ڵ�;PublishBarCode;180;;l;" & "io;n;y;30;"
                    'gridAttributes = gridAttributes & "|���ڸ������;ReaderListYN;80;;c;" & "io;n;n;1;"
                    'gridAttributes = gridAttributes & "|���޳��;PayYYYYMM;100;;l;" & "io;n;n;6;"
                    'gridAttributes = gridAttributes & "|ȸ������;RedeemYN;80;;c;" & "io;n;n;1;"
                    'gridAttributes = gridAttributes & "|�����ǹ����ڵ�;CouponSeriesNum;100;;l;" & "io;n;y;10;"
                    'gridAttributes = gridAttributes & "|;Dumi;100;;l;" & "o;n;n;9;"
                    'gridAttributes = gridAttributes & "|�űԱ���;IsExist;100;;l;" & "o;n;y;9;"

                ElseIf reciveDataSet.Tables.Count > 0 And reciveDataSet.Tables(0).Rows.Count > 0 Then
                    If reciveDataSet.Tables(0).Rows(0).Item("RedeemYN") = 0 Then

                        If grd_1.Rows > 1 Then
                            For i As Integer = 1 To grd_1.Rows - 1
                                If grd_1.GetData(i, "PublishBarCode").ToString().Trim() = reciveDataSet.Tables(0).Rows(0).Item("PublishBarCode") Then
                                    ' ȸ���� üũ�Ѵ�.
                                    grd_1.SetCellCheck(i, grd_1.get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                                    'grd_1.SetData(i, "RedeemBranchNum", Me.popBranchCd.CodeText)
                                    'grd_1.SetData(i, "BranchNm", Me.popBranchCd.NameText)
                                    'grd_1.SetData(i, "RedeemDt", Me.dtpRedeemDt.Text)
                                    'grd_1.SetData(1, "PayYYYYMM", Me.dtpPayYYYYMM.TextValue)
                                    'grd_1.SetCellCheck(i, grd_1.get_ColIndex("RedeemYN"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                                    'grd_1.SetData(i, "RedeemUnitAmt", Me.numRedeemUnitCost.Text)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("RedeemBranchNum"), Me.popBranchCd.TextValue)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("BranchNm"), Me.popBranchCd.NameText)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("RedeemDt"), Me.dtpRedeemDt.Text)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("PayYYYYMM"), Me.dtpPayYYYYMM.Text)
                                    Me.grd_1.SetCellCheck(i, Me.grd_1.get_ColIndex("RedeemYN"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("RedeemUnitAmt"), Me.numRedeemUnitCost.Text)
                                    Exit Sub
                                End If
                            Next
                            ' ���߰��ϰ� ���� �ִ´�.
                            grd_1.AddRow()
                            regReciveCoupon(reciveDataSet.Tables(0))
                        Else
                            grd_1.AddRow()
                            regReciveCoupon(reciveDataSet.Tables(0))

                        End If
                    Else
                        MsgBox("�̹� ��ϵ� ��ȣ�Դϴ�.", MsgBoxStyle.Information)
                    End If

                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    'If AprocessMessage = True Then .RequestDataMessage(Me)
                Else
                    MsgBox("����� ��ȣ�� �ƴմϴ�.", MsgBoxStyle.Information)
                End If

            End With


        End Sub

        ''' <summary>
        ''' ���Ȯ���� ȸ������Ѵ�.
        ''' </summary>
        ''' <param name="DT"></param>
        ''' <remarks></remarks>
        Private Sub regReciveCoupon(ByVal DT As DataTable)
            grd_1.SetData(grd_1.Rows - 1, "PublishYearMonth", DT.Rows(0).Item("PublishYearMonth").ToString().Substring(0, 4) + "-" + DT.Rows(0).Item("PublishYearMonth").ToString().Substring(4, 2))
            grd_1.SetData(grd_1.Rows - 1, "RedeemBranchNum", Me.popBranchCd.CodeText)
            grd_1.SetData(grd_1.Rows - 1, "BranchNm", Me.popBranchCd.NameText)
            grd_1.SetData(grd_1.Rows - 1, "CouponPublicCd_2", DT.Rows(0).Item("CouponPublicCd_2"))
            grd_1.SetData(grd_1.Rows - 1, "CouponCorpCd", DT.Rows(0).Item("CouponCorpCd"))
            grd_1.SetData(grd_1.Rows - 1, "CouponCorpNm", DT.Rows(0).Item("CouponCorpNm"))
            grd_1.SetData(grd_1.Rows - 1, "DetailOrders", DT.Rows(0).Item("DetailOrders"))
            grd_1.SetData(grd_1.Rows - 1, "PublishDt", DT.Rows(0).Item("PublishDt").ToString().Substring(0, 4) + "-" + DT.Rows(0).Item("PublishDt").ToString().Substring(4, 2) + "-" + DT.Rows(0).Item("PublishDt").ToString().Substring(6, 2))
            grd_1.SetData(grd_1.Rows - 1, "RedeemDt", Me.dtpRedeemDt.Text)
            grd_1.SetData(grd_1.Rows - 1, "Orders", DT.Rows(0).Item("Orders"))
            grd_1.SetData(grd_1.Rows - 1, "PublishBarCode", DT.Rows(0).Item("PublishBarCode"))
            grd_1.SetCellCheck(grd_1.Rows - 1, grd_1.get_ColIndex("ReaderListYN"), VBN.IIf(DT.Rows(0).Item("ReaderListYN"), C1.Win.C1FlexGrid.CheckEnum.Checked, C1.Win.C1FlexGrid.CheckEnum.Unchecked))
            grd_1.SetData(grd_1.Rows - 1, "PayYYYYMM", Me.dtpPayYYYYMM.Text)
            grd_1.SetCellCheck(grd_1.Rows - 1, grd_1.get_ColIndex("RedeemYN"), C1.Win.C1FlexGrid.CheckEnum.Checked)

            If DT.Rows(0).Item("RedeemUnitAmt") = 0 Then
                grd_1.SetData(grd_1.Rows - 1, "RedeemUnitAmt", Me.numRedeemUnitCost.Text)
            Else
                grd_1.SetData(grd_1.Rows - 1, "RedeemUnitAmt", DT.Rows(0).Item("RedeemUnitAmt"))
            End If

            grd_1.SetData(grd_1.Rows - 1, "UnitCost", DT.Rows(0).Item("unitcost"))

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
            If Me.ValidationCheck = False Then
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Sub
            End If

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ201_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ201_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

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

                Dim strRedeemDt As String = ""
                For inti As Integer = 0 To Me.grd_1.Rows - 1
                    If Me.grd_1.GetCellCheck(inti, Me.grd_1.get_ColIndex("����")) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                        If Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("RedeemBranchNum")) = "" Then
                            MessageBox.Show("ȸ��������ȣ�� �ݵ�� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If

                        strRedeemDt = Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("RedeemDt"))
                        If IsDate(strRedeemDt) = False Then
                            MessageBox.Show("ȸ�����ڸ� Ȯ���� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If

                        'If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("CirculationNum"))) = False Then
                        '    MessageBox.Show("����μ��� Ȯ���� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Function
                        'End If
                        'If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("UnitCost"))) = False Then
                        '    MessageBox.Show("�ܰ��� Ȯ���� �ٽ� ����� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Function
                        'End If
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
         '       .SetExportCrystalDataParameter("PNJ201.rpt", "PNJ201_R", "", AsqlParameters, AformulaParameters)
         '   End With

        End Sub

    End Class

End Namespace
