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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic


Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE602
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNE602_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|Ȯ����;ExpandYearMonth;80;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|Ȯ����;ExpandYearMonth_2;80;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|Ȯ��μ� �ڵ�;SoliDeptCd;90;;l;" & "io;n;y;�μ� ��;SoliDeptName"
            gridAttributes = gridAttributes & "|Ȯ��μ� ��;SoliDeptName;90;;l;" & "io;n;y;;"
            gridAttributes = gridAttributes & "|Ȯ��μ� �ڵ�;SoliDeptCd_2;90;;l;" & "o;n;n;�μ� ��;SoliDeptName"
            gridAttributes = gridAttributes & "|Ȯ��μ� ��;SoliDeptName_2;90;;c;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|�űԺμ�;NewExpPapNum;70;#,###;r;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|�������μ�;ReExpPapNum;70;#,###;r;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|�Ѻμ�;SumExpPapNum;70;#,###;r;" & "o;n;n;;"
            'gridAttributes = gridAttributes & "|���;Remark;200;;l;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
        End Sub
#End Region

    End Class

End Namespace
