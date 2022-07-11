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

Imports Microsoft.Office.Interop
Imports System.IO

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB104
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
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������Ʈ ��ȣ;ProjectID;60;;c;" & "io;n;y;5;������Ʈ ��;ProjectName"
            gridAttributes = gridAttributes & "|������Ʈ ��;ProjectName;60;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�ý��� ��ȣ;SystemID;60;;c;" & "o;n;y;5;�ý��� ��;SystemName"
            gridAttributes = gridAttributes & "|�ý��� ��;SystemName;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�޴�;Levels;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���μ��� ��ȣ;ProcID;60;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|���μ��� ��;ProcName;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;ProcDesc;60;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|��� ����;UseYesOrNo;70;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|��������;CreateYesOrNo;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��������;DeleteYesOrNo;70;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|��ȸ����;SelectYesOrNo;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|ó������;ManagementYesOrNo;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���;FunctionDesc;70;;l;" & "io;n;n;40;"

            gridAttributes = gridAttributes & "|������ó���Ǽ�;IoCnt;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�߻��ֱ�;Cycle;70;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|�߻��ֱ����;CycleUnit;60;;l;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|���ÿ䱸���׹�ȣ;RefReqId;70;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|���α׷�ID;ProgramID;70;;l;" & "io;y;n;40;���α׷� ��;ProgramName"
            gridAttributes = gridAttributes & "|���α׷� ��;ProgramName;70;;l;" & "o;n;n;40;"

            'gridAttributes = gridAttributes & "|���α׷�ID;ProgramID;70;;l;" & "io;n;n;40;���� ���α׷� ��;ProgramName"
            'gridAttributes = gridAttributes & "|���� ���α׷���;ProgramName;70;;l;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CycleUnit;�߻��ֱ� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1
            Me.grd_1.ExplorerBar = 3

            'Me.GetTempletPath()

        End Sub

        Private Sub PNB104_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

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

        Dim xlApp As Excel.Application = Nothing
        Dim xlDoc As Excel.Workbook = Nothing
        Dim xlSht As Excel.Worksheet = Nothing

        Dim intJJ As Integer

        Dim strProjectName As String = "" '������Ʈ ��
        Dim strSystemName As String = "" '�ý��� ��
        Dim strUnitSystemName As String = "" '���� �ý��� ��
        Dim strTodate As String = "" '���� ��¥


