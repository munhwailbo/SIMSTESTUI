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

    Public Class PNI101
        Inherits CommonControls.UiControl
        '====================================================================================================
        

#Region "폼 초기화"

        Public Sub Initialize()

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|년월;CalYearMonths;60;;l;" & "io;n;n;6;"       '(10)
            
            gridAttributes = gridAttributes & "|영업담당;ChargeEmpNum;90;;c;" & "o;n;y;10;사원번호;ChargeEmpNm;"
            gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;100;;l;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;l;" & "io;n;n;9;"       '(30)
            gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;n;5;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|일반단가1;ValPaperUnit1;90;#,##0;r;" & "o;n;n;4;"    '(60) 유가부수1
            gridAttributes = gridAttributes & "|일반단가2;ValPaperUnit2;90;#,##0;r;" & "o;n;n;4;"  '(70) 유가부수2
            gridAttributes = gridAttributes & "|기타단가1;ValPaperUnit3;90;#,##0;r;" & "o;n;y;4;"   '(80) 유가부수3
            gridAttributes = gridAttributes & "|기타단가2;ValPaperUnit4;90;#,##0;r;" & "o;n;y;4;"   '(90) 유가부수4
            gridAttributes = gridAttributes & "|일반유가부수1;ValPaperNum1;90;#,##0;r;" & "o;n;n;4;"     '(60) 유가부수1
            gridAttributes = gridAttributes & "|일반유가부수2;ValPaperNum2;90;#,##0;r;" & "o;n;n;4;"   '(70) 유가부수2
            gridAttributes = gridAttributes & "|기타유가부수1;ValPaperNum3;90;#,##0;r;" & "o;n;y;4;"    '(80) 유가부수3
            gridAttributes = gridAttributes & "|기타유가부수2;ValPaperNum4;90;#,##0;r;" & "o;n;y;4;"    '(90) 유가부수4
            gridAttributes = gridAttributes & "|유가부수계;ValPaperNumTot;90;#,##0;r;" & "o;n;n;4;"       '(60) 부수계 
            gridAttributes = gridAttributes & "|무가부수계;NoValPaperNumTot;90;#,##0;r;" & "o;n;n;4;"     '(60) 부수계
            gridAttributes = gridAttributes & "|부수계;PaperNumTot;90;#,##0;r;" & "o;n;n;4;"       '(60) 부수계
            gridAttributes = gridAttributes & "|매출액;SalesAmt;90;#,##0;r;" & "io;n;n;4;"          '(70) 매출액
            gridAttributes = gridAttributes & "|일반매출1;ValPaperSale1;90;#,##0;r;" & "o;n;n;4;"    '(60) 유가부수1
            gridAttributes = gridAttributes & "|일반매출2;ValPaperSale2;90;#,##0;r;" & "o;n;n;4;"  '(70) 유가부수2
            gridAttributes = gridAttributes & "|기타매출1;ValPaperSale3;90;#,##0;r;" & "o;n;y;4;"   '(80) 유가부수3
            gridAttributes = gridAttributes & "|기타매출2;ValPaperSale4;90;#,##0;r;" & "o;n;y;4;"   '(90) 유가부수4
            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;90;;c;" & "o;n;n;10;지국지역코드;BranchRegionNm;"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;90;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|적요;Note;90;;l;" & "io;n;n;4;"     '(60) 부수계
            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "PrintOfficeCd;공장구분코드"
            ''gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            sbSetGridColDisp()

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
        Private Sub ACA003_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


#Region "그리드 화면 표시"
        '' <summary>
        ''  그리드 화면 표시 
        '' </summary>
        '' <param name="sender"></param>
        '' <param name="e"></param>
        '' <remarks></remarks>
        '' ---- 그리드 항목 표시 설정 
        Private Sub sbSetGridColDisp()

            With Me.grd_1
                '' 부수표시
                'If chkPaperNum.Checked = True Then
                'End If

                '' 단가표시
                'If chkPaperNum.Checked = True Then
                'End If

                '' 일반유가1
                .set_ColHidden(.get_ColIndex("ValPaperNum1"), Not (chkValPaper1.Checked))    ' 부수
                .set_ColHidden(.get_ColIndex("ValPaperUnit1"), Not (chkValPaper1.Checked))   ' 단가
                .set_ColHidden(.get_ColIndex("ValPaperSale1"), Not (chkValPaper1.Checked))   ' 매출
                If chkValPaper1.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum1"), Not (chkPaperNum.Checked))      ' 일반부수1
                    .set_ColHidden(.get_ColIndex("ValPaperUnit1"), Not (chkUnitAmount.Checked))   ' 일반단가1
                End If
                '' 일반유가2
                .set_ColHidden(.get_ColIndex("ValPaperNum2"), Not (chkValPaper2.Checked))    ' 부수
                .set_ColHidden(.get_ColIndex("ValPaperUnit2"), Not (chkValPaper2.Checked))   ' 단가
                .set_ColHidden(.get_ColIndex("ValPaperSale2"), Not (chkValPaper2.Checked))   ' 매출
                If chkValPaper2.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum2"), Not (chkPaperNum.Checked))      ' 일반부수2
                    .set_ColHidden(.get_ColIndex("ValPaperUnit2"), Not (chkUnitAmount.Checked))   ' 일반단가2
                End If
                '' 기타유가1
                .set_ColHidden(.get_ColIndex("ValPaperNum3"), Not (chkValPaper3.Checked))    ' 부수
                .set_ColHidden(.get_ColIndex("ValPaperUnit3"), Not (chkValPaper3.Checked))   ' 단가
                .set_ColHidden(.get_ColIndex("ValPaperSale3"), Not (chkValPaper3.Checked))   ' 매출
                If chkValPaper3.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum3"), Not (chkPaperNum.Checked))      ' 기타부수1
                    .set_ColHidden(.get_ColIndex("ValPaperUnit3"), Not (chkUnitAmount.Checked))   ' 기타단가1
                End If
                '' 기타유가2
                .set_ColHidden(.get_ColIndex("ValPaperNum4"), Not (chkValPaper4.Checked))    ' 부수
                .set_ColHidden(.get_ColIndex("ValPaperUnit4"), Not (chkValPaper4.Checked))   ' 단가
                .set_ColHidden(.get_ColIndex("ValPaperSale4"), Not (chkValPaper4.Checked))   ' 매출
                If chkValPaper4.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum4"), Not (chkPaperNum.Checked))      ' 기타부수2
                    .set_ColHidden(.get_ColIndex("ValPaperUnit4"), Not (chkUnitAmount.Checked))   ' 기타단가2
                End If
            End With

        End Sub

        Private Sub chkValPaper1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValPaper1.Click
            sbSetGridColDisp()
        End Sub

        Private Sub chkValPaper2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValPaper2.Click
            sbSetGridColDisp()
        End Sub

        Private Sub chkValPaper3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValPaper3.Click
            sbSetGridColDisp()
        End Sub

        Private Sub chkValPaper4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValPaper4.Click
            sbSetGridColDisp()
        End Sub


        Private Sub chkPaperNum_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPaperNum.Click
            sbSetGridColDisp()
        End Sub

        Private Sub chkUnitAmount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUnitAmount.Click
            sbSetGridColDisp()
        End Sub
#End Region

        Private Sub btnCreateSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSale.Click
            '' '' 매출 정산 자료 자동 생성 
            SaveData2()
        End Sub
    End Class

End Namespace
