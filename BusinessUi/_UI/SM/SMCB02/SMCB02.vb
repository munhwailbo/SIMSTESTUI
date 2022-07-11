'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ����������
' form ���� : ���� ���� �̷��� ��ȸ, �߰�, ����, �����Ѵ�.			
' �ۼ��� : �ڹ���
' �ۼ��� : 2006-03-09
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

    Public Class SMCB02
        Inherits CommonControls.UiControl

        Private Sub SMCB02_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code    

            gridAttributes = gridAttributes & "||����;����;40;;c;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���� �ڵ�;RoleCode;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|���α׷� ID;ProgramID;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���α׷� ��;ProgramName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȸ ����;RequestYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���� ����;SaveYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���� ����;DeleteYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|��� ����;PrintYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|������ȯ ����;ExcellRepYesOrNo;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|Ȱ��ȭ ����;ActivationYesOrNo;300;;c;" & "io;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "BusinessPlaceCode;����� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
        End Sub
    End Class

End Namespace
