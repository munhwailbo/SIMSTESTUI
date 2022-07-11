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
Imports System.ComponentModel
Imports System.Data.SqlClient

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE101
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;0;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|��������;ExpandDt;85;yyyy-MM-dd;4;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����;Orders;0;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;100;;100;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;98;;4;" & "io;n;n;40;Ȯ��ó ��;CompanyNm"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;149;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|����;TargetPaperTotNum;37;;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�ű�;NewExpPapNum;37;;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��Ȯ��;ReExpPapNum;50;;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��ܾ��ºμ�;NoListPapNum;87;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ��;FixedPaperNum;37;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|����;SubscribePagerNum;37;#,###;7;" & "o;n;y;5;"         '�ӽ÷� ���� 02/17
            gridAttributes = gridAttributes & "|������;NoSubscribePagerNum;50;#,###;7;" & "o;n;y;5;"     '�ӽ÷� ���� 02/17  
            gridAttributes = gridAttributes & "|��ܻ����ڵ�;ListStatCd;105;;1;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;87;;1;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|û������;BillType;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;93;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ��ڵ�;BillPeriodCd;87;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;74;#,###;7;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|������������;FixedStDt;87;yyyy-MM-dd;4;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|������������;FixedEdDt;87;yyyy-MM-dd;4;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|�������޻���;BranchNote;269;;1;" & "io;n;n;200;"
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;62;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|��������;ApprovalDt;62;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���;Note;291;;1;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|�������Ȯ���ȣ;OldEmployeeExpNum;0;;4;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|;Dummy;70;;4;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ListStatCd;��ܻ����ڵ�"    '' 2401
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;���������ڵ�"   ''2323
            gridCodeNameList = gridCodeNameList & "/BillType;û��������"    ''2505
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3


            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;0;;1;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;0;;1;" & "io;n;y;13;"
            gridAttributes = gridAttributes & "|��������;ContactDt;85;yyyy-MM-dd;4;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|����;Orders;48;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;185;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|����;ContactPaperNum;37;#,##0;4;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|����;FixedPagerNum;37;#,##0;4;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|��ȭ1;PhoneNum1;99;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ���;MobileNum;103;;1;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���ڻ����ڵ�;ReaderStateCd;87;;1;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|���������ڵ�;CollectionTypeCd;87;;1;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|�����ֱ��ڵ�;BillPeriodCd;87;;1;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|���ó�����ڵ�;DeliveryRegionCd;99;;1;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|��ޱ����ڵ�;DeliveryDivCd;87;;1;" & "io;n;n;7;"

            gridAttributes = gridAttributes & "|�ֱ�����;TrAdEmployeeNum;80;;c;" & "io;y;n;;��� ��;TrAdEmployeeNm"
            gridAttributes = gridAttributes & "|�ֱ�����;TrAdEmployeeNm;80;;c;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|�ֱ�����;TrAdEmployeeDeptCd;90;;c;" & "io;y;n;;�μ� ��;TrAdEmployeeDeptNm"
            gridAttributes = gridAttributes & "|�ֱ�����;TrAdEmployeeDeptNm;100;;c;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|������;AdEmployeeNum;80;;c;" & "io;y;n;;��� ��;AdEmployeeNm"
            gridAttributes = gridAttributes & "|������;AdEmployeeNm;80;;c;" & "o;y;n;;"
            gridAttributes = gridAttributes & "|������;AdEmployeeDeptCd;90;;c;" & "io;y;n;;�μ� ��;AdEmployeeDeptNm"
            gridAttributes = gridAttributes & "|������;AdEmployeeDeptNm;100;;c;" & "o;y;n;;"

            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;0;;4;" & "io;n;y;10;�����ȣ;OldAddr1"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;0;;1;" & "io;n;y;50;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;0;;1;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;0;;4;" & "io;n;y;7;�����ڵ�;DeliveryBranchNm "
            gridAttributes = gridAttributes & "|����������;DeliveryBranchNm;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|�������޻���;BranchNote;0;;1;" & "io;n;y;200;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;0;yyyy-MM-dd;4;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|������������;FixedEdDt;0;yyyy-MM-dd;4;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|����������ȣ;OldReceiptCd;0;;1;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|�������ڹ�ȣ;OldSubscribeCd;0;;1;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|;Dumi;30;;l;" & "o;n;n;30;"

            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ReaderStateCd;���ڻ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/CollectionTypeCd;���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;���ó�����ڵ�"
            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;��ޱ����ڵ�"

            grd_2.Initialize(gridAttributes, gridCodeNameList)

            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "����"
            strColName2 = strColName2 & ControlChars.Tab & "���Ȯ���ȣ"
            strColName2 = strColName2 & ControlChars.Tab & "���������ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "��������"
            strColName2 = strColName2 & ControlChars.Tab & "����"
            strColName2 = strColName2 & ControlChars.Tab & "���ڸ�"
            strColName2 = strColName2 & ControlChars.Tab & "����"
            strColName2 = strColName2 & ControlChars.Tab & "����"
            strColName2 = strColName2 & ControlChars.Tab & "��ȭ1"
            strColName2 = strColName2 & ControlChars.Tab & "�ڵ���"
            strColName2 = strColName2 & ControlChars.Tab & "���ڻ����ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "���������ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "�����ֱ��ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "���ó�����ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "��ޱ����ڵ�"

            strColName2 = strColName2 & ControlChars.Tab & "���"
            strColName2 = strColName2 & ControlChars.Tab & "�̸�"
            strColName2 = strColName2 & ControlChars.Tab & "�μ��ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "�μ���"

            strColName2 = strColName2 & ControlChars.Tab & "���"
            strColName2 = strColName2 & ControlChars.Tab & "�̸�"
            strColName2 = strColName2 & ControlChars.Tab & "�μ��ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "�μ���"

            strColName2 = strColName2 & ControlChars.Tab & "�����ȣ"
            strColName2 = strColName2 & ControlChars.Tab & "�ּ�"
            strColName2 = strColName2 & ControlChars.Tab & "���ּ�"
            strColName2 = strColName2 & ControlChars.Tab & "���������ڵ�"
            strColName2 = strColName2 & ControlChars.Tab & "����������"

            strColName2 = strColName2 & ControlChars.Tab & "�������޻���"
            strColName2 = strColName2 & ControlChars.Tab & "��������"
            strColName2 = strColName2 & ControlChars.Tab & "������������"

            strColName2 = strColName2 & ControlChars.Tab & "����������ȣ"
            strColName2 = strColName2 & ControlChars.Tab & "�������ڹ�ȣ"

            With Me.grd_2

                Dim i As Integer

                .AddItem(strColName2)

                .FixedRows = 3
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly

                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next

                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next

            End With



            Me.grd_2.ExplorerBar = 3

            Me.dtpFromExpand.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            Me.dtpToExpand.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")


        End Sub

        Private Sub PNE101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
            RequestData2()
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            SaveData2()
        End Sub

        Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
            DeleteData2()
        End Sub
        Private Sub BtnNewLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLine.Click

            If grd_1.Rows > 1 Then
                Me.grd_2.AddRow()
                AddReciptReader(grd_2.Rows)
            End If
        End Sub

        Private Sub AddReciptReader(ByVal row As Integer)

            If grd_1.Rows > 1 Then
                grd_2.SetData(row - 1, "EmployeeExpNum", Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))
                grd_2.SetData(row - 1, "ReceiptCd", Me.grd_1.GetCurrentRowCellValue("ExpandDt")) '' �������ڹ�ȣ
                grd_2.SetData(row - 1, "ContactDt", Me.grd_1.GetCurrentRowCellValue("ExpandDt")) '' ��������
                grd_2.SetData(row - 1, "ContactPaperNum", 1) '' �����μ�
                grd_2.SetData(row - 1, "FixedPagerNum", 1) '' ���Ժμ�

                ComboValueSetting(grd_2, row - 1, "ReaderStateCd", "1") ' "|���ڻ����ڵ�;ReaderStateCd;7;;c;" & "io;n;n;7;"     '���ڻ����ڵ�"
                ComboValueSetting(grd_2, row - 1, "CollectionTypeCd", Me.grd_1.GetCurrentRowCellValue("CollectionDivCd")) '"|���������ڵ�;CollectionTypeCd;7;;c;" & "io;n;n;7;"     '���ݱ����ڵ�"
                ComboValueSetting(grd_2, row - 1, "BillPeriodCd", "1") ' "|�����ֱ��ڵ�;BillPeriodCd;7;;c;" & "io;n;n;7;"     '�����ֱ��ڵ�"
                ComboValueSetting(grd_2, row - 1, "DeliveryRegionCd", "E") ' "|���ó�����ڵ�;DeliveryRegionCd;7;;c;" & "io;n;n;7;"     '���ó�����ڵ�"
                ComboValueSetting(grd_2, row - 1, "DeliveryDivCd", "1") ' "|��ޱ����ڵ�;DeliveryDivCd;7;;c;" & "io;n;n;7;"     '��ޱ����ڵ�"

                grd_2.SetData(row - 1, "BranchNote", Me.grd_1.GetCurrentRowCellValue("BranchNote")) '' BranchNote �������޻���
                grd_2.SetData(row - 1, "FixedStDt", Me.grd_1.GetCurrentRowCellValue("FixedStDt")) '' FixedStDt ���Խ�������
                grd_2.SetData(row - 1, "FixedEdDt", Me.grd_1.GetCurrentRowCellValue("FixedEdDt"))  '' FixedEdDt ������������

                CheckPaperNum()
            End If

        End Sub

        '' Ȯ�� �����μ��� ���Ժμ��� �Ѿ���� Ȯ���Ѵ�.
        Private Sub CheckPaperNum()

            If grd_1.Rows > 1 Then
                Me.TxtContactPaperNumTot.Text = Me.grd_1.GetCurrentRowCellValue("TargetPaperTotNum") '' �����μ�
                Dim FixPagNum As Integer = 0
                For i As Integer = 2 To grd_2.Rows - 1
                    FixPagNum = FixPagNum + Convert.ToInt32(Me.grd_2.GetData(i, "FixedPagerNum"))
                Next
                Me.TxtFixedPagerNum.Text = FixPagNum

                If Convert.ToInt32(TxtContactPaperNumTot.Text) < Convert.ToInt32(TxtFixedPagerNum.Text) Then
                    MsgBox("���Ժμ� �հ谡 Ȯ�� �����μ� ���� �����ϴ�.")

                End If
            End If

        End Sub

        ''' <summary>
        ''' �޺� �� ����
        ''' </summary>
        ''' <param name="_grd">������ �׸���</param>
        ''' <param name="row">������ ���ȣ</param>
        ''' <param name="colName">������ �÷���</param>
        ''' <param name="key">�޺� ��</param>
        ''' <remarks>�޺� ���� ��� �Բ� �׸��忡 ǥ���Ѵ�.</remarks>
        Private Sub ComboValueSetting(ByVal _grd As ubiLease.GridControl.grd, ByVal row As Integer, ByVal colName As String, ByVal key As String)
            Dim strs() As String = _grd.get_ColComboList(_grd.get_ColIndex(colName)).Split("|")
            For Each str As String In strs
                If str.Split(".")(0) = key Then
                    _grd.SetData(row, colName, str)
                    Exit For
                End If
            Next
        End Sub
        

        ''' <summary>
        ''' �Լ��� : btnOpenExcel_Click 
        ''' ��  �� : import�� ���� ���� ����
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2007-08-27
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnOpenExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenExcel.Click

            Dim strFileName As String = ""      '���� ��
           
            With Me.dlgOpenFile
                .CheckPathExists = True
                .Multiselect = False
                .Title = "���ε��� ���� ������ �����ϼ���"
                .DefaultExt = "xls"
                .Filter = "���� ����(*.xls;*.csv)|*.xls;*.csv"
                .InitialDirectory = "C:\"
                .FileName = ""
                .ShowDialog()

                If .FileName = "" Then
                    Exit Sub
                End If

                ExcelReader(.FileName)

            End With

        End Sub

        ''����
        Private Sub ExcelReader(ByVal strFileName As String)

            Dim intExcelRow As Integer = 0      '���� �� ��ȣ
            Dim intGridRow As Integer = 0       '�׸��� �� ��ȣ
            Dim intRowCnt As Integer = 0        '��ü �� ��


            Dim excTemp As Object = CreateObject("Excel.Application") '���� �۾� ��ü ����
            Dim wrbTemp As Object = Nothing '
            Dim shtTemp As Object = Nothing '�� �۾� sheet ��ü

            '���� ���� üũ
            Try
                wrbTemp = excTemp.Workbooks.Open(strFileName)
            Catch ex As Exception
                shtTemp = Nothing
                wrbTemp = Nothing
                excTemp = Nothing
                MessageBox.Show(ex.Message, "���� ���� ���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            'ù�� ° ��Ʈ�� �ε� ��
            shtTemp = wrbTemp.Sheets(1)

            'ù ���� ���� ǥ�� ��
            For intExcelRow = 1 To 1000 Step 1
                If Trim(shtTemp.Cells(intExcelRow, 1).Value) = "" Then
                    intRowCnt = intExcelRow - 2
                    Exit For
                End If
            Next intExcelRow

            '���� ������ üũ
            If intExcelRow <= 0 Then
                shtTemp = Nothing
                wrbTemp = Nothing
                excTemp = Nothing
                MessageBox.Show("���� ù��° ��Ʈ�� �����Ͱ� �������� �ʽ��ϴ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor()
            '�׸��忡 ����
            With Me.grd_2
                .Rows = .FixedRows
                '' ���ڸ�	�����μ�	���Ժμ�	
                '' ��ȭ��ȣ1	�ڵ�����ȣ	
                '' ���ڻ����ڵ�	���������ڵ�	�����ֱ��ڵ�  ���ó�����ڵ�	
                '' �������޻���	��������	������������

                For intGridRow = 1 To intRowCnt
                    .AddRow()
                    .SetData(intGridRow + 1, 0, intGridRow)
                    .SetData(intGridRow + 1, .get_ColIndex("EmployeeExpNum"), Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum"))     '���Ȯ���ȣ
                    .SetData(intGridRow + 1, .get_ColIndex("ReceiptCd"), "")    '�����ڵ�
                    .SetData(intGridRow + 1, .get_ColIndex("ContactDt"), Me.grd_1.GetCurrentRowCellValue("ExpandDt"))    '��������
                    .SetData(intGridRow + 1, .get_ColIndex("Orders"), intGridRow.ToString)    '����

                    .SetData(intGridRow + 1, .get_ColIndex("SubscriberNm"), shtTemp.Cells(intGridRow + 1, 1).Value)     '���ڸ�
                    .SetData(intGridRow + 1, .get_ColIndex("ContactPaperNum"), shtTemp.Cells(intGridRow + 1, 2).Value)     '�����μ�
                    .SetData(intGridRow + 1, .get_ColIndex("FixedPagerNum"), shtTemp.Cells(intGridRow + 1, 3).Value)     '���Ժμ�
                    .SetData(intGridRow + 1, .get_ColIndex("PhoneNum1"), shtTemp.Cells(intGridRow + 1, 4).Value)     '��ȭ��ȣ1
                    .SetData(intGridRow + 1, .get_ColIndex("MobileNum"), shtTemp.Cells(intGridRow + 1, 5).Value)     '�ڵ�����ȣ

                    ComboValueSetting(grd_2, intGridRow + 1, "ReaderStateCd", shtTemp.Cells(intGridRow + 1, 6).Value)     '���ڻ����ڵ�"
                    ComboValueSetting(grd_2, intGridRow + 1, "CollectionTypeCd", Me.grd_1.GetCurrentRowCellValue("CollectionDivCd")) '"|���������ڵ�;CollectionTypeCd;7;;c;" & "io;n;n;7;"     '���ݱ����ڵ�"
                    ComboValueSetting(grd_2, intGridRow + 1, "BillPeriodCd", Me.grd_1.GetCurrentRowCellValue("BillPeriodCd")) ' "|�����ֱ��ڵ�;BillPeriodCd;7;;c;" & "io;n;n;7;"     '�����ֱ��ڵ�"
                    ComboValueSetting(grd_2, intGridRow + 1, "DeliveryRegionCd", shtTemp.Cells(intGridRow + 1, 9).Value) ' "|���ó�����ڵ�;DeliveryRegionCd;7;;c;" & "io;n;n;7;"     '���ó�����ڵ�"
                    ComboValueSetting(grd_2, intGridRow + 1, "DeliveryDivCd", shtTemp.Cells(intGridRow + 1, 10).Value) ' "|��ޱ����ڵ�;DeliveryDivCd;7;;c;" & "io;n;n;7;"     '��ޱ����ڵ�"

                    .SetData(intGridRow + 1, "BranchNote", Me.grd_1.GetCurrentRowCellValue("BranchNote")) '' BranchNote �������޻���
                    .SetData(intGridRow + 1, .get_ColIndex("FixedStDt"), Me.grd_1.GetCurrentRowCellValue("FixedStDt"))     '��������
                    .SetData(intGridRow + 1, .get_ColIndex("FixedEdDt"), Me.grd_1.GetCurrentRowCellValue("FixedEdDt"))     '������������


                    Application.DoEvents()
                Next intGridRow
            End With
            Me.Cursor = Cursors.Default()
            MessageBox.Show("���� ���ε尡 �Ϸ� �Ǿ����ϴ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            shtTemp = Nothing '�� �۾� sheet ��ü
            wrbTemp = Nothing '
            'excTemp = Nothing ' '���� �۾� ��ü ����
            excTemp.Workbooks.Close()
        End Sub


        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            ''Dim CurruntRow As Long

            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("TargetPaperTotNum"), "0")    '|�����μ�
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NewExpPapNum"), "0")         '|�űԺμ�
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("ReExpPapNum"), "0")          '|��Ȯ��μ�
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NoListPapNum"), "0")         '|��ܾ��ºμ�
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("FixedPaperNum"), "0")        '|Ȯ���μ�
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("SubscribePagerNum"), "0")    '|���Ժμ�
            'Me.grd_1.set_TextMatrix(grd_1.Rows - 1, grd_1.get_ColIndex("NoSubscribePagerNum"), "0")  '|�����Ժμ�
            With grd_1
                If .Rows > 1 Then
                    '' ''CurruntRow = .GetCurrentRowCellValue("")
                    'Ȯ���μ� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("NewExpPapNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("ReExpPapNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedPaperNum"), TotalValue.ToString)
                End If
            End With
        End Sub

        '���� ������ ��� ���� , ���� ���� ��¥ ����
        Private Sub SetDateSetting()

            Dim sdate As Date
            Dim tmpDate As String
            Dim tmpDate2 As String


            tmpDate = grd_1.GetCurrentRowCellValue("ExpandDt") ' Ȯ��������
            tmpDate2 = grd_1.GetCurrentRowCellValue("FixedStDt") ' ������������

            If Len(tmpDate) = 0 Then
                sdate = dtpFromExpand.Text
            Else
                sdate = CDate(VB6.Format(tmpDate, "@@@@-@@-@@"))
                'sdate = CDate(Format(tmpDate.Substring(0, 4) + "-" + tmpDate.Substring(4, 2) + tmpDate.Substring(6, 2), "####-##-##"))
            End If


            If grd_1.GetCurrentRowCellValue("CollectionDivCd") = "2" Then
                If grd_1.get_ColKey(grd_1.CursorCell.c1) = "FixedStDt" Then
                    'Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedStDt"), DateAdd(DateInterval.Day, +1, sdate))
                    Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Year, 1, sdate))))
                ElseIf grd_1.get_ColKey(grd_1.CursorCell.c1) = "CollectionDivCd" Then
                    Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedStDt"), DateAdd(DateInterval.Day, +1, sdate))
                    Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Year, 1, sdate))))
                End If

            End If

                If Len(tmpDate2) = 0 Then Exit Sub

                ''������ ����� ������ ����
                Me.grd_1.set_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("FixedEdDt"), DateAdd(DateInterval.Day, -1, (DateAdd(DateInterval.Year, 1, CDate(VB6.Format(tmpDate2, "@@@@-@@-@@"))))))

        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.Row)
            SetDateSetting()
        End Sub

        ''' <summary>
        ''' �Լ��� : btnEmExReader_Click 
        ''' ��  �� : ȭ�� Jump!
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnEmExReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmExReader.Click

            '���Ȯ�� ������ ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '���Ȯ���ȣ
            strCode = Me.dtpFromExpand.TextValue & ";" & Me.dtpToExpand.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum")
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNE102;" & strCode)
            Me.ShowUiControl("PNE102", strCode)

        End Sub

        Private Sub grd_2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_2.DoubleClick

            '���Ȯ�� ���� ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '�������ڹ�ȣ
            strCode = Me.dtpFromExpand.TextValue & ";" & Me.dtpToExpand.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_2.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNC102;" & strCode)
            Me.ShowUiControl("PNC102", strCode)

        End Sub

        '' '' ��Ȯ�� ó��  
        Private Sub brnReExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnReExt.Click
            Dim intRow As Integer = grd_1.Rows - 1
            With grd_1
                For intII As Integer = 2 To intRow
                    If .GetCellCheck(intII, .get_ColIndex("����")) = CheckEnum.Checked Then
                        .AddRow()
                        .set_TextMatrix(.Rows - 1, 0, "�ű�")
                        For intJJ As Integer = .get_ColIndex("ExpandDt") To .get_ColIndex("Dummy")
                            .set_TextMatrix(.Rows - 1, intJJ, .get_TextMatrix(intII, intJJ))
                        Next
                        .set_TextMatrix(.Rows - 1, .get_ColIndex("OldEmployeeExpNum"), .get_TextMatrix(intII, .get_ColIndex("EmployeeExpNum")))
                        .SetCellCheck(intII, .get_ColIndex("����"), CheckEnum.Unchecked)
                    End If
                Next
            End With
        End Sub

        Private Sub btnExecDemand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecDemand.Click

            '���Ȯ�� û����ȹ ��� ȭ������ JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '���Ȯ���ȣ
            strCode = Me.dtpFromExpand.TextValue & ";" & Me.dtpToExpand.TextValue _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("CompanyNm") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("EmployeeExpNum")
            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNE421;" & strCode)
            Me.ShowUiControl("PNE421", strCode)

        End Sub

        Private Sub grd_2_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_2.AfterEdit
            Call UpdateSelectedSum()
        End Sub

        Private Sub grd_2_AfterRowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles grd_2.AfterRowColChange
            Call UpdateSelectedSum()
        End Sub

        Private Sub UpdateSelectedSum()
            Dim sumRow As Integer = 0

            With grd_2

                For i As Integer = 2 To grd_2.Rows - 1
                    If .GetCellCheck(i, .get_ColIndex("����")) = CheckEnum.Checked Then
                        sumRow += .get_TextMatrix(i, .get_ColIndex("ContactPaperNum"))
                    End If
                Next

            End With

            Me.txtSelectedNum.TextValue = sumRow
        End Sub

        Private Sub btnBulkApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBulkApply.Click
            With grd_2
                For i As Integer = 2 To grd_2.Rows - 1
                    If .GetCellCheck(i, .get_ColIndex("����")) = CheckEnum.Checked Then
                        .set_TextMatrix(i, .get_ColIndex("TrAdEmployeeNum"), Me.popTrAdEmployeeNum.TextValue)
                        .set_TextMatrix(i, .get_ColIndex("TrAdEmployeeNm"), Me.popTrAdEmployeeNum.NameText)
                        .set_TextMatrix(i, .get_ColIndex("TrAdEmployeeDeptCd"), Me.popTrAdEmployeeDeptCd.TextValue)
                        .set_TextMatrix(i, .get_ColIndex("TrAdEmployeeDeptNm"), Me.popTrAdEmployeeDeptCd.NameText)
                        .set_TextMatrix(i, .get_ColIndex("AdEmployeeNum"), Me.popAdEmployeeNum.TextValue)
                        .set_TextMatrix(i, .get_ColIndex("AdEmployeeNm"), Me.popAdEmployeeNum.NameText)
                        .set_TextMatrix(i, .get_ColIndex("AdEmployeeDeptCd"), Me.popAdEmployeeDeptCd.TextValue)
                        .set_TextMatrix(i, .get_ColIndex("AdEmployeeDeptNm"), Me.popAdEmployeeDeptCd.NameText)
                    End If

                    '.SetCellCheck(i, .get_ColIndex("����"), CheckEnum.Unchecked)
                Next

            End With
        End Sub

        Private Sub grd_1_AfterSelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
            Call RequestData_2()


            '2020.12.04 ����ͽ� ��û���� ������Ʈ ����
            'Me.popTrAdEmployeeDeptCd.TextValue = ""
            'Me.popTrAdEmployeeNum.TextValue = ""
            'Me.popAdEmployeeDeptCd.TextValue = ""
            'Me.popAdEmployeeNum.TextValue = ""
        End Sub
    End Class

End Namespace
