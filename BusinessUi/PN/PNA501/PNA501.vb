'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �������׸��������
' form ���� : ������ �׸��� ��� ���� �մϴ�.
' �ۼ��� : ������
' �ۼ��� : 2006-03-07
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

    Public Class PNA501
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.   <����M>
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;90;;c;" & "o;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�����;ChargeEmpNum;80;;c;" & "o;n;n;10;��� ��;ChargeEmpNumNm"
            gridAttributes = gridAttributes & "|����ڸ�;ChargeEmpNumNm;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���������;ChargeTypeCd;120;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '���ڸ� ���߱� ��

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ChargeTypeCd;����������ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;10;;;" & "io;n;y;10;"       '(20)
            gridAttributes = gridAttributes & "|����;SeriesNum;10;;;" & "io;n;y;10;"       '(20)
            gridAttributes = gridAttributes & "|�����ȣ;ZipSeriesNum;10;;;" & "io;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|�ּ�;Addr;30;;;" & "o;n;n;30;"       '(30)
            'grid_1 code combo    
            gridCodeNameList = ""
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3

            '==============================================================
            '  grid_3 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;10;;;" & "io;n;n;10;���� ��;BranchNm"       '(20)
            gridAttributes = gridAttributes & "|������;BranchNm;10;;;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|����;SeriesNum;10;;;" & "io;n;y;10;"       '(20)
            gridAttributes = gridAttributes & "|�����ȣ;ZipSeriesNum;10;;;" & "io;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|�ּ�;Addr;30;;;" & "o;n;n;30;"       '(30)
            'grid_1 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_3.ExplorerBar = 3


        End Sub

        Private Sub PNA501_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

    End Class

End Namespace
