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

    Public Class PNH101
        Inherits CommonControls.UiControl

        Private Sub PNH101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & " a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|구분;TreePath;114;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|년월;YYYYMM;63;yyyy-MM;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|일;DD;27;dd;4;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|부서명;DeptNm;75;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|부서코드;DeptCd;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당명;EmployeeNameHangul;50;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;62;;4;" & "io;n;n;10;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;68;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|전일유가;YdPaperNumY;59;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|전일무가;YdPaperNumM;58;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|전일부수계;YdPaperNumT;71;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|증감유가;IncPaperNumY;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|증감무가;IncPaperNumM;61;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|증감부수계;IncPaperNumT;73;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|유가부수;PrintPaperNumY;60;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|무가부수;PrintPaperNumM;59;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|인쇄부수계;PrintPaperNumT;69;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|적요;Remark;34;;1;" & "io;n;n;4;"

            gridAttributes = gridAttributes & "|공장구분코드org;PrintOfficeCd_org;81;;1;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|판구분코드org;PrintPlateCd_org;68;;1;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|공장구분코드;PrintOfficeCd;81;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|판구분코드;PrintPlateCd;68;;1;" & "io;n;n;10;"

            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;0;;4;" & "o;n;y;10;지국지역코드;"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;65;;4;" & "o;n;n;10; "
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "PrintOfficeCd_org;공장구분코드"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd_org;판구분코드"
            gridCodeNameList = gridCodeNameList & "/PrintOfficeCd;공장구분코드"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '' ''gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            '' ''gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;c;" & "io;n;n;10;"
            '' ''gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;n;5;지국코드;BranchNm"
            '' ''gridAttributes = gridAttributes & "|지국명;BranchNm;60;;l;" & "o;n;n;5;"
            '' ''gridAttributes = gridAttributes & "|교체횟수;ChangeNum;60;;c;" & "o;n;n;40;"
            '' ''gridAttributes = gridAttributes & "|년월;YYYYMM;60;;l;" & "io;n;n;6;"       '(20)
            '' ''gridAttributes = gridAttributes & "|유가부수1;ValPaperNum1;90;;r;" & "io;n;n;4;"       '(30)
            '' ''gridAttributes = gridAttributes & "|유가부수2;ValPaperNum2;90;;r;" & "io;n;n;4;"       '(40)
            '' ''gridAttributes = gridAttributes & "|유가부수3;ValPaperNum3;90;;r;" & "io;n;n;4;"       '(50)
            '' ''gridAttributes = gridAttributes & "|유가부수4;ValPaperNum4;90;;r;" & "io;n;n;4;"       '(60)
            '' ''gridAttributes = gridAttributes & "|무가부수;NoValPaperNum;90;;r;" & "io;n;n;4;"       '(70)
            '' ''gridAttributes = gridAttributes & "|매출조정부수;SettlePaperNum;120;;r;" & "io;n;n;4;"       '(80)
            '' ''gridAttributes = gridAttributes & "|매출조정액;SettleSalesAmt;150;;r;" & "io;n;n;15;"       '(90)
            ' '' ''grid_1 code combo    
            '' ''Dim gridCodeNameList As String = ""
            '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub
#End Region
        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.Row)
        End Sub

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValueInc As Long
            Dim TotalValueY As Long
            Dim TotalValueM As Long
            Dim TotalValueT As Long
            ''Dim CurruntRow As Long

            'gridAttributes = gridAttributes & "|증감유가;IncPaperNumY;40;#,##0;r;" & "io;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|증감무가;IncPaperNumM;40;#,##0;r;" & "io;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|증감부수계;IncPaperNumT;40;#,##0;r;" & "o;n;n;4;"       '(60)

            'gridAttributes = gridAttributes & "|인쇄유가;PrintPaperNumY;40;#,##0;r;" & "o;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|인쇄무가;PrintPaperNumM;40;#,##0;r;" & "o;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|인쇄부수계;PrintPaperNumT;40;#,##0;r;" & "o;n;n;4;"       '(60)
            With grd_1
                If .Rows > 1 Then
                    'CurruntRow = .GetCurrentRowCellValue("") + 1
                    '확정부수 처리
                    TotalValueInc = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumY")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumM")).ToString.Replace(",", ""))
                    TotalValueY = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("YdPaperNumY")).ToString.Replace(",", "")) _
                                    + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumY")).ToString.Replace(",", ""))
                    TotalValueM = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("YdPaperNumM")).ToString.Replace(",", "")) _
                                    + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumM")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("IncPaperNumT"), TotalValueInc.ToString)

                    .set_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumY"), TotalValueY.ToString)
                    .set_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumM"), TotalValueM.ToString)
                    TotalValueT = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumY")).ToString.Replace(",", "")) _
                                    + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumM")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("PrintPaperNumT"), TotalValueT.ToString)
                End If
            End With
        End Sub

        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
            RequestData2()
        End Sub


        'Private Sub SetTotalValue(ByVal CurruntRow As Long)

        '    Dim TotalValue As Long
        '    Dim CurruntRow As Long

        '    '' '' 증감부수계 = 증감유가 + 증감무가 
        '    '' '' 인쇄유가 = 전일유가 + 증감유가
        '    '' '' 인쇄무가 = 전일무가 + 증감무가
        '    '' '' 인쇄부수계 = 인쇄유가 + 인쇄무가
        '    With grd_1
        '        If .Rows > 1 Then
        '            CurruntRow = .GetCurrentRowCellValue("")
        '            ''이월 계 처리
        '            'TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum1"))) _
        '            '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum2"))) _
        '            '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNUm3"))) _
        '            '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNUm4"))) _
        '            '                 + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNum")))
        '            '.set_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNumTot"), TotalValue.ToString)
        '            '증감 계 처리
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum3")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum4")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNumTot"), TotalValue.ToString)

        '            '유가 1 계 처리
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum1")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum1")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum1"), TotalValue.ToString)

        '            '유가 2 계 처리
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum2")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum2")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum2"), TotalValue.ToString)

        '            '유가 3 계 처리
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum3")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum3")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum3"), TotalValue.ToString)

        '            '유가 4 계 처리
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurValPaperNum4")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryValPaperNum4")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum4"), TotalValue.ToString)

        '            '무가 계 처리
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("CurNoValPaperNum")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("VaryNoValPaperNum")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNum"), TotalValue.ToString)


        '            '확정 계 처리
        '            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum1")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum2")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum3")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNum4")).ToString.Replace(",", "")) _
        '                             + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedNoValPaperNum")).ToString.Replace(",", ""))
        '            .set_TextMatrix(CurruntRow, .get_ColIndex("FixedValPaperNumTot"), TotalValue.ToString)
        '        End If
        '    End With
        'End Sub

        'Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '    'SetTotalValue(e.row)
        'End Sub

    End Class

End Namespace
