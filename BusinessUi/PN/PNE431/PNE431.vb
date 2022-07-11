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

    Public Class PNE431
        Inherits CommonControls.UiControl

        Dim blnApprovalAll As Boolean = False

        Private Sub PNE431_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            gridAttributes = gridAttributes & "|��������;ExpandDt;79;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;1;;4;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;116;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;1;;4;" & "io;n;n;40;Ȯ��ó ��;CompanyNm"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;126;;1;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|û������;DmdStateCd;80;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û�����;DmdYYMM;80;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|û���۾����;ProcDmdYYMM;80;;c;" & "io;n;y;7;"

            gridAttributes = gridAttributes & "|��������;CollectionDivCd;0;;1;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|û������;BillType;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û�����;BillDivCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;88;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ᱸ�����۳��;CollectionYYYYMM;108;;4;" & "o;n;n;40;"

            'gridAttributes = gridAttributes & "|û������;DmdDivCd;80;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���μ�;DmdPapNum;70;#,###;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|û������;PlanDmdAmount;70;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��û����;PreDmdAmount;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|û��(ó��)��;NoDmdAmount;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|û����;ProcDmdAmount;90;#,##0;7;" & "io;n;y;15;"
            gridAttributes = gridAttributes & "|ó������;ProcDt;90;;c;" & "io;n;n;15;"

            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;77;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;75;#,###;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û������Ѿ�;TotDemandAmt;100;#,##0;7;" & "o;n;n;15;"

            gridAttributes = gridAttributes & "|�����Ⱓ;DmdDt;117;;4;" & "o;n;n;40;"

            ' '' ''gridAttributes = gridAttributes & "|���� ������ ����;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|������ݱ�����;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|������;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|��ü��;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|��ó�� ������;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillType;û��������"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            gridCodeNameList = gridCodeNameList & "/DmdStateCd;�������û�������ڵ�"
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

            ' '' ''==============================================================
            ' '' ''  grid_1 �� �ʱ�ȭ �Ѵ�.
            ' '' ''--------------------------------------------------------------
            '' ''Dim gridAttributes As String = ""
            ' '' ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            '' ''gridAttributes = gridAttributes & "a;r;n"

            ' '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ' '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            '' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"

            '' ''gridAttributes = gridAttributes & "|��������;ExpandDt;79;;4;" & "o;n;n;5;"
            '' ''gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;1;;4;" & "io;n;n;5;"
            '' ''gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;116;;1;" & "o;n;n;50;"
            '' ''gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;1;;4;" & "o;n;n;40;Ȯ��ó ��;CompanyNm"
            '' ''gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;126;;1;" & "o;n;n;40;"

            '' ''gridAttributes = gridAttributes & "|��������;CollectionDivCd;0;;1;" & "o;n;y;40;"
            '' ''gridAttributes = gridAttributes & "|û�����;BillDivCd;88;;1;" & "o;n;n;5;"
            '' ''gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;88;;1;" & "o;n;n;5;"
            ' '' ''gridAttributes = gridAttributes & "|�����Ⱓ;DmdDt;117;;4;" & "o;n;n;40;"
            ' '' ''gridAttributes = gridAttributes & "|���ᱸ�����۳��;FixedStDt;108;;4;" & "o;n;n;40;"

            ' '' '' ''gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;77;#,###;7;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;75;#,###;7;" & "o;n;n;5;"
            ' '' '' ''gridAttributes = gridAttributes & "|û������Ѿ�;Amount_A;90;#,##0;7;" & "o;n;n;15;"

            '' ''gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;60;#,###;r;" & "io;n;y;5;"
            '' '' ''gridAttributes = gridAttributes & "|û�����;CalYearMonths;60;;4;" & "o;n;n;40;"
            '' ''gridAttributes = gridAttributes & "|û�����;DmdYYMM;80;;c;" & "o;n;n;5;"
            ' '' ''gridAttributes = gridAttributes & "|û������;DmdDivCd;80;;c;" & "o;n;n;5;"
            '' ''gridAttributes = gridAttributes & "|û���μ�;DmdPapNum;70;#,###;c;" & "o;n;n;5;"
            '' ''gridAttributes = gridAttributes & "|û������;DmdPlanAmount;70;#,###;r;" & "o;n;n;5;"
            '' ''gridAttributes = gridAttributes & "|û����;DmdAmount;90;#,##0;7;" & "io;n;n;15;"

            '' ''gridAttributes = gridAttributes & "|û������;DmdStateCd;80;;c;" & "o;n;n;5;"
            ' '' '' '' ''gridAttributes = gridAttributes & "|���� ������ ����;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' '' '' ''gridAttributes = gridAttributes & "|������ݱ�����;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' '' '' ''gridAttributes = gridAttributes & "|������;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' '' '' ''gridAttributes = gridAttributes & "|��ü��;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' '' '' ''gridAttributes = gridAttributes & "|��ó�� ������;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            '' ''gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            ' '' ''grid_2 code combo    
            '' ''Dim gridCodeNameList As String = ""
            '' ''gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            '' ''gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            '' ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            '' ''gridCodeNameList = gridCodeNameList & "/DmdStateCd;�������û�������ڵ�"
            '' ''grd_2.Initialize(gridAttributes, gridCodeNameList)

            '' ''Me.grd_2.ExplorerBar = 3

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
        Private Sub PNE431_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4))
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
        Public Sub SetRequest(ByVal strBaseDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strEmployeeExpNum As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpBaseDt_r.TextValue = strBaseDt  '��������
            Me.popCompanyCd.TextValue = strCompanyCd  'Ȯ��ó��ȣ
            Me.popCompanyCd.NameText = strCompanyNm  'Ȯ��ó��
            Me.popEmployeeExpNum_R.TextValue = strEmployeeExpNum  'Ȯ��������ȣ

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
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

        End Sub

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                If blnApprovalAll = False Then
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
                                    .set_TextMatrix(inti, .get_ColIndex("ProcDt"), dtpProcDT.Text)
                                    .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = True
                Else
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
                                    '' ''.SetCellCheck(inti, .get_ColIndex("ApprovalYN"), CheckEnum.Unchecked)
                                    .set_TextMatrix(inti, .get_ColIndex("ProcDt"), "")
                                    .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = False
                End If
                ''btnApprovalAll.Text = IIf(blnApprovalAll, "�ϰ� ���", "�ϰ� ����")
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class

End Namespace