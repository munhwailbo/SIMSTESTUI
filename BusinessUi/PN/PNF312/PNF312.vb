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

    Public Class PNF312
        Inherits CommonControls.UiControl

        Private Sub PNF312_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|������;BranchName;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��������;SubscribeDate;73;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|û������;BillDate;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyName;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ڸ�;ReaderName;161;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ1;ReaderTel1;100;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ2;ReaderTel2;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�ڵ���;ReaderHp;93;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;ReaderZipCode;0;;4;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�ּ�;ReaderAddress1;193;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���ּ�;ReaderAddress2;232;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|���Ժμ�;ThrowNo;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�������;RegDate;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����ͽ��ο���;IsAccept;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeeEmpNum;232;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|����;ChrageEmpNm;232;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|�������ڿ���;IsExist;0;;1;" & "o;n;y;30;"

            gridAttributes = gridAttributes & "|;Dummy;100;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            'gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;���������ڵ�"
            'gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            'gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            'gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            'gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

        'Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

        '    '����Ȯ�� ���� ��� ȭ������ JUMP.
        '    If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
        '    Dim strCode As String '�������ڹ�ȣ
        '    strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
        '              & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
        '              & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
        '              & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm")
        '    GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC101;" & strCode)
        '    Me.ShowUiControl("PNC101", strCode)
        'End Sub



    End Class

End Namespace
