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

    Public Class PNG203
        Inherits CommonControls.UiControl

        Private Sub PNG203_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "n;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|������;YYYYMM;60;;l;" & "o;n;n;6;"       '(10)
            gridAttributes = gridAttributes & "|��������;CalDt;200;;l;" & "o;n;n;20;"       '(20)
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;l;" & "o;n;n;9;"       '(30)
            gridAttributes = gridAttributes & "|�����񱸺��ڵ�;DivCd;100;;l;" & "o;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|�μ�;PaperNum;40;;r;" & "o;n;n;4;"       '(50)
            gridAttributes = gridAttributes & "|�ܰ�;UnitCost;150;;r;" & "o;n;n;15;"       '(60)
            gridAttributes = gridAttributes & "|������ݾ�;SupAmt;150;;r;" & "o;n;n;15;"       '(70)
            gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;150;;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|�����ݾ�;DeductAmt;150;;r;" & "o;n;n;15;"       '(90)
            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;200;;l;" & "o;n;n;20;"       '(100)
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;200;;l;" & "o;n;n;20;"       '(110)
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;200;;l;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|���;Note;200;;l;" & "o;n;n;1000;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub
#End Region

    End Class

End Namespace
