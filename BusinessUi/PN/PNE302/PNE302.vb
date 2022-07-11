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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE302
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;60;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|Ȯ������;ExpandDt;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������������;FixedStDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|������������;FixedEdDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|D-M;Dday;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|����;Orders;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;70;;c;" & "o;n;n;40;Ȯ��ó ��;CompanyNm;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;70;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|�����μ�;TargetPaperTotNum;60;;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�űԺμ�;NewExpPapNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��Ȯ��μ�;ReExpPapNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;60;#,###;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ��ڵ�;BillPeriodCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;60;#,###;r;" & "o;n;n;5;"

            'gridAttributes = gridAttributes & "|�����μ�;TargetPaperTotNum;60;;r;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;60;#,###;r;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|���Ժμ�;SubscribePagerNum;60;#,###;r;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|�����Ժμ�;NotSubscribePagerNum;60;#,###;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|��������;ApprovalDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���;Note;70;;c;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|��ܾ��ºμ�;NoListPapNum;60;#,###;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|���Ժμ�;SubscribePagerNum;60;#,###;r;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�����Ժμ�;NoSubscribePagerNum;60;#,###;r;" & "o;n;y;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ProjectID;������Ʈ ��"
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1


            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;12;;;" & "io;n;y;12;"       '(190)
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;13;;;" & "o;n;y;13;"       '(10)
            gridAttributes = gridAttributes & "|��������;ContactDt;8;;;" & "o;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|����;Orders;4;#,##0;c;" & "o;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;30;;;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|�űԺμ�;NewConPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)
            gridAttributes = gridAttributes & "|��Ȯ��μ�;ReConPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)
            gridAttributes = gridAttributes & "|�����μ���;ContactPaperNum;4;#,##0;c;" & "o;n;n;4;"       '(61)

            gridAttributes = gridAttributes & "|�����ڸ�;AdEmployeeNm;70;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����ںμ�;AdEmployeeDeptNm;70;;c;" & "o;n;n;7;"

            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;30;;;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;30;;;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;10;;;" & "o;n;n;10;�����ȣ;OldAddr1;"       '(130)
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;50;;;" & "o;n;n;50;"       '(140)
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;100;;;" & "o;n;n;100;"       '(150)
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;7;;c;" & "o;n;n;7;�����ڵ�;DeliveryBranchNm;"       '(160)
            gridAttributes = gridAttributes & "|����������;DeliveryBranchNm;7;;;" & "o;n;n;7;"       '(160)
            gridAttributes = gridAttributes & "|�������޻���;BranchNote;70;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;8;;;" & "o;n;n;8;"       '(62)
            gridAttributes = gridAttributes & "|������������;FixedEdDt;8;;;" & "o;n;n;8;"       '(63)

            gridAttributes = gridAttributes & "|(��)ó���ڵ�;MonitoringResultCd;10;;;" & "o;n;n;10;"       '(370)
            gridAttributes = gridAttributes & "|(��)����������ڵ�;RefuseReasonCd;10;;;" & "o;n;n;10;"       '(380)
            gridAttributes = gridAttributes & "|(��)ó���ڻ��;MonitoringEmpNum;7;;;" & "o;n;n;7;"       '(350)
            gridAttributes = gridAttributes & "|(��)ó���ڸ�;MonitoringEmpNm;7;;;" & "o;n;n;7;"       '(350)
            gridAttributes = gridAttributes & "|(��)ó������;MonitoringProcDt;8;;;" & "o;n;n;8;"       '(360)

            gridAttributes = gridAttributes & "|�������뺸����;NotifyYN;1;;;" & "o;n;n;1;"       '(330)
            gridAttributes = gridAttributes & "|�������뺸����;SolicitorNotifyDt;8;;;" & "o;n;n;8;"       '(340)
            gridAttributes = gridAttributes & "|���;Note;1000;;;" & "o;n;n;1000;"       '(400)

            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "MonitoringResultCd;����Ͱ��ó���ڵ�"
            gridCodeNameList = gridCodeNameList & "/RefuseReasonCd;����͹���������ڵ�"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3


            '==============================================================
            '  grid_3 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------

            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;80;#,###;c;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;60;#,###;r;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|�����ڱ����ڵ�;SolicitorDivCd;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�������ڵ�;SolicitorEmpNum;80;;c;" & "io;n;n;5;��� ��;EmployeeNameHangul,SoliDeptCd,SoliDeptNm"
            gridAttributes = gridAttributes & "|�����;EmployeeNameHangul;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����μ��ڵ�;SoliDeptCd;80;;c;" & "io;n;n;40;�μ� ��;SoliDeptNm;"
            gridAttributes = gridAttributes & "|�����μ���;SoliDeptNm;80;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�ű�Ȯ��μ�;FixedPaperNum;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��Ȯ��μ�;ReFixedPaperNum;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���Ȯ��μ�;TargetPaperTotNum;70;#,###;r;" & "io;n;n;5;"
            'gridAttributes = gridAttributes & "|�����μ�;StopPaperNum;70;#,###;r;" & "io;n;n;40;"
            'gridAttributes = gridAttributes & "|���ν�������;IndividualYN;80;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|����������;RealSolicitorInfo;70;;c;" & "io;n;y;40;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "SolicitorDivCd;�����ڱ����ڵ�"
            Dim gridCriteriaPopupCodeList As String = ""
            gridCriteriaPopupCodeList = gridCriteriaPopupCodeList & "EmployeeNameHangul;�����μ��ڵ�,�����μ���"
            grd_3.Initialize(gridAttributes, gridCodeNameList, gridCriteriaPopupCodeList)
            Me.grd_3.ExplorerBar = 3

            Me.RequestData()

            '''''===========================================================================================
            '''' ====   �赿�������� ��û �������� ���� ���� �ʱ� �ּ� ó�� ���� 
            '''''===========================================================================================
            ' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            ' ''gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;12;;;" & "o;n;y;12;"       '(190)
            ' ''gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;13;;;" & "o;n;y;13;"       '(10)
            ' ''gridAttributes = gridAttributes & "|����;Orders;4;;;" & "o;n;n;4;"       '(30)
            ' ''gridAttributes = gridAttributes & "|��������;ContactDt;8;;;" & "o;n;n;8;"       '(20)
            ' ''gridAttributes = gridAttributes & "|���ο���;ApprovalYN;1;;;" & "o;n;n;1;"       '(390)
            ' ''gridAttributes = gridAttributes & "|��������;ApprovalDt;1;;;" & "o;n;n;1;"       '(390)

            ' ''gridAttributes = gridAttributes & "|�����μ�;ContactPaperNum;4;;;" & "o;n;n;4;"       '(61)
            ' ''gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;4;;;" & "o;n;n;4;"       '(64)

            ' ''gridAttributes = gridAttributes & "|�����ó���ھ��̵�;MonitoringEmpNum;7;;;" & "o;n;n;7;"       '(350)
            ' ''gridAttributes = gridAttributes & "|�����ó������;MonitoringProcDt;8;;;" & "o;n;n;8;"       '(360)
            ' ''gridAttributes = gridAttributes & "|�����ó���ڵ�;MonitoringResultCd;10;;;" & "o;n;n;10;"       '(370)
            ' ''gridAttributes = gridAttributes & "|����������ڵ�;RefuseReasonCd;10;;;" & "o;n;n;10;"       '(380)

            ' ''gridAttributes = gridAttributes & "|���ڻ����ڵ�;ReaderStateCd;10;;;" & "o;n;n;10;"       '(50)
            ' ''gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;30;;;" & "o;n;n;30;"       '(40)

            ' ''gridAttributes = gridAttributes & "|����ä���ڵ�;DeliveryChnlCd;10;;;" & "o;n;n;10;"       '(60)
            ' ''gridAttributes = gridAttributes & "|��������;FixedStDt;8;;;" & "o;n;n;8;"       '(62)
            ' ''gridAttributes = gridAttributes & "|������������;FixedEdDt;8;;;" & "o;n;n;8;"       '(63)
            ' ''gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceTerm;4;;;" & "o;n;n;4;"       '(65)
            ' ''gridAttributes = gridAttributes & "|���ݳ��;CollectionYYYYMM;6;;;" & "o;n;n;6;"       '(66)

            ' ''gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;30;;;" & "o;n;n;30;"       '(70)
            ' ''gridAttributes = gridAttributes & "|��ȭ��ȣ2;PhoneNum2;30;;;" & "o;n;n;30;"       '(80)
            ' ''gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;30;;;" & "o;n;n;30;"       '(90)
            ' ''gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;10;;;" & "o;n;n;10;"       '(130)
            ' ''gridAttributes = gridAttributes & "|�ּ�;OldAddr1;50;;;" & "o;n;n;50;"       '(140)
            ' ''gridAttributes = gridAttributes & "|���ּ�;OldAddr2;100;;;" & "o;n;n;100;"       '(150)
            ' ''gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;7;;;" & "o;n;n;7;"       '(160)

            ' ''gridAttributes = gridAttributes & "|(��)�����ȣ;NewPostNum;10;;;" & "o;n;n;10;"       '(100)
            ' ''gridAttributes = gridAttributes & "|(��)�ּ�;NewAddr1;50;;;" & "o;n;n;50;"       '(110)
            ' ''gridAttributes = gridAttributes & "|(��)���ּ�;NewAddr2;100;;;" & "o;n;n;100;"       '(120)
            ' ''gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;SolicitorCorpCd;10;;;" & "o;n;n;10;"       '(170)
            ' ''gridAttributes = gridAttributes & "|����Ȯ���ȣ;BranchExpNum;12;;;" & "o;n;n;12;"       '(180)
            ' ''gridAttributes = gridAttributes & "|���������ڵ�;ReaderTypeCd;10;;;" & "o;n;n;10;"       '(200)
            ' ''gridAttributes = gridAttributes & "|���ڱ����ڵ�;ReaderDivCd;10;;;" & "o;n;n;10;"       '(210)
            ' ''gridAttributes = gridAttributes & "|X���ó�����ڵ�;DeliveryRegionCd;10;;;" & "o;n;n;10;"       '(220)
            ' ''gridAttributes = gridAttributes & "|��ޱ����ڵ�;DeliveryDivCd;10;;;" & "o;n;n;10;"       '(230)
            ' ''gridAttributes = gridAttributes & "|���������ڵ�;CollectionTypeCd;10;;;" & "o;n;n;10;"       '(240)
            ' ''gridAttributes = gridAttributes & "|û������ڵ�;BillTypeCd;10;;;" & "o;n;n;10;"       '(250)
            ' ''gridAttributes = gridAttributes & "|�����ǵ��ڿ���;CouponReaderYN;1;;;" & "o;n;n;1;"       '(320)
            ' ''gridAttributes = gridAttributes & "|�������뺸����;NotifyYN;1;;;" & "o;n;n;1;"       '(330)
            ' ''gridAttributes = gridAttributes & "|�������뺸����;SolicitorNotifyDt;8;;;" & "o;n;n;8;"       '(340)
            ' ''gridAttributes = gridAttributes & "|���;Note;1000;;;" & "o;n;n;1000;"       '(400)
            ' ''gridAttributes = gridAttributes & "|�����ڵ�;SubscribeCd;10;;;" & "o;n;n;10;"       '(410)
            ' ''gridAttributes = gridAttributes & "|�����ǹ����ڵ�;CouponSeriesNum;10;;;" & "o;n;n;10;"       '(420)
            '''''===========================================================================================
            '''' ====   �赿�������� ��û �������� ���� ���� �ʱ� �ּ� ó�� ���� 
            '''''===========================================================================================
            'grid_4 code combo    

        End Sub

        Private Sub PNE302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

        Private Sub grd_1_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            Me.grd_1.Editable = EditableSettings.flexEDKbdMouse

            If Me.grd_1.Rows > 1 Then
                With Me.grd_1
                    Select Case .ColSel
                        Case .get_ColIndex("EmployeeExpNum")
                            .Editable = EditableSettings.flexEDNone
                        Case Else
                            .Editable = EditableSettings.flexEDKbdMouse
                    End Select
                End With
            End If

        End Sub

        Private Sub optGrd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGrd3.CheckedChanged
            grd_2.Visible = optGrd2.Checked
            grd_3.Visible = optGrd3.Checked
        End Sub

        Private Sub optGrd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGrd2.CheckedChanged
            grd_2.Visible = optGrd2.Checked
            grd_3.Visible = optGrd3.Checked
        End Sub

        ''''''' <summary>
        ''''''' �Լ��� : btnApprovalAll_Click 
        ''''''' ��  �� : �ϰ� ����
        ''''''' �ۼ��� : 
        ''''''' �ۼ��� : 
        ''''''' ������ : 
        ''''''' ������ : 
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>

        '' ''Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    Dim inti As Integer
        '' ''    Try
        '' ''        If blnApprovalAll = False Then
        '' ''            With grd_1
        '' ''                If (.Rows > .FixedRows) Then
        '' ''                    For inti = .FixedRows To .Rows - 1
        '' ''                        If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
        '' ''                            .SetCellCheck(inti, .get_ColIndex("ApprovalYN"), CheckEnum.Checked)
        '' ''                            .set_TextMatrix(inti, .get_ColIndex("ApprovalDt"), dtpApprovalDt.Text)
        '' ''                            .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
        '' ''                        End If
        '' ''                    Next inti
        '' ''                End If
        '' ''            End With
        '' ''            blnApprovalAll = True
        '' ''        Else
        '' ''            With grd_1
        '' ''                If (.Rows > .FixedRows) Then
        '' ''                    For inti = .FixedRows To .Rows - 1
        '' ''                        If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
        '' ''                            .SetCellCheck(inti, .get_ColIndex("ApprovalYN"), CheckEnum.Unchecked)
        '' ''                            .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
        '' ''                        End If
        '' ''                    Next inti
        '' ''                End If
        '' ''            End With
        '' ''            blnApprovalAll = False
        '' ''        End If
        '' ''        btnApprovalAll.Text = IIf(blnApprovalAll, "���� ���", "�ϰ� ����")
        '' ''    Catch ex As Exception
        '' ''        MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '' ''    End Try
        '' ''End Sub

    End Class

End Namespace
