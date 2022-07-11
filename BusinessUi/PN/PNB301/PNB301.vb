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

    Public Class PNB301
        Inherits CommonControls.UiControl

        Private Sub PNB301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|����;TreePath;114;;1;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|�������;ChargeEmpNumNm;63;;1;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;76;;1;" & "o;n;n;9;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|������;BranchNm;89;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ڸ�;BranchChiefCdNm;62;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�������;ContractDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|����������;ContractStDt;0;yyyy-MM-dd;4;" & "o;n;y;8;"
            gridAttributes = gridAttributes & "|�����������;ContractEdDt;0;yyyy-MM-dd;4;" & "o;n;y;8;"
            gridAttributes = gridAttributes & "|�����������;ContractCancelDt;87;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|�߼ۺμ�;DeliveryPaperNum;61;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��������;ValPaperNum;61;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��������;BranchValPaperNum;0;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|����������;DepositAmt;85;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|�ϳ�������;DepositDivCd;85;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|�հ�;SumAmt;85;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|�ǿ��;RealOperatorName;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ڰ���;OperatorRelation;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|������ڵ�;ManageDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|��üȽ��;ChangeNum;50;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��ü����;ChangeReason;68;;1;" & "o;n;n;1000;"
            gridAttributes = gridAttributes & "|�����ּ�;Addr;197;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|������ȭ��ȣ1;PhoneNum1;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|������ȭ��ȣ2;PhoneNum2;95;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ѽ���ȣ;FaxNum;106;;1;" & "o;n;n;30;"   
            gridAttributes = gridAttributes & "|�����μ���;GuarantorNm;74;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ΰ���;GuarantorRelation;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;71;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;135;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�б���;OfficeNum;50;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|������;HouseNum;44;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��������;TransferDate;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|����Ƚ��;TransferNum;62;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�μ������ڵ�;PrintRegionCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|��ü�����ڵ�;ChangeDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|��ڼ���;OperatorName;74;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����ֹι�ȣ;OperatorSocialNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|���ϰῩ��;ContractYN;76;;1;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|�������ֹι�ȣ;GuarantorSocialNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|��������꼼���ο���;GuarantorPropertyTaxAmt;136;;1;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|����������ڵ�;ChargeTypeCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�μ���;DeptNm;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�μ������ڵ�(��¿�);DeptDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ó��;OpenYYYYMM;0;yyyy-MM;4;" & "o;n;y;6;"
            gridAttributes = gridAttributes & "|�������;EndYYYYMM;0;yyyy-MM;4;" & "o;n;y;6;"
            gridAttributes = gridAttributes & "|�Ϲݴܰ�;UnitCost;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|Ư���ܰ�;SpecUnitCost;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|ó�������ڵ�;ProcessDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|��౸���ڵ�;ContractDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����������;RentDepositAmt;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|������;RentAmt;0;#,##0;7;" & "o;n;y;15;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ChargeTypeCd;����������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ChangeDivCd;��ü�����ڵ�"
            gridCodeNameList = gridCodeNameList & "/ManageDivCd;������ڵ�"
            gridCodeNameList = gridCodeNameList & "/PrintRegionCd;�μ������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BranchRegionCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ProcessDivCd;ó�������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ContractDivCd;��౸���ڵ�"
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
            '���� ���� ȭ������ ���� �ڵ带 �Ѱܼ� �ش� ���� ������ ��ȸ �Ѵ�.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim strBranchCd As String '���� �ڵ�

            strBranchCd = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("BranchCd")) '���� �ڵ�

            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNB202;" & strBranchCd)
            Me.ShowUiControl("PNB202", strBranchCd)
        End Sub

        Private Sub picCriteria_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCriteria_1.Click

        End Sub
    End Class

End Namespace
