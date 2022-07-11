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

    Partial Class PNI202

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
            Me.grd_1.AddRow()
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
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ACollectYYYYMM", Me.dtpCollectYYYYMM.TextValue)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI202_R", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
            Call SetSubTotal()
        End Sub
        Private Sub SetSubTotal()

            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Tree.Column = .get_ColIndex("TreePath")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData

                    ' '' =============================================================================
                    '' '' '' 그리드 담당 소계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    For intII As Integer = .get_ColIndex("UnColAmt") To .get_ColIndex("ValPaperSale4")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), intII, "{0} 소계")
                    Next

                    

                    ' '' =============================================================================
                    '' '' '' 그리드 합계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    For intII As Integer = .get_ColIndex("UnColAmt") To .get_ColIndex("ValPaperSale4")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, intII, "합 계")
                    Next

                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
      
        '====================================================================================================
        Public Sub SaveData()

            Dim message As String = "청구년월 : " & dtpCollectYYYYMM.TextValue.ToString().Substring(0, 4) & "년 " _
                                                  & dtpCollectYYYYMM.TextValue.ToString().Substring(4, 2) & "월 "
            message = message & vbCrLf & "수납마감일 : " & dtpColEndDt.TextValue.ToString().Substring(0, 4) & "년 " _
                                                         & dtpColEndDt.TextValue.ToString().Substring(4, 2) & "월 " _
                                                         & dtpColEndDt.TextValue.ToString().Substring(6, 2) & "일 "
            message = message & vbCrLf & "처리 하시겠습니까?"
            If MsgBox(message, MsgBoxStyle.YesNo, "선택하세요.") = MsgBoxResult.No Then
                Exit Sub
            End If

            message = "기존 자료를 삭제 후 재생성 처리 합니다."
            If MsgBox(message & vbCrLf & "처리 하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

                GmainsqlParameters = Nothing

                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", "1")
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseYearMonths", Me.dtpCollectYYYYMM.TextValue)  ' 매출 청구 기준 년월
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABaseColEndDt", Me.dtpColEndDt.TextValue)  ' 수납 마감일 
                ''''GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI202_CUD", True, False, GmainsqlParameters)


                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    GmainCommonFunction.SaveDataMessage(Me)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            End If

        End Sub

        '====================================================================================================
        Public Sub DeleteData()

            ' ''If MsgBox("삭제하시겠습니까?", MsgBoxStyle.OkCancel, "선택하세요.") = MsgBoxResult.Ok Then

            ' ''    GmainsqlParameters = Nothing

            ' ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ' ''    GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            ' ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNI202_CUD", True, False, GmainsqlParameters)

            ' ''    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            ' ''    MessageBox.Show("데이타가 삭제 되었습니다 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ''End If

        End Sub

    End Class

End Namespace
