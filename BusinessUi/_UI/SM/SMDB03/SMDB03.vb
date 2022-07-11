'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���� ���� ���
' form ���� : ���� ������ ��ȸ, �߰�, ����, �����Ѵ�.			
' �ۼ��� : Ȳ����
' �ۼ��� : 2007-06-15
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

    Public Class SMDB03
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

            gridAttributes = gridAttributes & "||����;����;40;;4;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���� ����;BusinessLogDate;80;####-##-##;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;Orders;80;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|���� �ڵ�;OnesPositionDepartmentCode;80;;l;" & "o;n;y;30;"
            'gridAttributes = gridAttributes & "|����;CodeName;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;LogTitle;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;BusinessLogContent;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������;ProgressRate;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�۾��ð�;WorkTime;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|���;Remark;150;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber_2;80;;l;" & "o;n;y;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|���� ����;ReceiptDate;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;Orders;300;#,###;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;EmployeeNumber;100;;r;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��������;ReceiptDivision;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������;Underwriter;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�۾���;Worker;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkStates;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|ó������ ����;ManagementProgramDate;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ó������;ManagementDate;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;Subject;300;;l;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""

            grd_3.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExplorerBar = 1

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|���� ����;ReceiptDate;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;Orders;300;#,###;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;EmployeeNumber;100;;r;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��������;ReceiptDivision;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������;Underwriter;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�۾���;Worker;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkStates;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|ó������ ����;ManagementProgramDate;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ó������;ManagementDate;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;Subject;300;;l;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""

            grd_4.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_4.ExplorerBar = 0
            Me.grd_4.ExplorerBar = 1

            Me.cboEmployee_R.TextValue = GmainBusinessFunction.GetValue("�α��� ID")

            Me.InitRequestData_1()
            Me.InitRequestData_2()

        End Sub

        '====================================================================================================
        Public Sub DateInit()
            '�⺻ ��¥ ����
            'Dim currentDateFrom As String = ""
            'Dim currentDateTo As String = ""
            'currentDateTo = Date.Today
            'currentDateFrom = currentDateTo.Substring(0, 8) + "01"
            'Date.Today.AddDays(-6)
            Me.dtpBusinessDateFrom.TextValue = Date.Today.AddDays(-6)
            Me.dtpBusinessDateTo.TextValue = Date.Today
        End Sub

        Private Sub SMDB03_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        ' Leave �̺�Ʈ�� TextValue OR Text ���� ���� ���� �Ѿ�Ƿ�... ������ �޾� �ѱ� ��... ¥��
        Public strBusinessLogDate As String = "" '�������ڸ� ���� ����
        Public strEmployeeNumber As String = "" '��� ��ȣ�� ���� ����
        Public strDivisionReques As String = "1" '�̺�Ʈ�� ��ȸ���� ��ȸ ��ư Ŭ���� ��ȸ���� ����

        Private Sub dtpBusinessLogDate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBusinessLogDate.Leave
            strBusinessLogDate = Me.dtpBusinessLogDate.TextValue

            If Me.dtpBusinessLogDate.TextValue.Length = 8 And Me.cboEmployee.TextValue.Length = 6 Then
                Me.grd_3.NewData()
                Me.grd_4.NewData()
                Me.RequestData_3()
                strDivisionReques = "2"
            End If

        End Sub

        Private Sub cboEmployee_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
            strEmployeeNumber = Me.cboEmployee.TextValue

            If Me.dtpBusinessLogDate.TextValue.Length = 8 And Me.cboEmployee.TextValue.Length = 6 Then
                Me.grd_3.NewData()
                Me.grd_4.NewData()
                Me.RequestData_3()
                strDivisionReques = "2"
            End If

        End Sub


    End Class

End Namespace
