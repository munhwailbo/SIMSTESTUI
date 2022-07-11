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

    Public Class SMDB01
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
            gridAttributes = gridAttributes & "|����;Orders;300;#,###;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;EmployeeNumber;100;;r;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramName;ProgramName;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|DptmProgramName;DptmProgramName;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��������;ReceiptDivision;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������;Underwriter;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�۾���;Worker;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkStates;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�۾�����;WorkDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|ó������ ����;ManagementProgramDate;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ó������;ManagementDate;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;Subject;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "WorkStates;�۾� ���� ��"
            gridCodeNameList = gridCodeNameList & "/WorkDivision;�۾� ���� ��"
            gridCodeNameList = gridCodeNameList & "/ReceiptDivision;���� ��û�� ���� ����"

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
            Me.dtpManagementDateFrom.TextValue = ""
            Me.dtpManagementDateTo.TextValue = ""

        End Sub

        Private Sub SMDB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        Private Sub btnReceiptCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiptCopy.Click
            Me.SaveData_2()
        End Sub

        Private Sub cboWorkDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWorkDivision.SelectedIndexChanged
            'If cboWorkDivision.SelectedIndex = 3 Then
            '    txtWorkDetail.Enabled = True
            'Else
            '    txtWorkDetail.Enabled = False
            '    txtWorkDetail.TextValue = ""
            'End If
        End Sub

        'Private Sub SMDB01_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        '    Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
        '    If ShareParameters(3) <> "" Then
        '        Me.dtpReceiptDateFrom.TextValue = ShareParameters(0) '���� ���� ����
        '        Me.dtpReceiptDateTo.TextValue = ShareParameters(1) '���� ���� ����
        '        Me.dtpManagementDateFrom.TextValue = "" 'ó�� ���� ����
        '        Me.dtpManagementDateTo.TextValue = "" 'ó�� ���� ����
        '        Me.popSystemID.TextValue = ShareParameters(2) '�ý��� ����

        '    ElseIf ShareParameters(4) <> "" Then
        '        Me.dtpReceiptDateFrom.TextValue = "" '���� ���� ����
        '        Me.dtpReceiptDateTo.TextValue = "" '���� ���� ����
        '        Me.dtpManagementDateFrom.TextValue = ShareParameters(0) 'ó�� ���� ����
        '        Me.dtpManagementDateTo.TextValue = ShareParameters(1) 'ó�� ���� ����
        '        Me.popSystemID.TextValue = ShareParameters(2) '�ý��� ����

        '    End If

        '    Me.RequestData()
        '    GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "")

        'End Sub

        Private Sub popProgramID_ButtonClick() Handles popProgramID.ButtonClick
            If Me.popSystemID_2.NameText = "" Then
                MessageBox.Show("�ݵ�� �ý��� ������ ������ �۾��ϼ��� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.popProgramID.Tag = "code(���α׷� ��);where(" & "Escape" & ");"
                Exit Sub
            End If

            'Dim strSysteDivision As String = ""

            'If Me.popSystemID_2.TextValue = "IR011" Then
            '    strSysteDivision = "CO"
            'ElseIf Me.popSystemID_2.TextValue = "IR012" Then
            '    strSysteDivision = "LE"
            'ElseIf Me.popSystemID_2.TextValue = "IR013" Then
            '    strSysteDivision = "PK"
            'ElseIf Me.popSystemID_2.TextValue = "IR014" Then
            '    strSysteDivision = "PR"
            'ElseIf Me.popSystemID_2.TextValue = "IR015" Then
            '    strSysteDivision = "PA"
            'ElseIf Me.popSystemID_2.TextValue = "IR016" Then
            '    strSysteDivision = "AC"
            'ElseIf Me.popSystemID_2.TextValue = "IR017" Then
            '    strSysteDivision = "CM"
            'ElseIf Me.popSystemID_2.TextValue = "IR018" Then
            '    strSysteDivision = "SM"
            'ElseIf Me.popSystemID_2.TextValue = "IR019" Then
            '    strSysteDivision = "MA"
            'ElseIf Me.popSystemID_2.TextValue = "IR051" Then
            '    strSysteDivision = "OM"
            'ElseIf Me.popSystemID_2.TextValue = "IR052" Then
            '    strSysteDivision = "PM"
            'End If

            Dim strProgramIDTag As String = ""

            'strProgramIDTag = "code(���α׷� ��2);where( SystemDivision='" & strSysteDivision & "' group by ProgramID);"
            'strProgramIDTag = "code(���α׷� ��);where( SystemDivision ='" & popSystemID_2.TextValue & "' group by ProgramID);"
            strProgramIDTag = "code(���α׷� ��);where( SystemDivision ='" & popSystemID_2.TextValue & "');"

            Me.popProgramID.Tag = strProgramIDTag

        End Sub

        'Private Sub popSystemID_ButtonClick()
        '    Me.popSystemID.Tag = ""
        '    Dim strProjectID As String = ""
        '    strProjectID = "code(�ý��� ��);where(ProjectID='" & Me.popProjectID.TextValue & "0');"
        '    Me.popSystemID.Tag = strProjectID
        'End Sub

    
    End Class

End Namespace
