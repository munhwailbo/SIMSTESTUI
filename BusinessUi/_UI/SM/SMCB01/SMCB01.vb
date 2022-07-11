' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : SMCB01
' form���� : ������� ������ ����Ѵ�.
' �ۼ��� : ���µ�
' �ۼ��� : 2006-01-24
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.AC

    Public Class SMCB01
        Inherits CommonControls.UiControl

        Private Sub SMCB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'VSFlexGrid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���� �ڵ�;RoleCode;84;;4;" & "io;n;y;6;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;84;;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;200;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���� �ڵ�;OnesPositionDepartmentCode;200;;1;" & "o;n;n;30;���� ��;OnesPositionDepartmentCodeName"
            gridAttributes = gridAttributes & "|���� ��;OnesPositionDepartmentCodeName;200;;1;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "businessplacecode;����� ��"
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)

            gridAttributes = ""
            Me.grd_1.ExplorerBar = 3


            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���� �ڵ�;RoleCode;84;;4;" & "io;n;y;6;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;84;;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;200;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���� �ڵ�;OnesPositionDepartmentCode;200;;1;" & "io;n;n;30;���� ��;OnesPositionDepartmentCodeName"
            gridAttributes = gridAttributes & "|���� ��;OnesPositionDepartmentCodeName;200;;1;" & "io;n;n;30;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "branchcode_2;���� ��"
            Me.grd_2.Initialize(gridAttributes, gridCodeNameList)


            Me.grd_2.ExplorerBar = 3
        End Sub

        Private Sub btnMove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove1.Click
            '
            GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RoleCode", Me.cboRoleCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)

            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub btnMove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove2.Click
            '
            GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RoleCode", Me.cboRoleCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_2_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)

            CallByName(Me, "RequestData", CallType.Method)
        End Sub
    End Class

End Namespace
