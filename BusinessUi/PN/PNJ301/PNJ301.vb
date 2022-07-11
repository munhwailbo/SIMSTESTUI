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

    Public Class PNJ301
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNJ301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|û�����;YYYYMM;60;;l;" & "io;y;n;6;"
            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;1;;c;" & "io;n;y;40;"
            gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;120;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|ȸ�����;PayYYYYMM;1;####-##;l;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|ȸ���μ�;RedeemPaperNum;80;#,##0;c;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|��бݾ�;PlanDmdAmount;110;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��û����;PreDmdAmount;90;#,##0;r;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|û��������;NoDmdAmount;90;#,##0;r;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|û���μ�ȸ��;DemandCollectCirculation;90;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|û����;ProcDmdAmount;90;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|ó������;ProcDt;90;;c;" & "io;y;n;15;"

            ' ''gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;100;#,##0;r;" & "io;n;n;15;"
            ' ''gridAttributes = gridAttributes & "|�����ݾ�;DeductAmt;100;#,##0;r;" & "io;n;n;15;"
            ''gridAttributes = gridAttributes & "|�ű�;NewGubn;40;;l;" & "o;n;y;6;"
            gridAttributes = gridAttributes & "| ;Dumi;50;;l;" & "o;n;n;6;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            ' '' '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ' '' '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            '' '' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            '' '' ''gridAttributes = gridAttributes & "|������;YYYYMM;60;;l;" & "io;y;n;6;"
            '' '' ''gridAttributes = gridAttributes & "|������;PayYYYYMM;60;####-##;l;" & "io;n;n;6;"
            '' '' ''gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;l;" & "io;y;n;9;�����ڵ�;BranchNm"
            '' '' ''gridAttributes = gridAttributes & "|������;BranchNm;100;;l;" & "o;n;n;9;"
            '' '' ''gridAttributes = gridAttributes & "|ȸ���μ���;RedeemPaperNum;80;#,##0;r;" & "io;n;n;4;"
            '' '' ''gridAttributes = gridAttributes & "|�������Ѿ�;PayTotAmt;100;#,##0;r;" & "io;n;n;15;"
            '' '' ''gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;100;#,##0;r;" & "io;n;n;15;"
            '' '' ''gridAttributes = gridAttributes & "|�����ݾ�;DeductAmt;100;#,##0;r;" & "io;n;n;15;"
            '' '' ''gridAttributes = gridAttributes & "|�ű�;NewGubn;40;;l;" & "o;n;y;6;"
            '' '' ''gridAttributes = gridAttributes & "|;Dumi;50;;l;" & "o;n;n;6;"
            ' '' '' ''grid_1 code combo    
            '' '' ''Dim gridCodeNameList As String = ""
            '' '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                If blnApprovalAll = False Then
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
                                    .set_TextMatrix(inti, .get_ColIndex("ProcDt"), dtpProcDT.Text)
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
                                    .set_TextMatrix(inti, .get_ColIndex("ProcDt"), "")
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
