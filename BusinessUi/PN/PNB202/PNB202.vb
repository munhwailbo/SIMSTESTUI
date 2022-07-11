'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���������
' form ���� : ��������� �Ѵ�.
' �ۼ��� : Ȳ����
' �ۼ��� : 2008-09-17
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

    Public Class PNB202
        Inherits CommonControls.UiControl

        Private Sub PNB202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill  ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
            End If
        End Sub

        ''' <summary>
        ''' �Լ��� : PNB202_Enter 
        ''' ��  �� : ȭ�� ��ȯ(���� ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNB202_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                SetBranchCd(ShareParameters(1))
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
            End If
        End Sub

        '====================================================================================================
        Public Sub Initialize()

            '����� ����
            popChargeEmpNum.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popChargeEmpNum.Enabled = False
                popChargeEmpNum.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                GmainBusinessFunction.GetValue("�α��� ID"), _
                                                GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

            ' ���Ժ����ݰ�� �ϳ������� ��
            lbl_napkum.Visible = False
            lbl_wankum.Visible = False
            num_napTkum.Visible = False
            num_wanTkum.Visible = False

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;120;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;150;;c;" & "o;n;y;7;���� ��;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|ȸ��;ChangeNum;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�������;ContractDt;120;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ϰῩ��;ContractYN;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����强��;BranchChiefCdName;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;80;;c;" & "o;n;n;10;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 1

            '==============================================================                                                                           
            '  grid_3 �� �ʱ�ȭ �Ѵ�.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;c;" & "io;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;150;;c;" & "o;n;n;7;"

            gridAttributes = gridAttributes & "|��������;TransferDate;8;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|����Ƚ��;TransferNum;4;;l;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|ó�������ڵ�;ProcessDivCd;10;;c;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|��౸���ڵ�;ContractDivCd;10;;c;" & "io;n;y;10;"

            gridAttributes = gridAttributes & "|�ǹ���;OwnerNm;30;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����������;RentDepositAmt;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|����;RentAmt;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|����������;ContractStDt;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|��ุ������;ContractEdDt;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|���������ȣ;PostNum;10;;c;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|�����ּ�;Addr;100;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|ä��Ȯ��;Obligation;30;;l;" & "io;n;n;30;"

            '' '' ''2009.01.23 ����ȣ ���忡 ���Ͽ� ���� ���� ��(�׸��� �׸� ��ü ������)
            gridAttributes = gridAttributes & "|�൵�̹������ϰ��;OutlineMapFilePath;0;;l;" & "o;n;y;0;"
            gridAttributes = gridAttributes & "|�������;SiteArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|�ǹ����;BuildingArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|������;UseArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|������;Floor;10;;l;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|���ѹ���;LimitedItem;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�빰�㺸-�����ڸ�;SecurityOwnerNm;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�빰�㺸-�����ȣ;SecurityPostNum;10;;l;" & "io;n;y;10;�����ȣ;CodeHangulName"
            gridAttributes = gridAttributes & "|�ּ�;CodeHangulName;90;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�빰�㺸-�ּ�;SecurityAddr;100;;l;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|�빰�㺸-�������;SecuritySiteArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|�빰�㺸-�ǹ����;SecurityBuildingArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|�빰�㺸-���ѹ���;SecurityLimitedItem;50;;l;" & "io;n;y;50;"
            gridAttributes = gridAttributes & "|���౸���ڵ�;BankCd;10;;l;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�ǹ��ֿ��ǰ���;OwnerRelation;10;;l;" & "io;n;y;10;"

            'grd_3 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ProcessDivCd;ó�������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ContractDivCd;��౸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/BankCd;���౸���ڵ�"
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_3.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_4 �� �ʱ�ȭ �Ѵ�.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;c;" & "io;n;n;7;�����ڵ�;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|������;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|����;Orders;4;;r;" & "io;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|���屸���ڵ�;PrintOfficeCd;10;;l;" & "io;n;n;10;"       '(30)
            gridAttributes = gridAttributes & "|�Ǳ����ڵ�;PrintPlateCd;10;;l;" & "io;n;n;10;"       '(40)
            'grd_4 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "PrintOfficeCd;���屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd;�Ǳ����ڵ�"
            grd_4.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_4.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_5 �� �ʱ�ȭ �Ѵ�.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "io;n;n;7;�����ڵ�;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|������;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|����;Orders;4;;;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|��񱸺��ڵ�;DivisionCd;10;;;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|���󼼳���;EquipmentNm;30;;;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;Cnt;4;;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�ݾ�;Amount;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|��������;StartDt;8;;;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|�������;EndDt;8;;;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|���;Remark;1000;;;" & "io;n;n;1000;"
            'grd_5 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "DivisionCd;��񱸺��ڵ�"
            grd_5.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_5.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_6 �� �ʱ�ȭ �Ѵ�.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;c;" & "io;n;n;7;�����ڵ�;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|������;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;4;;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�����ȣ�ڵ�;ZipSeriesNum;10;;l;" & "io;n;n;10;�����ȣ;CodeHangulName"
            gridAttributes = gridAttributes & "|�ּ�;CodeHangulName;90;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�ּ�;Addr;100;;l;" & "o;n;n;100;"
            'grd_6 code combo                                                                                                                       
            gridCodeNameList = ""
            grd_6.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_6.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_7 �� �ʱ�ȭ �Ѵ�.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;7;;;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|������;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|���񼭷��ڵ�;ReqDocCd;8;;;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|���⿩��;SubmitYN;7;;;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|���;remark;10;;;" & "io;n;n;10;"

            'grd_7 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ReqDocCd;���񼭷��ڵ�"
            grd_7.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_7.ExplorerBar = 1


            '==============================================================                                                                           
            '  grd_8 �� �ʱ�ȭ �Ѵ�.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;7;;l;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|������;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|����;Orders;8;;r;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|������-�ϳ������� ����;DepositDivCd;7;;c;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|��������;ReceiptDt;10;####-##-##;c;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|�����ڵ�;AccountCd;7;;c;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|�ݾ�;DepositAmt;10;#,##0;r;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|������;PayYYYYMM;10;####-##;c;" & "io;n;n;10;"

            'grd_8 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "DepositDivCd;�����������ݱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/AccountCd;�Աݱ����ڵ�"


            grd_8.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_8.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_9 �� �ʱ�ȭ �Ѵ�.    �ܰ�                                                                                                             
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;7;;l;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|������;BranchNm;7;;l;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|����;Orders;8;;r;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|��������;ApplyDt;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|���Դܰ�1;ValAmount1;20;#,##0;c;" & "io;n;n;20;"
            gridAttributes = gridAttributes & "|���Դܰ�2;ValAmount2;20;#,##0;c;" & "io;n;n;20;"
            gridAttributes = gridAttributes & "|���Դܰ�3;ValAmount3;20;#,##0;c;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|���Դܰ�4;ValAmount4;20;#,##0;c;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|����;AccountCd;20;;c;" & "io;n;y;200;"
            gridAttributes = gridAttributes & "|;Dummy;20;;c;" & "io;n;n;10;"

            'grd_9 code combo                                                                                                                       
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "DepositDivCd;�����������ݱ����ڵ�"

            grd_9.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_9.ExplorerBar = 1

            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            '==============================================================                                                                           
            '  grd_10 �� �ʱ�ȭ �Ѵ�.    �渮�ŷ�ó                                                                                                             
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;7;;l;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|������;BranchNm;7;;l;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|��������;StDate;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|�ŷ�ó�ڵ�;CustomerCode;7;;l;" & "io;n;n;7;�ŷ�ó�ڵ�;CustomerName"
            gridAttributes = gridAttributes & "|�ŷ�ó��;CustomerName;7;;l;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|����;Remark;20;;c;" & "io;n;n;200;"
            gridAttributes = gridAttributes & "|;Dummy;20;;c;" & "io;n;n;10;"

            gridCodeNameList = ""
            grd_10.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_10.ExplorerBar = 1
            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx


        End Sub

        Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrd_3.Click, _
         btngrd_4.Click, btngrd_5.Click, btngrd_6.Click, btngrd_7.Click, btngrd_8.Click, btngrd_9.Click, btngrd_10.Click

            grd_3.Visible = False
            grd_4.Visible = False
            grd_5.Visible = False
            grd_6.Visible = False
            grd_7.Visible = False
            grd_8.Visible = False
            grd_9.Visible = False
            grd_10.Visible = False

            ' ���Ժ����ݰ�� �ϳ������� ��
            lbl_napkum.Visible = False
            lbl_wankum.Visible = False
            num_napTkum.Visible = False
            num_wanTkum.Visible = False

            Me.lbl_grd_Title.Text = "[" & Me.ActiveControl.Text & "]"
            btnPlus.Visible = False : btnSave.Visible = False : btnDelete.Visible = False

            Dim strGridName As String = Mid(Me.ActiveControl.Name, 4, 6)  '???????????????????????? 10�ص� �ǳ�?.. �ȵɲ� ������

            If Me.grd_3.Name = strGridName Then
                Me.grd_3.Focus() : Me.grd_3.Visible = True
            ElseIf Me.grd_4.Name = strGridName Then
                Me.grd_4.Focus() : Me.grd_4.Visible = True
            ElseIf Me.grd_5.Name = strGridName Then
                Me.grd_5.Focus() : Me.grd_5.Visible = True
            ElseIf Me.grd_6.Name = strGridName Then
                Me.grd_6.Focus() : Me.grd_6.Visible = True
            ElseIf Me.grd_7.Name = strGridName Then    '���񼭷�
                Me.grd_7.Focus() : Me.grd_7.Visible = True
                btnPlus.Visible = True : btnSave.Visible = True : btnDelete.Visible = True
            ElseIf Me.grd_8.Name = strGridName Then    '���뺸����
                Me.grd_8.Focus() : Me.grd_8.Visible = True
                btnPlus.Visible = True : btnSave.Visible = True : btnDelete.Visible = True
                lbl_napkum.Visible = True : lbl_wankum.Visible = True
                num_napTkum.Visible = True : num_wanTkum.Visible = True   ' ���Ժ����ݰ� �ϳ������� ��
            ElseIf Me.grd_9.Name = strGridName Then    '�ܰ�
                Me.grd_9.Focus() : Me.grd_9.Visible = True
                btnPlus.Visible = True : btnSave.Visible = True : btnDelete.Visible = True
            ElseIf Me.grd_10.Name = strGridName Then   '�渮�ŷ�ó
                Me.grd_10.Focus() : Me.grd_10.Visible = True
                btnPlus.Visible = True : btnSave.Visible = True : btnDelete.Visible = True
            End If

        End Sub

        Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click

            If Me.txtNewGubn.TextValue <> "" Then
                If Me.grd_3.Visible = True Then
                    Me.grd_3.AddRow()
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("BranchCd"), Me.txtBranchNum.TextValue)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SiteArea"), 0) '
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("BuildingArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("UseArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SecuritySiteArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SecurityBuildingArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("RentDepositAmt"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("RentAmt"), 0)
                ElseIf Me.grd_4.Visible = True Then
                    Me.grd_4.AddRow()
                    Me.grd_4.set_TextMatrix(Me.grd_4.Rows - 1, Me.grd_4.get_ColIndex("BranchCd"), Me.popBranchCd.TextValue)
                ElseIf Me.grd_5.Visible = True Then
                    Me.grd_5.AddRow()
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("BranchCd"), Me.popBranchCd.TextValue)
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("Cnt"), 0)
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("Amount"), 0)
                ElseIf Me.grd_6.Visible = True Then
                    Me.grd_6.AddRow()
                    Me.grd_6.set_TextMatrix(Me.grd_6.Rows - 1, Me.grd_6.get_ColIndex("BranchCd"), Me.popBranchCd.TextValue)
                ElseIf Me.grd_7.Visible = True Then
                    Me.grd_7.AddRow()
                    Me.grd_7.set_TextMatrix(Me.grd_7.Rows - 1, Me.grd_7.get_ColIndex("BranchNum"), Me.txtBranchNum.TextValue)
                ElseIf Me.grd_8.Visible = True Then
                    Me.grd_8.AddRow()
                    Me.grd_8.set_TextMatrix(Me.grd_8.Rows - 1, Me.grd_8.get_ColIndex("BranchNum"), Me.txtBranchNum.TextValue)
                    Me.grd_8.set_TextMatrix(Me.grd_8.Rows - 1, Me.grd_8.get_ColIndex("DepositAmt"), 0)
                ElseIf Me.grd_9.Visible = True Then
                    Me.grd_9.AddRow()
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("BranchNum"), Me.txtBranchNum.TextValue)
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("ValAmount1"), 0)
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("ValAmount2"), 0)
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("ValAmount3"), 0)
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("ValAmount4"), 0)
                ElseIf Me.grd_10.Visible = True Then
                    Me.grd_10.AddRow()
                    Me.grd_10.set_TextMatrix(Me.grd_10.Rows - 1, Me.grd_10.get_ColIndex("BranchNum"), Me.txtBranchNum.TextValue)
                End If
            Else
                MsgBox("���� ��� ������ ���� �����ϼ���", MsgBoxStyle.Information)
            End If

        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            If Me.txtNewGubn.TextValue <> "" Then
                If Me.grd_3.Visible = True Then
                    Call Me.SaveData_2()
                ElseIf Me.grd_4.Visible = True Then
                    Call Me.SaveData_3()
                ElseIf Me.grd_5.Visible = True Then
                    Call Me.SaveData_4()
                ElseIf Me.grd_6.Visible = True Then
                    Call Me.SaveData_5()
                ElseIf Me.grd_7.Visible = True Then
                    Call Me.SaveData_6()
                ElseIf Me.grd_8.Visible = True Then
                    Call Me.SaveData_7()
                ElseIf Me.grd_9.Visible = True Then
                    Call Me.SaveData_8()
                ElseIf Me.grd_10.Visible = True Then
                    Call Me.SaveData_10()
                End If
            End If
        End Sub

        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
            If Me.txtNewGubn.TextValue <> "" Then
                If Me.grd_3.Visible = True Then
                    Call Me.DeleteData_2()
                ElseIf Me.grd_4.Visible = True Then
                    Call Me.DeleteData_3()
                ElseIf Me.grd_5.Visible = True Then
                    Call Me.DeleteData_4()
                ElseIf Me.grd_6.Visible = True Then
                    Call Me.DeleteData_5()
                ElseIf Me.grd_7.Visible = True Then
                    Call Me.DeleteData_6()
                ElseIf Me.grd_8.Visible = True Then
                    Call Me.DeleteData_7()
                ElseIf Me.grd_9.Visible = True Then
                    Call Me.DeleteData_8()
                ElseIf Me.grd_10.Visible = True Then
                    Call Me.DeleteData_10()
                End If
            End If
        End Sub

        ''' <summary>
        ''' �Լ��� : SetBranchCd
        ''' ��  �� : �ٸ� ȭ�鿡�� ���� �ڵ� �� �޾Ƽ� �ش� ���������� ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetBranchCd(ByVal strBranchCd As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.popBaseBranchCd_R.TextValue = strBranchCd  '�����ڵ� 

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub btnJumpChiefCd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumpChiefCd.Click
            '���ڱ�������ȭ������ �̵�
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim strBranchChiefName As String '�������
            Dim strChiefCd As String '�������ڵ�

            strBranchChiefName = popBranchChiefCd.NameText  '�������
            strChiefCd = popBranchChiefCd.TextValue         '�������ڵ�

            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNB201;" & strBranchChiefName & ";" & strChiefCd)
            Me.ShowUiControl("PNB201", strBranchChiefName)
        End Sub

        Private Sub btnJumpBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumpBranch.Click
            '��������ȭ������ �̵�
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim strBranchCd As String '�����ڵ�
            Dim strBranchNm As String '������

            strBranchCd = popBranchCd.TextValue   '�����ڵ�
            strBranchNm = popBranchCd.NameText    '������

            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNB101;" & strBranchCd & ";" & strBranchNm)
            Me.ShowUiControl("PNB101", strBranchNm)
        End Sub

    End Class

End Namespace
