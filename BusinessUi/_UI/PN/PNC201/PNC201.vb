' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 
' form설명 :
' 작성자 : 
' 작성일 : 
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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
Imports System.Collections.Generic

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC201
        Inherits CommonControls.UiControl

#Region "폼 초기화"

        ''' <summary>
        ''' 함수명 : Initialize
        ''' 리턴값 : 
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC201_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        ''''''' <summary>
        ''''''' 함수명 : btnRowInsert_Click 
        ''''''' 기  능 : 행 추가
        ''''''' 작성자 : 신현갑
        ''''''' 작성일 : 2007-01-02
        ''''''' 수정자 : 
        ''''''' 수정일 :
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>
        '' ''Private Sub btnRowInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    Dim RowNumber As Integer = 0

        '' ''    With Me.grd_2
        '' ''        .AddRow()
        '' ''        .set_TextMatrix(.Rows - 1, 0, "신규")
        '' ''        .set_TextMatrix(.Rows - 1, .get_ColIndex("SubscribeCd"), "0") '항목 번호 
        '' ''        .set_TextMatrix(.Rows - 1, .get_ColIndex("ReaderCd"), "") '항목 번호 
        '' ''        .set_TextMatrix(.Rows - 1, .get_ColIndex("Orders"), 0) '항목 번호 
        '' ''    End With
        '' ''End Sub
        ''''''' <summary>
        ''''''' 함수명 : btnRowSave_Click 
        ''''''' 기  능 : 행 저장
        ''''''' 작성자 : 신현갑
        ''''''' 작성일 : 2007-01-02
        ''''''' 수정자 : 
        ''''''' 수정일 :
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>
        '' ''Private Sub btnRowSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '' ''End Sub
        ''''''' <summary>
        ''''''' 함수명 : btnRowDelete_Click 
        ''''''' 기  능 : 행 삭제
        ''''''' 작성자 : 신현갑
        ''''''' 작성일 : 2007-01-02
        ''''''' 수정자 : 
        ''''''' 수정일 :
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>
        '' ''Private Sub btnRowDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    With Me.grd_2
        '' ''        If .Rows > .FixedRows Then
        '' ''            If .get_TextMatrix(.RowSel, 0) = "신규" Then
        '' ''                .RemoveItem(.RowSel)
        '' ''            ElseIf IsNumeric(.get_TextMatrix(.RowSel, 0)) = True Then
        '' ''                .set_TextMatrix(.RowSel, 0, "삭제")
        '' ''                .SetCellCheck(.RowSel, .get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
        '' ''            ElseIf .get_TextMatrix(.RowSel, 0) = "수정" = True Then
        '' ''                .set_TextMatrix(.RowSel, 0, "삭제")
        '' ''                .SetCellCheck(.RowSel, .get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
        '' ''            End If
        '' ''        End If
        '' ''    End With
        '' ''End Sub
        ''''''' <summary>
        ''''''' 함수명 : btnCopy_Click 
        ''''''' 기  능 : 행 복사
        ''''''' 작성자 : 신현갑
        ''''''' 작성일 : 2007-01-02
        ''''''' 수정자 : 
        ''''''' 수정일 :
        ''''''' </summary>
        ''''''' <param name="sender"></param>
        ''''''' <param name="e"></param>
        ''''''' <remarks></remarks>
        '' ''Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    Dim Row As Integer = 0                '행 INDEX
        '' ''    Dim RowNumber As Integer = 0

        '' ''    With Me.grd_2
        '' ''        If .Rows = .FixedRows Then Exit Sub
        '' ''        Row = .RowSel
        '' ''        .AddRow()
        '' ''        .set_TextMatrix(.Rows - 1, 0, "신규")
        '' ''        .SetCellCheck(.Rows - 1, .get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalSeq"), "0") '항목 번호 
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("AccountCode"), .get_TextMatrix(Row, .get_ColIndex("AccountCode")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("AccountCodeName"), .get_TextMatrix(Row, .get_ColIndex("AccountCodeName")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalQuantity"), .get_TextMatrix(Row, .get_ColIndex("ProposalQuantity")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalAmount"), .get_TextMatrix(Row, .get_ColIndex("ProposalAmount")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ValidBeginDate"), .get_TextMatrix(Row, .get_ColIndex("ValidBeginDate")))
        '' ''        '.set_TextMatrix(.Rows - 1, .get_ColIndex("ValidEndDate"), .get_TextMatrix(Row, .get_ColIndex("ValidEndDate")))
        '' ''    End With

        '' ''    '2006-07-26 신현갑 추가
        '' ''    Me.grd_2.Select(Me.grd_2.Rows - 1, Me.grd_2.get_ColIndex("SubscribeCd"))
        '' ''End Sub

#End Region


        ''' <summary>
        ''' 함수명 : PNC201_Enter 
        ''' 기  능 : 화면 전환(독자번호 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC201_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters.Length = 6 Then
                If ShareParameters(0) = Me.Name Then
                    SetSubscribeCd(ShareParameters(3), ShareParameters(4))
                    GmainBusinessFunction.SetValue("화면 전환", vbNullString)
                End If
            Else
                If ShareParameters(0) = Me.Name Then
                    SetSubscribeCd(ShareParameters(1), ShareParameters(2))
                    GmainBusinessFunction.SetValue("화면 전환", vbNullString)
                End If
            End If
        End Sub

        ''' <summary>
        ''' 함수명 : SetBranchCd
        ''' 기  능 : 다른 화면에서 지국 코드 를 받아서 해당 지국내역을 조회 한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Public Sub SetSubscribeCd(ByVal strSubscribeCd As String, ByVal strSubscribeNm As String)
            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.popSubscribeCd_R.TextValue = strSubscribeCd  '독자코드 
            Me.popSubscribeCd_R.NameText = strSubscribeNm  '독자명

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub btnJumpRemoval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumpRemoval.Click

            '' ''MessageBox.Show(cboExpandDivCd.TextValue)

            If cboExpandDivCd.TextValue = "1" Then
                '' ''사원확장 독자 등록 화면으로 JUMP.
                If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
                Dim strCode As String '접수독자번호
                strCode = Me.dtpContactDt.TextValue _
                          & ";" & Me.dtpContactDt.TextValue _
                          & ";" & "" _
                          & ";" & "" _
                          & ";" & Me.txtReceiptCd.TextValue _
                          & ";" & Me.txtSubscriberNm.TextValue _
                          & ";" & "2"    '' '' 처리구분 2:이사독자신규입력
                GmainBusinessFunction.SetValue("화면 전환", "PNC102;" & strCode)
                Me.ShowUiControl("PNC102", strCode)
            Else
                '' ''지국확장 독자 등록 화면으로 JUMP.
                If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
                Dim strCode As String '접수독자번호
                strCode = Me.dtpContactDt.TextValue _
                          & ";" & Me.dtpContactDt.TextValue _
                          & ";" & Me.txtReceiptCd.TextValue _
                          & ";" & Me.txtSubscriberNm.TextValue _
                          & ";" & "2"    '' '' 처리구분 2:이사독자신규입력
                GmainBusinessFunction.SetValue("화면 전환", "PNC101;" & strCode)
                Me.ShowUiControl("PNC101", strCode)
            End If
        End Sub

        Private Sub btnJumpSat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumpSat.Click

            '' 토요가정 배달 접수등록 화면으로 JUMP.
            If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
            Dim strCode As String '접수독자번호
            strCode = Me.dtpContactDt.TextValue _
                      & ";" & Me.dtpContactDt.TextValue _
                      & ";" & Me.txtReceiptCd.TextValue _
                      & ";" & Me.txtSubscriberNm.TextValue 
            GmainBusinessFunction.SetValue("화면 전환", "PNC202;" & strCode)
            Me.ShowUiControl("PNC202", strCode)

        End Sub
        
        Private Sub btnExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpand.Click
            '지국확장 독자 등록 화면으로 JUMP.
            If txtReceiptCd.TextValue.ToString() = "" Then Exit Sub
            Dim strCode As String '접수독자번호
            strCode = Me.dtpContactDt.TextValue _
                      & ";" & Me.dtpContactDt.TextValue _
                      & ";" & Me.txtReceiptCd.TextValue _
                      & ";" & Me.txtSubscriberNm.TextValue _
                      & ";" & "3"    '' '' 처리구분 2:재확장입력
            GmainBusinessFunction.SetValue("화면 전환", "PNC101;" & strCode)
            Me.ShowUiControl("PNC101", strCode)
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            ' '' 1. 확장구분 cboExpandDivCd
            ' '' 2. 접수번호 txtReceiptCd
            ' '' 3. 독자번호
            ' '' 4. 전화번호
            ' ''    --> 확장구분코드|신규);where(Note1='사확'

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum1.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtPhoneNum2.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))

        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

            Dim sendArgs As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            sendArgs.Add("PhoneNum", Me.txtMobileNum.TextValue)
            SendPhonenumber("PN", Me.Name, sendArgs, GmainBusinessFunction.GetValue("로그인ID"))

        End Sub

     
        Private Sub cboCollectionTypeCd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCollectionTypeCd.SelectedIndexChanged

        End Sub

        Private Sub popDeliveryChnlCd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popDeliveryChnlCd.Load

        End Sub
    End Class

End Namespace
