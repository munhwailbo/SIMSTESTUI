'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �ڵ����
' form ���� : ��ȭ���� �ڵ� ����
' �ۼ��� : �����
' �ۼ��� : 2006-04-06
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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMCA03
        Inherits CommonControls.UiControl

        Private Sub SMCA03_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "0;2;1"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���α׷� ID;ProgramID;1253;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|���α׷� ��;ProgramName;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|M1;Level1;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|M2;Level2;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|M3;Level3;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|M4;Level4;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|���� ����;MenuStandInRowOrder;3000;;l;" & "io;n;n;200;"
            gridAttributes = gridAttributes & "|���� ����;LastYesOrNo;1253;;l;" & "io;n;n;0;"
            gridAttributes = gridAttributes & "|��� ����;PrivateUseYesOrNo;1253;;l;" & "io;n;n;0;"
            gridAttributes = gridAttributes & "|�ý��� ���� ��;SystemDivision;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���α׷� ����;ProgramExplanation;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ű� ����;IsExist;1253;;l;" & "o;n;y;0;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SystemDivision;�ý��� ���� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            grd_1.ExplorerBar = 3

        End Sub
        '====================================================================================================
        'Ư�� Cell�� ������ ���� Grid�� ���� �����ϰ� �Ѵ�.
        '====================================================================================================
        Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
            With grd_1
                .Editable = False
                Select Case .ColSel
                    Case .get_ColIndex("ProgramID")
                        If .Cell(CellPropertySettings.flexcpText, .RowSel, .get_ColIndex("IsExist")) = "U" Then
                            .Editable = False
                        Else
                            .Editable = True
                        End If

                    Case Else
                        .Editable = True
                End Select
            End With
        End Sub

        'Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
        '    If grd_1.Row <> 0 And grd_1.Col <> 0 Then
        '        RequestData_2()
        '    End If
        'End Sub

        '' �׸����� ENTERŰ ó��
        'Private Sub grd1_KeyDownEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.KeyEditEventArgs) Handles grd_1.KeyDownEdit

        '    Dim ColCount As Integer
        '    'Dim StartofCols As Integer

        '    '*** �ʱⰪ ���� **************
        '    'StartofCols = ucTY_INOUT
        '    '******************************

        '    'EnterŰ ó��(���� �÷����� �Ѿ, ReadOnly���� �ڵ���ŵ)
        '    If e.KeyCode = Keys.Enter Then
        '        With grd_1

        '            ColCount = e.Col**
        '            If ColCount = .ColumnCollection.Count - 1 Then
        '                .AddRow()
        '                .Row = e.Row + 1
        '                ColCount = 1
        '            End If

        '            ColCount = ColCount + 1
        '            .Col = ColCount

        '            '  SendKeys.Send("{F2}")
        '        End With
        '    End If
        'End Sub

        '' �׸����� ENTERŰ ó��
        'Private Sub grd2_KeyDownEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.KeyEditEventArgs)

        '    Dim ColCount As Integer
        '    'Dim StartofCols As Integer

        '    '*** �ʱⰪ ���� **************
        '    'StartofCols = ucTY_INOUT
        '    '******************************

        '    'EnterŰ ó��(���� �÷����� �Ѿ, ReadOnly���� �ڵ���ŵ)
        '    If e.KeyCode = Keys.Enter Then
        '        With grd_2

        '            ColCount = e.Col
        '            If ColCount = .ColumnCollection.Count - 1 Then
        '                .AddRow()
        '                .Row = e.Row + 1
        '                ColCount = 1
        '            End If

        '            ColCount = ColCount + 1
        '            .Col = ColCount

        '            '  SendKeys.Send("{F2}")
        '        End With
        '    End If
        'End Sub
    End Class

End Namespace
