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

    Partial Class PND201

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
            GmainCommonFunction.ControlNewData(Me, Me.picIo_2)
            ''Me.TxtPKey.TextValue)
            ''Me.txtMtOrders.TextValue) '회의차수
            Me.TxtMtDesc.Text = "" '개요
            ''Me.dtpMtDate.TextValue) '회의일자
            Me.txtLastContents.Text = "" '지난내용
            Me.txtThisContents.Text = "" '회의안건
            Me.txtThisIssue.Text = "" '이슈
            Me.txtRemark.Text = "" '기타

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
                .SetSqlParameter(GmainsqlParameters, "@AMtDateFrom", Me.dtpMtDateFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AMtDateTo", Me.dtpMtDateTo.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AMtDesc", Me.txtMtDesc_2.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PND201_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub

        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            If grd_1.Rows <= grd_1.FixedRows Then Exit Sub

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@APKey", Me.grd_1.GetCurrentRowCellValue("Pkey"))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PND201_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)
                'Me.txtPkey.Text = reciveDataSet.Tables(0).Rows(0).Item("Pkey").ToString
                'Me.txtMtOrders.Text = reciveDataSet.Tables(0).Rows(0).Item("MtOrders").ToString
                'Me.TxtMtDesc.Text = reciveDataSet.Tables(0).Rows(0).Item("MtDesc").ToString
                'Me.dtpMtDate.Text = reciveDataSet.Tables(0).Rows(0).Item("MtDate").ToString

                'Me.txtLastContents.Text = reciveDataSet.Tables(0).Rows(0).Item("LastContents").ToString
                'Me.txtThisContents.Text = reciveDataSet.Tables(0).Rows(0).Item("ThisContents").ToString
                'Me.txtThisIssue.Text = reciveDataSet.Tables(0).Rows(0).Item("ThisIssue").ToString
                'Me.txtRemark.Text = reciveDataSet.Tables(0).Rows(0).Item("Remark").ToString

                ''txtLastContents.Text = reciveDataSet.Tables(0).Rows(0)("LastContents").ToString.Replace("_&!@&_", vbCrLf)
                ''txtThisContents.Text = reciveDataSet.Tables(0).Rows(0)("ThisContents").ToString.Replace("_&!@&_", vbCrLf)
                ''txtThisIssue.Text = reciveDataSet.Tables(0).Rows(0)("ThisIssue").ToString.Replace("_&!@&_", vbCrLf)
                ''txtRemark.Text = reciveDataSet.Tables(0).Rows(0)("Remark").ToString.Replace("_&!@&_", vbCrLf)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

            End With
        End Sub

        Public Sub SaveData()
            If Me.TxtPKey.Text.Replace(" ", "") = "" Then
                GrecordProcessMode = "1"
            Else
                GrecordProcessMode = "2"
            End If
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
                .SetSqlParameter(GmainsqlParameters, "@APKey", Me.TxtPKey.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AMtOrders", Me.txtMtOrders.TextValue) '회의차수
                .SetSqlParameter(GmainsqlParameters, "@AMtDesc", Me.TxtMtDesc.Text) '개요
                .SetSqlParameter(GmainsqlParameters, "@AMtDate", Me.dtpMtDate.TextValue) '회의일자
                .SetSqlParameter(GmainsqlParameters, "@ALastContents", Me.txtLastContents.Text) '지난내용
                .SetSqlParameter(GmainsqlParameters, "@AThisContents", Me.txtThisContents.Text) '회의안건
                .SetSqlParameter(GmainsqlParameters, "@AThisIssue", Me.txtThisIssue.Text) '이슈
                .SetSqlParameter(GmainsqlParameters, "@ARemark", Me.txtRemark.Text) '기타
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PND201_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub

        Public Sub DeleteData()

            Dim result As DialogResult
            result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
                    .SetSqlParameter(GmainsqlParameters, "@APkey", Me.TxtPKey.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AMtOrders", Me.txtMtOrders.TextValue) '회의차수
                    .SetSqlParameter(GmainsqlParameters, "@AMtDesc", Me.TxtMtDesc.Text) '개요
                    .SetSqlParameter(GmainsqlParameters, "@AMtDate", Me.dtpMtDate.TextValue) '회의일자
                    .SetSqlParameter(GmainsqlParameters, "@ALastContents", Me.txtLastContents.Text) '지난내용
                    .SetSqlParameter(GmainsqlParameters, "@AThisContents", Me.txtThisContents.Text) '회의안건
                    .SetSqlParameter(GmainsqlParameters, "@AThisIssue", Me.txtThisIssue.Text) '이슈
                    .SetSqlParameter(GmainsqlParameters, "@ARemark", Me.txtRemark.Text) '기타
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PND201_CUD", True, False, GmainsqlParameters)
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
    End Class

End Namespace
