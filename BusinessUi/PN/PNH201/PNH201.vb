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

    Public Class PNH201
        Inherits CommonControls.UiControl

        Private Sub PNH201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|����;TreePath;123;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���;YYYYMM;63;yyyy-MM;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|�μ���;DeptNm;64;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����;ChargeEmpNm;50;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;76;;4;" & "io;n;n;10;������ȣ;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;58;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���屸���ڵ�;PrintOfficeCd;0;;1;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|�Ǳ����ڵ�;PrintPlateCd;0;;1;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|�����Ϲ�����1;CurValPaperNum1;94;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�����Ϲ�����2;CurValPaperNum2;94;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|������Ÿ����1;CurValPaperNUm3;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|������Ÿ����2;CurValPaperNum4;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|���������μ���;CurValPaperNumYT;99;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���������μ�;CurNoValPaperNum;87;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�����μ���;CurNoValPaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����Ϲ�����1;VaryValPaperNum1;91;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�����Ϲ�����2;VaryValPaperNum2;90;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|������Ÿ����1;VaryValPaperNum3;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|������Ÿ����2;VaryValPaperNum4;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|���������μ���;VaryValPaperNumYT;99;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���������μ�;VaryNoValPaperNum;87;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�����μ���;VaryNoValPaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|����Ϲ�����1;FixedValPaperNum1;94;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|����Ϲ�����2;FixedValPaperNum2;94;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�����Ÿ����1;FixedValPaperNum3;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|�����Ÿ����2;FixedValPaperNum4;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|��������μ���;FixedValPaperNumYT;99;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��������μ�;FixedNoValPaperNum;87;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|����μ���;FixedNoValPaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����μ�μ�;CurPrintPaperNum;0;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|Ȯ���μ�μ�;FixedPrintPaperNum;0;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            'gridCodeNameList = gridCodeNameList & "PrintOfficeCd;���屸���ڵ�"
            'gridCodeNameList = gridCodeNameList & "/PrintPlateCd;�Ǳ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            ' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            ' ''gridAttributes = gridAttributes & "|���;YYYYMM;60;;l;" & "io;n;n;6;"       '(10)
            ' ''gridAttributes = gridAttributes & "|��;DD;20;;l;" & "io;n;n;2;"       '(20)
            ' ''gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;l;" & "io;n;n;9;"       '(30)
            ' ''gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;c;" & "o;n;n;5;�����ڵ�;BranchNm"
            ' ''gridAttributes = gridAttributes & "|������;BranchNm;60;;l;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|���屸���ڵ�;PrintOfficeCd;100;;l;" & "io;n;n;10;"       '(40)
            ' ''gridAttributes = gridAttributes & "|�Ǳ����ڵ�;PrintPlateCd;100;;l;" & "io;n;n;10;"       '(50)
            ' ''gridAttributes = gridAttributes & "|�Ϲ�����;CurValPaperNum1;90;;r;" & "io;n;n;4;"       '(60)�������μ�1
            ' ''gridAttributes = gridAttributes & "|����������;CurValPaperNum2;90;;r;" & "io;n;n;4;"       '(70)�������μ�2
            ' ''gridAttributes = gridAttributes & "|��Ÿ����1;CurValPaperNUm3;90;;r;" & "io;n;n;4;"       '(80)�������μ�3
            ' ''gridAttributes = gridAttributes & "|��Ÿ����2;CurValPaperNum4;90;;r;" & "io;n;n;4;"       '(90)�������μ�4
            ' ''gridAttributes = gridAttributes & "|�������μ�;CurNoValPaperNum;90;;r;" & "io;n;n;4;"       '(100)
            ' ''gridAttributes = gridAttributes & "|�����Ϲ�����;VaryValPaperNum1;90;;r;" & "io;n;n;4;"       '(110)
            ' ''gridAttributes = gridAttributes & "|��������������;VaryValPaperNum2;90;;r;" & "io;n;n;4;"       '(120)
            ' ''gridAttributes = gridAttributes & "|������Ÿ����1;VaryValPaperNum3;90;;r;" & "io;n;n;4;"       '(130)
            ' ''gridAttributes = gridAttributes & "|������Ÿ����2;VaryValPaperNum4;90;;r;" & "io;n;n;4;"       '(140)
            ' ''gridAttributes = gridAttributes & "|���������μ�;VaryNoValPaperNum;90;;r;" & "io;n;n;4;"       '(150)
            ' ''gridAttributes = gridAttributes & "|Ȯ���Ϲ�����;FixedValPaperNum1;90;;r;" & "io;n;n;4;"       '(160)
            ' ''gridAttributes = gridAttributes & "|Ȯ������������;FixedValPaperNum2;90;;r;" & "io;n;n;4;"       '(170)
            ' ''gridAttributes = gridAttributes & "|Ȯ����Ÿ����1;FixedValPaperNum3;90;;r;" & "io;n;n;4;"       '(180)
            ' ''gridAttributes = gridAttributes & "|Ȯ����Ÿ����2;FixedValPaperNum4;90;;r;" & "io;n;n;4;"       '(190)
            ' ''gridAttributes = gridAttributes & "|Ȯ�������μ�;FixedNoValPaperNum;90;;r;" & "io;n;n;4;"       '(200)
            ' ''gridAttributes = gridAttributes & "|�����μ�μ�;CurPrintPaperNum;90;;r;" & "io;n;n;4;"       '(210)
            ' ''gridAttributes = gridAttributes & "|Ȯ���μ�μ�;FixedPrintPaperNum;90;;r;" & "io;n;n;4;"       '(220)
            ' ''gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)

        End Sub
#End Region

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            '' ''Dim CurruntRow As Long

            With grd_1
                If .Rows > .FixedRows + 1 Then
                    ''CurruntRow = .GetCurrentRowCellValue("") + 1
                    ''�̿� �� ó��
                    'TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum1"))) _
                    '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum2"))) _
                    '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNUm3"))) _
                    '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNUm4"))) _
                    '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNum")))
                    '.set_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNumTot"), TotalValue.ToString)
                    '���� �� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum3")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum4")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNumTot"), TotalValue.ToString)

                    '���� 1 �� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum1"), TotalValue.ToString)

                    '���� 2 �� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum2")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum2"), TotalValue.ToString)

                    '���� 3 �� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum3")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum3")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum3"), TotalValue.ToString)

                    '���� 4 �� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum4")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum4")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum4"), TotalValue.ToString)
                    '���� �μ��� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNumYT")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNumYT"), TotalValue.ToString)
                    '�������� �μ��� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", ""))

                    .set_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNumYT"), TotalValue.ToString)
                    '���� �μ��� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNumT"), TotalValue.ToString)
                    '���� �� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNum"), TotalValue.ToString)


                    'Ȯ�� �� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNumT")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", "")) _
                    + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
                    '+ Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNumT"), TotalValue.ToString)
                End If
            End With
        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.Row)
        End Sub

   
        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
            RequestData2()
        End Sub


      
    End Class

End Namespace
