'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSA101] 지대매출 등록
' form 설명 :  [PSA101] 지대매출 등록
' 작성자 : 
' 작성일 : 2013-11-28 오후 1:38:26
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
 
    Public Class PSA101 
        Inherits CommonControls.UiControl  
 
        Private Sub PSA101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "|지국번호;BranchNum;8;;c;" & "io;n;n;;"  '' SaleBase.BranchNum 
            gridAttributes_1 = gridAttributes_1 & "|지국명;BranchNm;7;;l;" & "o;n;n;;"  '' SaleBase.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "io;n;n;;"  '' SaleBase.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|매출부수;SaleBusu;0;#,##0;c;" & "io;n;n;;"  '' SaleBase.SaleBusu 
            gridAttributes_1 = gridAttributes_1 & "|매출단가;Price;0;#,##0;c;" & "io;n;n;;"  '' SaleBase.SaleBusu 
            gridAttributes_1 = gridAttributes_1 & "|매출금액;SaleAmt;19;#,##0;r;" & "io;n;n;;"  '' SaleBase.SaleAmt 
            gridAttributes_1 = gridAttributes_1 & "|계산서유무;TaxYesOrNo;0;;c;" & "io;n;n;;"  '' SaleBase.TaxYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|청구년월;CalYearMonths;70;;c;" & "io;n;n;;"  '' SaleBase.TaxYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|영업담당자;ChargeEmpNum;6;;c;" & "io;n;n;;"  '' SaleBase.ChargeEmpNum 
            gridAttributes_1 = gridAttributes_1 & "|영업담당명;ChargeEmpNm;6;;c;" & "o;n;n;;"  '' SaleBase.ChargeEmpNum 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;c;" & "io;n;n;;"  '' SaleBase.Remark 
            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;" 
 
            'grid code combo 
            Dim gridCodeNameList_1 As String = ""  
 
            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1) 
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0 
            Me.grd_1.ExplorerBar = 1 
 
            ''grid를 초기화 한다. 
            ''-------------------------------------------------- 
            ''Dim gridAttributes_2 As String = ""

            ' ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no) 
            ''gridAttributes_2 = gridAttributes_2 & "a;r;n"

            ' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            ' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            ''gridAttributes_2 = gridAttributes_2 & "||선택;선택;40;;l;" & "io;n;n;"  
            ''gridAttributes_2 = gridAttributes_2 & "|정산년월;CalYearMonths;6;;c;" & "io;n;n;;"  '' SIMS.dbo.Sales.CalYearMonths 
            ''gridAttributes_2 = gridAttributes_2 & "|지국번호;BranchNum;9;;c;" & "io;n;n;;"  '' SIMS.dbo.Sales.BranchNum 
            ''gridAttributes_2 = gridAttributes_2 & "|지국명;BranchNm;120;;l;" & "o;n;n;;"  '' SIMS.dbo.Sales.BranchNum 
            ''gridAttributes_2 = gridAttributes_2 & "|매출부수;SettlePaperNum;0;;c;" & "io;n;n;;"  '' SIMS.dbo.Sales.SettlePaperNum 
            ''gridAttributes_2 = gridAttributes_2 & "|매출액;SalesAmt;15;#,##0;r;" & "io;n;n;;"  '' SIMS.dbo.Sales.SalesAmt 
            ''gridAttributes_2 = gridAttributes_2 & "|비고;Note;1000;;c;" & "io;n;n;;"  '' SIMS.dbo.Sales.Note 
            ''gridAttributes_2 = gridAttributes_2 & "|매출처리일자;ProcessDt;8;;c;" & "io;n;n;;"  '' SIMS.dbo.Sales.ProcessDt 
            ''gridAttributes_2 = gridAttributes_2 & "|담당자사번;ChargeEmpNum;7;;c;" & "io;n;n;;"  '' SIMS.dbo.Sales.ChargeEmpNum 
            ''gridAttributes_2 = gridAttributes_2 & "| ;col_adjust;1;;c;" & "o;n;n;;" 

            ' ''grid code combo 
            ''Dim gridCodeNameList_2 As String = ""  

            ''grd_2.Initialize(gridAttributes_2, gridCodeNameList_2) 
            ' ''-------------------------------------------------- 
            ''Me.grd_2.ExplorerBar = 0 
            ''Me.grd_2.ExplorerBar = 1 
 
        End Sub 

        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
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