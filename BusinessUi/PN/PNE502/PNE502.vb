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

Imports Microsoft.Office.Interop

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE502
        Inherits CommonControls.UiControl

        Private Sub PNE502_BACK_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "�� �ʱ�ȭ"
        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.11.19
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            ''If optreceipt.Checked = True Then
            Dim gridAttributes As String = ""

            ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            'gridAttributes = gridAttributes & "a;r;n"

            ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            'gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"

            'gridAttributes = gridAttributes & "|��������;ContactDt4;85;yyyy-MM-dd;4;" & "o;n;n;30;"

            'gridAttributes = gridAttributes & "|����ó;CompanyNm;119;;1;" & "o;n;n;30;"

            'gridAttributes = gridAttributes & "|������(1);TrAdEmployeeNm;62;;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|�����ڸ�(1);BizEmpNm;1;;4;" & "o;n;n;7;"
            'gridAttributes = gridAttributes & "|������(2);AdEmployeeNm;62;;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|�����ڸ�(2);BizEmpNm;1;;4;" & "o;n;n;7;"

            'gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;191;;1;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|�ּ�;OldAddr1;231;;1;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|���ּ�;OldAddr2;232;;1;" & "o;n;n;30;"

            'gridAttributes = gridAttributes & "|�����ű�;NewPapNum;62;;7;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|������Ȯ��;ReExpPapNum;1;74;;7;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|������;TargetPaperTotNum;50;;7;" & "o;n;n;30;"

            'gridAttributes = gridAttributes & "|Ȯ���ű�;NewExpPapNum;1;;7;" & "o;n;n;50;"
            'gridAttributes = gridAttributes & "|Ȯ����Ȯ��;ReExpPapNum;1;;7;" & "o;n;n;100;"
            'gridAttributes = gridAttributes & "|Ȯ����;FixedPaperNum;1;;7;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|����;SubscribePagerNum;1;;7;" & "o;n;n;8;"

            'gridAttributes = gridAttributes & "|������;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            'gridAttributes = gridAttributes & "|�������;EmployeeNm;62;;4;" & "o;n;n;7;"
            'gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;87;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|û������ڵ�;BillTypeCd;87;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;74;;7;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|���ݳ��;CollectionYYYY;63;yyyy-MM;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|����Ͱ��;Refuse;1;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|����͹��������;RefuseReasonCd;1;;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|���ڻ���;ReaderStateCd;74;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|��������;SubscribeStateCd;70;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|��������;FixedStDt3;85;yyyy-MM-dd;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|����������;FixedStDt1;85;dd;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|����������;FixedEdDt;85;dd;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|���񽺱Ⱓ;ServiceTerm;74;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|��������;StopDt;62;yyyy-MM-dd;4;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|��������;ReturnCd;1;;1;" & "o;n;n;50;"
            'gridAttributes = gridAttributes & "|�Ǹű��ۼ�;SalWtList;1;;1;" & "o;n;n;100;"

            'gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;1;;1;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|����ó;DeliveryChnlNm;128;;1;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|��ȭ1;PhoneNum1;116;;1;" & "o;n;n;10;"

            Me.dtpFixedEdDt.TextValue = ""

            ''grid_1 code combo    
            Dim gridCodeNameList As String = ""

            'Grd_1.Initialize(gridAttributes, gridCodeNameList)
            'Me.Grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|��������;ContactDt4;85;yyyy-MM-dd;4;" & "o;n;n;30;"

            gridAttributes = gridAttributes & "|������(1);TrAdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڸ�(1);TrAdEmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|������(2);AdEmployeeNum;1;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڸ�(2);AdEmployeeNm;62;;4;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����ںμ�;AdEmployeeDeptCd;1;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|�����ںμ���;AdEmployeeDeptNm;75;;1;" & "o;n;n;50;"

            ''gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|ķ���θ�;ExpandNm;80;;4;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|����ó;CompanyNm;114;;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;180;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;246;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;271;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|��������;SubscribeStateCd;87;;1;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|������ȭ��ȣ;PhoneNum1;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|������ȭ��ȣ;PhoneNum2;1;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;1;;1;" & "o;n;y;30;"

            gridAttributes = gridAttributes & "|��������;DeliveryBranchNm;62;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�������;EmployeeNm;74;;1;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|������;TargetPaperTotNum;50;#,##0;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�ű�Ȯ��;NewExpPapNum;62;#,##0;c;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|��Ȯ��;ReExpPapNum;50;#,##0;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;87;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;87;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;85;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��������;MngStopDt;85;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�������޻���;BranchMessage;227;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���;Note;232;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;10;"       '(80)


            gridCodeNameList = ""
            Grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.Grd_1.ExplorerBar = 3

            '' ''==============================================================
            '' ''  grid_3 �� �ʱ�ȭ �Ѵ�.
            '' ''--------------------------------------------------------------
            ' ''gridAttributes = ""

            '' ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            ' ''gridAttributes = gridAttributes & "a;r;n"
            '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            ' ''gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            ' ''gridAttributes = gridAttributes & "|��������;ContactDt4;85;yyyy-MM-dd;4;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|Ȯ��ó;CompanyNm;119;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;191;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|������ȭ��ȣ;PhoneNum1;116;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|������ȭ��ȣ;PhoneNum2;99;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;106;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|�ּ�;OldAddr1;231;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|���ּ�;OldAddr2;232;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|�����ű�;NewPapNum;62;;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|������Ȯ��;ReExpPapNum1;74;;7;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|������;TargetPaperTotNum;50;;7;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|������;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|�������;EmployeeNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;87;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;74;;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|��������;FixedStDt3;85;yyyy-MM-dd;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|���;Note;232;;1;" & "o;n;n;50;"

            ' ''gridCodeNameList = ""
            ' ''Grd_3.Initialize(gridAttributes, gridCodeNameList)
            ' ''Me.Grd_3.ExplorerBar = 3

            '' ''==============================================================
            '' ''  grid_4 �� �ʱ�ȭ �Ѵ�.
            '' ''--------------------------------------------------------------
            ' ''gridAttributes = ""

            '' ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            ' ''gridAttributes = gridAttributes & "a;r;y"
            '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            ' ''gridAttributes = gridAttributes & "||����;seq;119;;1;" & "o;n;y;30;"
            ' ''gridAttributes = gridAttributes & "|����;ContactDt4;85;;4;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|Ȯ��ó;CompanyNm;119;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|����ó;DeliveryChnlNm;128;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;191;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|��ȭ;PhoneNum1;116;;1;" & "o;n;n;10;"
            '' ''gridAttributes = gridAttributes & "|�ڵ���;MobileNum;116;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|�ּ�;OldAddr1;231;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|���ּ�;OldAddr2;232;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|�ű�;NewPapNum;62;;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|��Ȯ��;ReExpPapNum1;74;;7;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|��;TargetPaperTotNum;50;;7;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|������;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|�������;EmployeeNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|����;CollectionDivCd;87;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|�����;Refuse;1;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|��������;FixedStDt1;85;;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|��������;FixedEdDt;85;;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|���Ȯ��;DeliveryConfirm;74;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|�̹��;NotDelivery;62;;4;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|�̹�޻���;NotDeliveryReason;1;;1;" & "o;n;n;50;"
            ' ''gridAttributes = gridAttributes & "|��ġ����;MeasuresSubject;1;;1;" & "o;n;n;100;"
            ' ''gridAttributes = gridAttributes & "|���;Result;1;;1;" & "o;n;n;100;"

            '' ''grid_4 code combo    
            ' ''gridCodeNameList = ""

            ' ''grd_4.Initialize(gridAttributes, gridCodeNameList)
            ' ''Me.grd_4.ExplorerBar = 3

            '' ''==============================================================
            '' ''  grid_5 �� �ʱ�ȭ �Ѵ�.
            '' ''--------------------------------------------------------------
            ' ''gridAttributes = ""

            '' ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            ' ''gridAttributes = gridAttributes & "a;r;y"
            '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            ' ''gridAttributes = gridAttributes & "||����;seq;119;;1;" & "o;n;y;30;"
            ' ''gridAttributes = gridAttributes & "|����;ContactDt4;85;;4;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|Ȯ��ó;CompanyNm;119;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|����ó;DeliveryChnlNm;128;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;191;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|��ȭ1;PhoneNum1;116;;1;" & "o;n;n;10;"
            '' ''gridAttributes = gridAttributes & "|�ڵ���;MobileNum;116;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|�ּ�;OldAddr1;231;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|���ּ�;OldAddr2;232;;1;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|�ű�;NewPapNum;62;;7;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|��Ȯ��;ReExpPapNum1;74;;7;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|��;TargetPaperTotNum;50;;7;" & "o;n;n;30;"
            ' ''gridAttributes = gridAttributes & "|������;DeliveryBranchNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|�������;EmployeeNm;62;;4;" & "o;n;n;7;"
            ' ''gridAttributes = gridAttributes & "|����;CollectionDivCd;87;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|�����;Refuse;1;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|��������;FixedStDt1;85;dd;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|1�����;OneYearPoint;85;;4;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|���Ȯ��;DeliveryConfirm;74;;1;" & "o;n;n;10;"
            ' ''gridAttributes = gridAttributes & "|�̹��;NotDelivery;62;;4;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|�̹�޻���;NotDeliveryReason;1;;1;" & "o;n;n;50;"
            ' ''gridAttributes = gridAttributes & "|��ġ����;MeasuresSubject;1;;1;" & "o;n;n;100;"
            ' ''gridAttributes = gridAttributes & "|��������;FixedEdDt;1;;1;" & "o;n;n;100;"

            '' ''grid_5 code combo    
            ' ''gridCodeNameList = ""

            ' ''grd_5.Initialize(gridAttributes, gridCodeNameList)
            ' ''Me.grd_5.ExplorerBar = 3

            '����� ����
            popBizChargeCd.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popBizChargeCd.Enabled = False
                popBizChargeCd.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                               GmainBusinessFunction.GetValue("�α��� ID"), _
                                               GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

            '' 2010.10.26�������� ����üũ �߰�
            If GmainBusinessFunction.GetValue("����ڵ��") = "04" Then
                popBizChargeCd.Enabled = True
            End If

            Me.Grd_1.Visible = True

        End Sub
