'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �α����� ��ȸ
' form ���� : �α� ������ ��ȸ�Ѵ�.			
' �ۼ��� : Ȳ����
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

    Public Class SMDA04
        Inherits CommonControls.UiControl

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
            gridAttributes = gridAttributes & "|���� ����;SystemDivision;80;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|ȭ�� ID;UiID;80;;i;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|ȭ�� ��;UiName;170;;i;" & "o;n;n;80;"
            gridAttributes = gridAttributes & "|��� ��ȣ;employeeNumber;60;;c;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeName;80;;c;" & "o;n;n;"
            gridAttributes = gridAttributes & "|���� �Ǽ�;LogInCnt;70;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��ȸ �� ��;RCnt;70;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���� �� ��;SCnt;70;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���� �� ��;DCnt;70;;c;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "SystemDivision;���� ���� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            'grd_1.FrozenCols = 3

            grd_1.ExplorerBar = 3
        End Sub

        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
            'Call sbSetGridToControl()
        End Sub

    End Class

End Namespace
