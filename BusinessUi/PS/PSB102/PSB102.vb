'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSB102] 계산서 일괄 발행 등록
' form 설명 :  [PSB102] 계산서 일괄 발행 등록
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:06:21
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
 
    Public Class PSB102 
        Inherits CommonControls.UiControl  
 
        Private Sub PSB102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;6;;c;" & "io;n;n;;"  '' TotalTaxD.PubYYmm 
            gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;0;;c;" & "io;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|발행일자;PubDate;20;;c;" & "io;n;n;;"  '' TotalTax.PubDate 
            gridAttributes_1 = gridAttributes_1 & "|계산서구분코드;TaxTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.TaxTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|거래처명;CustomerNm;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 

            gridAttributes_1 = gridAttributes_1 & "|공급가액;SupplyAmt;19;#,##0;r;" & "io;n;n;;"  '' TotalTax.SupplyAmt 
            'gridAttributes_1 = gridAttributes_1 & "|부가세액;TaxAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TaxAmt 
            'gridAttributes_1 = gridAttributes_1 & "|합계액;TotalAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TotalAmt 

            gridAttributes_1 = gridAttributes_1 & "|기초금액;SaleAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            gridAttributes_1 = gridAttributes_1 & "|기발행금액;PreSupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            gridAttributes_1 = gridAttributes_1 & "|미발행금액;NoSupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 

            gridAttributes_1 = gridAttributes_1 & "|전자여부;ElectYesOrNo;0;;c;" & "io;n;n;;"  '' TotalTax.ElectYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|ASP업체코드;ASPBizCd;20;;c;" & "io;n;n;;"  '' TotalTax.ASPBizCd 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;l;" & "io;n;n;;"  '' TotalTax.Remark 
            gridAttributes_1 = gridAttributes_1 & "|사업자번호;BizNum;13;;c;" & "o;n;n;;"  '' TotalTax.BizNum 
            gridAttributes_1 = gridAttributes_1 & "|상호명;FirmName;30;;c;" & "o;n;n;;"  '' TotalTax.FirmName 
            gridAttributes_1 = gridAttributes_1 & "|대표자명;OwnerName;30;;c;" & "o;n;n;;"  '' TotalTax.OwnerName 
            gridAttributes_1 = gridAttributes_1 & "|사업장주소;FirmAddr;50;;c;" & "o;n;n;;"  '' TotalTax.FirmAddr 
            gridAttributes_1 = gridAttributes_1 & "|업태;BizType;30;;c;" & "o;n;n;;"  '' TotalTax.BizType 
            gridAttributes_1 = gridAttributes_1 & "|종목;BizItem;30;;c;" & "o;n;n;;"  '' TotalTax.BizItem 
            gridAttributes_1 = gridAttributes_1 & "|회계전표번호;AccSlipNum;30;;c;" & "o;n;n;;"  '' TotalTax.AccSlipNum 
            gridAttributes_1 = gridAttributes_1 & "|삭제여부;DelYesOrNo;0;;c;" & "o;n;y;;"  '' TotalTax.DelYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|매출일자;SaleDate;8;;c;" & "io;n;y;;"  '' TotalTaxD.SaleDate 
            gridAttributes_1 = gridAttributes_1 & "|매출순번;SaleSeq;0;;c;" & "io;n;y;;"  '' TotalTaxD.SaleSeq 
            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;"
 
            'grid code combo 
            Dim gridCodeNameList_1 As String = ""  
            gridCodeNameList_1 = gridCodeNameList_1 & "SaleTypeCd;판매매출구분"   ''2111
            gridCodeNameList_1 = gridCodeNameList_1 & "/TaxTypeCd;증빙 구분 명"   '' 632 : 증빙 구분 명
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
            ''gridAttributes_2 = gridAttributes_2 & "|매출일자;SaleDate;8;;c;" & "io;n;n;;"  '' SaleBase.SaleDate 
            ''gridAttributes_2 = gridAttributes_2 & "|매출순번;SaleSeq;0;;c;" & "io;n;n;;"  '' SaleBase.SaleSeq 
            ''gridAttributes_2 = gridAttributes_2 & "|매출구분코드;SaleTypeCd;5;;c;" & "io;n;n;;"  '' SaleBase.SaleTypeCd 
            ''gridAttributes_2 = gridAttributes_2 & "|거래처코드;CustomerCode;7;;c;" & "io;n;n;;"  '' SaleBase.CustomerCode 
            ''gridAttributes_2 = gridAttributes_2 & "|지국번호;BranchNum;8;;c;" & "io;n;n;;"  '' SaleBase.BranchNum 
            ''gridAttributes_2 = gridAttributes_2 & "|확장처코드;CompanyCd;12;;c;" & "io;n;n;;"  '' SaleBase.CompanyCd 
            ''gridAttributes_2 = gridAttributes_2 & "|소속사코드;CouponCorpCd;10;;c;" & "io;n;n;;"  '' SaleBase.CouponCorpCd 
            ''gridAttributes_2 = gridAttributes_2 & "|매출부수;SaleBusu;0;;c;" & "io;n;n;;"  '' SaleBase.SaleBusu 
            ''gridAttributes_2 = gridAttributes_2 & "|매출금액;SaleAmt;19;;c;" & "io;n;n;;"  '' SaleBase.SaleAmt 
            ''gridAttributes_2 = gridAttributes_2 & "|청구주기코드;BillPeriodCd;5;;c;" & "io;n;n;;"  '' SaleBase.BillPeriodCd 
            ''gridAttributes_2 = gridAttributes_2 & "|구독시작일자;FixedStDate;20;;c;" & "io;n;n;;"  '' SaleBase.FixedStDate 
            ''gridAttributes_2 = gridAttributes_2 & "|구독종료일자;FixedEdDate;20;;c;" & "io;n;n;;"  '' SaleBase.FixedEdDate 
            ''gridAttributes_2 = gridAttributes_2 & "|계산서유무;TaxYesOrNo;0;;c;" & "io;n;n;;"  '' SaleBase.TaxYesOrNo 
            ''gridAttributes_2 = gridAttributes_2 & "|매출담당자;ChargeEmpNum;6;;c;" & "io;n;n;;"  '' SaleBase.ChargeEmpNum 
            ''gridAttributes_2 = gridAttributes_2 & "|적요;Remark;200;;c;" & "io;n;n;;"  '' SaleBase.Remark 
            ''gridAttributes_2 = gridAttributes_2 & "|내부관리코드;SystemMngCd;30;;c;" & "io;n;n;;"  '' SaleBase.SystemMngCd 
            ''gridAttributes_2 = gridAttributes_2 & "|시스템매출금액;systemSaleAmt;19;;c;" & "io;n;n;;"  '' SaleBase.systemSaleAmt 
            ''gridAttributes_2 = gridAttributes_2 & "| ;col_adjust;1;;c;" & "o;n;n;;" 
            gridAttributes_2 = gridAttributes_2 & "|계산서발행년월;PubYYmm;6;;c;" & "io;n;y;;"  '' TotalTaxD.PubYYmm 
            gridAttributes_2 = gridAttributes_2 & "|발행순번;PubSeq;0;;c;" & "io;n;y;;"  '' TotalTaxD.PubSeq 
            gridAttributes_2 = gridAttributes_2 & "|상세순번;PubDSeq;0;;c;" & "io;n;n;;"  '' TotalTaxD.PubDSeq 
            gridAttributes_2 = gridAttributes_2 & "|품목;ItemName;30;;c;" & "io;n;n;;"  '' TotalTaxD.ItemName 
            gridAttributes_2 = gridAttributes_2 & "|단위;Unit;30;;c;" & "io;n;n;;"  '' TotalTaxD.Unit 
            gridAttributes_2 = gridAttributes_2 & "|수량;Qty;0;#,##0;r;" & "io;n;n;;"  '' TotalTaxD.Qty 
            gridAttributes_2 = gridAttributes_2 & "|단가;Price;19;#,##0;r;" & "io;n;n;;"  '' TotalTaxD.Price 
            gridAttributes_2 = gridAttributes_2 & "|공급가액;SupplyAmt;19;#,##0;r;" & "io;n;n;;"  '' TotalTaxD.SupplyAmt 
            gridAttributes_2 = gridAttributes_2 & "|부가세액;TaxAmt;19;#,##0;r;" & "io;n;n;;"  '' TotalTaxD.TaxAmt 
            gridAttributes_2 = gridAttributes_2 & "|비고;Remark;200;;c;" & "io;n;n;;"  '' TotalTaxD.Remark 
            gridAttributes_2 = gridAttributes_2 & "|기초금액;SaleAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            gridAttributes_2 = gridAttributes_2 & "|기발행금액;PreSupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            gridAttributes_2 = gridAttributes_2 & "|미발행금액;NoSupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            gridAttributes_2 = gridAttributes_2 & "|매출일자;SaleDate;8;;c;" & "io;n;y;;"  '' TotalTaxD.SaleDate 
            gridAttributes_2 = gridAttributes_2 & "|매출순번;SaleSeq;0;;c;" & "io;n;y;;"  '' TotalTaxD.SaleSeq 
            gridAttributes_2 = gridAttributes_2 & "| ;col_adjust;1;;c;" & "o;n;n;;"

            'grid code combo 
            Dim gridCodeNameList_2 As String = ""  
 
            grd_2.Initialize(gridAttributes_2, gridCodeNameList_2) 
            '-------------------------------------------------- 
            Me.grd_2.ExplorerBar = 0 
            Me.grd_2.ExplorerBar = 1 

            optGb2.Checked = True
            dtpPubDateFr_R.TextValue = Now.ToString.Substring(0, 7) & "01"
            chkSaleDateYesOrNo.BackColor = picTitle1.BackColor
            chkSaleDateYesOrNo.Visible = False
            dtpSaleDate_All.Visible = False
            btnSaleDate_All.Visible = False
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

