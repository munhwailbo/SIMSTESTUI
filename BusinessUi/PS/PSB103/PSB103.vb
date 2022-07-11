'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSB103] 계산서 출력
' form 설명 :  [PSB103] 계산서 출력
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:06:25
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
 
    Public Class PSB103 
        Inherits CommonControls.UiControl  
 
        Private Sub PSB103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;6;;c;" & "o;n;n;;"  '' TotalTax.PubYYmm 
            gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;0;;c;" & "o;n;n;;"  '' TotalTax.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|계산서번호;SeriesNum;6;;c;" & "io;n;y;;"  '' TotalTax.PubYYmm 
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|발행일자;PubDate;20;;c;" & "o;n;n;;"  '' TotalTax.PubDate 
            gridAttributes_1 = gridAttributes_1 & "|계산서구분코드;TaxTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.TaxTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|공급가액;SupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            gridAttributes_1 = gridAttributes_1 & "|부가세액;TaxAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TaxAmt 
            gridAttributes_1 = gridAttributes_1 & "|합계액;TotalAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TotalAmt 
            gridAttributes_1 = gridAttributes_1 & "|전자여부;ElectYesOrNo;0;;c;" & "o;n;n;;"  '' TotalTax.ElectYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|ASP업체코드;ASPBizCd;20;;c;" & "o;n;n;;"  '' TotalTax.ASPBizCd 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;c;" & "o;n;n;;"  '' TotalTax.Remark 
            gridAttributes_1 = gridAttributes_1 & "|사업자번호;BizNum;13;;c;" & "o;n;n;;"  '' TotalTax.BizNum 
            gridAttributes_1 = gridAttributes_1 & "|상호명;FirmName;30;;c;" & "o;n;n;;"  '' TotalTax.FirmName 
            gridAttributes_1 = gridAttributes_1 & "|대표자명;OwnerName;30;;c;" & "o;n;n;;"  '' TotalTax.OwnerName 
            gridAttributes_1 = gridAttributes_1 & "|사업장주소;FirmAddr;50;;c;" & "o;n;n;;"  '' TotalTax.FirmAddr 
            gridAttributes_1 = gridAttributes_1 & "|업태;BizType;30;;c;" & "o;n;n;;"  '' TotalTax.BizType 
            gridAttributes_1 = gridAttributes_1 & "|종목;BizItem;30;;c;" & "o;n;n;;"  '' TotalTax.BizItem 
            gridAttributes_1 = gridAttributes_1 & "|회계전표번호;AccSlipNum;30;;c;" & "o;n;n;;"  '' TotalTax.AccSlipNum 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|삭제여부;DelYesOrNo;0;;c;" & "o;n;n;;"  '' TotalTax.DelYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;" 
 
            'grid code combo 
            Dim gridCodeNameList_1 As String = ""  
            gridCodeNameList_1 = gridCodeNameList_1 & "SaleTypeCd;판매매출구분"   ''2111
            gridCodeNameList_1 = gridCodeNameList_1 & "/TaxTypeCd;증빙 구분 명"   '' 632 : 증빙 구분 명
            gridCodeNameList_1 = gridCodeNameList_1 & "/ASPBizCd;ASP 업체 명"   ''  : ASP 업체 명

            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1) 
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0 
            Me.grd_1.ExplorerBar = 1

            optGb2.Checked = True
            dtpPubDateFr_R.TextValue = Now.ToString.Substring(0, 7) & "01"

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

    End Class
End Namespace                                                                                                                                            