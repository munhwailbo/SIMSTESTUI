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

Namespace ubiLease.UI.BusinessUi.CO

    Public Class SMCA02
        Inherits CommonControls.UiControl

        Private Sub SMCA02_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;100;;c;" & "io;n;n;6;���� ����� ��� ��;EmployeeNameHangul"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��� ��ȣ;SecretNumber;100;;c;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|�ʱ�ȭ ����;NewYesNo;80;;c;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���� �ڵ�;OnesPositionDepartmentCode;100;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|���� ��;OrganizationCodeName;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����� ���;UserGrade;80;;c;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���� ��� ��ȣ;RoleEmpNum;100;;c;" & "io;n;n;6;���� ����� ��� ��;RoleEmpNm"
            gridAttributes = gridAttributes & "|���� ��� ��;RoleEmpNm;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��� ����;PrivateUseYesOrNo;100;;c;" & "io;n;n;1;"

            'gridAttributes = gridAttributes & "|���;Note;3000;;l;" & "io;n;n;255;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "UserGrade;����� ��� ��"
            'gridCodeNameList = gridCodeNameList & "BusinessPlaceCode;����� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            grd_1.ExplorerBar = grd_1.get_ColIndex("EmployeeNumber")
            grd_1.ExplorerBar = grd_1.get_ColIndex("EmployeeNameHangul")

            grd_1.FrozenCols = 3

            '--------------------------------------------------
        End Sub

        Private Sub txtManagementTrustName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub txtProfitDistributionRatio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
            'Call sbSetGridToControl()
        End Sub

        Private Sub btnPromiseAmount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'Me.grd_3.AddRow()
        End Sub

        Private Sub popEarningsOrganizationCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popEarningsOrganizationCode.Load

        End Sub
    End Class

End Namespace