#Region "화면 스플릿"
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
            Dim pPBox2 As Point = New Point(picTitle2.Location.X, picBar2.Location.Y + picTitle2.Location.Y - picBar.Location.Y)
            Dim plblTitle2 As Point = New Point(lblTitle2.Location.X, picBar2.Location.Y + lblTitle2.Location.Y - picBar.Location.Y)
            Dim plblTitle21 As Point = New Point(lblTitle21.Location.X, picBar2.Location.Y + lblTitle21.Location.Y - picBar.Location.Y)
            Dim plblTitle22 As Point = New Point(lblTitle22.Location.X, picBar2.Location.Y + lblTitle22.Location.Y - picBar.Location.Y)
            Dim pdtpSaleDateFr_R As Point = New Point(dtpSaleDateFr_R.Location.X, picBar2.Location.Y + dtpSaleDateFr_R.Location.Y - picBar.Location.Y)
            Dim pdtpSaleDateTo_R As Point = New Point(dtpSaleDateTo_R.Location.X, picBar2.Location.Y + dtpSaleDateTo_R.Location.Y - picBar.Location.Y)
            Dim pbtnReqSale As Point = New Point(btnReqSale.Location.X, picBar2.Location.Y + btnReqSale.Location.Y - picBar.Location.Y)
            Dim pbtnSave As Point = New Point(btnSave.Location.X, picBar2.Location.Y + btnSave.Location.Y - picBar.Location.Y)
            Dim pGrd2 As Point = New Point(grd_2.Location.X, picBar2.Location.Y + grd_2.Location.Y - picBar.Location.Y)

            picBar2.Visible = False
            If pBar.Y >= grd_1.Location.Y + 20 And pBar.Y + 20 <= Me.Height Then
                picBar.Location = pBar
                picTitle2.Location = pPBox2
                lblTitle2.Location = plblTitle2
                lblTitle21.Location = plblTitle21
                lblTitle22.Location = plblTitle22
                dtpSaleDateFr_R.Location = pdtpSaleDateFr_R
                dtpSaleDateTo_R.Location = pdtpSaleDateTo_R
                btnReqSale.Location = pbtnReqSale
                btnSave.Location = pbtnSave
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

        Private Sub btnReqSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReqSale.Click
            RequestData2()
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            SaveData()
        End Sub

        Private Sub chkSaleDateYesOrNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSaleDateYesOrNo.CheckedChanged
            If chkSaleDateYesOrNo.Checked Then
                dtpSaleDate_All.Visible = True
                btnSaleDate_All.Visible = True
            Else
                dtpSaleDate_All.Visible = False
                btnSaleDate_All.Visible = False
            End If
        End Sub

        Private Sub btnSaleDate_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaleDate_All.Click
            With grd_1
                If .Rows > .FixedRows Then
                    For II As Integer = .FixedRows To .Rows - 1
                        If .GetCellCheck(II, .get_ColIndex("선택")) = CheckEnum.Checked Then
                            .SetData(II, .get_ColIndex("PubDate"), dtpSaleDate_All.Text)
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