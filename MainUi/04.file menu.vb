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
Imports System.Configuration
Imports System.Reflection

Namespace ubiLease.UI.MainUi

    Partial Class frmMainUi
        Private Gexception As DAT.CustomException = New DAT.CustomException

        Public RequestPermition As Integer = 0
        Public SavePermition As Integer = 0
        Public DeletePermition As Integer = 0
        Public PrintPermition As Integer = 0
        Public ActivationPermition As Integer = 0

        '====================================================================================================
        Public Sub InitializeUiMessage()
            Me.lblRequestData.Text = ""
            Me.lblCreateData.Text = ""
            Me.lblUpdateData.Text = ""
            Me.lblDeleteData.Text = ""
            Me.lblMessage.Text = ""
        End Sub

        '====================================================================================================


        Public Sub mnuData_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles mnuRequestData.Click, btnRequestData.Click _
            , mnuNewData.Click, btnNewData.Click _
            , mnuSaveData.Click, btnSaveData.Click _
            , mnuDeleteData.Click, btnDeleteData.Click


            Me.Cursor = Cursors.WaitCursor

            Dim intSystemLogID As Integer = 0
            Dim Param As New System.Data.SqlClient.SqlParameter
            Dim UbiDat As New ubiLease.DAT.ExecuteDbCommand

            Try
                ' ���� ����
                If GmainCommonFunction.GactiveUiControlName <> "" Then
                    InitializeUiMessage()

                    Dim activeUiControl As Object = Me.pnlRight.Controls(Replace(GmainCommonFunction.GactiveUiControlName, "mnu", ""))

                    If CheckDataAllowPermitionByUser(GmainCommonFunction.GactiveUiControlName,
                                                 GmainBusinessFunction.GetValue("�α��� ID"),
                                                 Trim(Mid(sender.Name, 4, 50))) Then


                        '�� ó�� (CRUD ó��)
                        GmainCommonFunction.GdataProcessing = True

                        Select Case Trim(Mid(sender.Name, 4, 50))

                            Case "NewData" ' �ű� ����

                                activeUiControl.GmainCommonFunction.GRequestDataNumber = 1
                                '' CRUD �Լ� ȣ�� ó��
                                CallByName(activeUiControl, Mid(sender.Name, 4, 50), CallType.Method)

                            Case "RequestData" ' ��ȸ ����
                                GmainCommonFunction.GridFocusCollection = Nothing

                                ' ��Ʈ�� �ʼ� ���� üũ
                                If GmainCommonFunction.CheckControlsValidation(activeUiControl, 1) = True Then
                                    GoTo pntEnd
                                End If
                                activeUiControl.GmainCommonFunction.GRequestDataNumber = 1
                                '' CRUD �Լ� ȣ�� ó��
                                CallByName(activeUiControl, Mid(sender.Name, 4, 50), CallType.Method)

                            Case "SaveData" ' ���� ����

                                '�׸��� ���� ���� ���� üũ
                                GmainCommonFunction.GridFinishEditing(activeUiControl)

                                ' ��Ʈ�� �ʼ� üũ
                                If GmainCommonFunction.CheckControlsValidation(activeUiControl, 2) = True Then
                                    GoTo pntEnd
                                End If

                                ' UI Nogic üũ
                                If GmainCommonFunction.GactiveUiControl.GLogicCheckPassYesOrNo = False Then


                                    GoTo pntEnd
                                Else
                                    '' CRUD �Լ� ȣ�� ó��
                                    CallByName(activeUiControl, Mid(sender.Name, 4, 50), CallType.Method)
                                End If


                            Case "DeleteData" ' ���� ����

                                '' CRUD �Լ� ȣ�� ó��
                                CallByName(activeUiControl, Mid(sender.Name, 4, 50), CallType.Method)

                            Case Else

                        End Select

                        GmainCommonFunction.GdataProcessing = False



                        ' �ý��� CRUD ���� �α� �ۼ�    
                        intSystemLogID = UbiDat.SystemLog(intSystemLogID,
                                                            GmainCommonFunction.GbusinessDivisionName,
                                                            GmainCommonFunction.GactiveUiControlName,
                                                            Trim(Mid(sender.Name, 4, 50)),
                                                            GmainBusinessFunction.GetValue("�α��� ID"),
                                                            "",
                                                            "",
                                                            "")


                        '�ý��� CRUD ���� ��� �α� ������Ʈ

                        intSystemLogID = UbiDat.SystemLog(intSystemLogID,
                                                            GmainCommonFunction.GbusinessDivisionName,
                                                            GmainCommonFunction.GactiveUiControlName,
                                                            Trim(Mid(sender.Name, 4, 50)),
                                                            GmainBusinessFunction.GetValue("�α��� ID"),
                                                            "",
                                                            "",
                                                            "")

                        '�� ����

                        Select Case Trim(Mid(sender.Name, 4, 50))

                            Case "NewData" ' �ű� ����

                                activeUiControl.GrecordProcessMode = 1 '�߰�

                            Case "RequestData" ' ��ȸ ����

                                activeUiControl.GrecordProcessMode = 2 '����

                            Case "SaveData" ' ���� ����

                                GmainCommonFunction.GdataProcessing = True

                                Debug.Print("���� ������ȣ : " & activeUiControl.GmainExecuteDbCommand.GerrorNumber)
                                Debug.Print("���� �������� : " & activeUiControl.GmainExecuteDbCommand.GerrorDescription)

                                If activeUiControl.GmainExecuteDbCommand.GerrorNumber = 0 _
                                And activeUiControl.GmainExecuteDbCommand.GerrorDescription = "" _
                                Then
                                    ' Ŀ����ġ����
                                    GetGridCursor(activeUiControl)

                                    CallByName(activeUiControl, "RequestData", CallType.Method)

                                    ' Ŀ����ġ �����ϱ�
                                    'SetGridCursor(activeUiControl)
                                    GmainCommonFunction.GridFocusCollection = Nothing
                                Else

                                End If

                                GmainCommonFunction.GdataProcessing = False

                            Case "DeleteData" ' ���� ����

                                GmainCommonFunction.GdataProcessing = True

                                Debug.Print("���� ������ȣ : " & activeUiControl.GmainExecuteDbCommand.GerrorNumber)
                                Debug.Print("���� �������� : " & activeUiControl.GmainExecuteDbCommand.GerrorDescription)

                                If activeUiControl.GmainExecuteDbCommand.GerrorNumber = 0 _
                               And activeUiControl.GmainExecuteDbCommand.GerrorDescription = "" _
                               Then
                                    ' Ŀ����ġ����

                                    'GetGridCursor(activeUiControl)

                                    CallByName(activeUiControl, "RequestData", CallType.Method)
                                    ' Ŀ����ġ �����ϱ�
                                    'SetGridCursor(activeUiControl)
                                    'GmainCommonFunction.GridFocusCollection = Nothing

                                End If

                                GmainCommonFunction.GdataProcessing = False

                            Case Else

                        End Select



                        If _
                            activeUiControl.GmainExecuteDbCommand.GerrorNumber > 0 _
                            And activeUiControl.GmainExecuteDbCommand.GerrorDescription <> "" _
                            Then
                            'MsgBox(activeUiControl.GmainExecuteDbCommand.GerrorDescription)
                            lblMessage.Text = activeUiControl.GmainExecuteDbCommand.GerrorDescription
                        End If

                    Else
                        MessageBox.Show("������ �����ϴ�.")
                    End If

