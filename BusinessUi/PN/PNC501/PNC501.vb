'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : Ȯ��ó ���
' form ���� : Ȯ��ó�� ����մϴ�.
' �ۼ��� : ��������
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
Imports System.Collections.Generic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC501
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code

            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|����;Orders;40;;l;" & "o;n;y;"

            gridAttributes = gridAttributes & "|����;GB;40;;l;" & "o;n;y;"

            gridAttributes = gridAttributes & "|����Ű;vPkey;60;;c;" & "o;n;y;12;"
            'gridAttributes = gridAttributes & "|�����ڵ�;SubscribeCd;60;;c;" & "o;n;y;5;"
            'gridAttributes = gridAttributes & "|�����ڵ�;ReceiptCd;60;;c;" & "o;n;y;5;"


            gridAttributes = gridAttributes & "|��������;ReceiptDt;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�ð�;ReceiptStTime;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|��ȭ����ð�;ReceiptEdTime;60;;c;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|����;ConsultationCd;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|Ȯ�屸��;ExpandDivCd;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|���ڸ�;SubscribeNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ;PhoneNumber;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�����ȣ;PostNum;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ּ�;Addr1;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ּ�;Addr2;60;;l;" & "o;n;n;5;"



            'gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|���� ��;BranchNm;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|������� ��;BizEmpTeamCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�θ�;BizEmpTeamNm;60;;l;" & "o;n;n;5;"

            'gridAttributes = gridAttributes & "|���������;BizEmpNum;60;;c;" & "o;n;y;5;������� ��;BizEmpNm"
            gridAttributes = gridAttributes & "|���;BizEmpNm;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�ο�����;Content;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|ó�����;Results;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|ó������;StateCd;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|ó������;FinishDt;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�������;CnsltEmpNum;60;;l;" & "o;n;y;5;����ʹ�� ��;CnsltEmpNm"
            gridAttributes = gridAttributes & "|���� ��;CnsltEmpNm;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|��ȭ���ſ���;ReceiveSendBit;60;;l;" & "o;n;n;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ConsultationCd;�ο������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/StateCd;�ο������ڵ�"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNC501_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

        Private Sub grd_1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick
            '���Ȯ�� ���� ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            


            Dim ShowConsaultation As Collections.Generic.Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            ShowConsaultation.Add("�ο�������", Me.grd_1.GetCurrentRowCellValue("ReceiptDt"))
            ShowConsaultation.Add("�ο�����Ű", Me.grd_1.GetCurrentRowCellValue("vPkey"))
            ShowConsaultation.Add("����", Me.grd_1.GetCurrentRowCellValue("Orders"))
            ShowConsaultation.Add("���ڸ�", Me.grd_1.GetCurrentRowCellValue("SubscribeNm"))

            Me.SendPhonenumber("PN", Me.Name, ShowConsaultation, Me.GmainBusinessFunction.GetValue("�α��� ID"))

        End Sub
    End Class

End Namespace
