' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form��   :[PNI401] �̼�ä������ ���	
' form���� :�̼�ä������ �����(��) �Ѵ�	
' �ۼ���   :�輺��
' �ۼ���   :2008-09-22 18:41:53
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

    Public Class PNI401
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
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;y;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;80;;c;" & "io;n;n;5;������;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�������;Name;100;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;100;;c;" & "io;n;n;5;������� ��;EmployeeNameHangul"
            'gridAttributes = gridAttributes & "|������� ��;EmployeeNameHangul;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����;EmployeeNameHangul;100;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����� ���;OpenYYYYMM;100;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����� ���;EndYYYYMM;100;;c;" & "io;n;n;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;100;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;100;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����ڸ�;EmployeeNameHangul;100;;c;" & "o;n;n;30;������� ��;EmployeeNameHangul"
            'gridAttributes = gridAttributes & "|������� ��;EmployeeNameHangul;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����;EmployeeNameHangul;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��ڱ����ڵ�;OperatorDivCd;100;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|������;DepositAmt;70;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ϳ���������;FullPaymentAmt;100;;c;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|�̼��ݴ���;UnColAmt;100;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�̼���ó�������ڵ�;ProcDivCd;120;;c;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|���;Note;60;;l;" & "io;n;y;60;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ProcDivCd;�̼���ó�������ڵ�"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

            Me.grd_2.ExplorerBar = 0
        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNI401_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNI401_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub
#End Region

    End Class

End Namespace
