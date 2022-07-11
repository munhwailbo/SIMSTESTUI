'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : UI ����
' form ���� : UI ������ ��ȸ, �߰�, ����, �����Ѵ�.			
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMF001
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
            gridAttributes = gridAttributes & "|���� ����;ReceiptDate;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;Orders;300;;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���� �ڵ�;OnesPositionDepartmentCode;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|���� ��;OnesPositionDepartmentCodeName;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|����;Subject;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|��������;ReceiptDivision;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|������;Underwriter;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�۾���;Worker;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkStates;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkDivision;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|ó������ ����;ManagementProgramDate;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|ó������;ManagementDate;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"


            'gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|���α׷� ��;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|bbsSeq;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|��� ��ȣ;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|��� ��;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|�系 ��ȭ��ȣ;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|���� ����;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|������;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|ó�� ����;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|�۾� ����;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|�۾���;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|ó�� ���� ����;ProgramID;300;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|ó�� ����;ProgramID;300;;l;" & "io;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SystemDivision;�ý��� ���� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            Me.DateInit()

        End Sub

        '====================================================================================================
        Public Sub DateInit()
            '�⺻ ��¥ ����
            'Dim currentDateFrom As String = ""
            'Dim currentDateTo As String = ""
            'currentDateTo = Date.Today
            'currentDateFrom = currentDateTo.Substring(0, 8) + "01"
            'Date.Today.AddDays(-6)
            Me.dtpReceiptDateFrom.TextValue = Date.Today.AddDays(-6)
            Me.dtpReceiptDateTo.TextValue = Date.Today
        End Sub

        Private Sub SMF001_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        Private Sub btnReceiptCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiptCopy.Click
            Me.SaveData_2()
        End Sub
    End Class

End Namespace
