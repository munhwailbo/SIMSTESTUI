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


Imports System.IO

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB201
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
            gridAttributes = gridAttributes & "||선택;선택;60;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;120;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;150;;c;" & "o;n;y;7;지국 명;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;150;;l;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|지국장성명;Name;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|계약자주민번호;SocialNum;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|상태;Stat;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|계약일자;ContractDt;120;####-##-##;c;" & "o;n;n;10;"    ' 20081013
            gridAttributes = gridAttributes & "|폐국일자;CloseDt;120;####-##-##;c;" & "o;n;n;10;"    ' 20081013

            gridAttributes = gridAttributes & "|우편번호;PostNum;100;;l;" & "o;n;y;10;우편번호;CodeHangulName"
            ''            gridAttributes = gridAttributes & "|주소;CodeHangulName;90;;c;" & "o;n;y;5;"       '(130)
            gridAttributes = gridAttributes & "|주소;Addr;200;;l;" & "o;n;n;50;"       '(140)
            ''            gridAttributes = gridAttributes & "|상세주소;Addr1;200;;l;" & "o;n;n;100;"       '(150)

            gridAttributes = gridAttributes & "|전화번호1;PhoneNum;200;;l;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;200;;l;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|;Dummy;80;;c;" & "o;n;n;10;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_3 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;120;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;150;;c;" & "o;n;y;7;지국 명;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;150;;l;" & "o;n;n;7;"
            '''''gridAttributes = gridAttributes & "|회수;ChangeNum;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|계약일자;ContractDt;120;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|상태;Stat;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;80;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|지국장성명;BranchChiefCdName;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;80;;c;" & "o;n;n;10;"
            'grid_1 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_3.ExplorerBar = 3
            '==============================================================

            '-- 사진 전송 버튼을 처음에는 보이지 않게 한다.
            Me.picOpen.Visible = True
            Me.picSave.Visible = True

            Me.Label2.Visible = True

        End Sub

        Private Sub PNB201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        ''' <summary>
        ''' 함수명 : PNB201_Enter 
        ''' 기  능 : 화면 전환(지국장 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNB201_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2))
                GmainBusinessFunction.SetValue("화면 전환", vbNullString)
            End If
        End Sub

        ''' <summary>
        ''' 함수명 : Request
        ''' 기  능 : 다른 화면에서 코드 를 받아서 해당 내역을 조회 한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Public Sub SetRequest(ByVal strBranchChiefName As String, ByVal strChiefCd As String)
            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.txtBranchChiefName.TextValue = strBranchChiefName  '지국장명
            Me.txtChiefCd.TextValue = strChiefCd      '지국장코드

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
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

     
        Dim intJJ As Integer

        Dim strProjectName As String = "" '프로젝트 명
        Dim strSystemName As String = "" '시스템 명
        Dim strUnitSystemName As String = "" '단위 시스템 명
        Dim strTodate As String = "" '오늘 날짜


#Region "프로그램 목록"

       
#End Region

#Region "프로세스 계층도"

        

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
                'strFilePath = FolderPath.SelectedPath
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

      
        Private Sub picOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOpen.Click
            Me.OpenFileDialog1.InitialDirectory = "c:\"
            Me.OpenFileDialog1.Filter = "이미지 파일 (*.jpg)|*.jpg|이미지 파일 (*.bmp)|*.bmp|모든 파일 (*.*)|*.*"

            Try
                If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                    PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                End If
            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub picSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSave.Click
            '-- 이미지 저장
            Call UpLoadImage()
        End Sub


        Private Sub grd_3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_3.DoubleClick

            '지국 정보 화면으로 지국 코드를 넘겨서 해당 지국 정보를 조회 한다.
            If Me.grd_3.Rows <= Me.grd_3.FixedRows Then Exit Sub

            Dim strBranchCd As String '지국 코드
            strBranchCd = Me.grd_3.get_TextMatrix(Me.grd_3.Row, Me.grd_3.get_ColIndex("BranchCd")) '지국 코드

            GmainBusinessFunction.SetValue("화면 전환", "PNB202;" & strBranchCd)
            Me.ShowUiControl("PNB202", strBranchCd)

        End Sub

    End Class

End Namespace

