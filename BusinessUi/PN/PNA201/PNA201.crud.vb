
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

            '-- ���� ���� �ʱ�ȭ 
            Me.OpenFileDialog1.Reset()

            '-- ��� �̹����� �ʱ�ȭ
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
        ''' �̹����� ��ȯ�Ͽ� ������
        ''' </summary>
        ''' <param name="bytBuffer"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function fnGetImage(ByVal bytBuffer() As Byte) As Image
            GmainCommonFunction.setImage(bytBuffer)
            fnGetImage = GmainCommonFunction.getImage()
        End Function
       

        '-- �̹��� ���� 
        Public Sub UpLoadImage()
            Try
                Dim fr As FileStream

                fr = OpenFileDialog1.OpenFile()
                Dim bytBuffer(fr.Length - 1) As Byte
                fr.Read(bytBuffer, 0, fr.Length)
                fr.Close()

                Call saveImage(bytBuffer)

            Catch ex As Exception
                MessageBox.Show("������ ���������� �����Ͻʽÿ�", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                MessageBox.Show("�̹����� ���� �Ǿ����ϴ�.", "�߰�", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
                    strMode = "2" '����
                Else
                    strMode = "1" '�Է�
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
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AreJoinCompanyDate", "") '�ʱ�ȭ �ȵǴ� ��찡 ���Ƽ� ""����
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

                '-- ���� �߰�
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeImage", bytBuffer)

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA201_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            End If
        End Sub

        Public Sub SaveData_2()
            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

            GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA201_2_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub

        '====================================================================================================
        Public Sub DeleteData()
            Try

                Dim result As DialogResult = Nothing

                result = MessageBox.Show("����� ���� �Ͻðڽ��ϱ�?   ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

                    '-- ���� �߰�
                    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AemployeeImage", bytBuffer)

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                    GmainExecuteDbCommand.ExecuteStoredProcedure("HR", "PNA201_CUD", True, False, GmainsqlParameters)

                    If GmainExecuteDbCommand.GerrorNumber = 0 Then
                        MessageBox.Show("����Ÿ�������Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GmainCommonFunction.GRequestDataNumber = 1
                    Else
                        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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

            '************** üũ ���� *********************
            '1. �� 6�ڸ��� YYMMDD �� �� ��¥.
            '2. 7��° �ڸ��� ���� ����.
            '    1,2 : 20���� ��/��
            '    3,4 : 21���� ��/��
            '3. ������ �ڸ��� �����ϰ�, �տ������� ���ʷ� [2,3,4,5,6,7,8,9,2,3,4,5]�� ���ڸ��� ���ϱ�.
            '4. ���� �� �ڸ��� ���� ��� ���ϱ�.
            '5. ��� ���� ���� 11�� ���� ������ ���ϱ�.
            '6. �������� 2 �̻��̸� 11 ���� ���� �������� ����. 
            '   ���� �������� 0�̸� 10�� ����, 1�̸� 11�� ����.
            '7. 3~6���� ���� ����� ���� ���ϸ� �ڸ����� ���Ͽ� ������ ��ȿ�� �ֹε�Ϲ�ȣ�̸�, �ٸ��� �߸��� ��ȣ�̴�.

            Dim tempResidentRegistrationNumber As String = "" '�ֹι�ȣ���� üũ�� ���� �ӽ� ����

            '�����ؼ� �ٿ��� ��쿡 ���� ó�� �߰�
            tempResidentRegistrationNumber = Trim(Me.txtInhabitantsNumber.TextValue)

            'If IsNumeric(tempResidentRegistrationNumber) <> True Then
            '    MessageBox.Show("�ֹ� ��ȣ�� ���ڸ� �Է��ϼ���.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Function
            'End If

            If tempResidentRegistrationNumber.Length <> 13 Then
                MessageBox.Show("�ֹι�ȣ �ڸ����� ���� �ʽ��ϴ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Function
            End If

            If tempResidentRegistrationNumber.Substring(6, 1) > 6 _
                Or tempResidentRegistrationNumber.Substring(6, 1) = 0 Then '�ܱ��α��� ����(1,2 : 20���� ��/��,3,4, : 21���� ��/��, 5,6 : �ܱ���)
                MessageBox.Show("�ֹι�ȣ�� ��ȿ���� �ʽ��ϴ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Function
            End If

            If tempResidentRegistrationNumber.Substring(6, 1) = 3 Or tempResidentRegistrationNumber.Substring(6, 1) = 4 Then '2000�� ���� ���
                Dim tempInt1 As Integer = Convert.ToInt32(tempResidentRegistrationNumber.Substring(0, 2)) '�ֹι�ȣ�� �¾ ��
                Dim tempInt2 As Integer = Convert.ToInt32(Date.Now.Year().ToString().Substring(2, 2)) '���� �⵵
                If tempInt1 > tempInt2 Then '���� �⵵ ���ٴ� �Ʒ����� �ϱ� ������
                    MessageBox.Show("�ֹι�ȣ�� ��ȿ���� �ʽ��ϴ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GmainExecuteDbCommand.GerrorNumber = 1
                    Exit Function
                End If
            End If

            '��ȿ�� üũ
            Dim tempInvalidationCheckString As String = "234567892345" '������ ���ؼ� ������ڸ��� ������ �� �ڸ����� ���� ����
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
                MessageBox.Show("�ֹι�ȣ�� ��ȿ���� �ʽ��ϴ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Function
            End If

            Validation = True

        End Function

    End Class

End Namespace
