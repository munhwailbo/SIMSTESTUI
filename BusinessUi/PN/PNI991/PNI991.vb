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

    Public Class PNI991
        Inherits CommonControls.UiControl

        Private Sub PNI991_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���� ���� �ڵ�;ClosingType;80;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���� ���� ��;ClosingTypeNm;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���� ����;ClosingYearMonths;100;####-##-##;l;" & "o;y;n;30;"
            gridAttributes = gridAttributes & "|���� ó�� ����;ClosingDt;100;####-##-##;l;" & "o;y;n;30;"
            gridAttributes = gridAttributes & "|�۾��ڻ��;ClosingEmployee;100;;c;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|�۾��ڸ�;ClosingEmployeeNm;100;;l;" & "o;n;n;10;"       '(20)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            '' ''gridCodeNameList = gridCodeNameList & "BizTypeCd;�ް������ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            RequestData()

        End Sub
#End Region

    End Class

End Namespace
