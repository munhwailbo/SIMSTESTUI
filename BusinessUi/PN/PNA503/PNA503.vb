'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �����ȣ ���
' form ���� : �����ȣ ���,����,���� �մϴ�.
' �ۼ��� : 
' �ۼ��� : 2008-12-03
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

    Public Class PNA503
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|�����ȣ�ڵ�;ZipSeriesNum;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�����ȣ;ZipCd;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��;Do;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��;City;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��;Dong;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��;Ri;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����;Island;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��;San;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���۹�����;SHouseNumJu;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���۹�����;SHouseNum1Bu;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��������;EHouseNumJu;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��������;EHouseNumBu;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����Ʈ��;ApartmentNm;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����Ʈ���۵�;ApartmentSDong;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����Ʈ����;ApartmentEDong;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��������;ProcessDt;20;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�ּ�;Addr;60;;l;" & "io;n;n;5;"
            'gridAttributes = gridAttributes & "|����������ڵ�;ChargeTypeCd;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;y;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ChargeTypeCd;����������ڵ�"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNA503_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub


        Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

        End Sub
    End Class

End Namespace
