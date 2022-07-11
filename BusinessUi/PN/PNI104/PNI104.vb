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

    Public Class PNI104
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
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|년월;CalYearMonths;63;yyyy-MM;4;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;96;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;76;;1;" & "o;n;y;9;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;76;;4;" & "o;n;y;5;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;65;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|일반단가;ValPaperUnit1;86;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|구독권단가;ValPaperUnit2;86;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|기타단가1;ValPaperUnit3;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|기타단가2;ValPaperUnit4;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|일반유가부수;ValPaperNum1;86;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|구독권유가부수;ValPaperNum2;86;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|기타유가부수1;ValPaperNum3;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|기타유가부수2;ValPaperNum4;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|유가부수계;ValPaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|무가부수계;NoValPaperNum;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|발송부수계;PaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|일반매출;ValPaperSale1;76;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|구독권매출;ValPaperSale2;76;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|기타매출1;ValPaperSale3;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|기타매출2;ValPaperSale4;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|매출액;SalesAmt;78;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;80;;4;" & "o;n;n;10;지국지역코드;BranchRegionNm"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;96;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "PrintOfficeCd;공장구분코드"
            ''gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            sbSetGridColDisp()

            '담당자 셋팅
            popChargeEmpNum.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popChargeEmpNum.Enabled = False
                popChargeEmpNum.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                GmainBusinessFunction.GetValue("로그인 ID"), _
                                                GmainBusinessFunction.GetValue("역할대행사번"))
            End If

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

                '' 일반유가
                .set_ColHidden(.get_ColIndex("ValPaperNum1"), Not (chkValPaper1.Checked))    ' 부수
                .set_ColHidden(.get_ColIndex("ValPaperUnit1"), Not (chkValPaper1.Checked))   ' 단가
                .set_ColHidden(.get_ColIndex("ValPaperSale1"), Not (chkValPaper1.Checked))   ' 매출
                If chkValPaper1.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum1"), Not (chkPaperNum.Checked))      ' 일반부수
                    .set_ColHidden(.get_ColIndex("ValPaperUnit1"), Not (chkUnitAmount.Checked))   ' 일반단가
                End If
                '' 구독권유가  
                .set_ColHidden(.get_ColIndex("ValPaperNum2"), Not (chkValPaper2.Checked))    ' 부수
                .set_ColHidden(.get_ColIndex("ValPaperUnit2"), Not (chkValPaper2.Checked))   ' 단가
                .set_ColHidden(.get_ColIndex("ValPaperSale2"), Not (chkValPaper2.Checked))   ' 매출
                If chkValPaper2.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum2"), Not (chkPaperNum.Checked))      ' 구독권부수
                    .set_ColHidden(.get_ColIndex("ValPaperUnit2"), Not (chkUnitAmount.Checked))   ' 구독권단가
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

    End Class

End Namespace
