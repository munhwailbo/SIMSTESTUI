'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 프로세스 기능 분해 등록
' form 설명 : 프로세스 기능 분해를 등록 한다.
' 작성자 : 황인중
' 작성일 : 2007-07-11
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

        ' 파일 경로 변수
        Public strFilePath As String = ""

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""


            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|프로젝트 번호;ProjectID;60;;c;" & "io;n;y;5;프로젝트 명;ProjectName"
            gridAttributes = gridAttributes & "|프로젝트 명;ProjectName;60;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|시스템 번호;SystemID;60;;c;" & "o;n;y;5;시스템 명;SystemName"
            gridAttributes = gridAttributes & "|시스템 명;SystemName;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|메뉴;Levels;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|프로세스 번호;ProcID;60;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|프로세스 명;ProcName;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|설명;ProcDesc;60;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|사용 여부;UseYesOrNo;70;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|생성여부;CreateYesOrNo;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|삭제여부;DeleteYesOrNo;70;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|조회여부;SelectYesOrNo;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|처리여부;ManagementYesOrNo;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|기능;FunctionDesc;70;;l;" & "io;n;n;40;"

            gridAttributes = gridAttributes & "|데이터처리건수;IoCnt;60;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|발생주기;Cycle;70;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|발생주기단위;CycleUnit;60;;l;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|관련요구사항번호;RefReqId;70;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|프로그램ID;ProgramID;70;;l;" & "io;y;n;40;프로그램 명;ProgramName"
            gridAttributes = gridAttributes & "|프로그래 명;ProgramName;70;;l;" & "o;n;n;40;"

            'gridAttributes = gridAttributes & "|프로그램ID;ProgramID;70;;l;" & "io;n;n;40;수불 프로그램 명;ProgramName"
            'gridAttributes = gridAttributes & "|수불 프로그래명;ProgramName;70;;l;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CycleUnit;발생주기 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1
            Me.grd_1.ExplorerBar = 3

            'Me.GetTempletPath()

        End Sub

        Private Sub PNB104_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

