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

    Public Class PNJ304
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNJ304_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|����;TreePath;37;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���޳��;CalYearMonths;63;yyyy-MM;4;" & "io;n;n;8;"

            gridAttributes = gridAttributes & "|�μ���;DeptNm;69;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����;EmployeeNameHangul;50;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchNum;76;;4;" & "o;n;n;12;���� ��;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;62;;1;" & "o;n;n;12;"
            gridAttributes = gridAttributes & "|����;Orders;0;;4;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;0;;4;" & "o;n;y;40;�Ҽӻ� ��;CouponCorpCdNm"
            gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpCdNm;62;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���Ȯ�ο���;RegYesOrNo;87;;1;" & "o;n;n;8;                  "
            gridAttributes = gridAttributes & "|�������ο���;ApplyYesOrNo;87;;1;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|�μ�;PaperNum;37;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�ܰ�;SubsUnitAmt;52;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|������ݾ�;SubscriptionAmt;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��ü����;DeductYN;62;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��ü����;DeductDt;85;yyyy-MM-dd;4;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|��ü�ݾ�;DeductAmt;62;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;70;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;95;;1;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;127;;1;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;62;;1;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|ó������;ProcDt;0;yyyy-MM-dd;4;" & "o;n;y;8;"
            gridAttributes = gridAttributes & "|���;Note;0;;1;" & "o;n;y;8;"
            gridAttributes = gridAttributes & "|;Ral;0;;1;" & "o;n;y;8;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BankCd;�����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

            '' ''Me.popEmployeeNumber.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            '' ''Me.popEmployeeNumber.Enabled = GmainBusinessFunction.GetValue("�α��� ID") = "999999"

        End Sub
#End Region


        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            ''Dim CurruntRow As Long

            With grd_1
                If .Rows > 1 Then
                    ''CurruntRow = .GetCurrentRowCellValue("")

                    '��ü �ݾ� ó�� (Ȯ��� - ��ü�ݾ� = ��ü�ݾ�)
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SubscriptionAmt")).ToString.Replace(",", "")) _
                                     - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
                End If
            End With

        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.row)
        End Sub

        Private Sub btnCreateSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSale.Click
            SaveData2()
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
                                If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
                                    .set_TextMatrix(inti, .get_ColIndex("DeductDt"), dtpDeductDt.Text)
                                    .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = True
                Else
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
                                    '' ''.SetCellCheck(inti, .get_ColIndex("ApprovalYN"), CheckEnum.Unchecked)
                                    .set_TextMatrix(inti, .get_ColIndex("DeductDt"), "")
                                    .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = False
                End If
                ''btnApprovalAll.Text = IIf(blnApprovalAll, "�ϰ� ���", "�ϰ� ����")
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

    End Class

End Namespace
