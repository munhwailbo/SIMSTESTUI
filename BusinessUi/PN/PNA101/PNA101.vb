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

    Public Class PNA101
        Inherits CommonControls.UiControl

        Private Sub PNA101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|코드 구분;CodeDivision_2;1253;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|코드 구분 한글 명;CodeDivisionHangulName_2;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|코드 구분 영문 명;CodeDivisionReasonName;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|코드 구분 설명;CodeDivisionExplanation;3000;;l;" & "io;n;n;200;"
            gridAttributes = gridAttributes & "|사용 여부;PrivateUseYesOrNo;1253;;l;" & "io;n;n;;"
            gridAttributes = gridAttributes & "|비고 1;Note1;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|비고 2;Note2;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|비고 3;Note3;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|비고 4;Note4;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|등록 코드;CodeList;1358;;l;" & "o;n;n;10;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '--------------------------------------------------

            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|코드;Code;1000;;c;" & "io;y;y;5;"
            gridAttributes = gridAttributes & "|코드;Code_2;1000;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|코드 한글 명;CodeHangulName;2415;;l;" & "io;y;n;20;"
            gridAttributes = gridAttributes & "|코드 영문 명;CodeReasonName;3000;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|코드 설명;CodeExplanation;3000;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|비고 1;Note1;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|비고 2;Note2;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|비고 3;Note3;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|비고 4;Note4;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|사용 여부;PrivateUseYesOrNo;1358;;l;" & "io;n;n;10;"

            'grid code combo
            gridCodeNameList = ""
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3
            '--------------------------------------------------
        End Sub
#End Region

#Region "폼 이벤트"

        ''' <summary>
        ''' 함수명 : grd_1_Click
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
            If grd_1.Row <> 0 And grd_1.Col <> 0 Then
                Me.RequestData_2()
            End If
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

                    '  SendKeys.Send("{F2}")
                End With
            End If
        End Sub
        ''' <summary>
        ''' 함수명 : grd2_KeyDownEdit
        ''' 기  능 : 그리드의 ENTER키 처리
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd2_KeyDownEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.KeyEditEventArgs) Handles grd_2.KeyDownEdit

            Dim ColCount As Integer
            'Dim StartofCols As Integer

            '*** 초기값 설정 **************
            'StartofCols = ucTY_INOUT
            '******************************

            'Enter키 처리(다음 컬럼으로 넘어감, ReadOnly색은 자동스킵)
            If e.KeyCode = Keys.Enter Then
                With grd_2

                    ColCount = e.Col
                    If ColCount = .ColumnCollection.Count - 1 Then
                        .AddRow()
                        .Row = e.Row + 1
                        ColCount = 1
                    End If

                    ColCount = ColCount + 1
                    .Col = ColCount

                    '  SendKeys.Send("{F2}")
                End With
            End If
        End Sub
#End Region

        'Private Sub grd_1_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '    MsgBox(grd_1.GetData(e.Row, e.Col), MsgBoxStyle.Information, "")
        'End Sub
    End Class

End Namespace
