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

    Partial Class PNI311

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
            GmainCommonFunction.ControlNewData(Me, Me.picIo_1)
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

            ' ''GmainsqlParameters = Nothing
            ' ''With GmainCommonFunction
            ' ''    .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", Me.dtpYYYYMM.TextValue)
            ' ''    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI311_R", False, True, GmainsqlParameters)
            ' ''    GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
            ' ''    reciveDataSet = Nothing
            ' ''    .SetAllBusinessUiInitialValue(Me)
            ' ''    If AprocessMessage = True Then .RequestDataMessage(Me)
            ' ''End With

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
                .SetSqlParameter(GmainsqlParameters, "@ArecordProcessMode", "1")  '' 1:처리, 3:삭제
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", dtpYYYYMM.TextValue)   '' 지대년월
                .SetSqlParameter(GmainsqlParameters, "@ATransferDt1", dtpTransferDt1.TextValue)   '' 대체일자(From)
                .SetSqlParameter(GmainsqlParameters, "@ATransferDt2", dtpTransferDt2.TextValue)   '' 대체일자(To)

                .SetSqlParameter(GmainsqlParameters, "@AchkExp11", Me.chkExp11.Checked)   '' 본사수금구독료 대체 여부 
                .SetSqlParameter(GmainsqlParameters, "@AchkExp21", Me.chkExp21.Checked)   '' 지국확장비 대체 여부     
                .SetSqlParameter(GmainsqlParameters, "@AchkExp31", Me.chkExp31.Checked)   '' 목표지원비 대체 여부     
                .SetSqlParameter(GmainsqlParameters, "@AchkExp32", Me.chkExp32.Checked)   '' 조직지원비 대체 여부     
                .SetSqlParameter(GmainsqlParameters, "@AchkExp33", Me.chkExp33.Checked)   '' 기증지 대체 여부         
                .SetSqlParameter(GmainsqlParameters, "@AchkExp34", Me.chkExp34.Checked)   '' 이사독자 대체 여부       
                .SetSqlParameter(GmainsqlParameters, "@AchkExp41", Me.chkExp41.Checked)   '' 배달확인증 대체 여부     
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI311_CUD", True, False, GmainsqlParameters)
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
                    .SetSqlParameter(GmainsqlParameters, "@ArecordProcessMode", "3")  '' 1:처리, 3:삭제
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                    .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", dtpYYYYMM.TextValue)   '' 지대년월
                    .SetSqlParameter(GmainsqlParameters, "@ATransferDt1", dtpTransferDt1.TextValue)   '' 대체일자(From)
                    .SetSqlParameter(GmainsqlParameters, "@ATransferDt2", dtpTransferDt2.TextValue)   '' 대체일자(To)

                    .SetSqlParameter(GmainsqlParameters, "@AchkExp11", Me.chkExp11.Checked)   '' 본사수금구독료 대체 여부 
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp21", Me.chkExp21.Checked)   '' 지국확장비 대체 여부     
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp31", Me.chkExp31.Checked)   '' 목표지원비 대체 여부     
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp32", Me.chkExp32.Checked)   '' 조직지원비 대체 여부     
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp33", Me.chkExp33.Checked)   '' 기증지 대체 여부         
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp34", Me.chkExp34.Checked)   '' 이사독자 대체 여부       
                    .SetSqlParameter(GmainsqlParameters, "@AchkExp41", Me.chkExp41.Checked)   '' 배달확인증 대체 여부     
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI311_CUD", True, False, GmainsqlParameters)
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

        '''' <summary>
        '''' 함수명 : ExportData 
        '''' 기  능 : 출력
        '''' 작성자 : 
        '''' 작성일 : 2008.09.01
        '''' 수정자 : 
        '''' 수정일 : 
        '''' </summary>
        '''' <remarks></remarks>
        Public Sub ExportData()

            ' '' ''Dim AsqlParameters() As SqlParameter = Nothing
            ' '' ''If optExpAmt1.Checked = True Then
            ' '' ''    With GmainCommonFunction
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpYYYYMM.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABranchNm", Me.popBranchCd_R.TextValue)
            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            ' '' ''        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            ' '' ''        .SetExportCrystalDataParameter("PNI303_1_C_R.rpt", "PNI303_1_C_R", "", AsqlParameters, AformulaParameters)
            ' '' ''    End With
            ' '' ''ElseIf optExpAmt2.Checked = True Then

            ' '' ''    With GmainCommonFunction
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpYYYYMM.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@AChargeEmpNum_R", Me.txtChargeEmpNum_R.TextValue)
            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            ' '' ''        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            ' '' ''        .SetExportCrystalDataParameter("PNI303_2_C_R.rpt", "PNI303_2_C_R", "", AsqlParameters, AformulaParameters)
            ' '' ''    End With
            ' '' ''ElseIf optExpAmt3.Checked = True Then

            ' '' ''    With GmainCommonFunction
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABaseYearMonths", Me.dtpYYYYMM.TextValue)
            ' '' ''        .SetSqlParameter(AsqlParameters, "@ABranchNum", Me.popBranchCd_R.TextValue)
            ' '' ''        'Dim AAAA As String = ""
            ' '' ''        'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

            ' '' ''        Dim AformulaParameters() As SqlParameter = Nothing

            ' '' ''        'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
            ' '' ''        .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

            ' '' ''        ' 공통변수의정의가생성시에발생될수있도록유도한다.
            ' '' ''        .SetExportCrystalDataParameter("PNI303_3_C_R.rpt", "PNI303_3_C_R", "", AsqlParameters, AformulaParameters)
            ' '' ''    End With
            ' '' ''End If
        End Sub
    End Class

End Namespace
