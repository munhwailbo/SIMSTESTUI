
Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Partial Class PNA201

        '====================================================================================================
        Public Sub NewData()

            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)

            Me.picOpen.Visible = False
            Me.picSave.Visible = False

            If Not PictureBox1.Image Is Nothing Then
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Nothing
            End If
            Me.chkUnmInsAppYesOrNo.Checked = True
            Me.chkNtnHltInsAppYesOrNo.Checked = True
            Me.dtpJoinCompanyDate.TextValue = System.DateTime.Now
            Me.numSupportFamilyCount.TextValue = 0
            Me.txtEmployeeNumber.Focus()

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASeviceStatesCode2", Me.cboSeviceStatesCode2.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmployeeNameHangul", Me.txtEmployeeNameHangul_2.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA201_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@EmployeeNumber", Me.grd_1.GetCurrentRowCellValue("EmployeeNumber"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA201_2_R", False, True, GmainsqlParameters)
            GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

            If reciveDataSet.Tables(0).Rows(0).Item("EmployeeNumber").ToString.Length > 0 Then
                Me.picOpen.Visible = True
                Me.picSave.Visible = True
            Else
                Me.picOpen.Visible = False
                Me.picSave.Visible = False
            End If

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

            If Me.chkMeritoriousTargetYesOrNo.Checked = True Then
                Me.txtMeritoriousNumber.Visible = True
                Me.Label2.Visible = True
            Else
                Me.txtMeritoriousNumber.Visible = False
                Me.Label2.Visible = False

            End If

        End Sub

        '====================================================================================================
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@EmployeeNumber", Me.grd_1.GetCurrentRowCellValue("EmployeeNumber"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA201_3_R", False, True, GmainsqlParameters)
            Dim bytBuffer() As Byte

            '-- 오픈 값의 초기화 
            Me.OpenFileDialog1.Reset()

            '-- 사원 이미지의 초기화
            If Not PictureBox1.Image Is Nothing Then
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Nothing
            End If

            If reciveDataSet.Tables.Count >= 1 And reciveDataSet.Tables(0).Rows.Count >= 1 Then
                If reciveDataSet.Tables(0).Rows(0).Item("EmployeeImage").GetType.Name = "Byte[]" Then
                    bytBuffer = reciveDataSet.Tables(0).Rows(0).Item("EmployeeImage")
                    PictureBox1.Image = fnGetImage(bytBuffer)
                End If
            End If
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub
        ''' <summary>
        ''' 이미지로 변환하여 가져옴
        ''' </summary>
        ''' <param name="bytBuffer"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function fnGetImage(ByVal bytBuffer() As Byte) As Image
            GmainCommonFunction.setImage(bytBuffer)
            fnGetImage = GmainCommonFunction.getImage()
        End Function
       

        '-- 이미지 저장 
        Public Sub UpLoadImage()
            Try
                Dim fr As FileStream

                fr = OpenFileDialog1.OpenFile()
                Dim bytBuffer(fr.Length - 1) As Byte
                fr.Read(bytBuffer, 0, fr.Length)
                fr.Close()

                Call saveImage(bytBuffer)

            Catch ex As Exception
                MessageBox.Show("파일을 정상적으로 선택하십시요", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Sub

        Private Sub saveImage(ByVal bytBuffer() As Byte)
           
            Try
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@EmployeeNumber", txtEmployeeNumber.Text.Trim())
                    .SetSqlParameter(GmainsqlParameters, "@EmployeeImage", bytBuffer)

                    GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PAAB02_CUD", True, False, GmainsqlParameters)

                    .SetAllBusinessUiInitialValue(Me)
                    .SaveDataMessage(Me)
                End With

                MessageBox.Show("이미지가 저장 되었습니다.", "추가", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        End Sub
        '====================================================================================================

        Public Sub SaveData()
            If Me.Validation = True Then
                Dim strMode As String = ""
                If Me.txtEmployeeNumber_2.TextValue.Length = 6 Then
                    strMode = "2" '수정
                Else
                    strMode = "1" '입력
                End If

                GmainsqlParameters = Nothing
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", strMode)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.txtEmployeeNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbusinessPlaceCode", "01") 'Me.cboBusinessPlaceCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeNameHangul", Me.txtEmployeeNameHangul.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeNameChineseCharacter", Me.txtEmployeeNameChineseCharacter.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AinhabitantsNumber", Me.txtInhabitantsNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ApassportNumber", Me.txtPassportNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AopenPalanquinDivisionCode", Me.cboOpenPalanquinDivisionCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AnationalAnthemCode", Me.popNationalAnthemCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AonesPositionDepartmentCode", Me.popOnesPositionDepartmentCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AseviceDepartmentCode", Me.popSeviceDepartmentCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AjobGroupCode", Me.cboJobGroupCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ApromotionCode", Me.cboPromotionCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AdutyCode", Me.txtDutyCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ApositionCode", Me.cboPositionCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGub", Me.txtGub.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AHo", Me.txtHo.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AonesDutyCode", Me.cboOnesDutyCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ApayStepCode", Me.txtPayStepCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AjoinCompanyDate", Me.dtpJoinCompanyDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AgroupJoinCompanyDate", "")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AreJoinCompanyDate", "") '초기화 안되는 경우가 많아서 ""으로
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AgroupJoinCompanyDate", Me.dtpGroupJoinCompanyDate.TextValue)
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AreJoinCompanyDate", Me.dtpReJoinCompanyDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AadoptionDivisionCode", Me.cboAdoptionDivisionCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AseviceStatesCode", Me.cboSeviceStatesCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AallowanceDivisionCode", Me.cboAllowanceDivisionCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AphoneNumber", Me.txtPhoneNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AmobilePhoneNumber", Me.txtMobilePhoneNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AeMAIL", Me.txtEMAIL.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AlstAnnOfAppCod", Me.cboSeviceStatesCode2.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AlstAnnOfAppDat", Me.dtpLstAnnOfAppDat.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Anote", Me.txtNote.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AretirementDate", Me.dtpRetirementDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AretirementAmount", Me.numRetirementAmount.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AretirementReason", Me.txtRetirementReason.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AmarriageYesOrNoCode", Me.cboMarriageYesOrNoCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AmarriageDate", Me.dtpMarriageDate.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbankCode", Me.cboBankCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AaccountNumber", Me.txtAccountNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AsupportFamilyCount", Me.numSupportFamilyCount.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AunmInsAppYesOrNo", Me.chkUnmInsAppYesOrNo.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AhealthInsuranceClass", Me.txtHealthInsuranceClass.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AntnHltInsAppYesOrNo", Me.chkNtnHltInsAppYesOrNo.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AnationalPensionClass", Me.txtNationalPensionClass.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AjoiCmpRcmPrs", Me.txtJoiCmpRcmPrs.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARetirementYesOrNo", Me.chkRetirementYesOrNo.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMeritoriousTargetYesOrNo", Me.chkMeritoriousTargetYesOrNo.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMeritoriousNumber", Me.txtMeritoriousNumber.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesBirthday", Me.dtpOnesBirthday.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesBirthdayDivisionCode", Me.cboOnesBirthdayDivisionCode.TextValue)

                '-- 사진 추가
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeImage", bytBuffer)

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA201_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            End If
        End Sub

        Public Sub SaveData_2()
            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

            GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA201_2_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            Try

                Dim result As DialogResult = Nothing

                result = MessageBox.Show("사원을 삭제 하시겠습니까?   ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    GmainsqlParameters = Nothing
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.txtEmployeeNumber.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbusinessPlaceCode", "01") 'Me.cboBusinessPlaceCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeNameHangul", Me.txtEmployeeNameHangul.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeNameChineseCharacter", Me.txtEmployeeNameChineseCharacter.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AinhabitantsNumber", Me.txtInhabitantsNumber.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ApassportNumber", Me.txtPassportNumber.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AopenPalanquinDivisionCode", Me.cboOpenPalanquinDivisionCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AnationalAnthemCode", Me.popNationalAnthemCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AonesPositionDepartmentCode", Me.popOnesPositionDepartmentCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AseviceDepartmentCode", Me.popSeviceDepartmentCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AjobGroupCode", Me.cboJobGroupCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ApromotionCode", Me.cboPromotionCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AdutyCode", Me.txtDutyCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ApositionCode", Me.cboPositionCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AGub", Me.txtGub.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AHo", Me.txtHo.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AonesDutyCode", Me.cboOnesDutyCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ApayStepCode", Me.txtPayStepCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AjoinCompanyDate", Me.dtpJoinCompanyDate.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AgroupJoinCompanyDate", Me.dtpGroupJoinCompanyDate.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AreJoinCompanyDate", Me.dtpReJoinCompanyDate.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AadoptionDivisionCode", Me.cboAdoptionDivisionCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AseviceStatesCode", Me.cboSeviceStatesCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AallowanceDivisionCode", Me.cboAllowanceDivisionCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AphoneNumber", Me.txtPhoneNumber.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AmobilePhoneNumber", Me.txtMobilePhoneNumber.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AeMAIL", Me.txtEMAIL.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AlstAnnOfAppCod", Me.cboSeviceStatesCode2.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AlstAnnOfAppDat", Me.dtpLstAnnOfAppDat.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Anote", Me.txtNote.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AretirementDate", Me.dtpRetirementDate.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AretirementAmount", Me.numRetirementAmount.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AretirementReason", Me.txtRetirementReason.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AmarriageYesOrNoCode", Me.cboMarriageYesOrNoCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AmarriageDate", Me.dtpMarriageDate.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AbankCode", Me.cboBankCode.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AaccountNumber", Me.txtAccountNumber.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AsupportFamilyCount", Me.numSupportFamilyCount.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AunmInsAppYesOrNo", Me.chkUnmInsAppYesOrNo.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AhealthInsuranceClass", Me.txtHealthInsuranceClass.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AntnHltInsAppYesOrNo", Me.chkNtnHltInsAppYesOrNo.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AnationalPensionClass", Me.txtNationalPensionClass.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AjoiCmpRcmPrs", Me.txtJoiCmpRcmPrs.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARetirementYesOrNo", Me.chkRetirementYesOrNo.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMeritoriousTargetYesOrNo", Me.chkMeritoriousTargetYesOrNo.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMeritoriousNumber", Me.txtMeritoriousNumber.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesBirthday", Me.dtpOnesBirthday.TextValue)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOnesBirthdayDivisionCode", Me.cboOnesBirthdayDivisionCode.TextValue)

                    '-- 사진 추가
                    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeImage", bytBuffer)

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA201_CUD", True, False, GmainsqlParameters)

                    If GmainExecuteDbCommand.GerrorNumber = 0 Then
                        MessageBox.Show("데이타가삭제되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GmainCommonFunction.GRequestDataNumber = 1
                    Else
                        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If

                    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

                End If

            Catch ex As Exception

            End Try

        End Sub

        '====================================================================================================
        'Validation Check
        '====================================================================================================
        Public Function Validation() As Boolean

            Validation = False

            '************** 체크 로직 *********************
            '1. 앞 6자리는 YYMMDD 로 된 날짜.
            '2. 7번째 자리는 성별 구분.
            '    1,2 : 20세기 남/여
            '    3,4 : 21세기 남/여
            '3. 마지막 자리를 제외하고, 앞에서부터 차례로 [2,3,4,5,6,7,8,9,2,3,4,5]를 각자리에 곱하기.
            '4. 곱한 각 자리의 수를 모두 더하기.
            '5. 모두 더한 수를 11로 나눈 나머지 구하기.
            '6. 나머지가 2 이상이면 11 에서 구한 나머지를 빼기. 
            '   만일 나머지가 0이면 10을 빼고, 1이면 11을 빼기.
            '7. 3~6번을 통해 계산한 값을 마니막 자리수와 비교하여 같으면 유효한 주민등록번호이며, 다르면 잘못된 번호이다.

            Dim tempResidentRegistrationNumber As String = "" '주민번호로직 체크를 위한 임시 변수

            '복사해서 붙였을 경우에 대한 처리 추가
            tempResidentRegistrationNumber = Trim(Me.txtInhabitantsNumber.TextValue)

            'If IsNumeric(tempResidentRegistrationNumber) <> True Then
            '    MessageBox.Show("주민 번호는 숫자만 입력하세요.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Function
            'End If

            If tempResidentRegistrationNumber.Length <> 13 Then
                MessageBox.Show("주민번호 자리수가 맞지 않습니다.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Function
            End If

            If tempResidentRegistrationNumber.Substring(6, 1) > 6 _
                Or tempResidentRegistrationNumber.Substring(6, 1) = 0 Then '외국인까지 포함(1,2 : 20세기 남/여,3,4, : 21세기 남/여, 5,6 : 외국인)
                MessageBox.Show("주민번호가 유효하지 않습니다.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Function
            End If

            If tempResidentRegistrationNumber.Substring(6, 1) = 3 Or tempResidentRegistrationNumber.Substring(6, 1) = 4 Then '2000년 이후 출생
                Dim tempInt1 As Integer = Convert.ToInt32(tempResidentRegistrationNumber.Substring(0, 2)) '주민번호상 태어난 해
                Dim tempInt2 As Integer = Convert.ToInt32(Date.Now.Year().ToString().Substring(2, 2)) '현재 년도
                If tempInt1 > tempInt2 Then '현재 년도 보다는 아래여야 하기 때문에
                    MessageBox.Show("주민번호가 유효하지 않습니다.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GmainExecuteDbCommand.GerrorNumber = 1
                    Exit Function
                End If
            End If

            '유효성 체크
            Dim tempInvalidationCheckString As String = "234567892345" '로직을 위해서 가장뒷자리를 제외한 각 자리수에 곱할 숫자
            Dim tempSum As Integer = 0
            Dim tempMod As Integer = 0

            For tempInti As Integer = 0 To 11 Step 1
                tempSum = tempSum + tempResidentRegistrationNumber.Substring(tempInti, 1) * tempInvalidationCheckString.Substring(tempInti, 1)
            Next tempInti

            tempMod = tempSum Mod 11

            If tempMod = 0 Then
                tempSum = 11 - 10
            ElseIf tempMod = 1 Then
                tempSum = 11 - 11
            ElseIf tempMod >= 2 Then
                tempSum = 11 - tempMod
            End If

            ' MsgBox(tempSum)

            If tempSum <> tempResidentRegistrationNumber.Substring(12, 1) Then
                MessageBox.Show("주민번호가 유효하지 않습니다.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Function
            End If

            Validation = True

        End Function

    End Class

End Namespace
