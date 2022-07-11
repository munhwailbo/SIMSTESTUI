' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���곻�����
' form ���� : ���곻�����.
' �ۼ��� : Ȳ����
' �ۼ��� : 2008-09-17
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI102
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"

        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ���ϰ� : 
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()
            'VSFlexGrid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|������;CalYearMonths;80;####-##;c;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|����;Orders;50;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;c;" & "o;n;n;6;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;140;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|��������;CalDt;80;####-##-##;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|����ݾ�;SalesAmt;100;#,##0;r;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|�����ݾ�;DeductAmt;100;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���;Note;120;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|�ű�;NewGubn;120;;l;" & "o;n;y;6;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)

            'VSFlexGrid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������;CalYearMonths;80;####-##;c;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|����;Orders;50;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;c;" & "io;n;n;6;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;90;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|�������;CalOrders;50;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|�����׸��ڵ�;CalItemCd;100;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|����ݾ�;CalAmt;120;#,##0;r;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|���;Note;120;;l;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|�ý��۱���;SystemGubn;100;;l;" & "io;n;n;5;"

            'grid code combo
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "CalItemCd;�����׸��ڵ�"
            Me.grd_2.Initialize(gridAttributes, gridCodeNameList)

        End Sub

#End Region

#Region "�� �̺�Ʈ"
        Private Sub PNI102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Me.DesignMode = False Then ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill  ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
            End If
        End Sub

        'Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
        '    With Me.grd_1
        '        If .Rows > 1 Then
        '            If .GetCurrentRowCellValue("NewGubn") <> "" Then
        '                Me.dtpCalYearMonths_2.TextValue = Me.grd_1.GetCurrentRowCellValue("CalYearMonths")
        '                Me.popBranchNum.TextValue = Me.grd_1.GetCurrentRowCellValue("BranchNum")
        '                Me.txtOrders.TextValue = Me.grd_1.GetCurrentRowCellValue("Orders")
        '            End If
        '        End If
        '    End With
        'End Sub
#End Region

        'Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

        '    With Me.grd_2
        '        If .Rows > 1 Then
        '            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
        '            Select Case .ColSel
        '                Case .get_ColIndex("CalYearMonths")
        '                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
        '                Case .get_ColIndex("Orders")
        '                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
        '                Case .get_ColIndex("BranchNum")
        '                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
        '            End Select
        '        End If
        '    End With

        'End Sub

    End Class

End Namespace
