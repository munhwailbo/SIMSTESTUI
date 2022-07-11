'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : SP ��� ���
' form ���� : SP ��� ��� �Ѵ�.
' �ۼ��� : Ȳ����
' �ۼ��� : 2007-07-12
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB105
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
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "o;n;y;;;"
            gridAttributes = gridAttributes & "|����;TreePath;121;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���ڵ�;DeptCd;108;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�� ��;DeptNm;108;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��� ��;ChargeEmpNm;108;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;0;;4;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;76;;4;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;0;;4;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������;BranchNm;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;62;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��������;BranchRegionNm;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����;ContractDt;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������;ContractTerm;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������;RentDepositAmt;62;#,##0;7;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������ݾ�;RentAmt;74;#,##0;7;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ΰ�����;RentVat;62;#,##0;7;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�Ұ�;RentAmtTot;85;#,##0;7;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���������޾�;LastMonthDeptAmt;109;#,##0;7;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;ReserveRentMonAmt;135;#,##0;7;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ǹ���;OwnerNm;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ּ�;Addr;62;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ;OwnerPhoneNum;62;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����;BankCd;62;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;62;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;62;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|ä��Ȯ��;Obligation;62;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���;Note;62;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;dumi;150;;1;" & "o;n;n;30;"

       
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "BankCd;�����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3

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

        Private Sub PNB105_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                ''Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        ' �׸��� Key Lock

        Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'Me.grd_2.Editable = EditableSettings.flexEDKbdMouse

            'If Me.grd_2.Rows > 1 Then
            '    With Me.grd_2
            '        Select Case .ColSel
            '            Case .get_ColIndex("Seq")
            '                .Editable = EditableSettings.flexEDNone
            '            Case .get_ColIndex("ProjectID")
            '                .Editable = EditableSettings.flexEDNone
            '            Case Else
            '                .Editable = EditableSettings.flexEDKbdMouse
            '        End Select
            '    End With
            'End If
        End Sub

        'Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    'SaveData()
        'End Sub

     
    End Class

End Namespace

