'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ����ȸ ȸ�� ����
' form ���� : ����ȸ ȸ�� ����
' �ۼ��� : Ȳ����
' �ۼ��� : 2009.07.06
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

Namespace ubiLease.UI.BusinessUi.BM

    Public Class BMA102
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"
        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����;ChargeEmpNumNm;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ �ڵ�;BranchChiefCd;1253;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|������ ��;BranchChiefCdName;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ֹι�ȣ;SocialNum;3000;######-#######;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|����;Orders;1253;;l;" & "io;y;y;5;"
            gridAttributes = gridAttributes & "|��������;JoinDate;3000;####-##-##;l;" & "io;y;n;30;"
            gridAttributes = gridAttributes & "|Ż������;SecessionDate;1253;####-##-##;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|Ż�𿩺�;SecessionYON;1253;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���������ڵ�;MutualBranchCode;3000;;l;" & "io;y;n;200;�����ڵ�;MutualBranchCodeName"
            gridAttributes = gridAttributes & "|����������;MutualBranchCodeName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|�������;SideJobBranchName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|����;Note;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ;PhoneNum;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|�ڵ���;MobileNum;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|�ּ�;Address;3000;;l;" & "o;n;n;200;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "JoinStateCode;����ȸ ���Ի���"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '--------------------------------------------------

            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|�����;ChargeEmpNumNm;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ �ڵ�;BranchChiefCd;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ ��;BranchChiefCdName;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ֹι�ȣ;SocialNum;3000;######-#######;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|����;Orders;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��������;JoinDate;3000;####-##-##;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ż������;SecessionDate;1253;####-##-##;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ż�𿩺�;SecessionYON;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���������ڵ�;MutualBranchCode;3000;;l;" & "o;n;n;200;�����ڵ�;MutualBranchCodeName"
            gridAttributes = gridAttributes & "|����������;MutualBranchCodeName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|�������;SideJobBranchName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|����;Note;1358;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ;PhoneNum;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|�ڵ���;MobileNum;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|�ּ�;Address;3000;;l;" & "o;n;n;200;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "JoinStateCode;����ȸ ���Ի���"

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '--------------------------------------------------
        End Sub
#End Region

#Region "�� �̺�Ʈ"

        Private Sub BMA102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Dock = DockStyle.Fill
        End Sub


        ''' <summary>
        ''' �Լ��� : grd1_KeyDownEdit
        ''' ��  �� : �׸����� ENTERŰ ó��
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd1_KeyDownEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.KeyEditEventArgs) Handles grd_1.KeyDownEdit

            Dim ColCount As Integer
            'Dim StartofCols As Integer

            '*** �ʱⰪ ���� **************
            'StartofCols = ucTY_INOUT
            '******************************

            'EnterŰ ó��(���� �÷����� �Ѿ, ReadOnly���� �ڵ���ŵ)
            If e.KeyCode = Keys.Enter Then
                With grd_1
                    ColCount = e.Col
                    If ColCount = .ColumnCollection.Count - 1 Then
                        .AddRow()
                        .Row = e.Row + 1
                        ColCount = 1
                    End If
                    ColCount = ColCount + 1
                    .Col = ColCount
                End With
            End If
        End Sub
#End Region

        Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
            With Me.grd_1
                If .Rows > 1 Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
                    Select Case .ColSel
                        Case .get_ColIndex("BranchChiefCd")
                            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    End Select
                End If
            End With
        End Sub
    End Class

End Namespace
