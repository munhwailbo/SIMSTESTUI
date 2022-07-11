'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���� ���� ���
' form ���� : ���� ������ ��ȸ, �߰�, ����, �����Ѵ�.			
' �ۼ��� : Ȳ����
' �ۼ��� : 2007-06-15
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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDB04
        Inherits CommonControls.UiControl
        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code    

            gridAttributes = gridAttributes & "||����;����;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���� ����;BusinessLogDate;80;####-##-##;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;Orders;80;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|���� �ڵ�;OnesPositionDepartmentCode;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|����;CodeName;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;LogTitle;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;BusinessLogContent;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|������;ProgressRate;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�۾��ð�(��);WorkTime;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���;Remark;150;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber_2;80;;l;" & "o;n;y;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '----------------------------------------------------------------------------------------------------
            Me.grd_1.AutoSizeRows()

            Me.grd_1.RowHeightMin = 18
            Me.grd_1.RowHeightMax = 100

            Me.grd_1.AutoResize = True
            Me.grd_1.AllowEditing = True
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both

            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeBoth
            '----------------------------------------------------------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            'Me.popEmployee.TextValue = GmainBusinessFunction.GetValue("�α��� ID")
            DateInit()

        End Sub

        '====================================================================================================
        Public Sub DateInit()
            '�⺻ ��¥ ����
            'Dim currentDateFrom As String = ""
            'Dim currentDateTo As String = ""
            'currentDateTo = Date.Today
            'currentDateFrom = currentDateTo.Substring(0, 8) + "01"
            'Date.Today.AddDays(-6)
            Me.dtpBusinessDateFrom.TextValue = Date.Today  'Date.Today.AddDays(-6)
            Me.dtpBusinessDateFrom.TextValue = Me.dtpBusinessDateFrom.TextValue.ToString.Substring(0, 6) & "01"
            Me.dtpBusinessDateTo.TextValue = Date.Today
        End Sub

        Private Sub SMDB04_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        ' Leave �̺�Ʈ�� TextValue OR Text ���� ���� ���� �Ѿ�Ƿ�... ������ �޾� �ѱ� ��... ¥��
        Public strBusinessLogDate As String = "" '�������ڸ� ���� ����
        Public strEmployeeNumber As String = "" '��� ��ȣ�� ���� ����
        Public strDivisionReques As String = "1" '�̺�Ʈ�� ��ȸ���� ��ȸ ��ư Ŭ���� ��ȸ���� ����


        Private Sub grd_1_EnterCell_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            With Me.grd_1
                .Editable = EditableSettings.flexEDNone
                If .Rows > 1 Then
                    Select Case .ColSel
                        Case .get_ColIndex("����")
                            .Editable = EditableSettings.flexEDKbdMouse
                    End Select
                End If
            End With

        End Sub

    End Class

End Namespace
