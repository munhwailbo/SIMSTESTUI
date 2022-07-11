﻿'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSD103] 업체 입금 내역 조회
' form 설명 :  [PSD103] 업체 입금 내역 조회
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:07:58
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
 
    Public Class PSD103 
        Inherits CommonControls.UiControl  
 
        Private Sub PSD103_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_2 = gridAttributes_2 & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);  
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code   
            gridAttributes_2 = gridAttributes_2 & "||선택;선택;40;;l;" & "io;n;y;"
            gridAttributes_2 = gridAttributes_2 & "|입금일자;ReceiptDate;20;;c;" & "o;n;y;;"  '' Receipt.ReceiptDate 
            gridAttributes_2 = gridAttributes_2 & "|입금순번;ReceiptSeq;0;;c;" & "o;n;y;;"  '' Receipt.ReceiptSeq 
            gridAttributes_2 = gridAttributes_2 & "|입금번호;ReceiptNumber;110;;l;" & "o;n;n;;"  '' Receipt.ReceiptDate 
            gridAttributes_2 = gridAttributes_2 & "|매출구분;SaleTypeCd;95;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            gridAttributes_2 = gridAttributes_2 & "|청구유형;BillType;1;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 

            gridAttributes_2 = gridAttributes_2 & "|[거래처];CustomerCode;1;;c;" & "o;n;n;7;경리 거래처 코드;CustomerNm"  '' Receipt.CustomerCode 
            gridAttributes_2 = gridAttributes_2 & "|[거래처];CustomerNm;150;;l;" & "o;n;n;;"

            gridAttributes_2 = gridAttributes_2 & "|입 금;ReceiptType;80;;c;" & "o;n;n;;"  '' Receipt.ReceiptType 
            gridAttributes_2 = gridAttributes_2 & "|입 금;ReceiptAmt;100;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptAmt 
            gridAttributes_2 = gridAttributes_2 & "|입 금;ReceiptFeeAmt;100;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptFeeAmt 
            gridAttributes_2 = gridAttributes_2 & "|입 금;RcptAccNumCd;180;;l;" & "o;n;n;;"  '' Receipt.RcptAccNumCd 
            gridAttributes_2 = gridAttributes_2 & "|입 금;ManagementNum;120;;l;" & "o;n;n;;"  '' Receipt.ManagementNum 

            gridAttributes_2 = gridAttributes_2 & "|수납금액;EpReceiptAmt;100;#,##0;r;" & "o;n;n;;"  '' Receipt.ReceiptFeeAmt 
            gridAttributes_2 = gridAttributes_2 & "|적요;Remark;200;;l;" & "o;n;n;;"  '' Receipt.Remark 
            gridAttributes_2 = gridAttributes_2 & "|회계전표번호;AccSlipNum;120;;c;" & "o;n;n;;"  '' Receipt.AccSlipNum 
            gridAttributes_2 = gridAttributes_2 & "| ;col_adjust;1;;c;" & "o;n;n;;"

            'grid code combo 
            Dim gridCodeNameList_2 As String = ""
            gridCodeNameList_2 = gridCodeNameList_2 & "SaleTypeCd;판매매출구분"   ''2111
            gridCodeNameList_2 = gridCodeNameList_2 & "/BillType;청구유형명"   '' 
            gridCodeNameList_2 = gridCodeNameList_2 & "/ReceiptType;PS입금구분"   ''2502 : PS입금구분
            gridCodeNameList_2 = gridCodeNameList_2 & "/RcptAccNumCd;입금계좌코드"   ''  : 입금계좌코드

            grd_1.Initialize(gridAttributes_2, gridCodeNameList_2)
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

            dtpReceiptDateFr_R.TextValue = Now.ToString.Substring(0, 7) & "01"

        End Sub 

        ''' <summary>
        ''' 함수명 : PSD103_Enter 
        ''' 기  능 : 화면 전환(업체입금내역조회)
        Private Sub PSD103_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")

            If ShareParameters(0) = Me.Name Then
                '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.               
                Me.cboSaleTypeCd_R.TextValue = ShareParameters(1) '판매매출구분                           
                Me.popCustomerCode_R.TextValue = ShareParameters(2) '거래처코드   
                'Dim sTaxNumber As String = Replace(ShareParameters(3), "-", "")
                Me.popReceiptNumber_R.TextValue = ShareParameters(3) ' 입금번호
                'Me.dtpPubYYmm_R.TextValue = sTaxNumber.ToString.Substring(0, 6) '계산서번호                         
                'Me.numPubSeq_R.TextValue = sTaxNumber.ToString.Substring(6, 5) '계산서번호                         
                Me.dtpReceiptDateFr_R.TextValue = Replace(ShareParameters(4), "-", "") '거래 일자                             
                Me.dtpReceiptDateTo_R.TextValue = Replace(ShareParameters(5), "-", "") '거래 일자                             

                GrecordProcessMode = "2"   '조회 모드로 변경
                Me.GmainCommonFunction.GRequestDataNumber = 1
                CallByName(Me, "RequestData", CallType.Method)
                GmainBusinessFunction.SetValue("화면 전환", vbNullString)
            End If
        End Sub

        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick
            '전표 화면으로 전표 번호를 넘겨서 해당 전표를 조회 한다.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim sParm As String = vbNullString   '파라미터
            Dim sProgramID As String = ""   '화면 ID
            Dim sSaleTypeCd As String '판매매출구분 
            Dim sCustomerCode As String '거래처코드
            Dim sTaxNumber As String '계산서번호
            Dim sPubDateFr As String '기준일자1
            Dim sPubDateTo As String '기준일자2
            Dim sReceiptNumber As String '입금번호

            With Me.grd_1
                If sender.col.ToString = .get_ColIndex("TaxNumber").ToString Then
                    '' 미수/선수현황 (계산서 등록)
                    sProgramID = "PSB107"
                ElseIf sender.col.ToString = .get_ColIndex("EpReceiptNumber").ToString _
                    Or sender.col.ToString = .get_ColIndex("EpReceiptAmt").ToString Then
                    '' 수납등록
                    sProgramID = "PSD106"
                    sProgramID = ""
                ElseIf sender.col.ToString = .get_ColIndex("ReceiptNumber").ToString _
                    Or sender.col.ToString = .get_ColIndex("ReceiptAmt").ToString Then
                    '' 입금등록
                    sProgramID = "PSD101"
                End If

                sReceiptNumber = ""
                If sProgramID.ToString.Length > 0 Then
                    sSaleTypeCd = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SaleTypeCd")).ToString.Substring(0, 2) '판매매출구분 
                    sCustomerCode = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("CustomerCode"))  '거래처코드
                    If sProgramID = "PSD101" Then
                        ' 입금번호, 입금일자1, 입금일자2
                        sTaxNumber = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("ReceiptNumber")).ToString    '계산서번호
                        sPubDateFr = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("ReceiptDate")).ToString  '입금일자
                        sPubDateTo = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("ReceiptDate")).ToString  '입금일자
                    ElseIf sProgramID = "PSD106" Then
                        ' 계산서번호, 입금일자1, 입금일자2
                        sTaxNumber = ""   ''''Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("TaxNumber")).ToString    '계산서번호
                        sPubDateFr = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("ReceiptDate")).ToString  '입금일자
                        sPubDateTo = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("ReceiptDate")).ToString  '입금일자
                        sReceiptNumber = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("ReceiptNumber")).ToString    '입금번호
                    Else
                        ' 계산서번호, 기준일자1, 기준일자2
                        sTaxNumber = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("TaxNumber")).ToString    '계산서번호
                        sPubDateFr = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("PubYYmm")).ToString + "01" '기준일자1
                        sPubDateTo = Now.ToString() '기준일자2
                    End If
                    If sProgramID = "PSD106" Then
                        sParm = sProgramID & ";" & sSaleTypeCd & ";" & sCustomerCode & ";" & sTaxNumber & ";" & sPubDateFr & ";" & sPubDateTo & ";" & sReceiptNumber
                    Else
                        sParm = sProgramID & ";" & sSaleTypeCd & ";" & sCustomerCode & ";" & sTaxNumber & ";" & sPubDateFr & ";" & sPubDateTo
                    End If
                    GmainBusinessFunction.SetValue("화면 전환", sParm)
                    Me.ShowUiControl(sProgramID, sParm)
                End If
            End With
        End Sub

    End Class
End Namespace                                                                                                                                            