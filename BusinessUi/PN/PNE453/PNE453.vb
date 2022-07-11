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

    Public Class PNE453
        Inherits CommonControls.UiControl

        Private Sub PNE453_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;116;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;1;;4;" & "o;n;n;40;Ȯ��ó ��;CompanyNm"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;126;;1;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|û������;BillType;1;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;1;;1;" & "o;n;n;y;"

            gridAttributes = gridAttributes & "|û������;DmdStateCd;80;;c;" & "o;n;n;5;"

            ''gridAttributes = gridAttributes & "|��������;CollectionDivCd;0;;1;" & "o;n;y;40;"
            ''gridAttributes = gridAttributes & "|û�����;BillDivCd;88;;1;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;88;;1;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|�����Ⱓ;CalYearMonths;117;;4;" & "o;n;n;40;"
            ''gridAttributes = gridAttributes & "|���ᱸ�����۳��;FixedStDt;108;;4;" & "o;n;n;40;"
            ''gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;77;#,###;7;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;75;#,###;7;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|û������Ѿ�;TotDmdAmount;1;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|1���ݾ�;DmdAmount_01;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|2���ݾ�;DmdAmount_02;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|3���ݾ�;DmdAmount_03;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|4���ݾ�;DmdAmount_04;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|5���ݾ�;DmdAmount_05;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|6���ݾ�;DmdAmount_06;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|7���ݾ�;DmdAmount_07;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|8���ݾ�;DmdAmount_08;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|9���ݾ�;DmdAmount_09;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|10���ݾ�;DmdAmount_10;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|11���ݾ�;DmdAmount_11;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|12���ݾ�;DmdAmount_12;80;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "DmdStateCd;�������û�������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillType;û��������"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            ''gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            ''gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
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