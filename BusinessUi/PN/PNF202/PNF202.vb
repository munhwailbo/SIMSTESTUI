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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNF202
        Inherits CommonControls.UiControl

        Private Sub PNF202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|����;TreePath;70;;1;" & "io;n;n;5;                      "
            gridAttributes = gridAttributes & "|Ȯ����;CalYearMonths;63;yyyy-MM;4;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|����;WeekNumber;37;;4;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����;EmployeeNameHangul;50;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���Ȯ�ο���;RegYesOrNo;83;;1;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|�������ο���;ApplyYesOrNo;0;;1;" & "o;n;y;8;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchNum;69;;4;" & "io;n;n;12;���� ��;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;58;;1;" & "o;n;n;12;"
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;0;;4;" & "o;n;y;10;���������ڵ�;"
            gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�繫��;ExpPNum_Office;50;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��;ExpPNum_Shop;37;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|����;ExpPNum_House;37;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|����Ʈ;ExpPNum_Apt;50;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|Ȯ��μ�;ExpandPapNum;62;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandAmount;70;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��ü�ݾ�;DeductAmt;69;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;70;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;91;;1;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;113;;1;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;62;;1;" & "o;n;n;8;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BankCd;�����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

            'Me.popEmployeeNumber.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            'Me.popEmployeeNumber.Enabled = GmainBusinessFunction.GetValue("�α��� ID") = "999999"

            '����� ����
            popEmployeeNumber.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popEmployeeNumber.Enabled = False
                popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("�α��� ID"), _
                                                  GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

        End Sub
#End Region


        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            ''Dim CurruntRow As Long

            With grd_1
                If .Rows > 1 Then
                    ''CurruntRow = .GetCurrentRowCellValue("")

                    '��ü �ݾ� ó�� (Ȯ��� - ��ü�ݾ� = ��ü�ݾ�)
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("ExpandAmount")).ToString.Replace(",", "")) _
                                     - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
                End If
            End With

        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.Row)
        End Sub

    End Class

End Namespace
