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

    Public Class PNJ102
        Inherits CommonControls.UiControl

        Private Sub PNJ102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|����;TreePath;80;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;80;;c;" & "o;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;110;;l;" & "o;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|������;PublishDt;70;;c;" & "io;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|����μ�;CirculationNum;70;#,##0;c;" & "o;n;n;4;"       '(70)
            gridAttributes = gridAttributes & "|�����ǹ����ڵ�;CouponPublicCd;1;;c;" & "io;n;y;10;"       '(10)
            gridAttributes = gridAttributes & "|�������;Orders;65;;c;" & "io;n;n;20;"       '(30)
            gridAttributes = gridAttributes & "|����󼼼���;DetailOrders;90;;c;" & "io;n;n;20;"       '(110)
            gridAttributes = gridAttributes & "|������ڵ�;PublishBarCode;140;;c;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|������۹�ȣ;PublishStNum;1;;l;" & "o;n;y;30;"       '(50)
            gridAttributes = gridAttributes & "|���������ȣ;PublishEdNum;1;;l;" & "o;n;y;8;"       '(60)

            gridAttributes = gridAttributes & "|����ܰ�;UnitCost;60;#,##0;r;" & "o;n;n;15;"       '(80)
            gridAttributes = gridAttributes & "|���;Note;100;;l;" & "o;n;n;1000;"       '(90)
            gridAttributes = gridAttributes & "|�������;PrintDt;100;;c;" & "o;n;n;20;"       '(130)
            gridAttributes = gridAttributes & "| ;Dummy;5;;c;" & "o;n;n;20;"       '(130)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub
#End Region

        
    End Class

End Namespace
