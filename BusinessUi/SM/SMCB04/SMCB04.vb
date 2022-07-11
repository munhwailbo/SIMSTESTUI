' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : SMCB04
' form설명 : 예산계정 정보를 등록한다.
' 작성자 : 정태득
' 작성일 : 2006-01-24
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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.AC

    Public Class SMCB04
        Inherits CommonControls.UiControl

        Private Sub SMCB04_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'VSFlexGrid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|조직 코드;OnesPositionDepartmentCode;150;;c;" & "o;n;n;30;조직 명;OnesPositionDepartmentCodeName"
            gridAttributes = gridAttributes & "|조직 명;OnesPositionDepartmentCodeName;150;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;80;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;100;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|근무 상태;SeviceStatesCode;100;;l;" & "o;n;n;50;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|역할 코드;RoleCode;84;;c;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|역할 명;RoleName;200;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;84;;l;" & "io;n;y;6;"
            gridAttributes = gridAttributes & "|시스템 구분;SystemDivision;84;;l;" & "o;n;n;6;"

            'grid code combo
            gridCodeNameList = ""
            Me.grd_2.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|역할 코드;RoleCode;84;;c;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|역할 명;RoleName;200;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|시스템 구분;SystemDivision;84;;l;" & "o;n;n;6;"

            'grid code combo
            gridCodeNameList = ""
            Me.grd_3.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|역할 코드;RoleCode;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|프로그램 ID;ProgramID;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|프로그램 명;ProgramName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|조회 여부;RequestYesOrNo;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|저장 여부;SaveYesOrNo;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|삭제 여부;DeleteYesOrNo;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|출력 여부;PrintYesOrNo;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|활성화 여부;ActivationYesOrNo;300;;c;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""

            Me.grd_4.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 1
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExplorerBar = 1
            Me.grd_4.ExplorerBar = 0
            Me.grd_4.ExplorerBar = 1

        End Sub

        Private Sub btnMove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove1.Click
            Me.DeleteData()
        End Sub

        Private Sub btnMove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove2.Click
            Me.SaveData()
        End Sub

        Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

            Me.grd_2.Editable = EditableSettings.flexEDKbdMouse
            With Me.grd_2
                Select Case .ColSel
                    Case .get_ColIndex("RoleCode")
                        .Editable = EditableSettings.flexEDNone
                End Select
            End With

        End Sub

        Private Sub grd_3_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_3.EnterCell

            Me.grd_3.Editable = EditableSettings.flexEDKbdMouse
            With Me.grd_3
                Select Case .ColSel
                    Case .get_ColIndex("RoleCode")
                        .Editable = EditableSettings.flexEDNone
                End Select
            End With

        End Sub

    End Class

End Namespace
