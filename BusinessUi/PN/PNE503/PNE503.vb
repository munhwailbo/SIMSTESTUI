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

    Public Class PNE503
        Inherits CommonControls.UiControl

        Private Sub PNE503_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            Grid_Initialize()
        End Sub
        Private Sub Grid_Initialize()


            '  �Ǹź��޺�(��޺�) ������Ȳ
            'If optExpAmt1.Checked Then
            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"
            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|������ȣ;EmployeeExpNum;1;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|��޺����޳��;YYYYMM;100;;l;" & "o;n;n;;"

            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;87;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|û�����;BillDivCdNm;1;;1;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|������ȣ;BranchNum;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���������;ChargeEmpNum;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�������;ChargeEmpNm;80;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;200;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ּ�;Addr1;180;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ּ�;Addr2;180;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|��޺����޺μ�;GsPaperNum;80;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|������;PaperNum;60;#,##0;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ű�;NewExpPapNum;60;#,##0;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��Ȯ��;ReExpPapNum;60;#,##0;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ݾ�;Amt;100;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����ü;DeductAmt;100;#,##0;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;100;#,##0;r;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|��޴ܰ�;SubscriptionAmt;100;#,##0;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|���ԱⰣ;FixedStEdDt;120;;l;" & "o;n;y;;"
            gridAttributes = gridAttributes & "|��޺����ް��ÿ�;CollectionYYYYMM;80;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|��޺����޿�;MM;80;;l;" & "o;n;y;;"

            gridAttributes = gridAttributes & "|��б��س��;DisYearMonths;80;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|������(*);TrAdEmployeeNum;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�����ڸ�(*);TrAdEmployeeNm;62;;4;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|������;AdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڸ�;AdEmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����ںμ�;AdEmployeeDeptCd;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�����ںμ���;AdEmployeeDeptNm;75;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|����ó�ڵ�;CompanyCd;1;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|����ó��;CompanyNm;120;;l;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|��������;ContactDt;1;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;1;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;MngStopDt;85;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|���;Memo;80;;l;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|SO;SortOrders;1;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;80;;l;" & "o;n;y;5;"
            'gridAttributes = gridAttributes & "|��޺����޳⵵;YYYY;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|��޺����޿�;MM;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|��������;FixedStDt;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|��������;FixedEdDt;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceMM;1;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|��ü����;TransferDt;80;;l;" & "o;n;y;;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;1000;"       '(80)

            'gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            ''gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3
            'End If

            '' �Ǹź��޺�(��޺�) ������Ȳ
            'If optExpAmt2.Checked Then
            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            'grid_1 code combo    
            gridCodeNameList = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"
            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|������ȣ;EmployeeExpNum;1;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|��޺����޳��;YYYYMM;100;;l;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|���ԱⰣ;FixedStEdDt;120;;l;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|��޺����ް��ó��;CollectionYYYYMM;80;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��޴ܰ�;SubscriptionAmt;100;#,##0;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|��޺����޿�;MM;80;;l;" & "o;n;y;;"

            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;87;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|û�����;BillDivCdNm;1;;1;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|��޺����޺μ�;GsPaperNum;80;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|����ó�ڵ�;CompanyCd;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����ó��;CompanyNm;120;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|������(*);TrAdEmployeeNum;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�����ڸ�(*);TrAdEmployeeNm;62;;4;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|������;AdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڸ�;AdEmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����ںμ�;AdEmployeeDeptCd;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�����ںμ���;AdEmployeeDeptNm;75;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|���������;ChargeEmpNum;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�������;ChargeEmpNm;80;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;1;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|��б��س��;DisYearMonths;80;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������;PaperNum;60;#,##0;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ű�;NewExpPapNum;60;#,##0;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|��Ȯ��;ReExpPapNum;60;#,##0;c;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|�ݾ�;Amt;100;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����ü;DeductAmt;100;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;100;#,##0;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;1;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;200;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�ּ�;Addr1;180;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|���ּ�;Addr2;180;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|��������;ContactDt;1;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;1;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;MngStopDt;85;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|���;Memo;80;;l;" & "o;n;n;5;"

            'gridAttributes = gridAttributes & "|SO;SortOrders;1;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;80;;l;" & "o;n;y;5;"
            'gridAttributes = gridAttributes & "|��޺����޳⵵;YYYY;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|��޺����޿�;MM;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|��������;FixedStDt;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|��������;FixedEdDt;80;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceMM;1;;l;" & "o;n;y;;"
            'gridAttributes = gridAttributes & "|��ü����;TransferDt;80;;l;" & "o;n;y;;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;1000;"       '(80)

            'gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            ''gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_2.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_2.ExplorerBar = 3
            'End If

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


        Private Sub optExpAmt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optExpAmt1.CheckedChanged, optExpAmt2.CheckedChanged

            grd_1.Visible = optExpAmt1.Checked
            grd_2.Visible = optExpAmt2.Checked

            chkRemark.Visible = optExpAmt1.Checked
        End Sub

    End Class

End Namespace