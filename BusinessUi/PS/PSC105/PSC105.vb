'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSC105] 매출 내역
' form 설명 :  [PSC105] 매출 내역
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:07:47
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
 
    Public Class PSC105 
        Inherits CommonControls.UiControl  
 
        Private Sub PSC105_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
             If Me.DesignMode = False Then                          
                 Me.Dock = DockStyle.Fill                           
        '' ''         Me.MinimumSize = New System.Drawing.Size(800, 640) 
                 Me.MinimumSize = New System.Drawing.Size(700, 500) 
             End If 
         End Sub    
 
        '==================================================================================================== 

        '==================================================================================================== 
        Public Sub Initialize()

            'grid를 초기화 한다. 
            '-------------------------------------------------- 
            Dim gridAttributes_1 As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no) 
            gridAttributes_1 = gridAttributes_1 & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_1 = gridAttributes_1 & "||선택;선택;37;;1;" & "io;n;n;;;"
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;52;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|담당;ChargeEmpNm;108;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|매출일자;SaleRegDate;81;yyyy-MM-dd;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|계산서일자;PubDate;84;yyyy-MM-dd;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|판매 코드;SimsNm;130;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|판매 코드;SimsCode;80;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|유가부수;Qty;70;#,##0;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|단가;Price;60;#,##0;7;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|청구금액;ttAmt;110;#,##0;7;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|매출액;srAmt;110;#,##0;7;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;130;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|계산서번호;TaxNumber;100;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|경리 코드;CustomerCode;80;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|경리 코드;CustomerNm;130;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|경리 코드;BizNum;100;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|경리 코드;RdstNum;120;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|담당사번;ChargeEmpNum;0;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|전표번호1;AccSlipNum;0;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|전표번호2;AccSlipNum2;0;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|;col_adjust;1;;4;" & "o;n;n;;"

            '#Region "그리드 주석"
            ' ''gridAttributes_1 = gridAttributes_1 & "||선택;선택;40;;l;" & "io;n;n;"
            ' ''gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            ' ''gridAttributes_1 = gridAttributes_1 & "|담당;ChargeEmpNm;30;;l;" & "o;n;n;;"  ''  
            ' ''gridAttributes_1 = gridAttributes_1 & "|매출일자;SaleRegDate;10;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            ' ''gridAttributes_1 = gridAttributes_1 & "|계산서일자;PubDate;10;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 

            ' ''gridAttributes_1 = gridAttributes_1 & "|업체명;SimsNm;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "|판매코드;SimsCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 

            ' ''gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "|거래처명;CustomerNm;7;;l;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "|사업자번호;BizNum;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "|주민번호;RdstNum;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 

            ' ''gridAttributes_1 = gridAttributes_1 & "|유가부수;Qty;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            ' ''gridAttributes_1 = gridAttributes_1 & "|단가;Price;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            ' ''gridAttributes_1 = gridAttributes_1 & "|청구금액;ttAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            ' ''gridAttributes_1 = gridAttributes_1 & "|매출액;srAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 

            ' ''gridAttributes_1 = gridAttributes_1 & "|적요;Remark;7;;l;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "|담당사번;ChargeEmpNum;30;;c;" & "o;n;n;;"  ''  
            ' ''gridAttributes_1 = gridAttributes_1 & "|계산서번호;TaxNumber;10;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            ' ''gridAttributes_1 = gridAttributes_1 & "|전표번호1;AccSlipNum;0;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "|전표번호2;AccSlipNum2;0;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;"
            '#End Region


            'grid code combo 
            Dim gridCodeNameList_1 As String = ""
            gridCodeNameList_1 = gridCodeNameList_1 & "SaleTypeCd;판매매출구분"   ''2111
            ''gridCodeNameList_1 = gridCodeNameList_1 & "/ASPBizCd;ASP 업체 명"   ''  : ASP 업체 명
            'gridCodeNameList_1 = gridCodeNameList_1 & "/TaxTypeCd;계산서구분"   ''2111

            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1)
            '-------------------------------------------------- 

            '----그리드 행병합--------------------------------- 
            Dim i As Integer = 0
            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "선택"
            strColName2 = strColName2 & ControlChars.Tab & "매출구분코드"
            strColName2 = strColName2 & ControlChars.Tab & "담당"
            strColName2 = strColName2 & ControlChars.Tab & "매출일자"
            strColName2 = strColName2 & ControlChars.Tab & "계산서일자"

            strColName2 = strColName2 & ControlChars.Tab & "업체명"
            strColName2 = strColName2 & ControlChars.Tab & "판매코드"
            strColName2 = strColName2 & ControlChars.Tab & "유가부수"
            strColName2 = strColName2 & ControlChars.Tab & "단가"
            strColName2 = strColName2 & ControlChars.Tab & "청구금액"
            strColName2 = strColName2 & ControlChars.Tab & "매출액"
            strColName2 = strColName2 & ControlChars.Tab & "적요"

            strColName2 = strColName2 & ControlChars.Tab & "계산서번호"
            strColName2 = strColName2 & ControlChars.Tab & "거래처코드"
            strColName2 = strColName2 & ControlChars.Tab & "거래처명"
            strColName2 = strColName2 & ControlChars.Tab & "사업자번호"
            strColName2 = strColName2 & ControlChars.Tab & "주민번호"

            strColName2 = strColName2 & ControlChars.Tab & "담당사번"
            strColName2 = strColName2 & ControlChars.Tab & "전표번호1"
            strColName2 = strColName2 & ControlChars.Tab & "전표번호2"
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

            optGb2.Checked = True
            dtpPubDateFr_R.Text = Now.ToString().Substring(0, 8) + "01"
            dtpPubDateTo_R.Text = Now.ToString()
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