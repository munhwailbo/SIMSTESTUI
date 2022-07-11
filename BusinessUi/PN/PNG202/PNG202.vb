'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �ڵ����
' form ���� : ��ȭ�Ϻ� �ڵ� ����
' �ۼ��� : ������
' �ۼ��� : 2008.09.01
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

    Public Class PNG202
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNG202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "�� �ʱ�ȭ"
        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
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
            gridAttributes = gridAttributes & "|����;TreePath;72;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������;YYYYMM;63;yyyy-MM;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|�����;ChargeEmpNum;1;;4;" & "o;n;n;9;�����;ChargeEmpNm"
            gridAttributes = gridAttributes & "|����;ChargeEmpNm;50;;1;" & "o;n;n;9;"
            gridAttributes = gridAttributes & "|��������;CalDt;0;yyyy-MM-dd;4;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;1;;4;" & "io;n;n;9;������ȣ;BranchNumNm"
            gridAttributes = gridAttributes & "|������;BranchNumNm;62;;1;" & "o;n;n;9;"
            gridAttributes = gridAttributes & "|�����׸��ڵ�;DivCd;87;;4;" & "io;n;y;10;�����׸� ��;DivNm"
            gridAttributes = gridAttributes & "|�����׸��;DivNm;99;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���Ȯ�ο���;RegYesOrNo;87;;1;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|�������ο���;ApplyYesOrNo;0;;1;" & "o;n;y;8;"
            gridAttributes = gridAttributes & "|�μ�;PaperNum;0;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|�ܰ�;UnitCost;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|������ݾ�;SupAmt;74;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��ü����;DeductDt;0;yyyy-MM-dd;4;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|��ü�ݾ�;DeductAmt;62;#,##0;7;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;62;#,##0;7;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;0;;1;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;0;;1;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;0;;1;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|���;Note;37;;1;" & "io;n;n;1000;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BankCd;�����ڵ�"
            'gridCodeNameList = gridCodeNameList & "/DivCd;�����񱸺��ڵ�"
            'gridCodeNameList = gridCodeNameList & "/BankCd;�����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            'Me.popChargeEmpNum_R.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            'Me.popChargeEmpNum_R.Enabled = GmainBusinessFunction.GetValue("�α��� ID") = "999999"

            '����� ����
            popChargeEmpNum_R.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popChargeEmpNum_R.Enabled = False
                popChargeEmpNum_R.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("�α��� ID"), _
                                                  GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

        End Sub
#End Region

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.Row)
        End Sub

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            'Dim CurruntRow As Long

            With grd_1
                If .Rows > 1 Then
                    'CurruntRow = .GetCurrentRowCellValue("")

                    '��ü �ݾ� ó�� (Ȯ��� - ��ü�ݾ� = ��ü�ݾ�)
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupAmt")).ToString.Replace(",", "")) _
                                     - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
                End If
            End With

        End Sub

    End Class

End Namespace
