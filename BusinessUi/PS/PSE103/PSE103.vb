'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSE103] 기타 비용 발생 전표
' form 설명 :  [PSE103] 기타 비용 발생 전표
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:08:30
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
 
    Public Class PSE103 
        Inherits CommonControls.UiControl  
 
        Private Sub PSE103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "|공제년월;DeduYYMM;63;yyyy-MM;4;" & "io;n;y;6;"
            gridAttributes_1 = gridAttributes_1 & "|공제순번;DeduSeq;0;yyyy-MM-dd;4;" & "io;n;y;20;"
            gridAttributes_1 = gridAttributes_1 & "|정산년월;YYYYMM;63;yyyy-MM;4;" & "io;n;n;6;"
            gridAttributes_1 = gridAttributes_1 & "|정산일자;CalDt;0;yyyy-MM-dd;4;" & "io;n;y;20;"
            gridAttributes_1 = gridAttributes_1 & "|담당사번;ChargeEmpNum;1;;4;" & "o;n;n;9;"
            gridAttributes_1 = gridAttributes_1 & "|담당명;ChargeEmpNm;50;;1;" & "o;n;n;9;"
            gridAttributes_1 = gridAttributes_1 & "|지국번호;BranchNum;62;;4;" & "io;n;n;9;"
            gridAttributes_1 = gridAttributes_1 & "|지국명;BranchNumNm;62;;1;" & "o;n;n;9;"
            gridAttributes_1 = gridAttributes_1 & "|지원항목코드;DivCd;87;;4;" & "io;n;y;10;"
            gridAttributes_1 = gridAttributes_1 & "|지원항목명;DivNm;99;;1;" & "o;n;y;10;"
            gridAttributes_1 = gridAttributes_1 & "|담당확인여부;RegYesOrNo;87;;1;" & "o;n;n;8;"
            gridAttributes_1 = gridAttributes_1 & "|관리승인여부;ApplyYesOrNo;87;;1;" & "o;n;n;8;"
            gridAttributes_1 = gridAttributes_1 & "|부수;PaperNum;0;#,##0;7;" & "o;n;y;4;"
            gridAttributes_1 = gridAttributes_1 & "|단가;UnitCost;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes_1 = gridAttributes_1 & "|지원비금액;SupAmt;74;#,##0;7;" & "o;n;n;15;"
            'gridAttributes_1 = gridAttributes_1 & "|대체여부;DeductYN;62;#,##0;7;" & "o;n;n;4;"
            'gridAttributes_1 = gridAttributes_1 & "|대체일자;DeductDt;62;yyyy-MM-dd;4;" & "o;n;n;4;"
            'gridAttributes_1 = gridAttributes_1 & "|대체금액;DeductAmt;62;#,##0;7;" & "o;n;n;15;"
            'gridAttributes_1 = gridAttributes_1 & "|이체금액;TransferAmt;62;#,##0;7;" & "o;n;n;15;"
            'gridAttributes_1 = gridAttributes_1 & "|은행코드;BankCd;0;;1;" & "o;n;y;20;"
            'gridAttributes_1 = gridAttributes_1 & "|계좌번호;AccountNum;0;;1;" & "o;n;y;20;"
            'gridAttributes_1 = gridAttributes_1 & "|예금주명;DepositorNm;0;;1;" & "o;n;y;30;"
            gridAttributes_1 = gridAttributes_1 & "|비용전표번호;AccSlipNum;37;;1;" & "o;n;n;30;"
            gridAttributes_1 = gridAttributes_1 & "|비고;Note;37;;1;" & "o;n;n;1000;"
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