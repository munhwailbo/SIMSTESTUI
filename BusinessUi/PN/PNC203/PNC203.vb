' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 
' form설명 :
' 작성자 : 
' 작성일 : 
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC203
        Inherits CommonControls.UiControl
        '====================================================================================================
       

#Region "폼 초기화"

        ''' <summary>
        ''' 함수명 : Initialize
        ''' 리턴값 : 
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|독자코드;ReaderCd;80;;l;" & "o;n;n;8;"       '(10)
            gridAttributes = gridAttributes & "|독자명;ReaderNm;100;;l;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;200;;l;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;200;;l;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;200;;l;" & "o;n;n;30;"       '(50)
            gridAttributes = gridAttributes & "|신우편번호;NewPostNum;100;;l;" & "o;n;n;10;"       '(60)
            gridAttributes = gridAttributes & "|신주소;NewAddr1;200;;l;" & "o;n;n;50;"       '(70)
            gridAttributes = gridAttributes & "|신상세주소;NewAddr2;200;;l;" & "o;n;n;100;"       '(80)
            gridAttributes = gridAttributes & "|구우편번호;OldPostNum;100;;l;" & "o;n;n;10;"       '(90)
            gridAttributes = gridAttributes & "|구주소;OldAddr1;200;;l;" & "o;n;n;50;"       '(100)
            gridAttributes = gridAttributes & "|구상세주소;OldAddr2;200;;l;" & "o;n;n;100;"       '(110)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|구독코드;SubscribeCd;100;;l;" & "io;n;n;10;"       '(10)
            gridAttributes = gridAttributes & "|독자코드;ReaderCd;80;;l;" & "io;n;n;8;"       '(20)
            gridAttributes = gridAttributes & "|순번;Orders;40;;r;" & "io;n;n;4;"       '(30)

            gridAttributes = gridAttributes & "|구독상태코드;SubscribeStateCd;100;;l;" & "io;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|확장구분코드;ExpandDivCd;100;;l;" & "io;n;n;10;"       '(50)
            gridAttributes = gridAttributes & "|독자구분코드;ReaderDivCd;100;;l;" & "io;n;n;10;"       '(60)
            gridAttributes = gridAttributes & "|독자상태코드;ReaderStateCd;100;;l;" & "io;n;n;10;"       '(70)
            gridAttributes = gridAttributes & "|배달처구분코드;DeliveryRegionCd;100;;l;" & "io;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|배달구분코드;DeliveryDivCd;100;;l;" & "io;n;n;10;"       '(90)
            gridAttributes = gridAttributes & "|본사독자구분코드;MHReaderDivCd;100;;l;" & "io;n;n;10;"       '(100)
            gridAttributes = gridAttributes & "|판촉여부;PromotionYN;10;;c;" & "io;n;n;1;"       '(110)
            gridAttributes = gridAttributes & "|판촉사원명;PromotionEmpNm;200;;l;" & "io;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;100;;l;" & "io;n;n;10;"       '(130)
            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;100;;l;" & "io;n;n;10;"       '(140)
            gridAttributes = gridAttributes & "|청구주기코드;BillPeriodCd;100;;l;" & "io;n;n;10;"       '(150)
            gridAttributes = gridAttributes & "|접수일자;ContactDt;80;;l;" & "io;n;n;8;"       '(160)
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;80;;l;" & "io;n;n;8;"       '(170)
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;80;;l;" & "io;n;n;8;"       '(180)
            gridAttributes = gridAttributes & "|중지일자;StopDt;80;;l;" & "io;n;n;8;"       '(190)
            gridAttributes = gridAttributes & "|서비스기간;ServiceTerm;40;;r;" & "io;n;n;4;"       '(200)
            gridAttributes = gridAttributes & "|접수부수;ContactPaperNum;40;;r;" & "io;n;n;4;"       '(210)
            gridAttributes = gridAttributes & "|확정부수;FixedPaperNum;40;;r;" & "io;n;n;4;"       '(220)
            gridAttributes = gridAttributes & "|투입부수;SubscribePagerNum;40;;r;" & "io;n;n;4;"       '(230)
            gridAttributes = gridAttributes & "|중지부수;StopPaperNum;40;;r;" & "io;n;n;4;"       '(240)
            gridAttributes = gridAttributes & "|수금시작년월;CollectionYYYYMM;60;;l;" & "io;n;n;6;"       '(250)
            gridAttributes = gridAttributes & "|확장비확정처리자아이디;ExpSupAmtProcEmpNum;70;;l;" & "io;n;n;7;"       '(260)
            gridAttributes = gridAttributes & "|확장비확정일자;ExpSupAmtFixedDt;80;;l;" & "io;n;n;8;"       '(270)
            gridAttributes = gridAttributes & "|실독자결정처리아이디;RealReaderProcEmpNum;70;;l;" & "io;n;n;7;"       '(280)
            gridAttributes = gridAttributes & "|실독자결정일자;RealReaderFixedDt;80;;l;" & "io;n;n;8;"       '(290)

            gridAttributes = gridAttributes & "|접수지국코드;ReceiptBranchCd;70;;l;" & "io;n;n;7;"       '(300)
            gridAttributes = gridAttributes & "|투입지국코드;SubscribeBranchCd;70;;l;" & "io;n;n;7;"       '(310)
            gridAttributes = gridAttributes & "|수금지국코드;ReceiptMoneyBranchCd;70;;l;" & "io;n;n;7;"       '(320)
            gridAttributes = gridAttributes & "|유가지국코드;ValPaperBranchCd;70;;l;" & "io;n;n;7;"       '(330)
            gridAttributes = gridAttributes & "|비고;Note;200;;l;" & "io;n;n;20;"       '(340)

            'grid_2 code combo    
            gridCodeNameList = ""

            gridCodeNameList = gridCodeNameList & "SubscribeStateCd;구독상태코드"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            gridCodeNameList = gridCodeNameList & "/ReaderDivCd;독자구분코드"
            gridCodeNameList = gridCodeNameList & "/ReaderStateCd;독자상태코드"
            gridCodeNameList = gridCodeNameList & "/DeliveryRegionCd;배달처구분코드"

            gridCodeNameList = gridCodeNameList & "/DeliveryDivCd;배달구분코드"
            gridCodeNameList = gridCodeNameList & "/MHReaderDivCd;본사독자구분코드"
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;수금형태코드"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;청구주기코드"

            gridCodeNameList = gridCodeNameList & "/ReceiptBranchCd;접수지국코드"
            gridCodeNameList = gridCodeNameList & "/SubscribeBranchCd;투입지국코드"
            gridCodeNameList = gridCodeNameList & "/ReceiptMoneyBranchCd;수금지국코드"
            gridCodeNameList = gridCodeNameList & "/ValPaperBranchCd;유가지국코드"

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3

            '  grid_3 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;80;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|독자코드;ReaderCd;80;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|독자명;ReaderNm;100;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;200;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;200;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;200;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|신우편번호;NewPostNum;100;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|신주소;NewAddr1;200;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|신상세주소;NewAddr2;200;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|구우편번호;OldPostNum;100;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|구주소;OldAddr1;200;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|구상세주소;OldAddr2;200;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|처리일자;ProcessDt;200;;l;" & "io;n;n;100;"

            'grid_3 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3


        End Sub

#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC201_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
        ''' <summary>
        ''' 함수명 : btnRowInsert_Click 
        ''' 기  능 : 행 추가
        ''' 작성자 : 신현갑
        ''' 작성일 : 2007-01-02
        ''' 수정자 : 
        ''' 수정일 :
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnRowInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRowInsert.Click
            Dim RowNumber As Integer = 0

            With Me.grd_2
                .AddRow()
                .set_TextMatrix(.Rows - 1, 0, "신규")
                .set_TextMatrix(.Rows - 1, .get_ColIndex("SubscribeCd"), "0") '항목 번호 
                .set_TextMatrix(.Rows - 1, .get_ColIndex("ReaderCd"), "") '항목 번호 
                .set_TextMatrix(.Rows - 1, .get_ColIndex("Orders"), 0) '항목 번호 
            End With
        End Sub
        ''' <summary>
        ''' 함수명 : btnRowSave_Click 
        ''' 기  능 : 행 저장
        ''' 작성자 : 신현갑
        ''' 작성일 : 2007-01-02
        ''' 수정자 : 
        ''' 수정일 :
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnRowSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRowSave.Click

        End Sub
        ''' <summary>
        ''' 함수명 : btnRowDelete_Click 
        ''' 기  능 : 행 삭제
        ''' 작성자 : 신현갑
        ''' 작성일 : 2007-01-02
        ''' 수정자 : 
        ''' 수정일 :
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnRowDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRowDelete.Click
            With Me.grd_2
                If .Rows > .FixedRows Then
                    If .get_TextMatrix(.RowSel, 0) = "신규" Then
                        .RemoveItem(.RowSel)
                    ElseIf IsNumeric(.get_TextMatrix(.RowSel, 0)) = True Then
                        .set_TextMatrix(.RowSel, 0, "삭제")
                        .SetCellCheck(.RowSel, .get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                    ElseIf .get_TextMatrix(.RowSel, 0) = "수정" = True Then
                        .set_TextMatrix(.RowSel, 0, "삭제")
                        .SetCellCheck(.RowSel, .get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                    End If
                End If
            End With
        End Sub
        ''' <summary>
        ''' 함수명 : btnCopy_Click 
        ''' 기  능 : 행 복사
        ''' 작성자 : 신현갑
        ''' 작성일 : 2007-01-02
        ''' 수정자 : 
        ''' 수정일 :
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
            Dim Row As Integer = 0                '행 INDEX
            Dim RowNumber As Integer = 0

            With Me.grd_2
                If .Rows = .FixedRows Then Exit Sub
                Row = .RowSel
                .AddRow()
                .set_TextMatrix(.Rows - 1, 0, "신규")
                .SetCellCheck(.Rows - 1, .get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalSeq"), "0") '항목 번호 
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("AccountCode"), .get_TextMatrix(Row, .get_ColIndex("AccountCode")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("AccountCodeName"), .get_TextMatrix(Row, .get_ColIndex("AccountCodeName")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalQuantity"), .get_TextMatrix(Row, .get_ColIndex("ProposalQuantity")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ProposalAmount"), .get_TextMatrix(Row, .get_ColIndex("ProposalAmount")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ValidBeginDate"), .get_TextMatrix(Row, .get_ColIndex("ValidBeginDate")))
                '.set_TextMatrix(.Rows - 1, .get_ColIndex("ValidEndDate"), .get_TextMatrix(Row, .get_ColIndex("ValidEndDate")))
            End With

            '2006-07-26 신현갑 추가
            Me.grd_2.Select(Me.grd_2.Rows - 1, Me.grd_2.get_ColIndex("SubscribeCd"))
        End Sub
#End Region

    End Class

End Namespace
