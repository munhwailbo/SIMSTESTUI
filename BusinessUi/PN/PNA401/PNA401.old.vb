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

    Public Class PNA401
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
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;60;;c;" & "io;n;n;12;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ѱ۸�;CompanyHangulNm;70;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|����Ȯ��ó�ڵ�;ParentCompanyCd;60;;c;" & "io;n;n;5;Ȯ��ó ��;ParentCompanyNm;"
            gridAttributes = gridAttributes & "|����Ȯ��ó��;ParentCompanyNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����ڵ�;GroupCd;60;;c;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|������ܿ���;PrintYesOrNo;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��뿩��;UseYN;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�����ȣ;PostNum;70;;c;" & "io;n;n;40;�����ȣ;CodeHangulName"
            gridAttributes = gridAttributes & "|�ּ�;Addr1;120;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���ּ�;Addr2;100;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����;BusiStatus;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����ڹ�ȣ;BusinessNum;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��ǥ�ڸ�;CorparationNm;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����;BusiType;70;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|���������;ExChargeEmpInfo;70;;c;" & "io;n;n40;"
            gridAttributes = gridAttributes & "|����ڿ���ó;ExChargeEmpPhoneNum1;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���;Note;60;;l;" & "io;n;n;5;"


            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "GroupCd;Ȯ�� ���� �ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNA401_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub


    End Class

End Namespace
