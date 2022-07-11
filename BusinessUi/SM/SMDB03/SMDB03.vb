'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 업무 일지 등록
' form 설명 : 업무 일지를 조회, 추가, 수정, 삭제한다.			
' 작성자 : 황인중
' 작성일 : 2007-06-15
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDB03
        Inherits CommonControls.UiControl
        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code    

            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "i;n;y;"
            gridAttributes = gridAttributes & "|업무 일자;BusinessLogDate;80;####-##-##;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|순번;Orders;80;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|조직 코드;OnesPositionDepartmentCode;80;;l;" & "o;n;y;30;"
            'gridAttributes = gridAttributes & "|조직;CodeName;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|제목;LogTitle;80;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|내용;BusinessLogContent;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|진행율;ProgressRate;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|작업시간;WorkTime;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|비고;Remark;150;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber_2;80;;l;" & "o;n;y;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|접수 일자;ReceiptDate;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|순번;Orders;300;#,###;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|시스템 구분;SystemDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|사원번호;EmployeeNumber;100;;r;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수구분;ReceiptDivision;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수자;Underwriter;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|작업자;Worker;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|작업상태;WorkStates;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|작업구분;WorkDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|처리예정 일자;ManagementProgramDate;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|처리일자;ManagementDate;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|제목;Subject;300;;l;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""

            grd_3.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExplorerBar = 1

            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|접수 일자;ReceiptDate;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|순번;Orders;300;#,###;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|시스템 구분;SystemDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|사원번호;EmployeeNumber;100;;r;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수구분;ReceiptDivision;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수자;Underwriter;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|작업자;Worker;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|작업상태;WorkStates;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|작업구분;WorkDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|처리예정 일자;ManagementProgramDate;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|처리일자;ManagementDate;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|제목;Subject;300;;l;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""

            grd_4.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_4.ExplorerBar = 0
            Me.grd_4.ExplorerBar = 1

            Me.cboEmployee_R.TextValue = GmainBusinessFunction.GetValue("로그인 ID")

            Me.InitRequestData_1()
            Me.InitRequestData_2()

        End Sub

        '====================================================================================================
        Public Sub DateInit()
            '기본 날짜 셋팅
            'Dim currentDateFrom As String = ""
            'Dim currentDateTo As String = ""
            'currentDateTo = Date.Today
            'currentDateFrom = currentDateTo.Substring(0, 8) + "01"
            'Date.Today.AddDays(-6)
            Me.dtpBusinessDateFrom.TextValue = Date.Today.AddDays(-6)
            Me.dtpBusinessDateTo.TextValue = Date.Today
        End Sub

        Private Sub SMDB03_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        ' Leave 이벤트시 TextValue OR Text 값이 변경 없이 넘어가므로... 변수에 받아 넘김 좀... 짜증
        Public strBusinessLogDate As String = "" '업무일자를 받을 변수
        Public strEmployeeNumber As String = "" '사원 번호를 받을 변수
        Public strDivisionReques As String = "1" '이벤트시 조회인지 조회 버튼 클릭시 조회인지 구분

        Private Sub dtpBusinessLogDate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBusinessLogDate.Leave
            strBusinessLogDate = Me.dtpBusinessLogDate.TextValue

            If Me.dtpBusinessLogDate.TextValue.Length = 8 And Me.cboEmployee.TextValue.Length = 6 Then
                Me.grd_3.NewData()
                Me.grd_4.NewData()
                Me.RequestData_3()
                strDivisionReques = "2"
            End If

        End Sub

        Private Sub cboEmployee_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
            strEmployeeNumber = Me.cboEmployee.TextValue

            If Me.dtpBusinessLogDate.TextValue.Length = 8 And Me.cboEmployee.TextValue.Length = 6 Then
                Me.grd_3.NewData()
                Me.grd_4.NewData()
                Me.RequestData_3()
                strDivisionReques = "2"
            End If

        End Sub


    End Class

End Namespace
