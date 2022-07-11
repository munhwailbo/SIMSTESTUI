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

    Public Class SMBB01
        Inherits CommonControls.UiControl

        Dim mBolInit As Boolean = False

        Private Sub SMBB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""
            Dim strLevel As String = Me.cboOrganizationLevel.TextValue

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|��������;CodeDivisionCode;100;;l;" & "io;n;n;20;"
            gridAttributes = gridAttributes & "|�����ڵ�;OrganizationCode;100;;l;" & "io;n;y;20;"
            'gridAttributes = gridAttributes & "|��������;EmployeeNumber;100;;c;" & "io;n;n;6;"

            'gridAttributes = gridAttributes & "|����;BranchCode;50;;c;" & "io;n;n;2;"
            'gridAttributes = gridAttributes & "|��;TeamCode;50;;c;" & "io;n;n;2;"
            'gridAttributes = gridAttributes & "|��Ʈ;PartCode;50;;c;" & "io;n;n;2"
            'gridAttributes = gridAttributes & "|PC;PCCode;50;;c;" & "io;n;n;2;"
            'gridAttributes = gridAttributes & "|�ڳ�;CornerCode;50;;c;" & "io;n;n;2;"
            'gridAttributes = gridAttributes & "|������;CodeName;100;;l;" & "io;n;n;100;"


            'gridAttributes = gridAttributes & "|���;Note;3000;;l;" & "io;n;n;255;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            'grd_1.ComboItem(3)

            gridCodeNameList = gridCodeNameList & "CodeDivisionCode;���� ����"

            Select Case strLevel
                Case "1"
                    gridAttributes = gridAttributes & "|����;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|����;BranchCode;50;;l;" & "io;n;y;2;"
                    gridAttributes = gridAttributes & "|��;TeamCode;50;;l;" & "io;n;y;2;"
                    gridAttributes = gridAttributes & "|��Ʈ;PartCode;50;;l;" & "io;n;y;2"
                    gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;y;2;"
                    gridAttributes = gridAttributes & "|�ڳ�;CornerCode;50;;l;" & "io;n;y;2;"

                Case "2"
                    gridAttributes = gridAttributes & "|����;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|����;BranchCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|��;TeamCode;50;;l;" & "io;n;y;2;"
                    gridAttributes = gridAttributes & "|��Ʈ;PartCode;50;;l;" & "io;n;y;2"
                    gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;y;2;"
                    gridAttributes = gridAttributes & "|�ڳ�;CornerCode;50;;l;" & "io;n;y;2;"

                    gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;����� ��"

                Case "3"
                    gridAttributes = gridAttributes & "|����;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|����;BranchCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|��;TeamCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|��Ʈ;PartCode;50;;l;" & "io;n;y;2"
                    gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;y;2;"
                    gridAttributes = gridAttributes & "|�ڳ�;CornerCode;50;;l;" & "io;n;y;2;"

                    gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;����� ��"
                    gridCodeNameList = gridCodeNameList & "/BranchCode;���� ���� ��,����"
                Case "4"
                    gridAttributes = gridAttributes & "|����;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|����;BranchCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|��;TeamCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|��Ʈ;PartCode;50;;l;" & "io;n;n;2"
                    gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;y;2;"
                    gridAttributes = gridAttributes & "|�ڳ�;CornerCode;50;;l;" & "io;n;y;2;"

                    gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;����� ��"
                    gridCodeNameList = gridCodeNameList & "/BranchCode;���� ���� ��,����"
                    gridCodeNameList = gridCodeNameList & "/TeamCode;���� �� ��,����,����"
                Case "5"
                    gridAttributes = gridAttributes & "|����;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|����;BranchCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|��;TeamCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|��Ʈ;PartCode;50;;l;" & "io;n;n;2"
                    gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|�ڳ�;CornerCode;50;;l;" & "io;n;y;2;"

                    gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;����� ��"
                    gridCodeNameList = gridCodeNameList & "/BranchCode;���� ���� ��,����"
                    gridCodeNameList = gridCodeNameList & "/TeamCode;���� �� ��,����,����"
                    gridCodeNameList = gridCodeNameList & "/PartCode;���� ��Ʈ ��,����,����,��"
                Case "6"
                    gridAttributes = gridAttributes & "|����;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|����;BranchCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|��;TeamCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|��Ʈ;PartCode;50;;l;" & "io;n;n;2"
                    gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;n;2;"
                    gridAttributes = gridAttributes & "|�ڳ�;CornerCode;50;;l;" & "io;n;n;2;"

                    gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;����� ��"
                    gridCodeNameList = gridCodeNameList & "/BranchCode;���� ���� ��,����"
                    gridCodeNameList = gridCodeNameList & "/TeamCode;���� �� ��,����,����"
                    gridCodeNameList = gridCodeNameList & "/PartCode;���� ��Ʈ ��,����,����,��"
                    gridCodeNameList = gridCodeNameList & "/PCCode;���� PC ��,����,����,��,��Ʈ"
                Case Else
                    gridCodeNameList = ""
            End Select

            gridAttributes = gridAttributes & "|������;CodeName;100;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|���� ����;LastYesOrNo;100;;c;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|��� ����;PrivateUseYesOrNo;100;;c;" & "io;n;n;100;"

            'gridCodeNameList = gridCodeNameList & "BusinessPlaceCode;����� ��"
            'grd_1.Clear(C1.Win.C1FlexGrid.Classic.ClearWhereSettings.flexClearSelection)
            'grd_1.Clear(C1.Win.C1FlexGrid.Classic.ClearWhereSettings.flexClearEverywhere)

            Debug.Print("��" & gridAttributes)
            Debug.Print("�޺�" & gridCodeNameList)

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '-- copy �� �ٿ� �ֱ� ���
            'grd_1.AutoClipboard = True

            mBolInit = True

            'grd_1.ColumnCollection("BusinessPlaceCode").AllowEditing = False
            'grd_1.ColumnCollection("BranchCode").AllowEditing = False
            'grd_1.ColumnCollection("TeamCode").AllowEditing = False
            'grd_1.ColumnCollection("PartCode").AllowEditing = False
            'grd_1.ColumnCollection("PCCode").AllowEditing = False
            'grd_1.ColumnCollection("CornerCode").AllowEditing = False

            'Select Case strLevel
            '    Case "1"
            '        grd_1.ColumnCollection("BusinessPlaceCode").AllowEditing = True
            '    Case "2"
            '        grd_1.ColumnCollection("BranchCode").AllowEditing = True
            '    Case "3"
            '        grd_1.ColumnCollection("TeamCode").AllowEditing = True
            '    Case "4"
            '        grd_1.ColumnCollection("PartCode").AllowEditing = True
            '    Case "5"
            '        grd_1.ColumnCollection("PCCode").AllowEditing = True
            '    Case "6"
            '        grd_1.ColumnCollection("CornerCode").AllowEditing = True
            'End Select

            '--------------------------------------------------
        End Sub

        Private Sub txtManagementTrustName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub


        Private Sub OrganizationCodeInitialize()
            '' �ͼ� ���� ���п� ���� ���� �ڵ� �׸��� ���� �Ѵ�.
            Dim blnBusinessPlaceCode As Boolean = False '���� �ڵ�
            Dim blnBranchCode As Boolean = False '�� �ڵ�
            Dim blnTeamCode As Boolean = False '�� �ڵ�
            Dim blnPartCode As Boolean = False '��Ʈ �ڵ�
            Dim blnPCCode As Boolean = False 'PC �ڵ�
            Dim blnCornerCode As Boolean = False '�ڳ� �ڵ�

            'If Len(cboReversionDivisionCode.TextValue) > 0 Then
            If cboOrganizationLevel.TextValue >= "1" Then blnBusinessPlaceCode = True '���� �ڵ�  
            If cboOrganizationLevel.TextValue >= "2" Then blnBranchCode = True '�� �ڵ�
            If cboOrganizationLevel.TextValue >= "3" Then blnTeamCode = True '�� �ڵ�
            If cboOrganizationLevel.TextValue >= "4" Then blnPartCode = True '��Ʈ �ڵ�
            If cboOrganizationLevel.TextValue >= "5" Then blnPCCode = True 'PC �ڵ�
            If cboOrganizationLevel.TextValue >= "6" Then blnCornerCode = True '�ڳ� �ڵ�

            '���� �ڵ� ��Ʈ�� Visible ����
            'lblBusinessPlaceCode.Visible = blnBusinessPlaceCode '���� �ڵ�  
            lblBranchCode.Visible = blnBranchCode '�� �ڵ�    
            lblTeamCode.Visible = blnTeamCode '�� �ڵ�    
            lblPartCode.Visible = blnPartCode '��Ʈ �ڵ�  
            lblPCCode.Visible = blnPCCode 'PC �ڵ�    
            lblCornerCode.Visible = blnCornerCode '�ڳ� �ڵ�  
            'cboBusinessPlaceCode.Visible = blnBusinessPlaceCode '���� �ڵ�  
            cboBranchCode.Visible = blnBranchCode '�� �ڵ�    
            cboTeamCode.Visible = blnTeamCode '�� �ڵ�    
            cboPartCode.Visible = blnPartCode '��Ʈ �ڵ�  
            cboPCCode.Visible = blnPCCode 'PC �ڵ�    
            cboCornerCode.Visible = blnCornerCode '�ڳ� �ڵ�  
            'End If
        End Sub
        
        Private Sub cboOrganizationLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOrganizationLevel.SelectedIndexChanged
            '-- ��ȸ �޺� ����
            Call OrganizationCodeInitialize()


            '-- �׸��� �� ����
            '-- 
            If mBolInit = True Then
                Call Initialize()
            End If

        End Sub
    End Class

End Namespace
