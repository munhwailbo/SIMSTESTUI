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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE501
        Inherits CommonControls.UiControl

        Private Sub PNE501_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|�����ڵ�;BillDivCd;50;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;BillDivCdNm;90;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;1;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|������;BranchNm;100;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����ó;CompanyCd;1;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����ó��;CompanyNm;200;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������ȣ;EmployeeExpNum;100;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�Ǽ�;Cnt;1;#,###;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��кμ�;PaperNum;60;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ܺμ�;FixedPaperNum;60;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���̺μ�;diffPaperNum;60;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������;ExpandNm;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ݾ�;Amt;120;#,##0;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�������;DeductAmt;120;#,##0;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;120;#,##0;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;100;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��������;EmployeeExpDt;100;;1;" & "o;n;y;30;"

            gridAttributes = gridAttributes & "|�������޻���;BranchNote;269;;1;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|����;TargetPaperTotNum;37;;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ű�;NewExpPapNum;37;;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��Ȯ��;ReExpPapNum;50;;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��ܾ��ºμ�;NoListPapNum;87;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ��;FixedPaperNum2;37;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;SubscribePagerNum;37;#,###;7;" & "o;n;y;5;"         '�ӽ÷� ���� 02/17
            gridAttributes = gridAttributes & "|������;NoSubscribePagerNum;50;#,###;7;" & "o;n;y;5;"     '�ӽ÷� ���� 02/17  
            gridAttributes = gridAttributes & "|��ܻ����ڵ�;ListStatCd;105;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;87;;1;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|û������;BillType;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����ڵ�;BillDivCd2;93;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ֱ��ڵ�;BillPeriodCd;87;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;74;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������������;FixedStDt;87;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|������������;FixedEdDt;87;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;62;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|��������;ApprovalDt;62;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���;Note;291;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�������Ȯ���ȣ;OldEmployeeExpNum;0;;4;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|;Dummy;10;;1;" & "o;n;n;10;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ListStatCd;��ܻ����ڵ�"    '' 2401
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;���������ڵ�"   ''2323
            'gridCodeNameList = gridCodeNameList & "/BillType;û��������"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd2;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111

            With grd_1
                .Initialize(gridAttributes, gridCodeNameList)
                .ExplorerBar = 3
                .FrozenCols = .get_ColIndex("ExpandNm")
            End With

            ' ''����� ����
            ''popEmployeeNumber.Enabled = True
            ''If GmainBusinessFunction.GetValue("������翩��") = "0" Then
            ''    popEmployeeNumber.Enabled = False
            ''    popEmployeeNumber.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
            ''                                      GmainBusinessFunction.GetValue("�α��� ID"), _
            ''                                      GmainBusinessFunction.GetValue("���Ҵ�����"))
            ''End If



            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|��������;ContactDt4;85;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ȯ��ó;CompanyNm;119;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����ó;DeliveryChnlNm;128;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;191;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�������ڹ�ȣ;ReceiptCd;1;;1;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|���ڹ�ȣ;SubscribeCd;1;;1;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|��ȭ1;PhoneNum1;116;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;231;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;232;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ű�;NewPapNum;62;;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|������Ȯ��;ReExpPapNum1;74;;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������;TargetPaperTotNum;50;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ȯ���ű�;NewExpPapNum;1;;c;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|Ȯ����Ȯ��;ReExpPapNum;1;;c;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|Ȯ����;FixedPaperNum;1;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;SubscribePagerNum;1;;c;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|������;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�������;EmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�ֱ�����;TrAdEmployeeNm;62;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����ڸ�;BizEmpNm;1;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|û������ڵ�;BillTypeCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;74;;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ݳ��;CollectionYYYY;63;yyyy-MM;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����Ͱ��;Refuse;1;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����͹��������;RefuseReasonCd;1;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ڻ���;ReaderStateCd;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;SubscribeStateCd;70;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;FixedStDt3;85;yyyy-MM-dd;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����������;FixedStDt1;85;dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����������;FixedEdDt;85;dd;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceTerm;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;StopDt;70;yyyy-MM-dd;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��������;ReturnCd;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�Ǹű��ۼ�;SalWtList;1;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|�������;MngStopDt;90;yyyy-MM-dd;1;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|�������;MngRemark;150;;1;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|;Dummy;10;;1;" & "o;n;n;10;"
            'grid_1 code combo    
            gridCodeNameList = ""

            With grd_2
                .Initialize(gridAttributes, gridCodeNameList)
                .ExplorerBar = 3
                .FrozenCols = .get_ColIndex("SubscriberNm")
            End With


            '==============================================================
            dtpProcYM_R.Text = Now.ToString
            numBaseDay_R.TextValue = 14
            '==============================================================

        End Sub
#End Region

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            ''���Ȯ�� ���� ��� ȭ������ JUMP.
            'If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            'Dim strCode As String '�������ڹ�ȣ
            'strCode = "" _
            '          & ";" & "" _"
            '          & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
            '          & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
            '          & ";" & "" _
            '          & ";" & ""
            'GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC102;" & strCode)
            'Me.ShowUiControl("PNC102", strCode)

        End Sub


#Region "ȭ�� ���ø�"
        ''' <summary>
        ''' ' ȭ�� ���ø� 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>

        Private Sub picBar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBar.MouseHover
            Me.picBar.BackColor = Color.DarkGray
        End Sub
        Private Sub picBar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBar.MouseLeave
            Me.picBar.BackColor = Color.WhiteSmoke
        End Sub
        Private Sub picBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseDown
            picBar2.Visible = True
        End Sub
        Private Sub picBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseUp
            Dim pBar As Point = New Point(picBar2.Location.X, picBar2.Location.Y)
            Dim ppicTitle2 As Point = New Point(picTitle2.Location.X, picBar2.Location.Y + picTitle2.Location.Y - picBar.Location.Y)
            Dim plblTitle2 As Point = New Point(lblTitle2.Location.X, picBar2.Location.Y + lblTitle2.Location.Y - picBar.Location.Y)
            Dim pGrd2 As Point = New Point(grd_2.Location.X, picBar2.Location.Y + grd_2.Location.Y - picBar.Location.Y)
            '' PictureBox1, PictureBox2
            picBar2.Visible = False
            If pBar.Y >= grd_1.Location.Y + 20 And pBar.Y + 20 <= Me.Height Then
                picBar.Location = pBar
                ''grd_1.Width = 5
                picTitle2.Location = ppicTitle2
                '

                lblTitle2.Location = plblTitle2
                grd_2.Location = pGrd2

                Dim sGrd1 As Size = New Size(picBar.Width, picBar.Location.Y - grd_1.Location.Y)
                grd_1.Size = sGrd1
                Dim sGrd2 As Size = New Size(grd_2.Width, Me.Height - grd_2.Location.Y - 5)
                grd_2.Size = sGrd2
            End If
        End Sub
        Private Sub picBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseMove
            Dim p As Point = New Point(picBar.Location.X, picBar.Location.Y + e.Y)
            picBar2.Location = p
        End Sub
#End Region

        Private Sub btnBatchApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatchApply.Click
            With Me.grd_2
                For i As Integer = 1 To .Rows - 1
                    If .GetCellCheck(i, .get_ColIndex("����")) = CheckEnum.Checked Then
                        .set_TextMatrix(i, .get_ColIndex("MngStopDt"), Me.dtpDisYearMonth.Text)
                    End If
                Next
            End With
            
        End Sub
    End Class

End Namespace
