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

    Public Class PNI402
        Inherits CommonControls.UiControl

        Private Sub PNI402_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|����;TreePath;102;;1;" & "io;n;n;5;"
            
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����;ChargeEmpNm;50;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchNum;1;;4;" & "o;n;n;10;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;56;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;0;;4;" & "o;n;y;10;���������ڵ�;;"
            gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�������;BranchChiefNm;50;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����;OldOrNew;57;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���������;ContractDt;70;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|������;CloseDate;70;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|������;YearMonths;63;yyyy-MM;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����̼���;LastUnColAmt;84;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��������;ThisSaleAmt;78;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|���û����;ThisDemandAmt;78;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��ü���ݾ�;ThisDeduAmt;69;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�Աݼ��ݾ�;ThisTransAmt;74;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|������ݰ�;ThisInComAmt;78;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|������;ColRate;50;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|����̼���;ThisUnColAmt;78;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��ü�̼���;TotUnColAmt;78;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����������;DepositAmt1;85;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�ϳ�������;DepositAmt2;85;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����ݰ�;DepositAmtT;85;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�߼ۺμ�;DeliveryPaperNum;62;#,##0;7;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;ValPaperNum;62;#,##0;7;" & "o;n;n;10;"
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
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '����� ����
            popChargeEmpNum.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popChargeEmpNum.Enabled = False
                popChargeEmpNum.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                GmainBusinessFunction.GetValue("�α��� ID"), _
                                                GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

        End Sub

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '���Ȯ�� ���� ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '�������ڹ�ȣ
            Dim sdate As String
            sdate = dtpBaseYear.TextValue.Substring(0, 4) + "-" + "01"
            strCode = Me.dtpBaseYear.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("BranchNum") _
                      & ";" & sdate
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNI403;" & strCode)
            Me.ShowUiControl("PNI403", strCode)

        End Sub

    End Class

End Namespace