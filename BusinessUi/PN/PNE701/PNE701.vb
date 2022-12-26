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

Imports System.Xml

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PR

    Public Class PNE701
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            '=================== grid1 초기화 한다. =================== 
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;r;" & "io;n;n;"
            gridAttributes = gridAttributes & "|바스켓코드;BasketCd;80;;l;" & "io;y;n;;바스켓코드;CodeHangulName"
            gridAttributes = gridAttributes & "|바스켓명;CodeHangulName;70;;l;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|확장처 코드;CompanyCd;120;;c;" & "io;y;n;;" '확장처명;CompanyHangulNm"
            gridAttributes = gridAttributes & "|확장처명;CompanyHangulNm;200;;l;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|비고;Remark;250;;l;" & "io;y;n;;"
            gridAttributes = gridAttributes & "|;Dummy;50;;l;" & "o;n;n;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            grd_1.ExplorerBar = 1
            grd_1.FrozenCols = 3

        End Sub
        Private Sub PNE701_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

        Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
            Call Me.SaveData_2()
        End Sub

        Private Sub btnComDataReq_Click(sender As Object, e As EventArgs) Handles btnComDataReq.Click
            Call Me.SetData()
        End Sub
    End Class

End Namespace
