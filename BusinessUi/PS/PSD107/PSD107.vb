'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSD107] 가수금 대체 내역 조회
' form 설명 :  [PSD107] 가수금 대체 내역 조회
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:08:13
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
 
    Public Class PSD107 
        Inherits CommonControls.UiControl  
 
        Private Sub PSD107_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;100;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 

            gridAttributes_1 = gridAttributes_1 & "|업   체;CustomerCode;62;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|업   체;CustomerNm;170;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|업   체;SimsCode;100;;4;" & "o;n;n;;"

            gridAttributes_1 = gridAttributes_1 & "|입금번호;RcpNumber;100;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|[일자];DispDate;85;;c;" & "o;n;n;;"  '' TotalTaxD.PubYYmm 
            '' 가수금(선수금)
            gridAttributes_1 = gridAttributes_1 & "|가수금(A);Amt_11;100;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            '' 가수금대체
            gridAttributes_1 = gridAttributes_1 & "|가수금대체;Amt_21;100;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            gridAttributes_1 = gridAttributes_1 & "|가수금대체;Amt_22;100;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            gridAttributes_1 = gridAttributes_1 & "|잔액(A-B-C);Amt_23;100;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 

            gridAttributes_1 = gridAttributes_1 & "|담당;ErpNm;100;;c;" & "o;n;n;;"  ''  
            gridAttributes_1 = gridAttributes_1 & "|입금번호;ReceiptDate;6;;c;" & "io;n;y;;"  '' TotalTaxD.PubYYmm 
            gridAttributes_1 = gridAttributes_1 & "|입금번호;ReceiptSeq;0;;c;" & "o;n;y;;"  '' TotalTaxD.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|수납번호;EpReceiptDate;6;;c;" & "o;n;y;;"  '' TotalTaxD.PubYYmm 
            gridAttributes_1 = gridAttributes_1 & "|수납번호;EpReceiptSeq;0;;c;" & "o;n;y;;"  '' TotalTaxD.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;"

            'grid code combo 
            Dim gridCodeNameList_1 As String = ""
            gridCodeNameList_1 = gridCodeNameList_1 & "SaleTypeCd;판매매출구분"   ''2111
            gridCodeNameList_1 = gridCodeNameList_1 & "/ErpNm;청구유형명"   '' 
            ''gridCodeNameList_1 = gridCodeNameList_1 & "/ASPBizCd;ASP 업체 명"   ''  : ASP 업체 명
            'gridCodeNameList_1 = gridCodeNameList_1 & "/TaxTypeCd;계산서구분"   ''2111

            ' ''gridAttributes_1 = gridAttributes_1 & "|입금일자;ReceiptDate;20;;c;" & "o;n;n;;"  '' Receipt.ReceiptDate 
            ' ''gridAttributes_1 = gridAttributes_1 & "|입금순번;ReceiptSeq;0;;c;" & "o;n;n;;"  '' Receipt.ReceiptSeq 
            ' ''gridAttributes_1 = gridAttributes_1 & "|입금시제코드;ReceiptType;5;;c;" & "o;n;n;;"  '' Receipt.ReceiptType 
            ' ''gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;;"  '' Receipt.CustomerCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "|계좌코드;AccountCode;5;;c;" & "o;n;n;;"  '' Receipt.AccountCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "|어음번호;ManagementNum;30;;c;" & "o;n;n;;"  '' Receipt.ManagementNum 
            ' ''gridAttributes_1 = gridAttributes_1 & "|입금액;ReceiptAmt;19;;c;" & "o;n;n;;"  '' Receipt.ReceiptAmt 
            ' ''gridAttributes_1 = gridAttributes_1 & "|수수료금액;ReceiptFeeAmt;19;;c;" & "o;n;n;;"  '' Receipt.ReceiptFeeAmt 
            ' ''gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;c;" & "o;n;n;;"  '' Receipt.Remark 
            ' ''gridAttributes_1 = gridAttributes_1 & "|회계전표번호;AccSlipNum;30;;c;" & "o;n;n;;"  '' Receipt.AccSlipNum 
            ' ''gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;" 

            '' ''grid code combo 
            ' ''Dim gridCodeNameList_1 As String = ""  
 
            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1) 
            '-------------------------------------------------- 
            '----그리드 행병합--------------------------------- 
            Dim i As Integer = 0
            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "선택"
            strColName2 = strColName2 & ControlChars.Tab & "매출구분코드"
            strColName2 = strColName2 & ControlChars.Tab & "업체코드"
            strColName2 = strColName2 & ControlChars.Tab & "업체명"
            strColName2 = strColName2 & ControlChars.Tab & "판매코드"

            strColName2 = strColName2 & ControlChars.Tab & "입금번호"
            strColName2 = strColName2 & ControlChars.Tab & "[일자]"

            strColName2 = strColName2 & ControlChars.Tab & "가수금(A)"
            strColName2 = strColName2 & ControlChars.Tab & "미수금대체(B)"
            strColName2 = strColName2 & ControlChars.Tab & "배달비대체(C)"
            strColName2 = strColName2 & ControlChars.Tab & "잔액(A-B-C)"

            strColName2 = strColName2 & ControlChars.Tab & "담당"
            strColName2 = strColName2 & ControlChars.Tab & "입금일자"
            strColName2 = strColName2 & ControlChars.Tab & "입금순번"
            strColName2 = strColName2 & ControlChars.Tab & "수납일자"
            strColName2 = strColName2 & ControlChars.Tab & "수납순번"
            '''' --- 
            strColName2 = strColName2 & ControlChars.Tab & ""

            With Me.grd_1
                .AddItem(strColName2)
                .FixedRows = 2
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly
                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next
                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next
            End With
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0 
            Me.grd_1.ExplorerBar = 1 
 
 
        End Sub 
 
    End Class
End Namespace                                                                                                                                            