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

    Partial Class PNJ101

        ''' <summary>
        ''' 함수명 : NewData 
        ''' 기  능 : 신규 
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 황인중
        ''' 수정일 : 2008.11.13
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()

            Me.grd_1.AddRow()
            Me.grd_1.set_TextMatrix(Me.grd_1.Rows - 1, Me.grd_1.get_ColIndex("PublishStNum"), 1)

            'Exit Sub
            'If grd_1.Focused = True Then
            '    Me.grd_1.AddRow()
            '    Exit Sub
            'Else
            '    If Me.grd_1.GetCurrentRowCellValue("CouponPublicCd") <> "" Then
            '        Me.grd_2.AddRow()
            '        Me.grd_2.set_TextMatrix(Me.grd_2.Rows - 1, Me.grd_2.get_ColIndex("CouponSeriesNum"), Me.grd_1.GetCurrentRowCellValue("CouponPublicCd"))
            '    Else
            '        MessageBox.Show("구독권발행코드를 확인후 신규 작업을 하세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    End If
            'End If
        End Sub

        ''' <summary>
        ''' 함수명 : RequestData
        ''' 기  능 : 조회
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 황인중
        ''' 수정일 : 2008.11.13     
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@APublishYearMonthFrom", Me.dtpPublishYearMonthFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@APublishYearMonthTo", Me.dtpPublishYearMonthTo.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.popCouponCorpCd.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
            Call SetSubTotal()
        End Sub
        Private Sub SetSubTotal()

            With Me.grd_1
                If .Rows > .FixedRows Then
                    .Tree.Column = .get_ColIndex("TreePath")
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
                    .SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData

                    ' '' =============================================================================
                    '' '' '' 그리드 합계행 추가
                    ' '' =============================================================================
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.LightYellow
                    .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.Blue
                    .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, -1, .get_ColIndex("CirculationNum"), "합계")
                    '.set_TextMatrix(.FixedRows, .get_ColIndex("ChargeEmpNm"), "합   계")
                    Me.grd_1.FrozenRows = 1
                End If
            End With
        End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                If grd_1.Rows > 1 Then
                    .SetSqlParameter(GmainsqlParameters, "@ACouponPublicCd", grd_1.GetCurrentRowCellValue("CouponPublicCd"))
                    .SetSqlParameter(GmainsqlParameters, "@AOrders", grd_1.GetCurrentRowCellValue("Orders"))

                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_R", False, True, GmainsqlParameters)
                    Me.grd_2.SetDataSet(reciveDataSet)
                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    If AprocessMessage = True Then .RequestDataMessage(Me)
                End If
            End With

        End Sub

        ''' <summary>
        ''' 함수명 : SaveData 
        ''' 기  능 : 저장
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 황인중
        ''' 수정일 : 2008.11.13
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()

            If Me.ValidationCheck = False Then
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Sub
            End If

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            'If grd_1.Focused = True Then
            '    If Me.ValidationCheck(Me.grd_1) = False Then
            '        Exit Sub
            '    End If
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        GmainCommonFunction.SaveDataMessage(Me)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            'ElseIf Me.grd_2.Focus = True Then
            '    If Me.ValidationCheck(Me.grd_2) = False Then
            '        Exit Sub
            '    End If
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        GmainCommonFunction.SaveDataMessage(Me)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '        GmainExecuteDbCommand.GerrorNumber = 1
            '    End If
            'End If
        End Sub

        Public Sub DetailSave()
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
                Call RequestData_2()
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                GmainExecuteDbCommand.GerrorNumber = 1
            End If
        End Sub

        Private Sub saveImage(ByVal bytBuffer() As Byte)

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhotoFilePath", bytBuffer)   '주민번호

            Try
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    '.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    '.SetSqlParameter(GmainsqlParameters, "@ABranchChiefCd", txtChiefCd.Text.Trim())
                    '.SetSqlParameter(GmainsqlParameters, "@APhotoFilePath", bytBuffer)
                    'GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNB201_2_CUD", True, False, GmainsqlParameters)
                    '.SetAllBusinessUiInitialValue(Me)
                    '.SaveDataMessage(Me)
                End With

                MessageBox.Show("이미지가 저장 되었습니다.", "추가", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        End Sub

        ''' <summary>
        ''' 함수명 : DeleteData 
        ''' 기  능 : 삭제
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 황인중
        ''' 수정일 : 2008.11.13        
        ''' ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()

            If MessageBox.Show("데이터를 삭제 하시겠습니까? ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                MessageBox.Show("데이타가삭제되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)


            'If Me.grd_1.Focus = True Then
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        MessageBox.Show("데이타가삭제되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            'ElseIf Me.grd_2.Focus = True Then
            '    With GmainCommonFunction
            '        .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            '        .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
            '        GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_CUD", True, False, GmainsqlParameters)
            '        .SetAllBusinessUiInitialValue(Me)
            '    End With
            '    If GmainExecuteDbCommand.GerrorNumber = 0 Then
            '        MessageBox.Show("데이타가삭제되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Else
            '        MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            '    End If
            '    GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            'End If
        End Sub

        Public Sub DetailDelete()

            If Me.grd_2.Rows < 2 Then
                MessageBox.Show("삭제할 내역이 없습니다 확인후 작업하세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If MessageBox.Show("내역 데이터를 삭제 하시겠습니까? ", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ101_2_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                MessageBox.Show("데이타가삭제되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call RequestData_2()
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

        End Sub


        ''' <summary>
        ''' 함수명 : ValidationCheck
        ''' 기 능  : 저장, 삭제시 정합성 체크
        ''' 작성자 : 황인중
        ''' 작성일 : 2008.11.13
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ValidationCheck() As Boolean
            ValidationCheck = False

            If Me.grd_1.Rows > 1 Then

                Dim strPublishYearMonth As String = ""
                For inti As Integer = 0 To Me.grd_1.Rows - 1
                    If Me.grd_1.GetCellCheck(inti, Me.grd_1.get_ColIndex("선택")) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                        strPublishYearMonth = Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("PublishYearMonth")) & "-01"
                        If IsDate(strPublishYearMonth) = False Then
                            MessageBox.Show("발행년월을 확인후 등록해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                        If Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("CouponCorpCd")) = "" Then
                            MessageBox.Show("소속사코드를 반드시 등록해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                        If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("CirculationNum"))) = False Then
                            MessageBox.Show("발행부수를 확인후 다시 등록해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                        If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("UnitCost"))) = False Then
                            MessageBox.Show("단가를 확인후 다시 등록해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If
                    End If
                Next inti
            End If

            ValidationCheck = True
        End Function

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

         '   Dim AsqlParameters() As SqlParameter = Nothing
         '
         '   With GmainCommonFunction
         '       .SetSqlParameter(AsqlParameters, "@AcodeDivisionHangulName", Me.txtCodeDivisionHangulName.TextValue)
         '       .SetSqlParameter(AsqlParameters, "@AcodeDivision", Me.txtCodeDivision.TextValue)
         '
         '       'Dim AAAA As String = ""
         '       'AAAA = "{@장표ID}=" &"'" & GmainBusinessFunction.GetValue("로그인ID") & "'"
         '
         '       Dim AformulaParameters() As SqlParameter = Nothing
         '
         '       'GmainCommonFunction.SetSqlParameter(AformulaParameters, "장표ID", "'" & GmainBusinessFunction.GetValue("로그인ID") & "'")
         '       .SetSqlParameter(AformulaParameters, "작성자", "'" & GmainBusinessFunction.GetValue("로그인명") & "'")
         '
         '       ' 공통변수의정의가생성시에발생될수있도록유도한다.
         '       .SetExportCrystalDataParameter("PNJ101.rpt", "PNJ101_R", "", AsqlParameters, AformulaParameters)
         '   End With

        End Sub

    End Class

End Namespace
