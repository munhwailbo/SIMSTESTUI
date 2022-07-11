'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : UI 명세서
' form 설명 : UI 명세서를 조회, 추가, 수정, 삭제한다.			
' 작성자 : 
' 작성일 : 
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

    Public Class SMDB02
        Inherits CommonControls.UiControl
        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""
            Dim i As Integer = 0

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code    

            ' multi header
            gridAttributes = gridAttributes & "||선택;선택;80;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|프로젝트;ProjectID;65;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|프로젝트명;ProjectName;130;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|시스템구분;SystemDivisionCode;65;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|시스템구분명;SystemDivisionName;120;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|기간;ReceiptCount;55;;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|기간;DealingCount;55;;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|누계;ReceiptSum;55;;r;" & "o;n;n;30;"          '접수건수 
            gridAttributes = gridAttributes & "|누계;DealingSum;55;;r;" & "o;n;n;30;"          '처리건수  
            gridAttributes = gridAttributes & "|미처리;Receipting;55;;r;" & "o;n;n;30;"        '접수중
            gridAttributes = gridAttributes & "|미처리;Ing;55;;r;" & "o;n;n;30;"               '진행중
            gridAttributes = gridAttributes & "|미처리;Lefting;55;;r;" & "o;n;n;30;"           '보류

            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"                   '더미

            ' 기존의 single header
            'gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "o;n;y;"
            'gridAttributes = gridAttributes & "|시스템구분;SystemDivisionCode;300;;c;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|시스템구분명;SystemDivisionName;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|접수건수;ReceiptCount;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|처리건수;DealingCount;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|접수누계;ReceiptSum;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|처리누계;DealingSum;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|진행중;Ing;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|접수중;Receipting;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|보류;Lefting;300;;r;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"


            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            Me.DateInit()

            '--multi header
            'Fixed 컬럼 column Merge
            With Me.grd_1
                .AddItem(ControlChars.Tab & "선택" & ControlChars.Tab & "프로젝트" & ControlChars.Tab & "프로젝트명" & ControlChars.Tab _
                                          & "시스템구분" & ControlChars.Tab & "시스템구분명" & ControlChars.Tab _
                                          & "접수" & ControlChars.Tab & "처리" & ControlChars.Tab _
                                          & "접수" & ControlChars.Tab & "처리" & ControlChars.Tab _
                                          & "접수중" & ControlChars.Tab & "진행중" & ControlChars.Tab & "보류" & ControlChars.Tab & "")
                .FixedRows = 2
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly
                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next
                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next
            End With

            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|접수 일자;ReceiptDate;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|순번;Orders;300;#,###;r;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|시스템 구분;SystemDivision;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|사원번호;EmployeeNumber;100;;r;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|접수구분;ReceiptDivision;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수자;Underwriter;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|작업자;Worker;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|작업상태코드;WorkStates;300;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|작업상태;WorkStatesName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|작업구분코드;WorkDivision;300;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|작업구분;WorkDivisionName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|처리예정 일자;ManagementProgramDate;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|처리일자;ManagementDate;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|제목;Subject;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|요청사항;DemandMatters;10;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|요청사항;DemandMatters_2;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|원인;ManagementInternalUse;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|처리내용;OccurrenceCause;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|부서;HCodeName;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|사내전화번호;InFirmTelephoneNumber;10;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|제목;Title;10;;l;" & "io;n;y;30;"                   '리포트 타이틀 

            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"                   '더미

            'grid code combo
            gridCodeNameList = ""

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

            Me.grd_2.ExplorerBar = 3

        End Sub

#Region "팝업 이벤트"
        ''' <summary>
        ''' 함수명 : popSystemID
        ''' 기  능 : 팝업 Where절 추가 
        ''' 작성자 : 
        ''' 작성일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub popSystemID_ButtonClick() Handles popSystemID.ButtonClick
            Me.popSystemID.Tag = ""
            Dim strProjectID As String = ""
            If Me.popProjectID.NameText = "" Then
                strProjectID = "code(시스템 명);where(ProjectID like '%' + '" & Me.popProjectID.TextValue & "');"
            Else
                strProjectID = "code(시스템 명);where(ProjectID='" & Me.popProjectID.TextValue & "0');"
            End If

            Me.popSystemID.Tag = strProjectID
            'MsgBox(strContractorIDTag)
        End Sub
#End Region

        '====================================================================================================
        Public Sub DateInit()
            '기본 날짜 셋팅
            Me.dtpReceiptDateFrom.TextValue = Date.Today.AddDays(-6)
            Me.dtpReceiptDateTo.TextValue = Date.Today
        End Sub

        Private Sub SMDB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        'Private Sub btnReceiptCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiptCopy.Click
        '    Me.SaveData_2()
        'End Sub

        Private Sub optTotality_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            RequestData_2()
        End Sub

        Private Sub optDivision1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDivision1.Click
            RequestData_2()
        End Sub

        Private Sub optDivision2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDivision2.Click
            RequestData_2()
        End Sub

        Private Sub optreceipt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optreceipt.Click
            RequestData_2()
        End Sub

        Private Sub optleft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optleft.Click
            RequestData_2()
        End Sub

        Private Sub opting_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles opting.Click
            RequestData_2()
        End Sub

        Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

            'With Me.grd_2
            '    If .Rows > 1 Then
            '        If Control.MouseButtons = Windows.Forms.MouseButtons.Left Then
            '            If .CellChecked = C1.Win.C1FlexGrid.Classic.CellCheckedSettings.flexChecked Then
            '                Me.ToolTip1.RemoveAll()
            '                Exit Sub
            '            End If
            '            Me.ToolTip1.GetToolTip(Me.grd_2)
            '            Me.ToolTip1.SetToolTip(Me.grd_2, .GetCurrentRowCellValue("DemandMatters"))
            '            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
            '            Select Case .ColSel
            '                Case .get_ColIndex("선택")
            '                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
            '            End Select
            '        End If

            '    End If
            'End With
        End Sub

        Private Sub grd_2_LeaveCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_2.LeaveCell

            If Me.ToolTip1.Active = True Then
                Me.ToolTip1.RemoveAll()
            End If

        End Sub

        Private Sub cboWorkDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWorkDivision.SelectedIndexChanged
            If Me.grd_1.Rows > 2 Then
                Me.RequestData_2()
            End If
        End Sub

    End Class

End Namespace
