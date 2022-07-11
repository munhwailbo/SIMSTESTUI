'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 코드관리
' form 설명 : 문화일보 코드 관리
' 작성자 : 권진성
' 작성일 : 2008.09.01
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNH201
        Inherits CommonControls.UiControl

        Private Sub PNH201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "폼 초기화"
        ''' <summary>
        ''' 함수명 : Initialize
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|구분;TreePath;123;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|년월;YYYYMM;63;yyyy-MM;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|부서명;DeptNm;64;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|부서코드;DeptCd;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;50;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;76;;4;" & "io;n;n;10;지국번호;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;58;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|공장구분코드;PrintOfficeCd;0;;1;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|판구분코드;PrintPlateCd;0;;1;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|전월일반유가1;CurValPaperNum1;94;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|전월일반유가2;CurValPaperNum2;94;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|전월기타유가1;CurValPaperNUm3;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|전월기타유가2;CurValPaperNum4;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|전월유가부수계;CurValPaperNumYT;99;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|전월무가부수;CurNoValPaperNum;87;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|전월부수계;CurNoValPaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|증감일반유가1;VaryValPaperNum1;91;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|증감일반유가2;VaryValPaperNum2;90;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|증감기타유가1;VaryValPaperNum3;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|증감기타유가2;VaryValPaperNum4;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|증감유가부수계;VaryValPaperNumYT;99;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|증감무가부수;VaryNoValPaperNum;87;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|증감부수계;VaryNoValPaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|당월일반유가1;FixedValPaperNum1;94;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|당월일반유가2;FixedValPaperNum2;94;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|당월기타유가1;FixedValPaperNum3;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|당월기타유가2;FixedValPaperNum4;0;#,##0;7;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|당월유가부수계;FixedValPaperNumYT;99;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|당월무가부수;FixedNoValPaperNum;87;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|당월부수계;FixedNoValPaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|현재인쇄부수;CurPrintPaperNum;0;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|확정인쇄부수;FixedPrintPaperNum;0;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            'gridCodeNameList = gridCodeNameList & "PrintOfficeCd;공장구분코드"
            'gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            ' ''gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            ' ''gridAttributes = gridAttributes & "|년월;YYYYMM;60;;l;" & "io;n;n;6;"       '(10)
            ' ''gridAttributes = gridAttributes & "|일;DD;20;;l;" & "io;n;n;2;"       '(20)
            ' ''gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;l;" & "io;n;n;9;"       '(30)
            ' ''gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;n;5;지국코드;BranchNm"
            ' ''gridAttributes = gridAttributes & "|지국명;BranchNm;60;;l;" & "o;n;n;5;"
            ' ''gridAttributes = gridAttributes & "|공장구분코드;PrintOfficeCd;100;;l;" & "io;n;n;10;"       '(40)
            ' ''gridAttributes = gridAttributes & "|판구분코드;PrintPlateCd;100;;l;" & "io;n;n;10;"       '(50)
            ' ''gridAttributes = gridAttributes & "|일반유가;CurValPaperNum1;90;;r;" & "io;n;n;4;"       '(60)현유가부수1
            ' ''gridAttributes = gridAttributes & "|구독권유가;CurValPaperNum2;90;;r;" & "io;n;n;4;"       '(70)현유가부수2
            ' ''gridAttributes = gridAttributes & "|기타유가1;CurValPaperNUm3;90;;r;" & "io;n;n;4;"       '(80)현유가부수3
            ' ''gridAttributes = gridAttributes & "|기타유가2;CurValPaperNum4;90;;r;" & "io;n;n;4;"       '(90)현유가부수4
            ' ''gridAttributes = gridAttributes & "|현무가부수;CurNoValPaperNum;90;;r;" & "io;n;n;4;"       '(100)
            ' ''gridAttributes = gridAttributes & "|증감일반유가;VaryValPaperNum1;90;;r;" & "io;n;n;4;"       '(110)
            ' ''gridAttributes = gridAttributes & "|증감구독권유가;VaryValPaperNum2;90;;r;" & "io;n;n;4;"       '(120)
            ' ''gridAttributes = gridAttributes & "|증감기타유가1;VaryValPaperNum3;90;;r;" & "io;n;n;4;"       '(130)
            ' ''gridAttributes = gridAttributes & "|증감기타유가2;VaryValPaperNum4;90;;r;" & "io;n;n;4;"       '(140)
            ' ''gridAttributes = gridAttributes & "|증감무가부수;VaryNoValPaperNum;90;;r;" & "io;n;n;4;"       '(150)
            ' ''gridAttributes = gridAttributes & "|확정일반유가;FixedValPaperNum1;90;;r;" & "io;n;n;4;"       '(160)
            ' ''gridAttributes = gridAttributes & "|확정구독권유가;FixedValPaperNum2;90;;r;" & "io;n;n;4;"       '(170)
            ' ''gridAttributes = gridAttributes & "|확정기타유가1;FixedValPaperNum3;90;;r;" & "io;n;n;4;"       '(180)
            ' ''gridAttributes = gridAttributes & "|확정기타유가2;FixedValPaperNum4;90;;r;" & "io;n;n;4;"       '(190)
            ' ''gridAttributes = gridAttributes & "|확정무가부수;FixedNoValPaperNum;90;;r;" & "io;n;n;4;"       '(200)
            ' ''gridAttributes = gridAttributes & "|현재인쇄부수;CurPrintPaperNum;90;;r;" & "io;n;n;4;"       '(210)
            ' ''gridAttributes = gridAttributes & "|확정인쇄부수;FixedPrintPaperNum;90;;r;" & "io;n;n;4;"       '(220)
            ' ''gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)

        End Sub
#End Region

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            '' ''Dim CurruntRow As Long

            With grd_1
                If .Rows > .FixedRows + 1 Then
                    ''CurruntRow = .GetCurrentRowCellValue("") + 1
                    ''이월 계 처리
                    'TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum1"))) _
                    '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum2"))) _
                    '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNUm3"))) _
                    '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNUm4"))) _
                    '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNum")))
                    '.set_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNumTot"), TotalValue.ToString)
                    '증감 계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum3")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum4")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNumTot"), TotalValue.ToString)

                    '유가 1 계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum1"), TotalValue.ToString)

                    '유가 2 계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum2")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum2"), TotalValue.ToString)

                    '유가 3 계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum3")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum3")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum3"), TotalValue.ToString)

                    '유가 4 계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum4")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum4")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum4"), TotalValue.ToString)
                    '유가 부수계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNumYT")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNumYT"), TotalValue.ToString)
                    '증감유가 부수계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", ""))

                    .set_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNumYT"), TotalValue.ToString)
                    '증감 부수계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNumT"), TotalValue.ToString)
                    '무가 계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNum"), TotalValue.ToString)


                    '확정 계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNumT")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", "")) _
                    + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
                    '+ Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNumT"), TotalValue.ToString)
                End If
            End With
        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.Row)
        End Sub

   
        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
            RequestData2()
        End Sub


      
    End Class

End Namespace
