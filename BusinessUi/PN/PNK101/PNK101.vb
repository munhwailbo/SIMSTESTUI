'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ������ ����
' form ���� : 
' �ۼ��� : �赿��
' �ۼ��� : 2009-05-27
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

    Public Class PNK101
        Inherits CommonControls.UiControl
        Private Sub PNK101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            'If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
            Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
            'Me.MinimumSize = New System.Drawing.Size(811, 647)

            ' End If

        End Sub

        Public Sub Initialize()
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|����;kNo;50;;r;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|������;BranchName;50;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|��������;DelChk;50;;c;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|���ڸ�;ReaderName;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ���;ReaderHp;80;;l;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;ReaderTel1;80;;l;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;ReaderTel2;80;;l;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|�ּ�1;ReaderAddress1;100;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�ּ�2;ReaderAddress2;100;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|���Ժμ�;ThrowNo;50;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�������;RegDate;80;;l;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;l;" & "o;n;n;7;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            'Me.grd_1.ExplorerBar = 3
            'With Me.grd_1
            '    If .Rows > 1 Then
            '        .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse

            '        Select Case .ColSel
            '            Case .get_ColIndex("kNo")
            '                .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone

            '        End Select

            '    End If
            'End With
        End Sub

        Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
            With Me.grd_1
                If .Rows > 1 Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse

                    Select Case .ColSel
                        Case .get_ColIndex("kNo")
                            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone

                    End Select

                End If
            End With
        End Sub




       
    End Class

End Namespace
