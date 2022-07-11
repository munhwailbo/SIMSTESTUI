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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDB04
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

            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|업무 일자;BusinessLogDate;80;####-##-##;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|순번;Orders;80;;l;" & "io;n;n;30;"
            'gridAttributes = gridAttributes & "|조직 코드;OnesPositionDepartmentCode;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|조직;CodeName;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;80;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|제목;LogTitle;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|내용;BusinessLogContent;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|진행율;ProgressRate;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|작업시간(분);WorkTime;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|비고;Remark;150;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber_2;80;;l;" & "o;n;y;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '----------------------------------------------------------------------------------------------------
            Me.grd_1.AutoSizeRows()

            Me.grd_1.RowHeightMin = 18
            Me.grd_1.RowHeightMax = 100

            Me.grd_1.AutoResize = True
            Me.grd_1.AllowEditing = True
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both

            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeBoth
            '----------------------------------------------------------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            'Me.popEmployee.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
            DateInit()

        End Sub

        '====================================================================================================
        Public Sub DateInit()
            '기본 날짜 셋팅
            'Dim currentDateFrom As String = ""
            'Dim currentDateTo As String = ""
            'currentDateTo = Date.Today
            'currentDateFrom = currentDateTo.Substring(0, 8) + "01"
            'Date.Today.AddDays(-6)
            Me.dtpBusinessDateFrom.TextValue = Date.Today  'Date.Today.AddDays(-6)
            Me.dtpBusinessDateFrom.TextValue = Me.dtpBusinessDateFrom.TextValue.ToString.Substring(0, 6) & "01"
            Me.dtpBusinessDateTo.TextValue = Date.Today
        End Sub

        Private Sub SMDB04_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        ' Leave 이벤트시 TextValue OR Text 값이 변경 없이 넘어가므로... 변수에 받아 넘김 좀... 짜증
        Public strBusinessLogDate As String = "" '업무일자를 받을 변수
        Public strEmployeeNumber As String = "" '사원 번호를 받을 변수
        Public strDivisionReques As String = "1" '이벤트시 조회인지 조회 버튼 클릭시 조회인지 구분


        Private Sub grd_1_EnterCell_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            With Me.grd_1
                .Editable = EditableSettings.flexEDNone
                If .Rows > 1 Then
                    Select Case .ColSel
                        Case .get_ColIndex("선택")
                            .Editable = EditableSettings.flexEDKbdMouse
                    End Select
                End If
            End With

        End Sub

    End Class

End Namespace
