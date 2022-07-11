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

    Public Class PNH101
        Inherits CommonControls.UiControl

        Private Sub PNH101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & " a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|����;TreePath;114;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���;YYYYMM;63;yyyy-MM;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|��;DD;27;dd;4;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|�μ���;DeptNm;75;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����;EmployeeNameHangul;50;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;62;;4;" & "io;n;n;10;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;68;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��������;YdPaperNumY;59;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���Ϲ���;YdPaperNumM;58;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���Ϻμ���;YdPaperNumT;71;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��������;IncPaperNumY;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|��������;IncPaperNumM;61;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�����μ���;IncPaperNumT;73;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����μ�;PrintPaperNumY;60;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�����μ�;PrintPaperNumM;59;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�μ�μ���;PrintPaperNumT;69;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|����;Remark;34;;1;" & "io;n;n;4;"

            gridAttributes = gridAttributes & "|���屸���ڵ�org;PrintOfficeCd_org;81;;1;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|�Ǳ����ڵ�org;PrintPlateCd_org;68;;1;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|���屸���ڵ�;PrintOfficeCd;81;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|�Ǳ����ڵ�;PrintPlateCd;68;;1;" & "io;n;n;10;"

            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;0;;4;" & "o;n;y;10;���������ڵ�;"
            gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;65;;4;" & "o;n;n;10; "
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "PrintOfficeCd_org;���屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd_org;�Ǳ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/PrintOfficeCd;���屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd;�Ǳ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            '' ''gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;c;" & "io;n;n;10;"
            '' ''gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;c;" & "o;n;n;5;�����ڵ�;BranchNm"
            '' ''gridAttributes = gridAttributes & "|������;BranchNm;60;;l;" & "o;n;n;5;"
            '' ''gridAttributes = gridAttributes & "|��üȽ��;ChangeNum;60;;c;" & "o;n;n;40;"
            '' ''gridAttributes = gridAttributes & "|���;YYYYMM;60;;l;" & "io;n;n;6;"       '(20)
            '' ''gridAttributes = gridAttributes & "|�����μ�1;ValPaperNum1;90;;r;" & "io;n;n;4;"       '(30)
            '' ''gridAttributes = gridAttributes & "|�����μ�2;ValPaperNum2;90;;r;" & "io;n;n;4;"       '(40)
            '' ''gridAttributes = gridAttributes & "|�����μ�3;ValPaperNum3;90;;r;" & "io;n;n;4;"       '(50)
            '' ''gridAttributes = gridAttributes & "|�����μ�4;ValPaperNum4;90;;r;" & "io;n;n;4;"       '(60)
            '' ''gridAttributes = gridAttributes & "|�����μ�;NoValPaperNum;90;;r;" & "io;n;n;4;"       '(70)
            '' ''gridAttributes = gridAttributes & "|���������μ�;SettlePaperNum;120;;r;" & "io;n;n;4;"       '(80)
            '' ''gridAttributes = gridAttributes & "|����������;SettleSalesAmt;150;;r;" & "io;n;n;15;"       '(90)
            ' '' ''grid_1 code combo    
            '' ''Dim gridCodeNameList As String = ""
            '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub
#End Region
        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.Row)
        End Sub

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValueInc As Long
            Dim TotalValueY As Long
            Dim TotalValueM As Long
            Dim TotalValueT As Long
            ''Dim CurruntRow As Long

            'gridAttributes = gridAttributes & "|��������;IncPaperNumY;40;#,##0;r;" & "io;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|��������;IncPaperNumM;40;#,##0;r;" & "io;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|�����μ���;IncPaperNumT;40;#,##0;r;" & "o;n;n;4;"       '(60)

            'gridAttributes = gridAttributes & "|�μ�����;PrintPaperNumY;40;#,##0;r;" & "o;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|�μ⹫��;PrintPaperNumM;40;#,##0;r;" & "o;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|�μ�μ���;PrintPaperNumT;40;#,##0;r;" & "o;n;n;4;"       '(60)
            With grd_1
                If .Rows > 1 Then
                    'CurruntRow = .GetCurrentRowCellValue("") + 1
                    'Ȯ���μ� ó��
                    TotalValueInc = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumY")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumM")).ToString.Replace(",", ""))
                    TotalValueY = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("YdPaperNumY")).ToString.Replace(",", "")) _
                                    + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumY")).ToString.Replace(",", ""))
                    TotalValueM = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("YdPaperNumM")).ToString.Replace(",", "")) _
                                    + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumM")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumT"), TotalValueInc.ToString)

                    .set_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumY"), TotalValueY.ToString)
                    .set_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumM"), TotalValueM.ToString)
                    TotalValueT = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumY")).ToString.Replace(",", "")) _
                                    + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumM")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumT"), TotalValueT.ToString)
                End If
            End With
        End Sub

        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
            RequestData2()
        End Sub


        'Private Sub SetTotalValue(ByVal CurruntRow As Long)

        '    Dim TotalValue As Long
        '    Dim CurruntRow As Long

        '    '' '' �����μ��� = �������� + �������� 
        '    '' '' �μ����� = �������� + ��������
        '    '' '' �μ⹫�� = ���Ϲ��� + ��������
        '    '' '' �μ�μ��� = �μ����� + �μ⹫��
        '    With grd_1
        '        If .Rows > 1 Then
        '            CurruntRow = .GetCurrentRowCellValue("")
        '            ''�̿� �� ó��
        '            'TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum1"))) _
        '            '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum2"))) _
        '            '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNUm3"))) _
        '            '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNUm4"))) _
        '            '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNum")))
        '            '.set_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNumTot"), TotalValue.ToString)
        '            '���� �� ó��
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum3")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum4")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNumTot"), TotalValue.ToString)

        '            '���� 1 �� ó��
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum1")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum1"), TotalValue.ToString)

        '            '���� 2 �� ó��
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum2")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum2"), TotalValue.ToString)

        '            '���� 3 �� ó��
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum3")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum3")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum3"), TotalValue.ToString)

        '            '���� 4 �� ó��
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum4")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum4")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum4"), TotalValue.ToString)

        '            '���� �� ó��
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNum")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNum"), TotalValue.ToString)


        '            'Ȯ�� �� ó��
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum1")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum2")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum3")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum4")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNum")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNumTot"), TotalValue.ToString)
        '        End If
        '    End With
        'End Sub

        'Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '    'SetTotalValue(e.row)
        'End Sub

    End Class

End Namespace