#Region "���α׷� ���"

        Private Sub btnExelExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'Dim ResultDataSet As DataSet = Me.ProgramListRequestData

            ' ��ȸ�� �����Ͱ� ������� ���� ����~
            'If ResultDataSet.Tables(0).Rows.Count < 1 Then
            '    Exit Sub
            'End If

            ' ���� ��ü ����
            xlApp = CreateObject("Excel.Application")
            Try
                ' ��ũ�� ��ü ����
                xlDoc = xlApp.Workbooks.Open(strFilePath & "\���α׷����.xls")
            Catch
                MessageBox.Show("�ش��ο� ���α׷���� ���ø� ���� ������ �����ϴ� Ȯ���� �۾��ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' ��ũ ��Ʈ ��ü ����
            xlSht = xlDoc.Worksheets("���α׷����")
            ' ���� ��ü�� �����ش�
            xlApp.Visible = True
            Try
                ' �ý��� ���� �����ڷ� ���� ���� ó�� �ý��� ���� �޾Ƶд�.
                'Dim tmpSystemName As String = ResultDataSet.Tables(0).Rows(0).Item("UnitSystemName")
                'strUnitSystemName = ResultDataSet.Tables(0).Rows(0).Item("UnitSystemName")

                ' �ý��� ���� ������ ���� ���� ���� ex) �λ������ 44���� ���̶�� 45���ʹ� ȸ�� �������� ����Ÿ�� �Ѹ��� ����.. 
                'Dim intRowNumber As Integer = ResultDataSet.Tables(0).Rows.Count - 1
                Dim intTemp As Integer = 0
                Dim intForNumber As Integer = 0

                'For intj As Integer = 2 To ResultDataSet.Tables(0).Rows(0).Item("SystemCount") + 1

                ' Ÿ��Ʋ ������ ������ ���
                'strProjectName = ResultDataSet.Tables(0).Rows(intForNumber).Item("ProjectName").ToString '������Ʈ ��
                'strSystemName = ResultDataSet.Tables(0).Rows(intForNumber).Item("SystemName").ToString '�ý��� ��
                'strUnitSystemName = ResultDataSet.Tables(0).Rows(intForNumber).Item("UnitSystemName").ToString '���� �ý��� ��
                'strTodate = ResultDataSet.Tables(0).Rows(intForNumber).Item("CreateDate").ToString '�ۼ� ����

                xlDoc.Worksheets.Copy()

                'xlApp.Workbooks(intj).Worksheets(1).Name = strUnitSystemName & " ���α׷����"

                'xlApp.Workbooks(intj).Worksheets(1).Cells(1, 2) = strProjectName '������Ʈ ��
                'xlApp.Workbooks(intj).Worksheets(1).Cells(2, 2) = strSystemName '�ý��� ��
                'xlApp.Workbooks(intj).Worksheets(1).Cells(3, 2) = strUnitSystemName '���� �ý��� ��
                'xlApp.Workbooks(intj).Worksheets(1).Cells(1, 11) = strTodate '�ۼ� ����
                'xlApp.Workbooks(intj).Worksheets(1).Cells(2, 11) = ResultDataSet.Tables(0).Rows(intForNumber).Item("EmployeeNameHangul").ToString '�ۼ���

                ' ������° �� ����
                'xlApp.Workbooks(intj).Worksheets(1).Rows(6).Copy()

                intTemp = 0

                '  �� �ٿ� �ֱ�
                'For inti As Integer = 0 To ResultDataSet.Tables(0).Rows(intForNumber).Item("CountMax") - 1
                '    xlApp.Workbooks(intj).Worksheets(1).Rows(7 + intTemp).PasteSpecial() 'xlPasteAll, xlPasteSpecialOperationAdd)
                '    intTemp = intTemp + 1
                'Next

                intTemp = 0

                'For intJJ = 0 To ResultDataSet.Tables(0).Rows(intForNumber).Item("countMax") - 1

                ' SP �� �� �ѹ��� �޾ƿ� ���� �Ѵ�
                'intTemp = ResultDataSet.Tables(0).Rows(intForNumber).Item("RowNumber") - 1

                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 1) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu1")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 2) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu2")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 4) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu3")

                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 7) = ResultDataSet.Tables(0).Rows(intForNumber).Item("ProgramID")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 9) = ResultDataSet.Tables(0).Rows(intForNumber).Item("FunctionDesc")

                ' ���� ���� ���� ������....
                'If intForNumber < ResultDataSet.Tables(0).Rows.Count - 1 Then
                ' ���� ���� �ý��� ��� ���� ���� �ý��� ���� �� �ؼ� �ٸ���... �ý��� ���� �� �ؼ� 
                'If tmpSystemName <> ResultDataSet.Tables(0).Rows(intForNumber + 1).Item("UnitSystemName").ToString Then
                '    tmpSystemName = ResultDataSet.Tables(0).Rows(intForNumber + 1).Item("UnitSystemName").ToString

                '�� �ý����� �ο� ������ 1�� ���Ѵ�(�ý����� ����)
                'intForNumber = intForNumber + 1
                'Exit For
                'End If
                'intForNumber = intForNumber + 1
                'End If
                'Next

                ' ó�� ������ ������ ���� ���� ���� Ȯ��
                'If intj = 2 Then
                '    Dim TempDirectorys As New DirectoryInfo(strFilePath & "\!���α׷� ���")
                ' ��� �ȿ� ���α׷���� ������ ������ �ڵ� ����

                'If Not (TempDirectorys.Exists) Then
                '    TempDirectorys.Create()
                'End If
                'End If

                ' ���μ��� ������ ���� ���� �ͱٴ�
                'Dim strSaveFileNames As String = Replace(Replace(strFilePath & "\!���α׷� ���\" & strProjectName, "������ũ��", ""), "����", "") & "- " & strUnitSystemName & " ���α׷� ���(" & strTodate & ").xls"

                'Try
                'xlApp.Workbooks(intj).Worksheets(1).SaveAs(strSaveFileNames)
                'Catch ex As Exception
                '    MsgBox(strSaveFileNames & vbCrLf & "������ �̸����� ������ �־� �ڵ� ������ �ʵ˴ϴ� ������ ���� �ϼ���", MsgBoxStyle.DefaultButton1, "�ڵ� ����")
                'End Try

                '    Next

                '���� ���� �ڵ����� ����
                System.Diagnostics.Process.Start("explorer.exe", strFilePath & "\!���α׷� ���")

            Catch
                MsgBox("���� ���� ������ �ǵ��� ���ÿ�~ ", MsgBoxStyle.DefaultButton1, Me.Name)
            End Try
            xlApp.Workbooks(1).Close()

            'ResultDataSet = Nothing

            'xlSht = Nothing
            'xlDoc = Nothing

            'xlApp = Nothing

            xlApp.Quit()

            'System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSht)
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(xlDoc)
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)

            GC.Collect()
            GC.WaitForPendingFinalizers()

            'strSystemName = ResultDataSet.Tables(0).Rows(intJJ).Item("SystemName").ToString '�ý��� ��

            'xlDoc = xlApp.Workbooks.Open(strFilePath & "\���α׷����.xls")

            '' Ÿ��Ʋ ����
            'xlSht = xlDoc.Worksheets("���α׷����")

            'xlSht.Cells(1, 2) = ResultDataSet.Tables(0).Rows(intJJ).Item("ProjectName").ToString '������Ʈ ��
            'strProjectName = ResultDataSet.Tables(0).Rows(intJJ).Item("ProjectName").ToString '������Ʈ ��

            'xlSht.Cells(2, 2) = strSystemName '�ý��� ��
            'strTodate = ResultDataSet.Tables(0).Rows(intJJ).Item("CreateDate").ToString '�ۼ� ����
            'xlSht.Cells(1, 12) = ResultDataSet.Tables(0).Rows(intJJ).Item("CreateDate").ToString '�ۼ� ����
            'xlSht.Cells(2, 12) = ResultDataSet.Tables(0).Rows(intJJ).Item("EmployeeNameHangul").ToString '�ۼ���

            'xlSht.Rows(6).Copy()

            'For intJJ = 0 To ResultDataSet.Tables(0).Rows.Count - 1
            '    '=======================================================
            '    '  SP ��� ���� ����
            '    '=======================================================

            '    '  ��ó�� 
            '    xlSht.Rows(7 + intJJ).PasteSpecial() 'xlPasteAll, xlPasteSpecialOperationAdd)

            '    xlSht.Cells(6 + intJJ, 1) = ResultDataSet.Tables(0).Rows(intJJ).Item("menu1").ToString
            '    xlSht.Cells(6 + intJJ, 2) = ResultDataSet.Tables(0).Rows(intJJ).Item("menu2").ToString
            '    xlSht.Cells(6 + intJJ, 4) = ResultDataSet.Tables(0).Rows(intJJ).Item("menu3").ToString
            '    xlSht.Cells(6 + intJJ, 7) = ResultDataSet.Tables(0).Rows(intJJ).Item("ProgramID").ToString
            '    xlSht.Cells(6 + intJJ, 9) = ResultDataSet.Tables(0).Rows(intJJ).Item("FunctionDesc").ToString
            'Next

            '' ������ ������ �����....
            'For inti As Integer = 1 To 20
            '    xlSht.Cells(ResultDataSet.Tables(0).Rows.Count + 6, inti) = ""
            'Next

            'Dim TempDirectory As New DirectoryInfo(strFilePath & "\!���α׷� ���\")

            '' ��� �ȿ� ���α׷���� ������ ������ �ڵ� ����
            'If Not (TempDirectory.Exists) Then
            '    TempDirectory.Create()
            'End If

            '' ���α׷� ��� ���� ���� �ͱٴ�
            'Dim strSaveFileName As String = Replace(Replace(strFilePath & "\!���α׷� ���\" & strProjectName, "������ũ��", ""), "����", "") & "- " & strSystemName & " ���α׷� ���(" & strTodate & ").xls"

            'Try
            '    xlSht.SaveAs(strSaveFileName)
            'Catch ex As Exception
            '    MsgBox(strSaveFileName & vbCrLf & "������ �̸����� ������ �־� �ڵ� ������ �ʵ˴ϴ� ������ ���� �ϼ���", MsgBoxStyle.DefaultButton1, "�ڵ� ����")
            'End Try

            ' ''Dim strTempDirectory As String = "C:\!���α׷� ���\"

            ' ''Dim TempDirectory As New DirectoryInfo(strTempDirectory)

            '' '' ��� �ȿ� ���α׷���� ������ ������ �ڵ� ����
            ' ''If Not (TempDirectory.Exists) Then
            ' ''    TempDirectory.Create()
            ' ''End If

            '' '' ���α׷� ��� ���� ���� �ͱٴ�
            ' ''Dim strSaveFileName As String = Replace(Replace(strTempDirectory & strProjectName, "������ũ��", ""), "����", "") & "- " & strSystemName & " ���α׷� ���(" & strTodate & ").xls"

            ' ''temp = Nothing
            ' ''temp = System.IO.Directory.GetFiles(strTempDirectory)
            '' '' !���α׷� ��� ���� ���� ���� ���� �� �Ͽ� ������ �ڵ� ���̺� ����.
            ' ''For inti As Integer = 0 To temp.Length - 1
            ' ''    If temp(inti).ToString = strSaveFileName Then
            ' ''        xlSht = Nothing
            ' ''        xlDoc = Nothing
            ' ''        xlApp = Nothing
            ' ''        Exit Sub
            ' ''    End If
            ' ''Next

            ' ''xlSht.SaveAs(strSaveFileName)


            'ResultDataSet = Nothing
            'xlSht = Nothing
            'xlDoc = Nothing
            'xlApp = Nothing

            '' ExcelAppKill()

        End Sub
