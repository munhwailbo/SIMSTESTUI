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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN
    Partial Class PNB101

        '====================================================================================================
        Public Sub NewData()
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_1)
            Me.txtBranchCd.TextValue = ""
            Me.txtBranchNm.TextValue = ""
            Me.cboChargeTypeCd2.TextValue = ""
            Me.popChargeEmpNum_2.TextValue = ""
            Me.txtNewGubn.TextValue = "1"
        End Sub

        '====================================================================================================
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", "")
                .SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm_2.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AChargeTypeCd", Me.cboChargeTypeCd.Text)
                .SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", Me.popChargeEmpNum.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AcloseCheck", Me.chkCloseCheck.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AOpenCheck", Me.chkOpenCheck.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

            End With

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .ControlNewData(Me, Me.picIo_2)
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                ''''  아래 처리 조건은 무의미 
                .SetSqlParameter(GmainsqlParameters, "@ABranchNm", "")  ''Me.grd_1.GetCurrentRowCellValue("BranchNm"))
                .SetSqlParameter(GmainsqlParameters, "@AChargeTypeCd", "")  ''Me.grd_1.GetCurrentRowCellValue("ChargeTypeCd"))
                .SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", "")  ''Me.grd_1.GetCurrentRowCellValue("ChargeEmpNum").Split(".")(0))
                .SetSqlParameter(GmainsqlParameters, "@AcloseCheck", "0") '' Me.chkCloseCheck.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AOpenCheck", Me.chkOpenCheck.TextValue)
            End With

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_R", False, True, GmainsqlParameters)

            'GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

            If IsNothing(reciveDataSet) = False Then
                Me.txtBranchCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchCd")
                Me.txtBranchNm.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BranchNm")
                Me.cboChargeTypeCd2.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ChargeTypeCd")
                Me.popChargeEmpNum_2.TextValue = reciveDataSet.Tables(0).Rows(0).Item("ChargeEmpNum").ToString().Split(".")(0)
                'Me.txtNewGubn.TextValue = reciveDataSet.Tables(0).Rows(0).Item("NewGubn")

                Me.txtBizArea.TextValue = reciveDataSet.Tables(0).Rows(0).Item("BizArea") ' 관할지역
                Me.txtMkTargetGroup.TextValue = reciveDataSet.Tables(0).Rows(0).Item("MkTargetGroup") ' 주요구독대상처
                Me.dtpOpenDate.TextValue = reciveDataSet.Tables(0).Rows(0).Item("OpenDate") ' 개국일자
                Me.dtpCloseDate.TextValue = reciveDataSet.Tables(0).Rows(0).Item("CloseDate") ' 폐국일자
                Me.txtCloseRemark.TextValue = reciveDataSet.Tables(0).Rows(0).Item("CloseRemark") ' 폐국사유
            End If
            reciveDataSet = Nothing

            Call RequestData_3()

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)

        End Sub

        '====================================================================================================
        Public Sub RequestData_3(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            With GmainCommonFunction

                '---grd_3------------------------------------------------------------------------------------------------------------------------
                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_2_R", False, True, GmainsqlParameters)
                Me.grd_3.Rows = Me.grd_3.FixedRows

                Me.grd_3.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_4------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_3_R", False, True, GmainsqlParameters)

                Me.grd_4.Rows = Me.grd_4.FixedRows
                Me.grd_4.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_5------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_4_R", False, True, GmainsqlParameters)

                Me.grd_5.Rows = Me.grd_5.FixedRows
                Me.grd_5.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_6------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_5_R", False, True, GmainsqlParameters)

                Me.grd_6.Rows = Me.grd_6.FixedRows
                Me.grd_6.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

                '---grd_7------------------------------------------------------------------------------------------------------------------------
                GmainsqlParameters = Nothing

                .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.grd_1.GetCurrentRowCellValue("BranchCd"))
                reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_6_R", False, True, GmainsqlParameters)

                Me.grd_7.Rows = Me.grd_7.FixedRows
                Me.grd_7.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
                '---grd_7------------------------------------------------------------------------------------------------------------------------
            End With

        End Sub

        '====================================================================================================
        Public Sub SaveData()

            Dim strMode As String = "1"
            If Me.txtNewGubn.TextValue <> "" Then
                If grd_1.GetCurrentRowCellValue("BranchCd").Trim() = Me.txtBranchCd.TextValue Then
                    strMode = "2" '수정
                Else
                    strMode = "1" '입력
                End If

            Else
                If grd_1.GetCurrentRowCellValue("BranchCd").Trim() = Me.txtBranchCd.TextValue Then strMode = "2" '수정 
            End If


            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", strMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.txtBranchCd.TextValue)   '지국코드
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)   '지국명
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeTypeCd", Me.cboChargeTypeCd2.TextValue)   '담당유형
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", Me.popChargeEmpNum_2.TextValue)  '담당사번
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABizArea", Me.txtBizArea.TextValue) ' 관할지역
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMkTargetGroup", Me.txtMkTargetGroup.TextValue) ' 주요구독대상처
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOpenDate", Me.dtpOpenDate.TextValue) ' 개국일자
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACloseDate", Me.dtpCloseDate.TextValue) ' 폐국일자
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACloseRemark", Me.txtCloseRemark.TextValue) ' 폐국사유

            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_CUD", True, False, GmainsqlParameters)

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

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", 3)
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.txtBranchCd.TextValue)   ' 지국코드
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)   ' 지국 명
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeTypeCd", Me.cboChargeTypeCd2.TextValue)    '담당 유형
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum", Me.popChargeEmpNum_2.TextValue)   '담당사번
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABizArea", Me.txtBizArea.TextValue) ' 관할지역
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AMkTargetGroup", Me.txtMkTargetGroup.TextValue) ' 주요구독대상처
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOpenDate", Me.dtpOpenDate.TextValue) ' 개국일자
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACloseDate", Me.dtpCloseDate.TextValue) ' 폐국일자
                    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACloseRemark", Me.txtCloseRemark.TextValue) ' 폐국사유

                    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APrintRegionCd", Me.cboChargeTypeCd2.TextValue)
                    'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchRegionCd", Me.popChargeEmpNum_2.TextValue)

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_CUD", True, False, GmainsqlParameters)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If   '' Result end

        End Sub

        '====================================================================================================
        Public Sub SaveData_2()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_2_CUD", True, False, GmainsqlParameters)
            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_2()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_3.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_2_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_3()

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_4.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_3_CUD", True, False, GmainsqlParameters)
            End With

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_3()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_4.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_3_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_4()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_5.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_4_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_4()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_5.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_4_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_5()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_6.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_5_CUD", True, False, GmainsqlParameters)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_5()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_6.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_5_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        '====================================================================================================
        Public Sub SaveData_6()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_7.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_6_CUD", True, False, GmainsqlParameters)

            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                Call RequestData_3()
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData_6()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing

                With GmainCommonFunction

                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_7.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_6_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)

                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call RequestData_3()
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Sub

        ''====================================================================================================
        'Public Sub DeleteData_7()

        '    Dim result As DialogResult
        '    result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        '    If result = DialogResult.OK Then   '' Result Start
        '        GmainsqlParameters = Nothing
        '        With GmainCommonFunction
        '            .SetSqlParameter(GmainsqlParameters, "@ABranchCd", "")  ''txtBranchCd.textvalue)   --(10)지국코드
        '            .SetSqlParameter(GmainsqlParameters, "@ABranchNm", "")  ''txtBranchNm.textvalue)   --(20)지국명
        '            .SetSqlParameter(GmainsqlParameters, "@APrintRegionCd", "")  ''txtPrintRegionCd.textvalue)   --(70)인쇄지역코드
        '            .SetSqlParameter(GmainsqlParameters, "@ABranchRegionCd", "")  ''txtBranchRegionCd.textvalue)   --(80)지국지역코드
        '            .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
        '            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB101_7_CUD", True, False, GmainsqlParameters)
        '            .SetAllBusinessUiInitialValue(Me)
        '            '' .SaveDataMessage(Me)
        '        End With
        '        If GmainExecuteDbCommand.GerrorNumber = 0 Then
        '            MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '        Else
        '            MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '        End If
        '    End If   '' Result end

        'End Sub

    End Class

End Namespace
