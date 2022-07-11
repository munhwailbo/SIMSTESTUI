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

Namespace ubiLease.UI.BusinessUi.BM

    Public Class BMB101
        Inherits CommonControls.UiControl

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
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|납부년월;MutualYearMonth;1253;####-##;l;" & "io;y;n;5;"

            gridAttributes = gridAttributes & "|부서;DeptNm;1253;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|담당자;ChargeEmpNumNm;1253;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|지국장 코드;BranchChiefCd;1253;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|지국장 명;BranchChiefCdName;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|대상여부;SubjectYON;1253;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|순번;Orders;1253;;l;" & "o;y;y;5;"

            gridAttributes = gridAttributes & "|상조회비;MutualSocietyDues;1253;#,##0;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|납부여부;MutualYesOrNo;1253;#,##0;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|납부금액;MutualAmount;1253;#,##0;r;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|납부지국코드;MutualBranchCode;3000;;l;" & "o;n;y;200;지국코드;MutualBranchCodeName"
            gridAttributes = gridAttributes & "|납부지국명;MutualBranchCodeName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|겸업지국;SideJobBranchName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|적요;Note;150;;l;" & "io;n;n;10;"

            gridAttributes = gridAttributes & "|가입일자;JoinDate;80;####-##-##;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|탈퇴일자;SecessionDate;80;####-##-##;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|탈퇴여부;SecessionYON;50;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|신규구분;NewGubn;80;;l;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|;Dumi;80;;l;" & "o;n;n"
                'grid code combo
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
                '--------------------------------------------------
        End Sub
#End Region

#Region "폼 이벤트"

        Private Sub BMB101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Dock = DockStyle.Fill
        End Sub


        ''' <summary>
        ''' 함수명 : grd1_KeyDownEdit
        ''' 기  능 : 그리드의 ENTER키 처리
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd1_KeyDownEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.KeyEditEventArgs) Handles grd_1.KeyDownEdit

            Dim ColCount As Integer
            'Dim StartofCols As Integer

            '*** 초기값 설정 **************
            'StartofCols = ucTY_INOUT
            '******************************

            'Enter키 처리(다음 컬럼으로 넘어감, ReadOnly색은 자동스킵)
            If e.KeyCode = Keys.Enter Then
                With grd_1
                    ColCount = e.Col
                    If ColCount = .ColumnCollection.Count - 1 Then
                        .AddRow()
                        .Row = e.Row + 1
                        ColCount = 1
                    End If
                    ColCount = ColCount + 1
                    .Col = ColCount
                End With
            End If
        End Sub
#End Region

        Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            With Me.grd_1
                If .Rows > 1 Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse

                    Select Case .ColSel
                        Case .get_ColIndex("MutualYearMonth")
                            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    End Select

                    'If .GetCurrentRowCellValue("Orders") <> "" Then
                    '    Select Case .ColSel
                    '        Case .get_ColIndex("MutualBranchCode")
                    '            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    '    End Select
                    'End If
                End If
            End With
        End Sub
    End Class

End Namespace
