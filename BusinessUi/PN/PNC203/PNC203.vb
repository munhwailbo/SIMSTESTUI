' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : 
' form���� :
' �ۼ��� : 
' �ۼ��� : 
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

    Public Class PNC203
        Inherits CommonControls.UiControl
        '====================================================================================================
       

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

            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|�����ڵ�;ReaderCd;80;;l;" & "o;n;n;8;"       '(10)
            gridAttributes = gridAttributes & "|���ڸ�;ReaderNm;100;;l;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;200;;l;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;200;;l;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;200;;l;" & "o;n;n;30;"       '(50)
            gridAttributes = gridAttributes & "|�ſ����ȣ;NewPostNum;100;;l;" & "o;n;n;10;"       '(60)
            gridAttributes = gridAttributes & "|���ּ�;NewAddr1;200;;l;" & "o;n;n;50;"       '(70)
            gridAttributes = gridAttributes & "|�Ż��ּ�;NewAddr2;200;;l;" & "o;n;n;100;"       '(80)
            gridAttributes = gridAttributes & "|�������ȣ;OldPostNum;100;;l;" & "o;n;n;10;"       '(90)
            gridAttributes = gridAttributes & "|���ּ�;OldAddr1;200;;l;" & "o;n;n;50;"       '(100)
            gridAttributes = gridAttributes & "|�����ּ�;OldAddr2;200;;l;" & "o;n;n;100;"       '(110)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;SubscribeCd;100;;l;" & "io;n;n;10;"       '(10)
            gridAttributes = gridAttributes & "|�����ڵ�;ReaderCd;80;;l;" & "io;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|����;Orders;40;;r;" & "io;n;n;4;"       '(30)

            gridAttributes = gridAttributes & "|���������ڵ�;SubscribeStateCd;100;;l;" & "io;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|Ȯ�屸���ڵ�;ExpandDivCd;100;;l;" & "io;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|���ڱ����ڵ�;ReaderDivCd;100;;l;" & "io;n;n;10;"       '(60)
            gridAttributes = gridAttributes & "|���ڻ����ڵ�;ReaderStateCd;100;;l;" & "io;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|���ó�����ڵ�;DeliveryRegionCd;100;;l;" & "io;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|��ޱ����ڵ�;DeliveryDivCd;100;;l;" & "io;n;n;10;"       '(90)
            gridAttributes = gridAttributes & "|���絶�ڱ����ڵ�;MHReaderDivCd;100;;l;" & "io;n;n;10;"       '(100)
            gridAttributes = gridAttributes & "|���˿���;PromotionYN;10;;c;" & "io;n;n;1;"       '(110)
            gridAttributes = gridAttributes & "|���˻����;PromotionEmpNm;200;;l;" & "io;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;100;;l;" & "io;n;n;10;"       '(130)
            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;100;;l;" & "io;n;n;10;"       '(140)
            gridAttributes = gridAttributes & "|û���ֱ��ڵ�;BillPeriodCd;100;;l;" & "io;n;n;10;"       '(150)
            gridAttributes = gridAttributes & "|��������;ContactDt;80;;l;" & "io;n;n;8;"       '(160)
            gridAttributes = gridAttributes & "|��������;FixedStDt;80;;l;" & "io;n;n;8;"       '(170)
            gridAttributes = gridAttributes & "|������������;FixedEdDt;80;;l;" & "io;n;n;8;"       '(180)
            gridAttributes = gridAttributes & "|��������;StopDt;80;;l;" & "io;n;n;8;"       '(190)
            gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceTerm;40;;r;" & "io;n;n;4;"       '(200)
            gridAttributes = gridAttributes & "|�����μ�;ContactPaperNum;40;;r;" & "io;n;n;4;"       '(210)
            gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;40;;r;" & "io;n;n;4;"       '(220)
            gridAttributes = gridAttributes & "|���Ժμ�;SubscribePagerNum;40;;r;" & "io;n;n;4;"       '(230)
            gridAttributes = gridAttributes & "|�����μ�;StopPaperNum;40;;r;" & "io;n;n;4;"       '(240)
            gridAttributes = gridAttributes & "|���ݽ��۳��;CollectionYYYYMM;60;;l;" & "io;n;n;6;"       '(250)
            gridAttributes = gridAttributes & "|Ȯ���Ȯ��ó���ھ��̵�;ExpSupAmtProcEmpNum;70;;l;" & "io;n;n;7;"       '(260)
            gridAttributes = gridAttributes & "|Ȯ���Ȯ������;ExpSupAmtFixedDt;80;;l;" & "io;n;n;8;"       '(270)
            gridAttributes = gridAttributes & "|�ǵ��ڰ���ó�����̵�;RealReaderProcEmpNum;70;;l;" & "io;n;n;7;"       '(280)
            gridAttributes = gridAttributes & "|�ǵ��ڰ�������;RealReaderFixedDt;80;;l;" & "io;n;n;8;"       '(290)

            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptBranchCd;70;;l;" & "io;n;n;7;"       '(300)
            gridAttributes = gridAttributes & "|���������ڵ�;SubscribeBranchCd;70;;l;" & "io;n;n;7;"       '(310)
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptMoneyBranchCd;70;;l;" & "io;n;n;7;"       '(320)
            gridAttributes = gridAttributes & "|���������ڵ�;ValPaperBranchCd;70;;l;" & "io;n;n;7;"       '(330)
            gridAttributes = gridAttributes & "|���;Note;200;;l;" & "io;n;n;20;"       '(340)

            'grid_2 code combo    
            gridCodeNameList = ""

            gridCodeNameList = gridCodeNameList & "SubscribeStateCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;Ȯ�屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/ReaderDivCd;���ڱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/ReaderStateCd;���ڻ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"

            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;���絶�ڱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;û���ֱ��ڵ�"

            gridCodeNameList = gridCodeNameList & "/ReceiptBranchCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/SubscribeBranchCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ReceiptMoneyBranchCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ValPaperBranchCd;���������ڵ�"

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3

            '  grid_3 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;80;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|�����ڵ�;ReaderCd;80;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|���ڸ�;ReaderNm;100;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;200;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;200;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;200;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ſ����ȣ;NewPostNum;100;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|���ּ�;NewAddr1;200;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|�Ż��ּ�;NewAddr2;200;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|�������ȣ;OldPostNum;100;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr1;200;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|�����ּ�;OldAddr2;200;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|ó������;ProcessDt;200;;l;" & "io;n;n;100;"

            'grid_3 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3


        End Sub

