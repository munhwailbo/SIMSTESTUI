'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �α����� ��ȸ
' form ���� : �α� ������ ��ȸ�Ѵ�.			
' �ۼ��� : Ȳ����
' �ۼ��� : 2006-06-13 ����� 7�ð� ��
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDA01
        Inherits CommonControls.UiControl

        Private Sub SMDA01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;100;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeName;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|IP �ּ�;IPAdress;100;;c;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|���� �� ��;BeginningHour;80;;c;" & "o;n;n;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            'grd_1.FrozenCols = 3
            grd_1.ExplorerBar = 3
        End Sub

        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
            'Call sbSetGridToControl()
        End Sub

    End Class

End Namespace
