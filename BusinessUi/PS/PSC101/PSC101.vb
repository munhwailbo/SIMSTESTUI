'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSC101] 매출 처리 등록
' form 설명 :  [PSC101] 매출 처리 등록
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:06:45
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
 
    Public Class PSC101 
        Inherits CommonControls.UiControl  
 
        Private Sub PSC101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "a;r;n"
 
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_1 = gridAttributes_1 & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;80;;c;" & "io;n;y;;"  '' TotalTaxD.PubYYmm 
            gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;1;;c;" & "io;n;y;;"  '' TotalTaxD.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|계산서번호;TaxNumber;100;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;80;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|발행일자;PubDate;85;;c;" & "o;n;n;;"  '' TotalTax.PubDate 
            gridAttributes_1 = gridAttributes_1 & "|계산서구분코드;TaxTypeCd;5;;80;" & "o;n;y;;"  '' TotalTax.TaxTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;1;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|거래처명;CustomerNm;150;;l;" & "o;n;n;;"  '' TotalTax.CustomerCode 

            gridAttributes_1 = gridAttributes_1 & "|공급가액;SupplyAmt;100;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            'gridAttributes_1 = gridAttributes_1 & "|부가세액;TaxAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TaxAmt 
            'gridAttributes_1 = gridAttributes_1 & "|합계액;TotalAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TotalAmt 
            gridAttributes_1 = gridAttributes_1 & "|매출계획금액;SalePlanAmt;100;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            gridAttributes_1 = gridAttributes_1 & "|미계획금액;SaleUnPlanAmt;100;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 

            'gridAttributes_1 = gridAttributes_1 & "|기초금액;SaleAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            gridAttributes_1 = gridAttributes_1 & "|매출확정금액;SaleRegAmt;100;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            gridAttributes_1 = gridAttributes_1 & "|미반영금액;SaleUnRegAmt;100;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 

            gridAttributes_1 = gridAttributes_1 & "|회계전표번호;AccSlipNum;100;;c;" & "o;n;n;;"  '' TotalTax.AccSlipNum 

            gridAttributes_1 = gridAttributes_1 & "|전자여부;ElectYesOrNo;60;;c;" & "o;n;n;;"  '' TotalTax.ElectYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|ASP업체코드;ASPBizCd;90;;c;" & "o;n;n;;"  '' TotalTax.ASPBizCd 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;150;;l;" & "o;n;n;;"  '' TotalTax.Remark 
            gridAttributes_1 = gridAttributes_1 & "|사업자번호;BizNum;90;;c;" & "o;n;n;;"  '' TotalTax.BizNum 
            gridAttributes_1 = gridAttributes_1 & "|상호명;FirmName;100;;l;" & "o;n;n;;"  '' TotalTax.FirmName 
            gridAttributes_1 = gridAttributes_1 & "|대표자명;OwnerName;50;;c;" & "o;n;n;;"  '' TotalTax.OwnerName 
            gridAttributes_1 = gridAttributes_1 & "|사업장주소;FirmAddr;80;;l;" & "o;n;n;;"  '' TotalTax.FirmAddr 
            gridAttributes_1 = gridAttributes_1 & "|업태;BizType;60;;l;" & "o;n;n;;"  '' TotalTax.BizType 
            gridAttributes_1 = gridAttributes_1 & "|종목;BizItem;60;;l;" & "o;n;n;;"  '' TotalTax.BizItem 
            gridAttributes_1 = gridAttributes_1 & "|삭제여부;DelYesOrNo;80;;c;" & "o;n;y;;"  '' TotalTax.DelYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|매출일자;SaleDate;85;;c;" & "o;n;y;;"  '' TotalTaxD.SaleDate 
            gridAttributes_1 = gridAttributes_1 & "|매출순번;SaleSeq;50;;c;" & "o;n;y;;"  '' TotalTaxD.SaleSeq 
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
            gridAttributes_2 = gridAttributes_2 & "a;r;n"
 
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_2 = gridAttributes_2 & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes_2 = gridAttributes_2 & "|발행년월;PubYYmm;80;;c;" & "io;n;y;;"  '' SalePlan.PubYYmm 
            gridAttributes_2 = gridAttributes_2 & "|발행순번;PubSeq;1;;c;" & "io;n;y;;"  '' SalePlan.PubSeq 
            gridAttributes_2 = gridAttributes_2 & "|계산서번호;TaxNumber;100;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_2 = gridAttributes_2 & "|순번;PlanSeq;40;;c;" & "io;n;y;;"  '' SalePlan.PlanDate 
            gridAttributes_2 = gridAttributes_2 & "|매출계획일자;PlanDate;90;;c;" & "o;n;n;;"  '' SalePlan.PlanDate 
            gridAttributes_2 = gridAttributes_2 & "|매출계획금액;SalePlanAmt;90;#,##0;r;" & "o;n;n;;"  '' SalePlan.SalePlanAmt 
            gridAttributes_2 = gridAttributes_2 & "|매출인식금액;SaleRegAmt;90;#,##0;r;" & "o;n;n;;"  '' SalePlan.SalePlanAmt 
            gridAttributes_2 = gridAttributes_2 & "|비고;Remark;150;;l;" & "o;n;n;;"  '' SalePlan.Remark 
            gridAttributes_2 = gridAttributes_2 & "| ;col_adjust;1;;c;" & "o;n;n;;"

            'grid code combo 
            Dim gridCodeNameList_2 As String = ""  
 
            grd_2.Initialize(gridAttributes_2, gridCodeNameList_2) 
            '-------------------------------------------------- 
            Me.grd_2.ExplorerBar = 0 
            Me.grd_2.ExplorerBar = 1 
 
            'grid를 초기화 한다. 
            '-------------------------------------------------- 
            Dim gridAttributes_3 As String = "" 
 
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no) 
            gridAttributes_3 = gridAttributes_3 & "a;r;n"
 
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_3 = gridAttributes_3 & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes_3 = gridAttributes_3 & "|발행년월;PubYYmm;80;;c;" & "io;n;y;;"  '' SalePlan.PubYYmm 
            gridAttributes_3 = gridAttributes_3 & "|발행순번;PubSeq;1;;c;" & "io;n;y;;"  '' SalePlan.PubSeq 
            gridAttributes_3 = gridAttributes_3 & "|계산서번호;TaxNumber;100;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_3 = gridAttributes_3 & "|순번;RegSeq;40;;c;" & "io;n;n;;"  '' SalePlan.PlanDate 
            gridAttributes_3 = gridAttributes_3 & "|매출확정일자;SaleRegDate;90;;c;" & "io;n;n;;"  '' SalePlan.PlanDate 
            gridAttributes_3 = gridAttributes_3 & "|매출확정금액;SaleRegAmt;100;#,##0;r;" & "io;n;n;;"  '' SalePlan.SalePlanAmt 
            gridAttributes_3 = gridAttributes_3 & "|수량;Qty;60;#,##0;c;" & "io;n;n;;"  '' SalePlan.SalePlanAmt 
            gridAttributes_3 = gridAttributes_3 & "|단가;Price;80;#,##0;r;" & "io;n;n;;"  '' SalePlan.SalePlanAmt 
            gridAttributes_3 = gridAttributes_3 & "|비고;Remark;150;;l;" & "io;n;n;;"  '' SalePlan.Remark 
            gridAttributes_3 = gridAttributes_3 & "|매출인식전표;AccSlipNum;100;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_3 = gridAttributes_3 & "|선수금반제전표;AccSlipNum2;100;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_3 = gridAttributes_3 & "| ;col_adjust;1;;c;" & "o;n;n;;"

            'grid code combo 
            Dim gridCodeNameList_3 As String = ""  
 
            grd_3.Initialize(gridAttributes_3, gridCodeNameList_3) 
            '-------------------------------------------------- 
            Me.grd_3.ExplorerBar = 0 
            Me.grd_3.ExplorerBar = 1 

            dtpPubDateFr_R.Text = Now.ToString().Substring(0, 8) + "01"
            dtpPubDateTo_R.Text = Now.ToString()
            dtpPubYYmm_R.Text = ""
        End Sub

        'Private Sub optGb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    If optGb1.Checked Then
        '        dtpPubYYmm_R.Enabled = True
        '        dtpPubDateFr_R.Enabled = False
        '        dtpPubDateTo_R.Enabled = False
        '    Else
        '        dtpPubYYmm_R.Enabled = False
        '        dtpPubDateFr_R.Enabled = True
        '        dtpPubDateTo_R.Enabled = True
        '    End If
        'End Sub

        ''' <summary>
        ''' 함수명 : PSC101_Enter 
        ''' 기  능 : 화면 전환(매출 (건별)처리등록)
        Private Sub PSC101_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")

            If ShareParameters(0) = Me.Name Then
                '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.               
                Me.cboSaleTypeCd_R.TextValue = ShareParameters(1) '판매매출구분                           
                Me.popCustomerCode_R.TextValue = ShareParameters(2) '거래처코드   
                Dim sTaxNumber As String = Replace(ShareParameters(3), "-", "")
                Me.dtpPubYYmm_R.TextValue = sTaxNumber.ToString.Substring(0, 6) '계산서번호                         
                Me.numPubSeq_R.TextValue = sTaxNumber.ToString.Substring(6, 5) '계산서번호                         
                Me.dtpPubDateFr_R.TextValue = Replace(ShareParameters(4), "-", "") '거래 일자                             
                Me.dtpPubDateTo_R.TextValue = Replace(ShareParameters(5), "-", "") '거래 일자                             

                GrecordProcessMode = "2"   '조회 모드로 변경
                Me.GmainCommonFunction.GRequestDataNumber = 1
                CallByName(Me, "RequestData", CallType.Method)
                GmainBusinessFunction.SetValue("화면 전환", vbNullString)
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
            Dim pBarY As Point = New Point(picBarY.Location.X, picBar2.Location.Y + 2)
            Dim pBarY2 As Point = New Point(picBarY2.Location.X, picBar2.Location.Y + 2)
            Dim pPBox2 As Point = New Point(picTitle2.Location.X, picBar2.Location.Y + picTitle2.Location.Y - picBar.Location.Y)
            Dim pPBox3 As Point = New Point(picTitle3.Location.X, picBar2.Location.Y + picTitle3.Location.Y - picBar.Location.Y)

            Dim pbtnReqSale As Point = New Point(btnReqSale.Location.X, picBar2.Location.Y + btnReqSale.Location.Y - picBar.Location.Y)
            Dim pbtnRowAdd As Point = New Point(btnRowAdd.Location.X, picBar2.Location.Y + btnRowAdd.Location.Y - picBar.Location.Y)

            Dim plblTitle2 As Point = New Point(lblTitle2.Location.X, picBar2.Location.Y + lblTitle2.Location.Y - picBar.Location.Y)
            Dim plblTitle3 As Point = New Point(lblTitle3.Location.X, picBar2.Location.Y + lblTitle3.Location.Y - picBar.Location.Y)
            Dim pGrd2 As Point = New Point(grd_2.Location.X, picBar2.Location.Y + grd_2.Location.Y - picBar.Location.Y)
            Dim pGrd3 As Point = New Point(grd_3.Location.X, picBar2.Location.Y + grd_3.Location.Y - picBar.Location.Y)
            '' PictureBox1, PictureBox2
            picBar2.Visible = False
            If pBar.Y >= grd_1.Location.Y + 20 And pBar.Y + 20 <= Me.Height Then
                picBar.Location = pBar
                picBarY.Location = pBarY
                picBarY2.Location = pBarY2
                ''grd_1.Width = 5
                picTitle2.Location = pPBox2
                picTitle3.Location = pPBox3

                btnReqSale.Location = pbtnReqSale
                btnRowAdd.Location = pbtnRowAdd

                lblTitle2.Location = plblTitle2
                lblTitle3.Location = plblTitle3
                grd_2.Location = pGrd2
                grd_3.Location = pGrd3

                Dim sPBarY As Size = New Size(picBarY.Width, Me.Height - picBarY.Location.Y - 5)
                picBarY.Size = sPBarY
                Dim sPBarY2 As Size = New Size(picBarY2.Width, Me.Height - picBarY2.Location.Y - 5)
                picBarY2.Size = sPBarY2

                Dim sGrd1 As Size = New Size(picBar.Width, picBar.Location.Y - grd_1.Location.Y)
                grd_1.Size = sGrd1
                Dim sGrd2 As Size = New Size(grd_2.Width, Me.Height - grd_2.Location.Y - 5)
                grd_2.Size = sGrd2
                Dim sGrd3 As Size = New Size(grd_1.Width - grd_2.Width - 5, Me.Height - grd_3.Location.Y - 5)
                grd_3.Size = sGrd3
            End If
        End Sub
        Private Sub picBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBar.MouseMove
            Dim p As Point = New Point(picBar.Location.X, picBar.Location.Y + e.Y)
            picBar2.Location = p
        End Sub
#End Region

#Region "PicBarY "
        Private Sub picBarY_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBarY.MouseHover
            Me.picBarY.BackColor = Color.DarkGray
        End Sub
        Private Sub picBarY_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBarY.MouseLeave
            Me.picBarY.BackColor = Color.WhiteSmoke
        End Sub
        Private Sub picBarY_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBarY.MouseDown
            picBarY2.Visible = True
        End Sub
        Private Sub picBarY_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBarY.MouseUp
            Dim pBarY As Point = New Point(picBarY2.Location.X, picBarY2.Location.Y)
            ''Dim plblTitle2 As Point = New Point(lblTitle2.Location.X, picBarY2.Location.Y)
            Dim plblTitle3 As Point = New Point(picBarY2.Location.X + lblTitle3.Location.X - picBarY.Location.X, lblTitle3.Location.Y)
            ''Dim pPBox2 As Point = New Point(picTitle2.Location.X, picBarY2.Location.Y)
            Dim pPBox3 As Point = New Point(picBarY2.Location.X + picTitle3.Location.X - picBarY.Location.X, picTitle3.Location.Y)

            Dim pbtnReqSale As Point = New Point(picBarY2.Location.X + btnReqSale.Location.X - picBarY.Location.X, btnReqSale.Location.Y)
            Dim pbtnRowAdd As Point = New Point(picBarY2.Location.X + btnRowAdd.Location.X - picBarY.Location.X, btnRowAdd.Location.Y)

            Dim pGrd3 As Point = New Point(picBarY2.Location.X + grd_3.Location.X - picBarY.Location.X, grd_3.Location.Y)

            picBarY2.Visible = False
            If pBarY.X >= 100 And pBarY.X + 70 <= Me.Width Then
                picBarY.Location = pBarY
                ' ''grd_2.Width = 5
                ''' lblTitle2.Location = plblTitle2
                lblTitle3.Location = plblTitle3
                'picTitle2.Location = pPBox2
                picTitle3.Location = pPBox3

                btnReqSale.Location = pbtnReqSale
                btnRowAdd.Location = pbtnRowAdd

                grd_3.Location = pGrd3

                Dim sPTitle2 As Size = New Size(picBarY.Location.X - picTitle2.Location.X, picTitle3.Height)
                picTitle2.Size = sPTitle2
                Dim sPTitle3 As Size = New Size(Me.Width - picTitle3.Location.X - 5, picTitle3.Height)
                picTitle3.Size = sPTitle3
                Dim sGrd2 As Size = New Size(picBarY.Location.X - grd_2.Location.X, grd_2.Height)
                grd_2.Size = sGrd2
                Dim sGrd3 As Size = New Size(Me.Width - grd_3.Location.X - 5, grd_3.Height)
                grd_3.Size = sGrd3
            End If
        End Sub
        Private Sub picBarY_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBarY.MouseMove
            Dim p As Point = New Point(picBarY.Location.X + e.X, picBarY2.Location.Y)
            picBarY2.Location = p
        End Sub
#End Region

        Private Sub btnRowAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRowAdd.Click
            grd_3.AddRow()
            grd_3.set_TextMatrix(grd_3.Rows - 1, 0, "신규")
            grd_3.set_TextMatrix(grd_3.Rows - 1, grd_3.get_ColIndex("PubYYmm"), Me.grd_1.GetCurrentRowCellValue("PubYYmm"))
            grd_3.set_TextMatrix(grd_3.Rows - 1, grd_3.get_ColIndex("PubSeq"), Me.grd_1.GetCurrentRowCellValue("PubSeq"))
        End Sub

        Private Sub btnReqSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReqSale.Click
            RequestData4()
        End Sub

    End Class
End Namespace                                                                                                                                            