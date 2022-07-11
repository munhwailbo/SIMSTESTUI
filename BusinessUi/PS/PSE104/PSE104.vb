'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSE104] 가수금 대체 수납 전표
' form 설명 :  [PSE104] 가수금 대체 수납 전표
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:08:33
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
 
    Public Class PSE104 
        Inherits CommonControls.UiControl  
 
        Private Sub PSE104_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "||선택;선택;40;;l;" & "io;n;y;"
            gridAttributes_1 = gridAttributes_1 & "|배부년월;DeliYYmm;6;;c;" & "o;n;n;;"  '' DeliveryList.DeliYYmm 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;;"  '' DeliveryList.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|거래처명;CustomerNm;30;;l;" & "o;n;n;;"  '' DeliveryList.CompanyCd 
            gridAttributes_1 = gridAttributes_1 & "|지국번호;BranchNum;12;;c;" & "o;n;n;;"  '' DeliveryList.EmployeeExpNum 
            gridAttributes_1 = gridAttributes_1 & "|지국명;BranchNm;30;;l;" & "o;n;n;;"  '' DeliveryList.CouponCorpCd 
            gridAttributes_1 = gridAttributes_1 & "|부수;DeliBusu;19;#,##0;r;" & "o;n;n;;"  '' DeliveryList.DeliBusu 
            gridAttributes_1 = gridAttributes_1 & "|단가;DeliPrice;19;#,##0;r;" & "o;n;n;;"  '' DeliveryList.DeliPrice 
            gridAttributes_1 = gridAttributes_1 & "|금액;DeliAmt;19;#,##0;r;" & "o;n;n;;"  '' DeliveryList.DeliAmt 
            gridAttributes_1 = gridAttributes_1 & "|비용전표번호;AccSlipNum;30;;c;" & "o;n;n;;"  '' DeliveryList.TaxYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;"


            'grid code combo 
            Dim gridCodeNameList_1 As String = ""

            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1)
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1

 
        End Sub 
 
    End Class
End Namespace                                                                                                                                            