#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNC201_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
        ''' <summary>
        ''' �Լ��� : btnRowInsert_Click 
        ''' ��  �� : �� �߰�
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2007-01-02
        ''' ������ : 
        ''' ������ :
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnRowInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRowInsert.Click
            Dim RowNumber As Integer = 0

            With Me.grd_2
                .AddRow()
                .set_TextMatrix(.Rows - 1, 0, "�ű�")
                .set_TextMatrix(.Rows - 1, .get_ColIndex("SubscribeCd"), "0") '�׸� ��ȣ 
                .set_TextMatrix(.Rows - 1, .get_ColIndex("ReaderCd"), "") '�׸� ��ȣ 
                .set_TextMatrix(.Rows - 1, .get_ColIndex("Orders"), 0) '�׸� ��ȣ 
            End With
        End Sub
        ''' <summary>
        ''' �Լ��� : btnRowSave_Click 
        ''' ��  �� : �� ����
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2007-01-02
        ''' ������ : 
        ''' ������ :
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnRowSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRowSave.Click

        End Sub
        ''' <summary>
        ''' �Լ��� : btnRowDelete_Click 
        ''' ��  �� : �� ����
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2007-01-02
        ''' ������ : 
        ''' ������ :
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnRowDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRowDelete.Click
            With Me.grd_2
                If .Rows > .FixedRows Then
                    If .get_TextMatrix(.RowSel, 0) = "�ű�" Then
                        .RemoveItem(.RowSel)
                    ElseIf IsNumeric(.get_TextMatrix(.RowSel, 0)) = True Then
                        .set_TextMatrix(.RowSel, 0, "����")
                        .SetCellCheck(.RowSel, .get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                    ElseIf .get_TextMatrix(.RowSel, 0) = "����" = True Then
                        .set_TextMatrix(.RowSel, 0, "����")
                        .SetCellCheck(.RowSel, .get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                    End If
                End If
            End With
        End Sub
        ''' <summary>
        ''' �Լ��� : btnCopy_Click 
        ''' ��  �� : �� ����
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2007-01-02
        ''' ������ : 
        ''' ������ :
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
            Dim Row As Integer = 0                '�� INDEX
            Dim RowNumber As Integer = 0

            With Me.grd_2
                If .Rows = .FixedRows Then Exit Sub
                Row = .RowSel
                .AddRow()
                .set_TextMatrix(.Rows - 1, 0, "�ű�")
                .SetCellCheck(.Rows - 1, .get_ColIndex("����"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalSeq"), "0") '�׸� ��ȣ 
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("AccountCode"), .get_TextMatrix(Row, .get_ColIndex("AccountCode")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("AccountCodeName"), .get_TextMatrix(Row, .get_ColIndex("AccountCodeName")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalQuantity"), .get_TextMatrix(Row, .get_ColIndex("ProposalQuantity")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalAmount"), .get_TextMatrix(Row, .get_ColIndex("ProposalAmount")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ValidBeginDate"), .get_TextMatrix(Row, .get_ColIndex("ValidBeginDate")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ValidEndDate"), .get_TextMatrix(Row, .get_ColIndex("ValidEndDate")))
            End With

            '2006-07-26 ������ �߰�
            Me.grd_2.Select(Me.grd_2.Rows - 1, Me.grd_2.get_ColIndex("SubscribeCd"))
        End Sub
#End Region

    End Class

End Namespace
