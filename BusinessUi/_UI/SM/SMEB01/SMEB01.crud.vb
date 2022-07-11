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

Namespace ubiLease.UI.BusinessUi.SM

    Partial Class SMEB01

        '====================================================================================================
        Public Sub NewData()
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)

            '신규 버튼 클릭후 컨트롤 세팅
            Me.txtProgramID.Enabled = True
            Me.txtTerms.Enabled = True

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@SystemDivision", Me.cboSystemDivision.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@PrivateUseYesOrNo", Me.cboPrivateUseYesOrNo.TextValue)
            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEB01_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)

            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ProgramID", Me.grd_1.GetCurrentRowCellValue("ProgramID"))

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEB01_2_R", False, True, GmainsqlParameters)
            GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

            'Me.txtUiID.TextValue = Me.grd_1.GetCurrentRowCellValue("ProgramID").ToString()
            'Me.txtUiName.TextValue = Me.grd_1.GetCurrentRowCellValue("ProgramName").ToString()
            'Me.txtUiDescription.TextValue = Me.grd_1.GetCurrentRowCellValue("ProgramExplanation").ToString()

        End Sub


        '====================================================================================================

        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)
            ''GmainsqlParameters = Nothing
            ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AprogramID", Me.grd_1.GetCurrentRowCellValue("ProgramID"))
            ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Aorders", 1) 'Me.grd_1.GetCurrentRowCellValue("ProgramID"))

            ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMEB01_3_R", False, True, GmainsqlParameters)
            ''Dim bytBuffer() As Byte

            ' ''-- 오픈 값의 초기화 
            ''Me.OpenFileDialog1.Reset()

            ' ''-- 이미지의 초기화
            ''If Not Me.picUiImage.Image Is Nothing Then
            ''    Me.picUiImage.Image.Dispose()
            ''    Me.picUiImage.Image = Nothing
            ''End If

            ' ''pic1.Image = mainDataSet.Tables(0).Rows(0).Item(1)
            ' ''txtCatID.Text = mainDataSet.Tables(0).Rows(0).Item(0)
            ''If reciveDataSet.Tables.Count > 0 And reciveDataSet.Tables(0).Rows.Count > 0 Then
            ''    If reciveDataSet.Tables(0).Rows(0).Item("UiImage").GetType.Name = "Byte[]" Then
            ''        bytBuffer = reciveDataSet.Tables(0).Rows(0).Item("UiImage")
            ''        Me.picUiImage.Image = fnGetImage(bytBuffer)
            ''        'Else
            ''        '    PictureBox1.Image.Dispose()
            ''        '    PictureBox1.Image = Nothing
            ''    End If
            ''End If

            ''GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            ''reciveDataSet = Nothing

            ''WebBrowser1.Url("http://220.64.7.51/help/help.aspx?ProgramID=ADC102")

            Dim strHtml As String = ""
            strHtml = strHtml & vbCrLf & "<script language='javascript'>"
            strHtml = strHtml & vbCrLf & "<!--"
            strHtml = strHtml & vbCrLf & "    function plainImageView()"
            strHtml = strHtml & vbCrLf & "    {"
            strHtml = strHtml & vbCrLf & "        window.open('http://220.64.7.51/help/UiImage/" & Me.grd_1.GetCurrentRowCellValue("SystemDivision").ToString() & "/" & Me.grd_1.GetCurrentRowCellValue("ProgramID").ToString() & ".jpg', '확대보기', 'width=1024, height=768, directories=no, location=no, menubar=no, scrollbars=yes, status=no, toolbar=no, resizable=1, left=2,top=2');"
            strHtml = strHtml & vbCrLf & "    }"
            strHtml = strHtml & vbCrLf & "-->"
            strHtml = strHtml & vbCrLf & "</script>"

            strHtml = strHtml & vbCrLf & "<table width='100%' aliign='center' border='0' bgcolor=#FFFFFF cellspacing='0' cellpadding='0'>"
            strHtml = strHtml & vbCrLf & "  <tr align='center'> <td valign='top'>"
            strHtml = strHtml & vbCrLf & "       <a href='javascript:plainImageView();' onFocus='this.blur()'><img src='http://220.64.7.51/help/UiImage/" & Me.grd_1.GetCurrentRowCellValue("SystemDivision").ToString() & "/" & Me.grd_1.GetCurrentRowCellValue("ProgramID").ToString() & ".jpg' width='400' height='280' border='0'></a> </td> "
            strHtml = strHtml & vbCrLf & "  </tr>"
            strHtml = strHtml & vbCrLf & "</table>"

            With WebBrowser1
                .DocumentText = strHtml
                '' .Navigate("http://220.64.7.51/help/UiImage/AD/ADC102.jpg")
            End With


            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
        End Sub

        Private Function fnGetImage(ByVal bytBuffer() As Byte) As Image

            Try
                ' 이미지를 임시 메모리에 저장한다.
                GmainCommonFunction.setImage(bytBuffer)
                ' 저장된 이미지를 bmp object로 변환하여 반환한다.
                fnGetImage = GmainCommonFunction.getImage()

            Catch ex As Exception
                Throw ex
            End Try

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
            'Dim cnnSQL As SqlClient.SqlConnection
            'Dim cmdSQL As SqlClient.SqlCommand
            'Dim intRows As Integer

            'cnnSQL = New SqlClient.SqlConnection()

            'Try
            '    cnnSQL.ConnectionString = "" ''DAT.SqlConnectionString.SqlConnectionStringText()
            '    cnnSQL.Open()

            '    cmdSQL = New SqlClient.SqlCommand()
            '    cmdSQL.Connection = cnnSQL
            '    cmdSQL.CommandType = CommandType.StoredProcedure
            '    cmdSQL.CommandText = "SMEB02_3_CUD"

            '    'bytBuffer.SetValue(PictureBox1.Image, 0)
            '    cmdSQL.Parameters.Add("@ProgramID", SqlDbType.NVarChar, 10, "UiID").Value = txtProgramID.Text.Trim()
            '    cmdSQL.Parameters.Add("@Orders", SqlDbType.NVarChar, 5, "Orders").Value = "1"    'txtUiID.Text.Trim()
            '    cmdSQL.Parameters.Add("@UiImage", SqlDbType.Image).Value = bytBuffer

            '    intRows = cmdSQL.ExecuteNonQuery
            '    cnnSQL.Close()

            '    MessageBox.Show("이미지가 저장 되었습니다.", "추가", MessageBoxButtons.OK, MessageBoxIcon.Information)


            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhotoFilePath", bytBuffer)   '주민번호

            Try
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ProgramID", txtProgramID.Text.Trim())
                    .SetSqlParameter(GmainsqlParameters, "@Orders", "1")
                    .SetSqlParameter(GmainsqlParameters, "@UiImage", bytBuffer)
                    GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMEB02_3_CUD", True, False, GmainsqlParameters)
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

            If Trim(Me.txtUiID.TextValue).Length > 0 Then
                GrecordProcessMode = 2
            Else
                GrecordProcessMode = 1
            End If

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@UiID", Me.txtProgramID.TextValue) 'UiID
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@UiName", Me.txtProgramName.TextValue) 'UiName
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@UiDescription", Me.txtUiDescription.TextValue) 'UiDescription
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@CreateYesOrNo", Me.chkCreateYesOrNo.TextValue) '생성
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RequestYesOrNo", Me.chkRequestYesOrNo.TextValue) '조회
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@UpdateYesOrNo", Me.chkUpdateYesOrNo.TextValue) '수정
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@DeleteYesOrNo", Me.chkDeleteYesOrNo.TextValue) '삭제
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@PrintYesOrNo", Me.chkPrintYesOrNo.TextValue) '출력
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Terms", Me.txtTerms.TextValue) '처리 주기
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@SkillExplanation", Me.txtSkillExplanation.TextValue) '사용 방법
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@DictionaryManagement", Me.txtDictionaryManagement.TextValue) '사전 처리
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AfterFactManagement", Me.txtAfterFactManagement.TextValue) '사후 처리
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@PreconditionItem", Me.txtPreconditionItem.TextValue) '필수 항목
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AttentionItem", Me.txtAttentionItem.TextValue) '주의 사항
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMEB01_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)
        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@UiID", Me.txtProgramID.TextValue) 'UiID
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@UiName", Me.txtProgramName.TextValue) 'UiName
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@UiDescription", Me.txtUiDescription.TextValue) 'UiDescription
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@CreateYesOrNo", Me.chkCreateYesOrNo.TextValue) '생성
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RequestYesOrNo", Me.chkRequestYesOrNo.TextValue) '조회
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@UpdateYesOrNo", Me.chkUpdateYesOrNo.TextValue) '수정
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@DeleteYesOrNo", Me.chkDeleteYesOrNo.TextValue) '삭제
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@PrintYesOrNo", Me.chkPrintYesOrNo.TextValue) '출력
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Terms", Me.txtTerms.TextValue) '처리 주기
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@SkillExplanation", Me.txtSkillExplanation.TextValue) '사용 방법
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@DictionaryManagement", Me.txtDictionaryManagement.TextValue) '사전 처리
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AfterFactManagement", Me.txtAfterFactManagement.TextValue) '사후 처리
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@PreconditionItem", Me.txtPreconditionItem.TextValue) '필수 항목
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AttentionItem", Me.txtAttentionItem.TextValue) '주의 사항
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMEB01_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)
        End Sub

    End Class

End Namespace
