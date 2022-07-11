'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSA104] 기타매출자료 등록
' form 설명 :  [PSA104] 기타매출자료 등록
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:02:54
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
 
    Public Class PSA104 
        Inherits CommonControls.UiControl  
 
        Private Sub PSA104_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "|매출일자;SaleDate;8;;c;" & "io;n;n;;"  '' SaleBase.SaleDate 
            gridAttributes_1 = gridAttributes_1 & "|매출순번;SaleSeq;0;;c;" & "io;n;n;;"  '' SaleBase.SaleSeq 
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;5;;c;" & "io;n;n;;"  '' SaleBase.SaleTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "io;n;n;;"  '' SaleBase.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|확장처코드;CompanyCd;12;;c;" & "io;n;n;;"  '' SaleBase.CompanyCd 
            gridAttributes_1 = gridAttributes_1 & "|소속사코드;CouponCorpCd;10;;c;" & "io;n;n;;"  '' SaleBase.CouponCorpCd 
            gridAttributes_1 = gridAttributes_1 & "|매출부수;SaleBusu;0;#,##0;r;" & "io;n;n;;"  '' SaleBase.SaleBusu 
            gridAttributes_1 = gridAttributes_1 & "|단가;Price;19;#,##0;c;" & "io;n;n;;"  '' SaleBase.Price 
            gridAttributes_1 = gridAttributes_1 & "|매출금액;SaleAmt;19;#,##0;r;" & "io;n;n;;"  '' SaleBase.SaleAmt 
            gridAttributes_1 = gridAttributes_1 & "|청구주기코드;BillPeriodCd;5;;c;" & "io;n;n;;"  '' SaleBase.BillPeriodCd 
            gridAttributes_1 = gridAttributes_1 & "|구독시작일자;FixedStDate;8;;c;" & "io;n;n;;"  '' SaleBase.FixedStDate 
            gridAttributes_1 = gridAttributes_1 & "|구독종료일자;FixedEdDate;8;;c;" & "io;n;n;;"  '' SaleBase.FixedEdDate 
            gridAttributes_1 = gridAttributes_1 & "|계산서유무;TaxYesOrNo;0;;c;" & "io;n;n;;"  '' SaleBase.TaxYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|매출담당자;ChargeEmpNum;6;;c;" & "io;n;n;;"  '' SaleBase.ChargeEmpNum 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;c;" & "io;n;n;;"  '' SaleBase.Remark 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|시스템매출금액;systemSaleAmt;19;#,##0;r;" & "io;n;y;;"  '' SaleBase.systemSaleAmt 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|정산년월;CalYearMonths;6;;c;" & "io;n;y;;"  '' SaleBase.CalYearMonths 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|지국번호;BranchNum;8;;c;" & "io;n;y;;"  '' SaleBase.BranchNum 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|사원확장번호;EmployeeExpNum;12;;c;" & "io;n;y;;"  '' SaleBase.EmployeeExpNum 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|작성일자;ProcDT;8;;c;" & "io;n;y;;"  '' SaleBase.ProcDT 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|순번;ProcOrders;0;;c;" & "io;n;y;;"  '' SaleBase.ProcOrders 
            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;" 
 
            'grid code combo 
            Dim gridCodeNameList_1 As String = ""
            gridCodeNameList_1 = gridCodeNameList_1 & "SaleTypeCd;판매매출구분"   ''(2501) 판매매출구분 
            gridCodeNameList_1 = gridCodeNameList_1 & "/BillPeriodCd;수금주기코드"   ''2111

            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1) 
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0 
            Me.grd_1.ExplorerBar = 1 
 
        End Sub 
 
    End Class
End Namespace                                                                                                                                            