' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 정산내역등록
' form 설명 : 정산내역등록.
' 작성자 : 황인중
' 작성일 : 2008-09-17
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI102
        Inherits CommonControls.UiControl

#Region "폼 초기화"

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
            'VSFlexGrid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|정산년월;CalYearMonths;80;####-##;c;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|순번;Orders;50;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;c;" & "o;n;n;6;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;140;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|정산일자;CalDt;80;####-##-##;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|매출금액;SalesAmt;100;#,##0;r;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|공제금액;DeductAmt;100;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|비고;Note;120;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|신규;NewGubn;120;;l;" & "o;n;y;6;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)

            'VSFlexGrid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|정산년월;CalYearMonths;80;####-##;c;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|순번;Orders;50;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;90;;c;" & "io;n;n;6;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;90;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|정산순번;CalOrders;50;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|정산항목코드;CalItemCd;100;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|정산금액;CalAmt;120;#,##0;r;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|비고;Note;120;;l;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|시스템구분;SystemGubn;100;;l;" & "io;n;n;5;"

            'grid code combo
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "CalItemCd;정산항목코드"
            Me.grd_2.Initialize(gridAttributes, gridCodeNameList)

        End Sub

#End Region

#Region "폼 이벤트"
        Private Sub PNI102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Me.DesignMode = False Then ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill  ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
            End If
        End Sub

        'Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
        '    With Me.grd_1
        '        If .Rows > 1 Then
        '            If .GetCurrentRowCellValue("NewGubn") <> "" Then
        '                Me.dtpCalYearMonths_2.TextValue = Me.grd_1.GetCurrentRowCellValue("CalYearMonths")
        '                Me.popBranchNum.TextValue = Me.grd_1.GetCurrentRowCellValue("BranchNum")
        '                Me.txtOrders.TextValue = Me.grd_1.GetCurrentRowCellValue("Orders")
        '            End If
        '        End If
        '    End With
        'End Sub
#End Region

        'Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

        '    With Me.grd_2
        '        If .Rows > 1 Then
        '            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
        '            Select Case .ColSel
        '                Case .get_ColIndex("CalYearMonths")
        '                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
        '                Case .get_ColIndex("Orders")
        '                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
        '                Case .get_ColIndex("BranchNum")
        '                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
        '            End Select
        '        End If
        '    End With

        'End Sub

    End Class

End Namespace
