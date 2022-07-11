Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic
Imports System.Configuration
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Imports System.Reflection

Namespace ubiLease.UI.MainUi
    Partial Class frmMainUi
       

        ' 메뉴 비활성화
        '화면별 사용자 저장/삭제 권한관리 관련 수정부분
        Public Sub ControlDisable()
            'If Me.GmainBusinessFunction.GetValue("로그인 ID") = "000001" Then
            '    Exit Sub
            'End If

            For i As Integer = 0 To tlbMain.Items.Count - 1
                If tlbMain.Items(i).Name = "btnExit" Then
                    tlbMain.Items(i).Enabled = True
                Else
                    tlbMain.Items(i).Enabled = False
                End If
            Next

            Me.mnuRequestData.Enabled = False
            Me.mnuNewData.Enabled = False
            Me.mnuSaveData.Enabled = False
            Me.mnuDeleteData.Enabled = False
            Me.mnuExportDataToExcel.Enabled = False
            Me.mnuExportDataToPreview.Enabled = False
            Me.mnuExportDataToPrinter.Enabled = False
            Me.mnuHelp.Enabled = False
        End Sub


        ' 컨트롤 활성 화
        Public Sub IsControlActivated(ByVal programId As String, ByVal systemDivision As String)
            sttMainLableClear()
            Dim GmainsqlParameters As SqlParameter()
            '나중에 삭제 시작
            'If Me.GmainBusinessFunction.GetValue("로그인 ID") = "000001" Then
            '    Exit Sub
            'End If

            ' sp 호출 화면 활성화 정보를 가져 온다
            GmainsqlParameters = Nothing
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AprogramId", programId)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AsystemDivision", systemDivision)

            Dim receiveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "GetControlActivityByRole", False, True, GmainsqlParameters)
            ' 나중에 삭제 끝

            If IsNothing(receiveDataSet) = False Then
                If receiveDataSet.Tables(0).Rows.Count > 0 Then

                    '' 조회권한
                    If receiveDataSet.Tables(0).Rows(0).Item("RequestYesOrNo") = True Then
                        Me.btnRequestData.Enabled = True
                        Me.mnuRequestData.Enabled = True
                    End If
                    '' 신규/저장 권한
                    If receiveDataSet.Tables(0).Rows(0).Item("SaveYesOrNo") = True Then

                        Me.btnNewData.Enabled = True
                        Me.mnuNewData.Enabled = True

                        Me.btnSaveData.Enabled = True
                        Me.mnuSaveData.Enabled = True
                    End If

                    '' 삭제권한
                    If receiveDataSet.Tables(0).Rows(0).Item("DeleteYesOrNo") = True Then
                        Me.btnDeleteData.Enabled = True
                        Me.mnuDeleteData.Enabled = True
                    End If

                    '' 출력권한
                    If receiveDataSet.Tables(0).Rows(0).Item("PrintYesOrNo") = True Then

                        Me.btnExportDataToPrinter.Enabled = True
                        Me.mnuExportDataToPrinter.Enabled = True

                        '' 미리보기
                        Me.btnExportDataToPreview.Enabled = True
                        Me.mnuExportDataToPreview.Enabled = True


                    End If

                    If receiveDataSet.Tables(0).Rows(0).Item("ExcellRepYesOrNo") = True Then
                        '' 엑셀
                        Me.btnExportDataToExcel.Enabled = True
                        Me.mnuExportDataToExcel.Enabled = True
                    End If

                    If receiveDataSet.Tables(0).Rows(0).Item("ActivationYesOrNo") = True Then
                        '' 도움말
                        Me.btnHelp.Enabled = True
                        Me.mnuHelp.Enabled = True

                    End If

                    Me.btnNotepad.Enabled = True
                    Me.btnCalc.Enabled = True
                End If
            End If

            receiveDataSet = Nothing
        End Sub ' 컨트롤 활성 화


        Private Function CheckDataAllowPermitionByUser(ByVal AUiId As String, ByVal ALogInID As String, ByVal APermition As String) As Boolean
            ' 사용자 ID를 접근하여 화면단위의 권한 코드를 가져온다.
            Dim tempSqlParameter() As SqlParameter = Nothing
            Dim reciveDataSet As DataSet = Nothing

            CheckDataAllowPermitionByUser = False

            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", ALogInID)
            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AprogramId", AUiId)
            'GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@APermition", APermition)

            reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "GetScreeenPermintionByUser", False, True, tempSqlParameter)
            If IsNothing(reciveDataSet) = False Then
                If reciveDataSet.Tables(0).Rows.Count > 0 Then
                    RequestPermition = CType(reciveDataSet.Tables(0).Rows(0).Item(0), Integer)
                    SavePermition = reciveDataSet.Tables(0).Rows(0).Item(1)
                    DeletePermition = reciveDataSet.Tables(0).Rows(0).Item(2)
                    PrintPermition = reciveDataSet.Tables(0).Rows(0).Item(3)
                    ActivationPermition = reciveDataSet.Tables(0).Rows(0).Item(4)

                    If APermition = "RequestData" Then
                        CheckDataAllowPermitionByUser = IIf(RequestPermition = 1, True, False)
                    ElseIf APermition = "SaveData" Or APermition = "NewData" Then
                        CheckDataAllowPermitionByUser = SavePermition
                    ElseIf APermition = "DeleteData" Then
                        CheckDataAllowPermitionByUser = DeletePermition
                    ElseIf APermition = "PrintData" Then
                        CheckDataAllowPermitionByUser = PrintPermition
                    ElseIf APermition = "Activation" Then
                        CheckDataAllowPermitionByUser = ActivationPermition
                    Else
                        CheckDataAllowPermitionByUser = False
                    End If
                End If

            End If
        End Function

    End Class
End Namespace