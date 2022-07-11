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

    Public Class PNC301
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
            gridAttributes = gridAttributes & "|���� �ڵ�;ReaderCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���� ��;ReaderNm;90;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;70;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ڵ��� ��ȣ;MobileNum;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�ſ����ȣ;NewPostNum;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ּ�;NewAddr1;90;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�Ż��ּ�;NewAddr2;70;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�� �����ȣ;OldPostNum;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr1;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����ּ�;OldAddr2;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����ڵ�;SubscribeCd;60;;l;" & "o;n;y;5;"


            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1


            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|��������;ReceiptDt;70;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;Orders;50;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����ð�;ReceiptTime;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;SubscribeCd;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ο������ڵ�;DivCd;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���ڸ���;ReaderNmNote;90;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ���;PhoneNumNote;90;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ּҺ��;AddrNote;90;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|��������;BranchNmNote;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�θ�;DeptNm;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;Content;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����뺸�ڵ�;ResultInformCd;80;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|ó�����;ResultNote;70;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�����ó���ھ��̵�;MonitoringEmpNum;100;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�����ó������;MonitoringProcDt;70;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|��������ڵ�;IngStateCd;80;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|;dumi;80;;l;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "ParType;�÷� Ÿ�� ��"

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 1

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

        End Sub


#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : ACA003_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ACA003_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnPRB002_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRB002.Click

            'If Me.txtChiefCd.Text.Replace(" ", "") = "" Then
            '    GrecordProcessMode = "1"
            'Else
            '    GrecordProcessMode = "2"
            'End If
            Dim sDateTime As String
            sDateTime = Format(Now, "HH:MM:ss")
            Dim sSubscribe As String
            sSubscribe = grd_1.GetCurrentRowCellValue("SubscribeCd")

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue.Replace("-", "").Substring(0, 8))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(IsNumeric(Me.grd_2.GetCurrentRowCellValue("Orders")) = False, 0, Me.grd_2.GetCurrentRowCellValue("Orders")))
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptTime", Me.dtpReceiptDt.Text) 'Me.cboBusinessPlaceCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptTime", sDateTime) 'Me.cboBusinessPlaceCode.TextValue)

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADivCd", Me.cboDivCd.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReaderNmNote", Me.txtReaderNmNote.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNumNote", Me.txtPhoneNumNote.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddrNote", Me.txtAddrNote.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNmNote", Me.txtBranchNmNote.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptNm", Me.txtDeptNm.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContent", Me.txtContent.Text)

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", sSubscribe)


            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC301_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            RequestData()
        End Sub
    End Class

End Namespace
