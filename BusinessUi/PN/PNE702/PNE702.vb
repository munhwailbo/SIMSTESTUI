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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.SM

    Public Class PNE702
        Inherits CommonControls.UiControl

        Private Sub PNE702_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            '=================== grid1 초기화 한다. =================== 
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원확장 광고 구분;AdDivision;130;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|바스켓 번호;BasketCd;50;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|바스켓 이름;BasketHangulNm;100;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|신규 부수;NewSum;70;;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|재접수 부수;ReSum;70;;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|신규 전환액;NewSumAmt;100;#,###;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|재접수 전환액;ReSumAmt;100;#,###;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;50;;l;" & "o;n;n;5;"


            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "AdDivision;사원확장 광고 구분"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub grd_1_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
            With Me.grd_1
                .ImeMode = System.Windows.Forms.ImeMode.Hangul
                .Editable = Classic.EditableSettings.flexEDKbdMouse
                If .Rows > 1 Then
                    .Editable = Classic.EditableSettings.flexEDNone
                End If
            End With
        End Sub


    End Class

End Namespace
