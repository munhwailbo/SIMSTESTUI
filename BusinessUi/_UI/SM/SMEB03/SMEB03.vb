'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : Table ���� ���
' form ���� : Table ���� ��� �߰�, ����, ����, ��ȸ�Ѵ�.
' �ۼ��� : Ȳ����
' �ۼ��� : 2006-07-04
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

Imports System.Text
Imports System.IO

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMEB03
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String
            Dim gridCodeNameList As String

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = ""
            gridCodeNameList = ""
            gridAttributes = gridAttributes & "a;c;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���� ����;SystemClass;100;;c;" & "io;y;n;"
            gridAttributes = gridAttributes & "|���̺� ID;TableId;100;;l;" & "io;y;n;"
            gridAttributes = gridAttributes & "|���̺� ��;TableName;100;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���̺� ����;TableDesc;500;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|�̰� ����;MigYesOrNo;50;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|��� ����;UseYesOrNo;50;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|;Dummy;500;;l;" & "o;n;n;"

            'grid code combo
            gridCodeNameList = gridCodeNameList & "SystemClass;�ý��� ���� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

        End Sub

        Private Sub SMEB03_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub
    End Class

End Namespace
