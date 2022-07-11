'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSA102] 사원확장 등록
' form 설명 :  [PSA102] 사원확장 등록
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:02:08
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
 
Imports C1.Win.C1FlexGrid 
Imports C1.Win.C1FlexGrid.Classic  
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic  
 
Namespace ubiLease.UI.BusinessUi.PS 
 
    Public Class PSA102 
        Inherits CommonControls.UiControl  
 
        Private Sub PSA102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
             If Me.DesignMode = False Then                          
                 Me.Dock = DockStyle.Fill                           
        '' ''         Me.MinimumSize = New System.Drawing.Size(800, 640) 
                 Me.MinimumSize = New System.Drawing.Size(700, 500) 
             End If 
         End Sub    
 
        '==================================================================================================== 
        Public Sub Initialize()  
 
            'grid를 초기화 한다. 
            '-------------------------------------------------- 
            Dim gridAttributes_1 As String = "" 
 
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no) 
            gridAttributes_1 = gridAttributes_1 & "a;r;y" 
 
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_1 = gridAttributes_1 & "||선택;선택;40;;l;" & "io;n;n;"  
            gridAttributes_1 = gridAttributes_1 & "|매출일자;SaleDate;20;;c;" & "io;n;n;;"  '' SaleBase.SaleDate 
            gridAttributes_1 = gridAttributes_1 & "|매출순번;SaleSeq;0;;c;" & "io;n;n;;"  '' SaleBase.SaleSeq 
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;5;;c;" & "io;n;y;;"  '' SaleBase.SaleTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|확장처코드;CompanyCd;12;;c;" & "io;n;n;;"  '' SaleBase.CompanyCd 
            gridAttributes_1 = gridAttributes_1 & "|확장처명;CompanyNm;12;;l;" & "o;n;n;;"  '' SaleBase.CompanyCd 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "io;n;n;;"  '' SaleBase.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|확장번호;EmployeeExpNum;30;;c;" & "io;n;n;;"  '' SaleBase.SystemMngCd 
            gridAttributes_1 = gridAttributes_1 & "|확장명;EmployeeExpNm;30;;l;" & "o;n;n;;"  '' SaleBase.SystemMngCd 
            gridAttributes_1 = gridAttributes_1 & "|매출부수;SaleBusu;0;#,##0;c;" & "io;n;n;;"  '' SaleBase.SaleBusu 
            gridAttributes_1 = gridAttributes_1 & "|매출단가;Price;0;#,##0;c;" & "io;n;y;;"  '' SaleBase.SaleBusu 
            gridAttributes_1 = gridAttributes_1 & "|매출금액;SaleAmt;19;#,##0;r;" & "io;n;n;;"  '' SaleBase.SaleAmt 
            gridAttributes_1 = gridAttributes_1 & "|청구주기코드;BillPeriodCd;5;;c;" & "io;n;n;;"  '' SaleBase.BillPeriodCd 
            gridAttributes_1 = gridAttributes_1 & "|구독시작일자;FixedStDate;20;;c;" & "io;n;n;;"  '' SaleBase.FixedStDate 
            gridAttributes_1 = gridAttributes_1 & "|구독종료일자;FixedEdDate;20;;c;" & "io;n;n;;"  '' SaleBase.FixedEdDate 
            gridAttributes_1 = gridAttributes_1 & "|계산서유무;TaxYesOrNo;0;;c;" & "io;n;n;;"  '' SaleBase.TaxYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|매출담당자;ChargeEmpNum;6;;c;" & "io;n;n;;"  '' SaleBase.ChargeEmpNum 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;c;" & "io;n;n;;"  '' SaleBase.Remark 
            gridAttributes_1 = gridAttributes_1 & "|시스템매출금액;systemSaleAmt;19;;c;" & "io;n;y;;"  '' SaleBase.systemSaleAmt 
            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;" 
 
            'grid code combo 
            Dim gridCodeNameList_1 As String = ""  
            gridCodeNameList_1 = gridCodeNameList_1 & "BillPeriodCd;수금주기코드"   ''2111

            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1)
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1
 
            'grid를 초기화 한다. 
            '-------------------------------------------------- 
            Dim gridAttributes_2 As String = "" 
 
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no) 
            gridAttributes_2 = gridAttributes_2 & "a;r;n"

            ' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            gridAttributes_2 = gridAttributes_2 & "||선택;선택;37;;1;" & "i;n;y;;;"
            gridAttributes_2 = gridAttributes_2 & "|사원확장번호;EmployeeExpNum;0;;4;" & "io;n;y;5;"
            gridAttributes_2 = gridAttributes_2 & "|접수일자;ExpandDt;85;yyyy-MM-dd;4;" & "io;n;n;5;"
            gridAttributes_2 = gridAttributes_2 & "|순번;Orders;0;;4;" & "io;n;y;5;"
            gridAttributes_2 = gridAttributes_2 & "|확장명;ExpandNm;100;;100;" & "io;n;n;50;"
            gridAttributes_2 = gridAttributes_2 & "|확장처코드;CompanyCd;98;;4;" & "io;n;n;40;확장처 명;CompanyNm"
            gridAttributes_2 = gridAttributes_2 & "|확장처명;CompanyNm;149;;1;" & "o;n;n;40;"
            gridAttributes_2 = gridAttributes_2 & "|접수;TargetPaperTotNum;37;;7;" & "io;n;n;5;"
            gridAttributes_2 = gridAttributes_2 & "|신규;NewExpPapNum;37;;7;" & "io;n;n;5;"
            gridAttributes_2 = gridAttributes_2 & "|재확장;ReExpPapNum;50;;7;" & "io;n;n;5;"
            gridAttributes_2 = gridAttributes_2 & "|명단없는부수;NoListPapNum;87;#,###;7;" & "io;n;n;5;"
            gridAttributes_2 = gridAttributes_2 & "|확정;FixedPaperNum;37;#,###;7;" & "io;n;n;5;"
            gridAttributes_2 = gridAttributes_2 & "|투입;SubscribePagerNum;37;#,###;7;" & "o;n;y;5;"         '임시로 숨김 02/17
            gridAttributes_2 = gridAttributes_2 & "|미투입;NoSubscribePagerNum;50;#,###;7;" & "o;n;y;5;"     '임시로 숨김 02/17  
            gridAttributes_2 = gridAttributes_2 & "|명단상태코드;ListStatCd;105;;1;" & "io;n;n;40;"
            gridAttributes_2 = gridAttributes_2 & "|수금형태코드;CollectionDivCd;87;;1;" & "io;n;n;40;"
            gridAttributes_2 = gridAttributes_2 & "|청구방법코드;BillDivCd;93;;1;" & "io;n;n;5;"
            gridAttributes_2 = gridAttributes_2 & "|청구주기코드;BillPeriodCd;87;;1;" & "io;n;n;5;"
            gridAttributes_2 = gridAttributes_2 & "|구독료단가;SubscriptionAmt;74;#,###;7;" & "io;n;n;5;"
            gridAttributes_2 = gridAttributes_2 & "|구독시작일자;FixedStDt;87;yyyy-MM-dd;4;" & "io;n;n;40;"
            gridAttributes_2 = gridAttributes_2 & "|구독만료일자;FixedEdDt;87;yyyy-MM-dd;4;" & "io;n;n;40;"
            gridAttributes_2 = gridAttributes_2 & "|지국전달사항;BranchNote;269;;1;" & "io;n;n;200;"
            gridAttributes_2 = gridAttributes_2 & "|승인여부;ApprovalYN;62;;4;" & "o;n;n;40;"
            gridAttributes_2 = gridAttributes_2 & "|승인일자;ApprovalDt;62;yyyy-MM-dd;4;" & "o;n;n;40;"
            gridAttributes_2 = gridAttributes_2 & "|비고;Note;291;;1;" & "io;n;n;40;"
            gridAttributes_2 = gridAttributes_2 & "|이전사원확장번호;OldEmployeeExpNum;0;;4;" & "io;n;y;5;"
            gridAttributes_2 = gridAttributes_2 & "|;Dummy;70;;4;" & "o;n;n;40;"

            ''gridAttributes_2 = gridAttributes_2 & "||선택;선택;40;;l;" & "io;n;n;"  
            ''gridAttributes_2 = gridAttributes_2 & "|사원확장번호;EmployeeExpNum;12;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.EmployeeExpNum 
            ''gridAttributes_2 = gridAttributes_2 & "|확장일자;ExpandDt;8;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.ExpandDt 
            ''gridAttributes_2 = gridAttributes_2 & "|순번;Orders;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.Orders 
            ''gridAttributes_2 = gridAttributes_2 & "|확장 명;ExpandNm;50;;c;" & "o;n;n;;"  '' SIMS.dbo.EmployeeExpand.ExpandNm 
            ''gridAttributes_2 = gridAttributes_2 & "|확장처코드;CompanyCd;12;;c;" & "o;n;n;;"  '' SIMS.dbo.EmployeeExpand.CompanyCd 
            ''gridAttributes_2 = gridAttributes_2 & "|접수부수;TargetPaperTotNum;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.TargetPaperTotNum 
            ''gridAttributes_2 = gridAttributes_2 & "|신규확장;NewExpPapNum;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.NewExpPapNum 
            ''gridAttributes_2 = gridAttributes_2 & "|재확장;ReExpPapNum;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.ReExpPapNum 
            ''gridAttributes_2 = gridAttributes_2 & "|명단없는부수;NoListPapNum;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.NoListPapNum 
            ''gridAttributes_2 = gridAttributes_2 & "|확정부수;FixedPaperNum;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.FixedPaperNum 
            ''gridAttributes_2 = gridAttributes_2 & "|투입부수;SubscribePagerNum;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.SubscribePagerNum 
            ''gridAttributes_2 = gridAttributes_2 & "|미투입부수;NoSubscribePapNum;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.NoSubscribePapNum 
            ''gridAttributes_2 = gridAttributes_2 & "|명단상태코드(2401);ListStatCd;50;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.ListStatCd 
            ''gridAttributes_2 = gridAttributes_2 & "|수금형태코드(2323);CollectionDivCd;10;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.CollectionDivCd 
            ''gridAttributes_2 = gridAttributes_2 & "|청구방법코드(2321);BillDivCd;10;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.BillDivCd 
            ''gridAttributes_2 = gridAttributes_2 & "|청구주기코드(2111);BillPeriodCd;10;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.BillPeriodCd 
            ''gridAttributes_2 = gridAttributes_2 & "|구독료단가;SubscriptionAmt;15;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.SubscriptionAmt 
            ''gridAttributes_2 = gridAttributes_2 & "|구독시작일자;FixedStDt;8;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.FixedStDt 
            ''gridAttributes_2 = gridAttributes_2 & "|구독만료일자;FixedEdDt;8;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.FixedEdDt 
            ''gridAttributes_2 = gridAttributes_2 & "|지국전달사항;BranchNote;200;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.BranchNote 
            ''gridAttributes_2 = gridAttributes_2 & "|승인여부;ApprovalYN;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.ApprovalYN 
            ''gridAttributes_2 = gridAttributes_2 & "|승인일자;ApprovalDt;8;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.ApprovalDt 
            ''gridAttributes_2 = gridAttributes_2 & "|비고;Note;1000;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.Note 
            ''gridAttributes_2 = gridAttributes_2 & "|이전사원확장번호;OldEmployeeExpNum;12;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.OldEmployeeExpNum 
            ''gridAttributes_2 = gridAttributes_2 & "|;ReContPapNum;0;;c;" & "io;n;n;;"  '' SIMS.dbo.EmployeeExpand.ReContPapNum 
            ''gridAttributes_2 = gridAttributes_2 & "| ;col_adjust;1;;c;" & "o;n;n;;" 
 
            'grid code combo 
            Dim gridCodeNameList_2 As String = ""  
            gridCodeNameList_2 = gridCodeNameList_2 & "ListStatCd;명단상태코드"    '' 2401
            gridCodeNameList_2 = gridCodeNameList_2 & "/CollectionDivCd;수금형태코드"   ''2323
            gridCodeNameList_2 = gridCodeNameList_2 & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList_2 = gridCodeNameList_2 & "/BillPeriodCd;수금주기코드"   ''2111
            grd_2.Initialize(gridAttributes_2, gridCodeNameList_2)
            '-------------------------------------------------- 
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 3

            dtpSaleDateFr_R.TextValue = Now.ToString.Substring(0, 7) & "01"

        End Sub 
 
