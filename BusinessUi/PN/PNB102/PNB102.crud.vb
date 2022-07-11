
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

    Partial Class PNB102

        '====================================================================================================
        Public Sub NewData()

            lblRecordState.Text = "신규"
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2_3)

            If popBranchCd_R.TextValue.ToString().Length > 0 Then
                With Me.grd_1
                    .AddRow()
                    For intII As Integer = .Rows - 1 To .FixedRows Step -1
                        If intII = .FixedRows Then
                            For intJJ As Integer = 1 To .Cols - 1
                                .set_TextMatrix(intII, intJJ, "")
                            Next
                            .set_TextMatrix(intII, .get_ColIndex("BranchCd"), Me.popBranchCd_R.TextValue)
                            .set_TextMatrix(intII, .get_ColIndex("BranchNm"), Me.popBranchCd_R.NameText)
                            .set_TextMatrix(intII, .get_ColIndex("TransferDate"), "신규")
                        Else
                            For intJJ As Integer = 1 To .Cols - 1
                                .set_TextMatrix(intII, intJJ, .get_TextMatrix(intII - 1, intJJ))
                            Next
                        End If
                    Next

                    '' '' '' .set_TextMatrix(.Rows - 1, .get_ColIndex("BranchCd"), .get_TextMatrix(.Rows - 2, .get_ColIndex("BranchCd")))
                    ' ''.set_TextMatrix(.Rows - 1, .get_ColIndex("BranchCd"), Me.popBranchCd_R.TextValue)
                    ' ''.set_TextMatrix(.Rows - 1, .get_ColIndex("TransferDate"), "신규")
                End With
                Me.RequestData_2()
            End If

        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            If popBranchCd_R.TextValue.ToString().Length < 1 Then
                MsgBox("지국코드를 입력 하세요", MsgBoxStyle.Information, "확인하세요")
                popBranchCd_R.Focus()
                Exit Sub
            End If

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseDt", Me.dtpBaseDt.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))    '' 지국번호
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferDate", Me.grd_1.GetCurrentRowCellValue("TransferDate"))  '' 이전일자

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_2_R", False, True, GmainsqlParameters)
            If reciveDataSet.Tables.Count > 0 Then
                If Me.grd_1.GetCurrentRowCellValue("TransferDate") = "신규" Then
                    lblRecordState.Text = "신규"
                Else
                    lblRecordState.Text = "조회"
                End If
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            End If

            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        Public Sub RequestData2(Optional ByVal AprocessMessage As Boolean = True)

            '' ''GmainsqlParameters = Nothing

            '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))    '' 지국번호
            '' ''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferDate", Me.grd_1.GetCurrentRowCellValue("TransferDate"))  '' 이전일자

            '' ''Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_2_R", False, True, GmainsqlParameters)
            '' ''If reciveDataSet.Tables.Count > 0 Then
            '' ''    lblRecordState.Text = "조회"
            '' ''    GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            '' ''End If

            '' ''reciveDataSet = Nothing

            '' ''GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            '' ''If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub


        '' ''Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)
        '' ''    GmainsqlParameters = Nothing

        '' ''    With GmainCommonFunction
        '' ''        .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_2.GetCurrentRowCellValue("BranchCd"))
        '' ''        Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC101_3_R", False, True, GmainsqlParameters)
        '' ''        GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
        '' ''        reciveDataSet = Nothing
        '' ''        .SetAllBusinessUiInitialValue(Me)
        '' ''        If AprocessMessage = True Then .RequestDataMessage(Me)
        '' ''        GrecordProcessMode = "2"
        '' ''    End With

        '' ''End Sub

        '====================================================================================================
        Public Sub SaveData()

            'If Validation() = True Then

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", IIf(lblRecordState.Text = "신규", "1", "2"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", popBranchCd.TextValue)             '' '' 지국코드
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferDate", dtpTransferDate.TextValue)     '' '' 이전일자	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferNum", numTransferNum.TextValue)       '' '' 이전횟수	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProcessDivCd", popProcessDivCd.TextValue)     '' '' 처리구분코드	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractDivCd", popContractDivCd.TextValue)   '' '' 계약구분코드	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerNm", txtOwnerNm.TextValue)               '' '' 소유주명	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerPhoneNum", txtOwnerPhoneNum.TextValue)   '' '' 건물주 연락처	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APostNum", popPostNum.TextValue)               '' '' 지국우편번호	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr1", txtAddr1.TextValue)                   '' '' 지국주소	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr2", txtAddr2.TextValue)                   '' '' 지국주소	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASiteArea", numSiteArea.TextValue)             '' '' 대지평수	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABuildingArea", numBuildingArea.TextValue)     '' '' 건물평수	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUseArea", numUseArea.TextValue)               '' '' 사용평수	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFloor", txtFloor.TextValue)                   '' '' 층구분	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ALimitedItem", txtLimitedItem.TextValue)       '' '' 제한물건	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AObligation", txtObligation.TextValue)         '' '' 채권확보	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractStDt", dtpContractStDt.TextValue)      '' '' 계약시작일	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractEdDt", dtpContractEdDt.TextValue)      '' '' 계약시작일	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityOwnerNm", txtSecurityOwnerNm.TextValue)    '' '' 대물담보-소유자명	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityPostNum", popSecurityPostNum.TextValue)    '' '' 대물담보-우편번호	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityAddr1", txtSecurityAddr1.TextValue)        '' '' 대물담보-주소	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityAddr2", txtSecurityAddr2.TextValue)        '' '' 대물담보-주소	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecuritySiteArea", numSecuritySiteArea.TextValue)  '' '' 대물담보-대지평수	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityBuildingArea", numSecurityBuildingArea.TextValue)    '' '' 대물담보-건물평수	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityLimitedItem", txtSecurityLimitedItem.TextValue)      '' '' 대물담보-제한물건
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARentDepositAmt", numRentDepositAmt.TextValue)      '' '' 임차보증금	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARentAmt", numRentAmt.TextValue)                    '' '' 임차료	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeferPaymentYn", chkdeferPaymentYn.Checked)        '' '' 월세보류여부	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AVatYn", chkVatYn.Checked)                          '' '' VAT포함여부	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABankCd", popBankCd.TextValue)                      '' '' 은행구분코드	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAccountNum", txtAccountNum.TextValue)              '' '' 계좌번호	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositorNm", txtDepositorNm.TextValue)            '' '' 예금주명	
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerRelation", txtOwnerRelation.TextValue)        '' '' 건물주와의관계	
            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", popBranchCd.TextValue)             '' '' 지국코드
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferDate", dtpTransferDate.TextValue)     '' '' 이전일자	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ATransferNum", numTransferNum.TextValue)       '' '' 이전횟수	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AProcessDivCd", popProcessDivCd.TextValue)     '' '' 처리구분코드	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractDivCd", popContractDivCd.TextValue)   '' '' 계약구분코드	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerNm", txtOwnerNm.TextValue)               '' '' 소유주명	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerPhoneNum", txtOwnerPhoneNum.TextValue)   '' '' 건물주 연락처	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APostNum", popPostNum.TextValue)               '' '' 지국우편번호	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr1", txtAddr1.TextValue)                   '' '' 지국주소	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddr2", txtAddr2.TextValue)                   '' '' 지국주소	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASiteArea", numSiteArea.TextValue)             '' '' 대지평수	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABuildingArea", numBuildingArea.TextValue)     '' '' 건물평수	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AUseArea", numUseArea.TextValue)               '' '' 사용평수	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AFloor", txtFloor.TextValue)                   '' '' 층구분	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ALimitedItem", txtLimitedItem.TextValue)       '' '' 제한물건	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AObligation", txtObligation.TextValue)         '' '' 채권확보	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractStDt", dtpContractStDt.TextValue)      '' '' 계약시작일	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContractEdDt", dtpContractEdDt.TextValue)      '' '' 계약시작일	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityOwnerNm", txtSecurityOwnerNm.TextValue)    '' '' 대물담보-소유자명	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityPostNum", popSecurityPostNum.TextValue)    '' '' 대물담보-우편번호	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityAddr1", txtSecurityAddr1.TextValue)        '' '' 대물담보-주소	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityAddr2", txtSecurityAddr2.TextValue)        '' '' 대물담보-주소	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecuritySiteArea", numSecuritySiteArea.TextValue)  '' '' 대물담보-대지평수	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityBuildingArea", numSecurityBuildingArea.TextValue)    '' '' 대물담보-건물평수	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASecurityLimitedItem", txtSecurityLimitedItem.TextValue)      '' '' 대물담보-제한물건
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARentDepositAmt", numRentDepositAmt.TextValue)      '' '' 임차보증금	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ARentAmt", numRentAmt.TextValue)                    '' '' 임차료	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeferPaymentYn", chkdeferPaymentYn.Checked)        '' '' 월세보류여부	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AVatYn", chkVatYn.Checked)                          '' '' VAT포함여부	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABankCd", popBankCd.TextValue)                      '' '' 은행구분코드	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAccountNum", txtAccountNum.TextValue)              '' '' 계좌번호	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADepositorNm", txtDepositorNm.TextValue)            '' '' 예금주명	
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOwnerRelation", txtOwnerRelation.TextValue)        '' '' 건물주와의관계	

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB102_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.DeleteDataMessage(Me)
                    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    GmainExecuteDbCommand.GerrorNumber = 1
                End If

            End If

        End Sub


        Public Sub ExportData()

            Dim AsqlParameters() As SqlParameter = Nothing
            If optMonAmtList.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNB102_1_C_R.rpt", "PNB102_1_C_R", "", AsqlParameters, AformulaParameters)
                End With


            ElseIf optMonthTotal.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNB102_2_C_R.rpt", "PNB102_2_C_R", "", AsqlParameters, AformulaParameters)
                End With

            ElseIf optMonthDepositBack.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNB102_3_C_R.rpt", "PNB102_3_C_R", "", AsqlParameters, AformulaParameters)
                End With
            ElseIf optBranchHp.Checked = True Then
                With GmainCommonFunction
                    .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd_R.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNB102_4_C_R.rpt", "PNB102_4_C_R", "", AsqlParameters, AformulaParameters)
                End With
            ElseIf optsend.Checked = True Then
                With GmainCommonFunction
                    '.SetSqlParameter(AsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)
                    .SetSqlParameter(AsqlParameters, "@AYYYYMMDD ", Me.dtpBaseDt.TextValue)

                    'Dim AAAA As String = ""
                    'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                    Dim AformulaParameters() As SqlParameter = Nothing

                    'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                    .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                    ' 공통변수의정의가생성시에발생될수있도록유도한다.
                    .SetExportCrystalDataParameter("PNB302_C_R.rpt", "PNB302_C_R", "", AsqlParameters, AformulaParameters)
                End With
            End If


        End Sub
        Public Function Validation() As Boolean

            'Validation = False

            ''With Me.grd_2
            ''For inti As Integer = .FixedRows To .Rows - 1

            ''    If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
            ''        If Trim(.get_TextMatrix(inti, .get_ColIndex("ColumnName"))).Length < 1 Then
            ''            MessageBox.Show("컬럼 물리명을 반드시 입력해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ''            Exit Function
            ''        End If

            ''        If .get_TextMatrix(inti, .get_ColIndex("ColLen")) <> "" Then
            ''            .set_TextMatrix(inti, .get_ColIndex("ColLen"), "(" & .get_TextMatrix(inti, .get_ColIndex("ColLen")) & ")")
            ''        End If

            ''    End If
            ''Next inti
            ''End With

            'Validation = True

        End Function


    End Class

End Namespace
