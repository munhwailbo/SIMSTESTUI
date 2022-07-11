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

    Public Class SMF002
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

            gridAttributes = gridAttributes & "||����;����;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|���� ����;ReceiptDate;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;Orders;300;;r;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���� �ڵ�;OnesPositionDepartmentCode;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|���� ��;OnesPositionDepartmentCodeName;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���α׷� ��;ProgramName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|bbsSeq;bbsSeq;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;300;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeName;300;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�系 ��ȭ��ȣ;InFirmTelephoneNumber;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�۾���;Worker;400;;c;" & "io;n;n;200;"
            gridAttributes = gridAttributes & "|�۾� ����;WorkStates;400;;l;" & "io;n;n;80;"
            gridAttributes = gridAttributes & "|ó�� ���� ����;ManagementTerm;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|ó�� ���� ����;ManagementProgramDate;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|ó�� ����;ManagementDate;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���� ����;ReceiptDivision;300;;l;" & "o;n;n;80;"
            gridAttributes = gridAttributes & "|�۾� ����;WorkDivision;300;;l;" & "o;n;y;80;"
            gridAttributes = gridAttributes & "|������;Underwriter;300;;c;" & "o;n;n;100;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SystemDivision;�ý��� ���� ��"
            gridCodeNameList = gridCodeNameList & "/Worker;������ �ڵ�"
            gridCodeNameList = gridCodeNameList & "/WorkStates;�۾� ����"
            gridCodeNameList = gridCodeNameList & "/Underwriter;������ �ڵ�"
            gridCodeNameList = gridCodeNameList & "/ReceiptDivision;���� ��û�� ���� ����"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1
        End Sub

        Private Sub SMF002_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

    End Class

End Namespace