#Region "팝업 이벤트"
        ''' <summary>
        ''' 함수명 : popSystemID
        ''' 기  능 : 팝업 Where절 추가 
        ''' 작성자 : 황인중
        ''' 작성일 : 2007-10-08
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub popSystemID_ButtonClick()
            'Me.popSystemID.Tag = ""
            Dim strProjectID As String = ""
            'strProjectID = "code(시스템 명);where(ProjectID='" & Me.popProjectID.TextValue & "0');"
            'Me.popSystemID.Tag = strProjectID
            'MsgBox(strContractorIDTag)
        End Sub
#End Region

        Dim xlApp As Excel.Application = Nothing
        Dim xlDoc As Excel.Workbook = Nothing
        Dim xlSht As Excel.Worksheet = Nothing

        Dim intJJ As Integer

        Dim strProjectName As String = "" '프로젝트 명
        Dim strSystemName As String = "" '시스템 명
        Dim strUnitSystemName As String = "" '단위 시스템 명
        Dim strTodate As String = "" '오늘 날짜


#Region "프로그램 목록"

        Private Sub btnExelExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'Dim ResultDataSet As DataSet = Me.ProgramListRequestData

            ' 조회된 데이터가 없을경우 나가 버려~
            'If ResultDataSet.Tables(0).Rows.Count < 1 Then
            '    Exit Sub
            'End If

            ' 엑셀 객체 생성
            xlApp = CreateObject("Excel.Application")
            Try
                ' 워크북 객체 생성
                xlDoc = xlApp.Workbooks.Open(strFilePath & "\프로그램목록.xls")
            Catch
                MessageBox.Show("해당경로에 프로그램목록 템플릿 엑셀 파일이 없습니다 확인후 작업하세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' 워크 쉬트 객체 생성
            xlSht = xlDoc.Worksheets("프로그램목록")
            ' 엑셀 객체를 보여준다
            xlApp.Visible = True
            Try
                ' 시스템 명을 구분자로 갖기 위해 처음 시스템 명을 받아둔다.
                'Dim tmpSystemName As String = ResultDataSet.Tables(0).Rows(0).Item("UnitSystemName")
                'strUnitSystemName = ResultDataSet.Tables(0).Rows(0).Item("UnitSystemName")

                ' 시스템 별로 구분을 짓기 위한 변수 ex) 인사관리가 44개의 행이라면 45부터는 회계 관리부터 데이타를 뿌리기 위해.. 
                'Dim intRowNumber As Integer = ResultDataSet.Tables(0).Rows.Count - 1
                Dim intTemp As Integer = 0
                Dim intForNumber As Integer = 0

                'For intj As Integer = 2 To ResultDataSet.Tables(0).Rows(0).Item("SystemCount") + 1

                ' 타이틀 데이터 변수에 담기
                'strProjectName = ResultDataSet.Tables(0).Rows(intForNumber).Item("ProjectName").ToString '프로젝트 명
                'strSystemName = ResultDataSet.Tables(0).Rows(intForNumber).Item("SystemName").ToString '시스템 명
                'strUnitSystemName = ResultDataSet.Tables(0).Rows(intForNumber).Item("UnitSystemName").ToString '단위 시스템 명
                'strTodate = ResultDataSet.Tables(0).Rows(intForNumber).Item("CreateDate").ToString '작성 일자

                xlDoc.Worksheets.Copy()

                'xlApp.Workbooks(intj).Worksheets(1).Name = strUnitSystemName & " 프로그램목록"

                'xlApp.Workbooks(intj).Worksheets(1).Cells(1, 2) = strProjectName '프로젝트 명
                'xlApp.Workbooks(intj).Worksheets(1).Cells(2, 2) = strSystemName '시스템 명
                'xlApp.Workbooks(intj).Worksheets(1).Cells(3, 2) = strUnitSystemName '단위 시스템 명
                'xlApp.Workbooks(intj).Worksheets(1).Cells(1, 11) = strTodate '작성 일자
                'xlApp.Workbooks(intj).Worksheets(1).Cells(2, 11) = ResultDataSet.Tables(0).Rows(intForNumber).Item("EmployeeNameHangul").ToString '작성자

                ' 여섯번째 행 복사
                'xlApp.Workbooks(intj).Worksheets(1).Rows(6).Copy()

                intTemp = 0

                '  행 붙여 넣기
                'For inti As Integer = 0 To ResultDataSet.Tables(0).Rows(intForNumber).Item("CountMax") - 1
                '    xlApp.Workbooks(intj).Worksheets(1).Rows(7 + intTemp).PasteSpecial() 'xlPasteAll, xlPasteSpecialOperationAdd)
                '    intTemp = intTemp + 1
                'Next

                intTemp = 0

                'For intJJ = 0 To ResultDataSet.Tables(0).Rows(intForNumber).Item("countMax") - 1

                ' SP 의 행 넘버를 받아와 저장 한다
                'intTemp = ResultDataSet.Tables(0).Rows(intForNumber).Item("RowNumber") - 1

                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 1) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu1")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 2) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu2")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 4) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu3")

                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 7) = ResultDataSet.Tables(0).Rows(intForNumber).Item("ProgramID")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 9) = ResultDataSet.Tables(0).Rows(intForNumber).Item("FunctionDesc")

                ' 행의 갯수 보다 작으면....
                'If intForNumber < ResultDataSet.Tables(0).Rows.Count - 1 Then
                ' 현재 행의 시스템 명과 다음 행의 시스템 명을 비교 해서 다르면... 시스템 명을 비교 해서 
                'If tmpSystemName <> ResultDataSet.Tables(0).Rows(intForNumber + 1).Item("UnitSystemName").ToString Then
                '    tmpSystemName = ResultDataSet.Tables(0).Rows(intForNumber + 1).Item("UnitSystemName").ToString

                '각 시스템의 로우 갯수에 1을 더한다(시스템의 구분)
                'intForNumber = intForNumber + 1
                'Exit For
                'End If
                'intForNumber = intForNumber + 1
                'End If
                'Next

                ' 처음 루프를 돌때만 폴더 생성 유무 확인
                'If intj = 2 Then
                '    Dim TempDirectorys As New DirectoryInfo(strFilePath & "\!프로그램 목록")
                ' 경로 안에 프로그램목록 폴더가 없으면 자동 생성

                'If Not (TempDirectorys.Exists) Then
                '    TempDirectorys.Create()
                'End If
                'End If

                ' 프로세스 계층도 파일 명을 맹근다
                'Dim strSaveFileNames As String = Replace(Replace(strFilePath & "\!프로그램 목록\" & strProjectName, "아이파크몰", ""), "구축", "") & "- " & strUnitSystemName & " 프로그램 목록(" & strTodate & ").xls"

                'Try
                'xlApp.Workbooks(intj).Worksheets(1).SaveAs(strSaveFileNames)
                'Catch ex As Exception
                '    MsgBox(strSaveFileNames & vbCrLf & "동일한 이름가진 파일이 있어 자동 저장이 않됩니다 스스로 저장 하세요", MsgBoxStyle.DefaultButton1, "자동 저장")
                'End Try

                '    Next

                '저장 폴더 자동으로 열기
                System.Diagnostics.Process.Start("explorer.exe", strFilePath & "\!프로그램 목록")

            Catch
                MsgBox("엑셀 파일 생성시 건들지 마시오~ ", MsgBoxStyle.DefaultButton1, Me.Name)
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

            'strSystemName = ResultDataSet.Tables(0).Rows(intJJ).Item("SystemName").ToString '시스템 명

            'xlDoc = xlApp.Workbooks.Open(strFilePath & "\프로그램목록.xls")

            '' 타이틀 생성
            'xlSht = xlDoc.Worksheets("프로그램목록")

            'xlSht.Cells(1, 2) = ResultDataSet.Tables(0).Rows(intJJ).Item("ProjectName").ToString '프로젝트 명
            'strProjectName = ResultDataSet.Tables(0).Rows(intJJ).Item("ProjectName").ToString '프로젝트 명

            'xlSht.Cells(2, 2) = strSystemName '시스템 명
            'strTodate = ResultDataSet.Tables(0).Rows(intJJ).Item("CreateDate").ToString '작성 일자
            'xlSht.Cells(1, 12) = ResultDataSet.Tables(0).Rows(intJJ).Item("CreateDate").ToString '작성 일자
            'xlSht.Cells(2, 12) = ResultDataSet.Tables(0).Rows(intJJ).Item("EmployeeNameHangul").ToString '작성자

            'xlSht.Rows(6).Copy()

            'For intJJ = 0 To ResultDataSet.Tables(0).Rows.Count - 1
            '    '=======================================================
            '    '  SP 결과 변수 대입
            '    '=======================================================

            '    '  행처리 
            '    xlSht.Rows(7 + intJJ).PasteSpecial() 'xlPasteAll, xlPasteSpecialOperationAdd)

            '    xlSht.Cells(6 + intJJ, 1) = ResultDataSet.Tables(0).Rows(intJJ).Item("menu1").ToString
            '    xlSht.Cells(6 + intJJ, 2) = ResultDataSet.Tables(0).Rows(intJJ).Item("menu2").ToString
            '    xlSht.Cells(6 + intJJ, 4) = ResultDataSet.Tables(0).Rows(intJJ).Item("menu3").ToString
            '    xlSht.Cells(6 + intJJ, 7) = ResultDataSet.Tables(0).Rows(intJJ).Item("ProgramID").ToString
            '    xlSht.Cells(6 + intJJ, 9) = ResultDataSet.Tables(0).Rows(intJJ).Item("FunctionDesc").ToString
            'Next

            '' 마지막 한줄은 지운다....
            'For inti As Integer = 1 To 20
            '    xlSht.Cells(ResultDataSet.Tables(0).Rows.Count + 6, inti) = ""
            'Next

            'Dim TempDirectory As New DirectoryInfo(strFilePath & "\!프로그램 목록\")

            '' 경로 안에 프로그램목록 폴더가 없으면 자동 생성
            'If Not (TempDirectory.Exists) Then
            '    TempDirectory.Create()
            'End If

            '' 프로그램 목록 파일 명을 맹근다
            'Dim strSaveFileName As String = Replace(Replace(strFilePath & "\!프로그램 목록\" & strProjectName, "아이파크몰", ""), "구축", "") & "- " & strSystemName & " 프로그램 목록(" & strTodate & ").xls"

            'Try
            '    xlSht.SaveAs(strSaveFileName)
            'Catch ex As Exception
            '    MsgBox(strSaveFileName & vbCrLf & "동일한 이름가진 파일이 있어 자동 저장이 않됩니다 스스로 저장 하세요", MsgBoxStyle.DefaultButton1, "자동 저장")
            'End Try

            ' ''Dim strTempDirectory As String = "C:\!프로그램 목록\"

            ' ''Dim TempDirectory As New DirectoryInfo(strTempDirectory)

            '' '' 경로 안에 프로그램목록 폴더가 없으면 자동 생성
            ' ''If Not (TempDirectory.Exists) Then
            ' ''    TempDirectory.Create()
            ' ''End If

            '' '' 프로그램 목록 파일 명을 맹근다
            ' ''Dim strSaveFileName As String = Replace(Replace(strTempDirectory & strProjectName, "아이파크몰", ""), "구축", "") & "- " & strSystemName & " 프로그램 목록(" & strTodate & ").xls"

            ' ''temp = Nothing
            ' ''temp = System.IO.Directory.GetFiles(strTempDirectory)
            '' '' !프로그램 목록 폴더 안의 파일 명을 비교 하여 있으면 자동 세이브 않함.
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

#Region "프로세스 계층도"

        Private Sub btnProcessStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'Dim ResultDataSet As DataSet = Me.ProcessStepRequestData

            ' 조회된 데이타가 없으면 패쑤~
            'If ResultDataSet.Tables(0).Rows.Count < 1 Then
            '    Exit Sub
            'End If
            Try
                ' 엑셀 객체 생성
                xlApp = CreateObject("Excel.Application")
                Try
                    ' 워크북 객체 생성
                    xlDoc = xlApp.Workbooks.Open(strFilePath & "\프로세스계층도.xls")
                Catch
                    MessageBox.Show("해당경로에 프로세스계층도 템플릿 엑셀 파일이 없습니다 확인후 작업하세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                ' 워크 쉬트 객체 생성
                xlSht = xlDoc.Worksheets("프로세스계층도")

                ' 엑셀 객체를 보여준다
                xlApp.Visible = True

                'Dim tmpSystemName As String = ResultDataSet.Tables(0).Rows(0).Item("UnitSystemName")
                'strUnitSystemName = ResultDataSet.Tables(0).Rows(0).Item("UnitSystemName")

                ' 시스템 별로 구분을 짓기 위한 변수 ex) 인사관리가 44개의 행이라면 45부터는 회계 관리부터 데이타를 뿌리기 위해.. 
                'Dim intRowNumber As Integer = ResultDataSet.Tables(0).Rows.Count - 1
                Dim intTemp As Integer = 0
                Dim intForNumber As Integer = 0

                'For intj As Integer = 2 To ResultDataSet.Tables(0).Rows(0).Item("SystemCount") + 1

                ' 타이틀 데이터 변수에 담기
                'strProjectName = ResultDataSet.Tables(0).Rows(intForNumber).Item("ProjectName").ToString '프로젝트 명
                'strSystemName = ResultDataSet.Tables(0).Rows(intForNumber).Item("SystemName").ToString '시스템 명
                'strUnitSystemName = ResultDataSet.Tables(0).Rows(intForNumber).Item("UnitSystemName").ToString '단위 시스템 명
                'strTodate = ResultDataSet.Tables(0).Rows(intForNumber).Item("CreateDate").ToString '작성 일자

                'xlDoc.Worksheets.Copy()

                'xlApp.Workbooks(intj).Worksheets(1).Name = strUnitSystemName & " 프로세스계층도"

                'xlApp.Workbooks(intj).Worksheets(1).Cells(1, 2) = strProjectName '프로젝트 명
                'xlApp.Workbooks(intj).Worksheets(1).Cells(2, 2) = strSystemName '시스템 명
                'xlApp.Workbooks(intj).Worksheets(1).Cells(3, 2) = strUnitSystemName '단위 시스템 명
                'xlApp.Workbooks(intj).Worksheets(1).Cells(1, 7) = strTodate '작성 일자
                'xlApp.Workbooks(intj).Worksheets(1).Cells(2, 7) = ResultDataSet.Tables(0).Rows(intForNumber).Item("EmployeeNameHangul").ToString '작성자

                ' 여섯번째 행 복사
                'xlApp.Workbooks(intj).Worksheets(1).Rows(6).Copy()

                intTemp = 0

                '  행 붙여 넣기
                'For inti As Integer = 0 To ResultDataSet.Tables(0).Rows(intForNumber).Item("CountMax") - 1
                '    xlApp.Workbooks(intj).Worksheets(1).Rows(7 + intTemp).PasteSpecial() 'xlPasteAll, xlPasteSpecialOperationAdd)
                '    intTemp = intTemp + 1
                'Next

                intTemp = 0

                'For intJJ = 0 To ResultDataSet.Tables(0).Rows(intForNumber).Item("countMax") - 1

                ' SP 의 행 넘버를 받아와 저장 한다
                'intTemp = ResultDataSet.Tables(0).Rows(intForNumber).Item("RowNumber") - 1

                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 1) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu1")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 3) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu2")
                'xlApp.Workbooks(intj).Worksheets(1).Cells(6 + intJJ, 6) = ResultDataSet.Tables(0).Rows(intForNumber).Item("menu3")

                ' 행의 갯수 보다 작으면....
                'If intForNumber < ResultDataSet.Tables(0).Rows.Count - 1 Then
                ' 현재 행의 시스템 명과 다음 행의 시스템 명을 비교 해서 다르면... 시스템 명을 비교 해서 
                'If tmpSystemName <> ResultDataSet.Tables(0).Rows(intForNumber + 1).Item("UnitSystemName").ToString Then
                '    tmpSystemName = ResultDataSet.Tables(0).Rows(intForNumber + 1).Item("UnitSystemName").ToString

                '각 시스템의 로우 갯수에 1을 더한다(시스템의 구분)
                'intForNumber = intForNumber + 1
                'Exit For
                'End If
                'intForNumber = intForNumber + 1
                'End If
                'Next

                ' 처음 루프를 돌때만 폴더 생성 유무 확인
                'If intj = 2 Then
                '    Dim TempDirectory As New DirectoryInfo(strFilePath & "\!프로세스 계층도\")
                '    ' 경로 안에 프로그램목록 폴더가 없으면 자동 생성
                '    If Not (TempDirectory.Exists) Then
                '        TempDirectory.Create()
                '    End If
                'End If

                ' 프로세스 계층도 파일 명을 맹근다
                Dim strSaveFileName As String = Replace(Replace(strFilePath & "\!프로세스 계층도\" & strProjectName, "아이파크몰", ""), "구축", "") & "- " & strUnitSystemName & " 프로세스 계층도(" & strTodate & ").xls"

                Try
                    'xlApp.Workbooks(intj).Worksheets(1).SaveAs(strSaveFileName)
                Catch ex As Exception
                    MsgBox(strSaveFileName & vbCrLf & "동일한 이름가진 파일이 있어 자동 저장이 않됩니다 스스로 저장 하세요", MsgBoxStyle.DefaultButton1, "자동 저장")
                End Try

                'Next
                '저장 폴더 자동으로 열기
                System.Diagnostics.Process.Start("explorer.exe", strFilePath & "\!프로세스 계층도")

            Catch
                MsgBox("엑셀 파일 생성시 건들지 마시오~ ", MsgBoxStyle.DefaultButton1, Me.Name)
            End Try

            xlApp.Workbooks(1).Close()

            'ResultDataSet = Nothing

            xlSht = Nothing
            xlDoc = Nothing

            xlApp = Nothing

        End Sub

#End Region

#Region "엑셀 프로세스 Kill"

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

#Region "템플릿 파일 경로 설정"

        Private Sub btnFilePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Dim FolderPath As New FolderBrowserDialog
            FolderPath.ShowNewFolderButton = True

            Dim result As DialogResult = FolderPath.ShowDialog()

            If result = DialogResult.OK Then
                'Me.lblPath.Text = " 파일 경로: " + FolderPath.SelectedPath
                strFilePath = FolderPath.SelectedPath
                Dim intTempCoubt As Integer = 0

                Dim temp() As String = System.IO.Directory.GetFiles(FolderPath.SelectedPath & "\")

                If temp.Length > 0 Then
                    For inti As Integer = 0 To temp.Length - 1
                        If temp(inti) = strFilePath & "\프로그램목록.xls" Then
                            intTempCoubt = intTempCoubt + 1
                            Exit Sub
                        End If
                    Next
                    MessageBox.Show("선택한 경로 안에 양식 템플릿 파일이 없습니다 생성후 경로 설정하세요 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Me.GetTempletPath()
                    Exit Sub
                End If
            End If
        End Sub
#End Region

#Region "툴팁"

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

#Region "참고"

        ''Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''    Dim SourceDirectory As New DirectoryInfo("c:\양식 템플릿 테스트")
        ''    Dim DestinationDirectory As New DirectoryInfo("d:\양식 템플릿 테스트")
        ''    Copy(SourceDirectory, DestinationDirectory, "프로그램목록 테스트.xls", "프로그램목록 테스트.xls", True)
        ''End Sub

        ''Protected Sub Copy(ByVal SourceDirectory As DirectoryInfo, ByVal DestinationDirectory As DirectoryInfo, ByVal SourceDirectoryFilter As String, ByVal SourceFileFilter As String, ByVal OverWrite As Boolean)

        ''    Dim SourceSubDirectories() As DirectoryInfo
        ''    Dim SourceFiles() As FileInfo

        ''    '폴더 필터 검사

        ''    If (SourceDirectoryFilter Is Nothing) Then
        ''        SourceSubDirectories = SourceDirectory.GetDirectories()
        ''    Else
        ''        SourceSubDirectories = SourceDirectory.GetDirectories(SourceDirectoryFilter.Trim())
        ''    End If

        ''    '타겟 폴더가 없으면 생성

        ''    If Not (DestinationDirectory.Exists) Then
        ''        DestinationDirectory.Create()
        ''    End If


        ''    '파일 필터 검사

        ''    If (SourceFileFilter Is Nothing) Then
        ''        SourceFiles = SourceDirectory.GetFiles()
        ''    Else
        ''        SourceDirectory.Create()
        ''        ' SourceFiles = SourceDirectory.GetFiles(SourceFileFilter.Trim())
        ''    End If


        ''    '재귀호출, 서브폴더를 복사한다.

        ''    For Each SourceSubDirectory As DirectoryInfo In SourceSubDirectories
        ''        Copy(SourceSubDirectory, New DirectoryInfo(DestinationDirectory.FullName + "\" + SourceSubDirectory.Name), SourceDirectoryFilter, SourceFileFilter, OverWrite)
        ''    Next

        ''    '파일을 복사한다.

        ''    For Each SourceFile As FileInfo In SourceFiles
        ''        SourceFile.CopyTo(DestinationDirectory.FullName + "\" + SourceFile.Name, OverWrite)
        ''    Next

        ''End Sub




        ''        Private Sub sb프로그램목록()
        ''            On Error GoTo ErrRtn

        ''            Dim xlApp As Excel.Application
        ''            Dim xlDoc As Excel.Workbook
        ''            Dim xlSht As Excel.Worksheet
        ''            Dim xlTemplate As Excel.Worksheet
        ''            Dim iPage As Integer, intII As Integer, intJJ As Integer
        ''            Dim strFilePath As String

        ''            Dim strSql As String
        ''            Dim Str프로젝트번호 As String, str시스템번호 As String

        ''            strFilePath = "C:\양식 템플릿\프로그램목록.xls"


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
        ''                    xlSht = xlDoc.Worksheets("프로그램목록")
        ''                    'xlSht.Name = "Page " & CStr(iPage)

        ''                    '        xlSht.Range("B4", "G4").Copy
        ''                    '        xlSht.Range("B5", "G" & CStr(5 + intII)).PasteSpecial xlPasteAll
        ''                    xlSht.Cells(1, 2) = Trim(Mid((Cmb프로젝트번호.Text), 1, Len(Trim(Cmb프로젝트번호.Text)) - 5))
        ''                    xlSht.Cells(2, 2) = Trim(Mid((Cmb시스템번호.Text), 1, Len(Trim(Cmb시스템번호.Text)) - 3))
        ''                    xlSht.Cells(2, 12) = Str담당PL

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

