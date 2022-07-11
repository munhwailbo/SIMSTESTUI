'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 프로세스 기능 분해 등록
' form 설명 : 프로세스 기능 분해를 등록 한다.
' 작성자 : 황인중
' 작성일 : 2007-07-11
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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB204
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

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
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|담당 명;EmployeeNameHangul;120;;c;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|부서 명;DeptNm;120;;l;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;100;;l;" & "io;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|지국명;BranchNm;100;;l;" & "o;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|계약일자;ContractDt;100;;l;" & "o;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|계약완결여부;ContractYN;100;;c;" & "io;n;n;1;"       '(420)

            gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;100;;l;" & "o;n;y;8;"       '(50)
            gridAttributes = gridAttributes & "|계약종료일자;ContractEdDt;100;;l;" & "o;n;y;8;"       '(60)

            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;100;;l;" & "o;n;n;10;;"       '(80)
            gridAttributes = gridAttributes & "|지국장명;BranchChiefNm;100;;l;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|주민번호;BranchSocialNum;100;;l;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;100;;l;" & "o;n;n;7;"       '(100)
            gridAttributes = gridAttributes & "|담당자명;ChargeEmpNm;10;;c;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "| ;dummy;90;;c;" & "o;n;n;1;"       '(420)

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

            '''' ==============================================================================================
            gridAttributes = "a;r;y"
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;y;"
            gridAttributes = gridAttributes & "|담당 명;EmployeeNameHangul;120;;c;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|부서 명;DeptNm;120;;l;" & "o;n;y;1;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;100;;l;" & "io;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|지국명;BranchNm;100;;l;" & "o;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|폐국일자;CloseDate;100;;l;" & "o;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;100;;l;" & "o;n;n;10;;"       '(80)
            gridAttributes = gridAttributes & "|지국장명;BranchChiefNm;100;;l;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|주민번호;BranchSocialNum;100;;l;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;100;;l;" & "o;n;n;7;"       '(100)
            gridAttributes = gridAttributes & "|담당자명;ChargeEmpNm;10;;c;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "| ;dummy;90;;c;" & "o;n;n;1;"       '(420)

            'grid_2 code combo    
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub
        ''' <summary>
        ''' 함수명 : PNB204_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNB204_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If

        End Sub
        ''' <summary>
        ''' 함수명 : grd_1_DoubleClick 
        ''' 기  능 : 화면 Jump!
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick

            ''전표 화면으로 전표 번호를 넘겨서 해당 전표를 조회 한다.
            'If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            'Dim BusinessPlaceCode As String '사업장 코드
            'Dim BranchCode As String '지점 코드
            'Dim SlipDate As String '거래 일자
            'Dim SlipNumber As String '전표 번호

            'BusinessPlaceCode = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("BusinessPlaceCode")) '사업장 코드
            'BranchCode = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("BranchCode")) ''지점 코드                                  
            'SlipDate = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SlipDate")) '거래 일자                                  
            'SlipNumber = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("SlipNumber")) '전표 번호                                  

            'GmainBusinessFunction.SetValue("화면 전환", "ACCA01;" & BusinessPlaceCode & ";" & BranchCode & ";" & SlipDate & ";" & SlipNumber)
            'Me.ShowUiControl("ACCA01", BusinessPlaceCode & ";" & BranchCode & ";" & SlipDate & ";" & SlipNumber)
        End Sub
        ''' <summary>
        ''' 함수명 : btnApprovalAll_Click 
        ''' 기  능 : 일괄 승인
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                If blnApprovalAll = False Then
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                .SetCellCheck(inti, .get_ColIndex("ContractYN"), CheckEnum.Checked)
                                .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
                            Next inti
                        End If
                    End With
                    blnApprovalAll = True
                Else
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("ContractYN")) = CheckEnum.Checked Then
                                    .SetCellCheck(inti, .get_ColIndex("ContractYN"), CheckEnum.Unchecked)
                                    .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = False
                End If
                btnApprovalAll.Text = IIf(blnApprovalAll, "승인 취소", "일괄 승인")
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class

End Namespace

