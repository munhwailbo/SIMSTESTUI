'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 코드관리
' form 설명 : 문화일보 코드 관리
' 작성자 : 권진성
' 작성일 : 2008.09.01
'////////////////////////////////////////////////////////////////////////////////////////////////////

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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNJ303
        Inherits CommonControls.UiControl

        Dim blnApprovalAll As Boolean = False

        Private Sub PNJ303_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub


        ''' <summary>
        ''' 함수명 : Initialize
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            grd_1_Initialize()
            grd_2_Initialize()

        End Sub

        ''' <summary>
        ''' 함수명 : Initialize
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub grd_1_Initialize()

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"

            gridAttributes = gridAttributes & "|접수일자;ExpandDt;1;;4;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;85;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;85;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|청구상태;DmdStateCd;80;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구년월;DmdYYMM;80;;c;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|청구작업년월;ProcDmdYYMM;80;;c;" & "io;n;y;7;"
            gridAttributes = gridAttributes & "|최종배분년월;DistributionMM;80;;c;" & "o;n;n;7;"

            ''''''gridAttributes = gridAttributes & "|청구구분;DmdDivCd;80;;c;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|구독기간;DmdDt;117;;4;" & "o;n;n;40;"
            ''gridAttributes = gridAttributes & "|수금형태;CollectionDivCd;0;;1;" & "o;n;y;40;"
            ''gridAttributes = gridAttributes & "|청구방법;BillDivCd;88;;1;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|청구주기;BillPeriodCd;88;;1;" & "o;n;n;5;"
            ''gridAttributes = gridAttributes & "|유료구독시작년월;CollectionYYYYMM;108;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;75;#,###;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|청구액;DemandAmt;90;#,##0;7;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|수금액;CollectionAmt;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|배분액;DistributionAmt;90;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|미배분액;NoDistributionAmt;90;#,##0;7;" & "o;n;n;15;"
            'gridAttributes = gridAttributes & "|처리일자;ProcDt;90;;c;" & "io;n;n;15;"

            '' 청구 부수는 청구 계획 참고.. 이해 못하는 관계로 제외
            gridAttributes = gridAttributes & "|청구부수;DmdPapNum;1;#,###;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구대상액;PlanDmdAmount;1;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;77;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구대상총액;TotDemandAmt;100;#,##0;7;" & "o;n;n;15;"


            ' '' ''gridAttributes = gridAttributes & "|전월 구독료 누계;LastSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|본사수금구독료;SubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|공제액;DeductAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|이체액;TransferAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            ' '' ''gridAttributes = gridAttributes & "|미처리 구독료;RemainSubscriptionAmt;100;#,##0;r;" & "o;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|;Dummy;200;;l;" & "o;n;n;1000;"       '(80)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "DmdStateCd;본사수금청구상태코드"
            ''gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            ''gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            ''gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            ''gridCodeNameList = gridCodeNameList & "/DmdStateCd;본사수금청구상태코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 3
            Me.grd_1.FrozenCols = grd_1.get_ColIndex("DmdYYMM")

        End Sub


        ''' <summary>
        ''' 함수명 : Initialize
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub grd_2_Initialize()


            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"

            gridAttributes = gridAttributes & "|확장년월;CalYearMonths;80;;l;" & "io;n;y;8;"       '(20)
            gridAttributes = gridAttributes & "|연번;Orders;40;;c;" & "io;n;y;4;"       '(30)

            gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;85;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;85;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|지국코드;BranchNum;80;;l;" & "io;n;n;12;지국번호;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|지국명;BranchNm;100;;l;" & "o;n;n;12;"       '(10)

            gridAttributes = gridAttributes & "|부수;PaperNum;60;#,##0;c;" & "io;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|회수단가;SubsUnitAmt;60;#,##0;c;" & "io;n;n;4;"       '(80)
            gridAttributes = gridAttributes & "|구독료금액;SubscriptionAmt;100;#,##0;r;" & "io;n;n;4;"       '(80)

            gridAttributes = gridAttributes & "|배분년월(저장용);DisYearMonths;80;;l;" & "io;n;y;8;"       '(20)
            gridAttributes = gridAttributes & "|배분년월;DisYearMonths2;80;;l;" & "o;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|처리일자;ProcDt;80;;l;" & "io;n;n;8;"       '(110)
            ''gridAttributes = gridAttributes & "|대체여부;DeductYN;80;#,##0;r;" & "o;n;n;4;"       '(80)
            ''gridAttributes = gridAttributes & "|대체일자;DeductDt;80;#,##0;r;" & "io;n;n;4;"       '(80)
            ''gridAttributes = gridAttributes & "|대체금액;DeductAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)
            ''gridAttributes = gridAttributes & "|이체금액;TransferAmt;80;#,##0;r;" & "o;n;n;4;"       '(80)

            gridAttributes = gridAttributes & "|은행코드;BankCd;100;;l;" & "io;n;n;8;"            '(110)
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;130;;l;" & "io;n;n;8;"        '(110)
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;100;;l;" & "io;n;n;8;"       '(110)

            gridAttributes = gridAttributes & "|비고;Note;80;;l;" & "o;n;y;8;"       '(110)

            gridAttributes = gridAttributes & "|담당확인여부;RegYesOrNo;80;;l;" & "o;n;n;8;"       '(110)
            gridAttributes = gridAttributes & "|관리승인여부;ApplyYesOrNo;80;;l;" & "o;n;n;8;"       '(110)

            'gridAttributes = gridAttributes & "|확장처코드;CompanyCd;70;;c;" & "io;n;y;40;확장처 명;CompanyNm;"
            ' ''gridAttributes = gridAttributes & "|확장처명;CompanyNm;70;;l;" & "o;n;n;40;"

            ' ''gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;90;;c;" & "o;n;y;10;지국지역코드;;"
            ' ''gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;60;;c;" & "o;n;y;10;"

            ' ''gridAttributes = gridAttributes & "|청구방법;BillDivCd;60;;c;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;90;;c;" & "o;n;y;10;;"
            ' ''gridAttributes = gridAttributes & "|담당명;EmployeeNameHangul;60;;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "| ;JiRal;80;;l;" & "o;n;n;8;"       '(110)

            'grid_2 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BankCd;은행코드"
            '' ''gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"   ''2111
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_2.ExplorerBar = 3

        End Sub

        ''' <summary>
        ''' 함수명 : PNE421_Enter 
        ''' 기  능 : 화면 전환(사원확장 청구계획 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 5
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNJ303_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            ' ''Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            ' ''If ShareParameters(0) = Me.Name Then
            ' ''    SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4))
            ' ''    GmainBusinessFunction.SetValue("화면 전환", vbNullString)
            ' ''End If
        End Sub

        ''' <summary>
        ''' 함수명 : Request
        ''' 기  능 : 다른 화면에서 코드 를 받아서 해당 내역을 조회 한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Public Sub SetRequest(ByVal strBaseDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strEmployeeExpNum As String)
            '' ''다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            ' ''Me.dtpBaseDt_r.TextValue = strBaseDt  '기준일자
            ' ''Me.popCompanyCd.TextValue = strCompanyCd  '확장처번호
            ' ''Me.popCompanyCd.NameText = strCompanyNm  '확장처명
            ' ''Me.popEmployeeExpNum_R.TextValue = strEmployeeExpNum  '확장접수번호

            ' ''GrecordProcessMode = "2"   ' 조회 모드로 변경
            ' ''Me.GmainCommonFunction.GRequestDataNumber = 1
            ' ''CallByName(Me, "RequestData", CallType.Method)
        End Sub


        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            '' ''사원확장 독자 등록 화면으로 JUMP.
            ' ''If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            ' ''Dim strCode As String '접수독자번호
            ' ''Dim sdate As String
            ' ''sdate = dtpBaseYear.TextValue.Substring(0, 4) + "-" + "01"
            ' ''strCode = Me.dtpBaseYear.TextValue _
            ' ''          & ";" & Me.grd_1.GetCurrentRowCellValue("BranchNum") _
            ' ''          & ";" & sdate
            ' ''GmainBusinessFunction.SetValue("화면 전환", "PNI403;" & strCode)
            ' ''Me.ShowUiControl("PNI403", strCode)

        End Sub


        '' ''Private Sub optBaseProcDt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    If optBaseProcDt.Checked = True Then
        '' ''        sbOptBaseDtEnabled()
        '' ''    End If
        '' ''End Sub

        '' ''Private Sub optBaseDmdYM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' ''    If optBaseDmdYM.Checked = True Then
        '' ''        sbOptBaseDtEnabled()
        '' ''    End If
        '' ''End Sub

        Private Sub sbOptBaseDtEnabled()
            ' ''If optBaseProcDt.Checked = True Then
            ' ''    dtpBaseDtFr.Enabled = True
            ' ''    dtpBaseDtTo.Enabled = True
            ' ''Else
            ' ''    dtpBaseDtFr.Enabled = False
            ' ''    dtpBaseDtTo.Enabled = False
            ' ''End If

            ' ''If optBaseDmdYM.Checked = True Then
            ' ''    dtpDmdYMFr.Enabled = True
            ' ''    dtpDmdYMTo.Enabled = True
            ' ''Else
            ' ''    dtpDmdYMFr.Enabled = False
            ' ''    dtpDmdYMTo.Enabled = False
            ' ''End If
        End Sub

        Private Sub chkDmdYM_R_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDmdYM_R.CheckedChanged
            'If chkDmdYM_R.Checked = True Then
            dtpDmdYMFr.Enabled = chkDmdYM_R.Checked
            dtpDmdYMTo.Enabled = chkDmdYM_R.Checked
            'End If
        End Sub

        Private Sub chkDmd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDmd1.CheckedChanged
            If chkDmd1.Visible Then
                If chkDmd1.Checked = False And chkDmd2.Checked = False Then
                    'MsgBox(chkDmd1.Text.ToString & " 와 " & _
                    '       chkDmd2.Text.ToString & " 둘 중에" & _
                    '       vbCrLf & " 하나 이상은 반드시 체크가 되어 있어야 합니다. ", _
                    '       MsgBoxStyle.Information, "확인")
                    chkDmd1.Checked = True
                End If
            End If
        End Sub

        Private Sub chkDmd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDmd2.CheckedChanged
            If chkDmd2.Visible Then
                If chkDmd1.Checked = False And chkDmd2.Checked = False Then
                    'MsgBox(chkDmd1.Text.ToString & " 와 " & _
                    '       chkDmd2.Text.ToString & " 둘 중에" & _
                    '       vbCrLf & " 하나 이상은 반드시 체크가 되어 있어야 합니다. ", _
                    '       MsgBoxStyle.Information, "확인")
                    chkDmd2.Checked = True
                End If
            End If
        End Sub

        Private Sub BtnNewLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLine.Click
            RequestData2()
        End Sub

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                'If blnApprovalAll = False Then
                With grd_2
                    If (.Rows > .FixedRows) Then
                        For inti = .FixedRows To .Rows - 1
                            If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
                                .set_TextMatrix(inti, .get_ColIndex("ProcDt"), dtpProcDT.Text)
                                .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
                            End If
                        Next inti
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub picBar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBar.MouseHover
            Me.picBar.BackColor = Color.DarkGray
        End Sub

        Private Sub picBar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBar.MouseLeave
            Me.picBar.BackColor = Color.WhiteSmoke
        End Sub

        Private Sub picBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseDown
            picBar2.Visible = True
        End Sub

        Private Sub picBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseUp
            Dim pBar As Point = New Point(picBar2.Location.X, picBar2.Location.Y)
            Dim pPBox1 As Point = New Point(PictureBox1.Location.X, picBar2.Location.Y + PictureBox1.Location.Y - picBar.Location.Y)

            Dim pBtnNewLine As Point = New Point(BtnNewLine.Location.X, picBar2.Location.Y + BtnNewLine.Location.Y - picBar.Location.Y)
            Dim pLabel2 As Point = New Point(Label2.Location.X, picBar2.Location.Y + Label2.Location.Y - picBar.Location.Y)
            Dim pProcDT As Point = New Point(dtpProcDT.Location.X, picBar2.Location.Y + dtpProcDT.Location.Y - picBar.Location.Y)
            Dim pbtnApprovalAll As Point = New Point(btnApprovalAll.Location.X, picBar2.Location.Y + btnApprovalAll.Location.Y - picBar.Location.Y)

            Dim pPBox2 As Point = New Point(PictureBox2.Location.X, picBar2.Location.Y + PictureBox2.Location.Y - picBar.Location.Y)
            Dim pGrd2 As Point = New Point(grd_2.Location.X, picBar2.Location.Y + grd_2.Location.Y - picBar.Location.Y)
            '' PictureBox1, PictureBox2
            picBar2.Visible = False
            If pBar.Y >= grd_1.Location.Y + 20 And pBar.Y + 20 <= Me.Height Then
                picBar.Location = pBar
                ''grd_1.Width = 5
                PictureBox1.Location = pPBox1
                BtnNewLine.Location = pBtnNewLine
                Label2.Location = pLabel2
                dtpProcDT.Location = pProcDT
                btnApprovalAll.Location = pbtnApprovalAll

                PictureBox2.Location = pPBox2
                grd_2.Location = pGrd2

                Dim sGrd1 As Size = New Size(picBar.Width, picBar.Location.Y - grd_1.Location.Y)
                grd_1.Size = sGrd1
                Dim sGrd2 As Size = New Size(grd_1.Width, Me.Height - grd_2.Location.Y - 5)
                grd_2.Size = sGrd2
            End If
        End Sub

        Private Sub picBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseMove
            Dim p As Point = New Point(picBar.Location.X, picBar.Location.Y + e.Y)
            picBar2.Location = p
        End Sub

    End Class

End Namespace