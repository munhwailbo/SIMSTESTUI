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

    Public Class PNC503
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

            gridAttributes = gridAttributes & "|�߼���;Name;60;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�μ�;DeptNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�߼۹�ȣ;CALLBACK;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|������;DEST_NAME;70;;l;" & "o;n;n;40;"


            gridAttributes = gridAttributes & "|���Ź�ȣ;PHONE_NUMBER;60;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���ۻ���;RESULT;60;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�߼��Ͻ�;SEND_DATE;60;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�߼۸޼���;SMS_MSG;60;;l;" & "o;n;n;50;"


            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ConsultationCd;�ο������ڵ�"
            'gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            'gridCodeNameList = gridCodeNameList & "/StateCd;�ο������ڵ�"
            'gridCodeNameList = gridCodeNameList & "/MonitorResultCd;����Ͱ��ó���ڵ�"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNC503_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

    End Class

End Namespace
