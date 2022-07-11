'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 코드관리
' form 설명 : 문화센터 코드 관리
' 작성자 : 고재민
' 작성일 : 2006-04-06
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMCA03
        Inherits CommonControls.UiControl

        Private Sub SMCA03_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "0;2;1"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|프로그램 ID;ProgramID;1253;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|프로그램 명;ProgramName;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|M1;Level1;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|M2;Level2;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|M3;Level3;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|M4;Level4;1358;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|정렬 순서;MenuStandInRowOrder;3000;;l;" & "io;n;n;200;"
            gridAttributes = gridAttributes & "|최종 여부;LastYesOrNo;1253;;l;" & "io;n;n;0;"
            gridAttributes = gridAttributes & "|사용 여부;PrivateUseYesOrNo;1253;;l;" & "io;n;n;0;"
            gridAttributes = gridAttributes & "|시스템 구분 명;SystemDivision;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|프로그램 설명;ProgramExplanation;3000;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|신규 구분;IsExist;1253;;l;" & "o;n;y;0;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SystemDivision;시스템 구분 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            grd_1.ExplorerBar = 3

        End Sub
        '====================================================================================================
        '특정 Cell을 선택할 경우는 Grid를 수정 가능하게 한다.
        '====================================================================================================
        Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
            With grd_1
                .Editable = False
                Select Case .ColSel
                    Case .get_ColIndex("ProgramID")
                        If .Cell(CellPropertySettings.flexcpText, .RowSel, .get_ColIndex("IsExist")) = "U" Then
                            .Editable = False
                        Else
                            .Editable = True
                        End If

                    Case Else
                        .Editable = True
                End Select
            End With
        End Sub

        'Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
        '    If grd_1.Row <> 0 And grd_1.Col <> 0 Then
        '        RequestData_2()
        '    End If
        'End Sub

        '' 그리드의 ENTER키 처리
        'Private Sub grd1_KeyDownEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.KeyEditEventArgs) Handles grd_1.KeyDownEdit

        '    Dim ColCount As Integer
        '    'Dim StartofCols As Integer

        '    '*** 초기값 설정 **************
        '    'StartofCols = ucTY_INOUT
        '    '******************************

        '    'Enter키 처리(다음 컬럼으로 넘어감, ReadOnly색은 자동스킵)
        '    If e.KeyCode = Keys.Enter Then
        '        With grd_1

        '            ColCount = e.Col**
        '            If ColCount = .ColumnCollection.Count - 1 Then
        '                .AddRow()
        '                .Row = e.Row + 1
        '                ColCount = 1
        '            End If

        '            ColCount = ColCount + 1
        '            .Col = ColCount

        '            '  SendKeys.Send("{F2}")
        '        End With
        '    End If
        'End Sub

        '' 그리드의 ENTER키 처리
        'Private Sub grd2_KeyDownEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.KeyEditEventArgs)

        '    Dim ColCount As Integer
        '    'Dim StartofCols As Integer

        '    '*** 초기값 설정 **************
        '    'StartofCols = ucTY_INOUT
        '    '******************************

        '    'Enter키 처리(다음 컬럼으로 넘어감, ReadOnly색은 자동스킵)
        '    If e.KeyCode = Keys.Enter Then
        '        With grd_2

        '            ColCount = e.Col
        '            If ColCount = .ColumnCollection.Count - 1 Then
        '                .AddRow()
        '                .Row = e.Row + 1
        '                ColCount = 1
        '            End If

        '            ColCount = ColCount + 1
        '            .Col = ColCount

        '            '  SendKeys.Send("{F2}")
        '        End With
        '    End If
        'End Sub
    End Class

End Namespace
