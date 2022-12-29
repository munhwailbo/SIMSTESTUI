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

    Public Class PNE603
        Inherits CommonControls.UiControl

        Private Sub PNE603_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|접수일자;ExpandDt;90;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|거래처;EmployeeExpName;140;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|분류;Div;50;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|부수;SumExpPapNum;50;;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|금액;ChangeAmount;110;#,###;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|대행율;AgencyPercent;60;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|판매전환;AdAmount;110;#,###;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|기장일자;RecDate;100;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|분류;AdDivision;100;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|게재일자;PbDate;100;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|부서;SoliDeptName;100;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;50;;l;" & "o;n;n;5;"


            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "AdDivision;사원확장 광고 구분"

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

        Private Sub btnBasketPrint_Click(sender As Object, e As EventArgs) Handles btnBasketPrint.Click
            Me.ExportExcel(1)
        End Sub
    End Class

End Namespace
