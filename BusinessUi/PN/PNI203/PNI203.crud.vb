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

    Partial Class PNI203

        ''' <summary>
        ''' 함수명 : NewData 
        ''' 기  능 : 신규 
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()

            GmainCommonFunction.ControlNewData(Me, Me.picIo_1)

            Me.dtpClosingYearMonths.TextValue = System.DateTime.Now
            Me.dtpClosingDt.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")
            Me.cboClosingType.TextValue = "02"    '' 청구 마감
            cboClosingType.Enabled = False

            Me.RequestData()

        End Sub
        ''' <summary>
        ''' 함수명 : RequestData
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AClosingType", Me.cboClosingType.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "GetMaxCloseDate", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        '====================================================================================================
        Public Function GetCloseDate(Optional ByVal AprocessMessage As Boolean = True) As Boolean

            Return True
            'GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@NextCloseMonth", Me.dtpClosingYearMonths.TextValue)
            'Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI203_R", False, True, GmainsqlParameters)

            'Dim CloseDateCount As String = reciveDataSet.Tables(0).Rows(0).Item("CloseDateCount").ToString

            'reciveDataSet = Nothing

            'If CloseDateCount = "0" Then
            '    Return True
            'Else
            '    Return False
            'End If

            'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        End Function


        '====================================================================================================
        Public Sub SaveData()
            Dim message As String = Me.dtpNextClosingYearMonths.TextValue.Substring(0, 4) & "년 " & Me.dtpNextClosingYearMonths.TextValue.Substring(4, 2) & "월"
            If MsgBox(message & vbCrLf & "마감 처리 하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then
                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "1")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingYearMonths", Me.dtpNextClosingYearMonths.TextValue)  ' 마감 시는 마감 할 년월
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingType", Me.cboClosingType.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingMode", "1")  '' '' 1:마감처리 , 2: 마감취소
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI203_CUD", True, False, GmainsqlParameters)

                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                    GmainCommonFunction.GRequestDataNumber = 1
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            Dim message As String = Me.dtpClosingYearMonths.TextValue.Substring(0, 4) & "년 " & Me.dtpClosingYearMonths.TextValue.Substring(4, 2) & "월"
            If MsgBox(message & vbCrLf & "마감 취소 하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "3")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingYearMonths", Me.dtpClosingYearMonths.TextValue)  '마감 취소 시는 마감되어 있는 년월
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingType", Me.cboClosingType.TextValue)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AClosingMode", "2")  '' '' 1:마감처리 , 2: 마감취소
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI203_CUD", True, False, GmainsqlParameters)

                GmainCommonFunction.GRequestDataNumber = 1
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                'MessageBox.Show("데이타가 삭제 되었습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Sub

    End Class

End Namespace
