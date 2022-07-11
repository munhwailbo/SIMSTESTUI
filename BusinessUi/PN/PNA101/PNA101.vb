'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �ڵ����
' form ���� : ��ȭ�Ϻ� �ڵ� ����
' �ۼ��� : ������
' �ۼ��� : 2008.09.01
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

    Public Class PNA101
        Inherits CommonControls.UiControl

        Private Sub PNA101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

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
            gridAttributes = gridAttributes & "|�ڵ� ����;CodeDivision_2;1253;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|�ڵ� ���� �ѱ� ��;CodeDivisionHangulName_2;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ� ���� ���� ��;CodeDivisionReasonName;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ� ���� ����;CodeDivisionExplanation;3000;;l;" & "io;n;n;200;"
            gridAttributes = gridAttributes & "|��� ����;PrivateUseYesOrNo;1253;;l;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|��� 1;Note1;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��� 2;Note2;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��� 3;Note3;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��� 4;Note4;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��� �ڵ�;CodeList;1358;;l;" & "o;n;n;10;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '--------------------------------------------------

            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�ڵ�;Code;1000;;c;" & "io;y;y;5;"
            gridAttributes = gridAttributes & "|�ڵ�;Code_2;1000;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|�ڵ� �ѱ� ��;CodeHangulName;2415;;l;" & "io;y;n;20;"
            gridAttributes = gridAttributes & "|�ڵ� ���� ��;CodeReasonName;3000;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|�ڵ� ����;CodeExplanation;3000;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|��� 1;Note1;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��� 2;Note2;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��� 3;Note3;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��� 4;Note4;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��� ����;PrivateUseYesOrNo;1358;;l;" & "io;n;n;10;"

            'grid code combo
            gridCodeNameList = ""
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3
            '--------------------------------------------------
        End Sub
#End Region

#Region "�� �̺�Ʈ"

        ''' <summary>
        ''' �Լ��� : grd_1_Click
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
            If grd_1.Row <> 0 And grd_1.Col <> 0 Then
                Me.RequestData_2()
            End If
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

                    '  SendKeys.Send("{F2}")
                End With
            End If
        End Sub
        ''' <summary>
        ''' �Լ��� : grd2_KeyDownEdit
        ''' ��  �� : �׸����� ENTERŰ ó��
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd2_KeyDownEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.KeyEditEventArgs) Handles grd_2.KeyDownEdit

            Dim ColCount As Integer
            'Dim StartofCols As Integer

            '*** �ʱⰪ ���� **************
            'StartofCols = ucTY_INOUT
            '******************************

            'EnterŰ ó��(���� �÷����� �Ѿ, ReadOnly���� �ڵ���ŵ)
            If e.KeyCode = Keys.Enter Then
                With grd_2

                    ColCount = e.Col
                    If ColCount = .ColumnCollection.Count - 1 Then
                        .AddRow()
                        .Row = e.Row + 1
                        ColCount = 1
                    End If

                    ColCount = ColCount + 1
                    .Col = ColCount

                    '  SendKeys.Send("{F2}")
                End With
            End If
        End Sub
#End Region

        'Private Sub grd_1_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '    MsgBox(grd_1.GetData(e.Row, e.Col), MsgBoxStyle.Information, "")
        'End Sub
    End Class

End Namespace
