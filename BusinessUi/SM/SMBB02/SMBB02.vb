'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 인사조직등록
' form 설명 : 인사조직을 조회, 추가, 수정, 삭제한다.			
' 작성자 : 황인중
' 작성일 : 2006-09-11
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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.CO

    Public Class SMBB02
        Inherits CommonControls.UiControl

        Dim mBolInit As Boolean = False

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|조직구분;CodeDivisionCode;100;;l;" & "io;n;n;20;"
            gridAttributes = gridAttributes & "|조직코드;OrganizationCode;100;;l;" & "io;n;y;20;"

            gridAttributes = gridAttributes & "|본부;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|지점;BranchCode;50;;l;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|팀;TeamCode;50;;l;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|파트;PartCode;50;;l;" & "io;n;n;2"
            gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|코너;CornerCode;50;;l;" & "io;n;n;2;"
            gridAttributes = gridAttributes & "|인사조직명;CodeName;100;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|최종여부;LastYesOrNo;100;;c;" & "io;n;n;100;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            gridCodeNameList = gridCodeNameList & "CodeDivisionCode;조직 구분"
            'gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;사업장 명"
            'gridCodeNameList = gridCodeNameList & "/BranchCode;조직 지점 명,본부"
            'gridCodeNameList = gridCodeNameList & "/TeamCode;조직 팀 명,본부,지점"
            'gridCodeNameList = gridCodeNameList & "/PartCode;조직 파트 명,본부,지점,팀"
            'gridCodeNameList = gridCodeNameList & "/PCCode;조직 PC 명,본부,지점,팀,파트"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            'Select Case strLevel
            '    Case "1"
            '        gridAttributes = gridAttributes & "|본부;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|지점;BranchCode;50;;l;" & "io;n;y;2;"
            '        gridAttributes = gridAttributes & "|팀;TeamCode;50;;l;" & "io;n;y;2;"
            '        gridAttributes = gridAttributes & "|파트;PartCode;50;;l;" & "io;n;y;2"
            '        gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;y;2;"
            '        gridAttributes = gridAttributes & "|코너;CornerCode;50;;l;" & "io;n;y;2;"

            '    Case "2"
            '        gridAttributes = gridAttributes & "|본부;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|지점;BranchCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|팀;TeamCode;50;;l;" & "io;n;y;2;"
            '        gridAttributes = gridAttributes & "|파트;PartCode;50;;l;" & "io;n;y;2"
            '        gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;y;2;"
            '        gridAttributes = gridAttributes & "|코너;CornerCode;50;;l;" & "io;n;y;2;"

            '        gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;사업장 명"

            '    Case "3"
            '        gridAttributes = gridAttributes & "|본부;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|지점;BranchCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|팀;TeamCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|파트;PartCode;50;;l;" & "io;n;y;2"
            '        gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;y;2;"
            '        gridAttributes = gridAttributes & "|코너;CornerCode;50;;l;" & "io;n;y;2;"

            '        gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;사업장 명"
            '        gridCodeNameList = gridCodeNameList & "/BranchCode;조직 지점 명,본부"
            '    Case "4"
            '        gridAttributes = gridAttributes & "|본부;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|지점;BranchCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|팀;TeamCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|파트;PartCode;50;;l;" & "io;n;n;2"
            '        gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;y;2;"
            '        gridAttributes = gridAttributes & "|코너;CornerCode;50;;l;" & "io;n;y;2;"

            '        gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;사업장 명"
            '        gridCodeNameList = gridCodeNameList & "/BranchCode;조직 지점 명,본부"
            '        gridCodeNameList = gridCodeNameList & "/TeamCode;조직 팀 명,본부,지점"
            '    Case "5"
            '        gridAttributes = gridAttributes & "|본부;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|지점;BranchCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|팀;TeamCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|파트;PartCode;50;;l;" & "io;n;n;2"
            '        gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|코너;CornerCode;50;;l;" & "io;n;y;2;"

            '        gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;사업장 명"
            '        gridCodeNameList = gridCodeNameList & "/BranchCode;조직 지점 명,본부"
            '        gridCodeNameList = gridCodeNameList & "/TeamCode;조직 팀 명,본부,지점"
            '        gridCodeNameList = gridCodeNameList & "/PartCode;조직 파트 명,본부,지점,팀"
            '    Case "6"
            '        gridAttributes = gridAttributes & "|본부;BusinessPlaceCode;100;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|지점;BranchCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|팀;TeamCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|파트;PartCode;50;;l;" & "io;n;n;2"
            '        gridAttributes = gridAttributes & "|PC;PCCode;50;;l;" & "io;n;n;2;"
            '        gridAttributes = gridAttributes & "|코너;CornerCode;50;;l;" & "io;n;n;2;"

            '        gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;사업장 명"
            '        gridCodeNameList = gridCodeNameList & "/BranchCode;조직 지점 명,본부"
            '        gridCodeNameList = gridCodeNameList & "/TeamCode;조직 팀 명,본부,지점"
            '        gridCodeNameList = gridCodeNameList & "/PartCode;조직 파트 명,본부,지점,팀"
            '        gridCodeNameList = gridCodeNameList & "/PCCode;조직 PC 명,본부,지점,팀,파트"
            '    Case Else
            '        gridCodeNameList = ""
            'End Select


            'gridCodeNameList = gridCodeNameList & "BusinessPlaceCode;사업장 명"


            '-- copy 및 붙여 넣기 허용
            'grd_1.AutoClipboard = True

            'mBolInit = True

            'grd_1.ColumnCollection("BusinessPlaceCode").AllowEditing = False
            'grd_1.ColumnCollection("BranchCode").AllowEditing = False
            'grd_1.ColumnCollection("TeamCode").AllowEditing = False
            'grd_1.ColumnCollection("PartCode").AllowEditing = False
            'grd_1.ColumnCollection("PCCode").AllowEditing = False
            'grd_1.ColumnCollection("CornerCode").AllowEditing = False

            'Select Case strLevel
            '    Case "1"
            '        grd_1.ColumnCollection("BusinessPlaceCode").AllowEditing = True
            '    Case "2"
            '        grd_1.ColumnCollection("BranchCode").AllowEditing = True
            '    Case "3"
            '        grd_1.ColumnCollection("TeamCode").AllowEditing = True
            '    Case "4"
            '        grd_1.ColumnCollection("PartCode").AllowEditing = True
            '    Case "5"
            '        grd_1.ColumnCollection("PCCode").AllowEditing = True
            '    Case "6"
            '        grd_1.ColumnCollection("CornerCode").AllowEditing = True
            'End Select

            '--------------------------------------------------
        End Sub

        Private Sub grd_1_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            Me.grd_1.Editable = EditableSettings.flexEDKbdMouse
            With Me.grd_1
                Select Case .ColSel
                    Case .get_ColIndex("CodeName")
                        .Editable = EditableSettings.flexEDKbdMouse
                    Case Else
                        .Editable = EditableSettings.flexEDNone
                End Select
            End With

        End Sub
        'Private Sub OrganizationCodeInitialize()
        '    '' 귀속 조직 구분에 따른 조직 코드 항목을 셋팅 한다.
        '    Dim blnBusinessPlaceCode As Boolean = False '본부 코드
        '    Dim blnBranchCode As Boolean = False '점 코드
        '    Dim blnTeamCode As Boolean = False '팀 코드
        '    Dim blnPartCode As Boolean = False '파트 코드
        '    Dim blnPCCode As Boolean = False 'PC 코드
        '    Dim blnCornerCode As Boolean = False '코너 코드

        '    'If Len(cboReversionDivisionCode.TextValue) > 0 Then
        '    If cboOrganizationLevel.TextValue >= "1" Then blnBusinessPlaceCode = True '본부 코드  
        '    If cboOrganizationLevel.TextValue >= "2" Then blnBranchCode = True '점 코드
        '    If cboOrganizationLevel.TextValue >= "3" Then blnTeamCode = True '팀 코드
        '    If cboOrganizationLevel.TextValue >= "4" Then blnPartCode = True '파트 코드
        '    If cboOrganizationLevel.TextValue >= "5" Then blnPCCode = True 'PC 코드
        '    If cboOrganizationLevel.TextValue >= "6" Then blnCornerCode = True '코너 코드

        '    '조직 코드 컨트롤 Visible 제어
        '    'lblBusinessPlaceCode.Visible = blnBusinessPlaceCode '본부 코드  
        '    lblBranchCode.Visible = blnBranchCode '점 코드    
        '    lblTeamCode.Visible = blnTeamCode '팀 코드    
        '    lblPartCode.Visible = blnPartCode '파트 코드  
        '    lblPCCode.Visible = blnPCCode 'PC 코드    
        '    lblCornerCode.Visible = blnCornerCode '코너 코드  
        '    'cboBusinessPlaceCode.Visible = blnBusinessPlaceCode '본부 코드  
        '    cboBranchCode.Visible = blnBranchCode '점 코드    
        '    cboTeamCode.Visible = blnTeamCode '팀 코드    
        '    cboPartCode.Visible = blnPartCode '파트 코드  
        '    cboPCCode.Visible = blnPCCode 'PC 코드    
        '    cboCornerCode.Visible = blnCornerCode '코너 코드  
        '    'End If
        'End Sub

        'Private Sub cboOrganizationLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    '-- 조회 콤보 세팅
        '    Call OrganizationCodeInitialize()


        '    '-- 그리드 재 세팅
        '    '-- 
        '    If mBolInit = True Then
        '        Call Initialize()
        '    End If

        'End Sub


    End Class

End Namespace
