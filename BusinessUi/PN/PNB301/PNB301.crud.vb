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

    Partial Class PNB301

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
            'If grd_2.Focused = True Then
            '    Me.NewData_2()
            '    Exit Sub
            'End If
            'Me.grd_1.AddRow()
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
            Dim blnRequestYesOrNo As Boolean = True
            'If popBranchCd.TextValue.ToString.Length < 1 _
            '   And txtBranchNm.TextValue.ToString.Length < 1 _
            '   And popChargeEmpNum.TextValue.ToString.Length < 1  Then
            '    blnRequestYesOrNo = False
            '    MessageBox.Show("조회 조건을 기준일자 외 하나 이상 입력하세요.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'End If
            If blnRequestYesOrNo Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ABranchCd", Me.popBranchCd.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AchargeEmpNum", Me.popChargeEmpNum.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AcloseCheck", Me.chkCloseCheck.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AOpenCheck", Me.chkOpenCheck.TextValue)
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB301_R", False, True, GmainsqlParameters)
                    Me.grd_1.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End With
            End If
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
                    For intII As Integer = .get_ColIndex("DeliveryPaperNum") To .get_ColIndex("SumAmt")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNumNm"), intII, "{0} 소계")
                    Next



                    ' '' =============================================================================
                    '' '' '' 그리드 합계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    For intII As Integer = .get_ColIndex("DeliveryPaperNum") To .get_ColIndex("SumAmt")
                        .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, intII, "합 계")
                    Next

                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        'Private Sub SetSubTotal()
        '    With Me.grd_1
        '        If .Rows > .FixedRows Then
        '            .Tree.Column = .get_ColIndex("ChargeEmpNumNm")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
        '            .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
        '            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
        '            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue

        '            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
        '            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

        '            ' '' =============================================================================
        '            '' '' '' 그리드 팀 소계행 추가
        '            ' '' =============================================================================
        '            '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNumNm"), .get_ColIndex("DeliveryPaperNum"), "{0} 소계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNumNm"), .get_ColIndex("ValPaperNum"), "{0} 소계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNumNm"), .get_ColIndex("BranchValPaperNum"), "{0} 소계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNumNm"), .get_ColIndex("DepositAmt"), "{0} 소계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNumNm"), .get_ColIndex("DepositDivCd"), "{0} 소계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNumNm"), .get_ColIndex("SumAmt"), "{0} 소계")
        '            ' '' =============================================================================
        '            '' '' '' 그리드 합계행 추가
        '            ' '' =============================================================================
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DeliveryPaperNum"), "합  계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("ValPaperNum"), "합  계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("BranchValPaperNum"), "합  계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DepositAmt"), "합  계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("DepositDivCd"), "합  계")
        '            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("SumAmt"), "합  계")

        '            Me.grd_1.FrozenRows = 1
        '        End If
        '    End With
        'End Sub

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

            'GmainsqlParameters = Nothing
            'With GmainCommonFunction
            '    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB301_CUD", True, False, GmainsqlParameters)
            '    .SetAllBusinessUiInitialValue(Me)
            '    '' .SaveDataMessage(Me)
            'End With
            'If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '    GmainCommonFunction.SaveDataMessage(Me)
            'Else
            '    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'End If

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

            'Dim result As DialogResult
            'result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            'If result = DialogResult.OK Then   '' Result Start
            '    GmainsqlParameters = Nothing
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB301_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '        '' .SaveDataMessage(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            'End If   '' Result end

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

            Dim AsqlParameters() As SqlParameter = Nothing

            With GmainCommonFunction
                .SetSqlParameter(AsqlParameters, "@ABranchCd", Me.popBranchCd.TextValue)
                .SetSqlParameter(AsqlParameters, "@ABranchNm", Me.txtBranchNm.TextValue)
                .SetSqlParameter(AsqlParameters, "@AchargeEmpNum", Me.popChargeEmpNum.TextValue)
                .SetSqlParameter(AsqlParameters, "@AbaseDt", Me.dtpBaseDt.TextValue)

                'Dim AAAA As String = ""
                'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"

                Dim AformulaParameters() As SqlParameter = Nothing

                'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
                .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")

                ' 공통변수의정의가생성시에발생될수있도록유도한다.
                .SetExportCrystalDataParameter("PNB301_1_C_R.rpt", "PNB301_1_C_R;PNB301_2_C_R;", "", AsqlParameters, AformulaParameters)
            End With

        End Sub

       
    End Class
 
End Namespace
