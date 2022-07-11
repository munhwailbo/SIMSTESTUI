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

    Public Class PNF102
        Inherits CommonControls.UiControl

        Private Sub PNF102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "�� �ʱ�ȭ"
        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.12.01
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
            gridAttributes = gridAttributes & "|����;TreePath;114;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���س⵵;BaseYear;62;yyyy;4;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|���ڵ�;DeptCd;1;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�� ��;DeptNm;69;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���������;ChargeEmpNum;1;;4;" & "o;n;n;7;������� ��;BranchNm "
            gridAttributes = gridAttributes & "|������� ��;ChargeEmpNm;73;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;1;;4;" & "io;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|���� ��;BranchNm;66;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|��ǥ��;GoalPaperNum;50;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|������;ResultPaperNum;50;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|������;GuessPaperNum;50;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|1����ǥ;JanGoalPapeNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|1������;JanResultPapeNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|1������;JanGuessPapeNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|2����ǥ;FebGoalPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|2������;FebResultPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|2������;FebGuessPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|3����ǥ;MarGoalPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|3������;MarResultPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|3������;MarGuessPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|4����ǥ;AprGoalPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|4������;AprResultPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|4������;AprGuessPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|5����ǥ;MayGoalPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|5������;MayResultPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|5������;MayGuessPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|6����ǥ;JunGoalPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|6������;JunResultPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|6������;JunGuessPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|7����ǥ;JulGoalPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|7������;JulResultPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|7������;JulGuessPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|8����ǥ;AugGoalPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|8������;AugResultPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|8������;AugGuessPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|9����ǥ;SepGoalPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|9������;SepResultPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|9������;SepGuessPaperNum;57;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|10����ǥ;OctGoalPaperNum;64;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|10������;OctResultPaperNum;64;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|10������;OctGuessPaperNum;64;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|11����ǥ;NovGoalPaperNum;64;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|11������;NovResultPaperNum;64;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|11������;NovGuessPaperNum;64;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|12����ǥ;DecGoalPaperNum;64;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|12������;DecResultPaperNum;64;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|12������;DecGuessPaperNum;64;#,##0;7;" & "o;n;n;4;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '����� ����
            popChargeEmpNum.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popChargeEmpNum.Enabled = False
                popChargeEmpNum.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                GmainBusinessFunction.GetValue("�α��� ID"), _
                                                GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

        End Sub
#End Region

        Private Sub SetTotalValue(ByVal CurruntRow As Long)
            '' ''Dim TotalValue As Long
            '' '' ''Dim CurruntRow As Long
            '' ''With grd_1
            '' ''    If .Rows > 1 Then
            '' '' ''        CurruntRow = .GetCurrentRowCellValue("")
            '' ''        '���� �� ó��
            '' ''        TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("JanGoalPapeNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FebGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("MarGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("AprGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("MayGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("JunGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("JulGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("AugGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SepGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("OctGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("NovGoalPaperNum")).ToString.Replace(",", "")) _
            '' ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DecGoalPaperNum")).ToString.Replace(",", ""))
            '' ''        .set_TextMatrix(CurruntRow, .get_ColIndex("GoalPaperNum"), TotalValue.ToString)
            '' ''    End If
            '' ''End With
        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.row)
        End Sub

    End Class

End Namespace
