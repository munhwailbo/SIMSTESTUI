'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : Ȯ��ó ���
' form ���� : Ȯ��ó�� ����մϴ�.
' �ۼ��� : �ݿ�ö
' �ۼ��� : 2008-09-22
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

    Public Class PNA403
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;100;;c;" & "io;y;n;4;"
            gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;150;;l;" & "io;y;n;30;"
            gridAttributes = gridAttributes & "|���ڸ�ܿ���;ReaderListYN;200;;l;" & "io;n;n;100;"

            ' ------ 2013.11.01 �ŷ�ó�ڵ� ���� ���Ͽ� �߰�
            gridAttributes = gridAttributes & "|�ŷ�ó�ڵ�;CustomerCode;80;;c;" & "io;n;n;30;�ŷ�ó�ڵ�;CustomerName"
            gridAttributes = gridAttributes & "|�ŷ�ó��;CustomerName;150;;c;" & "o;n;n;30;"
            ' ------ 2013.11.01 �ŷ�ó�ڵ� ���� ���Ͽ� �߰�

            gridAttributes = gridAttributes & "|����ڵ�Ϲ�ȣ;BusinessNum;100;;c;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|��ȣ;FirmNm;150;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��ǥ�ڸ�;PresidentNm;150;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�����ȣ;PostNum;80;;c;" & "o;n;y;7;�����ȣ;Addr1"
            gridAttributes = gridAttributes & "|�ּ�;Addr1;200;;l;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|���ּ�;Addr2;200;;l;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|����;BusiStatus;150;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|����;BusiType;150;;c;" & "o;n;y;30;"


            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNA403_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub


    End Class

End Namespace
