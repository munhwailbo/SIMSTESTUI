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

    Partial Class PNJ201

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
                If Me.txtABarCode.TextValue = "" Then
                    .SetSqlParameter(GmainsqlParameters, "@ADetailOrders", Me.txtABarCode.TextValue)
                Else
                    If Me.txtABarCode.TextValue.Length = 16 Then
                        Me.popCouponCorpCd.TextValue = Me.txtABarCode.TextValue.Substring(0, 4)
                        Me.dtpPublishYearMonthFrom.TextValue = Me.txtABarCode.TextValue.Substring(4, 6) + "01"
                        Me.dtpPublishYearMonthTo.TextValue = Me.txtABarCode.TextValue.Substring(4, 6) + "01"
                        .SetSqlParameter(GmainsqlParameters, "@ADetailOrders", Me.txtABarCode.TextValue.Substring(10, 6))
                    Else
                        MsgBox("입력한 구독권번호가 잘 못되었습니다.")
                        GmainExecuteDbCommand.GerrorNumber = 1
                        Return
                    End If

                End If
                If chkRedeemDt.Checked = True Then
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt_FR", IIf(dtpRedeemDt_FR.TextValue.ToString.Length < 1, "", Me.dtpRedeemDt_FR.TextValue))
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt_To", IIf(dtpRedeemDt_To.TextValue.ToString.Length < 1, "", Me.dtpRedeemDt_To.TextValue))
                Else
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt_FR", "")
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt_To", "")
                End If

                .SetSqlParameter(GmainsqlParameters, "@APublishYearMonthFrom", Me.dtpPublishYearMonthFrom.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@APublishYearMonthTo", Me.dtpPublishYearMonthTo.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ACouponCorpCd", Me.popCouponCorpCd.TextValue)



                'If IsNothing(Me.txtDetailOrders.TextValue) = True Then
                '    Me.txtDetailOrders.TextValue = ""
                'End If

                '.SetSqlParameter(GmainsqlParameters, "@ADetailOrders", Me.txtDetailOrders.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ201_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)

                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)

            End With


        End Sub


        Public Sub RequestData_BarcodeChk(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@APublishBarCode", Me.txtBarCode.TextValue)

                'If IsNothing(Me.txtDetailOrders.TextValue) = True Then
                '    Me.txtDetailOrders.TextValue = ""  
                'End If

                '.SetSqlParameter(GmainsqlParameters, "@ADetailOrders", Me.txtDetailOrders.TextValue)


                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ201_3_R", False, True, GmainsqlParameters)
                If IsNothing(reciveDataSet) Then

                    'gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
                    'gridAttributes = gridAttributes & "|발행년월;PublishYearMonth;100;####-##;c;" & "o;n;n;4;"
                    'gridAttributes = gridAttributes & "|회수지국번호;RedeemBranchNum;100;;l;" & "io;n;n;9;지국코드;BranchNm"
                    'gridAttributes = gridAttributes & "|회수지국명;BranchNm;120;;l;" & "o;n;n;9;"
                    'gridAttributes = gridAttributes & "|구독권발행코드;CouponPublicCd_2;100;;l;" & "io;n;y;8;"
                    'gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;80;;l;" & "o;n;n;8;"
                    'gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;100;;l;" & "o;n;n;8;"
                    'gridAttributes = gridAttributes & "|발행상세순번;DetailOrders;100;;r;" & "io;n;n;4;"
                    'gridAttributes = gridAttributes & "|발행일자;PublishDt;100;####-##-##;c;" & "o;n;n;4;"
                    'gridAttributes = gridAttributes & "|회수일자;RedeemDt;100;####-##-##;l;" & "io;n;n;8;"
                    'gridAttributes = gridAttributes & "|순번;Orders;40;;r;" & "io;n;y;4;"
                    'gridAttributes = gridAttributes & "|바코드;PublishBarCode;180;;l;" & "io;n;y;30;"
                    'gridAttributes = gridAttributes & "|독자명단유무;ReaderListYN;80;;c;" & "io;n;n;1;"
                    'gridAttributes = gridAttributes & "|지급년월;PayYYYYMM;100;;l;" & "io;n;n;6;"
                    'gridAttributes = gridAttributes & "|회수여부;RedeemYN;80;;c;" & "io;n;n;1;"
                    'gridAttributes = gridAttributes & "|구독권발행코드;CouponSeriesNum;100;;l;" & "io;n;y;10;"
                    'gridAttributes = gridAttributes & "|;Dumi;100;;l;" & "o;n;n;9;"
                    'gridAttributes = gridAttributes & "|신규구분;IsExist;100;;l;" & "o;n;y;9;"

                ElseIf reciveDataSet.Tables.Count > 0 And reciveDataSet.Tables(0).Rows.Count > 0 Then
                    If reciveDataSet.Tables(0).Rows(0).Item("RedeemYN") = 0 Then

                        If grd_1.Rows > 1 Then
                            For i As Integer = 1 To grd_1.Rows - 1
                                If grd_1.GetData(i, "PublishBarCode").ToString().Trim() = reciveDataSet.Tables(0).Rows(0).Item("PublishBarCode") Then
                                    ' 회수에 체크한다.
                                    grd_1.SetCellCheck(i, grd_1.get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                                    'grd_1.SetData(i, "RedeemBranchNum", Me.popBranchCd.CodeText)
                                    'grd_1.SetData(i, "BranchNm", Me.popBranchCd.NameText)
                                    'grd_1.SetData(i, "RedeemDt", Me.dtpRedeemDt.Text)
                                    'grd_1.SetData(1, "PayYYYYMM", Me.dtpPayYYYYMM.TextValue)
                                    'grd_1.SetCellCheck(i, grd_1.get_ColIndex("RedeemYN"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                                    'grd_1.SetData(i, "RedeemUnitAmt", Me.numRedeemUnitCost.Text)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("RedeemBranchNum"), Me.popBranchCd.TextValue)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("BranchNm"), Me.popBranchCd.NameText)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("RedeemDt"), Me.dtpRedeemDt.Text)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("PayYYYYMM"), Me.dtpPayYYYYMM.Text)
                                    Me.grd_1.SetCellCheck(i, Me.grd_1.get_ColIndex("RedeemYN"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                                    Me.grd_1.set_TextMatrix(i, Me.grd_1.get_ColIndex("RedeemUnitAmt"), Me.numRedeemUnitCost.Text)
                                    Exit Sub
                                End If
                            Next
                            ' 행추가하고 값을 넣는다.
                            grd_1.AddRow()
                            regReciveCoupon(reciveDataSet.Tables(0))
                        Else
                            grd_1.AddRow()
                            regReciveCoupon(reciveDataSet.Tables(0))

                        End If
                    Else
                        MsgBox("이미 등록된 번호입니다.", MsgBoxStyle.Information)
                    End If

                    reciveDataSet = Nothing
                    .SetAllBusinessUiInitialValue(Me)
                    'If AprocessMessage = True Then .RequestDataMessage(Me)
                Else
                    MsgBox("발행된 번호가 아닙니다.", MsgBoxStyle.Information)
                End If

            End With


        End Sub

        ''' <summary>
        ''' 배달확인증 회수등록한다.
        ''' </summary>
        ''' <param name="DT"></param>
        ''' <remarks></remarks>
        Private Sub regReciveCoupon(ByVal DT As DataTable)
            grd_1.SetData(grd_1.Rows - 1, "PublishYearMonth", DT.Rows(0).Item("PublishYearMonth").ToString().Substring(0, 4) + "-" + DT.Rows(0).Item("PublishYearMonth").ToString().Substring(4, 2))
            grd_1.SetData(grd_1.Rows - 1, "RedeemBranchNum", Me.popBranchCd.CodeText)
            grd_1.SetData(grd_1.Rows - 1, "BranchNm", Me.popBranchCd.NameText)
            grd_1.SetData(grd_1.Rows - 1, "CouponPublicCd_2", DT.Rows(0).Item("CouponPublicCd_2"))
            grd_1.SetData(grd_1.Rows - 1, "CouponCorpCd", DT.Rows(0).Item("CouponCorpCd"))
            grd_1.SetData(grd_1.Rows - 1, "CouponCorpNm", DT.Rows(0).Item("CouponCorpNm"))
            grd_1.SetData(grd_1.Rows - 1, "DetailOrders", DT.Rows(0).Item("DetailOrders"))
            grd_1.SetData(grd_1.Rows - 1, "PublishDt", DT.Rows(0).Item("PublishDt").ToString().Substring(0, 4) + "-" + DT.Rows(0).Item("PublishDt").ToString().Substring(4, 2) + "-" + DT.Rows(0).Item("PublishDt").ToString().Substring(6, 2))
            grd_1.SetData(grd_1.Rows - 1, "RedeemDt", Me.dtpRedeemDt.Text)
            grd_1.SetData(grd_1.Rows - 1, "Orders", DT.Rows(0).Item("Orders"))
            grd_1.SetData(grd_1.Rows - 1, "PublishBarCode", DT.Rows(0).Item("PublishBarCode"))
            grd_1.SetCellCheck(grd_1.Rows - 1, grd_1.get_ColIndex("ReaderListYN"), VBN.IIf(DT.Rows(0).Item("ReaderListYN"), C1.Win.C1FlexGrid.CheckEnum.Checked, C1.Win.C1FlexGrid.CheckEnum.Unchecked))
            grd_1.SetData(grd_1.Rows - 1, "PayYYYYMM", Me.dtpPayYYYYMM.Text)
            grd_1.SetCellCheck(grd_1.Rows - 1, grd_1.get_ColIndex("RedeemYN"), C1.Win.C1FlexGrid.CheckEnum.Checked)

            If DT.Rows(0).Item("RedeemUnitAmt") = 0 Then
                grd_1.SetData(grd_1.Rows - 1, "RedeemUnitAmt", Me.numRedeemUnitCost.Text)
            Else
                grd_1.SetData(grd_1.Rows - 1, "RedeemUnitAmt", DT.Rows(0).Item("RedeemUnitAmt"))
            End If

            grd_1.SetData(grd_1.Rows - 1, "UnitCost", DT.Rows(0).Item("unitcost"))

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
            If Me.ValidationCheck = False Then
                GmainExecuteDbCommand.GerrorNumber = 1
                Exit Sub
            End If

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(False))
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ201_CUD", True, False, GmainsqlParameters)
                .SetAllBusinessUiInitialValue(Me)
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
                    .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))
                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ201_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("데이타가 삭제 되었습니다", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

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

                Dim strRedeemDt As String = ""
                For inti As Integer = 0 To Me.grd_1.Rows - 1
                    If Me.grd_1.GetCellCheck(inti, Me.grd_1.get_ColIndex("선택")) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                        If Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("RedeemBranchNum")) = "" Then
                            MessageBox.Show("회수지국번호를 반드시 등록해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If

                        strRedeemDt = Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("RedeemDt"))
                        If IsDate(strRedeemDt) = False Then
                            MessageBox.Show("회수일자를 확인후 등록해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Function
                        End If

                        'If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("CirculationNum"))) = False Then
                        '    MessageBox.Show("발행부수를 확인후 다시 등록해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Function
                        'End If
                        'If IsNumeric(Me.grd_1.get_TextMatrix(inti, Me.grd_1.get_ColIndex("UnitCost"))) = False Then
                        '    MessageBox.Show("단가를 확인후 다시 등록해 주세요", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '    Exit Function
                        'End If
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
         '       .SetExportCrystalDataParameter("PNJ201.rpt", "PNJ201_R", "", AsqlParameters, AformulaParameters)
         '   End With

        End Sub

    End Class

End Namespace
