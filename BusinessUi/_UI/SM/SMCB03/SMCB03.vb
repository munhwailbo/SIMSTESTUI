'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ����ں� �������� ���
' form ���� : ����ں� ���������� ��ȸ, �߰�, ����, �����Ѵ�. 
' �ۼ��� : ������
' �ۼ��� : 2006-08-30
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

    Public Class SMCB03
        Inherits CommonControls.UiControl

        Private tmpOrganizationCode As String = ""
#Region "�� �ʱ�ȭ"
        ''' <summary>
        ''' �Լ��� : Initialize 
        ''' ��  �� : �׸��� �ʱ�ȭ 
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-09-02
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code    

            gridAttributes = gridAttributes & "||����;����;40;;c;" & "o;n;y;"
            gridAttributes = gridAttributes & "|���� �ڵ�;RoleCode;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;300;;l;" & "o;n;n;6;��� ��;EmployeeNameHangul"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;100;;c;" & "io;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "RoleCode;�� �ڵ� ��"


            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code    
            gridAttributes = gridAttributes & "||����;����;40;;c;" & "io;n;n;"
            gridAttributes = gridAttributes & "|���� �ڵ�;RoleCode;300;;l;" & "io;n;n;5;�� �ڵ� ��;RoleName"
            gridAttributes = gridAttributes & "|���� ��;RoleName;300;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;300;;l;" & "io;n;y;6;��� ��;EmployeeNameHangul"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;100;;c;" & "o;n;y;30;"

            gridAttributes = gridAttributes & "|���� �ڵ�;OrganizationCode;300;;l;" & "o;n;n;5;�μ� ��;CodeName"
            gridAttributes = gridAttributes & "|���� ��;CodeName;300;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�ڵ� ���� �ڵ�;CodeDivisionCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|�ڵ� �Ӽ� �ڵ�;CodeAttributeCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|���� ���� ����;LastYesOrNo;300;;l;" & "o;n;y;;"

            gridAttributes = gridAttributes & "|����� �ڵ�;BusinessPlaceCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|���� �ڵ�;BranchCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|�� �ڵ�;TeamCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|��Ʈ �ڵ�;PartCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|PC �ڵ�;PCCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|�ڳ� �ڵ�;CornerCode;300;;l;" & "o;n;y;3;"
            gridAttributes = gridAttributes & "|�ű� ����;IsExist;300;;l;" & "o;n;y;3;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "RoleCode;�� �ڵ� ��;"

            grd_2.Initialize(gridAttributes, gridCodeNameList)

        End Sub
#End Region

#Region "�� �̺�Ʈ"

        Private Sub SaveBreak()
            ' 1. ���� üũ�� �� ���̴�.
            ' 2. DB ������ �ǳ� �ٰ� �ʹ�.
            ' 3. �׸��� �� ��ȸ�� ���� �ʹ�.

            Me.GLogicCheckPassYesOrNo = True ' �������� ����
            Me.GmainExecuteDbCommand.GerrorNumber = 1
            Me.GmainExecuteDbCommand.GerrorDescription = " ����ȸ�� �����ϴ�."

        End Sub


        ''' <summary>
        ''' �Լ��� : grd_1_BeforeSelChange 
        ''' ��  �� : �׸��� ���� 
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-09-02
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_1_BeforeSelChange(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles grd_1.BeforeSelChange
            'Dim isNoneSaveDataExist As Boolean = False

            'If Me.grd_2.Rows > 0 And Me.grd_2.get_ColKey(1) = "����" Then
            '    For i As Integer = 1 To grd_2.BottomRow Step 1
            '        If grd_2.GetCellCheck(i, 1) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
            '            isNoneSaveDataExist = True
            '        End If
            '    Next
            'End If

            'If Me.grd_1.Rows > 1 And Me.grd_1.RowSel > 0 Then
            '    If isNoneSaveDataExist = False Then
            '        'Me.RequestData_2(True)
            '    Else
            '        MsgBox("������� ���� �����Ͱ� �����մϴ�." & Environment.NewLine & "���� �� �ٽ� �ϼ���")
            '        e.Cancel = True
            '    End If
            'End If
        End Sub
        ''' <summary>
        ''' �Լ��� : grd_2_LostFocus 
        ''' ��  �� : �׸��� ��Ŀ�� �̵��� ������ �̺�Ʈ 
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-09-02
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
            'If grd_2.Rows > 1 Then
            '    If grd_2.get_ColKey(grd_2.CursorCell.c1) = "OrganizationCode" Then
            '        tmpOrganizationCode = ""
            '        tmpOrganizationCode = grd_2.get_TextMatrix(grd_2.CursorCell.r1, grd_2.CursorCell.c1)
            '    End If
            'End If

        End Sub
        ''' <summary>
        ''' �Լ��� : grd_2_EnterCell 
        ''' ��  �� : Key Lock
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-09-02
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs)

            With Me.grd_2
                .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                If .get_TextMatrix(.RowSel, .get_ColIndex("IsExist")) = "U" Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                Else
                    If .ColSel = .get_ColIndex("RoleCode") Then
                        .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    Else
                        .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
                    End If
                End If
            End With
        End Sub
#End Region

        
        Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AsystemDivisionCode", Me.cboBizGubun.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("EmployeeNumber")))
            End With

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMCB03_3_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            Dim intII As Integer
            For intII = 1 To grd_2.Rows - grd_2.FixedRows
                Me.grd_2.set_TextMatrix(intII, 0, "�ű�")
                Me.grd_2.SetCellCheck(intII, Me.grd_2.get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
            Next
        End Sub
    End Class

End Namespace
