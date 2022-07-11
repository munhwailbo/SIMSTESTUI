'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 인사헤더등록
' form 설명 : 
' 작성자 : 황인중
' 작성일 : 2006-05-12
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

    Public Class PNA201
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

            '-- 사진 전송 버튼을 처음에는 보이지 않게 한다.
            Me.picOpen.Visible = False
            Me.picSave.Visible = False

            Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNameHangul")

            Me.chkNtnHltInsAppYesOrNo.Checked = True
            Me.chkUnmInsAppYesOrNo.Checked = True
            Me.txtMeritoriousNumber.Visible = False
            Me.Label2.Visible = False

        End Sub

        Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
            btnPRB002.Click, btnPRB003.Click, btnPRB004.Click, btnPRB005.Click _
            , btnPRB006.Click, btnPRB007.Click, btnPRB009.Click _
            , btnPRB010.Click, btnPRB011.Click, btnPRB012.Click, btnPRB013.Click _
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

        Private Function CheckDataAllowPermitionByUser(ByVal AUiId As String, ByVal ALogInID As String, ByVal APermition As String) As Boolean
            Dim tempSqlParameter() As SqlParameter = Nothing
            Dim reciveDataSet As DataSet = Nothing

            Dim RequestPermition As String = ""
            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", ALogInID)
            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AprogramId", AUiId)

            reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("sdb", "GetScreeenPermintionByUser", False, True, tempSqlParameter)
            If IsNothing(reciveDataSet) = False Then
                If reciveDataSet.Tables(0).Rows.Count > 0 Then
                    RequestPermition = CType(reciveDataSet.Tables(0).Rows(0).Item(0), Integer)

                    If APermition = "RequestData" Then
                        CheckDataAllowPermitionByUser = IIf(RequestPermition = 1, True, False)
                    End If
                End If

            End If
        End Function

        Private Sub cboMarriageYesOrNoCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMarriageYesOrNoCode.TextChanged

            If Me.cboMarriageYesOrNoCode.SelectedItem = "1.미혼" Then
                Me.dtpMarriageDate.Visible = False
                Me.lblMarriageDate.Visible = False
            Else
                Me.dtpMarriageDate.Visible = True
                Me.lblMarriageDate.Visible = True
            End If

        End Sub

        Private Sub BtnImageSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImageSave.Click
            '-- 이미지 저장
            Call UpLoadImage()

        End Sub

        Private Sub chkMeritoriousTargetYesOrNo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMeritoriousTargetYesOrNo.CheckedChanged
            If Me.chkMeritoriousTargetYesOrNo.Checked = True Then
                Me.txtMeritoriousNumber.Visible = True
                Me.Label2.Visible = True
            Else
                Me.txtMeritoriousNumber.Visible = False
                Me.Label2.Visible = False
            End If
        End Sub

        Private Sub picOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picOpen.Click

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

        Private Sub picSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSave.Click
            '-- 이미지 저장
            Call UpLoadImage()
        End Sub

        Private Sub picOpen_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOpen.MouseEnter

            Me.picOpen.Image = Me.ImageList1.Images(1)
            Me.Cursor = Cursors.Hand

        End Sub

        Private Sub picOpen_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picOpen.MouseLeave

            Me.picOpen.Image = Me.ImageList1.Images(0)
            Me.Cursor = Cursors.Default

        End Sub

        Private Sub picSave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSave.MouseEnter
            Me.picSave.Image = Me.ImageList1.Images(3)
            Me.Cursor = Cursors.Hand
        End Sub

        Private Sub picSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSave.MouseLeave
            Me.picSave.Image = Me.ImageList1.Images(2)
            Me.Cursor = Cursors.Default
        End Sub

        Private Sub cboOpenPalanquinDivisionCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOpenPalanquinDivisionCode.LostFocus

            If Trim(Me.cboOpenPalanquinDivisionCode.TextValue).Length <> 0 Then
                If Me.cboOpenPalanquinDivisionCode.TextValue = "2" Then
                    Me.cboMilitaryServiceDivisionCode.Visible = False
                    Me.Label3.Visible = False
                End If
                If Me.cboOpenPalanquinDivisionCode.TextValue = "1" Then
                    Me.cboMilitaryServiceDivisionCode.Visible = True
                    Me.Label3.Visible = True
                End If
            End If

        End Sub

        Private Sub cboOpenPalanquinDivisionCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOpenPalanquinDivisionCode.TextChanged
            If Trim(Me.cboOpenPalanquinDivisionCode.TextValue).Length <> 0 Then
                If Me.cboOpenPalanquinDivisionCode.TextValue = "2" Then
                    Me.cboMilitaryServiceDivisionCode.Visible = False
                    Me.Label3.Visible = False
                End If
                If Me.cboOpenPalanquinDivisionCode.TextValue = "1" Then
                    Me.cboMilitaryServiceDivisionCode.Visible = True
                    Me.Label3.Visible = True
                End If
            End If

        End Sub

        Private Sub txtInhabitantsNumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInhabitantsNumber.LostFocus

            If Trim(Me.txtInhabitantsNumber.TextValue).Length = 13 Then
                Me.dtpOnesBirthday.TextValue = DateTime.ParseExact("19" + Me.txtInhabitantsNumber.TextValue.Substring(0, 6), "yyyyMMdd", Nothing)
                If Me.txtInhabitantsNumber.TextValue.Substring(6, 1) = "1" Then
                    Me.cboOpenPalanquinDivisionCode.TextValue = "1"
                Else
                    Me.cboOpenPalanquinDivisionCode.TextValue = "2"
                End If
            End If

        End Sub

        Private Sub txtInhabitantsNumber_TextChanged() Handles txtInhabitantsNumber.TextChanged
            If Trim(Me.txtInhabitantsNumber.TextValue).Length = 13 Then
                Me.dtpOnesBirthday.TextValue = DateTime.ParseExact("19" + Me.txtInhabitantsNumber.TextValue.Substring(0, 6), "yyyyMMdd", Nothing)
                If Me.txtInhabitantsNumber.TextValue.Substring(6, 1) = "1" Then
                    Me.cboOpenPalanquinDivisionCode.TextValue = "1"
                Else
                    Me.cboOpenPalanquinDivisionCode.TextValue = "2"
                End If
            End If
        End Sub

        Private Sub popOnesPositionDepartmentCode_TextChanged() Handles popOnesPositionDepartmentCode.TextChanged

        End Sub

        Private Sub PNA201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If
        End Sub

        Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

        End Sub

        Private Sub btnSyncPersnalAffairHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSyncPersnalAffairHeader.Click
            SaveData_2()
        End Sub
    End Class
End Namespace
