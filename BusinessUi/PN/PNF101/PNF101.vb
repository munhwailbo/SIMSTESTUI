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

    Public Class PNF101
        Inherits CommonControls.UiControl

        Private Sub PNF101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|구분;TreePath;72;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|기준년도;BaseYear;57;yyyy;4;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|영업담당자;ChargeEmpNum;1;;4;" & "o;n;n;7;영업사원 명;BranchNm"
            gridAttributes = gridAttributes & "|영업담당 명;ChargeEmpNm;74;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;1;;4;" & "io;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국 명;BranchNm;65;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|총목표부수;GoalPaperNum;70;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|1월목표;JanGoalPapeNum;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|2월목표;FebGoalPaperNum;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|3월목표;MarGoalPaperNum;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|4월목표;AprGoalPaperNum;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|5월목표;MayGoalPaperNum;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|6월목표;JunGoalPaperNum;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|7월목표;JulGoalPaperNum;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|8월목표;AugGoalPaperNum;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|9월목표;SepGoalPaperNum;57;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|10월목표;OctGoalPaperNum;64;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|11월목표;NovGoalPaperNum;64;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|12월목표;DecGoalPaperNum;64;#,##0;7;" & "io;n;n;4;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

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

        Private Sub SetTotalValue(ByVal CurruntRow As Long)
            Dim TotalValue As Long
            ''Dim CurruntRow As Long
            With grd_1
                If .Rows > 1 Then
                    ''CurruntRow = .GetCurrentRowCellValue("")
                    '증감 계 처리
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("JanGoalPapeNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FebGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("MarGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("AprGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("MayGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("JunGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("JulGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("AugGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SepGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("OctGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("NovGoalPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DecGoalPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("GoalPaperNum"), TotalValue.ToString)
                End If
            End With
        End Sub

        Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
            SetTotalValue(e.row)
        End Sub

        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
            RequestData2()
        End Sub

     
       
    End Class

End Namespace
