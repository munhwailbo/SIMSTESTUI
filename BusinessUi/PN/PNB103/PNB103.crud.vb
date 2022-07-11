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

    Partial Class PNB103

        '====================================================================================================
        Public Sub NewData()

            grd_1.NewData()

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpPayYYYYMM.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB103_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

            Call SetSubTotal()
        End Sub

        '�׸��� �հ��� �߰�
        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Tree.Column = .get_ColIndex("ChargeEmpNm")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

                    ' '' =============================================================================
                    '' '' '' �׸��� �� �Ұ��� �߰�
                    ' '' =============================================================================
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("RentAmt"), "{0} �Ұ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("RentVat"), "{0} �Ұ�")
                    ' '' =============================================================================
                    '' '' '' �׸��� �հ��� �߰�
                    ' '' =============================================================================

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("RentAmt"), "�հ�")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("RentVat"), "�հ�")
                    '.set_TextMatrix(.FixedRows, .get_ColIndex("ChargeEmpNm"), "��   ��")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        '====================================================================================================
        Public Sub SaveData()

            If Validation() = True Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordProcessMode", "1")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APayYYYYMM", Me.dtpPayYYYYMM.TextValue)     '������ ���޳��
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APaymentDt", Me.dtpPaymentDt.TextValue)     '������ ��������
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                ''''''' GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB103_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                    RequestData()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            Else
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                ''GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordProcessMode", "3")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APayYYYYMM", Me.dtpPayYYYYMM.TextValue)     '������ ���޳��
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APaymentDt", Me.dtpPaymentDt.TextValue)     '������ ��������
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                ''''' GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB103_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.DeleteDataMessage(Me)
                    RequestData()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            End If

        End Sub

        Public Function Validation() As Boolean

            'validation = False

            'With Me.grd_1
            '    For inti As Integer = .FixedRows To .Rows - 1

            '        If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
            '            If .get_TextMatrix(inti, .get_ColIndex("ProjectID")).Length <> 4 Then
            '                MessageBox.Show("������Ʈ ID�� �ݵ�� �Է��� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If
            '            If .get_TextMatrix(inti, .get_ColIndex("SystemID")).Length <> 5 Then
            '                MessageBox.Show("�ý��� ID�� �ݵ�� �Է��� �ּ���  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If

            '        End If
            '    Next inti
            'End With

            Validation = True

        End Function
    End Class

End Namespace
