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

    Partial Class PNJ303

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

            If grd_1.Rows > 1 Then
                Me.grd_2.AddRow()
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CalYearMonths"), Me.grd_1.GetCurrentRowCellValue("DmdYYMM"))
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CouponCorpCd"), Me.grd_1.GetCurrentRowCellValue("CouponCorpCd"))
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CouponCorpNm"), Me.grd_1.GetCurrentRowCellValue("CouponCorpNm"))
                ' ''grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CompanyCd"), Me.grd_1.GetCurrentRowCellValue("CompanyCd"))
                ' ''grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("CompanyNm"), Me.grd_1.GetCurrentRowCellValue("CompanyNm"))
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("DisYearMonths"), IIf(dtpBaseDt_R.TextValue.ToString.Length < 1, "", dtpBaseDt_R.TextValue))
                grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("DisYearMonths2"), IIf(dtpBaseDt_R.TextValue.ToString.Length < 1, "", dtpBaseDt_R.TextValue))
            End If

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
            'Dim sdate As String
            'sdate = dtpBaseYear.TextValue.Substring(0, 4) + "01"

            Dim chkState As String = ""
            If chkDmd1.Checked And chkDmd2.Checked = False Then chkState = "1"
            If chkDmd1.Checked = False And chkDmd2.Checked Then chkState = "2"
            If chkDmd1.Checked And chkDmd2.Checked Then chkState = "3"

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYYMM", Me.dtpBaseDt_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpBaseDt2_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ADmdYMFr", IIf(Me.dtpDmdYMFr.Enabled, Me.dtpDmdYMFr.TextValue, ""))
                .SetSqlParameter(GmainsqlParameters, "@ADmdYMTo", IIf(Me.dtpDmdYMTo.Enabled, Me.dtpDmdYMTo.TextValue, ""))
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.popCouponCorpCd_R.Text)
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", chkState)    '' 1:청구완료만포함,  2:미청구만포함, 3:전체
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        ''' <summary>
        ''' 함수명 : RequestData2
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            'Dim sdate As String
            'sdate = dtpBaseYear.TextValue.Substring(0, 4) + "01"

            If grd_1.Rows <= grd_1.FixedRows Then Exit Sub

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.grd_1.GetCurrentRowCellValue("DmdYYMM"))
                .SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpBaseDt2_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.grd_1.GetCurrentRowCellValue("CouponCorpCd"))
                .SetSqlParameter(GmainsqlParameters, "@ABaseYYMM", Me.dtpBaseDt_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", "1")       '' 1:조회, 2:신규
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_2_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            Call SetSubTotal_2()

        End Sub

        ''' <summary>
        ''' 함수명 : RequestData2
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 :         ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)
            'Dim sdate As String
            'sdate = dtpBaseYear.TextValue.Substring(0, 4) + "01"

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.grd_1.GetCurrentRowCellValue("DmdYYMM"))
                .SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpBaseDt2_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.grd_1.GetCurrentRowCellValue("CouponCorpCd"))
                .SetSqlParameter(GmainsqlParameters, "@ABaseYYMM", Me.dtpBaseDt_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AprocGb", "2")       '' 1:조회, 2:신규
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_2_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            Dim intII As Integer
            For intII = 1 To grd_2.Rows - grd_2.FixedRows
                grd_2.set_TextMatrix(intII, 0, "신규")
                Me.grd_2.SetCellCheck(intII, Me.grd_2.get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
            Next

            Call SetSubTotal_2()
        End Sub

        '그리드 합계행 추가
        Private Sub SetSubTotal_2()
            With Me.grd_2
                If .Rows > .FixedRows Then
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("PaperNum"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SubscriptionAmt"), "합계")
                    ''.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DistributionAmt"), "합계")

                    .set_TextMatrix(.FixedRows, .get_ColIndex("BranchNum"), "합   계")
                    Me.grd_2.FrozenRows = 1
                End If
            End With
        End Sub

        ''' <summary>
        ''' 함수명 : SaveData 
        ''' 기  능 : 저장
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub
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

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ303_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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
            '' '' '' '' ''Dim AsqlParameters() As SqlParameter = Nothing
            '' '' '' '' ''If optExpAmt1.Checked = True Then
            '' '' '' '' ''    With GmainCommonFunction
            '' '' '' '' ''        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
            '' '' '' '' ''        '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            '' '' '' '' ''        'Dim AAAA As String = ""
            '' '' '' '' ''        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            '' '' '' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            '' '' '' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            '' '' '' '' ''        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            '' '' '' '' ''        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            '' '' '' '' ''        .SetExportCrystalDataParameter("PNI201_1_C_R.rpt", "PNI201_1_C_R", "", AsqlParameters, AformulaParameters)
            '' '' '' '' ''    End With

            '' '' '' '' ''ElseIf optExpAmt2.Checked = True Then

            '' '' '' '' ''    With GmainCommonFunction
            '' '' '' '' ''        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
            '' '' '' '' ''        '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            '' '' '' '' ''        'Dim AAAA As String = ""
            '' '' '' '' ''        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            '' '' '' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            '' '' '' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            '' '' '' '' ''        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            '' '' '' '' ''        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            '' '' '' '' ''        .SetExportCrystalDataParameter("PNI201_2_C_R.rpt", "PNI201_2_C_R", "", AsqlParameters, AformulaParameters)
            '' '' '' '' ''    End With
            '' '' '' '' ''ElseIf optExpAmt3.Checked = True Then

            '' '' '' '' ''    With GmainCommonFunction
            '' '' '' '' ''        .SetSqlParameter(AsqlParameters, "@AYYYYMM", Me.dtpBaseYear.TextValue)
            '' '' '' '' ''        '.SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)

            '' '' '' '' ''        'Dim AAAA As String = ""
            '' '' '' '' ''        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            '' '' '' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            '' '' '' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            '' '' '' '' ''        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            '' '' '' '' ''        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            '' '' '' '' ''        .SetExportCrystalDataParameter("PNI201_3_C_R.rpt", "PNI201_3_C_R", "", AsqlParameters, AformulaParameters)
            '' '' '' '' ''    End With
            '' '' '' '' ''End If

        End Sub

    End Class

End Namespace
