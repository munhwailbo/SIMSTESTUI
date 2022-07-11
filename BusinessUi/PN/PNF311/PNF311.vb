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

    Public Class PNF311
        Inherits CommonControls.UiControl

        Private Sub PNF311_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;171;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;DeliveryBranchCd;65;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���� ��;DeliveryBranchNm;103;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;74;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;83;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;56;#,##0;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���Ȯ�ο���;IsAccept;76;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;0;;4;" & "o;n;y;10;�����ȣ;OldPostNm"
            gridAttributes = gridAttributes & "|�ּ�;OldPostNm;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;178;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;179;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|Ȯ������;ContactDt;79;yyyy-MM-dd;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;79;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;FixedEdDt;76;yyyy-MM-dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceTerm;1;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|���ݳ��;CollectionYYYYMM;67;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�޸�;Memo;100;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;66;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�������ڹ�ȣ;ReceiptCd;70;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|WEB������ȣ;WebPkey;50;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10; "

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            '' ''gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;���������ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '����Ȯ�� ���� ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '�������ڹ�ȣ
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)
        End Sub

        Private Sub btnPRB002_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRB002.Click

            '����Ȯ�� ���� ��� ȭ������ JUMP.
            '''' If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
            If Me.grd_1.GetCurrentRowCellValue("ReceiptCd").ToString.Length > 1 Then
                MsgBox("���� ó�� �� �ڷ��Դϴ�.")
                Exit Sub
            End If

            Dim strCode As String '�������ڹ�ȣ
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("WebPkey") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm") _
                      & ";" & "5"    '' '' ó������  2:�̻� ���� �ű�, 3:��Ȯ�� �ű�, 5:WEB���� ��ȯ
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)

        End Sub
    End Class

End Namespace
