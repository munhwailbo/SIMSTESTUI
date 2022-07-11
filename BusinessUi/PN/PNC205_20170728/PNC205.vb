' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : ����Ȯ���������ڵ��
' form���� : ����Ȯ���������ڵ����(��) �Ѵ�
' �ۼ��� : ������
' �ۼ��� : 2008-09-18
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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC205
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

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;200;;l;" & "io;n;y;30;"       '(40)
            gridAttributes = gridAttributes & "|�������ڹ�ȣ;ReceiptCd;200;;l;" & "o;n;y;30;"       '(40)
            gridAttributes = gridAttributes & "|Ȯ�屸��;ExpandDivCd;200;;l;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|���ڻ���;ReaderStateCd;100;;l;" & "o;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|��������;SubscribeStateCd;100;;l;" & "io;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|��������;RealEdDt;100;yyyy-mm-dd;l;" & "io;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|�������;MngStopDt;100;yyyy-mm-dd;l;" & "io;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;200;;l;" & "o;n;n;30;"       '(40)

            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;100;;l;" & "o;n;n;10;"       '(60)
            gridAttributes = gridAttributes & "|Ȯ������;ContactDt;80;;l;" & "o;n;n;8;"       '(20) ��������

            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;200;;l;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;200;;l;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;100;;l;" & "o;n;y;10;�����ȣ;OldPostNm"
            gridAttributes = gridAttributes & "|�ּ�;OldPostNm;90;;c;" & "o;n;y;5;"       '(130)
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;200;;l;" & "o;n;n;50;"       '(140)
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;200;;l;" & "o;n;n;100;"       '(150)

            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;200;;l;" & "o;n;y;30;"       '(10)
            '' 'gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;70;;l;" & "o;n;n;7;�����ڵ�;DeliveryBranchNm"       '(300)
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;70;;l;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���� ��;DeliveryBranchNm;70;;l;" & "o;n;n;7;"

            gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;20;#,##0;c;" & "o;n;n;10;"       '(230)���Ժμ�
            gridAttributes = gridAttributes & "|��ޱ���;DeliveryDivCd;100;;l;" & "o;n;n;10;"       '(230) ��ޱ����ڵ�(2313) 
            gridAttributes = gridAttributes & "|���ó;DeliveryRegionCd;100;;l;" & "o;n;n;10;"       '(410) ���ó�����ڵ�(2314)
            gridAttributes = gridAttributes & "|���絶�ڱ���;MHReaderDivCd;100;;l;" & "o;n;n;10;"       '(410) ���絶�ڱ����ڵ�(2316)

            gridAttributes = gridAttributes & "|��������;FixedStDt;100;;l;" & "o;n;n;10;"       '(410)
            gridAttributes = gridAttributes & "|��������;FixedEdDt;100;;l;" & "o;n;n;10;"       '(410)
            gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceTerm;100;;c;" & "o;n;n;10;"       '(410)
            gridAttributes = gridAttributes & "|���ݳ��;CollectionYYYYMM;100;;l;" & "o;n;n;10;"       '(410)

            gridAttributes = gridAttributes & "|(��)�����ȣ;NewPostNum;100;;l;" & "o;n;y;10;�����ȣ;NewPostNm"
            gridAttributes = gridAttributes & "|(��)�ּ�;NewPostNm;90;;c;" & "o;n;y;5;"       '(100)
            gridAttributes = gridAttributes & "|(��)�ּ�;NewAddr1;200;;l;" & "o;n;y;50;"       '(110)
            gridAttributes = gridAttributes & "|(��)���ּ�;NewAddr2;200;;l;" & "o;n;y;100;"       '(120)

            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;10;;c;" & "o;n;n;1;"       '(390)
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|�Ǹű��ۼ���ܿ���;SalWtListYn;100;;l;" & "o;n;n;10;"       '(60)
            gridAttributes = gridAttributes & "|����ó�ڵ�;DeliveryChnlCd;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|����ó��;DeliveryChnlNm;100;;l;" & "o;n;y;10;"       '(60)
            gridAttributes = gridAttributes & "|�����ǵ��ڿ���;CouponReaderYN;100;;l;" & "o;n;y;10;"       '(410)
            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponSeriesNum;100;;l;" & "o;n;y;10;"       '(410)

            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;200;;l;" & "o;n;y;30;"       '(80)
            gridAttributes = gridAttributes & "|;Dummy;100;;l;" & "o;n;n;10;"       '(60)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/SubscribeStateCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryBranchCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3

            Me.NewData()

        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNC205_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC205_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        ''' <summary>
        ''' �Լ��� : grd_1_DoubleClick 
        ''' ��  �� : 
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick
            '���ڱ�������ȭ������ �̵�
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim strSubscribeCd As String '������ȣ
            Dim strSubscriberNm As String '���ڸ�

            strSubscribeCd = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscribeCd")) '������ȣ
            strSubscriberNm = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SubscriberNm")) '���ڸ�

            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC201;" & strSubscribeCd & ";" & strSubscriberNm)
            Me.ShowUiControl("PNC201", strSubscribeCd)
        End Sub

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Try
                With grd_1
                    If (.Rows > .FixedRows) Then
                        For intII As Integer = .FixedRows To .Rows - 1
                            If .GetCellCheck(intII, .get_ColIndex("����")) = CheckEnum.Checked Then
                                .set_TextMatrix(intII, .get_ColIndex("SubscribeStateCd"), cboReaderStateCd_E.Text)
                                .set_TextMatrix(intII, .get_ColIndex("RealEdDt"), dtpRealEdDt.Text)
                                .set_TextMatrix(intII, .get_ColIndex("MngStopDt"), dtpRealEdDt.Text)
                                .SetCellCheck(intII, .get_ColIndex("����"), CheckEnum.Checked)
                            End If
                        Next intII
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End Sub
    End Class

End Namespace
