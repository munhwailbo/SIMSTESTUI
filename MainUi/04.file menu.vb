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
                ' 권한 관리
                If GmainCommonFunction.GactiveUiControlName <> "" Then
                    InitializeUiMessage()

                    Dim activeUiControl As Object = Me.pnlRight.Controls(Replace(GmainCommonFunction.GactiveUiControlName, "mnu", ""))

                    If CheckDataAllowPermitionByUser(GmainCommonFunction.GactiveUiControlName,
                                                 GmainBusinessFunction.GetValue("로그인 ID"),
                                                 Trim(Mid(sender.Name, 4, 50))) Then


                        '전 처리 (CRUD 처리)
                        GmainCommonFunction.GdataProcessing = True

                        Select Case Trim(Mid(sender.Name, 4, 50))

                            Case "NewData" ' 신규 조건

                                activeUiControl.GmainCommonFunction.GRequestDataNumber = 1
                                '' CRUD 함수 호출 처리
                                CallByName(activeUiControl, Mid(sender.Name, 4, 50), CallType.Method)

                            Case "RequestData" ' 조회 조건
                                GmainCommonFunction.GridFocusCollection = Nothing

                                ' 컨트롤 필수 조건 체크
                                If GmainCommonFunction.CheckControlsValidation(activeUiControl, 1) = True Then
                                    GoTo pntEnd
                                End If
                                activeUiControl.GmainCommonFunction.GRequestDataNumber = 1
                                '' CRUD 함수 호출 처리
                                CallByName(activeUiControl, Mid(sender.Name, 4, 50), CallType.Method)

                            Case "SaveData" ' 저장 조건

                                '그리드 편집 종료 상태 체크
                                GmainCommonFunction.GridFinishEditing(activeUiControl)

                                ' 컨트롤 필수 체크
                                If GmainCommonFunction.CheckControlsValidation(activeUiControl, 2) = True Then
                                    GoTo pntEnd
                                End If

                                ' UI Nogic 체크
                                If GmainCommonFunction.GactiveUiControl.GLogicCheckPassYesOrNo = False Then


                                    GoTo pntEnd
                                Else
                                    '' CRUD 함수 호출 처리
                                    CallByName(activeUiControl, Mid(sender.Name, 4, 50), CallType.Method)
                                End If


                            Case "DeleteData" ' 삭제 조건

                                '' CRUD 함수 호출 처리
                                CallByName(activeUiControl, Mid(sender.Name, 4, 50), CallType.Method)

                            Case Else

                        End Select

                        GmainCommonFunction.GdataProcessing = False



                        ' 시스템 CRUD 실행 로그 작성    
                        intSystemLogID = UbiDat.SystemLog(intSystemLogID,
                                                            GmainCommonFunction.GbusinessDivisionName,
                                                            GmainCommonFunction.GactiveUiControlName,
                                                            Trim(Mid(sender.Name, 4, 50)),
                                                            GmainBusinessFunction.GetValue("로그인 ID"),
                                                            "",
                                                            "",
                                                            "")


                        '시스템 CRUD 실행 결과 로그 업데이트

                        intSystemLogID = UbiDat.SystemLog(intSystemLogID,
                                                            GmainCommonFunction.GbusinessDivisionName,
                                                            GmainCommonFunction.GactiveUiControlName,
                                                            Trim(Mid(sender.Name, 4, 50)),
                                                            GmainBusinessFunction.GetValue("로그인 ID"),
                                                            "",
                                                            "",
                                                            "")

                        '후 저리

                        Select Case Trim(Mid(sender.Name, 4, 50))

                            Case "NewData" ' 신규 조건

                                activeUiControl.GrecordProcessMode = 1 '추가

                            Case "RequestData" ' 조회 조건

                                activeUiControl.GrecordProcessMode = 2 '수정

                            Case "SaveData" ' 저장 조건

                                GmainCommonFunction.GdataProcessing = True

                                Debug.Print("저장 에러번호 : " & activeUiControl.GmainExecuteDbCommand.GerrorNumber)
                                Debug.Print("저장 에러내용 : " & activeUiControl.GmainExecuteDbCommand.GerrorDescription)

                                If activeUiControl.GmainExecuteDbCommand.GerrorNumber = 0 _
                                And activeUiControl.GmainExecuteDbCommand.GerrorDescription = "" _
                                Then
                                    ' 커서위치저장
                                    GetGridCursor(activeUiControl)

                                    CallByName(activeUiControl, "RequestData", CallType.Method)

                                    ' 커서위치 세팅하기
                                    'SetGridCursor(activeUiControl)
                                    GmainCommonFunction.GridFocusCollection = Nothing
                                Else

                                End If

                                GmainCommonFunction.GdataProcessing = False

                            Case "DeleteData" ' 삭제 조건

                                GmainCommonFunction.GdataProcessing = True

                                Debug.Print("삭제 에러번호 : " & activeUiControl.GmainExecuteDbCommand.GerrorNumber)
                                Debug.Print("삭제 에러내용 : " & activeUiControl.GmainExecuteDbCommand.GerrorDescription)

                                If activeUiControl.GmainExecuteDbCommand.GerrorNumber = 0 _
                               And activeUiControl.GmainExecuteDbCommand.GerrorDescription = "" _
                               Then
                                    ' 커서위치저장

                                    'GetGridCursor(activeUiControl)

                                    CallByName(activeUiControl, "RequestData", CallType.Method)
                                    ' 커서위치 세팅하기
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
                        MessageBox.Show("권한이 없습니다.")
                    End If

