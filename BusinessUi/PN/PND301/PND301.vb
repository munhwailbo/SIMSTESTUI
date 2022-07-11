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

    Public Class PND301
        Inherits CommonControls.UiControl
        '====================================================================================================
        

#Region "�� �ʱ�ȭ"

        Public Sub Initialize()
            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|Pkey;Pkey;4;;;" & "io;n;y;4;"       '(10)
            gridAttributes = gridAttributes & "|ȸ��;MtOrders;4;;;" & "io;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|���θ�� ��;PromotionNm;30;;;" & "io;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|���� Ȯ��ó �ڵ�;CompanyCd;4;;;" & "io;n;n;4;Ȯ��ó ��;CompanyHangulNm"       '(40)
            gridAttributes = gridAttributes & "|Ȯ��ó ��;CompanyHangulNm;50;;;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|���� �ּ�;CompanyAddr;90;;c;" & "io;n;y;50;"       '(60)
            gridAttributes = gridAttributes & "|���� �μ�;ValPaperNum;4;#,##0;r;" & "io;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|��� ���� �ڵ�;ProBranchNum;9;;c;" & "io;n;n;9;�����ڵ�;BranchNm"       '(70)
            gridAttributes = gridAttributes & "|���� ��;BranchNm;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|����� ���;ProEmployeeNumber;8;;c;" & "io;n;n;8;������� ��;EmployeeNameHangul"       '(80)
            'gridAttributes = gridAttributes & "|������� ��;EmployeeNameHangul;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|�����;EmployeeNameHangul;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|����;Remak;200;;;" & "io;n;n;200;"       '(90)
            gridAttributes = gridAttributes & "|���� ����;StartDate;8;;;" & "io;n;n;8;"       '(100)
            gridAttributes = gridAttributes & "|���� ���� ����;PlanEndDate;8;;;" & "io;n;n;8;"       '(110)
            gridAttributes = gridAttributes & "|���� ����;EndDate;8;;;" & "io;n;n;8;"       '(120)
            gridAttributes = gridAttributes & "|��������ڵ�;IngStateCd;5;;;" & "io;n;n;5;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "IngStateCd;��������ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PND301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

        
    End Class

End Namespace
