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

    Public Class PNI206
        Inherits CommonControls.UiControl

        Private Sub PNI206_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;40;;r;" & "io;n;y;4;"                         '(10)
            gridAttributes = gridAttributes & "|��꼭���� ����;TaxAccPublishDt;80;;l;" & "io;n;n;8;"             '(20)

            gridAttributes = gridAttributes & "|����ó����;SalesDiviCd;200;;l;" & "o;n;n;30;"       '(160)
            gridAttributes = gridAttributes & "|����ó�ڵ�;SalesCd;200;;l;" & "o;n;n;30;"       '(170)
            gridAttributes = gridAttributes & "|����ó��;SalesNm;200;;l;" & "o;n;y;30;"       '(170)

            gridAttributes = gridAttributes & "|��ȣ(���θ�);ConsumerCorpNm;200;;l;" & "o;n;n;30;"       '(130)
            gridAttributes = gridAttributes & "|����ڹ�ȣ;ConsumerBusinessNum;200;;l;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|�ֹι�ȣ;Jumin_reg_no;200;;l;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|��ǥ�ڼ���;ConsumerPresidentNm;200;;l;" & "o;n;n;30;"       '(140)
            gridAttributes = gridAttributes & "|���ް���;SupplyTotalAmt;150;#,##0;r;" & "o;n;n;15;"       '(200)
            gridAttributes = gridAttributes & "|����;TaxTotAmt;150;#,##0;r;" & "o;n;y;15;"       '(210)

            gridAttributes = gridAttributes & "|������ּ�;ConsumerAddr;200;;l;" & "o;n;n;1000;"      '(150)

            gridAttributes = gridAttributes & "|å��ȣ-��;BillGroupNum;40;;r;" & "o;n;y;4;"                      '(30)
            gridAttributes = gridAttributes & "|å��ȣ-ȣ;BillGroupSeriesNum;40;;r;" & "o;n;y;4;"                '(40)
            gridAttributes = gridAttributes & "|��꼭�Ϸù�ȣ;BillSeriesNum;40;;r;" & "o;n;y;4;"                '(50)

            gridAttributes = gridAttributes & "| ;jIrAL;40;;r;" & "o;n;n;4;"                      '(30)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SalesDiviCd;����ó�����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3

            dtpTaxAccPublishDt.TextValue = DateTime.Now().ToString.Substring(0, 8) & "01"
            dtpTaxAccPublishDt2.TextValue = DateTime.Now().ToString

        End Sub

#End Region


        Private Sub cboSalesDivCd_R_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSalesDivCd_R.SelectedIndexChanged

            'popSalesCd_R.Enabled = True
            'If cboSalesDivCd_R.TextValue = "1" Then
            '    lblCodeDivisionHangulName.Text = "Ȯ��ó�ڵ�"
            '    popSalesCd_R.Tag = "code(Ȯ��ó ��);"
            '    popSalesCd_R.TextValue = ""
            '    popSalesCd_R.MaxLength = 12
            'ElseIf cboSalesDivCd_R.TextValue = "2" Then
            '    lblCodeDivisionHangulName.Text = "�Ҽӻ��ڵ�"
            '    popSalesCd_R.Tag = "code(�Ҽӻ� ��);"
            '    popSalesCd_R.TextValue = ""
            '    popSalesCd_R.MaxLength = 4
            'ElseIf cboSalesDivCd_R.TextValue = "3" Then
            '    lblCodeDivisionHangulName.Text = "������ȣ"
            '    popSalesCd_R.Tag = "code(������ȣ);"
            '    popSalesCd_R.TextValue = ""
            '    popSalesCd_R.MaxLength = 9
            'Else
            '    lblCodeDivisionHangulName.Text = "��Ÿ����ó"
            '    popSalesCd_R.Enabled = False
            'End If

        End Sub
    End Class

End Namespace
