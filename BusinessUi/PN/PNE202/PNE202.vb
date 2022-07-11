' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명   : 사원확장비 청구 생성 처리
' form설명 : 사원확장비(본사) 청구생성처리 한다
' 작성자   : 김성훈
' 작성일   : 2008-09-22
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

    Public Class PNE202
        Inherits CommonControls.UiControl
        '====================================================================================================


#Region "폼 초기화"

        Public Sub Initialize()

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|확장년월;PayYearMonths;60;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|연번;SeriesNum;40;;c;" & "io;n;n;6;"       '(10)

            gridAttributes = gridAttributes & "|권유자사번;EmpNum;70;;c;" & "o;n;n;5;사원 명;EmpNm"
            gridAttributes = gridAttributes & "|권유자명;EmpNm;70;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|부서코드;DeptCd;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|부서명;DeptNm;100;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지급일자;PayDt;80;;c;" & "io;y;n;5;"

            gridAttributes = gridAttributes & "|신규확장;NewExpPaperNum;70;#,##0;c;" & "o;n;n;4;"    '(70) 신규확장부수
            gridAttributes = gridAttributes & "|재확장;ReExpPaperNum;70;#,##0;c;" & "o;n;n;4;"       '(70) 재확장부수
            gridAttributes = gridAttributes & "|확장계;ExpPaperNum;70;#,##0;c;" & "o;n;n;4;"         '(70) 확장부수계
            gridAttributes = gridAttributes & "|조정;NewStopPaperNum;70;#,##0;c;" & "o;n;n;4;"    '(70) 조정부수(신규)
            gridAttributes = gridAttributes & "|조정;ReStopPaperNum;70;#,##0;c;" & "o;n;n;4;"  '(70) 조정부수(재접수)
            gridAttributes = gridAttributes & "|정산;NewRealPaperNum;70;#,##0;c;" & "o;n;n;4;"          '(70) 중지부수
            gridAttributes = gridAttributes & "|정산;ReRealPaperNum;70;#,##0;c;" & "o;n;n;4;"          '(70) 중지부수
            'gridAttributes = gridAttributes & "|확장단가;ExpPaperUnit;90;#,##0;r;" & "o;n;n;4;"      '(70) 확장단가

            gridAttributes = gridAttributes & "|신규확장비;NewExpPaperUnit;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|신규확장비;NewIncomeTax;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|신규확장비;NewInhabitantsTax;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|신규확장비;NewExpAmount;90;#,##0;r;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|재확장비(50부이하);ReExpPaperUnitBelow50;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|재확장비(50부이하);ReIncomeTaxBelow50;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|재확장비(50부이하);ReInhabitantsTaxBelow50;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|재확장비(50부이하);ReExpAmountBelow50;90;#,##0;r;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|재확장비(51부~100부);ReExpPaperUnitBelow100;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|재확장비(51부~100부);ReIncomeTaxBelow100;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|재확장비(51부~100부);ReInhabitantsTaxBelow100;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|재확장비(51부~100부);ReExpAmountBelow100;90;#,##0;r;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|재확장비(101부이상);ReExpPaperUnitAbove101;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|재확장비(101부이상);ReIncomeTaxAbove101;90;#,##0;r;" & "o;n;n;4;"
            'gridAttributes = gridAttributes & "|재확장비(101부이상);ReInhabitantsTaxAbove101;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|재확장비(101부이상);ReExpAmountAbove101;90;#,##0;r;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|계;SupportAmt;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|계;IncomeTax;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|계;InhabitantsTax;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|계;SumTax;90;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|계;ExpAmount;90;#,##0;r;" & "o;n;n;4;"


            gridAttributes = gridAttributes & "|매수;OneMillionWon;50;#,##0;r;" & "o;n;n;4;"      '백만원권 매수
            gridAttributes = gridAttributes & "|매수;HundredThousandWon;50;#,##0;r;" & "o;n;n;4;" '십만원권 매수
            gridAttributes = gridAttributes & "|매수;TenThousandWon;50;#,##0;r;" & "o;n;n;4;"     '만원권 매수

            gridAttributes = gridAttributes & "|국적코드;NationalityCd;60;;c;" & "io;y;n;5;"            ' 국적코드
            gridAttributes = gridAttributes & "|거주구분코드;ResidenceDivCd;60;;c;" & "io;y;n;5;"       ' 거주구분코드

            'gridAttributes = gridAttributes & "|적요;Remark;90;;r;" & "o;n;n;4;"     '(60) 부수계
            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "NationalityCd;국적코드"
            gridCodeNameList = gridCodeNameList & "/ResidenceDivCd;거주구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Dim strColName2 As String = " "
            strColName2 = strColName2 & ControlChars.Tab & "선택"
            strColName2 = strColName2 & ControlChars.Tab & "확장년월"
            strColName2 = strColName2 & ControlChars.Tab & "연번"

            strColName2 = strColName2 & ControlChars.Tab & "권유자사번"
            strColName2 = strColName2 & ControlChars.Tab & "권유자명"
            strColName2 = strColName2 & ControlChars.Tab & "부서코드"
            strColName2 = strColName2 & ControlChars.Tab & "부서명"
            strColName2 = strColName2 & ControlChars.Tab & "지급일자"

            strColName2 = strColName2 & ControlChars.Tab & "신규확장"
            strColName2 = strColName2 & ControlChars.Tab & "재확장"
            strColName2 = strColName2 & ControlChars.Tab & "확장계"
            strColName2 = strColName2 & ControlChars.Tab & "신규"
            strColName2 = strColName2 & ControlChars.Tab & "재접수"
            strColName2 = strColName2 & ControlChars.Tab & "신규"
            strColName2 = strColName2 & ControlChars.Tab & "재접수"

            strColName2 = strColName2 & ControlChars.Tab & "단가"
            strColName2 = strColName2 & ControlChars.Tab & "확장비금액"

            strColName2 = strColName2 & ControlChars.Tab & "단가"
            strColName2 = strColName2 & ControlChars.Tab & "확장비금액"

            strColName2 = strColName2 & ControlChars.Tab & "단가"
            strColName2 = strColName2 & ControlChars.Tab & "확장비금액"

            strColName2 = strColName2 & ControlChars.Tab & "단가"
            strColName2 = strColName2 & ControlChars.Tab & "확장비금액"

            strColName2 = strColName2 & ControlChars.Tab & "과세고료"
            strColName2 = strColName2 & ControlChars.Tab & "소득세"
            strColName2 = strColName2 & ControlChars.Tab & "주민세"
            strColName2 = strColName2 & ControlChars.Tab & "세금계"
            strColName2 = strColName2 & ControlChars.Tab & "확장비금액"

            strColName2 = strColName2 & ControlChars.Tab & "백만원"
            strColName2 = strColName2 & ControlChars.Tab & "십만원"
            strColName2 = strColName2 & ControlChars.Tab & "만원"

            strColName2 = strColName2 & ControlChars.Tab & "국적코드"
            strColName2 = strColName2 & ControlChars.Tab & "거주구분코드"

            With Me.grd_1

                Dim i As Integer

                .AddItem(strColName2)

                .FixedRows = 3
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly

                For i = 0 To .ColumnCollection.Count - 1
                    .ColumnCollection(i).AllowMerging = True
                Next

                For i = 0 To .FixedRows - 1
                    .set_MergeRow(i, True)
                Next

            End With

            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : ACA003_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNE202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If

        End Sub
#End Region

        Private Sub btnCreateSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSale.Click
            SaveData()
        End Sub

        Private Sub btnSlipApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyClose.Click
            SaveData_2("1")
        End Sub

        Private Sub btnSlipCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelClose.Click
            SaveData_2("3")
        End Sub
    End Class

End Namespace
