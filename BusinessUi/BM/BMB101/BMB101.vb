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

Namespace ubiLease.UI.BusinessUi.BM

    Public Class BMB101
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
            gridAttributes = gridAttributes & "|���γ��;MutualYearMonth;1253;####-##;l;" & "io;y;n;5;"

            gridAttributes = gridAttributes & "|�μ�;DeptNm;1253;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�����;ChargeEmpNumNm;1253;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|������ �ڵ�;BranchChiefCd;1253;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|������ ��;BranchChiefCdName;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��󿩺�;SubjectYON;1253;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|����;Orders;1253;;l;" & "o;y;y;5;"

            gridAttributes = gridAttributes & "|����ȸ��;MutualSocietyDues;1253;#,##0;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���ο���;MutualYesOrNo;1253;#,##0;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���αݾ�;MutualAmount;1253;#,##0;r;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|���������ڵ�;MutualBranchCode;3000;;l;" & "o;n;y;200;�����ڵ�;MutualBranchCodeName"
            gridAttributes = gridAttributes & "|����������;MutualBranchCodeName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|�������;SideJobBranchName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|����;Note;150;;l;" & "io;n;n;10;"

            gridAttributes = gridAttributes & "|��������;JoinDate;80;####-##-##;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ż������;SecessionDate;80;####-##-##;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ż�𿩺�;SecessionYON;50;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�űԱ���;NewGubn;80;;l;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|;Dumi;80;;l;" & "o;n;n"
                'grid code combo
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
                '--------------------------------------------------
        End Sub
#End Region

#Region "�� �̺�Ʈ"

        Private Sub BMB101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                        Case .get_ColIndex("MutualYearMonth")
                            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    End Select

                    'If .GetCurrentRowCellValue("Orders") <> "" Then
                    '    Select Case .ColSel
                    '        Case .get_ColIndex("MutualBranchCode")
                    '            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    '    End Select
                    'End If
                End If
            End With
        End Sub
    End Class

End Namespace
