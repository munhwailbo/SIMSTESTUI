'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : Table 명세서 등록
' form 설명 : Table 명세서 등록 추가, 수정, 삭제, 조회한다.
' 작성자 : 황인중
' 작성일 : 2006-07-04
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

Imports System.Text
Imports System.IO

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMEB03
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String
            Dim gridCodeNameList As String

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = ""
            gridCodeNameList = ""
            gridAttributes = gridAttributes & "a;c;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|업무 구분;SystemClass;100;;c;" & "io;y;n;"
            gridAttributes = gridAttributes & "|테이블 ID;TableId;100;;l;" & "io;y;n;"
            gridAttributes = gridAttributes & "|테이블 명;TableName;100;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|테이블 개요;TableDesc;500;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|이관 여부;MigYesOrNo;50;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|사용 여부;UseYesOrNo;50;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|;Dummy;500;;l;" & "o;n;n;"

            'grid code combo
            gridCodeNameList = gridCodeNameList & "SystemClass;시스템 구분 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

        End Sub

        Private Sub SMEB03_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub
    End Class

End Namespace
