'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �߷� ���� ���
' form ���� : �߷� ������ �߰�, ����, ����, ��ȸ�Ѵ�.
' �ۼ��� : �ڹ���
' �ۼ��� : 2006-05-09
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNA202
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;1000;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;5000;;l;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|�Ի�����;JoinCompanyDate;5000;;l;" & "o;n;y;2;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNameHangul")

            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;1000;;r;" & "io;n;y;6;"
            gridAttributes = gridAttributes & "|�߷� �Ϸ� ��ȣ;AnnOfAppCnsNmb;1000;;c;" & "io;y;y;2;"
            gridAttributes = gridAttributes & "|�߷� ����;AnnouncementOfAppointmentDate;100;;l;" & "io;y;n;8;"
            gridAttributes = gridAttributes & "|�߷� �ڵ�;AnnouncementOfAppointmentCode;80;;c;" & "io;y;n;5;�߷� ��;AnnouncementOfAppointmentName"
            gridAttributes = gridAttributes & "|�߷� ��;AnnouncementOfAppointmentName;100;;l;" & "o;y;n;5;"
            gridAttributes = gridAttributes & "|�ٹ� ����;SeviceStatesCode;80;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|�μ� �ڵ�;OnesPositionDepartmentCode;80;;l;" & "io;n;n;7;��Ʈ ��;OnesPositionDepartmentCodeName"
            gridAttributes = gridAttributes & "|�߷� �μ�;OnesPositionDepartmentCodeName;100;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|�ٹ� �μ�;SeviceDepartmentCode;1147;;l;" & "io;n;y;7;"
            gridAttributes = gridAttributes & "|����;PromotionCode;80;;c;" & "io;n;n;5"
            gridAttributes = gridAttributes & "|����;PositionCode;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��� ����;DutyCode;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����;PayStepCode;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�����߷� ����;LstAnnOfAppYesOrNo;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�������� ����;LastPromotionYesOrNo;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�޿� ����;AllowanceDivisionCode;1000;;l;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|���;Note;100;;l;" & "io;n;n;255;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "AnnouncementOfAppointmentCode;�߷� ��"
            gridCodeNameList = gridCodeNameList & "SeviceStatesCode;�ٹ� ���� ��"
            ''gridCodeNameList = gridCodeNameList & "/OnesPositionDepartmentCode;�Ҽ� �μ� ��"
            ''gridCodeNameList = gridCodeNameList & "/SeviceDepartmentCode;�ٹ� �μ� ��"
            gridCodeNameList = gridCodeNameList & "/PromotionCode;���� ��"
            gridCodeNameList = gridCodeNameList & "/PositionCode;���� ��"
            gridCodeNameList = gridCodeNameList & "/PayStepCode;ȣ�� ��"
            gridCodeNameList = gridCodeNameList & "/AllowanceDivisionCode;�޿� ���� ��"

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 1

        End Sub

        Private Sub PNA202_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = "" Then Exit Sub

            Me.cboSeviceStatesCode2.TextValue = ShareParameters(0)
            Me.txtEmployeeNameHangul_2.TextValue = ShareParameters(1)

            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub grd_2_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.grd_2.ImeMode = System.Windows.Forms.ImeMode.Hangul
        End Sub

        Private Sub PNA202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If
        End Sub

        Private Function CheckDataAllowPermitionByUser(ByVal AUiId As String, ByVal ALogInID As String, ByVal APermition As String) As Boolean
            Dim tempSqlParameter() As SqlParameter = Nothing
            Dim reciveDataSet As DataSet = Nothing

            Dim RequestPermition As String = ""
            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", ALogInID)
            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AprogramId", AUiId)

            reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "GetScreeenPermintionByUser", False, True, tempSqlParameter)
            If IsNothing(reciveDataSet) = False Then
                If reciveDataSet.Tables(0).Rows.Count > 0 Then
                    RequestPermition = CType(reciveDataSet.Tables(0).Rows(0).Item(0), Integer)

                    If APermition = "RequestData" Then
                        CheckDataAllowPermitionByUser = IIf(RequestPermition = 1, True, False)
                    End If
                End If

            End If
        End Function

        Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        btnPRB002.Click, btnPRB003.Click, btnPRB004.Click, btnPRB005.Click _
        , btnPRB006.Click, btnPRB007.Click, btnPRB009.Click _
        , btnPNA202.Click, btnPRB011.Click, btnPRB012.Click, btnPRB013.Click _
        , btnPRB014.Click, btnPRB015.Click, btnPRB016.Click

            If txtEmployeeNumber.TextValue = "" Then
                MessageBox.Show("�ݵ�� ����� ��ȸ�� ȭ�� �̵��� �ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim SeviceStatesCode2 As String = Me.cboSeviceStatesCode2.TextValue
            Dim EmployeeNameHangul As String = Me.txtEmployeeNameHangul.TextValue

            If SeviceStatesCode2 <> "" Then
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", SeviceStatesCode2 & ";" & EmployeeNameHangul & ";")
                Dim UiControlId As String = Mid(Me.ActiveControl.Name, 4, 6)

                If Me.CheckDataAllowPermitionByUser(UiControlId, GmainBusinessFunction.GetValue("�α��� ID"), "RequestData") = True Then
                    ' ������ �ִ� ���
                    Me.ShowUiControl(UiControlId, "")
                Else
                    MessageBox.Show("ȭ�� ���� ������ �����ϴ�.", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MsgBox("��ȸ�� ����� �����ϴ�.")
            End If

        End Sub
    End Class

End Namespace
