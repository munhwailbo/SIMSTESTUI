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
Imports System.Drawing.Image
Imports System.Windows.Forms

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNJ101
        Inherits CommonControls.UiControl

        Private Sub PNJ101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|구분;TreePath;80;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|구독권발행코드;CouponPublicCd;100;;l;" & "io;y;y;10;"
            gridAttributes = gridAttributes & "|발행년월;PublishYearMonth;80;####-##;l;" & "io;y;n;8;"
            gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;100;;l;" & "io;y;n;10;소속사 명;CouponCorpNm"
            gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;100;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|순번;Orders;80;;c;" & "io;y;n;10;"
            gridAttributes = gridAttributes & "|발행시작번호;PublishStNum;200;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|발행종료번호;PublishEdNum;80;;c;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|발행부수;CirculationNum;40;#,##0;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|단가;UnitCost;150;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|비고;Note;200;;l;" & "io;n;n;100;"
            'gridAttributes = gridAttributes & "|발행부수합계;sumCirculationNum;200;;l;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|신규구분;IsExist;200;;l;" & "o;n;y;100;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 0

            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|구독권발행코드;CouponPublicCd;120;;c;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|순번;Orders;120;;l;" & "io;n;n;20;"
            gridAttributes = gridAttributes & "|발행상세순번;DetailOrders;80;;c;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|발행일자;PublishDt;120;####-##-##;l;" & "io;n;n;20;"
            gridAttributes = gridAttributes & "|발행바코드;PublishBarCode;200;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|출력일자;PrintDt;120;####-##-##;l;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|;Dumi;120;;l;" & "o;n;n;20;"

            'grid_2 code combo    
            gridCodeNameList = ""
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 0

            'grd_1_MouseClick(Nothing, Nothing)

        End Sub

#End Region

        Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
            With Me.grd_1

                If .ColSel = .get_ColIndex("Orders") Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    Exit Sub
                End If

                If .get_TextMatrix(.RowSel, .get_ColIndex("IsExist")) = "U" Then
                    If .ColSel = .get_ColIndex("CouponPublicCd") Or .ColSel = .get_ColIndex("SubscribeYearMonth") Or .ColSel = .get_ColIndex("CouponCorpCd") Then
                        .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    Else
                        .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
                    End If
                Else
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
                End If
            End With
        End Sub

        Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell
            With Me.grd_2
                If .ColSel = .get_ColIndex("CouponPublicCd") Or .ColSel = .get_ColIndex("DetailOrders") Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                Else
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
                End If
            End With
        End Sub

        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
            If Me.grd_1.Rows < 1 Then
                Exit Sub
            End If

            If Me.grd_1.GetCurrentRowCellValue("IsExist") <> "U" Or IsNumeric(Me.grd_1.GetCurrentRowCellValue("CirculationNum")) = False Then
                Exit Sub
            End If
            If Me.grd_1.GetCurrentRowCellValue("CouponPublicCd") = "" Then
                Exit Sub
            End If

            Dim intCirculationNum As Integer = Me.grd_1.GetCurrentRowCellValue("CirculationNum")

            With Me.grd_2
                Dim intII As Integer
                For intII = Me.grd_2.Rows To intCirculationNum
                    .AddRow()
                    .set_TextMatrix(intII, 0, "신규")
                    .SetCellCheck(intII, .get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                    .set_TextMatrix(intII, .get_ColIndex("CouponPublicCd"), Me.grd_1.GetCurrentRowCellValue("CouponPublicCd"))
                    .set_TextMatrix(intII, .get_ColIndex("Orders"), Me.grd_1.GetCurrentRowCellValue("Orders"))
                    .set_TextMatrix(intII, .get_ColIndex("DetailOrders"), intII)
                    .set_TextMatrix(intII, .get_ColIndex("PublishDt"), Today.Date)
                Next
            End With

        End Sub

        Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
            Call DetailSave()
        End Sub

        'Private Sub grd_1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grd_1.MouseClick
        '    If Me.grd_1.Focus = True Then
        '        Me.grd_1.BackColorBkg = Color.LightSkyBlue
        '        Me.grd_2.BackColorBkg = Color.WhiteSmoke
        '    Else
        '        Me.grd_1.BackColorBkg = Color.WhiteSmoke
        '        Me.grd_2.BackColorBkg = Color.LightSkyBlue
        '    End If
        'End Sub

        'Private Sub grd_2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grd_2.MouseClick
        '    If Me.grd_2.Focus = True Then
        '        Me.grd_2.BackColorBkg = Color.LightSkyBlue
        '        Me.grd_1.BackColorBkg = Color.WhiteSmoke
        '    Else
        '        Me.grd_2.BackColorBkg = Color.WhiteSmoke
        '        Me.grd_1.BackColorBkg = Color.LightSkyBlue
        '    End If
        'End Sub

        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
            Call Me.DetailDelete()
        End Sub

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                'If blnApprovalAll = False Then
                With grd_2
                    If (.Rows > .FixedRows) Then
                        For inti = .FixedRows To .Rows - 1
                            If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
                                .set_TextMatrix(inti, .get_ColIndex("PublishDt"), dtpProcDT.Text)
                                .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
                            End If
                        Next inti
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub
    End Class

End Namespace
