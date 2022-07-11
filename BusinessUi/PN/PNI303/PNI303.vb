' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : 
' form���� :
' �ۼ��� : 
' �ۼ��� : 
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

    Public Class PNI303
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"

        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ���ϰ� : 
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>


        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;90;;1;" & "o;n;y;;;"
            gridAttributes = gridAttributes & "|����;TreePath;95;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����;ChargeEmpNm;50;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|������;BranchNm;80;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchNum;1;;4;" & "o;n;n;10;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|����;OldOrNew;50;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������;YearMonths;63;yyyy-MM;4;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�����̼���;UnColAmt;60;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|��������;SalesAmt;70;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���û����;TotalDemandAmt;70;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|������ݰ�;ColAmt;70;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���Աݾ�;DemandRemainAmt;67;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�̼�����;ThisMisuAmt;67;#,###;7;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�������������;LastDepositAmt;91;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|���������;ThisInDepositAmt;74;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|���ȯ�Ҿ�;ThisOutDepositAmt;74;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|������������;ThisDepositAmt;99;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;0;;4;" & "o;n;y;10;���������ڵ�;BranchRegionNm"
            gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|;Dummy;200;;1;" & "o;n;n;1000;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

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
        Private Sub PNI303_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

    End Class

End Namespace
