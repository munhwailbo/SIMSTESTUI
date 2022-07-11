' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 사원확장접수독자등록
' form설명 : 사원확장접수독자등록 한다
' 작성자 : 신현갑
' 작성일 : 2008-09-19
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

    Public Class PNC102
        Inherits CommonControls.UiControl

#Region "폼 초기화"

        Public Sub Initialize()
            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;0;;1;" & "o;n;y;12;"
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;0;;1;" & "o;n;y;13;"
            gridAttributes = gridAttributes & "|접수일자;ContactDt;70;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|순번;Orders;32;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;122;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|접수;ContactPaperNum;34;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|전화1;PhoneNum1;87;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰;MobileNum;88;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;58;;4;" & "o;n;n;10;우편번호;OldAddr1"
            gridAttributes = gridAttributes & "|주소;OldAddr1;308;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;365;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;87;c;4;" & "o;n;n;7;지국코드;DeliveryBranchNm"
            gridAttributes = gridAttributes & "|투입지국명;DeliveryBranchNm;74;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국전달사항;Note2;87;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;87;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|구독코드;SubscribeCd;105;;1;" & "o;n;n;10;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------

            Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            Me.dtpReceiptDtTo.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd")

            Me.NewData()

        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC102_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub


        ''' <summary>
        ''' 함수명 : PNC102_Enter 
        ''' 기  능 : 화면 전환(사원확장 독자 접수 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC102_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")

            If ShareParameters.Length = 8 Then

                If ShareParameters(0) = Me.Name Then
                    SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5), ShareParameters(6), ShareParameters(7))
                    GmainBusinessFunction.SetValue("화면 전환", vbNullString)
                End If

            ElseIf ShareParameters.Length = 7 Then
                If ShareParameters(0) = Me.Name Then
                    SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5), ShareParameters(6))
                    GmainBusinessFunction.SetValue("화면 전환", vbNullString)
                End If

            ElseIf ShareParameters.Length = 6 Then

                If ShareParameters(0) = Me.Name Then
                    SetRequest2(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5))
                    GmainBusinessFunction.SetValue("화면 전환", vbNullString)
                End If

            End If
        End Sub

        ''' <summary>
        ''' 함수명 : Request
        ''' 기  능 : 다른 화면에서 코드 를 받아서 해당 내역을 조회 한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, _
                              ByVal strCompanyCd As String, ByVal strCompanyNm As String, _
                              ByVal strReceiptCd As String, ByVal strSubscriberNm As String, _
                              Optional ByVal strProcGb As String = "1")

            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.dtpReceiptDtFrom.TextValue = strFromDt  '시작일자
            Me.dtpReceiptDtTo.TextValue = strToDt      '종료일자
            Me.popCompanyCd_R.TextValue = strCompanyCd  '확장처번호
            Me.popCompanyCd_R.NameText = strCompanyNm  '확장처명
            Me.txtReceiptCd_2_R.TextValue = strReceiptCd  '접수독자번호
            Me.txtSubscriberNm_2_R.TextValue = strSubscriberNm  '접수독자명

            If strProcGb = "1" Then   '처리 구분 1:정상 조회
                GrecordProcessMode = "2"   ' 조회 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestData", CallType.Method)
            ElseIf strProcGb = "2" Then   '처리 구분 2:이사 독자 신규, 3:재확장 신규
                GrecordProcessMode = "1"   ' 신규 모드로 변경
                'Me.GmainCommonFunction.GRequestDataNumber = 9
                CallByName(Me, "RequestDataSubscribeRemove", CallType.Method)
            End If

        End Sub

        ''' <summary>
        ''' 함수명 : Request
        ''' 기  능 : 다른 화면에서 코드 를 받아서 해당 내역을 조회 한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Public Sub SetRequest2(ByVal strFromDt As String, ByVal strToDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strReceiptCd As String)

            Me.dtpReceiptDtFrom.TextValue = strFromDt  '시작일자
            Me.dtpReceiptDtTo.TextValue = strToDt      '종료일자


            Me.txtReceiptCd_2_R.TextValue = strCompanyCd  '접수독자번호
            Me.txtSubscriberNm_2_R.TextValue = strCompanyNm  '접수독자명

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

#End Region


        Private Sub btnPRB002_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRB002.Click

            '모니터 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            Dim strCode As String '접수독자번호
            strCode = Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ContactDt") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("ReceiptCd") _
                      & ";" & Me.grd_1.GetCurrentRowCellValue("SubscriberNm")
            GmainBusinessFunction.SetValue("화면 전환", "PNC105;" & strCode)
            Me.ShowUiControl("PNC105", strCode)

        End Sub

        '' 수금 여부 변경시
        Private Sub cboCollectionTypeCd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCollectionTypeCd.SelectedValueChanged
            SetDateSetting()
        End Sub

        '' 서비스 기간 셋팅시 투입 시작일 부터 개월수 추가 지정
        Private Sub numServiceTerm_TextChanged() Handles numServiceTerm.TextChanged
            ' 수금년월/서비스기간 셋팅
            SettingServiceTerms()
        End Sub

        ''투입일자변경시 1종료일 1년 지정
        'Private Sub dtpFixedStDt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFixedStDt.Leave
        '    If dtpFixedStDt.TextValue <> Nothing Then

        '        Dim dt As DateTime = dtpFixedStDt.Value.ToString("yyyy-MM-dd") ' 투입일자
        '        dtpFixedEdDt.TextValue = dt.AddYears(1).AddDays(-1).ToString("yyyy-MM-dd") ' 완료일자
        '        ' 수금년월/서비스기간 셋팅
        '        SettingServiceTerms()
        '    End If
        'End Sub

        '일자 자동 셋팅
        Private Sub SetDateSetting()
            If Me.cboCollectionTypeCd.TextValue = "2" Then
                ' 접수일자 
                Dim dt As DateTime = dtpContactDt.Value.ToString("yyyy-MM-dd")  ' 접수 일자
                dtpFixedStDt.TextValue = dt.AddDays(1).ToString("yyyy-MM-dd")   '투입일자
                dtpFixedEdDt.TextValue = dt.AddYears(1).ToString("yyyy-MM-dd") ' 완료일자
                ' 수금년월/서비스기간 셋팅
                SettingServiceTerms()
            End If
        End Sub

        Private Sub SettingServiceTerms()
            ''수금년월 변경
            If numServiceTerm.Text = "" Then
                numServiceTerm.Text = 0
            End If
            If dtpFixedStDt.TextValue <> Nothing Then
                dtpCollectionYYYYMM.TextValue = dtpFixedStDt.Value.AddMonths(numServiceTerm.Text).ToString("yyyy-MM-dd")
            End If

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

        Private Sub dtpFixedStDt_Dtp_TextChanged() Handles dtpFixedStDt.Dtp_TextChanged
            If dtpFixedStDt.TextValue <> Nothing And RequestMode = 0 Then
                Dim dt As DateTime = dtpFixedStDt.Value.ToString("yyyy-MM-dd") ' 투입일자
                dtpFixedEdDt.TextValue = dt.AddYears(1).AddDays(-1).ToString("yyyy-MM-dd") ' 완료일자
                ' 수금년월/서비스기간 셋팅
                SettingServiceTerms()
            End If
        End Sub


    End Class

End Namespace
