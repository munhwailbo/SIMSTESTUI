' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form��   : ���Ȯ��� û�� ���� ó��
' form���� : ���Ȯ���(����) û������ó�� �Ѵ�
' �ۼ���   : �輺��
' �ۼ���   : 2008-09-22
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

    Public Class PNI201
        Inherits CommonControls.UiControl
        '====================================================================================================


#Region "�� �ʱ�ȭ"

        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|û�����;CollectYYYYMM;60;;c;" & "o;y;n;5;"

            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;60;;l;" & "o;y;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;70;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;70;;c;" & "o;n;n;40;Ȯ��ó ��;CompanyNm;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;70;;l;" & "o;n;n;40;"
        
            gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;70;;c;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ��ڵ�;BillPeriodCd;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|ȸ��;DemandOrders;70;;c;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|��û�����ݾ�;TotBillAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û������ݾ�;TotDemandAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�μ�;FixedPaperNum;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ݾ�;BillAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��û���ܾ�;RemainAmt;60;#,###;r;" & "o;n;n;5;"

            'gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;60;;c;" & "io;n;n;5;"
            'gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;70;;c;" & "io;n;n;40;"
            'gridAttributes = gridAttributes & "|���ݾ�;CollectionAmt;70;#,##0;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|����;Remark;70;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|������� ���;SYYYYMM;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���븸�� ���;EYYYYMM;70;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|�Ա� ����;ReceiveDt;70;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|���� ����;CollectionYN;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3

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
        Private Sub PNI201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If

        End Sub
#End Region

        Private Sub btnCreateSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSale.Click
            '''''''RequestData2()
            SaveData()
        End Sub

    End Class

End Namespace