pntEnd:
                    Select Case Trim(Mid(sender.Name, 4, 50))

                        Case "NewData" ' 신규 조건

                            lblMessage.Text = "신규 처리 종료"
                        Case "RequestData" ' 조회 조건
                            lblMessage.Text = "조회 처리 종료"


                        Case "SaveData" ' 저장 조건

                            lblMessage.Text = "저장 처리 종료"

                        Case "DeleteData" ' 삭제 조건
                            lblMessage.Text = "삭제 처리 종료"
                        Case Else

                    End Select

                    lblCreateData.Text = GmainExecuteDbCommand.GcreateCount
                    lblDeleteData.Text = GmainExecuteDbCommand.GdeleteCount
                    lblRequestData.Text = GmainExecuteDbCommand.GrequestCount
                    lblUpdateData.Text = GmainExecuteDbCommand.GupdateCount


                    activeUiControl = Nothing
                End If
            Catch ex As Exception
                '에러시 로그 작성 발생
                Gexception.getException(ex)
                intSystemLogID = UbiDat.SystemLog(intSystemLogID,
                                                    GmainCommonFunction.GbusinessDivisionName,
                                                    GmainCommonFunction.GactiveUiControlName,
                                                    Trim(Mid(sender.Name, 4, 50)),
                                                    GmainBusinessFunction.GetValue("로그인 ID"),
                                                    ex.Source,
                                                    sender.ToString(),
                                                    ex.Message)
                'MessageBox.Show(ex.Message & System.Environment.NewLine & ex.ToString(), "오류정보", MessageBoxButtons.OK, MessageBoxIcon.Error)

                lblMessage.Text = GmainExecuteDbCommand.GerrorDescription
            End Try
            Me.Cursor = Cursors.Arrow


        End Sub
        ''' <summary>
        ''' 저장전 포커스 저장
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
                '에러시 로그 작성 발생
                Gexception.getException(ex)
            End Try

        End Sub

        ''' <summary>
        '''  저장후 포커스 처리
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
                '에러시 로그 작성 발생
                Gexception.getException(ex)
            End Try
        End Sub

        '====================================================================================================
        Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles _
        mnuExportDataToExcel.Click _
            , btnExportDataToExcel.Click

            InitializeUiMessage()

            '' 엑셀 출력 선택 - 기능 최초 것은 False 
            '' 나중에 만든 것은 True
            Dim TopMenu_excelExport_BufferCopy As Boolean = False


            If GmainCommonFunction.GactiveUiControlName <> "" Then

                If TopMenu_excelExport_BufferCopy Then
                    Me.CommonSaveDialog.FileName = GmainBusinessFunction.UiControlName(GmainCommonFunction.GactiveUiControlName).ToString()
                    Me.CommonSaveDialog.Filter = "엑셀 화일 (*.XLS)|*.XLS"
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
            'IE 실행  
            Process.Start(ConfigurationManager.AppSettings("HelpPagePath").ToString() & "?ProgramID=" & GmainCommonFunction.GactiveUiControlName)
        End Sub

        Private Sub btnNotepad_Click(sender As Object, e As EventArgs) Handles btnNotepad.Click
            Process.Start("Notepad")
            'System.Threading.Thread.Sleep(1000) '1000밀리초 동안 스레드 일시중지(스레드 대기)
            'My.Computer.Keyboard.SendKeys(Clipboard.GetText(), True)
        End Sub

        Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
            'IE 실행  
            Process.Start("Calc")
        End Sub

        '====================================================================================================
        Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click, btnExit.Click
            frmMainUi_FormClosing(Nothing, Nothing)
        End Sub

    End Class

End Namespace
