'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���θ������
' form ���� : ���� ������ ����Ѵ�
' �ۼ��� : ������
' �ۼ��� : 2006-03-16
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

Namespace ubiLease.UI.BusinessUi.CM

    Public Class CMAA01
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;c;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|��ȣ;SEQ;1464;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;Title;1253;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|����;Content;1570;;l;" & "o;n;n;10000;"
            gridAttributes = gridAttributes & "|�ۼ�����;RegistrationDate;1041;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�ۼ���;Writer;1570;;l;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|���� ���� ����;DayClose;1570;;c;" & "o;n;y;12;"
            'gridAttributes = gridAttributes & "|��� ID;RegistrationIP;1570;;r;" & "o;n;n;12;"
            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

        End Sub


    End Class

End Namespace
