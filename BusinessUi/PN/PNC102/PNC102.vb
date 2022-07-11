' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : ���Ȯ���������ڵ��
' form���� : ���Ȯ���������ڵ�� �Ѵ�
' �ۼ��� : ������
' �ۼ��� : 2008-09-19
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

    Public Class PNC102
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"

        Public Sub Initialize()
            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;0;;1;" & "o;n;y;12;"
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;0;;1;" & "o;n;y;13;"
            gridAttributes = gridAttributes & "|��������;ContactDt;70;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|����;Orders;32;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;122;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;ContactPaperNum;34;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��ȭ1;PhoneNum1;87;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ���;MobileNum;88;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;58;;4;" & "o;n;n;10;�����ȣ;OldAddr1"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;308;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;365;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;87;c;4;" & "o;n;n;7;�����ڵ�;DeliveryBranchNm"
            gridAttributes = gridAttributes & "|����������;DeliveryBranchNm;74;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�������޻���;Note2;87;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|������������;FixedEdDt;87;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|�����ڵ�;SubscribeCd;105;;1;" & "o;n;n;10;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------

            Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            Me.dtpReceiptDtTo.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")

            Me.NewData()

        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNC102_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub


        ''' <summary>
        ''' �Լ��� : PNC102_Enter 
        ''' ��  �� : ȭ�� ��ȯ(���Ȯ�� ���� ���� ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC102_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")

            If ShareParameters.Length = 8 Then

                If ShareParameters(0) = Me.Name Then
                    SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5), ShareParameters(6), ShareParameters(7))
                    GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
                End If

            ElseIf ShareParameters.Length = 7 Then
                If ShareParameters(0) = Me.Name Then
                    SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5), ShareParameters(6))
                    GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
                End If

            ElseIf ShareParameters.Length = 6 Then

                If ShareParameters(0) = Me.Name Then
                    SetRequest2(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5))
                    GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
                End If

            End If
        End Sub

        ''' <summary>
        ''' �Լ��� : Request
        ''' ��  �� : �ٸ� ȭ�鿡�� �ڵ� �� �޾Ƽ� �ش� ������ ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, _
                              ByVal strCompanyCd As String, ByVal strCompanyNm As String, _
                              ByVal strReceiptCd As String, ByVal strSubscriberNm As String, _
                              Optional ByVal strProcGb As String = "1")

            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '��������
            Me.dtpReceiptDtTo.TextValue = strToDt      '��������
            Me.popCompanyCd_R.TextValue = strCompanyCd  'Ȯ��ó��ȣ
            Me.popCompanyCd_R.NameText = strCompanyNm  'Ȯ��ó��
            Me.txtReceiptCd_2_R.TextValue = strReceiptCd  '�������ڹ�ȣ
            Me.txtSubscriberNm_2_R.TextValue = strSubscriberNm  '�������ڸ�

            If strProcGb = "1" Then   'ó�� ���� 1:���� ��ȸ
                GrecordProcessMode = "2"   ' ��ȸ ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestData", CallType.Method)
            ElseIf strProcGb = "2" Then   'ó�� ���� 2:�̻� ���� �ű�, 3:��Ȯ�� �ű�
                GrecordProcessMode = "1"   ' �ű� ���� ����
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeRemove", CallType.Method)
            End If

        End Sub

        ''' <summary>
        ''' �Լ��� : Request
        ''' ��  �� : �ٸ� ȭ�鿡�� �ڵ� �� �޾Ƽ� �ش� ������ ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetRequest2(ByVal strFromDt As String, ByVal strToDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strReceiptCd As String)

            Me.dtpReceiptDtFrom.TextValue = strFromDt  '��������
            Me.dtpReceiptDtTo.TextValue = strToDt      '��������


            Me.txtReceiptCd_2_R.TextValue = strCompanyCd  '�������ڹ�ȣ
            Me.txtSubscriberNm_2_R.TextValue = strCompanyNm  '�������ڸ�

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

#End Region


        Private Sub btnPRB002_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRB002.Click

            '����� ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '�������ڹ�ȣ
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC105;" & strCode)
            Me.ShowUiControl("PNC105", strCode)

        End Sub

        '' ���� ���� �����
        Private Sub cboCollectionTypeCd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCollectionTypeCd.SelectedValueChanged
            SetDateSetting()
        End Sub

        '' ���� �Ⱓ ���ý� ���� ������ ���� ������ �߰� ����
        Private Sub numServiceTerm_TextChanged() Handles numServiceTerm.TextChanged
            ' ���ݳ��/���񽺱Ⱓ ����
            SettingServiceTerms()
        End Sub

        ''�������ں���� 1������ 1�� ����
        'Private Sub dtpFixedStDt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFixedStDt.Leave
        '    If dtpFixedStDt.TextValue <> Nothing Then

        '        Dim dt As DateTime = dtpFixedStDt.Value.ToString("yyyy-MM-dd") ' ��������
        '        dtpFixedEdDt.TextValue = dt.AddYears(1).AddDays(-1).ToString("yyyy-MM-dd") ' �Ϸ�����
        '        ' ���ݳ��/���񽺱Ⱓ ����
        '        SettingServiceTerms()
        '    End If
        'End Sub

        '���� �ڵ� ����
        Private Sub SetDateSetting()
            If Me.cboCollectionTypeCd.TextValue = "2" Then
                ' �������� 
                Dim dt As DateTime = dtpContactDt.Value.ToString("yyyy-MM-dd")  ' ���� ����
                dtpFixedStDt.TextValue = dt.AddDays(1).ToString("yyyy-MM-dd")   '��������
                dtpFixedEdDt.TextValue = dt.AddYears(1).ToString("yyyy-MM-dd") ' �Ϸ�����
                ' ���ݳ��/���񽺱Ⱓ ����
                SettingServiceTerms()
            End If
        End Sub

        Private Sub SettingServiceTerms()
            ''���ݳ�� ����
            If numServiceTerm.Text = "" Then
                numServiceTerm.Text = 0
            End If
            If dtpFixedStDt.TextValue <> Nothing Then
                dtpCollectionYYYYMM.TextValue = dtpFixedStDt.Value.AddMonths(numServiceTerm.Text).ToString("yyyy-MM-dd")
            End If

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

        Private Sub dtpFixedStDt_Dtp_TextChanged() Handles dtpFixedStDt.Dtp_TextChanged
            If dtpFixedStDt.TextValue <> Nothing And RequestMode = 0 Then
                Dim dt As DateTime = dtpFixedStDt.Value.ToString("yyyy-MM-dd") ' ��������
                dtpFixedEdDt.TextValue = dt.AddYears(1).AddDays(-1).ToString("yyyy-MM-dd") ' �Ϸ�����
                ' ���ݳ��/���񽺱Ⱓ ����
                SettingServiceTerms()
            End If
        End Sub


    End Class

End Namespace