#Region "화면 스필릿"
        ''' <summary>
        ''' ' 화면 스플릿 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>

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

            'Dim pBtnNewLine As Point = New Point(BtnNewLine.Location.X, picBar2.Location.Y + BtnNewLine.Location.Y - picBar.Location.Y)
            Dim plblTitle2 As Point = New Point(lblTitle2.Location.X, picBar2.Location.Y + lblTitle2.Location.Y - picBar.Location.Y)
            'Dim pProcDT As Point = New Point(dtpProcDT.Location.X, picBar2.Location.Y + dtpProcDT.Location.Y - picBar.Location.Y)
            'Dim pbtnApprovalAll As Point = New Point(btnApprovalAll.Location.X, picBar2.Location.Y + btnApprovalAll.Location.Y - picBar.Location.Y)

            'Dim pPBox2 As Point = New Point(PictureBox2.Location.X, picBar2.Location.Y + PictureBox2.Location.Y - picBar.Location.Y)
            Dim pGrd2 As Point = New Point(grd_2.Location.X, picBar2.Location.Y + grd_2.Location.Y - picBar.Location.Y)
            '' PictureBox1, PictureBox2
            picBar2.Visible = False
            If pBar.Y >= grd_1.Location.Y + 20 And pBar.Y + 20 <= Me.Height Then
                picBar.Location = pBar
                ''grd_1.Width = 5
                PictureBox1.Location = pPBox1
                'BtnNewLine.Location = pBtnNewLine
                lblTitle2.Location = plblTitle2
                'dtpProcDT.Location = pProcDT
                'btnApprovalAll.Location = pbtnApprovalAll

                'PictureBox2.Location = pPBox2
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
#End Region

        Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
            With grd_1
                If .Rows > .FixedRows Then
                    For II As Integer = .FixedRows To .Rows - 1
                        If .GetCellCheck(II, .get_ColIndex("선택")) = CheckEnum.Checked Then
                            .SetData(II, 2, dtpSaleDate.Text)
                            '                            .SetCellCheck(II, .get_ColIndex("선택"), CheckEnum.Checked)
                            '                        Else
                            '                           .SetCellCheck(II, .get_ColIndex("선택"), CheckEnum.Unchecked)
                        End If
                    Next
                End If
            End With
        End Sub
    End Class
End Namespace                                                                                                                                            