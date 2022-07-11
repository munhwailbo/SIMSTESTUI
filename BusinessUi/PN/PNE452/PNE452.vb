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

    Public Class PNE452
        Inherits CommonControls.UiControl

        Private Sub PNE452_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            gridAttributes = gridAttributes & "|��������;ExpandDt;79;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��������;CollectionDivCd;0;;1;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|û�����;BillDivCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����Ⱓ;DmdDt;117;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���ᱸ�����۳��;FixedStDt;108;;c;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;77;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;75;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û������Ѿ�;Amount_A;90;#,##0;r;" & "o;n;n;15;"

            gridAttributes = gridAttributes & "|û������;DmdStateCd;80;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û�����;CalYearMonths;60;;c;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|û������;PlanDemandAmt;90;#,##0;r;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|û����;Amount_B;90;#,##0;r;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|���ݾ�;Amount_E;90;#,##0;r;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|��бݾ�;Amount_G;90;#,##0;r;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��кμ�;Amount_H;1;#,##0;r;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�̹�бݾ�;Amount_I;90;#,##0;r;" & "o;n;n;10;"

            ' '' ''gridAttributes = gridAttributes & "|���� ������ ����;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|������ݱ�����;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|������;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|��ü��;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|��ó�� ������;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            gridCodeNameList = gridCodeNameList & "/DmdStateCd;�������û�������ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3

        End Sub


        ''' <summary>
        ''' �Լ��� : PNE421_Enter 
        ''' ��  �� : ȭ�� ��ȯ(���Ȯ�� û����ȹ ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 5
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNE452_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4))
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
            End If
        End Sub

        ''' <summary>
        ''' �Լ��� : Request
        ''' ��  �� : �ٸ� ȭ�鿡�� �ڵ� �� �޾Ƽ� �ش� ������ ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetRequest(ByVal strBaseDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strEmployeeExpNum As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpBaseYear.TextValue = strBaseDt  '��������
            Me.popCompanyCd.TextValue = strCompanyCd  'Ȯ��ó��ȣ
            Me.popCompanyCd.NameText = strCompanyNm  'Ȯ��ó��
            Me.popEmployeeExpNum_R.TextValue = strEmployeeExpNum  'Ȯ��������ȣ

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
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