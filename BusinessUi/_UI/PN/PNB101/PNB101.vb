'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �����������
' form ���� : ����������� �Ѵ�.
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

    Public Class PNB101
        Inherits CommonControls.UiControl

        Private Sub PNB101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill  ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
            End If
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.   <����M>
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "a;r;y;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;90;;c;" & "o;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;80;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�μ���;DeptNm;80;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����;ChargeEmpNum;80;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ڸ�;ChargeEmpNumNm;80;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���������;ChargeTypeCd;120;;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|��������;BizArea;120;;l;" & "o;n;n;10;"    ' ��������
            gridAttributes = gridAttributes & "|�������ó;MkTargetGroup;120;;l;" & "o;n;n;10;"    ' �ֿ䱸�����ó
            gridAttributes = gridAttributes & "|�������;OpenDate;120;####-##-##;c;" & "o;n;n;10;"    ' ��������
            gridAttributes = gridAttributes & "|������;CloseDate;120;####-##-##;c;" & "o;n;n;10;"    ' ������
            gridAttributes = gridAttributes & "|�󱹻���;CloseRemark;120;;l;" & "o;n;n;10;"    ' �󱹻���

            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '���ڸ� ���߱� ��

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ChargeTypeCd;����������ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '==============================================================                                                                           
            '  grid_3 �� �ʱ�ȭ �Ѵ�.   <�����繫��(����)>                                                                                        
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;c;" & "io;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;30;"
            '' '' '' ''2009.01.23 �ڱ�ö ���� ��û�� ���Ͽ� �������� ǥ�� �ȵǰ� ����
            gridAttributes = gridAttributes & "|��������;TransferDate;8;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|����Ƚ��;TransferNum;4;;c;" & "io;n;n;4;"

            gridAttributes = gridAttributes & "|ó������;ProcessDivCd;10;;c;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|��౸��;ContractDivCd;10;;c;" & "io;n;n;10;"

            gridAttributes = gridAttributes & "|�ǹ���;OwnerNm;30;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����������;RentDepositAmt;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|����;RentAmt;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|����������;ContractStDt;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|��ุ������;ContractEdDt;8;;l;" & "io;n;n;8;"

            gridAttributes = gridAttributes & "|�����ּ�;Addr;100;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|���������ȣ;PostNum;10;;c;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|ä��Ȯ��;Obligation;30;;l;" & "io;n;n;30;"

            gridAttributes = gridAttributes & "|���౸���ڵ�;BankCd;10;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;30;;l;" & "io;n;n;30;"

            '' '' ''2009.01.23 ����ȣ ���忡 ���Ͽ� ���� ���� ��(�׸��� �׸� ��ü ������)
            gridAttributes = gridAttributes & "|�൵�̹������ϰ��;OutlineMapFilePath;0;;l;" & "o;n;y;0;"
            gridAttributes = gridAttributes & "|�������;SiteArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|�ǹ����;BuildingArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|������;UseArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|������;Floor;10;;l;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|���ѹ���;LimitedItem;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�빰�㺸-�����ڸ�;SecurityOwnerNm;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�빰�㺸-�����ȣ;SecurityPostNum;10;;l;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|�빰�㺸-�ּ�;SecurityAddr;100;;l;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|�빰�㺸-�������;SecuritySiteArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|�빰�㺸-�ǹ����;SecurityBuildingArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|�빰�㺸-���ѹ���;SecurityLimitedItem;50;;l;" & "io;n;y;50;"
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;30;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ǹ��ֿ��ǰ���;OwnerRelation;10;;l;" & "io;y;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;y;10;"    '���ڸ� ���߱� ��

            'grd_3 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ProcessDivCd;�����繫��ó�������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ContractDivCd;�����繫�ǰ�౸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/OwnerRelation;�ǹ��ֿ��ǰ���"
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_3.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_4 �� �ʱ�ȭ �Ѵ�.      <�����μ����>                                                                                   
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;c;" & "io;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;30;" '(10)
            gridAttributes = gridAttributes & "|����;Orders;4;;r;" & "io;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|�μ�ó;PrintOfficeCd;10;;l;" & "io;n;n;10;"       '(30)
            gridAttributes = gridAttributes & "|�Ǳ����ڵ�;PrintPlateCd;10;;l;" & "io;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '���ڸ� ���߱� ��
            'grd_4 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "PrintOfficeCd;���屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd;�Ǳ����ڵ�"
            grd_4.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_4.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_5 �� �ʱ�ȭ �Ѵ�.        <�������>                                                                                      
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "io;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;30;" '(10)
            gridAttributes = gridAttributes & "|����;Orders;4;;;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|��񱸺��ڵ�;DivisionCd;10;;;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|���󼼳���;EquipmentNm;30;;;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;Cnt;4;#,##0;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�ݾ�;Amount;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|��������;StartDt;8;####-##-##;c;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|�������;EndDt;8;####-##-##;c;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|���;Remark;1000;;;" & "io;n;n;1000;"
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '���ڸ� ���߱� ��
            'grd_5 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "DivisionCd;��񱸺��ڵ�"
            grd_5.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_5.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_6 �� �ʱ�ȭ �Ѵ�.       <������������>                                                            
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;c;" & "io;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;30;" '(10)
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;4;;r;" & "io;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|�����ȣ�ڵ�;ZipSeriesNum;10;;l;" & "io;y;n;10;�����ȣ;Addr"       '(30)
            gridAttributes = gridAttributes & "|�ּ�;Addr;100;;l;" & "o;n;n;100;"       '(40)
            gridAttributes = gridAttributes & "|�������ó;MkTargetGroup;80;;l;" & "io;n;n;10;"    ' �ֿ䱸�����ó '200801013
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '���ڸ� ���߱� ��
            'grd_6 code combo                                                                                                                       
            gridCodeNameList = ""
            grd_6.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_6.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_7 �� �ʱ�ȭ �Ѵ�.       <�������>                                                             
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "io;n;n;7;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;120;;l;" & "o;n;n;30;" '(10)
            gridAttributes = gridAttributes & "|��������;ProcessDt;8;;;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;7;;;" & "io;n;n;7;������� ��;EmployeeNameHangul;"
            gridAttributes = gridAttributes & "|����ڸ�;ChargeEmpNumNm;7;;;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|����������ڵ�;ChargeTypeCd;10;;;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;10;;;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '���ڸ� ���߱� ��
            'grd_7 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ChargeTypeCd;����������ڵ�"
            grd_7.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_7.ExplorerBar = 1

            '''''
            Me.grd_7.Focus() : Me.grd_7.Visible = True
            lbl_grd_Title.Text = "[ " & Me.btngrd_7.Text & " ]"

        End Sub

        Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrd_3.Click, _
         btngrd_4.Click, btngrd_5.Click, btngrd_6.Click, btngrd_7.Click

            grd_3.Visible = False
            grd_4.Visible = False
            grd_5.Visible = False
            grd_6.Visible = False
            grd_7.Visible = False

            Dim strGridName As String = Mid(Me.ActiveControl.Name, 4, 5)

            btnPlus.Visible = True
            btnSave.Visible = True
            btnDelete.Visible = True

            If Me.grd_3.Name = strGridName Then
                Me.grd_3.Focus() : Me.grd_3.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"

                ''' 2009.01.23  ����ȣ ���� ��û���� ���Ͽ� ��� ��� ȭ��(����) ���� ó�� - ������ Ȯ��
                btnPlus.Visible = False
                btnSave.Visible = False
                btnDelete.Visible = False

            ElseIf Me.grd_4.Name = strGridName Then
                Me.grd_4.Focus() : Me.grd_4.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"
            ElseIf Me.grd_5.Name = strGridName Then
                Me.grd_5.Focus() : Me.grd_5.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"
            ElseIf Me.grd_6.Name = strGridName Then
                Me.grd_6.Focus() : Me.grd_6.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"
            ElseIf Me.grd_7.Name = strGridName Then
                Me.grd_7.Focus() : Me.grd_7.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"
            End If

        End Sub

        Private Sub grdAddRow(ByVal _grd As ubiLease.GridControl.grd, ByVal pic As Windows.Forms.PictureBox)
            ''================================ 
            '' �ش� ������ �繫��, �μ� ����, ��� ����, ����� ������ ����ϰ� �����Ҷ� ������ ���� �߰��Ѵ�.
            '' �̵��� ��
            '' 1. ���� ���� ������
            '' 2. ���� ����� ������.
            '' 

        End Sub

        Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click

            If Me.txtBranchCd.TextValue <> "" Then
                If Me.grd_3.Visible = True Then
                    Me.grd_3.AddRow()
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SiteArea"), 0) '
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("BuildingArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("UseArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SecuritySiteArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SecurityBuildingArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("RentDepositAmt"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("RentAmt"), 0)
                ElseIf Me.grd_4.Visible = True Then
                    Me.grd_4.AddRow()
                    Me.grd_4.set_TextMatrix(Me.grd_4.Rows - 1, Me.grd_4.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue) '
                ElseIf Me.grd_5.Visible = True Then
                    Me.grd_5.AddRow()
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue)
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("Cnt"), 0)
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("Amount"), 0)
                ElseIf Me.grd_6.Visible = True Then
                    Me.grd_6.AddRow()
                    Me.grd_6.set_TextMatrix(Me.grd_6.Rows - 1, Me.grd_6.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue)
                ElseIf Me.grd_7.Visible = True Then
                    Me.grd_7.AddRow()
                    Me.grd_7.set_TextMatrix(Me.grd_7.Rows - 1, Me.grd_7.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue)
                End If
            End If

        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            'If Me.txtNewGubn.TextValue <> "" Then
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
                End If
            'End If
        End Sub

        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
            'If Me.txtNewGubn.TextValue <> "" Then
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
            End If
            'End If
        End Sub

        ''' <summary>
        ''' �Լ��� : PNB101_Enter 
        ''' ��  �� : ȭ�� ��ȯ(���� ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNB101_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2))
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
        Public Sub SetRequest(ByVal strBranchCd As String, ByVal strBranchNm As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.txtBranchCd.TextValue = strBranchCd      '�����ڵ�
            Me.txtBranchNm_2.TextValue = strBranchNm      '������

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

   
    End Class

End Namespace
