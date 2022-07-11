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

    Public Class PNE451
        Inherits CommonControls.UiControl

        Private Sub PNE451_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;1;;4;" & "o;n;n;40;Ȯ��ó ��;CompanyNm"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;126;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;116;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|��������;ExpandDt;79;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��������;CollectionDivCd;0;;1;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|û������;BillType;1;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û�����;BillDivCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����Ⱓ;CalYearMonths;117;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���ᱸ�����۳��;FixedStDt;108;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;77;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;75;#,###;7;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|û ��;Amount_A;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|û ��;Amount_B;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|û ��;Amount_C;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|û ��;Amount_D;0;#,##0;4;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|�� ��;Amount_E;90;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�� ��;Amount_F;90;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�� ��;Amount_G;90;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�� ��;Amount_H;90;#,##0;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|(I)���2��;Amount_I;90;#,##0;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|(J)�̹��2��;Amount_J;90;#,##0;7;" & "o;n;n;10;"
            '' '' '' ''gridAttributes = gridAttributes & "|���� ������ ����;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            '' '' '' ''gridAttributes = gridAttributes & "|������ݱ�����;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            '' '' '' ''gridAttributes = gridAttributes & "|������;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            '' '' '' ''gridAttributes = gridAttributes & "|��ü��;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            '' '' '' ''gridAttributes = gridAttributes & "|��ó�� ������;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillType;û��������"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '----�׸��� �ິ��--------------------------------- 
            Dim i As Integer = 0
            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "����"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ��ó�ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ��ó��"
            strColName2 = strColName2 & ControlChars.Tab & "���Ȯ���ȣ"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ���"

            strColName2 = strColName2 & ControlChars.Tab & "��������"
            strColName2 = strColName2 & ControlChars.Tab & "��������"
            strColName2 = strColName2 & ControlChars.Tab & "û������"
            strColName2 = strColName2 & ControlChars.Tab & "û�����"
            strColName2 = strColName2 & ControlChars.Tab & "û���ֱ�"
            strColName2 = strColName2 & ControlChars.Tab & "�����Ⱓ"
            strColName2 = strColName2 & ControlChars.Tab & "���ᱸ�����۳��"
            strColName2 = strColName2 & ControlChars.Tab & "������ܰ�"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ���μ�"

            strColName2 = strColName2 & ControlChars.Tab & "(A)û������Ѿ�"
            strColName2 = strColName2 & ControlChars.Tab & "(B)��û����"
            strColName2 = strColName2 & ControlChars.Tab & "(C)��û���Ѿ�"
            strColName2 = strColName2 & ControlChars.Tab & "(D)��û����"
            strColName2 = strColName2 & ControlChars.Tab & "(E)�����Ѿ�"
            strColName2 = strColName2 & ControlChars.Tab & "(F)�̼��ݾ�"
            strColName2 = strColName2 & ControlChars.Tab & "(G)���"
            strColName2 = strColName2 & ControlChars.Tab & "(H)�̹��"
            '''' --- 
            strColName2 = strColName2 & ControlChars.Tab & ""

            With Me.grd_1
                .AddItem(strColName2)
                .FixedRows = 2
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly
                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next
                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next
            End With
            '-------------------------------------------------- 


            Me.grd_1.ExplorerBar = 3

        End Sub

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '���Ȯ�� û����ȹ �� ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '���Ȯ���ȣ
            strCode = Me.dtpBaseYear.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum")
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNE452;" & strCode)
            Me.ShowUiControl("PNE452", strCode)

        End Sub

    End Class

End Namespace