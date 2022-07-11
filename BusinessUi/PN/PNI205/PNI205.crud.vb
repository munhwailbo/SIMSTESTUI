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

    Partial Class PNI205

        ''' <summary>
        ''' 함수명 : NewData 
        ''' 기  능 : 신규 
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()

            If grd_3.Focused = False Then

                '' ' 마스터 내용 초기화
                GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
                Me.dtpTaxAccPublishDt.TextValue = DateTime.Now()
                Me.txtSeriesNum.TextValue = ""

                grd_3.Rows = grd_3.FixedRows
            End If

            '' ''  그리드 초기화 내용
            If Me.grd_3.Rows - Me.grd_3.FixedRows > 4 Then Exit Sub

            lblRecordState.Text = "신규"
            Me.grd_3.AddRow()
            Me.grd_3.set_TextMatrix(grd_3.Rows - 1, Me.grd_3.get_ColIndex("SeriesNum"), Me.grd_1.GetCurrentRowCellValue("SeriesNum"))
            Me.grd_3.set_TextMatrix(grd_3.Rows - 1, Me.grd_3.get_ColIndex("Orders"), Me.grd_3.Rows - Me.grd_3.FixedRows)

        End Sub
        ''' <summary>
        ''' 함수명 : RequestData
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt", Me.dtpTaxAccPublishDt_R1.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt2", Me.dtpTaxAccPublishDt_R2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ASalesDivCd", Me.cboSalesDivCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ASalesCd", Me.popSalesCd_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", "")
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub

        ''' <summary>
        ''' 함수명 : RequestData_2 
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("TaxAccPublishDt")).ToString.Replace("-", ""))
                .SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt2", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("TaxAccPublishDt")).ToString.Replace("-", ""))
                .SetSqlParameter(GmainsqlParameters, "@ASalesDivCd", "")
                .SetSqlParameter(GmainsqlParameters, "@ASalesCd", "")
                .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("SeriesNum")))  'Me.txtSeriesNum.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_R", False, True, GmainsqlParameters)
                If reciveDataSet.Tables.Count > 0 Then
                    lblRecordState.Text = "조회"
                    .SetDataSetToControls(reciveDataSet, Me)
                End If

                '' ''If reciveDataSet.Tables.Count >= 1 And reciveDataSet.Tables(0).Rows.Count >= 1 Then
                '' ''    Me.numSupplyTotalAmt.TextValue = Me.grd_1.GetCurrentRowCellValue("SupplyTotalAmt")
                '' ''    Me.popOldPostNum.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumePostNum")
                '' ''    Me.txtConsumerAddr.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerAddr")
                '' ''    Me.txtConsumerAddr2.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerAddr2")

                '' ''    Me.txtConsumerBusinessNum.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerBusinessNum")
                '' ''    Me.txtConsumerCorpNm.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerCorpNm")
                '' ''    Me.txtConsumerPresidentNm.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerPresidentNm")
                '' ''    Me.txtConsumerBusiStatusCd.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerBusiStatusCd")
                '' ''    Me.txtConsumerBusiTypeCd.TextValue = Me.grd_1.GetCurrentRowCellValue("ConsumerBusiTypeCd")

                '' ''    Me.cboSalesDiviCd.TextValue = Me.grd_1.GetCurrentRowCellValue("SalesDiviCd")
                '' ''    Me.popSalesCd.TextValue = Me.grd_1.GetCurrentRowCellValue("SalesCd").ToString().Split(".")(0)
                '' ''    Me.dtpRcptDate.TextValue = Me.grd_1.GetCurrentRowCellValue("TaxAccPublishDt")
                '' ''    Me.txtSeriesNum.TextValue = Me.grd_1.GetCurrentRowCellValue("SeriesNum")
                '' ''End If

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        ''' <summary>
        ''' 함수명 : RequestData_3 
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ASeriesNum", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("SeriesNum")))  'Me.txtSeriesNum.TextValue)
                ' ''.SetSqlParameter(GmainsqlParameters, "@ASeriesNum", Me.txtSeriesNum.TextValue)  'Me.txtSeriesNum.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_2_R", False, True, GmainsqlParameters)
                Me.grd_3.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub

        Public Sub BusinessDetail()

            Dim ConsumerPostNum As String = vbNullString
            Dim ConsumerAddr As String = vbNullString
            Dim ConsumerAddr2 As String = vbNullString
            Dim ConsumerBusinessNum As String = vbNullString
            Dim ConsumerBusiStatusCd As String = vbNullString
            Dim ConsumerBusiTypeCd As String = vbNullString
            Dim ConsumerCorpNm As String = vbNullString
            Dim ConsumerPresidentNm As String = vbNullString

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ADegree", Me.cboSalesDiviCd.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACompanyCd", Me.popSalesCd.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_3_R", False, True, GmainsqlParameters)
                If reciveDataSet.Tables.Count > 0 Then
                    ConsumerPostNum = reciveDataSet.Tables(0).Rows(0).Item("PostNum")
                    ConsumerAddr = reciveDataSet.Tables(0).Rows(0).Item("Addr1")
                    ConsumerAddr2 = reciveDataSet.Tables(0).Rows(0).Item("Addr2")
                    ConsumerBusinessNum = reciveDataSet.Tables(0).Rows(0).Item("BusinessNum")
                    ConsumerBusiStatusCd = reciveDataSet.Tables(0).Rows(0).Item("BusiStatus")
                    ConsumerBusiTypeCd = reciveDataSet.Tables(0).Rows(0).Item("BusiType")
                    ConsumerCorpNm = reciveDataSet.Tables(0).Rows(0).Item("FirmNm")
                    ConsumerPresidentNm = reciveDataSet.Tables(0).Rows(0).Item("RepresenName")
                End If
                reciveDataSet = Nothing
            End With
            Me.popConsumerPostNum.TextValue = ConsumerPostNum
            Me.txtConsumerAddr.TextValue = ConsumerAddr
            Me.txtConsumerAddr2.TextValue = ConsumerAddr2
            Me.txtConsumerBusinessNum.TextValue = ConsumerBusinessNum
            Me.txtConsumerBusiStatusCd.TextValue = ConsumerBusiStatusCd
            Me.txtConsumerBusiTypeCd.TextValue = ConsumerBusiTypeCd
            Me.txtConsumerCorpNm.TextValue = ConsumerCorpNm
            Me.txtConsumerPresidentNm.TextValue = ConsumerPresidentNm


        End Sub

        '' <summary>
        '' 함수명 : SaveData 
        '' 기  능 : 저장
        '' 작성자 : 
        '' 작성일 : 2008.09.01
        '' 수정자 : 
        ' 수정일 : 
        '' </summary>
        '' <remarks></remarks>
        'Public Sub SaveData()


        '    If grd_3.Focused = True Then
        '        Me.SaveData_2()
        '        Exit Sub

        '    End If
        ''GmainsqlParameters = Nothing
        ''With GmainCommonFunction
        ''    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
        ''    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
        ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_CUD", True, False, GmainsqlParameters)
        ''    .SetAllBusinessUiInitialValue(Me)
        ''    '' .SaveDataMessage(Me)
        ''End With
        ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
        ''    GmainCommonFunction.SaveDataMessage(Me)
        ''Else
        ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        ''End If

        'End Sub

        '====================================================================================================
        Public Sub SaveData()

            Dim strMode As String = ""
            '' ''If grd_3.Focused = True Then
            '' ''    Me.SaveData2()
            '' ''    Exit Sub
            '' ''End If

            'If Me.grd_1.GetCurrentRowCellValue("SeriesNum").Length < 1 Then
            If Me.txtSeriesNum.TextValue = "" Then
                strMode = "1" '신규
            Else
                strMode = "2" '수정
            End If
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", IIf(lblRecordState.Text = "신규", "1", "2"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASeriesNum", IIf((strMode = "1") = True, 0, Me.grd_1.GetCurrentRowCellValue("SeriesNum")))                       ' 지국번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt", Me.dtpTaxAccPublishDt.TextValue)           ' 발행일자
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillGroupNum", Replace(Me.dtpTaxAccPublishDt.TextValue, "-", "").Substring(0, 6))              ' 책번호-권
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillGroupSeriesNum", Replace(Me.dtpTaxAccPublishDt.TextValue, "-", "").Substring(6, 2))        ' 책번호-호 
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillSeriesNum", 0)

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASalesDiviCd", Me.cboSalesDiviCd.TextValue)                          ' 접수일자
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASalesCd", Me.popSalesCd.TextValue)                     ' 총공급금액
            ' 
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWriteDt", Me.dtpTaxAccPublishDt.TextValue)                          ' 접수일자
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASupplyTotalAmt", Me.TxtTotalSupAmt.TextValue)                ' 총공급금액
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusinessNum", Me.txtConsumerBusinessNum.TextValue)   ' 등록번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerCorpNm", Me.txtConsumerCorpNm.TextValue)             ' 상호(법인명)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerPresidentNm", Me.txtConsumerPresidentNm.TextValue)   ' 성명
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerPostNum", Me.popConsumerPostNum.TextValue)                ' 우편번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerAddr", Me.txtConsumerAddr.TextValue)                             ' 주소
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerAddr2", Me.txtConsumerAddr2.TextValue)                            ' 상세주소
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusiStatusCd", Me.txtConsumerBusiStatusCd.TextValue) ' 업태코드
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusiTypeCd", Me.txtConsumerBusiTypeCd.TextValue)      ' 종목코드
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABlankNum", 0)                     ' 공란
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", "")

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(False))
            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
                Me.GmainCommonFunction.GRequestDataNumber = 1
                CallByName(Me, "RequestData", CallType.Method)
                ''''''''''popBaseBranchCd_R.TextValue = popBranchCd.NameText
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub


        '''''''' <summary>
        '''''''' 함수명 : SaveData_2 
        '''''''' 기  능 : 저장
        '''''''' 작성자 : 
        '''''''' 작성일 : 2008.09.01
        '''''''' 수정자 : 
        '''''''' 수정일 : 
        '''''''' </summary>
        '''''''' <remarks></remarks>
        ' '' ''Public Sub SaveData2()

        ' '' ''    GmainsqlParameters = Nothing
        ' '' ''    With GmainCommonFunction
        ' '' ''        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
        ' '' ''        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(False))
        ' '' ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_2_CUD", True, False, GmainsqlParameters)
        ' '' ''        '' .SaveDataMessage(Me)
        ' '' ''    End With
        ' '' ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
        ' '' ''        GmainCommonFunction.SaveDataMessage(Me)
        ' '' ''        Me.picIo_2.Select()
        ' '' ''        Me.RequestData()
        ' '' ''    Else
        ' '' ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        ' '' ''    End If
        ' '' ''    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        ' '' ''End Sub

        ''' <summary>
        ''' 함수명 : DeleteData 
        ''' 기  능 : 삭제
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            If grd_3.Focused = True Then
                Me.DeleteData2()
                Exit Sub
            End If

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                With GmainCommonFunction
                    GmainsqlParameters = Nothing
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASeriesNum", Me.grd_1.GetCurrentRowCellValue("SeriesNum"))                       ' 지국번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATaxAccPublishDt", Me.dtpTaxAccPublishDt.TextValue)           ' 발행일자
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillGroupNum", Replace(Me.dtpTaxAccPublishDt.TextValue, "-", "").Substring(0, 6))              ' 책번호-권
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillGroupSeriesNum", Replace(Me.dtpTaxAccPublishDt.TextValue, "-", "").Substring(6, 2))        ' 책번호-호 
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABillSeriesNum", 0)

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASalesDiviCd", Me.cboSalesDiviCd.TextValue)                          ' 접수일자
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASalesCd", Me.popSalesCd.TextValue)                     ' 총공급금액
                    ' 
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AWriteDt", Me.dtpTaxAccPublishDt.TextValue)                          ' 접수일자
                    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASupplyTotalAmt", Me.TxtTotalSupAmt.TextValue)                ' 총공급금액
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusinessNum", Me.txtConsumerBusinessNum.TextValue)   ' 등록번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerCorpNm", Me.txtConsumerCorpNm.TextValue)             ' 상호(법인명)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerPresidentNm", Me.txtConsumerPresidentNm.TextValue)   ' 성명
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerPostNum", Me.popConsumerPostNum.TextValue)                ' 우편번호
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerAddr", Me.txtConsumerAddr.TextValue)                             ' 주소
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerAddr2", Me.txtConsumerAddr2.TextValue)                            ' 상세주소
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusiStatusCd", Me.txtConsumerBusiStatusCd.TextValue) ' 업태코드
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AConsumerBusiTypeCd", Me.txtConsumerBusiTypeCd.TextValue)      ' 종목코드
                    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABlankNum", 0)                     ' 공란
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ANote", "")

                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_CUD", True, False, GmainsqlParameters)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Me.RequestData()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If


                '    GmainsqlParameters = Nothing
                '    With GmainCommonFunction
                '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
                '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_CUD", True, False, GmainsqlParameters)
                '        .SetAllBusinessUiInitialValue(Me)
                '        '' .SaveDataMessage(Me)
                '    End With
                '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
                '        MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Else
                '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    End If
            End If   '' Result end

        End Sub

        ''' <summary>
        ''' 함수명 : DeleteData_2
        ''' 기  능 : 삭제
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData2()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI205_2_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Me.RequestData_2()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If   '' Result end

        End Sub

        ''' <summary>
        ''' 함수명 : ExportData 
        ''' 기  능 : 출력
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ExportData()

            'Dim AsqlParameters() As SqlParameter = Nothing

            'With GmainCommonFunction
            '    .SetSqlParameter(AsqlParameters, "@AcodeDivisionHangulName", Me.txtBranchNum.TextValue)
            '    .SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            '    'Dim AAAA As String = ""
            '    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            '    Dim AformulaParameters() As SqlParameter = Nothing

            '    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            '    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            '    ' 공통변수의정의가생성시에발생될수있도록유도한다.
            '    .SetExportCrystalDataParameter("PNI205.rpt", "PNI205_R", "", AsqlParameters, AformulaParameters)
            'End With

        End Sub

    End Class

End Namespace
