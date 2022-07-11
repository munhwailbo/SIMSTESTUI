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

    Public Class PNI403
        Inherits CommonControls.UiControl

        Private Sub PNI403_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code

            'gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;90;;c;" & "o;n;y;10;���������ڵ�;;"
            'gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;60;;c;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;90;;c;" & "o;n;y;10;;"
            'gridAttributes = gridAttributes & "|����;ChargeEmpNm;60;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "||����;����;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchNum;1;;4;" & "o;n;n;10;�����ڵ�;BranchNm "
            gridAttributes = gridAttributes & "|������;BranchNm;50;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������;CalYearMonths;63;yyyy-MM;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|ó������;ProcDt;85;yyyy-MM-dd;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�Աݱ���;ColTypeCd;144;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����̼���;LastUnColAmt;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|�����;ThisSalesAmt;70;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|���ݾ�;ThisColAmt;70;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�̼���;ThisUnColAmt;70;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���¼��ݾ�;ColAmt1;74;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��ü���ݾ�;ColAmt2;74;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�μ�;PaperNum;45;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����;Note;150;;l;" & "o;n;n;150;"
            gridAttributes = gridAttributes & "|;Dummy;200;;1;" & "o;n;n;1000;"
            '' ''gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;80;;c;" & "o;n;n;7;"       '(10)
            '' ''gridAttributes = gridAttributes & "|������ȣ;BranchNum;80;;c;" & "o;n;n;9;"       '(20)
            '' ''gridAttributes = gridAttributes & "|��ڱ����ڵ�;OperatorDivCd;90;;c;" & "o;n;n;10;"       '(30)
            '' ''gridAttributes = gridAttributes & "|������;DepositAmt;120;;r;" & "o;n;n;15;"       '(40)
            '' ''gridAttributes = gridAttributes & "|�ϳ������ݴ���;FullPaymentAmt;120;;r;" & "o;n;n;15;"       '(50)
            '' ''gridAttributes = gridAttributes & "|�̼��ݴ���;UnColAmt;120;;r;" & "o;n;n;15;"       '(60)
            '' ''gridAttributes = gridAttributes & "|�̼�ó�������ڵ�;ProcDivCd;100;;c;" & "o;n;n;10;"       '(70)
            '' ''gridAttributes = gridAttributes & "|���;Note;200;;l;" & "o;n;n;1000;"       '(80)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ColTypeCd;�Աݱ����ڵ�"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            dtpFromYearMonths.TextValue = "19910101"

            '����� ����
            popChargeEmpNum_r.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popChargeEmpNum_r.Enabled = False
                popChargeEmpNum_r.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                  GmainBusinessFunction.GetValue("�α��� ID"), _
                                                  GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If


        End Sub
        ''' <summary>
        ''' �Լ��� : PNE102_Enter 
        ''' ��  �� : ȭ�� ��ȯ(���Ȯ�� ������ ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNI403_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3))
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
            End If
        End Sub
        ' <summary
        ' �Լ��� : Request
        ' ��  �� : �ٸ� ȭ�鿡�� �ڵ� �� �޾Ƽ� �ش� ������ ��ȸ �Ѵ�.
        ' �ۼ��� : ������
        ''�ۼ��� : 2008-12-12
        ''������ : 
        ''������ : 
        '' </summary>
        Public Sub SetRequest(ByVal strBaseYear As String, ByVal strBranchNum As String, ByVal strFrYear As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpFromYearMonths.TextValue = strFrYear '��������
            Me.dtpToYearMonths.TextValue = strBaseYear  '��������
            Me.popBranchNum.TextValue = strBranchNum '������ȣ

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

    End Class

End Namespace
