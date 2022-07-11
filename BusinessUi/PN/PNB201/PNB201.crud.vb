
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

    Partial Class PNB201

        '====================================================================================================
        Public Sub NewData()

            GmainCommonFunction.ControlNewData(Me, Me.picCriteria_1, Me.picIo_2_1)

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm_R.Text)   '���� ��
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AName", Me.txtBranchChiefName.Text)   '����ڼ���
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AphoneNum", Me.txtPhoneNum_2.Text)   '��ȭ��ȣ
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr", Me.txtAddr_2.Text)   '�ּ�
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AsocialNum", "")   '�ֹι�ȣ

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '=====================================================================================================
        ' ������ ���� ��ȸ(UI��Ʈ��)
        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)

            GmainsqlParameters = Nothing

            If Me.grd_1.RowSel() > 0 Then

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.grd_1.GetCurrentRowCellValue("BranchChiefCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                Me.txtChiefCd.Text = reciveDataSet.Tables(0).Rows(0).Item("BranchChiefCd").ToString
                reciveDataSet = Nothing


            Else
                Me.grd_1.Select()
                If Me.grd_1.Rows > 1 Then

                    Me.grd_1.Select(1, 1, True)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.grd_1.GetCurrentRowCellValue("BranchChiefCd"))
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_2_R", False, True, GmainsqlParameters)
                    GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                    reciveDataSet = Nothing
                Else
                    '' clear ������ ���� �ƹ��͵� ���� ��� �Է»����� �����.
                    GmainCommonFunction.ControlNewData(Me, picCriteria_1, Me.picIo_2_1)
                End If

            End If
            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.grd_1.GetCurrentRowCellValue("BranchChiefCd"))
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_4_R", False, True, GmainsqlParameters)
            Me.grd_3.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_4(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.grd_1.GetCurrentRowCellValue("BranchChiefCd"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_3_R", False, True, GmainsqlParameters)
            Dim bytBuffer() As Byte

            '-- ���� ���� �ʱ�ȭ 
            Me.OpenFileDialog1.Reset()

            '-- ������ �̹����� �ʱ�ȭ
            If Not PictureBox1.Image Is Nothing Then
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Nothing
            End If

            If reciveDataSet.Tables.Count >= 1 And reciveDataSet.Tables(0).Rows.Count >= 1 Then
                If reciveDataSet.Tables(0).Rows(0).Item("PhotoFilePath").GetType.Name = "Byte[]" Then
                    bytBuffer = reciveDataSet.Tables(0).Rows(0).Item("PhotoFilePath")
                    PictureBox1.Image = fnGetImage(bytBuffer)
                End If
            End If

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

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

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhotoFilePath", bytBuffer)   '�ֹι�ȣ

            Try
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", txtChiefCd.Text.Trim())
                    .SetSqlParameter(GmainsqlParameters, "@APhotoFilePath", bytBuffer)
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_2_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    .SaveDataMessage(Me)
                End With

                MessageBox.Show("�̹����� ���� �Ǿ����ϴ�.", "�߰�", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        End Sub


        Private Function fnGetImage(ByVal bytBuffer() As Byte) As Image
            GmainCommonFunction.setImage(bytBuffer)
            fnGetImage = GmainCommonFunction.getImage()
        End Function


        '====================================================================================================
        Public Sub SaveData()

            'If Validation() = True Then
            If Me.txtChiefCd.Text.Replace(" ", "") = "" Then
                GrecordProcessMode = "1"
            Else
                GrecordProcessMode = "2"
            End If

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.txtChiefCd.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASocialNum", Me.txtSocialNum.Text) 'Me.cboBusinessPlaceCode.TextValue)
            ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.TxtBranchNm.Text)   '20081013
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AName", Me.txtName.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APostNum", Me.PopPostNum.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr1", Me.txtAddr1.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr2", Me.txtAddr2.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum", Me.txtPhoneNum.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMobileNum", Me.txtMobileNum.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACareer", Me.txtCareer.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAcademyCode", Me.popAcademyCode.TextValue)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APropertyTaxAmt", Me.txtPropertyTaxAmt.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APropertyTaxAmt", Me.chkPropertyTaxAmt.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchYn", Me.chkBranchYn.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessNum", Me.txtBusinessNum.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATaxDivCd", Me.txtTaxDivCd.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACorparationNm", Me.txtCorparationNm.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiType", Me.txtBusiType.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiStatus", Me.txtBusiStatus.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOpenDt", Me.dtpOpenDt.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiPostNum", Me.popBusiPostNum.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiAddr1", Me.txtBusiAddr1.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiAddr2", Me.txtBusiAddr2.Text)

            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            'Me.RequestData()
            'Else
            'GmainExecuteDbCommand.GerrorNumber = 1
            'End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("�����Ͻðڽ��ϱ�?", MsgBoxStyle.OkCancel, "�����ϼ���.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", Me.txtChiefCd.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASocialNum", Me.txtSocialNum.Text) 'Me.cboBusinessPlaceCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AName", Me.txtName.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APostNum", Me.PopPostNum.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr1", Me.txtAddr1.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr2", Me.txtAddr2.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNum", Me.txtPhoneNum.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMobileNum", Me.txtMobileNum.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACareer", Me.txtCareer.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAcademyCode", Me.popAcademyCode.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APropertyTaxAmt", Me.chkPropertyTaxAmt.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchYn", Me.chkBranchYn.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusinessNum", Me.txtBusinessNum.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATaxDivCd", Me.txtTaxDivCd.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACorparationNm", Me.txtCorparationNm.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiType", Me.txtBusiType.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiStatus", Me.txtBusiStatus.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOpenDt", Me.dtpOpenDt.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiPostNum", Me.popBusiPostNum.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiAddr1", Me.txtBusiAddr1.Text)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABusiAddr2", Me.txtBusiAddr2.Text)

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ� ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Sub

        Public Function Validation() As Boolean

            'Validation = False

            'With Me.grd_1
            '    For inti As Integer = .FixedRows To .Rows - 1

            '        If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
            '            If IsNumeric(.get_TextMatrix(inti, .get_ColIndex("IoCnt"))) = False Then
            '                MessageBox.Show("������ó���Ǽ��� �ٽ� �Է��� �ּ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If
            '            If IsNumeric(.get_TextMatrix(inti, .get_ColIndex("Cycle"))) = False Then
            '                MessageBox.Show("�߻��ֱ⸦ �ٽ� �Է��� �ּ���  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If
            '            If .get_TextMatrix(inti, .get_ColIndex("ProgramID")) = "" Then
            '                MessageBox.Show("���α׷�ID�� �ݵ�� �Է��� �ּ���  ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                Exit Function
            '            End If

            '        End If
            '    Next inti
            'End With

            'Validation = True

        End Function


    End Class

End Namespace
