'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSD105] 업체 수납 전표
' form 설명 :  [PSD105] 업체 수납 전표
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:08:04
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
 
    Public Class PSD105 
        Inherits CommonControls.UiControl  
 
        Private Sub PSD105_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            Dim gridAttributes_3 As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no) 
            gridAttributes_3 = gridAttributes_3 & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_3 = gridAttributes_3 & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes_3 = gridAttributes_3 & "|계산서발행년월;PubYYmm;6;;c;" & "io;n;y;;"  '' EpRceipt.PubYYmm 
            gridAttributes_3 = gridAttributes_3 & "|발행순번;PubSeq;0;;c;" & "io;n;y;;"  '' EpRceipt.PubSeq 
            gridAttributes_3 = gridAttributes_3 & "|수납일자;EpReceiptDate;8;;c;" & "io;n;y;;"  '' EpRceipt.EpReceiptDate 
            gridAttributes_3 = gridAttributes_3 & "|수납순번;EpReceiptSeq;0;;c;" & "io;n;y;;"  '' EpRceipt.EpReceiptSeq 
            gridAttributes_3 = gridAttributes_3 & "|수납번호;EpReceiptNumber;0;;c;" & "o;n;n;;"  '' EpRceipt.ReceiptSeq 
            gridAttributes_3 = gridAttributes_3 & "|수납적요;Remark;200;;l;" & "o;n;n;;"  '' EpRceipt.Remark 
            gridAttributes_3 = gridAttributes_3 & "|수납금액;EpReceiptAmt;19;#,##0;r;" & "o;n;n;;"  '' EpRceipt.EpReceiptAmt 
            gridAttributes_3 = gridAttributes_3 & "|수납전표;AccSlipNum;19;;c;" & "o;n;n;;"  '' EpRceipt.EpReceiptAmt 
            gridAttributes_3 = gridAttributes_3 & "|입금번호;ReceiptNumber;0;;c;" & "o;n;n;;"  '' EpRceipt.ReceiptSeq 
            gridAttributes_3 = gridAttributes_3 & "|입금일자;ReceiptDate;20;;c;" & "io;n;y;;"  '' EpRceipt.ReceiptDate 
            gridAttributes_3 = gridAttributes_3 & "|입금순번;ReceiptSeq;0;;c;" & "io;n;y;;"  '' EpRceipt.ReceiptSeq 
            gridAttributes_3 = gridAttributes_3 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;7;경리 거래처 코드;CustomerNm"  '' Receipt.CustomerCode 
            gridAttributes_3 = gridAttributes_3 & "|거래처명;CustomerNm;98;;l;" & "o;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|계좌코드;RcptAccNumCd;5;;c;" & "o;n;n;;"  '' Receipt.RcptAccNumCd 
            gridAttributes_3 = gridAttributes_3 & "|어음번호;ManagementNum;30;;c;" & "o;n;n;;"  '' Receipt.ManagementNum 
            gridAttributes_3 = gridAttributes_3 & "|입금액;ReceiptAmt;19;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptAmt 
            gridAttributes_3 = gridAttributes_3 & "|수수료금액;ReceiptFeeAmt;19;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptFeeAmt 
            gridAttributes_3 = gridAttributes_3 & "|입금적요;RcRemark;200;;l;" & "o;n;n;;"  '' Receipt.Remark 
            gridAttributes_3 = gridAttributes_3 & "| ;col_adjust;1;;c;" & "o;n;n;;"

            'grid code combo 
            Dim gridCodeNameList_3 As String = ""
            gridCodeNameList_3 = gridCodeNameList_3 & "RcptAccNumCd;입금계좌코드"   ''  : 입금계좌코드

            grd_1.Initialize(gridAttributes_3, gridCodeNameList_3)
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1

            optGb2.Checked = True
            dtpReceiptDateFr_R.Text = Now.ToString().Substring(0, 8) + "01"
            dtpReceiptDateTo_R.Text = Now.ToString()
 
        End Sub 
 
    End Class
End Namespace                                                                                                                                            