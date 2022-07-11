'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSD104] 업체 수납 등록
' form 설명 :  [PSD104] 업체 수납 등록
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:08:01
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
 
    Public Class PSD104 
        Inherits CommonControls.UiControl  
 
        Private Sub PSD104_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "a;r;N"
 
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_1 = gridAttributes_1 & "||선택;선택;40;;l;" & "io;n;y;"
            gridAttributes_1 = gridAttributes_1 & "|입금일자;ReceiptDate;20;;c;" & "o;n;y;;"  '' Receipt.ReceiptDate 
            gridAttributes_1 = gridAttributes_1 & "|입금순번;ReceiptSeq;0;;c;" & "o;n;y;;"  '' Receipt.ReceiptSeq 
            gridAttributes_1 = gridAttributes_1 & "|입금번호;ReceiptNumber;110;;l;" & "o;n;n;;"  '' Receipt.ReceiptDate 
            gridAttributes_1 = gridAttributes_1 & "|매출구분;SaleTypeCd;95;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            gridAttributes_1 = gridAttributes_1 & "|청구유형;BillType;1;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 

            gridAttributes_1 = gridAttributes_1 & "|[거래처];CustomerCode;1;;c;" & "o;n;n;7;경리 거래처 코드;CustomerNm"  '' Receipt.CustomerCode 
            gridAttributes_1 = gridAttributes_1 & "|[거래처];CustomerNm;150;;l;" & "o;n;n;;"

            gridAttributes_1 = gridAttributes_1 & "|입 금;ReceiptType;80;;c;" & "o;n;n;;"  '' Receipt.ReceiptType 
            gridAttributes_1 = gridAttributes_1 & "|입 금;ReceiptAmt;100;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptAmt 
            gridAttributes_1 = gridAttributes_1 & "|입 금;ReceiptFeeAmt;100;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptFeeAmt 
            gridAttributes_1 = gridAttributes_1 & "|입 금;RcptAccNumCd;180;;l;" & "o;n;n;;"  '' Receipt.RcptAccNumCd 
            gridAttributes_1 = gridAttributes_1 & "|입 금;ManagementNum;120;;l;" & "o;n;n;;"  '' Receipt.ManagementNum 

            gridAttributes_1 = gridAttributes_1 & "|수납금액;EpReceiptAmt;100;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptFeeAmt 
            gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;l;" & "o;n;n;;"  '' Receipt.Remark 
            gridAttributes_1 = gridAttributes_1 & "|회계전표번호;AccSlipNum;120;;c;" & "o;n;n;;"  '' Receipt.AccSlipNum 
            gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;"

            'grid code combo 
            Dim gridCodeNameList_1 As String = ""
            gridCodeNameList_1 = gridCodeNameList_1 & "SaleTypeCd;판매매출구분"   ''2111
            gridCodeNameList_1 = gridCodeNameList_1 & "/BillType;청구유형명"   '' 
            gridCodeNameList_1 = gridCodeNameList_1 & "/ReceiptType;PS입금구분"   ''2502 : PS입금구분
            gridCodeNameList_1 = gridCodeNameList_1 & "/RcptAccNumCd;입금계좌코드"   ''  : 입금계좌코드

            '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            ' ''gridAttributes_1 = gridAttributes_1 & "||선택;선택;40;;l;" & "io;n;n;"
            ' ''gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;6;;c;" & "io;n;y;;"  '' TotalTaxD.PubYYmm 
            ' ''gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;0;;c;" & "io;n;y;;"  '' TotalTaxD.PubSeq 
            ' ''gridAttributes_1 = gridAttributes_1 & "|계산서번호;TaxNumber;0;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            ' ''gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            ' ''gridAttributes_1 = gridAttributes_1 & "|발행일자;PubDate;20;;c;" & "o;n;n;;"  '' TotalTax.PubDate 
            ' ''gridAttributes_1 = gridAttributes_1 & "|계산서구분코드;TaxTypeCd;5;;c;" & "o;n;y;;"  '' TotalTax.TaxTypeCd 
            ' ''gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ' ''gridAttributes_1 = gridAttributes_1 & "|거래처명;CustomerNm;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 

            ' ''gridAttributes_1 = gridAttributes_1 & "|공급가액;SupplyAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            ' ''gridAttributes_1 = gridAttributes_1 & "|수납금액;ReceiptAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            ' ''gridAttributes_1 = gridAttributes_1 & "|미수금액;UnReceiptAmt;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 

            ' ''gridAttributes_1 = gridAttributes_1 & "|전자여부;ElectYesOrNo;0;;c;" & "o;n;n;;"  '' TotalTax.ElectYesOrNo 
            ' ''gridAttributes_1 = gridAttributes_1 & "|ASP업체코드;ASPBizCd;20;;c;" & "o;n;n;;"  '' TotalTax.ASPBizCd 
            ' ''gridAttributes_1 = gridAttributes_1 & "|적요;Remark;200;;l;" & "o;n;n;;"  '' TotalTax.Remark 
            ' ''gridAttributes_1 = gridAttributes_1 & "|사업자번호;BizNum;13;;c;" & "o;n;n;;"  '' TotalTax.BizNum 
            ' ''gridAttributes_1 = gridAttributes_1 & "|상호명;FirmName;30;;c;" & "o;n;n;;"  '' TotalTax.FirmName 
            ' ''gridAttributes_1 = gridAttributes_1 & "|대표자명;OwnerName;30;;c;" & "o;n;n;;"  '' TotalTax.OwnerName 
            ' ''gridAttributes_1 = gridAttributes_1 & "|사업장주소;FirmAddr;50;;c;" & "o;n;n;;"  '' TotalTax.FirmAddr 
            ' ''gridAttributes_1 = gridAttributes_1 & "|업태;BizType;30;;c;" & "o;n;n;;"  '' TotalTax.BizType 
            ' ''gridAttributes_1 = gridAttributes_1 & "|종목;BizItem;30;;c;" & "o;n;n;;"  '' TotalTax.BizItem 
            ' ''gridAttributes_1 = gridAttributes_1 & "|회계전표번호;AccSlipNum;30;;c;" & "o;n;n;;"  '' TotalTax.AccSlipNum 
            ' ''gridAttributes_1 = gridAttributes_1 & "|삭제여부;DelYesOrNo;0;;c;" & "o;n;y;;"  '' TotalTax.DelYesOrNo 
            ' ''gridAttributes_1 = gridAttributes_1 & "|매출일자;SaleDate;8;;c;" & "o;n;y;;"  '' TotalTaxD.SaleDate 
            ' ''gridAttributes_1 = gridAttributes_1 & "|매출순번;SaleSeq;0;;c;" & "o;n;y;;"  '' TotalTaxD.SaleSeq 
            ' ''gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;"

            ''grid code combo 
            'Dim gridCodeNameList_1 As String = ""
            'gridCodeNameList_1 = gridCodeNameList_1 & "SaleTypeCd;판매매출구분"   ''2111
            'gridCodeNameList_1 = gridCodeNameList_1 & "/TaxTypeCd;계산서구분"   ''2111
            ' '' ''gridAttributes_1 = gridAttributes_1 & "||선택;선택;40;;l;" & "io;n;n;"  
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;6;;c;" & "io;n;n;;"  '' TotalTax.PubYYmm 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;0;;c;" & "io;n;n;;"  '' TotalTax.PubSeq 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|거래처코드;CustomerCode;7;;c;" & "io;n;n;;"  '' TotalTax.CustomerCode 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|청구액;TotalAmt;19;;c;" & "io;n;n;;"  '' TotalTax.TotalAmt 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "|수납금액;EpReceiptAmt;19;;c;" & "io;n;n;;"  '' EpRceipt.EpReceiptAmt 
            ' '' ''gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;" 
 
            grd_1.Initialize(gridAttributes_1, gridCodeNameList_1) 
            '-------------------------------------------------- 
            '----그리드 행병합--------------------------------- 
            Dim i As Integer = 0
            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "선택"
            strColName2 = strColName2 & ControlChars.Tab & "입금일자"
            strColName2 = strColName2 & ControlChars.Tab & "입금순번"
            strColName2 = strColName2 & ControlChars.Tab & "입금번호"
            strColName2 = strColName2 & ControlChars.Tab & "매출구분"
            strColName2 = strColName2 & ControlChars.Tab & "청구유형"

            strColName2 = strColName2 & ControlChars.Tab & "거래처코드"
            strColName2 = strColName2 & ControlChars.Tab & "거래처명"

            strColName2 = strColName2 & ControlChars.Tab & "입금구분"
            strColName2 = strColName2 & ControlChars.Tab & "입금액"
            strColName2 = strColName2 & ControlChars.Tab & "수수료금액"
            strColName2 = strColName2 & ControlChars.Tab & "계좌코드"
            strColName2 = strColName2 & ControlChars.Tab & "어음번호"

            strColName2 = strColName2 & ControlChars.Tab & "수납금액"
            '''' --- 
            strColName2 = strColName2 & ControlChars.Tab & "적요"
            strColName2 = strColName2 & ControlChars.Tab & "회계전표번호"
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

            grd_2.Initialize(gridAttributes_3, gridCodeNameList_3)
            '-------------------------------------------------- 
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 1
 
            dtpReceiptDateFr_R.Text = Now.ToString().Substring(0, 8) + "01"
            dtpReceiptDateTo_R.Text = Now.ToString()
        End Sub

        ''' <summary>
        ''' 함수명 : PSD104_Enter 
        ''' 기  능 : 화면 전환(업체수납등록)
        Private Sub PSD104_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")

            If ShareParameters(0) = Me.Name Then
                '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.               
                Me.cboSaleTypeCd_R.TextValue = ShareParameters(1) '판매매출구분                           
                Me.popCustomerCode_R.TextValue = ShareParameters(2) '거래처코드   
                Dim sTaxNumber As String = Replace(ShareParameters(3), "-", "")
                ''Me.dtpPubYYmm_R.TextValue = sTaxNumber.ToString.Substring(0, 6) '계산서번호                         
                ''Me.numPubSeq_R.TextValue = sTaxNumber.ToString.Substring(6, 5) '계산서번호                         
                ''Me.dtpPubDateFr_R.TextValue = Replace(ShareParameters(4), "-", "") '거래 일자                             
                ''Me.dtpPubDateTo_R.TextValue = Replace(ShareParameters(5), "-", "") '거래 일자                             

                GrecordProcessMode = "2"   '조회 모드로 변경
                Me.GmainCommonFunction.GRequestDataNumber = 1
                CallByName(Me, "RequestData", CallType.Method)
                GmainBusinessFunction.SetValue("화면 전환", vbNullString)
            End If
        End Sub

        'Private Sub optGb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    If optGb1.Checked Then
        '        dtpPubYYmm_R.Enabled = True
        '        dtpPubDateFr_R.Enabled = False
        '        dtpPubDateTo_R.Enabled = False
        '    Else
        '        dtpPubYYmm_R.Enabled = False
        '        dtpPubDateFr_R.Enabled = True
        '        dtpPubDateTo_R.Enabled = True
        '    End If
        'End Sub

        Private Sub cboBillType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBillType.SelectedIndexChanged
            If cboBillType.TextValue = "D3" Then
                lblTaxNumber.Enabled = False
                popTaxNumber.Visible = False
                popTaxNumber.Text = ""
            Else
                lblTaxNumber.Enabled = True
                popTaxNumber.Visible = True
            End If
        End Sub

    End Class
End Namespace                                                                                                                                            