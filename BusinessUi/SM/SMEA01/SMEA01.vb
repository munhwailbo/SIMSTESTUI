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

    Public Class SMEA01
        Inherits CommonControls.UiControl

        Private Sub SMEA01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;c;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code    
    
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "io;n;y;"
            gridAttributes = gridAttributes & "|����� �ڵ�;BusinessPlaceCode;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȣ;FirmName;300;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|����� ��ȣ;BusinessesNumber;300;###-##-#####;l;" & "o;n;y;30;"
            'gridAttributes = gridAttributes & "|���� ��ȣ;JuridicalPersonNumber;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|��ǥ�� ��;RepresentativeName;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|���� ��ȣ;PostNumber;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|�ּ� 1;Address1;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|�ּ� 2;Address2;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|��ȭ ��ȣ;PhoneNumber;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|�ѽ� ��ȣ;FaxNumber;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|����;BusinessConditions;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|����;Item;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|������ �ڵ�;TaxOfficeCode;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|������ ��;TaxOfficeName;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|���;Note;300;;l;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "BusinessPlaceCode;����� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------



        End Sub

        

        
    End Class

End Namespace
