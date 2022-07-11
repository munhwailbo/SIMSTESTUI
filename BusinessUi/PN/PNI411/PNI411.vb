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

    Public Class PNI411
        Inherits CommonControls.UiControl

        Private Sub PNI411_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub


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
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;70;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;70;;c;" & "o;n;n;40;Ȯ��ó ��;CompanyNm;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;70;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|û���Ⱓ;CalYearMonths;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ��ڵ�;BillPeriodCd;60;;c;" & "o;n;n;5;"

            '' ''eoeksgks dlgofur... 
            ''If GmainBusinessFunction.GetValue("�α��� ID") = "999999" Then gridAttributes = gridAttributes & "|û��ȸ��;DemandOrders;1;#,##0;c;" & "o;n;n;15;" '(40)

            gridAttributes = gridAttributes & "|û������;TotDemandAmt;120;#,##0;r;" & "o;n;n;15;"       '(50)
            gridAttributes = gridAttributes & "|���ݰǼ�;Colcnt;120;#,##0;c;" & "o;n;y;15;"       '(60)
            gridAttributes = gridAttributes & "|���ݴ���;ColAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|�̼��ܾ�;RemainAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)

            gridAttributes = gridAttributes & "|���� ������ ����;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|������ݱ�����;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|������;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|��ü��;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|��ó�� ������;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)
            '' ''gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;80;;c;" & "o;n;n;7;"       '(10)
            '' ''gridAttributes = gridAttributes & "|������ȣ;BranchNum;80;;c;" & "o;n;n;9;"       '(20)
            '' ''gridAttributes = gridAttributes & "|��ڱ����ڵ�;OperatorDivCd;90;;c;" & "o;n;n;10;"       '(30)
            '' ''gridAttributes = gridAttributes & "|������;DepositAmt;120;;r;" & "o;n;n;15;"       '(40)
            '' ''gridAttributes = gridAttributes & "|�ϳ������ݴ���;FullPaymentAmt;120;;r;" & "o;n;n;15;"       '(50)
            '' ''gridAttributes = gridAttributes & "|�̼��ݴ���;UnColAmt;120;;r;" & "o;n;n;15;"       '(60)
            '' ''gridAttributes = gridAttributes & "|�̼�ó�������ڵ�;ProcDivCd;100;;c;" & "o;n;n;10;"       '(70)
            '' ''gridAttributes = gridAttributes & "|���;Note;200;;l;" & "o;n;n;1000;"       '(80)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

        End Sub

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '' ''���Ȯ�� ���� ��� ȭ������ JUMP.
            ' ''If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            ' ''Dim strCode As String '�������ڹ�ȣ
            ' ''Dim sdate As String
            ' ''sdate = dtpBaseYear.TextValue.Substring(0, 4) + "-" + "01"
            ' ''strCode = Me.dtpBaseYear.TextValue _
            ' ''          & ";" & Me.grd_1.GetCurrentRowCellValue("BranchNum") _
            ' ''          & ";" & sdate
            ' ''GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNI403;" & strCode)
            ' ''Me.ShowUiControl("PNI403", strCode)

        End Sub

       
    End Class

End Namespace