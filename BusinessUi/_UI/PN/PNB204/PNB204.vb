'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���μ��� ��� ���� ���
' form ���� : ���μ��� ��� ���ظ� ��� �Ѵ�.
' �ۼ��� : Ȳ����
' �ۼ��� : 2007-07-11
'////////////////////////////////////////////////////////////////////////////////////////////////////

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

    Public Class PNB204
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

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

            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;120;;c;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|�μ� ��;DeptNm;120;;l;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;100;;l;" & "io;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|������;BranchNm;100;;l;" & "o;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|�������;ContractDt;100;;l;" & "o;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|���ϰῩ��;ContractYN;100;;c;" & "io;n;n;1;"       '(420)

            gridAttributes = gridAttributes & "|����������;ContractStDt;100;;l;" & "o;n;y;8;"       '(50)
            gridAttributes = gridAttributes & "|�����������;ContractEdDt;100;;l;" & "o;n;y;8;"       '(60)

            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;100;;l;" & "o;n;n;10;;"       '(80)
            gridAttributes = gridAttributes & "|�������;BranchChiefNm;100;;l;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|�ֹι�ȣ;BranchSocialNum;100;;l;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;100;;l;" & "o;n;n;7;"       '(100)
            gridAttributes = gridAttributes & "|����ڸ�;ChargeEmpNm;10;;c;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "| ;dummy;90;;c;" & "o;n;n;1;"       '(420)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            '''' ==============================================================================================
            gridAttributes = "a;r;y"
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;y;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;120;;c;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|�μ� ��;DeptNm;120;;l;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;100;;l;" & "io;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|������;BranchNm;100;;l;" & "o;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|������;CloseDate;100;;l;" & "o;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;100;;l;" & "o;n;n;10;;"       '(80)
            gridAttributes = gridAttributes & "|�������;BranchChiefNm;100;;l;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|�ֹι�ȣ;BranchSocialNum;100;;l;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;100;;l;" & "o;n;n;7;"       '(100)
            gridAttributes = gridAttributes & "|����ڸ�;ChargeEmpNm;10;;c;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "| ;dummy;90;;c;" & "o;n;n;1;"       '(420)

            'grid_2 code combo    
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub
        ''' <summary>
        ''' �Լ��� : PNB204_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNB204_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If

        End Sub
        ''' <summary>
        ''' �Լ��� : grd_1_DoubleClick 
        ''' ��  �� : ȭ�� Jump!
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            ''��ǥ ȭ������ ��ǥ ��ȣ�� �Ѱܼ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            'If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            'Dim BusinessPlaceCode As String '����� �ڵ�
            'Dim BranchCode As String '���� �ڵ�
            'Dim SlipDate As String '�ŷ� ����
            'Dim SlipNumber As String '��ǥ ��ȣ

            'BusinessPlaceCode = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("BusinessPlaceCode")) '����� �ڵ�
            'BranchCode = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("BranchCode")) ''���� �ڵ�                                  
            'SlipDate = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SlipDate")) '�ŷ� ����                                  
            'SlipNumber = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SlipNumber")) '��ǥ ��ȣ                                  

            'GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "ACCA01;" & BusinessPlaceCode & ";" & BranchCode & ";" & SlipDate & ";" & SlipNumber)
            'Me.ShowUiControl("ACCA01", BusinessPlaceCode & ";" & BranchCode & ";" & SlipDate & ";" & SlipNumber)
        End Sub
        ''' <summary>
        ''' �Լ��� : btnApprovalAll_Click 
        ''' ��  �� : �ϰ� ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                If blnApprovalAll = False Then
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                .SetCellCheck(inti, .get_ColIndex("ContractYN"), CheckEnum.Checked)
                                .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
                            Next inti
                        End If
                    End With
                    blnApprovalAll = True
                Else
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("ContractYN")) = CheckEnum.Checked Then
                                    .SetCellCheck(inti, .get_ColIndex("ContractYN"), CheckEnum.Unchecked)
                                    .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = False
                End If
                btnApprovalAll.Text = IIf(blnApprovalAll, "���� ���", "�ϰ� ����")
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class

End Namespace