pntEnd:
                    Select Case Trim(Mid(sender.Name, 4, 50))

                        Case "NewData" ' �ű� ����

                            lblMessage.Text = "�ű� ó�� ����"
                        Case "RequestData" ' ��ȸ ����
                            lblMessage.Text = "��ȸ ó�� ����"


                        Case "SaveData" ' ���� ����

                            lblMessage.Text = "���� ó�� ����"

                        Case "DeleteData" ' ���� ����
                            lblMessage.Text = "���� ó�� ����"
                        Case Else

                    End Select

                    lblCreateData.Text = GmainExecuteDbCommand.GcreateCount
                    lblDeleteData.Text = GmainExecuteDbCommand.GdeleteCount
                    lblRequestData.Text = GmainExecuteDbCommand.GrequestCount
                    lblUpdateData.Text = GmainExecuteDbCommand.GupdateCount


                    activeUiControl = Nothing
                End If
            Catch ex As Exception
                '������ �α� �ۼ� �߻�
                Gexception.getException(ex)
                intSystemLogID = UbiDat.SystemLog(intSystemLogID,
                                                    GmainCommonFunction.GbusinessDivisionName,
                                                    GmainCommonFunction.GactiveUiControlName,
                                                    Trim(Mid(sender.Name, 4, 50)),
                                                    GmainBusinessFunction.GetValue("�α��� ID"),
                                                    ex.Source,
                                                    sender.ToString(),
                                                    ex.Message)
                'MessageBox.Show(ex.Message & System.Environment.NewLine & ex.ToString(), "��������", MessageBoxButtons.OK, MessageBoxIcon.Error)

                lblMessage.Text = GmainExecuteDbCommand.GerrorDescription
            End Try
            Me.Cursor = Cursors.Arrow


        End Sub
        ''' <summary>
        ''' ������ ��Ŀ�� ����
        ''' </summary>
        ''' <param name="ActiveUIObj"></param>
        ''' <remarks></remarks>
        Public Sub GetGridCursor(ByVal ActiveUIObj As Object)

            Dim eachControl As Object = Nothing
            Dim getedType As Type = Nothing
            Dim GridStringCollection As New Collection
            Dim grdString As New Object

            Try
                For Each eachControl In ActiveUIObj.Controls
                    getedType = eachControl.GetType
                    If getedType.Name = "grd" Then
                        'grdString = eachControl.Name & "," & eachControl.CursorCell.r1 & "," & eachControl.CursorCell.c1 & eachControl.get_TextMatrix
                        grdString = eachControl.Name & "," & eachControl.CursorCell.r1 & "," & eachControl.CursorCell.c1
                        GridStringCollection.Add(grdString, eachControl.Name)
                    End If
                Next
                GmainCommonFunction.GridFocusCollection = GridStringCollection
            Catch ex As Exception
                '������ �α� �ۼ� �߻�
                Gexception.getException(ex)
            End Try

        End Sub

        ''' <summary>
        '''  ������ ��Ŀ�� ó��
        ''' </summary>
        ''' <param name="ActiveUIObj"></param>
        ''' <remarks></remarks>
        Public Sub SetGridCursor(ByVal ActiveUIObj As Object)
            Dim eachControl As Object = Nothing
            Dim getedType As Type = Nothing
            Dim GridFocusRow As Integer = 0
            Dim GridFocusCol As Integer = 0
            Try

                For Each eachControl In ActiveUIObj.Controls
                    getedType = eachControl.GetType
                    If getedType.Name = "grd" Then

                        GridFocusRow = Split(GmainCommonFunction.GridFocusCollection.Item(eachControl.Name).ToString, ",")(1)
                        GridFocusCol = Split(GmainCommonFunction.GridFocusCollection.Item(eachControl.Name).ToString, ",")(2)
                        If CType(eachControl, ubiLease.GridControl.grd).Rows - 1 > 0 Then

                            If CType(eachControl, ubiLease.GridControl.grd).Rows - 1 >= GridFocusRow Then
                                CType(eachControl, ubiLease.GridControl.grd).Select(GridFocusRow, GridFocusCol, True)
                            Else
                                'CType(eachControl, ubiLease.GridControl.grd).Focus()
                                CType(eachControl, ubiLease.GridControl.grd).Select(CType(eachControl, ubiLease.GridControl.grd).BottomRow, GridFocusCol, True)
                                'eachControl.CallRequestData()
                            End If
                        Else


                        End If
                    End If
                Next

            Catch ex As Exception
                '������ �α� �ۼ� �߻�
                Gexception.getException(ex)
            End Try
        End Sub

        '====================================================================================================
        Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles _
        mnuExportDataToExcel.Click _
            , btnExportDataToExcel.Click

            InitializeUiMessage()

            '' ���� ��� ���� - ��� ���� ���� False 
            '' ���߿� ���� ���� True
            Dim TopMenu_excelExport_BufferCopy As Boolean = False


            If GmainCommonFunction.GactiveUiControlName <> "" Then

                If TopMenu_excelExport_BufferCopy Then
                    Me.CommonSaveDialog.FileName = GmainBusinessFunction.UiControlName(GmainCommonFunction.GactiveUiControlName).ToString()
                    Me.CommonSaveDialog.Filter = "���� ȭ�� (*.XLS)|*.XLS"
                    Me.CommonSaveDialog.DefaultExt = "XLS"
                    Me.CommonSaveDialog.SupportMultiDottedExtensions = True
                    Me.CommonSaveDialog.ValidateNames = True
                    Me.CommonSaveDialog.InitialDirectory = System.Environment.CurrentDirectory

                    If Me.CommonSaveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

                        Me.GmainCommonFunction.GridToExcelFile(Me, Me.CommonSaveDialog.FileName, GmainBusinessFunction.UiControlName(GmainCommonFunction.GactiveUiControlName).ToString())

                    Else

                    End If
                Else
                    'CallByName(GmainCommonFunction, Mid(sender.Name, 4, 50), CallType.Method)
                    GmainCommonFunction.ExportDataToExcel(Me)
                End If

            End If
        End Sub

        '====================================================================================================
        Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click, btnHelp.Click
            'IE ����  
            Process.Start(ConfigurationManager.AppSettings("HelpPagePath").ToString() & "?ProgramID=" & GmainCommonFunction.GactiveUiControlName)
        End Sub

        Private Sub btnNotepad_Click(sender As Object, e As EventArgs) Handles btnNotepad.Click
            Process.Start("Notepad")
            'System.Threading.Thread.Sleep(1000) '1000�и��� ���� ������ �Ͻ�����(������ ���)
            'My.Computer.Keyboard.SendKeys(Clipboard.GetText(), True)
        End Sub

        Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
            'IE ����  
            Process.Start("Calc")
        End Sub

        '====================================================================================================
        Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click, btnExit.Click
            frmMainUi_FormClosing(Nothing, Nothing)
        End Sub

    End Class

End Namespace
