'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 웹독자 수정
' form 설명 : 
' 작성자 : 김동욱
' 작성일 : 2009-05-27
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

    Public Class PNK101
        Inherits CommonControls.UiControl
        Private Sub PNK101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            'If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
            Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
            'Me.MinimumSize = New System.Drawing.Size(811, 647)

            ' End If

        End Sub

        Public Sub Initialize()
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|순서;kNo;50;;r;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|지국명;BranchName;50;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|삭제여부;DelChk;50;;c;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|독자명;ReaderName;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰;ReaderHp;80;;l;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|전화번호1;ReaderTel1;80;;l;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|전화번호2;ReaderTel2;80;;l;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|주소1;ReaderAddress1;100;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|주소2;ReaderAddress2;100;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|투입부수;ThrowNo;50;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|등록일자;RegDate;80;;l;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;l;" & "o;n;n;7;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            'Me.grd_1.ExplorerBar = 3
            'With Me.grd_1
            '    If .Rows > 1 Then
            '        .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse

            '        Select Case .ColSel
            '            Case .get_ColIndex("kNo")
            '                .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone

            '        End Select

            '    End If
            'End With
        End Sub

        Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
            With Me.grd_1
                If .Rows > 1 Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse

                    Select Case .ColSel
                        Case .get_ColIndex("kNo")
                            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone

                    End Select

                End If
            End With
        End Sub




       
    End Class

End Namespace
