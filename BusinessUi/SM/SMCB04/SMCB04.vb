' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : SMCB04
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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.AC

    Public Class SMCB04
        Inherits CommonControls.UiControl

        Private Sub SMCB04_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'VSFlexGrid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|���� �ڵ�;OnesPositionDepartmentCode;150;;c;" & "o;n;n;30;���� ��;OnesPositionDepartmentCodeName"
            gridAttributes = gridAttributes & "|���� ��;OnesPositionDepartmentCodeName;150;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;80;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;100;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�ٹ� ����;SeviceStatesCode;100;;l;" & "o;n;n;50;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���� �ڵ�;RoleCode;84;;c;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|���� ��;RoleName;200;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;84;;l;" & "io;n;y;6;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;84;;l;" & "o;n;n;6;"

            'grid code combo
            gridCodeNameList = ""
            Me.grd_2.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���� �ڵ�;RoleCode;84;;c;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|���� ��;RoleName;200;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;84;;l;" & "o;n;n;6;"

            'grid code combo
            gridCodeNameList = ""
            Me.grd_3.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|���� �ڵ�;RoleCode;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|���α׷� ID;ProgramID;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���α׷� ��;ProgramName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȸ ����;RequestYesOrNo;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���� ����;SaveYesOrNo;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���� ����;DeleteYesOrNo;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��� ����;PrintYesOrNo;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ȱ��ȭ ����;ActivationYesOrNo;300;;c;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""

            Me.grd_4.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 1
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExplorerBar = 1
            Me.grd_4.ExplorerBar = 0
            Me.grd_4.ExplorerBar = 1

        End Sub

        Private Sub btnMove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove1.Click
            Me.DeleteData()
        End Sub

        Private Sub btnMove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove2.Click
            Me.SaveData()
        End Sub

        Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

            Me.grd_2.Editable = EditableSettings.flexEDKbdMouse
            With Me.grd_2
                Select Case .ColSel
                    Case .get_ColIndex("RoleCode")
                        .Editable = EditableSettings.flexEDNone
                End Select
            End With

        End Sub

        Private Sub grd_3_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_3.EnterCell

            Me.grd_3.Editable = EditableSettings.flexEDKbdMouse
            With Me.grd_3
                Select Case .ColSel
                    Case .get_ColIndex("RoleCode")
                        .Editable = EditableSettings.flexEDNone
                End Select
            End With

        End Sub

    End Class

End Namespace
