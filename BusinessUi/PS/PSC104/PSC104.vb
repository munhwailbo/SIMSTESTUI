'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSC104] 업체 매출 전표
' form 설명 :  [PSC104] 업체 매출 전표
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:06:53
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
 
    Public Class PSC104 
        Inherits CommonControls.UiControl  
 
        Private Sub PSC104_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;0;;c;" & "io;n;y;;"  '' SaleRecognition.PubYYmm 
            gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;0;;c;" & "io;n;y;;"  '' SaleRecognition.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|인식순번;RegSeq;0;;c;" & "io;n;y;;"  '' SaleRecognition.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|매출확정일자;SaleRegDate;8;;c;" & "o;n;n;;"  '' SaleRecognition.SaleRegDate 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|거래처명;CustomerNm;30;;l;" & "o;n;n;;"  '' TotalTax.FirmName 
            gridAttributes_1 = gridAttributes_1 & "|매출인식금액;SaleRegAmt;19;#,##0;r;" & "o;n;n;;"  '' SaleRecognition.SaleRegAmt 
            gridAttributes_1 = gridAttributes_1 & "|매출전표번호;AccSlipNum;30;;c;" & "o;n;n;;" '' SaleRecognition.AccSlipNum 
            gridAttributes_1 = gridAttributes_1 & "|대체전표번호;AccSlipNum2;30;;c;" & "o;n;n;;" '' SaleRecognition.AccSlipNum 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;l;" & "o;n;n;;"  '' SaleRecognition.Remark 

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