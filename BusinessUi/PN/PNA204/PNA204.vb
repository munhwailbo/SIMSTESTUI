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

    Public Class PNA204
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
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|��ȣ;idx;40;;l;" & "io;y;y;"
            gridAttributes = gridAttributes & "|CTI ������;AgentNM;60;;c;" & "io;y;n;12;"
            gridAttributes = gridAttributes & "|�����ȣ;EmployeeNumber;70;;l;" & "io;y;n;40;����ʹ�� ��;EmployeeNameHangul;"
            gridAttributes = gridAttributes & "|�����;EmployeeNameHangul;60;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|���̵�;Extension;60;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|CTI ����� ���̵�;UserID;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|CTI ����� �н�����;Password;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|CTI ���� IP;CTIServerIP;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|CTI DB IP;DBServerIP;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���� �׷�;svcID;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��뿩��;PrivateUseYesOrNo;40;;c;" & "io;y;n;5;"

            gridAttributes = gridAttributes & "|���;Note;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���2;Note1;60;;c;" & "io;n;n;5;"

            


            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "GroupCd;Ȯ�� ���� �ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNA204_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub


    End Class

End Namespace
