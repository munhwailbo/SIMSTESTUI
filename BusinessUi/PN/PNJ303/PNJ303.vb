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

    Public Class PNJ303
        Inherits CommonControls.UiControl

        Dim blnApprovalAll As Boolean = False

        Private Sub PNJ303_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub


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
            grd_1_Initialize()
            grd_2_Initialize()

        End Sub

        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub grd_1_Initialize()

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"

            gridAttributes = gridAttributes & "|��������;ExpandDt;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;85;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;85;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|û������;DmdStateCd;80;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û�����;DmdYYMM;80;;c;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|û���۾����;ProcDmdYYMM;80;;c;" & "io;n;y;7;"
            gridAttributes = gridAttributes & "|������г��;DistributionMM;80;;c;" & "o;n;n;7;"

            ''''''gridAttributes = gridAttributes & "|û������;DmdDivCd;80;;c;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|�����Ⱓ;DmdDt;117;;4;" & "o;n;n;40;"
            ''gridAttributes = gridAttributes & "|��������;CollectionDivCd;0;;1;" & "o;n;y;40;"
            ''gridAttributes = gridAttributes & "|û�����;BillDivCd;88;;1;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;88;;1;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|���ᱸ�����۳��;CollectionYYYYMM;108;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;75;#,###;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|û����;DemandAmt;90;#,##0;7;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|���ݾ�;CollectionAmt;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��о�;DistributionAmt;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|�̹�о�;NoDistributionAmt;90;#,##0;7;" & "o;n;n;15;"
            'gridAttributes = gridAttributes & "|ó������;ProcDt;90;;c;" & "io;n;n;15;"

            '' û�� �μ��� û�� ��ȹ ����.. ���� ���ϴ� ����� ����
            gridAttributes = gridAttributes & "|û���μ�;DmdPapNum;1;#,###;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û������;PlanDmdAmount;1;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;77;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û������Ѿ�;TotDemandAmt;100;#,##0;7;" & "o;n;n;15;"


            ' '' ''gridAttributes = gridAttributes & "|���� ������ ����;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|������ݱ�����;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|������;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|��ü��;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|��ó�� ������;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "DmdStateCd;�������û�������ڵ�"
            ''gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            ''gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            ''gridCodeNameList = gridCodeNameList & "/DmdStateCd;�������û�������ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3
            Me.grd_1.FrozenCols = grd_1.get_ColIndex("DmdYYMM")

        End Sub


        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub grd_2_Initialize()


            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"

            gridAttributes = gridAttributes & "|Ȯ����;CalYearMonths;80;;l;" & "io;n;y;8;"       '(20)
            gridAttributes = gridAttributes & "|����;Orders;40;;c;" & "io;n;y;4;"       '(30)

            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;85;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;85;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchNum;80;;l;" & "io;n;n;12;������ȣ;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|������;BranchNm;100;;l;" & "o;n;n;12;"       '(10)

            gridAttributes = gridAttributes & "|�μ�;PaperNum;60;#,##0;c;" & "io;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|ȸ���ܰ�;SubsUnitAmt;60;#,##0;c;" & "io;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|������ݾ�;SubscriptionAmt;100;#,##0;r;" & "io;n;n;4;"       '(80)

            gridAttributes = gridAttributes & "|��г��(�����);DisYearMonths;80;;l;" & "io;n;y;8;"       '(20)
            gridAttributes = gridAttributes & "|��г��;DisYearMonths2;80;;l;" & "o;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|ó������;ProcDt;80;;l;" & "io;n;n;8;"       '(110)
            ''gridAttributes = gridAttributes & "|��ü����;DeductYN;80;#,##0;r;" & "o;n;n;4;"       '(80)
            ''gridAttributes = gridAttributes & "|��ü����;DeductDt;80;#,##0;r;" & "io;n;n;4;"       '(80)
            ''gridAttributes = gridAttributes & "|��ü�ݾ�;DeductAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)
            ''gridAttributes = gridAttributes & "|��ü�ݾ�;TransferAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)

            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;100;;l;" & "io;n;n;8;"            '(110)
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;130;;l;" & "io;n;n;8;"        '(110)
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;100;;l;" & "io;n;n;8;"       '(110)

            gridAttributes = gridAttributes & "|���;Note;80;;l;" & "o;n;y;8;"       '(110)

            gridAttributes = gridAttributes & "|���Ȯ�ο���;RegYesOrNo;80;;l;" & "o;n;n;8;"       '(110)
            gridAttributes = gridAttributes & "|�������ο���;ApplyYesOrNo;80;;l;" & "o;n;n;8;"       '(110)

            'gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;70;;c;" & "io;n;y;40;Ȯ��ó ��;CompanyNm;"
            ' ''gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;70;;l;" & "o;n;n;40;"

            ' ''gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;90;;c;" & "o;n;y;10;���������ڵ�;;"
            ' ''gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;60;;c;" & "o;n;y;10;"

            ' ''gridAttributes = gridAttributes & "|û�����;BillDivCd;60;;c;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;90;;c;" & "o;n;y;10;;"
            ' ''gridAttributes = gridAttributes & "|����;EmployeeNameHangul;60;;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "| ;JiRal;80;;l;" & "o;n;n;8;"       '(110)

            'grid_2 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BankCd;�����ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"   ''2111
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_2.ExplorerBar = 3

        End Sub

        ''' <summary>
        ''' �Լ��� : PNE421_Enter 
        ''' ��  �� : ȭ�� ��ȯ(���Ȯ�� û����ȹ ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 5
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNJ303_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            ' ''Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            ' ''If ShareParameters(0) = Me.Name Then
            ' ''    SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4))
            ' ''    GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
            ' ''End If
        End Sub

        ''' <summary>
        ''' �Լ��� : Request
        ''' ��  �� : �ٸ� ȭ�鿡�� �ڵ� �� �޾Ƽ� �ش� ������ ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetRequest(ByVal strBaseDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strEmployeeExpNum As String)
            '' ''�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            ' ''Me.dtpBaseDt_r.TextValue = strBaseDt  '��������
            ' ''Me.popCompanyCd.TextValue = strCompanyCd  'Ȯ��ó��ȣ
            ' ''Me.popCompanyCd.NameText = strCompanyNm  'Ȯ��ó��
            ' ''Me.popEmployeeExpNum_R.TextValue = strEmployeeExpNum  'Ȯ��������ȣ

            ' ''GrecordProcessMode = "2"   ' ��ȸ ���� ����
            ' ''Me.GmainCommonFunction.GRequestDataNumber = 1
            ' ''CallByName(Me, "RequestData", CallType.Method)
        End Sub


        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '' ''���Ȯ�� ���� ��� ȭ������ JUMP.
            ' ''If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            ' ''Dim strCode As String '�������ڹ�ȣ
            ' ''Dim sdate As String
            ' ''sdate = dtpBaseYear.TextValue.Substring(0, 4) + "-" + "01"
            ' ''strCode = Me.dtpBaseYear.TextValue _
            ' ''          & ";" & Me.grd_1.GetCurrentRowCellValue("BranchNum") _
            ' ''          & ";" & sdate
            ' ''GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNI403;" & strCode)
            ' ''Me.ShowUiControl("PNI403", strCode)

        End Sub


        '' ''Private Sub optBaseProcDt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    If optBaseProcDt.Checked = True Then
        '' ''        sbOptBaseDtEnabled()
        '' ''    End If
        '' ''End Sub

        '' ''Private Sub optBaseDmdYM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    If optBaseDmdYM.Checked = True Then
        '' ''        sbOptBaseDtEnabled()
        '' ''    End If
        '' ''End Sub

        Private Sub sbOptBaseDtEnabled()
            ' ''If optBaseProcDt.Checked = True Then
            ' ''    dtpBaseDtFr.Enabled = True
            ' ''    dtpBaseDtTo.Enabled = True
            ' ''Else
            ' ''    dtpBaseDtFr.Enabled = False
            ' ''    dtpBaseDtTo.Enabled = False
            ' ''End If

            ' ''If optBaseDmdYM.Checked = True Then
            ' ''    dtpDmdYMFr.Enabled = True
            ' ''    dtpDmdYMTo.Enabled = True
            ' ''Else
            ' ''    dtpDmdYMFr.Enabled = False
            ' ''    dtpDmdYMTo.Enabled = False
            ' ''End If
        End Sub

        Private Sub chkDmdYM_R_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDmdYM_R.CheckedChanged
            'If chkDmdYM_R.Checked = True Then
            dtpDmdYMFr.Enabled = chkDmdYM_R.Checked
            dtpDmdYMTo.Enabled = chkDmdYM_R.Checked
            'End If
        End Sub

        Private Sub chkDmd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDmd1.CheckedChanged
            If chkDmd1.Visible Then
                If chkDmd1.Checked = False And chkDmd2.Checked = False Then
                    'MsgBox(chkDmd1.Text.ToString & " �� " & _
                    '       chkDmd2.Text.ToString & " �� �߿�" & _
                    '       vbCrLf & " �ϳ� �̻��� �ݵ�� üũ�� �Ǿ� �־�� �մϴ�. ", _
                    '       MsgBoxStyle.Information, "Ȯ��")
                    chkDmd1.Checked = True
                End If
            End If
        End Sub

        Private Sub chkDmd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDmd2.CheckedChanged
            If chkDmd2.Visible Then
                If chkDmd1.Checked = False And chkDmd2.Checked = False Then
                    'MsgBox(chkDmd1.Text.ToString & " �� " & _
                    '       chkDmd2.Text.ToString & " �� �߿�" & _
                    '       vbCrLf & " �ϳ� �̻��� �ݵ�� üũ�� �Ǿ� �־�� �մϴ�. ", _
                    '       MsgBoxStyle.Information, "Ȯ��")
                    chkDmd2.Checked = True
                End If
            End If
        End Sub

        Private Sub BtnNewLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLine.Click
            RequestData2()
        End Sub

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                'If blnApprovalAll = False Then
                With grd_2
                    If (.Rows > .FixedRows) Then
                        For inti = .FixedRows To .Rows - 1
                            If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
                                .set_TextMatrix(inti, .get_ColIndex("ProcDt"), dtpProcDT.Text)
                                .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
                            End If
                        Next inti
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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
            Dim pPBox1 As Point = New Point(PictureBox1.Location.X, picBar2.Location.Y + PictureBox1.Location.Y - picBar.Location.Y)

            Dim pBtnNewLine As Point = New Point(BtnNewLine.Location.X, picBar2.Location.Y + BtnNewLine.Location.Y - picBar.Location.Y)
            Dim pLabel2 As Point = New Point(Label2.Location.X, picBar2.Location.Y + Label2.Location.Y - picBar.Location.Y)
            Dim pProcDT As Point = New Point(dtpProcDT.Location.X, picBar2.Location.Y + dtpProcDT.Location.Y - picBar.Location.Y)
            Dim pbtnApprovalAll As Point = New Point(btnApprovalAll.Location.X, picBar2.Location.Y + btnApprovalAll.Location.Y - picBar.Location.Y)

            Dim pPBox2 As Point = New Point(PictureBox2.Location.X, picBar2.Location.Y + PictureBox2.Location.Y - picBar.Location.Y)
            Dim pGrd2 As Point = New Point(grd_2.Location.X, picBar2.Location.Y + grd_2.Location.Y - picBar.Location.Y)
            '' PictureBox1, PictureBox2
            picBar2.Visible = False
            If pBar.Y >= grd_1.Location.Y + 20 And pBar.Y + 20 <= Me.Height Then
                picBar.Location = pBar
                ''grd_1.Width = 5
                PictureBox1.Location = pPBox1
                BtnNewLine.Location = pBtnNewLine
                Label2.Location = pLabel2
                dtpProcDT.Location = pProcDT
                btnApprovalAll.Location = pbtnApprovalAll

                PictureBox2.Location = pPBox2
                grd_2.Location = pGrd2

                Dim sGrd1 As Size = New Size(picBar.Width, picBar.Location.Y - grd_1.Location.Y)
                grd_1.Size = sGrd1
                Dim sGrd2 As Size = New Size(grd_1.Width, Me.Height - grd_2.Location.Y - 5)
                grd_2.Size = sGrd2
            End If
        End Sub

        Private Sub picBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseMove
            Dim p As Point = New Point(picBar.Location.X, picBar.Location.Y + e.Y)
            picBar2.Location = p
        End Sub

    End Class

End Namespace