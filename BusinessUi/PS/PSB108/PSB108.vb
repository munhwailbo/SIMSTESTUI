'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSB108] 업체 미수 내역
' form 설명 :  [PSB108] 업체 미수 내역
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:07:29
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
 
    Public Class PSB108 
        Inherits CommonControls.UiControl  
 
        Private Sub PSB108_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
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
            gridAttributes_1 = gridAttributes_1 & "||선택;선택;37;;1;" & "io;n;n;;;"
            gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;100;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|업   체;CustomerCode;62;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|업   체;CustomerNm;170;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|업   체;SimsCode;100;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|[일자];DispDate;85;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|계산서번호;TaxNumber;100;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;0;yyyy-MM;4;" & "io;n;y;;"
            gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;0;;4;" & "o;n;y;;"
            gridAttributes_1 = gridAttributes_1 & "|금   액;Amt_11;100;#,##0;7;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|금   액;Amt_21;100;#,##0;7;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|금   액;Amt_22;100;#,##0;7;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|담당;ErpNm;80;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|입금번호;ReceiptNumber;100;;1;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|전표번호;AccSlipNum;100;;4;" & "o;n;n;;"
            gridAttributes_1 = gridAttributes_1 & "|;col_adjust;1;;4;" & "o;n;n;;"

            ''gridAttributes_1 = gridAttributes_1 & "||선택;선택;40;;l;" & "io;n;n;"
            ''gridAttributes_1 = gridAttributes_1 & "|매출구분코드;SaleTypeCd;5;;c;" & "o;n;n;;"  '' TotalTax.SaleTypeCd 
            ''gridAttributes_1 = gridAttributes_1 & "|업체;CustomerCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ''gridAttributes_1 = gridAttributes_1 & "|업체;CustomerNm;7;;l;" & "o;n;n;;"  '' TotalTax.CustomerCode 
            ''gridAttributes_1 = gridAttributes_1 & "|업체;SimsCode;7;;c;" & "o;n;n;;"  '' TotalTax.CustomerCode 

            ''gridAttributes_1 = gridAttributes_1 & "|[일자];DispDate;6;;c;" & "o;n;n;;"  '' TotalTaxD.PubYYmm 
            ''gridAttributes_1 = gridAttributes_1 & "|계산서번호;TaxNumber;10;;l;" & "o;n;n;;"  '' TotalTaxD.PubSeq 
            ''gridAttributes_1 = gridAttributes_1 & "|계산서발행년월;PubYYmm;6;;c;" & "io;n;y;;"  '' TotalTaxD.PubYYmm 
            ''gridAttributes_1 = gridAttributes_1 & "|발행순번;PubSeq;0;;c;" & "o;n;y;;"  '' TotalTaxD.PubSeq 
            '' '' 미수금(선수금)
            ''gridAttributes_1 = gridAttributes_1 & "|금   액;Amt_11;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            '' '' 가수금대체(가수금대체/미수잔액)
            ''gridAttributes_1 = gridAttributes_1 & "|금   액;Amt_21;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            ''gridAttributes_1 = gridAttributes_1 & "|금   액;Amt_22;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            '' '' 매출채권대체(매출채권대체/선수잔액)
            ' ''gridAttributes_1 = gridAttributes_1 & "|매출채권대체;Amt_31;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 
            ' ''gridAttributes_1 = gridAttributes_1 & "|선수잔액;Amt_32;19;#,##0;r;" & "o;n;n;;"  '' TotalTax.SupplyAmt 

            ''gridAttributes_1 = gridAttributes_1 & "|담당;ErpNm;30;;c;" & "o;n;n;;"  ''  
            ''gridAttributes_1 = gridAttributes_1 & "| ;col_adjust;1;;c;" & "o;n;n;;"

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
            strColName2 = strColName2 & ControlChars.Tab & "업체코드"
            strColName2 = strColName2 & ControlChars.Tab & "업체명"
            strColName2 = strColName2 & ControlChars.Tab & "판매코드"
            strColName2 = strColName2 & ControlChars.Tab & "[일자]"
            strColName2 = strColName2 & ControlChars.Tab & "계산서번호"
            strColName2 = strColName2 & ControlChars.Tab & "계산서발행년월"
            strColName2 = strColName2 & ControlChars.Tab & "발행순번"
            '''' ---미수금(선수금)
            strColName2 = strColName2 & ControlChars.Tab & "미수금(A)"
            strColName2 = strColName2 & ControlChars.Tab & "가수금대체(B)"
            strColName2 = strColName2 & ControlChars.Tab & "잔액(A-B)"
            '''' --- 
            strColName2 = strColName2 & ControlChars.Tab & "담당"
            strColName2 = strColName2 & ControlChars.Tab & "입금번호"
            strColName2 = strColName2 & ControlChars.Tab & "전표번호"
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

            dtpPubDateFr_R.Text = Now.ToString().Substring(0, 8) + "01"
            dtpPubDateTo_R.Text = Now.ToString()
            dtpPubYYmm_R.Text = ""
        End Sub

        'Private Sub optGb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGb2.CheckedChanged
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

        ''' <summary>
        ''' 함수명 : PSB108_Enter 
        ''' 기  능 : 화면 전환(미수/선수)
        Private Sub PSB108_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
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
                If sender.col.ToString = .get_ColIndex("TaxNumber").ToString _
                    Or sender.col.ToString = .get_ColIndex("Amt_11").ToString Then
                    '' 미수/선수 현황
                    sProgramID = "PSB107"
                ElseIf sender.col.ToString = .get_ColIndex("Amt_21").ToString _
                    Or sender.col.ToString = .get_ColIndex("Amt_22").ToString Then
                    '' 수납내역조회
                    sProgramID = "PSD106"
                ElseIf sender.col.ToString = .get_ColIndex("Amt_31").ToString _
                    Or sender.col.ToString = .get_ColIndex("Amt_32").ToString Then
                    '' 매출(건별)등록
                    sProgramID = "PSC101"
                End If

                If sProgramID.ToString.Length > 0 Then
                    sSaleTypeCd = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SaleTypeCd")).ToString.Substring(0, 2) '판매매출구분 
                    sCustomerCode = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("CustomerCode"))  '거래처코드
                    sTaxNumber = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("TaxNumber")).ToString    '계산서번호
                    sPubDateFr = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("PubYYmm")).ToString + "01" '기준일자1
                    sPubDateTo = Now.ToString() '기준일자2

                    If sProgramID = "PSD106" Then
                        sReceiptNumber = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("ReceiptNumber")).ToString    '입금번호
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