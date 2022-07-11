'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 발령 사항 등록
' form 설명 : 발령 사항을 추가, 수정, 삭제, 조회한다.
' 작성자 : 박민정
' 작성일 : 2006-05-09
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNA202
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;1000;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;5000;;l;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|입사일자;JoinCompanyDate;5000;;l;" & "o;n;y;2;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNameHangul")

            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;1000;;r;" & "io;n;y;6;"
            gridAttributes = gridAttributes & "|발령 일련 번호;AnnOfAppCnsNmb;1000;;c;" & "io;y;y;2;"
            gridAttributes = gridAttributes & "|발령 일자;AnnouncementOfAppointmentDate;100;;l;" & "io;y;n;8;"
            gridAttributes = gridAttributes & "|발령 코드;AnnouncementOfAppointmentCode;80;;c;" & "io;y;n;5;발령 명;AnnouncementOfAppointmentName"
            gridAttributes = gridAttributes & "|발령 명;AnnouncementOfAppointmentName;100;;l;" & "o;y;n;5;"
            gridAttributes = gridAttributes & "|근무 상태;SeviceStatesCode;80;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|부서 코드;OnesPositionDepartmentCode;80;;l;" & "io;n;n;7;파트 명;OnesPositionDepartmentCodeName"
            gridAttributes = gridAttributes & "|발령 부서;OnesPositionDepartmentCodeName;100;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|근무 부서;SeviceDepartmentCode;1147;;l;" & "io;n;y;7;"
            gridAttributes = gridAttributes & "|직급;PromotionCode;80;;c;" & "io;n;n;5"
            gridAttributes = gridAttributes & "|직위;PositionCode;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|담당 업무;DutyCode;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|년차;PayStepCode;60;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|최종발령 여부;LstAnnOfAppYesOrNo;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|최종승진 여부;LastPromotionYesOrNo;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|급여 구분;AllowanceDivisionCode;1000;;l;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|비고;Note;100;;l;" & "io;n;n;255;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "AnnouncementOfAppointmentCode;발령 명"
            gridCodeNameList = gridCodeNameList & "SeviceStatesCode;근무 상태 명"
            ''gridCodeNameList = gridCodeNameList & "/OnesPositionDepartmentCode;소속 부서 명"
            ''gridCodeNameList = gridCodeNameList & "/SeviceDepartmentCode;근무 부서 명"
            gridCodeNameList = gridCodeNameList & "/PromotionCode;직급 명"
            gridCodeNameList = gridCodeNameList & "/PositionCode;직위 명"
            gridCodeNameList = gridCodeNameList & "/PayStepCode;호봉 명"
            gridCodeNameList = gridCodeNameList & "/AllowanceDivisionCode;급여 구분 명"

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 1

        End Sub

        Private Sub PNA202_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters(0) = "" Then Exit Sub

            Me.cboSeviceStatesCode2.TextValue = ShareParameters(0)
            Me.txtEmployeeNameHangul_2.TextValue = ShareParameters(1)

            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub grd_2_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.grd_2.ImeMode = System.Windows.Forms.ImeMode.Hangul
        End Sub

        Private Sub PNA202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If
        End Sub

        Private Function CheckDataAllowPermitionByUser(ByVal AUiId As String, ByVal ALogInID As String, ByVal APermition As String) As Boolean
            Dim tempSqlParameter() As SqlParameter = Nothing
            Dim reciveDataSet As DataSet = Nothing

            Dim RequestPermition As String = ""
            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", ALogInID)
            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AprogramId", AUiId)

            reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "GetScreeenPermintionByUser", False, True, tempSqlParameter)
            If IsNothing(reciveDataSet) = False Then
                If reciveDataSet.Tables(0).Rows.Count > 0 Then
                    RequestPermition = CType(reciveDataSet.Tables(0).Rows(0).Item(0), Integer)

                    If APermition = "RequestData" Then
                        CheckDataAllowPermitionByUser = IIf(RequestPermition = 1, True, False)
                    End If
                End If

            End If
        End Function

        Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        btnPRB002.Click, btnPRB003.Click, btnPRB004.Click, btnPRB005.Click _
        , btnPRB006.Click, btnPRB007.Click, btnPRB009.Click _
        , btnPNA202.Click, btnPRB011.Click, btnPRB012.Click, btnPRB013.Click _
        , btnPRB014.Click, btnPRB015.Click, btnPRB016.Click

            If txtEmployeeNumber.TextValue = "" Then
                MessageBox.Show("반드시 사원을 조회후 화면 이동을 하세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim SeviceStatesCode2 As String = Me.cboSeviceStatesCode2.TextValue
            Dim EmployeeNameHangul As String = Me.txtEmployeeNameHangul.TextValue

            If SeviceStatesCode2 <> "" Then
                GmainBusinessFunction.SetValue("화면 전환", SeviceStatesCode2 & ";" & EmployeeNameHangul & ";")
                Dim UiControlId As String = Mid(Me.ActiveControl.Name, 4, 6)

                If Me.CheckDataAllowPermitionByUser(UiControlId, GmainBusinessFunction.GetValue("로그인 ID"), "RequestData") = True Then
                    ' 권한이 있는 경우
                    Me.ShowUiControl(UiControlId, "")
                Else
                    MessageBox.Show("화면 접근 권한이 없습니다.", "권한 에러", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MsgBox("조회된 사원이 없습니다.")
            End If

        End Sub
    End Class

End Namespace
