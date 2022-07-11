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

    Public Class PNB303
        Inherits CommonControls.UiControl

        Private Sub PNB303_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;9;;;" & "o;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "o;n;n;7;"       '(20)
            gridAttributes = gridAttributes & "|������;BranchNm;30;;;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|��üȽ��;ChangeNum;4;;;" & "o;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|��������;TransferDate;8;;;" & "o;n;n;8;"       '(440)
            gridAttributes = gridAttributes & "|����Ƚ��;TransferNum;4;;;" & "o;n;n;4;"       '(450)
            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;10;;;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|�������;BranchChiefCdNm;10;;;" & "o;n;n;10;"       '(80)

            gridAttributes = gridAttributes & "|�������;ContractDt;8;;;" & "o;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|����������;ContractStDt;8;;;" & "o;n;y;8;"       '(50)
            gridAttributes = gridAttributes & "|�����������;ContractEdDt;8;;;" & "o;n;y;8;"       '(60)
            gridAttributes = gridAttributes & "|�����������;ContractCancelDt;8;;;" & "o;n;y;8;"       '(70)

            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;7;;;" & "o;n;y;7;"       '(100)
            gridAttributes = gridAttributes & "|����ڸ�;ChargeEmpNumNm;7;;;" & "o;n;y;7;"       '(100)
            gridAttributes = gridAttributes & "|����������ڵ�;ChargeTypeCd;10;;;" & "o;n;y;10;"       '(110)
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;10;;;" & "o;n;y;10;"       '(120)
            gridAttributes = gridAttributes & "|�μ���;DeptNm;10;;;" & "o;n;y;10;"       '(120)
            gridAttributes = gridAttributes & "|�μ������ڵ�(��¿�);DeptDivCd;10;;;" & "o;n;y;10;"       '(130)
            gridAttributes = gridAttributes & "|����ó��;OpenYYYYMM;6;;;" & "o;n;y;6;"       '(140)
            gridAttributes = gridAttributes & "|�������;EndYYYYMM;6;;;" & "o;n;y;6;"       '(150)
            gridAttributes = gridAttributes & "|��ü�����ڵ�;ChangeDivCd;10;;;" & "o;n;y;10;"       '(160)
            gridAttributes = gridAttributes & "|������ڵ�;ManageDivCd;10;;;" & "o;n;y;10;"       '(170)
            gridAttributes = gridAttributes & "|�μ������ڵ�;PrintRegionCd;10;;;" & "o;n;y;10;"       '(180)
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;10;;;" & "o;n;n;10;"       '(190)
            gridAttributes = gridAttributes & "|������ȭ��ȣ1;PhoneNum1;30;;;" & "o;n;n;30;"       '(200)
            gridAttributes = gridAttributes & "|������ȭ��ȣ2;PhoneNum2;30;;;" & "o;n;n;30;"       '(210)
            gridAttributes = gridAttributes & "|�����ѽ���ȣ;FaxNum;30;;;" & "o;n;n;30;"       '(220)
            gridAttributes = gridAttributes & "|�б���;OfficeNum;4;;;" & "o;n;n;4;"       '(230)
            gridAttributes = gridAttributes & "|������;HouseNum;4;;;" & "o;n;n;4;"       '(240)
            gridAttributes = gridAttributes & "|����������;DepositAmt;15;#,##0;r;" & "o;n;n;15;"       '(250)
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;30;;;" & "o;n;n;30;"       '(260)
            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;10;;;" & "o;n;n;10;"       '(270)
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;30;;;" & "o;n;n;30;"       '(280)
            gridAttributes = gridAttributes & "|�Ϲݴܰ�;UnitCost;15;#,##0;r;" & "o;n;y;15;"       '(290)
            gridAttributes = gridAttributes & "|Ư���ܰ�;SpecUnitCost;15;#,##0;r;" & "o;n;y;15;"       '(300)
            gridAttributes = gridAttributes & "|�߼ۺμ�;DeliveryPaperNum;4;;c;" & "o;n;n;4;"       '(310)
            gridAttributes = gridAttributes & "|��������;ValPaperNum;4;#,##0;r;" & "o;n;n;4;"       '(320)
            gridAttributes = gridAttributes & "|��������;BranchValPaperNum;4;#,##0;r;" & "o;n;y;4;"       '(330)
            gridAttributes = gridAttributes & "|��ü����;ChangeReason;1000;;;" & "o;n;n;1000;"       '(340)
            gridAttributes = gridAttributes & "|�����μ���;GuarantorNm;30;;;" & "o;n;n;30;"       '(350)
            gridAttributes = gridAttributes & "|�����ΰ���;GuarantorRelation;10;;;" & "o;n;n;10;"       '(360)
            gridAttributes = gridAttributes & "|�������ֹι�ȣ;GuarantorSocialNum;30;;;" & "o;n;n;30;"       '(370)
            gridAttributes = gridAttributes & "|��������꼼����;GuarantorPropertyTaxAmt;1;;;" & "o;n;n;1;"       '(380)
            gridAttributes = gridAttributes & "|��ڼ���;OperatorName;30;;;" & "o;n;n;30;"       '(390)
            gridAttributes = gridAttributes & "|��ڰ���;OperatorRelation;10;;;" & "o;n;n;10;"       '(400)
            gridAttributes = gridAttributes & "|����ֹι�ȣ;OperatorSocialNum;30;;;" & "o;n;n;30;"       '(410)
            gridAttributes = gridAttributes & "|���ϰῩ��;ContractYN;1;;;" & "o;n;n;1;"       '(420)

            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "o;n;y;7;"       '(430)
            gridAttributes = gridAttributes & "|ó�������ڵ�;ProcessDivCd;10;;;" & "o;n;y;10;"       '(460)
            gridAttributes = gridAttributes & "|��౸���ڵ�;ContractDivCd;10;;;" & "o;n;y;10;"       '(470)
            gridAttributes = gridAttributes & "|�����ּ�;Addr;100;;;" & "o;n;n;100;"       '(500)
            gridAttributes = gridAttributes & "|����������;RentDepositAmt;15;#,##0;r;" & "o;n;y;15;"       '(660)
            gridAttributes = gridAttributes & "|������;RentAmt;15;#,##0;r;" & "o;n;y;15;"       '(670)
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

        End Sub
#End Region



    End Class

End Namespace
