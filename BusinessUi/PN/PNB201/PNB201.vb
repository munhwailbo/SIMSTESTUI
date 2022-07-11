'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���μ��� ��� ���� ���
' form ���� : ���μ��� ��� ���ظ� ��� �Ѵ�.
' �ۼ��� : Ȳ����
' �ۼ��� : 2007-07-11
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


Imports System.IO

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB201
        Inherits CommonControls.UiControl

        ' ���� ��� ����
        Public strFilePath As String = ""

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;60;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;120;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;150;;c;" & "o;n;y;7;���� ��;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;150;;l;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�����强��;Name;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ֹι�ȣ;SocialNum;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|����;Stat;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�������;ContractDt;120;####-##-##;c;" & "o;n;n;10;"    ' 20081013
            gridAttributes = gridAttributes & "|������;CloseDt;120;####-##-##;c;" & "o;n;n;10;"    ' 20081013

            gridAttributes = gridAttributes & "|�����ȣ;PostNum;100;;l;" & "o;n;y;10;�����ȣ;CodeHangulName"
            ''            gridAttributes = gridAttributes & "|�ּ�;CodeHangulName;90;;c;" & "o;n;y;5;"       '(130)
            gridAttributes = gridAttributes & "|�ּ�;Addr;200;;l;" & "o;n;n;50;"       '(140)
            ''            gridAttributes = gridAttributes & "|���ּ�;Addr1;200;;l;" & "o;n;n;100;"       '(150)

            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum;200;;l;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;200;;l;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|;Dummy;80;;c;" & "o;n;n;10;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_3 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;120;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;150;;c;" & "o;n;y;7;���� ��;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;150;;l;" & "o;n;n;7;"
            '''''gridAttributes = gridAttributes & "|ȸ��;ChangeNum;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�������;ContractDt;120;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����;Stat;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;80;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|�����强��;BranchChiefCdName;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;80;;c;" & "o;n;n;10;"
            'grid_1 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_3.ExplorerBar = 3
            '==============================================================

            '-- ���� ���� ��ư�� ó������ ������ �ʰ� �Ѵ�.
            Me.picOpen.Visible = True
            Me.picSave.Visible = True

            Me.Label2.Visible = True

        End Sub

        Private Sub PNB201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        ''' <summary>
        ''' �Լ��� : PNB201_Enter 
        ''' ��  �� : ȭ�� ��ȯ(������ ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNB201_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
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
        Public Sub SetRequest(ByVal strBranchChiefName As String, ByVal strChiefCd As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.txtBranchChiefName.TextValue = strBranchChiefName  '�������
            Me.txtChiefCd.TextValue = strChiefCd      '�������ڵ�

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub


#Region "�˾� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : popSystemID
        ''' ��  �� : �˾� Where�� �߰� 
        ''' �ۼ��� : Ȳ����
        ''' �ۼ��� : 2007-10-08
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub popSystemID_ButtonClick()
            'Me.popSystemID.Tag = ""
            Dim strProjectID As String = ""
            'strProjectID = "code(�ý��� ��);where(ProjectID='" & Me.popProjectID.TextValue & "0');"
            'Me.popSystemID.Tag = strProjectID
            'MsgBox(strContractorIDTag)
        End Sub
#End Region

     
        Dim intJJ As Integer

        Dim strProjectName As String = "" '������Ʈ ��
        Dim strSystemName As String = "" '�ý��� ��
        Dim strUnitSystemName As String = "" '���� �ý��� ��
        Dim strTodate As String = "" '���� ��¥


#Region "���α׷� ���"

       
#End Region

#Region "���μ��� ������"

        

#End Region

#Region "���� ���μ��� Kill"

        Private Sub ExcelAppKill()

            Dim myPro() As Process
            Dim pro As Process

            myPro = Process.GetProcesses()

            For Each pro In myPro
                If pro.ProcessName = "EXCEL" Then
                    pro.Kill()
                End If
            Next
        End Sub
#End Region

#Region "���ø� ���� ��� ����"

        Private Sub btnFilePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Dim FolderPath As New FolderBrowserDialog
            FolderPath.ShowNewFolderButton = True

            Dim result As DialogResult = FolderPath.ShowDialog()

            If result = DialogResult.OK Then
                'Me.lblPath.Text = " ���� ���: " + FolderPath.SelectedPath
                'strFilePath = FolderPath.SelectedPath
                Dim intTempCoubt As Integer = 0

                Dim temp() As String = System.IO.Directory.GetFiles(FolderPath.SelectedPath & "\")

                If temp.Length > 0 Then
                    For inti As Integer = 0 To temp.Length - 1
                        If temp(inti) = strFilePath & "\���α׷����.xls" Then
                            intTempCoubt = intTempCoubt + 1
                            Exit Sub
                        End If
                    Next
                    MessageBox.Show("������ ��� �ȿ� ��� ���ø� ������ �����ϴ� ������ ��� �����ϼ��� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Exit Sub
                End If
            End If
        End Sub
#End Region

#Region "����"

        'Private Sub picCriteria_1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCriteria_1.MouseEnter
        '    Me.ToolTip1.GetToolTip(Me.picCriteria_1)
        '    Me.ToolTip1.SetToolTip(Me.picCriteria_1, strFilePath)
        'End Sub

        'Private Sub picCriteria_1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCriteria_1.MouseLeave
        '    If Me.ToolTip1.Active = True Then
        '        Me.ToolTip1.RemoveAll()
        '    End If
        'End Sub
#End Region

#Region "����"

        ''Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''    Dim SourceDirectory As New DirectoryInfo("c:\��� ���ø� �׽�Ʈ")
        ''    Dim DestinationDirectory As New DirectoryInfo("d:\��� ���ø� �׽�Ʈ")
        ''    Copy(SourceDirectory, DestinationDirectory, "���α׷���� �׽�Ʈ.xls", "���α׷���� �׽�Ʈ.xls", True)
        ''End Sub

        ''Protected Sub Copy(ByVal SourceDirectory As DirectoryInfo, ByVal DestinationDirectory As DirectoryInfo, ByVal SourceDirectoryFilter As String, ByVal SourceFileFilter As String, ByVal OverWrite As Boolean)

        ''    Dim SourceSubDirectories() As DirectoryInfo
        ''    Dim SourceFiles() As FileInfo

        ''    '���� ���� �˻�

        ''    If (SourceDirectoryFilter Is Nothing) Then
        ''        SourceSubDirectories = SourceDirectory.GetDirectories()
        ''    Else
        ''        SourceSubDirectories = SourceDirectory.GetDirectories(SourceDirectoryFilter.Trim())
        ''    End If

        ''    'Ÿ�� ������ ������ ����

        ''    If Not (DestinationDirectory.Exists) Then
        ''        DestinationDirectory.Create()
        ''    End If


        ''    '���� ���� �˻�

        ''    If (SourceFileFilter Is Nothing) Then
        ''        SourceFiles = SourceDirectory.GetFiles()
        ''    Else
        ''        SourceDirectory.Create()
        ''        ' SourceFiles = SourceDirectory.GetFiles(SourceFileFilter.Trim())
        ''    End If


        ''    '���ȣ��, ���������� �����Ѵ�.

        ''    For Each SourceSubDirectory As DirectoryInfo In SourceSubDirectories
        ''        Copy(SourceSubDirectory, New DirectoryInfo(DestinationDirectory.FullName + "\" + SourceSubDirectory.Name), SourceDirectoryFilter, SourceFileFilter, OverWrite)
        ''    Next

        ''    '������ �����Ѵ�.

        ''    For Each SourceFile As FileInfo In SourceFiles
        ''        SourceFile.CopyTo(DestinationDirectory.FullName + "\" + SourceFile.Name, OverWrite)
        ''    Next

        ''End Sub




        ''        Private Sub sb���α׷����()
        ''            On Error GoTo ErrRtn

        ''            Dim xlApp As Excel.Application
        ''            Dim xlDoc As Excel.Workbook
        ''            Dim xlSht As Excel.Worksheet
        ''            Dim xlTemplate As Excel.Worksheet
        ''            Dim iPage As Integer, intII As Integer, intJJ As Integer
        ''            Dim strFilePath As String

        ''            Dim strSql As String
        ''            Dim Str������Ʈ��ȣ As String, str�ý��۹�ȣ As String

        ''            strFilePath = "C:\��� ���ø�\���α׷����.xls"


        ''            If RS1.RecordCount > 0 Then

        ''                On Error Resume Next
        ''                xlApp = GetObject(, "Excel.Application")
        ''                If Err() Then
        ''                    xlApp = CreateObject("Excel.Application")
        ''                    xlApp.Visible = True
        ''                End If
        ''                On Error GoTo 0

        ''                xlDoc = xlApp.Workbooks.Add(strFilePath)
        ''                For intII = 1 To 1

        ''                    'Set xlTemplate = xlDoc.Worksheets("Temp")

        ''                    'xlTemplate.Copy xlTemplate
        ''                    'iPage = iPage + 1
        ''                    'Set xlSht = xlDoc.Worksheets(xlDoc.Worksheets.Count - 1)
        ''                    xlSht = xlDoc.Worksheets("���α׷����")
        ''                    'xlSht.Name = "Page " & CStr(iPage)

        ''                    '        xlSht.Range("B4", "G4").Copy
        ''                    '        xlSht.Range("B5", "G" & CStr(5 + intII)).PasteSpecial xlPasteAll
        ''                    xlSht.Cells(1, 2) = Trim(Mid((Cmb������Ʈ��ȣ.Text), 1, Len(Trim(Cmb������Ʈ��ȣ.Text)) - 5))
        ''                    xlSht.Cells(2, 2) = Trim(Mid((Cmb�ý��۹�ȣ.Text), 1, Len(Trim(Cmb�ý��۹�ȣ.Text)) - 3))
        ''                    xlSht.Cells(2, 12) = Str���PL

        ''                    xlSht.Rows(6).Copy()
        ''                    'For intCnt = 1 To intII
        ''                    For intJJ = 0 To RS1.RecordCount - 1
        ''                        xlSht.Rows(7 + intJJ).PasteSpecial(xlPasteAll, xlPasteSpecialOperationAdd)
        ''                        xlSht.Cells(6 + intJJ, 1) = RS1.Fields(0)
        ''                        xlSht.Cells(6 + intJJ, 2) = RS1.Fields(1)
        ''                        xlSht.Cells(6 + intJJ, 3) = RS1.Fields(2)
        ''                        xlSht.Cells(6 + intJJ, 5) = RS1.Fields(3)
        ''                        xlSht.Cells(6 + intJJ, 6) = RS1.Fields(4)
        ''                        xlSht.Cells(6 + intJJ, 7) = RS1.Fields(5)
        ''                        xlSht.Cells(6 + intJJ, 8) = RS1.Fields(6)
        ''                        xlSht.Cells(6 + intJJ, 9) = RS1.Fields(7)
        ''                        xlSht.Cells(6 + intJJ, 10) = RS1.Fields(8)
        ''                        xlSht.Cells(6 + intJJ, 11) = RS1.Fields(9)
        ''                        xlSht.Cells(6 + intJJ, 12) = RS1.Fields(10)
        ''                        xlSht.Cells(6 + intJJ, 13) = RS1.Fields(11)
        ''                        xlSht.Cells(6 + intJJ, 14) = RS1.Fields(12)

        ''                        RS1.MoveNext()
        ''                    Next
        ''                Next

        ''                xlSht = Nothing
        ''                xlTemplate = Nothing
        ''                xlDoc = Nothing
        ''                xlApp = Nothing

        ''            End If

        ''            RS1 = Nothing


        ''            Exit Sub
        ''ErrRtn:

        ''        End Sub
#End Region

      
        Private Sub picOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOpen.Click
            Me.OpenFileDialog1.InitialDirectory = "c:\"
            Me.OpenFileDialog1.Filter = "�̹��� ���� (*.jpg)|*.jpg|�̹��� ���� (*.bmp)|*.bmp|��� ���� (*.*)|*.*"

            Try
                If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                    PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                End If
            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub picSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSave.Click
            '-- �̹��� ����
            Call UpLoadImage()
        End Sub


        Private Sub grd_3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_3.DoubleClick

            '���� ���� ȭ������ ���� �ڵ带 �Ѱܼ� �ش� ���� ������ ��ȸ �Ѵ�.
            If Me.grd_3.Rows <= Me.grd_3.FixedRows Then Exit Sub

            Dim strBranchCd As String '���� �ڵ�
            strBranchCd = Me.grd_3.get_TextMatrix(Me.grd_3.Row, Me.grd_3.get_ColIndex("BranchCd")) '���� �ڵ�

            GmainBusinessFunction.SetValue("ȭ�� ��ȯ", "PNB202;" & strBranchCd)
            Me.ShowUiControl("PNB202", strBranchCd)

        End Sub

    End Class

End Namespace

