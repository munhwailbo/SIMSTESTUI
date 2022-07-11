'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSB101] 계산서 발행 내역 등록
' form 설명 :  [PSB101] 계산서 발행 내역 등록
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:03:07
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
 
    Public Class PSB101 
        Inherits CommonControls.UiControl  
 
        Private Sub PSB101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;6;;c;" & "o;n;n;;"  '' TotalTaxD.PubYYmm 
            gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;0;;c;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|발행일자;PubDate;20;;c;" & "o;n;n;;"  '' TotalTax.PubDate 
            gridAttributes_1 = gridAttributes_1 & "|계산서구분코드;TaxTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.TaxTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|공급가액;SupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            gridAttributes_1 = gridAttributes_1 & "|부가세액;TaxAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TaxAmt 
            gridAttributes_1 = gridAttributes_1 & "|합계액;TotalAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.TotalAmt 
            gridAttributes_1 = gridAttributes_1 & "|전자여부;ElectYesOrNo;0;;c;" & "o;n;n;;"  '' TotalTax.ElectYesOrNo 
            gridAttributes_1 = gridAttributes_1 & "|ASP업체코드;ASPBizCd;20;;c;" & "o;n;n;;"  '' TotalTax.ASPBizCd 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;l;" & "o;n;n;;"  '' TotalTax.Remark 
            gridAttributes_1 = gridAttributes_1 & "|사업자번호;BizNum;13;;c;" & "o;n;n;;"  '' TotalTax.BizNum 
            gridAttributes_1 = gridAttributes_1 & "|상호명;FirmName;30;;l;" & "o;n;n;;"  '' TotalTax.FirmName 
            gridAttributes_1 = gridAttributes_1 & "|대표자명;OwnerName;30;;l;" & "o;n;n;;"  '' TotalTax.OwnerName 
            gridAttributes_1 = gridAttributes_1 & "|사업장주소;FirmAddr;50;;l;" & "o;n;n;;"  '' TotalTax.FirmAddr 
            gridAttributes_1 = gridAttributes_1 & "|업태;BizType;30;;l;" & "o;n;n;;"  '' TotalTax.BizType 
            gridAttributes_1 = gridAttributes_1 & "|종목;BizItem;30;;l;" & "o;n;n;;"  '' TotalTax.BizItem 
            gridAttributes_1 = gridAttributes_1 & "|회계전표번호;AccSlipNum;30;;c;" & "o;n;n;;"  '' TotalTax.AccSlipNum 
            gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|삭제여부;DelYesOrNo;0;;c;" & "o;n;n;;"  '' TotalTax.DelYesOrNo 

            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;"
 
            'grid code combo 
            Dim gridCodeNameList_1 As String = ""  
            gridCodeNameList_1 = gridCodeNameList_1 & "SaleTypeCd;판매매출구분"   ''  : 판매매출구분
            gridCodeNameList_1 = gridCodeNameList_1 & "/TaxTypeCd;증빙 구분 명"   '' 632 : 증빙 구분 명
            gridCodeNameList_1 = gridCodeNameList_1 & "/ASPBizCd;ASP 업체 명"   ''  : ASP 업체 명

            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1) 
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0 
            Me.grd_1.ExplorerBar = 1 
 
            'grid를 초기화 한다. 
            '-------------------------------------------------- 
            Dim gridAttributes_3 As String = "" 
 
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no) 
            gridAttributes_3 = gridAttributes_3 & "a;r;n"
 
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_3 = gridAttributes_3 & "||선택;선택;37;;1;" & "io;n;n;;;"
            gridAttributes_3 = gridAttributes_3 & "|계산서발행년월;PubYYmm;0;yyyy-MM;4;" & "io;n;y;;"
            gridAttributes_3 = gridAttributes_3 & "|발행순번;PubSeq;0;;4;" & "io;n;y;;"
            gridAttributes_3 = gridAttributes_3 & "|상세순번;PubDSeq;62;;4;" & "io;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|품목;ItemName;129;;4;" & "io;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|단위;Unit;55;;4;" & "io;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|수량;Qty;57;#,##0;7;" & "io;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|단가;Price;61;#,##0;7;" & "io;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|공급가액;SupplyAmt;89;#,##0;7;" & "io;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|부가세액;TaxAmt;1;#,##0;7;" & "io;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|비고;Remark;150;;4;" & "io;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|기초금액;SaleAmt;1;#,##0;7;" & "o;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|기발행금액;PreSupplyAmt;1;#,##0;7;" & "o;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|미발행금액;NoSupplyAmt;1;#,##0;7;" & "o;n;n;;"
            gridAttributes_3 = gridAttributes_3 & "|매출일자;SaleDate;0;yyyy-MM-dd;4;" & "io;n;y;;"
            gridAttributes_3 = gridAttributes_3 & "|매출순번;SaleSeq;0;;4;" & "io;n;y;;"
            gridAttributes_3 = gridAttributes_3 & "|;col_adjust;1;;4;" & "o;n;n;;"

            ' ''gridAttributes_3 = gridAttributes_3 & "||선택;선택;40;;l;" & "io;n;n;"
            ' ''gridAttributes_3 = gridAttributes_3 & "|계산서발행년월;PubYYmm;6;;c;" & "io;n;y;;"  '' TotalTaxD.PubYYmm 
            ' ''gridAttributes_3 = gridAttributes_3 & "|발행순번;PubSeq;0;;c;" & "io;n;y;;"  '' TotalTaxD.PubSeq 
            ' ''gridAttributes_3 = gridAttributes_3 & "|상세순번;PubDSeq;0;;c;" & "io;n;n;;"  '' TotalTaxD.PubDSeq 
            ' ''gridAttributes_3 = gridAttributes_3 & "|품목;ItemName;30;;c;" & "io;n;n;;"  '' TotalTaxD.ItemName 
            ' ''gridAttributes_3 = gridAttributes_3 & "|단위;Unit;30;;c;" & "io;n;n;;"  '' TotalTaxD.Unit 
            ' ''gridAttributes_3 = gridAttributes_3 & "|수량;Qty;0;#,##0;r;" & "io;n;n;;"  '' TotalTaxD.Qty 
            ' ''gridAttributes_3 = gridAttributes_3 & "|단가;Price;19;#,##0;r;" & "io;n;n;;"  '' TotalTaxD.Price 
            ' ''gridAttributes_3 = gridAttributes_3 & "|공급가액;SupplyAmt;19;#,##0;r;" & "io;n;n;;"  '' TotalTaxD.SupplyAmt 
            ' ''gridAttributes_3 = gridAttributes_3 & "|부가세액;TaxAmt;19;#,##0;r;" & "io;n;n;;"  '' TotalTaxD.TaxAmt 
            ' ''gridAttributes_3 = gridAttributes_3 & "|비고;Remark;200;;c;" & "io;n;n;;"  '' TotalTaxD.Remark 
            ' ''gridAttributes_3 = gridAttributes_3 & "|기초금액;SaleAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            ' ''gridAttributes_3 = gridAttributes_3 & "|기발행금액;PreSupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            ' ''gridAttributes_3 = gridAttributes_3 & "|미발행금액;NoSupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTaxD.SupplyAmt 
            ' ''gridAttributes_3 = gridAttributes_3 & "|매출일자;SaleDate;8;;c;" & "io;n;y;;"  '' TotalTaxD.SaleDate 
            ' ''gridAttributes_3 = gridAttributes_3 & "|매출순번;SaleSeq;0;;c;" & "io;n;y;;"  '' TotalTaxD.SaleSeq 
            ' ''gridAttributes_3 = gridAttributes_3 & "| ;col_adjust;1;;c;" & "o;n;n;;"
 
            'grid code combo 
            Dim gridCodeNameList_3 As String = ""  

            grd_3.Initialize(gridAttributes_3, gridCodeNameList_3) 
            '-------------------------------------------------- 
            Me.grd_3.ExplorerBar = 0 
            Me.grd_3.ExplorerBar = 1 

            dtpPubDateFr_R.TextValue = Now.ToString.Substring(0, 7) & "01"

        End Sub 

        ''' <summary>
        ''' 함수명 : PSB101_Enter 
        ''' 기  능 : 화면 전환(계산서(건별)발행)
        Private Sub PSB101_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
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

        ''Private Sub optGb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''    If optGb1.Checked Then
        ''        dtpPubYYmm_R.Enabled = True
        ''        dtpPubDateFr_R.Enabled = False
        ''        dtpPubDateTo_R.Enabled = False
        ''    Else
        ''        dtpPubYYmm_R.Enabled = False
        ''        dtpPubDateFr_R.Enabled = True
        ''        dtpPubDateTo_R.Enabled = True
        ''    End If
        ''End Sub
 
        Private Sub btnReqSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReqSale.Click
            RequestData4()
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            SaveData()
        End Sub

        Private Sub btnDelRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelRow.Click
            If grd_3.Rows <= grd_3.FixedRows Then
                MessageBox.Show("삭제할 행이 존재하지 않습니다." & vbCrLf & " 확인후 작업하세요", "확인", MessageBoxButtons.OK)
                Exit Sub
            End If
            With grd_3
                If .Rows > .FixedRows Then
                    For i As Integer = .FixedRows To .Rows - 1
                        .SetData(i, 0, "삭제")
                    Next
                End If
            End With

        End Sub

    End Class
End Namespace                                                                                                                                            