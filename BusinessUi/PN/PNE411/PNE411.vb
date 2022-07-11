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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE411
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"

        Public Sub Initialize()

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input out'put); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"

            '''' ============================================================
            ''''   �׸��� ���� 2009.01.30 �ڱ�ö ���� ���� ���� Ȯ��
            '''' ============================================================
            gridAttributes = gridAttributes & "|�ۼ�����;ProcDt;70;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;ProcOrders;60;;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�Աݱ����ڵ�;ProcTypeCd;85;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|û�����;CalYearMonths;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;0;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|Ȯ���;EmployeeExpNm;90;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;0;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;90;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|��������;CollectionDivCd;70;;c;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|û�����;BillDivCd;70;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;70;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����Ⱓ;BillPeriodCd;70;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ᱸ�����۳��;BillPeriodCd;90;;c;" & "o;n;n;5;"

            '' ''gridAttributes = gridAttributes & "|������ܰ�;DemandAmt;70;#,###;r;" & "o;n;n;5;"
            '' ''gridAttributes = gridAttributes & "|�μ�;CollectionAmt;70;#,###;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|û���ݾ�;DemandAmt;70;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ݱݾ�;CollectionAmt;70;#,###;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|��г��;DistYearMonths;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��бݾ�;DistributionAmt;70;#,###;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|����;Note;120;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�Աݰ���;ColBankCd;0;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���¹�ȣ;ColAccountNum;0;;l;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|�Ա��ڸ�;Recipient;0;;c;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|�۾��ڻ��;ProcEmpNum;0;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�۾��ڸ�;ProcEmpNm;0;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "| ;mERoNG;30;;l;" & "o;n;n;40;"
            '''' ============================================================

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ColBankCd;�����ڵ�"
            gridCodeNameList = gridCodeNameList & "ColBankCd;�Աݰ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/ProcTypeCd;�Աݱ����ڵ�"   ''2323
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;���������ڵ�"   ''2323
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3

            lblRecordState.Text = "�غ�"
            ''dtpFromColDt.TextValue = "20081130"
            ''dtpToColDt.TextValue = "20081130"
            Me.NewData()

        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : ACA003_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNE411_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

        End Sub

        Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

        End Sub

        Private Sub numColAmt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numDistributionAmt.Load

        End Sub
    End Class

End Namespace
