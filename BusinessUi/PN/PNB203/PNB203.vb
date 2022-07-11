'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���̺� ��� ���
' form ���� : ���̺� ����� ��� �Ѵ�.
' �ۼ��� : �ݿ�ö
' �ۼ��� : 2008-09-19
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


Imports System.IO

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB203
        Inherits CommonControls.UiControl

        ' ���ø� ���� ��� ����
        Public strFilePath As String = ""

        ' ���� ��� ����
        Public strSaveFilePath As String = ""

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;c;" & "o;n;n;5;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ֹι�ȣ;SocialNum;90;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����� ��;Name;70;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��üȽ��;ChangeNum;60;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�������;ContractDt;60;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|����������;ContractStDt;80;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�����������;ContractEdDt;80;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�����������;ContractCancelDt;80;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|������ֹι�ȣ;SocialNum;90;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|����� ��;Name;70;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|������ֹι�ȣ;SocialNum;90;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|����� ��;Name;70;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|��ȣ;CorparationNm;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|����;BusiType;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|����;BusiStatus;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|������ȣ;BranchNum;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;c;" & "o;n;n;5;"       '(10)
            'gridAttributes = gridAttributes & "|������;BranchNm;150;;c;" & "o;n;n;7;"
            'gridAttributes = gridAttributes & "|���� ��;BranchNm;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|��üȽ��;ChangeNum;60;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|�������;ContractDt;60;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|����������;ContractStDt;80;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|�����������;ContractEdDt;80;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|�����������;ContractCancelDt;80;;c;" & "o;n;n;40;"


            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 3

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;70;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;Orders;50;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����������ݱ����ڵ�;DepositDivCd;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�Ա�����;ReceiptDt;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;AccountCd;70;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����ݱݾ�;DepositAmt;70;#,###;r;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|������;PayYYYYMM;80;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;dumi;80;;l;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "ParType;�÷� Ÿ�� ��"
            gridCodeNameList = gridCodeNameList & "DepositDivCd;�����������ݱ����ڵ�"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 1

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

        End Sub

#Region "�˾� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : popSystemID
        ''' ��  �� : �˾� Where�� �߰� 
        ''' �ۼ��� : Ȳ����
        ''' �ۼ��� : 2007-10-08
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub popSystemID_ButtonClick()
            'Me.popSystemID.Tag = ""
            Dim strProjectID As String = ""
            'If Me.popProjectID.NameText = "" Then
            '    strProjectID = "code(�ý��� ��);where(ProjectID like '%' + '" & Me.popProjectID.TextValue & "');"
            'Else
            '    strProjectID = "code(�ý��� ��);where(ProjectID='" & Me.popProjectID.TextValue & "0');"
            'End If

            'Me.popSystemID.Tag = strProjectID
            'MsgBox(strContractorIDTag)
        End Sub
#End Region

        Private Sub PNB203_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub


#Region "���ø� ��� ����"
        'Private Sub btnTampletFilePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '    Dim FolderPath As New FolderBrowserDialog
        '    FolderPath.ShowNewFolderButton = True

        '    Dim result As DialogResult = FolderPath.ShowDialog()

        '    If result = DialogResult.OK Then
        '        'Me.lblTemplatePath.Text = " ���� ���: " + FolderPath.SelectedPath
        '        strFilePath = FolderPath.SelectedPath

        '        Dim intTempCount As Integer = 0
        '        Dim temp() As String = System.IO.Directory.GetFiles(FolderPath.SelectedPath & "\")

        '        If temp.Length > 0 Then
        '            For inti As Integer = 0 To temp.Length - 1
        '                If temp(inti) = strFilePath & "\���̺���.xls" Then
        '                    intTempCount = intTempCount + 1
        '                    Exit Sub
        '                End If
        '            Next
        '            MessageBox.Show("������ ��� �ȿ� ��� ���ø� ������ �����ϴ� ������ ��� �����ϼ��� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Me.GetTempletPath()
        '            Exit Sub
        '        End If
        '    End If

        'End Sub
#End Region

#Region "���� ��� ����"
        'Private Sub btnSavePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '    Dim FolderPath As New FolderBrowserDialog
        '    FolderPath.ShowNewFolderButton = True

        '    Dim result As DialogResult = FolderPath.ShowDialog()
        '    If result = DialogResult.OK Then

        '        Me.strSaveFilePath = FolderPath.SelectedPath
        '        'Me.lblSavePath.Text = " ���� ���: " + strSaveFilePath

        '    End If
        'End Sub
#End Region



        Dim intJJ As Integer

        Dim strProjectName As String = "" '������Ʈ ��
        Dim strSystemName As String = "" '�ý��� ��
        Dim strUnitSystemName As String = "" '���� �ý��� ��
        Dim strTodate As String = "" '���� ��¥


#Region "���̺� ��� ��������"


#End Region

        Private Sub grd_2_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

            With Me.grd_2
                If .Rows > 1 Then
                    .Editable = Classic.EditableSettings.flexEDKbdMouse

                    Select Case .ColSel
                        Case .get_ColIndex("BranchNum")
                            .Editable = Classic.EditableSettings.flexEDNone
                        Case .get_ColIndex("Orders")
                            .Editable = Classic.EditableSettings.flexEDNone
                        Case Else
                            .Editable = Classic.EditableSettings.flexEDKbdMouse
                    End Select
                    'End If
                End If

            End With

        End Sub
    End Class

End Namespace

