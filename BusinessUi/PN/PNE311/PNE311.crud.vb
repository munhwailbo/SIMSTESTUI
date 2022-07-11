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

    Partial Class PNE311

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
            grd_1.NewData()
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
                .SetSqlParameter(GmainsqlParameters, "@AYYYYMM", Me.dtpYYYYMM.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AChargeEmpNum_R", Me.popChargeEmpNum_R.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchNum", Me.popBranchCd_R.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE311_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

            Call SetSubTotal()
    
        End Sub

        '그리드 합계행 추가
        '그리드 합계행 추가
        Private Sub SetSubTotal()
            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Tree.Column = .get_ColIndex("ChargeEmpNm")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Blue
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue

                    ' '' =============================================================================
                    '' '' '' 그리드 팀 소계행 추가
                    ' '' =============================================================================
                    '.set_MergeCol(Me.grd_1.get_ColIndex("ChargeEmpNm"), True)
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("Ext_Sa_New"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("Ext_Sa_ReNew1"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("Ext_Sa_Dup"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("Ext_Sa_ReNew2"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("Ext_Sa_ReNewTot"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("Ext_Sa_ReNewInc"), "{0} 소계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, .get_ColIndex("ChargeEmpNm"), .get_ColIndex("Ext_Sa_Tot"), "{0} 소계")

                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Ext_Sa_New"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Ext_Sa_ReNew1"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Ext_Sa_Dup"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Ext_Sa_ReNew2"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Ext_Sa_ReNewTot"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Ext_Sa_ReNewInc"), "합계")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("Ext_Sa_Tot"), "합계")
                    '.set_TextMatrix(.FixedRows, .get_ColIndex("ChargeEmpNm"), "합   계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub
        'gridAttributes = gridAttributes & "|신규부수(a);Ext_Sa_New;80;#,##0;c;" & "o;n;n;15;"       '(80)
        '   gridAttributes = gridAttributes & "|재확장 기존;Ext_Sa_ReNew1;80;#,##0;c;" & "o;n;n;15;"       '(80)
        '   gridAttributes = gridAttributes & "|재확장 중복;Ext_Sa_Dup;80;#,##0;c;" & "o;n;n;15;"       '(80)
        '   gridAttributes = gridAttributes & "|재확장 신규;Ext_Sa_ReNew2;80;#,##0;c;" & "o;n;n;15;"       '(80)
        '   gridAttributes = gridAttributes & "|재확장 계(b);Ext_Sa_ReNewTot;80;#,##0;c;" & "o;n;n;15;"       '(80)
        '   gridAttributes = gridAttributes & "|재확장증감(c);Ext_Sa_ReNewInc;80;#,##0;c;" & "o;n;n;15;"       '(80)

        '   gridAttributes = gridAttributes & "|총확장부수(a+b);Ext_Sa_Tot;80;#,##0;c;" & "o;n;n;15;"       '(80)

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

            ' '' ''GmainsqlParameters = Nothing
            ' '' ''With GmainCommonFunction
            ' '' ''    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            ' '' ''    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            ' '' ''    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE311_CUD", True, False, GmainsqlParameters)
            ' '' ''    .SetAllBusinessUiInitialValue(Me)
            ' '' ''    '' .SaveDataMessage(Me)
            ' '' ''End With
            ' '' ''If GmainExecuteDbCommand.GerrorNumber = 0 Then
            ' '' ''    GmainCommonFunction.SaveDataMessage(Me)
            ' '' ''Else
            ' '' ''    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ' '' ''End If

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

            '' ''Dim result As DialogResult
            '' ''result = MessageBox.Show("데이타를 삭제 하시겠습니까?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            '' ''If result = DialogResult.OK Then   '' Result Start
            '' ''    GmainsqlParameters = Nothing
            '' ''    With GmainCommonFunction
            '' ''        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '' ''        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '' ''        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNE311_CUD", True, False, GmainsqlParameters)
            '' ''        .SetAllBusinessUiInitialValue(Me)
            '' ''        '' .SaveDataMessage(Me)
            '' ''    End With
            '' ''    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '' ''        MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''    Else
            '' ''        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '' ''    End If
            '' ''End If   '' Result end

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
