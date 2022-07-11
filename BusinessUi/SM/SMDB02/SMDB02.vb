'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : UI ����
' form ���� : UI ������ ��ȸ, �߰�, ����, �����Ѵ�.			
' �ۼ��� : 
' �ۼ��� : 
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

    Public Class SMDB02
        Inherits CommonControls.UiControl
        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""
            Dim i As Integer = 0

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code    

            ' multi header
            gridAttributes = gridAttributes & "||����;����;80;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|������Ʈ;ProjectID;65;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������Ʈ��;ProjectName;130;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�ý��۱���;SystemDivisionCode;65;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ý��۱��и�;SystemDivisionName;120;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�Ⱓ;ReceiptCount;55;;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�Ⱓ;DealingCount;55;;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;ReceiptSum;55;;r;" & "o;n;n;30;"          '�����Ǽ� 
            gridAttributes = gridAttributes & "|����;DealingSum;55;;r;" & "o;n;n;30;"          'ó���Ǽ�  
            gridAttributes = gridAttributes & "|��ó��;Receipting;55;;r;" & "o;n;n;30;"        '������
            gridAttributes = gridAttributes & "|��ó��;Ing;55;;r;" & "o;n;n;30;"               '������
            gridAttributes = gridAttributes & "|��ó��;Lefting;55;;r;" & "o;n;n;30;"           '����

            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"                   '����

            ' ������ single header
            'gridAttributes = gridAttributes & "||����;����;40;;4;" & "o;n;y;"
            'gridAttributes = gridAttributes & "|�ý��۱���;SystemDivisionCode;300;;c;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|�ý��۱��и�;SystemDivisionName;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|�����Ǽ�;ReceiptCount;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|ó���Ǽ�;DealingCount;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|��������;ReceiptSum;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|ó������;DealingSum;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|������;Ing;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|������;Receipting;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|����;Lefting;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"


            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            Me.DateInit()

            '--multi header
            'Fixed �÷� column Merge
            With Me.grd_1
                .AddItem(ControlChars.Tab & "����" & ControlChars.Tab & "������Ʈ" & ControlChars.Tab & "������Ʈ��" & ControlChars.Tab _
                                          & "�ý��۱���" & ControlChars.Tab & "�ý��۱��и�" & ControlChars.Tab _
                                          & "����" & ControlChars.Tab & "ó��" & ControlChars.Tab _
                                          & "����" & ControlChars.Tab & "ó��" & ControlChars.Tab _
                                          & "������" & ControlChars.Tab & "������" & ControlChars.Tab & "����" & ControlChars.Tab & "")
                .FixedRows = 2
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly
                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next
                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next
            End With

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���� ����;ReceiptDate;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;Orders;300;#,###;r;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;EmployeeNumber;100;;r;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|��������;ReceiptDivision;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������;Underwriter;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�۾���;Worker;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�۾������ڵ�;WorkStates;300;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkStatesName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�۾������ڵ�;WorkDivision;300;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkDivisionName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|ó������ ����;ManagementProgramDate;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|ó������;ManagementDate;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;Subject;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|��û����;DemandMatters;10;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��û����;DemandMatters_2;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|����;ManagementInternalUse;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|ó������;OccurrenceCause;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�μ�;HCodeName;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�系��ȭ��ȣ;InFirmTelephoneNumber;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|����;Title;10;;l;" & "io;n;y;30;"                   '����Ʈ Ÿ��Ʋ 

            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"                   '����

            'grid code combo
            gridCodeNameList = ""

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

            Me.grd_2.ExplorerBar = 3

        End Sub

#Region "�˾� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : popSystemID
        ''' ��  �� : �˾� Where�� �߰� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub popSystemID_ButtonClick() Handles popSystemID.ButtonClick
            Me.popSystemID.Tag = ""
            Dim strProjectID As String = ""
            If Me.popProjectID.NameText = "" Then
                strProjectID = "code(�ý��� ��);where(ProjectID like '%' + '" & Me.popProjectID.TextValue & "');"
            Else
                strProjectID = "code(�ý��� ��);where(ProjectID='" & Me.popProjectID.TextValue & "0');"
            End If

            Me.popSystemID.Tag = strProjectID
            'MsgBox(strContractorIDTag)
        End Sub
#End Region

        '====================================================================================================
        Public Sub DateInit()
            '�⺻ ��¥ ����
            Me.dtpReceiptDateFrom.TextValue = Date.Today.AddDays(-6)
            Me.dtpReceiptDateTo.TextValue = Date.Today
        End Sub

        Private Sub SMDB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        'Private Sub btnReceiptCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiptCopy.Click
        '    Me.SaveData_2()
        'End Sub

        Private Sub optTotality_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            RequestData_2()
        End Sub

        Private Sub optDivision1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDivision1.Click
            RequestData_2()
        End Sub

        Private Sub optDivision2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDivision2.Click
            RequestData_2()
        End Sub

        Private Sub optreceipt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optreceipt.Click
            RequestData_2()
        End Sub

        Private Sub optleft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optleft.Click
            RequestData_2()
        End Sub

        Private Sub opting_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles opting.Click
            RequestData_2()
        End Sub

        Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

            'With Me.grd_2
            '    If .Rows > 1 Then
            '        If Control.MouseButtons = Windows.Forms.MouseButtons.Left Then
            '            If .CellChecked = C1.Win.C1FlexGrid.Classic.CellCheckedSettings.flexChecked Then
            '                Me.ToolTip1.RemoveAll()
            '                Exit Sub
            '            End If
            '            Me.ToolTip1.GetToolTip(Me.grd_2)
            '            Me.ToolTip1.SetToolTip(Me.grd_2, .GetCurrentRowCellValue("DemandMatters"))
            '            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
            '            Select Case .ColSel
            '                Case .get_ColIndex("����")
            '                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
            '            End Select
            '        End If

            '    End If
            'End With
        End Sub

        Private Sub grd_2_LeaveCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_2.LeaveCell

            If Me.ToolTip1.Active = True Then
                Me.ToolTip1.RemoveAll()
            End If

        End Sub

        Private Sub cboWorkDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWorkDivision.SelectedIndexChanged
            If Me.grd_1.Rows > 2 Then
                Me.RequestData_2()
            End If
        End Sub

    End Class

End Namespace
