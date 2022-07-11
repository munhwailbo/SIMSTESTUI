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

    Public Class PNE202
        Inherits CommonControls.UiControl
        '====================================================================================================


#Region "�� �ʱ�ȭ"

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
            gridAttributes = gridAttributes & "|Ȯ����;PayYearMonths;60;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|����;SeriesNum;40;;c;" & "io;n;n;6;"       '(10)

            gridAttributes = gridAttributes & "|�����ڻ��;EmpNum;70;;c;" & "o;n;n;5;��� ��;EmpNm"
            gridAttributes = gridAttributes & "|�����ڸ�;EmpNm;70;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�μ���;DeptNm;100;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��������;PayDt;80;;c;" & "io;y;n;5;"

            gridAttributes = gridAttributes & "|�ű�Ȯ��;NewExpPaperNum;70;#,##0;c;" & "o;n;n;4;"    '(70) �ű�Ȯ��μ�
            gridAttributes = gridAttributes & "|��Ȯ��;ReExpPaperNum;70;#,##0;c;" & "o;n;n;4;"       '(70) ��Ȯ��μ�
            gridAttributes = gridAttributes & "|Ȯ���;ExpPaperNum;70;#,##0;c;" & "o;n;n;4;"         '(70) Ȯ��μ���
            gridAttributes = gridAttributes & "|����;NewStopPaperNum;70;#,##0;c;" & "o;n;n;4;"    '(70) �����μ�(�ű�)
            gridAttributes = gridAttributes & "|����;ReStopPaperNum;70;#,##0;c;" & "o;n;n;4;"  '(70) �����μ�(������)
            gridAttributes = gridAttributes & "|����;NewRealPaperNum;70;#,##0;c;" & "o;n;n;4;"          '(70) �����μ�
            gridAttributes = gridAttributes & "|����;ReRealPaperNum;70;#,##0;c;" & "o;n;n;4;"          '(70) �����μ�
            'gridAttributes = gridAttributes & "|Ȯ��ܰ�;ExpPaperUnit;90;#,##0;r;" & "o;n;n;4;"      '(70) Ȯ��ܰ�

            gridAttributes = gridAttributes & "|�ű�Ȯ���;NewExpPaperUnit;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|�ű�Ȯ���;NewIncomeTax;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|�ű�Ȯ���;NewInhabitantsTax;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�ű�Ȯ���;NewExpAmount;90;#,##0;r;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|��Ȯ���(50������);ReExpPaperUnitBelow50;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|��Ȯ���(50������);ReIncomeTaxBelow50;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|��Ȯ���(50������);ReInhabitantsTaxBelow50;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��Ȯ���(50������);ReExpAmountBelow50;90;#,##0;r;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|��Ȯ���(51��~100��);ReExpPaperUnitBelow100;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|��Ȯ���(51��~100��);ReIncomeTaxBelow100;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|��Ȯ���(51��~100��);ReInhabitantsTaxBelow100;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��Ȯ���(51��~100��);ReExpAmountBelow100;90;#,##0;r;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|��Ȯ���(101���̻�);ReExpPaperUnitAbove101;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|��Ȯ���(101���̻�);ReIncomeTaxAbove101;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|��Ȯ���(101���̻�);ReInhabitantsTaxAbove101;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��Ȯ���(101���̻�);ReExpAmountAbove101;90;#,##0;r;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|��;SupportAmt;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��;IncomeTax;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��;InhabitantsTax;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��;SumTax;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��;ExpAmount;90;#,##0;r;" & "o;n;n;4;"


            gridAttributes = gridAttributes & "|�ż�;OneMillionWon;50;#,##0;r;" & "o;n;n;4;"      '�鸸���� �ż�
            gridAttributes = gridAttributes & "|�ż�;HundredThousandWon;50;#,##0;r;" & "o;n;n;4;" '�ʸ����� �ż�
            gridAttributes = gridAttributes & "|�ż�;TenThousandWon;50;#,##0;r;" & "o;n;n;4;"     '������ �ż�

            gridAttributes = gridAttributes & "|�����ڵ�;NationalityCd;60;;c;" & "io;y;n;5;"            ' �����ڵ�
            gridAttributes = gridAttributes & "|���ֱ����ڵ�;ResidenceDivCd;60;;c;" & "io;y;n;5;"       ' ���ֱ����ڵ�

            'gridAttributes = gridAttributes & "|����;Remark;90;;r;" & "o;n;n;4;"     '(60) �μ���
            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "NationalityCd;�����ڵ�"
            gridCodeNameList = gridCodeNameList & "/ResidenceDivCd;���ֱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "����"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ����"
            strColName2 = strColName2 & ControlChars.Tab & "����"

            strColName2 = strColName2 & ControlChars.Tab & "�����ڻ��"
            strColName2 = strColName2 & ControlChars.Tab & "�����ڸ�"
            strColName2 = strColName2 & ControlChars.Tab & "�μ��ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "�μ���"
            strColName2 = strColName2 & ControlChars.Tab & "��������"

            strColName2 = strColName2 & ControlChars.Tab & "�ű�Ȯ��"
            strColName2 = strColName2 & ControlChars.Tab & "��Ȯ��"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ���"
            strColName2 = strColName2 & ControlChars.Tab & "�ű�"
            strColName2 = strColName2 & ControlChars.Tab & "������"
            strColName2 = strColName2 & ControlChars.Tab & "�ű�"
            strColName2 = strColName2 & ControlChars.Tab & "������"

            strColName2 = strColName2 & ControlChars.Tab & "�ܰ�"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ���ݾ�"

            strColName2 = strColName2 & ControlChars.Tab & "�ܰ�"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ���ݾ�"

            strColName2 = strColName2 & ControlChars.Tab & "�ܰ�"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ���ݾ�"

            strColName2 = strColName2 & ControlChars.Tab & "�ܰ�"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ���ݾ�"

            strColName2 = strColName2 & ControlChars.Tab & "�������"
            strColName2 = strColName2 & ControlChars.Tab & "�ҵ漼"
            strColName2 = strColName2 & ControlChars.Tab & "�ֹμ�"
            strColName2 = strColName2 & ControlChars.Tab & "���ݰ�"
            strColName2 = strColName2 & ControlChars.Tab & "Ȯ���ݾ�"

            strColName2 = strColName2 & ControlChars.Tab & "�鸸��"
            strColName2 = strColName2 & ControlChars.Tab & "�ʸ���"
            strColName2 = strColName2 & ControlChars.Tab & "����"

            strColName2 = strColName2 & ControlChars.Tab & "�����ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "���ֱ����ڵ�"

            With Me.grd_1

                Dim i As Integer

                .AddItem(strColName2)

                .FixedRows = 3
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly

                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next

                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next

            End With

            Me.grd_1.ExplorerBar = 3

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
        Private Sub PNE202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If

        End Sub
#End Region

        Private Sub btnCreateSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSale.Click
            SaveData()
        End Sub

        Private Sub btnSlipApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyClose.Click
            SaveData_2("1")
        End Sub

        Private Sub btnSlipCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelClose.Click
            SaveData_2("3")
        End Sub
    End Class

End Namespace
