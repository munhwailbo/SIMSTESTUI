'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSD101] 업체 입금 등록
' form 설명 :  [PSD101] 업체 입금 등록
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:07:51
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
 
    Public Class PSD101 
        Inherits CommonControls.UiControl  
 
        Private Sub PSD101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            Dim gridAttributes_2 As String = "" 
 
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no) 
            gridAttributes_2 = gridAttributes_2 & "a;r;y" 
 
            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_2 = gridAttributes_2 & "||선택;선택;40;;l;" & "io;n;y;"
            gridAttributes_2 = gridAttributes_2 & "|입금일자;ReceiptDate;20;;c;" & "o;n;y;;"  '' Receipt.ReceiptDate 
            gridAttributes_2 = gridAttributes_2 & "|입금순번;ReceiptSeq;0;;c;" & "o;n;y;;"  '' Receipt.ReceiptSeq 
            gridAttributes_2 = gridAttributes_2 & "|입금번호;ReceiptNumber;20;;l;" & "o;n;n;;"  '' Receipt.ReceiptDate 
            gridAttributes_2 = gridAttributes_2 & "|매출구분;SaleTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            gridAttributes_2 = gridAttributes_2 & "|청구유형;BillType;5;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            gridAttributes_2 = gridAttributes_2 & "|입금구분;ReceiptType;5;;c;" & "o;n;n;;"  '' Receipt.ReceiptType 
            gridAttributes_2 = gridAttributes_2 & "|거래처코드;CustomerCode;7;;c;" & "o;n;n;7;경리 거래처 코드;CustomerNm"  '' Receipt.CustomerCode 
            gridAttributes_2 = gridAttributes_2 & "|거래처명;CustomerNm;98;;l;" & "o;n;n;;"
            gridAttributes_2 = gridAttributes_2 & "|계좌코드;RcptAccNumCd;5;;c;" & "o;n;n;;"  '' Receipt.RcptAccNumCd 
            gridAttributes_2 = gridAttributes_2 & "|어음번호;ManagementNum;30;;l;" & "o;n;n;;"  '' Receipt.ManagementNum 
            gridAttributes_2 = gridAttributes_2 & "|입금액;ReceiptAmt;19;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptAmt 
            gridAttributes_2 = gridAttributes_2 & "|수수료금액;ReceiptFeeAmt;19;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptFeeAmt 
            gridAttributes_2 = gridAttributes_2 & "|적요;Remark;200;;l;" & "o;n;n;;"  '' Receipt.Remark 
            gridAttributes_2 = gridAttributes_2 & "|회계전표번호;AccSlipNum;30;;c;" & "o;n;n;;"  '' Receipt.AccSlipNum 
            gridAttributes_2 = gridAttributes_2 & "| ;col_adjust;1;;c;" & "o;n;n;;" 
 
            'grid code combo 
            Dim gridCodeNameList_2 As String = ""  
            gridCodeNameList_2 = gridCodeNameList_2 & "SaleTypeCd;판매매출구분"   ''2111
            gridCodeNameList_2 = gridCodeNameList_2 & "/BillType;청구유형명"   '' 
            gridCodeNameList_2 = gridCodeNameList_2 & "/ReceiptType;PS입금구분"   ''2502 : PS입금구분
            gridCodeNameList_2 = gridCodeNameList_2 & "/RcptAccNumCd;입금계좌코드"   ''  : 입금계좌코드

            grd_1.Initialize(gridAttributes_2, gridCodeNameList_2)
            '-------------------------------------------------- 
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1

            dtpReceiptDateFr_R.TextValue = Now.ToString.Substring(0, 7) & "01"

        End Sub 

        ''' <summary>
        ''' 함수명 : PSD101_Enter 
        ''' 기  능 : 화면 전환(매출 (건별)처리등록)
        Private Sub PSD101_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")

            If ShareParameters(0) = Me.Name Then
                '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.               
                'Me.cboSaleTypeCd_R.TextValue = ShareParameters(1) '판매매출구분                           
                Me.popCustomerCode_R.TextValue = ShareParameters(2) '거래처코드   
                Dim sTaxNumber As String = Replace(ShareParameters(3), "-", "")
                ''Me.dtpPubYYmm_R.TextValue = VBN.IIf(IsNothing(sTaxNumber), "", sTaxNumber.ToString.Substring(0, 6)) '계산서번호                         
                ''Me.numPubSeq_R.TextValue = VBN.IIf(IsNothing(sTaxNumber), "0", sTaxNumber.ToString.Substring(6, 5)) '계산서번호                         
                Me.dtpReceiptDateFr_R.TextValue = Replace(ShareParameters(4), "-", "") '수납일자 
                Me.dtpReceiptDateTo_R.TextValue = Replace(ShareParameters(5), "-", "") '수납일자
                ''Me.popReceiptNumber_R.TextValue = VBN.IIf(IsNothing(ShareParameters(6)), "", ShareParameters(6)) ''입금번호

                GrecordProcessMode = "2"   '조회 모드로 변경
                Me.GmainCommonFunction.GRequestDataNumber = 1
                CallByName(Me, "RequestData", CallType.Method)
                GmainBusinessFunction.SetValue("화면 전환", vbNullString)
            End If
        End Sub

        Private Sub cboReceiptType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReceiptType.SelectedIndexChanged
            Try
                If cboReceiptType.TextValue.ToString.Substring(0, 2) = "01" Then
                    ''' 계좌입금
                    'cboRcptAccNumCd.SelectedIndex = 0
                    cboRcptAccNumCd.Enabled = True
                    txtManagementNum.TextValue = ""
                    txtManagementNum.Enabled = False
                ElseIf cboReceiptType.TextValue.ToString.Substring(0, 2) = "02" _
                       Or cboReceiptType.TextValue.ToString.Substring(0, 2) = "03" Then
                    '' 어음(전자/일반)입금
                    cboRcptAccNumCd.SelectedIndex = 0
                    cboRcptAccNumCd.Enabled = False
                    txtManagementNum.Enabled = True
                ElseIf cboReceiptType.TextValue.ToString.Substring(0, 2) = "04" Then
                    '' 현금입금
                    cboRcptAccNumCd.SelectedIndex = 0
                    cboRcptAccNumCd.Enabled = False
                    txtManagementNum.Enabled = False
                Else
                    cboRcptAccNumCd.SelectedIndex = 0
                    cboRcptAccNumCd.Enabled = False
                    txtManagementNum.Enabled = False
                End If
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace                                                                                                                                            