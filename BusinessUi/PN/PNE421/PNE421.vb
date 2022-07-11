'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �������׸��������
' form ���� : ������ �׸��� ��� ���� �մϴ�.
' �ۼ��� : ������
' �ۼ��� : 2006-03-07
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

    Public Class PNE421
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '' ===============================================================================================
            '' ====  ������ݱ����� ���Ȯ�� ����
            '' ===============================================================================================
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;116;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;1;;4;" & "o;n;n;40;Ȯ��ó ��;CompanyNm"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;126;;1;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|Ȯ������;ExpandDt;79;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��������;CollectionDivCd;1;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|û������;BillType;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û�����;BillDivCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����Ⱓ;FixedDt;117;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|������������;FixedStDt;1;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|������������;FixedEdDt;1;;4;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;50;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;74;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;62;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|��������;ApprovalDt;62;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���;Note;100;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�������Ȯ���ȣ;OldEmployeeExpNum;1;;4;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillType;û��������"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            '--------------------------------------------------
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3

            '' ===============================================================================================
            '' ====  ������ݱ����� û�� �̷� 
            '' ===============================================================================================
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"
            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;1;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;1;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;1;;4;" & "o;n;y;40;Ȯ��ó ��;CompanyNm"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;1;;1;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|��������;ProcDt;79;;4;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���ᱸ�����۳��;CollectionYYYYMM;108;;4;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|�����ܰ�;SubscriptionAmt;77;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;70;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��û���ݾ�;TotDemandAmt;90;#,###;7;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|��������;CollectionDivCd;1;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|û�����;BillDivCd;1;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;1;;1;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|����;Remark;120;;c;" & "io;n;n;40;"

            gridAttributes = gridAttributes & "|;Dummy;10;;c;" & "o;n;n;40;"

            'grid code combo
            gridCodeNameList = ""
            Dim gridCriteriaPopupCodeList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_2.Initialize(gridAttributes, gridCodeNameList, gridCriteriaPopupCodeList)
            Me.grd_2.ExplorerBar = 3

            '' ===============================================================================================
            '' ====  ������ݱ����� ��(����) û�� ��ȹ 
            '' ===============================================================================================
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"
            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;80;#,###;c;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;60;#,###;r;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|û�����;DmdYYMM;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|û������;DmdDivCd;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|û���μ�;DmdPapNum;70;#,###;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|û���ݾ�;DmdAmount;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|û������;DmdStateCd;80;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "DmdDivCd;�������û�������ڵ�"
            gridCodeNameList = gridCodeNameList & "/DmdStateCd;�������û�������ڵ�"
            gridCriteriaPopupCodeList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList, gridCriteriaPopupCodeList)
            Me.grd_3.ExplorerBar = 3

        End Sub

        Private Sub PNE421_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        ''' <summary>
        ''' �Լ��� : PNE421_Enter 
        ''' ��  �� : ȭ�� ��ȯ(���Ȯ�� û����ȹ ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNE421_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5))
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
            End If
        End Sub

        ''' <summary>
        ''' �Լ��� : Request
        ''' ��  �� : �ٸ� ȭ�鿡�� �ڵ� �� �޾Ƽ� �ش� ������ ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strEmployeeExpNum As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpFromExpand.TextValue = strFromDt  '��������
            Me.dtpToExpand.TextValue = strToDt      '��������
            Me.popCompanyCd.TextValue = strCompanyCd  'Ȯ��ó��ȣ
            Me.popCompanyCd.NameText = strCompanyNm  'Ȯ��ó��
            Me.popEmployeeExpNum_R.TextValue = strEmployeeExpNum  'Ȯ��������ȣ

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            ''Dim CurruntRow As Long

            ''With grd_2
            ''    If .Rows > 1 Then
            ''        ''CurruntRow = .GetCurrentRowCellValue("")
            ''        'Ȯ���μ� ó��
            ''        TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedPaperNum")).ToString.Replace(",", "")) _
            ''                         + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("ReFixedPaperNum")).ToString.Replace(",", ""))
            ''        .set_TextMatrix(CurruntRow, .get_ColIndex("TargetPaperTotNum"), TotalValue.ToString)
            ''    End If
            ''End With
        End Sub

        Private Sub grd_2_AfterEdit1(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_3.AfterEdit
            SetTotalValue(e.Row)
        End Sub

        Private Sub btnInsRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsRow.Click
            grd_3.AddRow()
            grd_3.set_TextMatrix(grd_3.Rows - 1, grd_3.get_ColIndex("EmployeeExpNum"), Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))
        End Sub

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
            Dim pGrd3 As Point = New Point(picBar2.Location.X + grd_3.Location.X - picBar.Location.X, grd_3.Location.Y)

            picBar2.Visible = False
            If pBar.X >= 20 And pBar.X + 20 <= Me.Width Then
                picBar.Location = pBar
                ' ''grd_2.Width = 5
                grd_3.Location = pGrd3

                Dim sGrd2 As Size = New Size(picBar.Location.X - grd_2.Location.X, grd_2.Height)
                grd_2.Size = sGrd2
                Dim sGrd3 As Size = New Size(Me.Width - grd_3.Location.X - 5, grd_3.Height)
                grd_3.Size = sGrd3
            End If
        End Sub

        Private Sub picBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseMove
            Dim p As Point = New Point(picBar.Location.X + e.X, picBar2.Location.Y)
            picBar2.Location = p
        End Sub

        Private Sub BtnNewLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLine.Click
            RequestData3()
        End Sub

    End Class

End Namespace
