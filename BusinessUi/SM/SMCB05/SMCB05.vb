'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 사원별 프로그램 권한현황
' form 설명 : 사원별 프로그램 권한현황을 조회한다.			
' 작성자 : 황인중
' 작성일 : 2007-02-02 토요일
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMCB05
        Inherits CommonControls.UiControl

        Private Sub SMCB05_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()

            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y;"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|조직 코드;OrganizationCode;100;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|조직 명;OrganizationName;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|직위 코드;PositionCode;100;;c;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|직위 명;PositionName;80;;c;" & "o;n;n;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;100;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;100;;c;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

        End Sub


        Public Sub DynamicInitialize(ByRef reciveDataSet As DataSet)
            Dim intII As Integer = 0
            Dim intj As Integer = 0
            Dim intCol As Integer = 0

            Dim strColName As String = ""

            Me.grd_1.FixedRows = 1


            'VSFlexGrid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""
            Dim strMerge As String = ""

            '수정 mode(0 - 불가, 1 - 키보드, 2 - 키보드 & 마우스); 선택 mode(1 - cell, 2 - row); 자동 Size Y/N(1/0))
            With reciveDataSet.Tables(1)
                gridAttributes = gridAttributes & "n;r;y"

                '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
                '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
                gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
                gridAttributes = gridAttributes & "|조직 코드;OrganizationCode;100;;c;" & "o;n;n;6;"
                gridAttributes = gridAttributes & "|조직 명;OrganizationName;100;;c;" & "o;n;n;30;"
                gridAttributes = gridAttributes & "|직위 코드;PositionCode;100;;c;" & "o;n;n;20;"
                gridAttributes = gridAttributes & "|직위 명;PositionName;80;;c;" & "o;n;n;"
                gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;100;;c;" & "o;n;n;6;"
                gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;100;;c;" & "o;n;n;30;"

                intCol = 0

                ' 동적으로 RoleCode를 받아 온다
                For intII = 6 To .Columns.Count - 1

                    intCol += 1
                    strColName = .Rows(1).Item(intII).ToString
                    gridAttributes = gridAttributes & "|" & strColName & ";RoleCode_" & VBN.Right("000" & CStr(intCol), 3) & ";100;;c;" & "o;n;n;50;"

                Next

            End With

            gridAttributes = gridAttributes & "|;Dummy;100;;c;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            'Fixed 컬럼 Merge
            With Me.grd_1

                .Rows = 3 '3개의 행을 미리 만들어 놓는다

                .FixedRows = 3
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly

                For intRows As Integer = 0 To reciveDataSet.Tables(1).Rows.Count - 1
                    For intCols As Integer = 0 To reciveDataSet.Tables(1).Columns.Count - 1
                        .set_TextMatrix(intRows, intCols + 2, reciveDataSet.Tables(1).Rows(intRows).Item(intCols).ToString)
                        ' SP 에서 처리..
                        '' 컬럼 명이 없다면 히든~
                        'If .get_TextMatrix(intRows, intCols + 2) = "" Then
                        '    .set_ColHidden(intCols + 2, True)
                        'End If
                    Next
                Next

                For intC As Integer = 0 To 7
                    .set_MergeCol(intC, True)
                Next
                .set_MergeRow(0, True)

            End With

            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1

            'End With
        End Sub
    End Class

End Namespace
