'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSB105] 매출증빙(독자명단)등록
' form 설명 :  [PSB105] 매출증빙(독자명단)등록
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:06:34
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
 
    Public Class PSB105 
        Inherits CommonControls.UiControl  
 
        Private Sub PSB105_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;6;;c;" & "io;n;y;;"  '' TotalTaxD.PubYYmm 
            gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;0;;c;" & "io;n;y;;"  '' TotalTaxD.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|계산서번호;TaxNumber;0;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|발행일자;PubDate;20;;c;" & "o;n;n;;"  '' TotalTax.PubDate 
            gridAttributes_1 = gridAttributes_1 & "|계산서구분코드;TaxTypeCd;5;;c;" & "o;n;y;;"  '' TotalTax.TaxTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|거래처명;CustomerNm;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 

            gridAttributes_1 = gridAttributes_1 & "|공급가액;SupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            'gridAttributes_1 = gridAttributes_1 & "|부가세액;TaxAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TaxAmt 
            'gridAttributes_1 = gridAttributes_1 & "|합계액;TotalAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TotalAmt 
            gridAttributes_1 = gridAttributes_1 & "|명단등록부수;RegCnt;19;#,##0;c;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            
            'gridAttributes_1 = gridAttributes_1 & "|기초금액;SaleAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            'gridAttributes_1 = gridAttributes_1 & "|기발행금액;PreSupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            'gridAttributes_1 = gridAttributes_1 & "|미발행금액;NoSupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 

            gridAttributes_1 = gridAttributes_1 & "|전자여부;ElectYesOrNo;0;;c;" & "o;n;n;;"  '' TotalTax.ElectYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|ASP업체코드;ASPBizCd;20;;c;" & "o;n;n;;"  '' TotalTax.ASPBizCd 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;l;" & "o;n;n;;"  '' TotalTax.Remark 
            gridAttributes_1 = gridAttributes_1 & "|사업자번호;BizNum;13;;c;" & "o;n;n;;"  '' TotalTax.BizNum 
            gridAttributes_1 = gridAttributes_1 & "|상호명;FirmName;30;;c;" & "o;n;n;;"  '' TotalTax.FirmName 
            gridAttributes_1 = gridAttributes_1 & "|대표자명;OwnerName;30;;c;" & "o;n;n;;"  '' TotalTax.OwnerName 
            gridAttributes_1 = gridAttributes_1 & "|사업장주소;FirmAddr;50;;c;" & "o;n;n;;"  '' TotalTax.FirmAddr 
            gridAttributes_1 = gridAttributes_1 & "|업태;BizType;30;;c;" & "o;n;n;;"  '' TotalTax.BizType 
            gridAttributes_1 = gridAttributes_1 & "|종목;BizItem;30;;c;" & "o;n;n;;"  '' TotalTax.BizItem 
            gridAttributes_1 = gridAttributes_1 & "|회계전표번호;AccSlipNum;30;;c;" & "o;n;n;;"  '' TotalTax.AccSlipNum 
            gridAttributes_1 = gridAttributes_1 & "|삭제여부;DelYesOrNo;0;;c;" & "o;n;y;;"  '' TotalTax.DelYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|매출일자;SaleDate;8;;c;" & "o;n;y;;"  '' TotalTaxD.SaleDate 
            gridAttributes_1 = gridAttributes_1 & "|매출순번;SaleSeq;0;;c;" & "o;n;y;;"  '' TotalTaxD.SaleSeq 
            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;"

            'grid code combo 
            Dim gridCodeNameList_1 As String = ""
            gridCodeNameList_1 = gridCodeNameList_1 & "SaleTypeCd;판매매출구분"   ''2111
            gridCodeNameList_1 = gridCodeNameList_1 & "/ASPBizCd;ASP 업체 명"   ''  : ASP 업체 명
            'gridCodeNameList_1 = gridCodeNameList_1 & "/TaxTypeCd;계산서구분"   ''2111

            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1) 
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0 
            Me.grd_1.ExplorerBar = 1 
 
            'grid를 초기화 한다. 
            '-------------------------------------------------- 
            Dim gridAttributes_2 As String = "" 
 
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no) 
            gridAttributes_2 = gridAttributes_2 & "a;r;y" 
 
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_2 = gridAttributes_2 & "||선택;선택;40;;l;" & "io;n;n;"  
            gridAttributes_2 = gridAttributes_2 & "|계산서발행년월;PubYYmm;6;;c;" & "io;n;y;;"  '' SaleRegister.PubYYmm 
            gridAttributes_2 = gridAttributes_2 & "|발행순번;PubSeq;0;;c;" & "io;n;y;;"  '' SaleRegister.PubSeq 
            gridAttributes_2 = gridAttributes_2 & "|계산서번호;TaxNumber;0;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_2 = gridAttributes_2 & "|명단순번;RegSeq;0;;c;" & "io;n;n;;"  '' SaleRegister.RegSeq 
            gridAttributes_2 = gridAttributes_2 & "|구독번호;SubscribeCd;12;;c;" & "io;n;n;;"  '' SaleRegister.SubscribeCd 
            gridAttributes_2 = gridAttributes_2 & "|독자명;SubscriberNm;200;;l;" & "io;n;n;;"  '' SaleRegister.SubscribeCd 
            gridAttributes_2 = gridAttributes_2 & "|핸드폰;MobileNum;120;;l;" & "io;n;n;;"  '' SaleRegister.Remark 
            gridAttributes_2 = gridAttributes_2 & "|주소;Addr;200;;l;" & "io;n;n;;"  '' SaleRegister.Remark 
            gridAttributes_2 = gridAttributes_2 & "|전화번호;PhoneNum1;200;;l;" & "io;n;n;;"  '' SaleRegister.Remark 
            gridAttributes_2 = gridAttributes_2 & "|부수;FixedBusu;0;;c;" & "io;n;n;;"  '' SaleRegister.FixedBusu 
            gridAttributes_2 = gridAttributes_2 & "|비고;Remark;200;;l;" & "io;n;n;;"  '' SaleRegister.Remark 
            gridAttributes_2 = gridAttributes_2 & "| ;col_adjust;1;;c;" & "o;n;n;;" 
 
            'grid code combo 
            Dim gridCodeNameList_2 As String = ""  
 
            grd_2.Initialize(gridAttributes_2, gridCodeNameList_2) 
            '-------------------------------------------------- 
            Me.grd_2.ExplorerBar = 0 
            Me.grd_2.ExplorerBar = 1 

            optGb2.Checked = True
            dtpPubDateFr_R.Text = Now.ToString().Substring(0, 8) + "01"
            dtpPubDateTo_R.Text = Now.ToString()
        End Sub 

        Private Sub optGb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGb1.CheckedChanged, optGb2.CheckedChanged
            If optGb1.Checked Then
                dtpPubYYmm_R.Enabled = True
                dtpPubDateFr_R.Enabled = False
                dtpPubDateTo_R.Enabled = False
            Else
                dtpPubYYmm_R.Enabled = False
                dtpPubDateFr_R.Enabled = True
                dtpPubDateTo_R.Enabled = True
            End If
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

            Dim plblTitle2 As Point = New Point(lblTitle2.Location.X, picBar2.Location.Y + lblTitle2.Location.Y - picBar.Location.Y)
            Dim plblBillPeriodCd As Point = New Point(lblBillPeriodCd.Location.X, picBar2.Location.Y + lblBillPeriodCd.Location.Y - picBar.Location.Y)
            Dim plblCompanyCd As Point = New Point(lblCompanyCd.Location.X, picBar2.Location.Y + lblCompanyCd.Location.Y - picBar.Location.Y)
            Dim ppopCompanyCd As Point = New Point(popCompanyCd.Location.X, picBar2.Location.Y + popCompanyCd.Location.Y - picBar.Location.Y)
            Dim ppopEmployeeExpNum As Point = New Point(popEmployeeExpNum.Location.X, picBar2.Location.Y + popEmployeeExpNum.Location.Y - picBar.Location.Y)
            Dim pbtnReqSale As Point = New Point(btnReqSale.Location.X, picBar2.Location.Y + btnReqSale.Location.Y - picBar.Location.Y)
            Dim pbtnRowAdd As Point = New Point(btnRowAdd.Location.X, picBar2.Location.Y + btnRowAdd.Location.Y - picBar.Location.Y)

            'Dim pPBox2 As Point = New Point(PictureBox2.Location.X, picBar2.Location.Y + PictureBox2.Location.Y - picBar.Location.Y)
            Dim pGrd2 As Point = New Point(grd_2.Location.X, picBar2.Location.Y + grd_2.Location.Y - picBar.Location.Y)
            '' PictureBox1, PictureBox2
            picBar2.Visible = False
            If pBar.Y >= grd_1.Location.Y + 20 And pBar.Y + 20 <= Me.Height Then
                picBar.Location = pBar
                ''grd_1.Width = 5
                PictureBox1.Location = pPBox1
                lblTitle2.Location = plblTitle2
                lblCompanyCd.Location = plblCompanyCd
                lblBillPeriodCd.Location = plblBillPeriodCd
                popCompanyCd.Location = ppopCompanyCd
                popEmployeeExpNum.Location = ppopEmployeeExpNum
                btnReqSale.Location = pbtnReqSale
                btnRowAdd.Location = pbtnRowAdd

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

        Private Sub btnRowAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRowAdd.Click
            grd_2.AddRow()
            grd_2.set_TextMatrix(grd_2.Rows - 1, 0, "신규")
            grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("PubYYmm"), Me.grd_1.GetCurrentRowCellValue("PubYYmm"))
            grd_2.set_TextMatrix(grd_2.Rows - 1, grd_2.get_ColIndex("PubSeq"), Me.grd_1.GetCurrentRowCellValue("PubSeq"))

        End Sub

        Private Sub btnReqSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReqSale.Click
            RequestData3()
        End Sub
    End Class
End Namespace                                                                                                                                            