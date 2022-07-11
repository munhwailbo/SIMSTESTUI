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

    Public Class PNH103
        Inherits CommonControls.UiControl

        Private Sub PNH103_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|����;TreePath;121;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���;YYYYMM;56;yyyy-MM;4;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|��;DD;27;dd;4;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|�μ���;DeptNm;66;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|����ڸ�;ChargeEmpNm;57;;1;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;54;;4;" & "o;n;n;10;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;67;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�μ�μ�;PrintPaperNum;62;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����μ�;PrintValPaperNum;62;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����μ�;PrintNoValPaperNum;62;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���屸���ڵ�;PrintOfficeCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�Ǳ����ڵ�;PrintPlateCd;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;87;;4;" & "o;n;n;10;���������ڵ�;"
            gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;112;;4;" & "o;n;n;10;                   "
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "PrintOfficeCd;���屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd;�Ǳ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            ' '' '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ' '' '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            '' '' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            '' '' ''gridAttributes = gridAttributes & "|���;YYYYMM;60;;l;" & "o;n;n;6;"       '(10)
            '' '' ''gridAttributes = gridAttributes & "|��;DD;20;;l;" & "o;n;n;2;"       '(20)
            '' '' ''gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;c;" & "io;n;n;10;"
            '' '' ''gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;c;" & "o;n;n;5;�����ڵ�;BranchNm"
            '' '' ''gridAttributes = gridAttributes & "|������;BranchNm;60;;l;" & "o;n;n;5;"
            '' '' ''gridAttributes = gridAttributes & "|���屸���ڵ�;PrintOfficeCd;100;;l;" & "o;n;n;10;"       '(40)
            '' '' ''gridAttributes = gridAttributes & "|�Ǳ����ڵ�;PrintPlateCd;100;;l;" & "o;n;n;10;"       '(50)
            '' '' ''gridAttributes = gridAttributes & "|�μ�μ�;PrintPaperNum;40;;r;" & "o;n;n;4;"       '(60)
            '' '' ''gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            ' '' '' ''grid_1 code combo    
            '' '' ''Dim gridCodeNameList As String = ""
            '' '' ''gridCodeNameList = gridCodeNameList & "PrintOfficeCd;���屸���ڵ�"
            '' '' ''gridCodeNameList = gridCodeNameList & "/PrintPlateCd;�Ǳ����ڵ�"
            '' '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click

        End Sub
    End Class

End Namespace
