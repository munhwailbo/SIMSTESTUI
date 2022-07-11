' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : 
' form���� :
' �ۼ��� : 
' �ۼ��� : 
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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
Imports System.Collections.Generic

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC201
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"

        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ���ϰ� : 
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNC201_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        ''''''' <summary>
        ''''''' �Լ��� : btnRowInsert_Click 
        ''''''' ��  �� : �� �߰�
        ''''''' �ۼ��� : ������
        ''''''' �ۼ��� : 2007-01-02
        ''''''' ������ : 
        ''''''' ������ :
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>
        '' ''Private Sub btnRowInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    Dim RowNumber As Integer = 0

        '' ''    With Me.grd_2
        '' ''        .AddRow()
        '' ''        .set_TextMatrix(.Rows - 1, 0, "�ű�")
        '' ''        .set_TextMatrix(.Rows - 1, .get_ColIndex("SubscribeCd"), "0") '�׸� ��ȣ 
        '' ''        .set_TextMatrix(.Rows - 1, .get_ColIndex("ReaderCd"), "") '�׸� ��ȣ 
        '' ''        .set_TextMatrix(.Rows - 1, .get_ColIndex("Orders"), 0) '�׸� ��ȣ 
        '' ''    End With
        '' ''End Sub
        ''''''' <summary>
        ''''''' �Լ��� : btnRowSave_Click 
        ''''''' ��  �� : �� ����
        ''''''' �ۼ��� : ������
        ''''''' �ۼ��� : 2007-01-02
        ''''''' ������ : 
        ''''''' ������ :
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>
        '' ''Private Sub btnRowSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '' ''End Sub
        ''''''' <summary>
        ''''''' �Լ��� : btnRowDelete_Click 
        ''''''' ��  �� : �� ����
        ''''''' �ۼ��� : ������
        ''''''' �ۼ��� : 2007-01-02
        ''''''' ������ : 
        ''''''' ������ :
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>
        '' ''Private Sub btnRowDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    With Me.grd_2
        '' ''        If .Rows > .FixedRows Then
        '' ''            If .get_TextMatrix(.RowSel, 0) = "�ű�" Then
        '' ''                .RemoveItem(.RowSel)
        '' ''            ElseIf IsNumeric(.get_TextMatrix(.RowSel, 0)) = True Then
        '' ''                .set_TextMatrix(.RowSel, 0, "����")
        '' ''                .SetCellCheck(.RowSel, .get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
        '' ''            ElseIf .get_TextMatrix(.RowSel, 0) = "����" = True Then
        '' ''                .set_TextMatrix(.RowSel, 0, "����")
        '' ''                .SetCellCheck(.RowSel, .get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
        '' ''            End If
        '' ''        End If
        '' ''    End With
        '' ''End Sub
        ''''''' <summary>
        ''''''' �Լ��� : btnCopy_Click 
        ''''''' ��  �� : �� ����
        ''''''' �ۼ��� : ������
        ''''''' �ۼ��� : 2007-01-02
        ''''''' ������ : 
        ''''''' ������ :
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>
        '' ''Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    Dim Row As Integer = 0                '�� INDEX
        '' ''    Dim RowNumber As Integer = 0

        '' ''    With Me.grd_2
        '' ''        If .Rows = .FixedRows Then Exit Sub
        '' ''        Row = .RowSel
        '' ''        .AddRow()
        '' ''        .set_TextMatrix(.Rows - 1, 0, "�ű�")
        '' ''        .SetCellCheck(.Rows - 1, .get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalSeq"), "0") '�׸� ��ȣ 
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("AccountCode"), .get_TextMatrix(Row, .get_ColIndex("AccountCode")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("AccountCodeName"), .get_TextMatrix(Row, .get_ColIndex("AccountCodeName")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalQuantity"), .get_TextMatrix(Row, .get_ColIndex("ProposalQuantity")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalAmount"), .get_TextMatrix(Row, .get_ColIndex("ProposalAmount")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ValidBeginDate"), .get_TextMatrix(Row, .get_ColIndex("ValidBeginDate")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ValidEndDate"), .get_TextMatrix(Row, .get_ColIndex("ValidEndDate")))
        '' ''    End With

        '' ''    '2006-07-26 ������ �߰�
        '' ''    Me.grd_2.Select(Me.grd_2.Rows - 1, Me.grd_2.get_ColIndex("SubscribeCd"))
        '' ''End Sub

#End Region


        ''' <summary>
        ''' �Լ��� : PNC201_Enter 
        ''' ��  �� : ȭ�� ��ȯ(���ڹ�ȣ ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC201_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters.Length = 6 Then
                If ShareParameters(0) = Me.Name Then
                    SetSubscribeCd(ShareParameters(3), ShareParameters(4))
                    GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
                End If
            Else
                If ShareParameters(0) = Me.Name Then
                    SetSubscribeCd(ShareParameters(1), ShareParameters(2))
                    GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
                End If
            End If
        End Sub

        ''' <summary>
        ''' �Լ��� : SetBranchCd
        ''' ��  �� : �ٸ� ȭ�鿡�� ���� �ڵ� �� �޾Ƽ� �ش� ���������� ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetSubscribeCd(ByVal strSubscribeCd As String, ByVal strSubscribeNm As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.popSubscribeCd_R.TextValue = strSubscribeCd  '�����ڵ� 
            Me.popSubscribeCd_R.NameText = strSubscribeNm  '���ڸ�

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub btnJumpRemoval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumpRemoval.Click

            '' ''MessageBox.Show(cboExpandDivCd.TextValue)

            If cboExpandDivCd.TextValue = "1" Then
                '' ''���Ȯ�� ���� ��� ȭ������ JUMP.
                If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
                Dim strCode As String '�������ڹ�ȣ
                strCode = Me.dtpContactDt.TextValue _
                          & ";" & Me.dtpContactDt.TextValue _
                          & ";" & "" _
                          & ";" & "" _
                          & ";" & Me.txtReceiptCd.TextValue _
                          & ";" & Me.txtSubscriberNm.TextValue _
                          & ";" & "2"    '' '' ó������ 2:�̻絶�ڽű��Է�
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC102;" & strCode)
                Me.ShowUiControl("PNC102", strCode)
            Else
                '' ''����Ȯ�� ���� ��� ȭ������ JUMP.
                If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
                Dim strCode As String '�������ڹ�ȣ
                strCode = Me.dtpContactDt.TextValue _
                          & ";" & Me.dtpContactDt.TextValue _
                          & ";" & Me.txtReceiptCd.TextValue _
                          & ";" & Me.txtSubscriberNm.TextValue _
                          & ";" & "2"    '' '' ó������ 2:�̻絶�ڽű��Է�
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC101;" & strCode)
                Me.ShowUiControl("PNC101", strCode)
            End If
        End Sub

        Private Sub btnJumpSat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumpSat.Click

            '' ��䰡�� ��� ������� ȭ������ JUMP.
            If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
            Dim strCode As String '�������ڹ�ȣ
            strCode = Me.dtpContactDt.TextValue _
                      & ";" & Me.dtpContactDt.TextValue _
                      & ";" & Me.txtReceiptCd.TextValue _
                      & ";" & Me.txtSubscriberNm.TextValue 
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC202;" & strCode)
            Me.ShowUiControl("PNC202", strCode)

        End Sub
        
        Private Sub btnExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpand.Click
            '����Ȯ�� ���� ��� ȭ������ JUMP.
            If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
            Dim strCode As String '�������ڹ�ȣ
            strCode = Me.dtpContactDt.TextValue _
                      & ";" & Me.dtpContactDt.TextValue _
                      & ";" & Me.txtReceiptCd.TextValue _
                      & ";" & Me.txtSubscriberNm.TextValue _
                      & ";" & "3"    '' '' ó������ 2:��Ȯ���Է�
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            ' '' 1. Ȯ�屸�� cboExpandDivCd
            ' '' 2. ������ȣ txtReceiptCd
            ' '' 3. ���ڹ�ȣ
            ' '' 4. ��ȭ��ȣ
            ' ''    --> Ȯ�屸���ڵ�|�ű�);where(Note1='��Ȯ'

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum1.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum2.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))

        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtMobileNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("�α���ID"))

        End Sub

     
        Private Sub cboCollectionTypeCd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCollectionTypeCd.SelectedIndexChanged

        End Sub

        Private Sub popDeliveryChnlCd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popDeliveryChnlCd.Load

        End Sub
    End Class

End Namespace