#End Region

#Region "�̺�Ʈ"

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grd_1.DoubleClick

            ''���Ȯ�� ���� ��� ȭ������ JUMP.
            'If Me.Grd_1.Rows <= Me.Grd_1.FixedRows Then Exit Sub
            'Dim strCode As String '�������ڹ�ȣ
            'Dim sdate As String
            'sdate = dtpBaseYear.TextValue.Substring(0, 4) + "-" + "01"
            'strCode = Me.dtpBaseYear.TextValue _
            '          & ";" & Me.Grd_1.GetCurrentRowCellValue("BranchNum") _
            '          & ";" & sdate
            'GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNI403;" & strCode)
            'Me.ShowUiControl("PNI403", strCode)

        End Sub


#End Region


#Region "������"

        Private Sub btnExcelExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelExport.Click
            Call CreateXLS(GetDataSet)
        End Sub

        ' ���� ��������
        Public Sub CreateXLS(ByVal tmpDataSet As DataSet)

            ' ��ȸ�ȵ���Ÿ���������о�~
            If tmpDataSet.Tables.Count < 1 Then
                Exit Sub
            End If
            If tmpDataSet.Tables(0).Rows.Count < 1 Then
                Exit Sub
            End If

            Dim strToday As String = Replace(Date.Today, "-", "").Substring(2, 2) & "." & Replace(Date.Today, "-", "").Substring(4, 2) & "." & Replace(Date.Today, "-", "").Substring(6, 2)

            'Dim ProcExcel As Process() = Process.GetProcesses()
            'Dim ExcelID() As Integer

            'For ii As Integer = 0 To ProcExcel.Length - 1
            '    ExcelID(ii) = Process.GetProcessesByName("EXCEL").Length
            'Next

            Dim xlsApp As Object = CreateObject("Excel.Application")

            Dim dlgSave As New SaveFileDialog
            Dim sFileName As String = ""

            ' ���� ��ü ����

            dlgSave.Filter = "Excel file (*.xls)|*.xls|All files (*.*)|*.*"

            Dim dr As DialogResult = dlgSave.ShowDialog()

            If dr = DialogResult.OK Then
                sFileName = dlgSave.FileName
            Else
                Exit Sub
            End If

            Try
                Me.Cursor = Cursors.WaitCursor

                Const xlContinuous = 1 ' // �Ϲ� ���� ���մϴ�.  ������ ����,, �⼱���� ����..
                Const xlEdgeRight = 10 ' // ����ʿ� ������ �����ų�.. �ɼ�����.  left, top , bottom 
                Const xlEdgeLeft = 7 '
                Const xlEdgeTop = 8
                Const xlEdgeBottom = 9

                Const xlCenter = -4108 '��� ����
                Const xlRight = -4152 '������ ����

                '�������� ����(������)
                'excTemp.Visible = True

                xlsApp.Workbooks.Add()
                'xlsApp.Visible = True

                Dim intWorkSheetCount As Integer
                '' ������ ��ũ ��Ʈ ���� ��� ����
                For intWorkSheetCount = xlsApp.Worksheets.Count To 2 Step -1
                    xlsApp.Worksheets(intWorkSheetCount).Delete()
                Next intWorkSheetCount

                ''==============������ݵ��� ���Ȯ��=====================
                'If Me.optHeadOfficeDelivery.Checked = True Then

                '    'xlsApp.Selection.HorizontalAlignment() = xlCenter
                '    xlsApp.Workbooks(1).Sheets(1).Name = "������ݵ��� ���Ȯ��"

                '    '��ü���� ���� ����
                '    xlsApp.Cells.Resize.RowHeight = 18.75
                '    '��ü ������ �ؽ�Ʈ ����
                '    xlsApp.Cells.NumberFormatLocal = "@"
                '    '��ü �����ڼ� �Ѿ�� �ڵ����� ���� ũ�� ���ߴ� ����
                '    xlsApp.Cells.ShrinkToFit = True

                '    '������ ��Ʈ, ������, ����� ����
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).Font.Size = 20
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).Font.Bold = True
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).RowHeight = 19.5

                '    xlsApp.Workbooks(1).Sheets(1).Cells(1, 1) = "���Ȯ�� ������ݵ��� ���Ȯ��"
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).Merge()

                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).HorizontalAlignment = xlCenter '����
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 1 & ":T" & 1).VerticalAlignment = xlCenter '����

                '    '��¥�� �����
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 3 & ":T" & 3).RowHeight = 13.5
                '    xlsApp.Workbooks(1).Sheets(1).Range("Q" & 3 & ":T" & 3).Merge()
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & 3 & ":T" & 3).HorizontalAlignment = xlRight '����

                '    xlsApp.Workbooks(1).Sheets(1).Cells(3, 17) = "<�������:" & strToday & ">"

                '    xlsApp.Workbooks(1).Sheets(1).columns("A:A").columnwidth = 4.11
                '    xlsApp.Workbooks(1).Sheets(1).columns("B:B").columnwidth = 7.89
                '    xlsApp.Workbooks(1).Sheets(1).columns("C:C").columnwidth = 8.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("D:D").columnwidth = 31.76

                '    xlsApp.Workbooks(1).Sheets(1).columns("E:E").columnwidth = 10.56
                '    xlsApp.Workbooks(1).Sheets(1).columns("F:F").columnwidth = 23.67
                '    xlsApp.Workbooks(1).Sheets(1).columns("G:G").columnwidth = 44.11
                '    xlsApp.Workbooks(1).Sheets(1).columns("H:H").columnwidth = 4.11

                '    xlsApp.Workbooks(1).Sheets(1).columns("I:I").columnwidth = 5.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("J:J").columnwidth = 4.11
                '    xlsApp.Workbooks(1).Sheets(1).columns("K:K").columnwidth = 7.44
                '    xlsApp.Workbooks(1).Sheets(1).columns("L:L").columnwidth = 7.44

                '    xlsApp.Workbooks(1).Sheets(1).columns("M:M").columnwidth = 4.11
                '    xlsApp.Workbooks(1).Sheets(1).columns("N:N").columnwidth = 7.89
                '    xlsApp.Workbooks(1).Sheets(1).columns("O:O").columnwidth = 7.89
                '    xlsApp.Workbooks(1).Sheets(1).columns("P:P").columnwidth = 7.44

                '    xlsApp.Workbooks(1).Sheets(1).columns("Q:Q").columnwidth = 5.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("R:R").columnwidth = 10.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("S:S").columnwidth = 10.78
                '    xlsApp.Workbooks(1).Sheets(1).columns("T:T").columnwidth = 4.11

                '    '�÷� 
                '    For j As Integer = 1 To tmpDataSet.Tables(0).Columns.Count - 1
                '        xlsApp.Workbooks(1).Sheets(1).Cells(4, j) = tmpDataSet.Tables(0).Rows(0).Item(j - 1).ToString
                '        xlsApp.Workbooks(1).Sheets(1).Range("A" & 4 & ":T" & 4).HorizontalAlignment = xlCenter '����
                '    Next

                '    Dim i As Integer = 0
                '    '������
                '    For i = 5 To tmpDataSet.Tables(0).Rows.Count + 3
                '        For j As Integer = 1 To tmpDataSet.Tables(0).Columns.Count - 1
                '            xlsApp.Workbooks(1).Sheets(1).Cells(i, j) = tmpDataSet.Tables(0).Rows(i - 4).Item(j - 1)
                '        Next
                '    Next

                '    '�հ��� ��Ʈ ����~~
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & i - 1 & ":T" & i - 1).Font.Bold = True

                '    '��ü �÷� ���� �ڵ����� ����
                '    'xlsApp.Workbooks(1).Sheets(1).Columns.AutoFit()

                '    Dim intCols As Integer = 0

                '    '���ζ��� �׸���
                '    For intCols = 1 To tmpDataSet.Tables(0).Columns.Count - 1
                '        xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(4, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count - 1, intCols)).Borders(xlEdgeRight).LineStyle = xlContinuous
                '        xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(4, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count - 1, intCols)).Borders(xlEdgeLeft).LineStyle = xlContinuous
                '    Next
                '    xlsApp.Workbooks(1).Sheets(1).Range("A" & tmpDataSet.Tables(0).Rows.Count + 3).Borders(xlEdgeLeft).LineStyle = xlContinuous
                '    xlsApp.Workbooks(1).Sheets(1).Range("T" & tmpDataSet.Tables(0).Rows.Count + 3).Borders(xlEdgeRight).LineStyle = xlContinuous

                '    Dim intRows As Integer = 0
                '    '���ζ��� �׸���
                '    For intRows = 3 To tmpDataSet.Tables(0).Rows.Count + 3
                '        xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":T" & intRows).Borders(xlEdgeBottom).LineStyle = xlContinuous
                '    Next
                '    '==========�������ݵ��� ���Ȯ��=====================
                '    'ElseIf Me.optBranchDelivery.Checked = True Then
                '    '    '�÷� 
                '    '    For j As Integer = 1 To Me.grd_5.Cols - 1
                '    '        xlsApp.Cells(1, j) = Me.grd_5.get_TextMatrix(0, j)
                '    '    Next
                '    '    ' ������
                '    '    For i As Integer = 2 To Me.grd_5.Rows - 1
                '    '        For j As Integer = 2 To Me.grd_5.Cols - 1
                '    '            xlsApp.Cells(i, j) = Me.grd_5.Item(i, j)
                '    '        Next
                '    '    Next
                '    '    xlsApp.Columns.AutoFit()
                '    '    Dim intCols As Integer = 0

                '    '    For intCols = 1 To Me.grd_5.Cols - 1
                '    '        'xlsApp.Sheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Sheets(1).Cells(xlsApp.Sheets(1).UsedRange.Rows.Count, intCols)).Select()
                '    '        'xlsApp.Selection.Borders(xlEdgeRight).LineStyle = xlContinuous
                '    '        'xlsApp.Selection.Borders(xlEdgeLeft).LineStyle = xlContinuous
                '    '    Next

                '    '    Dim intRows As Integer = 0

                '    '    For intRows = 1 To Me.grd_5.Rows - 1
                '    '        xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Borders(xlEdgeBottom).LineStyle = xlContinuous
                '    '    Next
                'End If

                MessageBox.Show("���� �������� �Ϸ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

                xlsApp.Workbooks(1).SaveAs(sFileName)
                xlsApp.Application.Quit()
                xlsApp = Nothing
                GC.Collect()

                Me.Cursor = Cursors.Default

            Catch ex As Exception
                MessageBox.Show(ex.ToString(), "Xls2Grd")
            End Try
        End Sub


        ' ���� ��������
        'Public Sub CreateXLS()

        '    'Dim ProcExcel As Process() = Process.GetProcesses()
        '    'Dim ExcelID() As Integer

        '    'For ii As Integer = 0 To ProcExcel.Length - 1
        '    '    ExcelID(ii) = Process.GetProcessesByName("EXCEL").Length
        '    'Next


        '    Dim xlsApp As Object = CreateObject("Excel.Application")

        '    Dim dlgSave As New SaveFileDialog
        '    Dim sFileName As String = ""

        '    ' ���� ��ü ����

        '    dlgSave.Filter = "Excel file (*.xls)|*.xls|All files (*.*)|*.*"

        '    Dim dr As DialogResult = dlgSave.ShowDialog()

        '    If dr = DialogResult.OK Then
        '        sFileName = dlgSave.FileName
        '    Else
        '        Exit Sub
        '    End If

        '    Try
        '        Me.Cursor = Cursors.WaitCursor

        '        Const xlContinuous = 1 ' // �Ϲ� ���� ���մϴ�.  ������ ����,, �⼱���� ����..
        '        Const xlEdgeRight = 10 ' // ����ʿ� ������ �����ų�.. �ɼ�����.  left, top , bottom 
        '        Const xlEdgeLeft = 7 '
        '        Const xlEdgeTop = 8
        '        Const xlEdgeBottom = 9

        '        '�������� ����(������)
        '        'excTemp.Visible = True

        '        xlsApp.Workbooks.Add()


        '        xlsApp.Visible = True
        '        '==============������ݵ��� ���Ȯ��=====================
        '        If Me.optHeadOfficeDelivery.Checked = True Then

        '            xlsApp.Workbooks(1).Sheets(1).Name = "������ݵ��� ���Ȯ��"

        '            '�÷� 
        '            For j As Integer = 1 To Me.grd_4.Cols - 1
        '                xlsApp.Workbooks(1).Sheets(1).Cells(1, j) = Me.grd_4.get_TextMatrix(0, j)
        '            Next

        '            ' ������
        '            For i As Integer = 2 To Me.grd_4.Rows - 1
        '                For j As Integer = 1 To Me.grd_4.Cols - 1
        '                    xlsApp.Workbooks(1).Sheets(1).Cells(i, j) = Me.grd_4.Item(i - 1, j)
        '                Next
        '            Next

        '            '' ������
        '            'For i As Integer = 2 To tmpDataSet.Tables(0).Rows.Count - 1
        '            '    For j As Integer = 1 To tmpDataSet.Tables(0).Columns.Count - 1
        '            '        xlsApp.Workbooks(1).Sheets(1).Cells(i, j) = tmpDataSet.Tables(0).Rows(i).Item(j)
        '            '    Next
        '            'Next
        '            xlsApp.Workbooks(1).Sheets(1).Columns.AutoFit()

        '            Dim intCols As Integer = 0

        '            '���ζ��� �׸���
        '            For intCols = 1 To Me.grd_4.Cols - 1
        '                'xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count, intCols)).Select()
        '                xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count, intCols)).Borders(xlEdgeRight).LineStyle = xlContinuous
        '                xlsApp.Workbooks(1).Worksheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Workbooks(1).Sheets(1).Cells(xlsApp.Workbooks(1).Sheets(1).UsedRange.Rows.Count, intCols)).Borders(xlEdgeLeft).LineStyle = xlContinuous
        '                'xlsApp.Workbooks(1).Worksheets(1).Borders(xlEdgeRight).LineStyle = xlContinuous
        '                'xlsApp.Workbooks(1).Worksheets(1).Selection.Borders(xlEdgeLeft).LineStyle = xlContinuous
        '            Next

        '            Dim intRows As Integer = 0
        '            '���ζ��� �׸���
        '            For intRows = 1 To Me.grd_4.Rows - 1
        '                'xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Select()
        '                xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Borders(xlEdgeBottom).LineStyle = xlContinuous
        '                'xlsApp.Workbooks(1).Sheets(1).Selection.Borders(xlEdgeBottom).LineStyle = xlContinuous
        '            Next
        '            '==========�������ݵ��� ���Ȯ��=====================
        '        ElseIf Me.optBranchDelivery.Checked = True Then
        '            '�÷� 
        '            For j As Integer = 1 To Me.grd_5.Cols - 1
        '                xlsApp.Cells(1, j) = Me.grd_5.get_TextMatrix(0, j)
        '            Next
        '            ' ������
        '            For i As Integer = 2 To Me.grd_5.Rows - 1
        '                For j As Integer = 2 To Me.grd_5.Cols - 1
        '                    xlsApp.Cells(i, j) = Me.grd_5.Item(i, j)
        '                Next
        '            Next
        '            xlsApp.Columns.AutoFit()
        '            Dim intCols As Integer = 0

        '            For intCols = 1 To Me.grd_5.Cols - 1
        '                'xlsApp.Sheets(1).Range(xlsApp.Sheets(1).Cells(3, intCols), xlsApp.Sheets(1).Cells(xlsApp.Sheets(1).UsedRange.Rows.Count, intCols)).Select()
        '                'xlsApp.Selection.Borders(xlEdgeRight).LineStyle = xlContinuous
        '                'xlsApp.Selection.Borders(xlEdgeLeft).LineStyle = xlContinuous
        '            Next

        '            Dim intRows As Integer = 0

        '            For intRows = 1 To Me.grd_5.Rows - 1
        '                'xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Select()
        '                xlsApp.Workbooks(1).Sheets(1).Range("A" & intRows & ":V" & intRows).Borders(xlEdgeBottom).LineStyle = xlContinuous
        '            Next
        '        End If

        '        MessageBox.Show("���� �������� ����!")

        '        xlsApp.Workbooks(1).SaveAs(sFileName)
        '        xlsApp.Application.Quit()
        '        xlsApp = Nothing
        '        GC.Collect()

        '        Me.Cursor = Cursors.Default

        '        'Dim pro() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
        '        'For Each i As Process In pro
        '        '    i.Kill()
        '        'Next

        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString(), "Xls2Grd")
        '    End Try
        'End Sub
#End Region

    End Class

End Namespace
