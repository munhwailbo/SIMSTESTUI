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

    Public Class PNA301
        Inherits CommonControls.UiControl
        Private Sub PNA301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

        Public Sub Initialize()

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code

            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;6;;;" & "o;n;n;6;"       '(90)
            gridAttributes = gridAttributes & "|��� �� �ѱ�;EmployeeNameHangul;20;;;" & "o;n;n;20;"       '(110)
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "o;n;n;7;"       '(10)
            gridAttributes = gridAttributes & "|������;BranchNm;30;;;" & "o;n;n;30;"       '(20)
            ''gridAttributes = gridAttributes & "|����������ڵ�;ChargeTypeCd;10;;;" & "o;n;y;10;"       '(30)
            ''gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;7;;;" & "o;n;y;7;"       '(40)
            'grid_1 code combo    

            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)


            '==============================================================
            '  grid_3 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;9;;;" & "io;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "io;n;n;7;"       '(20)
            gridAttributes = gridAttributes & "|��üȽ��;ChangeNum;4;;;" & "io;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|�������;ContractDt;8;;;" & "io;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|����������;ContractStDt;8;;;" & "io;n;n;8;"       '(50)
            gridAttributes = gridAttributes & "|�����������;ContractEdDt;8;;;" & "io;n;n;8;"       '(60)
            gridAttributes = gridAttributes & "|�����������;ContractCancelDt;8;;;" & "io;n;n;8;"       '(70)
            gridAttributes = gridAttributes & "|������;BranchNm;30;;;" & "io;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;7;;;" & "io;n;n;7;"       '(100)
            gridAttributes = gridAttributes & "|����������ڵ�;ChargeTypeCd;10;;;" & "io;n;n;10;"       '(110)
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;10;;;" & "io;n;n;10;"       '(120)
            gridAttributes = gridAttributes & "|�μ������ڵ�(��¿�);DeptDivCd;10;;;" & "io;n;n;10;"       '(130)
            gridAttributes = gridAttributes & "|����ó��;OpenYYYYMM;6;;;" & "io;n;n;6;"       '(140)
            gridAttributes = gridAttributes & "|�������;EndYYYYMM;6;;;" & "io;n;n;6;"       '(150)
            gridAttributes = gridAttributes & "|��ü�����ڵ�;ChangeDivCd;10;;;" & "io;n;n;10;"       '(160)
            gridAttributes = gridAttributes & "|������ڵ�;ManageDivCd;10;;;" & "io;n;n;10;"       '(170)
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;10;;;" & "io;n;n;10;"       '(190)
            'grid_3 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_3.ExplorerBar = Me.grd_3.get_ColIndex("EmployeeNumber")

            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;9;;;" & "io;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "io;n;n;7;"       '(20)
            gridAttributes = gridAttributes & "|��üȽ��;ChangeNum;4;;;" & "io;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|�������;ContractDt;8;;;" & "io;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|����������;ContractStDt;8;;;" & "io;n;n;8;"       '(50)
            gridAttributes = gridAttributes & "|�����������;ContractEdDt;8;;;" & "io;n;n;8;"       '(60)
            gridAttributes = gridAttributes & "|�����������;ContractCancelDt;8;;;" & "io;n;n;8;"       '(70)
            gridAttributes = gridAttributes & "|������;BranchNm;30;;;" & "io;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;7;;;" & "io;n;n;7;"       '(100)
            gridAttributes = gridAttributes & "|����������ڵ�;ChargeTypeCd;10;;;" & "io;n;n;10;"       '(110)
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;10;;;" & "io;n;n;10;"       '(120)
            gridAttributes = gridAttributes & "|�μ������ڵ�(��¿�);DeptDivCd;10;;;" & "io;n;n;10;"       '(130)
            gridAttributes = gridAttributes & "|����ó��;OpenYYYYMM;6;;;" & "io;n;n;6;"       '(140)
            gridAttributes = gridAttributes & "|�������;EndYYYYMM;6;;;" & "io;n;n;6;"       '(150)
            gridAttributes = gridAttributes & "|��ü�����ڵ�;ChangeDivCd;10;;;" & "io;n;n;10;"       '(160)
            gridAttributes = gridAttributes & "|������ڵ�;ManageDivCd;10;;;" & "io;n;n;10;"       '(170)
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;10;;;" & "io;n;n;10;"       '(190)
            'grid_4 code combo    
            gridCodeNameList = ""
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_4.ExplorerBar = Me.grd_4.get_ColIndex("EmployeeNumber")

        End Sub
       

        
    End Class

End Namespace
