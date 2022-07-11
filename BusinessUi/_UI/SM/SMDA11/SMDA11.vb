'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �ڵ����
' form ���� : ��ȭ���� �ڵ� ����
' �ۼ��� : �����
' �ۼ��� : 2006-04-06
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDA11
        Inherits CommonControls.UiControl

        Private Sub SMDA11_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���α׷� ID;ProgramId;80;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���α׷� ��;ProgramName;150;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|1�� ����;Weeks;80;#,##0;r;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|1���� ����;Months;80;#,##0;r;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|3���� ����;ThreeMonths;80;#,##0;r;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|6���� ����;SixMonths;80;#,##0;r;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|1�� ����;Years;80;#,##0;r;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|;Dummy;20;;l;" & "o;n;n;50;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

        End Sub

    End Class

End Namespace