#End Region

#Region "���μ��� ������"

        Private Sub btnProcessStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'Dim ResultDataSet As DataSet = Me.ProcessStepRequestData

            ' ��ȸ�� ����Ÿ�� ������ �о�~
            'If ResultDataSet.Tables(0).Rows.Count < 1 Then
            '    Exit Sub
            'End If
            Try
                ' ���� ��ü ����
                xlApp = CreateObject("Excel.Application")
                Try
                    ' ��ũ�� ��ü ����
                    xlDoc = xlApp.Workbooks.Open(strFilePath & "\���μ���������.xls")
                Catch
                    MessageBox.Show("�ش��ο� ���μ��������� ���ø� ���� ������ �����ϴ� Ȯ���� �۾��ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                ' ��ũ ��Ʈ ��ü ����
                xlSht = xlDoc.Worksheets("���μ���������")

                ' ���� ��ü�� �����ش�
                xlApp.Visible = True

                'Dim tmpSystemName As String = ResultDataSet.Tables(0).Rows(0).Item("UnitSystemName")
                'strUnitSystemName = ResultDataSet.Tables(0).Rows(0).Item("UnitSystemName")

                ' �ý��� ���� ������ ���� ���� ���� ex) �λ������ 44���� ���̶�� 45���ʹ� ȸ�� �������� ����Ÿ�� �Ѹ��� ����.. 
                'Dim intRowNumber As Integer = ResultDataSet.Tables(0).Rows.Count - 1
                Dim intTemp As Integer = 0
                Dim intForNumber As Integer = 0

                'For intj As Integer = 2 To ResultDataSet.Tables(0).Rows(0).Item("SystemCount") + 1

                ' Ÿ��Ʋ ������ ������ ���
                'strProjectName = ResultDataSet.Tables(0).Rows(intForNumber).Item("ProjectName").ToString '������Ʈ ��
                'strSystemName = ResultDataSet.Tables(0).Rows(intForNumber).Item("SystemName").ToString '�ý��� ��
                'strUnitSystemName = ResultDataSet.Tables(0).Rows(intForNumber).Item("UnitSystemName").ToString '���� �ý��� ��
                'strTodate = ResultDataSet.Tables(0).Rows(intForNumber).Item("CreateDate").ToString '�ۼ� ����

                'xlDoc.Worksheets.Copy()

                'xlApp.Workbooks(intj).Worksheets(1).Name = strUnitSystemName & " ���μ���������"

                'xlApp.Workbooks(intj).Worksheets(1).Cells(1, 2) = strProjectName '������Ʈ ��
                'xlApp.Workbooks(intj).Worksheets(1).Cells(2, 2) = strSystemName '�ý��� ��
                'xlApp.Workbooks(intj).Worksheets(1).Cells(3, 2) = strUnitSystemName '���� �ý��� ��
                'xlApp.Workbooks(intj).Worksheets(1).Cells(1, 7) = strTodate '�ۼ� ����
                'xlApp.Workbooks(intj).Worksheets(1).Cells(2, 7) = ResultDataSet.Tables(0).Rows(intForNumber).Item("EmployeeNameHangul").ToString '�ۼ���

                ' ������° �� ����
                'xlApp.Workbooks(intj).Worksheets(1).Rows(6).Copy()

                intTemp = 0

                '  �� �ٿ� �ֱ�
                'For inti As Integer = 0 To ResultDataSet.Tables(0).Rows(intForNumber).Item("CountMax") - 1
                '    xlApp.Workbooks(intj).Worksheets(1).Rows(7 + intTemp).PasteSpecial() 'xlPasteAll, xlPasteSpecialOperationAdd)
                '    intTemp = intTemp + 1
                'Next

                intTemp = 0

                'For intJJ = 0 To ResultDataSet.Tables(0).Rows(intForNumber).Item("countMax") - 1

                ' SP �� �� �ѹ��� �޾ƿ� ���� �Ѵ�
                'intTemp = ResultDataSet.Tables(0).Rows(intForNumber).Item("RowNumber") - 1

                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 1) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu1")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 3) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu2")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 6) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu3")

                ' ���� ���� ���� ������....
                'If intForNumber < ResultDataSet.Tables(0).Rows.Count - 1 Then
                ' ���� ���� �ý��� ��� ���� ���� �ý��� ���� �� �ؼ� �ٸ���... �ý��� ���� �� �ؼ� 
                'If tmpSystemName <> ResultDataSet.Tables(0).Rows(intForNumber + 1).Item("UnitSystemName").ToString Then
                '    tmpSystemName = ResultDataSet.Tables(0).Rows(intForNumber + 1).Item("UnitSystemName").ToString

                '�� �ý����� �ο� ������ 1�� ���Ѵ�(�ý����� ����)
                'intForNumber = intForNumber + 1
                'Exit For
                'End If
                'intForNumber = intForNumber + 1
                'End If
                'Next

                ' ó�� ������ ������ ���� ���� ���� Ȯ��
                'If intj = 2 Then
                '    Dim TempDirectory As New DirectoryInfo(strFilePath & "\!���μ��� ������\")
                '    ' ��� �ȿ� ���α׷���� ������ ������ �ڵ� ����
                '    If Not (TempDirectory.Exists) Then
                '        TempDirectory.Create()
                '    End If
                'End If

                ' ���μ��� ������ ���� ���� �ͱٴ�
                Dim strSaveFileName As String = Replace(Replace(strFilePath & "\!���μ��� ������\" & strProjectName, "������ũ��", ""), "����", "") & "- " & strUnitSystemName & " ���μ��� ������(" & strTodate & ").xls"

                Try
                    'xlApp.Workbooks(intj).Worksheets(1).SaveAs(strSaveFileName)
                Catch ex As Exception
                    MsgBox(strSaveFileName & vbCrLf & "������ �̸����� ������ �־� �ڵ� ������ �ʵ˴ϴ� ������ ���� �ϼ���", MsgBoxStyle.DefaultButton1, "�ڵ� ����")
                End Try

                'Next
                '���� ���� �ڵ����� ����
                System.Diagnostics.Process.Start("explorer.exe", strFilePath & "\!���μ��� ������")

            Catch
                MsgBox("���� ���� ������ �ǵ��� ���ÿ�~ ", MsgBoxStyle.DefaultButton1, Me.Name)
            End Try

            xlApp.Workbooks(1).Close()

            'ResultDataSet = Nothing

            xlSht = Nothing
            xlDoc = Nothing

            xlApp = Nothing

        End Sub

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
                strFilePath = FolderPath.SelectedPath
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
                    'Me.GetTempletPath()
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

    End Class

End Namespace

