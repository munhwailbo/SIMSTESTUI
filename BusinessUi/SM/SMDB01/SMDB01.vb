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

    Public Class SMDB01
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

            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|접수 일자;ReceiptDate;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|순번;Orders;300;#,###;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|시스템 구분;SystemDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|사원번호;EmployeeNumber;100;;r;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramID;ProgramID;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|ProgramName;ProgramName;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|DptmProgramName;DptmProgramName;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수구분;ReceiptDivision;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|접수자;Underwriter;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|작업자;Worker;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|작업상태;WorkStates;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|작업구분;WorkDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|처리예정 일자;ManagementProgramDate;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|처리일자;ManagementDate;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|제목;Subject;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "WorkStates;작업 상태 명"
            gridCodeNameList = gridCodeNameList & "/WorkDivision;작업 구분 명"
            gridCodeNameList = gridCodeNameList & "/ReceiptDivision;수정 요청서 접수 구분"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            Me.DateInit()

        End Sub

        '====================================================================================================
        Public Sub DateInit()
            '기본 날짜 셋팅
            'Dim currentDateFrom As String = ""
            'Dim currentDateTo As String = ""
            'currentDateTo = Date.Today
            'currentDateFrom = currentDateTo.Substring(0, 8) + "01"
            'Date.Today.AddDays(-6)

            Me.dtpReceiptDateFrom.TextValue = Date.Today.AddDays(-6)
            Me.dtpReceiptDateTo.TextValue = Date.Today
            Me.dtpManagementDateFrom.TextValue = ""
            Me.dtpManagementDateTo.TextValue = ""

        End Sub

        Private Sub SMDB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        Private Sub btnReceiptCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiptCopy.Click
            Me.SaveData_2()
        End Sub

        Private Sub cboWorkDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWorkDivision.SelectedIndexChanged
            'If cboWorkDivision.SelectedIndex = 3 Then
            '    txtWorkDetail.Enabled = True
            'Else
            '    txtWorkDetail.Enabled = False
            '    txtWorkDetail.TextValue = ""
            'End If
        End Sub

        'Private Sub SMDB01_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        '    Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
        '    If ShareParameters(3) <> "" Then
        '        Me.dtpReceiptDateFrom.TextValue = ShareParameters(0) '접수 시작 일자
        '        Me.dtpReceiptDateTo.TextValue = ShareParameters(1) '접수 종료 일자
        '        Me.dtpManagementDateFrom.TextValue = "" '처리 기준 일자
        '        Me.dtpManagementDateTo.TextValue = "" '처리 종료 일자
        '        Me.popSystemID.TextValue = ShareParameters(2) '시스템 구분

        '    ElseIf ShareParameters(4) <> "" Then
        '        Me.dtpReceiptDateFrom.TextValue = "" '접수 시작 일자
        '        Me.dtpReceiptDateTo.TextValue = "" '접수 종료 일자
        '        Me.dtpManagementDateFrom.TextValue = ShareParameters(0) '처리 기준 일자
        '        Me.dtpManagementDateTo.TextValue = ShareParameters(1) '처리 종료 일자
        '        Me.popSystemID.TextValue = ShareParameters(2) '시스템 구분

        '    End If

        '    Me.RequestData()
        '    GmainBusinessFunction.SetValue("화면 전환", "")

        'End Sub

        Private Sub popProgramID_ButtonClick() Handles popProgramID.ButtonClick
            If Me.popSystemID_2.NameText = "" Then
                MessageBox.Show("반드시 시스템 구분을 선택후 작업하세요 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.popProgramID.Tag = "code(프로그램 명);where(" & "Escape" & ");"
                Exit Sub
            End If

            'Dim strSysteDivision As String = ""

            'If Me.popSystemID_2.TextValue = "IR011" Then
            '    strSysteDivision = "CO"
            'ElseIf Me.popSystemID_2.TextValue = "IR012" Then
            '    strSysteDivision = "LE"
            'ElseIf Me.popSystemID_2.TextValue = "IR013" Then
            '    strSysteDivision = "PK"
            'ElseIf Me.popSystemID_2.TextValue = "IR014" Then
            '    strSysteDivision = "PR"
            'ElseIf Me.popSystemID_2.TextValue = "IR015" Then
            '    strSysteDivision = "PA"
            'ElseIf Me.popSystemID_2.TextValue = "IR016" Then
            '    strSysteDivision = "AC"
            'ElseIf Me.popSystemID_2.TextValue = "IR017" Then
            '    strSysteDivision = "CM"
            'ElseIf Me.popSystemID_2.TextValue = "IR018" Then
            '    strSysteDivision = "SM"
            'ElseIf Me.popSystemID_2.TextValue = "IR019" Then
            '    strSysteDivision = "MA"
            'ElseIf Me.popSystemID_2.TextValue = "IR051" Then
            '    strSysteDivision = "OM"
            'ElseIf Me.popSystemID_2.TextValue = "IR052" Then
            '    strSysteDivision = "PM"
            'End If

            Dim strProgramIDTag As String = ""

            'strProgramIDTag = "code(프로그램 명2);where( SystemDivision='" & strSysteDivision & "' group by ProgramID);"
            'strProgramIDTag = "code(프로그램 명);where( SystemDivision ='" & popSystemID_2.TextValue & "' group by ProgramID);"
            strProgramIDTag = "code(프로그램 명);where( SystemDivision ='" & popSystemID_2.TextValue & "');"

            Me.popProgramID.Tag = strProgramIDTag

        End Sub

        'Private Sub popSystemID_ButtonClick()
        '    Me.popSystemID.Tag = ""
        '    Dim strProjectID As String = ""
        '    strProjectID = "code(시스템 명);where(ProjectID='" & Me.popProjectID.TextValue & "0');"
        '    Me.popSystemID.Tag = strProjectID
        'End Sub

    
    End Class

End Namespace
